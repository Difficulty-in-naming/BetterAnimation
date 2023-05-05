using System;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;

public class BetterAnimation : MonoBehaviour, IAnimationClipSource
{
    public bool PlayAutomatically;
    [SerializeField] private List<AnimationClip> AnimationClip = new List<AnimationClip>();
    [SerializeField] private KeyframeDataWrapper[] AnimateProto = Array.Empty<KeyframeDataWrapper>();

    public void GetAnimationClips(List<AnimationClip> results)
    {
        results.AddRange(AnimationClip);
    }

    public void StopAnimation()
    {
        
    }

    public AnimationBuilder DoJob(string animationName)
    {
        KeyframeDataWrapper keyframeData = null;
        for (var index = 0; index < AnimateProto.Length; index++)
        {
            var node = AnimateProto[index];
            if (node.AnimationName == animationName)
            {
                keyframeData = node;
            }
        }

        if (keyframeData == null)
        {
            throw new Exception($"动画{animationName}不存在");
        }

        var sequence = DOTween.Sequence(this);
        foreach (var node in keyframeData.Objects)
        {
            var obj = node.ObjectKey != "" ? transform.Find(node.ObjectKey) : transform;
            foreach (var typeKeyFrame in node.Types)
            {
                object target = obj;
                if (typeKeyFrame.Type == typeof(GameObject))
                {
                    target = obj.gameObject;
                }
                else if(typeKeyFrame.Type != typeof(Transform) && typeKeyFrame.Type != typeof(RectTransform))
                {
                    target = obj.GetComponent(typeKeyFrame.Type);   
                }
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
            builder.InsertCallback(node.Time, () =>
            {
                var list = builder.GetEvent(node.EvtName);
                foreach (var action in list)
                {
                    action(builder);
                }
            });
        }

        return builder;
    }
}