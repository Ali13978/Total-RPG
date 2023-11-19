using UnityEngine;
private sealed class NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey7
{
    // Fields
    internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey5 <>f__ref$5;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4 <>f__ref$4;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey6 <>f__ref$6;
    
    // Methods
    public NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4.<CreateWithInvitationScreen>c__AnonStorey7()
    {
    
    }
    internal void <>m__0()
    {
        this.<>f__ref$5.$this.mRealtimeManager.CreateRoom(config:  this.<>f__ref$6.config, helper:  this.helper, callback:  new System.Action<RealTimeRoomResponse>(object:  this.<>f__ref$4.newRoom, method:  System.Void NativeRealtimeMultiplayerClient.RoomSession::HandleRoomResponse(GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse response)));
    }

}
