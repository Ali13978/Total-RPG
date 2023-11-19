using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<LeaveDuringTurn>c__AnonStorey12
{
    // Fields
    internal System.Action<bool> callback;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<LeaveDuringTurn>c__AnonStorey12()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant pendingParticipant, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)
    {
        this.$this.mTurnBasedManager.LeaveDuringMyTurn(match:  foundMatch, nextParticipant:  pendingParticipant, callback:  new System.Action<MultiplayerStatus>(object:  this, method:  System.Void NativeTurnBasedMultiplayerClient.<LeaveDuringTurn>c__AnonStorey12::<>m__1(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus status)));
    }
    internal void <>m__1(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus status)
    {
        this.callback.Invoke(obj:  (status > 0) ? 1 : 0);
    }

}
