using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    public abstract class CinemachineComponentBase : MonoBehaviour
    {
        // Fields
        protected const float Epsilon = 0.0001;
        private Cinemachine.CinemachineVirtualCameraBase m_vcamOwner;
        
        // Properties
        public Cinemachine.CinemachineVirtualCameraBase VirtualCamera { get; }
        public UnityEngine.Transform FollowTarget { get; }
        public UnityEngine.Transform LookAtTarget { get; }
        public Cinemachine.CameraState VcamState { get; }
        public abstract bool IsValid { get; }
        public abstract Cinemachine.CinemachineCore.Stage Stage { get; }
        
        // Methods
        protected CinemachineComponentBase()
        {
        
        }
        public Cinemachine.CinemachineVirtualCameraBase get_VirtualCamera()
        {
            Cinemachine.CinemachineVirtualCameraBase val_8;
            if(0 == this.m_vcamOwner)
            {
                    this.m_vcamOwner = this.gameObject.transform.parent.gameObject.GetComponent<Cinemachine.CinemachineVirtualCameraBase>();
                return val_8;
            }
            
            val_8 = this.m_vcamOwner;
            return val_8;
        }
        public UnityEngine.Transform get_FollowTarget()
        {
            Cinemachine.CinemachineVirtualCameraBase val_1 = this.VirtualCamera;
            if(0 == val_1)
            {
                    return 0;
            }
            
            if(val_1 == null)
            {
                
            }
        
        }
        public UnityEngine.Transform get_LookAtTarget()
        {
            Cinemachine.CinemachineVirtualCameraBase val_1 = this.VirtualCamera;
            if(0 == val_1)
            {
                    return 0;
            }
            
            if(val_1 == null)
            {
                
            }
        
        }
        public Cinemachine.CameraState get_VcamState()
        {
            var val_4;
            Cinemachine.CameraState val_0;
            if(0 == this.VirtualCamera)
            {
                    Cinemachine.CameraState val_3 = Cinemachine.CameraState.Default;
                return val_0;
            }
            
            val_4;
            return val_0;
        }
        public abstract bool get_IsValid(); // 0
        public virtual void PrePipelineMutateCameraState(ref Cinemachine.CameraState state)
        {
        
        }
        public abstract Cinemachine.CinemachineCore.Stage get_Stage(); // 0
        public abstract void MutateCameraState(ref Cinemachine.CameraState curState, float deltaTime); // 0
        public virtual void OnPositionDragged(UnityEngine.Vector3 delta)
        {
        
        }
    
    }

}
