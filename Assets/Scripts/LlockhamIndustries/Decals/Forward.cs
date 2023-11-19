using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public abstract class Forward : Projection
    {
        // Fields
        public LlockhamIndustries.Decals.AlbedoPropertyGroup albedo;
        
        // Properties
        public override int InstanceLimit { get; }
        public override LlockhamIndustries.Decals.RenderingPaths SupportedRendering { get; }
        
        // Methods
        protected Forward()
        {
        
        }
        public override int get_InstanceLimit()
        {
            return 500;
        }
        public override LlockhamIndustries.Decals.RenderingPaths get_SupportedRendering()
        {
            return 1;
        }
        protected override void Apply(UnityEngine.Material Material)
        {
            this.Apply(Material:  Material);
            this.albedo.Apply(Material:  Material);
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
        
        }
        protected override void GenerateIDs()
        {
            this.GenerateIDs();
            this.albedo.GenerateIDs();
        }
        public override void UpdateProperties()
        {
            var val_1;
            var val_2;
            var val_3;
            LlockhamIndustries.Decals.AlbedoPropertyGroup val_4;
            val_1 = 10330;
            if((X21 != 0) && ((X21 + 24) == 1))
            {
                    val_3 = X21;
            }
            else
            {
                    val_1 = null;
                val_3 = val_1;
                mem[1152921511784496584] = val_3;
                if(null != null)
            {
                    val_2 = val_3;
            }
            else
            {
                    val_2 = 0;
            }
            
            }
            
            val_4 = this.albedo;
            if(this.albedo != null)
            {
                goto label_6;
            }
            
            val_4 = this.albedo;
            if(val_4 == null)
            {
                goto label_7;
            }
            
            label_6:
            mem[32] = "Albedo";
            mem[40] = this.albedo._Color;
            mem[44] = 0;
            mem[48] = this.albedo.color;
            mem[52] = this.albedo;
            mem[56] = ???;
            mem[60] = ???;
            mem[68] = 0;
            mem[64] = 0;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_47 = 0;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_45 = 0;
            return;
            label_7:
            LlockhamIndustries.Decals.ProjectionProperty[].__error = 1;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_8 = ???;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_C = 0;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_10 = ???;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_14 = ???;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_18 = ???;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_1C = ???;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_20 = 0;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_24 = 0;
        }
    
    }

}
