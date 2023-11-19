using UnityEngine;
private sealed class ModifierManager.<OncePerSecond>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal LlockhamIndustries.Decals.ModifierManager $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public ModifierManager.<OncePerSecond>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        var val_3;
        int val_4;
        int val_3 = this.$PC;
        this.$PC = 0;
        val_3 = val_3 | 1;
        if(val_3 != 1)
        {
            goto label_1;
        }
        
        val_3 = 0;
        goto label_2;
        label_9:
        val_3 = 1;
        label_2:
        if(val_3 >= this.$this.oneModifiers.Count)
        {
            goto label_6;
        }
        
        if(this.$this.oneModifiers.Item[1] != null)
        {
            goto label_9;
        }
        
        goto label_9;
        label_1:
        val_4 = 0;
        return (bool)val_4;
        label_6:
        val_4 = 1;
        this.$current = this.$this.second;
        if(this.$disposing == true)
        {
                return (bool)val_4;
        }
        
        this.$PC = val_4;
        return (bool)val_4;
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
