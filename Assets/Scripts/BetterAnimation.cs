using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using DG.Tweening;
using UnityEngine;
using Object = UnityEngine.Object;

[Serializable]
public class AnimationKeysProto
{
    public string AnimationName;
    public string Data;
}

[Serializable]
public class SerializedObjectDictionary : SerializedDictionary<string, Object> { }

public class BetterAnimation : MonoBehaviour, IAnimationClipSource
{
    public bool PlayAutomatically;
    [SerializeField] private List<AnimationClip> AnimationClip = new List<AnimationClip>();
    private Dictionary<string, KeyframeDataWrapper> mKeyframeData;
    [SerializeField] private AnimationKeysProto[] AnimateProto = Array.Empty<AnimationKeysProto>();
    [SerializeField] private SerializedObjectDictionary ObjectDictionary = new SerializedObjectDictionary();

    private void AddClip(AnimationClip clip)
    {
        AnimationClip.Add(clip);
    }

    public void GetAnimationClips(List<AnimationClip> results)
    {
        results.AddRange(AnimationClip);
    }

#if UNITY_EDITOR
    void OnValidate()
    {
        HashSet<AnimationClip> clips = new HashSet<AnimationClip>(AnimationClip);
        var animator = GetComponent<Animator>();
        if (animator != null)
        { 
            foreach(var node in animator.runtimeAnimatorController.animationClips)
            {
                clips.Add(node);
            }
        }

        var legacyAnimation = GetComponent<Animation>();
        if (legacyAnimation != null)
        {
            foreach(AnimationClip node in legacyAnimation)
                clips.Add(node);
        }

        AnimationClip = clips.ToList();
    }
#endif

    public void StopAnimation()
    {
        
    }
    
    public AnimationBuilder Build(string animationName)
    {
        if (mKeyframeData == null)
            mKeyframeData = new Dictionary<string, KeyframeDataWrapper>();
        if (!mKeyframeData.TryGetValue(animationName, out var keyframeData))
        {
            foreach (var node in AnimateProto)
            {
                if (node.AnimationName == animationName)
                {
                    var wrapper = JsonUtility.FromJson<KeyframeDataWrapper>(node.Data);
                    keyframeData = wrapper;
                    mKeyframeData.Add(animationName, wrapper);
                }
            }
        }

        var sequence = DOTween.Sequence();
        if (keyframeData != null)
        {
            foreach (var node in keyframeData.Objects)
            {
                var obj = node.ObjectKey != "" ? transform.Find(node.ObjectKey) : transform;
                foreach (var typeKeyFrame in node.Types)
                {
                    var target = obj.GetComponent(typeKeyFrame.Type);
                    foreach (var dict in typeKeyFrame.Properties)
                    {
                        AnimationCurve curve = new AnimationCurve();
                        var list = dict.Keyframes;
                        if (list.Count == 0)
                            continue;
                        for (int i = 0; i < list.Count; i++)
                        {
                            var frame = list[i];
                            curve.AddKey(new Keyframe(frame.Time, frame.Value, frame.InTangent, frame.OutTangent, frame.InWeight, frame.OutWeight));
                        }

                        string className = (typeKeyFrame.Type.ActualType.FullName + "_" + dict.PropertyName).Replace(".", "_");
                        if (BetterAnimationAot.Delegate.TryGetValue(className, out var func))
                        {
                            var animation = func(target, 1, list[list.Count - 1].Time).SetEase(curve);
                            sequence.Insert(list[0].Time, animation);
                        }
                    }
                }
            }

            var builder = new AnimationBuilder(sequence);
            foreach (var node in keyframeData.Events)
            {
                sequence.InsertCallback(node.Time, () =>
                {
                    if (builder.Events.TryGetValue(node.EvtName, out var list))
                    {
                        foreach (var action in list)
                        {
                            action(builder);
                        }
                    }
                });
            }

            return builder;
        }

        throw new Exception($"动画{animationName}不存在");
    }
}




[Serializable]
public class KeyframeData
{
   public float Time;
   public float Value;
   public float InTangent;
   public float OutTangent;
   public string Property;
   public float InWeight;
   public float OutWeight;
   public string Path;
   public SerializableType Type;
    public string ObjectKeyPair;


    public class KeyframeDataTimeComparer : IComparer<KeyframeData>
    {
        public int Compare(KeyframeData x, KeyframeData y)
        {
            return x.Time.CompareTo(y.Time);
        }
    }
}

[Serializable]
public class KeyframeEventData
{
    public int Index;
    public float Time;
    public string EvtName;
}

[Serializable]
public class KeyframeDataWrapper
{
    public List<ObjectKeyframes> Objects;
    public List<KeyframeEventData> Events;

    public KeyframeDataWrapper()
    {
        Objects = new List<ObjectKeyframes>();
        Events = new List<KeyframeEventData>();
    }
}

[System.Serializable]
public class SerializableType
{
    public string TypeName;
    private Type mType;
    public Type ActualType => mType ??= Type.GetType(TypeName);
    public SerializableType() { }

    public SerializableType(Type type)
    {
        TypeName = type.AssemblyQualifiedName;
    }
    
    public static implicit operator Type(SerializableType typeKeyframes)
    {
        return typeKeyframes.ActualType;
    }

    public static implicit operator SerializableType(Type type)
    {
        return new SerializableType(type);
    }
}

[Serializable]
public class PropertyKeyframes
{
    public string PropertyName;
    public List<KeyframeData> Keyframes;

    public PropertyKeyframes(string propertyName)
    {
        PropertyName = propertyName;
        Keyframes = new List<KeyframeData>();
    }
}

public class AnimationBuilder
{
    public Sequence Sequence;
    public Dictionary<string, List<Action<AnimationBuilder>>> Events = new Dictionary<string, List<Action<AnimationBuilder>>>();
    public object Target;
    public int Id;
    public Action<AnimationBuilder> onStart;
    public Action<AnimationBuilder> onComplete;
    public AnimationBuilder(Sequence sequence)
    {
        Sequence = sequence;
    }
}

[Serializable]
public class TypeKeyframes
{
    public SerializableType Type;
    public List<PropertyKeyframes> Properties;

    public TypeKeyframes(Type type)
    {
        Type = new SerializableType(type);
        Properties = new List<PropertyKeyframes>();
    }
}

[Serializable]
public class ObjectKeyframes
{
    public string ObjectKey;
    public List<TypeKeyframes> Types;

    public ObjectKeyframes(string objectKey)
    {
        ObjectKey = objectKey;
        Types = new List<TypeKeyframes>();
    }
}