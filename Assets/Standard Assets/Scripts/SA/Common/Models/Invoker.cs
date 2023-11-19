using UnityEngine;

namespace SA.Common.Models
{
    public class Invoker : MonoBehaviour
    {
        // Fields
        private System.Action _callback;
        
        // Methods
        public Invoker()
        {
        
        }
        public static SA.Common.Models.Invoker Create(string name)
        {
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  0 + "SA.Common.Models.Invoker: "("SA.Common.Models.Invoker: "));
            if(null != 0)
            {
                    return AddComponent<SA.Common.Models.Invoker>();
            }
            
            return AddComponent<SA.Common.Models.Invoker>();
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public void StartInvoke(System.Action callback, float time)
        {
            this._callback = callback;
            this.Invoke(methodName:  "TimeOut", time:  time);
        }
        private void TimeOut()
        {
            if(this._callback != null)
            {
                    this._callback.Invoke();
            }
            
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
    
    }

}
