using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<AcceptInvitation>c__AnonStorey8
{
    // Fields
    internal string invitationId;
    internal System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<AcceptInvitation>c__AnonStorey8()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
    {
        GooglePlayGames.Native.NativeTurnBasedMultiplayerClient val_4;
        if(invitation != null)
        {
                val_4 = this.$this;
            if(this.$this == null)
        {
                val_4 = this.$this;
        }
        
            this.$this.mTurnBasedManager.AcceptInvitation(invitation:  invitation, callback:  val_4.BridgeMatchToUserCallback(userCallback:  new System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  this, method:  System.Void NativeTurnBasedMultiplayerClient.<AcceptInvitation>c__AnonStorey8::<>m__1(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match))));
            return;
        }
        
        string val_3 = 0 + "Could not find invitation with id ";
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        this.callback.Invoke(arg1:  false, arg2:  0);
    }
    internal void <>m__1(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)
    {
        this.callback.Invoke(arg1:  (status == 1) ? 1 : 0, arg2:  match);
    }

}
