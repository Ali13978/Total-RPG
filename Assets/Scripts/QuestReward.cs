using UnityEngine;
private class GameUI.QuestReward : GameUI.UiBaseState
{
    // Fields
    private System.Action callback;
    
    // Methods
    public GameUI.QuestReward()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_5;
        this.OnStateBegin(prevState:  prevState);
        val_5 = 0;
        TzarGames.Endless.UI.GameUI val_2 = this.UI;
        val_2.questReward.Reward = (mem[1103844756725] + (GameUI.QuestData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? true : 0 + 16;
        this.callback = (mem[1103844756725] + (GameUI.QuestData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? true : 0 + 24;
        TzarGames.Endless.UI.GameUI val_3 = this.UI;
        this.ShowOnlyThisMenu(menuToShow:  val_3.questReward);
        this.UI.showFadingBackground(show:  true, full:  false, onCompleteCallback:  0);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        val_1.questReward.Reward = 0;
        TzarGames.Endless.UI.GameUI val_2 = this.UI;
        this.UI.showMenu(menu:  val_3.questReward, show:  false);
        TzarGames.Endless.UI.GameUI val_4 = this.UI;
        val_4.fadeBackground.FadeOut(completeCallback:  0);
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke();
    }
    protected override bool shouldStopPlayerMovement()
    {
        return true;
    }

}
