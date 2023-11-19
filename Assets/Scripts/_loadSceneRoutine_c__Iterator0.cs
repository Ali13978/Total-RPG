using UnityEngine;
private sealed class EndlessGameState.GameStateBase.<loadSceneRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal string sceneName;
    internal UnityEngine.AsyncOperation <asyncOperation>__0;
    internal float <loadingStartTime>__0;
    internal bool unloadUnusedAssets;
    internal System.Action loadedCallback;
    internal TzarGames.Endless.EndlessGameState.GameStateBase $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public EndlessGameState.GameStateBase.<loadSceneRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_8;
        int val_8 = this.$PC;
        val_8 = 0;
        this.$PC = 0;
        val_8 = (val_8 < 4) ? (val_8 + 3) : 0;
        val_8 = val_8 - 3;
        if(val_8 > 3)
        {
                return (bool);
        }
        
        var val_9 = 25804228 + ((this.$PC < 4 ? (this.$PC + 3) : 0 - 3)) << 2;
        val_9 = val_9 + 25804228;
        goto (25804228 + ((this.$PC < 4 ? (this.$PC + 3) : 0 - 3)) << 2 + 25804228);
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
