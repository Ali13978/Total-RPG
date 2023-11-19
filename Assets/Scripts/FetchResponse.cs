using UnityEngine;
internal class PlayerManager.FetchResponse : BaseReferenceHolder
{
    // Methods
    internal PlayerManager.FetchResponse(IntPtr selfPointer)
    {
    
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal GooglePlayGames.Native.PInvoke.NativePlayer GetPlayer()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (GooglePlayGames.Native.PInvoke.NativePlayer)new GooglePlayGames.Native.PInvoke.NativePlayer(selfPointer:  GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchResponse_GetData(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
    }
    internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus Status()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal static GooglePlayGames.Native.PInvoke.PlayerManager.FetchResponse FromPointer(IntPtr selfPointer)
    {
        var val_4;
        if((GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(pointer:  null)) != false)
        {
                val_4 = 0;
            return (FetchResponse)val_4;
        }
        
        PlayerManager.FetchResponse val_3 = null;
        val_4 = val_3;
        val_3 = new PlayerManager.FetchResponse(selfPointer:  X1);
        return (FetchResponse)val_4;
    }

}
