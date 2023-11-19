using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<GetAllMatches>c__AnonStorey5
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]> callback;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<GetAllMatches>c__AnonStorey5()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchesResponse allMatches)
    {
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        if(allMatches != null)
        {
                val_33 = allMatches.MyTurnMatchesCount();
            val_34 = allMatches.TheirTurnMatchesCount();
        }
        else
        {
                val_33 = 0.MyTurnMatchesCount();
            val_34 = 0.TheirTurnMatchesCount();
        }
        
        val_33 = (val_33 + val_34) + allMatches.CompletedMatchesCount();
        System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> val_7 = allMatches.MyTurnMatches();
        var val_33 = 0;
        val_33 = val_33 + 1;
        val_35 = val_7;
        val_36 = 0;
        goto label_9;
        label_28:
        val_36 = W25;
        typeof(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]).__il2cppRuntimeField_20 = val_7;
        label_9:
        var val_34 = 0;
        val_34 = val_34 + 1;
        val_37 = val_7;
        if(((val_7 & 1) & 1) == 0)
        {
            goto label_105;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        val_38 = val_7;
        var val_12 = val_36 + 1;
        GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_14 = val_7.AsTurnBasedMatch(selfPlayerId:  this.$this.mNativeClient.GetUserId());
        if((val_14 == null) || (val_14 != null))
        {
            goto label_28;
        }
        
        goto label_28;
        label_105:
        if(val_7 != null)
        {
                var val_36 = 0;
            val_36 = val_36 + 1;
            val_42 = val_7;
        }
        
        if( == 117)
        {
                val_40 = 0;
        }
        else
        {
                val_39 = 0;
        }
        
        System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> val_16 = allMatches.TheirTurnMatches();
        var val_37 = 0;
        val_37 = val_37 + 1;
        val_43 = val_16;
        val_44 = 1152921504608178176;
        goto label_43;
        label_62:
        var val_18 = null + (((long)(int)((W25 + 1))) << 3);
        val_41 = 1152921504608018432;
        mem2[0] = val_39;
        label_43:
        var val_38 = 0;
        val_38 = val_38 + 1;
        val_45 = val_16;
        if(((val_16 & 1) & 1) == 0)
        {
            goto label_106;
        }
        
        var val_39 = 0;
        val_39 = val_39 + 1;
        val_46 = val_16;
        GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_23 = val_16.AsTurnBasedMatch(selfPlayerId:  this.$this.mNativeClient.GetUserId());
        if((val_23 == null) || (val_23 != null))
        {
            goto label_62;
        }
        
        goto label_62;
        label_106:
        if(val_16 != null)
        {
                var val_40 = 0;
            val_40 = val_40 + 1;
            val_49 = val_16;
        }
        
        if( == 206)
        {
            
        }
        else
        {
                val_47 = 0;
        }
        
        System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> val_25 = allMatches.CompletedMatches();
        var val_41 = 0;
        val_41 = val_41 + 1;
        val_50 = val_25;
        val_51 = val_47;
        goto label_77;
        label_96:
        val_48 = 34531042;
        mem[1152921505717907096] = val_16;
        label_77:
        var val_42 = 0;
        val_42 = val_42 + 1;
        val_52 = val_25;
        if(((val_25 & 1) & 1) == 0)
        {
            goto label_107;
        }
        
        var val_43 = 0;
        val_43 = val_43 + 1;
        val_53 = val_25;
        GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_31 = val_25.AsTurnBasedMatch(selfPlayerId:  this.$this.mNativeClient.GetUserId());
        if((val_31 == null) || (val_31 != null))
        {
            goto label_96;
        }
        
        goto label_96;
        label_107:
        if(val_25 != null)
        {
                var val_44 = 0;
            val_44 = val_44 + 1;
            val_54 = val_25;
        }
        
        this.callback.Invoke(obj:  null);
    }

}
