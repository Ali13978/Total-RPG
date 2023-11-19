using UnityEngine;
private sealed class DestroyOnTime.<destroy>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <startTime>__0;
    internal DestroyOnTime $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public DestroyOnTime.<destroy>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_7;
        int val_7 = this.$PC;
        this.$PC = 0;
        val_7 = ((val_7 == 1) ? 1 : 0) << 2;
        var val_2 = (val_7 == 0) ? 3 : (val_7);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_7 = 0;
        if(val_2 == 4)
        {
            goto label_2;
        }
        
        return (bool)val_7;
        label_1:
        this.<startTime>__0 = UnityEngine.Time.time;
        label_2:
        if((UnityEngine.Time.time - (this.<startTime>__0)) >= 0)
        {
                UnityEngine.GameObject val_6 = this.$this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            val_7 = 0;
            this.$PC = 0;
            return (bool)val_7;
        }
        
        val_7 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_7;
        }
        
        this.$PC = val_7;
        return (bool)val_7;
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
