using UnityEngine;
private sealed class NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyF
{
    // Fields
    internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyD <>f__ref$13;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC <>f__ref$12;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyE <>f__ref$14;
    
    // Methods
    public NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC.<AcceptInvitation>c__AnonStoreyF()
    {
    
    }
    internal void <>m__0()
    {
        this.<>f__ref$13.$this.mRealtimeManager.AcceptInvitation(invitation:  this.<>f__ref$14.invitation, listener:  this.helper, callback:  new System.Action<RealTimeRoomResponse>(object:  this.<>f__ref$12.newRoom, method:  System.Void NativeRealtimeMultiplayerClient.RoomSession::HandleRoomResponse(GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse response)));
    }

}
