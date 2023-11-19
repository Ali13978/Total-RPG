using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class TiltInput : MonoBehaviour
    {
        // Fields
        public UnityStandardAssets.CrossPlatformInput.TiltInput.AxisMapping mapping;
        public UnityStandardAssets.CrossPlatformInput.TiltInput.AxisOptions tiltAroundAxis;
        public float fullTiltAngle;
        public float centreAngleOffset;
        private UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis m_SteerAxis;
        
        // Methods
        public TiltInput()
        {
            this.fullTiltAngle = 25f;
        }
        private void OnEnable()
        {
            if(this.mapping.type != 0)
            {
                    return;
            }
            
            typeof(CrossPlatformInputManager.VirtualAxis).__il2cppRuntimeField_10 = this.mapping.axisName;
            typeof(CrossPlatformInputManager.VirtualAxis).__il2cppRuntimeField_1C = 1;
            this.m_SteerAxis = new System.Object();
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.RegisterVirtualAxis(axis:  null);
        }
        private void Update()
        {
            VirtualAxis val_9;
            float val_13;
            float val_14;
            float val_15;
            val_9 = this;
            UnityEngine.Vector3 val_1 = UnityEngine.Input.acceleration;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_13 = 0f;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) == false)
            {
                goto label_7;
            }
            
            if(this.tiltAroundAxis == 1)
            {
                goto label_6;
            }
            
            if(this.tiltAroundAxis != 0)
            {
                goto label_7;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Input.acceleration;
            val_14 = val_4.x;
            goto label_10;
            label_6:
            UnityEngine.Vector3 val_5 = UnityEngine.Input.acceleration;
            val_14 = val_5.z;
            label_10:
            UnityEngine.Vector3 val_6 = UnityEngine.Input.acceleration;
            float val_9 = val_14;
            val_9 = val_9 * 57.29578f;
            val_13 = val_9 + this.centreAngleOffset;
            label_7:
            float val_7 = UnityEngine.Mathf.InverseLerp(a:  -this.fullTiltAngle, b:  this.fullTiltAngle, value:  val_13);
            val_15 = val_7;
            MappingType val_10 = this.mapping.type;
            val_10 = (val_10 < 4) ? (val_10 + 20) : 0;
            val_10 = val_10 - 20;
            if(val_10 > 3)
            {
                    return;
            }
            
            var val_11 = 25976748 + ((this.mapping.type < 0x4 ? (this.mapping.type + 20) : 0 - 20)) << 2;
            val_7 = val_15 + val_15;
            val_15 = val_7 + (-1f);
            val_11 = val_11 + 25976748;
            goto (25976748 + ((this.mapping.type < 0x4 ? (this.mapping.type + 20) : 0 - 20)) << 2 + 25976748);
        }
        private void OnDisable()
        {
            this.m_SteerAxis.Remove();
        }
    
    }

}
