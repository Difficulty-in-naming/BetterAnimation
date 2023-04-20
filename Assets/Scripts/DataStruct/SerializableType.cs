/*using System;

[System.Serializable]
public class SerializableType
{
    // 存储类型的完全限定名，包括程序集信息。
    public string TypeName;
    private Type mType;
    public Type ActualType => mType ??= Type.GetType(TypeName);
    public SerializableType() { }

    public SerializableType(Type type)
    {
        TypeName = type.AssemblyQualifiedName;
    }
}*/