using UnityEngine;
[Uninterrupted]
private class EndlessGameState.LobbyTransition : EndlessGameState.GameStateBase
{
    // Methods
    public EndlessGameState.LobbyTransition()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        bool val_2 = this.GameState.GotoState<EndlessGameState.Lobby>(stateData:  0);
    }

}
