using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [UnityEngine.ExecuteInEditMode]
    public class ProjectionRenderer : MonoBehaviour
    {
        // Fields
        private UnityEngine.MaterialPropertyBlock block;
        private bool marked;
        [UnityEngine.SerializeField]
        private LlockhamIndustries.Decals.Projection projection;
        private LlockhamIndustries.Decals.Projection active;
        [UnityEngine.SerializeField]
        private LlockhamIndustries.Decals.ProjectionProperty[] properties;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector2 tiling;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector2 offset;
        [UnityEngine.SerializeField]
        protected LlockhamIndustries.Decals.MaskMethod maskMethod;
        [UnityEngine.SerializeField]
        protected bool[] masks;
        private UnityEngine.MeshRenderer meshRenderer;
        private LlockhamIndustries.Decals.ProjectionData data;
        private LlockhamIndustries.Decals.PoolItem poolItem;
        public int _TilingOffset;
        public int _MaskBase;
        public int _MaskLayers;
        
        // Properties
        public LlockhamIndustries.Decals.ProjectionProperty[] Properties { get; set; }
        public UnityEngine.Vector2 Tiling { get; set; }
        public UnityEngine.Vector2 Offset { get; set; }
        public LlockhamIndustries.Decals.MaskMethod MaskMethod { get; set; }
        public bool MaskLayer1 { get; set; }
        public bool MaskLayer2 { get; set; }
        public bool MaskLayer3 { get; set; }
        public bool MaskLayer4 { get; set; }
        public LlockhamIndustries.Decals.Projection Projection { get; set; }
        public UnityEngine.MeshRenderer Renderer { get; }
        public LlockhamIndustries.Decals.ProjectionData Data { get; set; }
        public LlockhamIndustries.Decals.ProjectionPool Pool { get; }
        public LlockhamIndustries.Decals.PoolItem PoolItem { get; set; }
        
        // Methods
        public ProjectionRenderer()
        {
            this.marked = true;
            this.masks = null;
        }
        public LlockhamIndustries.Decals.ProjectionProperty[] get_Properties()
        {
            return (LlockhamIndustries.Decals.ProjectionProperty[])this.properties;
        }
        public void set_Properties(LlockhamIndustries.Decals.ProjectionProperty[] value)
        {
            var val_3;
            LlockhamIndustries.Decals.ProjectionProperty[] val_4;
            if(value != null)
            {
                    object val_1 = value.Clone();
                val_4 = 0;
                if(val_1 != null)
            {
                    val_4 = val_1;
                val_3 = null;
                if(val_4 == null)
            {
                    val_4 = 0;
            }
            
            }
            
                this.properties = val_4;
            }
            else
            {
                    this.properties = 0;
            }
            
            this.marked = true;
        }
        public void ResetProperties(bool UpdateImmediately = False)
        {
            LlockhamIndustries.Decals.Projection val_7;
            LlockhamIndustries.Decals.ProjectionProperty[] val_8;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.one;
            this.tiling = val_1;
            mem[1152921511825260676] = val_1.y;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this.offset = val_2;
            mem[1152921511825260684] = val_2.y;
            this.maskMethod = 0;
            this.masks = null;
            val_7 = this.projection;
            if(0 != val_7)
            {
                    val_7 = this.projection.properties.Clone();
                val_8 = 0;
                if(val_7 != null)
            {
                    val_8 = val_7;
                if(val_8 == null)
            {
                    val_8 = 0;
            }
            
            }
            
                this.properties = val_8;
            }
            else
            {
                    this.properties = 0;
            }
            
            this.MarkProperties(UpdateImmediately:  UpdateImmediately);
        }
        public void UpdateProperties()
        {
            if(0 == this.meshRenderer)
            {
                    return;
            }
            
            if(this.marked == false)
            {
                    return;
            }
            
            if(0 == this.Projection)
            {
                    return;
            }
            
            LlockhamIndustries.Decals.Projection val_4 = this.Projection;
            this.UpdateRendererBlock(Local:  this.properties, Global:  val_4.properties);
            1152921504721543168 = this.block;
            this.meshRenderer.SetPropertyBlock(properties:  1152921504721543168);
            this.marked = false;
        }
        public void MarkProperties(bool UpdateImmediately = False)
        {
            this.marked = true;
            if(UpdateImmediately == false)
            {
                    return;
            }
            
            if(0 == this.meshRenderer)
            {
                    return;
            }
            
            this.UpdateProperties();
        }
        public void SetFloat(int PropertyIndex, float Float)
        {
            var val_1 = this.properties + ((long)PropertyIndex * 40);
            if((((long)(int)(PropertyIndex) * 40) + this.properties + 44) != 1)
            {
                    var val_2 = this.properties + ((long)PropertyIndex * 40);
                if((((long)(int)(PropertyIndex) * 40) + this.properties + 44) != 2)
            {
                    return;
            }
            
            }
            
            var val_3 = this.properties + ((long)PropertyIndex * 40);
            if((((long)(int)(PropertyIndex) * 40) + this.properties + 64) == Float)
            {
                    return;
            }
            
            var val_4 = this.properties + ((long)PropertyIndex * 40);
            mem2[0] = Float;
            var val_5 = this.properties + ((long)PropertyIndex * 40);
            mem2[0] = true;
            this.marked = true;
        }
        public void SetColor(int PropertyIndex, UnityEngine.Color Color)
        {
            var val_1 = this.properties + ((long)PropertyIndex * 40);
            if((((long)(int)(PropertyIndex) * 40) + this.properties + 44) != 0)
            {
                    var val_2 = this.properties + ((long)PropertyIndex * 40);
                if((((long)(int)(PropertyIndex) * 40) + this.properties + 44) != 2)
            {
                    return;
            }
            
            }
            
            var val_3 = this.properties + ((long)PropertyIndex * 40);
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = ((long)(int)(PropertyIndex) * 40) + this.properties + 48, g = ((long)(int)(PropertyIndex) * 40) + this.properties + 48 + 4, b = ((long)(int)(PropertyIndex) * 40) + this.properties + 56, a = ((long)(int)(PropertyIndex) * 40) + this.properties + 56 + 4}, rhs:  new UnityEngine.Color() {r = Color.r, g = Color.g, b = Color.b, a = Color.a})) == false)
            {
                    return;
            }
            
            var val_5 = this.properties + ((long)PropertyIndex * 40);
            mem2[0] = Color.r;
            mem2[0] = Color.g;
            mem2[0] = Color.b;
            mem2[0] = Color.a;
            var val_6 = this.properties + ((long)PropertyIndex * 40);
            mem2[0] = true;
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
            mem[1152921511826915716] = value.y;
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
            mem[1152921511827139724] = value.y;
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
        public LlockhamIndustries.Decals.Projection get_Projection()
        {
            LlockhamIndustries.Decals.Projection val_5;
            if(this.gameObject.activeInHierarchy != false)
            {
                    val_5 = this;
                if(0 != this.active)
            {
                    return (LlockhamIndustries.Decals.Projection)mem[this.projection];
            }
            
            }
            
            val_5 = this.projection;
            return (LlockhamIndustries.Decals.Projection)mem[this.projection];
        }
        public void set_Projection(LlockhamIndustries.Decals.Projection value)
        {
            if(0 == this.projection)
            {
                    return;
            }
            
            this.projection = value;
            this.ChangeProjection();
        }
        public void ChangeProjection()
        {
            LlockhamIndustries.Decals.ProjectionProperty[] val_14;
            if(0 != this.active)
            {
                    if((this.gameObject.activeInHierarchy != false) && (this.enabled != false))
            {
                    if(0 != this.active)
            {
                    this.Deregister();
            }
            
            }
            
                this.active = this.projection;
                if((this.gameObject.activeInHierarchy != false) && (this.enabled != false))
            {
                    if(0 != this.active)
            {
                    bool val_10 = this.Register();
            }
            
            }
            
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.one;
                this.tiling = val_11;
                mem[1152921511829611524] = val_11.y;
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
                this.offset = val_12;
                mem[1152921511829611532] = val_12.y;
                if(0 != this.active)
            {
                    val_14 = this.active.properties;
            }
            else
            {
                    val_14 = 0;
            }
            
                this.Properties = val_14;
            }
            
            this.UpdateProjection();
        }
        public void UpdateProjection()
        {
            UnityEngine.MaterialPropertyBlock val_11;
            UnityEngine.MaterialPropertyBlock val_12;
            val_11 = 1152921504721543168;
            if(0 == this.meshRenderer)
            {
                    return;
            }
            
            if(0 != this.Projection)
            {
                    if(this.Projection.Valid != false)
            {
                    this.meshRenderer.gameObject.SetActive(value:  true);
                this.meshRenderer.sharedMaterial = this.Projection.Mat;
                LlockhamIndustries.Decals.Projection val_9 = this.Projection;
                this.UpdateRendererBlock(Local:  this.properties, Global:  val_9.properties);
                val_11 = this.block;
                this.meshRenderer.SetPropertyBlock(properties:  val_11);
                this.marked = false;
                return;
            }
            
            }
            
            this.meshRenderer.gameObject.SetActive(value:  false);
            this.meshRenderer.sharedMaterial = 0;
            val_12 = 0;
            if(this.block != null)
            {
                    this.block.Clear();
                val_12 = this.block;
            }
            
            this.meshRenderer.SetPropertyBlock(properties:  val_12);
        }
        private bool Register()
        {
            if(0 == this)
            {
                    return false;
            }
            
            LlockhamIndustries.Decals.DynamicDecals val_2 = LlockhamIndustries.Decals.DynamicDecals.System;
            if(val_2 != null)
            {
                    return val_2.Register(Instance:  this);
            }
            
            return val_2.Register(Instance:  this);
        }
        private void Deregister()
        {
            if(0 == this)
            {
                    return;
            }
            
            LlockhamIndustries.Decals.DynamicDecals.System.Deregister(Instance:  this);
        }
        public UnityEngine.MeshRenderer get_Renderer()
        {
            return (UnityEngine.MeshRenderer)this.meshRenderer;
        }
        public void InitializeRenderer(bool Active)
        {
            var val_25;
            var val_26;
            var val_27;
            UnityEngine.Mesh val_28;
            var val_29;
            UnityEngine.MeshRenderer val_30;
            if(0 != this.meshRenderer)
            {
                goto label_36;
            }
            
            System.Collections.IEnumerator val_3 = this.transform.GetEnumerator();
            goto label_16;
            label_24:
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_25 = val_3;
            if((System.String.op_Equality(a:  0, b:  0.name)) == false)
            {
                goto label_16;
            }
            
            goto label_17;
            label_16:
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_26 = val_3;
            if(((val_3 & 1) & 1) != 0)
            {
                goto label_24;
            }
            
            val_27 = 0;
            goto label_25;
            label_17:
            val_27 = 0;
            this.meshRenderer = 0.GetComponent<UnityEngine.MeshRenderer>();
            label_25:
            val_28 = 120;
            if(val_3 != null)
            {
                    var val_27 = 0;
                val_27 = val_27 + 1;
                val_29 = val_3;
            }
            
            label_36:
            val_30 = this.meshRenderer;
            if(0 == val_30)
            {
                    UnityEngine.GameObject val_14 = new UnityEngine.GameObject(name:  "Renderer");
                transform.SetParent(parent:  this.transform, worldPositionStays:  false);
                int val_18 = this.gameObject.layer;
                if(null != 0)
            {
                    layer = val_18;
                hideFlags = 21;
            }
            else
            {
                    layer = val_18;
                0.hideFlags = 21;
            }
            
                val_28 = LlockhamIndustries.Decals.DynamicDecals.System.Cube;
                AddComponent<UnityEngine.MeshFilter>().sharedMesh = val_28;
                UnityEngine.MeshRenderer val_22 = AddComponent<UnityEngine.MeshRenderer>();
                this.meshRenderer = val_22;
                val_22.shadowCastingMode = 0;
                this.meshRenderer.motionVectorGenerationMode = 0;
                val_30 = this.meshRenderer;
                val_30.lightProbeUsage = 1;
            }
            
            this.meshRenderer.gameObject.SetActive(value:  Active);
        }
        public void TerminateRenderer()
        {
            this.meshRenderer.gameObject.SetActive(value:  false);
        }
        private void UpdateRendererBlock(LlockhamIndustries.Decals.ProjectionProperty[] Local, LlockhamIndustries.Decals.ProjectionProperty[] Global)
        {
            UnityEngine.MaterialPropertyBlock val_10;
            int val_11;
            System.Boolean[] val_16;
            float val_17;
            float val_18;
            float val_19;
            float val_20;
            var val_21;
            var val_22;
            var val_23;
            int val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            var val_29;
            int val_30;
            if(this.block != null)
            {
                    this.block.Clear();
                val_10 = this.block;
            }
            else
            {
                    UnityEngine.MaterialPropertyBlock val_1 = null;
                val_10 = val_1;
                val_1 = new UnityEngine.MaterialPropertyBlock();
                this.block = val_10;
            }
            
            val_11 = this._TilingOffset;
            SetVector(nameID:  val_11, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            if(this.maskMethod == 1)
            {
                goto label_4;
            }
            
            if(this.maskMethod != 0)
            {
                goto label_5;
            }
            
            this.block.SetFloat(nameID:  this._MaskBase, value:  1f);
            UnityEngine.Color val_2 = UnityEngine.Color.clear;
            bool val_19 = this.masks[0];
            val_16 = this.masks;
            val_17 = 0.5f;
            val_18 = 0f;
            goto label_9;
            label_4:
            this.block.SetFloat(nameID:  this._MaskBase, value:  0f);
            UnityEngine.Color val_3 = UnityEngine.Color.clear;
            val_16 = this.masks;
            val_17 = 0.5f;
            val_18 = 1f;
            label_9:
            val_11 = this._MaskLayers;
            UnityEngine.Vector4 val_8 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = (this.masks[0] == true) ? (val_18) : (val_17), g = (val_16[1] == true) ? (val_18) : (val_17), b = (this.masks[2] == true) ? (val_18) : (val_17), a = (this.masks[3] == true) ? (val_18) : (val_17)});
            val_19 = val_8.y;
            val_20 = val_8.w;
            this.block.SetVector(nameID:  val_11, value:  new UnityEngine.Vector4() {x = val_8.x, y = val_19, z = val_8.z, w = val_20});
            label_5:
            val_21 = 0;
            goto label_20;
            label_60:
            val_21 = 1;
            label_20:
            if(val_21 >= Local.Length)
            {
                    return;
            }
            
            var val_9 = Local + (1 * 40);
            if(((1 * 40) + Local + 44) != 1)
            {
                goto label_24;
            }
            
            var val_10 = Local + (1 * 40);
            if(((1 * 40) + Local + 68) == 0)
            {
                goto label_26;
            }
            
            val_22 = Local;
            if(val_21 < Local.Length)
            {
                goto label_30;
            }
            
            val_22 = Local;
            goto label_30;
            label_26:
            val_22 = Global;
            if(val_21 >= Global.Length)
            {
                    val_22 = Global;
            }
            
            label_30:
            val_22 = val_22 + (1 * 40);
            var val_11 = Global + (1 * 40);
            this.block.SetFloat(nameID:  (1 * 40) + Global + 40, value:  (1 * 40) + Global + 64);
            label_24:
            if(((1 * 40) + Local + 44) == 0)
            {
                    var val_12 = Local + (1 * 40);
                if(((1 * 40) + Local + 68) != 0)
            {
                    val_23 = Local + (1 * 40);
            }
            else
            {
                    val_23 = Global + (1 * 40);
            }
            
                val_19 = mem[(1 * 40) + Global + 52];
                val_19 = (1 * 40) + Global + 52;
                val_20 = mem[(1 * 40) + Global + 60];
                val_20 = (1 * 40) + Global + 60;
                var val_13 = Global + (1 * 40);
                this.block.SetColor(nameID:  (1 * 40) + Global + 40, value:  new UnityEngine.Color() {r = (1 * 40) + Global + 48, g = val_19, b = (1 * 40) + Global + 56, a = val_20});
            }
            
            if(((1 * 40) + Local + 44) != 2)
            {
                goto label_60;
            }
            
            var val_14 = Local + (1 * 40);
            if(((1 * 40) + Local + 68) != 0)
            {
                    val_24 = Local.Length;
                if(val_21 >= val_24)
            {
                    val_24 = Local.Length;
            }
            
                var val_15 = Local + (1 * 40);
                val_25 = mem[(1 * 40) + Local + 48];
                val_25 = (1 * 40) + Local + 48;
                val_26 = mem[(1 * 40) + Local + 48 + 4];
                val_26 = (1 * 40) + Local + 48 + 4;
                val_27 = mem[(1 * 40) + Local + 56];
                val_27 = (1 * 40) + Local + 56;
                val_28 = mem[(1 * 40) + Local + 56 + 4];
                val_28 = (1 * 40) + Local + 56 + 4;
                val_29 = Local + (1 * 40);
            }
            else
            {
                    val_30 = Global.Length;
                if(val_21 >= val_30)
            {
                    val_30 = Global.Length;
            }
            
                var val_16 = Global + (1 * 40);
                val_25 = mem[(1 * 40) + Global + 48];
                val_25 = (1 * 40) + Global + 48;
                val_26 = mem[(1 * 40) + Global + 48 + 4];
                val_26 = (1 * 40) + Global + 48 + 4;
                val_27 = mem[(1 * 40) + Global + 56];
                val_27 = (1 * 40) + Global + 56;
                val_28 = mem[(1 * 40) + Global + 56 + 4];
                val_28 = (1 * 40) + Global + 56 + 4;
                val_29 = Global + (1 * 40);
            }
            
            UnityEngine.Color val_17 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = val_25, g = val_26, b = val_27, a = val_28}, b:  (1 * 40) + Global + 64);
            var val_18 = Global + (1 * 40);
            this.block.SetColor(nameID:  (1 * 40) + Global + 40, value:  new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a});
            goto label_60;
        }
        private void OnEnable()
        {
            this._TilingOffset = UnityEngine.Shader.PropertyToID(name:  0);
            this._MaskBase = UnityEngine.Shader.PropertyToID(name:  0);
            this._MaskLayers = UnityEngine.Shader.PropertyToID(name:  0);
            this.Initialize();
        }
        private void OnDisable()
        {
            this.Terminate();
        }
        private void Initialize()
        {
            var val_4;
            if(0 != this.projection)
            {
                    this.active = this.projection;
                val_4 = this.Register();
            }
            else
            {
                    val_4 = 0;
            }
            
            this.InitializeRenderer(Active:  false);
            this.UpdateProjection();
        }
        private void Terminate()
        {
            if(0 != this.projection)
            {
                    this.Deregister();
            }
            
            this.TerminateRenderer();
        }
        public LlockhamIndustries.Decals.ProjectionData get_Data()
        {
            return (LlockhamIndustries.Decals.ProjectionData)this.data;
        }
        public void set_Data(LlockhamIndustries.Decals.ProjectionData value)
        {
            this.data = value;
        }
        public void MoveToTop()
        {
            if(this.data == null)
            {
                    return;
            }
            
            this.data.MoveToTop(Instance:  this);
        }
        public void MoveToBottom()
        {
            if(this.data == null)
            {
                    return;
            }
            
            this.data.MoveToBottom(Instance:  this);
        }
        public LlockhamIndustries.Decals.ProjectionPool get_Pool()
        {
            if(this.poolItem == null)
            {
                    return 0;
            }
            
            return (LlockhamIndustries.Decals.ProjectionPool)this.poolItem.pool;
        }
        public LlockhamIndustries.Decals.PoolItem get_PoolItem()
        {
            return (LlockhamIndustries.Decals.PoolItem)this.poolItem;
        }
        public void set_PoolItem(LlockhamIndustries.Decals.PoolItem value)
        {
            this.poolItem = value;
        }
        public float CheckIntersecting(UnityEngine.Vector3 Point)
        {
            UnityEngine.Vector3 val_2 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = Point.x, y = Point.y, z = Point.z});
            float val_4 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Max(a:  System.Math.Abs(val_2.x), b:  System.Math.Abs(val_2.y)), b:  System.Math.Abs(val_2.z));
            val_4 = 0.5f - val_4;
            val_4 = val_4 + val_4;
            return UnityEngine.Mathf.Clamp01(value:  val_4);
        }
        public void Destroy()
        {
            if(this.poolItem != null)
            {
                    this.poolItem.Return();
                return;
            }
            
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
    
    }

}
