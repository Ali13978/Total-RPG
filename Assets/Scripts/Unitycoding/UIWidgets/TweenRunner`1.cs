using UnityEngine;

namespace Unitycoding.UIWidgets
{
    internal class TweenRunner<T>
    {
        // Fields
        protected UnityEngine.MonoBehaviour m_CoroutineContainer;
        protected System.Collections.IEnumerator m_Tween;
        
        // Methods
        public TweenRunner<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private static System.Collections.IEnumerator Start(T tweenInfo)
        {
            mem2[0] = __RuntimeMethodHiddenParam + 32;
            mem2[0] = __RuntimeMethodHiddenParam + 16;
            mem2[0] = __RuntimeMethodHiddenParam;
            return (System.Collections.IEnumerator)X2 + 24 + 168;
        }
        public void Init(UnityEngine.MonoBehaviour coroutineContainer)
        {
            mem[1152921512647117488] = coroutineContainer;
        }
        public void StartTween(T info)
        {
            if(0 == 34820096)
            {
                    UnityEngine.Debug.LogWarning(message:  0);
                return;
            }
            
            if(!=0)
            {
                    X23.StopCoroutine(routine:  34820096);
                mem[1152921512647258152] = 0;
            }
            
            if(gameObject.activeInHierarchy != false)
            {
                    mem[1152921512647258152] = 0;
                UnityEngine.Coroutine val_5 = __RuntimeMethodHiddenParam.StartCoroutine(routine:  0);
                return;
            }
        
        }
    
    }

}
