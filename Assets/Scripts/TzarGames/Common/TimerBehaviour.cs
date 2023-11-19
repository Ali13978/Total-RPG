using UnityEngine;

namespace TzarGames.Common
{
    public class TimerBehaviour : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onTimerActivated;
        private UnityEngine.Coroutine timerCoroutine;
        
        // Methods
        public TimerBehaviour()
        {
        
        }
        public void StartTimer(float time)
        {
            this.timerCoroutine = this.StartCoroutine(routine:  this.timerFunc(time:  time));
        }
        public void ResetTimer()
        {
            if(this.timerCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.timerCoroutine);
            this.timerCoroutine = 0;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator timerFunc(float time)
        {
            if(null != 0)
            {
                    typeof(TimerBehaviour.<timerFunc>c__Iterator0).__il2cppRuntimeField_10 = time;
            }
            else
            {
                    mem[16] = time;
            }
            
            typeof(TimerBehaviour.<timerFunc>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
