using UnityEngine;
private sealed class NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9
{
    // Fields
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession newRoom;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient $this;
    
    // Methods
    public NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.RealtimeManager.RoomInboxUIResponse response)
    {
        IntPtr val_19;
        var val_20;
        var val_21;
        var val_22;
        typeof(NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyA).__il2cppRuntimeField_18 = this;
        this.$this.mCurrentSession.mShowingUI = false;
        if(response.ResponseStatus() != 1)
        {
            goto label_5;
        }
        
        typeof(NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyA).__il2cppRuntimeField_10 = response.Invitation();
        if(null == 0)
        {
            goto label_8;
        }
        
        typeof(NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyB).__il2cppRuntimeField_18 = this;
        goto label_9;
        label_5:
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        this.newRoom.LeaveRoom();
        return;
        label_8:
        mem[24] = this;
        label_9:
        typeof(NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyB).__il2cppRuntimeField_20 = new System.Object();
        typeof(NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyB).__il2cppRuntimeField_10 = GooglePlayGames.Native.NativeRealtimeMultiplayerClient.HelperForSession(session:  0);
        string val_6 = typeof(NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyA).__il2cppRuntimeField_10.Id();
        string val_7 = 0 + "About to accept invitation ";
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        val_19 = System.Void NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyB::<>m__0();
        System.Action val_9 = new System.Action(object:  new System.Object(), method:  val_19);
        this.newRoom.StartRoomCreation(currentPlayerId:  this.$this.mNativeClient.GetUserId(), createRoom:  null);
        val_20 = 0;
        val_21 = 208;
        if((typeof(NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyB).__il2cppRuntimeField_10) == 0)
        {
            goto label_23;
        }
        
        if((val_5 + 258) == 0)
        {
            goto label_24;
        }
        
        var val_18 = val_5 + 152;
        var val_19 = 0;
        val_18 = val_18 + 8;
        label_26:
        if(((val_5 + 152 + 8) + -8) == null)
        {
            goto label_25;
        }
        
        val_19 = val_19 + 1;
        val_18 = val_18 + 16;
        if(val_19 < (val_5 + 258))
        {
            goto label_26;
        }
        
        label_24:
        val_22 = typeof(NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyB).__il2cppRuntimeField_10;
        goto label_27;
        label_25:
        val_22 = ((val_5 + ((val_5 + 152 + 8)) << 4)) + 272;
        label_27:
        label_23:
        if(208 == 208)
        {
                return;
        }
        
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = ???;
        val_21 = ???;
        val_19 = ???;
    }

}
