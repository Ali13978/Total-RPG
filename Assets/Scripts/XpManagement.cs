using UnityEngine;
private class GameUI.XpManagement : GameUI.UiBaseState
{
    // Methods
    public GameUI.XpManagement()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.UI.showMenu(menu:  val_2.xpManagement, show:  true);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.UI.showMenu(menu:  val_2.xpManagement, show:  false);
    }
    protected override bool shouldStopPlayerMovement()
    {
        return true;
    }

}
