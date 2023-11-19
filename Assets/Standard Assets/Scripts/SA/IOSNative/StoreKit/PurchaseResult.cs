using UnityEngine;

namespace SA.IOSNative.StoreKit
{
    public class PurchaseResult : Result
    {
        // Fields
        private string _ProductIdentifier;
        private SA.IOSNative.StoreKit.PurchaseState _State;
        private string _Receipt;
        private string _TransactionIdentifier;
        private string _ApplicationUsername;
        
        // Properties
        public SA.IOSNative.StoreKit.TransactionErrorCode TransactionErrorCode { get; }
        public SA.IOSNative.StoreKit.PurchaseState State { get; }
        public string ProductIdentifier { get; }
        public string ApplicationUsername { get; }
        public string Receipt { get; }
        public string TransactionIdentifier { get; }
        
        // Methods
        public PurchaseResult(string productIdentifier, SA.Common.Models.Error e)
        {
            null = null;
            this._State = 1;
            this._ProductIdentifier = System.String.Empty;
            this._Receipt = System.String.Empty;
            this._TransactionIdentifier = System.String.Empty;
            this._ApplicationUsername = System.String.Empty;
            val_1 = new System.Object();
            mem[1152921510334586784] = val_1;
            this._ProductIdentifier = productIdentifier;
            this._State = 1;
        }
        public PurchaseResult(string productIdentifier, SA.IOSNative.StoreKit.PurchaseState state, string applicationUsername = "", string receipt = "", string transactionIdentifier = "")
        {
            null = null;
            this._State = 1;
            this._ProductIdentifier = System.String.Empty;
            this._Receipt = System.String.Empty;
            this._TransactionIdentifier = System.String.Empty;
            this._ApplicationUsername = System.String.Empty;
            val_1 = new System.Object();
            this._ProductIdentifier = productIdentifier;
            this._State = state;
            this._Receipt = receipt;
            this._TransactionIdentifier = transactionIdentifier;
            this._ApplicationUsername = val_1;
        }
        public SA.IOSNative.StoreKit.TransactionErrorCode get_TransactionErrorCode()
        {
            if(X8 == 0)
            {
                    return 8;
            }
            
            return (SA.IOSNative.StoreKit.TransactionErrorCode)X8 + 16;
        }
        public SA.IOSNative.StoreKit.PurchaseState get_State()
        {
            return (SA.IOSNative.StoreKit.PurchaseState)this._State;
        }
        public string get_ProductIdentifier()
        {
            return (string)this._ProductIdentifier;
        }
        public string get_ApplicationUsername()
        {
            return (string)this._ApplicationUsername;
        }
        public string get_Receipt()
        {
            return (string)this._Receipt;
        }
        public string get_TransactionIdentifier()
        {
            return (string)this._TransactionIdentifier;
        }
    
    }

}
