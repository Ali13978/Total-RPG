using UnityEngine;
public class IOSNativeUtility : Singleton<IOSNativeUtility>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<ISN_Locale> OnLocaleLoaded;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<bool> GuidedAccessSessionRequestResult;
    
    // Properties
    public bool IsGuidedAccessEnabled { get; }
    public static bool IsRunningTestFlightBeta { get; }
    
    // Methods
    public IOSNativeUtility()
    {
    
    }
    public static void add_OnLocaleLoaded(System.Action<ISN_Locale> value)
    {
        var val_3;
        System.Action<ISN_Locale> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSNativeUtility.OnLocaleLoaded;
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  null);
        val_5 = 0;
        if(val_1 == null)
        {
                return;
        }
        
        val_5 = val_1;
        if(null == null)
        {
                return;
        }
        
        val_5 = 0;
    }
    public static void remove_OnLocaleLoaded(System.Action<ISN_Locale> value)
    {
        var val_3;
        System.Action<ISN_Locale> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSNativeUtility.OnLocaleLoaded;
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  null);
        val_5 = 0;
        if(val_1 == null)
        {
                return;
        }
        
        val_5 = val_1;
        if(null == null)
        {
                return;
        }
        
        val_5 = 0;
    }
    public static void add_GuidedAccessSessionRequestResult(System.Action<bool> value)
    {
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSNativeUtility.GuidedAccessSessionRequestResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSNativeUtility.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504849129480 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_GuidedAccessSessionRequestResult(System.Action<bool> value)
    {
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSNativeUtility.GuidedAccessSessionRequestResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSNativeUtility.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504849129480 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void GetLocale()
    {
    
    }
    public static void CopyToClipboard(string text)
    {
    
    }
    public static void RedirectToAppStoreRatingPage()
    {
        IOSNativeSettings val_1 = IOSNativeSettings.Instance;
    }
    public static void RedirectToAppStoreRatingPage(string appleId)
    {
    
    }
    public static void SetApplicationBagesNumber(int count)
    {
    
    }
    public static void ShowPreloader()
    {
    
    }
    public static void HidePreloader()
    {
    
    }
    public void RequestGuidedAccessSession(bool enabled)
    {
    
    }
    public bool get_IsGuidedAccessEnabled()
    {
        return false;
    }
    public static bool get_IsRunningTestFlightBeta()
    {
        return true;
    }
    private void OnGuidedAccessSessionRequestResult(string data)
    {
        var val_3 = null;
        IOSNativeUtility.GuidedAccessSessionRequestResult.Invoke(obj:  System.Convert.ToBoolean(value:  0));
    }
    private void OnLocaleLoadedHandler(string data)
    {
        int val_3;
        var val_4;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = data.Split(separator:  null);
        val_3 = val_1.Length;
        if(val_3 == 0)
        {
                val_3 = val_1.Length;
        }
        
        if(val_3 <= 1)
        {
                val_3 = val_1.Length;
        }
        
        if(val_3 <= 2)
        {
                val_3 = val_1.Length;
        }
        
        typeof(ISN_Locale).__il2cppRuntimeField_10 = val_1[0];
        typeof(ISN_Locale).__il2cppRuntimeField_18 = val_1[1];
        typeof(ISN_Locale).__il2cppRuntimeField_20 = val_1[2];
        typeof(ISN_Locale).__il2cppRuntimeField_28 = val_1[3];
        val_4 = null;
        val_4 = null;
        IOSNativeUtility.OnLocaleLoaded.Invoke(obj:  new System.Object());
    }
    private static IOSNativeUtility()
    {
        IOSNativeUtility.OnLocaleLoaded = new System.Action<ISN_Locale>(object:  0, method:  static System.Void IOSNativeUtility::<OnLocaleLoaded>m__0(ISN_Locale ));
        IOSNativeUtility.GuidedAccessSessionRequestResult = new System.Action<System.Boolean>(object:  0, method:  static System.Void IOSNativeUtility::<GuidedAccessSessionRequestResult>m__1(bool ));
    }
    private static void <OnLocaleLoaded>m__0(ISN_Locale )
    {
    
    }
    private static void <GuidedAccessSessionRequestResult>m__1(bool )
    {
    
    }

}
