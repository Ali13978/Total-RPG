using UnityEngine;

namespace SA.IOSNative.UIKit
{
    public static class DateTimePicker
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<System.DateTime> OnPickerClosed;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<System.DateTime> OnPickerDateChanged;
        
        // Methods
        private static DateTimePicker()
        {
            if((SA.Common.Pattern.Singleton<SA_EditorAd>.Instance) != null)
            {
                    return;
            }
        
        }
        private static void add_OnPickerClosed(System.Action<System.DateTime> value)
        {
            var val_3;
            System.Action<System.DateTime> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.UIKit.DateTimePicker.OnPickerClosed;
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  null);
            val_5 = 0;
            if(val_1 == null)
            {
                    return;
            }
            
            val_5 = val_1;
            if(null == null)
            {
                    return;
            }
            
            val_5 = 0;
        }
        private static void remove_OnPickerClosed(System.Action<System.DateTime> value)
        {
            var val_3;
            System.Action<System.DateTime> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.UIKit.DateTimePicker.OnPickerClosed;
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  null);
            val_5 = 0;
            if(val_1 == null)
            {
                    return;
            }
            
            val_5 = val_1;
            if(null == null)
            {
                    return;
            }
            
            val_5 = 0;
        }
        private static void add_OnPickerDateChanged(System.Action<System.DateTime> value)
        {
            var val_3;
            System.Action<System.DateTime> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.UIKit.DateTimePicker.OnPickerDateChanged;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.UIKit.DateTimePicker.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504849289224 != val_4)
            {
                goto label_8;
            }
        
        }
        private static void remove_OnPickerDateChanged(System.Action<System.DateTime> value)
        {
            var val_3;
            System.Action<System.DateTime> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.UIKit.DateTimePicker.OnPickerDateChanged;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.UIKit.DateTimePicker.__il2cppRuntimeField_static_fields;
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
            
            if(1152921504849289224 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void Show(SA.IOSNative.UIKit.DateTimePickerMode mode, System.Action<System.DateTime> callback)
        {
            null = null;
            SA.IOSNative.UIKit.DateTimePicker.OnPickerClosed = X2;
        }
        public static void Show(SA.IOSNative.UIKit.DateTimePickerMode mode, System.DateTime dateTime, System.Action<System.DateTime> callback)
        {
            null = null;
            SA.IOSNative.UIKit.DateTimePicker.OnPickerClosed = X4;
            System.TimeSpan val_1 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {ticks = new System.TimeSpan(), kind = dateTime.kind}, d2:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = callback}});
        }
        internal static void DateChangedEvent(string time)
        {
            var val_2;
            System.DateTime val_1 = System.DateTime.Parse(s:  0);
            val_2 = null;
            val_2 = null;
            SA.IOSNative.UIKit.DateTimePicker.OnPickerDateChanged.Invoke(obj:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = val_1.ticks._ticks}, kind = val_1.kind});
        }
        internal static void PickerClosed(string time)
        {
            var val_2;
            System.DateTime val_1 = System.DateTime.Parse(s:  0);
            val_2 = null;
            val_2 = null;
            SA.IOSNative.UIKit.DateTimePicker.OnPickerClosed.Invoke(obj:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = val_1.ticks._ticks}, kind = val_1.kind});
        }
    
    }

}
