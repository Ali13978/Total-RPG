using UnityEngine;
public class SA_InApps_EditorUIController : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text Title;
    public UnityEngine.UI.Text Describtion;
    public UnityEngine.UI.Text Price;
    public UnityEngine.UI.Toggle IsSuccsesPurchase;
    public UnityEngine.UI.Image Fader;
    public SA_UIHightDependence HightDependence;
    private SA.Common.Animation.ValuesTween _CurrentTween;
    private SA.Common.Animation.ValuesTween _FaderTween;
    private System.Action<bool> _OnComplete;
    
    // Methods
    public SA_InApps_EditorUIController()
    {
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        this.GetComponent<UnityEngine.Canvas>().sortingOrder = 19;
    }
    public void ShowInAppPopup(string title, string describtion, string price, System.Action<bool> OnComplete)
    {
        if(0 != this._CurrentTween)
        {
                this._CurrentTween.Stop();
        }
        
        if(0 != this._FaderTween)
        {
                this._FaderTween.Stop();
        }
        
        this._OnComplete = OnComplete;
        this.Animate(from:  150f, to:  -300f, easeType:  27);
        this._CurrentTween.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void SA_InApps_EditorUIController::HandleOnInTweenComplete()));
        this.FadeIn();
    }
    public void Close()
    {
        System.Action val_6;
        if(0 != this._CurrentTween)
        {
                this._CurrentTween.Stop();
        }
        
        if(0 != this._FaderTween)
        {
                this._FaderTween.Stop();
        }
        
        this.Animate(from:  -300f, to:  150f, easeType:  26);
        System.Action val_3 = null;
        val_6 = val_3;
        val_3 = new System.Action(object:  this, method:  System.Void SA_InApps_EditorUIController::HandleOnOutTweenComplete());
        this._CurrentTween.add_OnComplete(value:  val_6);
        this.FadeOut();
        if(this._OnComplete == null)
        {
                return;
        }
        
        val_6 = this.IsSuccsesPurchase;
        this._OnComplete.Invoke(obj:  val_6.isOn);
        this._OnComplete = 0;
    }
    private void HandleOnInTweenComplete()
    {
        this._CurrentTween = 0;
    }
    private void HandleOnOutTweenComplete()
    {
        this._CurrentTween = 0;
    }
    private void HandleOnValueChanged(float pos)
    {
    
    }
    private void HandleOnFadeValueChanged(float a)
    {
        UnityEngine.Color val_1 = this.Fader.color;
        UnityEngine.Color val_2 = this.Fader.color;
        UnityEngine.Color val_3 = this.Fader.color;
        this.Fader.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private void HandleFadeComplete()
    {
        this.Fader.enabled = false;
    }
    private void FadeIn()
    {
        this.Fader.enabled = true;
        SA.Common.Animation.ValuesTween val_1 = SA.Common.Animation.ValuesTween.Create();
        this._FaderTween = val_1;
        val_1.add_OnValueChanged(value:  new System.Action<System.Single>(object:  this, method:  System.Void SA_InApps_EditorUIController::HandleOnFadeValueChanged(float a)));
        this._FaderTween.ValueTo(from:  0f, to:  0.5f, time:  0.5f, easeType:  21);
    }
    private void FadeOut()
    {
        SA.Common.Animation.ValuesTween val_1 = SA.Common.Animation.ValuesTween.Create();
        this._FaderTween = val_1;
        val_1.add_OnValueChanged(value:  new System.Action<System.Single>(object:  this, method:  System.Void SA_InApps_EditorUIController::HandleOnFadeValueChanged(float a)));
        this._FaderTween.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void SA_InApps_EditorUIController::HandleFadeComplete()));
        this._FaderTween.ValueTo(from:  0.5f, to:  0f, time:  0.5f, easeType:  21);
    }
    private void Animate(float from, float to, SA.Common.Animation.EaseType easeType)
    {
        SA.Common.Animation.ValuesTween val_1 = SA.Common.Animation.ValuesTween.Create();
        this._CurrentTween = val_1;
        val_1.add_OnValueChanged(value:  new System.Action<System.Single>(object:  this, method:  System.Void SA_InApps_EditorUIController::HandleOnValueChanged(float pos)));
        this._CurrentTween.ValueTo(from:  from, to:  to, time:  0.5f, easeType:  easeType);
    }

}
