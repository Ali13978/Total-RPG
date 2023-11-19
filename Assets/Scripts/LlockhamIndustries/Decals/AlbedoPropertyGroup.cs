using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class AlbedoPropertyGroup
    {
        // Fields
        protected LlockhamIndustries.Decals.Projection projection;
        [UnityEngine.SerializeField]
        private UnityEngine.Texture texture;
        [UnityEngine.SerializeField]
        private UnityEngine.Color color;
        public int _MainTex;
        public int _Color;
        
        // Properties
        public UnityEngine.Texture Texture { get; set; }
        public UnityEngine.Color Color { get; set; }
        
        // Methods
        public AlbedoPropertyGroup(LlockhamIndustries.Decals.Projection Projection)
        {
            UnityEngine.Color val_1 = UnityEngine.Color.grey;
            this.color = val_1;
            mem[1152921511776599284] = val_1.g;
            mem[1152921511776599288] = val_1.b;
            mem[1152921511776599292] = val_1.a;
            this.projection = Projection;
        }
        protected void Mark()
        {
            this.projection.marked = true;
        }
        public void GenerateIDs()
        {
            this._MainTex = UnityEngine.Shader.PropertyToID(name:  0);
            this._Color = UnityEngine.Shader.PropertyToID(name:  0);
        }
        public void Apply(UnityEngine.Material Material)
        {
            Material.SetTexture(nameID:  this._MainTex, value:  this.texture);
            Material.SetColor(nameID:  this._Color, value:  new UnityEngine.Color() {r = this.color, g = V9.16B, b = V10.16B, a = V11.16B});
        }
        public UnityEngine.Texture get_Texture()
        {
            return (UnityEngine.Texture)this.texture;
        }
        public void set_Texture(UnityEngine.Texture value)
        {
            UnityEngine.Texture val_2 = this.texture;
            if(0 == val_2)
            {
                    return;
            }
            
            val_2 = this.projection;
            this.texture = value;
            this.projection.marked = true;
        }
        public UnityEngine.Color get_Color()
        {
            return new UnityEngine.Color() {r = this.color};
        }
        public void set_Color(UnityEngine.Color value)
        {
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.color, g = V5.16B, b = V6.16B, a = V7.16B}, rhs:  new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a})) == false)
            {
                    return;
            }
            
            this.color = value;
            mem[1152921511777448820] = value.g;
            mem[1152921511777448824] = value.b;
            mem[1152921511777448828] = value.a;
            this.projection.marked = true;
        }
    
    }

}
