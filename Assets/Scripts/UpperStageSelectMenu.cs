using UnityEngine;
[Uninterrupted]
private class GameUI.UpperStageSelectMenu : GameUI.UiBaseState
{
    // Methods
    public GameUI.UpperStageSelectMenu()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.ShowOnlyThisMenu(menuToShow:  val_1.lobby);
        TzarGames.Endless.UI.GameUI val_2 = this.UI;
        val_2.lobby.ShowUpperStageSelectionPanel();
        this.UI.showFadingBackground(show:  true, full:  false, onCompleteCallback:  0);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        val_1.lobby.HideStageSelectionPanel();
        TzarGames.Endless.UI.GameUI val_2 = this.UI;
        val_2.fadeBackground.FadeOut(completeCallback:  0);
    }
    protected override bool shouldStopPlayerMovement()
    {
        return true;
    }

}
