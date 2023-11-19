using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class UILineTextureRenderer : UIPrimitiveBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Rect m_UVRect;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector2[] m_points;
        public float LineThickness;
        public bool UseMargins;
        public UnityEngine.Vector2 Margin;
        public bool relativeSize;
        
        // Properties
        public UnityEngine.Rect uvRect { get; set; }
        public UnityEngine.Vector2[] Points { get; set; }
        
        // Methods
        public UILineTextureRenderer()
        {
            this.LineThickness = 2f;
            this.m_UVRect = 0;
            mem[1152921512762294400] = 1065353216;
            this = new UnityEngine.UI.MaskableGraphic();
        }
        public UnityEngine.Rect get_uvRect()
        {
            return new UnityEngine.Rect() {m_XMin = this.m_UVRect};
        }
        public void set_uvRect(UnityEngine.Rect value)
        {
            if((UnityEngine.Rect.op_Equality(lhs:  new UnityEngine.Rect() {m_XMin = this.m_UVRect, m_YMin = V5.16B, m_Width = V6.16B, m_Height = V7.16B}, rhs:  new UnityEngine.Rect() {m_XMin = value.m_XMin, m_YMin = value.m_YMin, m_Width = value.m_Width, m_Height = value.m_Height})) != false)
            {
                    return;
            }
            
            this.m_UVRect = value;
            mem[1152921512762518408] = value.m_YMin;
            mem[1152921512762518412] = value.m_Width;
            mem[1152921512762518416] = value.m_Height;
            this.SetVerticesDirty();
        }
        public UnityEngine.Vector2[] get_Points()
        {
            return (UnityEngine.Vector2[])this.m_points;
        }
        public void set_Points(UnityEngine.Vector2[] value)
        {
            if(this.m_points == value)
            {
                    return;
            }
            
            this.m_points = value;
            this.SetAllDirty();
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_73;
            float val_74;
            var val_75;
            UnityEngine.Vector2[] val_76;
            float val_79;
            float val_81;
            if(this.m_points != null)
            {
                    if(this.m_points.Length > 1)
            {
                goto label_2;
            }
            
            }
            
            CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_1.m_Height;
            CinemachineFreeLook.Orbit val_2 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_2.m_Height;
            this.m_points = null;
            label_2:
            UnityEngine.Rect val_4 = this.rectTransform.rect;
            UnityEngine.Rect val_6 = this.rectTransform.rect;
            UnityEngine.Vector2 val_8 = this.rectTransform.pivot;
            UnityEngine.Rect val_10 = this.rectTransform.rect;
            UnityEngine.Vector2 val_12 = this.rectTransform.pivot;
            float val_77 = val_12.y;
            UnityEngine.Rect val_14 = this.rectTransform.rect;
            null = new System.Collections.Generic.List<UnityEngine.Vector2>();
            Add(item:  new UnityEngine.Vector2() {x = this.m_points[0], y = this.m_points[0]});
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 1.041983E-37f, y = 0f}, b:  new UnityEngine.Vector2() {x = 8.96831E-44f, y = 0f});
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, d:  24f);
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.m_points[0], y = this.m_points[0]}, b:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            val_77 = val_77 * val_14.m_XMin;
            Add(item:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            goto label_24;
            label_30:
            Add(item:  new UnityEngine.Vector2() {x = this.m_points[0], y = this.m_points[0]});
            label_24:
            int val_80 = this.m_points.Length;
            val_80 = val_80 - 1;
            if(2 >= val_80)
            {
                goto label_26;
            }
            
            if(2 < this.m_points.Length)
            {
                goto label_30;
            }
            
            goto label_30;
            label_26:
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = mem[58034200], y = mem[58034204]}, b:  new UnityEngine.Vector2() {x = mem[58034192], y = mem[58034196]});
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y}, d:  24f);
            var val_81 = -4294967296;
            val_81 = val_81 + ((this.m_points.Length) << 32);
            val_73 = val_23.y;
            UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.m_points[val_81 >> 32], y = this.m_points[val_81 >> 32]}, b:  new UnityEngine.Vector2() {x = val_23.x, y = val_73});
            Add(item:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
            var val_84 = -4294967296;
            val_84 = val_84 + ((this.m_points.Length) << 32);
            UnityEngine.Vector2 val_86 = this.m_points[val_84 >> 32];
            Add(item:  new UnityEngine.Vector2() {x = this.m_points[val_84 >> 32], y = val_86});
            T[] val_27 = ToArray();
            if(this.UseMargins != false)
            {
                    float val_87 = (this.relativeSize == true) ? val_4.m_XMin : 1f;
                float val_28 = this.Margin * 0.5f;
                val_87 = val_87 - this.Margin;
                float val_29 = val_86 * 0.5f;
                val_73 = ((this.relativeSize == true) ? val_6.m_XMin : 1f) - val_86;
            }
            
            vh.Clear();
            float val_30 = 0f - val_77;
            float val_31 = 0f - (val_8.x * val_10.m_XMin);
            UnityEngine.Vector2 val_32 = UnityEngine.Vector2.zero;
            UnityEngine.Vector2 val_33 = UnityEngine.Vector2.zero;
            val_74 = val_33.x;
            val_75 = 0;
            goto label_49;
            label_90:
            vh.AddUIVertexQuad(verts:  1152921511095450080);
            val_75 = 1;
            val_74 = val_77;
            label_49:
            if(2 >= val_27.Length)
            {
                    return;
            }
            
            T val_88 = val_27[1];
            if(2 < val_27.Length)
            {
                    T val_34 = val_88 >> 32;
            }
            else
            {
                    T val_90 = val_88;
                T val_91 = val_88;
            }
            
            T val_89 = val_27[2];
            val_90 = val_87 * val_90;
            val_91 = val_73 * val_91;
            val_90 = val_31 + val_90;
            val_91 = val_30 + val_91;
            CinemachineFreeLook.Orbit val_35 = new CinemachineFreeLook.Orbit(h:  val_90, r:  val_91);
            T val_92 = val_89;
            T val_93 = val_89;
            val_92 = val_87 * val_92;
            val_93 = val_73 * val_93;
            val_92 = val_31 + val_92;
            val_93 = val_30 + val_93;
            CinemachineFreeLook.Orbit val_36 = new CinemachineFreeLook.Orbit(h:  val_92, r:  val_93);
            float val_37 = val_36.m_Radius - val_35.m_Radius;
            float val_38 = val_36.m_Height - val_35.m_Height;
            val_37 = val_37 * 180f;
            float val_94 = this.LineThickness;
            val_37 = val_37 / 3.141593f;
            val_94 = val_94 * (-0.5f);
            CinemachineFreeLook.Orbit val_39 = new CinemachineFreeLook.Orbit(h:  0f, r:  val_94);
            UnityEngine.Vector2 val_40 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_35.m_Height, y = val_35.m_Radius}, b:  new UnityEngine.Vector2() {x = val_39.m_Height, y = val_39.m_Radius});
            float val_95 = 0.5f;
            val_95 = this.LineThickness * val_95;
            CinemachineFreeLook.Orbit val_41 = new CinemachineFreeLook.Orbit(h:  0f, r:  val_95);
            UnityEngine.Vector2 val_42 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_35.m_Height, y = val_35.m_Radius}, b:  new UnityEngine.Vector2() {x = val_41.m_Height, y = val_41.m_Radius});
            CinemachineFreeLook.Orbit val_44 = new CinemachineFreeLook.Orbit(h:  0f, r:  this.LineThickness * val_95);
            UnityEngine.Vector2 val_45 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_36.m_Height, y = val_36.m_Radius}, b:  new UnityEngine.Vector2() {x = val_44.m_Height, y = val_44.m_Radius});
            CinemachineFreeLook.Orbit val_47 = new CinemachineFreeLook.Orbit(h:  0f, r:  this.LineThickness * (-0.5f));
            UnityEngine.Vector2 val_48 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_36.m_Height, y = val_36.m_Radius}, b:  new UnityEngine.Vector2() {x = val_47.m_Height, y = val_47.m_Radius});
            UnityEngine.Vector3 val_49 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_40.x, y = val_40.y});
            UnityEngine.Vector3 val_50 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_35.m_Height, y = val_35.m_Radius});
            UnityEngine.Vector3 val_51 = 0.RotatePointAroundPivot(point:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, pivot:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z}, angles:  new UnityEngine.Vector3() {x = 0f, y = 0f});
            UnityEngine.Vector2 val_52 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z});
            UnityEngine.Vector3 val_53 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_42.x, y = val_42.y});
            UnityEngine.Vector3 val_54 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_35.m_Height, y = val_35.m_Radius});
            UnityEngine.Vector3 val_55 = 0.RotatePointAroundPivot(point:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z}, pivot:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, angles:  new UnityEngine.Vector3() {x = 0f, y = 0f});
            UnityEngine.Vector2 val_56 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z});
            UnityEngine.Vector3 val_57 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_45.x, y = val_45.y});
            UnityEngine.Vector3 val_58 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_36.m_Height, y = val_36.m_Radius});
            UnityEngine.Vector3 val_59 = 0.RotatePointAroundPivot(point:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z}, pivot:  new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z}, angles:  new UnityEngine.Vector3() {x = 0f, y = 0f});
            UnityEngine.Vector2 val_60 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z});
            UnityEngine.Vector3 val_61 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_48.x, y = val_48.y});
            UnityEngine.Vector3 val_62 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_36.m_Height, y = val_36.m_Radius});
            UnityEngine.Vector3 val_63 = 0.RotatePointAroundPivot(point:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z}, pivot:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z}, angles:  new UnityEngine.Vector3() {x = 0f, y = 0f});
            UnityEngine.Vector2 val_64 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z});
            UnityEngine.Vector2 val_65 = UnityEngine.Vector2.zero;
            CinemachineFreeLook.Orbit val_66 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
            CinemachineFreeLook.Orbit val_67 = new CinemachineFreeLook.Orbit(h:  0.5f, r:  0f);
            CinemachineFreeLook.Orbit val_68 = new CinemachineFreeLook.Orbit(h:  0.5f, r:  1f);
            CinemachineFreeLook.Orbit val_69 = new CinemachineFreeLook.Orbit(h:  1f, r:  0f);
            CinemachineFreeLook.Orbit val_70 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
            val_76 = null;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_67.m_Height;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_68.m_Height;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = val_68.m_Height;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = val_67.m_Height;
            if(2 >= 2)
            {
                    typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_32.x;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24 = val_20.x;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_74;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_2C = val_32.y;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = val_52.x;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_34 = val_52.y;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = val_56.x;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_3C = val_56.y;
                vh.AddUIVertexQuad(verts:  this.SetVbo(vertices:  null, uvs:  val_76));
            }
            
            if(val_75 == 0)
            {
                goto label_71;
            }
            
            int val_96 = val_27.Length;
            val_79 = val_60.y;
            val_96 = val_96 - 1;
            if(2 != val_96)
            {
                goto label_73;
            }
            
            val_76 = null;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_67.m_Height;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_68.m_Height;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = val_70.m_Height;
            val_81 = val_69.m_Height;
            goto label_78;
            label_71:
            val_76 = null;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_65.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24 = val_65.y;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_66.m_Height;
            val_79 = val_60.y;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = val_68.m_Height;
            val_81 = val_67.m_Height;
            label_78:
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = val_81;
            label_73:
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_52.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24 = val_52.y;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_56.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_2C = val_56.y;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = val_60.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_34 = val_79;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = val_64.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_3C = val_64.y;
            UnityEngine.UIVertex[] val_72 = this.SetVbo(vertices:  null, uvs:  val_76);
            if(vh != null)
            {
                goto label_90;
            }
            
            goto label_90;
        }
        public UnityEngine.Vector3 RotatePointAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Vector3 angles)
        {
            float val_1;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = pivot.x, y = pivot.y, z = pivot.z});
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = angles.x, y = val_1, z = angles.y});
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, point:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = pivot.x, y = pivot.y, z = pivot.z});
        }
    
    }

}
