using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class RadialAttackSMB : StateMachineBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject effect;
        private UnityEngine.Transform effectInstance;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <NormalizedTime>k__BackingField;
        private bool entered;
        
        // Properties
        public float NormalizedTime { get; set; }
        
        // Methods
        public RadialAttackSMB()
        {
        
        }
        public float get_NormalizedTime()
        {
            return (float)this.<NormalizedTime>k__BackingField;
        }
        private void set_NormalizedTime(float value)
        {
            this.<NormalizedTime>k__BackingField = value;
        }
        public override void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateEnter(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Length = stateInfo.m_Length, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            this.entered = true;
            this.<NormalizedTime>k__BackingField = stateInfo.m_Name;
            UnityEngine.Transform val_2 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0).transform;
            this.effectInstance = val_2;
            val_2.SetParent(parent:  animator.transform);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.effectInstance.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            this.effectInstance.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        }
        public override void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateExit(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Length = stateInfo.m_Length, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            this.entered = false;
            this.<NormalizedTime>k__BackingField = 0f;
            if(0 == this.effectInstance)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.effectInstance.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            this.effectInstance = 0;
        }
        public override void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateUpdate(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Length = stateInfo.m_Length, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            if(this.entered != false)
            {
                    this.<NormalizedTime>k__BackingField = UnityEngine.Mathf.Clamp01(value:  stateInfo.m_Name);
                return;
            }
            
            this.<NormalizedTime>k__BackingField = 0f;
        }
    
    }

}
