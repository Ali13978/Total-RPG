using UnityEngine;
private class EndlessGameState.Lobby : EndlessGameState.GameStateBase
{
    // Methods
    public EndlessGameState.Lobby()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_10;
        prevState.OnStateBegin(prevState:  prevState);
        if(this.GameState.SelectedCharacter == null)
        {
            goto label_2;
        }
        
        TzarGames.Endless.ICharacterInfo val_4 = this.GameState.SelectedCharacter;
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_10 = val_4;
        if((val_4 & 1) == 0)
        {
            goto label_9;
        }
        
        label_2:
        UnityEngine.Debug.LogError(message:  0);
        bool val_7 = this.GameState.GotoState<EndlessGameState.MainMenu>(stateData:  0);
        return;
        label_9:
        UnityEngine.Debug.Log(message:  0);
        TzarGames.Endless.EndlessGameState val_8 = this.GameState;
        this.LoadSceneAsync(sceneName:  val_8.lobbySceneName, unloadUnusedAssets:  true, loadedCallback:  new System.Action(object:  this, method:  System.Void EndlessGameState.Lobby::LoadedCallback()));
    }
    private void LoadedCallback()
    {
        if(TzarGames.Endless.EndlessGameState.OnLobbyLoaded == null)
        {
                return;
        }
        
        TzarGames.Endless.EndlessGameState.OnLobbyLoaded.Invoke();
    }

}
