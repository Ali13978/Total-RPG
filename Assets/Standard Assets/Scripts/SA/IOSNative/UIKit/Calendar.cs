using UnityEngine;

namespace SA.IOSNative.UIKit
{
    internal static class Calendar
    {
        // Fields
        private static System.Action<System.DateTime> OnCalendarClosed;
        
        // Methods
        private static Calendar()
        {
            if((SA.Common.Pattern.Singleton<SA_EditorAd>.Instance) != null)
            {
                    return;
            }
        
        }
        public static void PickDate(System.Action<System.DateTime> callback, int startFromYear = 0)
        {
            null = null;
            SA.IOSNative.UIKit.Calendar.OnCalendarClosed = startFromYear;
        }
        internal static void DatePicked(string time)
        {
            var val_2;
            System.DateTime val_1 = System.DateTime.Parse(s:  0);
            val_2 = null;
            val_2 = null;
            SA.IOSNative.UIKit.Calendar.OnCalendarClosed.Invoke(obj:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = val_1.ticks._ticks}, kind = val_1.kind});
        }
    
    }

}
