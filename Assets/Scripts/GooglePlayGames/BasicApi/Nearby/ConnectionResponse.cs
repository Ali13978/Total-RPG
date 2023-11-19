using UnityEngine;

namespace GooglePlayGames.BasicApi.Nearby
{
    public struct ConnectionResponse
    {
        // Fields
        private static readonly byte[] EmptyPayload;
        private readonly long mLocalClientId;
        private readonly string mRemoteEndpointId;
        private readonly GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Status mResponseStatus;
        private readonly byte[] mPayload;
        
        // Properties
        public long LocalClientId { get; }
        public string RemoteEndpointId { get; }
        public GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Status ResponseStatus { get; }
        public byte[] Payload { get; }
        
        // Methods
        private ConnectionResponse(long localClientId, string remoteEndpointId, GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Status code, byte[] payload)
        {
        
        }
        public long get_LocalClientId()
        {
            return (long)this.mResponseStatus;
        }
        public string get_RemoteEndpointId()
        {
            return (string)this.mPayload;
        }
        public GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Status get_ResponseStatus()
        {
            return (Status)this;
        }
        public byte[] get_Payload()
        {
            return (System.Byte[])this;
        }
        public static GooglePlayGames.BasicApi.Nearby.ConnectionResponse Rejected(long localClientId, string remoteEndpointId)
        {
            var val_1 = null;
            val_0.mResponseStatus = 0;
            val_0.mPayload = 0;
            val_0.mLocalClientId = 0;
            val_0.mRemoteEndpointId = 0;
        }
        public static GooglePlayGames.BasicApi.Nearby.ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId)
        {
            var val_1 = null;
            val_0.mResponseStatus = 0;
            val_0.mPayload = 0;
            val_0.mLocalClientId = 0;
            val_0.mRemoteEndpointId = 0;
        }
        public static GooglePlayGames.BasicApi.Nearby.ConnectionResponse InternalError(long localClientId, string remoteEndpointId)
        {
            var val_1 = null;
            val_0.mResponseStatus = 0;
            val_0.mPayload = 0;
            val_0.mLocalClientId = 0;
            val_0.mRemoteEndpointId = 0;
        }
        public static GooglePlayGames.BasicApi.Nearby.ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId)
        {
            var val_1 = null;
            val_0.mResponseStatus = 0;
            val_0.mPayload = 0;
            val_0.mLocalClientId = 0;
            val_0.mRemoteEndpointId = 0;
        }
        public static GooglePlayGames.BasicApi.Nearby.ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload)
        {
            val_0.mResponseStatus = 0;
            val_0.mPayload = 0;
            val_0.mLocalClientId = 0;
            val_0.mRemoteEndpointId = 0;
        }
        public static GooglePlayGames.BasicApi.Nearby.ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId)
        {
            var val_1 = null;
            val_0.mResponseStatus = 0;
            val_0.mPayload = 0;
            val_0.mLocalClientId = 0;
            val_0.mRemoteEndpointId = 0;
        }
        private static ConnectionResponse()
        {
            GooglePlayGames.BasicApi.Nearby.ConnectionResponse.EmptyPayload = null;
        }
    
    }

}
