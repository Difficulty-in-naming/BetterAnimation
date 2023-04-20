using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AnimationPostProcessor : AssetPostprocessor
{
    private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        foreach (var node in importedAssets)
        {
            if (node.EndsWith(".anim"))
            {
                BetterAnimationUtility.GenerateAnimationAsset(AssetDatabase.LoadAssetAtPath<AnimationClip>(node));
            }
        }
        
        foreach (var node in movedAssets)
        {
            if (node.EndsWith(".anim"))
            {
                BetterAnimationUtility.GenerateAnimationAsset(AssetDatabase.LoadAssetAtPath<AnimationClip>(node));
            }
        }
    }
}
