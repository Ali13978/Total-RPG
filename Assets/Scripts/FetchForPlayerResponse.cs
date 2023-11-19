using UnityEngine;
internal class StatsManager.FetchForPlayerResponse : BaseReferenceHolder
{
    // Methods
    internal StatsManager.FetchForPlayerResponse(IntPtr selfPointer)
    {
    
    }
    internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus Status()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.StatsManager.StatsManager_FetchForPlayerResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
    }
    internal GooglePlayGames.Native.PInvoke.NativePlayerStats PlayerStats()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return (GooglePlayGames.Native.PInvoke.NativePlayerStats)new GooglePlayGames.Native.PInvoke.NativePlayerStats(selfPointer:  GooglePlayGames.Native.Cwrapper.StatsManager.StatsManager_FetchForPlayerResponse_GetData(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        GooglePlayGames.Native.Cwrapper.StatsManager.StatsManager_FetchForPlayerResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
    }
    internal static GooglePlayGames.Native.PInvoke.StatsManager.FetchForPlayerResponse FromPointer(IntPtr pointer)
    {
        var val_2;
        val_2 = 0;
        if((0 & 1) != 0)
        {
                return (FetchForPlayerResponse)val_2;
        }
        
        StatsManager.FetchForPlayerResponse val_1 = null;
        val_2 = val_1;
        val_1 = new StatsManager.FetchForPlayerResponse(selfPointer:  ???);
        return (FetchForPlayerResponse)val_2;
    }

}
