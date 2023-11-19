using UnityEngine;

namespace LlockhamIndustries.Misc
{
    internal class DebugEntry
    {
        // Fields
        public UnityEngine.UI.Text text;
        public UnityEngine.RectTransform transform;
        public string title;
        public string log;
        
        // Methods
        public DebugEntry(UnityEngine.Font Font, UnityEngine.RectTransform LogRect, float LogHeight, int Index)
        {
            var val_14;
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "Entry");
            UnityEngine.RectTransform val_2 = AddComponent<UnityEngine.RectTransform>();
            this.transform = val_2;
            val_2.SetParent(parent:  LogRect, worldPositionStays:  false);
            UnityEngine.Rect val_3 = LogRect.rect;
            val_3.m_XMin = LogHeight / val_3.m_XMin;
            val_3.m_XMin = (float)Index * val_3.m_XMin;
            CinemachineFreeLook.Orbit val_5 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f - val_3.m_XMin);
            this.transform.anchorMin = new UnityEngine.Vector2() {x = val_5.m_Height, y = val_5.m_Radius};
            UnityEngine.Rect val_6 = LogRect.rect;
            val_6.m_XMin = LogHeight / val_6.m_XMin;
            val_6.m_XMin = (float)Index * val_6.m_XMin;
            CinemachineFreeLook.Orbit val_8 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f - val_6.m_XMin);
            this.transform.anchorMax = new UnityEngine.Vector2() {x = val_8.m_Height, y = val_8.m_Radius};
            CinemachineFreeLook.Orbit val_9 = new CinemachineFreeLook.Orbit(h:  0f, r:  -LogHeight);
            this.transform.offsetMin = new UnityEngine.Vector2() {x = val_9.m_Height, y = val_9.m_Radius};
            UnityEngine.Rect val_10 = LogRect.rect;
            CinemachineFreeLook.Orbit val_11 = new CinemachineFreeLook.Orbit(h:  val_10.m_XMin, r:  0f);
            this.transform.offsetMax = new UnityEngine.Vector2() {x = val_11.m_Height, y = val_11.m_Radius};
            UnityEngine.UI.Text val_12 = AddComponent<UnityEngine.UI.Text>();
            this.text = val_12;
            val_12.alignment = 3;
            UnityEngine.Color val_13 = UnityEngine.Color.white;
            this.text.color = new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
            this.text.fontSize = 20;
            this.text.font = Font;
            val_14 = null;
            val_14 = null;
            if(this.text != null)
            {
                    return;
            }
        
        }
        public void Update(string Title, string Log)
        {
            string val_5;
            var val_6;
            var val_7;
            UnityEngine.UI.Text val_8;
            var val_10;
            val_5 = Title;
            this.title = val_5;
            this.log = Log;
            val_6 = null;
            val_6 = null;
            if((System.String.op_Inequality(a:  0, b:  val_5)) == true)
            {
                goto label_3;
            }
            
            val_7 = null;
            val_7 = null;
            if((System.String.op_Inequality(a:  0, b:  Log)) == false)
            {
                goto label_6;
            }
            
            label_3:
            val_5 = this.title;
            val_8 = 0 + val_5 + " : "(" : ");
            if(this.text != null)
            {
                goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
            }
            
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
            label_6:
            val_10 = null;
            val_8 = this.text;
            val_10 = null;
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
    
    }

}
