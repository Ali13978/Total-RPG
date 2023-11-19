using UnityEngine;

namespace AssetBundles
{
    public abstract class AssetBundleLoadAssetOperation : AssetBundleLoadOperation
    {
        // Methods
        protected AssetBundleLoadAssetOperation()
        {
            val_1 = new System.Object();
        }
        public abstract T GetAsset<T>(); // 0
    
    }

}
