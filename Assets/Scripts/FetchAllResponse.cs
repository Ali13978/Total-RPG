using UnityEngine;
internal class SnapshotManager.FetchAllResponse : BaseReferenceHolder
{
    // Methods
    internal SnapshotManager.FetchAllResponse(IntPtr selfPointer)
    {
    
    }
    internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus ResponseStatus()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_FetchAllResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal bool RequestSucceeded()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (bool)((GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_FetchAllResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) > 0) ? 1 : 0;
    }
    internal System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata> Data()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata> val_3 = new System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata>(object:  this, method:  GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata SnapshotManager.FetchAllResponse::<Data>m__0(UIntPtr index));
        return GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(size:  0, getElement:  GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_FetchAllResponse_GetData_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_FetchAllResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
    }
    internal static GooglePlayGames.Native.PInvoke.SnapshotManager.FetchAllResponse FromPointer(IntPtr pointer)
    {
        var val_2;
        val_2 = 0;
        if((0 & 1) != 0)
        {
                return (FetchAllResponse)val_2;
        }
        
        SnapshotManager.FetchAllResponse val_1 = null;
        val_2 = val_1;
        val_1 = new SnapshotManager.FetchAllResponse(selfPointer:  ???);
        return (FetchAllResponse)val_2;
    }
    private GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata <Data>m__0(UIntPtr index)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata)new GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata(selfPointer:  GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_FetchAllResponse_GetData_GetElement(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, index:  val_1.handle));
    }

}
