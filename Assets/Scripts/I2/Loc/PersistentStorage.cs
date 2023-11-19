using UnityEngine;

namespace I2.Loc
{
    public static class PersistentStorage
    {
        // Fields
        private static I2.Loc.I2CustomPersistentStorage mStorage;
        
        // Methods
        public static void SetSetting_String(string key, string value)
        {
            I2.Loc.I2CustomPersistentStorage val_2;
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 != null)
            {
                goto label_1;
            }
            
            object val_1 = null;
            val_2 = val_1;
            val_1 = new System.Object();
            I2.Loc.PersistentStorage.mStorage = val_2;
            val_3 = I2.Loc.PersistentStorage.mStorage;
            if(null == 0)
            {
                goto label_2;
            }
            
            label_1:
            SetSetting_String(key:  value, value:  X2);
            return;
            label_2:
        }
        public static string GetSetting_String(string key, string defaultValue)
        {
            I2.Loc.I2CustomPersistentStorage val_2;
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 != null)
            {
                    return GetSetting_String(key:  defaultValue, defaultValue:  X2);
            }
            
            object val_1 = null;
            val_2 = val_1;
            val_1 = new System.Object();
            I2.Loc.PersistentStorage.mStorage = val_2;
            val_3 = I2.Loc.PersistentStorage.mStorage;
            if(null != 0)
            {
                    return GetSetting_String(key:  defaultValue, defaultValue:  X2);
            }
        
        }
        public static void DeleteSetting(string key)
        {
            I2.Loc.I2CustomPersistentStorage val_2 = I2.Loc.PersistentStorage.mStorage;
            if(val_2 != null)
            {
                goto label_1;
            }
            
            I2.Loc.PersistentStorage.mStorage = new System.Object();
            val_2 = I2.Loc.PersistentStorage.mStorage;
            if(null == 0)
            {
                goto label_2;
            }
            
            label_1:
            DeleteSetting(key:  X1);
            return;
            label_2:
        }
        public static bool HasSetting(string key)
        {
            I2.Loc.I2CustomPersistentStorage val_2 = I2.Loc.PersistentStorage.mStorage;
            if(val_2 != null)
            {
                    return HasSetting(key:  X1);
            }
            
            I2.Loc.PersistentStorage.mStorage = new System.Object();
            val_2 = I2.Loc.PersistentStorage.mStorage;
            if(null != 0)
            {
                    return HasSetting(key:  X1);
            }
        
        }
        public static void ForceSaveSettings()
        {
            I2.Loc.I2CustomPersistentStorage val_2;
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 != null)
            {
                goto label_1;
            }
            
            object val_1 = null;
            val_2 = val_1;
            val_1 = new System.Object();
            I2.Loc.PersistentStorage.mStorage = val_2;
            val_3 = I2.Loc.PersistentStorage.mStorage;
            if(null == 0)
            {
                goto label_2;
            }
            
            label_1:
            ForceSaveSettings();
            return;
            label_2:
        }
        public static bool CanAccessFiles()
        {
            I2.Loc.I2CustomPersistentStorage val_2;
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 != null)
            {
                    return CanAccessFiles();
            }
            
            object val_1 = null;
            val_2 = val_1;
            val_1 = new System.Object();
            I2.Loc.PersistentStorage.mStorage = val_2;
            val_3 = I2.Loc.PersistentStorage.mStorage;
            if(null != 0)
            {
                    return CanAccessFiles();
            }
        
        }
        public static bool SaveFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = True)
        {
            I2.Loc.I2CustomPersistentStorage val_3;
            I2.Loc.I2CustomPersistentStorage val_4 = I2.Loc.PersistentStorage.mStorage;
            if(val_4 != null)
            {
                    return SaveFile(fileType:  fileName, fileName:  data, data:  logExceptions, logExceptions:  W4 & 1);
            }
            
            object val_1 = null;
            val_3 = val_1;
            val_1 = new System.Object();
            I2.Loc.PersistentStorage.mStorage = val_3;
            val_4 = I2.Loc.PersistentStorage.mStorage;
            if(null != 0)
            {
                    return SaveFile(fileType:  fileName, fileName:  data, data:  logExceptions, logExceptions:  W4 & 1);
            }
        
        }
        public static string LoadFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 != null)
            {
                    return LoadFile(fileType:  fileName, fileName:  logExceptions, logExceptions:  W3 & 1);
            }
            
            I2.Loc.PersistentStorage.mStorage = new System.Object();
            val_3 = I2.Loc.PersistentStorage.mStorage;
            if(null != 0)
            {
                    return LoadFile(fileType:  fileName, fileName:  logExceptions, logExceptions:  W3 & 1);
            }
        
        }
        public static bool DeleteFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 != null)
            {
                    return DeleteFile(fileType:  fileName, fileName:  logExceptions, logExceptions:  W3 & 1);
            }
            
            I2.Loc.PersistentStorage.mStorage = new System.Object();
            val_3 = I2.Loc.PersistentStorage.mStorage;
            if(null != 0)
            {
                    return DeleteFile(fileType:  fileName, fileName:  logExceptions, logExceptions:  W3 & 1);
            }
        
        }
        public static bool HasFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            I2.Loc.I2CustomPersistentStorage val_3 = I2.Loc.PersistentStorage.mStorage;
            if(val_3 != null)
            {
                    return HasFile(fileType:  fileName, fileName:  logExceptions, logExceptions:  W3 & 1);
            }
            
            I2.Loc.PersistentStorage.mStorage = new System.Object();
            val_3 = I2.Loc.PersistentStorage.mStorage;
            if(null != 0)
            {
                    return HasFile(fileType:  fileName, fileName:  logExceptions, logExceptions:  W3 & 1);
            }
        
        }
    
    }

}
