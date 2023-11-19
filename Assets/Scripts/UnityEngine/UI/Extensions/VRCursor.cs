using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class VRCursor : MonoBehaviour
    {
        // Fields
        public float xSens;
        public float ySens;
        private UnityEngine.Collider currentCollider;
        
        // Methods
        public VRCursor()
        {
        
        }
        private void Update()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            float val_13 = val_1.x;
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            val_13 = val_13 * this.xSens;
            UnityEngine.Vector3 val_6 = this.transform.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_13, y = (val_2.y * this.ySens) + (-1f), z = val_6.z};
            UnityEngine.Vector3 val_9 = this.transform.position;
            UnityEngine.UI.Extensions.VRInputModule.cursorPosition = val_9.x;
            UnityEngine.UI.Extensions.VRInputModule.targetObject.__il2cppRuntimeField_18 = val_9.y;
            UnityEngine.UI.Extensions.VRInputModule.targetObject.__il2cppRuntimeField_1C = val_9.z;
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            UnityEngine.UI.Extensions.VRInputModule.PointerSubmit(obj:  this.currentCollider.gameObject);
        }
        private void OnTriggerEnter(UnityEngine.Collider other)
        {
            UnityEngine.UI.Extensions.VRInputModule.PointerEnter(obj:  other.gameObject);
            this.currentCollider = other;
        }
        private void OnTriggerExit(UnityEngine.Collider other)
        {
            UnityEngine.UI.Extensions.VRInputModule.PointerExit(obj:  other.gameObject);
            this.currentCollider = 0;
        }
    
    }

}
