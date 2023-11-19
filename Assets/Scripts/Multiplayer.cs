using UnityEngine;
private class EndlessGameState.Multiplayer : EndlessGameState.Game
{
    // Methods
    public EndlessGameState.Multiplayer()
    {
        val_1 = new EndlessGameState.GameStateBase();
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        goto typeof(EndlessGameState.Multiplayer).__il2cppRuntimeField_1B0;
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        this.GameState.CurrentQuest = 0;
    }
    public override void Continue()
    {
        this.Continue();
        this.LoadSceneAsync(sceneName:  "Test_TzarHeroNet", unloadUnusedAssets:  true, loadedCallback:  0);
    }

}
