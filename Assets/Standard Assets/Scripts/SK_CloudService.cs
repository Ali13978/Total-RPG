using UnityEngine;
public class SK_CloudService : Singleton<SK_CloudService>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SK_AuthorizationResult> OnAuthorizationFinished;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SK_RequestCapabilitieResult> OnCapabilitiesRequestFinished;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SK_RequestStorefrontIdentifierResult> OnStorefrontIdentifierRequestFinished;
    
    // Properties
    public static int AuthorizationStatus { get; }
    
    // Methods
    public SK_CloudService()
    {
    
    }
    public static void add_OnAuthorizationFinished(System.Action<SK_AuthorizationResult> value)
    {
        var val_3;
        System.Action<SK_AuthorizationResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SK_CloudService.OnAuthorizationFinished;
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
    public static void remove_OnAuthorizationFinished(System.Action<SK_AuthorizationResult> value)
    {
        var val_3;
        System.Action<SK_AuthorizationResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SK_CloudService.OnAuthorizationFinished;
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
    public static void add_OnCapabilitiesRequestFinished(System.Action<SK_RequestCapabilitieResult> value)
    {
        var val_3;
        System.Action<SK_RequestCapabilitieResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SK_CloudService.OnCapabilitiesRequestFinished;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SK_CloudService.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504847159304 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnCapabilitiesRequestFinished(System.Action<SK_RequestCapabilitieResult> value)
    {
        var val_3;
        System.Action<SK_RequestCapabilitieResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SK_CloudService.OnCapabilitiesRequestFinished;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SK_CloudService.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504847159304 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnStorefrontIdentifierRequestFinished(System.Action<SK_RequestStorefrontIdentifierResult> value)
    {
        var val_3;
        System.Action<SK_RequestStorefrontIdentifierResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SK_CloudService.OnStorefrontIdentifierRequestFinished;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SK_CloudService.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504847159312 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnStorefrontIdentifierRequestFinished(System.Action<SK_RequestStorefrontIdentifierResult> value)
    {
        var val_3;
        System.Action<SK_RequestStorefrontIdentifierResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SK_CloudService.OnStorefrontIdentifierRequestFinished;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SK_CloudService.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504847159312 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void RequestAuthorization()
    {
    
    }
    public void RequestCapabilities()
    {
    
    }
    public void RequestStorefrontIdentifier()
    {
    
    }
    public static int get_AuthorizationStatus()
    {
        return 0;
    }
    private void Event_AuthorizationFinished(string data)
    {
        var val_3;
        typeof(SK_AuthorizationResult).__il2cppRuntimeField_18 = System.Convert.ToInt32(value:  0);
        val_3 = null;
        val_3 = null;
        SK_CloudService.OnAuthorizationFinished.Invoke(obj:  new System.Object());
    }
    private void Event_RequestCapabilitieSsuccess(string data)
    {
        var val_3;
        typeof(SK_RequestCapabilitieResult).__il2cppRuntimeField_18 = System.Convert.ToInt32(value:  0);
        val_3 = null;
        val_3 = null;
        SK_CloudService.OnCapabilitiesRequestFinished.Invoke(obj:  new System.Object());
    }
    private void Event_RequestCapabilitiesFailed(string errorData)
    {
        var val_2 = null;
        SK_CloudService.OnCapabilitiesRequestFinished.Invoke(obj:  new SK_RequestCapabilitieResult(errorData:  errorData));
    }
    private void Event_RequestStorefrontIdentifierSsuccess(string storefrontIdentifier)
    {
        var val_2;
        typeof(SK_RequestStorefrontIdentifierResult).__il2cppRuntimeField_18 = storefrontIdentifier;
        val_2 = null;
        val_2 = null;
        SK_CloudService.OnStorefrontIdentifierRequestFinished.Invoke(obj:  new SK_RequestStorefrontIdentifierResult());
    }
    private void Event_RequestStorefrontIdentifierFailed(string errorData)
    {
        var val_2 = null;
        SK_CloudService.OnStorefrontIdentifierRequestFinished.Invoke(obj:  new SK_RequestStorefrontIdentifierResult(errorData:  errorData));
    }
    private static SK_CloudService()
    {
        SK_CloudService.OnAuthorizationFinished = new System.Action<SK_AuthorizationResult>(object:  0, method:  static System.Void SK_CloudService::<OnAuthorizationFinished>m__0(SK_AuthorizationResult ));
        SK_CloudService.OnCapabilitiesRequestFinished = new System.Action<SK_RequestCapabilitieResult>(object:  0, method:  static System.Void SK_CloudService::<OnCapabilitiesRequestFinished>m__1(SK_RequestCapabilitieResult ));
        SK_CloudService.OnStorefrontIdentifierRequestFinished = new System.Action<SK_RequestStorefrontIdentifierResult>(object:  0, method:  static System.Void SK_CloudService::<OnStorefrontIdentifierRequestFinished>m__2(SK_RequestStorefrontIdentifierResult ));
    }
    private static void <OnAuthorizationFinished>m__0(SK_AuthorizationResult )
    {
    
    }
    private static void <OnCapabilitiesRequestFinished>m__1(SK_RequestCapabilitieResult )
    {
    
    }
    private static void <OnStorefrontIdentifierRequestFinished>m__2(SK_RequestStorefrontIdentifierResult )
    {
    
    }

}
