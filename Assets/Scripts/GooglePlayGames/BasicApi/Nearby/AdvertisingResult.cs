using UnityEngine;

namespace GooglePlayGames.BasicApi.Nearby
{
    public struct AdvertisingResult
    {
        // Fields
        private readonly GooglePlayGames.BasicApi.ResponseStatus mStatus;
        private readonly string mLocalEndpointName;
        
        // Properties
        public bool Succeeded { get; }
        public GooglePlayGames.BasicApi.ResponseStatus Status { get; }
        public string LocalEndpointName { get; }
        
        // Methods
        public AdvertisingResult(GooglePlayGames.BasicApi.ResponseStatus status, string localEndpointName)
        {
        
        }
        public bool get_Succeeded()
        {
            return (bool)(W8 == 1) ? 1 : 0;
        }
        public GooglePlayGames.BasicApi.ResponseStatus get_Status()
        {
            return (GooglePlayGames.BasicApi.ResponseStatus)this;
        }
        public string get_LocalEndpointName()
        {
            return (string)this;
        }
    
    }

}
