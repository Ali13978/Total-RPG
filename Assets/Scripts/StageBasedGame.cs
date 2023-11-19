using UnityEngine;
private class EndlessGameState.StageBasedGame : EndlessGameState.Game
{
    // Fields
    protected bool IsPlayingStageScene;
    
    // Methods
    public EndlessGameState.StageBasedGame()
    {
        val_1 = new EndlessGameState.GameStateBase();
    }
    internal override void OnStageRaised()
    {
        var val_11;
        string val_12;
        var val_13;
        var val_14;
        if(this.IsPlayingStageScene == false)
        {
                return;
        }
        
        TzarGames.Endless.ICharacterInfo val_2 = this.GameState.SelectedCharacter;
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_11 = val_2;
        if(val_2 == null)
        {
            goto label_8;
        }
        
        val_12 = "GAME_LAST_STAGE_SCENE_NUM";
        if((val_2.HasInt(id:  "GAME_LAST_STAGE_SCENE_NUM")) == false)
        {
            goto label_11;
        }
        
        val_13 = val_2.GetInt(id:  val_12);
        goto label_10;
        label_8:
        val_12 = "GAME_LAST_STAGE_SCENE_NUM";
        if((0.HasInt(id:  "GAME_LAST_STAGE_SCENE_NUM")) == false)
        {
            goto label_11;
        }
        
        val_13 = 0.GetInt(id:  val_12);
        label_10:
        val_14 = val_13 + 1;
        val_12 = "GAME_LAST_STAGE_SCENE_NUM";
        goto label_12;
        label_11:
        val_14 = 1;
        label_12:
        val_2.SetInt(id:  val_12, val:  1);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        this.IsPlayingStageScene = false;
    }

}
