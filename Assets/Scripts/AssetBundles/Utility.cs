using UnityEngine;

namespace AssetBundles
{
    public class Utility
    {
        // Fields
        public const string AssetBundlesOutputPath = "AssetBundles";
        
        // Methods
        public Utility()
        {
        
        }
        public static string GetPlatformName()
        {
            return AssetBundles.Utility.GetPlatformForAssetBundles(platform:  UnityEngine.Application.platform);
        }
        private static string GetPlatformForAssetBundles(UnityEngine.RuntimePlatform platform)
        {
            var val_3;
            if(W1 == 1)
            {
                goto label_1;
            }
            
            if(W1 != 2)
            {
                goto label_2;
            }
            
            val_3 = "Windows";
            return (string)(W1 != 17) ? 0 : "WebGL";
            label_1:
            val_3 = "OSX";
            return (string)(W1 != 17) ? 0 : "WebGL";
            label_2:
            if((W1 - 8) <= 3)
            {
                    if((25808208 + ((W1 - 8)) << 2) == 5)
            {
                    return (string)(W1 != 17) ? 0 : "WebGL";
            }
            
                if((25808208 + ((W1 - 8)) << 2) == 7)
            {
                    return (string)(W1 != 17) ? 0 : "WebGL";
            }
            
            }
            
            return (string)(W1 != 17) ? 0 : "WebGL";
        }
    
    }

}
