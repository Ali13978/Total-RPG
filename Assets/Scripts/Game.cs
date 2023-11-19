using UnityEngine;
private class EndlessGameState.Game : EndlessGameState.GameStateBase
{
    // Fields
    protected const string currentSceneNumKey = "GAME_LAST_STAGE_SCENE_NUM";
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private uint <CurrentStage>k__BackingField;
    
    // Properties
    public uint CurrentStage { get; set; }
    
    // Methods
    public EndlessGameState.Game()
    {
    
    }
    public uint get_CurrentStage()
    {
        return (uint)this.<CurrentStage>k__BackingField;
    }
    private void set_CurrentStage(uint value)
    {
        this.<CurrentStage>k__BackingField = value;
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_11;
        var val_12;
        var val_13;
        prevState.OnStateBegin(prevState:  prevState);
        if(this.GameState.SelectedCharacter == null)
        {
            goto label_2;
        }
        
        TzarGames.Endless.ICharacterInfo val_4 = this.GameState.SelectedCharacter;
        val_11 = 1152921504863608832;
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_12 = val_4;
        if((val_4 & 1) == 0)
        {
            goto label_9;
        }
        
        label_2:
        UnityEngine.Debug.LogError(message:  0);
        bool val_7 = this.GameState.GotoState<EndlessGameState.MainMenu>(stateData:  0);
        return;
        label_9:
        TzarGames.Endless.ICharacterInfo val_9 = this.GameState.SelectedCharacter;
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_13 = val_9;
        this.<CurrentStage>k__BackingField = val_9;
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.EndlessGameState val_1 = this.GameState;
        val_1.lastAttemptGameStateType = 0;
        TzarGames.Endless.EndlessGameState val_2 = this.GameState;
        val_2.lastAttemptGameStateData = 0;
    }
    public int GetStageSceneNum()
    {
        var val_10;
        var val_11;
        var val_12;
        TzarGames.Endless.ICharacterInfo val_2 = this.GameState.SelectedCharacter;
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_10 = val_2;
        if((val_2.HasInt(id:  "GAME_LAST_STAGE_SCENE_NUM")) != false)
        {
                val_11 = val_2.GetInt(id:  "GAME_LAST_STAGE_SCENE_NUM");
        }
        else
        {
                val_11 = 0;
        }
        
        TzarGames.Endless.EndlessGameState val_6 = this.GameState;
        int val_11 = val_6.stages.Length;
        int val_7 = val_11 / val_11;
        val_7 = val_11 - (val_7 * val_11);
        if((val_7 & 2147483648) == 0)
        {
                int val_8 = val_11 >> 31;
            val_8 = val_8 & 4294967291;
            val_11 = val_11 - 1;
            var val_9 = (val_8 == 5) ? (val_11) : (val_7);
            return (int)val_12;
        }
        
        val_12 = 0;
        return (int)val_12;
    }
    public virtual void Continue()
    {
        TzarGames.Endless.EndlessGameState val_1 = this.GameState;
        val_1.lastAttemptGameStateType = 0;
        TzarGames.Endless.EndlessGameState val_2 = this.GameState;
        val_2.lastAttemptGameStateData = 0;
        if(TzarGames.Endless.EndlessGameState.OnGameContinued == null)
        {
                return;
        }
        
        TzarGames.Endless.EndlessGameState.OnGameContinued.Invoke();
    }
    public override bool OnStateValidate(StateMachine.State prevState)
    {
        TzarGames.Endless.EndlessGameState val_1 = this.GameState;
        System.Type val_2 = this.GetType();
        val_1.lastAttemptGameStateType = val_2;
        TzarGames.Endless.EndlessGameState val_3 = this.GameState;
        val_3.lastAttemptGameStateData = val_2;
        if((prevState.OnStateValidate(prevState:  prevState)) == false)
        {
                return false;
        }
        
        TzarGames.Endless.EndlessGameState val_5 = this.GameState;
        if(val_5 != null)
        {
                return val_5.CanContinueGame();
        }
        
        return val_5.CanContinueGame();
    }
    internal virtual void OnStageRaised()
    {
    
    }

}
