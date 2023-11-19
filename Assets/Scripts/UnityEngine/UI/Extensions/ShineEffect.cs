using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class ShineEffect : MaskableGraphic
    {
        // Fields
        [UnityEngine.SerializeField]
        private float yoffset;
        [UnityEngine.SerializeField]
        private float width;
        
        // Properties
        public float Yoffset { get; set; }
        public float Width { get; set; }
        
        // Methods
        public ShineEffect()
        {
            this.yoffset = -1f;
            this.width = 1f;
        }
        public float get_Yoffset()
        {
            return (float)this.yoffset;
        }
        public void set_Yoffset(float value)
        {
            this.SetVerticesDirty();
            this.yoffset = value;
        }
        public float get_Width()
        {
            return (float)this.width;
        }
        public void set_Width(float value)
        {
            this.SetAllDirty();
            this.width = value;
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            UnityEngine.Rect val_1 = this.GetPixelAdjustedRect();
            float val_2 = val_1.m_XMin + val_1.m_XMin;
            float val_3 = val_1.m_XMin + val_1.m_XMin;
            float val_23 = 0f;
            val_23 = val_23 - 0f;
            float val_4 = val_23 + val_23;
            UnityEngine.Color val_5 = this.color;
            UnityEngine.Color32 val_6 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
            vh.Clear();
            float val_26 = 0f;
            float val_25 = this.yoffset;
            float val_24 = this.width;
            val_24 = val_24 * 0f;
            val_25 = val_4 * val_25;
            val_26 = val_26 + (-50f);
            val_25 = val_24 + val_25;
            byte val_7 = val_6.r & 16777215;
            CinemachineFreeLook.Orbit val_8 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
            vh.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = val_7, g = val_7, b = val_7, a = val_7}, uv0:  new UnityEngine.Vector2() {x = val_8.m_Height, y = val_8.m_Radius});
            float val_29 = 0f;
            float val_28 = this.yoffset;
            float val_27 = this.width;
            val_27 = val_27 * 0f;
            val_28 = val_4 * val_28;
            val_29 = val_29 + 50f;
            val_28 = val_27 + val_28;
            CinemachineFreeLook.Orbit val_9 = new CinemachineFreeLook.Orbit(h:  1f, r:  0f);
            vh.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = val_7, g = val_7, b = val_7, a = val_7}, uv0:  new UnityEngine.Vector2() {x = val_9.m_Height, y = val_9.m_Radius});
            UnityEngine.Color val_10 = this.color;
            float val_30 = 0f;
            float val_32 = this.yoffset;
            float val_31 = this.width;
            val_30 = val_30 * 0.25f;
            val_31 = val_31 * val_30;
            val_32 = val_4 * val_32;
            float val_11 = 0f + (-50f);
            val_10.a = val_10.a * 255f;
            val_32 = val_31 + val_32;
            int val_33 = (int)val_10.a;
            val_33 = val_7 | (val_33 << 24);
            CinemachineFreeLook.Orbit val_12 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
            vh.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = val_33, g = val_33, b = val_33, a = val_33}, uv0:  new UnityEngine.Vector2() {x = val_12.m_Height, y = val_12.m_Radius});
            float val_34 = 0f;
            float val_36 = 0f;
            float val_35 = this.yoffset;
            val_34 = val_34 * 0.25f;
            val_34 = this.width * val_34;
            val_35 = val_4 * val_35;
            val_36 = val_36 + 50f;
            val_34 = val_34 + val_35;
            CinemachineFreeLook.Orbit val_13 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
            vh.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = val_33, g = val_33, b = val_33, a = val_33}, uv0:  new UnityEngine.Vector2() {x = val_13.m_Height, y = val_13.m_Radius});
            UnityEngine.Color val_14 = this.color;
            float val_37 = this.yoffset;
            int val_38 = (int)val_14.a * 255f;
            float val_16 = 0f + (-50f);
            val_37 = val_4 * val_37;
            float val_17 = 0f * 0.25f;
            val_17 = this.width * val_17;
            val_17 = val_17 + val_37;
            val_38 = val_7 | (val_38 << 24);
            CinemachineFreeLook.Orbit val_18 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
            vh.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = val_38, g = val_38, b = val_38, a = val_38}, uv0:  new UnityEngine.Vector2() {x = val_18.m_Height, y = val_18.m_Radius});
            float val_41 = 0f;
            float val_39 = 0f;
            float val_40 = this.yoffset;
            val_39 = val_39 * 0.25f;
            val_39 = this.width * val_39;
            val_40 = val_4 * val_40;
            val_41 = val_41 + 50f;
            val_39 = val_39 + val_40;
            CinemachineFreeLook.Orbit val_19 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
            vh.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = val_38, g = val_38, b = val_38, a = val_38}, uv0:  new UnityEngine.Vector2() {x = val_19.m_Height, y = val_19.m_Radius});
            UnityEngine.Color val_20 = this.color;
            float val_42 = 0f;
            float val_43 = this.yoffset;
            float val_44 = this.width;
            val_42 = val_42 + (-50f);
            val_43 = val_4 * val_43;
            val_44 = val_44 * 0f;
            val_43 = val_44 + val_43;
            CinemachineFreeLook.Orbit val_21 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
            vh.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = val_7, g = val_7, b = val_7, a = val_7}, uv0:  new UnityEngine.Vector2() {x = val_21.m_Height, y = val_21.m_Radius});
            float val_45 = 0f;
            float val_47 = this.yoffset;
            float val_46 = this.width;
            val_45 = val_45 + 50f;
            val_46 = val_46 * 0f;
            val_47 = val_4 * val_47;
            val_47 = val_46 + val_47;
            CinemachineFreeLook.Orbit val_22 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
            vh.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = val_7, g = val_7, b = val_7, a = val_7}, uv0:  new UnityEngine.Vector2() {x = val_22.m_Height, y = val_22.m_Radius});
            if(vh != null)
            {
                    vh.AddTriangle(idx0:  0, idx1:  1, idx2:  2);
                vh.AddTriangle(idx0:  2, idx1:  3, idx2:  1);
                vh.AddTriangle(idx0:  2, idx1:  3, idx2:  4);
                vh.AddTriangle(idx0:  4, idx1:  5, idx2:  3);
                vh.AddTriangle(idx0:  4, idx1:  5, idx2:  6);
            }
            else
            {
                    0.AddTriangle(idx0:  0, idx1:  1, idx2:  2);
                0.AddTriangle(idx0:  2, idx1:  3, idx2:  1);
                0.AddTriangle(idx0:  2, idx1:  3, idx2:  4);
                0.AddTriangle(idx0:  4, idx1:  5, idx2:  3);
                0.AddTriangle(idx0:  4, idx1:  5, idx2:  6);
            }
            
            vh.AddTriangle(idx0:  6, idx1:  7, idx2:  5);
        }
        public void Triangulate(UnityEngine.UI.VertexHelper vh)
        {
            int val_5;
            int val_6;
            val_5 = vh.currentVertCount - 2;
            UnityEngine.Debug.Log(message:  0);
            var val_2 = (val_5 < 0) ? (val_5 + 1) : (val_5);
            if(val_5 < 3)
            {
                    return;
            }
            
            val_2 = val_2 >> 1;
            do
            {
                if(vh != null)
            {
                    val_6 = 0 + 1;
                val_5 = 0 + 2;
                vh.AddTriangle(idx0:  0, idx1:  val_6, idx2:  val_5);
            }
            else
            {
                    val_6 = 0 + 1;
                val_5 = 0 + 2;
                0.AddTriangle(idx0:  0, idx1:  val_6, idx2:  val_5);
            }
            
                vh.AddTriangle(idx0:  val_5, idx1:  0 + 3, idx2:  val_6);
            }
            while(val_5 <= (val_2 + 1));
        
        }
    
    }

}
