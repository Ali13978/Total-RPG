using UnityEngine;

namespace TzarGames.GameFramework
{
    public abstract class NetworkViewID
    {
        // Properties
        public abstract ulong ID { get; }
        public abstract bool IsUnassigned { get; }
        
        // Methods
        protected NetworkViewID()
        {
        
        }
        public abstract ulong get_ID(); // 0
        public abstract bool get_IsUnassigned(); // 0
        public static bool op_Inequality(TzarGames.GameFramework.NetworkViewID a, TzarGames.GameFramework.NetworkViewID b)
        {
            var val_7;
            bool val_1 = System.Object.ReferenceEquals(objA:  0, objB:  b);
            bool val_2 = System.Object.ReferenceEquals(objA:  0, objB:  X2);
            val_7 = val_1 ^ val_2;
            if(val_1 != true)
            {
                    if(val_2 != true)
            {
                    var val_6 = X2;
            }
            
            }
            
            val_6 = ((b != val_6) ? 1 : 0) & 1;
            return (bool)val_6;
        }
        public static bool op_Equality(TzarGames.GameFramework.NetworkViewID a, TzarGames.GameFramework.NetworkViewID b)
        {
            var val_7;
            bool val_1 = System.Object.ReferenceEquals(objA:  0, objB:  b);
            bool val_2 = System.Object.ReferenceEquals(objA:  0, objB:  X2);
            if(val_1 != false)
            {
                    if(val_2 != false)
            {
                    val_7 = 1;
                return (bool)(b == X2) ? 1 : 0;
            }
            
            }
            
            if((val_1 | val_2) == false)
            {
                    return (bool)(b == X2) ? 1 : 0;
            }
            
            val_7 = 0;
            return (bool)(b == X2) ? 1 : 0;
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                    return false;
            }
            
            return false;
        }
        public override int GetHashCode()
        {
            return -1831871784;
        }
    
    }

}
