using UnityEngine;

namespace I2.Loc
{
    public abstract class I2BasePersistentStorage
    {
        // Methods
        protected I2BasePersistentStorage()
        {
        
        }
        public virtual void SetSetting_String(string key, string value)
        {
            string val_8;
            var val_9;
            val_8 = key;
            val_9 = value.Length;
            if(val_9 > 8000)
            {
                    float val_8 = 8000f;
                val_8 = (float)val_9 / val_8;
                int val_2 = UnityEngine.Mathf.CeilToInt(f:  val_8);
                if(val_2 >= 1)
            {
                    var val_10 = 0;
                object val_9 = 0;
                do
            {
                string val_5 = value.Substring(startIndex:  0, length:  UnityEngine.Mathf.Min(a:  0, b:  64));
                UnityEngine.PlayerPrefs.SetString(key:  0, value:  System.String.Format(format:  0, arg0:  "[I2split]{0}{1}", arg1:  val_9));
                val_9 = val_9 + 7999;
                val_9 = val_9 + 1;
                val_10 = val_10 + 8000;
            }
            while(val_9 < val_2);
            
            }
            
                string val_6 = 0 + "[$I2#@div$]";
                UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_8);
                return;
            }
            
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  val_8);
        }
        public virtual string GetSetting_String(string key, string defaultValue)
        {
            string val_12;
            var val_13;
            var val_14;
            val_12 = UnityEngine.PlayerPrefs.GetString(key:  0, defaultValue:  key);
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return (string)val_12;
            }
            
            if((val_12.StartsWith(value:  "[I2split]")) == false)
            {
                    return (string)val_12;
            }
            
            val_13 = "[I2split]";
            if("[I2split]" == null)
            {
                    val_13 = "[I2split]";
            }
            
            string val_6 = val_12.Substring(startIndex:  Length);
            int val_7 = System.Int32.Parse(s:  0);
            val_14 = null;
            val_14 = null;
            val_12 = System.String.Empty;
            if(val_7 < 1)
            {
                    return (string)val_12;
            }
            
            object val_12 = 0;
            do
            {
                string val_9 = UnityEngine.PlayerPrefs.GetString(key:  0, defaultValue:  System.String.Format(format:  0, arg0:  "[I2split]{0}{1}", arg1:  val_12));
                string val_10 = 0 + val_12;
                val_12 = val_10;
                val_12 = val_12 + 1;
            }
            while(val_12 < val_7);
            
            return (string)val_12;
        }
        public virtual void DeleteSetting(string key)
        {
            int val_9;
            var val_10;
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  0, defaultValue:  key);
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_9 = "[I2split]";
                if((val_1.StartsWith(value:  "[I2split]")) != false)
            {
                    val_10 = "[I2split]";
                if("[I2split]" == null)
            {
                    val_10 = "[I2split]";
            }
            
                val_9 = Length;
                string val_6 = val_1.Substring(startIndex:  val_9);
                int val_7 = System.Int32.Parse(s:  0);
                if(val_7 >= 1)
            {
                    object val_9 = 0;
                do
            {
                val_9 = val_9;
                string val_8 = System.String.Format(format:  0, arg0:  "[I2split]{0}{1}", arg1:  val_9);
                UnityEngine.PlayerPrefs.DeleteKey(key:  0);
                val_9 = val_9 + 1;
            }
            while(val_9 < val_7);
            
            }
            
            }
            
            }
            
            UnityEngine.PlayerPrefs.DeleteKey(key:  0);
        }
        public virtual void ForceSaveSettings()
        {
            UnityEngine.PlayerPrefs.Save();
        }
        public virtual bool HasSetting(string key)
        {
            return UnityEngine.PlayerPrefs.HasKey(key:  0);
        }
        public virtual bool CanAccessFiles()
        {
            return true;
        }
        private string UpdateFilename(I2.Loc.PersistentStorage.eFileType fileType, string fileName)
        {
            if(fileType != 3)
            {
                    if(fileType == 2)
            {
                    return 0 + UnityEngine.Application.temporaryCachePath + "/"("/");
            }
            
                if(fileType != 1)
            {
                    return (string)fileName;
            }
            
                string val_1 = UnityEngine.Application.persistentDataPath;
                return 0 + UnityEngine.Application.temporaryCachePath + "/"("/");
            }
            
            string val_2 = UnityEngine.Application.streamingAssetsPath;
            return 0 + UnityEngine.Application.temporaryCachePath + "/"("/");
        }
        public virtual bool SaveFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = True)
        {
            var val_5;
            string val_6;
            var val_7;
            val_5 = logExceptions;
            val_6 = fileName;
            if((this & 1) != 0)
            {
                    val_6 = this.UpdateFilename(fileType:  fileType, fileName:  val_6);
                System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
                System.IO.File.WriteAllText(path:  0, contents:  val_6, encoding:  data);
                val_7 = 1;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public virtual string LoadFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            var val_6;
            string val_7;
            var val_8;
            val_6 = logExceptions;
            val_7 = fileName;
            if((this & 1) != 0)
            {
                    val_7 = this.UpdateFilename(fileType:  fileType, fileName:  val_7);
                System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
                string val_3 = System.IO.File.ReadAllText(path:  0, encoding:  val_7);
                return (string)val_8;
            }
            
            val_8 = 0;
            return (string)val_8;
        }
        public virtual bool DeleteFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            string val_4;
            eFileType val_5;
            var val_6;
            val_4 = fileName;
            val_5 = fileType;
            if((this & 1) != 0)
            {
                    val_4 = this.UpdateFilename(fileType:  val_5, fileName:  val_4);
                System.IO.File.Delete(path:  0);
                val_6 = 1;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        public virtual bool HasFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            string val_5;
            eFileType val_6;
            string val_7;
            val_5 = fileName;
            val_6 = fileType;
            if((this & 1) != 0)
            {
                    val_7 = 0;
                val_5 = this.UpdateFilename(fileType:  val_6, fileName:  val_5);
                bool val_2 = System.IO.File.Exists(path:  val_7);
            }
            else
            {
                    val_7 = 0;
            }
            
            val_7 = val_7 & 1;
            return (bool)val_7;
        }
    
    }

}
