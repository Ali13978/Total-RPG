using UnityEngine;
public class SA_EditorTestingSceneController : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Button ShowInterstitial_Button;
    public UnityEngine.UI.Button ShowInterstitial_Video;
    
    // Methods
    public SA_EditorTestingSceneController()
    {
    
    }
    public void LoadInterstitial()
    {
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.LoadInterstitial();
    }
    public void ShowInterstitial()
    {
        if((SA.Common.Pattern.Singleton<SA_EditorAd>.Instance) != null)
        {
                return;
        }
    
    }
    public void LoadVideo()
    {
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.LoadVideo();
    }
    public void ShowVideo()
    {
        if((SA.Common.Pattern.Singleton<SA_EditorAd>.Instance) != null)
        {
                return;
        }
    
    }
    public void Show_Notifications()
    {
        SA_EditorNotifications.ShowNotification(title:  null, message:  "Test", type:  "Test Notification Body");
    }
    public void Show_A_Notifications()
    {
        SA_EditorNotifications.ShowNotification(title:  null, message:  "Achievement", type:  "Test Notification Body");
    }
    public void Show_L_Notifications()
    {
        SA_EditorNotifications.ShowNotification(title:  null, message:  "Leaderboard", type:  "Test Notification Body");
    }
    public void Show_E_Notifications()
    {
        SA_EditorNotifications.ShowNotification(title:  null, message:  "Error", type:  "Test Notification Body");
    }
    public void Show_InApp_Popup()
    {
        SA_EditorInApps.ShowInAppPopup(title:  null, describtion:  "Product Title", price:  "Product Describtion", OnComplete:  "2.99$");
    }
    private void FixedUpdate()
    {
        var val_3;
        var val_4;
        SA_EditorAd val_1 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        if(val_1._IsInterstitialReady != false)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = 0;
        }
        
        this.ShowInterstitial_Button.interactable = false;
        SA_EditorAd val_2 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        if(val_2._IsVideoReady != false)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = 0;
        }
        
        this.ShowInterstitial_Video.interactable = false;
    }

}
