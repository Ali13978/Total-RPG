using UnityEngine;

namespace TzarGames.GameFramework
{
    public class SpawnPoint : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Collider> touchingColliders;
        private UnityEngine.Vector3 offset;
        
        // Properties
        public UnityEngine.Vector3 Position { get; }
        public UnityEngine.Quaternion Rotation { get; }
        
        // Methods
        public SpawnPoint()
        {
            this.touchingColliders = new System.Collections.Generic.List<UnityEngine.Collider>();
            this.offset = 0;
            mem[1152921511439212516] = 0;
            mem[1152921511439212520] = 0;
        }
        public UnityEngine.Vector3 get_Position()
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.offset, y = V11.16B, z = V10.16B});
        }
        public UnityEngine.Quaternion get_Rotation()
        {
            UnityEngine.Transform val_1 = this.transform;
            if(val_1 != null)
            {
                    return val_1.rotation;
            }
            
            return val_1.rotation;
        }
        private void OnTriggerEnter(UnityEngine.Collider collider)
        {
            if((this.touchingColliders.Contains(item:  collider)) != false)
            {
                    return;
            }
            
            this.touchingColliders.Add(item:  collider);
        }
        private void OnTriggerExit(UnityEngine.Collider collider)
        {
            if((this.touchingColliders.Contains(item:  collider)) == false)
            {
                    return;
            }
            
            bool val_2 = this.touchingColliders.Remove(item:  collider);
        }
        public bool isFree()
        {
            UnityEngine.Collider val_15;
            var val_16;
            var val_17;
            if(this.touchingColliders.Count < 1)
            {
                    return (bool)(this.touchingColliders.Count == 0) ? 1 : 0;
            }
            
            val_15 = 1152921504721543168;
            val_16 = 0;
            val_17 = 0;
            goto label_3;
            label_15:
            val_16 = 1;
            label_3:
            if(val_16 >= this.touchingColliders.Count)
            {
                goto label_5;
            }
            
            UnityEngine.Collider val_3 = this.touchingColliders.Item[1];
            if(0 != val_3)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
            {
                goto label_15;
            }
            
            }
            
            if(val_17 == 0)
            {
                    System.Collections.Generic.List<UnityEngine.Collider> val_8 = null;
                val_17 = val_8;
                val_8 = new System.Collections.Generic.List<UnityEngine.Collider>();
                if(null == 0)
            {
                    val_17 = 0;
            }
            
            }
            
            val_17.Add(item:  val_3);
            goto label_15;
            label_5:
            if(val_17 == 0)
            {
                    return (bool)(this.touchingColliders.Count == 0) ? 1 : 0;
            }
            
            if(val_17.Count < 1)
            {
                    return (bool)(this.touchingColliders.Count == 0) ? 1 : 0;
            }
            
            do
            {
                val_15 = val_17.Item[0];
                bool val_11 = this.touchingColliders.Remove(item:  val_15);
                val_16 = 0 + 1;
            }
            while(val_16 < val_17.Count);
            
            return (bool)(this.touchingColliders.Count == 0) ? 1 : 0;
        }
    
    }

}
