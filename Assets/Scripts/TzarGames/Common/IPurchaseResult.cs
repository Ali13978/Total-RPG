using UnityEngine;

namespace TzarGames.Common
{
    public interface IPurchaseResult
    {
        // Properties
        public abstract string ProductID { get; }
        public abstract bool Success { get; }
        public abstract TzarGames.Common.PurchaseFailureReason FailureReason { get; }
        
        // Methods
        public abstract string get_ProductID(); // 0
        public abstract bool get_Success(); // 0
        public abstract TzarGames.Common.PurchaseFailureReason get_FailureReason(); // 0
    
    }

}
