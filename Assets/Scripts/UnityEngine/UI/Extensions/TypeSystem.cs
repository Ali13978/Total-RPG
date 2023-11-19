using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    internal static class TypeSystem
    {
        // Methods
        internal static System.Type GetElementType(System.Type seqType)
        {
            var val_2 = X1;
            System.Type val_1 = UnityEngine.UI.Extensions.TypeSystem.FindIEnumerable(seqType:  seqType);
            if(val_1 == null)
            {
                    return val_1;
            }
            
            return val_1;
        }
        private static System.Type FindIEnumerable(System.Type seqType)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = X1;
            goto label_0;
            label_30:
            val_9 = val_9;
            label_0:
            if(val_9 == 0)
            {
                goto label_27;
            }
            
            val_10 = null;
            val_11 = 0;
            if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) == val_9)
            {
                    return (System.Type)val_11;
            }
            
            if(val_9.IsArray == true)
            {
                goto label_6;
            }
            
            if((val_9 & 1) == 0)
            {
                goto label_9;
            }
            
            val_10 = val_9;
            var val_10 = 0;
            label_19:
            if(val_10 >= (X1 + 24))
            {
                goto label_9;
            }
            
            var val_3 = val_10 + 0;
            val_12 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            typeof(System.Type[]).__il2cppRuntimeField_20 = (X1 + 0) + 32;
            val_11 = val_12;
            val_10 = val_10 + 1;
            if(((val_11 & 1) & 1) == 0)
            {
                goto label_19;
            }
            
            return (System.Type)val_11;
            label_9:
            val_10 = val_9;
            if((val_10 != 0) && ((X1 + 24) >= 1))
            {
                    do
            {
                val_12 = 0;
                var val_6 = val_10 + 0;
                val_11 = val_9;
                if(val_11 != 0)
            {
                    return (System.Type)val_11;
            }
            
            }
            while((val_12 + 1) < (X1 + 24));
            
            }
            
            if(val_9 == 0)
            {
                goto label_27;
            }
            
            val_10 = val_9;
            val_11 = 0;
            if(val_10 != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_30;
            }
            
            return (System.Type)val_11;
            label_27:
            val_11 = 0;
            return (System.Type)val_11;
            label_6:
            typeof(System.Type[]).__il2cppRuntimeField_20 = val_9;
            if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) == null)
            {
                
            }
        
        }
        public static bool IsEnumerableType(System.Type type)
        {
            return (bool)((X1.GetInterface(name:  "IEnumerable")) != 0) ? 1 : 0;
        }
        public static bool IsCollectionType(System.Type type)
        {
            return (bool)((X1.GetInterface(name:  "ICollection")) != 0) ? 1 : 0;
        }
    
    }

}
