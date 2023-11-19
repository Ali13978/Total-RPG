using UnityEngine;

namespace TzarGames.Common.EventSystem
{
    public class Event<T>
    {
        // Fields
        private static System.Collections.Generic.List<T> handlers;
        
        // Methods
        public Event<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public static void AddHandler(T obj)
        {
            if((((X2 + 24 + 168 + 160) & 1) & 1) != 0)
            {
                    return;
            }
            
            if((X2 + 24 + 168 + 160) == 0)
            {
                
            }
        
        }
        public static void RemoveHandler(T obj)
        {
            if((X2 + 24 + 168 + 160) == 0)
            {
                
            }
        
        }
        public static void Execute(TzarGames.Common.EventSystem.Event.EventFunction<T> functor)
        {
            var val_1;
            var val_2 = (X2 + 24 + 168 + 160) - 1;
            if((val_2 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                val_1 = mem[X2 + 24];
                val_1 = X2 + 24;
                val_2 = val_2 - 1;
            }
            while((val_2 & 2147483648) == 0);
        
        }
        private static Event<T>()
        {
            mem2[0] = X1 + 24 + 168 + 56;
        }
    
    }

}
