using UnityEngine;
private sealed class LowHealthUI.<enableColor>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.UI.LowHealthUI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public LowHealthUI.<enableColor>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_5;
        var val_6;
        int val_5 = this.$PC;
        this.$PC = 0;
        val_5 = ((val_5 == 1) ? 1 : 0) << 2;
        var val_2 = (val_5 == 0) ? 3 : (val_5);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_5 = 0;
        if(val_2 != 4)
        {
                return (bool)val_5;
        }
        
        val_6 = 0;
        goto label_3;
        label_11:
        val_6 = 1;
        label_3:
        if(val_6 >= this.$this.renderCount)
        {
            goto label_5;
        }
        
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        if((this.$this.canvasRenderers[1].GetComponent<UnityEngine.UI.Graphic>()) != null)
        {
            goto label_11;
        }
        
        goto label_11;
        label_1:
        val_5 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_5;
        }
        
        this.$PC = val_5;
        return (bool)val_5;
        label_5:
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
    }

}
