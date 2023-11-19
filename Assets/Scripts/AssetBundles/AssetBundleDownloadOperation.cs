using UnityEngine;

namespace AssetBundles
{
    public abstract class AssetBundleDownloadOperation : AssetBundleLoadOperation
    {
        // Fields
        private bool done;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <assetBundleName>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private AssetBundles.LoadedAssetBundle <assetBundle>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <error>k__BackingField;
        
        // Properties
        public string assetBundleName { get; set; }
        public AssetBundles.LoadedAssetBundle assetBundle { get; set; }
        public string error { get; set; }
        protected abstract bool downloadIsDone { get; }
        
        // Methods
        public AssetBundleDownloadOperation(string assetBundleName)
        {
            val_1 = new System.Object();
            this.<assetBundleName>k__BackingField = assetBundleName;
        }
        public string get_assetBundleName()
        {
            return (string)this.<assetBundleName>k__BackingField;
        }
        private void set_assetBundleName(string value)
        {
            this.<assetBundleName>k__BackingField = value;
        }
        public AssetBundles.LoadedAssetBundle get_assetBundle()
        {
            return (AssetBundles.LoadedAssetBundle)this.<assetBundle>k__BackingField;
        }
        protected void set_assetBundle(AssetBundles.LoadedAssetBundle value)
        {
            this.<assetBundle>k__BackingField = value;
        }
        public string get_error()
        {
            return (string)this.<error>k__BackingField;
        }
        protected void set_error(string value)
        {
            this.<error>k__BackingField = value;
        }
        protected abstract bool get_downloadIsDone(); // 0
        protected abstract void FinishDownload(); // 0
        public override bool Update()
        {
            bool val_2 = this.done;
            if(val_2 == true)
            {
                    return (bool)(val_2 == false) ? 1 : 0;
            }
            
            if((0 & 1) != 0)
            {
                    val_2 = true;
                this.done = val_2;
                return (bool)(val_2 == false) ? 1 : 0;
            }
            
            val_2 = this.done;
            return (bool)(val_2 == false) ? 1 : 0;
        }
        public override bool IsDone()
        {
            return (bool)this.done;
        }
        public abstract string GetSourceURL(); // 0
        public override bool HasError()
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  0);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public override string GetLastError()
        {
            return (string)this.<error>k__BackingField;
        }
    
    }

}
