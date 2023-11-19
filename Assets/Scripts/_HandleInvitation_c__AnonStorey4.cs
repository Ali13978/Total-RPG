using UnityEngine;
private sealed class NativeClient.<HandleInvitation>c__AnonStorey4
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, bool> currentHandler;
    internal GooglePlayGames.BasicApi.Multiplayer.Invitation invite;
    internal bool shouldAutolaunch;
    
    // Methods
    public NativeClient.<HandleInvitation>c__AnonStorey4()
    {
    
    }
    internal void <>m__0()
    {
        this.currentHandler.Invoke(arg1:  this.invite, arg2:  (this.shouldAutolaunch == true) ? 1 : 0);
    }

}
