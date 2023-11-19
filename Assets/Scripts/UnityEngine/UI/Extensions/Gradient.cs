using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class Gradient : BaseMeshEffect
    {
        // Fields
        public UnityEngine.UI.Extensions.GradientMode gradientMode;
        public UnityEngine.UI.Extensions.GradientDir gradientDir;
        public bool overwriteAllColor;
        public UnityEngine.Color vertex1;
        public UnityEngine.Color vertex2;
        private UnityEngine.UI.Graphic targetGraphic;
        
        // Methods
        public Gradient()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.vertex1 = val_1;
            mem[1152921512713342048] = val_1.g;
            mem[1152921512713342052] = val_1.b;
            mem[1152921512713342056] = val_1.a;
            UnityEngine.Color val_2 = UnityEngine.Color.black;
            this.vertex2 = val_2;
            mem[1152921512713342064] = val_2.g;
            mem[1152921512713342068] = val_2.b;
            mem[1152921512713342072] = val_2.a;
        }
        protected override void Start()
        {
            this.targetGraphic = this.GetComponent<UnityEngine.UI.Graphic>();
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            byte val_6;
            float val_24;
            float val_27;
            UnityEngine.UI.Graphic val_39;
            float val_40;
            float val_41;
            var val_54;
            var val_55;
            float val_56;
            float val_57;
            int val_1 = vh.currentVertCount;
            if(val_1 == 0)
            {
                    return;
            }
            
            if(this.IsActive() ^ 1 == true)
            {
                    return;
            }
            
            vh.GetUIVertexStream(stream:  new System.Collections.Generic.List<UnityEngine.UIVertex>());
            if(this.gradientMode == 0)
            {
                goto label_5;
            }
            
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_42 = 0;
            label_26:
            vh.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  0);
            if(this.overwriteAllColor == true)
            {
                goto label_8;
            }
            
            UnityEngine.Color val_7 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_39 = this.targetGraphic;
            val_40 = val_7.r;
            val_41 = val_7.a;
            if((val_39.CompareCarefully(col1:  new UnityEngine.Color() {r = val_40, g = val_7.g, b = val_7.b, a = val_41}, col2:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a})) == false)
            {
                goto label_10;
            }
            
            label_8:
            UnityEngine.UI.Extensions.GradientDir val_40 = this.gradientDir;
            UnityEngine.UI.Extensions.GradientDir val_9 = val_40 + 23;
            val_40 = (val_40 < 4) ? (val_9) : 0;
            val_9 = val_40 - 23;
            if(val_9 > 3)
            {
                goto label_11;
            }
            
            var val_41 = 25811108 + ((this.gradientDir < 0x4 ? (this.gradientDir + 23) : 0 - 23)) << 2;
            val_41 = val_41 + 25811108;
            goto (25811108 + ((this.gradientDir < 0x4 ? (this.gradientDir + 23) : 0 - 23)) << 2 + 25811108);
            label_11:
            if(val_40 != 0)
            {
                    return;
            }
            
            vh.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  0);
            label_10:
            val_42 = val_42 + 1;
            if(val_42 < val_1)
            {
                goto label_26;
            }
            
            return;
            label_5:
            if((this.gradientDir & 4294967294) == 2)
            {
                    this.gradientDir = 0;
                val_54 = 1;
            }
            
            if(null != 0)
            {
                    val_55 = Count;
            }
            else
            {
                    val_55 = Count;
            }
            
            if(((this.gradientDir == 0) ? 1 : 0) != 0)
            {
                    UnityEngine.UIVertex val_23 = Item[val_55 - 1];
                val_56 = val_24;
            }
            else
            {
                    UnityEngine.UIVertex val_26 = Item[val_55 - 1];
                val_56 = val_27;
            }
            
            val_39 = this.gradientDir;
            if(val_39 != 0)
            {
                    UnityEngine.UIVertex val_28 = Item[0];
                val_57 = val_27;
            }
            else
            {
                    UnityEngine.UIVertex val_29 = Item[0];
                val_57 = val_24;
            }
            
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_43 = 0;
            label_43:
            vh.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32() {g = val_17.g, b = val_17.b, a = val_17.a}, uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  0);
            if(this.overwriteAllColor == true)
            {
                goto label_39;
            }
            
            UnityEngine.Color val_31 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_39 = this.targetGraphic;
            val_40 = val_31.r;
            val_41 = val_31.a;
            val_57 = val_40;
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_57, g = val_31.g, b = val_31.b, a = val_41}, rhs:  new UnityEngine.Color() {r = val_31.r, g = val_31.g, b = val_31.b, a = val_31.a})) == true)
            {
                goto label_41;
            }
            
            label_39:
            UnityEngine.Color val_34 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_40 = val_34.r;
            val_41 = val_34.b;
            float val_36 = ((this.gradientDir == 0) ? -483169020 : -483169024) - val_56;
            val_36 = val_36 / (val_57 - val_56);
            UnityEngine.Color val_37 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.vertex2, g = val_34.g, b = val_34.b, a = V16.16B}, b:  new UnityEngine.Color() {r = this.vertex1, g = val_31.g, b = val_31.b, a = val_31.a}, t:  val_36);
            UnityEngine.Color val_38 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = val_40, g = val_34.g, b = val_41, a = val_34.a}, b:  new UnityEngine.Color() {r = val_37.r, g = val_37.g, b = val_37.b, a = val_37.a});
            UnityEngine.Color32 val_39 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_38.r, g = val_38.g, b = val_38.b, a = val_38.a});
            val_6 = val_39.r;
            vh.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  0);
            label_41:
            val_43 = val_43 + 1;
            if(val_1 != val_43)
            {
                goto label_43;
            }
        
        }
        private bool CompareCarefully(UnityEngine.Color col1, UnityEngine.Color col2)
        {
            var val_3;
            col1.r = col1.r - col2.r;
            if(((System.Math.Abs(col1.r) < 0) && ((System.Math.Abs(col1.g - col2.g)) < 0)) && ((System.Math.Abs(col1.b - col2.b)) < 0))
            {
                    float val_6 = col2.a;
                val_6 = col1.a - val_6;
                if(System.Math.Abs(val_6) < 0)
            {
                    val_3 = 1;
                return (bool)val_3;
            }
            
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
    
    }

}
