using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class NicerOutline : BaseMeshEffect
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Color m_EffectColor;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector2 m_EffectDistance;
        [UnityEngine.SerializeField]
        private bool m_UseGraphicAlpha;
        
        // Properties
        public UnityEngine.Color effectColor { get; set; }
        public UnityEngine.Vector2 effectDistance { get; set; }
        public bool useGraphicAlpha { get; set; }
        
        // Methods
        public NicerOutline()
        {
            this.m_EffectColor = 0;
            CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  1f, r:  -1f);
            this.m_EffectDistance = val_1.m_Height;
            mem[1152921512715893300] = val_1.m_Height >> 32;
            this.m_UseGraphicAlpha = true;
        }
        public UnityEngine.Color get_effectColor()
        {
            return new UnityEngine.Color() {r = this.m_EffectColor};
        }
        public void set_effectColor(UnityEngine.Color value)
        {
            float val_12;
            float val_13;
            var val_14;
            val_12 = value.a;
            val_13 = value.g;
            val_14 = this;
            this.m_EffectColor = value;
            mem[1152921512716125476] = val_13;
            mem[1152921512716125480] = value.b;
            mem[1152921512716125484] = val_12;
            if(0 == this.graphic)
            {
                    return;
            }
            
            UnityEngine.UI.Graphic val_3 = this.graphic;
            val_14 = ???;
            val_12 = ???;
            val_13 = ???;
            goto typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_2D0;
        }
        public UnityEngine.Vector2 get_effectDistance()
        {
            return new UnityEngine.Vector2() {x = this.m_EffectDistance};
        }
        public void set_effectDistance(UnityEngine.Vector2 value)
        {
            var val_16;
            double val_17;
            double val_18;
            val_16 = this;
            float val_1 = (value.x > 600f) ? 600f : (S2);
            float val_2 = (value.y > 600f) ? 600f : -600f;
            if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = this.m_EffectDistance, y = V10.16B}, rhs:  new UnityEngine.Vector2() {x = val_1, y = val_2})) == true)
            {
                    return;
            }
            
            this.m_EffectDistance = val_1;
            mem[1152921512716365876] = val_2;
            if(0 == this.graphic)
            {
                    return;
            }
            
            UnityEngine.UI.Graphic val_7 = this.graphic;
            val_16 = ???;
            val_18 = ???;
            val_17 = ???;
            goto typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_2D0;
        }
        public bool get_useGraphicAlpha()
        {
            return (bool)this.m_UseGraphicAlpha;
        }
        public void set_useGraphicAlpha(bool value)
        {
            var val_11;
            this.m_UseGraphicAlpha = value;
            if(0 == this.graphic)
            {
                    return;
            }
            
            UnityEngine.UI.Graphic val_4 = this.graphic;
            this = ???;
            val_11 = ???;
            goto typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_2D0;
        }
        protected void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y)
        {
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            float val_14;
            byte val_15;
            var val_17;
            float val_21;
            int val_22;
            byte val_23;
            int val_22 = start;
            val_21 = color.r;
            if(verts != null)
            {
                    val_22 = verts.Count;
            }
            else
            {
                    val_22 = 0.Count;
            }
            
            if(verts.Capacity < (val_22 << 1))
            {
                    val_22 = val_22 << 1;
                verts.Capacity = val_22;
            }
            
            if(val_22 >= end)
            {
                    return;
            }
            
            byte val_4 = val_21 >> 24;
            do
            {
                UnityEngine.UIVertex val_6 = verts.Item[val_22];
                float val_20 = val_7;
                val_21 = val_13;
                float val_21 = val_14;
                verts.Add(item:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_21}, normal = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_8}, color = new UnityEngine.Color32() {r = val_15, g = val_15, b = val_15, a = val_15}, uv0 = new UnityEngine.Vector2() {x = val_10, y = val_10}, uv1 = new UnityEngine.Vector2() {x = val_10, y = val_10}, uv2 = new UnityEngine.Vector2() {x = val_11, y = val_11}, uv3 = new UnityEngine.Vector2() {x = val_11, y = val_11}, tangent = new UnityEngine.Vector4() {x = val_12, y = val_12, z = val_12, w = val_12}});
                val_23 = val_4;
                if(mem[1152921512716742008] != false)
            {
                    UnityEngine.UIVertex val_16 = verts.Item[val_22];
                bool val_19 = val_17;
                val_19 = val_19 * val_4;
                val_19 = val_19 * 2155905153;
                val_23 = val_19 >> 39;
            }
            
                val_20 = val_20 + x;
                val_21 = val_21 + y;
                val_7 = val_10;
                verts.set_Item(index:  val_22, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_21}, normal = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_8}, color = new UnityEngine.Color32() {r = (val_21 & 16777215) | (val_23 << 24)}, uv0 = new UnityEngine.Vector2() {x = val_7, y = val_7}, uv1 = new UnityEngine.Vector2() {x = val_7, y = val_7}, uv2 = new UnityEngine.Vector2() {x = val_11, y = val_11}, uv3 = new UnityEngine.Vector2() {x = val_11, y = val_11}, tangent = new UnityEngine.Vector4() {x = val_12, y = val_12, z = val_12, w = val_12}});
                val_22 = val_22 + 1;
            }
            while(end != val_22);
        
        }
        protected void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y)
        {
            int val_5;
            if(verts != null)
            {
                    val_5 = verts.Count;
            }
            else
            {
                    val_5 = 0.Count;
            }
            
            if(verts.Capacity < (val_5 << 1))
            {
                    val_5 = val_5 << 1;
                verts.Capacity = val_5;
            }
            
            this.ApplyShadowZeroAlloc(verts:  verts, color:  new UnityEngine.Color32() {r = color.r & 4294967295, g = color.r & 4294967295, b = color.r & 4294967295, a = color.r & 4294967295}, start:  start, end:  end, x:  x, y:  y);
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_54;
            float val_55;
            float val_56;
            float val_57;
            if(this.IsActive() == false)
            {
                    return;
            }
            
            System.Collections.Generic.List<UnityEngine.UIVertex> val_2 = new System.Collections.Generic.List<UnityEngine.UIVertex>();
            vh.GetUIVertexStream(stream:  val_2);
            UnityEngine.UI.Text val_3 = this.GetComponent<UnityEngine.UI.Text>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    if(val_3.resizeTextForBestFit != false)
            {
                    float val_10 = (float)val_3.cachedTextGenerator.fontSizeUsedForBestFit / ((float)val_3.resizeTextMaxSize - 1);
            }
            
            }
            
            float val_11 = val_10 * this.m_EffectDistance;
            val_10 = val_10 * S11;
            UnityEngine.Color32 val_13 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.m_EffectColor, g = (float)val_3.resizeTextMaxSize - 1});
            if(null != 0)
            {
                    this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_13.r & 4294967295, g = val_13.r & 4294967295, b = val_13.r & 4294967295, a = val_13.r & 4294967295}, start:  0, end:  Count, x:  val_11, y:  val_10);
            }
            else
            {
                    this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_13.r & 4294967295, g = val_13.r & 4294967295, b = val_13.r & 4294967295, a = val_13.r & 4294967295}, start:  0, end:  Count, x:  val_11, y:  val_10);
            }
            
            UnityEngine.Color32 val_19 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.m_EffectColor, g = val_10});
            this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_19.r & 4294967295, g = val_19.r & 4294967295, b = val_19.r & 4294967295, a = val_19.r & 4294967295}, start:  Count, end:  Count, x:  val_11, y:  -val_10);
            int val_22 = Count;
            UnityEngine.Color32 val_23 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.m_EffectColor, g = -val_10});
            this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_23.r & 4294967295, g = val_23.r & 4294967295, b = val_23.r & 4294967295, a = val_23.r & 4294967295}, start:  Count, end:  Count, x:  -val_11, y:  val_10);
            int val_26 = Count;
            UnityEngine.Color32 val_27 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.m_EffectColor, g = val_10});
            if(null != 0)
            {
                    val_54 = -val_10;
                this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_27.r & 4294967295, g = val_27.r & 4294967295, b = val_27.r & 4294967295, a = val_27.r & 4294967295}, start:  val_22, end:  Count, x:  -val_11, y:  val_54);
            }
            else
            {
                    val_54 = -val_10;
                this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_27.r & 4294967295, g = val_27.r & 4294967295, b = val_27.r & 4294967295, a = val_27.r & 4294967295}, start:  val_22, end:  Count, x:  -val_11, y:  val_54);
            }
            
            int val_32 = Count;
            UnityEngine.Color32 val_33 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.m_EffectColor, g = val_54});
            if(null != 0)
            {
                    val_55 = 0f;
                this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_33.r & 4294967295, g = val_33.r & 4294967295, b = val_33.r & 4294967295, a = val_33.r & 4294967295}, start:  val_26, end:  Count, x:  val_11, y:  val_55);
            }
            else
            {
                    val_55 = 0f;
                this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_33.r & 4294967295, g = val_33.r & 4294967295, b = val_33.r & 4294967295, a = val_33.r & 4294967295}, start:  val_26, end:  Count, x:  val_11, y:  val_55);
            }
            
            int val_38 = Count;
            UnityEngine.Color32 val_39 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.m_EffectColor, g = val_55});
            if(null != 0)
            {
                    val_56 = 0f;
                this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_39.r & 4294967295, g = val_39.r & 4294967295, b = val_39.r & 4294967295, a = val_39.r & 4294967295}, start:  val_32, end:  Count, x:  -val_11, y:  val_56);
            }
            else
            {
                    val_56 = 0f;
                this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_39.r & 4294967295, g = val_39.r & 4294967295, b = val_39.r & 4294967295, a = val_39.r & 4294967295}, start:  val_32, end:  Count, x:  -val_11, y:  val_56);
            }
            
            UnityEngine.Color32 val_45 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.m_EffectColor, g = val_56});
            if(null != 0)
            {
                    val_57 = val_10;
                this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_45.r & 4294967295, g = val_45.r & 4294967295, b = val_45.r & 4294967295, a = val_45.r & 4294967295}, start:  val_38, end:  Count, x:  0f, y:  val_57);
            }
            else
            {
                    val_57 = val_10;
                this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_45.r & 4294967295, g = val_45.r & 4294967295, b = val_45.r & 4294967295, a = val_45.r & 4294967295}, start:  val_38, end:  Count, x:  0f, y:  val_57);
            }
            
            int val_50 = Count;
            UnityEngine.Color32 val_51 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.m_EffectColor, g = val_57});
            this.ApplyShadow(verts:  val_2, color:  new UnityEngine.Color32() {r = val_51.r & 4294967295, g = val_51.r & 4294967295, b = val_51.r & 4294967295, a = val_51.r & 4294967295}, start:  Count, end:  Count, x:  0f, y:  -val_10);
            if(vh != null)
            {
                    vh.Clear();
            }
            else
            {
                    0.Clear();
            }
            
            vh.AddUIVertexTriangleStream(verts:  val_2);
        }
    
    }

}
