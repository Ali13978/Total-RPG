using UnityEngine;

namespace TzarGames.Common
{
    public class InstancePool<T> : PoolBase<T>
    {
        // Fields
        private TzarGames.Common.InstancePool.CreateInstanceDeleagate<T> createCallback;
        private T original;
        
        // Methods
        public InstancePool<T>(T original, TzarGames.Common.InstancePool.CreateInstanceDeleagate<T> createObjectCallback, int maxCount)
        {
            mem[1152921511151758272] = createObjectCallback;
            mem[1152921511151758280] = original;
        }
        protected override T createObject()
        {
            if(X19 == 0)
            {
                
            }
        
        }
    
    }

}
