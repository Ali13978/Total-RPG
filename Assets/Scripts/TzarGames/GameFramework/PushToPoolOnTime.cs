using UnityEngine;

namespace TzarGames.GameFramework
{
    public class PushToPoolOnTime : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private float time;
        [UnityEngine.SerializeField]
        private bool destroyIfNoPool;
        private UnityEngine.Coroutine coroutine;
        
        // Methods
        public PushToPoolOnTime()
        {
            this.time = 5f;
        }
        private void OnEnable()
        {
            if(this.coroutine != null)
            {
                    return;
            }
            
            this.coroutine = this.StartCoroutine(routine:  this.timeRoutine(timeToWait:  this.time));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator timeRoutine(float timeToWait)
        {
            if(null != 0)
            {
                    typeof(PushToPoolOnTime.<timeRoutine>c__Iterator0).__il2cppRuntimeField_10 = timeToWait;
            }
            else
            {
                    mem[16] = timeToWait;
            }
            
            typeof(PushToPoolOnTime.<timeRoutine>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void OnPulledFromPool()
        {
            if(this.coroutine != null)
            {
                    return;
            }
            
            this.coroutine = this.StartCoroutine(routine:  this.timeRoutine(timeToWait:  this.time));
        }
        public void OnPushedToPool()
        {
            if(this.coroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.coroutine);
            this.coroutine = 0;
        }
        private void OnDisable()
        {
            if(this.coroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.coroutine);
            this.coroutine = 0;
        }
    
    }

}
