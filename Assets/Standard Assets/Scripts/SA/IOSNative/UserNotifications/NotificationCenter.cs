using UnityEngine;

namespace SA.IOSNative.UserNotifications
{
    public static class NotificationCenter
    {
        // Fields
        private static System.Collections.Generic.Dictionary<string, System.Action<SA.Common.Models.Result>> OnCallbackDictionary;
        private static System.Action<System.Collections.Generic.List<SA.IOSNative.UserNotifications.NotificationRequest>> OnPendingNotificationsCallback;
        private static System.Action<SA.Common.Models.Result> RequestPermissionsCallback;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<SA.IOSNative.UserNotifications.NotificationRequest> OnWillPresentNotification;
        public static SA.IOSNative.UserNotifications.NotificationRequest LastNotificationRequest;
        
        // Properties
        public static SA.IOSNative.UserNotifications.NotificationRequest LaunchNotification { get; }
        
        // Methods
        private static NotificationCenter()
        {
            SA.IOSNative.UserNotifications.NotificationCenter.OnWillPresentNotification = new System.Action<SA.IOSNative.UserNotifications.NotificationRequest>(object:  0, method:  static System.Void SA.IOSNative.UserNotifications.NotificationCenter::<OnWillPresentNotification>m__0(SA.IOSNative.UserNotifications.NotificationRequest ));
            SA_EditorAd val_2 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
            SA.IOSNative.UserNotifications.NotificationCenter.OnCallbackDictionary = new System.Collections.Generic.Dictionary<System.String, System.Action<SA.Common.Models.Result>>();
        }
        public static void add_OnWillPresentNotification(System.Action<SA.IOSNative.UserNotifications.NotificationRequest> value)
        {
            var val_3;
            System.Action<SA.IOSNative.UserNotifications.NotificationRequest> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.UserNotifications.NotificationCenter.OnWillPresentNotification;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.UserNotifications.NotificationCenter.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504845934616 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnWillPresentNotification(System.Action<SA.IOSNative.UserNotifications.NotificationRequest> value)
        {
            var val_3;
            System.Action<SA.IOSNative.UserNotifications.NotificationRequest> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.UserNotifications.NotificationCenter.OnWillPresentNotification;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.UserNotifications.NotificationCenter.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504845934616 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void RequestPermissions(System.Action<SA.Common.Models.Result> callback)
        {
            null = null;
            SA.IOSNative.UserNotifications.NotificationCenter.RequestPermissionsCallback = X1;
        }
        public static void AddNotificationRequest(SA.IOSNative.UserNotifications.NotificationRequest request, System.Action<SA.Common.Models.Result> callback)
        {
            string val_3;
            var val_4;
            if(callback != null)
            {
                
            }
            else
            {
                    val_3 = 11993091;
            }
            
            val_4 = null;
            val_4 = null;
            SA.IOSNative.UserNotifications.NotificationCenter.OnCallbackDictionary.set_Item(key:  val_3, value:  X2);
            string val_2 = 0 + "{" + System.String.Format(format:  0, arg0:  "\"id\" : \"{0}\", \"content\" : {1}, \"trigger\" : {2}", arg1:  val_3, arg2:  X2)(System.String.Format(format:  0, arg0:  "\"id\" : \"{0}\", \"content\" : {1}, \"trigger\" : {2}", arg1:  val_3, arg2:  X2));
        }
        private static void ScheduleUserNotification(string notificationJSONData)
        {
        
        }
        public static void CancelAllNotifications()
        {
        
        }
        public static void CancelUserNotificationById(string nId)
        {
        
        }
        public static void GetPendingNotificationRequests(System.Action<System.Collections.Generic.List<SA.IOSNative.UserNotifications.NotificationRequest>> callback)
        {
            null = null;
            SA.IOSNative.UserNotifications.NotificationCenter.OnPendingNotificationsCallback = X1;
        }
        public static SA.IOSNative.UserNotifications.NotificationRequest get_LaunchNotification()
        {
            return SA.IOSNative.Core.AppController.LaunchNotification;
        }
        internal static void RequestPermissionsResponse(string dataString)
        {
            SA.Common.Models.Result val_5;
            var val_6;
            if((X1.Equals(value:  "success")) != false)
            {
                    object val_2 = null;
                val_5 = val_2;
                val_2 = new System.Object();
            }
            else
            {
                    object val_4 = null;
                val_5 = val_4;
                val_4 = new System.Object();
                typeof(SA.Common.Models.Result).__il2cppRuntimeField_10 = new SA.Common.Models.Error();
            }
            
            val_6 = null;
            val_6 = null;
            SA.IOSNative.UserNotifications.NotificationCenter.RequestPermissionsCallback.Invoke(obj:  val_5);
        }
        internal static void AddNotificationRequestResponse(string dataString)
        {
            int val_7;
            SA.Common.Models.Result val_8;
            var val_9;
            typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
            System.String[] val_1 = X1.Split(separator:  null, options:  0);
            val_7 = val_1.Length;
            if(val_7 == 0)
            {
                    val_7 = val_1.Length;
            }
            
            string val_8 = val_1[1];
            if((val_8.Equals(value:  "success")) != false)
            {
                    object val_3 = null;
                val_8 = val_3;
                val_3 = new System.Object();
            }
            else
            {
                    object val_5 = null;
                val_8 = val_5;
                val_5 = new System.Object();
                typeof(SA.Common.Models.Result).__il2cppRuntimeField_10 = new SA.Common.Models.Error(errorData:  val_8);
            }
            
            val_9 = null;
            val_9 = null;
            System.Action<SA.Common.Models.Result> val_6 = SA.IOSNative.UserNotifications.NotificationCenter.OnCallbackDictionary.Item[val_1[0]];
            if(val_6 == null)
            {
                    return;
            }
            
            val_6.Invoke(obj:  val_8);
        }
        internal static void WillPresentNotification(string data)
        {
            var val_2 = null;
            SA.IOSNative.UserNotifications.NotificationCenter.OnWillPresentNotification.Invoke(obj:  new SA.IOSNative.UserNotifications.NotificationRequest(data:  X1));
        }
        internal static void PendingNotificationsRequestResponse(string data)
        {
            var val_7;
            var val_8;
            if(X1.Length < 1)
            {
                    return;
            }
            
            typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
            val_7 = 0;
            goto label_8;
            label_16:
            Add(item:  X22);
            val_7 = 1;
            label_8:
            if(val_7 >= val_2.Length)
            {
                goto label_14;
            }
            
            if((System.String.op_Equality(a:  0, b:  X1.Split(separator:  null, options:  0)[1])) == true)
            {
                goto label_14;
            }
            
            SA.IOSNative.UserNotifications.NotificationRequest val_6 = new SA.IOSNative.UserNotifications.NotificationRequest(data:  X1);
            if(null != 0)
            {
                goto label_16;
            }
            
            goto label_16;
            label_14:
            val_8 = null;
            val_8 = null;
            SA.IOSNative.UserNotifications.NotificationCenter.OnPendingNotificationsCallback.Invoke(obj:  new System.Collections.Generic.List<SA.IOSNative.UserNotifications.NotificationRequest>());
        }
        internal static void SetLastNotifification(string data)
        {
            var val_2 = null;
            SA.IOSNative.UserNotifications.NotificationCenter.LastNotificationRequest = new SA.IOSNative.UserNotifications.NotificationRequest(data:  X1);
        }
        private static void <OnWillPresentNotification>m__0(SA.IOSNative.UserNotifications.NotificationRequest )
        {
        
        }
    
    }

}
