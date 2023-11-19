using UnityEngine;

namespace TMPro.Examples
{
    public class SimpleScript : MonoBehaviour
    {
        // Fields
        private TMPro.TextMeshPro m_textMeshPro;
        private const string label = "The <#0050FF>count is: </color>{0:2}";
        private float m_frame;
        
        // Methods
        public SimpleScript()
        {
        
        }
        private void Start()
        {
            this.m_textMeshPro = this.gameObject.AddComponent<TMPro.TextMeshPro>();
            this.m_textMeshPro.fontSize = 48f;
            this.m_textMeshPro.alignment = 2;
            this.m_textMeshPro.enableWordWrapping = false;
        }
        private void Update()
        {
            this.m_textMeshPro.SetText(text:  "The <#0050FF>count is: </color>{0:2}", arg0:  this.m_frame);
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.m_frame + val_1;
            this.m_frame = val_1;
        }
    
    }

}
