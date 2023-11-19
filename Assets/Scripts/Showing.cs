using UnityEngine;
private class AlertUI.Showing : AlertUI.AlertBaseState
{
    // Methods
    public AlertUI.Showing()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.AlertUI val_1 = this.UI;
        val_1.text.enabled = true;
    }
    private void show(string msg)
    {
        TzarGames.Endless.UI.AlertUI val_1 = this.UI;
        val_1.text.text = msg;
        TzarGames.Endless.UI.AlertUI val_2 = this.UI;
        bool val_3 = val_2._animation.Play();
    }
    public override void Update()
    {
        this.Update();
        TzarGames.Endless.UI.AlertUI val_1 = this.UI;
        if(val_1._animation.isPlaying != false)
        {
                return;
        }
        
        TzarGames.Endless.UI.AlertUI val_4 = this.UI;
        if(val_4.messages.Count >= 1)
        {
                this.show(msg:  val_6.messages.Item[0]);
            TzarGames.Endless.UI.AlertUI val_8 = this.UI;
            val_8.messages.RemoveAt(index:  0);
            return;
        }
        
        bool val_9 = this.UI.GotoState<AlertUI.Disabled>(stateData:  0);
    }

}
