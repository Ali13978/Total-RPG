using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineSameAsFollowObject : CinemachineComponentBase
    {
        // Properties
        public override bool IsValid { get; }
        public override Cinemachine.CinemachineCore.Stage Stage { get; }
        
        // Methods
        public CinemachineSameAsFollowObject()
        {
        
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
            return 1;
        }
        public override void MutateCameraState(ref Cinemachine.CameraState curState, float deltaTime)
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.Quaternion val_3 = this.FollowTarget.transform.rotation;
            1152921511720369616 = ???;
        }
    
    }

}
