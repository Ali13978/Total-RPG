using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<BridgeMatchToUserCallback>c__AnonStorey6
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> userCallback;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<BridgeMatchToUserCallback>c__AnonStorey6()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse callbackResult)
    {
        var val_14;
        var val_15;
        var val_16;
        val_14 = callbackResult.Match();
        if(val_14 != null)
        {
                string val_4 = 0 + "Passing converted match to user callback:"("Passing converted match to user callback:");
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            this.userCallback.Invoke(arg1:  1, arg2:  val_14.AsTurnBasedMatch(selfPlayerId:  this.$this.mNativeClient.GetUserId()));
        }
        else
        {
                if((callbackResult.ResponseStatus() + 5) < 8)
        {
                val_15 = mem[25808864 + ((val_5 + 5)) << 2];
            val_15 = 25808864 + ((val_5 + 5)) << 2;
        }
        else
        {
                val_15 = 0;
        }
        
            var val_7 = val_15 & 65535;
            val_7 = 8129 >> val_7;
            if((val_7 & 1) == 0)
        {
                return;
        }
        
            this.userCallback.Invoke(arg1:  -2, arg2:  0);
        }
        
        val_15 = 202;
        if(val_14 != null)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_16 = val_14;
        }
        
        if(202 == 202)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_14 = ???;
        val_15 = ???;
    }

}
