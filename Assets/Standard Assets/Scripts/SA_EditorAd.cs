using UnityEngine;
public class SA_EditorAd : Singleton<SA_EditorAd>
{
    // Fields
    public const float MIN_LOAD_TIME = 1;
    public const float MAX_LOAD_TIME = 3;
    private bool _IsInterstitialLoading;
    private bool _IsVideoLoading;
    private bool _IsInterstitialReady;
    private bool _IsVideoReady;
    private int _FillRate;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<bool> OnInterstitialFinished;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<bool> OnInterstitialLoadComplete;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action OnInterstitialLeftApplication;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<bool> OnVideoFinished;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<bool> OnVideoLoadComplete;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action OnVideoLeftApplication;
    private SA_Ad_EditorUIController _EditorUI;
    
    // Properties
    public bool IsVideoReady { get; }
    public bool IsVideoLoading { get; }
    public bool IsInterstitialReady { get; }
    public bool IsInterstitialLoading { get; }
    public bool HasFill { get; }
    public int FillRate { get; }
    private SA_Ad_EditorUIController EditorUI { get; }
    
    // Methods
    public SA_EditorAd()
    {
        this._FillRate = 100;
    }
    public static void add_OnInterstitialFinished(System.Action<bool> value)
    {
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SA_EditorAd.OnInterstitialFinished;
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
    public static void remove_OnInterstitialFinished(System.Action<bool> value)
    {
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SA_EditorAd.OnInterstitialFinished;
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
    public static void add_OnInterstitialLoadComplete(System.Action<bool> value)
    {
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SA_EditorAd.OnInterstitialLoadComplete;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SA_EditorAd.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504853762056 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnInterstitialLoadComplete(System.Action<bool> value)
    {
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SA_EditorAd.OnInterstitialLoadComplete;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SA_EditorAd.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504853762056 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnInterstitialLeftApplication(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SA_EditorAd.OnInterstitialLeftApplication;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SA_EditorAd.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504853762064 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnInterstitialLeftApplication(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SA_EditorAd.OnInterstitialLeftApplication;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SA_EditorAd.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504853762064 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnVideoFinished(System.Action<bool> value)
    {
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SA_EditorAd.OnVideoFinished;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SA_EditorAd.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504853762072 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnVideoFinished(System.Action<bool> value)
    {
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SA_EditorAd.OnVideoFinished;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SA_EditorAd.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504853762072 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnVideoLoadComplete(System.Action<bool> value)
    {
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SA_EditorAd.OnVideoLoadComplete;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SA_EditorAd.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504853762080 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnVideoLoadComplete(System.Action<bool> value)
    {
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SA_EditorAd.OnVideoLoadComplete;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SA_EditorAd.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504853762080 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnVideoLeftApplication(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SA_EditorAd.OnVideoLeftApplication;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SA_EditorAd.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504853762088 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnVideoLeftApplication(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = SA_EditorAd.OnVideoLeftApplication;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = SA_EditorAd.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504853762088 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void SetFillRate(int fillRate)
    {
        this._FillRate = fillRate;
    }
    public void LoadInterstitial()
    {
        bool val_2 = this._IsInterstitialLoading;
        val_2 = val_2 & 16711935;
        if(val_2 != false)
        {
                return;
        }
        
        this._IsInterstitialLoading = true;
        this.Invoke(methodName:  "OnInterstitialRequestComplete", time:  UnityEngine.Random.Range(min:  1f, max:  3f));
    }
    public void ShowInterstitial()
    {
    
    }
    public void LoadVideo()
    {
        if(this._IsVideoLoading == true)
        {
                return;
        }
        
        if(this._IsVideoReady != false)
        {
                return;
        }
        
        this._IsVideoLoading = true;
        this.Invoke(methodName:  "OnVideoRequestComplete", time:  UnityEngine.Random.Range(min:  1f, max:  3f));
    }
    public void ShowVideo()
    {
    
    }
    public bool get_IsVideoReady()
    {
        return (bool)this._IsVideoReady;
    }
    public bool get_IsVideoLoading()
    {
        return (bool)this._IsVideoLoading;
    }
    public bool get_IsInterstitialReady()
    {
        return (bool)this._IsInterstitialReady;
    }
    public bool get_IsInterstitialLoading()
    {
        return (bool)this._IsInterstitialLoading;
    }
    public bool get_HasFill()
    {
        return (bool)((UnityEngine.Random.Range(min:  0, max:  1)) <= this._FillRate) ? 1 : 0;
    }
    public int get_FillRate()
    {
        return (int)this._FillRate;
    }
    private SA_Ad_EditorUIController get_EditorUI()
    {
        return (SA_Ad_EditorUIController)this._EditorUI;
    }
    private void OnVideoRequestComplete()
    {
        bool val_4;
        var val_5;
        this._IsVideoLoading = false;
        this._IsVideoReady = ((UnityEngine.Random.Range(min:  0, max:  1)) <= this._FillRate) ? 1 : 0;
        val_5 = null;
        val_5 = null;
        val_4 = this._IsVideoReady;
        SA_EditorAd.OnVideoLoadComplete.Invoke(obj:  (val_4 == true) ? 1 : 0);
    }
    private void OnInterstitialRequestComplete()
    {
        bool val_4;
        var val_5;
        this._IsInterstitialLoading = false;
        this._IsInterstitialReady = ((UnityEngine.Random.Range(min:  0, max:  1)) <= this._FillRate) ? 1 : 0;
        val_5 = null;
        val_5 = null;
        val_4 = this._IsInterstitialReady;
        SA_EditorAd.OnInterstitialLoadComplete.Invoke(obj:  (val_4 == true) ? 1 : 0);
    }
    private void OnInterstitialFinished_UIEvent(bool IsRewarded)
    {
        var val_1;
        this._IsInterstitialReady = false;
        val_1 = null;
        val_1 = null;
        IsRewarded = IsRewarded;
        SA_EditorAd.OnInterstitialFinished.Invoke(obj:  IsRewarded);
    }
    private void OnVideoFinished_UIEvent(bool IsRewarded)
    {
        var val_1;
        this._IsVideoReady = false;
        val_1 = null;
        val_1 = null;
        IsRewarded = IsRewarded;
        SA_EditorAd.OnVideoFinished.Invoke(obj:  IsRewarded);
    }
    private void OnInterstitialLeftApplication_UIEvent()
    {
        null = null;
        SA_EditorAd.OnInterstitialLeftApplication.Invoke();
    }
    private void OnVideoLeftApplication_UIEvent()
    {
        null = null;
        SA_EditorAd.OnVideoLeftApplication.Invoke();
    }
    private static SA_EditorAd()
    {
        SA_EditorAd.OnInterstitialFinished = new System.Action<System.Boolean>(object:  0, method:  static System.Void SA_EditorAd::<OnInterstitialFinished>m__0(bool ));
        SA_EditorAd.OnInterstitialLoadComplete = new System.Action<System.Boolean>(object:  0, method:  static System.Void SA_EditorAd::<OnInterstitialLoadComplete>m__1(bool ));
        SA_EditorAd.OnInterstitialLeftApplication = new System.Action(object:  0, method:  static System.Void SA_EditorAd::<OnInterstitialLeftApplication>m__2());
        SA_EditorAd.OnVideoFinished = new System.Action<System.Boolean>(object:  0, method:  static System.Void SA_EditorAd::<OnVideoFinished>m__3(bool ));
        SA_EditorAd.OnVideoLoadComplete = new System.Action<System.Boolean>(object:  0, method:  static System.Void SA_EditorAd::<OnVideoLoadComplete>m__4(bool ));
        SA_EditorAd.OnVideoLeftApplication = new System.Action(object:  0, method:  static System.Void SA_EditorAd::<OnVideoLeftApplication>m__5());
    }
    private static void <OnInterstitialFinished>m__0(bool )
    {
    
    }
    private static void <OnInterstitialLoadComplete>m__1(bool )
    {
    
    }
    private static void <OnInterstitialLeftApplication>m__2()
    {
    
    }
    private static void <OnVideoFinished>m__3(bool )
    {
    
    }
    private static void <OnVideoLoadComplete>m__4(bool )
    {
    
    }
    private static void <OnVideoLeftApplication>m__5()
    {
    
    }

}
