using UnityEngine;
public class ISN_LocalNotificationsController : Singleton<ISN_LocalNotificationsController>
{
    // Fields
    private const string PP_KEY = "IOSNotificationControllerKey";
    private const string PP_ID_KEY = "IOSNotificationControllerrKey_ID";
    private ISN_LocalNotification _LaunchNotification;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnNotificationScheduleResult;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<ISN_LocalNotification> OnLocalNotificationReceived;
    
    // Properties
    public static int AllowedNotificationsType { get; }
    public ISN_LocalNotification LaunchNotification { get; }
    
    // Methods
    public ISN_LocalNotificationsController()
    {
    
    }
    public static void add_OnNotificationScheduleResult(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_LocalNotificationsController.OnNotificationScheduleResult;
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
    public static void remove_OnNotificationScheduleResult(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_LocalNotificationsController.OnNotificationScheduleResult;
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
    public static void add_OnLocalNotificationReceived(System.Action<ISN_LocalNotification> value)
    {
        var val_3;
        System.Action<ISN_LocalNotification> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_LocalNotificationsController.OnLocalNotificationReceived;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_LocalNotificationsController.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845189128 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnLocalNotificationReceived(System.Action<ISN_LocalNotification> value)
    {
        var val_3;
        System.Action<ISN_LocalNotification> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_LocalNotificationsController.OnLocalNotificationReceived;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_LocalNotificationsController.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845189128 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void RequestNotificationPermissions()
    {
        if(ISN_Device.CurrentDevice != null)
        {
                return;
        }
    
    }
    public void ShowGmaeKitNotification(string title, string message)
    {
        GameCenterManager.ShowGmaeKitNotification(title:  0, message:  title);
    }
    public void CancelAllLocalNotifications()
    {
        System.Collections.Generic.List<ISN_LocalNotification> val_1 = new System.Collections.Generic.List<ISN_LocalNotification>();
        val_1.SaveNotifications(notifications:  val_1);
    }
    public void CancelLocalNotification(ISN_LocalNotification notification)
    {
        if(notification != null)
        {
                return;
        }
    
    }
    public void CancelLocalNotificationById(int notificationId)
    {
    
    }
    public void ScheduleNotification(ISN_LocalNotification notification)
    {
    
    }
    public System.Collections.Generic.List<ISN_LocalNotification> LoadPendingNotifications(bool includeAll = False)
    {
        return 0;
    }
    public void ApplicationIconBadgeNumber(int badges)
    {
    
    }
    public static int get_AllowedNotificationsType()
    {
        return 0;
    }
    public ISN_LocalNotification get_LaunchNotification()
    {
        return (ISN_LocalNotification)this._LaunchNotification;
    }
    private void OnNotificationScheduleResultAction(string array)
    {
        var val_7;
        SA.Common.Models.Result val_8;
        var val_9;
        val_7 = "|";
        if(("|") == null)
        {
                val_7 = "|";
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_20 = Chars[0];
        if((array.Split(separator:  null)[0].Equals(value:  "0")) != false)
        {
                SA.Common.Models.Result val_5 = null;
            val_8 = val_5;
            val_5 = new SA.Common.Models.Result(error:  new SA.Common.Models.Error());
        }
        else
        {
                SA.Common.Models.Result val_6 = null;
            val_8 = val_6;
            val_6 = new SA.Common.Models.Result();
        }
        
        val_9 = null;
        val_9 = null;
        ISN_LocalNotificationsController.OnNotificationScheduleResult.Invoke(obj:  val_8);
    }
    private void OnLocalNotificationReceived_Event(string array)
    {
        var val_7;
        int val_8;
        int val_9;
        var val_10;
        val_7 = "|";
        if(("|") == null)
        {
                val_7 = "|";
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_20 = Chars[0];
        System.String[] val_2 = array.Split(separator:  null);
        val_8 = val_2.Length;
        if(val_8 == 0)
        {
                val_8 = val_2.Length;
        }
        
        string val_8 = val_2[1];
        val_9 = val_2.Length;
        if(val_9 <= 2)
        {
                val_9 = val_2.Length;
        }
        
        string val_9 = val_2[2];
        string val_10 = val_2[3];
        int val_4 = System.Convert.ToInt32(value:  0);
        System.DateTime val_5 = System.DateTime.Now;
        if(null != 0)
        {
                typeof(ISN_LocalNotification).__il2cppRuntimeField_38 = val_9;
            typeof(ISN_LocalNotification).__il2cppRuntimeField_34 = val_4;
        }
        else
        {
                mem[56] = val_9;
            typeof(ISN_LocalNotification).__il2cppRuntimeField_34 = val_4;
        }
        
        typeof(ISN_LocalNotification).__il2cppRuntimeField_10 = System.Convert.ToInt32(value:  0);
        val_10 = null;
        val_10 = null;
        ISN_LocalNotificationsController.OnLocalNotificationReceived.Invoke(obj:  new ISN_LocalNotification(time:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = val_5.ticks._ticks}, kind = val_5.kind}, message:  val_2[0], useSound:  true));
    }
    private void SaveNotifications(System.Collections.Generic.List<ISN_LocalNotification> notifications)
    {
        var val_7;
        string val_8;
        string val_9;
        var val_10;
        if(notifications.Count != 0)
        {
                val_7 = null;
            val_7 = null;
            val_8 = System.String.Empty;
            int val_2 = notifications.Count;
            if(val_2 >= 1)
        {
                var val_7 = 0;
            do
        {
            if(val_7 != 0)
        {
                val_9 = 0 + val_8;
        }
        
            string val_5 = notifications.Item[0].SerializedString;
            val_10 = 0 + val_9;
            val_7 = val_7 + 1;
        }
        while(val_2 != val_7);
        
        }
        
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  "IOSNotificationControllerKey");
            return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  0);
    }
    private static ISN_LocalNotificationsController()
    {
        ISN_LocalNotificationsController.OnNotificationScheduleResult = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void ISN_LocalNotificationsController::<OnNotificationScheduleResult>m__0(SA.Common.Models.Result ));
        ISN_LocalNotificationsController.OnLocalNotificationReceived = new System.Action<ISN_LocalNotification>(object:  0, method:  static System.Void ISN_LocalNotificationsController::<OnLocalNotificationReceived>m__1(ISN_LocalNotification ));
    }
    private static void <OnNotificationScheduleResult>m__0(SA.Common.Models.Result )
    {
    
    }
    private static void <OnLocalNotificationReceived>m__1(ISN_LocalNotification )
    {
    
    }

}
