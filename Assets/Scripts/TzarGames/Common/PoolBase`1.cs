using UnityEngine;

namespace TzarGames.Common
{
    public abstract class PoolBase<T> : IPool
    {
        // Fields
        private System.Collections.Generic.List<T> objects;
        private int maxCount;
        
        // Properties
        public int Count { get; }
        
        // Methods
        public PoolBase<T>(int maxCount)
        {
            mem[1152921511152487600] = __RuntimeMethodHiddenParam + 24 + 168;
            mem[1152921511152487608] = maxCount;
        }
        protected abstract T createObject(); // 0
        public void CreateObjects(int count)
        {
            var val_1;
            if(count < 1)
            {
                    return;
            }
            
            val_1 = 0;
            do
            {
                if((0 & 1) != 0)
            {
                    return;
            }
            
                val_1 = val_1 + 1;
            }
            while(val_1 < count);
        
        }
        public T Get()
        {
            if(X21 >= 1)
            {
                    if(X21 != 0)
            {
                    return (object)X21;
            }
            
                return (object)X21;
            }
            
            if(this == null)
            {
                
            }
        
        }
        public bool IsMaximumReached()
        {
            return (bool)(X20 >= (__RuntimeMethodHiddenParam + 24 + 168 + 40)) ? 1 : 0;
        }
        public bool Contains(T pooledObject)
        {
            if(X20 == 0)
            {
                
            }
        
        }
        public bool Set(T pooledObject)
        {
            var val_1;
            var val_2;
            val_1 = this;
            if((0 & 1) != 0)
            {
                    val_2 = 0;
                return (bool)val_2;
            }
            
            val_2 = 1;
            return (bool)val_2;
        }
        public int get_Count()
        {
            if(X19 == 0)
            {
                
            }
        
        }
        public T At(int num)
        {
            var val_7;
            var val_8;
            val_7 = num;
            val_8 = this;
            if((val_7 & 2147483648) != 0)
            {
                    return 0;
            }
            
            if(X22 <= val_7)
            {
                    return 0;
            }
            
            val_7 = ???;
            val_8 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 168 + 48;
        }
        public void Clear()
        {
            if(X19 == 0)
            {
                
            }
        
        }
    
    }

}
