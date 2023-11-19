using UnityEngine;

namespace GooglePlayGames.BasicApi.Nearby
{
    public struct ConnectionRequest
    {
        // Fields
        private readonly GooglePlayGames.BasicApi.Nearby.EndpointDetails mRemoteEndpoint;
        private readonly byte[] mPayload;
        
        // Properties
        public GooglePlayGames.BasicApi.Nearby.EndpointDetails RemoteEndpoint { get; }
        public byte[] Payload { get; }
        
        // Methods
        public ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload)
        {
        
        }
        public GooglePlayGames.BasicApi.Nearby.EndpointDetails get_RemoteEndpoint()
        {
            GooglePlayGames.BasicApi.Nearby.EndpointDetails val_0;
            val_0.mServiceId = null;
            val_0.mEndpointId = null;
            return val_0;
        }
        public byte[] get_Payload()
        {
            return (System.Byte[])this;
        }
    
    }

}
