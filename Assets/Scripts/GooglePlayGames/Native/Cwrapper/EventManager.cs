using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class EventManager
    {
        // Methods
        internal static extern void EventManager_FetchAll(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, GooglePlayGames.Native.Cwrapper.EventManager.FetchAllCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void EventManager_Fetch(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, string event_id, GooglePlayGames.Native.Cwrapper.EventManager.FetchCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void EventManager_Increment(System.Runtime.InteropServices.HandleRef self, string event_id, uint steps)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void EventManager_FetchAllResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus EventManager_FetchAllResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern UIntPtr EventManager_FetchAllResponse_GetData(System.Runtime.InteropServices.HandleRef self, IntPtr[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern void EventManager_FetchResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus EventManager_FetchResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern IntPtr EventManager_FetchResponse_GetData(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
    
    }

}
