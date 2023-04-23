我正在编写一个插件将Unity的AnimationClip转换为DOTween代码.目的是解决AnimationClip对代码不友好的问题.接下来是我编写的代码.请为我生成好看的github readme文件
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
                var target = obj.GetComponent(typeKeyFrame.Type);
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
            sequence.InsertCallback(node.Time, () =>
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

    public AnimationBuilder Play(bool unscaledTime = false)
    {
        mSequence.PlayForward();
        mSequence.ManualUpdate(Time.deltaTime, unscaledTime ? Time.unscaledDeltaTime : 0);
        return this;
    }
    
    #if HAS_UNITASK
    public async Cysharp.Threading.Tasks.UniTask AwaitComplete()
    {
        await Cysharp.Threading.Tasks.DOTweenAsyncExtensions.GetAwaiter(mSequence);
    }
    #else
    public async Task AwaitComplete()
    {
        var tcs = new TaskCompletionSource<bool>();
        mSequence.OnComplete(() => tcs.TrySetResult(true));
        await tcs.Task;
    }
    #endif
}

public class KeyframeData
{
    public float Time;
    public float Value;
    public float InTangent;
    public float OutTangent;
    public string Property;
    public float InWeight;
    public float OutWeight;
    public string Path;
    public SerializableType Type;
    public string ObjectKeyPair;


    public class KeyframeDataTimeComparer : IComparer<KeyframeData>
    {
        public int Compare(KeyframeData x, KeyframeData y)
        {
            return x.Time.CompareTo(y.Time);
        }
    }
}

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

public class KeyframeEventData
{
    public int Index;
    public float Time;
    public string EvtName;
}

public class ObjectKeyframes
{
    public string ObjectKey;
    public List<TypeKeyframes> Types;

    public ObjectKeyframes(string objectKey)
    {
        ObjectKey = objectKey;
        Types = new List<TypeKeyframes>();
    }
}

public class PropertyKeyframes
{
    public string PropertyName;
    public List<KeyframeData> Keyframes;

    public PropertyKeyframes(string propertyName)
    {
        PropertyName = propertyName;
        Keyframes = new List<KeyframeData>();
    }
}

public class SerializableType
{
    public string TypeName;
    private Type mType;
    public Type ActualType => mType ??= Type.GetType(TypeName);
    public SerializableType() { }

    public SerializableType(Type type)
    {
        TypeName = type.AssemblyQualifiedName;
    }
    
    public static implicit operator Type(SerializableType typeKeyframes)
    {
        return typeKeyframes.ActualType;
    }

    public static implicit operator SerializableType(Type type)
    {
        return new SerializableType(type);
    }
}

public class TypeKeyframes
{
    public SerializableType Type;
    public List<PropertyKeyframes> Properties;

    public TypeKeyframes(Type type)
    {
        Type = new SerializableType(type);
        Properties = new List<PropertyKeyframes>();
    }
}