using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class KeyframeDataWrapper : ScriptableObject
{
    public string AnimationName;
    public List<ObjectKeyframes> Objects;
    public List<KeyframeEventData> Events;

    public KeyframeDataWrapper()
    {
        Objects = new List<ObjectKeyframes>();
        Events = new List<KeyframeEventData>();
    }
}