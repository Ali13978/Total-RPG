using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class EndpointDiscoveryListenerHelper
    {
        // Methods
        internal static extern IntPtr EndpointDiscoveryListenerHelper_Construct()
        {
            if(25808612 != 0)
            {
                    return (IntPtr);
            }
        
        }
        internal static extern void EndpointDiscoveryListenerHelper_SetOnEndpointLostCallback(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.EndpointDiscoveryListenerHelper.OnEndpointLostCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void EndpointDiscoveryListenerHelper_SetOnEndpointFoundCallback(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.EndpointDiscoveryListenerHelper.OnEndpointFoundCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void EndpointDiscoveryListenerHelper_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 == 0)
            {
                goto mem[8316253453775630192];
            }
        
        }
    
    }

}
