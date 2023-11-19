using UnityEngine;
private class EndlessGameState.Tutorial : EndlessGameState.GameStateBase
{
    // Methods
    public EndlessGameState.Tutorial()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        UnityEngine.Debug.Log(message:  0);
        TzarGames.Endless.EndlessGameState val_1 = this.GameState;
        this.LoadSceneAsync(sceneName:  val_1.tutorialSceneName, unloadUnusedAssets:  false, loadedCallback:  0);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
    }

}
