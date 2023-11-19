using UnityEngine;

namespace TzarGames.GameFramework
{
    public class DamageParticles : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.ParticleSystem particlePrefab;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform attachPoint;
        
        // Methods
        public DamageParticles()
        {
        
        }
        public void OnTakeHit(TzarGames.GameFramework.IDamageInfo hitData)
        {
            var val_17;
            var val_21;
            UnityEngine.Transform val_22;
            UnityEngine.GameObject val_23;
            var val_24;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_17 = hitData;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            if(0 != this.attachPoint)
            {
                goto label_13;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_21 = hitData;
            goto label_18;
            label_13:
            val_22 = this.attachPoint;
            val_23 = val_22;
            UnityEngine.Vector3 val_6 = val_23.position;
            goto label_20;
            label_18:
            val_22 = hitData;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_24 = val_22;
            val_23 = val_22;
            label_20:
            bool val_9 = TzarGames.GameFramework.Instantiator.IsPoolablePrefab(prefab:  val_23);
            if(val_9 != false)
            {
                    UnityEngine.GameObject val_10 = TzarGames.GameFramework.Instantiator.InstantiateFromPool(originalObject:  val_9, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, parent:  this.particlePrefab.gameObject);
            }
            else
            {
                    TzarGames.GameFramework.TzarBehaviour val_11 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            }
            
            if(0 == val_11)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            if(0 == this.attachPoint)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  this.attachCoroutine(target:  val_11.transform));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator attachCoroutine(UnityEngine.Transform target)
        {
            if(null != 0)
            {
                    typeof(DamageParticles.<attachCoroutine>c__Iterator0).__il2cppRuntimeField_18 = target;
            }
            else
            {
                    mem[24] = target;
            }
            
            typeof(DamageParticles.<attachCoroutine>c__Iterator0).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
