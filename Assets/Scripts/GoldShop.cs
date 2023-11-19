using UnityEngine;
private class GameUI.GoldShop : GameUI.UiBaseState
{
    // Methods
    public GameUI.GoldShop()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.ShowOnlyThisMenu(menuToShow:  val_1.goldShop);
        TzarGames.Endless.UI.GameUI val_2 = this.UI;
        this.UI.showFadingBackground(show:  true, full:  false, onCompleteCallback:  0);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.UI.showMenu(menu:  val_2.goldShop, show:  false);
        TzarGames.Endless.UI.GameUI val_3 = this.UI;
        val_3.fadeBackground.FadeOut(completeCallback:  0);
    }
    protected override bool shouldStopPlayerMovement()
    {
        return true;
    }

}
