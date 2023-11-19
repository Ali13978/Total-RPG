using UnityEngine;

namespace SA.IOSNative.UserNotifications
{
    public abstract class NotificationTrigger
    {
        // Fields
        public bool repeated;
        
        // Properties
        public string Type { get; }
        
        // Methods
        protected NotificationTrigger()
        {
        
        }
        public static SA.IOSNative.UserNotifications.NotificationTrigger triggerFromDictionary(System.Collections.Generic.Dictionary<string, object> triggerDictionary)
        {
            var val_34;
            if((X1.ContainsKey(key:  "intervalToFire")) != false)
            {
                    object val_2 = X1.Item["intervalToFire"];
                object val_4 = null;
                val_34 = val_4;
                val_4 = new System.Object();
                typeof(SA.IOSNative.UserNotifications.TimeIntervalTrigger).__il2cppRuntimeField_14 = System.Int32.Parse(s:  0);
            }
            else
            {
                    if((X1.ContainsKey(key:  "year")) != false)
            {
                    object val_7 = X1.Item["year"];
                int val_8 = System.Int32.Parse(s:  0);
                typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_10 = 0;
            }
            
                if((X1.ContainsKey(key:  "month")) != false)
            {
                    object val_10 = X1.Item["month"];
                int val_11 = System.Int32.Parse(s:  0);
                typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_18 = 0;
            }
            
                if((X1.ContainsKey(key:  "day")) != false)
            {
                    object val_13 = X1.Item["day"];
                int val_14 = System.Int32.Parse(s:  0);
                typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_20 = 0;
            }
            
                if((X1.ContainsKey(key:  "hour")) != false)
            {
                    object val_16 = X1.Item["hour"];
                int val_17 = System.Int32.Parse(s:  0);
                typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_28 = 0;
            }
            
                if((X1.ContainsKey(key:  "minute")) != false)
            {
                    object val_19 = X1.Item["minute"];
                int val_20 = System.Int32.Parse(s:  0);
                typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_30 = 0;
            }
            
                if((X1.ContainsKey(key:  "second")) != false)
            {
                    object val_22 = X1.Item["second"];
                int val_23 = System.Int32.Parse(s:  0);
                typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_38 = 0;
            }
            
                if((X1.ContainsKey(key:  "weekday")) != false)
            {
                    object val_25 = X1.Item["weekday"];
                int val_26 = System.Int32.Parse(s:  0);
                typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_40 = 0;
            }
            
                if((X1.ContainsKey(key:  "quarter")) != false)
            {
                    object val_28 = X1.Item["quarter"];
                int val_29 = System.Int32.Parse(s:  0);
                typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_48 = 0;
            }
            
                object val_30 = null;
                val_34 = val_30;
                val_30 = new System.Object();
                typeof(SA.IOSNative.UserNotifications.CalendarTrigger).__il2cppRuntimeField_18 = new System.Object();
            }
            
            object val_31 = X1.Item["repeats"];
            typeof(SA.IOSNative.UserNotifications.CalendarTrigger).__il2cppRuntimeField_10 = ((System.Int32.Parse(s:  0)) == 1) ? 1 : 0;
            return (SA.IOSNative.UserNotifications.NotificationTrigger)val_34;
        }
        public void SetRepeat(bool repeats)
        {
            this.repeated = repeats;
        }
        public string get_Type()
        {
            if(this.GetType() == null)
            {
                
            }
        
        }
    
    }

}
