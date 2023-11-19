using UnityEngine;

namespace TMPro.Examples
{
    public class Benchmark01_UGUI : MonoBehaviour
    {
        // Fields
        public int BenchmarkType;
        public UnityEngine.Canvas canvas;
        public TMPro.TMP_FontAsset TMProFont;
        public UnityEngine.Font TextMeshFont;
        private TMPro.TextMeshProUGUI m_textMeshPro;
        private UnityEngine.UI.Text m_textMesh;
        private const string label01 = "The <#0050FF>count is: </color>";
        private const string label02 = "The <color=#0050FF>count is: </color>";
        private UnityEngine.Material m_material01;
        private UnityEngine.Material m_material02;
        
        // Methods
        public Benchmark01_UGUI()
        {
        
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(Benchmark01_UGUI.<Start>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
