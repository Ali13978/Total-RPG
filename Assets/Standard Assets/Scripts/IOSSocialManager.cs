using UnityEngine;
public class IOSSocialManager : Singleton<IOSSocialManager>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action OnFacebookPostStart;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action OnTwitterPostStart;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action OnInstagramPostStart;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnFacebookPostResult;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnTwitterPostResult;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnInstagramPostResult;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnMailResult;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<TextMessageComposeResult> OnTextMessageResult;
    private static System.Action<TextMessageComposeResult> <>f__am$cache0;
    
    // Methods
    public IOSSocialManager()
    {
    
    }
    public static void add_OnFacebookPostStart(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnFacebookPostStart;
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
    public static void remove_OnFacebookPostStart(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnFacebookPostStart;
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
    public static void add_OnTwitterPostStart(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnTwitterPostStart;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467080 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnTwitterPostStart(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnTwitterPostStart;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467080 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnInstagramPostStart(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnInstagramPostStart;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467088 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnInstagramPostStart(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnInstagramPostStart;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467088 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnFacebookPostResult(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnFacebookPostResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467096 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnFacebookPostResult(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnFacebookPostResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467096 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnTwitterPostResult(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnTwitterPostResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467104 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnTwitterPostResult(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnTwitterPostResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467104 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnInstagramPostResult(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnInstagramPostResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467112 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnInstagramPostResult(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnInstagramPostResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467112 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnMailResult(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnMailResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467120 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnMailResult(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnMailResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467120 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void ShareMedia(string text, UnityEngine.Texture2D texture)
    {
    
    }
    public void TwitterPost(string text, string url, UnityEngine.Texture2D texture)
    {
        null = null;
        IOSSocialManager.OnTwitterPostStart.Invoke();
    }
    public void TwitterPostGif(string text, string url)
    {
    
    }
    public void FacebookPost(string text, string url, UnityEngine.Texture2D texture)
    {
        null = null;
        IOSSocialManager.OnFacebookPostStart.Invoke();
    }
    public void InstagramPost(UnityEngine.Texture2D texture)
    {
        InstagramPost(texture:  texture, message:  null);
    }
    public void InstagramPost(UnityEngine.Texture2D texture, string message)
    {
        null = null;
        IOSSocialManager.OnInstagramPostStart.Invoke();
    }
    public void WhatsAppShareText(string message)
    {
    
    }
    public void WhatsAppShareImage(UnityEngine.Texture2D texture)
    {
    
    }
    public void SendMail(string subject, string body, string recipients)
    {
        this.SendMail(subject:  subject, body:  body, recipients:  recipients, texture:  0);
    }
    public void SendMail(string subject, string body, string recipients, UnityEngine.Texture2D texture)
    {
        bool val_1 = UnityEngine.Object.op_Equality(x:  0, y:  texture);
    }
    public static void add_OnTextMessageResult(System.Action<TextMessageComposeResult> value)
    {
        var val_3;
        System.Action<TextMessageComposeResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnTextMessageResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467128 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnTextMessageResult(System.Action<TextMessageComposeResult> value)
    {
        var val_3;
        System.Action<TextMessageComposeResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = IOSSocialManager.OnTextMessageResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = IOSSocialManager.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504846467128 != val_4)
        {
            goto label_8;
        }
    
    }
    public void SendTextMessage(string body, string recepient, System.Action<TextMessageComposeResult> callback)
    {
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        Add(item:  recepient);
        SendTextMessage(body:  recepient, recepients:  public System.Void System.Collections.Generic.List<System.String>::Add(System.String item), callback:  callback);
    }
    public void SendTextMessage(string body, System.Collections.Generic.List<string> recepients, System.Action<TextMessageComposeResult> callback)
    {
        IOSSocialManager.add_OnTextMessageResult(value:  null);
    }
    private void OnTextMessageComposeResult(string data)
    {
        TextMessageComposeResult val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = System.Convert.ToInt32(value:  0);
        val_4 = null;
        val_4 = null;
        IOSSocialManager.OnTextMessageResult.Invoke(obj:  val_3);
        val_5 = null;
        if((IOSSocialManager.<>f__am$cache0) == null)
        {
                System.Action<TextMessageComposeResult> val_2 = null;
            val_3 = val_2;
            val_2 = new System.Action<TextMessageComposeResult>(object:  0, method:  static System.Void IOSSocialManager::<OnTextMessageComposeResult>m__0(TextMessageComposeResult ));
            val_6 = null;
            val_6 = null;
            IOSSocialManager.<>f__am$cache0 = val_3;
            val_5 = null;
        }
        
        val_5 = null;
        IOSSocialManager.OnTextMessageResult = IOSSocialManager.<>f__am$cache0;
    }
    private void OnTwitterPostFailed()
    {
        var val_3 = null;
        IOSSocialManager.OnTwitterPostResult.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error()));
    }
    private void OnTwitterPostSuccess()
    {
        var val_2 = null;
        IOSSocialManager.OnTwitterPostResult.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnFacebookPostFailed()
    {
        var val_3 = null;
        IOSSocialManager.OnFacebookPostResult.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error()));
    }
    private void OnFacebookPostSuccess()
    {
        var val_2 = null;
        IOSSocialManager.OnFacebookPostResult.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnMailFailed()
    {
        var val_3 = null;
        IOSSocialManager.OnMailResult.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error()));
    }
    private void OnMailSuccess()
    {
        var val_2 = null;
        IOSSocialManager.OnMailResult.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnInstaPostSuccess()
    {
        var val_2 = null;
        IOSSocialManager.OnInstagramPostResult.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnInstaPostFailed(string data)
    {
        var val_4 = null;
        IOSSocialManager.OnInstagramPostResult.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(code:  System.Convert.ToInt32(value:  0), message:  "Posting Failed")));
    }
    private static IOSSocialManager()
    {
        IOSSocialManager.OnFacebookPostStart = new System.Action(object:  0, method:  static System.Void IOSSocialManager::<OnFacebookPostStart>m__1());
        IOSSocialManager.OnTwitterPostStart = new System.Action(object:  0, method:  static System.Void IOSSocialManager::<OnTwitterPostStart>m__2());
        IOSSocialManager.OnInstagramPostStart = new System.Action(object:  0, method:  static System.Void IOSSocialManager::<OnInstagramPostStart>m__3());
        IOSSocialManager.OnFacebookPostResult = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void IOSSocialManager::<OnFacebookPostResult>m__4(SA.Common.Models.Result ));
        IOSSocialManager.OnTwitterPostResult = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void IOSSocialManager::<OnTwitterPostResult>m__5(SA.Common.Models.Result ));
        IOSSocialManager.OnInstagramPostResult = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void IOSSocialManager::<OnInstagramPostResult>m__6(SA.Common.Models.Result ));
        IOSSocialManager.OnMailResult = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void IOSSocialManager::<OnMailResult>m__7(SA.Common.Models.Result ));
        IOSSocialManager.OnTextMessageResult = new System.Action<TextMessageComposeResult>(object:  0, method:  static System.Void IOSSocialManager::<OnTextMessageResult>m__8(TextMessageComposeResult ));
    }
    private static void <OnTextMessageComposeResult>m__0(TextMessageComposeResult )
    {
    
    }
    private static void <OnFacebookPostStart>m__1()
    {
    
    }
    private static void <OnTwitterPostStart>m__2()
    {
    
    }
    private static void <OnInstagramPostStart>m__3()
    {
    
    }
    private static void <OnFacebookPostResult>m__4(SA.Common.Models.Result )
    {
    
    }
    private static void <OnTwitterPostResult>m__5(SA.Common.Models.Result )
    {
    
    }
    private static void <OnInstagramPostResult>m__6(SA.Common.Models.Result )
    {
    
    }
    private static void <OnMailResult>m__7(SA.Common.Models.Result )
    {
    
    }
    private static void <OnTextMessageResult>m__8(TextMessageComposeResult )
    {
    
    }

}
