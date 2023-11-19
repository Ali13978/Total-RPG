using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class NormalPropertyGroup
    {
        // Fields
        protected LlockhamIndustries.Decals.Projection projection;
        [UnityEngine.SerializeField]
        private UnityEngine.Texture texture;
        [UnityEngine.SerializeField]
        private float strength;
        public int _BumpMap;
        public int _BumpScale;
        
        // Properties
        public UnityEngine.Texture Texture { get; set; }
        public float Strength { get; set; }
        
        // Methods
        public NormalPropertyGroup(LlockhamIndustries.Decals.Projection Projection)
        {
            this.strength = 1f;
            this.projection = Projection;
        }
        protected void Mark()
        {
            this.projection.marked = true;
        }
        public void GenerateIDs()
        {
            this._BumpMap = UnityEngine.Shader.PropertyToID(name:  0);
            this._BumpScale = UnityEngine.Shader.PropertyToID(name:  0);
        }
        public void Apply(UnityEngine.Material Material)
        {
            Material.SetTexture(nameID:  this._BumpMap, value:  this.texture);
            Material.SetFloat(nameID:  this._BumpScale, value:  this.strength);
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
        public float get_Strength()
        {
            return (float)this.strength;
        }
        public void set_Strength(float value)
        {
            if(this.strength == value)
            {
                    return;
            }
            
            this.strength = value;
            this.projection.marked = true;
        }
    
    }

}
