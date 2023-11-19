using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class UIPolygon : UIPrimitiveBase
    {
        // Fields
        public bool fill;
        public float thickness;
        [UnityEngine.RangeAttribute]
        public int sides;
        [UnityEngine.RangeAttribute]
        public float rotation;
        [UnityEngine.RangeAttribute]
        public float[] VerticesDistances;
        private float size;
        
        // Methods
        public UIPolygon()
        {
            this.fill = true;
            this.thickness = 5f;
            this.sides = 3;
            mem[1152921512764315392] = 1065353216;
            this.VerticesDistances = null;
            this = new UnityEngine.UI.MaskableGraphic();
        }
        public void DrawPolygon(int _sides)
        {
            System.Single[] val_2;
            var val_3;
            int val_2 = _sides;
            this.sides = val_2;
            int val_1 = val_2 + 1;
            val_2 = null;
            val_2 = val_2 - 1;
            this.VerticesDistances = val_2;
            if()
            {
                goto label_1;
            }
            
            val_3 = 0;
            goto label_2;
            label_5:
            val_2 = this.VerticesDistances;
            val_3 = 1;
            label_2:
            val_2[val_3] = 1f;
            if(val_2 != val_3)
            {
                goto label_5;
            }
            
            label_1:
            this.rotation = 0f;
        }
        public void DrawPolygon(int _sides, float[] _VerticesDistances)
        {
            this.sides = _sides;
            this.rotation = 0f;
            this.VerticesDistances = _VerticesDistances;
        }
        public void DrawPolygon(int _sides, float[] _VerticesDistances, float _rotation)
        {
            this.sides = _sides;
            this.VerticesDistances = _VerticesDistances;
            this.rotation = _rotation;
        }
        private void Update()
        {
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            this.size = val_2.m_XMin;
            UnityEngine.Rect val_4 = this.rectTransform.rect;
            UnityEngine.Rect val_6 = this.rectTransform.rect;
            UnityEngine.Rect val_8 = this.rectTransform.rect;
            if(val_4.m_XMin > val_6.m_XMin)
            {
                
            }
            else
            {
                
            }
            
            this.size = val_8.m_XMin;
            this.thickness = UnityEngine.Mathf.Clamp(value:  this.thickness, min:  0f, max:  val_8.m_XMin * 0.5f);
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_26;
            float val_27;
            float val_28;
            System.Single[] val_29;
            var val_30;
            float val_31;
            System.Single[] val_32;
            System.Single[] val_33;
            int val_34;
            float val_35;
            float val_36;
            float val_37;
            float val_38;
            vh.Clear();
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            val_26 = 0f;
            val_27 = val_2.x;
            CinemachineFreeLook.Orbit val_3 = new CinemachineFreeLook.Orbit(h:  val_26, r:  val_26);
            val_28 = 1f;
            CinemachineFreeLook.Orbit val_4 = new CinemachineFreeLook.Orbit(h:  val_26, r:  val_28);
            CinemachineFreeLook.Orbit val_5 = new CinemachineFreeLook.Orbit(h:  val_28, r:  val_28);
            CinemachineFreeLook.Orbit val_6 = new CinemachineFreeLook.Orbit(h:  val_28, r:  val_26);
            int val_7 = this.sides + 1;
            if(this.VerticesDistances.Length == val_7)
            {
                goto label_5;
            }
            
            val_29 = null;
            this.VerticesDistances = val_29;
            if(this.sides < 1)
            {
                goto label_6;
            }
            
            val_30 = 0;
            val_31 = 1f;
            goto label_7;
            label_10:
            val_32 = this.VerticesDistances;
            val_30 = 1;
            label_7:
            val_32[val_30] = val_31;
            if((this.sides - 1) != val_30)
            {
                goto label_10;
            }
            
            label_5:
            val_33 = this.VerticesDistances;
            label_6:
            val_34 = this.VerticesDistances.Length;
            if(val_34 == 0)
            {
                    val_34 = this.VerticesDistances.Length;
            }
            
            val_35 = val_33[0];
            val_33[this.sides] = val_35;
            if(val_7 < 1)
            {
                    return;
            }
            
            float val_25 = (float)this.sides;
            val_25 = 360f / val_25;
            val_31 = 1152921505902205200;
            var val_33 = 0;
            val_35 = this.sides + 1;
            do
            {
                UnityEngine.Vector2 val_10 = this.rectTransform.pivot;
                float val_27 = this.size;
                float val_26 = this.VerticesDistances[val_33];
                UnityEngine.Vector2 val_12 = this.rectTransform.pivot;
                val_27 = val_10.x * val_27;
                float val_29 = this.rotation;
                float val_28 = 0f;
                val_28 = val_25 * val_28;
                val_29 = val_28 + val_29;
                val_28 = this.thickness;
                val_26 = -(val_27 * val_26);
                float val_13 = val_29 * 0.01745329f;
                CinemachineFreeLook.Orbit val_14 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
                CinemachineFreeLook.Orbit val_15 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
                CinemachineFreeLook.Orbit val_16 = new CinemachineFreeLook.Orbit(h:  1f, r:  0f);
                CinemachineFreeLook.Orbit val_17 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
                CinemachineFreeLook.Orbit val_20 = new CinemachineFreeLook.Orbit(h:  val_13 * val_26, r:  val_13 * val_26);
                if(this.fill != false)
            {
                    val_36 = val_1.y;
                UnityEngine.Vector2 val_21 = UnityEngine.Vector2.zero;
                UnityEngine.Vector2 val_22 = UnityEngine.Vector2.zero;
                val_37 = val_22.x;
                val_38 = val_22.y;
            }
            else
            {
                    float val_32 = val_12.x;
                float val_31 = this.size;
                val_31 = val_32 * val_31;
                val_31 = val_31 * this.VerticesDistances[val_33];
                val_32 = val_28 - val_31;
                val_31 = val_32 * val_13;
                val_32 = val_32 * val_13;
                CinemachineFreeLook.Orbit val_23 = new CinemachineFreeLook.Orbit(h:  val_31, r:  val_32);
                val_38 = val_2.y;
                val_37 = val_27;
                val_36 = val_1.y;
            }
            
                val_26 = val_20.m_Height;
                val_27 = val_23.m_Height;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_1.x;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24 = val_36;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_20.m_Height;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = val_23.m_Height;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = val_37;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_3C = val_38;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_14.m_Height;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_15.m_Height;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = val_16.m_Height;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = val_17.m_Height;
                val_33 = this.SetVbo(vertices:  null, uvs:  null);
                vh.AddUIVertexQuad(verts:  val_33);
                val_33 = val_33 + 1;
            }
            while(val_35 != val_33);
        
        }
    
    }

}
