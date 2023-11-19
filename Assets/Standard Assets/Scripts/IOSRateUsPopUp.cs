using UnityEngine;
public class IOSRateUsPopUp : BaseIOSPopup
{
    // Fields
    public string rate;
    public string remind;
    public string declined;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action<IOSDialogResult> OnComplete;
    private static System.Action<IOSDialogResult> <>f__am$cache0;
    
    // Methods
    public IOSRateUsPopUp()
    {
        if((IOSRateUsPopUp.<>f__am$cache0) == null)
        {
                IOSRateUsPopUp.<>f__am$cache0 = new System.Action<IOSDialogResult>(object:  0, method:  static System.Void IOSRateUsPopUp::<OnComplete>m__0(IOSDialogResult ));
            null = null;
        }
        
        this.OnComplete = IOSRateUsPopUp.<>f__am$cache0;
    }
    public void add_OnComplete(System.Action<IOSDialogResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnComplete);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510302208304 != this.OnComplete);
    
    }
    public void remove_OnComplete(System.Action<IOSDialogResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnComplete);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510302344880 != this.OnComplete);
    
    }
    public static IOSRateUsPopUp Create()
    {
        return IOSRateUsPopUp.Create(title:  13077, message:  "Like the Game?");
    }
    public static IOSRateUsPopUp Create(string title, string message)
    {
        return IOSRateUsPopUp.Create(title:  13076, message:  message, rate:  X2, remind:  "Rate Now", declined:  "Ask me later");
    }
    public static IOSRateUsPopUp Create(string title, string message, string rate, string remind, string declined)
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "IOSRateUsPopUp");
        IOSRateUsPopUp val_2 = AddComponent<IOSRateUsPopUp>();
        if(val_2 != null)
        {
                mem2[0] = message;
            mem2[0] = rate;
            val_2.rate = remind;
            val_2.remind = declined;
            val_2.declined = X5;
            return val_2;
        }
        
        mem[24] = message;
        mem[32] = rate;
        mem[40] = remind;
        mem[48] = declined;
        mem[56] = X5;
        return val_2;
    }
    public void init()
    {
    
    }
    public void onPopUpCallBack(string buttonIndex)
    {
        System.Action<IOSDialogResult> val_4;
        IOSDialogResult val_5;
        var val_6;
        short val_2 = (System.Convert.ToInt16(value:  0)) & 65535;
        if(val_2 == 2)
        {
            goto label_3;
        }
        
        if(val_2 == 1)
        {
            goto label_4;
        }
        
        if(val_2 != 0)
        {
            goto label_5;
        }
        
        IOSNativeUtility.RedirectToAppStoreRatingPage();
        val_4 = this.OnComplete;
        val_5 = 2;
        val_6 = public System.Void System.Action<IOSDialogResult>::Invoke(IOSDialogResult obj);
        goto label_11;
        label_3:
        val_4 = this.OnComplete;
        val_5 = 4;
        val_6 = public System.Void System.Action<IOSDialogResult>::Invoke(IOSDialogResult obj);
        goto label_11;
        label_4:
        val_4 = this.OnComplete;
        val_5 = 3;
        val_6 = public System.Void System.Action<IOSDialogResult>::Invoke(IOSDialogResult obj);
        label_11:
        val_4.Invoke(obj:  val_5);
        label_5:
        UnityEngine.GameObject val_3 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  0);
    }
    private static void <OnComplete>m__0(IOSDialogResult )
    {
    
    }

}
