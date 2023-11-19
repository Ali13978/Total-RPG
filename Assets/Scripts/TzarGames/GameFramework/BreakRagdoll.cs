using UnityEngine;

namespace TzarGames.GameFramework
{
    public class BreakRagdoll : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Transform root;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform[] ignoreBones;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.RagdollBreakMethod method;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform optionalParent;
        
        // Methods
        public BreakRagdoll()
        {
        
        }
        private void Reset()
        {
            this.root = this.transform;
        }
        public void Break()
        {
            if(this.method != 1)
            {
                    if(this.method != 0)
            {
                    return;
            }
            
                this.breakByJoints();
                return;
            }
            
            this.breakByRigidbodies();
        }
        private void breakByJoints()
        {
            var val_6;
            UnityEngine.Transform val_7;
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                UnityEngine.Transform val_2 = 1152921505864181456.transform;
                if((this.isBoneMustBeIgnored(bone:  val_2)) != true)
            {
                    if(null != null)
            {
                    1152921505864181456.connectedBody = 0;
                1152921505864181456.breakForce = 0f;
            }
            else
            {
                    0.connectedBody = 0;
                0.breakForce = 0f;
                val_6 = 0;
            }
            
                val_6.breakTorque = 0f;
                if(0 != this.optionalParent)
            {
                    val_7 = this.optionalParent;
            }
            else
            {
                    val_7 = 0;
            }
            
                val_2.SetParent(parent:  val_7);
            }
            
                val_6 = val_6 + 1;
            }
            while(val_1.Length != val_6);
        
        }
        private void breakByRigidbodies()
        {
            UnityEngine.Transform val_6;
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                UnityEngine.Transform val_2 = 1152921505864181456.transform;
                if((this.isBoneMustBeIgnored(bone:  val_2)) != true)
            {
                    if(0 != this.optionalParent)
            {
                    val_6 = this.optionalParent;
            }
            else
            {
                    val_6 = 0;
            }
            
                val_2.SetParent(parent:  val_6);
            }
            
                val_6 = val_6 + 1;
            }
            while(val_1.Length != val_6);
        
        }
        private bool isBoneMustBeIgnored(UnityEngine.Transform bone)
        {
            UnityEngine.Transform[] val_3;
            var val_4;
            val_3 = this.ignoreBones;
            if(this.ignoreBones.Length < 1)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_8:
            val_3 = this.ignoreBones[val_3];
            if(0 == val_3)
            {
                goto label_7;
            }
            
            val_3 = val_3 + 1;
            if(val_3 < (long)this.ignoreBones.Length)
            {
                goto label_8;
            }
            
            label_2:
            val_4 = 0;
            return (bool)val_4;
            label_7:
            val_4 = 1;
            return (bool)val_4;
        }
    
    }

}
