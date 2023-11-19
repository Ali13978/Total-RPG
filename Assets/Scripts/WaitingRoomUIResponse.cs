using UnityEngine;
internal class RealtimeManager.WaitingRoomUIResponse : BaseReferenceHolder
{
    // Methods
    internal RealtimeManager.WaitingRoomUIResponse(IntPtr selfPointer)
    {
    
    }
    internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus ResponseStatus()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_WaitingRoomUIResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal GooglePlayGames.Native.PInvoke.NativeRealTimeRoom Room()
    {
        IntPtr val_6;
        var val_7;
        val_6 = this;
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        val_7 = 0;
        if((GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_WaitingRoomUIResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) != 1)
        {
                return (GooglePlayGames.Native.PInvoke.NativeRealTimeRoom)val_7;
        }
        
        System.Runtime.InteropServices.HandleRef val_3 = this.SelfPtr();
        val_6 = GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_WaitingRoomUIResponse_GetRoom(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper});
        GooglePlayGames.Native.PInvoke.NativeRealTimeRoom val_5 = null;
        val_7 = val_5;
        val_5 = new GooglePlayGames.Native.PInvoke.NativeRealTimeRoom(selfPointer:  val_6);
        return (GooglePlayGames.Native.PInvoke.NativeRealTimeRoom)val_7;
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_WaitingRoomUIResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
    }
    internal static GooglePlayGames.Native.PInvoke.RealtimeManager.WaitingRoomUIResponse FromPointer(IntPtr pointer)
    {
        var val_4;
        if((GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(pointer:  null)) != false)
        {
                val_4 = 0;
            return (WaitingRoomUIResponse)val_4;
        }
        
        RealtimeManager.WaitingRoomUIResponse val_3 = null;
        val_4 = val_3;
        val_3 = new RealtimeManager.WaitingRoomUIResponse(selfPointer:  X1);
        return (WaitingRoomUIResponse)val_4;
    }

}
