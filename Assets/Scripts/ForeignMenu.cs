using UnityEngine;
private class GameUI.ForeignMenu : GameUI.UiBaseState
{
    // Fields
    private TzarGames.GameFramework.UI.GameUIBase menu;
    
    // Methods
    public GameUI.ForeignMenu()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        TzarGames.GameFramework.UI.GameUIBase val_3;
        this.OnStateBegin(prevState:  prevState);
        if(true == 0)
        {
            goto label_1;
        }
        
        val_3 = 0;
        goto label_3;
        label_1:
        val_3 = this.menu;
        goto label_4;
        label_3:
        this.menu = ;
        label_4:
        this.ShowOnlyThisMenu(menuToShow:  null);
        this.UI.showFadingBackground(show:  true, full:  false, onCompleteCallback:  0);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        this.UI.showMenu(menu:  this.menu, show:  false);
        TzarGames.Endless.UI.GameUI val_2 = this.UI;
        val_2.fadeBackground.FadeOut(completeCallback:  0);
    }
    protected override bool shouldStopPlayerMovement()
    {
        return true;
    }

}
