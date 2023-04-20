using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using MonoHook;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class HookAnimationWindow_GetClosestAnimationPlayerComponentInParents
{
    static HookAnimationWindow_GetClosestAnimationPlayerComponentInParents()
    {
        Type type = Type.GetType("UnityEditorInternal.AnimationWindowUtility,UnityEditor.dll");
        MethodInfo miTarget = type.GetMethod("GetClosestAnimationPlayerComponentInParents",
            BindingFlags.Static | BindingFlags.Public);

        MethodInfo miReplacement = new OverrideMethod(Replacement).Method;

        MethodInfo miProxy = new OverrideMethod(Proxy).Method;

        var mHookGetClosestAnimation = new MethodHook(miTarget, miReplacement, miProxy);
        mHookGetClosestAnimation.Install();
    }

    private delegate Component OverrideMethod(Transform obj);

    private delegate bool OverrideMethod2(Component animationPlayer, AnimationClip newClip);

    private static Component Replacement(Transform tr)
    {
        while (true)
        {
            var hasAnimator = tr.TryGetComponent<Animator>(out var animatorComponent);
            var hasAnimation = tr.TryGetComponent<Animation>(out var animationComponent);
            var hasBetterAnimation = tr.TryGetComponent<BetterAnimation>(out var betterAnimationComponent);

            if (hasAnimator)
            {
                return animatorComponent;
            }

            if (hasAnimation)
            {
                return animationComponent;
            }

            if (hasBetterAnimation)
            {
                return betterAnimationComponent;
            }

            if (tr == tr.root)
            {
                return null;
            }

            tr = tr.parent;
        }
    }

    [MethodImpl(MethodImplOptions.NoOptimization)]
    private static Component Proxy(Transform obj)
    {
        // 为满足MonoHook要求的最小代码长度而特地加入的无用填充代码，
        for (int i = 0; i < 100; i++)
        {
            UnityEngine.Debug.Log("something");
        }
        UnityEngine.Debug.Log(Application.targetFrameRate);
        return null;
    }
}
