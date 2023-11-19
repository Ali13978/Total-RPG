using UnityEngine;

namespace GooglePlayGames.OurUtils
{
    public static class PlatformUtils
    {
        // Properties
        public static bool Supported { get; }
        
        // Methods
        public static bool get_Supported()
        {
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            typeof(System.Object[]).__il2cppRuntimeField_20 = "com.google.android.play.games";
            return (bool)((GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity").Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  null).Call<UnityEngine.AndroidJavaObject>(methodName:  "getLaunchIntentForPackage", args:  null)) != 0) ? 1 : 0;
        }
    
    }

}
