using UnityEngine;

namespace SA.IOSDeploy
{
    [Serializable]
    public class AssetFile
    {
        // Fields
        public bool IsOpen;
        public string XCodePath;
        public UnityEngine.Object Asset;
        
        // Properties
        public string FileName { get; }
        public string FilePath { get; }
        public string XCodeRelativePath { get; }
        public bool IsDirectory { get; }
        
        // Methods
        public AssetFile()
        {
            null = null;
            this.XCodePath = System.String.Empty;
        }
        public string get_FileName()
        {
            null = null;
            return (string)System.String.Empty;
        }
        public string get_FilePath()
        {
            null = null;
            return (string)System.String.Empty;
        }
        public string get_XCodeRelativePath()
        {
            string val_1 = this.FileName;
            return 0 + this.XCodePath;
        }
        public bool get_IsDirectory()
        {
            string val_1 = this.FilePath;
            return (bool)(uint)((System.IO.File.GetAttributes(path:  0)) >> 4) & 1;
        }
    
    }

}
