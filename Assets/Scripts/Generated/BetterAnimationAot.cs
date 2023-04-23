public  class UnityEngine_Transform_localPosition_x
{
    private  UnityEngine.Transform mInstance ;
    private  float mValue ;

    public   UnityEngine_Transform_localPosition_x(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public  System.Single Get()
    {
        return mValue;
    }

    public  void Set(System.Single value)
    {
        mValue = value;var cache = mInstance.localPosition;
cache.x = value;
mInstance.localPosition = cache;
    }

    public  DG.Tweening.Tween GetTween(System.Single endValue, float duration)
    {
        mValue = 0;return DG.Tweening.DOTween.To(Get,Set,endValue,duration);
    }
}
public  class UnityEngine_Transform_localPosition_y
{
    private  UnityEngine.Transform mInstance ;
    private  float mValue ;

    public   UnityEngine_Transform_localPosition_y(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public  System.Single Get()
    {
        return mValue;
    }

    public  void Set(System.Single value)
    {
        mValue = value;var cache = mInstance.localPosition;
cache.y = value;
mInstance.localPosition = cache;
    }

    public  DG.Tweening.Tween GetTween(System.Single endValue, float duration)
    {
        mValue = 0;return DG.Tweening.DOTween.To(Get,Set,endValue,duration);
    }
}
public  class UnityEngine_Transform_localPosition_z
{
    private  UnityEngine.Transform mInstance ;
    private  float mValue ;

    public   UnityEngine_Transform_localPosition_z(object value)
    {
        mInstance = (UnityEngine.Transform)value;
    }

    public  System.Single Get()
    {
        return mValue;
    }

    public  void Set(System.Single value)
    {
        mValue = value;var cache = mInstance.localPosition;
cache.z = value;
mInstance.localPosition = cache;
    }

    public  DG.Tweening.Tween GetTween(System.Single endValue, float duration)
    {
        mValue = 0;return DG.Tweening.DOTween.To(Get,Set,endValue,duration);
    }
}
public  class UnityEngine_UI_Image_color_r
{
    private  UnityEngine.UI.Image mInstance ;
    private  float mValue ;

    public   UnityEngine_UI_Image_color_r(object value)
    {
        mInstance = (UnityEngine.UI.Image)value;
    }

    public  System.Single Get()
    {
        return mValue;
    }

    public  void Set(System.Single value)
    {
        mValue = value;var cache = mInstance.color;
cache.r = value;
mInstance.color = cache;
    }

    public  DG.Tweening.Tween GetTween(System.Single endValue, float duration)
    {
        mValue = 0;return DG.Tweening.DOTween.To(Get,Set,endValue,duration);
    }
}
public  class UnityEngine_UI_Image_color_g
{
    private  UnityEngine.UI.Image mInstance ;
    private  float mValue ;

    public   UnityEngine_UI_Image_color_g(object value)
    {
        mInstance = (UnityEngine.UI.Image)value;
    }

    public  System.Single Get()
    {
        return mValue;
    }

    public  void Set(System.Single value)
    {
        mValue = value;var cache = mInstance.color;
cache.g = value;
mInstance.color = cache;
    }

    public  DG.Tweening.Tween GetTween(System.Single endValue, float duration)
    {
        mValue = 0;return DG.Tweening.DOTween.To(Get,Set,endValue,duration);
    }
}
public  class UnityEngine_UI_Image_color_b
{
    private  UnityEngine.UI.Image mInstance ;
    private  float mValue ;

    public   UnityEngine_UI_Image_color_b(object value)
    {
        mInstance = (UnityEngine.UI.Image)value;
    }

    public  System.Single Get()
    {
        return mValue;
    }

    public  void Set(System.Single value)
    {
        mValue = value;var cache = mInstance.color;
cache.b = value;
mInstance.color = cache;
    }

    public  DG.Tweening.Tween GetTween(System.Single endValue, float duration)
    {
        mValue = 0;return DG.Tweening.DOTween.To(Get,Set,endValue,duration);
    }
}
public  class UnityEngine_RectTransform_localScale_x
{
    private  UnityEngine.RectTransform mInstance ;
    private  float mValue ;

    public   UnityEngine_RectTransform_localScale_x(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public  System.Single Get()
    {
        return mValue;
    }

    public  void Set(System.Single value)
    {
        mValue = value;var cache = mInstance.localScale;
cache.x = value;
mInstance.localScale = cache;
    }

    public  DG.Tweening.Tween GetTween(System.Single endValue, float duration)
    {
        mValue = 0;return DG.Tweening.DOTween.To(Get,Set,endValue,duration);
    }
}
public  class UnityEngine_RectTransform_localScale_y
{
    private  UnityEngine.RectTransform mInstance ;
    private  float mValue ;

    public   UnityEngine_RectTransform_localScale_y(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public  System.Single Get()
    {
        return mValue;
    }

    public  void Set(System.Single value)
    {
        mValue = value;var cache = mInstance.localScale;
cache.y = value;
mInstance.localScale = cache;
    }

    public  DG.Tweening.Tween GetTween(System.Single endValue, float duration)
    {
        mValue = 0;return DG.Tweening.DOTween.To(Get,Set,endValue,duration);
    }
}
public  class UnityEngine_RectTransform_localScale_z
{
    private  UnityEngine.RectTransform mInstance ;
    private  float mValue ;

    public   UnityEngine_RectTransform_localScale_z(object value)
    {
        mInstance = (UnityEngine.RectTransform)value;
    }

    public  System.Single Get()
    {
        return mValue;
    }

    public  void Set(System.Single value)
    {
        mValue = value;var cache = mInstance.localScale;
cache.z = value;
mInstance.localScale = cache;
    }

    public  DG.Tweening.Tween GetTween(System.Single endValue, float duration)
    {
        mValue = 0;return DG.Tweening.DOTween.To(Get,Set,endValue,duration);
    }
}
public  class BetterAnimationAot
{
    public static System.Collections.Generic.Dictionary<string, System.Func<object,float,float,DG.Tweening.Tween>> Delegate = new System.Collections.Generic.Dictionary<string, System.Func<object,float,float,DG.Tweening.Tween>>{{"UnityEngine_Transform_localPosition_x",(t1,t2,t3)=> new UnityEngine_Transform_localPosition_x(t1).GetTween((System.Single)t2,t3)},{"UnityEngine_Transform_localPosition_y",(t1,t2,t3)=> new UnityEngine_Transform_localPosition_y(t1).GetTween((System.Single)t2,t3)},{"UnityEngine_Transform_localPosition_z",(t1,t2,t3)=> new UnityEngine_Transform_localPosition_z(t1).GetTween((System.Single)t2,t3)},{"UnityEngine_UI_Image_color_r",(t1,t2,t3)=> new UnityEngine_UI_Image_color_r(t1).GetTween((System.Single)t2,t3)},{"UnityEngine_UI_Image_color_g",(t1,t2,t3)=> new UnityEngine_UI_Image_color_g(t1).GetTween((System.Single)t2,t3)},{"UnityEngine_UI_Image_color_b",(t1,t2,t3)=> new UnityEngine_UI_Image_color_b(t1).GetTween((System.Single)t2,t3)},{"UnityEngine_RectTransform_localScale_x",(t1,t2,t3)=> new UnityEngine_RectTransform_localScale_x(t1).GetTween((System.Single)t2,t3)},{"UnityEngine_RectTransform_localScale_y",(t1,t2,t3)=> new UnityEngine_RectTransform_localScale_y(t1).GetTween((System.Single)t2,t3)},{"UnityEngine_RectTransform_localScale_z",(t1,t2,t3)=> new UnityEngine_RectTransform_localScale_z(t1).GetTween((System.Single)t2,t3)},};
}