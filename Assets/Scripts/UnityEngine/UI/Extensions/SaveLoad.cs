using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public static class SaveLoad
    {
        // Fields
        public static string saveGamePath;
        
        // Methods
        public static void Save(UnityEngine.UI.Extensions.SaveGame saveGame)
        {
            UnityEngine.UI.Extensions.SaveLoad.AddSurrogates(ss: ref  null);
            SurrogateSelector = new System.Runtime.Serialization.SurrogateSelector();
            UnityEngine.UI.Extensions.SaveLoad.CheckPath(path:  new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter());
            string val_4 = 0 + UnityEngine.UI.Extensions.SaveLoad.saveGamePath + X1 + 16(X1 + 16);
            Serialize(serializationStream:  System.IO.File.Create(path:  0), graph:  X1);
            string val_6 = 0 + "Saved Game: "("Saved Game: ");
            UnityEngine.Debug.Log(message:  0);
        }
        public static UnityEngine.UI.Extensions.SaveGame Load(string gameToLoad)
        {
            var val_13;
            System.IO.Stream val_14;
            var val_15;
            var val_16;
            val_13 = null;
            val_13 = null;
            string val_1 = 0 + UnityEngine.UI.Extensions.SaveLoad.saveGamePath + X1;
            if((System.IO.File.Exists(path:  0)) != false)
            {
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter val_3 = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                UnityEngine.UI.Extensions.SaveLoad.AddSurrogates(ss: ref  null);
                SurrogateSelector = new System.Runtime.Serialization.SurrogateSelector();
                val_14 = System.IO.File.Open(path:  0, mode:  0 + UnityEngine.UI.Extensions.SaveLoad.saveGamePath + X1);
                object val_8 = Deserialize(serializationStream:  val_14);
                val_15 = 0;
                if(val_8 != null)
            {
                    val_14 = null;
                val_15 = val_8;
                val_14 = 0;
                val_15 = 0;
            }
            
                val_16 = 0 + "Loaded Game: "("Loaded Game: ");
                UnityEngine.Debug.Log(message:  0);
                return (UnityEngine.UI.Extensions.SaveGame)val_15;
            }
            
            val_16 = 0 + X1;
            UnityEngine.Debug.Log(message:  0);
            val_15 = 0;
            return (UnityEngine.UI.Extensions.SaveGame)val_15;
        }
        private static void AddSurrogates(ref System.Runtime.Serialization.SurrogateSelector ss)
        {
            UnityEngine.UI.Extensions.Vector2Surrogate val_1 = new UnityEngine.UI.Extensions.Vector2Surrogate();
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.UI.Extensions.Vector3Surrogate val_3 = new UnityEngine.UI.Extensions.Vector3Surrogate();
            System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.UI.Extensions.Vector4Surrogate val_5 = new UnityEngine.UI.Extensions.Vector4Surrogate();
            System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            object val_7 = new System.Object();
            System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            object val_9 = new System.Object();
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(X1 != 0)
            {
                    return;
            }
        
        }
        private static void CheckPath(string path)
        {
            if((System.IO.Directory.Exists(path:  0)) == true)
            {
                    return;
            }
            
            System.IO.DirectoryInfo val_3 = System.IO.Directory.CreateDirectory(path:  0);
            X1 = 0 + "The directory was created successfully at ";
            UnityEngine.Debug.Log(message:  0);
        }
        private static SaveLoad()
        {
            UnityEngine.UI.Extensions.SaveLoad.saveGamePath = 0 + UnityEngine.Application.persistentDataPath;
        }
    
    }

}
