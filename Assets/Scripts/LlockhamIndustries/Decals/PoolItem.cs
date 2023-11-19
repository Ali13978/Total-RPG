using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public class PoolItem
    {
        // Fields
        private LlockhamIndustries.Decals.ProjectionPool pool;
        private LlockhamIndustries.Decals.ProjectionRenderer renderer;
        
        // Properties
        public LlockhamIndustries.Decals.ProjectionPool Pool { get; }
        public LlockhamIndustries.Decals.ProjectionRenderer Renderer { get; }
        private bool Valid { get; }
        
        // Methods
        public PoolItem(LlockhamIndustries.Decals.ProjectionPool Pool)
        {
            this.pool = Pool;
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "Projection");
            transform.SetParent(parent:  this.pool.Parent);
            if(null != 0)
            {
                    SetActive(value:  false);
            }
            else
            {
                    SetActive(value:  false);
            }
            
            this.renderer = AddComponent<LlockhamIndustries.Decals.ProjectionRenderer>();
            val_4.poolItem = this;
        }
        public LlockhamIndustries.Decals.ProjectionPool get_Pool()
        {
            return (LlockhamIndustries.Decals.ProjectionPool)this.pool;
        }
        public LlockhamIndustries.Decals.ProjectionRenderer get_Renderer()
        {
            return (LlockhamIndustries.Decals.ProjectionRenderer)this.renderer;
        }
        private bool get_Valid()
        {
            var val_4;
            if(0 == this.renderer)
            {
                    if(this.pool.activePool != null)
            {
                    bool val_2 = this.pool.activePool.Remove(item:  this);
            }
            
                if(this.pool.inactivePool != null)
            {
                    bool val_3 = this.pool.inactivePool.Remove(item:  this);
            }
            
                val_4 = 0;
                return (bool)val_4;
            }
            
            val_4 = 1;
            return (bool)val_4;
        }
        internal void Initialize(LlockhamIndustries.Decals.ProjectionRenderer Renderer, bool IncludeBehaviours = False)
        {
            var val_35;
            UnityEngine.Transform val_36;
            var val_37;
            float val_38;
            float val_39;
            val_35 = IncludeBehaviours;
            if(this.Valid == false)
            {
                    return;
            }
            
            val_36 = this.pool.Parent;
            this.renderer.transform.SetParent(parent:  val_36);
            if(0 == Renderer)
            {
                goto label_7;
            }
            
            this.renderer.Projection = Renderer.Projection;
            this.renderer.Tiling = new UnityEngine.Vector2() {x = Renderer.tiling, y = V9.16B};
            this.renderer.Offset = new UnityEngine.Vector2() {x = Renderer.offset, y = V9.16B};
            if(this.renderer.maskMethod != Renderer.maskMethod)
            {
                    this.renderer.maskMethod = Renderer.maskMethod;
                this.renderer.marked = true;
            }
            
            this.renderer.MaskLayer1 = Renderer.MaskLayer1;
            this.renderer.MaskLayer2 = Renderer.MaskLayer2;
            this.renderer.MaskLayer3 = Renderer.MaskLayer3;
            this.renderer.MaskLayer4 = Renderer.MaskLayer4;
            val_36 = Renderer.properties;
            this.renderer.Properties = val_36;
            if(val_35 == false)
            {
                goto label_30;
            }
            
            val_37 = 0;
            goto label_28;
            label_43:
            val_37 = 1;
            label_28:
            if(val_37 >= val_14.Length)
            {
                goto label_30;
            }
            
            T val_35 = Renderer.GetComponents<UnityEngine.MonoBehaviour>()[1];
            if((val_35.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) || (val_35.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))))
            {
                goto label_43;
            }
            
            LlockhamIndustries.ExtensionMethods.GameObjectExtensionMethods.AddComponent(GameObject:  0, Source:  this.renderer.gameObject).enabled = val_35.enabled;
            goto label_43;
            label_7:
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.one;
            val_38 = val_24.x;
            val_39 = val_24.z;
            this.renderer.transform.localScale = new UnityEngine.Vector3() {x = val_38, y = val_24.y, z = val_39};
            goto label_48;
            label_30:
            UnityEngine.Vector3 val_27 = Renderer.transform.localScale;
            val_38 = val_27.x;
            val_39 = val_27.z;
            this.renderer.transform.localScale = new UnityEngine.Vector3() {x = val_38, y = val_27.y, z = val_39};
            this.renderer.gameObject.layer = Renderer.gameObject.layer;
            val_35 = this.renderer.gameObject;
            val_35.tag = Renderer.gameObject.tag;
            label_48:
            this.renderer.gameObject.SetActive(value:  true);
        }
        internal void Terminate()
        {
            var val_11;
            if(this.Valid == false)
            {
                    return;
            }
            
            this.renderer.gameObject.SetActive(value:  false);
            val_11 = 0;
            goto label_6;
            label_20:
            val_11 = 1;
            label_6:
            if(val_11 >= val_4.Length)
            {
                goto label_8;
            }
            
            T val_11 = this.renderer.gameObject.GetComponents<UnityEngine.Component>()[1];
            if((val_11.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) || (val_11.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))))
            {
                goto label_20;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
            goto label_20;
            label_8:
            this.renderer.transform.SetParent(parent:  this.pool.Parent);
        }
        public void Return()
        {
            bool val_1 = this.pool.activePool.Remove(item:  this);
            this.Terminate();
            if(this.pool.inactivePool == null)
            {
                    this.pool.inactivePool = new System.Collections.Generic.List<LlockhamIndustries.Decals.PoolItem>();
            }
            
            this.pool.inactivePool.Add(item:  this);
        }
    
    }

}
