using UnityEngine;
internal class GooglePlayObbDownloader : IGooglePlayObbDownloader
{
    // Fields
    private static UnityEngine.AndroidJavaClass EnvironmentClass;
    private const string Environment_MediaMounted = "mounted";
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <PublicKey>k__BackingField;
    private string m_ExpansionFilePath;
    private static string m_ObbPackage;
    private static int m_ObbVersion;
    
    // Properties
    public string PublicKey { get; set; }
    private static string ObbPackage { get; }
    private static int ObbVersion { get; }
    
    // Methods
    public GooglePlayObbDownloader()
    {
    
    }
    public string get_PublicKey()
    {
        return (string)this.<PublicKey>k__BackingField;
    }
    public void set_PublicKey(string value)
    {
        this.<PublicKey>k__BackingField = value;
    }
    private void ApplyPublicKey()
    {
        var val_9;
        var val_10;
        var val_11;
        if((System.String.IsNullOrEmpty(value:  0)) != false)
        {
                UnityEngine.Debug.LogError(message:  0);
        }
        
        UnityEngine.AndroidJavaClass val_2 = null;
        val_9 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.plugin.downloader.UnityDownloaderService");
        SetStatic<System.String>(fieldName:  "BASE64_PUBLIC_KEY", val:  this.<PublicKey>k__BackingField);
        SetStatic<System.Byte[]>(fieldName:  "SALT", val:  null);
        val_10 = 101;
        if(null == 0)
        {
            goto label_8;
        }
        
        UnityEngine.AndroidJavaClass val_11 = null;
        if((mem[null + 258]) == 0)
        {
            goto label_9;
        }
        
        var val_9 = mem[null + 152];
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_11:
        if(((mem[null + 152] + 8) + -8) == null)
        {
            goto label_10;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (mem[null + 258]))
        {
            goto label_11;
        }
        
        label_9:
        val_11 = val_9;
        goto label_12;
        label_10:
        val_11 = val_11 + (((mem[null + 152] + 8)) << 4);
        label_12:
        label_8:
        if(101 == 101)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_9 = ???;
        val_10 = ???;
    }
    public void FetchOBB()
    {
        var val_9;
        this.ApplyPublicKey();
        UnityEngine.AndroidJavaObject val_2 = GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_2;
        UnityEngine.AndroidJavaClass val_3 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.plugin.downloader.UnityDownloaderActivity");
        typeof(System.Object[]).__il2cppRuntimeField_28 = null;
        UnityEngine.AndroidJavaObject val_4 = new UnityEngine.AndroidJavaObject(className:  "android.content.Intent", args:  null);
        typeof(System.Object[]).__il2cppRuntimeField_20 = 65536;
        typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
        UnityEngine.AndroidJavaObject val_5 = Call<UnityEngine.AndroidJavaObject>(methodName:  "addFlags", args:  null);
        typeof(System.Object[]).__il2cppRuntimeField_20 = "unityplayer.Activity";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getClass", args:  null).Call<System.String>(methodName:  "getName", args:  null);
        UnityEngine.AndroidJavaObject val_8 = Call<UnityEngine.AndroidJavaObject>(methodName:  "putExtra", args:  null);
        typeof(System.Object[]).__il2cppRuntimeField_20 = null;
        val_2.Call(methodName:  "startActivity", args:  null);
        if(null == 0)
        {
            goto label_30;
        }
        
        UnityEngine.AndroidJavaClass val_11 = null;
        if((mem[null + 258]) == 0)
        {
            goto label_31;
        }
        
        var val_9 = mem[null + 152];
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_33:
        if(((mem[null + 152] + 8) + -8) == null)
        {
            goto label_32;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (mem[null + 258]))
        {
            goto label_33;
        }
        
        label_31:
        val_9 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        goto label_34;
        label_32:
        val_11 = val_11 + (((mem[null + 152] + 8)) << 4);
        label_34:
        label_30:
        if(227 == 227)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    public string GetExpansionFilePath()
    {
        var val_9;
        string val_10;
        string val_11;
        var val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        val_10 = "getExternalStorageState";
        if((System.String.op_Inequality(a:  0, b:  GooglePlayObbDownloader.Environment_MediaMounted.CallStatic<System.String>(methodName:  val_10, args:  null))) != false)
        {
                val_11 = 0;
            this.m_ExpansionFilePath = 0;
            return val_11;
        }
        
        if((System.String.IsNullOrEmpty(value:  0)) != false)
        {
                val_12 = null;
            val_12 = null;
            UnityEngine.AndroidJavaObject val_4 = GooglePlayObbDownloader.Environment_MediaMounted.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getExternalStorageDirectory", args:  null);
            string val_6 = GooglePlayObbDownloader.ObbPackage;
            val_10 = 0;
            this.m_ExpansionFilePath = System.String.Format(format:  0, arg0:  "{0}/{1}/{2}", arg1:  val_4.Call<System.String>(methodName:  "getPath", args:  null), arg2:  "Android/obb");
            if(val_4 != null)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_13 = val_4;
        }
        
        }
        
        val_11 = this.m_ExpansionFilePath;
        return val_11;
    }
    public string GetMainOBBPath()
    {
        return GooglePlayObbDownloader.GetOBBPackagePath(expansionFilePath:  null = null, prefix:  this.GetExpansionFilePath());
    }
    public string GetPatchOBBPath()
    {
        return GooglePlayObbDownloader.GetOBBPackagePath(expansionFilePath:  null = null, prefix:  this.GetExpansionFilePath());
    }
    private static string GetOBBPackagePath(string expansionFilePath, string prefix)
    {
        var val_8;
        var val_9;
        if((System.String.IsNullOrEmpty(value:  0)) != false)
        {
                val_9 = 0;
            return (string)((System.IO.File.Exists(path:  0)) != true) ? (val_8) : 0;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = prefix;
        typeof(System.Object[]).__il2cppRuntimeField_28 = X2;
        typeof(System.Object[]).__il2cppRuntimeField_30 = GooglePlayObbDownloader.ObbVersion;
        typeof(System.Object[]).__il2cppRuntimeField_34 = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_38 = GooglePlayObbDownloader.ObbPackage;
        val_8 = System.String.Format(format:  0, args:  "{0}/{1}.{2}.{3}.obb");
        return (string)((System.IO.File.Exists(path:  0)) != true) ? (val_8) : 0;
    }
    private static string get_ObbPackage()
    {
        var val_1 = null;
        if(GooglePlayObbDownloader.m_ObbPackage == null)
        {
                GooglePlayObbDownloader.PopulateOBBProperties();
            val_1 = null;
        }
        
        val_1 = null;
        return (string)GooglePlayObbDownloader.m_ObbPackage;
    }
    private static int get_ObbVersion()
    {
        var val_1 = null;
        if(GooglePlayObbDownloader.m_ObbVersion == 0)
        {
                GooglePlayObbDownloader.PopulateOBBProperties();
            val_1 = null;
        }
        
        val_1 = null;
        return (int)GooglePlayObbDownloader.m_ObbVersion;
    }
    private static void PopulateOBBProperties()
    {
        var val_7;
        var val_8;
        UnityEngine.AndroidJavaObject val_2 = GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_7 = null;
        val_7 = null;
        GooglePlayObbDownloader.m_ObbPackage = val_2.Call<System.String>(methodName:  "getPackageName", args:  null);
        typeof(System.Object[]).__il2cppRuntimeField_20 = GooglePlayObbDownloader.m_ObbPackage;
        typeof(System.Object[]).__il2cppRuntimeField_28 = 0;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        GooglePlayObbDownloader.m_ObbVersion = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  null).Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageInfo", args:  null).Get<System.Int32>(fieldName:  "versionCode");
        if(null == 0)
        {
            goto label_15;
        }
        
        UnityEngine.AndroidJavaClass val_9 = null;
        if((mem[null + 258]) == 0)
        {
            goto label_16;
        }
        
        var val_7 = mem[null + 152];
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_18:
        if(((mem[null + 152] + 8) + -8) == null)
        {
            goto label_17;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (mem[null + 258]))
        {
            goto label_18;
        }
        
        label_16:
        val_8 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        goto label_19;
        label_17:
        val_9 = val_9 + (((mem[null + 152] + 8)) << 4);
        label_19:
        label_15:
        if(130 == 130)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    private static GooglePlayObbDownloader()
    {
        GooglePlayObbDownloader.Environment_MediaMounted = new UnityEngine.AndroidJavaClass(className:  "android.os.Environment");
    }

}
