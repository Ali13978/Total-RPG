using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<TakeTurn>c__AnonStoreyC
{
    // Fields
    internal byte[] data;
    internal System.Action<bool> callback;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<TakeTurn>c__AnonStoreyC()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant pendingParticipant, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)
    {
        this.$this.mTurnBasedManager.TakeTurn(match:  foundMatch, data:  this.data, nextParticipant:  pendingParticipant, callback:  new System.Action<TurnBasedMatchResponse>(object:  this, method:  System.Void NativeTurnBasedMultiplayerClient.<TakeTurn>c__AnonStoreyC::<>m__1(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse result)));
    }
    internal void <>m__1(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse result)
    {
        if(result.RequestSucceeded() != false)
        {
                this.callback.Invoke(obj:  true);
            return;
        }
        
        MultiplayerStatus val_2 = result.ResponseStatus();
        string val_3 = 0 + "Taking turn failed: "("Taking turn failed: ");
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        this.callback.Invoke(obj:  false);
    }

}
