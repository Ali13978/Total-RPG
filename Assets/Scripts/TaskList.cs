using UnityEngine;
private class GameUI.TaskList : GameUI.UiBaseState
{
    // Methods
    public GameUI.TaskList()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        val_1.taskList.QuestProvider = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
        TzarGames.Endless.UI.GameUI val_3 = this.UI;
        this.ShowOnlyThisMenu(menuToShow:  val_3.taskList);
        this.UI.showFadingBackground(show:  true, full:  false, onCompleteCallback:  0);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        val_1.taskList.QuestProvider = 0;
        TzarGames.Endless.UI.GameUI val_2 = this.UI;
        this.UI.showMenu(menu:  val_3.taskList, show:  false);
        TzarGames.Endless.UI.GameUI val_4 = this.UI;
        val_4.fadeBackground.FadeOut(completeCallback:  0);
    }
    protected override bool shouldStopPlayerMovement()
    {
        return true;
    }

}
