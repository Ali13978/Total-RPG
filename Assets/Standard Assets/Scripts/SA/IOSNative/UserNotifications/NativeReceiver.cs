using UnityEngine;

namespace SA.IOSNative.UserNotifications
{
    public class NativeReceiver : Singleton<SA.IOSNative.UserNotifications.NativeReceiver>
    {
        // Methods
        public NativeReceiver()
        {
        
        }
        public void Init()
        {
        
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        private void RequestPermissionsCallbackEvent(string data)
        {
            SA.IOSNative.UserNotifications.NotificationCenter.RequestPermissionsResponse(dataString:  null);
        }
        private void AddNotificationRequestEvent(string data)
        {
            SA.IOSNative.UserNotifications.NotificationCenter.AddNotificationRequestResponse(dataString:  null);
        }
        private void WillPresentNotification(string data)
        {
            SA.IOSNative.UserNotifications.NotificationCenter.WillPresentNotification(data:  null);
        }
        private void PendingNotificationsRequest(string data)
        {
            SA.IOSNative.UserNotifications.NotificationCenter.PendingNotificationsRequestResponse(data:  null);
        }
        private void LaunchNotification(string data)
        {
            SA.IOSNative.UserNotifications.NotificationCenter.SetLastNotifification(data:  null);
        }
    
    }

}
