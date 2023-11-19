using UnityEngine;
private class EndlessGameManager_Deathmatch.MatchEnd : EndlessGameManager_Deathmatch.DeathmatchBaseState
{
    // Fields
    private UnityEngine.Coroutine restartCoroutine;
    
    // Methods
    public EndlessGameManager_Deathmatch.MatchEnd()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_9;
        System.Collections.IEnumerator val_10;
        prevState.OnStateBegin(prevState:  prevState);
        List.Enumerator<T> val_3 = this.Game.SessionPlayers.GetEnumerator();
        label_4:
        if((0 & 1) == 0)
        {
            goto label_3;
        }
        
        this.processPlayer(player:  0.InitializationCallback);
        goto label_4;
        label_3:
        val_9 = 0;
        val_10 = 1;
        0.Dispose();
        TzarGames.Endless.EndlessGameManager_Deathmatch val_5 = this.Game;
        if(val_5.autoRestartMatch == false)
        {
                return;
        }
        
        val_10 = this.restart();
        this.restartCoroutine = this.Game.StartCoroutine(routine:  val_10);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
        if(this.restartCoroutine == null)
        {
                return;
        }
        
        this.Game.StopCoroutine(routine:  this.restartCoroutine);
        this.restartCoroutine = 0;
    }
    public override void OnPlayerEnter(TzarGames.GameFramework.Player player)
    {
        this.processPlayer(player:  player);
    }
    public override void OnPlayerObjectSpawn(TzarGames.GameFramework.Player player)
    {
        var val_2;
        var val_2 = 0;
        val_2 = val_2 + 1;
        val_2 = player.PlayerComponent;
        goto x3;
    }
    private void processPlayer(TzarGames.GameFramework.Player player)
    {
        var val_9;
        if(player.PlayerComponent != null)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = player.PlayerComponent;
        }
        
        if(this.Game.OnServer == false)
        {
                return;
        }
        
        if(player.itsMe != false)
        {
                return;
        }
        
        this.Game.RPC(methodDelegate:  new TzarGames.GameFramework.RPCall_VOID(object:  this.Game, method:  System.Void TzarGames.Endless.EndlessGameManager_Deathmatch::client_match_end()), target:  player.NetworkPlayer, parameters:  null);
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator restart()
    {
        typeof(EndlessGameManager_Deathmatch.MatchEnd.<restart>c__Iterator0).__il2cppRuntimeField_10 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }

}
