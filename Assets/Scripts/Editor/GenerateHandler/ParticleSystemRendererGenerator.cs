public static class ParticleSystemRendererGenerator
{
    public static string material__TintColor_r()
    {
        return @"mValue = value;
        var material = mInstance.material;
        if (material != null)
        {
            var color = material.GetColor(""_TintColor"");
            color.r = value;
            material.SetColor(""_TintColor"", color);
        }";
    }
    
    public static string material__TintColor_g()
    {
        return @"mValue = value;
        var material = mInstance.material;
        if (material != null)
        {
            var color = material.GetColor(""_TintColor"");
            color.g = value;
            material.SetColor(""_TintColor"", color);
        }";
    }
    
    public static string material__TintColor_b()
    {
        return @"mValue = value;
        var material = mInstance.material;
        if (material != null)
        {
            var color = material.GetColor(""_TintColor"");
            color.b = value;
            material.SetColor(""_TintColor"", color);
        }";
    }
    
    public static string material__TintColor_a()
    {
        return @"mValue = value;
        var material = mInstance.material;
        if (material != null)
        {
            var color = material.GetColor(""_TintColor"");
            color.a = value;
            material.SetColor(""_TintColor"", color);
        }";
    }
}
