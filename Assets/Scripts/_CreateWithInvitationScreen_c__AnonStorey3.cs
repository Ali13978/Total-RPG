using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey3
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
    internal uint variant;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey3()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse result)
    {
        var val_18;
        GooglePlayGames.Native.NativeTurnBasedMultiplayerClient val_19;
        GooglePlayGames.Native.PInvoke.TurnBasedManager val_20;
        System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        if(result.Status() != 1)
        {
            goto label_2;
        }
        
        val_18 = GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder.Create();
        GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder val_4 = val_18.PopulateFromUIResponse(response:  result).SetVariant(variant:  this.variant);
        GooglePlayGames.Native.PInvoke.TurnBasedMatchConfig val_5 = val_18.Build();
        val_19 = this.$this;
        if(val_19 == null)
        {
            goto label_6;
        }
        
        val_20 = this.$this.mTurnBasedManager;
        val_21 = this.callback;
        goto label_11;
        label_2:
        this.callback.Invoke(arg1:  result.Status(), arg2:  0);
        return;
        label_6:
        val_20 = this.$this.mTurnBasedManager;
        val_21 = this.callback;
        if(this.$this != null)
        {
                val_19 = this.$this;
        }
        else
        {
                val_19 = 0;
        }
        
        label_11:
        val_20.CreateMatch(config:  val_5, callback:  val_19.BridgeMatchToUserCallback(userCallback:  val_21));
        val_22 = 0;
        val_23 = 115;
        if(val_5 != null)
        {
                var val_18 = 0;
            val_18 = val_18 + 1;
            val_24 = val_5;
        }
        
        val_25 = 133;
        if((115 != 115) && (val_22 != 0))
        {
                val_22 = 0;
            val_25 = 133;
        }
        
        if(val_18 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_26 = val_18;
        }
        
        if(133 == 133)
        {
                return;
        }
        
        if(val_22 == 0)
        {
                return;
        }
        
        val_18 = ???;
        val_25 = ???;
        val_23 = ???;
    }

}
