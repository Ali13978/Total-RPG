using UnityEngine;
public class SA_Notifications_EditorUIController : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text Title;
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Image[] Icons;
    public SA_UIHightDependence HightDependence;
    private SA.Common.Animation.ValuesTween _CurrentTween;
    
    // Methods
    public SA_Notifications_EditorUIController()
    {
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        SA_EditorTesting.CheckForEventSystem();
        this.GetComponent<UnityEngine.Canvas>().sortingOrder = 17;
    }
    public void ShowNotification(string title, string message, SA_EditorNotificationType type)
    {
        var val_15;
        if(0 != this._CurrentTween)
        {
                this._CurrentTween.Stop();
        }
        
        this.CancelInvoke(methodName:  "NotificationDelayComplete");
        val_15 = 0;
        goto label_7;
        label_13:
        message.SetActive(value:  false);
        val_15 = 1;
        label_7:
        if(val_15 >= this.Icons.Length)
        {
            goto label_9;
        }
        
        if(this.Icons[1].gameObject != null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_9:
        if(((type < 4) ? (type + 8) : 0) > 11)
        {
                return;
        }
        
        var val_16 = 25809072 + (type < 0x4 ? (type + 8) : 0) << 2;
        val_16 = val_16 + 25809072;
        goto (25809072 + (type < 0x4 ? (type + 8) : 0) << 2 + 25809072);
    }
    private void HandleOnInTweenComplete()
    {
        this._CurrentTween = 0;
        this.Invoke(methodName:  "NotificationDelayComplete", time:  2f);
    }
    private void NotificationDelayComplete()
    {
        this.Animate(from:  -52f, to:  58f, easeType:  26);
        this._CurrentTween.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void SA_Notifications_EditorUIController::HandleOnOutTweenComplete()));
    }
    private void HandleOnOutTweenComplete()
    {
        this._CurrentTween = 0;
    }
    private void HandleOnValueChanged(float pos)
    {
    
    }
    private void Animate(float from, float to, SA.Common.Animation.EaseType easeType)
    {
        SA.Common.Animation.ValuesTween val_1 = SA.Common.Animation.ValuesTween.Create();
        this._CurrentTween = val_1;
        val_1.add_OnValueChanged(value:  new System.Action<System.Single>(object:  this, method:  System.Void SA_Notifications_EditorUIController::HandleOnValueChanged(float pos)));
        this._CurrentTween.ValueTo(from:  from, to:  to, time:  0.5f, easeType:  easeType);
    }

}
