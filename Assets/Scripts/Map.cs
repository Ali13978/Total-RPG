using UnityEngine;
private class GameUI.Map : GameUI.UiBaseState
{
    // Methods
    public GameUI.Map()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.UI.showMenu(menu:  val_2.mapMenu, show:  true);
        this.UI.showFadingBackground(show:  true, full:  false, onCompleteCallback:  0);
        UnityEngine.UI.Extensions.BoundTooltipItem val_4 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
        if(0 == val_4)
        {
                return;
        }
        
        val_4.SetExtendedMode();
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        this.UI.showMenu(menu:  val_2.mapMenu, show:  false);
        TzarGames.Endless.UI.GameUI val_3 = this.UI;
        val_3.fadeBackground.FadeOut(completeCallback:  0);
        UnityEngine.UI.Extensions.BoundTooltipItem val_4 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
        if(0 == val_4)
        {
                return;
        }
        
        val_4.SetMinimapMode();
    }
    protected override bool shouldStopPlayerMovement()
    {
        return true;
    }

}
