using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<AcceptFromInbox>c__AnonStorey7
{
    // Fields
    internal System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<AcceptFromInbox>c__AnonStorey7()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.TurnBasedManager.MatchInboxUIResponse callbackResult)
    {
        var val_12;
        var val_13;
        var val_14;
        val_12 = callbackResult.Match();
        if(val_12 != null)
        {
                string val_4 = 0 + "Passing converted match to user callback:"("Passing converted match to user callback:");
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            this.callback.Invoke(arg1:  true, arg2:  val_12.AsTurnBasedMatch(selfPlayerId:  this.$this.mNativeClient.GetUserId()));
        }
        else
        {
                this.callback.Invoke(arg1:  false, arg2:  0);
        }
        
        val_13 = 101;
        if(val_12 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            val_14 = val_12;
        }
        
        if(101 == 101)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_12 = ???;
        val_13 = ???;
    }

}
