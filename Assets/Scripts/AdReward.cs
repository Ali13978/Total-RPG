using UnityEngine;
private class GameUI.AdReward : GameUI.UiBaseState
{
    // Methods
    public GameUI.AdReward()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.UI.showMenu(menu:  val_2.adsRewardWindow, show:  true);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.UI.showMenu(menu:  val_2.adsRewardWindow, show:  false);
    }
    protected override bool shouldStopPlayerMovement()
    {
        return true;
    }

}
