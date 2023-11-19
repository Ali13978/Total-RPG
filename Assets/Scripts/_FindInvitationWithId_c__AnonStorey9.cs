using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<FindInvitationWithId>c__AnonStorey9
{
    // Fields
    internal System.Action<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> callback;
    internal string invitationId;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<FindInvitationWithId>c__AnonStorey9()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchesResponse allMatches)
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        if(allMatches.Status() <= 0)
        {
            goto label_45;
        }
        
        System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> val_2 = allMatches.Invitations();
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_13 = val_2;
        val_14 = 0;
        goto label_28;
        label_36:
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_15 = val_2;
        if((val_2.Id().Equals(value:  this.invitationId)) != false)
        {
                this.callback.Invoke(obj:  val_2);
            val_16 = 149;
        }
        else
        {
                val_16 = 108;
        }
        
        if(val_2 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            val_17 = val_2;
        }
        
        val_14 = val_14;
        if(108 == 108)
        {
            goto label_28;
        }
        
        if(108 == 149)
        {
            goto label_47;
        }
        
        val_14 = 0;
        if(val_14 != 0)
        {
                val_14 = 0;
        }
        
        label_28:
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_18 = val_2;
        if(((val_2 & 1) & 1) != 0)
        {
            goto label_36;
        }
        
        val_12 = val_14;
        label_47:
        if(val_2 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_19 = val_2;
        }
        
        if(108 != 137)
        {
                if(108 == 149)
        {
                return;
        }
        
        }
        
        label_45:
        this.callback.Invoke(obj:  0);
    }

}
