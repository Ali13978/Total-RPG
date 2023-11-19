using UnityEngine;

namespace SA.Common.Util
{
    public static class Loader
    {
        // Methods
        public static void LoadWebTexture(string url, System.Action<UnityEngine.Texture2D> callback)
        {
            SA.Common.Models.WWWTextureLoader val_1 = SA.Common.Models.WWWTextureLoader.Create();
            if(val_1 != null)
            {
                    val_1.add_OnLoad(value:  X2);
            }
            else
            {
                    0.add_OnLoad(value:  X2);
            }
            
            val_1.LoadTexture(url:  callback);
        }
        public static void LoadPrefab(string localPath, System.Action<UnityEngine.GameObject> callback)
        {
            SA.Common.Models.PrefabAsyncLoader val_1 = SA.Common.Models.PrefabAsyncLoader.Create();
            if(val_1 != null)
            {
                    val_1.add_ObjectLoadedAction(value:  X2);
            }
            else
            {
                    0.add_ObjectLoadedAction(value:  X2);
            }
            
            val_1.PrefabPath = callback;
            UnityEngine.Coroutine val_3 = val_1.StartCoroutine(routine:  val_1.Load());
        }
    
    }

}
