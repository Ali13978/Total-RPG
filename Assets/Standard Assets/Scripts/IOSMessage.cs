using UnityEngine;
public class IOSMessage : BaseIOSPopup
{
    // Fields
    public string ok;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action OnComplete;
    private static System.Action <>f__am$cache0;
    
    // Methods
    public IOSMessage()
    {
        if((IOSMessage.<>f__am$cache0) == null)
        {
                IOSMessage.<>f__am$cache0 = new System.Action(object:  0, method:  static System.Void IOSMessage::<OnComplete>m__0());
            null = null;
        }
        
        this.OnComplete = IOSMessage.<>f__am$cache0;
    }
    public void add_OnComplete(System.Action value)
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
        while(1152921510301187280 != this.OnComplete);
    
    }
    public void remove_OnComplete(System.Action value)
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
        while(1152921510301323856 != this.OnComplete);
    
    }
    public static IOSMessage Create(string title, string message)
    {
        return IOSMessage.Create(title:  13051, message:  message, ok:  X2);
    }
    public static IOSMessage Create(string title, string message, string ok)
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "IOSPopUp");
        IOSMessage val_2 = AddComponent<IOSMessage>();
        if(val_2 != null)
        {
                mem2[0] = message;
            mem2[0] = ok;
            val_2.ok = X3;
            return val_2;
        }
        
        mem[24] = message;
        mem[32] = ok;
        mem[40] = X3;
        return val_2;
    }
    public void init()
    {
    
    }
    public void onPopUpCallBack(string buttonIndex)
    {
        this.OnComplete.Invoke();
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  0);
    }
    private static void <OnComplete>m__0()
    {
    
    }

}
