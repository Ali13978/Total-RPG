using UnityEngine;
public class SA_Ad_EditorUIController : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject VideoPanel;
    public UnityEngine.GameObject InterstitialPanel;
    public UnityEngine.UI.Image[] AppIcons;
    public UnityEngine.UI.Text[] AppNames;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action<bool> OnCloseVideo;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action OnVideoLeftApplication;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action<bool> OnCloseInterstitial;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action OnInterstitialLeftApplication;
    private static System.Action<bool> <>f__am$cache0;
    private static System.Action <>f__am$cache1;
    private static System.Action<bool> <>f__am$cache2;
    private static System.Action <>f__am$cache3;
    
    // Methods
    public SA_Ad_EditorUIController()
    {
        var val_5;
        System.Action<System.Boolean> val_6;
        val_5 = null;
        if((SA_Ad_EditorUIController.<>f__am$cache0) == null)
        {
                System.Action<System.Boolean> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Action<System.Boolean>(object:  0, method:  static System.Void SA_Ad_EditorUIController::<OnCloseVideo>m__0(bool ));
            SA_Ad_EditorUIController.<>f__am$cache0 = val_6;
            val_5 = null;
        }
        
        this.OnCloseVideo = SA_Ad_EditorUIController.<>f__am$cache0;
        if((SA_Ad_EditorUIController.<>f__am$cache1) == null)
        {
                System.Action val_2 = null;
            val_6 = val_2;
            val_2 = new System.Action(object:  0, method:  static System.Void SA_Ad_EditorUIController::<OnVideoLeftApplication>m__1());
            SA_Ad_EditorUIController.<>f__am$cache1 = val_6;
        }
        
        this.OnVideoLeftApplication = SA_Ad_EditorUIController.<>f__am$cache1;
        if((SA_Ad_EditorUIController.<>f__am$cache2) == null)
        {
                System.Action<System.Boolean> val_3 = null;
            val_6 = val_3;
            val_3 = new System.Action<System.Boolean>(object:  0, method:  static System.Void SA_Ad_EditorUIController::<OnCloseInterstitial>m__2(bool ));
            SA_Ad_EditorUIController.<>f__am$cache2 = val_6;
        }
        
        this.OnCloseInterstitial = SA_Ad_EditorUIController.<>f__am$cache2;
        if((SA_Ad_EditorUIController.<>f__am$cache3) == null)
        {
                System.Action val_4 = null;
            val_6 = val_4;
            val_4 = new System.Action(object:  0, method:  static System.Void SA_Ad_EditorUIController::<OnInterstitialLeftApplication>m__3());
            SA_Ad_EditorUIController.<>f__am$cache3 = val_6;
        }
        
        this.OnInterstitialLeftApplication = SA_Ad_EditorUIController.<>f__am$cache3;
    }
    public void add_OnCloseVideo(System.Action<bool> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnCloseVideo);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510502562440 != this.OnCloseVideo);
    
    }
    public void remove_OnCloseVideo(System.Action<bool> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnCloseVideo);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510502699016 != this.OnCloseVideo);
    
    }
    public void add_OnVideoLeftApplication(System.Action value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnVideoLeftApplication);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510502835600 != this.OnVideoLeftApplication);
    
    }
    public void remove_OnVideoLeftApplication(System.Action value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnVideoLeftApplication);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510502972176 != this.OnVideoLeftApplication);
    
    }
    public void add_OnCloseInterstitial(System.Action<bool> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnCloseInterstitial);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510503108760 != this.OnCloseInterstitial);
    
    }
    public void remove_OnCloseInterstitial(System.Action<bool> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnCloseInterstitial);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510503245336 != this.OnCloseInterstitial);
    
    }
    public void add_OnInterstitialLeftApplication(System.Action value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnInterstitialLeftApplication);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510503381920 != this.OnInterstitialLeftApplication);
    
    }
    public void remove_OnInterstitialLeftApplication(System.Action value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnInterstitialLeftApplication);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510503518496 != this.OnInterstitialLeftApplication);
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        SA_EditorTesting.CheckForEventSystem();
        this.GetComponent<UnityEngine.Canvas>().sortingOrder = 17;
    }
    private void Start()
    {
    
    }
    public void InterstitialClick()
    {
        this.OnInterstitialLeftApplication.Invoke();
    }
    public void VideoClick()
    {
        this.OnVideoLeftApplication.Invoke();
    }
    public void ShowInterstitialAd()
    {
        this.gameObject.SetActive(value:  true);
        this.InterstitialPanel.SetActive(value:  true);
    }
    public void ShowVideoAd()
    {
        this.gameObject.SetActive(value:  true);
        this.VideoPanel.SetActive(value:  true);
    }
    public void CloseInterstitial()
    {
        this.gameObject.SetActive(value:  false);
        this.InterstitialPanel.SetActive(value:  false);
        this.OnCloseInterstitial.Invoke(obj:  true);
    }
    public void CloseVideo()
    {
        this.gameObject.SetActive(value:  false);
        this.VideoPanel.SetActive(value:  false);
        this.OnCloseVideo.Invoke(obj:  true);
    }
    private static void <OnCloseVideo>m__0(bool )
    {
    
    }
    private static void <OnVideoLeftApplication>m__1()
    {
    
    }
    private static void <OnCloseInterstitial>m__2(bool )
    {
    
    }
    private static void <OnInterstitialLeftApplication>m__3()
    {
    
    }

}
