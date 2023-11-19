using UnityEngine;

namespace TMPro.Examples
{
    public class VertexShakeA : MonoBehaviour
    {
        // Fields
        public float AngleMultiplier;
        public float SpeedMultiplier;
        public float ScaleMultiplier;
        public float RotationMultiplier;
        private TMPro.TMP_Text m_TextComponent;
        private bool hasTextChanged;
        
        // Methods
        public VertexShakeA()
        {
            this.AngleMultiplier = 1;
        }
        private void Awake()
        {
            this.m_TextComponent = this.GetComponent<TMPro.TMP_Text>();
        }
        private void OnEnable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Add(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.VertexShakeA::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        private void OnDisable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.VertexShakeA::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AnimateVertexColors());
        }
        private void ON_TEXT_CHANGED(UnityEngine.Object obj)
        {
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            this.hasTextChanged = true;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator AnimateVertexColors()
        {
            typeof(VertexShakeA.<AnimateVertexColors>c__Iterator0).__il2cppRuntimeField_68 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
