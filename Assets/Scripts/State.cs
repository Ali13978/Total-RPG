using UnityEngine;
internal abstract class NativeRealtimeMultiplayerClient.State
{
    // Methods
    protected NativeRealtimeMultiplayerClient.State()
    {
    
    }
    internal virtual void HandleRoomResponse(GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse response)
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
    }
    internal virtual bool IsActive()
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        return true;
    }
    internal virtual void LeaveRoom()
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
    }
    internal virtual void ShowWaitingRoomUI(uint minimumParticipantsBeforeStarting)
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
    }
    internal virtual void OnStateEntered()
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
    }
    internal virtual void OnRoomStatusChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
    }
    internal virtual void OnConnectedSetChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
    }
    internal virtual void OnParticipantStatusChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
    {
        string val_2 = 0 + participant.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
    }
    internal virtual void OnDataReceived(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant sender, byte[] data, bool isReliable)
    {
        string val_2 = 0 + sender.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
    }
    internal virtual void SendToSpecificRecipient(string recipientId, byte[] data, int offset, int length, bool isReliable)
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
    }
    internal virtual void SendToAll(byte[] data, int offset, int length, bool isReliable)
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
    }
    internal virtual System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> GetConnectedParticipants()
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>)new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>();
    }
    internal virtual GooglePlayGames.BasicApi.Multiplayer.Participant GetSelf()
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        return 0;
    }
    internal virtual GooglePlayGames.BasicApi.Multiplayer.Participant GetParticipant(string participantId)
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        return 0;
    }
    internal virtual bool IsRoomConnected()
    {
        string val_2 = 0 + this.GetType();
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        return false;
    }

}
