using UnityEngine;

namespace I2.Loc
{
    public class CoroutineManager : MonoBehaviour
    {
        // Fields
        private static I2.Loc.CoroutineManager mInstance;
        
        // Properties
        private static I2.Loc.CoroutineManager pInstance { get; }
        
        // Methods
        public CoroutineManager()
        {
        
        }
        private static I2.Loc.CoroutineManager get_pInstance()
        {
            I2.Loc.CoroutineManager val_5 = I2.Loc.CoroutineManager.mInstance;
            if(0 != val_5)
            {
                    return (I2.Loc.CoroutineManager)I2.Loc.CoroutineManager.mInstance;
            }
            
            if(null != 0)
            {
                    hideFlags = 61;
                val_5 = new UnityEngine.GameObject(name:  "_Coroutiner");
            }
            else
            {
                    0.hideFlags = 61;
                val_5 = 0;
            }
            
            I2.Loc.CoroutineManager.mInstance = AddComponent<I2.Loc.CoroutineManager>();
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (I2.Loc.CoroutineManager)I2.Loc.CoroutineManager.mInstance;
            }
            
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
            return (I2.Loc.CoroutineManager)I2.Loc.CoroutineManager.mInstance;
        }
        private void Awake()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public static UnityEngine.Coroutine Start(System.Collections.IEnumerator coroutine)
        {
            I2.Loc.CoroutineManager val_1 = I2.Loc.CoroutineManager.pInstance;
            if(val_1 != null)
            {
                    return val_1.StartCoroutine(routine:  X1);
            }
            
            return val_1.StartCoroutine(routine:  X1);
        }
    
    }

}
