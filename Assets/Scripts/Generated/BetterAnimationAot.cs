// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable CompareOfFloatsByEqualityOperator
// ReSharper disable IdentifierTypo
// ReSharper disable Unity.PreferAddressByIdToGraphicsParams
// ReSharper disable StringLiteralTypo
// ReSharper disable ClassNeverInstantiated.Global
public class UnityEngine_GameObject_isActive
{
    private UnityEngine.GameObject mInstance;
    private float mValue;

    public UnityEngine_GameObject_isActive(object value)
    {
        mInstance = (UnityEngine.GameObject)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        mInstance.SetActive(value == 1);
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localScale_x
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localScale_x(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localScale;
        cache.x = value;
        mInstance.localScale = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localScale_y
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localScale_y(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localScale;
        cache.y = value;
        mInstance.localScale = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localScale_z
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localScale_z(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localScale;
        cache.z = value;
        mInstance.localScale = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localEulerAngles_x
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localEulerAngles_x(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localEulerAngles;
        cache.x = value;
        mInstance.localEulerAngles = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localEulerAngles_y
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localEulerAngles_y(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localEulerAngles;
        cache.y = value;
        mInstance.localEulerAngles = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localEulerAngles_z
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localEulerAngles_z(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localEulerAngles;
        cache.z = value;
        mInstance.localEulerAngles = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localPosition_x
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localPosition_x(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localPosition;
        cache.x = value;
        mInstance.localPosition = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localPosition_y
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localPosition_y(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localPosition;
        cache.y = value;
        mInstance.localPosition = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localPosition_z
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localPosition_z(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localPosition;
        cache.z = value;
        mInstance.localPosition = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localScale_x
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localScale_x(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localScale;
        cache.x = value;
        mInstance.localScale = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localScale_y
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localScale_y(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localScale;
        cache.y = value;
        mInstance.localScale = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localScale_z
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localScale_z(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localScale;
        cache.z = value;
        mInstance.localScale = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_UI_Image_color_r
{
    private UnityEngine.UI.Image mInstance;
    private float mValue;

    public UnityEngine_UI_Image_color_r(object value)
    {
        mInstance = (UnityEngine.UI.Image)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.color;
        cache.r = value;
        mInstance.color = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_UI_Image_color_g
{
    private UnityEngine.UI.Image mInstance;
    private float mValue;

    public UnityEngine_UI_Image_color_g(object value)
    {
        mInstance = (UnityEngine.UI.Image)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.color;
        cache.g = value;
        mInstance.color = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_UI_Image_color_b
{
    private UnityEngine.UI.Image mInstance;
    private float mValue;

    public UnityEngine_UI_Image_color_b(object value)
    {
        mInstance = (UnityEngine.UI.Image)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.color;
        cache.b = value;
        mInstance.color = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_UI_Image_color_a
{
    private UnityEngine.UI.Image mInstance;
    private float mValue;

    public UnityEngine_UI_Image_color_a(object value)
    {
        mInstance = (UnityEngine.UI.Image)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.color;
        cache.a = value;
        mInstance.color = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_anchoredPosition_x
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_anchoredPosition_x(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.anchoredPosition;
        cache.x = value;
        mInstance.anchoredPosition = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_anchoredPosition_y
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_anchoredPosition_y(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.anchoredPosition;
        cache.y = value;
        mInstance.anchoredPosition = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localRotation_x
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localRotation_x(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localRotation;
        cache.x = value;
        mInstance.localRotation = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localRotation_y
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localRotation_y(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localRotation;
        cache.y = value;
        mInstance.localRotation = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localRotation_z
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localRotation_z(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localRotation;
        cache.z = value;
        mInstance.localRotation = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localRotation_w
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localRotation_w(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localRotation;
        cache.w = value;
        mInstance.localRotation = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class AudioHelper_enabled
{
    private AudioHelper mInstance;
    private float mValue;

    public AudioHelper_enabled(object value)
    {
        mInstance = (AudioHelper)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        mInstance.enabled = value == 1;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class TMPro_TextMeshProUGUI_color_a
{
    private TMPro.TextMeshProUGUI mInstance;
    private float mValue;

    public TMPro_TextMeshProUGUI_color_a(object value)
    {
        mInstance = (TMPro.TextMeshProUGUI)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.color;
        cache.a = value;
        mInstance.color = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localEulerAngles_x
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localEulerAngles_x(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localEulerAngles;
        cache.x = value;
        mInstance.localEulerAngles = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localEulerAngles_y
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localEulerAngles_y(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localEulerAngles;
        cache.y = value;
        mInstance.localEulerAngles = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localEulerAngles_z
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localEulerAngles_z(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localEulerAngles;
        cache.z = value;
        mInstance.localEulerAngles = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class PathMoveHelper_Value
{
    private PathMoveHelper mInstance;
    private float mValue;

    public PathMoveHelper_Value(object value)
    {
        mInstance = (PathMoveHelper)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        mInstance.Value = value;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class PathMoveHelper_GetPoint2_y
{
    private PathMoveHelper mInstance;
    private float mValue;

    public PathMoveHelper_GetPoint2_y(object value)
    {
        mInstance = (PathMoveHelper)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.GetPoint2;
        cache.y = value;
        mInstance.GetPoint2 = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class PathMoveHelper_GetPoint2_x
{
    private PathMoveHelper mInstance;
    private float mValue;

    public PathMoveHelper_GetPoint2_x(object value)
    {
        mInstance = (PathMoveHelper)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.GetPoint2;
        cache.x = value;
        mInstance.GetPoint2 = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_UI_Image_enabled
{
    private UnityEngine.UI.Image mInstance;
    private float mValue;

    public UnityEngine_UI_Image_enabled(object value)
    {
        mInstance = (UnityEngine.UI.Image)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        mInstance.enabled = value == 1;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localRotation_x
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localRotation_x(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localRotation;
        cache.x = value;
        mInstance.localRotation = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localRotation_y
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localRotation_y(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localRotation;
        cache.y = value;
        mInstance.localRotation = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localRotation_z
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localRotation_z(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localRotation;
        cache.z = value;
        mInstance.localRotation = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_Transform_localRotation_w
{
    private UnityEngine.Transform mInstance;
    private float mValue;

    public UnityEngine_Transform_localRotation_w(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localRotation;
        cache.w = value;
        mInstance.localRotation = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class TMPro_TextMeshProUGUI_color_r
{
    private TMPro.TextMeshProUGUI mInstance;
    private float mValue;

    public TMPro_TextMeshProUGUI_color_r(object value)
    {
        mInstance = (TMPro.TextMeshProUGUI)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.color;
        cache.r = value;
        mInstance.color = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class TMPro_TextMeshProUGUI_color_g
{
    private TMPro.TextMeshProUGUI mInstance;
    private float mValue;

    public TMPro_TextMeshProUGUI_color_g(object value)
    {
        mInstance = (TMPro.TextMeshProUGUI)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.color;
        cache.g = value;
        mInstance.color = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class TMPro_TextMeshProUGUI_color_b
{
    private TMPro.TextMeshProUGUI mInstance;
    private float mValue;

    public TMPro_TextMeshProUGUI_color_b(object value)
    {
        mInstance = (TMPro.TextMeshProUGUI)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.color;
        cache.b = value;
        mInstance.color = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class Spine_Unity_SkeletonGraphic_color_r
{
    private Spine.Unity.SkeletonGraphic mInstance;
    private float mValue;

    public Spine_Unity_SkeletonGraphic_color_r(object value)
    {
        mInstance = (Spine.Unity.SkeletonGraphic)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.color;
        cache.r = value;
        mInstance.color = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class Spine_Unity_SkeletonGraphic_color_g
{
    private Spine.Unity.SkeletonGraphic mInstance;
    private float mValue;

    public Spine_Unity_SkeletonGraphic_color_g(object value)
    {
        mInstance = (Spine.Unity.SkeletonGraphic)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.color;
        cache.g = value;
        mInstance.color = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class Spine_Unity_SkeletonGraphic_color_b
{
    private Spine.Unity.SkeletonGraphic mInstance;
    private float mValue;

    public Spine_Unity_SkeletonGraphic_color_b(object value)
    {
        mInstance = (Spine.Unity.SkeletonGraphic)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.color;
        cache.b = value;
        mInstance.color = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class Spine_Unity_SkeletonGraphic_color_a
{
    private Spine.Unity.SkeletonGraphic mInstance;
    private float mValue;

    public Spine_Unity_SkeletonGraphic_color_a(object value)
    {
        mInstance = (Spine.Unity.SkeletonGraphic)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.color;
        cache.a = value;
        mInstance.color = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_sizeDelta_x
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_sizeDelta_x(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.sizeDelta;
        cache.x = value;
        mInstance.sizeDelta = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_sizeDelta_y
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_sizeDelta_y(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.sizeDelta;
        cache.y = value;
        mInstance.sizeDelta = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_CanvasGroup_alpha
{
    private UnityEngine.CanvasGroup mInstance;
    private float mValue;

    public UnityEngine_CanvasGroup_alpha(object value)
    {
        mInstance = (UnityEngine.CanvasGroup)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        mInstance.alpha = value;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class BezierMoveCurve_Value
{
    private BezierMoveCurve mInstance;
    private float mValue;

    public BezierMoveCurve_Value(object value)
    {
        mInstance = (BezierMoveCurve)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        mInstance.Value = value;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localPosition_x
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localPosition_x(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localPosition;
        cache.x = value;
        mInstance.localPosition = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localPosition_y
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localPosition_y(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localPosition;
        cache.y = value;
        mInstance.localPosition = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_localPosition_z
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_localPosition_z(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.localPosition;
        cache.z = value;
        mInstance.localPosition = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class PathMoveHelper_GetPoint1_x
{
    private PathMoveHelper mInstance;
    private float mValue;

    public PathMoveHelper_GetPoint1_x(object value)
    {
        mInstance = (PathMoveHelper)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.GetPoint1;
        cache.x = value;
        mInstance.GetPoint1 = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class PathMoveHelper_GetPoint1_y
{
    private PathMoveHelper mInstance;
    private float mValue;

    public PathMoveHelper_GetPoint1_y(object value)
    {
        mInstance = (PathMoveHelper)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.GetPoint1;
        cache.y = value;
        mInstance.GetPoint1 = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_RectTransform_anchorMin_x
{
    private UnityEngine.RectTransform mInstance;
    private float mValue;

    public UnityEngine_RectTransform_anchorMin_x(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.anchorMin;
        cache.x = value;
        mInstance.anchorMin = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class TMPTextHelper_FaceColor_g
{
    private TMPTextHelper mInstance;
    private float mValue;

    public TMPTextHelper_FaceColor_g(object value)
    {
        mInstance = (TMPTextHelper)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.FaceColor;
        cache.g = value;
        mInstance.FaceColor = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class TMPTextHelper_FaceColor_b
{
    private TMPTextHelper mInstance;
    private float mValue;

    public TMPTextHelper_FaceColor_b(object value)
    {
        mInstance = (TMPTextHelper)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.FaceColor;
        cache.b = value;
        mInstance.FaceColor = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class PantheaMask_Height
{
    private PantheaMask mInstance;
    private float mValue;

    public PantheaMask_Height(object value)
    {
        mInstance = (PantheaMask)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        mInstance.Height = value;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class PantheaMask_Width
{
    private PantheaMask mInstance;
    private float mValue;

    public PantheaMask_Width(object value)
    {
        mInstance = (PantheaMask)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        mInstance.Width = value;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class Coffee_UIExtensions_UIParticle_scale3D_y
{
    private Coffee.UIExtensions.UIParticle mInstance;
    private float mValue;

    public Coffee_UIExtensions_UIParticle_scale3D_y(object value)
    {
        mInstance = (Coffee.UIExtensions.UIParticle)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.scale3D;
        cache.y = value;
        mInstance.scale3D = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class Coffee_UIExtensions_UIParticle_scale3D_z
{
    private Coffee.UIExtensions.UIParticle mInstance;
    private float mValue;

    public Coffee_UIExtensions_UIParticle_scale3D_z(object value)
    {
        mInstance = (Coffee.UIExtensions.UIParticle)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var cache = mInstance.scale3D;
        cache.z = value;
        mInstance.scale3D = cache;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_emissionModule_rateOverTime_scalar
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_emissionModule_rateOverTime_scalar(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var emission = mInstance.emission;

        if (emission.enabled)
        {
            var rate = emission.rateOverTime;
            rate.constant = value;
            emission.rateOverTime = rate;
        }
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_initialModule_startColor_minColor_r
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_initialModule_startColor_minColor_r(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMin;
        color.r = value;
        startColor.colorMin = color;
        mainModule.startColor = startColor;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_initialModule_startColor_minColor_g
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_initialModule_startColor_minColor_g(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMin;
        color.g = value;
        startColor.colorMin = color;
        mainModule.startColor = startColor;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_initialModule_startColor_minColor_b
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_initialModule_startColor_minColor_b(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMin;
        color.b = value;
        startColor.colorMin = color;
        mainModule.startColor = startColor;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_initialModule_startColor_minColor_a
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_initialModule_startColor_minColor_a(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMin;
        color.a = value;
        startColor.colorMin = color;
        mainModule.startColor = startColor;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_initialModule_startColor_maxColor_r
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_initialModule_startColor_maxColor_r(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMax;
        color.r = value;
        startColor.colorMax = color;
        mainModule.startColor = startColor;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_initialModule_startColor_maxColor_g
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_initialModule_startColor_maxColor_g(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMax;
        color.g = value;
        startColor.colorMax = color;
        mainModule.startColor = startColor;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_initialModule_startColor_maxColor_b
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_initialModule_startColor_maxColor_b(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMax;
        color.b = value;
        startColor.colorMax = color;
        mainModule.startColor = startColor;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_initialModule_startColor_maxColor_a
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_initialModule_startColor_maxColor_a(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMax;
        color.a = value;
        startColor.colorMax = color;
        mainModule.startColor = startColor;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_initialModule_gravityModifier_scalar
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_initialModule_gravityModifier_scalar(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var initialModule = mInstance.main;
        var gravityModifier = initialModule.gravityModifier;
        gravityModifier.constant = value;
        initialModule.gravityModifier = gravityModifier;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_initialModule_startLifetime_scalar
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_initialModule_startLifetime_scalar(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var initialModule = mInstance.main;
        var startLifetime = initialModule.startLifetime;
        startLifetime.constant = value;
        initialModule.startLifetime = startLifetime;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_initialModule_startSpeed_scalar
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_initialModule_startSpeed_scalar(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var initialModule = mInstance.main;
        var startSpeed = initialModule.startSpeed;
        startSpeed.constant = value;
        initialModule.startSpeed = startSpeed;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystem_initialModule_startSpeed_minScalar
{
    private UnityEngine.ParticleSystem mInstance;
    private float mValue;

    public UnityEngine_ParticleSystem_initialModule_startSpeed_minScalar(object value)
    {
        mInstance = (UnityEngine.ParticleSystem)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var initialModule = mInstance.main;
        var startSpeed = initialModule.startSpeed;
        startSpeed.constantMin = value;
        initialModule.startSpeed = startSpeed;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystemRenderer_material__TintColor_r
{
    private UnityEngine.ParticleSystemRenderer mInstance;
    private float mValue;

    public UnityEngine_ParticleSystemRenderer_material__TintColor_r(object value)
    {
        mInstance = (UnityEngine.ParticleSystemRenderer)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var material = mInstance.material;
        if (material != null)
        {
            var color = material.GetColor("_TintColor");
            color.r = value;
            material.SetColor("_TintColor", color);
        }
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystemRenderer_material__TintColor_g
{
    private UnityEngine.ParticleSystemRenderer mInstance;
    private float mValue;

    public UnityEngine_ParticleSystemRenderer_material__TintColor_g(object value)
    {
        mInstance = (UnityEngine.ParticleSystemRenderer)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var material = mInstance.material;
        if (material != null)
        {
            var color = material.GetColor("_TintColor");
            color.g = value;
            material.SetColor("_TintColor", color);
        }
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystemRenderer_material__TintColor_b
{
    private UnityEngine.ParticleSystemRenderer mInstance;
    private float mValue;

    public UnityEngine_ParticleSystemRenderer_material__TintColor_b(object value)
    {
        mInstance = (UnityEngine.ParticleSystemRenderer)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var material = mInstance.material;
        if (material != null)
        {
            var color = material.GetColor("_TintColor");
            color.b = value;
            material.SetColor("_TintColor", color);
        }
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_ParticleSystemRenderer_material__TintColor_a
{
    private UnityEngine.ParticleSystemRenderer mInstance;
    private float mValue;

    public UnityEngine_ParticleSystemRenderer_material__TintColor_a(object value)
    {
        mInstance = (UnityEngine.ParticleSystemRenderer)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        var material = mInstance.material;
        if (material != null)
        {
            var color = material.GetColor("_TintColor");
            color.a = value;
            material.SetColor("_TintColor", color);
        }
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class UnityEngine_UI_Image_raycastTarget
{
    private UnityEngine.UI.Image mInstance;
    private float mValue;

    public UnityEngine_UI_Image_raycastTarget(object value)
    {
        mInstance = (UnityEngine.UI.Image)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        mInstance.raycastTarget = value == 1;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class Spine_Unity_SkeletonAnimation_enabled
{
    private Spine.Unity.SkeletonAnimation mInstance;
    private float mValue;

    public Spine_Unity_SkeletonAnimation_enabled(object value)
    {
        mInstance = (Spine.Unity.SkeletonAnimation)value;
    }

    public float Get()
    {
        return mValue;
    }

    public void Set(float value)
    {
        mValue = value;
        mInstance.enabled = value == 1;
    }

    public DG.Tweening.Tween GetTween(float endValue, float duration)
    {
        mValue = 0;
        return DG.Tweening.DOTween.To(Get, Set, endValue, duration);
    }
}

public class BetterAnimationAot
{
    public static System.Collections.Generic.Dictionary<string, System.Func<object,float,float,DG.Tweening.Tween>> Delegate = new System.Collections.Generic.Dictionary<string, System.Func<object,float,float,DG.Tweening.Tween>>{
     {"UnityEngine_GameObject_isActive",(t1,t2,t3)=> new UnityEngine_GameObject_isActive(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localScale_x",(t1,t2,t3)=> new UnityEngine_Transform_localScale_x(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localScale_y",(t1,t2,t3)=> new UnityEngine_Transform_localScale_y(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localScale_z",(t1,t2,t3)=> new UnityEngine_Transform_localScale_z(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localEulerAngles_x",(t1,t2,t3)=> new UnityEngine_Transform_localEulerAngles_x(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localEulerAngles_y",(t1,t2,t3)=> new UnityEngine_Transform_localEulerAngles_y(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localEulerAngles_z",(t1,t2,t3)=> new UnityEngine_Transform_localEulerAngles_z(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localPosition_x",(t1,t2,t3)=> new UnityEngine_Transform_localPosition_x(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localPosition_y",(t1,t2,t3)=> new UnityEngine_Transform_localPosition_y(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localPosition_z",(t1,t2,t3)=> new UnityEngine_Transform_localPosition_z(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localScale_x",(t1,t2,t3)=> new UnityEngine_RectTransform_localScale_x(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localScale_y",(t1,t2,t3)=> new UnityEngine_RectTransform_localScale_y(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localScale_z",(t1,t2,t3)=> new UnityEngine_RectTransform_localScale_z(t1).GetTween(t2,t3)},
     {"UnityEngine_UI_Image_color_r",(t1,t2,t3)=> new UnityEngine_UI_Image_color_r(t1).GetTween(t2,t3)},
     {"UnityEngine_UI_Image_color_g",(t1,t2,t3)=> new UnityEngine_UI_Image_color_g(t1).GetTween(t2,t3)},
     {"UnityEngine_UI_Image_color_b",(t1,t2,t3)=> new UnityEngine_UI_Image_color_b(t1).GetTween(t2,t3)},
     {"UnityEngine_UI_Image_color_a",(t1,t2,t3)=> new UnityEngine_UI_Image_color_a(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_anchoredPosition_x",(t1,t2,t3)=> new UnityEngine_RectTransform_anchoredPosition_x(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_anchoredPosition_y",(t1,t2,t3)=> new UnityEngine_RectTransform_anchoredPosition_y(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localRotation_x",(t1,t2,t3)=> new UnityEngine_RectTransform_localRotation_x(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localRotation_y",(t1,t2,t3)=> new UnityEngine_RectTransform_localRotation_y(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localRotation_z",(t1,t2,t3)=> new UnityEngine_RectTransform_localRotation_z(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localRotation_w",(t1,t2,t3)=> new UnityEngine_RectTransform_localRotation_w(t1).GetTween(t2,t3)},
     {"AudioHelper_enabled",(t1,t2,t3)=> new AudioHelper_enabled(t1).GetTween(t2,t3)},
     {"TMPro_TextMeshProUGUI_color_a",(t1,t2,t3)=> new TMPro_TextMeshProUGUI_color_a(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localEulerAngles_x",(t1,t2,t3)=> new UnityEngine_RectTransform_localEulerAngles_x(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localEulerAngles_y",(t1,t2,t3)=> new UnityEngine_RectTransform_localEulerAngles_y(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localEulerAngles_z",(t1,t2,t3)=> new UnityEngine_RectTransform_localEulerAngles_z(t1).GetTween(t2,t3)},
     {"PathMoveHelper_Value",(t1,t2,t3)=> new PathMoveHelper_Value(t1).GetTween(t2,t3)},
     {"PathMoveHelper_GetPoint2_y",(t1,t2,t3)=> new PathMoveHelper_GetPoint2_y(t1).GetTween(t2,t3)},
     {"PathMoveHelper_GetPoint2_x",(t1,t2,t3)=> new PathMoveHelper_GetPoint2_x(t1).GetTween(t2,t3)},
     {"UnityEngine_UI_Image_enabled",(t1,t2,t3)=> new UnityEngine_UI_Image_enabled(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localRotation_x",(t1,t2,t3)=> new UnityEngine_Transform_localRotation_x(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localRotation_y",(t1,t2,t3)=> new UnityEngine_Transform_localRotation_y(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localRotation_z",(t1,t2,t3)=> new UnityEngine_Transform_localRotation_z(t1).GetTween(t2,t3)},
     {"UnityEngine_Transform_localRotation_w",(t1,t2,t3)=> new UnityEngine_Transform_localRotation_w(t1).GetTween(t2,t3)},
     {"TMPro_TextMeshProUGUI_color_r",(t1,t2,t3)=> new TMPro_TextMeshProUGUI_color_r(t1).GetTween(t2,t3)},
     {"TMPro_TextMeshProUGUI_color_g",(t1,t2,t3)=> new TMPro_TextMeshProUGUI_color_g(t1).GetTween(t2,t3)},
     {"TMPro_TextMeshProUGUI_color_b",(t1,t2,t3)=> new TMPro_TextMeshProUGUI_color_b(t1).GetTween(t2,t3)},
     {"Spine_Unity_SkeletonGraphic_color_r",(t1,t2,t3)=> new Spine_Unity_SkeletonGraphic_color_r(t1).GetTween(t2,t3)},
     {"Spine_Unity_SkeletonGraphic_color_g",(t1,t2,t3)=> new Spine_Unity_SkeletonGraphic_color_g(t1).GetTween(t2,t3)},
     {"Spine_Unity_SkeletonGraphic_color_b",(t1,t2,t3)=> new Spine_Unity_SkeletonGraphic_color_b(t1).GetTween(t2,t3)},
     {"Spine_Unity_SkeletonGraphic_color_a",(t1,t2,t3)=> new Spine_Unity_SkeletonGraphic_color_a(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_sizeDelta_x",(t1,t2,t3)=> new UnityEngine_RectTransform_sizeDelta_x(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_sizeDelta_y",(t1,t2,t3)=> new UnityEngine_RectTransform_sizeDelta_y(t1).GetTween(t2,t3)},
     {"UnityEngine_CanvasGroup_alpha",(t1,t2,t3)=> new UnityEngine_CanvasGroup_alpha(t1).GetTween(t2,t3)},
     {"BezierMoveCurve_Value",(t1,t2,t3)=> new BezierMoveCurve_Value(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localPosition_x",(t1,t2,t3)=> new UnityEngine_RectTransform_localPosition_x(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localPosition_y",(t1,t2,t3)=> new UnityEngine_RectTransform_localPosition_y(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_localPosition_z",(t1,t2,t3)=> new UnityEngine_RectTransform_localPosition_z(t1).GetTween(t2,t3)},
     {"PathMoveHelper_GetPoint1_x",(t1,t2,t3)=> new PathMoveHelper_GetPoint1_x(t1).GetTween(t2,t3)},
     {"PathMoveHelper_GetPoint1_y",(t1,t2,t3)=> new PathMoveHelper_GetPoint1_y(t1).GetTween(t2,t3)},
     {"UnityEngine_RectTransform_anchorMin_x",(t1,t2,t3)=> new UnityEngine_RectTransform_anchorMin_x(t1).GetTween(t2,t3)},
     {"TMPTextHelper_FaceColor_g",(t1,t2,t3)=> new TMPTextHelper_FaceColor_g(t1).GetTween(t2,t3)},
     {"TMPTextHelper_FaceColor_b",(t1,t2,t3)=> new TMPTextHelper_FaceColor_b(t1).GetTween(t2,t3)},
     {"PantheaMask_Height",(t1,t2,t3)=> new PantheaMask_Height(t1).GetTween(t2,t3)},
     {"PantheaMask_Width",(t1,t2,t3)=> new PantheaMask_Width(t1).GetTween(t2,t3)},
     {"Coffee_UIExtensions_UIParticle_scale3D_y",(t1,t2,t3)=> new Coffee_UIExtensions_UIParticle_scale3D_y(t1).GetTween(t2,t3)},
     {"Coffee_UIExtensions_UIParticle_scale3D_z",(t1,t2,t3)=> new Coffee_UIExtensions_UIParticle_scale3D_z(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_emissionModule_rateOverTime_scalar",(t1,t2,t3)=> new UnityEngine_ParticleSystem_emissionModule_rateOverTime_scalar(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_initialModule_startColor_minColor_r",(t1,t2,t3)=> new UnityEngine_ParticleSystem_initialModule_startColor_minColor_r(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_initialModule_startColor_minColor_g",(t1,t2,t3)=> new UnityEngine_ParticleSystem_initialModule_startColor_minColor_g(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_initialModule_startColor_minColor_b",(t1,t2,t3)=> new UnityEngine_ParticleSystem_initialModule_startColor_minColor_b(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_initialModule_startColor_minColor_a",(t1,t2,t3)=> new UnityEngine_ParticleSystem_initialModule_startColor_minColor_a(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_initialModule_startColor_maxColor_r",(t1,t2,t3)=> new UnityEngine_ParticleSystem_initialModule_startColor_maxColor_r(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_initialModule_startColor_maxColor_g",(t1,t2,t3)=> new UnityEngine_ParticleSystem_initialModule_startColor_maxColor_g(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_initialModule_startColor_maxColor_b",(t1,t2,t3)=> new UnityEngine_ParticleSystem_initialModule_startColor_maxColor_b(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_initialModule_startColor_maxColor_a",(t1,t2,t3)=> new UnityEngine_ParticleSystem_initialModule_startColor_maxColor_a(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_initialModule_gravityModifier_scalar",(t1,t2,t3)=> new UnityEngine_ParticleSystem_initialModule_gravityModifier_scalar(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_initialModule_startLifetime_scalar",(t1,t2,t3)=> new UnityEngine_ParticleSystem_initialModule_startLifetime_scalar(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_initialModule_startSpeed_scalar",(t1,t2,t3)=> new UnityEngine_ParticleSystem_initialModule_startSpeed_scalar(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystem_initialModule_startSpeed_minScalar",(t1,t2,t3)=> new UnityEngine_ParticleSystem_initialModule_startSpeed_minScalar(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystemRenderer_material__TintColor_r",(t1,t2,t3)=> new UnityEngine_ParticleSystemRenderer_material__TintColor_r(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystemRenderer_material__TintColor_g",(t1,t2,t3)=> new UnityEngine_ParticleSystemRenderer_material__TintColor_g(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystemRenderer_material__TintColor_b",(t1,t2,t3)=> new UnityEngine_ParticleSystemRenderer_material__TintColor_b(t1).GetTween(t2,t3)},
     {"UnityEngine_ParticleSystemRenderer_material__TintColor_a",(t1,t2,t3)=> new UnityEngine_ParticleSystemRenderer_material__TintColor_a(t1).GetTween(t2,t3)},
     {"UnityEngine_UI_Image_raycastTarget",(t1,t2,t3)=> new UnityEngine_UI_Image_raycastTarget(t1).GetTween(t2,t3)},
     {"Spine_Unity_SkeletonAnimation_enabled",(t1,t2,t3)=> new Spine_Unity_SkeletonAnimation_enabled(t1).GetTween(t2,t3)},
};
}

