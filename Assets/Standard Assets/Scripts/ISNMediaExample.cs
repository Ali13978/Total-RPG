using UnityEngine;
public class ISNMediaExample : BaseIOSFeaturePreview
{
    // Methods
    public ISNMediaExample()
    {
    
    }
    private void Awake()
    {
        System.Action<MP_MediaPickerResult> val_1 = new System.Action<MP_MediaPickerResult>(object:  this, method:  System.Void ISNMediaExample::HandleActionQueueUpdated(MP_MediaPickerResult res));
        ISN_MediaController.add_ActionQueueUpdated(value:  null);
        ISN_MediaController.add_ActionMediaPickerResult(value:  new System.Action<MP_MediaPickerResult>(object:  this, method:  System.Void ISNMediaExample::HandleActionMediaPickerResult(MP_MediaPickerResult res)) = new System.Action<MP_MediaPickerResult>(object:  this, method:  System.Void ISNMediaExample::HandleActionMediaPickerResult(MP_MediaPickerResult res)));
        ISN_MediaController.add_ActionPlaybackStateChanged(value:  new System.Action<MP_MusicPlaybackState>(object:  this, method:  System.Void ISNMediaExample::HandleActionPlaybackStateChanged(MP_MusicPlaybackState state)) = new System.Action<MP_MusicPlaybackState>(object:  this, method:  System.Void ISNMediaExample::HandleActionPlaybackStateChanged(MP_MusicPlaybackState state)));
        ISN_MediaController.add_ActionNowPlayingItemChanged(value:  new System.Action<MP_MediaItem>(object:  this, method:  System.Void ISNMediaExample::HandleActionNowPlayingItemChanged(MP_MediaItem item)) = new System.Action<MP_MediaItem>(object:  this, method:  System.Void ISNMediaExample::HandleActionNowPlayingItemChanged(MP_MediaItem item)));
    }
    private void HandleActionNowPlayingItemChanged(MP_MediaItem item)
    {
        SA_EditorAd val_1 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        string val_2 = 0 + "Now Playing Item Changed: "("Now Playing Item Changed: ");
        ISN_Logger.Log(message:  val_2, logType:  val_2);
    }
    private void HandleActionPlaybackStateChanged(MP_MusicPlaybackState state)
    {
        SA_EditorAd val_1 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        string val_2 = val_1._EditorUI.ToString();
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        string val_4 = 0 + "Playback State Changed: "("Playback State Changed: ");
        ISN_Logger.Log(message:  val_4, logType:  val_4);
    }
    private void HandleActionQueueUpdated(MP_MediaPickerResult res)
    {
        string val_10;
        var val_11;
        var val_12;
        if(res == null)
        {
            goto label_1;
        }
        
        if(res.IsSucceeded == true)
        {
            goto label_2;
        }
        
        goto label_4;
        label_1:
        if(0.IsSucceeded == false)
        {
            goto label_4;
        }
        
        label_2:
        List.Enumerator<T> val_4 = res._SelectedmediaItems.GetEnumerator();
        label_11:
        if((0 & 1) == 0)
        {
            goto label_6;
        }
        
        if(0.InitializationCallback != null)
        {
            
        }
        else
        {
                val_10 = 7254272;
        }
        
        string val_6 = 0 + "Item: "("Item: ") + val_10 + " / "(" / ");
        ISN_Logger.Log(message:  val_6, logType:  val_6);
        goto label_11;
        label_4:
        val_11 = res.Error.Message;
        string val_9 = 0 + "Queue Updated failed: "("Queue Updated failed: ");
        ISN_Logger.Log(message:  val_9, logType:  val_9);
        return;
        label_6:
        val_11 = 0;
        val_12 = 1;
        0.Dispose();
        if((val_12 & 1) != 0)
        {
                return;
        }
        
        if(val_11 == 0)
        {
                return;
        }
    
    }
    private void HandleActionMediaPickerResult(MP_MediaPickerResult res)
    {
        var val_5;
        var val_6;
        UnityEngine.LogType val_7;
        val_5 = res;
        val_6 = val_5;
        if(val_6.IsSucceeded != false)
        {
                val_7 = "Media piacker Succeeded";
        }
        else
        {
                val_5 = val_5.Error.Message;
            string val_4 = 0 + "Media piacker failed: "("Media piacker failed: ");
            val_7 = val_4;
        }
        
        ISN_Logger.Log(message:  val_4, logType:  val_7);
    }
    private void OnGUI()
    {
        this.UpdateToStartPos();
        int val_1 = UnityEngine.Screen.width;
        float val_24 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_24, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Selecting Songs");
        val_24 = val_24 + 0f;
        mem[1152921510391884072] = val_24;
        float val_25 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_25, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_3 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        val_25 = 0f + val_25;
        mem[1152921510391884076] = val_25;
        float val_26 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_26, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_5 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
            ISN_Logger.Log(message:  SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.Item[0], logType:  val_7._Title);
            typeof(MP_MediaItem[]).__il2cppRuntimeField_20 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.Item[0];
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.SetCollection(items:  null);
            SA_EditorAd val_11 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        mem[1152921510391884076] = MP_MediaItem[].__il2cppRuntimeField_namespaze;
        val_26 = val_26 + 0f;
        mem[1152921510391884072] = val_26 + 0f;
        int val_13 = UnityEngine.Screen.width;
        float val_27 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_27, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Controling Playback");
        val_27 = val_27 + 0f;
        mem[1152921510391884072] = val_27;
        float val_28 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_28, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_15 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        val_28 = 0f + val_28;
        mem[1152921510391884076] = val_28;
        float val_29 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_29, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_17 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        val_29 = 0f + val_29;
        mem[1152921510391884076] = 1152921510391187216;
        mem[1152921510391884072] = val_29;
        float val_30 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_30, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_19 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        val_30 = 0f + val_30;
        mem[1152921510391884076] = val_30;
        float val_31 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_31, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_21 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        val_31 = 0f + val_31;
        mem[1152921510391884076] = val_31;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        if((SA.Common.Pattern.Singleton<SA_EditorAd>.Instance) != null)
        {
                return;
        }
    
    }

}
