using UnityEngine;

namespace TMPro.Examples
{
    public class TeleType : MonoBehaviour
    {
        // Fields
        private string label01;
        private string label02;
        private TMPro.TMP_Text m_textMeshPro;
        
        // Methods
        public TeleType()
        {
            this.label01 = "Example <sprite=2> of using <sprite=7> <#ffa000>Graphics Inline</color> <sprite=5> with Text in <font=\"Bangers SDF\" material=\"Bangers SDF - Drop Shadow\">TextMesh<#40a0ff>Pro</color></font><sprite=0> and Unity<sprite=1>";
            this.label02 = "Example <sprite=2> of using <sprite=7> <#ffa000>Graphics Inline</color> <sprite=5> with Text in <font=\"Bangers SDF\" material=\"Bangers SDF - Drop Shadow\">TextMesh<#40a0ff>Pro</color></font><sprite=0> and Unity<sprite=2>";
        }
        private void Awake()
        {
            TMPro.TMP_Text val_1 = this.GetComponent<TMPro.TMP_Text>();
            this.m_textMeshPro = val_1;
            val_1.text = this.label01;
            this.m_textMeshPro.enableWordWrapping = true;
            this.m_textMeshPro.alignment = 2;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(TeleType.<Start>c__Iterator0).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
