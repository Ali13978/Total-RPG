using UnityEngine;

namespace SA.Common.Pattern
{
    public abstract class Singleton<T> : MonoBehaviour
    {
        // Fields
        private static T _instance;
        private static bool applicationIsQuitting;
        
        // Properties
        public static T Instance { get; }
        public static bool HasInstance { get; }
        public static bool IsDestroyed { get; }
        
        // Methods
        protected Singleton<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public static T get_Instance()
        {
            var val_9;
            string val_10;
            var val_11;
            var val_12;
            val_9 = X1;
            val_10 = mem[X1 + 24 + 168 + 160 + 8];
            val_10 = X1 + 24 + 168 + 160 + 8;
            if(val_10 != 0)
            {
                    val_11 = 0;
                return (object)val_11;
            }
            
            val_10 = 1152921504721543168;
            if(0 != (X1 + 24 + 168 + 160))
            {
                goto label_18;
            }
            
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_10 = UnityEngine.Object.FindObjectOfType(type:  0);
            if(val_10 == null)
            {
                goto label_16;
            }
            
            val_12 = val_10;
            if(val_12 != null)
            {
                goto label_17;
            }
            
            label_16:
            val_12 = 0;
            label_17:
            mem2[0] = val_12;
            if(0 == (X1 + 24 + 168 + 160))
            {
                    mem2[0] = new UnityEngine.GameObject();
                val_10 = X1 + 24 + 168 + 160.GetType();
                X1 + 24 + 168 + 160.gameObject.name = val_10;
            }
            
            label_18:
            val_9 = mem[X1 + 24 + 168];
            val_9 = X1 + 24 + 168;
            val_11 = mem[X1 + 24 + 168 + 160];
            val_11 = X1 + 24 + 168 + 160;
            return (object)val_11;
        }
        public static bool get_HasInstance()
        {
            if(((X1 + 24 + 168 + 266) & 1) == 0)
            {
                    return false;
            }
            
            if((X1 + 24 + 168 + 188) != 0)
            {
                    return false;
            }
            
            return false;
        }
        public static bool get_IsDestroyed()
        {
            return UnityEngine.Object.op_Equality(x:  0, y:  X1 + 24 + 168 + 160);
        }
        protected virtual void OnDestroy()
        {
            mem2[0] = 0;
            mem2[0] = 1;
        }
        protected virtual void OnApplicationQuit()
        {
            mem2[0] = 0;
            mem2[0] = 1;
        }
        private static Singleton<T>()
        {
        
        }
    
    }

}
