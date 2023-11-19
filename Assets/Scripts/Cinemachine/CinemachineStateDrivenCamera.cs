using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.DisallowMultipleComponent]
    [UnityEngine.AddComponentMenu]
    public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public UnityEngine.Transform m_LookAt;
        [UnityEngine.TooltipAttribute]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public UnityEngine.Transform m_Follow;
        [UnityEngine.SpaceAttribute]
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Animator m_AnimatedTarget;
        [UnityEngine.TooltipAttribute]
        public int m_LayerIndex;
        [UnityEngine.TooltipAttribute]
        public bool m_ShowDebugText;
        [UnityEngine.TooltipAttribute]
        public bool m_EnableAllChildCameras;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineStateDrivenCamera.Instruction[] m_Instructions;
        [Cinemachine.CinemachineBlendDefinitionPropertyAttribute]
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineBlendDefinition m_DefaultBlend;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineBlenderSettings m_CustomBlends;
        [UnityEngine.HideInInspector]
        [UnityEngine.SerializeField]
        public Cinemachine.CinemachineStateDrivenCamera.ParentHash[] m_ParentHash;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.ICinemachineCamera <LiveChild>k__BackingField;
        private Cinemachine.CameraState m_State;
        private float mActivationTime;
        private Cinemachine.CinemachineStateDrivenCamera.Instruction mActiveInstruction;
        private float mPendingActivationTime;
        private Cinemachine.CinemachineStateDrivenCamera.Instruction mPendingInstruction;
        private Cinemachine.CinemachineBlend mActiveBlend;
        private System.Collections.Generic.Dictionary<int, int> mInstructionDictionary;
        private System.Collections.Generic.Dictionary<int, int> mStateParentLookup;
        private System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> m_clipInfoList;
        
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
        public CinemachineStateDrivenCamera()
        {
            this.m_DefaultBlend = 0;
            Cinemachine.CameraState val_1 = Cinemachine.CameraState.Default;
            this.m_clipInfoList = new System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>();
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
            var val_4;
            if((this.<LiveChild>k__BackingField) == vcam)
            {
                goto label_2;
            }
            
            if(this.mActiveBlend == null)
            {
                goto label_1;
            }
            
            if(this.mActiveBlend.CamA != vcam)
            {
                    var val_3 = (this.mActiveBlend.CamB == vcam) ? 1 : 0;
                return (bool)val_4;
            }
            
            label_2:
            val_4 = 1;
            return (bool)val_4;
            label_1:
            val_4 = 0;
            return (bool)val_4;
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
        public override void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime)
        {
            float val_24;
            Cinemachine.CinemachineVirtualCameraBase[] val_25;
            var val_26;
            bool val_27;
            Cinemachine.ICinemachineCamera val_28;
            Cinemachine.ICinemachineCamera val_29;
            var val_30;
            Cinemachine.CinemachineBlend val_31;
            var val_32;
            float val_34;
            var val_35;
            float val_2 = (this.PreviousStateIsValid != true) ? deltaTime : -1f;
            this.UpdateListOfChildren();
            val_24 = val_2;
            Cinemachine.CinemachineVirtualCameraBase val_3 = this.ChooseCurrentCamera(deltaTime:  val_24);
            val_25 = this.m_ChildCameras;
            if(val_25 == null)
            {
                goto label_4;
            }
            
            val_26 = 0;
            goto label_2;
            label_23:
            val_25 = this.m_ChildCameras;
            val_26 = 1;
            label_2:
            if(val_26 >= this.m_ChildCameras.Length)
            {
                goto label_4;
            }
            
            Cinemachine.CinemachineVirtualCameraBase val_24 = this.m_ChildCameras[1];
            if(0 == val_24)
            {
                goto label_23;
            }
            
            if(this.m_EnableAllChildCameras != false)
            {
                    val_27 = 1;
            }
            else
            {
                    val_27 = UnityEngine.Object.op_Equality(x:  0, y:  val_24);
            }
            
            if(val_27 == val_24.VirtualCameraGameObject.activeInHierarchy)
            {
                goto label_23;
            }
            
            val_24.gameObject.SetActive(value:  val_27);
            if(val_27 == false)
            {
                goto label_23;
            }
            
            bool val_11 = Cinemachine.CinemachineCore.Instance.UpdateVirtualCamera(vcam:  val_24, worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  val_2);
            goto label_23;
            label_4:
            val_28 = this.<LiveChild>k__BackingField;
            this.<LiveChild>k__BackingField = val_3;
            if(((val_28 == val_3) || (val_3 == null)) || (val_28 == null))
            {
                goto label_26;
            }
            
            val_29 = this.<LiveChild>k__BackingField;
            this.mActiveBlend = this.CreateBlend(camA:  val_28, camB:  val_29, blendCurve:  this.LookupBlendCurve(fromKey:  val_28, toKey:  val_3, duration: out  float val_12 = -8.122747E-16f), duration:  0f, activeBlend:  this.mActiveBlend, deltaTime:  worldUp.y);
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_29 = 14;
            val_30 = this.<LiveChild>k__BackingField;
            goto label_31;
            label_26:
            val_31 = this.mActiveBlend;
            goto label_36;
            label_31:
            val_24 = worldUp.x;
            val_31 = this.mActiveBlend;
            val_28 = Cinemachine.CinemachineCore.Instance;
            val_28.GenerateCameraActivationEvent(vcam:  this.<LiveChild>k__BackingField);
            if(mem[this.mActiveBlend] == 0)
            {
                    val_28 = Cinemachine.CinemachineCore.Instance;
                val_28.GenerateCameraCutEvent(vcam:  this.<LiveChild>k__BackingField);
            }
            
            label_36:
            val_32 = mem[this.mActiveBlend];
            if(val_32 == 0)
            {
                goto label_49;
            }
            
            float val_18 = val_32.TimeInBlend;
            if(val_2 < 0f)
            {
                    val_28 = mem[this.mActiveBlend];
                val_34 = val_28.Duration;
                if(val_32 != 0)
            {
                    if(((val_2 >= 0f) ? 1 : 0) == 0)
            {
                goto label_45;
            }
            
            }
            
                val_32 = 0;
            }
            else
            {
                    val_34 = val_2;
            }
            
            label_45:
            val_18 = val_18 + val_34;
            val_32.TimeInBlend = val_18;
            if(mem[this.mActiveBlend].IsComplete == false)
            {
                goto label_47;
            }
            
            mem2[0] = 0;
            goto label_49;
            label_47:
            if(mem[this.mActiveBlend] == 0)
            {
                goto label_49;
            }
            
            mem[this.mActiveBlend].UpdateCameraState(worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  val_2);
            Cinemachine.CameraState val_22 = mem[this.mActiveBlend].State;
            goto label_51;
            label_49:
            if((this.<LiveChild>k__BackingField) == null)
            {
                goto label_52;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_35 = this.<LiveChild>k__BackingField;
            label_51:
            label_52:
            mem[1152921511693799176] = 1;
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
        public static string CreateFakeHashName(int parentHash, string stateName)
        {
            return (string)0 + stateName + "_";
        }
        private void InvalidateListOfChildren()
        {
            this.m_ChildCameras = 0;
            this.<LiveChild>k__BackingField = 0;
        }
        private void UpdateListOfChildren()
        {
            var val_8;
            if(((this.m_ChildCameras != null) && (this.mInstructionDictionary != null)) && (this.mStateParentLookup != null))
            {
                    return;
            }
            
            System.Collections.Generic.List<Cinemachine.CinemachineVirtualCameraBase> val_1 = new System.Collections.Generic.List<Cinemachine.CinemachineVirtualCameraBase>();
            val_8 = 0;
            goto label_4;
            label_14:
            val_8 = 1;
            label_4:
            if(val_8 >= val_2.Length)
            {
                goto label_6;
            }
            
            T val_8 = this.GetComponentsInChildren<Cinemachine.CinemachineVirtualCameraBase>(includeInactive:  true)[1];
            UnityEngine.Transform val_5 = this.transform;
            if(0 != val_8.transform.parent)
            {
                goto label_14;
            }
            
            Add(item:  val_8);
            goto label_14;
            label_6:
            this.m_ChildCameras = ToArray();
            this.ValidateInstructions();
        }
        public void ValidateInstructions()
        {
            var val_8;
            var val_9;
            Instruction[] val_10;
            if(this.m_Instructions == null)
            {
                    this.m_Instructions = null;
            }
            
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = null;
            val_8 = 1152921509853471184;
            val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            this.mInstructionDictionary = val_1;
            val_9 = 0;
            goto label_2;
            label_22:
            set_Item(key:  W22, value:  0);
            val_9 = 1;
            label_2:
            val_10 = this.m_Instructions;
            if(val_9 >= this.m_Instructions.Length)
            {
                goto label_4;
            }
            
            var val_2 = this.m_Instructions + (1 * 24);
            if(0 != ((1 * 24) + this.m_Instructions + 40))
            {
                    var val_4 = this.m_Instructions + (1 * 24);
                UnityEngine.Transform val_7 = this.transform;
                if(0 != ((1 * 24) + this.m_Instructions + 40.transform.parent))
            {
                    var val_9 = this.m_Instructions + (1 * 24);
                mem2[0] = 0;
            }
            
            }
            
            var val_10 = this.m_Instructions + (1 * 24);
            if(this.mInstructionDictionary != null)
            {
                goto label_22;
            }
            
            goto label_22;
            label_4:
            this.mStateParentLookup = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            if((this.m_ParentHash != null) && (this.m_ParentHash.Length >= 1))
            {
                    do
            {
                val_8 = 0;
                val_10 = this.m_ParentHash[val_8];
                this.mStateParentLookup.set_Item(key:  this.m_ParentHash[val_8], value:  val_10);
            }
            while((val_8 + 1) < this.m_ParentHash.Length);
            
            }
            
            this.mActiveBlend = 0;
            this.mPendingActivationTime = 0f;
            this.mActivationTime = 0f;
        }
        private Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera(float deltaTime)
        {
            var val_13;
            Cinemachine.CinemachineVirtualCameraBase val_27;
            UnityEngine.Animator val_28;
            int val_29;
            if((this.m_ChildCameras == null) || (this.m_ChildCameras.Length == 0))
            {
                goto label_2;
            }
            
            val_27 = this.m_ChildCameras[0];
            val_28 = this.m_AnimatedTarget;
            if(0 == val_28)
            {
                goto label_15;
            }
            
            val_28 = this.m_AnimatedTarget.gameObject;
            if(val_28.activeSelf == false)
            {
                goto label_15;
            }
            
            val_28 = this.m_AnimatedTarget.runtimeAnimatorController;
            if((0 == val_28) || ((this.m_LayerIndex & 2147483648) != 0))
            {
                goto label_15;
            }
            
            val_28 = this.m_AnimatedTarget;
            if(this.m_LayerIndex >= val_28.layerCount)
            {
                goto label_15;
            }
            
            if((this.m_AnimatedTarget.IsInTransition(layerIndex:  this.m_LayerIndex)) == false)
            {
                goto label_18;
            }
            
            UnityEngine.AnimatorStateInfo val_10 = this.m_AnimatedTarget.GetNextAnimatorStateInfo(layerIndex:  this.m_LayerIndex);
            val_29;
            if((this.m_AnimatedTarget.GetNextAnimatorClipInfoCount(layerIndex:  this.m_LayerIndex)) < 2)
            {
                goto label_24;
            }
            
            this.m_AnimatedTarget.GetNextAnimatorClipInfo(layerIndex:  this.m_LayerIndex, clips:  this.m_clipInfoList);
            goto label_22;
            label_2:
            val_27 = 0;
            label_15:
            this.mActivationTime = 0f;
            return (Cinemachine.CinemachineVirtualCameraBase)val_27;
            label_18:
            UnityEngine.AnimatorStateInfo val_15 = this.m_AnimatedTarget.GetCurrentAnimatorStateInfo(layerIndex:  this.m_LayerIndex);
            val_29;
            if((this.m_AnimatedTarget.GetCurrentAnimatorClipInfoCount(layerIndex:  this.m_LayerIndex)) < 2)
            {
                goto label_24;
            }
            
            this.m_AnimatedTarget.GetCurrentAnimatorClipInfo(layerIndex:  this.m_LayerIndex, clips:  this.m_clipInfoList);
            label_22:
            val_29 = val_13.GetClipHash(hash:  -1500696224, clips:  this.m_clipInfoList);
            label_24:
            if(val_29 == 0)
            {
                goto label_30;
            }
            
            label_32:
            if((this.mInstructionDictionary.ContainsKey(key:  val_29)) == true)
            {
                goto label_28;
            }
            
            if((this.mStateParentLookup.ContainsKey(key:  val_29)) != false)
            {
                    if(this.mStateParentLookup.Item[val_29] != 0)
            {
                goto label_32;
            }
            
            }
            
            label_30:
            val_29 = 0;
            label_28:
            float val_21 = UnityEngine.Time.time;
            float val_28 = this.mActivationTime;
            if(val_28 != 0f)
            {
                    if(this.mActiveInstruction == val_29)
            {
                    this.mPendingActivationTime = 0f;
                return (Cinemachine.CinemachineVirtualCameraBase)val_27;
            }
            
                if(deltaTime >= 0f)
            {
                    float val_27 = this.mPendingActivationTime;
                if((val_27 != 0f) && (this.mPendingInstruction == val_29))
            {
                    val_27 = val_21 - val_27;
                if(val_27 <= S2)
            {
                    return (Cinemachine.CinemachineVirtualCameraBase)val_27;
            }
            
                val_28 = val_21 - val_28;
                if(val_28 <= val_27)
            {
                    if(this.m_ChildCameras[0].m_Priority <= 1638426)
            {
                    return (Cinemachine.CinemachineVirtualCameraBase)val_27;
            }
            
            }
            
                m_ActivateAfter = this.mPendingInstruction.m_ActivateAfter;
                mem2[0] = this.mPendingInstruction.m_FullHash;
                this.mActivationTime = val_21;
                this.mPendingActivationTime = 0f;
                return (Cinemachine.CinemachineVirtualCameraBase)val_27;
            }
            
            }
            
            }
            
            this.mPendingActivationTime = 0f;
            if((this.mInstructionDictionary.ContainsKey(key:  0)) == false)
            {
                goto label_46;
            }
            
            var val_29 = 24;
            val_29 = this.m_Instructions + ((long)this.mInstructionDictionary.Item[0] * val_29);
            var val_26 = (0 != (((long)(int)(val_24) * 24) + this.m_Instructions + 32 + 8)) ? (val_27) : (((long)(int)(val_24) * 24) + this.m_Instructions + 32 + 8);
            if(deltaTime < 0f)
            {
                goto label_55;
            }
            
            float val_30 = this.mActivationTime;
            if(val_30 <= 0f)
            {
                goto label_55;
            }
            
            if((((long)(int)(val_24) * 24) + this.m_Instructions + 48) > 0f)
            {
                goto label_54;
            }
            
            val_30 = val_21 - val_30;
            label_55:
            this.mActiveInstruction = ((long)(int)(val_24) * 24) + this.m_Instructions + 32;
            mem[1152921511696097976] = val_26;
            mem[1152921511696097984] = ((long)(int)(val_24) * 24) + this.m_Instructions + 48;
            mem[1152921511696097988] = ((long)(int)(val_24) * 24) + this.m_Instructions + 52;
            this.mActivationTime = val_21;
            return (Cinemachine.CinemachineVirtualCameraBase)val_27;
            label_46:
            label_62:
            if(this.mActivationTime == 0f)
            {
                    return (Cinemachine.CinemachineVirtualCameraBase)val_27;
            }
            
            return (Cinemachine.CinemachineVirtualCameraBase)val_27;
            label_54:
            this.mPendingInstruction = ((long)(int)(val_24) * 24) + this.m_Instructions + 32;
            mem[1152921511696098008] = val_26;
            mem[1152921511696098016] = ((long)(int)(val_24) * 24) + this.m_Instructions + 48;
            mem[1152921511696098020] = ((long)(int)(val_24) * 24) + this.m_Instructions + 52;
            this.mPendingActivationTime = val_21;
            goto label_62;
        }
        private int GetClipHash(int hash, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
        {
            var val_10;
            string val_11;
            var val_12;
            val_11 = hash;
            if(clips.Count <= 1)
            {
                    return (int)val_11;
            }
            
            val_12 = 0;
            val_10 = 0;
            goto label_3;
            label_10:
            val_12 = 1;
            label_3:
            if(val_12 >= clips.Count)
            {
                goto label_5;
            }
            
            if((val_10 & 2147483648) != 0)
            {
                goto label_10;
            }
            
            UnityEngine.AnimatorClipInfo val_3 = clips.Item[1];
            UnityEngine.AnimatorClipInfo val_4 = clips.Item[0];
            if(V0.16B <= S0)
            {
                goto label_10;
            }
            
            goto label_10;
            label_5:
            if((0 & 2) != 0)
            {
                    return (int)val_11;
            }
            
            UnityEngine.AnimatorClipInfo val_5 = clips.Item[0];
            if(S0 <= 0f)
            {
                    return (int)val_11;
            }
            
            UnityEngine.AnimatorClipInfo val_6 = clips.Item[0];
            string val_8 = Cinemachine.CinemachineStateDrivenCamera.CreateFakeHashName(parentHash:  val_6.m_ClipInstanceID.name, stateName:  val_11);
            val_11 = UnityEngine.Animator.StringToHash(name:  0);
            return (int)val_11;
        }
        private UnityEngine.AnimationCurve LookupBlendCurve(Cinemachine.ICinemachineCamera fromKey, Cinemachine.ICinemachineCamera toKey, out float duration)
        {
            var val_8;
            string val_9;
            UnityEngine.AnimationCurve val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            string val_15;
            val_8 = 1152921511696617648;
            val_9 = fromKey;
            val_10 = this.m_DefaultBlend;
            if(0 == this.m_CustomBlends)
            {
                goto label_3;
            }
            
            if(val_9 == null)
            {
                goto label_4;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_11 = val_9;
            goto label_8;
            label_4:
            val_12 = null;
            val_12 = null;
            val_9 = System.String.Empty;
            goto label_11;
            label_8:
            val_9 = val_9;
            label_11:
            if(toKey == null)
            {
                goto label_12;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_13 = toKey;
            goto label_16;
            label_12:
            val_14 = null;
            val_14 = null;
            val_15 = System.String.Empty;
            goto label_19;
            label_16:
            val_15 = toKey;
            label_19:
            val_10 = this.m_CustomBlends.GetBlendCurveForVirtualCameras(fromCameraName:  val_9, toCameraName:  val_15, defaultCurve:  val_10);
            label_3:
            UnityEngine.Keyframe[] val_5 = val_10.keys;
            if(val_5 != null)
            {
                    if(val_5.Length != 0)
            {
                    var val_10 = -4294967296;
                val_10 = val_10 + ((val_5.Length) << 32);
                val_8 = (val_5.Length == 0) ? 0 : (val_8);
            }
            
            }
            
            mem2[0] = 0f;
            return (UnityEngine.AnimationCurve)val_10;
        }
        private Cinemachine.CinemachineBlend CreateBlend(Cinemachine.ICinemachineCamera camA, Cinemachine.ICinemachineCamera camB, UnityEngine.AnimationCurve blendCurve, float duration, Cinemachine.CinemachineBlend activeBlend, float deltaTime)
        {
            Cinemachine.ICinemachineCamera val_4;
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
                goto label_7;
            }
            
            label_4:
            Cinemachine.CameraState val_1 = activeBlend.State;
            label_9:
            object val_2 = null;
            val_4 = val_2;
            val_2 = new System.Object();
            typeof(Cinemachine.StaticPointVirtualCamera).__il2cppRuntimeField_10 = "Mid-blend";
            label_5:
            Cinemachine.CinemachineBlend val_3 = null;
            val_5 = val_3;
            val_3 = new Cinemachine.CinemachineBlend(a:  val_4, b:  camB, curve:  blendCurve, duration:  duration, t:  0f);
            return (Cinemachine.CinemachineBlend)val_5;
            label_7:
            goto label_9;
        }
    
    }

}
