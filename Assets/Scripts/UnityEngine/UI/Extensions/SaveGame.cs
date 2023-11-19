using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [Serializable]
    public class SaveGame
    {
        // Fields
        public string savegameName;
        public System.Collections.Generic.List<UnityEngine.UI.Extensions.SceneObject> sceneObjects;
        
        // Methods
        public SaveGame()
        {
            this.savegameName = "New SaveGame";
            this.sceneObjects = new System.Collections.Generic.List<UnityEngine.UI.Extensions.SceneObject>();
        }
        public SaveGame(string s, System.Collections.Generic.List<UnityEngine.UI.Extensions.SceneObject> list)
        {
            this.savegameName = "New SaveGame";
            this.sceneObjects = new System.Collections.Generic.List<UnityEngine.UI.Extensions.SceneObject>();
            val_2 = new System.Object();
            this.savegameName = s;
            this.sceneObjects = val_2;
        }
    
    }

}
