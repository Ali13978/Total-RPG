using UnityEngine;
private sealed class FinalBossLogic.<testLogic>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.FinalBossLogic $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public FinalBossLogic.<testLogic>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_7;
        int val_7 = this.$PC;
        val_7 = 0;
        this.$PC = 0;
        val_7 = (val_7 < 6) ? (val_7 + 3) : 0;
        val_7 = val_7 - 3;
        if(val_7 > 5)
        {
                return (bool);
        }
        
        var val_8 = 25804264 + ((this.$PC < 6 ? (this.$PC + 3) : 0 - 3)) << 2;
        val_8 = val_8 + 25804264;
        goto (25804264 + ((this.$PC < 6 ? (this.$PC + 3) : 0 - 3)) << 2 + 25804264);
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
