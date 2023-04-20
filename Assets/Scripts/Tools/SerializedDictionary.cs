using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unity无法序列化Dictionary，因此这里提供了一个自定义的包装器。需要注意的是，在能够序列化之前，
/// 您必须扩展它，因为Unity也不会序列化基于泛型的类型。
/// </summary>
/// <typeparam name="K">键的类型</typeparam>
/// <typeparam name="V">值的类型</typeparam>
/// <example>
/// public sealed class MyDictionary : SerializedDictionary&lt;KeyType, ValueType&gt; {}
/// </example>
[Serializable]
public class SerializedDictionary<K, V> : SerializedDictionary<K, V, K, V>
{
    /// <summary>
    /// 将键序列化的转换方法
    /// </summary>
    /// <param name="key">要序列化的键</param>
    /// <returns>已序列化的键</returns>
    public override K SerializeKey(K key) => key;

    /// <summary>
    /// 将值序列化的转换方法
    /// </summary>
    /// <param name="val">值</param>
    /// <returns>值</returns>
    public override V SerializeValue(V val) => val;

    /// <summary>
    /// 将键反序列化的转换方法
    /// </summary>
    /// <param name="key">要反序列化的键</param>
    /// <returns>原始键</returns>
    public override K DeserializeKey(K key) => key;

    /// <summary>
    /// 将值反序列化的转换方法
    /// </summary>
    /// <param name="val">要反序列化的值</param>
    /// <returns>原始值</returns>
    public override V DeserializeValue(V val) => val;
}

/// <summary>
/// 可以将键和值序列化为其他类型的Dictionary
/// </summary>
/// <typeparam name="K">键的类型</typeparam>
/// <typeparam name="V">值的类型</typeparam>
/// <typeparam name="SK">用于序列化键的类型</typeparam>
/// <typeparam name="SV">用于序列化值的类型</typeparam>
[Serializable]
public abstract class SerializedDictionary<K, V, SK, SV> : Dictionary<K, V>, ISerializationCallbackReceiver
{
    [SerializeField] List<SK> m_Keys = new List<SK>();

    [SerializeField] List<SV> m_Values = new List<SV>();

    /// <summary>
    /// 从<K>类型转换到<SK>类型
    /// </summary>
    /// <param name="key">K类型的键</param>
    /// <returns>SK类型的键</returns>
    public abstract SK SerializeKey(K key);

    /// <summary>
    /// 从<V>类型转换到<SV>类型
    /// </summary>
    /// <param name="value">V类型的值</param>
    /// <returns>SV类型的值</returns>
    public abstract SV SerializeValue(V value);

    /// <summary>
    /// 从<SK>类型转换到<K>类型
    /// </summary>
    /// <param name="serializedKey">SK类型的键</param>
    /// <returns>K类型的键</returns>
    public abstract K DeserializeKey(SK serializedKey);

    /// <summary>
    /// 从<SV>类型转换到<V>类型
    /// </summary>
    /// <param name="serializedValue">SV类型的值</param>
    /// <returns>V类型的值</returns>
    public abstract V DeserializeValue(SV serializedValue);

    /// <summary>
    /// OnBeforeSerialize实现
    /// </summary>
    public void OnBeforeSerialize()
    {
        m_Keys.Clear();
        m_Values.Clear();

        foreach (var kvp in this)
        {
            m_Keys.Add(SerializeKey(kvp.Key));
            m_Values.Add(SerializeValue(kvp.Value));
        }
    }

    /// <summary>
    /// OnAfterDeserialize实现
    /// </summary>
    public void OnAfterDeserialize()
    {
        for (int i = 0; i < m_Keys.Count; i++)
            Add(DeserializeKey(m_Keys[i]), DeserializeValue(m_Values[i]));

        m_Keys.Clear();
        m_Values.Clear();
    }
}
