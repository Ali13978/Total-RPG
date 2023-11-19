using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<Leave>c__AnonStorey11
{
    // Fields
    internal System.Action<bool> callback;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<Leave>c__AnonStorey11()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)
    {
        this.$this.mTurnBasedManager.LeaveMatchDuringTheirTurn(match:  foundMatch, callback:  new System.Action<MultiplayerStatus>(object:  this, method:  System.Void NativeTurnBasedMultiplayerClient.<Leave>c__AnonStorey11::<>m__1(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus status)));
    }
    internal void <>m__1(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus status)
    {
        this.callback.Invoke(obj:  (status > 0) ? 1 : 0);
    }

}
