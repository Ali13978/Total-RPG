using UnityEngine;

namespace Unitycoding
{
    public class HeaderLineAttribute : PropertyAttribute
    {
        // Fields
        public readonly string header;
        
        // Methods
        public HeaderLineAttribute(string header)
        {
            this.header = header;
        }
    
    }

}
