using UnityEngine;

namespace Unitycoding
{
    public class DontDestroyOnLoad : MonoBehaviour
    {
        // Methods
        public DontDestroyOnLoad()
        {
        
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
    
    }

}
