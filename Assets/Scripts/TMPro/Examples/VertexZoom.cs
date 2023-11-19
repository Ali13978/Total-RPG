using UnityEngine;

namespace TMPro.Examples
{
    public class VertexZoom : MonoBehaviour
    {
        // Fields
        public float AngleMultiplier;
        public float SpeedMultiplier;
        public float CurveScale;
        private TMPro.TMP_Text m_TextComponent;
        private bool hasTextChanged;
        
        // Methods
        public VertexZoom()
        {
            this.AngleMultiplier = 1f;
            this.SpeedMultiplier = 1f;
            this.CurveScale = 1f;
        }
        private void Awake()
        {
            this.m_TextComponent = this.GetComponent<TMPro.TMP_Text>();
        }
        private void OnEnable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Add(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.VertexZoom::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        private void OnDisable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.VertexZoom::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AnimateVertexColors());
        }
        private void ON_TEXT_CHANGED(UnityEngine.Object obj)
        {
            if(0 != obj)
            {
                    return;
            }
            
            this.hasTextChanged = true;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator AnimateVertexColors()
        {
            typeof(VertexZoom.<AnimateVertexColors>c__Iterator0).__il2cppRuntimeField_70 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
