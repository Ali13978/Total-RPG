using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class Gradient2 : BaseMeshEffect
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Extensions.Gradient2.Type _gradientType;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Extensions.Gradient2.Blend _blendMode;
        [UnityEngine.SerializeField]
        [UnityEngine.RangeAttribute]
        private float _offset;
        [UnityEngine.SerializeField]
        private UnityEngine.Gradient _effectGradient;
        
        // Properties
        public UnityEngine.UI.Extensions.Gradient2.Blend BlendMode { get; set; }
        public UnityEngine.Gradient EffectGradient { get; set; }
        public UnityEngine.UI.Extensions.Gradient2.Type GradientType { get; set; }
        public float Offset { get; set; }
        
        // Methods
        public Gradient2()
        {
            this._blendMode = 2;
            UnityEngine.Color val_2 = UnityEngine.Color.black;
            typeof(UnityEngine.GradientColorKey[]).__il2cppRuntimeField_30 = 0;
            typeof(UnityEngine.GradientColorKey[]).__il2cppRuntimeField_20 = 0;
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            typeof(UnityEngine.GradientColorKey[]).__il2cppRuntimeField_44 = 0;
            typeof(UnityEngine.GradientColorKey[]).__il2cppRuntimeField_34 = 0;
            colorKeys = null;
            this._effectGradient = new UnityEngine.Gradient();
        }
        public UnityEngine.UI.Extensions.Gradient2.Blend get_BlendMode()
        {
            return (Blend)this._blendMode;
        }
        public void set_BlendMode(UnityEngine.UI.Extensions.Gradient2.Blend value)
        {
            this._blendMode = value;
        }
        public UnityEngine.Gradient get_EffectGradient()
        {
            return (UnityEngine.Gradient)this._effectGradient;
        }
        public void set_EffectGradient(UnityEngine.Gradient value)
        {
            this._effectGradient = value;
        }
        public UnityEngine.UI.Extensions.Gradient2.Type get_GradientType()
        {
            return (Type)this._gradientType;
        }
        public void set_GradientType(UnityEngine.UI.Extensions.Gradient2.Type value)
        {
            this._gradientType = value;
        }
        public float get_Offset()
        {
            return (float)this._offset;
        }
        public void set_Offset(float value)
        {
            this._offset = value;
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper helper)
        {
            float val_6;
            float val_10;
            float val_12;
            byte val_17;
            float val_19;
            byte val_27;
            float val_29;
            System.Collections.Generic.List<UnityEngine.UIVertex> val_34;
            var val_35;
            int val_36;
            int val_37;
            if(this.IsActive() == false)
            {
                    return;
            }
            
            if(helper.currentVertCount == 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<UnityEngine.UIVertex> val_3 = null;
            val_34 = val_3;
            val_3 = new System.Collections.Generic.List<UnityEngine.UIVertex>();
            helper.GetUIVertexStream(stream:  val_34);
            val_35 = Count;
            if(this._gradientType == 1)
            {
                goto label_6;
            }
            
            if(this._gradientType != 0)
            {
                    return;
            }
            
            UnityEngine.UIVertex val_5 = Item[0];
            UnityEngine.UIVertex val_7 = Item[0];
            goto label_14;
            label_6:
            UnityEngine.UIVertex val_9 = Item[0];
            UnityEngine.UIVertex val_11 = Item[0];
            goto label_28;
            label_19:
            val_36 = val_35 + 1;
            goto label_14;
            label_20:
            if(val_36 <= 0)
            {
                goto label_15;
            }
            
            UnityEngine.UIVertex val_13 = Item[val_36];
            if(val_6 > val_12)
            {
                goto label_17;
            }
            
            val_36 = val_36 - 1;
            if(val_6 >= 0)
            {
                goto label_20;
            }
            
            goto label_19;
            label_17:
            label_14:
            val_36 = val_36 - 1;
            goto label_20;
            label_15:
            val_34 = 0;
            goto label_21;
            label_27:
            helper.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  0);
            val_34 = 1;
            label_21:
            if(val_34 >= helper.currentVertCount)
            {
                    return;
            }
            
            helper.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  1);
            UnityEngine.Color val_18 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            float val_20 = val_19 - V0.16B;
            val_20 = (1f / (val_12 - V0.16B)) * val_20;
            val_20 = val_20 - this._offset;
            UnityEngine.Color val_21 = this._effectGradient.Evaluate(time:  val_20);
            UnityEngine.Color val_22 = this.BlendColor(colorA:  new UnityEngine.Color() {r = val_18.r, g = val_18.g, b = val_18.b, a = val_18.a}, colorB:  new UnityEngine.Color() {r = val_21.r, g = val_21.g, b = val_21.b, a = val_21.a});
            UnityEngine.Color32 val_23 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_22.r, g = val_22.g, b = val_22.b, a = val_22.a});
            val_17 = val_23.r;
            if(helper != null)
            {
                goto label_27;
            }
            
            goto label_27;
            label_33:
            val_37 = this._effectGradient + 1;
            goto label_28;
            label_34:
            if(val_37 <= 0)
            {
                goto label_29;
            }
            
            UnityEngine.UIVertex val_24 = val_34.Item[val_37];
            if(val_10 > val_18.r)
            {
                goto label_31;
            }
            
            val_37 = val_37 - 1;
            if(val_10 >= 0)
            {
                goto label_34;
            }
            
            goto label_33;
            label_31:
            label_28:
            val_37 = val_37 - 1;
            goto label_34;
            label_29:
            val_22.r = val_18.r - val_22.r;
            val_34 = 0;
            goto label_35;
            label_41:
            helper.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  0);
            val_34 = 1;
            label_35:
            if(val_34 >= helper.currentVertCount)
            {
                    return;
            }
            
            helper.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  1);
            UnityEngine.Color val_28 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            float val_30 = val_29 - val_22.r;
            val_30 = (1f / val_22.r) * val_30;
            val_30 = val_30 - this._offset;
            UnityEngine.Color val_31 = this._effectGradient.Evaluate(time:  val_30);
            UnityEngine.Color val_32 = this.BlendColor(colorA:  new UnityEngine.Color() {r = val_28.r, g = val_28.g, b = val_28.b, a = val_28.a}, colorB:  new UnityEngine.Color() {r = val_31.r, g = val_31.g, b = val_31.b, a = val_31.a});
            UnityEngine.Color32 val_33 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_32.r, g = val_32.g, b = val_32.b, a = val_32.a});
            val_27 = val_33.r;
            if(helper != null)
            {
                goto label_41;
            }
            
            goto label_41;
        }
        private UnityEngine.Color BlendColor(UnityEngine.Color colorA, UnityEngine.Color colorB)
        {
            if(this._blendMode == 1)
            {
                    UnityEngine.Color val_1 = UnityEngine.Color.op_Addition(a:  new UnityEngine.Color() {r = colorA.r, g = colorA.g, b = colorA.b, a = colorA.a}, b:  new UnityEngine.Color() {r = colorB.r, g = colorB.g, b = colorB.b, a = colorB.a});
                return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            }
            
            if(this._blendMode != 2)
            {
                    return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            }
            
            UnityEngine.Color val_2 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = colorA.r, g = colorA.g, b = colorA.b, a = colorA.a}, b:  new UnityEngine.Color() {r = colorB.r, g = colorB.g, b = colorB.b, a = colorB.a});
            return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        }
    
    }

}
