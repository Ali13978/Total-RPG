using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class SpecularPropertyGroup
    {
        // Fields
        protected LlockhamIndustries.Decals.Projection projection;
        [UnityEngine.SerializeField]
        private UnityEngine.Texture texture;
        [UnityEngine.SerializeField]
        private UnityEngine.Color color;
        [UnityEngine.SerializeField]
        private float glossiness;
        public int _SpecGlossMap;
        public int _SpecColor;
        public int _Glossiness;
        
        // Properties
        public UnityEngine.Texture Texture { get; set; }
        public UnityEngine.Color Color { get; set; }
        public float Glossiness { get; set; }
        
        // Methods
        public SpecularPropertyGroup(LlockhamIndustries.Decals.Projection Projection)
        {
            this.color = 0;
            this.glossiness = 1f;
            this.projection = Projection;
        }
        protected void Mark()
        {
            this.projection.Mark(UpdateImmediately:  false);
        }
        public void GenerateIDs()
        {
            this._SpecGlossMap = UnityEngine.Shader.PropertyToID(name:  0);
            this._SpecColor = UnityEngine.Shader.PropertyToID(name:  0);
            this._Glossiness = UnityEngine.Shader.PropertyToID(name:  0);
        }
        public void Apply(UnityEngine.Material Material)
        {
            Material.SetTexture(nameID:  this._SpecGlossMap, value:  this.texture);
            Material.SetColor(nameID:  this._SpecColor, value:  new UnityEngine.Color() {r = this.color, g = V9.16B, b = V10.16B, a = V11.16B});
            Material.SetFloat(nameID:  this._Glossiness, value:  this.glossiness);
        }
        public UnityEngine.Texture get_Texture()
        {
            return (UnityEngine.Texture)this.texture;
        }
        public void set_Texture(UnityEngine.Texture value)
        {
            if(0 == this.texture)
            {
                    return;
            }
            
            this.texture = value;
            this.Mark();
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
            mem[1152921511780578500] = value.g;
            mem[1152921511780578504] = value.b;
            mem[1152921511780578508] = value.a;
            this.Mark();
        }
        public float get_Glossiness()
        {
            return (float)this.glossiness;
        }
        public void set_Glossiness(float value)
        {
            if(this.glossiness == value)
            {
                    return;
            }
            
            this.glossiness = value;
            this.Mark();
        }
    
    }

}
