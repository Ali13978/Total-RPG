using UnityEngine;

namespace GooglePlayGames.BasicApi.Nearby
{
    public interface IDiscoveryListener
    {
        // Methods
        public abstract void OnEndpointFound(GooglePlayGames.BasicApi.Nearby.EndpointDetails discoveredEndpoint); // 0
        public abstract void OnEndpointLost(string lostEndpointId); // 0
    
    }

}
