using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class NearbyConnectionsBuilder
    {
        // Methods
        internal static extern void NearbyConnections_Builder_SetOnInitializationFinished(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.NearbyConnectionsBuilder.OnInitializationFinishedCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern IntPtr NearbyConnections_Builder_Construct()
        {
            if(25808612 != 0)
            {
                    return (IntPtr);
            }
        
        }
        internal static extern void NearbyConnections_Builder_SetClientId(System.Runtime.InteropServices.HandleRef self, long client_id)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void NearbyConnections_Builder_SetOnLog(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.NearbyConnectionsBuilder.OnLogCallback callback, IntPtr callback_arg, GooglePlayGames.Native.Cwrapper.Types.LogLevel min_level)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void NearbyConnections_Builder_SetDefaultOnLog(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.LogLevel min_level)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern IntPtr NearbyConnections_Builder_Create(System.Runtime.InteropServices.HandleRef self, IntPtr platform)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)platform;
            }
        
        }
        internal static extern void NearbyConnections_Builder_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 == 0)
            {
                goto mem[7308900669421347442];
            }
        
        }
    
    }

}
