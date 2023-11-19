using UnityEngine;
private sealed class WallHackDetector.<CaptureFrame>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal UnityEngine.RenderTexture <previousActive>__0;
    internal bool <detected>__0;
    internal CodeStage.AntiCheat.Detectors.WallHackDetector $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public WallHackDetector.<CaptureFrame>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_33;
        int val_33 = this.$PC;
        val_33 = 0;
        this.$PC = 0;
        val_33 = (val_33 < 4) ? (val_33 + 3) : 0;
        val_33 = val_33 - 3;
        if(val_33 > 3)
        {
                return (bool);
        }
        
        var val_34 = 25836424 + ((this.$PC < 4 ? (this.$PC + 3) : 0 - 3)) << 2;
        val_34 = val_34 + 25836424;
        goto (25836424 + ((this.$PC < 4 ? (this.$PC + 3) : 0 - 3)) << 2 + 25836424);
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
