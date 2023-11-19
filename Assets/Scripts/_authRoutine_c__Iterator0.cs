using UnityEngine;
private sealed class SocialSystem.<authRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal System.Collections.Generic.List.Enumerator<System.Action<bool, string>> $locvar0;
    internal TzarGames.Endless.SocialSystem $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    private TzarGames.Endless.SocialSystem.<authRoutine>c__Iterator0.<authRoutine>c__AnonStorey3 $locvar1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public SocialSystem.<authRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        var val_8;
        List.Enumerator<System.Action<System.Boolean, System.String>> val_9;
        int val_14;
        TzarGames.Endless.SocialSystem val_15;
        IntPtr val_16;
        IntPtr val_17;
        bool val_18;
        var val_19;
        <authRoutine>c__AnonStorey3 val_20;
        var val_24;
        var val_25;
        int val_14 = this.$PC;
        this.$PC = 0;
        val_14 = ((val_14 == 1) ? 1 : 0) << 2;
        var val_2 = (val_14 == 0) ? 3 : (val_14);
        if(val_2 != 3)
        {
                val_14 = 0;
            if(val_2 != 4)
        {
                return (bool)val_14;
        }
        
            val_15 = this.$this;
        }
        else
        {
                this.$locvar1 = new System.Object();
            typeof(SocialSystem.<authRoutine>c__Iterator0.<authRoutine>c__AnonStorey3).__il2cppRuntimeField_20 = this;
            this.$locvar1.authResult = false;
            this.$locvar1.authMessage = 0;
            val_15 = this;
            this.$this.authInProcess = true;
            if(this.$this.LogDebugInfo != false)
        {
                UnityEngine.Debug.Log(message:  0);
        }
        
            val_16 = System.Void SocialSystem.<authRoutine>c__Iterator0.<authRoutine>c__AnonStorey3::<>m__0(bool result, string message);
            System.Action<System.Boolean, System.String> val_5 = null;
            val_17 = val_16;
            val_18 = val_5;
            val_5 = new System.Action<System.Boolean, System.String>(object:  this.$locvar1, method:  val_17);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_17 = 0;
            val_19 = UnityEngine.Social.localUser;
            this.$this.onAuthenticationStarted.Invoke();
        }
        
        if(this.$this.authInProcess != false)
        {
                val_14 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_14;
        }
        
            this.$PC = val_14;
            return (bool)val_14;
        }
        
        if(this.$this.LogDebugInfo != false)
        {
                UnityEngine.Debug.Log(message:  0);
        }
        
        List.Enumerator<T> val_7 = this.$this.authCallbacks.GetEnumerator();
        mem[1152921510847264480] = val_8;
        this.$locvar0 = val_9;
        label_39:
        if(((this.$locvar0 & 1) & 1) == 0)
        {
            goto label_29;
        }
        
        val_20 = this.$locvar1;
        if(val_20 != null)
        {
                var val_12 = (this.$locvar1.authResult == true) ? 1 : 0;
        }
        else
        {
                val_20 = this.$locvar1;
            if(val_20 == null)
        {
                val_20 = 0;
        }
        
        }
        
        this.$locvar0.InitializationCallback.Invoke(arg1:  (this.$locvar1.authResult == true) ? 1 : 0, arg2:  7254272);
        goto label_39;
        label_29:
        val_24 = 0;
        val_25 = 1;
        this.$locvar0.Dispose();
        this.$this.authCallbacks.Clear();
        val_18 = this.$locvar1.authResult;
        if(val_18 != false)
        {
                this.$this.onAuthenticationSuccess.Invoke();
        }
        else
        {
                val_18 = this.$locvar1.authMessage;
            this.$this.onAuthenticationFailed.Invoke(arg0:  val_18);
        }
        
        val_14 = 0;
        this.$PC = 0;
        return (bool)val_14;
        label_59:
        mem[8] = null;
        goto label_59;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.Generic.IEnumerator<object>.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Dispose()
    {
        this.$disposing = true;
        this.$PC = 0;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
