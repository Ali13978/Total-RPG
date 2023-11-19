using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class Gloss : Deferred
    {
        // Fields
        [UnityEngine.SerializeField]
        public LlockhamIndustries.Decals.GlossType glossType;
        public LlockhamIndustries.Decals.GlossPropertyGroup gloss;
        
        // Properties
        public LlockhamIndustries.Decals.GlossType GlossType { get; set; }
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
        public Gloss()
        {
            val_1 = new LlockhamIndustries.Decals.Projection();
        }
        public LlockhamIndustries.Decals.GlossType get_GlossType()
        {
            return (LlockhamIndustries.Decals.GlossType)this.glossType;
        }
        public void set_GlossType(LlockhamIndustries.Decals.GlossType value)
        {
            if(this.glossType == value)
            {
                    return;
            }
            
            this.glossType = value;
            mem[1152921511792683464] = 1;
        }
        private UnityEngine.Material get_Mobile()
        {
            UnityEngine.Shader val_2;
            var val_3;
            if(this.glossType != 1)
            {
                    val_2 = 0;
                if(this.glossType != 0)
            {
                    return this.MaterialFromShader(p_Shader:  val_2 = UnityEngine.Shader.Find(name:  0));
            }
            
                val_3 = "Projection/Decal/Mobile/Wet";
            }
            else
            {
                    val_3 = "Projection/Decal/Mobile/Dry";
            }
            
            return this.MaterialFromShader(p_Shader:  val_2);
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
            UnityEngine.Shader val_2;
            var val_3;
            if(this.glossType != 1)
            {
                    val_2 = 0;
                if(this.glossType != 0)
            {
                    return this.MaterialFromShader(p_Shader:  val_2 = UnityEngine.Shader.Find(name:  0));
            }
            
                val_3 = "Projection/Decal/Standard/Wet";
            }
            else
            {
                    val_3 = "Projection/Decal/Standard/Dry";
            }
            
            return this.MaterialFromShader(p_Shader:  val_2);
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
            UnityEngine.Shader val_2;
            var val_3;
            if(this.glossType != 1)
            {
                    val_2 = 0;
                if(this.glossType != 0)
            {
                    return this.MaterialFromShader(p_Shader:  val_2 = UnityEngine.Shader.Find(name:  0));
            }
            
                val_3 = "Projection/Decal/Packed/Wet";
            }
            else
            {
                    val_3 = "Projection/Decal/Packed/Dry";
            }
            
            return this.MaterialFromShader(p_Shader:  val_2);
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
            this.gloss.Apply(Material:  Material);
        }
        protected override void OnEnable()
        {
            if(this.gloss == null)
            {
                    object val_1 = null;
                typeof(LlockhamIndustries.Decals.GlossPropertyGroup).__il2cppRuntimeField_20 = 1065353216;
                val_1 = new System.Object();
                typeof(LlockhamIndustries.Decals.GlossPropertyGroup).__il2cppRuntimeField_10 = this;
                this.gloss = val_1;
            }
        
        }
        protected override void GenerateIDs()
        {
            this.GenerateIDs();
            this.gloss.GenerateIDs();
        }
        public override void UpdateProperties()
        {
            var val_2;
            var val_3;
            LlockhamIndustries.Decals.GlossPropertyGroup val_4;
            if((X21 != 0) && ((X21 + 24) == 1))
            {
                    val_3 = X21;
            }
            else
            {
                    val_3 = null;
                mem[1152921511794350648] = val_3;
                if(null != null)
            {
                    val_2 = val_3;
            }
            else
            {
                    val_2 = 0;
            }
            
            }
            
            val_4 = this.gloss;
            if(this.gloss != null)
            {
                goto label_6;
            }
            
            val_4 = this.gloss;
            if(val_4 == null)
            {
                goto label_7;
            }
            
            label_6:
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            mem[32] = "Glossiness";
            mem[48] = val_1.r;
            mem[52] = val_1.g;
            mem[56] = val_1.b;
            mem[60] = val_1.a;
            mem[64] = this.gloss.glossiness;
            mem[68] = 0;
            mem[40] = this.gloss._Glossiness;
            mem[44] = 1;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_47 = 0;
            typeof(LlockhamIndustries.Decals.ProjectionProperty[]).__il2cppRuntimeField_45 = 0;
            return;
            label_7:
        }
    
    }

}
