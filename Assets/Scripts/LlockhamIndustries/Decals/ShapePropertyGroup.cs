using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class ShapePropertyGroup
    {
        // Fields
        protected LlockhamIndustries.Decals.Projection projection;
        [UnityEngine.SerializeField]
        private UnityEngine.Texture texture;
        [UnityEngine.SerializeField]
        private float multiplier;
        public int _MainTex;
        public int _Multiplier;
        
        // Properties
        public UnityEngine.Texture Texture { get; set; }
        public float Multiplier { get; set; }
        
        // Methods
        public ShapePropertyGroup(LlockhamIndustries.Decals.Projection Projection)
        {
            this.multiplier = 1f;
            this.projection = Projection;
        }
        protected void Mark()
        {
            this.projection.marked = true;
        }
        public void GenerateIDs()
        {
            this._MainTex = UnityEngine.Shader.PropertyToID(name:  0);
            this._Multiplier = UnityEngine.Shader.PropertyToID(name:  0);
        }
        public void Apply(UnityEngine.Material Material)
        {
            Material.SetTexture(nameID:  this._MainTex, value:  this.texture);
            Material.SetFloat(nameID:  this._Multiplier, value:  this.multiplier);
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
        public float get_Multiplier()
        {
            return (float)this.multiplier;
        }
        public void set_Multiplier(float value)
        {
            if(this.multiplier == value)
            {
                    return;
            }
            
            this.multiplier = value;
            this.projection.marked = true;
        }
    
    }

}
