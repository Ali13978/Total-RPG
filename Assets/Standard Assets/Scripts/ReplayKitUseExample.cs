using UnityEngine;
public class ReplayKitUseExample : BaseIOSFeaturePreview
{
    // Methods
    public ReplayKitUseExample()
    {
    
    }
    private void Awake()
    {
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void ReplayKitUseExample::HandleActionRecordStarted(SA.Common.Models.Result res));
        ISN_ReplayKit.add_ActionRecordStarted(value:  0);
        System.Action<SA.Common.Models.Result> val_2 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void ReplayKitUseExample::HandleActionRecordStoped(SA.Common.Models.Result res));
        ISN_ReplayKit.add_ActionRecordStoped(value:  0);
        System.Action<SA.Common.Models.Error> val_3 = new System.Action<SA.Common.Models.Error>(object:  this, method:  System.Void ReplayKitUseExample::HandleActionRecordInterrupted(SA.Common.Models.Error error));
        ISN_ReplayKit.add_ActionRecordInterrupted(value:  0);
        System.Action<ReplayKitVideoShareResult> val_4 = new System.Action<ReplayKitVideoShareResult>(object:  this, method:  System.Void ReplayKitUseExample::HandleActionShareDialogFinished(ReplayKitVideoShareResult res));
        ISN_ReplayKit.add_ActionShareDialogFinished(value:  0);
        System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  this, method:  System.Void ReplayKitUseExample::HandleActionRecorderDidChangeAvailability(bool IsRecordingAvaliable));
        ISN_ReplayKit.add_ActionRecorderDidChangeAvailability(value:  0);
        IOSNativePopUpManager.showMessage(title:  0, message:  "Welcome");
        bool val_8 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.IsAvailable;
        ISN_Logger.Log(message:  0, logType:  0 + "ReplayKit Is Avaliable: "("ReplayKit Is Avaliable: "));
    }
    private void OnDestroy()
    {
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void ReplayKitUseExample::HandleActionRecordStarted(SA.Common.Models.Result res));
        ISN_ReplayKit.remove_ActionRecordStarted(value:  0);
        System.Action<SA.Common.Models.Result> val_2 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void ReplayKitUseExample::HandleActionRecordStoped(SA.Common.Models.Result res));
        ISN_ReplayKit.remove_ActionRecordStoped(value:  0);
        System.Action<SA.Common.Models.Error> val_3 = new System.Action<SA.Common.Models.Error>(object:  this, method:  System.Void ReplayKitUseExample::HandleActionRecordInterrupted(SA.Common.Models.Error error));
        ISN_ReplayKit.remove_ActionRecordInterrupted(value:  0);
    }
    private void OnGUI()
    {
        this.UpdateToStartPos();
        int val_1 = UnityEngine.Screen.width;
        float val_6 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_6, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Replay Kit");
        val_6 = val_6 + 0f;
        mem[1152921510399757528] = val_6;
        float val_7 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_7, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.StartRecording(microphoneEnabled:  true);
        }
        
        val_7 = 0f + val_7;
        mem[1152921510399757532] = val_7;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        this = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        this.StopRecording();
    }
    private void HandleActionRecordInterrupted(SA.Common.Models.Error error)
    {
        string val_1 = error.Message;
        string val_2 = 0 + " ";
        IOSNativePopUpManager.showMessage(title:  0, message:  "Video was interrupted with error: ");
    }
    private void HandleActionRecordStoped(SA.Common.Models.Result res)
    {
        if(res.IsSucceeded != false)
        {
                SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.ShowVideoShareDialog();
            return;
        }
        
        string val_4 = res.Error.Message;
        string val_5 = 0 + "Error: "("Error: ");
        IOSNativePopUpManager.showMessage(title:  0, message:  "Fail");
    }
    private void HandleActionShareDialogFinished(ReplayKitVideoShareResult res)
    {
        var val_2;
        if(res._Sources.Length < 1)
        {
            goto label_3;
        }
        
        val_2 = 0;
        goto label_5;
        label_11:
        string val_1 = 0 + "User has shared the video to";
        IOSNativePopUpManager.showMessage(title:  0, message:  "Success");
        val_2 = 1;
        label_5:
        if(val_2 >= res._Sources.Length)
        {
                return;
        }
        
        string val_2 = res._Sources[1];
        goto label_11;
        label_3:
        IOSNativePopUpManager.showMessage(title:  0, message:  "Fail");
    }
    private void HandleActionRecordStarted(SA.Common.Models.Result res)
    {
        string val_9;
        if(res.IsSucceeded != false)
        {
                val_9 = "Success";
        }
        else
        {
                string val_3 = res.Error.Message;
            ISN_Logger.Log(message:  0, logType:  0 + "Record start failed: "("Record start failed: "));
            string val_6 = res.Error.Message;
            string val_7 = 0 + "Error: "("Error: ");
            val_9 = "Fail";
        }
        
        IOSNativePopUpManager.showMessage(title:  0, message:  val_9);
        System.Action<SA.Common.Models.Result> val_8 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void ReplayKitUseExample::HandleActionRecordStarted(SA.Common.Models.Result res));
        ISN_ReplayKit.remove_ActionRecordStarted(value:  0);
    }
    private void HandleActionRecorderDidChangeAvailability(bool IsRecordingAvaliable)
    {
        bool val_1 = IsRecordingAvaliable;
        ISN_Logger.Log(message:  0, logType:  0 + "Is Recording Avaliable: "("Is Recording Avaliable: "));
        System.Action val_3 = new System.Action(object:  this, method:  System.Void ReplayKitUseExample::HandleActionRecordDiscard());
        ISN_ReplayKit.add_ActionRecordDiscard(value:  0);
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.DiscardRecording();
    }
    private void HandleActionRecordDiscard()
    {
        ISN_Logger.Log(message:  0, logType:  "Record Discarded");
    }

}
