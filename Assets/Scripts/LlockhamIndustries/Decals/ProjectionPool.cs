using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public class ProjectionPool
    {
        // Fields
        private LlockhamIndustries.Decals.PoolInstance instance;
        private UnityEngine.Transform parent;
        internal System.Collections.Generic.List<LlockhamIndustries.Decals.PoolItem> activePool;
        internal System.Collections.Generic.List<LlockhamIndustries.Decals.PoolItem> inactivePool;
        
        // Properties
        public string Title { get; }
        private int Limit { get; }
        public int ID { get; }
        internal UnityEngine.Transform Parent { get; }
        
        // Methods
        public ProjectionPool(LlockhamIndustries.Decals.PoolInstance Instance)
        {
            this.instance = Instance;
        }
        public string get_Title()
        {
            if(this.instance != null)
            {
                    return (string)this.instance.title;
            }
            
            return (string)this.instance.title;
        }
        private int get_Limit()
        {
            return (int)this.instance.limits[(long)UnityEngine.QualitySettings.GetQualityLevel()];
        }
        public int get_ID()
        {
            if(this.instance != null)
            {
                    return (int)this.instance.id;
            }
            
            return (int)this.instance.id;
        }
        internal UnityEngine.Transform get_Parent()
        {
            UnityEngine.Transform val_6;
            if(0 == this.parent)
            {
                    UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  0 + this.instance.title);
                UnityEngine.Object.DontDestroyOnLoad(target:  0);
                this.parent = transform;
                return val_6;
            }
            
            val_6 = this.parent;
            return val_6;
        }
        public static LlockhamIndustries.Decals.ProjectionPool GetPool(string Title)
        {
            LlockhamIndustries.Decals.DynamicDecals val_1 = LlockhamIndustries.Decals.DynamicDecals.System;
            if(val_1 != null)
            {
                    return val_1.GetPool(Title:  X1);
            }
            
            return val_1.GetPool(Title:  X1);
        }
        public static LlockhamIndustries.Decals.ProjectionPool GetPool(int ID)
        {
            LlockhamIndustries.Decals.DynamicDecals val_1 = LlockhamIndustries.Decals.DynamicDecals.System;
            if(val_1 != null)
            {
                    return val_1.GetPool(ID:  W1);
            }
            
            return val_1.GetPool(ID:  W1);
        }
        public bool CheckIntersecting(UnityEngine.Vector3 Point, float intersectionStrength)
        {
            System.Collections.Generic.List<LlockhamIndustries.Decals.PoolItem> val_7;
            if(this.activePool == null)
            {
                    return false;
            }
            
            val_7 = 1152921511773484976;
            if(this.activePool.Count < 1)
            {
                    return false;
            }
            
            System.Collections.Generic.List<LlockhamIndustries.Decals.PoolItem> val_7 = this.activePool;
            val_7 = val_7.Count - 1;
            if((val_7 & 2147483648) != 0)
            {
                    return false;
            }
            
            label_15:
            LlockhamIndustries.Decals.PoolItem val_3 = this.activePool.Item[val_7];
            val_7 = this.activePool;
            if(0 == val_3.renderer)
            {
                goto label_10;
            }
            
            LlockhamIndustries.Decals.PoolItem val_5 = val_7.Item[val_7];
            val_7 = val_5.renderer;
            if((val_7.CheckIntersecting(Point:  new UnityEngine.Vector3() {x = Point.x, y = Point.y, z = Point.z})) <= intersectionStrength)
            {
                goto label_13;
            }
            
            return false;
            label_10:
            val_7.RemoveAt(index:  val_7);
            label_13:
            val_7 = val_7 - 1;
            if((val_7 & 2147483648) == 0)
            {
                goto label_15;
            }
            
            return false;
        }
        public LlockhamIndustries.Decals.ProjectionRenderer Request(LlockhamIndustries.Decals.ProjectionRenderer Renderer, bool IncludeBehaviours = False)
        {
            goto label_2;
            label_5:
            IncludeBehaviours = IncludeBehaviours;
            0 = this.RequestRenderer(Renderer:  Renderer, IncludeBehaviours:  IncludeBehaviours);
            label_2:
            if(0 == 0)
            {
                goto label_5;
            }
            
            return (LlockhamIndustries.Decals.ProjectionRenderer)0;
        }
        private LlockhamIndustries.Decals.ProjectionRenderer RequestRenderer(LlockhamIndustries.Decals.ProjectionRenderer Renderer, bool IncludeBehaviours = False)
        {
            LlockhamIndustries.Decals.ProjectionRenderer val_10;
            LlockhamIndustries.Decals.ProjectionPool val_11;
            System.Collections.Generic.List<LlockhamIndustries.Decals.PoolItem> val_12;
            System.Collections.Generic.List<LlockhamIndustries.Decals.PoolItem> val_13;
            LlockhamIndustries.Decals.PoolItem val_14;
            val_10 = Renderer;
            val_11 = this;
            val_12 = this.activePool;
            if(val_12 == null)
            {
                    System.Collections.Generic.List<LlockhamIndustries.Decals.PoolItem> val_1 = null;
                val_12 = val_1;
                val_1 = new System.Collections.Generic.List<LlockhamIndustries.Decals.PoolItem>();
                this.activePool = val_12;
            }
            
            if(this.inactivePool == null)
            {
                goto label_2;
            }
            
            if(this.inactivePool.Count <= 0)
            {
                goto label_3;
            }
            
            val_13 = this.inactivePool;
            val_14 = this.inactivePool.Item[0];
            if(val_13 != null)
            {
                goto label_15;
            }
            
            goto label_6;
            label_3:
            val_12 = this.activePool;
            label_2:
            if(val_12.Count < this.Limit)
            {
                    LlockhamIndustries.Decals.PoolItem val_6 = null;
                val_14 = val_6;
                val_6 = new LlockhamIndustries.Decals.PoolItem(Pool:  this);
                IncludeBehaviours = IncludeBehaviours;
                Initialize(Renderer:  val_10, IncludeBehaviours:  IncludeBehaviours);
                val_10 = this.activePool;
                val_10.Add(item:  val_14);
                if(null != 0)
            {
                    return (LlockhamIndustries.Decals.ProjectionRenderer)mem[val_7.renderer];
            }
            
                return (LlockhamIndustries.Decals.ProjectionRenderer)mem[val_7.renderer];
            }
            
            val_14 = this.activePool.Item[0];
            val_14.Terminate();
            val_13 = this.activePool;
            if(val_13 != null)
            {
                goto label_15;
            }
            
            label_6:
            label_15:
            val_13.RemoveAt(index:  0);
            val_11 = this.activePool;
            val_11.Add(item:  val_14);
            if(val_14 != null)
            {
                    val_14.Initialize(Renderer:  val_10, IncludeBehaviours:  IncludeBehaviours);
                return (LlockhamIndustries.Decals.ProjectionRenderer)mem[val_7.renderer];
            }
            
            val_14.Initialize(Renderer:  val_10, IncludeBehaviours:  IncludeBehaviours);
            return (LlockhamIndustries.Decals.ProjectionRenderer)mem[val_7.renderer];
        }
    
    }

}
