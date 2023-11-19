using UnityEngine;
private class EndlessGameState.StageGame : EndlessGameState.StageBasedGame
{
    // Methods
    public EndlessGameState.StageGame()
    {
        val_1 = new EndlessGameState.GameStateBase();
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        goto typeof(EndlessGameState.StageGame).__il2cppRuntimeField_1B0;
    }
    public override void Continue()
    {
        var val_13;
        string val_14;
        System.Action val_15;
        var val_16;
        this.Continue();
        TzarGames.Endless.SceneInfo val_2 = this.GameState.getCurrentStageInfo();
        TzarGames.Endless.Quests.EpicBossQuest val_4 = this.GameState.GetBossQuestForStage(stageNum:  W21);
        if(0 != val_4)
        {
                if((this.GameState.IsBossDefeated(bossQuest:  val_4)) == false)
        {
            goto label_7;
        }
        
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Loading game scene ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_2.Label;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " on stage ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = System.Object[].__il2cppRuntimeField_namespaze;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        val_13 = +0;
        UnityEngine.Debug.Log(message:  0);
        mem[1152921510630651908] = 1;
        val_14 = val_2.SceneName;
        val_15 = 0;
        val_16 = 1;
        goto label_27;
        label_7:
        string val_13 = val_4.SceneNames[0];
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Loading boss scene ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_13;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " for boss ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_4.Name;
        typeof(System.Object[]).__il2cppRuntimeField_40 = " on stage ";
        typeof(System.Object[]).__il2cppRuntimeField_48 = System.Object[].__il2cppRuntimeField_namespaze;
        typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
        val_13 = +0;
        UnityEngine.Debug.Log(message:  0);
        val_15 = 0;
        val_16 = 1;
        val_14 = val_13;
        label_27:
        this.LoadSceneAsync(sceneName:  val_14, unloadUnusedAssets:  true, loadedCallback:  val_15);
        if(TzarGames.Endless.EndlessGameState.OnStageStarted == null)
        {
                return;
        }
        
        TzarGames.Endless.EndlessGameState.OnStageStarted.Invoke();
    }

}
