using UnityEngine;

namespace AssetBundles
{
    public class AssetBundleLoadAssetOperationFull : AssetBundleLoadAssetOperation
    {
        // Fields
        protected string m_AssetBundleName;
        protected string m_AssetName;
        protected string m_DownloadingError;
        protected System.Type m_Type;
        protected UnityEngine.AssetBundleRequest m_Request;
        
        // Methods
        public AssetBundleLoadAssetOperationFull(string bundleName, string assetName, System.Type type)
        {
            val_1 = new System.Object();
            this.m_AssetBundleName = bundleName;
            this.m_AssetName = val_1;
            this.m_Type = type;
        }
        public override T GetAsset<T>()
        {
            var val_4;
            var val_5;
            val_4 = __RuntimeMethodHiddenParam;
            if((this.m_Request != null) && (this.m_Request.isDone != false))
            {
                    UnityEngine.Object val_2 = this.m_Request.asset;
                val_4 = mem[__RuntimeMethodHiddenParam + 48];
                val_4 = __RuntimeMethodHiddenParam + 48;
                val_5 = 0;
                if(val_2 == null)
            {
                    return (object)val_5;
            }
            
                val_5 = val_2;
                if(val_5 != null)
            {
                    return (object)val_5;
            }
            
            }
            
            val_5 = 0;
            return (object)val_5;
        }
        public override bool Update()
        {
            var val_6;
            string val_7;
            if(this.m_Request != null)
            {
                    val_6 = 0;
                return (bool)val_6;
            }
            
            val_7 = this.m_DownloadingError;
            if((AssetBundles.AssetBundleManager.GetLoadedAssetBundle(assetBundleName:  null, error: out  this.m_AssetBundleName)) == null)
            {
                goto label_5;
            }
            
            val_7 = this.m_AssetName;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_8;
            }
            
            UnityEngine.AssetBundleRequest val_4 = val_2.m_AssetBundle.LoadAllAssetsAsync();
            goto label_10;
            label_5:
            val_6 = 1;
            return (bool)val_6;
            label_8:
            val_7 = this.m_AssetName;
            label_10:
            val_6 = 0;
            this.m_Request = val_2.m_AssetBundle.LoadAssetAsync(name:  val_7, type:  this.m_Type);
            return (bool)val_6;
        }
        public override bool IsDone()
        {
            var val_1;
            if(this.m_Request != null)
            {
                    return this.m_Request.isDone;
            }
            
            if(this.m_DownloadingError != null)
            {
                    UnityEngine.Debug.LogError(message:  0);
                val_1 = 1;
                return (bool)val_1;
            }
            
            val_1 = 0;
            return (bool)val_1;
        }
        public override bool HasError()
        {
            return (bool)(this.m_DownloadingError != null) ? 1 : 0;
        }
        public override string GetLastError()
        {
            return (string)this.m_DownloadingError;
        }
    
    }

}
