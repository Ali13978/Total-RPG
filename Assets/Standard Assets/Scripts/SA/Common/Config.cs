using UnityEngine;

namespace SA.Common
{
    public class Config
    {
        // Fields
        public const string LIB_VERSION = "24";
        public const int VERSION_UNDEFINED = 0;
        public const string VERSION_UNDEFINED_STRING = "Undefined";
        public const string SUPPORT_EMAIL = "support@stansassets.com";
        public const string WEBSITE_ROOT_URL = "https://stansassets.com/";
        public const string BUNDLES_PATH = "Plugins/StansAssets/Bundles/";
        public const string MODULS_PATH = "Plugins/StansAssets/Modules/";
        public const string SUPPORT_MODULS_PATH = "Plugins/StansAssets/Support/";
        public const string COMMON_LIB_PATH = "Plugins/StansAssets/Support/Common/";
        public const string VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/";
        public const string NATIVE_LIBRARIES_PATH = "Plugins/StansAssets/Support/NativeLibraries/";
        public const string EDITOR_TESTING_LIB_PATH = "Plugins/StansAssets/Support/EditorTesting/";
        public const string SETTINGS_REMOVE_PATH = "Plugins/StansAssets/Support/Settings/";
        public const string SETTINGS_PATH = "Plugins/StansAssets/Support/Settings/Resources/";
        public const string ANDROID_DESTANATION_PATH = "Plugins/Android/";
        public const string ANDROID_SOURCE_PATH = "Plugins/StansAssets/Support/NativeLibraries/Android/";
        public const string IOS_DESTANATION_PATH = "Plugins/IOS/";
        public const string IOS_SOURCE_PATH = "Plugins/StansAssets/Support/NativeLibraries/IOS/";
        public const string SPOTIFY_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/Spotify_VersionInfo.txt";
        public const string AN_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/AN_VersionInfo.txt";
        public const string UM_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/UM_VersionInfo.txt";
        public const string GMA_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/GMA_VersionInfo.txt";
        public const string MSP_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/MSP_VersionInfo.txt";
        public const string ISN_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/ISN_VersionInfo.txt";
        public const string MNP_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/MNP_VersionInfo.txt";
        public const string AMN_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/AMN_VersionInfo.txt";
        
        // Properties
        public static string FB_SDK_VersionCode { get; }
        public static int FB_SDK_MajorVersionCode { get; }
        
        // Methods
        public Config()
        {
        
        }
        public static string get_FB_SDK_VersionCode()
        {
            var val_16;
            var val_17;
            var val_18;
            System.Object[] val_19;
            var val_20;
            val_16 = "Undefined";
            val_17 = "Facebook.IFacebook";
            val_18 = System.AppDomain.CurrentDomain.GetAssemblies();
            val_19 = 0;
            label_8:
            if(val_19 >= val_2.Length)
            {
                goto label_14;
            }
            
            System.Reflection.Assembly val_16 = val_18[0];
            val_19 = val_19 + 1;
            if((val_16 == null) || (val_16 == null))
            {
                goto label_8;
            }
            
            val_18 = val_16.GetMethod(name:  "GetVersionAttributeOfType", bindingAttr:  24);
            if(val_18 != null)
            {
                    val_19 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = val_16;
                val_18 = val_18.Invoke(obj:  0, parameters:  val_19);
                System.Reflection.PropertyInfo val_5 = val_16.GetProperty(name:  "SdkVersion");
                if((val_18 != null) && (val_5 != null))
            {
                    val_20 = 0;
                if(val_5 != null)
            {
                    var val_6 = (null == null) ? (val_5) : 0;
            }
            
            }
            
            }
            
            label_14:
            if((System.Type.GetType(typeName:  0)) != null)
            {
                goto label_18;
            }
            
            System.Type val_9 = System.Type.GetType(typeName:  0);
            if(val_9 == null)
            {
                goto label_19;
            }
            
            label_18:
            System.Reflection.PropertyInfo val_10 = val_9.GetProperty(name:  "Build", bindingAttr:  24);
            if(val_10 == null)
            {
                    return (string)(val_6 == 0) ? (val_16) : (val_6);
            }
            
            val_16 = 0;
            if(val_10 == null)
            {
                    return (string)(val_6 == 0) ? (val_16) : (val_6);
            }
            
            val_16 = val_10;
            if(null == null)
            {
                    return (string)(val_6 == 0) ? (val_16) : (val_6);
            }
            
            val_16 = 0;
            return (string)(val_6 == 0) ? (val_16) : (val_6);
            label_19:
            val_17 = 1152921504608284672;
            val_19 = 0;
            goto label_25;
            label_34:
            val_19 = 1;
            label_25:
            if(val_19 >= val_13.Length)
            {
                    return (string)(val_6 == 0) ? (val_16) : (val_6);
            }
            
            System.Reflection.Assembly val_17 = System.AppDomain.CurrentDomain.GetAssemblies()[1];
            if(val_17 == null)
            {
                goto label_34;
            }
            
            System.Reflection.PropertyInfo val_14 = val_17.GetProperty(name:  "Build", bindingAttr:  24);
            if(((val_14 == null) || (val_14 == null)) || (null == null))
            {
                goto label_34;
            }
            
            goto label_34;
        }
        public static int get_FB_SDK_MajorVersionCode()
        {
            string val_7;
            string val_8;
            val_7 = SA.Common.Config.FB_SDK_VersionCode;
            if((val_7.Equals(value:  "Undefined")) != true)
            {
                    typeof(System.Char[]).__il2cppRuntimeField_20 = 46;
                val_7 = val_7.Split(separator:  null)[0];
                val_8 = 0;
                int val_5 = System.Convert.ToInt32(value:  val_8);
                return (int)val_8;
            }
            
            val_8 = 0;
            return (int)val_8;
        }
    
    }

}
