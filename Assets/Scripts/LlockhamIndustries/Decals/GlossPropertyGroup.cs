using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class GlossPropertyGroup
    {
        // Fields
        protected LlockhamIndustries.Decals.Projection projection;
        [UnityEngine.SerializeField]
        private UnityEngine.Texture texture;
        [UnityEngine.SerializeField]
        private float glossiness;
        public int _GlossMap;
        public int _Glossiness;
        
        // Properties
        public UnityEngine.Texture Texture { get; set; }
        public float Glossiness { get; set; }
        
        // Methods
        public GlossPropertyGroup(LlockhamIndustries.Decals.Projection Projection)
        {
            this.glossiness = 1f;
            this.projection = Projection;
        }
        protected void Mark()
        {
            this.projection.marked = true;
        }
        public void GenerateIDs()
        {
            this._GlossMap = UnityEngine.Shader.PropertyToID(name:  0);
            this._Glossiness = UnityEngine.Shader.PropertyToID(name:  0);
        }
        public void Apply(UnityEngine.Material Material)
        {
            Material.SetTexture(nameID:  this._GlossMap, value:  this.texture);
            Material.SetFloat(nameID:  this._Glossiness, value:  this.glossiness);
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
            this.projection.marked = true;
        }
    
    }

}
