using UnityEngine;
public class AppEventHandlerExample : MonoBehaviour
{
    // Methods
    public AppEventHandlerExample()
    {
    
    }
    private void Awake()
    {
        SA.IOSNative.Core.AppController.Subscribe();
        System.Action val_1 = new System.Action(object:  this, method:  System.Void AppEventHandlerExample::OnApplicationDidReceiveMemoryWarning());
        SA.IOSNative.Core.AppController.add_OnApplicationDidReceiveMemoryWarning(value:  0);
        System.Action val_2 = new System.Action(object:  this, method:  System.Void AppEventHandlerExample::HandleOnApplicationDidBecomeActive());
        SA.IOSNative.Core.AppController.add_OnApplicationDidBecomeActive(value:  0);
        System.Action<SA.IOSNative.Models.LaunchUrl> val_3 = new System.Action<SA.IOSNative.Models.LaunchUrl>(object:  this, method:  System.Void AppEventHandlerExample::OnOpenURL(SA.IOSNative.Models.LaunchUrl url));
        SA.IOSNative.Core.AppController.add_OnOpenURL(value:  0);
        System.Action<SA.IOSNative.Models.UniversalLink> val_4 = new System.Action<SA.IOSNative.Models.UniversalLink>(object:  this, method:  System.Void AppEventHandlerExample::OnContinueUserActivity(SA.IOSNative.Models.UniversalLink link));
        SA.IOSNative.Core.AppController.add_OnContinueUserActivity(value:  0);
        this.Invoke(methodName:  "TryDetectURL", time:  2f);
    }
    private void TryDetectURL()
    {
        SA.IOSNative.Models.LaunchUrl val_1 = SA.IOSNative.Core.AppController.LaunchUrl;
        if(val_1.IsEmpty != true)
        {
                string val_4 = val_1.AbsoluteUrl;
            IOSMessage val_5 = IOSMessage.Create(title:  0, message:  "Open URL Detecetd");
        }
        
        SA.IOSNative.Models.UniversalLink val_6 = SA.IOSNative.Core.AppController.LaunchUniversalLink;
        if(val_6.IsEmpty != false)
        {
                return;
        }
        
        string val_9 = val_6.AbsoluteUrl;
        IOSMessage val_10 = IOSMessage.Create(title:  0, message:  "Launch Universal Link Detecetd");
    }
    private void OnContinueUserActivity(SA.IOSNative.Models.UniversalLink link)
    {
        string val_1 = link.AbsoluteUrl;
        IOSMessage val_2 = IOSMessage.Create(title:  0, message:  "Universal Link Detecetd");
    }
    private void OnDestroy()
    {
        System.Action val_1 = new System.Action(object:  this, method:  System.Void AppEventHandlerExample::OnApplicationDidReceiveMemoryWarning());
        SA.IOSNative.Core.AppController.remove_OnApplicationDidReceiveMemoryWarning(value:  0);
        System.Action val_2 = new System.Action(object:  this, method:  System.Void AppEventHandlerExample::HandleOnApplicationDidBecomeActive());
        SA.IOSNative.Core.AppController.remove_OnApplicationDidBecomeActive(value:  0);
        System.Action<SA.IOSNative.Models.LaunchUrl> val_3 = new System.Action<SA.IOSNative.Models.LaunchUrl>(object:  this, method:  System.Void AppEventHandlerExample::OnOpenURL(SA.IOSNative.Models.LaunchUrl url));
        SA.IOSNative.Core.AppController.remove_OnOpenURL(value:  0);
    }
    private void OnOpenURL(SA.IOSNative.Models.LaunchUrl url)
    {
        string val_1 = url.AbsoluteUrl;
        IOSMessage val_2 = IOSMessage.Create(title:  0, message:  "Open URL Detecetd");
    }
    private void HandleOnApplicationDidBecomeActive()
    {
        ISN_Logger.Log(message:  0, logType:  "Caught OnApplicationDidBecomeActive event");
    }
    private void OnApplicationDidReceiveMemoryWarning()
    {
        ISN_Logger.Log(message:  0, logType:  "Caught OnApplicationDidReceiveMemoryWarning event");
    }

}
