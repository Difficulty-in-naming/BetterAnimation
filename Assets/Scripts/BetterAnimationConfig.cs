using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[Serializable]
public class BetterAnimationConfig : ScriptableObject
{
    private static BetterAnimationConfig mInstance;

    public static BetterAnimationConfig Instance
    {
        get
        {
            return mInstance ??= Resources.Load<BetterAnimationConfig>("BetterAnimationConfig");
        }
    }
    public string GenerateBetterAnimationConfigPath = "Assets/BetterAnimationConfig";
    public string GenerateAotPath = "Assets/Scripts";
}

[CustomEditor(typeof(BetterAnimationConfig))]
public class BetterAnimationConfigEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(serializedObject.FindProperty("GenerateBetterAnimationConfigPath"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("GenerateAotPath"));

        serializedObject.ApplyModifiedProperties();
    }
}

public class BetterAnimationConfigSettingsProvider : SettingsProvider
{
    private SerializedObject mBetterAnimationConfig;

    private BetterAnimationConfigSettingsProvider(string path, SettingsScope scope = SettingsScope.Project) : base(path, scope) { }

    private static bool IsSettingsAvailable()
    {
        return BetterAnimationConfig.Instance != null;
    }

    [SettingsProvider]
    public static SettingsProvider CreateSettingsProvider()
    {
        if (IsSettingsAvailable())
        {
            var provider = new BetterAnimationConfigSettingsProvider("Project/BetterAnimationConfig")
            {
                label = "Better Animation Config",
                keywords = new HashSet<string>(new[] { "animation", "config", "aot" })
            };

            return provider;
        }

        return null;
    }

    public override void OnActivate(string searchContext, VisualElement rootElement)
    {
        mBetterAnimationConfig = new SerializedObject(BetterAnimationConfig.Instance);
    }

    public override void OnGUI(string searchContext)
    {
        if (mBetterAnimationConfig == null)
        {
            EditorGUILayout.HelpBox("Better Animation Config is not available", MessageType.Error);
            return;
        }

        mBetterAnimationConfig.Update();
        EditorGUILayout.Space();

        EditorGUILayout.BeginVertical();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PropertyField(mBetterAnimationConfig.FindProperty("GenerateBetterAnimationConfigPath"), new GUIContent("  Generate Better Animation Config Path"));
        if (GUILayout.Button("Select Folder", GUILayout.Width(100)))
        {
            string folderPath = EditorUtility.OpenFolderPanel("Select Better Animation Config Path", "", "");
            if (!string.IsNullOrEmpty(folderPath))
            {
                string assetsPath = Application.dataPath;
                mBetterAnimationConfig.FindProperty("GenerateBetterAnimationConfigPath").stringValue = "Assets" + folderPath.Substring(assetsPath.Length);
            }
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PropertyField(mBetterAnimationConfig.FindProperty("GenerateAotPath"), new GUIContent("  Generate AOT Path"));
        if (GUILayout.Button("Select Folder", GUILayout.Width(100)))
        {
            string folderPath = EditorUtility.OpenFolderPanel("Select AOT Path", "", "");
            if (!string.IsNullOrEmpty(folderPath))
            {
                string assetsPath = Application.dataPath;
                mBetterAnimationConfig.FindProperty("GenerateAotPath").stringValue = "Assets" + folderPath.Substring(assetsPath.Length);
            }
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.EndVertical();

        mBetterAnimationConfig.ApplyModifiedProperties();
    }
}