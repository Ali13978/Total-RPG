using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class UICircle : UIPrimitiveBase
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public int fillPercent;
        [UnityEngine.TooltipAttribute]
        public bool FixedToSegments;
        [UnityEngine.TooltipAttribute]
        public bool fill;
        [UnityEngine.TooltipAttribute]
        public float thickness;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public int segments;
        
        // Methods
        public UICircle()
        {
            mem[1152921512757487808] = 1065353216;
            this.fillPercent = 100;
            this.fill = true;
            this.thickness = 5f;
            this.segments = 360;
            val_1 = new UnityEngine.UI.MaskableGraphic();
        }
        private void Update()
        {
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            this.thickness = UnityEngine.Mathf.Clamp(value:  this.thickness, min:  0f, max:  val_2.m_XMin * 0.5f);
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            UnityEngine.UIVertex[] val_35;
            float val_36;
            float val_37;
            int val_38;
            var val_39;
            float val_40;
            UnityEngine.Vector2 val_2 = this.rectTransform.pivot;
            float val_36 = val_2.x;
            UnityEngine.Rect val_4 = this.rectTransform.rect;
            UnityEngine.Vector2 val_6 = this.rectTransform.pivot;
            float val_35 = val_6.x;
            val_35 = this.rectTransform;
            UnityEngine.Rect val_8 = val_35.rect;
            val_36 = this.thickness;
            val_35 = val_35 * val_8.m_XMin;
            vh.Clear();
            val_36 = -(val_36 * val_4.m_XMin);
            float val_9 = val_36 - val_35;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
            val_37 = 0f;
            CinemachineFreeLook.Orbit val_12 = new CinemachineFreeLook.Orbit(h:  val_37, r:  val_37);
            CinemachineFreeLook.Orbit val_13 = new CinemachineFreeLook.Orbit(h:  val_37, r:  1f);
            CinemachineFreeLook.Orbit val_14 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
            CinemachineFreeLook.Orbit val_15 = new CinemachineFreeLook.Orbit(h:  1f, r:  val_37);
            if(this.FixedToSegments != false)
            {
                    float val_37 = (float)this.fillPercent;
                val_37 = val_37 / 100f;
                val_37 = val_37 * ((float)this.segments + 1);
                val_38 = (int)val_37;
                if(val_38 < (1.401298E-45f))
            {
                    return;
            }
            
                val_39 = 1152921504719998976;
                val_40 = 0.01745329f;
                var val_39 = 0;
                val_37 = 0f;
                do
            {
                float val_38 = 0f;
                val_38 = (360f / (float)this.segments) * val_38;
                float val_18 = val_38 * val_40;
                val_36 = val_18;
                CinemachineFreeLook.Orbit val_19 = new CinemachineFreeLook.Orbit(h:  val_37, r:  1f);
                CinemachineFreeLook.Orbit val_20 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
                CinemachineFreeLook.Orbit val_21 = new CinemachineFreeLook.Orbit(h:  1f, r:  val_37);
                CinemachineFreeLook.Orbit val_22 = new CinemachineFreeLook.Orbit(h:  val_37, r:  val_37);
                this.StepThroughPointsAndFill(outer:  val_36, inner:  val_9, prevX: ref  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, prevY: ref  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, pos0: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, pos1: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, pos2: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, pos3: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, c:  val_18, s:  val_36);
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = 0;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = 0;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = 0;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = 0;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_19.m_Height;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_20.m_Height;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = val_21.m_Height;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = val_22.m_Height;
                val_35 = this.SetVbo(vertices:  null, uvs:  null);
                vh.AddUIVertexQuad(verts:  val_35);
                val_39 = val_39 + 1;
            }
            while(val_38 != val_39);
            
                return;
            }
            
            UnityEngine.Rect val_25 = this.rectTransform.rect;
            val_35 = this.rectTransform;
            UnityEngine.Rect val_27 = val_35.rect;
            val_36 = val_27.m_XMin;
            if((this.segments + 1) < 1)
            {
                    return;
            }
            
            float val_40 = (float)this.fillPercent;
            val_39 = 1152921505902205200;
            val_40 = val_40 / 100f;
            val_40 = val_40 * 6.283185f;
            val_40 = 0.5f;
            do
            {
                this.StepThroughPointsAndFill(outer:  val_36, inner:  val_9, prevX: ref  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, prevY: ref  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, pos0: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, pos1: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, pos2: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, pos3: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, c:  val_37, s:  val_37);
                float val_41 = 0f;
                float val_42 = 0f;
                val_41 = val_41 / val_25.m_XMin;
                val_42 = val_42 / val_36;
                val_41 = val_41 + val_40;
                val_42 = val_42 + val_40;
                CinemachineFreeLook.Orbit val_30 = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_42);
                float val_43 = 0f;
                float val_44 = 0f;
                val_43 = val_43 / val_25.m_XMin;
                val_44 = val_44 / val_36;
                val_43 = val_43 + val_40;
                val_44 = val_44 + val_40;
                CinemachineFreeLook.Orbit val_31 = new CinemachineFreeLook.Orbit(h:  val_43, r:  val_44);
                float val_45 = 0f;
                float val_46 = 0f;
                val_45 = val_45 / val_25.m_XMin;
                val_46 = val_46 / val_36;
                val_45 = val_45 + val_40;
                val_46 = val_46 + val_40;
                CinemachineFreeLook.Orbit val_32 = new CinemachineFreeLook.Orbit(h:  val_45, r:  val_46);
                float val_47 = 0f;
                float val_48 = 0f;
                val_47 = val_47 / val_25.m_XMin;
                val_48 = val_48 / val_36;
                val_47 = val_47 + val_40;
                val_48 = val_48 + val_40;
                CinemachineFreeLook.Orbit val_33 = new CinemachineFreeLook.Orbit(h:  val_47, r:  val_48);
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = 0;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = 0;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = 0;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = 0;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_30.m_Height;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_31.m_Height;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = val_32.m_Height;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = val_33.m_Height;
                val_35 = this.SetVbo(vertices:  null, uvs:  null);
                vh.AddUIVertexQuad(verts:  val_35);
                int val_49 = this.segments;
                val_37 = (val_40 / (float)this.segments) + val_37;
                val_38 = 0 + 1;
                val_49 = val_49 + 1;
            }
            while(val_38 < val_49);
        
        }
        private void StepThroughPointsAndFill(float outer, float inner, ref UnityEngine.Vector2 prevX, ref UnityEngine.Vector2 prevY, out UnityEngine.Vector2 pos0, out UnityEngine.Vector2 pos1, out UnityEngine.Vector2 pos2, out UnityEngine.Vector2 pos3, float c, float s)
        {
            outer = outer * c;
            pos0.x = prevX.x;
            1152921512758106192 = new CinemachineFreeLook.Orbit(h:  outer, r:  outer * s);
            if(this.fill != false)
            {
                    UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
                pos2.x = val_3.x;
                pos2.y = val_3.y;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
                pos3.x = val_4.x;
                pos3.y = val_4.y;
            }
            else
            {
                    1152921512758110368 = new CinemachineFreeLook.Orbit(h:  inner * c, r:  inner * s);
                pos3.x = prevY.x;
            }
            
            prevX.x = pos1.x;
            prevY.x = pos2.x;
        }
    
    }

}
