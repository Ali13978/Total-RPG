using UnityEngine;

namespace SA.Common.Models
{
    public class Error
    {
        // Fields
        private int _Code;
        private string _Messgae;
        
        // Properties
        public int Code { get; }
        public string Message { get; }
        
        // Methods
        public Error()
        {
            null = null;
            this._Messgae = System.String.Empty;
            this._Code = 0;
            this._Messgae = "Unknown Error";
        }
        public Error(int code, string message = "")
        {
            null = null;
            this._Messgae = System.String.Empty;
            val_1 = new System.Object();
            this._Messgae = val_1;
            this._Code = code;
        }
        public Error(string errorData)
        {
            null = null;
            this._Messgae = System.String.Empty;
            typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
            System.String[] val_1 = errorData.Split(separator:  null);
            string val_3 = val_1[0];
            this._Code = System.Convert.ToInt32(value:  0);
            this._Messgae = val_1[1];
        }
        public int get_Code()
        {
            return (int)this._Code;
        }
        public string get_Message()
        {
            return (string)this._Messgae;
        }
    
    }

}
