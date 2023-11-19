using UnityEngine;

namespace AssetBundles
{
    public class AssetBundleDownloadFromWebOperation : AssetBundleDownloadOperation
    {
        // Fields
        private UnityEngine.WWW m_WWW;
        private string m_Url;
        
        // Properties
        protected override bool downloadIsDone { get; }
        
        // Methods
        public AssetBundleDownloadFromWebOperation(string assetBundleName, UnityEngine.WWW www)
        {
            val_1 = new System.Object();
            mem[1152921511632434520] = assetBundleName;
            if(val_1 != null)
            {
                    this.m_WWW = val_1;
                this.m_Url = val_1.url;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "www");
        }
        public override void Clean()
        {
            if(this.m_WWW == null)
            {
                    return;
            }
            
            this.m_WWW.Dispose();
        }
        protected override bool get_downloadIsDone()
        {
            if(this.m_WWW == null)
            {
                    return true;
            }
            
            return this.m_WWW.isDone;
        }
        protected override void FinishDownload()
        {
            var val_8;
            mem[1152921511632832120] = this.m_WWW.error;
            val_8 = 1152921504608284672;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                    return;
            }
            
            if(0 == this.m_WWW.assetBundle)
            {
                    mem[1152921511632832120] = System.String.Format(format:  0, arg0:  "{0} is not a valid asset bundle.");
            }
            else
            {
                    object val_7 = null;
                val_8 = val_7;
                val_7 = new System.Object();
                typeof(AssetBundles.LoadedAssetBundle).__il2cppRuntimeField_10 = this.m_WWW.assetBundle;
                typeof(AssetBundles.LoadedAssetBundle).__il2cppRuntimeField_18 = 1;
                mem[1152921511632832112] = val_8;
            }
            
            this.m_WWW.Dispose();
            this.m_WWW = 0;
        }
        public override string GetSourceURL()
        {
            return (string)this.m_Url;
        }
        public override float GetProgress()
        {
            if(this.m_WWW == null)
            {
                    return 0f;
            }
            
            return this.m_WWW.progress;
        }
    
    }

}
