using UnityEngine;
private class NativeRealtimeMultiplayerClient.ConnectingState : NativeRealtimeMultiplayerClient.MessagingEnabledState
{
    // Fields
    private const float InitialPercentComplete = 20;
    private static readonly System.Collections.Generic.HashSet<GooglePlayGames.Native.Cwrapper.Types.ParticipantStatus> FailedStatuses;
    private System.Collections.Generic.HashSet<string> mConnectedParticipants;
    private float mPercentComplete;
    private float mPercentPerParticipant;
    
    // Methods
    internal NativeRealtimeMultiplayerClient.ConnectingState(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession session)
    {
        this.mConnectedParticipants = new System.Collections.Generic.HashSet<System.String>();
        this.mPercentComplete = 20f;
        float val_2 = (float)(double)session.mMinPlayersToStart;
        val_2 = 80f / val_2;
        this.mPercentPerParticipant = val_2;
    }
    internal override void OnStateEntered()
    {
        X20 + 24.RoomSetupProgress(percent:  this.mPercentComplete);
    }
    internal override void HandleConnectedSetChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        NativeRealtimeMultiplayerClient.ConnectingState val_41;
        var val_42;
        float val_43;
        System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
        System.Runtime.InteropServices.HandleRef val_2 = room.SelfPtr();
        val_35 = val_2.handle;
        if((GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper})) == 3)
        {
            goto label_2;
        }
        
        System.Runtime.InteropServices.HandleRef val_4 = room.SelfPtr();
        val_35 = val_4.handle;
        if((GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_4.wrapper})) != 2)
        {
            goto label_7;
        }
        
        label_2:
        uint val_6 = room.ParticipantCount();
        mem2[0] = room.ParticipantCount() + (static_value_0213104C + 76);
        float val_35 = (float)(double)static_value_0213104C + 76;
        val_35 = 80f / val_35;
        this.mPercentPerParticipant = val_35;
        label_7:
        System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerParticipant> val_9 = room.Participants();
        var val_36 = 0;
        val_36 = val_36 + 1;
        val_35 = 0;
        val_36 = val_9;
        val_37 = 0;
        goto label_34;
        label_42:
        var val_37 = 0;
        val_37 = val_37 + 1;
        val_35 = 0;
        val_38 = val_9;
        if(val_9.IsConnectedToRoom() != false)
        {
                val_35 = public System.Boolean System.Collections.Generic.HashSet<System.String>::Add(System.String item);
            bool val_15 = Add(item:  val_9.Id());
        }
        
        if(val_9 != null)
        {
                var val_38 = 0;
            val_38 = val_38 + 1;
            val_35 = 0;
            val_39 = val_9;
        }
        
        val_37 = val_37;
        if(174 != 174)
        {
                val_37 = 0;
            if(val_37 != 0)
        {
                val_37 = 0;
        }
        
        }
        
        label_34:
        var val_39 = 0;
        val_39 = val_39 + 1;
        val_35 = 1;
        val_40 = val_9;
        if(((val_9 & 1) & 1) != 0)
        {
            goto label_42;
        }
        
        val_41 = this;
        if(val_9 != null)
        {
                var val_40 = 0;
            val_40 = val_40 + 1;
            val_35 = 0;
            val_42 = val_9;
        }
        
        if((mem[1152921512086668112] & 1) != 0)
        {
                GooglePlayGames.OurUtils.Logger.w(msg:  0);
            return;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_20 = System.Linq.Enumerable.Except<System.String>(first:  0, second:  mem[1152921512086668112]);
        System.Runtime.InteropServices.HandleRef val_21 = room.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_21.wrapper})) == 5)
        {
                TSource[] val_23 = System.Linq.Enumerable.ToArray<System.Type>(source:  0);
            string val_24 = System.String.Join(separator:  0, value:  ",");
            string val_25 = 0 + "Participants disconnected during room setup, failing. Participants were: "("Participants disconnected during room setup, failing. Participants were: ");
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            mem[1152921512086668080] + 24.RoomConnected(success:  false);
            mem[1152921512086668080].EnterState(handler:  new NativeRealtimeMultiplayerClient.ShutdownState(session:  mem[1152921512086668080]), fireStateEnteredEvent:  true);
            return;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_27 = System.Linq.Enumerable.Except<System.String>(first:  0, second:  val_1);
        TSource[] val_28 = System.Linq.Enumerable.ToArray<System.Type>(source:  0);
        string val_29 = System.String.Join(separator:  0, value:  ",");
        string val_30 = 0 + "New participants connected: "("New participants connected: ");
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        System.Runtime.InteropServices.HandleRef val_31 = room.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_31.wrapper})) == 4)
        {
                GooglePlayGames.OurUtils.Logger.d(msg:  0);
            mem[1152921512086668080].EnterState(handler:  new NativeRealtimeMultiplayerClient.MessagingEnabledState(session:  mem[1152921512086668080], room:  room), fireStateEnteredEvent:  true);
            mem[1152921512086668080] + 24.RoomConnected(success:  true);
            return;
        }
        
        float val_41 = (float)System.Linq.Enumerable.Count<I2.Loc.LanguageData>(source:  0);
        val_41 = this.mPercentPerParticipant * val_41;
        val_43 = mem[1152921512086668120] + val_41;
        mem[1152921512086668120] = val_43;
        mem[1152921512086668112] = val_1;
        if(mem[1152921512086668080] == 0)
        {
                val_43 = mem[1152921512086668120];
        }
        
        mem[1152921512086668080] + 24.RoomSetupProgress(percent:  val_43);
    }
    internal override void HandleParticipantStatusChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
    {
        GooglePlayGames.BasicApi.Multiplayer.Participant val_9;
        var val_10;
        val_9 = participant;
        val_10 = null;
        val_10 = null;
        System.Runtime.InteropServices.HandleRef val_1 = val_9.SelfPtr();
        if((NativeRealtimeMultiplayerClient.ConnectingState.FailedStatuses.Contains(item:  GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}))) == false)
        {
                return;
        }
        
        val_9 = val_9.AsParticipant();
        NativeRealtimeMultiplayerClient.ConnectingState.FailedStatuses + 24.ParticipantLeft(participant:  val_9);
        System.Runtime.InteropServices.HandleRef val_5 = room.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_5.wrapper})) == 2)
        {
                return;
        }
        
        System.Runtime.InteropServices.HandleRef val_7 = room.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_7.wrapper})) != 3)
        {
            goto typeof(NativeRealtimeMultiplayerClient.ConnectingState).__il2cppRuntimeField_170;
        }
    
    }
    internal override void LeaveRoom()
    {
        EnterState(handler:  new NativeRealtimeMultiplayerClient.LeavingRoom(session:  static_value_02131000, room:  X21, leavingCompleteCallback:  new System.Action(object:  this, method:  System.Void NativeRealtimeMultiplayerClient.ConnectingState::<LeaveRoom>m__0())), fireStateEnteredEvent:  true);
    }
    internal override void ShowWaitingRoomUI(uint minimumParticipantsBeforeStarting)
    {
        static_value_02131020.ShowWaitingRoomUI(room:  X22, minimumParticipantsBeforeStarting:  minimumParticipantsBeforeStarting, callback:  new System.Action<WaitingRoomUIResponse>(object:  this, method:  System.Void NativeRealtimeMultiplayerClient.ConnectingState::<ShowWaitingRoomUI>m__1(GooglePlayGames.Native.PInvoke.RealtimeManager.WaitingRoomUIResponse response)));
    }
    private static NativeRealtimeMultiplayerClient.ConnectingState()
    {
        if(null != 0)
        {
                bool val_2 = Add(item:  3);
        }
        else
        {
                bool val_3 = Add(item:  3);
        }
        
        bool val_4 = Add(item:  4);
        NativeRealtimeMultiplayerClient.ConnectingState.FailedStatuses = new System.Collections.Generic.HashSet<ParticipantStatus>();
    }
    private void <LeaveRoom>m__0()
    {
        X19 + 24.RoomConnected(success:  false);
    }
    private void <ShowWaitingRoomUI>m__1(GooglePlayGames.Native.PInvoke.RealtimeManager.WaitingRoomUIResponse response)
    {
        State val_16;
        var val_17;
        val_16 = this;
        UIStatus val_1 = response.ResponseStatus();
        val_17 = 0 + "ShowWaitingRoomUI Response: "("ShowWaitingRoomUI Response: ");
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        if(response.ResponseStatus() == 1)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = "Connecting state ShowWaitingRoomUI: room pcount:";
            typeof(System.Object[]).__il2cppRuntimeField_28 = response.Room().ParticipantCount();
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " status: ";
            System.Runtime.InteropServices.HandleRef val_7 = response.Room().SelfPtr();
            typeof(System.Object[]).__il2cppRuntimeField_38 = GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_7.wrapper});
            string val_9 = +0;
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            val_17 = response.Room();
            System.Runtime.InteropServices.HandleRef val_11 = val_17.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_11.wrapper})) != 4)
        {
                return;
        }
        
            NativeRealtimeMultiplayerClient.MessagingEnabledState val_14 = null;
            val_16 = val_14;
            val_14 = new NativeRealtimeMultiplayerClient.MessagingEnabledState(session:  response, room:  response.Room());
            val_17.EnterState(handler:  val_16, fireStateEnteredEvent:  true);
            return;
        }
        
        if(response.ResponseStatus() == 18)
        {
                return;
        }
        
        response.RoomSetupProgress(percent:  this.mPercentComplete);
    }

}
