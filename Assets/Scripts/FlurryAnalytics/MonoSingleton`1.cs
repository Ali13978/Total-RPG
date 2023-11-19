using UnityEngine;

namespace FlurryAnalytics
{
    public class MonoSingleton<T> : MonoBehaviour
    {
        // Fields
        private static T s_Instance;
        private static bool s_IsDestroyed;
        
        // Properties
        public static T Instance { get; }
        
        // Methods
        public MonoSingleton<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public static T get_Instance()
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_11 = X1;
            val_12 = mem[X1 + 24 + 168 + 160 + 8];
            val_12 = X1 + 24 + 168 + 160 + 8;
            if(val_12 != 0)
            {
                    val_13 = 0;
                return (object)val_13;
            }
            
            if(0 == (X1 + 24 + 168 + 160))
            {
                    System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                val_12 = UnityEngine.Object.FindObjectOfType(type:  0);
                val_14 = 0;
                if(val_12 != null)
            {
                    val_14 = val_12;
                if(val_14 == null)
            {
                    val_14 = 0;
            }
            
            }
            
                mem2[0] = val_14;
                if(0 == (X1 + 24 + 168 + 160))
            {
                    UnityEngine.GameObject val_7 = new UnityEngine.GameObject(name:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
                UnityEngine.Object.DontDestroyOnLoad(target:  0);
                val_12 = AddComponent(componentType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
                val_15 = 0;
                if(val_12 != null)
            {
                    val_15 = val_12;
                if(val_15 == null)
            {
                    val_15 = 0;
            }
            
            }
            
                mem2[0] = val_15;
            }
            
            }
            
            val_11 = mem[X1 + 24 + 168];
            val_11 = X1 + 24 + 168;
            val_13 = mem[X1 + 24 + 168 + 160];
            val_13 = X1 + 24 + 168 + 160;
            return (object)val_13;
        }
        protected virtual void OnDestroy()
        {
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    UnityEngine.Object.Destroy(obj:  0);
            }
            
            mem2[0] = 0;
            mem2[0] = 1;
        }
    
    }

}
