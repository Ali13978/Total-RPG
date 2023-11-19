using UnityEngine;
private class EndlessGameState.MainMenu : EndlessGameState.GameStateBase
{
    // Methods
    public EndlessGameState.MainMenu()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        UnityEngine.Debug.Log(message:  0);
        TzarGames.Endless.EndlessGameState val_1 = this.GameState;
        this.LoadSceneAsync(sceneName:  val_1.mainMenuSceneName, unloadUnusedAssets:  true, loadedCallback:  new System.Action(object:  this, method:  System.Void EndlessGameState.MainMenu::LoadedCallback()));
    }
    private void LoadedCallback()
    {
        if(TzarGames.Endless.EndlessGameState.OnMainMenuLoaded == null)
        {
                return;
        }
        
        TzarGames.Endless.EndlessGameState.OnMainMenuLoaded.Invoke();
    }

}
