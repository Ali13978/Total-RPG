using UnityEngine;

namespace SA.IOSNative.UserNotifications
{
    public class CalendarTrigger : NotificationTrigger
    {
        // Fields
        private SA.IOSNative.UserNotifications.DateComponents ComponentsOfDateToFire;
        
        // Methods
        public CalendarTrigger(SA.IOSNative.UserNotifications.DateComponents dateComponents)
        {
            val_1 = new System.Object();
            this.ComponentsOfDateToFire = dateComponents;
        }
        public override string ToString()
        {
            SA.IOSNative.UserNotifications.DateComponents val_3;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if((1406665576 & 1) != 0)
            {
                    Add(key:  "year", value:  this.ComponentsOfDateToFire.Year);
            }
            
            if((1406665568 & 1) != 0)
            {
                    Add(key:  "month", value:  this.ComponentsOfDateToFire.Month);
            }
            
            if((1406665560 & 1) != 0)
            {
                    Add(key:  "day", value:  this.ComponentsOfDateToFire.Day);
            }
            
            if((1406665552 & 1) != 0)
            {
                    Add(key:  "hour", value:  this.ComponentsOfDateToFire.Hour);
            }
            
            if((1406665544 & 1) != 0)
            {
                    Add(key:  "minute", value:  this.ComponentsOfDateToFire.Minute);
            }
            
            if((1406665536 & 1) != 0)
            {
                    Add(key:  "second", value:  this.ComponentsOfDateToFire.Second);
            }
            
            if((1406665528 & 1) != 0)
            {
                    Add(key:  "weekday", value:  this.ComponentsOfDateToFire.Weekday);
            }
            
            val_3 = this.ComponentsOfDateToFire;
            if((1406665520 & 1) != 0)
            {
                    val_3 = this.ComponentsOfDateToFire.Quarter;
                Add(key:  "quarter", value:  this.ComponentsOfDateToFire.Quarter);
            }
            
            Add(key:  "repeats", value:  "quarter");
            return (string)SA.Common.Data.Json.Serialize(obj:  0);
        }
    
    }

}
