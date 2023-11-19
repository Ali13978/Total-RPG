using UnityEngine;

namespace AssetBundles
{
    public class LoadedAssetBundle
    {
        // Fields
        public UnityEngine.AssetBundle m_AssetBundle;
        public int m_ReferencedCount;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action unload;
        
        // Methods
        public LoadedAssetBundle(UnityEngine.AssetBundle assetBundle)
        {
            this.m_ReferencedCount = 1;
            this.m_AssetBundle = assetBundle;
        }
        internal void add_unload(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.unload);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511635877488 != this.unload);
        
        }
        internal void remove_unload(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.unload);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511636014064 != this.unload);
        
        }
        internal void OnUnload()
        {
            this.m_AssetBundle.Unload(unloadAllLoadedObjects:  false);
            if(this.unload == null)
            {
                    return;
            }
            
            this.unload.Invoke();
        }
    
    }

}
