using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.DisallowMultipleComponent]
    [UnityEngine.AddComponentMenu]
    public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public UnityEngine.Transform m_LookAt;
        [UnityEngine.TooltipAttribute]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public UnityEngine.Transform m_Follow;
        [UnityEngine.TooltipAttribute]
        public bool m_ShowDebugText;
        [UnityEngine.TooltipAttribute]
        public bool m_EnableAllChildCameras;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineBlendListCamera.Instruction[] m_Instructions;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.ICinemachineCamera <LiveChild>k__BackingField;
        private Cinemachine.CameraState m_State;
        private float mActivationTime;
        private int mCurrentInstruction;
        private Cinemachine.CinemachineBlend mActiveBlend;
        
        // Properties
        public override string Description { get; }
        public Cinemachine.ICinemachineCamera LiveChild { get; set; }
        public override Cinemachine.ICinemachineCamera LiveChildOrSelf { get; }
        public override Cinemachine.CameraState State { get; }
        public override UnityEngine.Transform LookAt { get; set; }
        public override UnityEngine.Transform Follow { get; set; }
        public Cinemachine.CinemachineVirtualCameraBase[] ChildCameras { get; }
        public bool IsBlending { get; }
        
        // Methods
        public CinemachineBlendListCamera()
        {
            Cinemachine.CameraState val_1 = Cinemachine.CameraState.Default;
            this.mActivationTime = -1f;
        }
        public override string get_Description()
        {
            var val_2;
            if(this.mActiveBlend != null)
            {
                    return this.mActiveBlend.Description;
            }
            
            if((this.<LiveChild>k__BackingField) == null)
            {
                    return "(none)";
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.<LiveChild>k__BackingField;
            return 0 + "[" + this.<LiveChild>k__BackingField(this.<LiveChild>k__BackingField);
        }
        public void set_LiveChild(Cinemachine.ICinemachineCamera value)
        {
            this.<LiveChild>k__BackingField = value;
        }
        public Cinemachine.ICinemachineCamera get_LiveChild()
        {
            return (Cinemachine.ICinemachineCamera)this.<LiveChild>k__BackingField;
        }
        public override Cinemachine.ICinemachineCamera get_LiveChildOrSelf()
        {
            return (Cinemachine.ICinemachineCamera)this.<LiveChild>k__BackingField;
        }
        public override bool IsLiveChild(Cinemachine.ICinemachineCamera vcam)
        {
            if((this.<LiveChild>k__BackingField) == vcam)
            {
                    return true;
            }
            
            if(this.mActiveBlend == null)
            {
                    return false;
            }
            
            if((this.mActiveBlend.<CamA>k__BackingField) == vcam)
            {
                    return true;
            }
            
            return (bool)((this.mActiveBlend.<CamB>k__BackingField) == vcam) ? 1 : 0;
        }
        public override Cinemachine.CameraState get_State()
        {
        
        }
        public override UnityEngine.Transform get_LookAt()
        {
            return this.ResolveLookAt(localLookAt:  this.m_LookAt);
        }
        public override void set_LookAt(UnityEngine.Transform value)
        {
            this.m_LookAt = value;
        }
        public override UnityEngine.Transform get_Follow()
        {
            return this.ResolveFollow(localFollow:  this.m_Follow);
        }
        public override void set_Follow(UnityEngine.Transform value)
        {
            this.m_Follow = value;
        }
        public override void RemovePostPipelineStageHook(Cinemachine.CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
        {
            var val_1;
            this.RemovePostPipelineStageHook(d:  d);
            this.UpdateListOfChildren();
            val_1 = 0;
            goto label_0;
            label_5:
            val_1 = 1;
            label_0:
            if(val_1 >= this.m_ChildCameras.Length)
            {
                    return;
            }
            
            if(this.m_ChildCameras[1] != null)
            {
                goto label_5;
            }
            
            goto label_5;
        }
        public override void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime)
        {
            this.OnTransitionFromCamera(fromCam:  fromCam, worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  deltaTime);
            this.<LiveChild>k__BackingField = 0;
            this.mActivationTime = UnityEngine.Time.time;
            this.mActiveBlend = 0;
            this.mCurrentInstruction = 0;
            goto typeof(Cinemachine.CinemachineBlendListCamera).__il2cppRuntimeField_2E0;
        }
        public override void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime)
        {
            UnityEngine.Object val_20;
            Cinemachine.CinemachineVirtualCameraBase[] val_21;
            var val_22;
            bool val_23;
            Cinemachine.ICinemachineCamera val_24;
            var val_25;
            float val_26;
            var val_27;
            float val_2 = (this.PreviousStateIsValid != true) ? deltaTime : -1f;
            this.UpdateListOfChildren();
            this.AdvanceCurrentInstruction();
            val_20 = 0;
            if((this.mCurrentInstruction & 2147483648) == 0)
            {
                    if(this.mCurrentInstruction < this.m_Instructions.Length)
            {
                    var val_20 = 24;
                val_20 = this.m_Instructions + (this.mCurrentInstruction * val_20);
                val_20 = mem[(this.mCurrentInstruction * 24) + this.m_Instructions + 32];
                val_20 = (this.mCurrentInstruction * 24) + this.m_Instructions + 32;
            }
            else
            {
                    val_20 = 0;
            }
            
            }
            
            val_21 = this.m_ChildCameras;
            if(val_21 == null)
            {
                goto label_10;
            }
            
            val_22 = 0;
            goto label_8;
            label_29:
            val_21 = this.m_ChildCameras;
            val_22 = 1;
            label_8:
            if(val_22 >= this.m_ChildCameras.Length)
            {
                goto label_10;
            }
            
            Cinemachine.CinemachineVirtualCameraBase val_21 = this.m_ChildCameras[1];
            if(0 == val_21)
            {
                goto label_29;
            }
            
            if(this.m_EnableAllChildCameras != false)
            {
                    val_23 = 1;
            }
            else
            {
                    val_23 = UnityEngine.Object.op_Equality(x:  0, y:  val_21);
            }
            
            if(val_23 == val_21.VirtualCameraGameObject.activeInHierarchy)
            {
                goto label_29;
            }
            
            val_21.gameObject.SetActive(value:  val_23);
            if(val_23 == false)
            {
                goto label_29;
            }
            
            bool val_10 = Cinemachine.CinemachineCore.Instance.UpdateVirtualCamera(vcam:  val_21, worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  val_2);
            goto label_29;
            label_10:
            if(0 != val_20)
            {
                    val_21 = this.<LiveChild>k__BackingField;
                this.<LiveChild>k__BackingField = val_20;
                if((((val_21 != val_20) && (val_20 != 0)) && (val_21 != null)) && (this.mCurrentInstruction >= 1))
            {
                    var val_22 = 24;
                val_22 = this.m_Instructions + (this.mCurrentInstruction * val_22);
                var val_23 = 24;
                val_23 = this.m_Instructions + (this.mCurrentInstruction * val_23);
                val_24 = val_20;
                this.mActiveBlend = this.CreateBlend(camA:  val_21, camB:  val_24, blendCurve:  val_22 + 44, duration:  (this.mCurrentInstruction * 24) + this.m_Instructions + 48, activeBlend:  this.mActiveBlend, deltaTime:  worldUp.y);
                var val_24 = 0;
                val_24 = val_24 + 1;
                val_24 = 14;
                val_25 = this.<LiveChild>k__BackingField;
                val_21 = Cinemachine.CinemachineCore.Instance;
                val_21.GenerateCameraActivationEvent(vcam:  this.<LiveChild>k__BackingField);
                if(this.mActiveBlend == null)
            {
                    val_21 = Cinemachine.CinemachineCore.Instance;
                val_21.GenerateCameraCutEvent(vcam:  this.<LiveChild>k__BackingField);
            }
            
            }
            
            }
            
            if(this.mActiveBlend == null)
            {
                goto label_59;
            }
            
            float val_25 = this.mActiveBlend.<TimeInBlend>k__BackingField;
            val_26 = val_2;
            if(val_2 >= 0f)
            {
                goto label_54;
            }
            
            if((this.mActiveBlend == null) || (((val_2 >= 0f) ? 1 : 0) != 0))
            {
                goto label_56;
            }
            
            val_26 = this.mActiveBlend.<Duration>k__BackingField;
            label_54:
            val_25 = val_25 + val_26;
            this.mActiveBlend.<TimeInBlend>k__BackingField = val_25;
            if((this.mActiveBlend.<TimeInBlend>k__BackingField) >= (this.mActiveBlend.<Duration>k__BackingField))
            {
                goto label_58;
            }
            
            if(this.mActiveBlend == null)
            {
                goto label_59;
            }
            
            this.mActiveBlend.UpdateCameraState(worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  val_2);
            Cinemachine.CameraState val_18 = this.mActiveBlend.State;
            goto label_61;
            label_58:
            this.mActiveBlend = 0;
            label_59:
            if((this.<LiveChild>k__BackingField) == null)
            {
                goto label_62;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_27 = this.<LiveChild>k__BackingField;
            label_61:
            label_62:
            this.PreviousStateIsValid = true;
            return;
            label_56:
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.mActiveBlend = 0;
            this.m_ChildCameras = 0;
            this.<LiveChild>k__BackingField = 0;
        }
        public void OnTransformChildrenChanged()
        {
            this.m_ChildCameras = 0;
            this.<LiveChild>k__BackingField = 0;
        }
        public Cinemachine.CinemachineVirtualCameraBase[] get_ChildCameras()
        {
            this.UpdateListOfChildren();
            return (Cinemachine.CinemachineVirtualCameraBase[])this.m_ChildCameras;
        }
        public bool get_IsBlending()
        {
            return (bool)(this.mActiveBlend != 0) ? 1 : 0;
        }
        private void InvalidateListOfChildren()
        {
            this.m_ChildCameras = 0;
            this.<LiveChild>k__BackingField = 0;
        }
        private void UpdateListOfChildren()
        {
            var val_8;
            if(this.m_ChildCameras != null)
            {
                    return;
            }
            
            System.Collections.Generic.List<Cinemachine.CinemachineVirtualCameraBase> val_1 = new System.Collections.Generic.List<Cinemachine.CinemachineVirtualCameraBase>();
            val_8 = 0;
            goto label_2;
            label_12:
            val_8 = 1;
            label_2:
            if(val_8 >= val_2.Length)
            {
                goto label_4;
            }
            
            T val_8 = this.GetComponentsInChildren<Cinemachine.CinemachineVirtualCameraBase>(includeInactive:  true)[1];
            UnityEngine.Transform val_5 = this.transform;
            if(0 != val_8.transform.parent)
            {
                goto label_12;
            }
            
            Add(item:  val_8);
            goto label_12;
            label_4:
            this.m_ChildCameras = ToArray();
            this.ValidateInstructions();
        }
        public void ValidateInstructions()
        {
            Instruction[] val_6;
            var val_7;
            val_6 = this.m_Instructions;
            if(val_6 == null)
            {
                    val_6 = null;
                this.m_Instructions = val_6;
            }
            
            val_7 = 0;
            goto label_2;
            label_19:
            val_6 = this.m_Instructions;
            val_7 = 1;
            label_2:
            if(val_7 >= this.m_Instructions.Length)
            {
                goto label_4;
            }
            
            var val_1 = this.m_Instructions + (1 * 24);
            if(0 == ((1 * 24) + this.m_Instructions + 32))
            {
                goto label_19;
            }
            
            var val_3 = this.m_Instructions + (1 * 24);
            UnityEngine.Transform val_6 = this.transform;
            if(0 == ((1 * 24) + this.m_Instructions + 32.transform.parent))
            {
                goto label_19;
            }
            
            var val_8 = this.m_Instructions + (1 * 24);
            mem2[0] = 0;
            goto label_19;
            label_4:
            this.mActiveBlend = 0;
        }
        private void AdvanceCurrentInstruction()
        {
            int val_4;
            if((((this.m_ChildCameras == null) || (this.m_ChildCameras.Length == 0)) || (this.mActivationTime < 0)) || (this.m_Instructions.Length == 0))
            {
                goto label_5;
            }
            
            int val_4 = this.m_Instructions.Length;
            val_4 = val_4 - 1;
            if(this.mCurrentInstruction >= val_4)
            {
                goto label_7;
            }
            
            float val_1 = UnityEngine.Time.time;
            if((this.mCurrentInstruction & 2147483648) != 0)
            {
                goto label_8;
            }
            
            var val_5 = 24;
            val_5 = this.m_Instructions + (this.mCurrentInstruction * val_5);
            if((val_1 - this.mActivationTime) <= (UnityEngine.Mathf.Max(a:  0f, b:  (this.mCurrentInstruction * 24) + this.m_Instructions + 40)))
            {
                    return;
            }
            
            this.mActivationTime = val_1;
            val_4 = this.mCurrentInstruction + 1;
            goto label_14;
            label_5:
            this.mActivationTime = -1f;
            this.mCurrentInstruction = 0;
            this.mActiveBlend = 0;
            return;
            label_7:
            val_4 = this.m_Instructions.Length - 1;
            label_14:
            this.mCurrentInstruction = val_4;
            return;
            label_8:
            this.mActivationTime = val_1;
            this.mCurrentInstruction = 0;
        }
        private Cinemachine.CinemachineBlend CreateBlend(Cinemachine.ICinemachineCamera camA, Cinemachine.ICinemachineCamera camB, UnityEngine.AnimationCurve blendCurve, float duration, Cinemachine.CinemachineBlend activeBlend, float deltaTime)
        {
            Cinemachine.StaticPointVirtualCamera val_4;
            var val_5;
            val_4 = camA;
            val_5 = 0;
            if(blendCurve == null)
            {
                    return (Cinemachine.CinemachineBlend)val_5;
            }
            
            if(duration <= 0f)
            {
                    return (Cinemachine.CinemachineBlend)val_5;
            }
            
            if(val_4 == null)
            {
                goto label_3;
            }
            
            if(activeBlend != null)
            {
                goto label_4;
            }
            
            goto label_5;
            label_3:
            if(camB == null)
            {
                    return (Cinemachine.CinemachineBlend)val_5;
            }
            
            if(activeBlend == null)
            {
                goto label_9;
            }
            
            label_4:
            Cinemachine.CameraState val_1 = activeBlend.State;
            label_9:
            val_4 = null;
            val_4 = new Cinemachine.StaticPointVirtualCamera(state:  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {<Orthographic>k__BackingField = false}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3(), <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3(), <RawPosition>k__BackingField = new UnityEngine.Vector3(), <RawOrientation>k__BackingField = new UnityEngine.Quaternion(), <PositionDampingBypass>k__BackingField = new UnityEngine.Vector3(), <PositionCorrection>k__BackingField = new UnityEngine.Vector3(), <OrientationCorrection>k__BackingField = new UnityEngine.Quaternion(), mCustom0 = new CustomBlendable(), mCustom1 = new CustomBlendable(), mCustom2 = new CustomBlendable(), mCustom3 = new CustomBlendable()}, name:  "Mid-blend");
            label_5:
            Cinemachine.CinemachineBlend val_3 = null;
            val_5 = val_3;
            val_3 = new Cinemachine.CinemachineBlend(a:  val_4, b:  camB, curve:  blendCurve, duration:  duration, t:  0f);
            return (Cinemachine.CinemachineBlend)val_5;
        }
    
    }

}
