using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using MonoHook;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class HookAnimationWindow_AddClipToAnimationPlayerComponent
{
    static HookAnimationWindow_AddClipToAnimationPlayerComponent()
    {
        Type type = Type.GetType("UnityEditorInternal.AnimationWindowUtility,UnityEditor.dll");
        MethodInfo miTarget = type.GetMethod("AddClipToAnimationPlayerComponent",
            BindingFlags.Static | BindingFlags.Public);

        MethodInfo miReplacement = new OverrideMethod(Replacement).Method;

        MethodInfo miProxy = new OverrideMethod(Proxy).Method;

        var mHookGetClosestAnimation = new MethodHook(miTarget, miReplacement, miProxy);
        mHookGetClosestAnimation.Install();
    }

    private delegate bool OverrideMethod(Component animationPlayer, AnimationClip newClip);

    private static bool Replacement(Component animationPlayer, AnimationClip newClip)
    {
        Type type = Type.GetType("UnityEditorInternal.AnimationWindowUtility,UnityEditor.dll");
        switch (animationPlayer)
        {
            case Animator _:
                return (bool)type.GetMethod("AddClipToAnimatorComponent", BindingFlags.Static | BindingFlags.Public)
                    .Invoke(null, new object[] { animationPlayer as Animator, newClip });
            case Animation _:
                return (bool)type.GetMethod("AddClipToAnimationComponent", BindingFlags.Static | BindingFlags.Public)
                    .Invoke(null, new object[] { animationPlayer as Animation, newClip });
            case BetterAnimation _:
                var ba = animationPlayer as BetterAnimation;
                typeof(BetterAnimation).GetMethod("AddClip",BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(ba, new object[] { newClip });
                return true;
            default:
                return false;
        }
    }

    [MethodImpl(MethodImplOptions.NoOptimization)]
    private static bool Proxy(Component animationPlayer, AnimationClip newClip)
    {
        // 为满足MonoHook要求的最小代码长度而特地加入的无用填充代码，
        for (int i = 0; i < 100; i++)
        {
            UnityEngine.Debug.Log("something");
        }
        UnityEngine.Debug.Log(Application.targetFrameRate);
        return true;
    }
}
