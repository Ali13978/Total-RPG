using UnityEngine;
internal class TurnBasedManager.TurnBasedMatchResponse : BaseReferenceHolder
{
    // Methods
    internal TurnBasedManager.TurnBasedMatchResponse(IntPtr selfPointer)
    {
    
    }
    internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus ResponseStatus()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal bool RequestSucceeded()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (bool)((GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) > 0) ? 1 : 0;
    }
    internal GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch Match()
    {
        IntPtr val_6;
        var val_7;
        val_6 = this;
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        val_7 = 0;
        if((GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) < 1)
        {
                return (GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch)val_7;
        }
        
        System.Runtime.InteropServices.HandleRef val_3 = this.SelfPtr();
        val_6 = GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchResponse_GetMatch(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper});
        GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch val_5 = null;
        val_7 = val_5;
        val_5 = new GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch(selfPointer:  val_6);
        return (GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch)val_7;
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TurnBasedMatchResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
    }
    internal static GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse FromPointer(IntPtr pointer)
    {
        var val_2;
        val_2 = 0;
        if((0 & 1) != 0)
        {
                return (TurnBasedMatchResponse)val_2;
        }
        
        TurnBasedManager.TurnBasedMatchResponse val_1 = null;
        val_2 = val_1;
        val_1 = new TurnBasedManager.TurnBasedMatchResponse(selfPointer:  ???);
        return (TurnBasedMatchResponse)val_2;
    }

}
