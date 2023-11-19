using UnityEngine;

namespace GooglePlayGames.BasicApi.Nearby
{
    public interface INearbyConnectionClient
    {
        // Methods
        public abstract int MaxUnreliableMessagePayloadLength(); // 0
        public abstract int MaxReliableMessagePayloadLength(); // 0
        public abstract void SendReliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload); // 0
        public abstract void SendUnreliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload); // 0
        public abstract void StartAdvertising(string name, System.Collections.Generic.List<string> appIdentifiers, System.Nullable<System.TimeSpan> advertisingDuration, System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> connectionRequestCallback); // 0
        public abstract void StopAdvertising(); // 0
        public abstract void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback, GooglePlayGames.BasicApi.Nearby.IMessageListener listener); // 0
        public abstract void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, GooglePlayGames.BasicApi.Nearby.IMessageListener listener); // 0
        public abstract void StartDiscovery(string serviceId, System.Nullable<System.TimeSpan> advertisingTimeout, GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener); // 0
        public abstract void StopDiscovery(string serviceId); // 0
        public abstract void RejectConnectionRequest(string requestingEndpointId); // 0
        public abstract void DisconnectFromEndpoint(string remoteEndpointId); // 0
        public abstract void StopAllConnections(); // 0
        public abstract string GetAppBundleId(); // 0
        public abstract string GetServiceId(); // 0
    
    }

}
