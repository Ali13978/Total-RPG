using UnityEngine;
public class ISN_MediaController : Singleton<ISN_MediaController>
{
    // Fields
    private MP_MediaItem _NowPlayingItem;
    private MP_MusicPlaybackState _State;
    private System.Collections.Generic.List<MP_MediaItem> _CurrentQueue;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<MP_MediaPickerResult> ActionMediaPickerResult;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<MP_MediaPickerResult> ActionQueueUpdated;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<MP_MediaItem> ActionNowPlayingItemChanged;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<MP_MusicPlaybackState> ActionPlaybackStateChanged;
    
    // Properties
    public MP_MediaItem NowPlayingItem { get; }
    public System.Collections.Generic.List<MP_MediaItem> CurrentQueue { get; }
    public MP_MusicPlaybackState State { get; }
    
    // Methods
    public ISN_MediaController()
    {
        this._CurrentQueue = new System.Collections.Generic.List<MP_MediaItem>();
    }
    public static void add_ActionMediaPickerResult(System.Action<MP_MediaPickerResult> value)
    {
        var val_3;
        System.Action<MP_MediaPickerResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_MediaController.ActionMediaPickerResult;
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
    public static void remove_ActionMediaPickerResult(System.Action<MP_MediaPickerResult> value)
    {
        var val_3;
        System.Action<MP_MediaPickerResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_MediaController.ActionMediaPickerResult;
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
    public static void add_ActionQueueUpdated(System.Action<MP_MediaPickerResult> value)
    {
        var val_3;
        System.Action<MP_MediaPickerResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_MediaController.ActionQueueUpdated;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_MediaController.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504844709896 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionQueueUpdated(System.Action<MP_MediaPickerResult> value)
    {
        var val_3;
        System.Action<MP_MediaPickerResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_MediaController.ActionQueueUpdated;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_MediaController.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504844709896 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionNowPlayingItemChanged(System.Action<MP_MediaItem> value)
    {
        var val_3;
        System.Action<MP_MediaItem> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_MediaController.ActionNowPlayingItemChanged;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_MediaController.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504844709904 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionNowPlayingItemChanged(System.Action<MP_MediaItem> value)
    {
        var val_3;
        System.Action<MP_MediaItem> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_MediaController.ActionNowPlayingItemChanged;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_MediaController.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504844709904 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionPlaybackStateChanged(System.Action<MP_MusicPlaybackState> value)
    {
        var val_3;
        System.Action<MP_MusicPlaybackState> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_MediaController.ActionPlaybackStateChanged;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_MediaController.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504844709912 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionPlaybackStateChanged(System.Action<MP_MusicPlaybackState> value)
    {
        var val_3;
        System.Action<MP_MusicPlaybackState> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_MediaController.ActionPlaybackStateChanged;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_MediaController.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504844709912 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void SetRepeatMode(MP_MusicRepeatMode mode)
    {
    
    }
    public void SetShuffleMode(MP_MusicShuffleMode mode)
    {
    
    }
    public void Play()
    {
    
    }
    public void Pause()
    {
    
    }
    public void SkipToNextItem()
    {
    
    }
    public void SkipToBeginning()
    {
    
    }
    public void SkipToPreviousItem()
    {
    
    }
    public void ShowMediaPicker()
    {
    
    }
    public void SetCollection(MP_MediaItem[] items)
    {
        var val_3;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        val_3 = 0;
        goto label_1;
        label_7:
        Add(item:  X21);
        val_3 = 1;
        label_1:
        if(val_3 >= items.Length)
        {
            goto label_3;
        }
        
        MP_MediaItem val_3 = items[1];
        if(null != 0)
        {
            goto label_7;
        }
        
        goto label_7;
        label_3:
        T[] val_2 = ToArray();
    }
    public void AddItemWithProductID(string productID)
    {
    
    }
    public void SetCollection(string[] itemIds)
    {
    
    }
    public MP_MediaItem get_NowPlayingItem()
    {
        return (MP_MediaItem)this._NowPlayingItem;
    }
    public System.Collections.Generic.List<MP_MediaItem> get_CurrentQueue()
    {
        return (System.Collections.Generic.List<MP_MediaItem>)this._CurrentQueue;
    }
    public MP_MusicPlaybackState get_State()
    {
        return (MP_MusicPlaybackState)this._State;
    }
    private System.Collections.Generic.List<MP_MediaItem> ParseMediaItemsList(string[] data, int index = 0)
    {
        int val_5 = index;
        goto label_1;
        label_9:
        Add(item:  X22);
        val_5 = val_5 + 8;
        label_1:
        if(val_5 >= data.Length)
        {
                return (System.Collections.Generic.List<MP_MediaItem>)new System.Collections.Generic.List<MP_MediaItem>();
        }
        
        bool val_2 = System.String.op_Equality(a:  0, b:  data[(long)val_5]);
        if(val_2 == true)
        {
                return (System.Collections.Generic.List<MP_MediaItem>)new System.Collections.Generic.List<MP_MediaItem>();
        }
        
        MP_MediaItem val_4 = val_2.ParseMediaItemData(data:  data, index:  val_5);
        if(null != 0)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    private MP_MediaItem ParseMediaItemData(string[] data, int index)
    {
        int val_9 = data.Length;
        if(val_9 <= index)
        {
                val_9 = data.Length;
        }
        
        int val_1 = index + 1;
        if(val_1 >= val_9)
        {
                val_9 = data.Length;
        }
        
        int val_2 = index + 2;
        if(val_2 >= val_9)
        {
                val_9 = data.Length;
        }
        
        int val_3 = index + 3;
        if(val_3 >= val_9)
        {
                val_9 = data.Length;
        }
        
        int val_4 = index + 4;
        if(val_4 >= val_9)
        {
                val_9 = data.Length;
        }
        
        int val_5 = index + 5;
        if(val_5 >= val_9)
        {
                val_9 = data.Length;
        }
        
        int val_6 = index + 6;
        if(val_6 >= val_9)
        {
                val_9 = data.Length;
        }
        
        typeof(MP_MediaItem).__il2cppRuntimeField_10 = data[(long)index];
        typeof(MP_MediaItem).__il2cppRuntimeField_18 = data[(long)val_1];
        typeof(MP_MediaItem).__il2cppRuntimeField_20 = data[(long)val_2];
        typeof(MP_MediaItem).__il2cppRuntimeField_28 = data[(long)val_3];
        typeof(MP_MediaItem).__il2cppRuntimeField_30 = data[(long)val_4];
        typeof(MP_MediaItem).__il2cppRuntimeField_38 = data[(long)val_5];
        typeof(MP_MediaItem).__il2cppRuntimeField_40 = data[(long)val_6];
        typeof(MP_MediaItem).__il2cppRuntimeField_48 = data[(long)index + 7];
        return (MP_MediaItem)new System.Object();
    }
    private void OnQueueUpdate(string data)
    {
        var val_4;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.Collections.Generic.List<MP_MediaItem> val_2 = this.ParseMediaItemsList(data:  data.Split(separator:  null), index:  0);
        this._CurrentQueue = val_2;
        typeof(MP_MediaPickerResult).__il2cppRuntimeField_18 = val_2;
        val_4 = null;
        val_4 = null;
        ISN_MediaController.ActionQueueUpdated.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnQueueUpdateFailed(string errorData)
    {
        var val_2 = null;
        ISN_MediaController.ActionQueueUpdated.Invoke(obj:  new MP_MediaPickerResult(errorData:  errorData));
    }
    private void OnMediaPickerResult(string data)
    {
        var val_4;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.Collections.Generic.List<MP_MediaItem> val_2 = this.ParseMediaItemsList(data:  data.Split(separator:  null), index:  0);
        this._CurrentQueue = val_2;
        SA.Common.Models.Result val_3 = new SA.Common.Models.Result();
        typeof(MP_MediaPickerResult).__il2cppRuntimeField_18 = val_2;
        val_4 = null;
        val_4 = null;
        ISN_MediaController.ActionMediaPickerResult.Invoke(obj:  val_3);
        ISN_MediaController.ActionQueueUpdated.Invoke(obj:  val_3);
    }
    private void OnMediaPickerFailed(string errorData)
    {
        var val_2 = null;
        ISN_MediaController.ActionMediaPickerResult.Invoke(obj:  new MP_MediaPickerResult(errorData:  errorData));
    }
    private void OnNowPlayingItemchanged(string data)
    {
        MP_MediaItem val_3;
        var val_4;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = data.Split(separator:  null);
        val_3 = val_1.ParseMediaItemData(data:  val_1, index:  0);
        this._NowPlayingItem = val_3;
        val_4 = null;
        val_4 = null;
        val_3 = this._NowPlayingItem;
        ISN_MediaController.ActionNowPlayingItemChanged.Invoke(obj:  val_3);
    }
    private void OnPlaybackStateChanged(string state)
    {
        MP_MusicPlaybackState val_2;
        var val_3;
        val_2 = System.Convert.ToInt32(value:  0);
        this._State = val_2;
        val_3 = null;
        val_3 = null;
        val_2 = this._State;
        ISN_MediaController.ActionPlaybackStateChanged.Invoke(obj:  val_2);
    }
    private static ISN_MediaController()
    {
        ISN_MediaController.ActionMediaPickerResult = new System.Action<MP_MediaPickerResult>(object:  0, method:  static System.Void ISN_MediaController::<ActionMediaPickerResult>m__0(MP_MediaPickerResult ));
        ISN_MediaController.ActionQueueUpdated = new System.Action<MP_MediaPickerResult>(object:  0, method:  static System.Void ISN_MediaController::<ActionQueueUpdated>m__1(MP_MediaPickerResult ));
        ISN_MediaController.ActionNowPlayingItemChanged = new System.Action<MP_MediaItem>(object:  0, method:  static System.Void ISN_MediaController::<ActionNowPlayingItemChanged>m__2(MP_MediaItem ));
        ISN_MediaController.ActionPlaybackStateChanged = new System.Action<MP_MusicPlaybackState>(object:  0, method:  static System.Void ISN_MediaController::<ActionPlaybackStateChanged>m__3(MP_MusicPlaybackState ));
    }
    private static void <ActionMediaPickerResult>m__0(MP_MediaPickerResult )
    {
    
    }
    private static void <ActionQueueUpdated>m__1(MP_MediaPickerResult )
    {
    
    }
    private static void <ActionNowPlayingItemChanged>m__2(MP_MediaItem )
    {
    
    }
    private static void <ActionPlaybackStateChanged>m__3(MP_MusicPlaybackState )
    {
    
    }

}
