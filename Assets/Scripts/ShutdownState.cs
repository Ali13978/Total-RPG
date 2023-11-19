using UnityEngine;
private class NativeRealtimeMultiplayerClient.ShutdownState : NativeRealtimeMultiplayerClient.State
{
    // Fields
    private readonly GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession mSession;
    
    // Methods
    internal NativeRealtimeMultiplayerClient.ShutdownState(GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession session)
    {
        this = new System.Object();
        this.mSession = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
    }
    internal override bool IsActive()
    {
        return false;
    }
    internal override void LeaveRoom()
    {
        this.mSession.mListener.LeftRoom();
    }

}
