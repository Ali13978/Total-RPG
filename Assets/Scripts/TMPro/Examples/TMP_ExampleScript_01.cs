using UnityEngine;

namespace TMPro.Examples
{
    public class TMP_ExampleScript_01 : MonoBehaviour
    {
        // Fields
        public TMPro.Examples.TMP_ExampleScript_01.objectType ObjectType;
        public bool isStatic;
        private TMPro.TMP_Text m_text;
        private const string k_label = "The count is <#0080ff>{0}</color>";
        private int count;
        
        // Methods
        public TMP_ExampleScript_01()
        {
        
        }
        private void Awake()
        {
            TMPro.TMP_Text val_11;
            var val_12;
            var val_13;
            if(this.ObjectType == 0)
            {
                goto label_1;
            }
            
            val_11 = this.GetComponent<TMPro.TextMeshProUGUI>();
            if(val_11 != null)
            {
                goto label_5;
            }
            
            val_12 = this.gameObject;
            val_13 = 1152921509787622912;
            goto label_4;
            label_1:
            val_11 = this.GetComponent<TMPro.TextMeshPro>();
            if(val_11 != null)
            {
                goto label_5;
            }
            
            val_12 = this.gameObject;
            val_13 = 1152921512507964416;
            label_4:
            val_11 = val_12.AddComponent<TMPro.TextMeshPro>();
            label_5:
            this.m_text = val_11;
            val_11.font = UnityEngine.Resources.Load<UnityEngine.Mesh>(path:  0);
            UnityEngine.Mesh val_7 = UnityEngine.Resources.Load<UnityEngine.Mesh>(path:  0);
            this.m_text.fontSize = 120f;
            this.m_text.text = "A <#0080ff>simple</color> line of text.";
            UnityEngine.Vector2 val_8 = this.m_text.GetPreferredValues(width:  Infinityf, height:  Infinityf);
            CinemachineFreeLook.Orbit val_10 = new CinemachineFreeLook.Orbit(h:  val_8.x, r:  val_8.y);
            this.m_text.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_10.m_Height, y = val_10.m_Radius};
        }
        private void Update()
        {
            if(this.isStatic == true)
            {
                    return;
            }
            
            var val_2 = (long)this.count;
            var val_1 = val_2 * 274877907;
            val_2 = val_1 >> 63;
            val_1 = val_1 >> 38;
            val_1 = val_1 + val_2;
            val_1 = this.count - (val_1 * 1000);
            this.m_text.SetText(text:  "The count is <#0080ff>{0}</color>", arg0:  (float)val_1);
            int val_3 = this.count;
            val_3 = val_3 + 1;
            this.count = val_3;
        }
    
    }

}
