using UnityEngine;
private sealed class LevelLoader.<LoadLevel>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal string levelName;
    internal UnityEngine.WWW <request>__0;
    internal TzarGames.Common.LevelLoader $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public LevelLoader.<LoadLevel>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_17;
        int val_17 = this.$PC;
        val_17 = 0;
        this.$PC = 0;
        val_17 = (val_17 < 4) ? (val_17 + 3) : 0;
        val_17 = val_17 - 3;
        if(val_17 > 3)
        {
                return (bool);
        }
        
        var val_18 = 25807488 + ((this.$PC < 4 ? (this.$PC + 3) : 0 - 3)) << 2;
        val_18 = val_18 + 25807488;
        goto (25807488 + ((this.$PC < 4 ? (this.$PC + 3) : 0 - 3)) << 2 + 25807488);
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
