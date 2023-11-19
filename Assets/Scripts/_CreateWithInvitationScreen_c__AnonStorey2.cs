using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey2
{
    // Fields
    internal System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey2()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)
    {
        this.callback.Invoke(arg1:  (status == 1) ? 1 : 0, arg2:  match);
    }

}
