using UnityEngine;
private class EndlessGameManager_Deathmatch.Match : EndlessGameManager_Deathmatch.DeathmatchBaseState
{
    // Fields
    private System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, UnityEngine.Coroutine> playersWaitingForRespawn;
    
    // Methods
    public EndlessGameManager_Deathmatch.Match()
    {
        this.playersWaitingForRespawn = new System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, UnityEngine.Coroutine>();
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_13;
        var val_14;
        prevState.OnStateBegin(prevState:  prevState);
        if(this.Game.OnServer != false)
        {
                TzarGames.Endless.EndlessGameManager_Deathmatch val_3 = this.Game;
            val_3.data.PlayerDatas.Clear();
        }
        
        if(this.Game.OnClient != true)
        {
                TzarGames.Endless.EndlessGameManager_Deathmatch val_7 = this.Game;
            val_7.data.MatchStartTime = TzarGames.GameFramework.GameManagerNetSyncBase.NetworkTime;
        }
        
        List.Enumerator<T> val_11 = this.Game.SessionPlayers.GetEnumerator();
        label_15:
        if((0 & 1) == 0)
        {
            goto label_14;
        }
        
        this.processPlayer(player:  0.InitializationCallback);
        goto label_15;
        label_14:
        val_13 = 0;
        val_14 = 1;
        0.Dispose();
        if((val_14 & 1) != 0)
        {
                return;
        }
        
        if(val_13 == 0)
        {
                return;
        }
    
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        var val_4;
        var val_5;
        nextState.OnStateEnd(nextState:  nextState);
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.playersWaitingForRespawn.Values.GetEnumerator();
        label_5:
        if((0 & 1) == 0)
        {
            goto label_3;
        }
        
        this.Game.StopCoroutine(routine:  0);
        goto label_5;
        label_3:
        val_4 = 0;
        val_5 = 1;
        this.playersWaitingForRespawn.Clear();
    }
    public override void Update()
    {
        this.Update();
        if(this.Game.OnClient == true)
        {
                return;
        }
        
        TzarGames.Endless.EndlessGameManager_Deathmatch val_5 = this.Game;
        TzarGames.Endless.EndlessGameManager_Deathmatch val_6 = this.Game;
        if((TzarGames.GameFramework.GameManagerNetSyncBase.NetworkTime - val_5.data.MatchStartTime) < (double)val_6.matchTime)
        {
                return;
        }
        
        this.finishMatch();
    }
    private void finishMatch()
    {
        this.ForceGotoState<EndlessGameManager_Deathmatch.MatchEnd>(stateData:  0);
    }
    public override void OnCharacterDead(TzarGames.TzarHero.DeadEventData eventData)
    {
        System.Delegate val_17;
        TzarGames.GameFramework.Player val_18;
        System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, UnityEngine.Coroutine> val_19;
        var val_20;
        var val_21;
        int val_22;
        val_17 = this;
        val_18 = this.Game;
        if(val_18.OnServer == false)
        {
                return;
        }
        
        val_18 = 0;
        if(0 == )
        {
                return;
        }
        
        val_18 = PlayerOwner;
        val_19 = this.playersWaitingForRespawn;
        val_19.Add(key:  val_18, value:  this.Game.StartCoroutine(routine:  this.playerRespawnRoutine(player:  val_18)));
        val_20 = 0;
        if(0 == )
        {
                return;
        }
        
        TzarGames.Endless.EndlessGameManager_Deathmatch val_12 = this.Game;
        PlayerData val_13 = val_12.data.GetPlayerData(player:  PlayerOwner);
        if(val_13 != null)
        {
                val_21 = val_13;
            val_22 = val_13.score;
        }
        else
        {
                val_21 = 20;
            val_22 = 1;
        }
        
        mem[20] = 2;
        TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkPlayer, System.Int32> val_16 = null;
        val_17 = val_16;
        val_16 = new TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkPlayer, System.Int32>(object:  this.Game, method:  System.Void TzarGames.Endless.EndlessGameManager_Deathmatch::client_set_player_score(TzarGames.GameFramework.NetworkPlayer networkPlayer, int score));
        val_18 = null;
        val_19 = val_11.NetworkPlayer;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_19;
        typeof(System.Object[]).__il2cppRuntimeField_28 = 2;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        this.Game.RPC(methodDelegate:  val_17, rpcMode:  2, parameters:  val_18);
    }
    private void respawn(TzarGames.GameFramework.Player player)
    {
        TzarGames.GameFramework.SpawnPoint val_2 = this.Game.GetRandomSpawnPoint();
        UnityEngine.Vector3 val_4 = val_2.Position;
        UnityEngine.Quaternion val_5 = val_2.Rotation;
        this.Game.RespawnPlayerObject(player:  player, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w});
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator playerRespawnRoutine(TzarGames.GameFramework.Player player)
    {
        if(null != 0)
        {
                typeof(EndlessGameManager_Deathmatch.Match.<playerRespawnRoutine>c__Iterator0).__il2cppRuntimeField_10 = player;
        }
        else
        {
                mem[16] = player;
        }
        
        typeof(EndlessGameManager_Deathmatch.Match.<playerRespawnRoutine>c__Iterator0).__il2cppRuntimeField_18 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    public override void OnPlayerExit(TzarGames.GameFramework.Player player)
    {
        MatchState val_12;
        UnityEngine.Coroutine val_1 = 0;
        if((this.playersWaitingForRespawn.TryGetValue(key:  player, value: out  val_1)) != false)
        {
                this.Game.StopCoroutine(routine:  val_1);
            bool val_4 = this.playersWaitingForRespawn.Remove(key:  player);
        }
        
        TzarGames.Endless.EndlessGameManager_Deathmatch val_5 = this.Game;
        val_12 = val_5.data;
        PlayerData val_6 = val_12.GetPlayerData(player:  player);
        if(val_6 != null)
        {
                TzarGames.Endless.EndlessGameManager_Deathmatch val_7 = this.Game;
            val_12 = val_7.data.PlayerDatas;
            bool val_8 = val_12.Remove(item:  val_6);
        }
        
        if(this.Game.Connected == true)
        {
                return;
        }
        
        this.ForceGotoState<EndlessGameManager_Deathmatch.WaitingForMatch>(stateData:  0);
    }
    public override void OnPlayerObjectSpawn(TzarGames.GameFramework.Player player)
    {
        var val_2;
        var val_2 = 0;
        val_2 = val_2 + 1;
        val_2 = player.PlayerComponent;
    }
    public override void OnPlayerEnter(TzarGames.GameFramework.Player player)
    {
        this.processPlayer(player:  player);
    }
    private void processPlayer(TzarGames.GameFramework.Player player)
    {
        var val_18;
        var val_19;
        if(this.Game.OnServer == false)
        {
            goto label_2;
        }
        
        if(player.PlayerComponent == null)
        {
            goto label_5;
        }
        
        this.respawn(player:  player);
        goto label_5;
        label_2:
        if(player == null)
        {
            goto label_6;
        }
        
        label_5:
        val_18 = 0;
        goto label_7;
        label_6:
        val_18 = 1;
        label_7:
        if(player.PlayerComponent != null)
        {
                var val_18 = 0;
            val_18 = val_18 + 1;
            val_19 = player.PlayerComponent;
        }
        
        TzarGames.Endless.EndlessGameManager_Deathmatch val_4 = this.Game;
        if((val_4.data.GetPlayerData(player:  player)) == null)
        {
                TzarGames.Endless.EndlessGameManager_Deathmatch val_6 = this.Game;
            val_6.data.PlayerDatas.Add(item:  new EndlessGameManager_Deathmatch.PlayerData(player:  player));
        }
        
        if(this.Game.OnServer == false)
        {
                return;
        }
        
        if(player.itsMe != false)
        {
                return;
        }
        
        TzarGames.Endless.EndlessGameManager_Deathmatch val_12 = this.Game;
        typeof(System.Object[]).__il2cppRuntimeField_20 = TzarGames.Common.Utils.GetBytesFromString(str:  UnityEngine.JsonUtility.ToJson(obj:  0));
        this.Game.RPC(methodDelegate:  new TzarGames.GameFramework.RPCall<System.Byte[]>(object:  this.Game, method:  System.Void TzarGames.Endless.EndlessGameManager_Deathmatch::client_match_start(byte[] matchData)), target:  player.NetworkPlayer, parameters:  null);
    }

}
