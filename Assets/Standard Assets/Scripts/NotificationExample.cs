using UnityEngine;
public class NotificationExample : BaseIOSFeaturePreview
{
    // Fields
    private int lastNotificationId;
    private static System.Action<SA.IOSNative.UserNotifications.NotificationRequest> <>f__am$cache0;
    private static System.Action<ISN_RemoteNotificationsRegistrationResult> <>f__am$cache1;
    private static System.Action<SA.Common.Models.Result> <>f__am$cache2;
    private static System.Action<SA.Common.Models.Result> <>f__am$cache3;
    private static System.Action<SA.Common.Models.Result> <>f__am$cache4;
    private static System.Action<SA.Common.Models.Result> <>f__am$cache5;
    private static System.Action<System.Collections.Generic.List<SA.IOSNative.UserNotifications.NotificationRequest>> <>f__am$cache6;
    
    // Methods
    public NotificationExample()
    {
    
    }
    private void Awake()
    {
        System.Action<SA.IOSNative.UserNotifications.NotificationRequest> val_17;
        string val_18;
        System.Action<ISN_LocalNotification> val_1 = new System.Action<ISN_LocalNotification>(object:  this, method:  System.Void NotificationExample::HandleOnLocalNotificationReceived(ISN_LocalNotification notification));
        ISN_LocalNotificationsController.add_OnLocalNotificationReceived(value:  null);
        val_17 = NotificationExample.<>f__am$cache0;
        if(val_17 == null)
        {
                NotificationExample.<>f__am$cache0 = new System.Action<SA.IOSNative.UserNotifications.NotificationRequest>(object:  0, method:  static System.Void NotificationExample::<Awake>m__0(SA.IOSNative.UserNotifications.NotificationRequest obj));
            val_17 = NotificationExample.<>f__am$cache0;
        }
        
        SA.IOSNative.UserNotifications.NotificationCenter.add_OnWillPresentNotification(value:  0);
        SA.IOSNative.UserNotifications.NotificationRequest val_3 = SA.IOSNative.UserNotifications.NotificationCenter.LaunchNotification;
        if(val_3.Content != null)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = "Messgae: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_3.Content;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "\nNotification ID: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_3.Id;
            IOSMessage val_8 = IOSMessage.Create(title:  +0, message:  "Launch Notification");
        }
        
        SA_EditorAd val_9 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        if(val_9._IsInterstitialLoading != false)
        {
                SA_EditorAd val_10 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
            if(val_10._IsInterstitialLoading != false)
        {
                val_18 = mem[val_10._IsInterstitialLoading + 40];
            val_18 = val_10._IsInterstitialLoading + 40;
        }
        else
        {
                val_18 = 34460624;
        }
        
            IOSMessage val_12 = IOSMessage.Create(title:  0 + "Messgae: "("Messgae: ") + val_18 + "\nNotification Data: "("\nNotification Data: "), message:  "Launch Notification");
        }
        
        SA_EditorAd val_13 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        if(val_13._IsInterstitialLoading == false)
        {
                return;
        }
        
        SA_EditorAd val_14 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        IOSMessage val_16 = IOSMessage.Create(title:  0 + "Body: "("Body: "), message:  "Launch Remote Notification");
    }
    private void OnGUI()
    {
        object val_49;
        long val_50;
        System.Action<SA.Common.Models.Result> val_51;
        System.Action<SA.Common.Models.Result> val_52;
        var val_53;
        var val_54;
        val_49 = this;
        this.UpdateToStartPos();
        int val_1 = UnityEngine.Screen.width;
        float val_49 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_49, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Local and Push Notifications");
        val_49 = val_49 + 0f;
        mem[1152921510396704280] = val_49;
        float val_50 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_50, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.RequestNotificationPermissions();
        }
        
        val_50 = 0f + val_50;
        mem[1152921510396704284] = val_50;
        float val_51 = 0f;
        bool val_4 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_51, m_Width = 0f, m_Height = 0f}, text:  0);
        if(val_4 != false)
        {
                val_4.CheckNotificationSettings();
        }
        
        val_51 = val_51 + 0f;
        mem[1152921510396704280] = val_51;
        mem[1152921510396704284] = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                System.Action<SA.Common.Models.Result> val_6 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void NotificationExample::OnNotificationScheduleResult(SA.Common.Models.Result res));
            ISN_LocalNotificationsController.add_OnNotificationScheduleResult(value:  null);
            System.DateTime val_7 = System.DateTime.Now;
            double val_52 = 5;
            val_50;
            ISN_LocalNotification val_8 = new ISN_LocalNotification(time:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = val_50}}, message:  "Your Notification Text No Sound", useSound:  false);
            if(null != 0)
        {
                typeof(ISN_LocalNotification).__il2cppRuntimeField_38 = "some_test_data";
            Schedule();
        }
        else
        {
                mem[56] = "some_test_data";
            Schedule();
        }
        
            this.lastNotificationId = ISN_LocalNotification.__il2cppRuntimeField_name;
        }
        
        val_52 = 0f + val_52;
        mem[1152921510396704284] = val_52;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                System.Action<SA.Common.Models.Result> val_10 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void NotificationExample::OnNotificationScheduleResult(SA.Common.Models.Result res));
            ISN_LocalNotificationsController.add_OnNotificationScheduleResult(value:  null);
            System.DateTime val_11 = System.DateTime.Now;
            double val_53 = 5;
            val_50;
            ISN_LocalNotification val_12 = new ISN_LocalNotification(time:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = val_50}}, message:  "Your Notification Text", useSound:  true);
            if(null != 0)
        {
                typeof(ISN_LocalNotification).__il2cppRuntimeField_38 = "some_test_data";
            typeof(ISN_LocalNotification).__il2cppRuntimeField_34 = 1;
            typeof(ISN_LocalNotification).__il2cppRuntimeField_40 = "purchase_ok.wav";
            Schedule();
        }
        else
        {
                mem[56] = "some_test_data";
            mem[64] = "purchase_ok.wav";
            typeof(ISN_LocalNotification).__il2cppRuntimeField_34 = 1;
            Schedule();
        }
        
            this.lastNotificationId = ISN_LocalNotification.__il2cppRuntimeField_name;
        }
        
        val_53 = 0f + val_53;
        mem[1152921510396704284] = val_53;
        float val_54 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_54, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.CancelAllLocalNotifications();
        }
        
        val_54 = 0f + val_54;
        mem[1152921510396704284] = val_54;
        float val_55 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_55, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_16 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        mem[1152921510396704284] = 1152921510297167248;
        val_55 = val_55 + 0f;
        mem[1152921510396704280] = val_55 + 0f;
        int val_18 = UnityEngine.Screen.width;
        float val_56 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_56, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Local and Push Notifications");
        val_56 = val_56 + 0f;
        mem[1152921510396704280] = val_56;
        mem[1152921510396704284] = 0f;
        float val_57 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_57, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_20 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
            val_50 = NotificationExample.<>f__am$cache1;
            if(val_50 == null)
        {
                System.Action<ISN_RemoteNotificationsRegistrationResult> val_21 = new System.Action<ISN_RemoteNotificationsRegistrationResult>(object:  0, method:  static System.Void NotificationExample::<OnGUI>m__1(ISN_RemoteNotificationsRegistrationResult res));
            NotificationExample.<>f__am$cache1 = val_21;
            val_50 = NotificationExample.<>f__am$cache1;
        }
        
            val_21.RegisterForRemoteNotifications(callback:  val_50);
        }
        
        val_57 = 0f + val_57;
        mem[1152921510396704284] = val_57;
        float val_58 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_58, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.ShowGmaeKitNotification(title:  "Title", message:  "Message");
        }
        
        mem[1152921510396704284] = "Title";
        val_58 = val_58 + 0f;
        mem[1152921510396704280] = val_58 + 0f;
        int val_25 = UnityEngine.Screen.width;
        float val_59 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_59, m_Width = 0f, m_Height = 0f}, text:  0, style:  "User Notifications");
        val_59 = val_59 + 0f;
        mem[1152921510396704280] = val_59;
        mem[1152921510396704284] = 0f;
        float val_60 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_60, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_51 = NotificationExample.<>f__am$cache2;
            if(val_51 == null)
        {
                System.Action<SA.Common.Models.Result> val_27 = null;
            val_50 = val_27;
            val_27 = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void NotificationExample::<OnGUI>m__2(SA.Common.Models.Result result));
            NotificationExample.<>f__am$cache2 = val_50;
            val_51 = NotificationExample.<>f__am$cache2;
        }
        
            SA.IOSNative.UserNotifications.NotificationCenter.RequestPermissions(callback:  0);
        }
        
        val_60 = 0f + val_60;
        mem[1152921510396704284] = val_60;
        float val_61 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_61, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                if(null != 0)
        {
                typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_10 = "Title_";
            typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_18 = "Subtitle_";
            typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_30 = 1;
            typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_20 = "Body_";
            typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_28 = "beep.mp3";
        }
        else
        {
                mem[16] = "Title_";
            mem[24] = "Subtitle_";
            mem[32] = "Body_";
            mem[48] = 1;
            mem[40] = "beep.mp3";
        }
        
            set_Item(key:  "404", value:  "test User Info");
            SA.IOSNative.UserNotifications.NotificationRequest val_31 = null;
            val_50 = val_31;
            val_31 = new SA.IOSNative.UserNotifications.NotificationRequest(id:  "some0id0", content:  new SA.IOSNative.UserNotifications.NotificationContent(), trigger:  new SA.IOSNative.UserNotifications.TimeIntervalTrigger(secondsInterval:  5));
            ISN_Logger.Log(message:  val_31, logType:  "request Schedule for 5 sec");
            val_52 = NotificationExample.<>f__am$cache3;
            if(val_52 == null)
        {
                NotificationExample.<>f__am$cache3 = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void NotificationExample::<OnGUI>m__3(SA.Common.Models.Result result));
            val_52 = NotificationExample.<>f__am$cache3;
        }
        
            SA.IOSNative.UserNotifications.NotificationCenter.AddNotificationRequest(request:  0, callback:  val_50);
        }
        
        val_61 = 0f + val_61;
        mem[1152921510396704284] = val_61;
        float val_62 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_62, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                if(null != 0)
        {
                typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_10 = "Calendar - Date Components";
            typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_18 = "Subtitle_";
            typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_30 = 1;
            typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_20 = "Body_";
        }
        else
        {
                mem[16] = "Calendar - Date Components";
            mem[24] = "Subtitle_";
            mem[32] = "Body_";
            mem[48] = 1;
        }
        
            set_Item(key:  "404", value:  "test User Info");
            typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_38 = 0;
            SetRepeat(repeats:  true);
            SA.IOSNative.UserNotifications.NotificationRequest val_37 = null;
            val_50 = val_37;
            val_37 = new SA.IOSNative.UserNotifications.NotificationRequest(id:  "some0id1", content:  new SA.IOSNative.UserNotifications.NotificationContent(), trigger:  new SA.IOSNative.UserNotifications.CalendarTrigger(dateComponents:  new SA.IOSNative.UserNotifications.DateComponents()));
            val_53 = null;
            if((NotificationExample.<>f__am$cache4) == null)
        {
                NotificationExample.<>f__am$cache4 = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void NotificationExample::<OnGUI>m__4(SA.Common.Models.Result result));
            val_53 = null;
        }
        
            SA.IOSNative.UserNotifications.NotificationCenter.AddNotificationRequest(request:  0, callback:  val_50);
        }
        
        val_62 = 0f + val_62;
        mem[1152921510396704284] = val_62;
        float val_63 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_63, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                if(null != 0)
        {
                typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_10 = "Calendar - Date";
            typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_18 = "Subtitle_";
            typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_30 = 1;
            typeof(SA.IOSNative.UserNotifications.NotificationContent).__il2cppRuntimeField_20 = "Body_";
        }
        else
        {
                mem[16] = "Calendar - Date";
            mem[24] = "Subtitle_";
            mem[32] = "Body_";
            mem[48] = 1;
        }
        
            set_Item(key:  "404", value:  1);
            typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_38 = 0;
            typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_10 = 0;
            typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_18 = 0;
            typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_20 = 0;
            typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_28 = 0;
            typeof(SA.IOSNative.UserNotifications.DateComponents).__il2cppRuntimeField_30 = 0;
            SA.IOSNative.UserNotifications.NotificationRequest val_43 = null;
            val_50 = val_43;
            val_43 = new SA.IOSNative.UserNotifications.NotificationRequest(id:  "some0id2", content:  new SA.IOSNative.UserNotifications.NotificationContent(), trigger:  new SA.IOSNative.UserNotifications.CalendarTrigger(dateComponents:  new SA.IOSNative.UserNotifications.DateComponents()));
            val_54 = null;
            if((NotificationExample.<>f__am$cache5) == null)
        {
                NotificationExample.<>f__am$cache5 = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void NotificationExample::<OnGUI>m__5(SA.Common.Models.Result result));
            val_54 = null;
        }
        
            SA.IOSNative.UserNotifications.NotificationCenter.AddNotificationRequest(request:  0, callback:  val_50);
        }
        
        val_63 = 0f + val_63;
        mem[1152921510396704284] = val_63;
        float val_64 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_64, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.IOSNative.UserNotifications.NotificationCenter.CancelAllNotifications();
        }
        
        val_64 = 0f + val_64;
        mem[1152921510396704284] = val_64;
        float val_65 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_65, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.IOSNative.UserNotifications.NotificationCenter.CancelUserNotificationById(nId:  0);
        }
        
        val_65 = 0f + val_65;
        mem[1152921510396704284] = val_65;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        val_50 = 1152921504851095552;
        val_49 = NotificationExample.<>f__am$cache6;
        if(val_49 == null)
        {
                NotificationExample.<>f__am$cache6 = new System.Action<System.Collections.Generic.List<SA.IOSNative.UserNotifications.NotificationRequest>>(object:  0, method:  static System.Void NotificationExample::<OnGUI>m__6(System.Collections.Generic.List<SA.IOSNative.UserNotifications.NotificationRequest> requests));
            val_49 = NotificationExample.<>f__am$cache6;
        }
        
        SA.IOSNative.UserNotifications.NotificationCenter.GetPendingNotificationRequests(callback:  0);
    }
    public void CheckNotificationSettings()
    {
        string val_1 = 0 + "AllowedNotificationsType: "("AllowedNotificationsType: ");
        UnityEngine.Debug.Log(message:  0);
    }
    private void HandleOnLocalNotificationReceived(ISN_LocalNotification notification)
    {
        string val_3;
        if(notification != null)
        {
                val_3 = notification._Message;
        }
        else
        {
                val_3 = 34460624;
        }
        
        IOSMessage val_2 = IOSMessage.Create(title:  0 + "Messgae: "("Messgae: ") + val_3 + "\nNotification Data: "("\nNotification Data: "), message:  "Notification Received");
    }
    private void OnNotificationScheduleResult(SA.Common.Models.Result res)
    {
        var val_7;
        var val_8;
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void NotificationExample::OnNotificationScheduleResult(SA.Common.Models.Result res));
        ISN_LocalNotificationsController.remove_OnNotificationScheduleResult(value:  null);
        val_7 = null;
        val_7 = null;
        if(res.IsSucceeded != false)
        {
                val_8 = "Notification was successfully scheduled\n allowed notifications types: \n";
        }
        else
        {
                val_8 = "Notification scheduling failed";
        }
        
        IOSMessage val_6 = IOSMessage.Create(title:  0 + System.String.Empty, message:  "On Notification Schedule Result");
    }
    private static void <Awake>m__0(SA.IOSNative.UserNotifications.NotificationRequest obj)
    {
        SA.IOSNative.UserNotifications.NotificationContent val_1 = X1.Content;
        string val_2 = 0 + "OnWillPresentNotification: "("OnWillPresentNotification: ");
        UnityEngine.Debug.Log(message:  0);
    }
    private static void <OnGUI>m__1(ISN_RemoteNotificationsRegistrationResult res)
    {
        var val_13;
        bool val_2 = X1.IsSucceeded;
        string val_3 = 0 + "ISN_RemoteNotificationsRegistrationResult: "("ISN_RemoteNotificationsRegistrationResult: ");
        UnityEngine.Debug.Log(message:  0);
        if(X1 == 0)
        {
            goto label_6;
        }
        
        if(X1.IsSucceeded == false)
        {
            goto label_9;
        }
        
        goto label_8;
        label_6:
        if(X1.IsSucceeded == false)
        {
            goto label_9;
        }
        
        label_8:
        val_13 = mem[X1 + 24 + 16];
        val_13 = X1 + 24 + 16;
        goto label_13;
        label_9:
        string val_11 = X1.Error.Message;
        val_13 = 0 + X1.Error.Code + " / "(" / ");
        label_13:
        UnityEngine.Debug.Log(message:  0);
    }
    private static void <OnGUI>m__2(SA.Common.Models.Result result)
    {
        string val_1 = 0 + "RequestPermissions callback";
        ISN_Logger.Log(message:  val_1, logType:  val_1);
    }
    private static void <OnGUI>m__3(SA.Common.Models.Result result)
    {
        ISN_Logger.Log(message:  17612, logType:  "request callback");
        ISN_Logger.Log(message:  X1, logType:  X1);
    }
    private static void <OnGUI>m__4(SA.Common.Models.Result result)
    {
        ISN_Logger.Log(message:  17613, logType:  "request callback");
        ISN_Logger.Log(message:  X1, logType:  X1);
    }
    private static void <OnGUI>m__5(SA.Common.Models.Result result)
    {
        ISN_Logger.Log(message:  17614, logType:  "request callback");
        ISN_Logger.Log(message:  X1, logType:  X1);
    }
    private static void <OnGUI>m__6(System.Collections.Generic.List<SA.IOSNative.UserNotifications.NotificationRequest> requests)
    {
        goto label_1;
        label_7:
        ISN_Logger.Log(message:  17615, logType:  X21 + 16);
        0 = 1;
        label_1:
        if(0 >= X1.Count)
        {
                return;
        }
        
        if(X1.Item[1].Content != null)
        {
            goto label_7;
        }
        
        goto label_7;
    }

}
