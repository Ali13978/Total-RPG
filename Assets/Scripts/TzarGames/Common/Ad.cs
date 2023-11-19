using UnityEngine;

namespace TzarGames.Common
{
    public class Ad : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private string adId;
        
        // Properties
        public string AdId { get; }
        
        // Methods
        public Ad()
        {
        
        }
        public string get_AdId()
        {
            return (string)this.adId;
        }
    
    }

}
