using UnityEngine;
public class ISN_ReplayKit : Singleton<ISN_ReplayKit>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> ActionRecordStarted;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> ActionRecordStoped;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<ReplayKitVideoShareResult> ActionShareDialogFinished;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Error> ActionRecordInterrupted;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<bool> ActionRecorderDidChangeAvailability;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action ActionRecordDiscard;
    private bool _IsRecodingAvailableToShare;
    
    // Properties
    public bool IsRecording { get; }
    public bool IsRecodingAvailableToShare { get; }
    public bool IsAvailable { get; }
    public bool IsMicEnabled { get; }
    
    // Methods
    public ISN_ReplayKit()
    {
    
    }
    public static void add_ActionRecordStarted(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_ReplayKit.ActionRecordStarted;
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
    public static void remove_ActionRecordStarted(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_ReplayKit.ActionRecordStarted;
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
    public static void add_ActionRecordStoped(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_ReplayKit.ActionRecordStoped;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_ReplayKit.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845082632 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionRecordStoped(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_ReplayKit.ActionRecordStoped;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_ReplayKit.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845082632 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionShareDialogFinished(System.Action<ReplayKitVideoShareResult> value)
    {
        var val_3;
        System.Action<ReplayKitVideoShareResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_ReplayKit.ActionShareDialogFinished;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_ReplayKit.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845082640 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionShareDialogFinished(System.Action<ReplayKitVideoShareResult> value)
    {
        var val_3;
        System.Action<ReplayKitVideoShareResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_ReplayKit.ActionShareDialogFinished;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_ReplayKit.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845082640 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionRecordInterrupted(System.Action<SA.Common.Models.Error> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Error> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_ReplayKit.ActionRecordInterrupted;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_ReplayKit.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845082648 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionRecordInterrupted(System.Action<SA.Common.Models.Error> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Error> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_ReplayKit.ActionRecordInterrupted;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_ReplayKit.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845082648 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionRecorderDidChangeAvailability(System.Action<bool> value)
    {
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_ReplayKit.ActionRecorderDidChangeAvailability;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_ReplayKit.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845082656 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionRecorderDidChangeAvailability(System.Action<bool> value)
    {
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_ReplayKit.ActionRecorderDidChangeAvailability;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_ReplayKit.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845082656 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionRecordDiscard(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_ReplayKit.ActionRecordDiscard;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_ReplayKit.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845082664 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionRecordDiscard(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_ReplayKit.ActionRecordDiscard;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_ReplayKit.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845082664 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void StartRecording(bool microphoneEnabled = True)
    {
        this._IsRecodingAvailableToShare = false;
    }
    public void StopRecording()
    {
    
    }
    public void DiscardRecording()
    {
        this._IsRecodingAvailableToShare = false;
    }
    public void ShowVideoShareDialog()
    {
        this._IsRecodingAvailableToShare = false;
    }
    public bool get_IsRecording()
    {
        return false;
    }
    public bool get_IsRecodingAvailableToShare()
    {
        return (bool)this._IsRecodingAvailableToShare;
    }
    public bool get_IsAvailable()
    {
        return false;
    }
    public bool get_IsMicEnabled()
    {
        return false;
    }
    private void OnRecorStartSuccess(string data)
    {
        var val_2 = null;
        ISN_ReplayKit.ActionRecordStarted.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnRecorStartFailed(string errorData)
    {
        var val_3 = null;
        ISN_ReplayKit.ActionRecordStarted.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  errorData)));
    }
    private void OnRecorStopFailed(string errorData)
    {
        var val_3 = null;
        ISN_ReplayKit.ActionRecordStoped.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  errorData)));
    }
    private void OnRecorStopSuccess()
    {
        var val_2;
        this._IsRecodingAvailableToShare = true;
        val_2 = null;
        val_2 = null;
        ISN_ReplayKit.ActionRecordStoped.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnRecordInterrupted(string errorData)
    {
        var val_2;
        this._IsRecodingAvailableToShare = false;
        val_2 = null;
        val_2 = null;
        ISN_ReplayKit.ActionRecordInterrupted.Invoke(obj:  new SA.Common.Models.Error(errorData:  errorData));
    }
    private void OnRecorderDidChangeAvailability(string data)
    {
        null = null;
        ISN_ReplayKit.ActionRecorderDidChangeAvailability.Invoke(obj:  false);
    }
    private void OnSaveResult(string sourcesData)
    {
        var val_3 = null;
        ISN_ReplayKit.ActionShareDialogFinished.Invoke(obj:  new ReplayKitVideoShareResult(sourcesArray:  SA.Common.Data.Converter.ParseArray(arrayData:  0, splitter:  sourcesData)));
    }
    public void OnRecordDiscard(string data)
    {
        var val_1;
        this._IsRecodingAvailableToShare = false;
        val_1 = null;
        val_1 = null;
        ISN_ReplayKit.ActionRecordDiscard.Invoke();
    }
    private static ISN_ReplayKit()
    {
        ISN_ReplayKit.ActionRecordStarted = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void ISN_ReplayKit::<ActionRecordStarted>m__0(SA.Common.Models.Result ));
        ISN_ReplayKit.ActionRecordStoped = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void ISN_ReplayKit::<ActionRecordStoped>m__1(SA.Common.Models.Result ));
        ISN_ReplayKit.ActionShareDialogFinished = new System.Action<ReplayKitVideoShareResult>(object:  0, method:  static System.Void ISN_ReplayKit::<ActionShareDialogFinished>m__2(ReplayKitVideoShareResult ));
        ISN_ReplayKit.ActionRecordInterrupted = new System.Action<SA.Common.Models.Error>(object:  0, method:  static System.Void ISN_ReplayKit::<ActionRecordInterrupted>m__3(SA.Common.Models.Error ));
        ISN_ReplayKit.ActionRecorderDidChangeAvailability = new System.Action<System.Boolean>(object:  0, method:  static System.Void ISN_ReplayKit::<ActionRecorderDidChangeAvailability>m__4(bool ));
        ISN_ReplayKit.ActionRecordDiscard = new System.Action(object:  0, method:  static System.Void ISN_ReplayKit::<ActionRecordDiscard>m__5());
    }
    private static void <ActionRecordStarted>m__0(SA.Common.Models.Result )
    {
    
    }
    private static void <ActionRecordStoped>m__1(SA.Common.Models.Result )
    {
    
    }
    private static void <ActionShareDialogFinished>m__2(ReplayKitVideoShareResult )
    {
    
    }
    private static void <ActionRecordInterrupted>m__3(SA.Common.Models.Error )
    {
    
    }
    private static void <ActionRecorderDidChangeAvailability>m__4(bool )
    {
    
    }
    private static void <ActionRecordDiscard>m__5()
    {
    
    }

}
