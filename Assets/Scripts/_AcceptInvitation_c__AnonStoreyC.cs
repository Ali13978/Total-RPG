using UnityEngine;
private sealed class NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC
{
    // Fields
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession newRoom;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyD <>f__ref$13;
    
    // Methods
    public NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.RealtimeManager.FetchInvitationsResponse response)
    {
        NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC val_25;
        var val_26;
        var val_27;
        var val_28;
        System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> val_29;
        var val_30;
        System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> val_31;
        string val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        val_25 = this;
        if(response.RequestSucceeded() != false)
        {
                System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> val_3 = response.Invitations();
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_26 = val_3;
        }
        else
        {
                GooglePlayGames.OurUtils.Logger.e(msg:  0);
            this.newRoom.LeaveRoom();
            return;
        }
        
        val_27 = 0;
        goto label_64;
        label_74:
        object val_5 = new System.Object();
        if(null != 0)
        {
                typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyE).__il2cppRuntimeField_18 = this.<>f__ref$13;
        }
        else
        {
                mem[24] = this.<>f__ref$13;
        }
        
        typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyE).__il2cppRuntimeField_20 = val_25;
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_28 = val_3;
        val_29 = val_3;
        if(null != 0)
        {
                val_30 = null;
            typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyE).__il2cppRuntimeField_10 = val_29;
            val_31 = val_29;
        }
        else
        {
                mem[16] = val_29;
            val_31 = mem[16];
            val_29 = mem[16];
            val_30 = 16;
        }
        
        val_32 = this.<>f__ref$13.invitationId;
        if((val_29.Id().Equals(value:  val_32)) == false)
        {
            goto label_25;
        }
        
        System.Runtime.InteropServices.HandleRef val_10 = val_30.SelfPtr();
        this.<>f__ref$13.$this.mCurrentSession.mMinPlayersToStart = mem[16].ParticipantCount() + (GooglePlayGames.Native.Cwrapper.MultiplayerInvitation.MultiplayerInvitation_AutomatchingSlotsAvailable(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_10.wrapper}));
        string val_14 = 0 + "Setting MinPlayersToStart with invitation to : "("Setting MinPlayersToStart with invitation to : ");
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        object val_15 = new System.Object();
        if(null == 0)
        {
            goto label_40;
        }
        
        typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyF).__il2cppRuntimeField_18 = this.<>f__ref$13;
        typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyF).__il2cppRuntimeField_20 = val_25;
        goto label_41;
        label_25:
        val_33 = 354;
        val_34 = val_27;
        goto label_68;
        label_40:
        mem[24] = this.<>f__ref$13;
        mem[32] = val_25;
        label_41:
        typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyF).__il2cppRuntimeField_28 = null;
        typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyF).__il2cppRuntimeField_10 = GooglePlayGames.Native.NativeRealtimeMultiplayerClient.HelperForSession(session:  0);
        val_32 = this.<>f__ref$13.$this.mNativeClient.GetUserId();
        System.Action val_18 = new System.Action(object:  null, method:  System.Void NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyF::<>m__0());
        this.newRoom.StartRoomCreation(currentPlayerId:  val_32, createRoom:  null);
        if((typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyF).__il2cppRuntimeField_10) == 0)
        {
            goto label_48;
        }
        
        if((val_16 + 258) == 0)
        {
            goto label_49;
        }
        
        var val_25 = val_16 + 152;
        var val_26 = 0;
        val_25 = val_25 + 8;
        label_51:
        if(((val_16 + 152 + 8) + -8) == null)
        {
            goto label_50;
        }
        
        val_26 = val_26 + 1;
        val_25 = val_25 + 16;
        if(val_26 < (val_16 + 258))
        {
            goto label_51;
        }
        
        label_49:
        val_35 = typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyF).__il2cppRuntimeField_10;
        goto label_52;
        label_50:
        val_35 = ((val_16 + ((val_16 + 152 + 8)) << 4)) + 272;
        label_52:
        label_48:
        if(420 == 420)
        {
                val_33 = 420;
            val_34 = val_27;
        }
        else
        {
                val_34 = 0;
            val_33 = 354;
        }
        
        label_68:
        if(val_31 == 0)
        {
            goto label_56;
        }
        
        var val_29 = val_31;
        if((val_3 + 258) == 0)
        {
            goto label_57;
        }
        
        var val_27 = val_3 + 152;
        var val_28 = 0;
        val_27 = val_27 + 8;
        label_59:
        if(((val_3 + 152 + 8) + -8) == null)
        {
            goto label_58;
        }
        
        val_28 = val_28 + 1;
        val_27 = val_27 + 16;
        if(val_28 < (val_3 + 258))
        {
            goto label_59;
        }
        
        label_57:
        val_36 = val_31;
        goto label_60;
        label_58:
        val_29 = val_29 + (((val_3 + 152 + 8)) << 4);
        val_36 = val_29 + 272;
        label_60:
        label_56:
        val_27 = val_34;
        if(354 == 354)
        {
            goto label_64;
        }
        
        if(354 == 420)
        {
            goto label_90;
        }
        
        val_27 = 0;
        if(val_34 != 0)
        {
                val_27 = 0;
        }
        
        label_64:
        var val_30 = 0;
        val_30 = val_30 + 1;
        val_37 = val_3;
        if(((val_3 & 1) & 1) != 0)
        {
            goto label_74;
        }
        
        val_38 = val_27;
        label_90:
        if(val_3 != null)
        {
                var val_31 = 0;
            val_31 = val_31 + 1;
            val_39 = val_3;
        }
        
        if(354 != 383)
        {
                if(354 == 420)
        {
                return;
        }
        
        }
        
        string val_22 = 0 + "Room creation failed since we could not find invitation with ID ";
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        val_25 = this.newRoom;
        val_25.LeaveRoom();
    }

}
