using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineHardLookAt : CinemachineComponentBase
    {
        // Properties
        public override bool IsValid { get; }
        public override Cinemachine.CinemachineCore.Stage Stage { get; }
        
        // Methods
        public CinemachineHardLookAt()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        public override bool get_IsValid()
        {
            if(this.enabled == false)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  0, y:  this.LookAtTarget);
        }
        public override Cinemachine.CinemachineCore.Stage get_Stage()
        {
            return 1;
        }
        public override void MutateCameraState(ref Cinemachine.CameraState curState, float deltaTime)
        {
            float val_6;
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            float val_11;
            float val_12;
            if((this & 1) == 0)
            {
                    return;
            }
            
            if((1152921511714921984 & 1) == 0)
            {
                    return;
            }
            
            val_6 = curState.<ReferenceLookAt>k__BackingField.x;
            val_7 = curState.<ReferenceLookAt>k__BackingField.z;
            val_8 = V1.16B;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6, y = curState.<ReferenceLookAt>k__BackingField.y, z = val_7}, b:  new UnityEngine.Vector3() {x = deltaTime, y = val_8, z = V2.16B});
            if(val_1.x <= 0.0001f)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z});
            if(val_2.x < 0)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.forward;
                val_6 = val_3.x;
                val_8 = val_1.x;
                val_7 = val_1.z;
                val_9 = val_6;
                val_10 = val_3.y;
                val_11 = val_3.z;
                val_12 = val_8;
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11}, toDirection:  new UnityEngine.Vector3() {x = val_12, y = val_1.y, z = val_7});
            }
            else
            {
                    val_6 = val_1.x;
                val_7 = val_1.z;
                val_8 = curState.<ReferenceUp>k__BackingField.y;
                val_9 = val_6;
                val_10 = val_1.y;
                val_11 = val_7;
                val_12 = curState.<ReferenceUp>k__BackingField.x;
                UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11}, upwards:  new UnityEngine.Vector3() {x = val_12, y = val_8, z = curState.<ReferenceUp>k__BackingField.z});
            }
            
            curState.<RawOrientation>k__BackingField.x = val_5.x;
            curState.<RawOrientation>k__BackingField.y = val_5.y;
            curState.<RawOrientation>k__BackingField.z = val_5.z;
            curState.<RawOrientation>k__BackingField.w = val_5.w;
        }
    
    }

}
