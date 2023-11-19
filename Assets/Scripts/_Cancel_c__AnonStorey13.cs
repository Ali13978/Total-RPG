using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<Cancel>c__AnonStorey13
{
    // Fields
    internal System.Action<bool> callback;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<Cancel>c__AnonStorey13()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)
    {
        this.$this.mTurnBasedManager.CancelMatch(match:  foundMatch, callback:  new System.Action<MultiplayerStatus>(object:  this, method:  System.Void NativeTurnBasedMultiplayerClient.<Cancel>c__AnonStorey13::<>m__1(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus status)));
    }
    internal void <>m__1(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus status)
    {
        this.callback.Invoke(obj:  (status > 0) ? 1 : 0);
    }

}
