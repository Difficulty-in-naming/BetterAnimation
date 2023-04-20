using System;
using System.Collections.Generic;
using DG.Tweening;

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