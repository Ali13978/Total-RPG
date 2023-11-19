using UnityEngine;

namespace GooglePlayGames.BasicApi.Nearby
{
    public struct NearbyConnectionConfiguration
    {
        // Fields
        public const int MaxUnreliableMessagePayloadLength = 1168;
        public const int MaxReliableMessagePayloadLength = 4096;
        private readonly System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> mInitializationCallback;
        private readonly long mLocalClientId;
        
        // Properties
        public long LocalClientId { get; }
        public System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> InitializationCallback { get; }
        
        // Methods
        public NearbyConnectionConfiguration(System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> callback, long localClientId)
        {
        
        }
        public long get_LocalClientId()
        {
            return (long)this;
        }
        public System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> get_InitializationCallback()
        {
            return (System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus>)this;
        }
    
    }

}
