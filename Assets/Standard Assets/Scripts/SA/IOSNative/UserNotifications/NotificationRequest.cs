using UnityEngine;

namespace SA.IOSNative.UserNotifications
{
    public class NotificationRequest
    {
        // Fields
        private string _Id;
        private SA.IOSNative.UserNotifications.NotificationContent _Content;
        private SA.IOSNative.UserNotifications.NotificationTrigger _Trigger;
        
        // Properties
        public string Id { get; }
        public SA.IOSNative.UserNotifications.NotificationContent Content { get; }
        public SA.IOSNative.UserNotifications.NotificationTrigger Trigger { get; }
        
        // Methods
        public NotificationRequest()
        {
            null = null;
            this._Id = System.String.Empty;
        }
        public NotificationRequest(string id, SA.IOSNative.UserNotifications.NotificationContent content, SA.IOSNative.UserNotifications.NotificationTrigger trigger)
        {
            null = null;
            this._Id = System.String.Empty;
            val_1 = new System.Object();
            this._Id = id;
            this._Content = val_1;
            this._Trigger = trigger;
        }
        public NotificationRequest(string data)
        {
            var val_14;
            string val_15;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_16;
            var val_17;
            val_14 = null;
            val_14 = null;
            this._Id = System.String.Empty;
            if((SA.Common.Data.Json.Deserialize(json:  0)) != null)
            {
                
            }
            
            if(0.Item["id"] != null)
            {
                    if(null == null)
            {
                goto label_7;
            }
            
            }
            
            val_15 = 0;
            label_7:
            this._Id = val_15;
            val_16 = 0.Item["content"];
            val_16 = 0;
            val_17 = 0.Item["trigger"];
            val_17 = 0;
            SA.IOSNative.UserNotifications.NotificationContent val_12 = new SA.IOSNative.UserNotifications.NotificationContent(contentDictionary:  val_16);
            this._Content = val_12;
            this._Trigger = SA.IOSNative.UserNotifications.NotificationTrigger.triggerFromDictionary(triggerDictionary:  val_12 = new SA.IOSNative.UserNotifications.NotificationContent(contentDictionary:  val_16));
        }
        public string get_Id()
        {
            return (string)this._Id;
        }
        public SA.IOSNative.UserNotifications.NotificationContent get_Content()
        {
            return (SA.IOSNative.UserNotifications.NotificationContent)this._Content;
        }
        public SA.IOSNative.UserNotifications.NotificationTrigger get_Trigger()
        {
            return (SA.IOSNative.UserNotifications.NotificationTrigger)this._Trigger;
        }
    
    }

}
