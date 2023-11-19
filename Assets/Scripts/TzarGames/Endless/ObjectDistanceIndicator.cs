using UnityEngine;

namespace TzarGames.Endless
{
    public class ObjectDistanceIndicator : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Transform observer;
        [UnityEngine.SerializeField]
        private float maximumDistance;
        [UnityEngine.SerializeField]
        private float checkInterval;
        private float lastCheckTime;
        private System.Collections.Generic.List<UnityEngine.Transform> observedTransforms;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <NormalizedDistance>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Endless.ObjectDistanceIndicator> OnObservedCountChanged;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Sprite <Icon>k__BackingField;
        
        // Properties
        public float NormalizedDistance { get; set; }
        public UnityEngine.Sprite Icon { get; set; }
        public int ObservedObjectsCount { get; }
        
        // Methods
        public ObjectDistanceIndicator()
        {
            this.maximumDistance = 25f;
            this.checkInterval = 5.510186E-41f;
            this.observedTransforms = new System.Collections.Generic.List<UnityEngine.Transform>();
        }
        public float get_NormalizedDistance()
        {
            return (float)this.<NormalizedDistance>k__BackingField;
        }
        private void set_NormalizedDistance(float value)
        {
            this.<NormalizedDistance>k__BackingField = value;
        }
        public void add_OnObservedCountChanged(System.Action<TzarGames.Endless.ObjectDistanceIndicator> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnObservedCountChanged);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510750027184 != this.OnObservedCountChanged);
        
        }
        public void remove_OnObservedCountChanged(System.Action<TzarGames.Endless.ObjectDistanceIndicator> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnObservedCountChanged);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510750163760 != this.OnObservedCountChanged);
        
        }
        public UnityEngine.Sprite get_Icon()
        {
            return (UnityEngine.Sprite)this.<Icon>k__BackingField;
        }
        public void set_Icon(UnityEngine.Sprite value)
        {
            this.<Icon>k__BackingField = value;
        }
        public int get_ObservedObjectsCount()
        {
            if(this.observedTransforms != null)
            {
                    return this.observedTransforms.Count;
            }
            
            return this.observedTransforms.Count;
        }
        public void AddObservingObject(UnityEngine.Transform obj)
        {
            System.Collections.Generic.List<UnityEngine.Transform> val_3 = this.observedTransforms;
            if((val_3.Contains(item:  obj)) == true)
            {
                    return;
            }
            
            val_3 = this.observedTransforms;
            val_3.Add(item:  obj);
            if(this.OnObservedCountChanged == null)
            {
                    return;
            }
            
            this.OnObservedCountChanged.Invoke(obj:  this);
        }
        public void RemoveObservingObject(UnityEngine.Transform obj)
        {
            bool val_1 = this.observedTransforms.Remove(item:  obj);
            if(this.OnObservedCountChanged == null)
            {
                    return;
            }
            
            this.OnObservedCountChanged.Invoke(obj:  this);
        }
        private void Update()
        {
            float val_1 = UnityEngine.Time.time;
            float val_2 = this.lastCheckTime;
            val_2 = val_1 - val_2;
            if(val_2 < this.checkInterval)
            {
                    return;
            }
            
            this.lastCheckTime = val_1;
            this.check();
        }
        private void check()
        {
            var val_15;
            UnityEngine.Object val_16;
            float val_17;
            UnityEngine.Vector3 val_1 = this.observer.position;
            float val_2 = this.maximumDistance * this.maximumDistance;
            val_15 = this.observedTransforms.Count - 1;
            if((val_15 & 2147483648) != 0)
            {
                goto label_3;
            }
            
            label_16:
            label_14:
            val_15 = val_15 - 1;
            int val_5 = val_15 + 1;
            val_16 = this.observedTransforms.Item[val_5];
            if(0 != val_16)
            {
                goto label_7;
            }
            
            this.observedTransforms.RemoveAt(index:  val_5);
            goto label_9;
            label_7:
            UnityEngine.Vector3 val_8 = val_16.position;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_17 = val_9.x;
            if(val_17 <= val_2)
            {
                goto label_13;
            }
            
            label_9:
            int val_10 = val_15 - 1;
            if((val_15 & 2147483648) == 0)
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            if((val_15 & 2147483648) == 0)
            {
                goto label_16;
            }
            
            goto label_18;
            label_15:
            val_16 = 0;
            val_17 = val_2;
            goto label_18;
            label_3:
            val_16 = 0;
            val_17 = val_2;
            label_18:
            this.<NormalizedDistance>k__BackingField = (0 != val_16) ? 1f : (val_17 / val_2);
        }
        private void Reset()
        {
            this.observer = this.transform;
        }
        public void OnPushedToPool()
        {
            this.enabled = false;
            this.lastCheckTime = 0f;
            this.observedTransforms.Clear();
        }
        public void OnPulledFromPool()
        {
            this.enabled = true;
        }
    
    }

}
