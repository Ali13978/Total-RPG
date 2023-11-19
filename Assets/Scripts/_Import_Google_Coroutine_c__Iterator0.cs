using UnityEngine;
private sealed class LanguageSource.<Import_Google_Coroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal bool JustCheck;
    internal UnityEngine.WWW <www>__0;
    internal bool <notError>__0;
    internal string <wwwText>__0;
    internal I2.Loc.LanguageSource $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public LanguageSource.<Import_Google_Coroutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        I2.Loc.LanguageSource val_19;
        int val_20;
        UnityEngine.WWW val_21;
        var val_22;
        string val_23;
        var val_24;
        I2.Loc.LanguageSource val_25;
        I2.Loc.LanguageSource val_26;
        var val_27;
        I2.Loc.LanguageSource val_28;
        val_19 = this;
        int val_18 = this.$PC;
        this.$PC = 0;
        val_18 = ((val_18 == 1) ? 1 : 0) << 2;
        var val_2 = (val_18 == 0) ? 3 : (val_18);
        if(val_2 == 4)
        {
            goto label_1;
        }
        
        val_20 = 0;
        if(val_2 != 3)
        {
                return (bool)val_20;
        }
        
        UnityEngine.WWW val_3 = this.$this.Import_Google_CreateWWWcall(ForceUpdate:  false, justCheck:  false);
        val_22 = val_19;
        val_20 = 0;
        this.<www>__0 = val_3;
        if(val_3 != null)
        {
            goto label_6;
        }
        
        return (bool)val_20;
        label_1:
        val_22 = val_19;
        val_21 = this.<www>__0;
        if(val_21 == null)
        {
                val_21 = 0;
        }
        
        label_6:
        if(val_21.isDone == false)
        {
            goto label_7;
        }
        
        string val_5 = this.<www>__0.error;
        bool val_6 = System.String.IsNullOrEmpty(value:  0);
        this.<notError>__0 = val_6;
        this.<wwwText>__0 = 0;
        if(val_6 == false)
        {
            goto label_11;
        }
        
        System.Byte[] val_8 = this.<www>__0.bytes;
        val_23 = System.Text.Encoding.UTF8;
        this.<wwwText>__0 = val_23;
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_19;
        }
        
        val_24 = 1;
        goto label_20;
        label_7:
        val_20 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_20;
        }
        
        this.$PC = val_20;
        return (bool)val_20;
        label_19:
        val_24 = System.String.op_Equality(a:  0, b:  this.<wwwText>__0);
        label_20:
        if(this.JustCheck == false)
        {
            goto label_25;
        }
        
        if(val_24 == true)
        {
            goto label_26;
        }
        
        UnityEngine.Debug.LogWarning(message:  0);
        val_19 = this.$this;
        val_20 = 0;
        this.$this.GoogleLiveSyncIsUptoDate = false;
        return (bool)val_20;
        label_25:
        if(val_24 == false)
        {
            goto label_31;
        }
        
        label_11:
        if(this.$this.Event_OnSourceUpdateFromGoogle != null)
        {
                val_25 = this.$this;
            if(this.$this == null)
        {
                val_25 = this.$this;
        }
        
            val_23 = this.$this.Event_OnSourceUpdateFromGoogle;
            val_23.Invoke(arg1:  val_25, arg2:  false, arg3:  this.<www>__0.error);
        }
        
        UnityEngine.Debug.Log(message:  0);
        val_20 = 0;
        this.$PC = 0;
        return (bool)val_20;
        label_31:
        string val_14 = this.$this.Import_Google_Result(JsonString:  this.<wwwText>__0, UpdateMode:  1, saveInPlayerPrefs:  true);
        val_23 = this.$this;
        if((System.String.IsNullOrEmpty(value:  0)) != false)
        {
                if(this.$this.Event_OnSourceUpdateFromGoogle != null)
        {
                val_26 = this.$this;
            if(this.$this == null)
        {
                val_26 = this.$this;
        }
        
            val_19 = this.$this.Event_OnSourceUpdateFromGoogle;
            val_23 = this.<www>__0.error;
            val_19.Invoke(arg1:  val_26, arg2:  true, arg3:  val_23);
        }
        
            I2.Loc.LocalizationManager.LocalizeAll(Force:  false);
            val_27 = "Done Google Sync";
        }
        else
        {
                if(this.$this.Event_OnSourceUpdateFromGoogle != null)
        {
                val_28 = this.$this;
            if(this.$this == null)
        {
                val_28 = this.$this;
        }
        
            val_19 = this.$this.Event_OnSourceUpdateFromGoogle;
            val_23 = this.<www>__0.error;
            val_19.Invoke(arg1:  val_28, arg2:  false, arg3:  val_23);
        }
        
            val_27 = "Done Google Sync: source was up-to-date";
        }
        
        UnityEngine.Debug.Log(message:  0);
        label_26:
        val_20 = 0;
        return (bool)val_20;
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
