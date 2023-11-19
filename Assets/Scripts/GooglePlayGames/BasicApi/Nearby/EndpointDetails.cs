using UnityEngine;

namespace GooglePlayGames.BasicApi.Nearby
{
    public struct EndpointDetails
    {
        // Fields
        private readonly string mEndpointId;
        private readonly string mName;
        private readonly string mServiceId;
        
        // Properties
        public string EndpointId { get; }
        public string Name { get; }
        public string ServiceId { get; }
        
        // Methods
        public EndpointDetails(string endpointId, string name, string serviceId)
        {
        
        }
        public string get_EndpointId()
        {
            return (string)this.mServiceId;
        }
        public string get_Name()
        {
            return (string)this;
        }
        public string get_ServiceId()
        {
            return (string)this;
        }
    
    }

}
