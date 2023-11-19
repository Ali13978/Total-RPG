using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<GetAllInvitations>c__AnonStorey4
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<GetAllInvitations>c__AnonStorey4()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchesResponse allMatches)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> val_2 = allMatches.Invitations();
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_9 = val_2;
        val_10 = 0;
        goto label_8;
        label_25:
        val_10 = 1;
        typeof(GooglePlayGames.BasicApi.Multiplayer.Invitation[]).__il2cppRuntimeField_20 = allMatches.InvitationCount();
        label_8:
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_11 = val_2;
        if(((val_2 & 1) & 1) == 0)
        {
            goto label_34;
        }
        
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_12 = val_2;
        GooglePlayGames.BasicApi.Multiplayer.Invitation val_7 = val_2.AsInvitation();
        if((val_7 == null) || (val_7 != null))
        {
            goto label_25;
        }
        
        goto label_25;
        label_34:
        if(val_2 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            val_13 = val_2;
        }
        
        this.callback.Invoke(obj:  null);
    }

}
