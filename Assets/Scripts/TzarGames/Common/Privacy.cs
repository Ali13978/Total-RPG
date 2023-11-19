using UnityEngine;

namespace TzarGames.Common
{
    public static class Privacy
    {
        // Fields
        private const string privacyAnswerKey = "PRIVACYUI_ANSWER_GIVEN";
        private const string canCollectKey = "TZAR_PRIVACY_CAN_COLLECT_DATA";
        private static int canCollectCached;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<bool> OnDataCollectionPermissionChanged;
        
        // Properties
        public static bool PrivacyAnswerGiven { get; set; }
        public static bool CanCollectData { get; set; }
        
        // Methods
        public static bool get_PrivacyAnswerGiven()
        {
            return UnityEngine.PlayerPrefs.HasKey(key:  0);
        }
        public static void set_PrivacyAnswerGiven(bool value)
        {
            var val_1 = W1 & 1;
            UnityEngine.PlayerPrefs.SetInt(key:  0, value:  -2042147520);
        }
        public static void add_OnDataCollectionPermissionChanged(System.Action<bool> value)
        {
            var val_3;
            System.Action<System.Boolean> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = TzarGames.Common.Privacy.OnDataCollectionPermissionChanged;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = TzarGames.Common.Privacy.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504897478664 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnDataCollectionPermissionChanged(System.Action<bool> value)
        {
            var val_3;
            System.Action<System.Boolean> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = TzarGames.Common.Privacy.OnDataCollectionPermissionChanged;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = TzarGames.Common.Privacy.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504897478664 != val_4)
            {
                goto label_8;
            }
        
        }
        public static bool get_CanCollectData()
        {
            int val_3;
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if(TzarGames.Common.Privacy.canCollectCached == 1)
            {
                    val_5 = null;
                val_3 = UnityEngine.PlayerPrefs.GetInt(key:  0, defaultValue:  -2041666640);
                val_5 = null;
                TzarGames.Common.Privacy.canCollectCached = val_3;
                val_4 = null;
            }
            
            val_4 = null;
            return (bool)(TzarGames.Common.Privacy.canCollectCached > 0) ? 1 : 0;
        }
        public static void set_CanCollectData(bool value)
        {
            var val_4 = null;
            TzarGames.Common.Privacy.canCollectCached = W1 & 1;
            UnityEngine.PlayerPrefs.SetInt(key:  0, value:  -2041666640);
            string val_2 = 0 + "CanCollectData changed to ";
            UnityEngine.Debug.Log(message:  0);
            if(TzarGames.Common.Privacy.OnDataCollectionPermissionChanged == null)
            {
                    return;
            }
            
            0.Invoke(obj:  W1 & 1);
        }
        private static Privacy()
        {
            TzarGames.Common.Privacy.canCollectCached = 0;
        }
    
    }

}
