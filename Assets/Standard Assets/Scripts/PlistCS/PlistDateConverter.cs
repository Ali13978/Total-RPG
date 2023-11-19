using UnityEngine;

namespace PlistCS
{
    public static class PlistDateConverter
    {
        // Fields
        public static long timeDifference;
        
        // Methods
        public static long GetAppleTime(long unixTime)
        {
            null = null;
            return (long)X1 - PlistCS.PlistDateConverter.timeDifference;
        }
        public static long GetUnixTime(long appleTime)
        {
            null = null;
            return (long)PlistCS.PlistDateConverter.timeDifference + X1;
        }
        public static System.DateTime ConvertFromAppleTimeStamp(double timestamp)
        {
            return new System.DateTime() {ticks = new System.TimeSpan() {_ticks = 1152921510161556592}};
        }
        public static double ConvertToAppleTimeStamp(System.DateTime date)
        {
            System.TimeSpan val_1 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {ticks = new System.TimeSpan(), kind = date.kind}, d2:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = X2}});
            return (double)D0;
        }
        private static PlistDateConverter()
        {
            PlistCS.PlistDateConverter.timeDifference = 978307200;
        }
    
    }

}
