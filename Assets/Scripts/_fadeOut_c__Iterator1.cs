using UnityEngine;
private sealed class ActionNodePlaySound.<fadeOut>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <totalTime>__0;
    internal float <startVolume>__0;
    internal TzarGames.Common.ScriptViz.ActionNodePlaySound $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public ActionNodePlaySound.<fadeOut>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_6;
        float val_7;
        TzarGames.Common.ScriptViz.ActionNodePlaySound val_8;
        float val_9;
        UnityEngine.AudioSource val_10;
        int val_6 = this.$PC;
        this.$PC = 0;
        val_6 = ((val_6 == 1) ? 1 : 0) << 2;
        var val_2 = (val_6 == 0) ? 3 : (val_6);
        if(val_2 != 3)
        {
                val_6 = 0;
            if(val_2 != 4)
        {
                return (bool)val_6;
        }
        
            val_7 = this.<totalTime>__0;
            val_8 = this.$this;
        }
        else
        {
                val_7 = this;
            this.<totalTime>__0 = 0f;
            val_8 = this;
            this.<startVolume>__0 = this.$this.audioSource.volume;
        }
        
        val_9 = this.<totalTime>__0;
        if(null == null)
        {
            goto label_5;
        }
        
        val_10 = mem[this.$this + 112];
        val_10 = this.$this.audioSource;
        if(val_9 >= 0)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        val_10 = mem[this.$this + 112];
        val_10 = this.$this.audioSource;
        if(val_9 < 0)
        {
            goto label_9;
        }
        
        label_6:
        val_10.volume = 0f;
        val_6 = 0;
        this.$PC = 0;
        return (bool)val_6;
        label_9:
        val_7 = null;
        float val_4 = (this.<totalTime>__0) / this.$this.fadeOutTime;
        val_4 = 1f - val_4;
        val_4 = (this.<startVolume>__0) * val_4;
        val_10.volume = val_4;
        val_9 = this.<totalTime>__0;
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = val_9 + val_5;
        val_6 = 1;
        this.<totalTime>__0 = val_5;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_6;
        }
        
        this.$PC = val_6;
        return (bool)val_6;
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
