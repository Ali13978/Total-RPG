using UnityEngine;
public class IOSCamera : Singleton<IOSCamera>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<IOSImagePickResult> OnImagePicked;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnImageSaved;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<string> OnVideoPathPicked;
    private bool _IsWaitngForResponce;
    private bool _IsInitialized;
    
    // Methods
    public IOSCamera()
    {
    
    }
    public static void add_OnImagePicked(System.Action<IOSImagePickResult> value)
    {
        var val_3;
        System.Action<IOSImagePickResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSCamera.OnImagePicked;
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
    public static void remove_OnImagePicked(System.Action<IOSImagePickResult> value)
    {
        var val_3;
        System.Action<IOSImagePickResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSCamera.OnImagePicked;
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
    public static void add_OnImageSaved(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSCamera.OnImageSaved;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSCamera.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504844337160 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnImageSaved(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSCamera.OnImageSaved;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSCamera.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504844337160 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnVideoPathPicked(System.Action<string> value)
    {
        var val_3;
        System.Action<System.String> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSCamera.OnVideoPathPicked;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSCamera.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504844337168 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnVideoPathPicked(System.Action<string> value)
    {
        var val_3;
        System.Action<System.String> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSCamera.OnVideoPathPicked;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSCamera.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504844337168 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        if(this._IsInitialized == true)
        {
                return;
        }
        
        this._IsInitialized = true;
    }
    public void Init()
    {
        if(this._IsInitialized == true)
        {
                return;
        }
        
        this._IsInitialized = true;
    }
    public void SaveTextureToCameraRoll(UnityEngine.Texture2D texture)
    {
    
    }
    public void SaveScreenshotToCameraRoll()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.SaveScreenshot());
    }
    public void GetVideoPathFromAlbum()
    {
    
    }
    [System.ObsoleteAttribute]
    public void GetImageFromAlbum()
    {
        if(this._IsWaitngForResponce == true)
        {
                return;
        }
        
        this._IsWaitngForResponce = true;
    }
    [System.ObsoleteAttribute]
    public void GetImageFromCamera()
    {
        if(this._IsWaitngForResponce == true)
        {
                return;
        }
        
        this._IsWaitngForResponce = true;
    }
    public void PickImage(ISN_ImageSource source)
    {
        if(this._IsWaitngForResponce == true)
        {
                return;
        }
        
        this._IsWaitngForResponce = true;
    }
    private void OnImagePickedEvent(string data)
    {
        var val_2;
        this._IsWaitngForResponce = false;
        val_2 = null;
        val_2 = null;
        IOSCamera.OnImagePicked.Invoke(obj:  new IOSImagePickResult(ImageData:  data));
    }
    private void OnImageSaveFailed()
    {
        var val_3 = null;
        IOSCamera.OnImageSaved.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error()));
    }
    private void OnImageSaveSuccess()
    {
        var val_2 = null;
        IOSCamera.OnImageSaved.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnVideoPickedEvent(string path)
    {
        null = null;
        IOSCamera.OnVideoPathPicked.Invoke(obj:  path);
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator SaveScreenshot()
    {
        typeof(IOSCamera.<SaveScreenshot>c__Iterator0).__il2cppRuntimeField_20 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    private static IOSCamera()
    {
        IOSCamera.OnImagePicked = new System.Action<IOSImagePickResult>(object:  0, method:  static System.Void IOSCamera::<OnImagePicked>m__0(IOSImagePickResult ));
        IOSCamera.OnImageSaved = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void IOSCamera::<OnImageSaved>m__1(SA.Common.Models.Result ));
        IOSCamera.OnVideoPathPicked = new System.Action<System.String>(object:  0, method:  static System.Void IOSCamera::<OnVideoPathPicked>m__2(string ));
    }
    private static void <OnImagePicked>m__0(IOSImagePickResult )
    {
    
    }
    private static void <OnImageSaved>m__1(SA.Common.Models.Result )
    {
    
    }
    private static void <OnVideoPathPicked>m__2(string )
    {
    
    }

}
