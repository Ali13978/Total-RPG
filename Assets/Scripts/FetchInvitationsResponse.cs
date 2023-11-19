using UnityEngine;
internal class RealtimeManager.FetchInvitationsResponse : BaseReferenceHolder
{
    // Methods
    internal RealtimeManager.FetchInvitationsResponse(IntPtr selfPointer)
    {
    
    }
    internal bool RequestSucceeded()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (bool)((GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_FetchInvitationsResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) > 0) ? 1 : 0;
    }
    internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus ResponseStatus()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_FetchInvitationsResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> Invitations()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.MultiplayerInvitation> val_3 = new System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.MultiplayerInvitation>(object:  this, method:  GooglePlayGames.Native.PInvoke.MultiplayerInvitation RealtimeManager.FetchInvitationsResponse::<Invitations>m__0(UIntPtr index));
        return GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(size:  0, getElement:  GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_FetchInvitationsResponse_GetInvitations_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_FetchInvitationsResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
    }
    internal static GooglePlayGames.Native.PInvoke.RealtimeManager.FetchInvitationsResponse FromPointer(IntPtr pointer)
    {
        var val_4;
        if((GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(pointer:  null)) != false)
        {
                val_4 = 0;
            return (FetchInvitationsResponse)val_4;
        }
        
        RealtimeManager.FetchInvitationsResponse val_3 = null;
        val_4 = val_3;
        val_3 = new RealtimeManager.FetchInvitationsResponse(selfPointer:  X1);
        return (FetchInvitationsResponse)val_4;
    }
    private GooglePlayGames.Native.PInvoke.MultiplayerInvitation <Invitations>m__0(UIntPtr index)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (GooglePlayGames.Native.PInvoke.MultiplayerInvitation)new GooglePlayGames.Native.PInvoke.MultiplayerInvitation(selfPointer:  GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_FetchInvitationsResponse_GetInvitations_GetElement(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, index:  val_1.handle));
    }

}
