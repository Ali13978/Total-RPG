using UnityEngine;

namespace TzarGames.GameFramework
{
    public class SetRagdoll : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Transform root;
        [UnityEngine.SerializeField]
        private bool setDefaultStateOnEnable;
        [UnityEngine.SerializeField]
        private bool defaultState;
        [UnityEngine.SerializeField]
        private float defaultForceMultiplier;
        
        // Methods
        public SetRagdoll()
        {
            this.defaultForceMultiplier = 20f;
        }
        private void OnEnable()
        {
            if((this.setDefaultStateOnEnable & 255) == false)
            {
                    return;
            }
            
            this.SetState(state:  (this.setDefaultStateOnEnable > true) ? 1 : 0);
        }
        private void Reset()
        {
            this.root = this.transform;
        }
        public void SetState(bool state)
        {
            bool val_2 = state ^ 1;
            goto label_2;
            label_17:
            0 = 1;
            label_2:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            T val_11 = this.root.GetComponentsInChildren<UnityEngine.Transform>()[1];
            UnityEngine.Rigidbody val_3 = val_11.GetComponent<UnityEngine.Rigidbody>();
            if(0 != val_3)
            {
                    if(val_3 != null)
            {
                    val_3.isKinematic = val_2;
            }
            else
            {
                    val_3.isKinematic = val_2;
            }
            
                val_3.useGravity = state;
            }
            
            UnityEngine.Collider val_8 = val_11.GetComponent<UnityEngine.Collider>();
            if(0 == val_8)
            {
                goto label_17;
            }
            
            val_8.enabled = state;
            goto label_17;
        }
        public void AddForceByVector(UnityEngine.Vector3 force)
        {
            goto label_2;
            label_7:
            AddForce(force:  new UnityEngine.Vector3() {x = force.x, y = force.y, z = force.z});
            0 = 1;
            label_2:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            if((this.root.GetComponentsInChildren<UnityEngine.Rigidbody>()[1]) != 0)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public void AddForceByTransform(UnityEngine.Transform forceDirection)
        {
            UnityEngine.Vector3 val_1 = forceDirection.forward;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  this.defaultForceMultiplier);
            this.AddForceByVector(force:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public void OnPushedToPool()
        {
            this.enabled = false;
            this.root.gameObject.SetActive(value:  false);
        }
        public void OnPulledFromPool()
        {
            this.enabled = true;
            this.root.gameObject.SetActive(value:  true);
        }
    
    }

}
