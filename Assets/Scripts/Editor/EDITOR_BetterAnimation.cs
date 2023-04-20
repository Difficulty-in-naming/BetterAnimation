using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BetterAnimation))]
public class EDITOR_BetterAnimation : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("重新生成动画"))
        {
            BetterAnimationUtility.ReGenerateConfig((BetterAnimation)target);
        }
    }
}
