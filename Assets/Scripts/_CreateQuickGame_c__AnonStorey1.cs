using UnityEngine;
private sealed class NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey1
{
    // Fields
    internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey2 <>f__ref$2;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey0 <>f__ref$0;
    
    // Methods
    public NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey1()
    {
    
    }
    internal void <>m__0()
    {
        this.<>f__ref$2.$this.mRealtimeManager.CreateRoom(config:  this.<>f__ref$0.config, helper:  this.helper, callback:  new System.Action<RealTimeRoomResponse>(object:  this.<>f__ref$2.newSession, method:  System.Void NativeRealtimeMultiplayerClient.RoomSession::HandleRoomResponse(GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse response)));
    }

}
