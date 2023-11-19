using UnityEngine;
private sealed class GameManagerNetSyncBase.<handleConnectedPlayer>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.GameFramework.Player newPlayer;
    internal int <sessionId>__0;
    internal UnityEngine.Coroutine <coroutine>__0;
    internal TzarGames.GameFramework.GameManagerNetSyncBase $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public GameManagerNetSyncBase.<handleConnectedPlayer>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        TzarGames.GameFramework.Player val_10;
        int val_11;
        TzarGames.GameFramework.GameManagerNetSyncBase val_12;
        TzarGames.GameFramework.RPCall<A> val_13;
        val_10 = this;
        int val_10 = this.$PC;
        this.$PC = 0;
        val_10 = ((val_10 == 1) ? 1 : 0) << 2;
        var val_2 = (val_10 == 0) ? 3 : (val_10);
        if(val_2 == 4)
        {
            goto label_1;
        }
        
        val_11 = 0;
        if(val_2 != 3)
        {
                return (bool)val_11;
        }
        
        if((this.newPlayer.NetworkPlayer & 1) == 0)
        {
            goto label_29;
        }
        
        this.<sessionId>__0 = 0;
        if(this.$this.enableSessions != false)
        {
                if((this.$this._sessionManager.TryAddPlayerToAnySession(player:  this.newPlayer, sessionId: out  1152921511381155592)) == false)
        {
            goto label_10;
        }
        
        }
        
        this.newPlayer.DisconnectingFlag = false;
        this.$this.registerNetworkPlayer(player:  this.newPlayer, networkPlayer:  this.newPlayer.NetworkPlayer, sessionId:  0);
        this.<coroutine>__0 = this.$this.gameManager.StartCoroutine(routine:  this.$this.gameManager);
        val_12 = this.$this;
        if(this.$this == null)
        {
                val_12 = this.$this;
        }
        
        TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkPlayer> val_7 = null;
        val_13 = val_7;
        val_7 = new TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkPlayer>(object:  val_12, method:  System.Void TzarGames.GameFramework.GameManagerNetSyncBase::client_playerEnteredToGame(TzarGames.GameFramework.NetworkPlayer netPlayer));
        typeof(System.Object[]).__il2cppRuntimeField_20 = this.newPlayer.NetworkPlayer;
        this.$this.myNetworkView.RPC<TzarGames.GameFramework.NetworkPlayer>(methodDelegate:  val_13, mode:  2, args:  null);
        val_11 = 1;
        this.$current = this.<coroutine>__0;
        if(this.$disposing == true)
        {
                return (bool)val_11;
        }
        
        this.$PC = val_11;
        return (bool)val_11;
        label_1:
        if((TzarGames.GameFramework.GameManagerNetSyncBase.IsServer == false) || (this.newPlayer.IsConnected == false))
        {
            goto label_29;
        }
        
        this.$this.SpawnOtherPlayersForPlayer(player:  this.newPlayer);
        this.$this.updateRelationsForPlayer(player:  this.newPlayer);
        val_13 = this.newPlayer;
        this.$this.executeBufferedRpcsForPlayer(player:  val_13);
        val_11 = 0;
        this.$PC = 0;
        return (bool)val_11;
        label_10:
        val_13 = this.newPlayer;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_13;
        UnityEngine.Debug.LogFormat(format:  0, args:  "Server is full. Disconnecting new player {0}");
        val_10 = this.newPlayer;
        label_29:
        val_11 = 0;
        return (bool)val_11;
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
