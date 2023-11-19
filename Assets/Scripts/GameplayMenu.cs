using UnityEngine;
private class GameUI.GameplayMenu : GameUI.UiBaseState
{
    // Methods
    public GameUI.GameplayMenu()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        if(0 != TzarGames.Endless.EndlessGameState.Instance)
        {
                TzarGames.Endless.EndlessGameState.Instance.Paused = true;
        }
        
        TzarGames.Endless.UI.GameUI val_4 = this.UI;
        this.UI.showMenu(menu:  val_5.gameplayMenu, show:  true);
        this.UI.showFadingBackground(show:  true, full:  false, onCompleteCallback:  0);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.UI.showMenu(menu:  val_2.gameplayMenu, show:  false);
        TzarGames.Endless.UI.GameUI val_3 = this.UI;
        val_3.fadeBackground.FadeOut(completeCallback:  0);
    }
    protected override bool shouldStopPlayerMovement()
    {
        return true;
    }

}
