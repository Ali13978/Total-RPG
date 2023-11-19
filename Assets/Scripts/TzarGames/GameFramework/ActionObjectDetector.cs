using UnityEngine;

namespace TzarGames.GameFramework
{
    public class ActionObjectDetector : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private float radius;
        [UnityEngine.SerializeField]
        private float heightOffset;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask layers;
        private System.Collections.Generic.List<TzarGames.GameFramework.IObjectAction> availableActions;
        private UnityEngine.Transform cachedTransform;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.GameFramework.ActionObjectDetector> OnActionsChanged;
        private System.Collections.Generic.List<TzarGames.GameFramework.ActionObjectBehaviour> triggeredBehaviours;
        private System.Collections.Generic.List<UnityEngine.Collider> touchingColliders;
        
        // Methods
        public ActionObjectDetector()
        {
            this.radius = 2f;
            this.availableActions = new System.Collections.Generic.List<TzarGames.GameFramework.IObjectAction>();
            this.triggeredBehaviours = new System.Collections.Generic.List<TzarGames.GameFramework.ActionObjectBehaviour>();
            this.touchingColliders = new System.Collections.Generic.List<UnityEngine.Collider>();
        }
        public void add_OnActionsChanged(System.Action<TzarGames.GameFramework.ActionObjectDetector> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnActionsChanged);
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
            while(1152921511261978488 != this.OnActionsChanged);
        
        }
        public void remove_OnActionsChanged(System.Action<TzarGames.GameFramework.ActionObjectDetector> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnActionsChanged);
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
            while(1152921511262115064 != this.OnActionsChanged);
        
        }
        public TzarGames.GameFramework.IObjectAction[] GetActions()
        {
            if(this.availableActions != null)
            {
                    return this.availableActions.ToArray();
            }
            
            return this.availableActions.ToArray();
        }
        private void Awake()
        {
            this.cachedTransform = this.transform;
        }
        private void Update()
        {
            int val_16;
            var val_17;
            UnityEngine.Vector3 val_1 = this.cachedTransform.position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  this.heightOffset);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Collider[] val_6 = UnityEngine.Physics.OverlapSphere(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, radius:  this.radius, layerMask:  0, queryTriggerInteraction:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask()));
            val_16 = this.touchingColliders.Count - 1;
            if((val_16 & 2147483648) != 0)
            {
                goto label_5;
            }
            
            label_21:
            UnityEngine.Collider val_8 = this.touchingColliders.Item[val_16];
            if(0 == val_8)
            {
                goto label_11;
            }
            
            var val_17 = 0;
            label_15:
            if(val_17 >= null)
            {
                goto label_11;
            }
            
            val_17 = val_17 + 1;
            if(0 != val_6[0])
            {
                goto label_15;
            }
            
            goto label_20;
            label_11:
            this.touchingColliders.RemoveAt(index:  val_16);
            if(0 != val_8)
            {
                    this.Handle_OnTriggerExit(other:  val_8);
            }
            
            label_20:
            val_16 = val_16 - 1;
            if((val_16 & 2147483648) == 0)
            {
                goto label_21;
            }
            
            label_5:
            val_17 = 0;
            goto label_22;
            label_29:
            val_17 = 1;
            label_22:
            if(val_17 >= null)
            {
                    return;
            }
            
            UnityEngine.Collider val_18 = val_6[1];
            val_6[1] = this.touchingColliders.Contains(item:  val_18);
            if(val_6[1] == true)
            {
                goto label_29;
            }
            
            this.touchingColliders.Add(item:  val_18);
            this.Handle_OnTriggerEnter(other:  val_18);
            goto label_29;
        }
        private void Handle_OnTriggerEnter(UnityEngine.Collider other)
        {
            System.Collections.Generic.List<TzarGames.GameFramework.IObjectAction> val_7;
            TzarGames.GameFramework.ActionObjectBehaviour val_1 = other.GetComponent<TzarGames.GameFramework.ActionObjectBehaviour>();
            if(0 == val_1)
            {
                    return;
            }
            
            if((this.triggeredBehaviours.Contains(item:  val_1)) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.triggeredBehaviours.Add(item:  val_1);
            System.Action<TzarGames.GameFramework.IObjectAction> val_5 = new System.Action<TzarGames.GameFramework.IObjectAction>(object:  this, method:  System.Void TzarGames.GameFramework.ActionObjectDetector::ActionObjectOnOnActionPerformed(TzarGames.GameFramework.IObjectAction obj));
            if(val_1 != null)
            {
                    val_1.add_OnActionPerformed(value:  val_5);
                val_7 = this.availableActions;
            }
            else
            {
                    val_1.add_OnActionPerformed(value:  val_5);
                val_7 = this.availableActions;
            }
            
            val_7.AddRange(collection:  val_1.GetAvailableActions());
            if(this.OnActionsChanged == null)
            {
                    return;
            }
            
            this.OnActionsChanged.Invoke(obj:  this);
        }
        private void ActionObjectOnOnActionPerformed(TzarGames.GameFramework.IObjectAction obj)
        {
            if(this.updateAvailableActions() == false)
            {
                    return;
            }
            
            if(this.OnActionsChanged == null)
            {
                    return;
            }
            
            this.OnActionsChanged.Invoke(obj:  this);
        }
        private bool updateAvailableActions()
        {
            var val_6;
            var val_7;
            int val_8 = this.availableActions.Count;
            val_6 = 0;
            goto label_3;
            label_15:
            X21.RemoveAt(index:  val_8);
            val_6 = 1;
            goto label_3;
            label_12:
            TzarGames.GameFramework.IObjectAction val_2 = this.availableActions.Item[val_8];
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = val_2;
            if((val_2.IsActionAvailable(action:  val_2)) == false)
            {
                goto label_11;
            }
            
            label_3:
            val_8 = val_8 - 1;
            if((val_8 & 2147483648) == 0)
            {
                goto label_12;
            }
            
            return (bool)val_6 & 1;
            label_11:
            if(this.availableActions != null)
            {
                goto label_15;
            }
            
            goto label_15;
        }
        private void Handle_OnTriggerExit(UnityEngine.Collider other)
        {
            System.Action<TzarGames.GameFramework.IObjectAction> val_11;
            TzarGames.GameFramework.ActionObjectBehaviour val_1 = other.GetComponent<TzarGames.GameFramework.ActionObjectBehaviour>();
            if(0 == val_1)
            {
                    return;
            }
            
            if((this.triggeredBehaviours.Contains(item:  val_1)) == false)
            {
                goto label_6;
            }
            
            bool val_6 = this.triggeredBehaviours.Remove(item:  val_1);
            System.Action<TzarGames.GameFramework.IObjectAction> val_7 = null;
            val_11 = val_7;
            val_7 = new System.Action<TzarGames.GameFramework.IObjectAction>(object:  this, method:  System.Void TzarGames.GameFramework.ActionObjectDetector::ActionObjectOnOnActionPerformed(TzarGames.GameFramework.IObjectAction obj));
            if(val_1 == null)
            {
                goto label_8;
            }
            
            val_1.remove_OnActionPerformed(value:  val_11);
            goto label_9;
            label_6:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_8:
            val_1.remove_OnActionPerformed(value:  val_11);
            label_9:
            TzarGames.GameFramework.IObjectAction[] val_8 = val_1.GetAvailableActions();
            if((val_8 != null) && (val_8.Length >= 1))
            {
                    do
            {
                val_11 = val_8[0];
                bool val_9 = this.availableActions.Remove(item:  val_11);
            }
            while((0 + 1) < val_8.Length);
            
            }
            
            bool val_11 = this.updateAvailableActions();
            if(this.OnActionsChanged == null)
            {
                    return;
            }
            
            this.OnActionsChanged.Invoke(obj:  this);
        }
        private void OnDestroy()
        {
            var val_6;
            var val_7;
            List.Enumerator<T> val_1 = this.triggeredBehaviours.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_5;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if(0 == val_2)
            {
                goto label_5;
            }
            
            System.Action<TzarGames.GameFramework.IObjectAction> val_5 = new System.Action<TzarGames.GameFramework.IObjectAction>(object:  this, method:  System.Void TzarGames.GameFramework.ActionObjectDetector::ActionObjectOnOnActionPerformed(TzarGames.GameFramework.IObjectAction obj));
            val_2.remove_OnActionPerformed(value:  null);
            goto label_7;
            label_5:
            val_6 = 0;
            val_7 = 1;
            0.Dispose();
            if((val_7 & 1) != 0)
            {
                    return;
            }
            
            if(val_6 == 0)
            {
                    return;
            }
        
        }
        public void OnPushedToPool()
        {
            this.availableActions.Clear();
            this.OnActionsChanged = 0;
            this.triggeredBehaviours.Clear();
            this.touchingColliders.Clear();
            this.enabled = false;
        }
        public void OnPulledFromPool()
        {
            this.enabled = true;
        }
    
    }

}
