using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<HandleMatchEvent>c__AnonStoreyB
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> currentDelegate;
    internal GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch match;
    internal bool shouldAutolaunch;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<HandleMatchEvent>c__AnonStoreyB()
    {
    
    }
    internal void <>m__0()
    {
        this.currentDelegate.Invoke(arg1:  this.match.AsTurnBasedMatch(selfPlayerId:  this.$this.mNativeClient.GetUserId()), arg2:  (this.shouldAutolaunch == true) ? 1 : 0);
        this.match.ForgetMe();
    }

}
