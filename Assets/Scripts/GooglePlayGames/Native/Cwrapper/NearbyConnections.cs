using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class NearbyConnections
    {
        // Methods
        internal static extern void NearbyConnections_StartDiscovery(System.Runtime.InteropServices.HandleRef self, string service_id, long duration, IntPtr helper)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void NearbyConnections_RejectConnectionRequest(System.Runtime.InteropServices.HandleRef self, string remote_endpoint_id)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void NearbyConnections_Disconnect(System.Runtime.InteropServices.HandleRef self, string remote_endpoint_id)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void NearbyConnections_SendUnreliableMessage(System.Runtime.InteropServices.HandleRef self, string remote_endpoint_id, byte[] payload, UIntPtr payload_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (payload_size == 0) ? 0 : (payload_size + 32);
                return;
            }
        
        }
        internal static extern void NearbyConnections_StopAdvertising(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void NearbyConnections_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void NearbyConnections_SendReliableMessage(System.Runtime.InteropServices.HandleRef self, string remote_endpoint_id, byte[] payload, UIntPtr payload_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (payload_size == 0) ? 0 : (payload_size + 32);
                return;
            }
        
        }
        internal static extern void NearbyConnections_StopDiscovery(System.Runtime.InteropServices.HandleRef self, string service_id)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void NearbyConnections_SendConnectionRequest(System.Runtime.InteropServices.HandleRef self, string name, string remote_endpoint_id, byte[] payload, UIntPtr payload_size, GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionResponseCallback callback, IntPtr callback_arg, IntPtr helper)
        {
            UIntPtr val_3 = payload_size;
            if(25808612 != 0)
            {
                    val_3 = (val_3 == 0) ? 0 : (val_3 + 32);
                return;
            }
        
        }
        internal static extern void NearbyConnections_StartAdvertising(System.Runtime.InteropServices.HandleRef self, string name, IntPtr[] app_identifiers, UIntPtr app_identifiers_size, long duration, GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.StartAdvertisingCallback start_advertising_callback, IntPtr start_advertising_callback_arg, GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionRequestCallback request_callback, IntPtr request_callback_arg)
        {
            UIntPtr val_3 = app_identifiers_size;
            if(25808612 != 0)
            {
                    val_3 = (val_3 == 0) ? 0 : (val_3 + 32);
                return;
            }
        
        }
        internal static extern void NearbyConnections_Stop(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void NearbyConnections_AcceptConnectionRequest(System.Runtime.InteropServices.HandleRef self, string remote_endpoint_id, byte[] payload, UIntPtr payload_size, IntPtr helper)
        {
            if(25808612 != 0)
            {
                    var val_2 = (payload_size == 0) ? 0 : (payload_size + 32);
                return;
            }
        
        }
    
    }

}
