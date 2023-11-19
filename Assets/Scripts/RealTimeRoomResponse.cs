using UnityEngine;
internal class RealtimeManager.RealTimeRoomResponse : BaseReferenceHolder
{
    // Methods
    internal RealtimeManager.RealTimeRoomResponse(IntPtr selfPointer)
    {
    
    }
    internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus ResponseStatus()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_RealTimeRoomResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal bool RequestSucceeded()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (bool)((GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_RealTimeRoomResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) > 0) ? 1 : 0;
    }
    internal GooglePlayGames.Native.PInvoke.NativeRealTimeRoom Room()
    {
        IntPtr val_6;
        var val_7;
        val_6 = this;
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        val_7 = 0;
        if((GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_RealTimeRoomResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) < 1)
        {
                return (GooglePlayGames.Native.PInvoke.NativeRealTimeRoom)val_7;
        }
        
        System.Runtime.InteropServices.HandleRef val_3 = this.SelfPtr();
        val_6 = GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_RealTimeRoomResponse_GetRoom(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper});
        GooglePlayGames.Native.PInvoke.NativeRealTimeRoom val_5 = null;
        val_7 = val_5;
        val_5 = new GooglePlayGames.Native.PInvoke.NativeRealTimeRoom(selfPointer:  val_6);
        return (GooglePlayGames.Native.PInvoke.NativeRealTimeRoom)val_7;
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_RealTimeRoomResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
    }
    internal static GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse FromPointer(IntPtr pointer)
    {
        var val_2;
        val_2 = 0;
        if((0 & 1) != 0)
        {
                return (RealTimeRoomResponse)val_2;
        }
        
        RealtimeManager.RealTimeRoomResponse val_1 = null;
        val_2 = val_1;
        val_1 = new RealtimeManager.RealTimeRoomResponse(selfPointer:  ???);
        return (RealTimeRoomResponse)val_2;
    }

}
