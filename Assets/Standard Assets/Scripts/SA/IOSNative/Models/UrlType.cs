using UnityEngine;

namespace SA.IOSNative.Models
{
    [Serializable]
    public class UrlType
    {
        // Fields
        public string Identifier;
        public System.Collections.Generic.List<string> Schemes;
        public bool IsOpen;
        
        // Methods
        public UrlType(string identifier)
        {
            null = null;
            this.Identifier = System.String.Empty;
            this.Schemes = new System.Collections.Generic.List<System.String>();
            this.IsOpen = true;
            this.Identifier = identifier;
        }
        public void AddSchemes(string schemes)
        {
            this.Schemes.Add(item:  schemes);
        }
    
    }

}
