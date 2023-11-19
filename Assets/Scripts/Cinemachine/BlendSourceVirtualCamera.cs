using UnityEngine;

namespace Cinemachine
{
    internal class BlendSourceVirtualCamera : ICinemachineCamera
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.CinemachineBlend <Blend>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <Priority>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Transform <LookAt>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Transform <Follow>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.CameraState <State>k__BackingField;
        
        // Properties
        public Cinemachine.CinemachineBlend Blend { get; set; }
        public string Name { get; }
        public string Description { get; }
        public int Priority { get; set; }
        public UnityEngine.Transform LookAt { get; set; }
        public UnityEngine.Transform Follow { get; set; }
        public Cinemachine.CameraState State { get; set; }
        public UnityEngine.GameObject VirtualCameraGameObject { get; }
        public Cinemachine.ICinemachineCamera LiveChildOrSelf { get; }
        public Cinemachine.ICinemachineCamera ParentCamera { get; }
        
        // Methods
        public BlendSourceVirtualCamera(Cinemachine.CinemachineBlend blend, float deltaTime)
        {
            float val_2;
            float val_3;
            float val_4;
            var val_5;
            this.<Blend>k__BackingField = blend;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = blend.<CamA>k__BackingField;
            this.UpdateCameraState(worldUp:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4}, deltaTime:  deltaTime);
        }
        public Cinemachine.CinemachineBlend get_Blend()
        {
            return (Cinemachine.CinemachineBlend)this.<Blend>k__BackingField;
        }
        private void set_Blend(Cinemachine.CinemachineBlend value)
        {
            this.<Blend>k__BackingField = value;
        }
        public string get_Name()
        {
            return "Blend";
        }
        public string get_Description()
        {
            if((this.<Blend>k__BackingField) != null)
            {
                    return this.<Blend>k__BackingField.Description;
            }
            
            return this.<Blend>k__BackingField.Description;
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
            if((this.<Blend>k__BackingField) != null)
            {
                    return (Cinemachine.ICinemachineCamera)this.<Blend>k__BackingField.<CamB>k__BackingField;
            }
            
            return (Cinemachine.ICinemachineCamera)this.<Blend>k__BackingField.<CamB>k__BackingField;
        }
        public Cinemachine.ICinemachineCamera get_ParentCamera()
        {
            return 0;
        }
        public bool IsLiveChild(Cinemachine.ICinemachineCamera vcam)
        {
            var val_2;
            if((this.<Blend>k__BackingField.<CamA>k__BackingField) != vcam)
            {
                    var val_1 = ((this.<Blend>k__BackingField.<CamB>k__BackingField) == vcam) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 1;
            return (bool)val_2;
        }
        public Cinemachine.CameraState CalculateNewState(float deltaTime)
        {
        
        }
        public void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime)
        {
            this.<Blend>k__BackingField.UpdateCameraState(worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  deltaTime);
            Cinemachine.CameraState val_1 = this.<Blend>k__BackingField.State;
        }
        public void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime)
        {
        
        }
    
    }

}
