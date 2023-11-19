using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class PlayerManager
    {
        // Methods
        internal static extern void PlayerManager_FetchInvitable(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, GooglePlayGames.Native.Cwrapper.PlayerManager.FetchListCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void PlayerManager_FetchConnected(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, GooglePlayGames.Native.Cwrapper.PlayerManager.FetchListCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void PlayerManager_Fetch(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, string player_id, GooglePlayGames.Native.Cwrapper.PlayerManager.FetchCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void PlayerManager_FetchRecentlyPlayed(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, GooglePlayGames.Native.Cwrapper.PlayerManager.FetchListCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void PlayerManager_FetchSelf(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, GooglePlayGames.Native.Cwrapper.PlayerManager.FetchSelfCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void PlayerManager_FetchSelfResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus PlayerManager_FetchSelfResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern IntPtr PlayerManager_FetchSelfResponse_GetData(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void PlayerManager_FetchResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus PlayerManager_FetchResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern IntPtr PlayerManager_FetchResponse_GetData(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void PlayerManager_FetchListResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus PlayerManager_FetchListResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern UIntPtr PlayerManager_FetchListResponse_GetData_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr PlayerManager_FetchListResponse_GetData_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
    
    }

}
