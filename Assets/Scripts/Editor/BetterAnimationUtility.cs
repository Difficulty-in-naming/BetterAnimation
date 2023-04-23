using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;

public static class BetterAnimationUtility
{
    private class FieldAccessor<T>
    {
        private readonly object mTarget;
        private readonly FieldInfo mField;

        public FieldAccessor(object target, string fieldName)
        {
            var type = target.GetType();
            mField = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            if (mField == null)
            {
                throw new ArgumentException($"Field {fieldName} not found in type {type.FullName}");
            }

            this.mTarget = target;
        }

        public T Get()
        {
            return (T)mField.GetValue(mTarget);
        }

        public void Set(T value)
        {
            mField.SetValue(mTarget, value);
        }
    }

    public static void ReGenerateConfig(BetterAnimation target)
    {
        var serializedObject = new SerializedObject(target);
        var serializedAnimationClipAccessor = serializedObject.FindProperty("AnimationClip");
        var serializedAnimateProtoAccessor = serializedObject.FindProperty("AnimateProto");
        var count = serializedAnimationClipAccessor.arraySize;
        var animateProto = new KeyframeDataWrapper[count];
        for (var index = 0; index < count; index++)
        {
            var asset = GenerateAnimationAsset(serializedAnimationClipAccessor.GetArrayElementAtIndex(index).objectReferenceValue as AnimationClip);
            animateProto[index] = asset;
        }
        serializedAnimateProtoAccessor.arraySize = animateProto.Length;
        for (var index = 0; index < animateProto.Length; index++)
        {
            serializedAnimateProtoAccessor.GetArrayElementAtIndex(index).objectReferenceValue = animateProto[index];
        }
        serializedObject.ApplyModifiedProperties();
    }

    public static KeyframeDataWrapper GenerateAnimationAsset(AnimationClip clip)
    {
        //这里提供对传统动画的支持
        EditorCurveBinding[] curveBindings = AnimationUtility.GetCurveBindings(clip);
        List<ObjectKeyframes> keyframeDataList = new List<ObjectKeyframes>();
        List<KeyframeEventData> allEvents = new List<KeyframeEventData>();
        bool needToGeneratorCode = false;
        foreach (EditorCurveBinding binding in curveBindings)
        {
            AnimationCurve curve = AnimationUtility.GetEditorCurve(clip, binding);
            Array.Sort(curve.keys, (t1, t2) => t1.time.CompareTo(t2.time));
            for (int i = 0; i < curve.keys.Length; i++)
            {
                Keyframe keyframe = curve.keys[i];
                KeyframeData data = new KeyframeData
                {
                    Time = keyframe.time,
                    Value = keyframe.value,
                    InTangent = keyframe.inTangent,
                    OutTangent = keyframe.outTangent,
                    Property = binding.propertyName,
                    InWeight = keyframe.inWeight,
                    OutWeight = keyframe.outWeight,
                    Path = binding.path,
                    Type = new SerializableType(binding.type),
                };
                if (binding.type?.Namespace?.StartsWith("UnityEngine") ?? false)
                {
                    data.Property = data.Property.Replace("m_", "");
                    data.Property = data.Property.Substring(0, 1).ToLower() + data.Property.Substring(1);
                }

                var value = keyframeDataList.Find(t1 => t1.ObjectKey == binding.path);
                if (value == null)
                {
                    keyframeDataList.Add(value = new ObjectKeyframes(binding.path));
                }

                TypeKeyframes typeKeyframes = value.Types.Find(t1 => t1.Type == binding.type);
                if (typeKeyframes == null)
                {
                    value.Types.Add(typeKeyframes = new TypeKeyframes(binding.type));
                }

                PropertyKeyframes propertyKeyframes =
                    typeKeyframes.Properties.Find(t1 => t1.PropertyName == data.Property);
                if (propertyKeyframes == null)
                {
                    typeKeyframes.Properties.Add(propertyKeyframes = new PropertyKeyframes(data.Property));
                }

                propertyKeyframes.Keyframes.Add(data);
            }

            string className = (binding.type.FullName + "_" + binding.propertyName).Replace(".", "_");
            if (Type.GetType(className) == null)
            {
                needToGeneratorCode = true;
            }
        }

        var events = AnimationUtility.GetAnimationEvents(clip);
        for (var i = 0; i < events.Length; i++)
        {
            var e = events[i];
            allEvents.Add(new KeyframeEventData { Index = i + 1, EvtName = e.stringParameter, Time = e.time });
        }

        var scriptableObject = ScriptableObject.CreateInstance<KeyframeDataWrapper>();
        scriptableObject.AnimationName = clip.name;
        scriptableObject.Objects = keyframeDataList;
        scriptableObject.Events = allEvents;
        var asset = CreateBetterAnimationAssets(clip, scriptableObject);
        if (needToGeneratorCode)
        {
            GeneratorAotCode();
        }

        return asset;
    }

    private static KeyframeDataWrapper CreateBetterAnimationAssets(AnimationClip node, KeyframeDataWrapper scriptableObject)
    {
        if (!Directory.Exists(BetterAnimationConfig.Instance.GenerateBetterAnimationConfigPath))
        {
            Directory.CreateDirectory(BetterAnimationConfig.Instance.GenerateBetterAnimationConfigPath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
        string path = AssetDatabase.GetAssetPath(node);
        path = Path.ChangeExtension(path, null);
        var dir = Path.GetDirectoryName(path);
        if (dir != "Assets")
        {
            dir = dir?.Substring("Assets".Length + 1) ?? "";
        }
        CreateFolder(dir);
        var file = Path.Combine(BetterAnimationConfig.Instance.GenerateBetterAnimationConfigPath, dir + Path.DirectorySeparatorChar + Path.GetFileName(path) + ".asset");
        AssetDatabase.CreateAsset(scriptableObject, file);
        AssetDatabase.SaveAssets();
        return AssetDatabase.LoadAssetAtPath<KeyframeDataWrapper>(file);
    }

    private static void CreateFolder(string path)
    {
        string[] folders = path.Split(Path.DirectorySeparatorChar);
        string folderPath = BetterAnimationConfig.Instance.GenerateBetterAnimationConfigPath;
        for (var index = 0; index < folders.Length; index++)
        {
            var folder = folders[index];
            if (!string.IsNullOrEmpty(folder))
            {
                string subFolderPath = Path.Combine(folderPath, folder);
                if (!AssetDatabase.IsValidFolder(subFolderPath))
                {
                    AssetDatabase.CreateFolder(folderPath, folder);
                }

                folderPath = subFolderPath;
            }
        }
    }

    private static HashSet<TypeGenerator> ScanAllAnimation()
    {
        HashSet<TypeGenerator> hashSet = new HashSet<TypeGenerator>();
        var allAnimation = AssetDatabase.FindAssets("t:Animation").Select(AssetDatabase.GUIDToAssetPath);
        foreach (var node in allAnimation)
        {
            var clip = AssetDatabase.LoadAssetAtPath<AnimationClip>(node);
            EditorCurveBinding[] bindings = AnimationUtility.GetCurveBindings(clip);
            foreach (var curve in bindings)
            {
                string propertyName = curve.propertyName;
                if (curve.type == typeof(Animator))
                    continue;
                if (curve.type?.Namespace?.StartsWith("UnityEngine") ?? false)
                {
                    propertyName = curve.propertyName.Replace("m_", "");
                    propertyName = propertyName.Substring(0, 1).ToLower() + propertyName.Substring(1);
                    if (propertyName.Contains("Raw."))
                        propertyName = propertyName.Replace("Raw.", ".");
                }

                hashSet.Add(new TypeGenerator(propertyName, curve.type));
            }
        }

        return hashSet;
    }

    private static void WriteAotCode(HashSet<TypeGenerator> hashSet)
    {
        Dictionary<string, Class> allClasses = new Dictionary<string, Class>();
        StringBuilder sb = new StringBuilder();
        CodeGenerator generator = new CodeGenerator();
        foreach (var key in hashSet)
        {
            string className = (key.Type.FullName + "_" + key.Property).Replace(".", "_");
            if (!allClasses.ContainsKey(className))
            {
                var propertySetGetClass = new Class(className);
                propertySetGetClass.AddVariable(new Variable("mInstance", key.Type.FullName) { Modifier = AccessModifier.Private });
                propertySetGetClass.AddVariable(new Variable("mValue", "float") { Modifier = AccessModifier.Private });
                var fieldType = GetFieldType(key.Type, key.Property);
                if (key.Property == "isActive" && key.Type == typeof(GameObject))
                {
                    fieldType = (false, typeof(bool));
                }

                var getMethod = new Method("Get", "float", "return mValue;");

                Method setMethod;
                if (fieldType.isStruct && fieldType.currentType != typeof(bool))
                {
                    string[] parts = key.Property.Split('.');
                    setMethod = new Method("Set", "void", $"mValue = value;" +
                                                          $"var cache = mInstance.{Path.GetFileNameWithoutExtension(key.Property)};\n" +
                                                          $"cache.{parts[parts.Length - 1]} = value;\n" +
                                                          $"mInstance.{Path.GetFileNameWithoutExtension(key.Property)} = cache;");
                }
                else
                {
                    if (key.Property == "isActive" && key.Type == typeof(GameObject))
                    {
                        setMethod = new Method("Set", "void", "mValue = value;" +
                                                              "mInstance.SetActive(value == 1);");
                    }
                    else if (fieldType.currentType == typeof(bool))
                    {
                        setMethod = new Method("Set", "void", "mValue = value;" +
                                                              "mInstance." + key.Property + " = value == 1;");
                    }
                    else
                    {
                        setMethod = new Method("Set", "void", "mValue = value;" +
                                                              "mInstance." + key.Property + " = value;");
                    }
                }

                getMethod.ReturnType = "float";
                setMethod.AddParameter(new Parameter("value", "float"));
                var constructor = new Method(className, "", $"mInstance = ({key.Type.FullName})value;");
                constructor.AddParameter(new Parameter("value", "object"));
                var tweenMethod = new Method("GetTween", "DG.Tweening.Tween", $"mValue = 0;" +
                                                                              $"return DG.Tweening.DOTween.To(Get,Set,endValue,duration);");
                tweenMethod.AddParameter(new Parameter("endValue", "float"));
                tweenMethod.AddParameter(new Parameter("duration", "float"));
                propertySetGetClass.AddMethod(constructor);
                propertySetGetClass.AddMethod(getMethod);
                propertySetGetClass.AddMethod(setMethod);
                propertySetGetClass.AddMethod(tweenMethod);
                sb.Append(generator.GenerateCode(propertySetGetClass));
                allClasses.Add(className, propertySetGetClass);
            }
        }

        var aotType = new Class("BetterAnimationAot");
        var variable = new Variable("Delegate", "System.Collections.Generic.Dictionary<string, System.Func<object,float,float,DG.Tweening.Tween>>");
        variable.Defined = VariableModifier.Static;
        variable.DefaultValue = "new System.Collections.Generic.Dictionary<string, System.Func<object,float,float,DG.Tweening.Tween>>" +
                                "{";
        foreach (var type in allClasses)
        {
            variable.DefaultValue += $"{{\"{type.Key}\",(t1,t2,t3)=> new {type.Key}(t1).GetTween(t2,t3)}},";
        }

        variable.DefaultValue += "}";
        aotType.AddVariable(variable);
        sb.Append(generator.GenerateCode(aotType));
        File.WriteAllText(Path.Combine(BetterAnimationConfig.Instance.GenerateAotPath,"BetterAnimationAot.cs"), sb.ToString());
    }

    private static void GeneratorAotCode()
    {
        var hash = ScanAllAnimation();
        WriteAotCode(hash);
    }

    private static (bool isStruct, Type currentType) GetFieldType(Type objectType, string propertyPath)
    {
        if (objectType == null || string.IsNullOrEmpty(propertyPath))
        {
            return (false, null);
        }

        string[] properties = propertyPath.Split('.');
        bool isStruct = false;
        Type currentType = objectType;

        for (var index = 0; index < properties.Length; index++)
        {
            var property = properties[index];
            PropertyInfo propertyInfo = currentType.GetProperty(property, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (propertyInfo != null)
            {
                currentType = propertyInfo.PropertyType;
            }
            else
            {
                FieldInfo fieldInfo = currentType.GetField(property, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (fieldInfo != null)
                {
                    currentType = fieldInfo.FieldType;
                }
            }

            if (properties.Length > 1 && index == properties.Length - 2)
            {
                if (currentType.IsValueType)
                {
                    isStruct = true;
                }
            }
        }

        return (isStruct, currentType);
    }


    private class TypeGenerator
    {
        public readonly string Property;
        public readonly Type Type;

        public TypeGenerator(string property, Type type)
        {
            Property = property;
            Type = type;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Property != null ? Property.GetHashCode() : 0);
                hash = hash * 23 + (Type != null ? Type.GetHashCode() : 0);
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is TypeGenerator other))
            {
                return false;
            }

            return (Property == other.Property && Type == other.Type);
        }
    }
}
