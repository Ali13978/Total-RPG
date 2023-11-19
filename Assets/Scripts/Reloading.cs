using UnityEngine;
private class EndlessGameState.Reloading : EndlessGameState.GameStateBase
{
    // Methods
    public EndlessGameState.Reloading()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        this.GameState.beginLoadGame();
    }

}
