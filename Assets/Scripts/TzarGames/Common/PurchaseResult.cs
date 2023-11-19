using UnityEngine;

namespace TzarGames.Common
{
    internal class PurchaseResult : IPurchaseResult
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <ProductID>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <Success>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Common.PurchaseFailureReason <FailureReason>k__BackingField;
        
        // Properties
        public string ProductID { get; set; }
        public bool Success { get; set; }
        public TzarGames.Common.PurchaseFailureReason FailureReason { get; set; }
        
        // Methods
        public PurchaseResult()
        {
        
        }
        public string get_ProductID()
        {
            return (string)this.<ProductID>k__BackingField;
        }
        public void set_ProductID(string value)
        {
            this.<ProductID>k__BackingField = value;
        }
        public bool get_Success()
        {
            return (bool)this.<Success>k__BackingField;
        }
        public void set_Success(bool value)
        {
            this.<Success>k__BackingField = value;
        }
        public TzarGames.Common.PurchaseFailureReason get_FailureReason()
        {
            return (TzarGames.Common.PurchaseFailureReason)this.<FailureReason>k__BackingField;
        }
        public void set_FailureReason(TzarGames.Common.PurchaseFailureReason value)
        {
            this.<FailureReason>k__BackingField = value;
        }
    
    }

}
