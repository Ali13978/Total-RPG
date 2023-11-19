using UnityEngine;

namespace TzarGames.Endless
{
    public class AirborneAnimatorBehaviour : StateMachineBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private float changingSpeed;
        [UnityEngine.SerializeField]
        private string animParameter;
        private float currentValue;
        
        // Methods
        public AirborneAnimatorBehaviour()
        {
            this.changingSpeed = 1f;
        }
        public override void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateEnter(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Length = stateInfo.m_Length, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            this.currentValue = 0f;
            animator.SetFloat(name:  this.animParameter, value:  0f);
        }
        public override void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateUpdate(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Length = stateInfo.m_Length, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.currentValue + val_1;
            this.currentValue = this.currentValue;
            animator.SetFloat(name:  this.animParameter, value:  this.currentValue);
        }
        public override void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateExit(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Length = stateInfo.m_Length, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            animator.SetFloat(name:  this.animParameter, value:  0f);
        }
    
    }

}
