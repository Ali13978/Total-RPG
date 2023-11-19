using UnityEngine;

namespace AssetBundles
{
    public class AssetBundleLoadAssetOperationSimulation : AssetBundleLoadAssetOperation
    {
        // Fields
        private UnityEngine.Object m_SimulatedObject;
        
        // Methods
        public AssetBundleLoadAssetOperationSimulation(UnityEngine.Object simulatedObject)
        {
            val_1 = new System.Object();
            this.m_SimulatedObject = simulatedObject;
        }
        public override T GetAsset<T>()
        {
            var val_2;
            if(this.m_SimulatedObject != null)
            {
                    val_2 = this.m_SimulatedObject;
                if(val_2 != null)
            {
                    return (object)val_2;
            }
            
            }
            
            val_2 = 0;
            return (object)val_2;
        }
        public override bool Update()
        {
            return false;
        }
        public override bool IsDone()
        {
            return true;
        }
        public override bool HasError()
        {
            return false;
        }
        public override string GetLastError()
        {
            return 0;
        }
    
    }

}
