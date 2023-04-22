using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using MonoHook;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class HookAnimationWindowEvent
{
    private static MethodHook mHook;

    static HookAnimationWindowEvent()
    {
        
        Type type = Type.GetType("UnityEditor.AnimationWindowEventInspector,UnityEditor.dll");
        MethodInfo miTarget = type.GetMethod("OnEditAnimationEvents", BindingFlags.Static | BindingFlags.Public);

        MethodInfo miReplacement = new OverrideMethod(Replacement).Method;

        MethodInfo miProxy = new OverrideMethod(Proxy).Method;

        mHook = new MethodHook(miTarget, miReplacement, miProxy);
        mHook.Install();
    }

    private delegate void OverrideMethod(object obj);
    private static void Replacement(object obj)
    {
        Type type = Type.GetType("UnityEditor.AnimationWindowEventInspector,UnityEditor.dll");
        var method = type.GetMethod("GetData", BindingFlags.Static | BindingFlags.NonPublic);
        var data = method.Invoke(null, new object[]{obj});
        var animationWindowEventType = data.GetType();
        var root = animationWindowEventType.GetField("root").GetValue(data);
        if (root is GameObject go)
        {
            if (go.TryGetComponent(typeof(BetterAnimation), out var betterAnimation))
            {
                method = type.GetMethod("DoEditRegularParameters", BindingFlags.Static | BindingFlags.NonPublic);
                var selectedEvents = animationWindowEventType.GetField("selectedEvents").GetValue(data);
                method.Invoke(null,new object[]{selectedEvents,typeof(string)});
                method = type.GetMethod("SetData", BindingFlags.Static | BindingFlags.NonPublic);
                method.Invoke(null, new object[] { obj, data });
            }
            else
            {
                mHook.proxyMethod.Invoke(null,new object[]{obj});
            }
        }
        else
        {
            mHook.proxyMethod.Invoke(null,new object[]{obj});
        }
    }
    
    [MethodImpl(MethodImplOptions.NoOptimization)]
    private static void Proxy(object obj)
    {
        // 为满足MonoHook要求的最小代码长度而特地加入的无用填充代码，
        for (int i = 0; i < 100; i++)
        {
            UnityEngine.Debug.Log("something");
        }
        UnityEngine.Debug.Log(Application.targetFrameRate);
    }
}
