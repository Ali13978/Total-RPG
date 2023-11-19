using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public class DynamicDecalSettings : ScriptableObject
    {
        // Fields
        public LlockhamIndustries.Decals.PoolInstance[] pools;
        public LlockhamIndustries.Decals.DecalMaskMethod maskMethod;
        [UnityEngine.SerializeField]
        private LlockhamIndustries.Decals.ProjectionLayer[] layers;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<LlockhamIndustries.Decals.ReplacementPass> passes;
        [UnityEngine.SerializeField]
        private LlockhamIndustries.Decals.ShaderReplacementType replacement;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<UnityEngine.Material> materials;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<int> materialQueues;
        [UnityEngine.SerializeField]
        private bool singlepassVR;
        
        // Properties
        public bool UseMaskLayers { get; }
        public LlockhamIndustries.Decals.ProjectionLayer[] Layers { get; set; }
        public System.Collections.Generic.List<LlockhamIndustries.Decals.ReplacementPass> Passes { get; }
        public System.Collections.Generic.List<UnityEngine.Material> Materials { get; }
        public LlockhamIndustries.Decals.ShaderReplacementType Replacement { get; set; }
        public bool SinglePassVR { get; }
        
        // Methods
        public DynamicDecalSettings()
        {
            this.ResetPools();
            this.ResetMasking();
        }
        public bool get_UseMaskLayers()
        {
            LlockhamIndustries.Decals.DecalMaskMethod val_2 = this.maskMethod;
            val_2 = val_2 | 2;
            return (bool)(val_2 == 2) ? 1 : 0;
        }
        public LlockhamIndustries.Decals.ProjectionLayer[] get_Layers()
        {
            return (LlockhamIndustries.Decals.ProjectionLayer[])this.layers;
        }
        public void set_Layers(LlockhamIndustries.Decals.ProjectionLayer[] value)
        {
            if(this.layers == value)
            {
                    return;
            }
            
            this.layers = value;
            this.CalculatePasses();
        }
        public System.Collections.Generic.List<LlockhamIndustries.Decals.ReplacementPass> get_Passes()
        {
            return (System.Collections.Generic.List<LlockhamIndustries.Decals.ReplacementPass>)this.passes;
        }
        public System.Collections.Generic.List<UnityEngine.Material> get_Materials()
        {
            return (System.Collections.Generic.List<UnityEngine.Material>)this.materials;
        }
        public LlockhamIndustries.Decals.ShaderReplacementType get_Replacement()
        {
            return (LlockhamIndustries.Decals.ShaderReplacementType)this.replacement;
        }
        public void set_Replacement(LlockhamIndustries.Decals.ShaderReplacementType value)
        {
            if(this.replacement == value)
            {
                    return;
            }
            
            this.replacement = value;
            LlockhamIndustries.Decals.DynamicDecals.System.UpdateRenderers();
        }
        public bool get_SinglePassVR()
        {
            return (bool)this.singlepassVR;
        }
        public void ResetSettings()
        {
            LlockhamIndustries.Decals.DynamicDecals.System.UpdateRenderers();
        }
        public void ResetPools()
        {
            typeof(LlockhamIndustries.Decals.PoolInstance[]).__il2cppRuntimeField_20 = new LlockhamIndustries.Decals.PoolInstance(Title:  "Default", CurrentInstances:  0);
            this.pools = null;
        }
        public void ResetMasking()
        {
            this.maskMethod = 2;
            UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            typeof(LlockhamIndustries.Decals.ProjectionLayer[]).__il2cppRuntimeField_20 = "Layer 1";
            typeof(LlockhamIndustries.Decals.ProjectionLayer[]).__il2cppRuntimeField_28 = val_1.m_Mask;
            typeof(LlockhamIndustries.Decals.ProjectionLayer[]).__il2cppRuntimeField_2C = 0;
            UnityEngine.LayerMask val_2 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            typeof(LlockhamIndustries.Decals.ProjectionLayer[]).__il2cppRuntimeField_30 = "Layer 2";
            typeof(LlockhamIndustries.Decals.ProjectionLayer[]).__il2cppRuntimeField_38 = val_2.m_Mask;
            typeof(LlockhamIndustries.Decals.ProjectionLayer[]).__il2cppRuntimeField_3C = 0;
            UnityEngine.LayerMask val_3 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            typeof(LlockhamIndustries.Decals.ProjectionLayer[]).__il2cppRuntimeField_40 = "Layer 3";
            typeof(LlockhamIndustries.Decals.ProjectionLayer[]).__il2cppRuntimeField_48 = val_3.m_Mask;
            typeof(LlockhamIndustries.Decals.ProjectionLayer[]).__il2cppRuntimeField_4C = 0;
            UnityEngine.LayerMask val_4 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            typeof(LlockhamIndustries.Decals.ProjectionLayer[]).__il2cppRuntimeField_50 = "Layer 4";
            typeof(LlockhamIndustries.Decals.ProjectionLayer[]).__il2cppRuntimeField_58 = val_4.m_Mask;
            typeof(LlockhamIndustries.Decals.ProjectionLayer[]).__il2cppRuntimeField_5C = 0;
            this.layers = null;
            this.CalculatePasses();
            if(this.materials != null)
            {
                    this.ClearMaterials();
                return;
            }
            
            this.materials = new System.Collections.Generic.List<UnityEngine.Material>();
            this.materialQueues = new System.Collections.Generic.List<System.Int32>();
        }
        public void ResetGeneral()
        {
            this.replacement = 0;
        }
        public void CalculatePasses()
        {
            var val_3;
            if(this.passes != null)
            {
                    this.passes.Clear();
                val_3 = 0;
            }
            else
            {
                    val_3 = 0;
                this.passes = new System.Collections.Generic.List<LlockhamIndustries.Decals.ReplacementPass>();
                do
            {
                UnityEngine.Vector4 val_2 = this.LayerVector(LayerIndex:  0);
                this.AddToPasses(LayerIndex:  0, LayerVector:  new UnityEngine.Vector4() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
                val_3 = val_3 + 1;
            }
            while(val_3 != 32);
            
            }
        
        }
        private UnityEngine.Vector4 LayerVector(int LayerIndex)
        {
            bool val_1 = LlockhamIndustries.ExtensionMethods.LayerMaskExtensionMethods.Contains(Mask:  new UnityEngine.LayerMask(), Layer:  this.layers[1]);
            bool val_2 = LlockhamIndustries.ExtensionMethods.LayerMaskExtensionMethods.Contains(Mask:  new UnityEngine.LayerMask(), Layer:  this.layers[3]);
            bool val_3 = LlockhamIndustries.ExtensionMethods.LayerMaskExtensionMethods.Contains(Mask:  new UnityEngine.LayerMask(), Layer:  this.layers[5]);
            if((LlockhamIndustries.ExtensionMethods.LayerMaskExtensionMethods.Contains(Mask:  new UnityEngine.LayerMask(), Layer:  this.layers[7])) == false)
            {
                    return new UnityEngine.Vector4() {x = 1f, y = 1f, z = 1f, w = 1f};
            }
            
            return new UnityEngine.Vector4() {x = 1f, y = 1f, z = 1f, w = 1f};
        }
        private void AddToPasses(int LayerIndex, UnityEngine.Vector4 LayerVector)
        {
            goto label_1;
            label_8:
            0 = 1;
            label_1:
            if(0 >= this.passes.Count)
            {
                goto label_3;
            }
            
            LlockhamIndustries.Decals.ReplacementPass val_2 = this.passes.Item[1];
            if((UnityEngine.Vector4.op_Equality(lhs:  new UnityEngine.Vector4() {x = val_2.vector, y = V14.16B, z = V13.16B, w = V12.16B}, rhs:  new UnityEngine.Vector4() {x = LayerVector.x, y = LayerVector.y, z = LayerVector.z, w = LayerVector.w})) == false)
            {
                goto label_8;
            }
            
            LlockhamIndustries.Decals.ReplacementPass val_4 = this.passes.Item[1];
            LlockhamIndustries.Decals.ReplacementPass val_5 = this.passes.Item[1];
            UnityEngine.LayerMask val_6 = LlockhamIndustries.ExtensionMethods.LayerMaskExtensionMethods.Add(Mask:  new UnityEngine.LayerMask(), Layer:  val_5.layers);
            val_4.layers = val_6;
            return;
            label_3:
            this.passes.Add(item:  new LlockhamIndustries.Decals.ReplacementPass(LayerIndex:  LayerIndex, LayerVector:  new UnityEngine.Vector4() {x = LayerVector.x, y = LayerVector.y, z = LayerVector.z, w = LayerVector.w}));
        }
        public void AddMaterial(UnityEngine.Material p_Material)
        {
            System.Collections.Generic.List<UnityEngine.Material> val_5;
            if(p_Material.renderQueue > 2998)
            {
                    return;
            }
            
            val_5 = this.materials;
            if((val_5.Contains(item:  p_Material)) != false)
            {
                    return;
            }
            
            this.materials.Add(item:  p_Material);
            this.materialQueues.Add(item:  p_Material.renderQueue);
            p_Material.renderQueue = 183;
        }
        public void RemoveMaterial(UnityEngine.Material p_Material)
        {
            goto label_1;
            label_7:
            0 = 1;
            label_1:
            if(0 >= this.materials.Count)
            {
                    return;
            }
            
            if(0 != this.materials.Item[1])
            {
                goto label_7;
            }
            
            if(0 == 1)
            {
                    return;
            }
            
            this.RemoveMaterial(p_Index:  1);
        }
        public void RemoveMaterial(int p_Index)
        {
            this.materials.Item[p_Index].renderQueue = this.materialQueues.Item[p_Index];
            this.materials.RemoveAt(index:  p_Index);
            this.materialQueues.RemoveAt(index:  p_Index);
        }
        public void ClearMaterials()
        {
            System.Collections.Generic.List<UnityEngine.Material> val_4 = this.materials;
            val_4 = val_4.Count - 1;
            if((val_4 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                this.materials.Item[val_4].renderQueue = this.materialQueues.Item[val_4];
                this.materials.RemoveAt(index:  val_4);
                this.materialQueues.RemoveAt(index:  val_4);
                val_4 = val_4 - 1;
            }
            while((val_4 & 2147483648) == 0);
        
        }
        public void CalculateVR()
        {
        
        }
    
    }

}
