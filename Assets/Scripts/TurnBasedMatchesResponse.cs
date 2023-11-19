using UnityEngine;
internal class TurnBasedManager.TurnBasedMatchesResponse : BaseReferenceHolder
{
    // Methods
    internal TurnBasedManager.TurnBasedMatchesResponse(IntPtr selfPointer)
    {
    
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus Status()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> Invitations()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.MultiplayerInvitation> val_3 = new System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.MultiplayerInvitation>(object:  this, method:  GooglePlayGames.Native.PInvoke.MultiplayerInvitation TurnBasedManager.TurnBasedMatchesResponse::<Invitations>m__0(UIntPtr index));
        return GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(size:  0, getElement:  GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetInvitations_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
    }
    internal int InvitationCount()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (int)GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetInvitations_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}).Status;
    }
    internal System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> MyTurnMatches()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> val_3 = new System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(object:  this, method:  GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch TurnBasedManager.TurnBasedMatchesResponse::<MyTurnMatches>m__1(UIntPtr index));
        return GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(size:  0, getElement:  GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetMyTurnMatches_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
    }
    internal int MyTurnMatchesCount()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (int)GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetMyTurnMatches_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}).Status;
    }
    internal System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> TheirTurnMatches()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> val_3 = new System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(object:  this, method:  GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch TurnBasedManager.TurnBasedMatchesResponse::<TheirTurnMatches>m__2(UIntPtr index));
        return GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(size:  0, getElement:  GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetTheirTurnMatches_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
    }
    internal int TheirTurnMatchesCount()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (int)GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetTheirTurnMatches_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}).Status;
    }
    internal System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> CompletedMatches()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> val_3 = new System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(object:  this, method:  GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch TurnBasedManager.TurnBasedMatchesResponse::<CompletedMatches>m__3(UIntPtr index));
        return GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(size:  0, getElement:  GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetCompletedMatches_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
    }
    internal int CompletedMatchesCount()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (int)GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetCompletedMatches_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}).Status;
    }
    internal static GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchesResponse FromPointer(IntPtr pointer)
    {
        var val_4;
        if((GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(pointer:  null)) != false)
        {
                val_4 = 0;
            return (TurnBasedMatchesResponse)val_4;
        }
        
        TurnBasedManager.TurnBasedMatchesResponse val_3 = null;
        val_4 = val_3;
        val_3 = new TurnBasedManager.TurnBasedMatchesResponse(selfPointer:  X1);
        return (TurnBasedMatchesResponse)val_4;
    }
    private GooglePlayGames.Native.PInvoke.MultiplayerInvitation <Invitations>m__0(UIntPtr index)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (GooglePlayGames.Native.PInvoke.MultiplayerInvitation)new GooglePlayGames.Native.PInvoke.MultiplayerInvitation(selfPointer:  GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetInvitations_GetElement(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, index:  val_1.handle));
    }
    private GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch <MyTurnMatches>m__1(UIntPtr index)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch)new GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch(selfPointer:  GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetMyTurnMatches_GetElement(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, index:  val_1.handle));
    }
    private GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch <TheirTurnMatches>m__2(UIntPtr index)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch)new GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch(selfPointer:  GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetTheirTurnMatches_GetElement(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, index:  val_1.handle));
    }
    private GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch <CompletedMatches>m__3(UIntPtr index)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch)new GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch(selfPointer:  GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetCompletedMatches_GetElement(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, index:  val_1.handle));
    }

}
