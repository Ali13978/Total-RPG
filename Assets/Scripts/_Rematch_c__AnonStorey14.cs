using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<Rematch>c__AnonStorey14
{
    // Fields
    internal System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<Rematch>c__AnonStorey14()
    {
    
    }
    internal void <>m__0(bool failed)
    {
        this.callback.Invoke(arg1:  false, arg2:  0);
    }
    internal void <>m__1(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)
    {
        if(this.$this == null)
        {
                this.$this = this.$this;
        }
        
        this.$this.mTurnBasedManager.Rematch(match:  foundMatch, callback:  this.$this.BridgeMatchToUserCallback(userCallback:  new System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  this, method:  System.Void NativeTurnBasedMultiplayerClient.<Rematch>c__AnonStorey14::<>m__2(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch m))));
    }
    internal void <>m__2(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch m)
    {
        this.callback.Invoke(arg1:  (status == 1) ? 1 : 0, arg2:  m);
    }

}
