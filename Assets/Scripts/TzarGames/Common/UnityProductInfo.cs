using UnityEngine;

namespace TzarGames.Common
{
    [Serializable]
    internal class UnityProductInfo
    {
        // Fields
        public string ProductId;
        public UnityEngine.Purchasing.ProductType Type;
        public TzarGames.Common.UnityStoreId[] Identifiers;
        
        // Methods
        public UnityProductInfo()
        {
        
        }
    
    }

}
