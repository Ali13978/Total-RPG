using UnityEngine;
internal class SnapshotManager.ReadResponse : BaseReferenceHolder
{
    // Methods
    internal SnapshotManager.ReadResponse(IntPtr selfPointer)
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
    internal byte[] Data()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_CommitResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) > 0)
        {
                PInvokeUtilities.OutMethod<System.Byte> val_3 = new PInvokeUtilities.OutMethod<System.Byte>(object:  this, method:  System.UIntPtr SnapshotManager.ReadResponse::<Data>m__0(byte[] out_bytes, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToArray<System.Byte>(outMethod:  0);
        }
        
        System.InvalidOperationException val_4 = new System.InvalidOperationException(message:  "Request did not succeed");
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_ReadResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
    }
    internal static GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse FromPointer(IntPtr pointer)
    {
        var val_2;
        val_2 = 0;
        if((0 & 1) != 0)
        {
                return (ReadResponse)val_2;
        }
        
        SnapshotManager.ReadResponse val_1 = null;
        val_2 = val_1;
        val_1 = new SnapshotManager.ReadResponse(selfPointer:  ???);
        return (ReadResponse)val_2;
    }
    private UIntPtr <Data>m__0(byte[] out_bytes, UIntPtr out_size)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_ReadResponse_GetData(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_bytes);
    }

}
