using UnityEngine;

namespace SA.IOSNative.Models
{
    public class LaunchUrl
    {
        // Fields
        private System.Uri _URI;
        private string _AbsoluteUrl;
        private string _SourceApplication;
        
        // Properties
        public bool IsEmpty { get; }
        public System.Uri URI { get; }
        public string Host { get; }
        public string AbsoluteUrl { get; }
        public string SourceApplication { get; }
        
        // Methods
        public LaunchUrl(string data)
        {
            var val_4;
            string val_5;
            val_4 = null;
            val_4 = null;
            this._AbsoluteUrl = System.String.Empty;
            this._SourceApplication = System.String.Empty;
            typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
            System.String[] val_1 = data.Split(separator:  null);
            val_5 = val_1[0];
            this._AbsoluteUrl = val_5;
            if(val_1.Length <= 1)
            {
                    val_5 = this._AbsoluteUrl;
            }
            
            this._SourceApplication = val_1[1];
            if(val_5.Length < 1)
            {
                    return;
            }
            
            System.Uri val_3 = null;
            val_5 = val_3;
            val_3 = new System.Uri(uriString:  this._AbsoluteUrl);
            this._URI = val_5;
        }
        public LaunchUrl(string absoluteUrl, string sourceApplication)
        {
            string val_4;
            var val_5;
            val_4 = val_1;
            val_5 = null;
            val_5 = null;
            this._AbsoluteUrl = System.String.Empty;
            this._SourceApplication = System.String.Empty;
            val_1 = new System.Object();
            this._AbsoluteUrl = absoluteUrl;
            this._SourceApplication = val_4;
            if(absoluteUrl.Length < 1)
            {
                    return;
            }
            
            System.Uri val_3 = null;
            val_4 = val_3;
            val_3 = new System.Uri(uriString:  this._AbsoluteUrl);
            this._URI = val_4;
        }
        public bool get_IsEmpty()
        {
            null = null;
            if(this._AbsoluteUrl != null)
            {
                    return this._AbsoluteUrl.Equals(value:  System.String.Empty);
            }
            
            return this._AbsoluteUrl.Equals(value:  System.String.Empty);
        }
        public System.Uri get_URI()
        {
            return (System.Uri)this._URI;
        }
        public string get_Host()
        {
            if(this._URI != null)
            {
                    return this._URI.Host;
            }
            
            return this._URI.Host;
        }
        public string get_AbsoluteUrl()
        {
            return (string)this._AbsoluteUrl;
        }
        public string get_SourceApplication()
        {
            return (string)this._SourceApplication;
        }
    
    }

}
