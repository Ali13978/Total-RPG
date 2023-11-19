using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public abstract class Projection : ScriptableObject
    {
        // Fields
        private bool marked;
        protected UnityEngine.Material material;
        protected LlockhamIndustries.Decals.ProjectionProperty[] properties;
        [UnityEngine.SerializeField]
        protected LlockhamIndustries.Decals.ProjectionType type;
        [UnityEngine.SerializeField]
        protected bool instanced;
        [UnityEngine.SerializeField]
        protected bool forceForward;
        [UnityEngine.SerializeField]
        protected int priority;
        [UnityEngine.SerializeField]
        protected LlockhamIndustries.Decals.TransparencyType transparencyType;
        [UnityEngine.SerializeField]
        protected float cutoff;
        [UnityEngine.SerializeField]
        protected UnityEngine.Vector2 tiling;
        [UnityEngine.SerializeField]
        protected UnityEngine.Vector2 offset;
        [UnityEngine.SerializeField]
        protected LlockhamIndustries.Decals.MaskMethod maskMethod;
        [UnityEngine.SerializeField]
        protected bool[] masks;
        [UnityEngine.SerializeField]
        protected float projectionLimit;
        public int _Cutoff;
        public int _TilingOffset;
        public int _MaskBase;
        public int _MaskLayers;
        protected int _NormalCutoff;
        
        // Properties
        public UnityEngine.Material Mat { get; }
        private UnityEngine.Material Forward { get; }
        private UnityEngine.Material DeferredOpaque { get; }
        private UnityEngine.Material DeferredTransparent { get; }
        public virtual UnityEngine.Material MobileForward { get; }
        public virtual UnityEngine.Material MobileDeferredOpaque { get; }
        public virtual UnityEngine.Material MobileDeferredTransparent { get; }
        public virtual UnityEngine.Material StandardForward { get; }
        public virtual UnityEngine.Material StandardDeferredOpaque { get; }
        public virtual UnityEngine.Material StandardDeferredTransparent { get; }
        public virtual UnityEngine.Material PackedForward { get; }
        public virtual UnityEngine.Material PackedDeferredOpaque { get; }
        public virtual UnityEngine.Material PackedDeferredTransparent { get; }
        public abstract LlockhamIndustries.Decals.RenderingPaths SupportedRendering { get; }
        public bool Valid { get; }
        public LlockhamIndustries.Decals.ProjectionType ProjectionType { get; set; }
        public int Priority { get; set; }
        public LlockhamIndustries.Decals.TransparencyType TransparencyType { get; set; }
        public float Cutoff { get; set; }
        public UnityEngine.Vector2 Tiling { get; set; }
        public UnityEngine.Vector2 Offset { get; set; }
        public LlockhamIndustries.Decals.MaskMethod MaskMethod { get; set; }
        public bool MaskLayer1 { get; set; }
        public bool MaskLayer2 { get; set; }
        public bool MaskLayer3 { get; set; }
        public bool MaskLayer4 { get; set; }
        public float ProjectionLimit { get; set; }
        public bool Instanced { get; set; }
        public abstract int InstanceLimit { get; }
        public bool ForceForward { get; set; }
        public LlockhamIndustries.Decals.ProjectionProperty[] Properties { get; }
        
        // Methods
        protected Projection()
        {
            this.cutoff = 0.2f;
            this.projectionLimit = 80f;
            this.masks = null;
        }
        public UnityEngine.Material get_Mat()
        {
            if(this == 1)
            {
                    return this.Forward;
            }
            
            LlockhamIndustries.Decals.DynamicDecals val_1 = LlockhamIndustries.Decals.DynamicDecals.System;
            if(val_1.renderingPath == 0)
            {
                    return this.Forward;
            }
            
            if(this.forceForward != false)
            {
                    return this.Forward;
            }
            
            if(this.transparencyType == 1)
            {
                    return this.DeferredTransparent;
            }
            
            if(this.transparencyType != 0)
            {
                    return 0;
            }
            
            return this.DeferredOpaque;
        }
        private UnityEngine.Material get_Forward()
        {
            LlockhamIndustries.Decals.DynamicDecalSettings val_2 = LlockhamIndustries.Decals.DynamicDecals.System.Settings;
            if((val_2.replacement != 1) && (val_2.replacement == 2))
            {
                
            }
        
        }
        private UnityEngine.Material get_DeferredOpaque()
        {
            LlockhamIndustries.Decals.DynamicDecalSettings val_2 = LlockhamIndustries.Decals.DynamicDecals.System.Settings;
            if((val_2.replacement != 1) && (val_2.replacement == 2))
            {
                
            }
        
        }
        private UnityEngine.Material get_DeferredTransparent()
        {
            LlockhamIndustries.Decals.DynamicDecalSettings val_2 = LlockhamIndustries.Decals.DynamicDecals.System.Settings;
            if((val_2.replacement != 1) && (val_2.replacement == 2))
            {
                
            }
        
        }
        public virtual UnityEngine.Material get_MobileForward()
        {
            return 0;
        }
        public virtual UnityEngine.Material get_MobileDeferredOpaque()
        {
            return 0;
        }
        public virtual UnityEngine.Material get_MobileDeferredTransparent()
        {
            return 0;
        }
        public virtual UnityEngine.Material get_StandardForward()
        {
            return 0;
        }
        public virtual UnityEngine.Material get_StandardDeferredOpaque()
        {
            return 0;
        }
        public virtual UnityEngine.Material get_StandardDeferredTransparent()
        {
            return 0;
        }
        public virtual UnityEngine.Material get_PackedForward()
        {
            return 0;
        }
        public virtual UnityEngine.Material get_PackedDeferredOpaque()
        {
            return 0;
        }
        public virtual UnityEngine.Material get_PackedDeferredTransparent()
        {
            return 0;
        }
        protected UnityEngine.Material MaterialFromShader(UnityEngine.Shader p_Shader)
        {
            UnityEngine.Object val_5;
            if(0 == this.material)
            {
                    this.material = new UnityEngine.Material(shader:  p_Shader);
                hideFlags = 52;
            }
            
            val_5 = this.material.shader;
            if(0 == val_5)
            {
                    return (UnityEngine.Material)this.material;
            }
            
            val_5 = this.material;
            val_5.shader = p_Shader;
            return (UnityEngine.Material)this.material;
        }
        public abstract LlockhamIndustries.Decals.RenderingPaths get_SupportedRendering(); // 0
        public bool get_Valid()
        {
            var val_2;
            if(this != 2)
            {
                goto label_0;
            }
            
            LlockhamIndustries.Decals.DynamicDecals val_1 = LlockhamIndustries.Decals.DynamicDecals.System;
            if(val_1.renderingPath == 0)
            {
                goto label_2;
            }
            
            label_0:
            val_2 = 1;
            return (bool)val_2;
            label_2:
            val_2 = 0;
            return (bool)val_2;
        }
        protected void DestroyMaterial()
        {
            UnityEngine.Material val_1 = this.Mat;
            if(0 == val_1)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying != false)
            {
                    UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            UnityEngine.Object.DestroyImmediate(obj:  0, allowDestroyingAssets:  val_1);
        }
        protected void UpdateMaterial()
        {
            if(0 == this.Mat)
            {
                    return;
            }
            
            this = ???;
            goto typeof(LlockhamIndustries.Decals.Projection).__il2cppRuntimeField_1F0;
        }
        protected virtual void Apply(UnityEngine.Material Material)
        {
            float val_10;
            System.Boolean[] val_11;
            System.Boolean[] val_16;
            float val_17;
            float val_18;
            if(this.type == 1)
            {
                goto label_1;
            }
            
            if(this.type != 0)
            {
                goto label_4;
            }
            
            Material.DisableKeyword(keyword:  "_Omni");
            goto label_4;
            label_1:
            Material.EnableKeyword(keyword:  "_Omni");
            label_4:
            Material.enableInstancing = this.Instanced;
            if(this.transparencyType == 0)
            {
                goto label_7;
            }
            
            if(this.transparencyType != 1)
            {
                goto label_10;
            }
            
            Material.DisableKeyword(keyword:  "_AlphaTest");
            goto label_10;
            label_7:
            Material.EnableKeyword(keyword:  "_AlphaTest");
            label_10:
            Material.SetFloat(nameID:  this._Cutoff, value:  this.cutoff);
            val_10 = 0f;
            Material.SetVector(nameID:  this._TilingOffset, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = val_10, w = 0f});
            val_11 = this.masks;
            if(this.masks.Length != 4)
            {
                goto label_17;
            }
            
            if(this.maskMethod == 1)
            {
                goto label_16;
            }
            
            if(this.maskMethod != 0)
            {
                goto label_17;
            }
            
            Material.SetFloat(nameID:  this._MaskBase, value:  1f);
            UnityEngine.Color val_3 = UnityEngine.Color.clear;
            bool val_10 = this.masks[0];
            val_16 = this.masks;
            val_17 = 0.5f;
            val_18 = 0f;
            goto label_21;
            label_16:
            Material.SetFloat(nameID:  this._MaskBase, value:  0f);
            UnityEngine.Color val_4 = UnityEngine.Color.clear;
            val_16 = this.masks;
            val_17 = 0.5f;
            val_18 = 1f;
            label_21:
            val_11 = this._MaskLayers;
            UnityEngine.Vector4 val_9 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = (this.masks[0] == true) ? (val_18) : (val_17), g = (val_16[1] == true) ? (val_18) : (val_17), b = (this.masks[2] == true) ? (val_18) : (val_17), a = (this.masks[3] == true) ? (val_18) : (val_17)});
            val_10 = val_9.z;
            Material.SetVector(nameID:  val_11, value:  new UnityEngine.Vector4() {x = val_9.x, y = val_9.y, z = val_10, w = val_9.w});
            label_17:
            float val_15 = 0.01745329f;
            val_15 = this.projectionLimit * val_15;
            Material.SetFloat(nameID:  this._NormalCutoff, value:  val_15);
        }
        public LlockhamIndustries.Decals.ProjectionType get_ProjectionType()
        {
            return (LlockhamIndustries.Decals.ProjectionType)this.type;
        }
        public void set_ProjectionType(LlockhamIndustries.Decals.ProjectionType value)
        {
            if(this.type == value)
            {
                    return;
            }
            
            this.type = value;
            this.marked = true;
        }
        public int get_Priority()
        {
            return (int)this.priority;
        }
        public void set_Priority(int value)
        {
            if(this.priority == value)
            {
                    return;
            }
            
            this.priority = value;
            this.marked = true;
        }
        public LlockhamIndustries.Decals.TransparencyType get_TransparencyType()
        {
            return (LlockhamIndustries.Decals.TransparencyType)this.transparencyType;
        }
        public void set_TransparencyType(LlockhamIndustries.Decals.TransparencyType value)
        {
            if(this.transparencyType == value)
            {
                    return;
            }
            
            this.transparencyType = value;
            this.marked = true;
        }
        public float get_Cutoff()
        {
            return (float)this.cutoff;
        }
        public void set_Cutoff(float value)
        {
            if(this.cutoff == value)
            {
                    return;
            }
            
            this.cutoff = value;
            this.marked = true;
        }
        public UnityEngine.Vector2 get_Tiling()
        {
            return new UnityEngine.Vector2() {x = this.tiling};
        }
        public void set_Tiling(UnityEngine.Vector2 value)
        {
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.tiling, y = V10.16B}, rhs:  new UnityEngine.Vector2() {x = value.x, y = value.y})) == false)
            {
                    return;
            }
            
            this.tiling = value;
            mem[1152921511788539416] = value.y;
            this.marked = true;
        }
        public UnityEngine.Vector2 get_Offset()
        {
            return new UnityEngine.Vector2() {x = this.offset};
        }
        public void set_Offset(UnityEngine.Vector2 value)
        {
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.offset, y = V10.16B}, rhs:  new UnityEngine.Vector2() {x = value.x, y = value.y})) == false)
            {
                    return;
            }
            
            this.offset = value;
            mem[1152921511788763424] = value.y;
            this.marked = true;
        }
        public LlockhamIndustries.Decals.MaskMethod get_MaskMethod()
        {
            return (LlockhamIndustries.Decals.MaskMethod)this.maskMethod;
        }
        public void set_MaskMethod(LlockhamIndustries.Decals.MaskMethod value)
        {
            if(this.maskMethod == value)
            {
                    return;
            }
            
            this.maskMethod = value;
            this.marked = true;
        }
        public bool get_MaskLayer1()
        {
            return (bool)this.masks[0];
        }
        public void set_MaskLayer1(bool value)
        {
            System.Boolean[] val_3 = this.masks;
            var val_1 = (val_3[0] == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            val_3 = this.masks;
            val_3[0] = value;
            this.marked = true;
        }
        public bool get_MaskLayer2()
        {
            return (bool)this.masks[1];
        }
        public void set_MaskLayer2(bool value)
        {
            System.Boolean[] val_3 = this.masks;
            var val_1 = (val_3[1] == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            val_3 = this.masks;
            val_3[1] = value;
            this.marked = true;
        }
        public bool get_MaskLayer3()
        {
            return (bool)this.masks[2];
        }
        public void set_MaskLayer3(bool value)
        {
            System.Boolean[] val_3 = this.masks;
            var val_1 = (val_3[2] == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            val_3 = this.masks;
            val_3[2] = value;
            this.marked = true;
        }
        public bool get_MaskLayer4()
        {
            return (bool)this.masks[3];
        }
        public void set_MaskLayer4(bool value)
        {
            System.Boolean[] val_3 = this.masks;
            var val_1 = (val_3[3] == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            val_3 = this.masks;
            val_3[3] = value;
            this.marked = true;
        }
        public float get_ProjectionLimit()
        {
            return (float)this.projectionLimit;
        }
        public void set_ProjectionLimit(float value)
        {
            if(this.projectionLimit == value)
            {
                    return;
            }
            
            this.projectionLimit = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  180f);
            this.marked = true;
        }
        public bool get_Instanced()
        {
            var val_4;
            LlockhamIndustries.Decals.DynamicDecals val_1 = LlockhamIndustries.Decals.DynamicDecals.System;
            if(UnityEngine.SystemInfo.supportsInstancing != false)
            {
                    var val_3 = (this.instanced == true) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public void set_Instanced(bool value)
        {
            this.instanced = value;
        }
        public abstract int get_InstanceLimit(); // 0
        public bool get_ForceForward()
        {
            return (bool)this.forceForward;
        }
        public void set_ForceForward(bool value)
        {
            this.forceForward = value;
        }
        public LlockhamIndustries.Decals.ProjectionProperty[] get_Properties()
        {
            return (LlockhamIndustries.Decals.ProjectionProperty[])this.properties;
        }
        public virtual void UpdateProperties()
        {
        
        }
        protected virtual void OnEnable()
        {
            goto typeof(LlockhamIndustries.Decals.Projection).__il2cppRuntimeField_240;
        }
        protected virtual void OnDisable()
        {
            this.DestroyMaterial();
        }
        public void Update()
        {
            if(this.marked == false)
            {
                    return;
            }
            
            this.UpdateMaterial();
            this.marked = false;
        }
        public void Mark(bool UpdateImmediately = False)
        {
            this.marked = true;
            if(UpdateImmediately == false)
            {
                    return;
            }
            
            this.Update();
        }
        protected virtual void GenerateIDs()
        {
            this._Cutoff = UnityEngine.Shader.PropertyToID(name:  0);
            this._TilingOffset = UnityEngine.Shader.PropertyToID(name:  0);
            this._MaskBase = UnityEngine.Shader.PropertyToID(name:  0);
            this._MaskLayers = UnityEngine.Shader.PropertyToID(name:  0);
            this._NormalCutoff = UnityEngine.Shader.PropertyToID(name:  0);
        }
    
    }

}
