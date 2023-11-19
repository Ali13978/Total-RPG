using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class Normal : Deferred
    {
        // Fields
        public LlockhamIndustries.Decals.ShapePropertyGroup shape;
        public LlockhamIndustries.Decals.NormalPropertyGroup normal;
        protected UnityEngine.Material[] deferredMaterials;
        
        // Properties
        private UnityEngine.Material Mobile { get; }
        public override UnityEngine.Material MobileDeferredOpaque { get; }
        public override UnityEngine.Material MobileDeferredTransparent { get; }
        private UnityEngine.Material Standard { get; }
        public override UnityEngine.Material StandardDeferredOpaque { get; }
        public override UnityEngine.Material StandardDeferredTransparent { get; }
        private UnityEngine.Material Packed { get; }
        public override UnityEngine.Material PackedDeferredOpaque { get; }
        public override UnityEngine.Material PackedDeferredTransparent { get; }
        public override int InstanceLimit { get; }
        
        // Methods
        public Normal()
        {
            val_1 = new LlockhamIndustries.Decals.Projection();
        }
        private UnityEngine.Material get_Mobile()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_MobileDeferredOpaque()
        {
            return this.Mobile;
        }
        public override UnityEngine.Material get_MobileDeferredTransparent()
        {
            return this.Mobile;
        }
        private UnityEngine.Material get_Standard()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_StandardDeferredOpaque()
        {
            return this.Standard;
        }
        public override UnityEngine.Material get_StandardDeferredTransparent()
        {
            return this.Standard;
        }
        private UnityEngine.Material get_Packed()
        {
            return this.MaterialFromShader(p_Shader:  UnityEngine.Shader.Find(name:  0));
        }
        public override UnityEngine.Material get_PackedDeferredOpaque()
        {
            return this.Packed;
        }
        public override UnityEngine.Material get_PackedDeferredTransparent()
        {
            return this.Packed;
        }
        public override int get_InstanceLimit()
        {
            return 500;
        }
        protected override void Apply(UnityEngine.Material Material)
        {
            this.Apply(Material:  Material);
            this.shape.Apply(Material:  Material);
            this.normal.Apply(Material:  Material);
        }
        protected override void OnEnable()
        {
            if(this.shape == null)
            {
                    object val_1 = null;
                typeof(LlockhamIndustries.Decals.ShapePropertyGroup).__il2cppRuntimeField_20 = 1065353216;
                val_1 = new System.Object();
                typeof(LlockhamIndustries.Decals.ShapePropertyGroup).__il2cppRuntimeField_10 = this;
                this.shape = val_1;
            }
            
            if(this.normal == null)
            {
                    object val_2 = null;
                typeof(LlockhamIndustries.Decals.NormalPropertyGroup).__il2cppRuntimeField_20 = 1065353216;
                val_2 = new System.Object();
                typeof(LlockhamIndustries.Decals.NormalPropertyGroup).__il2cppRuntimeField_10 = this;
                this.normal = val_2;
            }
        
        }
        protected override void GenerateIDs()
        {
            this.GenerateIDs();
            this.shape.GenerateIDs();
            this.normal.GenerateIDs();
        }
        public override void UpdateProperties()
        {
            var val_3;
            var val_4;
            LlockhamIndustries.Decals.ShapePropertyGroup val_5;
            LlockhamIndustries.Decals.NormalPropertyGroup val_6;
            if((X21 != 0) && ((X21 + 24) == 2))
            {
                    val_4 = X21;
            }
            else
            {
                    val_4 = null;
                mem[1152921511798617400] = val_4;
                if(null != null)
            {
                    val_3 = val_4;
            }
            else
            {
                    val_3 = 0;
            }
            
            }
            
            val_5 = this.shape;
            if(this.shape != null)
            {
                goto label_6;
            }
            
            val_5 = this.shape;
            if(val_5 == null)
            {
                goto label_11;
            }
            
            label_6:
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            mem[32] = "Opacity";
            mem[48] = val_1.r;
            mem[52] = val_1.g;
            mem[56] = val_1.b;
            mem[60] = val_1.a;
            mem[64] = this.shape.multiplier;
            mem[68] = 0;
            mem[40] = this.shape._Multiplier;
            mem[44] = 1;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_47 = 0;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_45 = 0;
            val_6 = this.normal;
            if(this.normal != null)
            {
                goto label_10;
            }
            
            val_6 = this.normal;
            if(val_6 == null)
            {
                goto label_11;
            }
            
            label_10:
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_48 = "Normal Strength";
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_58 = val_2.r;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_5C = val_2.g;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_60 = val_2.b;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_64 = val_2.a;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_68 = this.normal.strength;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_6C = 0;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_50 = this.normal._BumpScale;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_54 = 1;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_6F = 0;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_6D = 0;
            return;
            label_11:
        }
    
    }

}
