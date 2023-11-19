using UnityEngine;

namespace LlockhamIndustries.ExtensionMethods
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class GameObjectExtensionMethods
    {
        // Methods
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static T AddComponent<T>(UnityEngine.GameObject GameObject, T Source)
        {
            if(Source == null)
            {
                
            }
        
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.MonoBehaviour AddComponent(UnityEngine.GameObject GameObject, UnityEngine.MonoBehaviour Source)
        {
            UnityEngine.MonoBehaviour val_7;
            var val_8;
            System.Type val_1 = X2.GetType();
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if((val_1 & 1) != 0)
            {
                    UnityEngine.Component val_3 = Source.AddComponent(componentType:  val_1);
                val_7 = 0;
                if(val_3 != null)
            {
                    val_7 = val_3;
                val_7 = 0;
            }
            
                UnityEngine.MonoBehaviour val_6 = LlockhamIndustries.ExtensionMethods.GameObjectExtensionMethods.GetCopyOf<UnityEngine.MonoBehaviour>(Monobehaviour:  0, Source:  val_7);
                return (UnityEngine.MonoBehaviour)val_8;
            }
            
            val_8 = 0;
            return (UnityEngine.MonoBehaviour)val_8;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static T GetCopyOf<T>(UnityEngine.MonoBehaviour Monobehaviour, T Source)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = X3;
            val_7 = __RuntimeMethodHiddenParam;
            val_8 = Source.GetType();
            if(val_8 == val_7.GetType())
            {
                goto label_5;
            }
            
            goto label_19;
            label_18:
            val_8 = val_8;
            label_5:
            if(val_8 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_8;
            }
            
            val_9 = 0;
            goto label_10;
            label_16:
            X24.SetValue(obj:  Source, value:  X25);
            val_9 = 1;
            label_10:
            if(val_9 >= null)
            {
                goto label_12;
            }
            
            System.Type val_4 = val_8 + 8;
            if(1 != 0)
            {
                goto label_16;
            }
            
            goto label_16;
            label_12:
            if(val_8 != null)
            {
                goto label_18;
            }
            
            goto label_18;
            label_8:
            val_7 = mem[X3 + 48];
            val_7 = X3 + 48;
            val_6 = mem[X3 + 48];
            val_6 = X3 + 48;
            if(Source != null)
            {
                    val_10 = Source;
                if(val_10 != null)
            {
                    return (object)val_10;
            }
            
            }
            
            label_19:
            val_10 = 0;
            return (object)val_10;
        }
    
    }

}
