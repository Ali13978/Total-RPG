using UnityEngine;
private sealed class Tester.<lobbyTest>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.EndlessGameState <game>__0;
    internal bool <inLobby>__1;
    internal float interval;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public Tester.<lobbyTest>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_9;
        int val_9 = this.$PC;
        val_9 = 0;
        this.$PC = 0;
        val_9 = (val_9 < 4) ? (val_9 + 3) : 0;
        val_9 = val_9 - 3;
        if(val_9 > 3)
        {
                return (bool);
        }
        
        var val_10 = 25486580 + ((this.$PC < 4 ? (this.$PC + 3) : 0 - 3)) << 2;
        val_10 = val_10 + 25486580;
        goto (25486580 + ((this.$PC < 4 ? (this.$PC + 3) : 0 - 3)) << 2 + 25486580);
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
