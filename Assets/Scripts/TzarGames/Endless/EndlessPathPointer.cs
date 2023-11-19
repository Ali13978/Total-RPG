using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessPathPointer : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.StagePathHelper pathHelper;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject pointer;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.PathfinderBase pathfinder;
        [UnityEngine.SerializeField]
        private float pathCheckInterval;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private UnityEngine.Transform cachedTransform;
        private UnityEngine.Vector3 lastPosition;
        private float lastPathCheckTime;
        private bool pendingPath;
        private UnityEngine.Vector3 currentTargetPos;
        
        // Methods
        public EndlessPathPointer()
        {
            this.pathCheckInterval = 0.1f;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.lastPosition = val_1;
            mem[1152921510638411076] = val_1.y;
            mem[1152921510638411080] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.currentTargetPos = val_2;
            mem[1152921510638411096] = val_2.y;
            mem[1152921510638411100] = val_2.z;
        }
        private void Reset()
        {
            this.pathHelper = this.GetComponent<TzarGames.Endless.StagePathHelper>();
            this.cachedTransform = this.transform;
            this.pathfinder = this.GetComponent<TzarGames.GameFramework.PathfinderBase>();
        }
        private void Start()
        {
            this.pointer.SetActive(value:  false);
        }
        private void LateUpdate()
        {
            UnityEngine.GameObject val_15;
            float val_16;
            float val_17;
            float val_18;
            UnityEngine.Transform val_19;
            float val_20;
            val_15 = this;
            if(0 == this.pathHelper.CurrentTarget)
            {
                    val_15 = this.pointer;
                val_15.SetActive(value:  false);
                return;
            }
            
            val_16 = this.lastPathCheckTime;
            val_17 = this.pathCheckInterval;
            val_18 = UnityEngine.Time.time - val_16;
            if(val_18 < val_17)
            {
                    val_19 = this.cachedTransform;
            }
            else
            {
                    this.lastPathCheckTime = UnityEngine.Time.time;
                val_19 = val_15;
                UnityEngine.Vector3 val_5 = this.cachedTransform.position;
                val_18 = this.lastPosition;
                val_16 = V9.16B;
                val_17 = V10.16B;
                if(((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_18, y = val_16, z = val_17}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) != false) && (this.pendingPath != true))
            {
                    this.pendingPath = true;
                UnityEngine.Vector3 val_7 = this.cachedTransform.position;
                val_20 = val_7.y;
                UnityEngine.Vector3 val_9 = this.pathHelper.CurrentTarget.position;
                UnityEngine.Events.UnityAction<TzarGames.GameFramework.IPathResult> val_10 = new UnityEngine.Events.UnityAction<TzarGames.GameFramework.IPathResult>(object:  this, method:  System.Void TzarGames.Endless.EndlessPathPointer::<LateUpdate>m__0(TzarGames.GameFramework.IPathResult pathResult));
                val_18 = val_7.x;
                val_16 = val_20;
                val_17 = val_7.z;
            }
            
            }
            
            UnityEngine.Vector3 val_11 = null.position;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.currentTargetPos, y = val_20, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            null.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = val_13.y, z = 0f};
            UnityEngine.Vector3 val_14 = null.position;
            this.lastPosition = val_14;
            mem[1152921510638816708] = val_14.y;
            mem[1152921510638816712] = val_14.z;
        }
        public void OnPushedToPool()
        {
            this.enabled = false;
            this.pointer.SetActive(value:  false);
        }
        public void OnPulledFromPool()
        {
            this.enabled = true;
        }
        private void <LateUpdate>m__0(TzarGames.GameFramework.IPathResult pathResult)
        {
            UnityEngine.Transform val_10;
            UnityEngine.GameObject val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_11 = this;
            this.pendingPath = false;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_12 = 0;
            val_13 = pathResult;
            if((pathResult & 1) == 0)
            {
                goto label_6;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = 3;
            val_14 = pathResult;
            goto label_11;
            label_6:
            UnityEngine.Vector3 val_3 = this.pathHelper.CurrentTarget.position;
            this.currentTargetPos = val_3;
            mem[1152921510639218264] = val_3.y;
            mem[1152921510639218268] = val_3.z;
            val_15 = 1;
            goto label_15;
            label_11:
            val_10 = pathResult;
            if(val_10 < 2)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_16 = 2;
                val_17 = pathResult;
            }
            else
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_18 = 2;
                val_19 = pathResult;
            }
            
            if(val_10 < 3)
            {
                goto label_27;
            }
            
            val_10 = this.cachedTransform;
            UnityEngine.Vector3 val_7 = val_10.position;
            float val_8 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            if(val_8 <= 3f)
            {
                goto label_31;
            }
            
            label_27:
            this.currentTargetPos = V0.16B;
            mem[1152921510639218264] = V1.16B;
            mem[1152921510639218268] = V2.16B;
            goto label_32;
            label_31:
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_20 = 2;
            val_21 = pathResult;
            this.currentTargetPos = val_8;
            mem[1152921510639218264] = 3f;
            mem[1152921510639218268] = val_7.z;
            label_32:
            val_11 = this.pointer;
            val_15 = 1;
            label_15:
            val_11.SetActive(value:  true);
        }
    
    }

}
