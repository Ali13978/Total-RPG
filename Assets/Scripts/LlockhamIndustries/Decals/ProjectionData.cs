using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public class ProjectionData
    {
        // Fields
        public LlockhamIndustries.Decals.Projection projection;
        public System.Collections.Generic.List<LlockhamIndustries.Decals.ProjectionRenderer> instances;
        
        // Methods
        public ProjectionData(LlockhamIndustries.Decals.Projection Projection)
        {
            this.projection = Projection;
            this.instances = new System.Collections.Generic.List<LlockhamIndustries.Decals.ProjectionRenderer>();
        }
        public void Update()
        {
            this.projection.Update();
        }
        public void Add(LlockhamIndustries.Decals.ProjectionRenderer Instance)
        {
            LlockhamIndustries.Decals.ProjectionRenderer val_4;
            System.Collections.Generic.List<LlockhamIndustries.Decals.ProjectionRenderer> val_5;
            val_4 = Instance;
            val_5 = this.instances;
            if((val_5.Contains(item:  val_4)) == true)
            {
                    return;
            }
            
            val_5 = this.instances;
            val_5.Add(item:  val_4);
            Instance.data = this;
            val_4 = LlockhamIndustries.Decals.DynamicDecals.System;
            val_3.renderersMarked = true;
        }
        public void Remove(LlockhamIndustries.Decals.ProjectionRenderer Instance)
        {
            bool val_1 = this.instances.Remove(item:  Instance);
            if(Instance.data != this)
            {
                    return;
            }
            
            Instance.data = 0;
        }
        public void MoveToTop(LlockhamIndustries.Decals.ProjectionRenderer Instance)
        {
            bool val_1 = this.instances.Remove(item:  Instance);
            this.instances.Add(item:  Instance);
            LlockhamIndustries.Decals.DynamicDecals val_2 = LlockhamIndustries.Decals.DynamicDecals.System;
            val_2.renderersMarked = true;
        }
        public void MoveToBottom(LlockhamIndustries.Decals.ProjectionRenderer Instance)
        {
            bool val_1 = this.instances.Remove(item:  Instance);
            this.instances.Insert(index:  0, item:  Instance);
            LlockhamIndustries.Decals.DynamicDecals val_2 = LlockhamIndustries.Decals.DynamicDecals.System;
            val_2.renderersMarked = true;
        }
        public void AssertOrder(ref int Order)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = 1152921511763817536;
            if(this.projection.Instanced == false)
            {
                goto label_3;
            }
            
            List.Enumerator<T> val_2 = this.instances.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            0.InitializationCallback.sortingOrder = Order;
            goto label_7;
            label_3:
            List.Enumerator<T> val_4 = this.instances.GetEnumerator();
            val_8 = 1152921511763750272;
            goto label_9;
            label_13:
            int val_6 = Order;
            val_6 = val_6 + 1;
            Order = val_6;
            label_9:
            if((0 & 1) == 0)
            {
                goto label_10;
            }
            
            0.InitializationCallback.sortingOrder = Order;
            goto label_13;
            label_4:
            val_7 = 0;
            val_8 = 1;
            0.Dispose();
            int val_7 = Order;
            val_7 = val_7 + 1;
            Order = val_7;
            return;
            label_10:
            val_6 = 0;
            val_9 = 1;
            0.Dispose();
            if((val_9 & 1) != 0)
            {
                    return;
            }
            
            if(val_6 == 0)
            {
                    return;
            }
        
        }
        public void EnableRenderers()
        {
            goto label_1;
            label_6:
            X21.InitializeRenderer(Active:  true);
            0 = 1;
            label_1:
            if(0 >= this.instances.Count)
            {
                    return;
            }
            
            if(this.instances.Item[1] != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        public void DisableRenderers()
        {
            goto label_1;
            label_6:
            X21.TerminateRenderer();
            0 = 1;
            label_1:
            if(0 >= this.instances.Count)
            {
                    return;
            }
            
            if(this.instances.Item[1] != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        public void UpdateRenderers()
        {
            goto label_1;
            label_6:
            X21.UpdateProjection();
            0 = 1;
            label_1:
            if(0 >= this.instances.Count)
            {
                    return;
            }
            
            if(this.instances.Item[1] != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
    
    }

}
