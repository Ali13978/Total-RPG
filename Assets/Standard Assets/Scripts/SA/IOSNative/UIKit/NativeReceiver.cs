using UnityEngine;

namespace SA.IOSNative.UIKit
{
    public class NativeReceiver : Singleton<SA.IOSNative.UIKit.NativeReceiver>
    {
        // Methods
        public NativeReceiver()
        {
        
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public void Init()
        {
        
        }
        private void CalendarPickerClosed(string time)
        {
            SA.IOSNative.UIKit.Calendar.DatePicked(time:  null);
        }
        private void DateTimePickerClosed(string time)
        {
            SA.IOSNative.UIKit.DateTimePicker.PickerClosed(time:  null);
        }
        private void DateTimePickerDateChanged(string time)
        {
            SA.IOSNative.UIKit.DateTimePicker.DateChangedEvent(time:  null);
        }
    
    }

}
