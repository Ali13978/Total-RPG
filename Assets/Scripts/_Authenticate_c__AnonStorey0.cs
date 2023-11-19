using UnityEngine;
private sealed class NativeClient.<Authenticate>c__AnonStorey0
{
    // Fields
    internal System.Action<bool, string> callback;
    internal GooglePlayGames.Native.NativeClient $this;
    
    // Methods
    public NativeClient.<Authenticate>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(int result)
    {
        GooglePlayGames.Native.NativeClient val_3;
        System.Action<System.Boolean, System.String> val_4;
        var val_5;
        System.Action<T, S> val_6;
        object val_7;
        val_3 = this.$this;
        val_3.InitializeGameServices();
        if(result == 16)
        {
            goto label_2;
        }
        
        if(result == 8)
        {
            goto label_3;
        }
        
        if(result != 0)
        {
            goto label_4;
        }
        
        if(this.callback == null)
        {
            goto label_5;
        }
        
        val_3 = this.$this;
        val_4 = System.Delegate.Combine(a:  0, b:  this.$this.mPendingAuthCallbacks);
        if(val_4 != null)
        {
                if(null == null)
        {
            goto label_9;
        }
        
        }
        
        val_4 = 0;
        label_9:
        this.$this.mPendingAuthCallbacks = val_4;
        label_5:
        System.Threading.Monitor.Enter(obj:  0);
        System.Threading.Monitor.Exit(obj:  0);
        this.$this.mServices.StartAuthorizationUI();
        return;
        label_2:
        val_5 = "Authentication canceled";
        val_6 = 0;
        val_7 = 0;
        goto label_13;
        label_3:
        val_5 = "Authentication failed - developer error";
        val_6 = 0;
        val_7 = 0;
        goto label_13;
        label_4:
        val_5 = "Authentication failed";
        val_6 = 0;
        val_7 = 0;
        label_13:
        GooglePlayGames.Native.NativeClient.InvokeCallbackOnGameThread<System.Boolean, System.Object>(callback:  val_6, data:  this.callback, msg:  val_7);
    }

}
