using UnityEngine;
private sealed class NativeRealtimeMultiplayerClient.<DeclineInvitation>c__AnonStorey10
{
    // Fields
    internal string invitationId;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient $this;
    
    // Methods
    public NativeRealtimeMultiplayerClient.<DeclineInvitation>c__AnonStorey10()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.RealtimeManager.FetchInvitationsResponse response)
    {
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        val_25 = this;
        if(response.RequestSucceeded() != false)
        {
                System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> val_3 = response.Invitations();
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_26 = val_3;
        }
        else
        {
                GooglePlayGames.OurUtils.Logger.e(msg:  0);
            return;
        }
        
        val_27 = 1152921504608018432;
        val_28 = 1152921504608124928;
        val_29 = 0;
        goto label_29;
        label_37:
        var val_26 = 0;
        val_26 = val_26 + 1;
        val_30 = val_3;
        if((val_3.Id().Equals(value:  this.invitationId)) != false)
        {
                this.$this.mRealtimeManager.DeclineInvitation(invitation:  val_3);
        }
        
        val_31 = val_29;
        if(val_3 != null)
        {
                var val_27 = 0;
            val_27 = val_27 + 1;
            val_32 = val_3;
        }
        
        val_29 = val_31;
        if(105 != 105)
        {
                val_29 = 0;
            if(val_31 != 0)
        {
                val_29 = 0;
        }
        
        }
        
        label_29:
        var val_28 = 0;
        val_28 = val_28 + 1;
        val_33 = val_3;
        if(((val_3 & 1) & 1) != 0)
        {
            goto label_37;
        }
        
        if(val_3 != null)
        {
                var val_29 = 0;
            val_29 = val_29 + 1;
            val_34 = val_3;
        }
        
        if(105 == 134)
        {
                return;
        }
        
        if( == 0)
        {
                return;
        }
        
        val_25 = ???;
        val_29 = ???;
        val_31 = ???;
        val_28 = ???;
        val_27 = ???;
    }

}
