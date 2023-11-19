using UnityEngine;
private class NativeRealtimeMultiplayerClient.AbortingRoomCreationState : NativeRealtimeMultiplayerClient.State
{
    // Fields
    private readonly GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession mSession;
    
    // Methods
    internal NativeRealtimeMultiplayerClient.AbortingRoomCreationState(GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession session)
    {
        this = new System.Object();
        this.mSession = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
    }
    internal override bool IsActive()
    {
        return false;
    }
    internal override void HandleRoomResponse(GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse response)
    {
        if(response.RequestSucceeded() != false)
        {
                this.mSession.EnterState(handler:  new NativeRealtimeMultiplayerClient.LeavingRoom(session:  this.mSession, room:  response.Room(), leavingCompleteCallback:  new System.Action(object:  this, method:  System.Void NativeRealtimeMultiplayerClient.AbortingRoomCreationState::<HandleRoomResponse>m__0())), fireStateEnteredEvent:  true);
            return;
        }
        
        this.mSession.EnterState(handler:  new NativeRealtimeMultiplayerClient.ShutdownState(session:  this.mSession), fireStateEnteredEvent:  true);
        this.mSession.mListener.RoomConnected(success:  false);
    }
    private void <HandleRoomResponse>m__0()
    {
        this.mSession.mListener.RoomConnected(success:  false);
    }

}
