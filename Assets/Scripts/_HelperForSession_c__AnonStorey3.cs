using UnityEngine;
private sealed class NativeRealtimeMultiplayerClient.<HelperForSession>c__AnonStorey3
{
    // Fields
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession session;
    
    // Methods
    public NativeRealtimeMultiplayerClient.<HelperForSession>c__AnonStorey3()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant, byte[] data, bool isReliable)
    {
        isReliable = isReliable;
        this.session.OnDataReceived(room:  room, sender:  participant, data:  data, isReliable:  isReliable);
    }
    internal void <>m__1(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
    {
        this.session.OnParticipantStatusChanged(room:  room, participant:  participant);
    }
    internal void <>m__2(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
        this.session.OnConnectedSetChanged(room:  room);
    }
    internal void <>m__3(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
        this.session.OnRoomStatusChanged(room:  room);
    }

}
