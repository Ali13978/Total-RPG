using UnityEngine;

namespace TzarGames.Common
{
    public class Pool<T> : PoolBase<T>
    {
        // Fields
        private TzarGames.Common.Pool.CreateObjectDeleagate<T> createCallback;
        
        // Methods
        public Pool<T>(TzarGames.Common.Pool.CreateObjectDeleagate<T> createObjectCallback, int maxCount)
        {
            mem[1152921511151041216] = createObjectCallback;
        }
        protected override T createObject()
        {
            if(X19 == 0)
            {
                
            }
        
        }
    
    }

}
