using UnityEngine;

namespace TzarGames
{
    public class SaveManager
    {
        // Fields
        public static string defaultSaveFileName;
        public static byte[] cachedData;
        private static string stringCK;
        
        // Properties
        public static string CryptKey { get; set; }
        
        // Methods
        public SaveManager()
        {
        
        }
        public static string get_CryptKey()
        {
            null = null;
            return (string)TzarGames.SaveManager.stringCK;
        }
        public static void set_CryptKey(string value)
        {
            null = null;
            TzarGames.SaveManager.stringCK = X1;
        }
        public static void SaveBinaryData(byte[] bytes)
        {
            string val_1 = TzarGames.SaveManager.GetLocalSavePathToDefaultFile();
            TzarGames.SaveManager.saveDataToPath(path:  val_1, data:  val_1);
        }
        public static byte[] GetBinaryData()
        {
            var val_5;
            var val_6;
            System.IO.FileStream val_2 = new System.IO.FileStream(path:  TzarGames.SaveManager.GetLocalSavePathToDefaultFile(), mode:  4);
            if(null == 0)
            {
                goto label_3;
            }
            
            System.IO.BinaryReader val_3 = new System.IO.BinaryReader(input:  null);
            if(null == 0)
            {
                goto label_4;
            }
            
            val_5 = null;
            val_6 = null;
            return (System.Byte[])val_6;
            label_3:
            val_5 = 0 + "Failed to create file stream from file ";
            UnityEngine.Debug.LogWarning(message:  0);
            goto label_10;
            label_4:
            val_5 = "Failed to create binary reader";
            UnityEngine.Debug.LogWarning(message:  0);
            label_10:
            val_6 = 0;
            return (System.Byte[])val_6;
        }
        public static void SaveDataToCache(string data)
        {
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            string val_3 = TzarGames.SaveManager.GetDecryptedString(encrypted:  null);
            TzarGames.SaveManager.cachedData = TzarGames.Common.Utils.GetBytesFromString(str:  0);
        }
        public static string LoadDataFromCache()
        {
            null = null;
            if(TzarGames.SaveManager.cachedData == null)
            {
                    return 0;
            }
            
            return TzarGames.SaveManager.GetDecryptedString(encrypted:  TzarGames.Common.Utils.GetStringFromBytes(bytes:  0));
        }
        public static void SaveDataToLocalStorage(string data, out byte[] bytes)
        {
            string val_1 = TzarGames.SaveManager.GetLocalSavePathToDefaultFile();
            TzarGames.SaveManager.SaveDataToPath(data:  val_1, path:  bytes, bytes: out  val_1);
        }
        public static void SaveDataToPath(string data, string path, out byte[] bytes)
        {
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    mem2[0] = 0;
                return;
            }
            
            string val_3 = TzarGames.SaveManager.GetEncryptedString(original:  null);
            System.Byte[] val_4 = TzarGames.Common.Utils.GetBytesFromString(str:  0);
            mem2[0] = val_4;
            TzarGames.SaveManager.saveDataToPath(path:  val_4, data:  bytes);
        }
        public static string BackupStringDataToLocalStorage(string data, string filePrefix, bool withDate)
        {
            var val_7;
            System.Byte[] val_8;
            val_7 = filePrefix;
            val_8 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return (string)val_8;
            }
            
            string val_3 = TzarGames.SaveManager.GetEncryptedString(original:  null);
            System.Byte[] val_4 = TzarGames.Common.Utils.GetBytesFromString(str:  0);
            var val_5 = W3 & 1;
            val_7 = val_4;
            string val_6 = TzarGames.SaveManager.GenerateFileNameForBackupFile(filePrefix:  val_4, withDate:  withDate);
            val_8 = val_6;
            TzarGames.SaveManager.saveDataToPath(path:  val_6, data:  val_8);
            return (string)val_8;
        }
        public static string[] GetAllFilePathsWithPrefix(string prefix)
        {
            var val_6;
            string val_1 = UnityEngine.Application.persistentDataPath;
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
            val_6 = 0;
            goto label_3;
            label_12:
            val_6 = 1;
            label_3:
            if(val_6 >= val_2.Length)
            {
                goto label_5;
            }
            
            if((System.IO.Path.GetFileName(path:  0).StartsWith(value:  X1)) == false)
            {
                goto label_12;
            }
            
            Add(item:  System.IO.Directory.GetFiles(path:  0)[1]);
            goto label_12;
            label_5:
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        public static string GetDecryptedString(string encrypted)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString.SetNewCryptoKey(newKey:  0);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  0);
            if(val_1 != null)
            {
                    val_1.SetEncrypted(encrypted:  X1);
                return val_1.GetDecrypted();
            }
            
            0.SetEncrypted(encrypted:  X1);
            return val_1.GetDecrypted();
        }
        public static string GetEncryptedString(string original)
        {
            null = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString.SetNewCryptoKey(newKey:  0);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredString val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  0);
            if(val_1 != null)
            {
                    return val_1.GetEncrypted();
            }
            
            return val_1.GetEncrypted();
        }
        private static void saveDataToPath(string path, byte[] data)
        {
            System.IO.FileStream val_1 = new System.IO.FileStream(path:  data, mode:  4);
            if(X2 == 0)
            {
                
            }
        
        }
        public static string LoadDataFromLocalStorageAsString()
        {
            return TzarGames.SaveManager.LoadFromMemoryAsString(data:  TzarGames.SaveManager.GetBinaryData());
        }
        public static string LoadFromMemoryAsString(byte[] data)
        {
            string val_1 = TzarGames.Common.Utils.GetStringFromBytes(bytes:  0);
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                    return TzarGames.SaveManager.GetDecryptedString(encrypted:  null);
            }
            
            return 0;
        }
        public static string GetLocalSavePath()
        {
            return UnityEngine.Application.persistentDataPath;
        }
        public static string GetLocalSavePathToDefaultFile()
        {
            return 0 + UnityEngine.Application.persistentDataPath + "/"("/");
        }
        public static string GenerateFileNameForBackupFile(string filePrefix, bool withDate)
        {
            var val_7 = W2;
            object val_1 = (val_7 != 1) ? "{0}-{1:yyyy-MM-dd_hh-mm-ss-tt}.bin" : "{0}.bin";
            if((val_7 & 1) != 0)
            {
                    System.DateTime val_2 = System.DateTime.Now;
                val_7 = val_2;
                string val_3 = System.String.Format(format:  0, arg0:  val_1, arg1:  withDate);
                return (string)0 + UnityEngine.Application.persistentDataPath + "/"("/");
            }
            
            string val_4 = System.String.Format(format:  0, arg0:  val_1);
            return (string)0 + UnityEngine.Application.persistentDataPath + "/"("/");
        }
        public static void DeleteUserDataFromLocalStorage()
        {
            string val_1 = TzarGames.SaveManager.GetLocalSavePathToDefaultFile();
            System.IO.File.Delete(path:  0);
        }
        private static SaveManager()
        {
            TzarGames.SaveManager.defaultSaveFileName = "save1.bin";
            TzarGames.SaveManager.stringCK = "1234";
        }
    
    }

}
