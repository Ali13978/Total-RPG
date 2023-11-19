using UnityEngine;

namespace TzarGames.Common
{
    public class InstanceMaker : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject defaultPrefab;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform parent;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 spawnOffset;
        [UnityEngine.SerializeField]
        private TzarGames.Common.Events.GameObjectEvent onInstantiate;
        
        // Methods
        public InstanceMaker()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.spawnOffset = val_1;
            mem[1152921511110455916] = val_1.y;
            mem[1152921511110455920] = val_1.z;
        }
        public void MakeInstance()
        {
            this.MakeInstance(prefab:  this.defaultPrefab);
        }
        public void MakeInstance(UnityEngine.GameObject prefab)
        {
            this.MakeInstance(prefab:  prefab, setParent:  UnityEngine.Object.op_Inequality(x:  0, y:  this.parent));
        }
        public void MakeUnparentedInstance(UnityEngine.GameObject prefab)
        {
            this.MakeInstance(prefab:  prefab, setParent:  false);
        }
        public void MakeInstance(UnityEngine.GameObject prefab, bool setParent)
        {
            UnityEngine.Transform val_14;
            float val_15;
            float val_16;
            float val_17;
            float val_18;
            UnityEngine.Transform val_19;
            float val_20;
            float val_21;
            float val_22;
            val_14 = setParent;
            if((0 == this.parent) || (val_14 == false))
            {
                goto label_4;
            }
            
            UnityEngine.Vector3 val_2 = this.parent.position;
            val_15 = val_2.x;
            val_16 = val_2.y;
            val_17 = val_2.z;
            val_18 = this.spawnOffset;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17}, b:  new UnityEngine.Vector3() {x = val_18, y = V11.16B, z = V10.16B});
            val_19 = this.parent;
            val_20 = val_3.x;
            val_21 = val_3.y;
            val_22 = val_3.z;
            if(val_19 != null)
            {
                goto label_16;
            }
            
            goto label_9;
            label_4:
            UnityEngine.Vector3 val_5 = this.transform.position;
            UnityEngine.Quaternion val_7 = this.transform.rotation;
            UnityEngine.Vector3 val_8 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, point:  new UnityEngine.Vector3() {x = this.spawnOffset, y = V15.16B, z = V14.16B});
            val_16 = val_5.y;
            val_15 = val_5.x;
            val_17 = val_5.z;
            val_18 = val_8.x;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17}, b:  new UnityEngine.Vector3() {x = val_18, y = val_8.y, z = val_8.z});
            val_20 = val_9.x;
            val_21 = val_9.y;
            val_22 = val_9.z;
            val_19 = this.transform;
            if(val_19 != null)
            {
                goto label_16;
            }
            
            label_9:
            label_16:
            UnityEngine.Quaternion val_11 = val_19.rotation;
            if(val_14 != false)
            {
                    val_14 = this.parent;
                TzarGames.TzarHero.DamageInfluenceBehaviour val_12 = UnityEngine.Object.Instantiate<TzarGames.TzarHero.DamageInfluenceBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22}, rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, parent:  prefab);
            }
            
            this.onInstantiate.Invoke(arg0:  UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22}, rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}));
        }
    
    }

}
