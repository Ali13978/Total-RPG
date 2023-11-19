using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class DiamondGraph : UIPrimitiveBase
    {
        // Fields
        public float a;
        public float b;
        public float c;
        public float d;
        
        // Methods
        public DiamondGraph()
        {
            this.a = 1;
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            vh.Clear();
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            float val_20 = val_2.m_XMin;
            float val_3 = val_20 * 0.5f;
            this.a = System.Math.Min(val1:  1f, val2:  System.Math.Max(val1:  0f, val2:  this.a));
            this.b = System.Math.Min(val1:  1f, val2:  System.Math.Max(val1:  0f, val2:  this.b));
            this.c = System.Math.Min(val1:  1f, val2:  System.Math.Max(val1:  0f, val2:  this.c));
            this.d = System.Math.Min(val1:  1f, val2:  System.Math.Max(val1:  0f, val2:  this.d));
            UnityEngine.Color val_12 = this.color;
            UnityEngine.Color32 val_13 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a});
            float val_21 = this.a;
            val_20 = val_20 * (-0.5f);
            byte val_22 = val_13.r;
            val_21 = val_21 * val_20;
            CinemachineFreeLook.Orbit val_14 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
            val_22 = val_22 & 4294967295;
            vh.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = val_22, g = val_22, b = val_22, a = val_22}, uv0:  new UnityEngine.Vector2() {x = val_14.m_Height, y = val_14.m_Radius});
            float val_15 = val_3 * this.b;
            CinemachineFreeLook.Orbit val_16 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
            vh.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = val_22, g = val_22, b = val_22, a = val_22}, uv0:  new UnityEngine.Vector2() {x = val_16.m_Height, y = val_16.m_Radius});
            float val_23 = this.c;
            val_23 = val_3 * val_23;
            CinemachineFreeLook.Orbit val_17 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
            vh.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = val_22, g = val_22, b = val_22, a = val_22}, uv0:  new UnityEngine.Vector2() {x = val_17.m_Height, y = val_17.m_Radius});
            float val_18 = this.d * val_20;
            CinemachineFreeLook.Orbit val_19 = new CinemachineFreeLook.Orbit(h:  1f, r:  0f);
            vh.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = val_22, g = val_22, b = val_22, a = val_22}, uv0:  new UnityEngine.Vector2() {x = val_19.m_Height, y = val_19.m_Radius});
            if(vh != null)
            {
                    vh.AddTriangle(idx0:  0, idx1:  1, idx2:  2);
            }
            else
            {
                    0.AddTriangle(idx0:  0, idx1:  1, idx2:  2);
            }
            
            vh.AddTriangle(idx0:  2, idx1:  3, idx2:  0);
        }
    
    }

}
