using UnityEngine;
private sealed class EndlessStageGameManager.<ActivateAllRooms>c__AnonStorey0
{
    // Fields
    internal TzarGames.Endless.Gate tmpGate;
    
    // Methods
    public EndlessStageGameManager.<ActivateAllRooms>c__AnonStorey0()
    {
    
    }
    internal void <>m__0()
    {
        if(0 == this.tmpGate)
        {
                return;
        }
        
        this = this.tmpGate;
        if(this.tmpGate.isBlocked == false)
        {
                return;
        }
        
        this.tmpGate.isBlocked = false;
        this.invokeBlockedEvents();
    }
    internal void <>m__1()
    {
        if(0 == this.tmpGate)
        {
                return;
        }
        
        this = this.tmpGate;
        if(this.tmpGate.isBlocked == false)
        {
                return;
        }
        
        this.tmpGate.isBlocked = false;
        this.invokeBlockedEvents();
    }

}
