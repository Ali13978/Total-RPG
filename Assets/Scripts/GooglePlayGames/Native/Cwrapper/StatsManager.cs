using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class StatsManager
    {
        // Methods
        internal static extern void StatsManager_FetchForPlayer(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, GooglePlayGames.Native.Cwrapper.StatsManager.FetchForPlayerCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void StatsManager_FetchForPlayerResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus StatsManager_FetchForPlayerResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern IntPtr StatsManager_FetchForPlayerResponse_GetData(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
    
    }

}
