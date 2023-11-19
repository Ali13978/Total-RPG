using UnityEngine;

namespace TzarGames
{
    public class HttpForm
    {
        // Fields
        private TzarGames.HttpRestMethods _method;
        private System.Collections.Generic.Dictionary<TzarGames.Parameter, string> _parameters;
        private System.Collections.Generic.Dictionary<string, string> _headers;
        private byte[] _binaryData;
        private string mimeType;
        private string binaryFileName;
        
        // Properties
        public TzarGames.HttpRestMethods Method { get; set; }
        public string BinaryFileName { get; set; }
        public string MimeType { get; set; }
        public byte[] Data { get; }
        public System.Collections.Generic.Dictionary<string, string> Headers { get; }
        public System.Collections.Generic.Dictionary<TzarGames.Parameter, string> Parameters { get; }
        
        // Methods
        public HttpForm()
        {
            this._parameters = new System.Collections.Generic.Dictionary<TzarGames.Parameter, System.String>();
            this._headers = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this.mimeType = "application/json";
            this.binaryFileName = "bin";
        }
        public TzarGames.HttpRestMethods get_Method()
        {
            return (TzarGames.HttpRestMethods)this._method;
        }
        public void set_Method(TzarGames.HttpRestMethods value)
        {
            this._method = value;
            this.checkMethod();
        }
        public string get_BinaryFileName()
        {
            return (string)this.binaryFileName;
        }
        public void set_BinaryFileName(string value)
        {
            this.binaryFileName = value;
        }
        public string get_MimeType()
        {
            return (string)this.mimeType;
        }
        public void set_MimeType(string value)
        {
            this.mimeType = value;
        }
        public byte[] get_Data()
        {
            return (System.Byte[])this._binaryData;
        }
        public System.Collections.Generic.Dictionary<string, string> get_Headers()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)this._headers;
        }
        public System.Collections.Generic.Dictionary<TzarGames.Parameter, string> get_Parameters()
        {
            return (System.Collections.Generic.Dictionary<TzarGames.Parameter, System.String>)this._parameters;
        }
        public void AddBinaryData(byte[] data)
        {
            this._binaryData = data;
            if(this._method == 0)
            {
                    this._method = 1;
            }
            
            this.checkMethod();
        }
        public void AddParameter(string fieldName, int val)
        {
            if(null != 0)
            {
                    typeof(TzarGames.IntParameter).__il2cppRuntimeField_10 = fieldName;
            }
            else
            {
                    mem[16] = fieldName;
            }
            
            typeof(TzarGames.IntParameter).__il2cppRuntimeField_18 = val;
            this._parameters.set_Item(key:  new System.Object(), value:  "int");
            this.checkMethod();
        }
        public void AddParameter(string fieldName, string val)
        {
            this.AddParameter(fieldName:  fieldName, val:  val, encoding:  new System.Text.ASCIIEncoding());
            this.checkMethod();
        }
        public void AddParameter(string fieldName, string val, System.Text.Encoding encoding)
        {
            if(null != 0)
            {
                    typeof(TzarGames.StringParameter).__il2cppRuntimeField_10 = fieldName;
                typeof(TzarGames.StringParameter).__il2cppRuntimeField_18 = val;
            }
            else
            {
                    mem[16] = fieldName;
                mem[24] = val;
            }
            
            typeof(TzarGames.StringParameter).__il2cppRuntimeField_20 = encoding;
            this._parameters.set_Item(key:  new System.Object(), value:  "string");
            this.checkMethod();
        }
        private void checkMethod()
        {
            if(this._parameters != null)
            {
                    if(this._parameters.Count > 0)
            {
                goto label_3;
            }
            
            }
            
            if(this._binaryData == null)
            {
                    if((this._headers == null) || (this._headers.Count < 1))
            {
                goto label_5;
            }
            
            }
            
            label_3:
            if(this._method != 0)
            {
                    return;
            }
            
            this._method = 1;
            return;
            label_5:
            if(this._method == 0)
            {
                    return;
            }
            
            this._method = 0;
        }
    
    }

}
