using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [Serializable]
    public class SceneObject
    {
        // Fields
        public string name;
        public string prefabName;
        public string id;
        public string idParent;
        public bool active;
        public UnityEngine.Vector3 position;
        public UnityEngine.Vector3 localScale;
        public UnityEngine.Quaternion rotation;
        public System.Collections.Generic.List<UnityEngine.UI.Extensions.ObjectComponent> objectComponents;
        
        // Methods
        public SceneObject()
        {
            this.objectComponents = new System.Collections.Generic.List<UnityEngine.UI.Extensions.ObjectComponent>();
        }
    
    }

}
