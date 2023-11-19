using UnityEngine;
internal class SnapshotManager.CommitResponse : BaseReferenceHolder
{
    // Methods
    internal SnapshotManager.CommitResponse(IntPtr selfPointer)
    {
    
    }
    internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus ResponseStatus()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_CommitResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal bool RequestSucceeded()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (bool)((GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_CommitResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) > 0) ? 1 : 0;
    }
    internal GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata Data()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_CommitResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) > 0)
        {
                System.Runtime.InteropServices.HandleRef val_3 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata)new GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata(selfPointer:  GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_CommitResponse_GetData(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper}));
        }
        
        System.InvalidOperationException val_6 = new System.InvalidOperationException(message:  "Request did not succeed");
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_CommitResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
    }
    internal static GooglePlayGames.Native.PInvoke.SnapshotManager.CommitResponse FromPointer(IntPtr pointer)
    {
        var val_2;
        val_2 = 0;
        if((0 & 1) != 0)
        {
                return (CommitResponse)val_2;
        }
        
        SnapshotManager.CommitResponse val_1 = null;
        val_2 = val_1;
        val_1 = new SnapshotManager.CommitResponse(selfPointer:  ???);
        return (CommitResponse)val_2;
    }

}
