using UnityEngine;

namespace SA.IOSNative.Storage
{
    public static class AppCache
    {
        // Methods
        public static void Save(string key, UnityEngine.Texture2D texture)
        {
            SA.IOSNative.Storage.AppCache.Save(key:  UnityEngine.ImageConversion.EncodeToPNG(tex:  0), data:  texture);
        }
        public static void Save(string key, byte[] data)
        {
            string val_1 = System.Convert.ToBase64String(inArray:  0);
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  data);
        }
        public static void Save(string key, string value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  value);
        }
        public static UnityEngine.Texture2D GetTexture(string key)
        {
            System.Byte[] val_1 = SA.IOSNative.Storage.AppCache.GetData(key:  694);
            UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  1, height:  1);
            bool val_3 = UnityEngine.ImageConversion.LoadImage(tex:  0, data:  val_2);
            hideFlags = 52;
            return val_2;
        }
        public static byte[] GetData(string key)
        {
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  0);
            return System.Convert.FromBase64String(s:  0);
        }
        public static string GetString(string key)
        {
            return UnityEngine.PlayerPrefs.GetString(key:  0);
        }
        public static void Remove(string key)
        {
            UnityEngine.PlayerPrefs.DeleteKey(key:  0);
        }
    
    }

}
