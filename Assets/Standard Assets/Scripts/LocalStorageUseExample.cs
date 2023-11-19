using UnityEngine;
public class LocalStorageUseExample : MonoBehaviour
{
    // Methods
    public LocalStorageUseExample()
    {
    
    }
    private void Start()
    {
        SA.IOSNative.Storage.AppCache.Save(key:  0, value:  "TEST_KEY");
        string val_1 = SA.IOSNative.Storage.AppCache.GetString(key:  0);
        UnityEngine.Debug.Log(message:  0);
        SA.IOSNative.Storage.AppCache.Remove(key:  0);
        UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  1, height:  1);
        SA.IOSNative.Storage.AppCache.Save(key:  0, texture:  "TEST_IMAGE_KEY");
        UnityEngine.Texture2D val_3 = SA.IOSNative.Storage.AppCache.GetTexture(key:  0);
        UnityEngine.Debug.Log(message:  0);
        SA.IOSNative.Storage.AppCache.Save(key:  0, data:  "TEST_DATA_KEY");
        System.Byte[] val_4 = SA.IOSNative.Storage.AppCache.GetData(key:  0);
        UnityEngine.Debug.Log(message:  0);
    }

}
