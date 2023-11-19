using UnityEngine;
private sealed class NativeClient.<RegisterInvitationDelegate>c__AnonStorey13
{
    // Fields
    internal GooglePlayGames.BasicApi.InvitationReceivedDelegate invitationDelegate;
    
    // Methods
    public NativeClient.<RegisterInvitationDelegate>c__AnonStorey13()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation, bool autoAccept)
    {
        autoAccept = autoAccept;
        this.invitationDelegate.Invoke(invitation:  invitation, shouldAutoAccept:  autoAccept);
    }

}
