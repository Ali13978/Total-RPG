using UnityEngine;

namespace SA.Common.Pattern
{
    public abstract class NonMonoSingleton<T>
    {
        // Fields
        private static T _Instance;
        
        // Properties
        public static T Instance { get; }
        
        // Methods
        protected NonMonoSingleton<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public static T get_Instance()
        {
            if((X1 + 24 + 168 + 160) == 0)
            {
                    mem2[0] = 0;
            }
            
            if(((X1 + 24 + 168 + 266) & 1) == 0)
            {
                    return (object)X1 + 24 + 168 + 160;
            }
            
            if((X1 + 24 + 168 + 188) != 0)
            {
                    return (object)X1 + 24 + 168 + 160;
            }
            
            return (object)X1 + 24 + 168 + 160;
        }
        private static NonMonoSingleton<T>()
        {
        
        }
    
    }

}
