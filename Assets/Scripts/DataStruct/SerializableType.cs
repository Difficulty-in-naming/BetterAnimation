using System;

[System.Serializable]
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