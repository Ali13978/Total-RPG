using UnityEngine;
[DefaultState]
private class AlertUI.Disabled : AlertUI.AlertBaseState
{
    // Methods
    public AlertUI.Disabled()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.AlertUI val_1 = this.UI;
        val_1.messages.Clear();
        TzarGames.Endless.UI.AlertUI val_2 = this.UI;
        val_2.text.enabled = false;
        TzarGames.Endless.UI.AlertUI val_3 = this.UI;
        val_3._animation.Stop();
    }

}
