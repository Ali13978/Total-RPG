using UnityEngine;

namespace AssetBundles
{
    public class AssetBundleLoadManifestOperation : AssetBundleLoadAssetOperationFull
    {
        // Methods
        public AssetBundleLoadManifestOperation(string bundleName, string assetName, System.Type type)
        {
            val_1 = new System.Object();
            mem[1152921511635507680] = bundleName;
            mem[1152921511635507688] = val_1;
            mem[1152921511635507704] = type;
        }
        public override bool Update()
        {
            var val_4;
            UnityEngine.AssetBundleManifest val_5;
            var val_6;
            val_4 = this;
            bool val_1 = this.Update();
            if(val_1 != false)
            {
                    if(val_1.isDone != false)
            {
                    val_5 = val_4;
                val_4 = val_5;
                val_5 = null;
                AssetBundles.AssetBundleManager.AssetBundleManifestObject = val_5;
                val_6 = 0;
                return (bool)val_6;
            }
            
            }
            
            val_6 = 1;
            return (bool)val_6;
        }
    
    }

}
