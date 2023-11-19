using UnityEngine;
internal class PlayerManager.FetchListResponse : BaseReferenceHolder, IEnumerable<GooglePlayGames.Native.PInvoke.NativePlayer>, IEnumerable
{
    // Methods
    internal PlayerManager.FetchListResponse(IntPtr selfPointer)
    {
    
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus Status()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    public System.Collections.Generic.IEnumerator<GooglePlayGames.Native.PInvoke.NativePlayer> GetEnumerator()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.NativePlayer> val_3 = new System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.NativePlayer>(object:  this, method:  GooglePlayGames.Native.PInvoke.NativePlayer PlayerManager.FetchListResponse::<GetEnumerator>m__0(UIntPtr index));
        return GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToEnumerator<System.String>(size:  0, getElement:  GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetData_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
    internal UIntPtr Length()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetData_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal GooglePlayGames.Native.PInvoke.NativePlayer GetElement(UIntPtr index)
    {
        System.Runtime.InteropServices.HandleRef val_2 = this.SelfPtr();
        if(index.ToUInt64() < (GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetData_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}).ToUInt64()))
        {
                System.Runtime.InteropServices.HandleRef val_5 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.NativePlayer)new GooglePlayGames.Native.PInvoke.NativePlayer(selfPointer:  GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetData_GetElement(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_5.wrapper}, index:  val_5.handle));
        }
        
        System.ArgumentOutOfRangeException val_8 = new System.ArgumentOutOfRangeException();
    }
    internal static GooglePlayGames.Native.PInvoke.PlayerManager.FetchListResponse FromPointer(IntPtr selfPointer)
    {
        var val_4;
        if((GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(pointer:  null)) != false)
        {
                val_4 = 0;
            return (FetchListResponse)val_4;
        }
        
        PlayerManager.FetchListResponse val_3 = null;
        val_4 = val_3;
        val_3 = new PlayerManager.FetchListResponse(selfPointer:  X1);
        return (FetchListResponse)val_4;
    }
    private GooglePlayGames.Native.PInvoke.NativePlayer <GetEnumerator>m__0(UIntPtr index)
    {
        return this.GetElement(index:  index);
    }

}
