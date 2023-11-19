using UnityEngine;

namespace TMPro.Examples
{
    public class Benchmark01 : MonoBehaviour
    {
        // Fields
        public int BenchmarkType;
        public TMPro.TMP_FontAsset TMProFont;
        public UnityEngine.Font TextMeshFont;
        private TMPro.TextMeshPro m_textMeshPro;
        private TMPro.TextContainer m_textContainer;
        private UnityEngine.TextMesh m_textMesh;
        private const string label01 = "The <#0050FF>count is: </color>{0}";
        private const string label02 = "The <color=#0050FF>count is: </color>";
        private UnityEngine.Material m_material01;
        private UnityEngine.Material m_material02;
        
        // Methods
        public Benchmark01()
        {
        
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(Benchmark01.<Start>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
