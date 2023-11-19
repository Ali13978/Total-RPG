using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.DisallowMultipleComponent]
    [UnityEngine.AddComponentMenu]
    public class CinemachineClearShot : CinemachineVirtualCameraBase
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public UnityEngine.Transform m_LookAt;
        [UnityEngine.TooltipAttribute]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public UnityEngine.Transform m_Follow;
        [UnityEngine.TooltipAttribute]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public bool m_ShowDebugText;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;
        [UnityEngine.TooltipAttribute]
        public float m_ActivateAfter;
        [UnityEngine.TooltipAttribute]
        public float m_MinDuration;
        [UnityEngine.TooltipAttribute]
        public bool m_RandomizeChoice;
        [Cinemachine.CinemachineBlendDefinitionPropertyAttribute]
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineBlendDefinition m_DefaultBlend;
        [UnityEngine.HideInInspector]
        public Cinemachine.CinemachineBlenderSettings m_CustomBlends;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.ICinemachineCamera <LiveChild>k__BackingField;
        private Cinemachine.CameraState m_State;
        private float mActivationTime;
        private float mPendingActivationTime;
        private Cinemachine.ICinemachineCamera mPendingCamera;
        private Cinemachine.CinemachineBlend mActiveBlend;
        private bool mRandomizeNow;
        private Cinemachine.CinemachineVirtualCameraBase[] m_RandomizedChilden;
        private static System.Comparison<Cinemachine.CinemachineClearShot.Pair> <>f__am$cache0;
        
        // Properties
        public override string Description { get; }
        public Cinemachine.ICinemachineCamera LiveChild { get; set; }
        public override Cinemachine.CameraState State { get; }
        public override Cinemachine.ICinemachineCamera LiveChildOrSelf { get; }
        public override UnityEngine.Transform LookAt { get; set; }
        public override UnityEngine.Transform Follow { get; set; }
        public bool IsBlending { get; }
        public Cinemachine.CinemachineVirtualCameraBase[] ChildCameras { get; }
        
        // Methods
        public CinemachineClearShot()
        {
            this.m_DefaultBlend = 0;
            Cinemachine.CameraState val_1 = Cinemachine.CameraState.Default;
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
        public override Cinemachine.CameraState get_State()
        {
        
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
            Cinemachine.ICinemachineCamera val_13;
            var val_14;
            Cinemachine.CinemachineBlend val_15;
            var val_16;
            float val_17;
            var val_18;
            float val_2 = (this.PreviousStateIsValid != true) ? deltaTime : -1f;
            this.UpdateListOfChildren();
            Cinemachine.ICinemachineCamera val_3 = this.ChooseCurrentCamera(worldUp:  new UnityEngine.Vector3() {x = -1f, y = worldUp.y, z = worldUp.z}, deltaTime:  val_2);
            this.<LiveChild>k__BackingField = val_3;
            if((((this.<LiveChild>k__BackingField) == val_3) || ((this.<LiveChild>k__BackingField) == null)) || (val_3 == null))
            {
                goto label_3;
            }
            
            val_13 = this.<LiveChild>k__BackingField;
            this.mActiveBlend = this.CreateBlend(camA:  this.<LiveChild>k__BackingField, camB:  val_13, blendCurve:  this.LookupBlendCurve(fromKey:  this.<LiveChild>k__BackingField, toKey:  val_3, duration: out  float val_4 = -5.462604E-17f), duration:  0f, activeBlend:  this.mActiveBlend, deltaTime:  worldUp.y);
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_13 = 14;
            val_14 = this.<LiveChild>k__BackingField;
            goto label_8;
            label_3:
            val_15 = this.mActiveBlend;
            goto label_13;
            label_8:
            val_15 = this.mActiveBlend;
            val_16 = Cinemachine.CinemachineCore.Instance;
            val_16.GenerateCameraActivationEvent(vcam:  this.<LiveChild>k__BackingField);
            if(mem[this.mActiveBlend] == 0)
            {
                    val_16 = Cinemachine.CinemachineCore.Instance;
                val_16.GenerateCameraCutEvent(vcam:  this.<LiveChild>k__BackingField);
            }
            
            label_13:
            if(mem[this.mActiveBlend] == 0)
            {
                goto label_23;
            }
            
            float val_14 = mem[this.mActiveBlend] + 40;
            val_17 = val_2;
            if(val_2 >= 0f)
            {
                goto label_18;
            }
            
            if((mem[this.mActiveBlend] == 0) || (((val_2 >= 0f) ? 1 : 0) != 0))
            {
                goto label_20;
            }
            
            val_17 = mem[mem[this.mActiveBlend] + 44];
            val_17 = mem[this.mActiveBlend] + 44;
            label_18:
            val_14 = val_14 + val_17;
            mem2[0] = val_14;
            if((mem[this.mActiveBlend] + 40) >= (mem[this.mActiveBlend] + 40 + 4))
            {
                goto label_22;
            }
            
            if(mem[this.mActiveBlend] == 0)
            {
                goto label_23;
            }
            
            mem[this.mActiveBlend].UpdateCameraState(worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  val_2);
            Cinemachine.CameraState val_11 = mem[this.mActiveBlend].State;
            goto label_25;
            label_22:
            mem2[0] = 0;
            label_23:
            if((this.<LiveChild>k__BackingField) == null)
            {
                goto label_26;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_18 = this.<LiveChild>k__BackingField;
            label_25:
            label_26:
            this.PreviousStateIsValid = true;
            return;
            label_20:
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.mActiveBlend = 0;
            this.m_ChildCameras = 0;
            this.m_RandomizedChilden = 0;
            this.<LiveChild>k__BackingField = 0;
        }
        public void OnTransformChildrenChanged()
        {
            this.m_ChildCameras = 0;
            this.m_RandomizedChilden = 0;
            this.<LiveChild>k__BackingField = 0;
        }
        public bool get_IsBlending()
        {
            return (bool)(this.mActiveBlend != 0) ? 1 : 0;
        }
        public Cinemachine.CinemachineVirtualCameraBase[] get_ChildCameras()
        {
            this.UpdateListOfChildren();
            return (Cinemachine.CinemachineVirtualCameraBase[])this.m_ChildCameras;
        }
        private void InvalidateListOfChildren()
        {
            this.m_ChildCameras = 0;
            this.m_RandomizedChilden = 0;
            this.<LiveChild>k__BackingField = 0;
        }
        public void ResetRandomization()
        {
            this.m_RandomizedChilden = 0;
            this.mRandomizeNow = true;
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
            this.<LiveChild>k__BackingField = 0;
            this.mPendingCamera = 0;
            this.mActiveBlend = 0;
            this.mActivationTime = 0f;
            this.mPendingActivationTime = 0f;
        }
        private Cinemachine.ICinemachineCamera ChooseCurrentCamera(UnityEngine.Vector3 worldUp, float deltaTime)
        {
            float val_7;
            float val_8;
            Cinemachine.CinemachineVirtualCameraBase[] val_17;
            Cinemachine.ICinemachineCamera val_18;
            var val_19;
            Cinemachine.ICinemachineCamera val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            if((this.m_ChildCameras == null) || (this.m_ChildCameras.Length == 0))
            {
                goto label_2;
            }
            
            if(this.m_RandomizeChoice == false)
            {
                goto label_3;
            }
            
            if(this.m_ChildCameras.Length < 2)
            {
                goto label_4;
            }
            
            val_17 = this.m_RandomizedChilden;
            if(val_17 != null)
            {
                goto label_6;
            }
            
            val_17 = this.Randomize(src:  this.m_ChildCameras);
            this.m_RandomizedChilden = val_17;
            goto label_6;
            label_2:
            val_18 = 0;
            this.mActivationTime = 0f;
            return (Cinemachine.ICinemachineCamera)val_18;
            label_3:
            this.m_RandomizedChilden = 0;
            label_4:
            val_17 = this.m_ChildCameras;
            label_6:
            if((this.<LiveChild>k__BackingField) == null)
            {
                goto label_8;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_19 = this.<LiveChild>k__BackingField;
            goto label_12;
            label_8:
            val_20 = 0;
            goto label_16;
            label_12:
            if((this.<LiveChild>k__BackingField.activeSelf) != false)
            {
                    val_20 = this.<LiveChild>k__BackingField;
            }
            else
            {
                    val_20 = 0;
                this.<LiveChild>k__BackingField = 0;
            }
            
            label_16:
            val_21 = 0;
            goto label_17;
            label_61:
            val_21 = 1;
            label_17:
            if(val_21 >= this.m_ChildCameras.Length)
            {
                goto label_19;
            }
            
            Cinemachine.CinemachineVirtualCameraBase val_13 = val_17[1];
            if(((0 == val_13) || (val_13.VirtualCameraGameObject.activeInHierarchy == false)) || (val_20 == 0))
            {
                goto label_61;
            }
            
            var val_17 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_29;
            }
            
            var val_14 = mem[282584257676823];
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_31:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_30;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < mem[282584257676929])
            {
                goto label_31;
            }
            
            label_29:
            val_22 = val_20;
            goto label_32;
            label_30:
            var val_16 = val_14;
            val_16 = val_16 + 8;
            val_17 = val_17 + val_16;
            val_22 = val_17 + 272;
            label_32:
            if(val_7 > val_8)
            {
                goto label_61;
            }
            
            var val_21 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_35;
            }
            
            var val_18 = mem[282584257676823];
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_37:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_36;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < mem[282584257676929])
            {
                goto label_37;
            }
            
            label_35:
            val_23 = val_20;
            goto label_38;
            label_36:
            var val_20 = val_18;
            val_20 = val_20 + 8;
            val_21 = val_21 + val_20;
            val_23 = val_21 + 272;
            label_38:
            if(val_7 != val_8)
            {
                goto label_39;
            }
            
            var val_25 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_41;
            }
            
            var val_22 = mem[282584257676823];
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_43:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_42;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < mem[282584257676929])
            {
                goto label_43;
            }
            
            label_41:
            val_24 = val_20;
            goto label_44;
            label_42:
            var val_24 = val_22;
            val_24 = val_24 + 2;
            val_25 = val_25 + val_24;
            val_24 = val_25 + 272;
            label_44:
            if(val_13.Priority > val_20)
            {
                goto label_61;
            }
            
            label_39:
            if(((this.m_RandomizeChoice == false) || (this.mRandomizeNow == false)) || (val_13 == (this.<LiveChild>k__BackingField)))
            {
                goto label_61;
            }
            
            var val_29 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_50;
            }
            
            var val_26 = mem[282584257676823];
            var val_27 = 0;
            val_26 = val_26 + 8;
            label_52:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_51;
            }
            
            val_27 = val_27 + 1;
            val_26 = val_26 + 16;
            if(val_27 < mem[282584257676929])
            {
                goto label_52;
            }
            
            label_50:
            val_25 = val_20;
            goto label_53;
            label_51:
            var val_28 = val_26;
            val_28 = val_28 + 8;
            val_29 = val_29 + val_28;
            val_25 = val_29 + 272;
            label_53:
            if(val_7 != val_8)
            {
                goto label_61;
            }
            
            var val_33 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_56;
            }
            
            var val_30 = mem[282584257676823];
            var val_31 = 0;
            val_30 = val_30 + 8;
            label_58:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_57;
            }
            
            val_31 = val_31 + 1;
            val_30 = val_30 + 16;
            if(val_31 < mem[282584257676929])
            {
                goto label_58;
            }
            
            label_56:
            val_26 = val_20;
            goto label_59;
            label_57:
            var val_32 = val_30;
            val_32 = val_32 + 2;
            val_33 = val_33 + val_32;
            val_26 = val_33 + 272;
            label_59:
            if(val_13.Priority != val_20)
            {
                goto label_61;
            }
            
            goto label_61;
            label_19:
            this.mRandomizeNow = false;
            float val_11 = UnityEngine.Time.time;
            float val_34 = this.mActivationTime;
            if(val_34 == 0f)
            {
                goto label_65;
            }
            
            val_18 = this.<LiveChild>k__BackingField;
            if(val_18 == val_20)
            {
                goto label_63;
            }
            
            if(deltaTime >= 0f)
            {
                    float val_35 = this.mPendingActivationTime;
                if(val_35 != 0f)
            {
                    if(this.mPendingCamera == val_20)
            {
                goto label_66;
            }
            
            }
            
            }
            
            label_65:
            this.mPendingActivationTime = 0f;
            this.mPendingCamera = 0;
            if((deltaTime < 0f) || (val_34 <= 0f))
            {
                goto label_70;
            }
            
            if(this.m_ActivateAfter > 0f)
            {
                goto label_69;
            }
            
            val_34 = val_11 - val_34;
            if(val_34 >= 0)
            {
                goto label_70;
            }
            
            label_69:
            val_18 = this.<LiveChild>k__BackingField;
            this.mPendingCamera = val_20;
            this.mPendingActivationTime = val_11;
            return (Cinemachine.ICinemachineCamera)val_18;
            label_70:
            this.m_RandomizedChilden = 0;
            this.mActivationTime = val_11;
            goto label_72;
            label_66:
            val_35 = val_11 - val_35;
            if(val_35 <= this.m_ActivateAfter)
            {
                    return (Cinemachine.ICinemachineCamera)val_18;
            }
            
            val_34 = val_11 - val_34;
            if(val_34 <= this.m_MinDuration)
            {
                    return (Cinemachine.ICinemachineCamera)val_18;
            }
            
            this.m_RandomizedChilden = 0;
            this.mActivationTime = val_11;
            label_63:
            this.mPendingActivationTime = 0f;
            this.mPendingCamera = 0;
            label_72:
            val_18 = val_20;
            return (Cinemachine.ICinemachineCamera)val_18;
        }
        private Cinemachine.CinemachineVirtualCameraBase[] Randomize(Cinemachine.CinemachineVirtualCameraBase[] src)
        {
            var val_6;
            System.Comparison<Pair> val_7;
            var val_8;
            System.Collections.Generic.List<Pair> val_1 = new System.Collections.Generic.List<Pair>();
            val_6 = 0;
            goto label_1;
            label_5:
            Add(item:  new Pair() {a = X21, b = X21});
            val_6 = 1;
            label_1:
            if(val_6 >= src.Length)
            {
                goto label_3;
            }
            
            float val_2 = UnityEngine.Random.Range(min:  0f, max:  1000f);
            if(null != 0)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            val_7 = Cinemachine.CinemachineClearShot.<>f__am$cache0;
            if(val_7 == null)
            {
                    Cinemachine.CinemachineClearShot.<>f__am$cache0 = new System.Comparison<Pair>(object:  0, method:  static System.Int32 Cinemachine.CinemachineClearShot::<Randomize>m__0(Cinemachine.CinemachineClearShot.Pair p1, Cinemachine.CinemachineClearShot.Pair p2));
                val_7 = Cinemachine.CinemachineClearShot.<>f__am$cache0;
            }
            
            Sort(comparison:  val_7);
            val_8 = 0;
            goto label_10;
            label_21:
            var val_5 = null + ((X24) << 3);
            val_8 = 1;
            mem2[0] = src.Length;
            label_10:
            if(val_8 >= src.Length)
            {
                    return (Cinemachine.CinemachineVirtualCameraBase[])null;
            }
            
            Cinemachine.CinemachineVirtualCameraBase val_7 = src[ToArray()[1]];
            if((val_7 == null) || (val_7 != null))
            {
                goto label_21;
            }
            
            goto label_21;
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
            val_8 = 1152921511663482624;
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
        public override void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime)
        {
            this.OnTransitionFromCamera(fromCam:  fromCam, worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  deltaTime);
            if(this.m_RandomizeChoice == false)
            {
                    return;
            }
            
            if(this.mActiveBlend != null)
            {
                    return;
            }
            
            this.<LiveChild>k__BackingField = 0;
            this.m_RandomizedChilden = 0;
            goto typeof(Cinemachine.CinemachineClearShot).__il2cppRuntimeField_2E0;
        }
        private static int <Randomize>m__0(Cinemachine.CinemachineClearShot.Pair p1, Cinemachine.CinemachineClearShot.Pair p2)
        {
            return (int)((int)p2.a >> 32) - ((int)X2 >> 32);
        }
    
    }

}
