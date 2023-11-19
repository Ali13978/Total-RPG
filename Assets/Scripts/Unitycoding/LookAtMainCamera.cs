using UnityEngine;

namespace Unitycoding
{
    public class LookAtMainCamera : MonoBehaviour
    {
        // Fields
        public bool ignoreRaycast;
        private UnityEngine.Transform target;
        private UnityEngine.Transform mTransform;
        private bool searchCamera;
        
        // Methods
        public LookAtMainCamera()
        {
            this.ignoreRaycast = true;
        }
        private void Start()
        {
            if(0 != UnityEngine.Camera.main)
            {
                    this.target = UnityEngine.Camera.main.transform;
            }
            else
            {
                    UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.SearchCamera());
            }
            
            this.mTransform = this.transform;
            if(this.ignoreRaycast == false)
            {
                    return;
            }
            
            this.gameObject.layer = 2;
        }
        private void Update()
        {
            if(0 != this.target)
            {
                    UnityEngine.Vector3 val_2 = this.mTransform.position;
                UnityEngine.Quaternion val_3 = this.target.rotation;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.back;
                UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, point:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
                UnityEngine.Quaternion val_7 = this.target.rotation;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_9 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, point:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                this.mTransform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, worldUp:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                return;
            }
            
            if(this.searchCamera != false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.SearchCamera());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator SearchCamera()
        {
            typeof(LookAtMainCamera.<SearchCamera>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
