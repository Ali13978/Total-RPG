using UnityEngine;

namespace TzarGames.Common
{
    public class StateMachineBehaviourEventHandler : StateMachineBehaviour
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, int> OnEnterToState;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, int> OnExitFromState;
        
        // Methods
        public StateMachineBehaviourEventHandler()
        {
        
        }
        public void add_OnEnterToState(System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, int> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnEnterToState);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511216262392 != this.OnEnterToState);
        
        }
        public void remove_OnEnterToState(System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, int> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnEnterToState);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511216398968 != this.OnEnterToState);
        
        }
        public void add_OnExitFromState(System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, int> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnExitFromState);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511216535552 != this.OnExitFromState);
        
        }
        public void remove_OnExitFromState(System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, int> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnExitFromState);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511216672128 != this.OnExitFromState);
        
        }
        public override void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateEnter(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Length = stateInfo.m_Length, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            if(this.OnEnterToState == null)
            {
                    return;
            }
            
            this.OnEnterToState.Invoke(arg1:  animator, arg2:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Length = stateInfo.m_Length, m_Loop = stateInfo.m_Loop}, arg3:  layerIndex);
        }
        public override void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateExit(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Length = stateInfo.m_Length, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            if(this.OnExitFromState == null)
            {
                    return;
            }
            
            this.OnExitFromState.Invoke(arg1:  animator, arg2:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Length = stateInfo.m_Length, m_Loop = stateInfo.m_Loop}, arg3:  layerIndex);
        }
    
    }

}
