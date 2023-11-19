using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineHardLockToTarget : CinemachineComponentBase
    {
        // Properties
        public override bool IsValid { get; }
        public override Cinemachine.CinemachineCore.Stage Stage { get; }
        
        // Methods
        public CinemachineHardLockToTarget()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        public override bool get_IsValid()
        {
            if(this.enabled == false)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  0, y:  this.FollowTarget);
        }
        public override Cinemachine.CinemachineCore.Stage get_Stage()
        {
            return 0;
        }
        public override void MutateCameraState(ref Cinemachine.CameraState curState, float deltaTime)
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = this.FollowTarget.position;
            curState.<RawPosition>k__BackingField.x = val_2.x;
            curState.<RawPosition>k__BackingField.y = val_2.y;
            curState.<RawPosition>k__BackingField.z = val_2.z;
        }
    
    }

}
