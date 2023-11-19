using UnityEngine;
private class AlertUI.AlertBaseState : StateMachine.State
{
    // Properties
    public TzarGames.Endless.UI.AlertUI UI { get; }
    
    // Methods
    public AlertUI.AlertBaseState()
    {
    
    }
    public TzarGames.Endless.UI.AlertUI get_UI()
    {
        if(this.Owner == null)
        {
                return (TzarGames.Endless.UI.AlertUI);
        }
        
        0 = 0;
        return (TzarGames.Endless.UI.AlertUI);
    }

}
