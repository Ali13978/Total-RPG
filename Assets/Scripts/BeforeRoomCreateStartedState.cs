using UnityEngine;
private class NativeRealtimeMultiplayerClient.BeforeRoomCreateStartedState : NativeRealtimeMultiplayerClient.State
{
    // Fields
    private readonly GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession mContainingSession;
    
    // Methods
    internal NativeRealtimeMultiplayerClient.BeforeRoomCreateStartedState(GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession session)
    {
        this = new System.Object();
        this.mContainingSession = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
    }
    internal override void LeaveRoom()
    {
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        this.mContainingSession.mListener.RoomConnected(success:  false);
        this.mContainingSession.EnterState(handler:  new NativeRealtimeMultiplayerClient.ShutdownState(session:  this.mContainingSession), fireStateEnteredEvent:  true);
    }

}
