using UnityEngine;

namespace SA.IOSNative.Models
{
    public class UniversalLink
    {
        // Fields
        private System.Uri _URI;
        private string _AbsoluteUrl;
        
        // Properties
        public bool IsEmpty { get; }
        public System.Uri URI { get; }
        public string Host { get; }
        public string AbsoluteUrl { get; }
        
        // Methods
        public UniversalLink(string absoluteUrl)
        {
            System.Uri val_3;
            var val_4;
            val_3 = 1152921504608284672;
            val_4 = null;
            val_4 = null;
            this._AbsoluteUrl = System.String.Empty;
            this._AbsoluteUrl = absoluteUrl;
            if(absoluteUrl.Length < 1)
            {
                    return;
            }
            
            System.Uri val_2 = null;
            val_3 = val_2;
            val_2 = new System.Uri(uriString:  this._AbsoluteUrl);
            this._URI = val_3;
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
    
    }

}
