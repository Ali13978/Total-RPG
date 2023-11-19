using UnityEngine;

namespace TzarGames.Common.UI
{
    public class UIBaseStateBehaviour : StateMachineBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool isVisibleState;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<bool> OnEnteredToState;
        
        // Methods
        public UIBaseStateBehaviour()
        {
        
        }
        public void add_OnEnteredToState(System.Action<bool> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnEnteredToState);
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
            while(1152921511230649680 != this.OnEnteredToState);
        
        }
        public void remove_OnEnteredToState(System.Action<bool> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnEnteredToState);
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
            while(1152921511230786256 != this.OnEnteredToState);
        
        }
        public override void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateEnter(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Length = stateInfo.m_Length, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            if(this.OnEnteredToState == null)
            {
                    return;
            }
            
            this.OnEnteredToState.Invoke(obj:  this.isVisibleState);
        }
    
    }

}
