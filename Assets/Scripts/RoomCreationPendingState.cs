using UnityEngine;
private class NativeRealtimeMultiplayerClient.RoomCreationPendingState : NativeRealtimeMultiplayerClient.State
{
    // Fields
    private readonly GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession mContainingSession;
    
    // Methods
    internal NativeRealtimeMultiplayerClient.RoomCreationPendingState(GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession session)
    {
        this = new System.Object();
        this.mContainingSession = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
    }
    internal override void HandleRoomResponse(GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse response)
    {
        if(response.RequestSucceeded() != false)
        {
                this.mContainingSession.EnterState(handler:  new NativeRealtimeMultiplayerClient.ConnectingState(room:  response.Room(), session:  this.mContainingSession), fireStateEnteredEvent:  true);
            return;
        }
        
        this.mContainingSession.EnterState(handler:  new NativeRealtimeMultiplayerClient.ShutdownState(session:  this.mContainingSession), fireStateEnteredEvent:  true);
        this.mContainingSession.mListener.RoomConnected(success:  false);
    }
    internal override bool IsActive()
    {
        return true;
    }
    internal override void LeaveRoom()
    {
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        this.mContainingSession.EnterState(handler:  new NativeRealtimeMultiplayerClient.AbortingRoomCreationState(session:  this.mContainingSession), fireStateEnteredEvent:  true);
    }

}
