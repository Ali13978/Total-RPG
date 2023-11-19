using UnityEngine;
private class NativeRealtimeMultiplayerClient.RoomSession
{
    // Fields
    private readonly object mLifecycleLock;
    private readonly GooglePlayGames.Native.NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener mListener;
    private readonly GooglePlayGames.Native.PInvoke.RealtimeManager mManager;
    private string mCurrentPlayerId;
    private GooglePlayGames.Native.NativeRealtimeMultiplayerClient.State mState;
    private bool mStillPreRoomCreation;
    private GooglePlayGames.BasicApi.Multiplayer.Invitation mInvitation;
    private bool mShowingUI;
    private uint mMinPlayersToStart;
    
    // Properties
    internal bool ShowingUI { get; set; }
    internal uint MinPlayersToStart { get; set; }
    
    // Methods
    internal NativeRealtimeMultiplayerClient.RoomSession(GooglePlayGames.Native.PInvoke.RealtimeManager manager, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
    {
        this.mLifecycleLock = new System.Object();
        this.mManager = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        this.mListener = new NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener(listener:  listener);
        this.EnterState(handler:  new NativeRealtimeMultiplayerClient.BeforeRoomCreateStartedState(session:  this), fireStateEnteredEvent:  false);
        this.mStillPreRoomCreation = true;
    }
    internal bool get_ShowingUI()
    {
        return (bool)this.mShowingUI;
    }
    internal void set_ShowingUI(bool value)
    {
        this.mShowingUI = value;
    }
    internal uint get_MinPlayersToStart()
    {
        return (uint)this.mMinPlayersToStart;
    }
    internal void set_MinPlayersToStart(uint value)
    {
        this.mMinPlayersToStart = value;
    }
    internal GooglePlayGames.Native.PInvoke.RealtimeManager Manager()
    {
        return (GooglePlayGames.Native.PInvoke.RealtimeManager)this.mManager;
    }
    internal bool IsActive()
    {
        if(this.mState == null)
        {
            
        }
    
    }
    internal string SelfPlayerId()
    {
        return (string)this.mCurrentPlayerId;
    }
    public void SetInvitation(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation)
    {
        this.mInvitation = invitation;
    }
    public GooglePlayGames.BasicApi.Multiplayer.Invitation GetInvitation()
    {
        return (GooglePlayGames.BasicApi.Multiplayer.Invitation)this.mInvitation;
    }
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener OnGameThreadListener()
    {
        return (OnGameThreadForwardingListener)this.mListener;
    }
    internal void EnterState(GooglePlayGames.Native.NativeRealtimeMultiplayerClient.State handler)
    {
        this.EnterState(handler:  handler, fireStateEnteredEvent:  true);
    }
    internal void EnterState(GooglePlayGames.Native.NativeRealtimeMultiplayerClient.State handler, bool fireStateEnteredEvent)
    {
        State val_5 = handler;
        System.Threading.Monitor.Enter(obj:  0);
        this.mState = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        if(fireStateEnteredEvent != false)
        {
                System.Type val_3 = val_5.GetType();
            val_5 = 0 + "Entering state: "("Entering state: ");
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
        }
        
        System.Threading.Monitor.Exit(obj:  0);
    }
    internal void LeaveRoom()
    {
        if(this.mShowingUI != false)
        {
                GooglePlayGames.OurUtils.Logger.d(msg:  0);
            return;
        }
        
        System.Threading.Monitor.Enter(obj:  0);
        System.Threading.Monitor.Exit(obj:  0);
    }
    internal void ShowWaitingRoomUI()
    {
        if(this.mState == null)
        {
            
        }
    
    }
    internal void StartRoomCreation(string currentPlayerId, System.Action createRoom)
    {
        bool val_4;
        System.Threading.Monitor.Enter(obj:  0);
        val_4 = this.mStillPreRoomCreation;
        if(val_4 == false)
        {
            goto label_1;
        }
        
        val_4 = this.mState;
        if(((val_4 & 1) & 1) == 0)
        {
            goto label_3;
        }
        
        this.mCurrentPlayerId = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        this.mStillPreRoomCreation = false;
        NativeRealtimeMultiplayerClient.RoomCreationPendingState val_3 = new NativeRealtimeMultiplayerClient.RoomCreationPendingState(session:  this);
        this.EnterState(handler:  null, fireStateEnteredEvent:  true);
        createRoom.Invoke();
        goto label_8;
        label_1:
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        goto label_8;
        label_3:
        GooglePlayGames.OurUtils.Logger.w(msg:  0);
        label_8:
        System.Threading.Monitor.Exit(obj:  0);
    }
    internal void OnRoomStatusChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
        System.Threading.Monitor.Enter(obj:  0);
        System.Threading.Monitor.Exit(obj:  0);
    }
    internal void OnConnectedSetChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
        System.Threading.Monitor.Enter(obj:  0);
        System.Threading.Monitor.Exit(obj:  0);
    }
    internal void OnParticipantStatusChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
    {
        System.Threading.Monitor.Enter(obj:  0);
        System.Threading.Monitor.Exit(obj:  0);
    }
    internal void HandleRoomResponse(GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse response)
    {
        System.Threading.Monitor.Enter(obj:  0);
        System.Threading.Monitor.Exit(obj:  0);
    }
    internal void OnDataReceived(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant sender, byte[] data, bool isReliable)
    {
        isReliable = isReliable;
        goto typeof(NativeRealtimeMultiplayerClient.State).__il2cppRuntimeField_1D0;
    }
    internal void SendMessageToAll(bool reliable, byte[] data)
    {
        reliable = reliable;
        this.SendMessageToAll(reliable:  reliable, data:  data, offset:  0, length:  data.Length);
    }
    internal void SendMessageToAll(bool reliable, byte[] data, int offset, int length)
    {
        bool val_1 = reliable;
        goto typeof(NativeRealtimeMultiplayerClient.State).__il2cppRuntimeField_1F0;
    }
    internal void SendMessage(bool reliable, string participantId, byte[] data)
    {
        reliable = reliable;
        this.SendMessage(reliable:  reliable, participantId:  participantId, data:  data, offset:  0, length:  data.Length);
    }
    internal void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length)
    {
        bool val_1 = reliable;
        goto typeof(NativeRealtimeMultiplayerClient.State).__il2cppRuntimeField_1E0;
    }
    internal System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> GetConnectedParticipants()
    {
        if(this.mState == null)
        {
            
        }
    
    }
    internal virtual GooglePlayGames.BasicApi.Multiplayer.Participant GetSelf()
    {
        if(this.mState == null)
        {
            
        }
    
    }
    internal virtual GooglePlayGames.BasicApi.Multiplayer.Participant GetParticipant(string participantId)
    {
        if(this.mState == null)
        {
            
        }
    
    }
    internal virtual bool IsRoomConnected()
    {
        if(this.mState == null)
        {
            
        }
    
    }

}
