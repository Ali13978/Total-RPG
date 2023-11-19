using UnityEngine;
private class EndlessGameState.QuestGame : EndlessGameState.StageBasedGame
{
    // Fields
    private StateMachine.State previousState;
    
    // Methods
    public EndlessGameState.QuestGame()
    {
        val_1 = new EndlessGameState.GameStateBase();
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        this.previousState = prevState;
        goto typeof(EndlessGameState.QuestGame).__il2cppRuntimeField_1B0;
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        mem[1152921510631094404] = 0;
        this.GameState.CurrentQuest = 0;
        this.previousState = 0;
    }
    public override void Continue()
    {
        var val_12;
        TzarGames.Endless.FloorSceneInfo[] val_13;
        string val_14;
        System.Action val_15;
        var val_16;
        var val_17;
        this.Continue();
        val_12 = 0;
        if(0 == )
        {
                UnityEngine.Debug.LogError(message:  0);
            this.previousState.ForceGotoState(state:  this.previousState, stateData:  0);
            return;
        }
        
        this.GameState.CurrentQuest = ;
        if(SceneNames == null)
        {
            goto label_14;
        }
        
        System.String[] val_5 = SceneNames;
        if(val_5.Length < 1)
        {
            goto label_14;
        }
        
        val_13 = SceneNames;
        goto label_16;
        label_14:
        TzarGames.Endless.EndlessGameState val_8 = this.GameState;
        val_13 = val_8.stages;
        TzarGames.Endless.FloorSceneInfo val_12 = val_13[(long)this.GetStageSceneNum()];
        mem[1152921510631456356] = 1;
        val_15 = 0;
        val_16 = 1;
        val_17 = public System.Void EndlessGameState.GameStateBase::LoadSceneAsync(string sceneName, bool unloadUnusedAssets, System.Action loadedCallback);
        goto label_21;
        label_16:
        System.String[] val_10 = SceneNames;
        val_14 = [(long)UnityEngine.Random.Range(min:  0, max:  0)];
        val_15 = 0;
        val_17 = public System.Void EndlessGameState.GameStateBase::LoadSceneAsync(string sceneName, bool unloadUnusedAssets, System.Action loadedCallback);
        val_16 = 1;
        label_21:
        this.LoadSceneAsync(sceneName:  val_14, unloadUnusedAssets:  true, loadedCallback:  val_15);
    }

}
