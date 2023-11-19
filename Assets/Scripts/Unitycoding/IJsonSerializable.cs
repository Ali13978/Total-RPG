using UnityEngine;

namespace Unitycoding
{
    public interface IJsonSerializable
    {
        // Methods
        public abstract void GetObjectData(System.Collections.Generic.Dictionary<string, object> data); // 0
        public abstract void SetObjectData(System.Collections.Generic.Dictionary<string, object> data); // 0
    
    }

}
