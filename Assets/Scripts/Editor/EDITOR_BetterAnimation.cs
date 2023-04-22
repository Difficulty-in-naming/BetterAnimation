using System;
using System.Collections.Generic;
using System.Linq;
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

    private void OnEnable()
    {
        BetterAnimation betterAnimation = (BetterAnimation)target;
        ModifyClips(betterAnimation);
    }

    void ModifyClips(BetterAnimation betterAnimation)
    {
        var animList = serializedObject.FindProperty("AnimationClip");
        HashSet<AnimationClip> clips = new HashSet<AnimationClip>();
        for (int i = 0; i < animList.arraySize; i++)
        {
            SerializedProperty animClipProp = animList.GetArrayElementAtIndex(i);
            AnimationClip animClip = animClipProp.objectReferenceValue as AnimationClip;
            clips.Add(animClip);
        }
        var animator = betterAnimation.GetComponent<Animator>();
        if (animator != null)
        { 
            foreach(var node in animator.runtimeAnimatorController.animationClips)
            {
                clips.Add(node);
            }
            DestroyImmediate(animator,true);
        }

        var legacyAnimation = betterAnimation.GetComponent<Animation>();
        if (legacyAnimation != null)
        {
            foreach(AnimationClip node in legacyAnimation)
                clips.Add(node);
            DestroyImmediate(legacyAnimation,true);
        }

        var list = clips.ToList();
        animList.arraySize = list.Count;
        for (int i = 0; i < animList.arraySize; i++)
        {
            SerializedProperty animClipProp = animList.GetArrayElementAtIndex(i);
            animClipProp.objectReferenceValue = list[i];
        }

        serializedObject.ApplyModifiedProperties();
    }
}
