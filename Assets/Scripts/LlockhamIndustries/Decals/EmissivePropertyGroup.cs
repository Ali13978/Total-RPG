using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class EmissivePropertyGroup
    {
        // Fields
        protected LlockhamIndustries.Decals.Projection projection;
        [UnityEngine.SerializeField]
        private UnityEngine.Texture texture;
        [UnityEngine.SerializeField]
        private UnityEngine.Color color;
        [UnityEngine.SerializeField]
        private float intensity;
        public int _EmissionMap;
        public int _EmissionColor;
        
        // Properties
        public UnityEngine.Texture Texture { get; set; }
        public float Intensity { get; set; }
        public UnityEngine.Color Color { get; set; }
        
        // Methods
        public EmissivePropertyGroup(LlockhamIndustries.Decals.Projection Projection)
        {
            UnityEngine.Color val_1 = UnityEngine.Color.black;
            this.color = val_1;
            mem[1152921511781888516] = val_1.g;
            mem[1152921511781888520] = val_1.b;
            mem[1152921511781888524] = val_1.a;
            this.intensity = 1f;
            this.projection = Projection;
        }
        protected void Mark()
        {
            this.projection.marked = true;
        }
        public void GenerateIDs()
        {
            this._EmissionMap = UnityEngine.Shader.PropertyToID(name:  0);
            this._EmissionColor = UnityEngine.Shader.PropertyToID(name:  0);
        }
        public void Apply(UnityEngine.Material Material)
        {
            Material.SetTexture(nameID:  this._EmissionMap, value:  this.texture);
            UnityEngine.Color val_1 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = this.color}, b:  this.intensity);
            Material.SetColor(nameID:  this._EmissionColor, value:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
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
        public float get_Intensity()
        {
            return (float)this.intensity;
        }
        public void set_Intensity(float value)
        {
            if(this.intensity == value)
            {
                    return;
            }
            
            this.intensity = value;
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
            mem[1152921511782970436] = value.g;
            mem[1152921511782970440] = value.b;
            mem[1152921511782970444] = value.a;
            this.projection.marked = true;
        }
    
    }

}
