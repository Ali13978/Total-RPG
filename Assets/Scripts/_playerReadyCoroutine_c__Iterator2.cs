using UnityEngine;
private sealed class GameManagerNetSyncBase.<playerReadyCoroutine>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.GameFramework.Player player;
    internal TzarGames.Common.Coroutine<bool> <coroutine>__0;
    internal TzarGames.GameFramework.GameManagerNetSyncBase $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public GameManagerNetSyncBase.<playerReadyCoroutine>c__Iterator2()
    {
    
    }
    public bool MoveNext()
    {
        int val_9;
        TzarGames.GameFramework.Player val_10;
        int val_9 = this.$PC;
        this.$PC = 0;
        val_9 = ((val_9 == 1) ? 1 : 0) << 2;
        var val_2 = (val_9 == 0) ? 3 : (val_9);
        if(val_2 != 4)
        {
                val_9 = 0;
            if(val_2 != 3)
        {
                return (bool)val_9;
        }
        
            this.$this.loginsInInitProcess.Add(item:  this.player.Login);
            val_10 = this.player;
            System.Collections.IEnumerator val_4 = this.$this.handleConnectedPlayer(newPlayer:  val_10);
            this.<coroutine>__0 = TzarGames.Common.Coroutine<System.Boolean>.StartCoroutine(obj:  0, coroutine:  this.$this);
            val_9 = 1;
            this.$current = 1152921511381972528;
            if(this.$disposing == true)
        {
                return (bool)val_9;
        }
        
            this.$PC = val_9;
            return (bool)val_9;
        }
        
        bool val_6 = this.<coroutine>__0.HasException();
        val_10 = this.player.Login;
        bool val_8 = this.$this.loginsInInitProcess.Remove(item:  val_10);
        val_9 = 0;
        this.$PC = 0;
        return (bool)val_9;
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
