using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class Specular : Projection
    {
        // Fields
        public LlockhamIndustries.Decals.AlbedoPropertyGroup albedo;
        public LlockhamIndustries.Decals.SpecularPropertyGroup specular;
        public LlockhamIndustries.Decals.NormalPropertyGroup normal;
        public LlockhamIndustries.Decals.EmissivePropertyGroup emissive;
        protected UnityEngine.Material[] forwardMaterials;
        protected UnityEngine.Material[] deferredOpaqueMaterials;
        protected UnityEngine.Material[] deferredTransparentMaterials;
        
        // Properties
        public override UnityEngine.Material MobileForward { get; }
        public override UnityEngine.Material MobileDeferredOpaque { get; }
        public override UnityEngine.Material MobileDeferredTransparent { get; }
        public override UnityEngine.Material StandardForward { get; }
        public override UnityEngine.Material StandardDeferredOpaque { get; }
        public override UnityEngine.Material StandardDeferredTransparent { get; }
        public override UnityEngine.Material PackedForward { get; }
        public override UnityEngine.Material PackedDeferredOpaque { get; }
        public override UnityEngine.Material PackedDeferredTransparent { get; }
        public override LlockhamIndustries.Decals.RenderingPaths SupportedRendering { get; }
        public override int InstanceLimit { get; }
        
        // Methods
        public Specular()
        {
        
        }
        public override UnityEngine.Material get_MobileForward()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_MobileDeferredOpaque()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_MobileDeferredTransparent()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_StandardForward()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_StandardDeferredOpaque()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_StandardDeferredTransparent()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_PackedForward()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_PackedDeferredOpaque()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_PackedDeferredTransparent()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override LlockhamIndustries.Decals.RenderingPaths get_SupportedRendering()
        {
            return 0;
        }
        public override int get_InstanceLimit()
        {
            return 500;
        }
        protected override void Apply(UnityEngine.Material Material)
        {
            this.Apply(Material:  Material);
            this.albedo.Apply(Material:  Material);
            this.specular.Apply(Material:  Material);
            this.normal.Apply(Material:  Material);
            this.emissive.Apply(Material:  Material);
        }
        protected override void OnEnable()
        {
            if(this.albedo == null)
            {
                    this.albedo = new LlockhamIndustries.Decals.AlbedoPropertyGroup(Projection:  this);
            }
            
            if(this.specular == null)
            {
                    this.specular = new LlockhamIndustries.Decals.SpecularPropertyGroup(Projection:  this);
            }
            
            if(this.normal == null)
            {
                    this.normal = new LlockhamIndustries.Decals.NormalPropertyGroup(Projection:  this);
            }
            
            if(this.emissive == null)
            {
                    this.emissive = new LlockhamIndustries.Decals.EmissivePropertyGroup(Projection:  this);
            }
            
            this.OnEnable();
        }
        protected override void GenerateIDs()
        {
            this.GenerateIDs();
            this.albedo.GenerateIDs();
            this.specular.GenerateIDs();
            this.normal.GenerateIDs();
            this.emissive.GenerateIDs();
        }
        public override void UpdateProperties()
        {
            var val_4;
            LlockhamIndustries.Decals.AlbedoPropertyGroup val_5;
            int val_6;
            LlockhamIndustries.Decals.EmissivePropertyGroup val_7;
            int val_8;
            if(!=0)
            {
                    if(mem[34807832] == 2)
            {
                goto label_3;
            }
            
            }
            
            val_4 = null;
            mem[1152921511800628024] = val_4;
            if(null == null)
            {
                    val_4 = 0;
            }
            
            label_3:
            val_5 = this.albedo;
            if(val_5 != null)
            {
                    val_6 = this.albedo._Color;
            }
            else
            {
                    val_6 = this.albedo._Color;
                if(this.albedo != null)
            {
                    val_5 = this.albedo;
            }
            else
            {
                    val_5 = 0;
            }
            
            }
            
            UnityEngine.Color val_1 = val_5.Color;
            mem[64] = 0;
            mem[48] = 0;
            mem[32] = 0;
            val_7 = this.emissive;
            if(val_7 != null)
            {
                    val_8 = this.emissive._EmissionColor;
            }
            else
            {
                    val_8 = this.emissive._EmissionColor;
                if(this.emissive != null)
            {
                    val_7 = this.emissive;
            }
            else
            {
                    val_7 = 0;
            }
            
            }
            
            UnityEngine.Color val_2 = val_7.Color;
            float val_3 = this.emissive.Intensity;
            mem[104] = 0;
            mem[88] = 0;
            mem[72] = 0;
        }
    
    }

}
