using UnityEngine;

namespace Unitycoding
{
    public class CoroutineQueue
    {
        // Fields
        private UnityEngine.MonoBehaviour m_Owner;
        private UnityEngine.Coroutine m_InternalCoroutine;
        private System.Collections.Generic.Queue<System.Collections.IEnumerator> actions;
        
        // Methods
        public CoroutineQueue(UnityEngine.MonoBehaviour aCoroutineOwner)
        {
            this.actions = new System.Collections.Generic.Queue<System.Collections.IEnumerator>();
            this.m_Owner = aCoroutineOwner;
        }
        public void Start()
        {
            this.m_InternalCoroutine = this.m_Owner.StartCoroutine(routine:  this.Process());
        }
        public void Stop()
        {
            this.m_Owner.StopCoroutine(routine:  this.m_InternalCoroutine);
            this.m_InternalCoroutine = 0;
        }
        public void EnqueueAction(System.Collections.IEnumerator aAction)
        {
            this.actions.Enqueue(item:  aAction);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Process()
        {
            typeof(CoroutineQueue.<Process>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
