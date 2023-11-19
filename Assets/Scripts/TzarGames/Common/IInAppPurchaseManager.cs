using UnityEngine;

namespace TzarGames.Common
{
    public interface IInAppPurchaseManager
    {
        // Properties
        public abstract bool IsInitialized { get; }
        
        // Methods
        public abstract bool get_IsInitialized(); // 0
        public abstract void InitiatePurchase(string productId, System.Action<TzarGames.Common.IPurchaseResult> resultCallback); // 0
    
    }

}
