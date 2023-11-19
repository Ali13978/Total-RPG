using UnityEngine;

namespace GooglePlayGames.BasicApi.Nearby
{
    public interface IMessageListener
    {
        // Methods
        public abstract void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage); // 0
        public abstract void OnRemoteEndpointDisconnected(string remoteEndpointId); // 0
    
    }

}
