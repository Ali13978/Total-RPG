using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class UILineRenderer : UIPrimitiveBase
    {
        // Fields
        private const float MIN_MITER_JOIN = 0.2617994;
        private const float MIN_BEVEL_NICE_JOIN = 0.5235988;
        private static readonly UnityEngine.Vector2 UV_TOP_LEFT;
        private static readonly UnityEngine.Vector2 UV_BOTTOM_LEFT;
        private static readonly UnityEngine.Vector2 UV_TOP_CENTER;
        private static readonly UnityEngine.Vector2 UV_BOTTOM_CENTER;
        private static readonly UnityEngine.Vector2 UV_TOP_RIGHT;
        private static readonly UnityEngine.Vector2 UV_BOTTOM_RIGHT;
        private static readonly UnityEngine.Vector2[] startUvs;
        private static readonly UnityEngine.Vector2[] middleUvs;
        private static readonly UnityEngine.Vector2[] endUvs;
        [UnityEngine.SerializeField]
        private UnityEngine.Rect m_UVRect;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector2[] m_points;
        public float LineThickness;
        public bool UseMargins;
        public UnityEngine.Vector2 Margin;
        public bool relativeSize;
        public bool LineList;
        public bool LineCaps;
        public UnityEngine.UI.Extensions.UILineRenderer.JoinType LineJoins;
        public UnityEngine.UI.Extensions.UILineRenderer.BezierType BezierMode;
        public int BezierSegmentsPerCurve;
        
        // Properties
        public UnityEngine.Rect uvRect { get; set; }
        public UnityEngine.Vector2[] Points { get; set; }
        
        // Methods
        public UILineRenderer()
        {
            this.LineThickness = 2f;
            this.BezierSegmentsPerCurve = 10;
            this.m_UVRect = 0;
            mem[1152921512758799872] = 1065353216;
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
            mem[1152921512759023880] = value.m_YMin;
            mem[1152921512759023884] = value.m_Width;
            mem[1152921512759023888] = value.m_Height;
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
            var val_72;
            UnityEngine.Vector2[] val_73;
            int val_74;
            float val_76;
            var val_77;
            var val_78;
            float val_79;
            float val_80;
            float val_81;
            var val_82;
            T val_83;
            T val_84;
            float val_85;
            float val_86;
            var val_87;
            T val_88;
            T val_89;
            float val_90;
            float val_91;
            var val_92;
            float val_93;
            val_73 = this.m_points;
            if(val_73 == null)
            {
                    return;
            }
            
            if((this.BezierMode == 0) || (this.m_points.Length < 4))
            {
                goto label_3;
            }
            
            UnityEngine.UI.Extensions.BezierPath val_1 = new UnityEngine.UI.Extensions.BezierPath();
            if(null != 0)
            {
                    SetControlPoints(newControlPoints:  val_73);
                val_74 = this.BezierSegmentsPerCurve;
            }
            else
            {
                    SetControlPoints(newControlPoints:  val_73);
                val_74 = this.BezierSegmentsPerCurve;
            }
            
            typeof(UnityEngine.UI.Extensions.BezierPath).__il2cppRuntimeField_10 = val_74;
            if(this.BezierMode == 3)
            {
                goto label_6;
            }
            
            if(this.BezierMode != 2)
            {
                goto label_7;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_2 = GetDrawingPoints0();
            goto label_9;
            label_6:
            System.Collections.Generic.List<UnityEngine.Vector2> val_3 = GetDrawingPoints1();
            goto label_9;
            label_7:
            label_9:
            val_73 = GetDrawingPoints2().ToArray();
            label_3:
            UnityEngine.Rect val_7 = this.rectTransform.rect;
            UnityEngine.Rect val_9 = this.rectTransform.rect;
            UnityEngine.Vector2 val_11 = this.rectTransform.pivot;
            UnityEngine.Rect val_13 = this.rectTransform.rect;
            float val_75 = val_13.m_XMin;
            UnityEngine.Vector2 val_15 = this.rectTransform.pivot;
            UnityEngine.Rect val_17 = this.rectTransform.rect;
            val_76 = 1f;
            float val_18 = (this.relativeSize == true) ? val_9.m_XMin : (val_76);
            float val_19 = (this.relativeSize == true) ? val_7.m_XMin : (val_76);
            if(this.UseMargins != false)
            {
                    val_76 = this.Margin;
                val_79 = 0.5f;
                val_78 = val_19 - val_76;
                val_77 = val_18 - val_17.m_Width;
                val_80 = val_76 * val_79;
                val_81 = val_17.m_Width * val_79;
            }
            else
            {
                    val_81 = 0f;
                val_80 = val_81;
            }
            
            val_75 = val_11.x * val_75;
            float val_20 = val_15.y * val_17.m_XMin;
            val_20 = val_81 - val_20;
            val_75 = val_80 - val_75;
            vh.Clear();
            System.Collections.Generic.List<UnityEngine.UIVertex[]> val_21 = null;
            val_72 = val_21;
            val_21 = new System.Collections.Generic.List<UnityEngine.UIVertex[]>();
            if(this.LineList == false)
            {
                goto label_20;
            }
            
            val_82 = 0;
            goto label_21;
            label_32:
            val_82 = 2;
            label_21:
            UnityEngine.UIVertex[] val_22 = val_82 + 1;
            if(val_22 >= val_5.Length)
            {
                goto label_35;
            }
            
            T val_76 = val_73[2];
            if(((val_22 - 1) + 1) < val_5.Length)
            {
                    val_83 = val_76;
                val_84 = val_76 >> 32;
            }
            else
            {
                    val_83 = val_76;
                val_84 = val_76;
            }
            
            T val_77 = val_73[(long)val_22];
            val_83 = val_19 * val_83;
            val_84 = val_18 * val_84;
            val_83 = val_75 + val_83;
            val_84 = val_20 + val_84;
            CinemachineFreeLook.Orbit val_26 = new CinemachineFreeLook.Orbit(h:  val_83, r:  val_84);
            T val_78 = val_77;
            T val_79 = val_77;
            val_78 = val_19 * val_78;
            val_79 = val_18 * val_79;
            val_78 = val_75 + val_78;
            val_85 = val_20 + val_79;
            CinemachineFreeLook.Orbit val_27 = new CinemachineFreeLook.Orbit(h:  val_78, r:  val_85);
            if(this.LineCaps != false)
            {
                    val_85 = val_26.m_Radius;
                val_86 = val_27.m_Radius;
                Add(item:  this.CreateLineCap(start:  new UnityEngine.Vector2() {x = val_26.m_Height, y = val_85}, end:  new UnityEngine.Vector2() {x = val_27.m_Height, y = val_86}, type:  0));
            }
            
            Add(item:  this.CreateLineSegment(start:  new UnityEngine.Vector2() {x = val_26.m_Height, y = val_26.m_Radius}, end:  new UnityEngine.Vector2() {x = val_27.m_Height, y = val_27.m_Radius}, type:  1));
            if(this.LineCaps == false)
            {
                goto label_32;
            }
            
            Add(item:  this.CreateLineCap(start:  new UnityEngine.Vector2() {x = val_26.m_Height, y = val_26.m_Radius}, end:  new UnityEngine.Vector2() {x = val_27.m_Height, y = val_27.m_Radius}, type:  2));
            goto label_32;
            label_20:
            val_87 = 0;
            goto label_33;
            label_47:
            val_87 = 1;
            label_33:
            var val_31 = val_87 + 1;
            if(val_31 >= val_5.Length)
            {
                goto label_35;
            }
            
            T val_80 = val_73[1];
            if(val_31 < val_5.Length)
            {
                    val_88 = val_80;
                val_89 = val_80 >> 32;
            }
            else
            {
                    val_88 = val_80;
                val_89 = val_80;
            }
            
            T val_81 = val_73[(long)val_31];
            val_88 = val_19 * val_88;
            val_89 = val_18 * val_89;
            val_88 = val_75 + val_88;
            val_89 = val_20 + val_89;
            CinemachineFreeLook.Orbit val_33 = new CinemachineFreeLook.Orbit(h:  val_88, r:  val_89);
            T val_82 = val_81;
            T val_83 = val_81;
            val_82 = val_19 * val_82;
            val_83 = val_18 * val_83;
            val_82 = val_75 + val_82;
            val_90 = val_20 + val_83;
            CinemachineFreeLook.Orbit val_34 = new CinemachineFreeLook.Orbit(h:  val_82, r:  val_90);
            if((val_87 == 0) && (this.LineCaps != false))
            {
                    val_90 = val_33.m_Radius;
                val_91 = val_34.m_Radius;
                Add(item:  this.CreateLineCap(start:  new UnityEngine.Vector2() {x = val_33.m_Height, y = val_90}, end:  new UnityEngine.Vector2() {x = val_34.m_Height, y = val_91}, type:  0));
            }
            
            Add(item:  this.CreateLineSegment(start:  new UnityEngine.Vector2() {x = val_33.m_Height, y = val_33.m_Radius}, end:  new UnityEngine.Vector2() {x = val_34.m_Height, y = val_34.m_Radius}, type:  1));
            if(this.LineCaps == false)
            {
                goto label_47;
            }
            
            int val_84 = val_5.Length;
            val_84 = val_84 - 1;
            if(val_31 != val_84)
            {
                goto label_47;
            }
            
            Add(item:  this.CreateLineCap(start:  new UnityEngine.Vector2() {x = val_33.m_Height, y = val_33.m_Radius}, end:  new UnityEngine.Vector2() {x = val_34.m_Height, y = val_34.m_Radius}, type:  2));
            goto label_47;
            label_35:
            val_92 = 0;
            goto label_48;
            label_134:
            vh.AddUIVertexQuad(verts:  val_22);
            val_92 = 1;
            label_48:
            if(val_92 >= Count)
            {
                    return;
            }
            
            if((this.LineList == true) || (val_92 >= (Count - 1)))
            {
                goto label_95;
            }
            
            UnityEngine.UIVertex[] val_41 = Item[1];
            UnityEngine.UIVertex[] val_42 = Item[1];
            UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_41[9], y = val_41[10], z = val_41[10]}, b:  new UnityEngine.Vector3() {x = val_42[19], y = val_42[19], z = val_42[20]});
            int val_44 = val_92 + 1;
            UnityEngine.UIVertex[] val_45 = Item[val_44];
            UnityEngine.UIVertex[] val_46 = Item[val_44];
            UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_45[19], y = val_45[19], z = val_45[20]}, b:  new UnityEngine.Vector3() {x = val_46[9], y = val_46[10], z = val_46[10]});
            UnityEngine.Vector2 val_48 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z});
            UnityEngine.Vector2 val_49 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z});
            float val_50 = UnityEngine.Vector2.Angle(from:  new UnityEngine.Vector2() {x = val_48.x, y = val_48.y}, to:  new UnityEngine.Vector2() {x = val_49.x, y = val_49.y});
            float val_51 = val_50 * 0.01745329f;
            UnityEngine.Vector3 val_52 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_50, y = 0.01745329f, z = val_49.x}, rhs:  new UnityEngine.Vector3() {x = val_50, y = 0.01745329f, z = val_49.x});
            float val_53 = UnityEngine.Mathf.Sign(f:  val_52.z);
            float val_97 = 0.5f;
            val_97 = val_51 * val_97;
            float val_98 = val_97;
            val_98 = val_98 + val_98;
            UnityEngine.UIVertex[] val_54 = Item[1];
            float val_55 = this.LineThickness / val_98;
            UnityEngine.Vector3 val_56 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_97, y = val_52.y, z = val_52.z}, d:  val_55);
            UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z}, d:  val_53);
            UnityEngine.Vector3 val_58 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_54[19], y = val_54[19], z = val_54[20]}, b:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z});
            UnityEngine.UIVertex[] val_59 = Item[1];
            UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z}, d:  val_55);
            UnityEngine.Vector3 val_61 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z}, d:  val_53);
            val_93 = val_59[28];
            UnityEngine.Vector3 val_62 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_93, y = val_59[29], z = val_59[29]}, b:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z});
            if(this.LineJoins == 0)
            {
                goto label_82;
            }
            
            if(this.LineJoins != 1)
            {
                goto label_95;
            }
            
            val_93 = val_62.x * 0.5f;
            if((val_55 >= 0) || (val_51 <= 0.2617994f))
            {
                goto label_82;
            }
            
            val_93 = val_93 * 0.5f;
            if(val_55 >= 0)
            {
                goto label_82;
            }
            
            UnityEngine.UIVertex[] val_63 = Item[1];
            val_63[19] = val_58.x;
            val_63[19] = val_58.y;
            val_63[20] = val_58.z;
            UnityEngine.UIVertex[] val_64 = Item[1];
            val_64[28] = val_62.x;
            val_64[29] = val_62.y;
            val_64[29] = val_62.z;
            UnityEngine.UIVertex[] val_65 = Item[val_44];
            val_65[0] = val_62.x;
            val_65[0] = val_62.y;
            val_65[1] = val_62.z;
            UnityEngine.UIVertex[] val_66 = Item[val_44];
            val_66[9] = val_58.x;
            val_66[10] = val_58.y;
            val_66[10] = val_58.z;
            goto label_95;
            label_82:
            val_62.x = val_62.x * 0.5f;
            if((val_55 < 0) && (val_51 > 0.5235988f))
            {
                    val_62.x = val_62.x * 0.5f;
                if(val_55 < 0)
            {
                    UnityEngine.UIVertex[] val_67 = Item[1];
                if(val_53 < 0)
            {
                    val_67[19] = val_58.x;
                val_67[19] = val_58.y;
                val_67[20] = val_58.z;
                UnityEngine.UIVertex[] val_68 = Item[val_44];
                val_68[9] = val_58.x;
                val_68[10] = val_58.y;
                val_68[10] = val_58.z;
            }
            else
            {
                    val_67[28] = val_62.x;
                val_67[29] = val_62.y;
                val_67[29] = val_62.z;
                UnityEngine.UIVertex[] val_69 = Item[val_44];
                val_69[0] = val_62.x;
                val_69[0] = val_62.y;
                val_69[1] = val_62.z;
            }
            
            }
            
            }
            
            vh.AddUIVertexQuad(verts:  null);
            label_95:
            UnityEngine.UIVertex[] val_74 = Item[1];
            if(vh != null)
            {
                goto label_134;
            }
            
            goto label_134;
        }
        private UnityEngine.UIVertex[] CreateLineCap(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.UI.Extensions.UILineRenderer.SegmentType type)
        {
            var val_11;
            if(type == 2)
            {
                goto label_1;
            }
            
            if(type != 0)
            {
                goto label_2;
            }
            
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = end.x, y = end.y}, b:  new UnityEngine.Vector2() {x = start.x, y = start.y});
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  this.LineThickness);
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  2f);
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = start.x, y = start.y}, b:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            UnityEngine.UIVertex[] val_5 = this.CreateLineSegment(start:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, end:  new UnityEngine.Vector2() {x = start.x, y = start.y}, type:  0);
            return (UnityEngine.UIVertex[])val_11;
            label_1:
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = end.x, y = end.y}, b:  new UnityEngine.Vector2() {x = start.x, y = start.y});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, d:  this.LineThickness);
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, d:  2f);
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = end.x, y = end.y}, b:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            UnityEngine.UIVertex[] val_10 = this.CreateLineSegment(start:  new UnityEngine.Vector2() {x = end.x, y = end.y}, end:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, type:  2);
            return (UnityEngine.UIVertex[])val_11;
            label_2:
            UnityEngine.Debug.LogError(message:  0);
            val_11 = 0;
            return (UnityEngine.UIVertex[])val_11;
        }
        private UnityEngine.UIVertex[] CreateLineSegment(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.UI.Extensions.UILineRenderer.SegmentType type)
        {
            var val_11;
            UnityEngine.Vector2[] val_14;
            val_11 = null;
            val_11 = null;
            if(type == 2)
            {
                goto label_3;
            }
            
            if(type != 0)
            {
                goto label_4;
            }
            
            val_14 = 1152921504993591344;
            goto label_10;
            label_3:
            val_14 = 1152921504993591360;
            goto label_10;
            label_4:
            val_14 = 1152921504993591352;
            label_10:
            float val_1 = start.y - end.y;
            float val_2 = end.x - start.x;
            CinemachineFreeLook.Orbit val_3 = new CinemachineFreeLook.Orbit(h:  val_1, r:  val_2);
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1, y = val_2}, d:  this.LineThickness);
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, d:  2f);
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = start.x, y = start.y}, b:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = start.x, y = start.y}, b:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = end.x, y = end.y}, b:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = end.x, y = end.y}, b:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_6.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24 = val_6.y;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_7.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_2C = val_7.y;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = val_8.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_34 = val_8.y;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = val_9.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_3C = val_9.y;
            return (UnityEngine.UIVertex[])this.SetVbo(vertices:  null, uvs:  val_14);
        }
        private static UILineRenderer()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT = val_1.x;
            UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_4 = val_1.y;
            CinemachineFreeLook.Orbit val_2 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
            UnityEngine.UI.Extensions.UILineRenderer.UV_BOTTOM_LEFT = val_2.m_Height;
            UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_C = val_2.m_Height >> 32;
            CinemachineFreeLook.Orbit val_4 = new CinemachineFreeLook.Orbit(h:  0.5f, r:  0f);
            UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_CENTER = val_4.m_Height;
            UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_14 = val_4.m_Height >> 32;
            CinemachineFreeLook.Orbit val_6 = new CinemachineFreeLook.Orbit(h:  0.5f, r:  1f);
            UnityEngine.UI.Extensions.UILineRenderer.UV_BOTTOM_CENTER = val_6.m_Height;
            UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_1C = val_6.m_Height >> 32;
            CinemachineFreeLook.Orbit val_8 = new CinemachineFreeLook.Orbit(h:  1f, r:  0f);
            UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_RIGHT = val_8.m_Height;
            UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_24 = val_8.m_Height >> 32;
            CinemachineFreeLook.Orbit val_10 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
            UnityEngine.UI.Extensions.UILineRenderer.UV_BOTTOM_RIGHT = val_10.m_Height;
            UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_2C = val_10.m_Height >> 32;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24 = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_4;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = UnityEngine.UI.Extensions.UILineRenderer.UV_BOTTOM_LEFT;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_2C = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_C;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = UnityEngine.UI.Extensions.UILineRenderer.UV_BOTTOM_CENTER;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_34 = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_1C;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_CENTER;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_3C = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_14;
            UnityEngine.UI.Extensions.UILineRenderer.startUvs = null;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_CENTER;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24 = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_14;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = UnityEngine.UI.Extensions.UILineRenderer.UV_BOTTOM_CENTER;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_2C = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_1C;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = UnityEngine.UI.Extensions.UILineRenderer.UV_BOTTOM_CENTER;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_34 = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_1C;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_CENTER;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_3C = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_14;
            UnityEngine.UI.Extensions.UILineRenderer.middleUvs = null;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_CENTER;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24 = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_14;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = UnityEngine.UI.Extensions.UILineRenderer.UV_BOTTOM_CENTER;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_2C = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_1C;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_30 = UnityEngine.UI.Extensions.UILineRenderer.UV_BOTTOM_RIGHT;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_34 = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_2C;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_RIGHT;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_3C = UnityEngine.UI.Extensions.UILineRenderer.UV_TOP_LEFT.__il2cppRuntimeField_24;
            UnityEngine.UI.Extensions.UILineRenderer.endUvs = null;
        }
    
    }

}
