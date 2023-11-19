using UnityEngine;
private class GameUI.Inventory : GameUI.UiBaseState
{
    // Methods
    public GameUI.Inventory()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.ShowOnlyThisMenu(menuToShow:  val_1.inventory);
        TzarGames.Endless.UI.GameUI val_2 = this.UI;
        val_2.inventory.RefreshItems();
        this.UI.showFadingBackground(show:  true, full:  false, onCompleteCallback:  0);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.UI.showMenu(menu:  val_2.inventory, show:  false);
        TzarGames.Endless.UI.GameUI val_3 = this.UI;
        val_3.fadeBackground.FadeOut(completeCallback:  0);
    }
    protected override bool shouldStopPlayerMovement()
    {
        return true;
    }

}
