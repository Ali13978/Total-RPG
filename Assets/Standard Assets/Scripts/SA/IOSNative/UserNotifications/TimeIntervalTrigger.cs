using UnityEngine;

namespace SA.IOSNative.UserNotifications
{
    public class TimeIntervalTrigger : NotificationTrigger
    {
        // Fields
        public int intervalToFire;
        
        // Methods
        public TimeIntervalTrigger(int secondsInterval)
        {
            val_1 = new System.Object();
            this.intervalToFire = secondsInterval;
        }
        public override string ToString()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            Add(key:  "intervalToFire", value:  this.intervalToFire);
            Add(key:  "repeats", value:  "intervalToFire");
            return (string)SA.Common.Data.Json.Serialize(obj:  0);
        }
    
    }

}
