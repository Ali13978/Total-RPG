using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    internal static class SetPropertyUtility
    {
        // Methods
        public static bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue)
        {
            if((((X1 == newValue.r) && ((X1 + 4) == newValue.g)) && ((X1 + 8) == newValue.b)) && ((X1 + 12) == newValue.a))
            {
                    return false;
            }
            
            mem2[0] = newValue.r;
            mem2[0] = newValue.g;
            mem2[0] = newValue.b;
            mem2[0] = newValue.a;
            return true;
        }
        public static bool SetStruct<T>(ref T currentValue, T newValue)
        {
            var val_2;
            if(((__RuntimeMethodHiddenParam & 1) & 1) != 0)
            {
                    val_2 = 0;
                return (bool)val_2;
            }
            
            val_2 = 1;
            mem2[0] = newValue.x;
            mem2[0] = newValue.y;
            return (bool)val_2;
        }
        public static bool SetClass<T>(ref T currentValue, T newValue)
        {
            var val_2;
            if((__RuntimeMethodHiddenParam | 1152921504606900224) != null)
            {
                    if((null == null) || ((0 & 1) == 0))
            {
                goto label_2;
            }
            
            }
            
            val_2 = 0;
            return (bool)val_2;
            label_2:
            val_2 = 1;
            mem2[0] = __RuntimeMethodHiddenParam;
            return (bool)val_2;
        }
    
    }

}
