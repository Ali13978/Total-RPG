using UnityEngine;
public class NativeIOSActionsExample : BaseIOSFeaturePreview
{
    // Fields
    public UnityEngine.Texture2D hello_texture;
    public UnityEngine.Texture2D drawTexture;
    private System.DateTime time;
    private static System.Action<ISN_SwipeDirection> <>f__am$cache0;
    private static System.Action <>f__am$cache1;
    private static System.Action<SA.IOSNative.Gestures.ForceInfo> <>f__am$cache2;
    private static System.Action <>f__am$cache3;
    private static System.Action<string> <>f__am$cache4;
    private static System.Action<SA.IOSNative.Contacts.ContactsResult> <>f__am$cache5;
    private static System.Action<SA.IOSNative.Contacts.ContactsResult> <>f__am$cache6;
    private static System.Action<System.DateTime> <>f__am$cache7;
    private static System.Action<System.DateTime> <>f__am$cache8;
    private static System.Action<System.DateTime> <>f__am$cache9;
    private static System.Action<System.DateTime> <>f__am$cacheA;
    private static System.Action<System.DateTime> <>f__am$cacheB;
    private static System.Action<System.DateTime> <>f__am$cacheC;
    private static System.Action<SA.IOSNative.Privacy.PermissionStatus> <>f__am$cacheD;
    private static System.Action<SA.IOSNative.Privacy.PermissionStatus> <>f__am$cacheE;
    private static System.Action<SA.IOSNative.Privacy.PermissionStatus> <>f__am$cacheF;
    
    // Methods
    public NativeIOSActionsExample()
    {
    
    }
    private void Awake()
    {
        var val_13;
        System.Action<ISN_SwipeDirection> val_14;
        System.Action val_15;
        System.Action<SA.IOSNative.Gestures.ForceInfo> val_16;
        System.Action val_17;
        System.Action<System.String> val_18;
        this.time = 0;
        mem[1152921510392515904] = 0;
        UnityEngine.Debug.Log(message:  0);
        val_13 = null;
        if((NativeIOSActionsExample.<>f__am$cache0) == null)
        {
                System.Action<ISN_SwipeDirection> val_2 = null;
            val_14 = val_2;
            val_2 = new System.Action<ISN_SwipeDirection>(object:  0, method:  static System.Void NativeIOSActionsExample::<Awake>m__0(ISN_SwipeDirection direction));
            NativeIOSActionsExample.<>f__am$cache0 = val_14;
            val_13 = null;
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.add_OnSwipe(value:  NativeIOSActionsExample.<>f__am$cache0);
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.Setup(forceTouchDelay:  0.5f, baseForceTouchPressure:  1f, triggeringForceTouchPressure:  2.5f);
        val_15 = NativeIOSActionsExample.<>f__am$cache1;
        if(val_15 == null)
        {
                System.Action val_5 = null;
            val_14 = val_5;
            val_5 = new System.Action(object:  0, method:  static System.Void NativeIOSActionsExample::<Awake>m__1());
            NativeIOSActionsExample.<>f__am$cache1 = val_14;
            val_15 = NativeIOSActionsExample.<>f__am$cache1;
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.add_OnForceTouchStarted(value:  val_15);
        val_16 = NativeIOSActionsExample.<>f__am$cache2;
        if(val_16 == null)
        {
                System.Action<SA.IOSNative.Gestures.ForceInfo> val_7 = null;
            val_14 = val_7;
            val_7 = new System.Action<SA.IOSNative.Gestures.ForceInfo>(object:  0, method:  static System.Void NativeIOSActionsExample::<Awake>m__2(SA.IOSNative.Gestures.ForceInfo info));
            NativeIOSActionsExample.<>f__am$cache2 = val_14;
            val_16 = NativeIOSActionsExample.<>f__am$cache2;
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.add_OnForceChanged(value:  val_16);
        val_17 = NativeIOSActionsExample.<>f__am$cache3;
        if(val_17 == null)
        {
                System.Action val_9 = null;
            val_14 = val_9;
            val_9 = new System.Action(object:  0, method:  static System.Void NativeIOSActionsExample::<Awake>m__3());
            NativeIOSActionsExample.<>f__am$cache3 = val_14;
            val_17 = NativeIOSActionsExample.<>f__am$cache3;
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.add_OnForceTouchFinished(value:  val_17);
        string val_10 = SA.IOSNative.Gestures.ForceTouch.AppOpenshortcutItem;
        UnityEngine.Debug.Log(message:  0);
        val_18 = NativeIOSActionsExample.<>f__am$cache4;
        if(val_18 == null)
        {
                System.Action<System.String> val_12 = null;
            val_14 = val_12;
            val_12 = new System.Action<System.String>(object:  0, method:  static System.Void NativeIOSActionsExample::<Awake>m__4(string action));
            NativeIOSActionsExample.<>f__am$cache4 = val_14;
            val_18 = NativeIOSActionsExample.<>f__am$cache4;
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.add_OnAppShortcutClick(value:  val_18);
    }
    private void OnGUI()
    {
        object val_62;
        System.Action<System.DateTime> val_63;
        System.Action<SA.IOSNative.Contacts.ContactsResult> val_64;
        val_62 = this;
        this.UpdateToStartPos();
        int val_1 = UnityEngine.Screen.width;
        float val_62 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_62, m_Width = 0f, m_Height = 0f}, text:  0, style:  "System Utils");
        val_62 = val_62 + 0f;
        mem[1152921510392741000] = val_62;
        float val_63 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_63, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                bool val_3 = SA.IOSNative.System.SharedApplication.CheckUrl(url:  0);
            if(val_3 != false)
        {
            
        }
        
            IOSMessage val_4 = IOSMessage.Create(title:  val_3, message:  "ERROR");
        }
        
        val_63 = 0f + val_63;
        mem[1152921510392741004] = val_63;
        float val_64 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_64, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.IOSNative.System.SharedApplication.OpenUrl(url:  0);
        }
        
        val_64 = 0f + val_64;
        mem[1152921510392741004] = val_64;
        float val_65 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_65, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA.IOSNative.System.SharedApplication.OpenUrl(url:  0);
        }
        
        val_65 = 0f + val_65;
        mem[1152921510392741004] = val_65;
        float val_66 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_66, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                ISN_Device val_8 = ISN_Device.CurrentDevice;
            IOSMessage val_9 = IOSMessage.Create(title:  13273, message:  "Identifier Loaded");
        }
        
        val_66 = 0f + val_66;
        mem[1152921510392741004] = "00000000-0000-0000-0000-000000000000";
        mem[1152921510392741000] = val_66;
        float val_67 = 0f;
        bool val_10 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_67, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        val_67 = 0f + val_67;
        mem[1152921510392741004] = val_67;
        float val_68 = 0f;
        bool val_11 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_68, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        val_68 = 0f + val_68;
        mem[1152921510392741004] = val_68;
        float val_69 = 0f;
        float val_70 = 0f;
        bool val_12 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_69, m_YMin = val_70, m_Width = 0f, m_Height = 0f}, text:  0);
        if(val_12 != false)
        {
                val_12.ShowDevoceInfo();
        }
        
        val_69 = val_69 + val_70;
        val_70 = val_69 + 0f;
        mem[1152921510392741004] = "Show Device Info";
        mem[1152921510392741000] = val_70;
        float val_71 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_71, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_63 = 1152921504851042304;
            val_64 = NativeIOSActionsExample.<>f__am$cache5;
            if(val_64 == null)
        {
                NativeIOSActionsExample.<>f__am$cache5 = new System.Action<SA.IOSNative.Contacts.ContactsResult>(object:  0, method:  static System.Void NativeIOSActionsExample::<OnGUI>m__5(SA.IOSNative.Contacts.ContactsResult result));
            val_64 = NativeIOSActionsExample.<>f__am$cache5;
        }
        
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.ShowContactsPickerUI(callback:  val_64);
        }
        
        val_71 = 0f + val_71;
        mem[1152921510392741004] = val_71;
        float val_72 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_72, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_63 = 1152921504851042304;
            val_64 = NativeIOSActionsExample.<>f__am$cache6;
            if(val_64 == null)
        {
                NativeIOSActionsExample.<>f__am$cache6 = new System.Action<SA.IOSNative.Contacts.ContactsResult>(object:  0, method:  static System.Void NativeIOSActionsExample::<OnGUI>m__6(SA.IOSNative.Contacts.ContactsResult result));
            val_64 = NativeIOSActionsExample.<>f__am$cache6;
        }
        
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.RetrievePhoneContacts(callback:  val_64);
        }
        
        mem[1152921510392741004] = NativeIOSActionsExample.__il2cppRuntimeField_static_fields;
        val_72 = val_72 + 0f;
        mem[1152921510392741000] = val_72 + 0f;
        int val_20 = UnityEngine.Screen.width;
        float val_73 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_73, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Date Time Picker");
        val_73 = val_73 + 0f;
        mem[1152921510392741000] = val_73;
        float val_74 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_74, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                if((NativeIOSActionsExample.<>f__am$cache7) == null)
        {
                System.Action<System.DateTime> val_22 = null;
            val_64 = val_22;
            val_22 = new System.Action<System.DateTime>(object:  0, method:  static System.Void NativeIOSActionsExample::<OnGUI>m__7(System.DateTime dateTime));
            NativeIOSActionsExample.<>f__am$cache7 = val_64;
        }
        
            SA.IOSNative.UIKit.DateTimePicker.Show(mode:  0, callback:  1);
        }
        
        val_74 = 0f + val_74;
        mem[1152921510392741004] = val_74;
        float val_75 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_75, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                if((NativeIOSActionsExample.<>f__am$cache8) == null)
        {
                System.Action<System.DateTime> val_24 = null;
            val_64 = val_24;
            val_24 = new System.Action<System.DateTime>(object:  0, method:  static System.Void NativeIOSActionsExample::<OnGUI>m__8(System.DateTime dateTime));
            NativeIOSActionsExample.<>f__am$cache8 = val_64;
        }
        
            SA.IOSNative.UIKit.DateTimePicker.Show(mode:  0, callback:  2);
        }
        
        val_75 = 0f + val_75;
        mem[1152921510392741004] = val_75;
        float val_76 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_76, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                if((NativeIOSActionsExample.<>f__am$cache9) == null)
        {
                System.Action<System.DateTime> val_26 = null;
            val_64 = val_26;
            val_26 = new System.Action<System.DateTime>(object:  0, method:  static System.Void NativeIOSActionsExample::<OnGUI>m__9(System.DateTime dateTime));
            NativeIOSActionsExample.<>f__am$cache9 = val_64;
        }
        
            SA.IOSNative.UIKit.DateTimePicker.Show(mode:  0, callback:  3);
        }
        
        val_76 = 0f + val_76;
        mem[1152921510392741004] = val_76;
        float val_77 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_77, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                if((NativeIOSActionsExample.<>f__am$cacheA) == null)
        {
                System.Action<System.DateTime> val_28 = null;
            val_64 = val_28;
            val_28 = new System.Action<System.DateTime>(object:  0, method:  static System.Void NativeIOSActionsExample::<OnGUI>m__A(System.DateTime dateTime));
            NativeIOSActionsExample.<>f__am$cacheA = val_64;
        }
        
            SA.IOSNative.UIKit.DateTimePicker.Show(mode:  0, callback:  4);
        }
        
        val_77 = 0f + val_77;
        mem[1152921510392741004] = SA.IOSNative.UIKit.DateTimePicker.__il2cppRuntimeField_cctor_finished;
        mem[1152921510392741000] = val_77;
        float val_78 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_78, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_64 = this.time;
            if((NativeIOSActionsExample.<>f__am$cacheB) == null)
        {
                System.Action<System.DateTime> val_30 = null;
            val_63 = val_30;
            val_30 = new System.Action<System.DateTime>(object:  0, method:  static System.Void NativeIOSActionsExample::<OnGUI>m__B(System.DateTime dateTime));
            NativeIOSActionsExample.<>f__am$cacheB = val_63;
        }
        
            SA.IOSNative.UIKit.DateTimePicker.Show(mode:  0, dateTime:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = 2}, kind = val_64}, callback:  NativeIOSActionsExample.<>f__am$cacheA);
        }
        
        val_78 = 0f + val_78;
        mem[1152921510392741004] = SA.IOSNative.UIKit.DateTimePicker.__il2cppRuntimeField_cctor_finished;
        mem[1152921510392741000] = val_78;
        float val_79 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_79, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                if((NativeIOSActionsExample.<>f__am$cacheC) == null)
        {
                System.Action<System.DateTime> val_32 = null;
            val_64 = val_32;
            val_32 = new System.Action<System.DateTime>(object:  0, method:  static System.Void NativeIOSActionsExample::<OnGUI>m__C(System.DateTime dateTime));
            NativeIOSActionsExample.<>f__am$cacheC = val_64;
        }
        
            SA.IOSNative.UIKit.Calendar.PickDate(callback:  0, startFromYear:  56709120);
            if((NativeIOSActionsExample.<>f__am$cacheD) == null)
        {
                System.Action<SA.IOSNative.Privacy.PermissionStatus> val_33 = null;
            val_64 = val_33;
            val_33 = new System.Action<SA.IOSNative.Privacy.PermissionStatus>(object:  0, method:  static System.Void NativeIOSActionsExample::<OnGUI>m__D(SA.IOSNative.Privacy.PermissionStatus permissionStatus));
            NativeIOSActionsExample.<>f__am$cacheD = val_64;
        }
        
            val_63 = 1152921504848752640;
            SA.IOSNative.Privacy.PermissionsManager.RequestPermission(permission:  0, callback:  4);
            if((NativeIOSActionsExample.<>f__am$cacheE) == null)
        {
                System.Action<SA.IOSNative.Privacy.PermissionStatus> val_34 = null;
            val_64 = val_34;
            val_34 = new System.Action<SA.IOSNative.Privacy.PermissionStatus>(object:  0, method:  static System.Void NativeIOSActionsExample::<OnGUI>m__E(SA.IOSNative.Privacy.PermissionStatus permissionStatus));
            NativeIOSActionsExample.<>f__am$cacheE = val_64;
        }
        
            SA.IOSNative.Privacy.PermissionsManager.RequestPermission(permission:  0, callback:  7);
            if((NativeIOSActionsExample.<>f__am$cacheF) == null)
        {
                System.Action<SA.IOSNative.Privacy.PermissionStatus> val_35 = null;
            val_64 = val_35;
            val_35 = new System.Action<SA.IOSNative.Privacy.PermissionStatus>(object:  0, method:  static System.Void NativeIOSActionsExample::<OnGUI>m__F(SA.IOSNative.Privacy.PermissionStatus permissionStatus));
            NativeIOSActionsExample.<>f__am$cacheF = val_64;
        }
        
            SA.IOSNative.Privacy.PermissionsManager.RequestPermission(permission:  0, callback:  3);
        }
        
        mem[1152921510392741004] = SA.IOSNative.Privacy.PermissionsManager.__il2cppRuntimeField_cctor_finished;
        val_79 = val_79 + 0f;
        mem[1152921510392741000] = val_79 + 0f;
        int val_37 = UnityEngine.Screen.width;
        float val_80 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_80, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Video");
        val_80 = val_80 + 0f;
        mem[1152921510392741000] = val_80;
        float val_81 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_81, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_39 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        val_81 = 0f + val_81;
        mem[1152921510392741004] = val_81;
        float val_82 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_82, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                SA_EditorAd val_41 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        mem[1152921510392741004] = 1152921510392669984;
        val_82 = val_82 + 0f;
        mem[1152921510392741000] = val_82 + 0f;
        int val_43 = UnityEngine.Screen.width;
        float val_83 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_83, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Camera Roll");
        val_83 = 0f + val_83;
        mem[1152921510392741000] = val_83;
        float val_84 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_84, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_64 = System.Void NativeIOSActionsExample::OnImageSaved(SA.Common.Models.Result result);
            System.Action<SA.Common.Models.Result> val_45 = new System.Action<SA.Common.Models.Result>(object:  this, method:  val_64);
            IOSCamera.add_OnImageSaved(value:  0);
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.SaveScreenshotToCameraRoll();
        }
        
        val_84 = 0f + val_84;
        mem[1152921510392741004] = val_84;
        float val_85 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_85, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                System.Action<SA.Common.Models.Result> val_48 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void NativeIOSActionsExample::OnImageSaved(SA.Common.Models.Result result));
            IOSCamera.add_OnImageSaved(value:  0);
            val_64 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
            val_64.SaveTextureToCameraRoll(texture:  this.hello_texture);
        }
        
        val_85 = 0f + val_85;
        mem[1152921510392741004] = val_85;
        float val_86 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_86, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_64 = System.Void NativeIOSActionsExample::OnImage(IOSImagePickResult result);
            System.Action<IOSImagePickResult> val_51 = new System.Action<IOSImagePickResult>(object:  this, method:  val_64);
            IOSCamera.add_OnImagePicked(value:  0);
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.PickImage(source:  2);
        }
        
        val_86 = 0f + val_86;
        mem[1152921510392741004] = val_86;
        float val_87 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_87, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_64 = System.Void NativeIOSActionsExample::OnImage(IOSImagePickResult result);
            System.Action<IOSImagePickResult> val_54 = new System.Action<IOSImagePickResult>(object:  this, method:  val_64);
            IOSCamera.add_OnImagePicked(value:  0);
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.PickImage(source:  1);
        }
        
        val_87 = 0f + val_87;
        mem[1152921510392741004] = val_87;
        float val_88 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_88, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_64 = System.Void NativeIOSActionsExample::<OnGUI>m__10(ISN_FilePickerResult res);
            System.Action<ISN_FilePickerResult> val_57 = new System.Action<ISN_FilePickerResult>(object:  this, method:  val_64);
            ISN_FilePicker.add_MediaPickFinished(value:  null);
            SA_EditorAd val_58 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        mem[1152921510392741004] = 1152921510392703552;
        val_88 = val_88 + 0f;
        mem[1152921510392741000] = val_88 + 0f;
        int val_60 = UnityEngine.Screen.width;
        float val_89 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_89, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "PickedImage");
        val_89 = val_89 + 0f;
        mem[1152921510392741000] = val_89;
        if(0 == this.drawTexture)
        {
                return;
        }
        
        val_62 = this.drawTexture;
        UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, image:  0);
    }
    private void ShowDevoceInfo()
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Name: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_1._Name;
        typeof(System.Object[]).__il2cppRuntimeField_30 = "\nSystem Name: ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_1._SystemName;
        typeof(System.Object[]).__il2cppRuntimeField_40 = "\nModel: ";
        typeof(System.Object[]).__il2cppRuntimeField_48 = val_1._Model;
        typeof(System.Object[]).__il2cppRuntimeField_50 = "\nLocalized Model: ";
        typeof(System.Object[]).__il2cppRuntimeField_58 = val_1._LocalizedModel;
        typeof(System.Object[]).__il2cppRuntimeField_60 = "\nSystem Version: ";
        typeof(System.Object[]).__il2cppRuntimeField_68 = val_1._SystemVersion;
        typeof(System.Object[]).__il2cppRuntimeField_70 = "\nMajor System Version: ";
        typeof(System.Object[]).__il2cppRuntimeField_78 = val_1._MajorSystemVersion;
        typeof(System.Object[]).__il2cppRuntimeField_7C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_80 = "\nPreferred Language Code: ";
        typeof(System.Object[]).__il2cppRuntimeField_88 = ISN_Device.CurrentDevice.PreferredLanguageCode;
        typeof(System.Object[]).__il2cppRuntimeField_90 = "\nPreferred Language_ISO639_1: ";
        typeof(System.Object[]).__il2cppRuntimeField_98 = val_1._PreferredLanguage_ISO639_1;
        typeof(System.Object[]).__il2cppRuntimeField_A0 = "\nUser Interface Idiom: ";
        typeof(System.Object[]).__il2cppRuntimeField_A8 = val_1._InterfaceIdiom;
        typeof(System.Object[]).__il2cppRuntimeField_B0 = "\nGUID in Base64: ";
        typeof(System.Object[]).__il2cppRuntimeField_B8 = val_1._GUID._Base64;
        IOSMessage val_4 = IOSMessage.Create(title:  +0, message:  "Device Info");
        ISN_TimeZone val_5 = ISN_TimeZone.LocalTimeZone;
        string val_6 = 0 + "ISN_TimeZone.LocalTimeZone.Name: "("ISN_TimeZone.LocalTimeZone.Name: ");
        UnityEngine.Debug.Log(message:  0);
        ISN_TimeZone val_7 = ISN_TimeZone.LocalTimeZone;
        string val_8 = 0 + "ISN_TimeZone.LocalTimeZone.SecondsFromGMT: "("ISN_TimeZone.LocalTimeZone.SecondsFromGMT: ");
        UnityEngine.Debug.Log(message:  0);
        ISN_Build val_9 = ISN_Build.Current;
        string val_10 = 0 + "ISN_TimeZone.LocalTimeZone.Name: "("ISN_TimeZone.LocalTimeZone.Name: ");
        UnityEngine.Debug.Log(message:  0);
        ISN_Build val_11 = ISN_Build.Current;
        string val_12 = 0 + "ISN_TimeZone.LocalTimeZone.Name: "("ISN_TimeZone.LocalTimeZone.Name: ");
        UnityEngine.Debug.Log(message:  0);
    }
    private void OnDateChanged(System.DateTime time)
    {
        string val_1 = 0 + "OnDateChanged: "("OnDateChanged: ");
        ISN_Logger.Log(message:  val_1, logType:  val_1);
    }
    private void OnPickerClosed(System.DateTime time)
    {
        string val_1 = 0 + "OnPickerClosed: "("OnPickerClosed: ");
        ISN_Logger.Log(message:  val_1, logType:  val_1);
    }
    private void OnImage(IOSImagePickResult result)
    {
        var val_7;
        var val_8;
        var val_9;
        string val_10;
        val_7 = result;
        bool val_1 = val_7.IsSucceeded;
        if(val_1 != false)
        {
                UnityEngine.Object.Destroy(obj:  0);
            this.drawTexture = result._image;
            val_8 = 4;
            val_8 = mem[null + 48];
            if(("Image Successfully Loaded, Image size: ") == null)
        {
                val_8 = 0;
        }
        
            val_8 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Image Successfully Loaded, Image size: ";
            int val_2 = result._image.width;
            if(val_2 != 0)
        {
                val_9 = mem[null + 48];
            if(val_2 == 0)
        {
                val_9 = 0;
        }
        
        }
        
            val_9 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_2;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            val_9 = mem[null + 48];
            if("x" == null)
        {
                val_9 = 0;
        }
        
            val_9 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "x";
            typeof(System.Object[]).__il2cppRuntimeField_38 = result._image.height;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            string val_4 = +0;
            val_10 = "Success";
        }
        else
        {
                val_10 = "ERROR";
        }
        
        IOSMessage val_5 = IOSMessage.Create(title:  val_1, message:  val_10);
        System.Action<IOSImagePickResult> val_6 = new System.Action<IOSImagePickResult>(object:  this, method:  System.Void NativeIOSActionsExample::OnImage(IOSImagePickResult result));
        IOSCamera.remove_OnImagePicked(value:  0);
    }
    private void OnImageSaved(SA.Common.Models.Result result)
    {
        string val_4;
        var val_5;
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void NativeIOSActionsExample::OnImageSaved(SA.Common.Models.Result result));
        IOSCamera.remove_OnImageSaved(value:  0);
        bool val_2 = result.IsSucceeded;
        if(val_2 != false)
        {
                val_4 = "Success";
            val_5 = "Image Successfully saved to Camera Roll";
        }
        else
        {
                val_4 = "ERROR";
            val_5 = "Image Save Failed";
        }
        
        IOSMessage val_3 = IOSMessage.Create(title:  val_2, message:  val_4);
    }
    private static void <Awake>m__0(ISN_SwipeDirection direction)
    {
        string val_1 = 0 + "Swipe: "("Swipe: ");
        UnityEngine.Debug.Log(message:  0);
    }
    private static void <Awake>m__1()
    {
        UnityEngine.Debug.Log(message:  0);
    }
    private static void <Awake>m__2(SA.IOSNative.Gestures.ForceInfo info)
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = "OnForceChanged: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = X1.Force;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " / ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = X1.MaxForce;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_3 = +0;
        UnityEngine.Debug.Log(message:  0);
    }
    private static void <Awake>m__3()
    {
        UnityEngine.Debug.Log(message:  0);
    }
    private static void <Awake>m__4(string action)
    {
        string val_1 = 0 + "Menu Item With action: "("Menu Item With action: ") + X1;
        UnityEngine.Debug.Log(message:  0);
    }
    private static void <OnGUI>m__5(SA.IOSNative.Contacts.ContactsResult result)
    {
        int val_14;
        var val_29;
        var val_30;
        if(X1 == 0)
        {
            goto label_1;
        }
        
        val_29 = X1;
        if(X1.IsSucceeded == true)
        {
            goto label_2;
        }
        
        goto label_4;
        label_1:
        val_29 = 0;
        if(0.IsSucceeded == false)
        {
            goto label_4;
        }
        
        label_2:
        string val_6 = 0 + "Picked " + X1.Contacts.Count;
        UnityEngine.Debug.Log(message:  0);
        IOSMessage val_10 = IOSMessage.Create(title:  0 + "Picked " + X1.Contacts.Count, message:  "Success");
        List.Enumerator<T> val_12 = X1.Contacts.GetEnumerator();
        label_39:
        if((0 & 1) == 0)
        {
            goto label_48;
        }
        
        string val_16 = 0 + "contact.GivenName: "("contact.GivenName: ");
        UnityEngine.Debug.Log(message:  0);
        if(val_16.Count >= 1)
        {
                SA.IOSNative.Contacts.PhoneNumber val_18 = val_16.Item[0];
            UnityEngine.Debug.Log(message:  0);
        }
        
        if((0 + "contact.PhoneNumber: "("contact.PhoneNumber: ").Count) < 1)
        {
            goto label_39;
        }
        
        string val_21 = val_14.InitializationCallback.Item[0];
        string val_22 = 0 + "contact.Email: "("contact.Email: ");
        UnityEngine.Debug.Log(message:  0);
        goto label_39;
        label_48:
        val_14.Dispose();
        if((0 & 1) != 0)
        {
                return;
        }
        
        if( == 0)
        {
                return;
        }
        
        return;
        label_4:
        val_14 = val_29.Error.Code;
        val_30 = val_29.Error.Message;
        IOSMessage val_28 = IOSMessage.Create(title:  0 + val_14 + " / "(" / "), message:  "Error");
    }
    private static void <OnGUI>m__6(SA.IOSNative.Contacts.ContactsResult result)
    {
        int val_14;
        var val_25;
        string val_26;
        var val_27;
        if(X1 == 0)
        {
            goto label_1;
        }
        
        val_25 = X1;
        if(X1.IsSucceeded == true)
        {
            goto label_2;
        }
        
        goto label_4;
        label_1:
        val_25 = 0;
        if(0.IsSucceeded == false)
        {
            goto label_4;
        }
        
        label_2:
        string val_6 = 0 + "Loaded " + X1.Contacts.Count;
        UnityEngine.Debug.Log(message:  0);
        IOSMessage val_10 = IOSMessage.Create(title:  0 + "Loaded " + X1.Contacts.Count, message:  "Success");
        System.Collections.Generic.List<SA.IOSNative.Contacts.Contact> val_11 = X1.Contacts;
        List.Enumerator<T> val_12 = val_11.GetEnumerator();
        do
        {
            label_26:
            if((0 & 1) == 0)
        {
            goto label_35;
        }
        
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_15 = val_14.InitializationCallback;
        }
        while(val_11.Count < 1);
        
        if(val_15 != null)
        {
            
        }
        else
        {
                val_26 = 11993091;
        }
        
        SA.IOSNative.Contacts.PhoneNumber val_17 = val_15.Item[0];
        string val_18 = 0 + val_26 + " / "(" / ");
        UnityEngine.Debug.Log(message:  0);
        goto label_26;
        label_35:
        val_14.Dispose();
        if((0 & 1) != 0)
        {
                return;
        }
        
        if( == 0)
        {
                return;
        }
        
        return;
        label_4:
        val_14 = val_25.Error.Code;
        val_27 = val_25.Error.Message;
        IOSMessage val_24 = IOSMessage.Create(title:  0 + val_14 + " / "(" / "), message:  "Error");
    }
    private static void <OnGUI>m__7(System.DateTime dateTime)
    {
    
    }
    private static void <OnGUI>m__8(System.DateTime dateTime)
    {
    
    }
    private static void <OnGUI>m__9(System.DateTime dateTime)
    {
    
    }
    private static void <OnGUI>m__A(System.DateTime dateTime)
    {
    
    }
    private static void <OnGUI>m__B(System.DateTime dateTime)
    {
    
    }
    private static void <OnGUI>m__C(System.DateTime dateTime)
    {
        string val_1 = 0 + "OnDateChanged: "("OnDateChanged: ");
        ISN_Logger.Log(message:  val_1, logType:  val_1);
    }
    private static void <OnGUI>m__D(SA.IOSNative.Privacy.PermissionStatus permissionStatus)
    {
        string val_1 = ???.ToString();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        string val_3 = 0 + "PermissionsManager.RequestPermission: "("PermissionsManager.RequestPermission: ") + 4;
        UnityEngine.Debug.Log(message:  0);
    }
    private static void <OnGUI>m__E(SA.IOSNative.Privacy.PermissionStatus permissionStatus)
    {
        string val_1 = ???.ToString();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        string val_3 = 0 + "PermissionsManager.RequestPermission: "("PermissionsManager.RequestPermission: ") + 7;
        UnityEngine.Debug.Log(message:  0);
    }
    private static void <OnGUI>m__F(SA.IOSNative.Privacy.PermissionStatus permissionStatus)
    {
        string val_1 = ???.ToString();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        string val_3 = 0 + "PermissionsManager.RequestPermission: "("PermissionsManager.RequestPermission: ") + 3;
        UnityEngine.Debug.Log(message:  0);
    }
    private void <OnGUI>m__10(ISN_FilePickerResult res)
    {
        System.Collections.Generic.List<UnityEngine.Texture2D> val_5;
        string val_2 = 0 + "Picked " + res.PickedImages.Count;
        UnityEngine.Debug.Log(message:  0);
        val_5 = res.PickedImages;
        if(val_5.Count == 0)
        {
                return;
        }
        
        val_5 = this.drawTexture;
        UnityEngine.Object.Destroy(obj:  0);
        this.drawTexture = res.PickedImages.Item[0];
    }

}
