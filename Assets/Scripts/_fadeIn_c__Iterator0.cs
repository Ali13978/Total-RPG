using UnityEngine;
private sealed class ActionNodePlaySound.<fadeIn>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <totalTime>__0;
    internal TzarGames.Common.ScriptViz.ActionNodePlaySound $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public ActionNodePlaySound.<fadeIn>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_5;
        float val_6;
        UnityEngine.AudioSource val_7;
        TzarGames.Common.ScriptViz.ActionNodePlaySound val_8;
        TzarGames.Common.ScriptViz.ActionNodePlaySound val_9;
        int val_5 = this.$PC;
        this.$PC = 0;
        val_5 = ((val_5 == 1) ? 1 : 0) << 2;
        var val_2 = (val_5 == 0) ? 3 : (val_5);
        if(val_2 != 3)
        {
                val_5 = 0;
            if(val_2 != 4)
        {
                return (bool)val_5;
        }
        
            val_6 = this.<totalTime>__0;
        }
        else
        {
                val_6 = 0f;
            this.<totalTime>__0 = 0f;
        }
        
        if(this.$this == null)
        {
            goto label_3;
        }
        
        val_7 = this.$this.audioSource;
        if(val_6 < 0)
        {
            goto label_7;
        }
        
        goto label_5;
        label_3:
        val_8 = this.$this;
        val_7 = this.$this.audioSource;
        if(val_6 < 0)
        {
            goto label_7;
        }
        
        label_5:
        val_7.volume = 1f;
        val_5 = 0;
        this.$PC = 0;
        return (bool)val_5;
        label_7:
        val_8 = this.$this;
        val_9 = val_8;
        if(val_8 != null)
        {
            goto label_10;
        }
        
        val_9 = this.$this;
        if(val_9 == null)
        {
            goto label_11;
        }
        
        label_10:
        float val_3 = (this.<totalTime>__0) / this.$this.fadeInTime;
        val_3 = val_3 * this.$this.volume;
        val_7.volume = val_3;
        val_6 = this.<totalTime>__0;
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = val_6 + val_4;
        val_5 = 1;
        this.<totalTime>__0 = val_4;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_5;
        }
        
        this.$PC = val_5;
        return (bool)val_5;
        label_11:
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
