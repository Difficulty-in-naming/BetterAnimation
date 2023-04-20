using System;
using System.Collections.Generic;
using DG.Tweening;

public static class AnimationBuilderExtension
{
    public static AnimationBuilder OnStart(this AnimationBuilder builder,Action<AnimationBuilder> action)
    {
        builder.onStart = action;
        builder.Sequence.OnStart(() => action(builder));
        return builder;
    }
    
    public static AnimationBuilder OnComplete(this AnimationBuilder builder,Action<AnimationBuilder> action)
    {
        builder.onComplete = action;
        builder.Sequence.OnComplete(() => action(builder));
        return builder;
    }

    public static AnimationBuilder OnEvent(this AnimationBuilder builder,string evtName, Action<AnimationBuilder> action)
    {
        if (!builder.Events.TryGetValue(evtName, out var list))
        {
            builder.Events.Add(evtName,list = new List<Action<AnimationBuilder>>());
        }
        list.Add(action);
        return builder;
    }
    
    public static AnimationBuilder SetLoops(this AnimationBuilder builder,int loop)
    {
        builder.Sequence.SetLoops(loop);
        return builder;
    }

    public static AnimationBuilder PlayForward(this AnimationBuilder builder)
    {
        builder.Sequence.PlayForward();
        return builder;
    }
    
    public static AnimationBuilder PlayBackwards(this AnimationBuilder builder)
    {
        builder.Sequence.SetInverted();
        builder.Sequence.PlayForward();
        return builder;
    }

    public static void Kill(this AnimationBuilder builder,bool complete = false)
    {
        builder.Sequence.Kill(complete);
    }
}