using UnityEngine;
private sealed class CoroutineQueue.<Process>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal Unitycoding.CoroutineQueue $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public CoroutineQueue.<Process>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        Unitycoding.CoroutineQueue val_4;
        int val_5;
        this.$PC = 0;
        if(this.$PC > 2)
        {
            goto label_1;
        }
        
        if(this.$this.actions.Count < 1)
        {
            goto label_4;
        }
        
        val_4 = this.$this;
        if(this.$this != null)
        {
            goto label_5;
        }
        
        val_4 = this.$this;
        if(val_4 == null)
        {
            goto label_6;
        }
        
        label_5:
        this.$current = this.$this.m_Owner.StartCoroutine(routine:  this.$this.actions.Dequeue());
        val_5 = 1;
        if(this.$disposing == true)
        {
                return (bool)val_5;
        }
        
        this.$PC = val_5;
        return (bool)val_5;
        label_1:
        val_5 = 0;
        return (bool)val_5;
        label_4:
        this.$current = 0;
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_5 = 1;
        return (bool)val_5;
        label_6:
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
