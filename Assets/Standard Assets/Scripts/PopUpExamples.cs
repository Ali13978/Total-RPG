using UnityEngine;
public class PopUpExamples : BaseIOSFeaturePreview
{
    // Methods
    public PopUpExamples()
    {
    
    }
    private void Awake()
    {
    
    }
    private void OnGUI()
    {
        System.Action<IOSDialogResult> val_21;
        this.UpdateToStartPos();
        int val_1 = UnityEngine.Screen.width;
        float val_21 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_21, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Native Pop-ups");
        val_21 = val_21 + 0f;
        mem[1152921510398453448] = val_21;
        float val_22 = 0f;
        bool val_2 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_22, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        if(val_2 != false)
        {
                System.Action<IOSDialogResult> val_4 = null;
            val_21 = val_4;
            val_4 = new System.Action<IOSDialogResult>(object:  this, method:  System.Void PopUpExamples::onRatePopUpClose(IOSDialogResult result));
            IOSRateUsPopUp.Create(title:  val_2, message:  "Like this game?").add_OnComplete(value:  val_21);
        }
        
        val_22 = 0f + val_22;
        mem[1152921510398453452] = val_22;
        float val_23 = 0f;
        bool val_5 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_23, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        if(val_5 != false)
        {
                System.Action<IOSDialogResult> val_7 = null;
            val_21 = val_7;
            val_7 = new System.Action<IOSDialogResult>(object:  this, method:  System.Void PopUpExamples::onDialogClose(IOSDialogResult result));
            IOSDialog.Create(title:  val_5, message:  "Dialog Title").add_OnComplete(value:  val_21);
        }
        
        val_23 = 0f + val_23;
        mem[1152921510398453452] = val_23;
        float val_24 = 0f;
        bool val_8 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_24, m_Width = 0f, m_Height = 0f}, text:  0);
        if(val_8 != false)
        {
                System.Action val_10 = null;
            val_21 = val_10;
            val_10 = new System.Action(object:  this, method:  System.Void PopUpExamples::onMessageClose());
            IOSMessage.Create(title:  val_8, message:  "Message Title").add_OnComplete(value:  val_21);
        }
        
        val_24 = 0f + val_24;
        mem[1152921510398453452] = null;
        mem[1152921510398453448] = val_24;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                float val_25 = 2f;
            this.Invoke(methodName:  "dismissAlert", time:  val_25);
            IOSMessage val_12 = IOSMessage.Create(title:  this, message:  "Hello");
        }
        
        val_25 = 0f + val_25;
        mem[1152921510398453452] = val_25;
        float val_26 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_26, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                IOSNativeUtility.RedirectToAppStoreRatingPage();
        }
        
        val_26 = 0f + val_26;
        mem[1152921510398453452] = IOSNativeUtility.__il2cppRuntimeField_cctor_finished;
        mem[1152921510398453448] = val_26;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                float val_27 = 3f;
            this.Invoke(methodName:  "HidePreloader", time:  val_27);
        }
        
        val_27 = 0f + val_27;
        mem[1152921510398453452] = val_27;
        float val_28 = 0f;
        bool val_15 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_28, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        if(val_15 != false)
        {
                val_15.HidePreloader();
        }
        
        val_28 = 0f + val_28;
        mem[1152921510398453452] = val_28;
        float val_29 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_29, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_21 = System.Void PopUpExamples::GetLocale(ISN_Locale locale);
            System.Action<ISN_Locale> val_17 = new System.Action<ISN_Locale>(object:  this, method:  val_21);
            IOSNativeUtility.add_OnLocaleLoaded(value:  null);
            SA_EditorAd val_18 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        }
        
        val_29 = 0f + val_29;
        mem[1152921510398453452] = val_29;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        if(SA.IOSNative.StoreKit.SK_StoreReviewController.IsAvaliable != false)
        {
                SA.IOSNative.StoreKit.SK_StoreReviewController.RrequestReview();
            return;
        }
        
        UnityEngine.Debug.Log(message:  0);
    }
    private void HidePreloader()
    {
    
    }
    private void dismissAlert()
    {
    
    }
    private void onRatePopUpClose(IOSDialogResult result)
    {
        UnityEngine.LogType val_4;
        if(result == 4)
        {
            goto label_1;
        }
        
        if(result == 3)
        {
            goto label_2;
        }
        
        if(result != 2)
        {
            goto label_3;
        }
        
        val_4 = "Rate button pressed";
        goto label_5;
        label_1:
        val_4 = "Decline button pressed";
        goto label_5;
        label_2:
        val_4 = "Remind button pressed";
        label_5:
        ISN_Logger.Log(message:  19830, logType:  val_4);
        label_3:
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        string val_3 = 0 + result.ToString();
    }
    private void onDialogClose(IOSDialogResult result)
    {
        UnityEngine.LogType val_4;
        if(result == 1)
        {
            goto label_1;
        }
        
        if(result != 0)
        {
            goto label_2;
        }
        
        val_4 = "Yes button pressed";
        goto label_3;
        label_1:
        val_4 = "No button pressed";
        label_3:
        ISN_Logger.Log(message:  19827, logType:  val_4);
        label_2:
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        string val_3 = 0 + result.ToString();
    }
    private void onMessageClose()
    {
        ISN_Logger.Log(message:  19829, logType:  "Message was just closed");
    }
    private void GetLocale(ISN_Locale locale)
    {
        ISN_Logger.Log(message:  19825, logType:  "GetLocale");
        ISN_Logger.Log(message:  19825, logType:  locale._DisplayCountry);
        typeof(System.String[]).__il2cppRuntimeField_20 = "Country:";
        typeof(System.String[]).__il2cppRuntimeField_28 = locale._CountryCode;
        typeof(System.String[]).__il2cppRuntimeField_30 = "/";
        typeof(System.String[]).__il2cppRuntimeField_38 = locale._DisplayCountry;
        typeof(System.String[]).__il2cppRuntimeField_40 = "  :   Language:";
        typeof(System.String[]).__il2cppRuntimeField_48 = locale._LanguageCode;
        typeof(System.String[]).__il2cppRuntimeField_50 = "/";
        typeof(System.String[]).__il2cppRuntimeField_58 = locale._DisplayLanguage;
        string val_1 = +0;
        System.Action<ISN_Locale> val_2 = new System.Action<ISN_Locale>(object:  this, method:  System.Void PopUpExamples::GetLocale(ISN_Locale locale));
        IOSNativeUtility.remove_OnLocaleLoaded(value:  null);
    }

}
