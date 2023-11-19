using UnityEngine;
public class ISN_RemoteNotificationsController : Singleton<ISN_RemoteNotificationsController>
{
    // Fields
    private static System.Action<ISN_RemoteNotificationsRegistrationResult> _RegistrationCallback;
    private ISN_RemoteNotification _LaunchNotification;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<ISN_RemoteNotification> OnRemoteNotificationReceived;
    
    // Properties
    public ISN_RemoteNotification LaunchNotification { get; }
    
    // Methods
    public ISN_RemoteNotificationsController()
    {
    
    }
    public static void add_OnRemoteNotificationReceived(System.Action<ISN_RemoteNotification> value)
    {
        var val_3;
        System.Action<ISN_RemoteNotification> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_RemoteNotificationsController.OnRemoteNotificationReceived;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_RemoteNotificationsController.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845242376 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnRemoteNotificationReceived(System.Action<ISN_RemoteNotification> value)
    {
        var val_3;
        System.Action<ISN_RemoteNotification> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_RemoteNotificationsController.OnRemoteNotificationReceived;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_RemoteNotificationsController.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504845242376 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void RegisterForRemoteNotifications(System.Action<ISN_RemoteNotificationsRegistrationResult> callback)
    {
        null = null;
        ISN_RemoteNotificationsController._RegistrationCallback = callback;
    }
    public ISN_RemoteNotification get_LaunchNotification()
    {
        return (ISN_RemoteNotification)this._LaunchNotification;
    }
    private void DidFailToRegisterForRemoteNotifications(string errorData)
    {
        var val_3;
        System.Action<ISN_RemoteNotificationsRegistrationResult> val_4;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_RemoteNotificationsController._RegistrationCallback;
        if(val_4 == null)
        {
                return;
        }
        
        val_4 = ISN_RemoteNotificationsController._RegistrationCallback;
        if(val_4 == null)
        {
                val_4 = 0;
        }
        
        val_4.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  errorData)));
    }
    private void DidRegisterForRemoteNotifications(string data)
    {
        int val_4;
        var val_5;
        System.Action<ISN_RemoteNotificationsRegistrationResult> val_6;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = data.Split(separator:  null);
        val_4 = val_1.Length;
        if(val_4 == 0)
        {
                val_4 = val_1.Length;
        }
        
        typeof(ISN_RemoteNotificationsRegistrationResult).__il2cppRuntimeField_18 = new ISN_DeviceToken(base64String:  val_1[1], token:  val_1[0]);
        val_5 = null;
        val_5 = null;
        val_6 = ISN_RemoteNotificationsController._RegistrationCallback;
        if(val_6 == null)
        {
                return;
        }
        
        val_6 = ISN_RemoteNotificationsController._RegistrationCallback;
        if(val_6 == null)
        {
                val_6 = 0;
        }
        
        val_6.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void DidReceiveRemoteNotification(string notificationBody)
    {
        var val_2 = null;
        ISN_RemoteNotificationsController.OnRemoteNotificationReceived.Invoke(obj:  new ISN_RemoteNotification(body:  notificationBody));
    }
    private static ISN_RemoteNotificationsController()
    {
        ISN_RemoteNotificationsController._RegistrationCallback = 0;
        ISN_RemoteNotificationsController.OnRemoteNotificationReceived = new System.Action<ISN_RemoteNotification>(object:  0, method:  static System.Void ISN_RemoteNotificationsController::<OnRemoteNotificationReceived>m__0(ISN_RemoteNotification ));
    }
    private static void <OnRemoteNotificationReceived>m__0(ISN_RemoteNotification )
    {
    
    }

}
