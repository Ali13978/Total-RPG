using UnityEngine;

namespace Cinemachine
{
    public interface ICinemachineCamera
    {
        // Properties
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract int Priority { get; set; }
        public abstract UnityEngine.Transform LookAt { get; set; }
        public abstract UnityEngine.Transform Follow { get; set; }
        public abstract Cinemachine.CameraState State { get; }
        public abstract UnityEngine.GameObject VirtualCameraGameObject { get; }
        public abstract Cinemachine.ICinemachineCamera LiveChildOrSelf { get; }
        public abstract Cinemachine.ICinemachineCamera ParentCamera { get; }
        
        // Methods
        public abstract string get_Name(); // 0
        public abstract string get_Description(); // 0
        public abstract int get_Priority(); // 0
        public abstract void set_Priority(int value); // 0
        public abstract UnityEngine.Transform get_LookAt(); // 0
        public abstract void set_LookAt(UnityEngine.Transform value); // 0
        public abstract UnityEngine.Transform get_Follow(); // 0
        public abstract void set_Follow(UnityEngine.Transform value); // 0
        public abstract Cinemachine.CameraState get_State(); // 0
        public abstract UnityEngine.GameObject get_VirtualCameraGameObject(); // 0
        public abstract Cinemachine.ICinemachineCamera get_LiveChildOrSelf(); // 0
        public abstract Cinemachine.ICinemachineCamera get_ParentCamera(); // 0
        public abstract bool IsLiveChild(Cinemachine.ICinemachineCamera vcam); // 0
        public abstract void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime); // 0
        public abstract void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime); // 0
    
    }

}
