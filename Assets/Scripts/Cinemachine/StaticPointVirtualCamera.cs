using UnityEngine;

namespace Cinemachine
{
    internal class StaticPointVirtualCamera : ICinemachineCamera
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <Name>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <Priority>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Transform <LookAt>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Transform <Follow>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.CameraState <State>k__BackingField;
        
        // Properties
        public string Name { get; set; }
        public string Description { get; }
        public int Priority { get; set; }
        public UnityEngine.Transform LookAt { get; set; }
        public UnityEngine.Transform Follow { get; set; }
        public Cinemachine.CameraState State { get; set; }
        public UnityEngine.GameObject VirtualCameraGameObject { get; }
        public Cinemachine.ICinemachineCamera LiveChildOrSelf { get; }
        public Cinemachine.ICinemachineCamera ParentCamera { get; }
        
        // Methods
        public StaticPointVirtualCamera(Cinemachine.CameraState state, string name)
        {
            val_1 = new System.Object();
            this.<Name>k__BackingField = val_1;
        }
        public void SetState(Cinemachine.CameraState state)
        {
        
        }
        public string get_Name()
        {
            return (string)this.<Name>k__BackingField;
        }
        private void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        public string get_Description()
        {
            null = null;
            return (string)System.String.Empty;
        }
        public int get_Priority()
        {
            return (int)this.<Priority>k__BackingField;
        }
        public void set_Priority(int value)
        {
            this.<Priority>k__BackingField = value;
        }
        public UnityEngine.Transform get_LookAt()
        {
            return (UnityEngine.Transform)this.<LookAt>k__BackingField;
        }
        public void set_LookAt(UnityEngine.Transform value)
        {
            this.<LookAt>k__BackingField = value;
        }
        public UnityEngine.Transform get_Follow()
        {
            return (UnityEngine.Transform)this.<Follow>k__BackingField;
        }
        public void set_Follow(UnityEngine.Transform value)
        {
            this.<Follow>k__BackingField = value;
        }
        public Cinemachine.CameraState get_State()
        {
        
        }
        private void set_State(Cinemachine.CameraState value)
        {
        
        }
        public UnityEngine.GameObject get_VirtualCameraGameObject()
        {
            return 0;
        }
        public Cinemachine.ICinemachineCamera get_LiveChildOrSelf()
        {
            return (Cinemachine.ICinemachineCamera)this;
        }
        public Cinemachine.ICinemachineCamera get_ParentCamera()
        {
            return 0;
        }
        public bool IsLiveChild(Cinemachine.ICinemachineCamera vcam)
        {
            return false;
        }
        public void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime)
        {
        
        }
        public void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime)
        {
        
        }
    
    }

}
