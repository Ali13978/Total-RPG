using UnityEngine;
public class ISN_Security : Singleton<ISN_Security>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<ISN_LocalReceiptResult> OnReceiptLoaded;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnReceiptRefreshComplete;
    
    // Methods
    public ISN_Security()
    {
    
    }
    public static void add_OnReceiptLoaded(System.Action<ISN_LocalReceiptResult> value)
    {
        var val_3;
        System.Action<ISN_LocalReceiptResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_Security.OnReceiptLoaded;
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
    public static void remove_OnReceiptLoaded(System.Action<ISN_LocalReceiptResult> value)
    {
        var val_3;
        System.Action<ISN_LocalReceiptResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_Security.OnReceiptLoaded;
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
    public static void add_OnReceiptRefreshComplete(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_Security.OnReceiptRefreshComplete;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_Security.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504848969736 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnReceiptRefreshComplete(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_Security.OnReceiptRefreshComplete;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_Security.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504848969736 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void RetrieveLocalReceipt()
    {
    
    }
    public void StartReceiptRefreshRequest()
    {
    
    }
    private void Event_ReceiptLoaded(string data)
    {
        var val_2 = null;
        ISN_Security.OnReceiptLoaded.Invoke(obj:  new ISN_LocalReceiptResult(data:  data));
    }
    private void Event_ReceiptRefreshRequestReceived(string data)
    {
        SA.Common.Models.Result val_5;
        var val_6;
        if((data.Equals(value:  "1")) != false)
        {
                SA.Common.Models.Result val_2 = null;
            val_5 = val_2;
            val_2 = new SA.Common.Models.Result();
        }
        else
        {
                SA.Common.Models.Result val_4 = null;
            val_5 = val_4;
            val_4 = new SA.Common.Models.Result(error:  new SA.Common.Models.Error());
        }
        
        val_6 = null;
        val_6 = null;
        ISN_Security.OnReceiptRefreshComplete.Invoke(obj:  val_5);
    }
    private static ISN_Security()
    {
        ISN_Security.OnReceiptLoaded = new System.Action<ISN_LocalReceiptResult>(object:  0, method:  static System.Void ISN_Security::<OnReceiptLoaded>m__0(ISN_LocalReceiptResult ));
        ISN_Security.OnReceiptRefreshComplete = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void ISN_Security::<OnReceiptRefreshComplete>m__1(SA.Common.Models.Result ));
    }
    private static void <OnReceiptLoaded>m__0(ISN_LocalReceiptResult )
    {
    
    }
    private static void <OnReceiptRefreshComplete>m__1(SA.Common.Models.Result )
    {
    
    }

}
