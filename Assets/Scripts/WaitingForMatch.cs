using UnityEngine;
[DefaultState]
private class EndlessGameManager_Deathmatch.WaitingForMatch : EndlessGameManager_Deathmatch.DeathmatchBaseState
{
    // Methods
    public EndlessGameManager_Deathmatch.WaitingForMatch()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 0;
        prevState.OnStateBegin(prevState:  prevState);
        List.Enumerator<T> val_3 = this.Game.SessionPlayers.GetEnumerator();
        label_10:
        if((0 & 1) == 0)
        {
            goto label_3;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = 0.InitializationCallback;
        if(val_4 == null)
        {
            goto label_10;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_6 = 6;
        val_7 = val_4;
        goto label_10;
        label_3:
        val_8 = 0;
        val_9 = 1;
        0.Dispose();
        if((val_9 & 1) != 0)
        {
                return;
        }
        
        if(val_8 == 0)
        {
                return;
        }
    
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
        var val_2;
        if(player.PlayerComponent == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        val_2 = player.PlayerComponent;
    }
    public override void Update()
    {
        this.Update();
        if(this.Game.Connected == false)
        {
                return;
        }
        
        if(this.Game.OnServer == false)
        {
                return;
        }
        
        this.ForceGotoState<EndlessGameManager_Deathmatch.Match>(stateData:  0);
    }

}
