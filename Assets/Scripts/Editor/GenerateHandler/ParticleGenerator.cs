public static class ParticleGenerator 
{
    public static string emissionModule_rateOverTime_scalar()
    {
        return @"mValue = value;
        var emission = mInstance.emission;

        if (emission.enabled)
        {
            var rate = emission.rateOverTime;
            rate.constant = value;
            emission.rateOverTime = rate;
        }";
    }
    
    public static string initialModule_startColor_minColor_r()
    {
        return @"mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMin;
        color.r = value;
        startColor.colorMin = color;
        mainModule.startColor = startColor;";
    }
    
    public static string initialModule_startColor_minColor_g()
    {
        return @"mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMin;
        color.g = value;
        startColor.colorMin = color;
        mainModule.startColor = startColor;";
    }
    
    public static string initialModule_startColor_minColor_b()
    {
        return @"mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMin;
        color.b = value;
        startColor.colorMin = color;
        mainModule.startColor = startColor;";
    }
    
    public static string initialModule_startColor_minColor_a()
    {
        return @"mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMin;
        color.a = value;
        startColor.colorMin = color;
        mainModule.startColor = startColor;";
    }
    
    public static string initialModule_startColor_maxColor_r()
    {
        return @"mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMax;
        color.r = value;
        startColor.colorMax = color;
        mainModule.startColor = startColor;";
    }
    
    public static string initialModule_startColor_maxColor_g()
    {
        return @"mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMax;
        color.g = value;
        startColor.colorMax = color;
        mainModule.startColor = startColor;";
    }
    
    public static string initialModule_startColor_maxColor_b()
    {
        return @"mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMax;
        color.b = value;
        startColor.colorMax = color;
        mainModule.startColor = startColor;";
    }
    
    public static string initialModule_startColor_maxColor_a()
    {
        return @"mValue = value;
        var mainModule = mInstance.main;
        var startColor = mainModule.startColor;
        var color = startColor.colorMax;
        color.a = value;
        startColor.colorMax = color;
        mainModule.startColor = startColor;";
    }
    
    public static string initialModule_gravityModifier_scalar()
    {
        return @"mValue = value;
        var initialModule = mInstance.main;
        var gravityModifier = initialModule.gravityModifier;
        gravityModifier.constant = value;
        initialModule.gravityModifier = gravityModifier;";
    }
    
    public static string initialModule_startLifetime_scalar()
    {
        return @"mValue = value;
        var initialModule = mInstance.main;
        var startLifetime = initialModule.startLifetime;
        startLifetime.constant = value;
        initialModule.startLifetime = startLifetime;";
    }
    
    public static string initialModule_startSpeed_scalar()
    {
        return @"mValue = value;
        var initialModule = mInstance.main;
        var startSpeed = initialModule.startSpeed;
        startSpeed.constant = value;
        initialModule.startSpeed = startSpeed;";
    }
    
    public static string initialModule_startSpeed_minScalar()
    {
        return @"mValue = value;
        var initialModule = mInstance.main;
        var startSpeed = initialModule.startSpeed;
        startSpeed.constantMin = value;
        initialModule.startSpeed = startSpeed;";
    }
    
    public static string initialModule_startSpeed_maxScalar()
    {
        return @"mValue = value;
        var initialModule = mInstance.main;
        var startSpeed = initialModule.startSpeed;
        startSpeed.constantMax = value;
        initialModule.startSpeed = startSpeed;";
    }
   
}