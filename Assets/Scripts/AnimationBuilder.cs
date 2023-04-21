using System;
using System.Collections.Generic;
using DG.Tweening;

public class AnimationBuilder
{
    private Sequence mSequence;
    private Dictionary<string, List<Action<AnimationBuilder>>> mEvents = new Dictionary<string, List<Action<AnimationBuilder>>>();
    private int mId;
    
    public AnimationBuilder(Sequence sequence)
    {
        mSequence = sequence;
    }

    public List<Action<AnimationBuilder>> GetEvent(string eventName)
    {
        if (mEvents.TryGetValue(eventName, out var value))
        {
            return value;
        }

        return new List<Action<AnimationBuilder>>();
    }
    
    public AnimationBuilder OnStart(Action<AnimationBuilder> action)
    {
        mSequence.OnStart(() => action(this));
        return this;
    }
    
    public AnimationBuilder OnComplete(Action<AnimationBuilder> action)
    {
        mSequence.OnComplete(() => action(this));
        return this;
    }

    public AnimationBuilder OnEvent(string evtName, Action<AnimationBuilder> action)
    {
        if (!mEvents.TryGetValue(evtName, out var list))
        {
            mEvents.Add(evtName,list = new List<Action<AnimationBuilder>>());
        }
        list.Add(action);
        return this;
    }
    
    public AnimationBuilder SetLoops(int loop)
    {
        mSequence.SetLoops(loop);
        return this;
    }

    public AnimationBuilder Flip()
    {
        mSequence.SetInverted();
        mSequence.PlayForward();
        return this;
    }

    public void Kill(bool complete = false)
    {
        mSequence.Kill(complete);
    }
}