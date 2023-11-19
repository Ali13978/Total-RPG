using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.SaveDuringPlayAttribute]
    public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera
    {
        // Fields
        [UnityEngine.HideInInspector]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public System.Action CinemachineGUIDebuggerCallback;
        [UnityEngine.HideInInspector]
        [UnityEngine.SerializeField]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public string[] m_ExcludedPropertiesInInspector;
        [UnityEngine.HideInInspector]
        [UnityEngine.SerializeField]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public Cinemachine.CinemachineCore.Stage[] m_LockStageInInspector;
        private int m_ValidatingStreamVersion;
        private bool m_OnValidateCalled;
        [UnityEngine.HideInInspector]
        [UnityEngine.SerializeField]
        [Cinemachine.NoSaveDuringPlayAttribute]
        private int m_StreamingVersion;
        [Cinemachine.NoSaveDuringPlayAttribute]
        [UnityEngine.TooltipAttribute]
        public int m_Priority;
        protected Cinemachine.CinemachineVirtualCameraBase.OnPostPipelineStageDelegate OnPostPipelineStage;
        private bool m_previousStateIsValid;
        private UnityEngine.Transform m_previousLookAtTarget;
        private UnityEngine.Transform m_previousFollowTarget;
        private bool mSlaveStatusUpdated;
        private Cinemachine.CinemachineVirtualCameraBase m_parentVcam;
        private int m_QueuePriority;
        
        // Properties
        public int ValidatingStreamVersion { get; set; }
        public string Name { get; }
        public virtual string Description { get; }
        public int Priority { get; set; }
        public UnityEngine.GameObject VirtualCameraGameObject { get; }
        public abstract Cinemachine.CameraState State { get; }
        public virtual Cinemachine.ICinemachineCamera LiveChildOrSelf { get; }
        public Cinemachine.ICinemachineCamera ParentCamera { get; }
        public abstract UnityEngine.Transform LookAt { get; set; }
        public abstract UnityEngine.Transform Follow { get; set; }
        public bool PreviousStateIsValid { get; set; }
        
        // Methods
        protected CinemachineVirtualCameraBase()
        {
            typeof(System.String[]).__il2cppRuntimeField_20 = "m_Script";
            this.m_QueuePriority = 2147483647;
            this.m_ExcludedPropertiesInInspector = null;
            this.m_Priority = 10;
        }
        public int get_ValidatingStreamVersion()
        {
            var val_1;
            int val_2;
            var val_3;
            val_1 = this;
            if(this.m_OnValidateCalled != false)
            {
                    val_2 = this.m_ValidatingStreamVersion;
                return (int)Cinemachine.CinemachineCore.__il2cppRuntimeField_static_fields;
            }
            
            val_1 = 1152921504930807808;
            val_3 = null;
            val_3 = null;
            return (int)Cinemachine.CinemachineCore.__il2cppRuntimeField_static_fields;
        }
        private void set_ValidatingStreamVersion(int value)
        {
            this.m_ValidatingStreamVersion = value;
        }
        public virtual void AddPostPipelineStageHook(Cinemachine.CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
        {
            OnPostPipelineStageDelegate val_5;
            OnPostPipelineStageDelegate val_6;
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnPostPipelineStage);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            this.OnPostPipelineStage = val_5;
            System.Delegate val_3 = System.Delegate.Combine(a:  0, b:  val_5);
            val_6 = 0;
            if(val_3 != null)
            {
                    val_6 = val_3;
                if(null != null)
            {
                    val_6 = 0;
            }
            
            }
            
            this.OnPostPipelineStage = val_6;
        }
        public virtual void RemovePostPipelineStageHook(Cinemachine.CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
        {
            OnPostPipelineStageDelegate val_3;
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnPostPipelineStage);
            val_3 = 0;
            if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            this.OnPostPipelineStage = val_3;
        }
        protected void InvokePostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, ref Cinemachine.CameraState newState, float deltaTime)
        {
            var val_4;
            goto label_9;
            label_10:
            label_9:
            if(this.OnPostPipelineStage != null)
            {
                    this.OnPostPipelineStage.Invoke(vcam:  vcam, stage:  stage, newState: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {FieldOfView = newState.<Lens>k__BackingField.FieldOfView, OrthographicSize = newState.<Lens>k__BackingField.OrthographicSize, NearClipPlane = newState.<Lens>k__BackingField.NearClipPlane, FarClipPlane = newState.<Lens>k__BackingField.FarClipPlane, Dutch = newState.<Lens>k__BackingField.Dutch, <Orthographic>k__BackingField = newState.<Lens>k__BackingField.<Orthographic>k__BackingField, <Aspect>k__BackingField = newState.<Lens>k__BackingField.<Aspect>k__BackingField}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3() {x = newState.<ReferenceUp>k__BackingField.x, y = newState.<ReferenceUp>k__BackingField.y, z = newState.<ReferenceUp>k__BackingField.z}, <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3() {x = newState.<ReferenceLookAt>k__BackingField.x, y = newState.<ReferenceLookAt>k__BackingField.y, z = newState.<ReferenceLookAt>k__BackingField.z}, <RawPosition>k__BackingField = new UnityEngine.Vector3() {x = newState.<RawPosition>k__BackingField.x, y = newState.<RawPosition>k__BackingField.y, z = newState.<RawPosition>k__BackingField.z}}, deltaTime:  deltaTime);
            }
            
            Cinemachine.ICinemachineCamera val_1 = this.ParentCamera;
            val_4 = 0;
            if(0 == )
            {
                    return;
            }
            
            goto label_10;
        }
        public string get_Name()
        {
            return this.name;
        }
        public virtual string get_Description()
        {
            null = null;
            return (string)System.String.Empty;
        }
        public int get_Priority()
        {
            return (int)this.m_Priority;
        }
        public void set_Priority(int value)
        {
            this.m_Priority = value;
        }
        public UnityEngine.GameObject get_VirtualCameraGameObject()
        {
            if(0 != this)
            {
                    return this.gameObject;
            }
            
            return 0;
        }
        public abstract Cinemachine.CameraState get_State(); // 0
        public virtual Cinemachine.ICinemachineCamera get_LiveChildOrSelf()
        {
            return (Cinemachine.ICinemachineCamera)this;
        }
        public Cinemachine.ICinemachineCamera get_ParentCamera()
        {
            if(this.mSlaveStatusUpdated != false)
            {
                    if(UnityEngine.Application.isPlaying == true)
            {
                    return (Cinemachine.ICinemachineCamera)this.m_parentVcam;
            }
            
            }
            
            this.UpdateSlaveStatus();
            return (Cinemachine.ICinemachineCamera)this.m_parentVcam;
        }
        public virtual bool IsLiveChild(Cinemachine.ICinemachineCamera vcam)
        {
            return false;
        }
        public abstract UnityEngine.Transform get_LookAt(); // 0
        public abstract void set_LookAt(UnityEngine.Transform value); // 0
        public abstract UnityEngine.Transform get_Follow(); // 0
        public abstract void set_Follow(UnityEngine.Transform value); // 0
        public bool get_PreviousStateIsValid()
        {
            var val_5;
            if(0 != this)
            {
                    this.m_previousLookAtTarget = this;
                this.m_previousStateIsValid = false;
            }
            
            if(0 == this)
            {
                    return (bool)(this.m_previousStateIsValid == true) ? 1 : 0;
            }
            
            val_5 = 0;
            this.m_previousFollowTarget = this;
            this.m_previousStateIsValid = false;
            return (bool)(this.m_previousStateIsValid == true) ? 1 : 0;
        }
        public void set_PreviousStateIsValid(bool value)
        {
            this.m_previousStateIsValid = value;
        }
        public abstract void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime); // 0
        public virtual void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime)
        {
            if(this.gameObject.activeInHierarchy == true)
            {
                    return;
            }
            
            this.m_previousStateIsValid = false;
        }
        protected virtual void Start()
        {
        
        }
        protected virtual void OnDestroy()
        {
            Cinemachine.CinemachineCore.Instance.RemoveActiveCamera(vcam:  this);
        }
        protected virtual void OnValidate()
        {
            var val_1;
            this.m_OnValidateCalled = true;
            this.m_ValidatingStreamVersion = this.m_StreamingVersion;
            val_1 = null;
            val_1 = null;
            this.m_StreamingVersion = Cinemachine.CinemachineCore.kStreamingVersion;
        }
        protected virtual void OnEnable()
        {
            goto label_1;
            label_17:
            0 = 1;
            label_1:
            if(0 >= val_1.Length)
            {
                goto label_3;
            }
            
            if(((this.GetComponents<Cinemachine.CinemachineVirtualCameraBase>()[1].enabled) == false) || (0 == (val_1[0x1] + 32)))
            {
                goto label_17;
            }
            
            string val_6 = 0 + this.name + " has multiple CinemachineVirtualCameraBase-derived components.  Disabling "(" has multiple CinemachineVirtualCameraBase-derived components.  Disabling ") + this.GetType();
            UnityEngine.Debug.LogError(message:  0);
            this.enabled = false;
            goto label_17;
            label_3:
            this.UpdateSlaveStatus();
            this.UpdateVcamPoolStatus();
            this.m_previousStateIsValid = false;
        }
        protected virtual void OnDisable()
        {
            this.UpdateVcamPoolStatus();
        }
        protected virtual void Update()
        {
            if(this.m_Priority == this.m_QueuePriority)
            {
                    return;
            }
            
            this.UpdateVcamPoolStatus();
        }
        protected virtual void OnTransformParentChanged()
        {
            this.UpdateSlaveStatus();
            this.UpdateVcamPoolStatus();
        }
        private void UpdateSlaveStatus()
        {
            this.mSlaveStatusUpdated = true;
            this.m_parentVcam = 0;
            UnityEngine.Transform val_2 = this.transform.parent;
            if(0 == val_2)
            {
                    return;
            }
            
            this.m_parentVcam = val_2.GetComponent<Cinemachine.CinemachineVirtualCameraBase>();
        }
        protected UnityEngine.Transform ResolveLookAt(UnityEngine.Transform localLookAt)
        {
            var val_5;
            if(0 != localLookAt)
            {
                    return (UnityEngine.Transform)localLookAt;
            }
            
            if(this.ParentCamera == null)
            {
                    return (UnityEngine.Transform)localLookAt;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = this.ParentCamera;
        }
        protected UnityEngine.Transform ResolveFollow(UnityEngine.Transform localFollow)
        {
            var val_5;
            if(0 != localFollow)
            {
                    return (UnityEngine.Transform)localFollow;
            }
            
            if(this.ParentCamera == null)
            {
                    return (UnityEngine.Transform)localFollow;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = this.ParentCamera;
        }
        private void UpdateVcamPoolStatus()
        {
            this.m_QueuePriority = 2147483647;
            Cinemachine.CinemachineCore.Instance.RemoveActiveCamera(vcam:  this);
            Cinemachine.CinemachineCore.Instance.RemoveChildCamera(vcam:  this);
            bool val_4 = this.isActiveAndEnabled;
            if(0 == this.m_parentVcam)
            {
                    if(val_4 == false)
            {
                    return;
            }
            
                Cinemachine.CinemachineCore.Instance.AddActiveCamera(vcam:  this);
                this.m_QueuePriority = this.m_Priority;
                return;
            }
            
            if(val_4 == false)
            {
                    return;
            }
            
            Cinemachine.CinemachineCore.Instance.AddChildCamera(vcam:  this);
        }
        public void MoveToTopOfPrioritySubqueue()
        {
            this.UpdateVcamPoolStatus();
        }
    
    }

}
