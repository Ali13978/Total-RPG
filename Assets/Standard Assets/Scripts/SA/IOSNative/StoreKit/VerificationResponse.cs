using UnityEngine;

namespace SA.IOSNative.StoreKit
{
    public class VerificationResponse
    {
        // Fields
        private int _Status;
        private string _Receipt;
        private string _ProductIdentifier;
        private string _OriginalJSON;
        
        // Properties
        public int Status { get; }
        public string Receipt { get; }
        public string ProductIdentifier { get; }
        public string OriginalJSON { get; }
        
        // Methods
        public VerificationResponse(string productIdentifier, string dataArray)
        {
            val_1 = new System.Object();
            typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
            System.String[] val_2 = val_1.Split(separator:  null);
            string val_4 = val_2[0];
            this._Status = System.Convert.ToInt32(value:  0);
            this._OriginalJSON = val_2[1];
            this._Receipt = val_2[2];
            this._ProductIdentifier = productIdentifier;
        }
        public int get_Status()
        {
            return (int)this._Status;
        }
        public string get_Receipt()
        {
            return (string)this._Receipt;
        }
        public string get_ProductIdentifier()
        {
            return (string)this._ProductIdentifier;
        }
        public string get_OriginalJSON()
        {
            return (string)this._OriginalJSON;
        }
    
    }

}
