using UnityEngine;

namespace TMPro.Examples
{
    public class VertexColorCycler : MonoBehaviour
    {
        // Fields
        private TMPro.TMP_Text m_TextComponent;
        
        // Methods
        public VertexColorCycler()
        {
        
        }
        private void Awake()
        {
            this.m_TextComponent = this.GetComponent<TMPro.TMP_Text>();
        }
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AnimateVertexColors());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator AnimateVertexColors()
        {
            typeof(VertexColorCycler.<AnimateVertexColors>c__Iterator0).__il2cppRuntimeField_38 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
