using UnityEngine;
private class EndlessGameState.PromoGame : EndlessGameState.Game
{
    // Methods
    public EndlessGameState.PromoGame()
    {
        val_1 = new EndlessGameState.GameStateBase();
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        goto typeof(EndlessGameState.PromoGame).__il2cppRuntimeField_1B0;
    }
    public override void Continue()
    {
        var val_5;
        this.Continue();
        TzarGames.Endless.ICharacterInfo val_2 = this.GameState.SelectedCharacter;
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_5 = val_2;
        TzarGames.Endless.EndlessGameState val_4 = this.GameState;
        TzarGames.Endless.SceneInfo val_6 = val_4.promoLevels[val_2];
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_4.promoLevels[val_2][0].SceneName;
        UnityEngine.Debug.LogFormat(format:  0, args:  "Loading promo game {0}");
        this.LoadSceneAsync(sceneName:  val_4.promoLevels[val_2][0].SceneName, unloadUnusedAssets:  true, loadedCallback:  0);
    }

}
