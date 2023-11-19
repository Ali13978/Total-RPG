using UnityEngine;
public static class AppSettings.GraphicsSettings
{
    // Fields
    private const string DEFAULT_QUALITY = "TOTAL_GRAPHICS_DEFAULT_QUALITY";
    private const string LOW_QUALITY = "TOTAL_GRAPHICS_LOW_QUALITY";
    private const string SHADOWS = "TOTAL_GRAPHICS_SHADOWS";
    private const string COLOR_ENHANCE = "TOTAL_GRAPHICS_COLOR_ENHANCE";
    
    // Properties
    public static bool LowQuality { get; set; }
    public static bool Shadows { get; set; }
    public static bool ColorEnhance { get; set; }
    
    // Methods
    public static bool get_LowQuality()
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  0, defaultValue:  1653656464)) > 0) ? 1 : 0;
    }
    public static void set_LowQuality(bool value)
    {
        var val_1 = W1 & 1;
        UnityEngine.PlayerPrefs.SetInt(key:  0, value:  1653656464);
        AppSettings.GraphicsSettings.Adjust();
    }
    public static bool get_Shadows()
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  0, defaultValue:  1653880592)) > 0) ? 1 : 0;
    }
    public static void set_Shadows(bool value)
    {
        var val_1 = W1 & 1;
        UnityEngine.PlayerPrefs.SetInt(key:  0, value:  1653880592);
        AppSettings.GraphicsSettings.Adjust();
    }
    public static bool get_ColorEnhance()
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  0, defaultValue:  1654104704)) > 0) ? 1 : 0;
    }
    public static void set_ColorEnhance(bool value)
    {
        var val_1 = W1 & 1;
        UnityEngine.PlayerPrefs.SetInt(key:  0, value:  1654104704);
        AppSettings.GraphicsSettings.Adjust();
    }
    public static void Adjust()
    {
        string val_8;
        var val_9;
        val_8 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_8)) != true)
        {
                int val_3 = UnityEngine.QualitySettings.GetQualityLevel();
            val_8 = 0;
            UnityEngine.PlayerPrefs.SetInt(key:  val_8, value:  1654328832);
        }
        
        if(AppSettings.GraphicsSettings.LowQuality != false)
        {
                UnityEngine.Debug.Log(message:  0);
            val_9 = 0;
        }
        else
        {
                UnityEngine.Debug.Log(message:  0);
            int val_7 = UnityEngine.PlayerPrefs.GetInt(key:  0);
            val_9 = 0;
        }
        
        UnityEngine.QualitySettings.SetQualityLevel(index:  0);
    }

}
