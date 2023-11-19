using UnityEngine;
internal class SnapshotManager.OpenResponse : BaseReferenceHolder
{
    // Methods
    internal SnapshotManager.OpenResponse(IntPtr selfPointer)
    {
    
    }
    internal bool RequestSucceeded()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (bool)((GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) > 0) ? 1 : 0;
    }
    internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.SnapshotOpenStatus ResponseStatus()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal string ConflictId()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) == 3)
        {
                typeof(PInvokeUtilities.OutStringMethod).__il2cppRuntimeField_20 = this;
            typeof(PInvokeUtilities.OutStringMethod).__il2cppRuntimeField_28 = System.UIntPtr SnapshotManager.OpenResponse::<ConflictId>m__0(byte[] out_string, UIntPtr out_size);
            typeof(PInvokeUtilities.OutStringMethod).__il2cppRuntimeField_10 = System.UIntPtr SnapshotManager.OpenResponse::<ConflictId>m__0(byte[] out_string, UIntPtr out_size);
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  null);
        }
        
        System.InvalidOperationException val_3 = new System.InvalidOperationException(message:  "OpenResponse did not have a conflict");
    }
    internal GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata Data()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) == 1)
        {
                System.Runtime.InteropServices.HandleRef val_3 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata)new GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata(selfPointer:  GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetData(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper}));
        }
        
        System.InvalidOperationException val_6 = new System.InvalidOperationException(message:  "OpenResponse had a conflict");
    }
    internal GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata ConflictOriginal()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) == 3)
        {
                System.Runtime.InteropServices.HandleRef val_3 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata)new GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata(selfPointer:  GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetConflictOriginal(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper}));
        }
        
        System.InvalidOperationException val_6 = new System.InvalidOperationException(message:  "OpenResponse did not have a conflict");
    }
    internal GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata ConflictUnmerged()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) == 3)
        {
                System.Runtime.InteropServices.HandleRef val_3 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata)new GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata(selfPointer:  GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetConflictUnmerged(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper}));
        }
        
        System.InvalidOperationException val_6 = new System.InvalidOperationException(message:  "OpenResponse did not have a conflict");
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
    }
    internal static GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse FromPointer(IntPtr pointer)
    {
        var val_2;
        val_2 = 0;
        if((0 & 1) != 0)
        {
                return (OpenResponse)val_2;
        }
        
        SnapshotManager.OpenResponse val_1 = null;
        val_2 = val_1;
        val_1 = new SnapshotManager.OpenResponse(selfPointer:  ???);
        return (OpenResponse)val_2;
    }
    private UIntPtr <ConflictId>m__0(byte[] out_string, UIntPtr out_size)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetConflictId(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
    }

}
