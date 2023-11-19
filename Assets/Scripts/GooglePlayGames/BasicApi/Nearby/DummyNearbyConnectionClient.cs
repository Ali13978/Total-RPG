using UnityEngine;

namespace GooglePlayGames.BasicApi.Nearby
{
    public class DummyNearbyConnectionClient : INearbyConnectionClient
    {
        // Methods
        public DummyNearbyConnectionClient()
        {
        
        }
        public int MaxUnreliableMessagePayloadLength()
        {
            return 1168;
        }
        public int MaxReliableMessagePayloadLength()
        {
            return 4096;
        }
        public void SendReliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload)
        {
            UnityEngine.Debug.LogError(message:  0);
        }
        public void SendUnreliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload)
        {
            UnityEngine.Debug.LogError(message:  0);
        }
        public void StartAdvertising(string name, System.Collections.Generic.List<string> appIdentifiers, System.Nullable<System.TimeSpan> advertisingDuration, System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> connectionRequestCallback)
        {
            null = null;
            connectionRequestCallback.Invoke(obj:  new GooglePlayGames.BasicApi.Nearby.AdvertisingResult());
        }
        public void StopAdvertising()
        {
            UnityEngine.Debug.LogError(message:  0);
        }
        public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback, GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
        {
            var val_3;
            UnityEngine.Debug.LogError(message:  0);
            if(responseCallback == null)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            GooglePlayGames.BasicApi.Nearby.ConnectionResponse val_1 = GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Rejected(localClientId:  null, remoteEndpointId:  0);
            responseCallback.Invoke(obj:  new GooglePlayGames.BasicApi.Nearby.ConnectionResponse());
        }
        public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
        {
            UnityEngine.Debug.LogError(message:  0);
        }
        public void StartDiscovery(string serviceId, System.Nullable<System.TimeSpan> advertisingTimeout, GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener)
        {
            UnityEngine.Debug.LogError(message:  0);
        }
        public void StopDiscovery(string serviceId)
        {
            UnityEngine.Debug.LogError(message:  0);
        }
        public void RejectConnectionRequest(string requestingEndpointId)
        {
            UnityEngine.Debug.LogError(message:  0);
        }
        public void DisconnectFromEndpoint(string remoteEndpointId)
        {
            UnityEngine.Debug.LogError(message:  0);
        }
        public void StopAllConnections()
        {
            UnityEngine.Debug.LogError(message:  0);
        }
        public string LocalEndpointId()
        {
            null = null;
            return (string)System.String.Empty;
        }
        public string LocalDeviceId()
        {
            return "DummyDevice";
        }
        public string GetAppBundleId()
        {
            return "dummy.bundle.id";
        }
        public string GetServiceId()
        {
            return "dummy.service.id";
        }
    
    }

}
