using UnityEngine;
private sealed class SA_iTween.<TweenRestart>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal SA.Common.Animation.SA_iTween $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public SA_iTween.<TweenRestart>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_5;
        SA.Common.Animation.SA_iTween val_6;
        SA.Common.Animation.SA_iTween val_7;
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
        
            val_6 = this.$this;
        }
        else
        {
                val_6 = this;
            if(this.$this.delay > 0f)
        {
                val_7 = null;
            delayStarted = UnityEngine.Time.time;
            val_5 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  this.$this.delay);
            if(this.$disposing == true)
        {
                return (bool)val_5;
        }
        
            this.$PC = val_5;
            return (bool)val_5;
        }
        
        }
        
        val_7 = mem[this.$this];
        mem2[0] = 1;
        mem[this.$this].TweenStart();
        val_5 = 0;
        this.$PC = 0;
        return (bool)val_5;
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
        goto __il2cppRuntimeField_this_arg;
    }

}
