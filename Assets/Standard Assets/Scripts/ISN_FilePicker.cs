using UnityEngine;
public class ISN_FilePicker : Singleton<ISN_FilePicker>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<ISN_FilePickerResult> MediaPickFinished;
    
    // Methods
    public ISN_FilePicker()
    {
    
    }
    public static void add_MediaPickFinished(System.Action<ISN_FilePickerResult> value)
    {
        var val_3;
        System.Action<ISN_FilePickerResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_FilePicker.MediaPickFinished;
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
    public static void remove_MediaPickFinished(System.Action<ISN_FilePickerResult> value)
    {
        var val_3;
        System.Action<ISN_FilePickerResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_FilePicker.MediaPickFinished;
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
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void PickFromCameraRoll(int maxItemsCount = 0)
    {
    
    }
    private void OnSelectImagesComplete(string data)
    {
        UnityEngine.Texture2D val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = data;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        val_11 = null;
        val_11 = null;
        if((val_10.Equals(value:  System.String.Empty)) == true)
        {
            goto label_16;
        }
        
        val_12 = 0;
        goto label_10;
        label_24:
        System.String.Empty.Add(item:  val_10);
        val_12 = 1;
        label_10:
        if(val_12 >= val_1.Length)
        {
            goto label_16;
        }
        
        val_10 = val_10.Split(separator:  null, options:  0)[1];
        if((System.String.op_Equality(a:  0, b:  val_10)) == true)
        {
            goto label_16;
        }
        
        System.Byte[] val_7 = System.Convert.FromBase64String(s:  0);
        bool val_9 = UnityEngine.ImageConversion.LoadImage(tex:  0, data:  new UnityEngine.Texture2D(width:  1, height:  1));
        hideFlags = 52;
        if(ISN_FilePickerResult != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_16:
        val_13 = null;
        val_13 = null;
        ISN_FilePicker.MediaPickFinished.Invoke(obj:  new ISN_FilePickerResult());
    }
    private static ISN_FilePicker()
    {
        ISN_FilePicker.MediaPickFinished = new System.Action<ISN_FilePickerResult>(object:  0, method:  static System.Void ISN_FilePicker::<MediaPickFinished>m__0(ISN_FilePickerResult ));
    }
    private static void <MediaPickFinished>m__0(ISN_FilePickerResult )
    {
    
    }

}
