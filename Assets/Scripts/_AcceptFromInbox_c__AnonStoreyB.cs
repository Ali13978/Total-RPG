using UnityEngine;
private sealed class NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyB
{
    // Fields
    internal GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9 <>f__ref$9;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyA <>f__ref$10;
    
    // Methods
    public NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyB()
    {
    
    }
    internal void <>m__0()
    {
        this.<>f__ref$9.$this.mRealtimeManager.AcceptInvitation(invitation:  this.<>f__ref$10.invitation, listener:  this.helper, callback:  new System.Action<RealTimeRoomResponse>(object:  this, method:  System.Void NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9.<AcceptFromInbox>c__AnonStoreyB::<>m__1(GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse acceptResponse)));
    }
    internal void <>m__1(GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse acceptResponse)
    {
        GooglePlayGames.Native.PInvoke.MultiplayerInvitation val_9;
        var val_10;
        var val_11;
        val_9 = this.<>f__ref$10.invitation;
        this.<>f__ref$9.newRoom.HandleRoomResponse(response:  acceptResponse);
        this.<>f__ref$9.newRoom.mInvitation = this.<>f__ref$10.invitation.AsInvitation();
        val_10 = 79;
        if(val_9 != null)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_11 = val_9;
        }
        
        if(79 == 79)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_9 = ???;
        val_10 = ???;
    }

}
