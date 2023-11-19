using UnityEngine;
private sealed class NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4
{
    // Fields
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession newRoom;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey5 <>f__ref$5;
    
    // Methods
    public NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse response)
    {
        var val_27;
        IntPtr val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        this.<>f__ref$5.$this.mCurrentSession.mShowingUI = false;
        if(response.Status() != 1)
        {
            goto label_5;
        }
        
        uint val_4 = response.MinimumAutomatchingPlayers() + (System.Linq.Enumerable.Count<I2.Loc.LanguageData>(source:  0));
        val_4 = val_4 + 1;
        this.<>f__ref$5.$this.mCurrentSession.mMinPlayersToStart = val_4;
        val_27 = GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder.Create();
        GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder val_6 = val_27.SetVariant(variantValue:  this.<>f__ref$5.variant);
        GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder val_7 = val_27.PopulateFromUIResponse(response:  response);
        object val_8 = new System.Object();
        typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey6).__il2cppRuntimeField_10 = val_27.Build();
        object val_10 = new System.Object();
        if(null == 0)
        {
            goto label_15;
        }
        
        typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey7).__il2cppRuntimeField_18 = this.<>f__ref$5;
        typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey7).__il2cppRuntimeField_20 = this;
        goto label_16;
        label_5:
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        this.newRoom.LeaveRoom();
        return;
        label_15:
        mem[24] = this.<>f__ref$5;
        mem[32] = this;
        label_16:
        typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey7).__il2cppRuntimeField_28 = null;
        typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey7).__il2cppRuntimeField_10 = GooglePlayGames.Native.NativeRealtimeMultiplayerClient.HelperForSession(session:  0);
        val_28 = System.Void NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey7::<>m__0();
        System.Action val_13 = new System.Action(object:  null, method:  val_28);
        this.newRoom.StartRoomCreation(currentPlayerId:  this.<>f__ref$5.$this.mNativeClient.GetUserId(), createRoom:  null);
        val_29 = 0;
        if((typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey7).__il2cppRuntimeField_10) == 0)
        {
            goto label_25;
        }
        
        if((val_11 + 258) == 0)
        {
            goto label_26;
        }
        
        var val_25 = val_11 + 152;
        var val_26 = 0;
        val_25 = val_25 + 8;
        label_28:
        if(((val_11 + 152 + 8) + -8) == null)
        {
            goto label_27;
        }
        
        val_26 = val_26 + 1;
        val_25 = val_25 + 16;
        if(val_26 < (val_11 + 258))
        {
            goto label_28;
        }
        
        label_26:
        val_30 = typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey7).__il2cppRuntimeField_10;
        goto label_29;
        label_27:
        val_30 = ((val_11 + ((val_11 + 152 + 8)) << 4)) + 272;
        label_29:
        label_25:
        val_31 = 295;
        if((267 != 267) && (val_29 != 0))
        {
                val_29 = 0;
            val_31 = 295;
        }
        
        if((typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey6).__il2cppRuntimeField_10) == 0)
        {
            goto label_33;
        }
        
        if((val_9 + 258) == 0)
        {
            goto label_34;
        }
        
        var val_27 = val_9 + 152;
        var val_28 = 0;
        val_27 = val_27 + 8;
        label_36:
        if(((val_9 + 152 + 8) + -8) == null)
        {
            goto label_35;
        }
        
        val_28 = val_28 + 1;
        val_27 = val_27 + 16;
        if(val_28 < (val_9 + 258))
        {
            goto label_36;
        }
        
        label_34:
        val_32 = typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey6).__il2cppRuntimeField_10;
        goto label_37;
        label_35:
        val_32 = ((val_9 + ((val_9 + 152 + 8)) << 4)) + 272;
        label_37:
        label_33:
        if((295 != 295) && (val_29 != 0))
        {
                val_29 = 0;
        }
        
        val_33 = 313;
        if(val_27 != null)
        {
                var val_29 = 0;
            val_29 = val_29 + 1;
            val_34 = val_27;
        }
        
        if(313 == 313)
        {
                return;
        }
        
        if(val_29 == 0)
        {
                return;
        }
        
        val_27 = ???;
        val_29 = ???;
        val_33 = ???;
        val_28 = ???;
    }

}
