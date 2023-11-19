using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<AcknowledgeFinished>c__AnonStorey10
{
    // Fields
    internal System.Action<bool> callback;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<AcknowledgeFinished>c__AnonStorey10()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)
    {
        this.$this.mTurnBasedManager.ConfirmPendingCompletion(match:  foundMatch, callback:  new System.Action<TurnBasedMatchResponse>(object:  this, method:  System.Void NativeTurnBasedMultiplayerClient.<AcknowledgeFinished>c__AnonStorey10::<>m__1(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse response)));
    }
    internal void <>m__1(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse response)
    {
        this.callback.Invoke(obj:  response.RequestSucceeded());
    }

}
