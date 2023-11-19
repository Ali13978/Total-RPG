using UnityEngine;
public class IOSDialog : BaseIOSPopup
{
    // Fields
    public string yes;
    public string no;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action<IOSDialogResult> OnComplete;
    private static System.Action<IOSDialogResult> <>f__am$cache0;
    
    // Methods
    public IOSDialog()
    {
        if((IOSDialog.<>f__am$cache0) == null)
        {
                IOSDialog.<>f__am$cache0 = new System.Action<IOSDialogResult>(object:  0, method:  static System.Void IOSDialog::<OnComplete>m__0(IOSDialogResult ));
            null = null;
        }
        
        this.OnComplete = IOSDialog.<>f__am$cache0;
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
        while(1152921510300140504 != this.OnComplete);
    
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
        while(1152921510300277080 != this.OnComplete);
    
    }
    public static IOSDialog Create(string title, string message)
    {
        return IOSDialog.Create(title:  13020, message:  message, yes:  X2, no:  "Yes");
    }
    public static IOSDialog Create(string title, string message, string yes, string no)
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "IOSPopUp");
        IOSDialog val_2 = AddComponent<IOSDialog>();
        if(val_2 != null)
        {
                mem2[0] = message;
            mem2[0] = yes;
            val_2.yes = no;
            val_2.no = X4;
            return val_2;
        }
        
        mem[24] = message;
        mem[32] = yes;
        mem[40] = no;
        mem[48] = X4;
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
        if(val_2 == 1)
        {
            goto label_3;
        }
        
        if(val_2 != 0)
        {
            goto label_4;
        }
        
        val_4 = this.OnComplete;
        val_5 = 0;
        val_6 = public System.Void System.Action<IOSDialogResult>::Invoke(IOSDialogResult obj);
        goto label_6;
        label_3:
        val_4 = this.OnComplete;
        val_5 = 1;
        val_6 = public System.Void System.Action<IOSDialogResult>::Invoke(IOSDialogResult obj);
        label_6:
        val_4.Invoke(obj:  val_5);
        label_4:
        UnityEngine.GameObject val_3 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  0);
    }
    private static void <OnComplete>m__0(IOSDialogResult )
    {
    
    }

}
