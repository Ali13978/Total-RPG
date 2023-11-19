using UnityEngine;
private class NativeRealtimeMultiplayerClient.LeavingRoom : NativeRealtimeMultiplayerClient.State
{
    // Fields
    private readonly GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession mSession;
    private readonly GooglePlayGames.Native.PInvoke.NativeRealTimeRoom mRoomToLeave;
    private readonly System.Action mLeavingCompleteCallback;
    
    // Methods
    internal NativeRealtimeMultiplayerClient.LeavingRoom(GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession session, GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, System.Action leavingCompleteCallback)
    {
        val_1 = new System.Object();
        this.mSession = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        this.mRoomToLeave = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        this.mLeavingCompleteCallback = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
    }
    internal override bool IsActive()
    {
        return false;
    }
    internal override void OnStateEntered()
    {
        this.mSession.mManager.LeaveRoom(room:  this.mRoomToLeave, callback:  new System.Action<ResponseStatus>(object:  this, method:  System.Void NativeRealtimeMultiplayerClient.LeavingRoom::<OnStateEntered>m__0(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus status)));
    }
    private void <OnStateEntered>m__0(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus status)
    {
        this.mLeavingCompleteCallback.Invoke();
        this.mSession.EnterState(handler:  new NativeRealtimeMultiplayerClient.ShutdownState(session:  this.mSession), fireStateEnteredEvent:  true);
    }

}
