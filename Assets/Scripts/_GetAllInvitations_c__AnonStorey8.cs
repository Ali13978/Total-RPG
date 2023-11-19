using UnityEngine;
private sealed class NativeRealtimeMultiplayerClient.<GetAllInvitations>c__AnonStorey8
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback;
    
    // Methods
    public NativeRealtimeMultiplayerClient.<GetAllInvitations>c__AnonStorey8()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.RealtimeManager.FetchInvitationsResponse response)
    {
        var val_13;
        var val_14;
        System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> val_15;
        GooglePlayGames.BasicApi.Multiplayer.Invitation[] val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_13 = response;
        if(val_13.RequestSucceeded() == false)
        {
            goto label_2;
        }
        
        System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Invitation> val_3 = new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Invitation>();
        System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> val_4 = val_13.Invitations();
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_14 = val_4;
        goto label_8;
        label_2:
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        val_15 = this.callback;
        val_16 = null;
        val_17 = public System.Void System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]>::Invoke(GooglePlayGames.BasicApi.Multiplayer.Invitation[] obj);
        goto label_12;
        label_8:
        val_13 = val_4;
        val_18 = 0;
        goto label_28;
        label_36:
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_19 = val_13;
        Add(item:  val_13.AsInvitation());
        if(val_13 != null)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_20 = val_13;
        }
        
        val_18 = val_18;
        if(101 != 101)
        {
                val_18 = 0;
            if(val_18 != 0)
        {
                val_18 = 0;
        }
        
        }
        
        label_28:
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_21 = val_13;
        if(((val_13 & 1) & 1) != 0)
        {
            goto label_36;
        }
        
        if(val_13 != null)
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_22 = val_13;
        }
        
        val_15 = val_15;
        val_16 = ToArray();
        val_17 = public System.Void System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]>::Invoke(GooglePlayGames.BasicApi.Multiplayer.Invitation[] obj);
        label_12:
        val_15.Invoke(obj:  val_16);
    }

}
