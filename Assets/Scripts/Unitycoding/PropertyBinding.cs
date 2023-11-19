using UnityEngine;

namespace Unitycoding
{
    public class PropertyBinding : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private Unitycoding.PropertyBinding.PropertyRef m_Source;
        [UnityEngine.SerializeField]
        private Unitycoding.PropertyBinding.PropertyRef m_Target;
        [UnityEngine.SerializeField]
        private Unitycoding.PropertyBinding.Execution m_Execution;
        [UnityEngine.SerializeField]
        private float m_Interval;
        
        // Methods
        public PropertyBinding()
        {
            this.m_Interval = 0.3f;
        }
        private void Start()
        {
            Execution val_3 = this.m_Execution;
            if(val_3 == 0)
            {
                    this.UpdateTarget();
                val_3 = this.m_Execution;
            }
            
            if(val_3 != 4)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.IntervalUpdate());
        }
        private void Update()
        {
            if(this.m_Execution != 1)
            {
                    return;
            }
            
            this.UpdateTarget();
        }
        private void LateUpdate()
        {
            if(this.m_Execution != 2)
            {
                    return;
            }
            
            this.UpdateTarget();
        }
        private void FixedUpdate()
        {
            if(this.m_Execution != 3)
            {
                    return;
            }
            
            this.UpdateTarget();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator IntervalUpdate()
        {
            typeof(PropertyBinding.<IntervalUpdate>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void UpdateTarget()
        {
            bool val_2 = this.m_Target.SetValue(value:  this.m_Source.GetValue());
        }
    
    }

}
