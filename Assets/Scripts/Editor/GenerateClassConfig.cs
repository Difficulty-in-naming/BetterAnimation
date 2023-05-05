using System;
using System.Collections.Generic;
using Coffee.UIExtensions;
using Spine.Unity;
using TMPro;
using UnityEngine;

public class GenerateClassConfig
{
    public static bool Ignore(Type type,string propertyName)
    {
        if (type == typeof(Animator))
            return false;
        if (type == typeof(GameObject) && propertyName.Equals("dummy", StringComparison.OrdinalIgnoreCase))
            return false;
        return true;
    }

    public static Dictionary<Type, Type> TypeMap = new Dictionary<Type, Type>()
    {
        { typeof(GameObject), typeof(GameObjectGenerator) },
        { typeof(ParticleSystem), typeof(ParticleGenerator) },
        { typeof(ParticleSystemRenderer), typeof(ParticleSystemRendererGenerator) }

    };

    public static Dictionary<Type, Dictionary<string, string>> ReplaceProperty = new Dictionary<Type, Dictionary<string, string>>()
    {
        { typeof(TextMeshProUGUI), new Dictionary<string, string> { { "m_fontColor", "color" } } },
        { typeof(PathMoveHelper), new Dictionary<string, string> { { "m_Value", "Value" }, { "Point2", "GetPoint2" }, { "Point1", "GetPoint1" } } },
        { typeof(BezierMoveCurve), new Dictionary<string, string> { { "m_Value", "Value" } } },
        { typeof(SkeletonGraphic), new Dictionary<string, string> { { "m_Color", "color" } } },
        { typeof(UIParticle), new Dictionary<string, string> { { "m_Scale3D", "scale3D" } } },
    };
}
