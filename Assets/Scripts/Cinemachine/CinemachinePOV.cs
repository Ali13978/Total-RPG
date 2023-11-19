using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachinePOV : CinemachineComponentBase
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public Cinemachine.AxisState m_VerticalAxis;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.AxisState m_HorizontalAxis;
        
        // Properties
        public override bool IsValid { get; }
        public override Cinemachine.CinemachineCore.Stage Stage { get; }
        
        // Methods
        public CinemachinePOV()
        {
            mem[1152921511719222416] = 0;
            mem[1152921511719222400] = 0;
            this.m_VerticalAxis = 0;
            mem[1152921511719222464] = 0;
            mem[1152921511719222448] = 0;
            this.m_HorizontalAxis = 0;
        }
        public override bool get_IsValid()
        {
            return this.enabled;
        }
        public override Cinemachine.CinemachineCore.Stage get_Stage()
        {
            return 1;
        }
        private void OnValidate()
        {
        
        }
        private void OnEnable()
        {
        
        }
        public override void MutateCameraState(ref Cinemachine.CameraState curState, float deltaTime)
        {
            float val_24;
            var val_25;
            var val_26;
            var val_27;
            val_24 = deltaTime;
            val_25 = 1152921511719847376;
            if((this & 1) == 0)
            {
                    return;
            }
            
            if(val_24 >= 0f)
            {
                goto label_2;
            }
            
            val_26 = Cinemachine.CinemachineCore.Instance;
            if((val_26.IsLive(vcam:  this.VirtualCamera)) == false)
            {
                goto label_6;
            }
            
            label_2:
            label_6:
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(x:  this.m_VerticalAxis, y:  this.m_HorizontalAxis, z:  0f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, toDirection:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, rhs:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w});
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, rhs:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w});
            val_25 = ???;
            val_27 = ???;
            val_24 = ???;
        }
    
    }

}
