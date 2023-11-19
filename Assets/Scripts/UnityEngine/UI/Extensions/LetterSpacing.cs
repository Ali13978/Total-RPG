using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class LetterSpacing : BaseMeshEffect
    {
        // Fields
        [UnityEngine.SerializeField]
        private float m_spacing;
        
        // Properties
        public float spacing { get; set; }
        
        // Methods
        protected LetterSpacing()
        {
        
        }
        public float get_spacing()
        {
            return (float)this.m_spacing;
        }
        public void set_spacing(float value)
        {
            float val_10;
            var val_11;
            val_10 = value;
            val_11 = this;
            if(this.m_spacing == val_10)
            {
                    return;
            }
            
            this.m_spacing = val_10;
            if(0 == this.graphic)
            {
                    return;
            }
            
            UnityEngine.UI.Graphic val_3 = this.graphic;
            val_11 = ???;
            val_10 = ???;
            goto typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_2D0;
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            var val_8;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            float val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            float val_38;
            float val_39;
            float val_42;
            float val_43;
            float val_44;
            float val_45;
            float val_46;
            float val_47;
            float val_48;
            float val_50;
            float val_51;
            float val_52;
            float val_53;
            float val_54;
            float val_55;
            float val_56;
            float val_58;
            float val_59;
            float val_60;
            float val_61;
            float val_62;
            float val_63;
            float val_64;
            float val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            float val_71;
            float val_72;
            UnityEngine.UI.VertexHelper val_83;
            System.String[] val_84;
            System.String[] val_85;
            float val_86;
            var val_87;
            int val_88;
            var val_89;
            float val_91;
            val_84 = this;
            if(this.IsActive() == false)
            {
                    return;
            }
            
            System.Collections.Generic.List<UnityEngine.UIVertex> val_2 = new System.Collections.Generic.List<UnityEngine.UIVertex>();
            val_83 = vh;
            val_83.GetUIVertexStream(stream:  val_2);
            UnityEngine.UI.Text val_3 = this.GetComponent<UnityEngine.UI.Text>();
            if(0 == val_3)
            {
                    UnityEngine.Debug.LogWarning(message:  0);
                return;
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_20 = 10;
            val_84 = val_3.Split(separator:  null);
            val_85 = val_3.fontSize;
            if(val_3.alignment > 8)
            {
                goto label_18;
            }
            
            if((25811408 + (val_7) << 2) > 9)
            {
                goto label_16;
            }
            
            if(((25811408 + (val_7) << 2) == 0) || ((25811408 + (val_7) << 2) == 9))
            {
                goto label_18;
            }
            
            return;
            label_16:
            if((25811408 + (val_7) << 2) != 11)
            {
                    if((25811408 + (val_7) << 2) != 10)
            {
                    return;
            }
            
                val_86 = 0.5f;
            }
            else
            {
                    val_86 = 1f;
            }
            
            label_18:
            val_87 = 1152921512713570672;
            float val_81 = (float)val_85;
            val_81 = this.m_spacing * val_81;
            val_81 = val_81 / 100f;
            val_88 = 0;
            val_85 = val_84;
            goto label_23;
            label_30:
            val_85 = val_84;
            UnityEngine.UI.VertexHelper val_82 = 0;
            val_88 = val_8 + 1;
            val_82 = val_82 + val_83;
            val_82 = val_82 + 1;
            label_23:
            if(val_88 >= (val_5 + 24))
            {
                goto label_25;
            }
            
            System.String[] val_9 = val_85 + (((long)(int)((val_8 + 1))) << 3);
            val_89 = mem[(val_5 + ((long)(int)((val_8 + 1))) << 3) + 32];
            val_89 = (val_5 + ((long)(int)((val_8 + 1))) << 3) + 32;
            val_8 = val_88;
            float val_83 = (float)val_89.Length - 1;
            val_83 = val_81 * val_83;
            val_83 = 0;
            val_85 = val_82 * 6;
            val_83 = val_86 * val_83;
            goto label_28;
            label_47:
            val_87 = 1152921512713570672;
            val_89 = val_89;
            UnityEngine.UIVertex val_16 = Item[val_88];
            val_83 = 1;
            val_85 = val_85 + 6;
            label_28:
            if(val_83 >= val_89.Length)
            {
                goto label_30;
            }
            
            UnityEngine.UI.VertexHelper val_18 = val_85 + 5;
            if(val_18 > (Count - 1))
            {
                    return;
            }
            
            UnityEngine.UI.VertexHelper val_21 = val_85 + 1;
            UnityEngine.UI.VertexHelper val_22 = val_85 + 2;
            UnityEngine.UIVertex val_23 = Item[val_85];
            UnityEngine.UI.VertexHelper val_31 = val_85 + 3;
            UnityEngine.UIVertex val_32 = Item[val_21];
            UnityEngine.UI.VertexHelper val_40 = val_85 + 4;
            UnityEngine.UIVertex val_41 = Item[val_22];
            UnityEngine.UIVertex val_49 = Item[val_31];
            UnityEngine.UIVertex val_57 = Item[val_40];
            UnityEngine.UIVertex val_65 = Item[val_18];
            UnityEngine.Vector3 val_73 = UnityEngine.Vector3.right;
            float val_84 = 1f;
            val_84 = val_81 * val_84;
            val_84 = val_84 - val_83;
            UnityEngine.Vector3 val_74 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_73.x, y = val_73.y, z = val_73.z}, d:  val_84);
            UnityEngine.Vector3 val_75 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24, y = val_29, z = val_30}, b:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z});
            UnityEngine.Vector3 val_76 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_33, y = val_38, z = val_39}, b:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z});
            UnityEngine.Vector3 val_77 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_42, y = val_47, z = val_48}, b:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z});
            UnityEngine.Vector3 val_78 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_50, y = val_55, z = val_56}, b:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z});
            UnityEngine.Vector3 val_79 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_58, y = val_63, z = val_64}, b:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z});
            UnityEngine.Vector3 val_80 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_66, y = val_71, z = val_72}, b:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z});
            if(null != 0)
            {
                    set_Item(index:  val_85, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_75.x, y = val_75.y, z = val_75.z}, normal = new UnityEngine.Vector3() {x = val_27, y = val_27, z = val_27}, color = new UnityEngine.Color32() {r = val_27, g = val_27, b = val_27, a = val_27}, uv0 = new UnityEngine.Vector2() {x = val_28, y = val_28}, uv1 = new UnityEngine.Vector2() {x = val_28, y = val_28}, uv2 = new UnityEngine.Vector2() {x = val_25, y = val_25}, uv3 = new UnityEngine.Vector2() {x = val_25, y = val_25}, tangent = new UnityEngine.Vector4() {x = val_26, y = val_26, z = val_26, w = val_26}});
            }
            else
            {
                    set_Item(index:  val_85, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_75.x, y = val_75.y, z = val_75.z}, normal = new UnityEngine.Vector3() {x = val_27, y = val_27, z = val_27}, color = new UnityEngine.Color32() {r = val_27, g = val_27, b = val_27, a = val_27}, uv0 = new UnityEngine.Vector2() {x = val_28, y = val_28}, uv1 = new UnityEngine.Vector2() {x = val_28, y = val_28}, uv2 = new UnityEngine.Vector2() {x = val_25, y = val_25}, uv3 = new UnityEngine.Vector2() {x = val_25, y = val_25}, tangent = new UnityEngine.Vector4() {x = val_26, y = val_26, z = val_26, w = val_26}});
            }
            
            set_Item(index:  val_21, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_76.x, y = val_76.y, z = val_76.z}, normal = new UnityEngine.Vector3() {x = val_36, y = val_36, z = val_36}, color = new UnityEngine.Color32() {r = val_36, g = val_36, b = val_36, a = val_36}, uv0 = new UnityEngine.Vector2() {x = val_37, y = val_37}, uv1 = new UnityEngine.Vector2() {x = val_37, y = val_37}, uv2 = new UnityEngine.Vector2() {x = val_34, y = val_34}, uv3 = new UnityEngine.Vector2() {x = val_34, y = val_34}, tangent = new UnityEngine.Vector4() {x = val_35, y = val_35, z = val_35, w = val_35}});
            if(null != 0)
            {
                    val_91 = val_77.z;
                set_Item(index:  val_22, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_77.x, y = val_77.y, z = val_91}, normal = new UnityEngine.Vector3() {x = val_45, y = val_45, z = val_45}, color = new UnityEngine.Color32() {r = val_45, g = val_45, b = val_45, a = val_45}, uv0 = new UnityEngine.Vector2() {x = val_46, y = val_46}, uv1 = new UnityEngine.Vector2() {x = val_46, y = val_46}, uv2 = new UnityEngine.Vector2() {x = val_43, y = val_43}, uv3 = new UnityEngine.Vector2() {x = val_43, y = val_43}, tangent = new UnityEngine.Vector4() {x = val_44, y = val_44, z = val_44, w = val_44}});
            }
            else
            {
                    val_91 = val_77.z;
                set_Item(index:  val_22, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_77.x, y = val_77.y, z = val_91}, normal = new UnityEngine.Vector3() {x = val_45, y = val_45, z = val_45}, color = new UnityEngine.Color32() {r = val_45, g = val_45, b = val_45, a = val_45}, uv0 = new UnityEngine.Vector2() {x = val_46, y = val_46}, uv1 = new UnityEngine.Vector2() {x = val_46, y = val_46}, uv2 = new UnityEngine.Vector2() {x = val_43, y = val_43}, uv3 = new UnityEngine.Vector2() {x = val_43, y = val_43}, tangent = new UnityEngine.Vector4() {x = val_44, y = val_44, z = val_44, w = val_44}});
            }
            
            set_Item(index:  val_31, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_78.x, y = val_78.y, z = val_78.z}, normal = new UnityEngine.Vector3() {x = val_53, y = val_53, z = val_53}, color = new UnityEngine.Color32() {r = val_53, g = val_53, b = val_53, a = val_53}, uv0 = new UnityEngine.Vector2() {x = val_54, y = val_54}, uv1 = new UnityEngine.Vector2() {x = val_54, y = val_54}, uv2 = new UnityEngine.Vector2() {x = val_51, y = val_51}, uv3 = new UnityEngine.Vector2() {x = val_51, y = val_51}, tangent = new UnityEngine.Vector4() {x = val_52, y = val_52, z = val_52, w = val_52}});
            if(null == 0)
            {
                goto label_45;
            }
            
            set_Item(index:  val_40, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_79.x, y = val_79.y, z = val_79.z}, normal = new UnityEngine.Vector3() {x = val_61, y = val_61, z = val_61}, color = new UnityEngine.Color32() {r = val_61, g = val_61, b = val_61, a = val_61}, uv0 = new UnityEngine.Vector2() {x = val_62, y = val_62}, uv1 = new UnityEngine.Vector2() {x = val_62, y = val_62}, uv2 = new UnityEngine.Vector2() {x = val_59, y = val_59}, uv3 = new UnityEngine.Vector2() {x = val_59, y = val_59}, tangent = new UnityEngine.Vector4() {x = val_60, y = val_60, z = val_60, w = val_60}});
            val_12 = val_67;
            val_13 = val_68;
            val_14 = val_69;
            val_15 = val_70;
            goto label_47;
            label_45:
            set_Item(index:  val_40, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_79.x, y = val_79.y, z = val_79.z}, normal = new UnityEngine.Vector3() {x = val_61, y = val_61, z = val_61}, color = new UnityEngine.Color32() {r = val_61, g = val_61, b = val_61, a = val_61}, uv0 = new UnityEngine.Vector2() {x = val_62, y = val_62}, uv1 = new UnityEngine.Vector2() {x = val_62, y = val_62}, uv2 = new UnityEngine.Vector2() {x = val_59, y = val_59}, uv3 = new UnityEngine.Vector2() {x = val_59, y = val_59}, tangent = new UnityEngine.Vector4() {x = val_60, y = val_60, z = val_60, w = val_60}});
            val_12 = val_67;
            val_13 = val_68;
            val_14 = val_69;
            val_15 = val_70;
            goto label_47;
            label_25:
            val_83 = val_83;
            if(val_83 != 0)
            {
                    val_83.Clear();
            }
            else
            {
                    0.Clear();
            }
            
            val_83.AddUIVertexTriangleStream(verts:  val_2);
        }
    
    }

}
