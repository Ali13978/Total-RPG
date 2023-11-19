using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class Spinner : MonoBehaviour
    {
        // Fields
        public float changeDelay;
        [UnityEngine.SerializeField]
        private float m_Current;
        public float step;
        public float min;
        public float max;
        public Unitycoding.UIWidgets.Spinner.SpinnerEvent onChange;
        public Unitycoding.UIWidgets.Spinner.SpinnerTextEvent m_OnChange;
        private System.Collections.IEnumerator coroutine;
        
        // Properties
        public float current { get; set; }
        
        // Methods
        public Spinner()
        {
            this.changeDelay = 0.1f;
            this.step = 1f;
            this.onChange = new Spinner.SpinnerEvent();
            this.m_OnChange = new Spinner.SpinnerTextEvent();
        }
        public float get_current()
        {
            return (float)this.m_Current;
        }
        public void set_current(float value)
        {
            this.m_Current = value;
        }
        private void Start()
        {
            this.onChange.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void Unitycoding.UIWidgets.Spinner::<Start>m__0(float value)));
        }
        public void StartIncrease()
        {
            if(this.coroutine != null)
            {
                    this.StopCoroutine(routine:  this.coroutine);
            }
            
            System.Collections.IEnumerator val_1 = this.Increase();
            this.coroutine = val_1;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  val_1);
        }
        public void StartDecrease()
        {
            if(this.coroutine != null)
            {
                    this.StopCoroutine(routine:  this.coroutine);
            }
            
            System.Collections.IEnumerator val_1 = this.Decrease();
            this.coroutine = val_1;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  val_1);
        }
        public void Stop()
        {
            if(this.coroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.coroutine);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public System.Collections.IEnumerator Increase()
        {
            typeof(Spinner.<Increase>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public System.Collections.IEnumerator Decrease()
        {
            typeof(Spinner.<Decrease>c__Iterator1).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void <Start>m__0(float value)
        {
            this.m_OnChange.Invoke(arg0:  UnityEngine.Mathf.RoundToInt(f:  value));
        }
    
    }

}
