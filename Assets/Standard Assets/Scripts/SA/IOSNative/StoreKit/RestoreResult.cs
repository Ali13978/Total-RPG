using UnityEngine;

namespace SA.IOSNative.StoreKit
{
    public class RestoreResult : Result
    {
        // Properties
        public SA.IOSNative.StoreKit.TransactionErrorCode TransactionErrorCode { get; }
        
        // Methods
        public RestoreResult(SA.Common.Models.Error e)
        {
            val_1 = new System.Object();
            mem[1152921510335576992] = e;
        }
        public RestoreResult()
        {
            val_1 = new System.Object();
        }
        public SA.IOSNative.StoreKit.TransactionErrorCode get_TransactionErrorCode()
        {
            if(X8 == 0)
            {
                    return 8;
            }
            
            return (SA.IOSNative.StoreKit.TransactionErrorCode)X8 + 16;
        }
    
    }

}
