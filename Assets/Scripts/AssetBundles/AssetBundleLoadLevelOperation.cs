using UnityEngine;

namespace AssetBundles
{
    public class AssetBundleLoadLevelOperation : AssetBundleLoadOperation
    {
        // Fields
        protected string m_AssetBundleName;
        protected string m_LevelName;
        protected bool m_IsAdditive;
        protected string m_DownloadingError;
        protected UnityEngine.AsyncOperation m_Request;
        
        // Methods
        public AssetBundleLoadLevelOperation(string assetbundleName, string levelName, bool isAdditive)
        {
            val_1 = new System.Object();
            this.m_AssetBundleName = assetbundleName;
            this.m_LevelName = val_1;
            this.m_IsAdditive = isAdditive;
        }
        public override bool Update()
        {
            var val_4;
            if(this.m_Request != null)
            {
                    val_4 = 0;
                return (bool)val_4;
            }
            
            if((AssetBundles.AssetBundleManager.GetLoadedAssetBundle(assetBundleName:  null, error: out  this.m_AssetBundleName)) != null)
            {
                    val_4 = 0;
                this.m_Request = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  0, mode:  this.m_LevelName);
                return (bool)val_4;
            }
            
            val_4 = 1;
            return (bool)val_4;
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
            bool val_1 = System.String.IsNullOrEmpty(value:  0);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public override string GetLastError()
        {
            return (string)this.m_DownloadingError;
        }
    
    }

}
