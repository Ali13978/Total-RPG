using UnityEngine;
public static class SA_iTween.Defaults
{
    // Fields
    public static float time;
    public static float delay;
    public static SA.Common.Animation.SA_iTween.NamedValueColor namedColorValue;
    public static SA.Common.Animation.SA_iTween.LoopType loopType;
    public static SA.Common.Animation.EaseType easeType;
    public static float lookSpeed;
    public static bool isLocal;
    public static UnityEngine.Space space;
    public static bool orientToPath;
    public static UnityEngine.Color color;
    public static float updateTimePercentage;
    public static float updateTime;
    public static int cameraFadeDepth;
    public static float lookAhead;
    public static bool useRealTime;
    public static UnityEngine.Vector3 up;
    
    // Methods
    private static SA_iTween.Defaults()
    {
        SA_iTween.Defaults.time = 1f;
        SA_iTween.Defaults.delay = 0f;
        SA_iTween.Defaults.namedColorValue = 0;
        SA_iTween.Defaults.loopType = 0;
        SA_iTween.Defaults.easeType = 16;
        SA_iTween.Defaults.lookSpeed = 3f;
        SA_iTween.Defaults.isLocal = false;
        SA_iTween.Defaults.space = 1;
        SA_iTween.Defaults.orientToPath = false;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        SA_iTween.Defaults.color = val_1.r;
        SA_iTween.Defaults.time.__il2cppRuntimeField_28 = val_1.g;
        SA_iTween.Defaults.time.__il2cppRuntimeField_2C = val_1.b;
        SA_iTween.Defaults.time.__il2cppRuntimeField_30 = val_1.a;
        SA_iTween.Defaults.updateTimePercentage = 0.05f;
        SA_iTween.Defaults.updateTime = SA_iTween.Defaults.updateTimePercentage;
        SA_iTween.Defaults.cameraFadeDepth = 999999;
        SA_iTween.Defaults.lookAhead = 0.05f;
        SA_iTween.Defaults.useRealTime = false;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        SA_iTween.Defaults.up = val_2.x;
        SA_iTween.Defaults.time.__il2cppRuntimeField_4C = val_2.y;
        SA_iTween.Defaults.time.__il2cppRuntimeField_50 = val_2.z;
    }

}
