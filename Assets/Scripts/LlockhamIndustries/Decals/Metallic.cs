using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class Metallic : Projection
    {
        // Fields
        public LlockhamIndustries.Decals.AlbedoPropertyGroup albedo;
        public LlockhamIndustries.Decals.MetallicPropertyGroup metallic;
        public LlockhamIndustries.Decals.NormalPropertyGroup normal;
        public LlockhamIndustries.Decals.EmissivePropertyGroup emissive;
        
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
        public Metallic()
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
            this.metallic.Apply(Material:  Material);
            this.normal.Apply(Material:  Material);
            this.emissive.Apply(Material:  Material);
        }
        protected override void OnEnable()
        {
            if(this.albedo == null)
            {
                    UnityEngine.Color val_1 = UnityEngine.Color.grey;
                typeof(LlockhamIndustries.Decals.AlbedoPropertyGroup).__il2cppRuntimeField_20 = val_1.r;
                typeof(LlockhamIndustries.Decals.AlbedoPropertyGroup).__il2cppRuntimeField_24 = val_1.g;
                typeof(LlockhamIndustries.Decals.AlbedoPropertyGroup).__il2cppRuntimeField_28 = val_1.b;
                typeof(LlockhamIndustries.Decals.AlbedoPropertyGroup).__il2cppRuntimeField_2C = val_1.a;
                null = new System.Object();
                typeof(LlockhamIndustries.Decals.AlbedoPropertyGroup).__il2cppRuntimeField_10 = this;
                this.albedo = null;
            }
            
            if(this.metallic == null)
            {
                    object val_3 = null;
                typeof(LlockhamIndustries.Decals.MetallicPropertyGroup).__il2cppRuntimeField_20 = 1065353216;
                val_3 = new System.Object();
                typeof(LlockhamIndustries.Decals.MetallicPropertyGroup).__il2cppRuntimeField_10 = this;
                this.metallic = val_3;
            }
            
            if(this.normal == null)
            {
                    object val_4 = null;
                typeof(LlockhamIndustries.Decals.NormalPropertyGroup).__il2cppRuntimeField_20 = 1065353216;
                val_4 = new System.Object();
                typeof(LlockhamIndustries.Decals.NormalPropertyGroup).__il2cppRuntimeField_10 = this;
                this.normal = val_4;
            }
            
            if(this.emissive == null)
            {
                    this.emissive = new LlockhamIndustries.Decals.EmissivePropertyGroup(Projection:  this);
            }
        
        }
        protected override void GenerateIDs()
        {
            this.GenerateIDs();
            this.albedo.GenerateIDs();
            this.metallic.GenerateIDs();
            this.normal.GenerateIDs();
            this.emissive.GenerateIDs();
        }
        public override void UpdateProperties()
        {
            var val_2;
            var val_3;
            var val_4;
            LlockhamIndustries.Decals.ProjectionProperty[] val_5;
            LlockhamIndustries.Decals.AlbedoPropertyGroup val_6;
            val_2 = 16307;
            if((X21 != 0) && ((X21 + 24) == 2))
            {
                    val_4 = X21;
            }
            else
            {
                    val_5 = 2;
                val_2 = null;
                val_4 = val_2;
                mem[1152921511796349080] = val_4;
                if(null != null)
            {
                    val_3 = val_4;
            }
            else
            {
                    val_3 = 0;
            }
            
            }
            
            val_6 = this.albedo;
            if(this.albedo != null)
            {
                goto label_6;
            }
            
            val_6 = this.albedo;
            if(val_6 == null)
            {
                goto label_11;
            }
            
            label_6:
            if(7254272 == 0)
            {
                    val_5 = 0;
            }
            
            mem[32] = "Albedo";
            mem[40] = this.albedo._Color;
            mem[44] = 0;
            mem[48] = this.albedo.color;
            mem[52] = ???;
            mem[56] = ???;
            mem[60] = ???;
            mem[68] = 0;
            mem[64] = 0;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_47 = 0;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_45 = 0;
            if(this.emissive == null)
            {
                    if(this.emissive == null)
            {
                goto label_11;
            }
            
            }
            
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_48 = "Emission";
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_58 = this.emissive.color;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_68 = this.emissive.intensity;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_6C = 0;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_50 = this.emissive._EmissionColor;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_54 = 2;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_6F = 0;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_6D = 0;
            return;
            label_11:
            LlockhamIndustries.Decals.ProjectionProperty[].__error = val_5;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_10 = ???;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_14 = ???;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_18 = ???;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_1C = ???;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_20 = ???;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_8 = ???;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_C = 2;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_24 = 0;
        }
    
    }

}
