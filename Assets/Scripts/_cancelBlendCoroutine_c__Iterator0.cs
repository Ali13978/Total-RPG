using UnityEngine;
private sealed class CutsceneUI.<cancelBlendCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal Cinemachine.CinemachineBrain brain;
    internal float <waitTime>__0;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public CutsceneUI.<cancelBlendCoroutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_16;
        float val_17;
        Cinemachine.CinemachineBrain val_18;
        float val_19;
        int val_16 = this.$PC;
        this.$PC = 0;
        val_16 = (val_16 < 3) ? (val_16 + 3) : 0;
        if(val_16 == 3)
        {
            goto label_1;
        }
        
        if(val_16 == 4)
        {
            goto label_2;
        }
        
        val_16 = 0;
        if(val_16 != 5)
        {
                return (bool)val_16;
        }
        
        val_17 = this.<waitTime>__0;
        val_18 = this.brain;
        goto label_4;
        label_1:
        if(this.brain.ActiveBlend != null)
        {
                val_18 = this.brain.ActiveBlend;
            val_19 = val_18.Duration;
            this.brain.ActiveBlend.TimeInBlend = val_19;
        }
        
        val_16 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_16;
        }
        
        this.$PC = val_16;
        return (bool)val_16;
        label_2:
        val_18 = this;
        if(0 == this.brain)
        {
            goto label_21;
        }
        
        val_17 = this;
        this.<waitTime>__0 = UnityEngine.Time.time;
        label_4:
        val_19 = UnityEngine.Time.time;
        if((val_19 - (this.<waitTime>__0)) < 0)
        {
                if(null.ActiveBlend == null)
        {
            goto label_19;
        }
        
        }
        
        if(null.ActiveBlend != null)
        {
                val_18 = null.ActiveBlend;
            val_19 = val_18.Duration;
            null.ActiveBlend.TimeInBlend = val_19;
            val_16 = 0;
            this.$PC = 0;
            return (bool)val_16;
        }
        
        label_21:
        val_16 = 0;
        return (bool)val_16;
        label_19:
        this.$current = 0;
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_16 = 1;
        return (bool)val_16;
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
