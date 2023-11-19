using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.DisallowMultipleComponent]
    [UnityEngine.AddComponentMenu]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineBrain : MonoBehaviour
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public bool m_ShowDebugText;
        [UnityEngine.TooltipAttribute]
        public bool m_ShowCameraFrustum;
        [UnityEngine.TooltipAttribute]
        public bool m_IgnoreTimeScale;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Transform m_WorldUpOverride;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineBrain.UpdateMethod m_UpdateMethod;
        [Cinemachine.CinemachineBlendDefinitionPropertyAttribute]
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineBlendDefinition m_DefaultBlend;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineBlenderSettings m_CustomBlends;
        private UnityEngine.Camera m_OutputCamera;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineBrain.BrainEvent m_CameraCutEvent;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineBrain.VcamEvent m_CameraActivatedEvent;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Component <PostProcessingComponent>k__BackingField;
        internal static Cinemachine.CinemachineBrain.BrainEvent sPostProcessingHandler;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static Cinemachine.ICinemachineCamera <SoloCamera>k__BackingField;
        private Cinemachine.ICinemachineCamera mActiveCameraPreviousFrame;
        private Cinemachine.ICinemachineCamera mOutgoingCameraPreviousFrame;
        private Cinemachine.CinemachineBlend mActiveBlend;
        private bool mPreviousFrameWasOverride;
        private System.Collections.Generic.List<Cinemachine.CinemachineBrain.OverrideStackFrame> mOverrideStack;
        private int mNextOverrideId;
        private Cinemachine.CinemachineBrain.OverrideStackFrame mOverrideBlendFromNothing;
        private UnityEngine.WaitForFixedUpdate mWaitForFixedUpdate;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.CameraState <CurrentCameraState>k__BackingField;
        private static int msCurrentFrame;
        private static int msFirstBrainObjectId;
        private static int msSubframes;
        
        // Properties
        public UnityEngine.Camera OutputCamera { get; }
        internal UnityEngine.Component PostProcessingComponent { get; set; }
        public static Cinemachine.ICinemachineCamera SoloCamera { get; set; }
        public UnityEngine.Vector3 DefaultWorldUp { get; }
        public bool IsBlending { get; }
        public Cinemachine.CinemachineBlend ActiveBlend { get; }
        public Cinemachine.ICinemachineCamera ActiveVirtualCamera { get; }
        public Cinemachine.CameraState CurrentCameraState { get; set; }
        
        // Methods
        public CinemachineBrain()
        {
            this.m_UpdateMethod = 3;
            mem[1152921511648099168] = 1073741824;
            this.m_ShowCameraFrustum = true;
            this.m_CameraCutEvent = new CinemachineBrain.BrainEvent();
            this.m_CameraActivatedEvent = new CinemachineBrain.VcamEvent();
            this.mNextOverrideId = true;
            this.mOverrideStack = new System.Collections.Generic.List<OverrideStackFrame>();
            this.mOverrideBlendFromNothing = new System.Object();
            this.mWaitForFixedUpdate = new UnityEngine.WaitForFixedUpdate();
        }
        public UnityEngine.Camera get_OutputCamera()
        {
            UnityEngine.Camera val_4;
            if(0 == this.m_OutputCamera)
            {
                    this.m_OutputCamera = this.GetComponent<UnityEngine.Camera>();
                return val_4;
            }
            
            val_4 = this.m_OutputCamera;
            return val_4;
        }
        internal UnityEngine.Component get_PostProcessingComponent()
        {
            return (UnityEngine.Component)this.<PostProcessingComponent>k__BackingField;
        }
        internal void set_PostProcessingComponent(UnityEngine.Component value)
        {
            this.<PostProcessingComponent>k__BackingField = value;
        }
        public static Cinemachine.ICinemachineCamera get_SoloCamera()
        {
            null = null;
            return (Cinemachine.ICinemachineCamera)Cinemachine.CinemachineBrain.<SoloCamera>k__BackingField;
        }
        public static void set_SoloCamera(Cinemachine.ICinemachineCamera value)
        {
            null = null;
            Cinemachine.CinemachineBrain.<SoloCamera>k__BackingField = X1;
        }
        public static UnityEngine.Color GetSoloGUIColor()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.red;
            UnityEngine.Color val_2 = UnityEngine.Color.yellow;
            UnityEngine.Color val_3 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a}, b:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, t:  0.8f);
            return new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        }
        public UnityEngine.Vector3 get_DefaultWorldUp()
        {
            if(0 == this.m_WorldUpOverride)
            {
                    return UnityEngine.Vector3.up;
            }
            
            UnityEngine.Transform val_2 = this.m_WorldUpOverride.transform;
            if(val_2 != null)
            {
                    return val_2.up;
            }
            
            return val_2.up;
        }
        private Cinemachine.CinemachineBrain.OverrideStackFrame GetOverrideFrame(int id)
        {
            int val_1 = this.mOverrideStack.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            label_6:
            OverrideStackFrame val_2 = this.mOverrideStack.Item[0];
            if(val_2.id == id)
            {
                goto label_5;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < val_1)
            {
                goto label_6;
            }
            
            label_2:
            object val_3 = new System.Object();
            typeof(CinemachineBrain.OverrideStackFrame).__il2cppRuntimeField_10 = id;
            this.mOverrideStack.Insert(index:  0, item:  val_3);
            return (OverrideStackFrame)val_3;
            label_5:
            if(this.mOverrideStack != null)
            {
                    return this.mOverrideStack.Item[0];
            }
            
            return this.mOverrideStack.Item[0];
        }
        private Cinemachine.CinemachineBrain.OverrideStackFrame GetNextActiveFrame(int overrideId)
        {
            System.Collections.Generic.List<OverrideStackFrame> val_6;
            var val_7;
            Cinemachine.CinemachineBlend val_8;
            var val_9;
            OverrideStackFrame val_10;
            val_6 = this;
            int val_1 = this.mOverrideStack.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_7 = 0;
            val_8 = 0;
            label_11:
            val_9 = this.mOverrideStack.Item[0];
            if(val_2.id != overrideId)
            {
                goto label_5;
            }
            
            val_7 = 1;
            goto label_9;
            label_5:
            val_9 = this.mOverrideStack.Item[0];
            if(val_3.camera == null)
            {
                goto label_9;
            }
            
            var val_4 = val_7 ^ 1;
            val_4 = val_4 & 1;
            if((val_4 & 1) == 0)
            {
                goto label_10;
            }
            
            label_9:
            val_8 = val_8 + 1;
            if(val_8 < val_1)
            {
                goto label_11;
            }
            
            label_2:
            this.mOverrideBlendFromNothing.camera = this.TopCameraFromPriorityQueue();
            val_8 = this.mActiveBlend;
            this.mOverrideBlendFromNothing.blend = val_8;
            val_10 = this.mOverrideBlendFromNothing;
            return (OverrideStackFrame)val_6.Item[0];
            label_10:
            val_6 = this.mOverrideStack;
            return (OverrideStackFrame)val_6.Item[0];
        }
        private Cinemachine.CinemachineBrain.OverrideStackFrame GetActiveOverride()
        {
            System.Collections.Generic.List<OverrideStackFrame> val_4;
            var val_5;
            val_4 = this;
            int val_1 = this.mOverrideStack.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            label_6:
            OverrideStackFrame val_2 = this.mOverrideStack.Item[0];
            if(val_2.camera != null)
            {
                goto label_5;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < val_1)
            {
                goto label_6;
            }
            
            label_2:
            val_5 = 0;
            return (OverrideStackFrame)val_4.Item[0];
            label_5:
            val_4 = this.mOverrideStack;
            return (OverrideStackFrame)val_4.Item[0];
        }
        internal int SetCameraOverride(int overrideId, Cinemachine.ICinemachineCamera camA, Cinemachine.ICinemachineCamera camB, float weightB, float deltaTime)
        {
            float val_11;
            Cinemachine.ICinemachineCamera val_12;
            Cinemachine.ICinemachineCamera val_13;
            int val_14;
            Cinemachine.CinemachineBlend val_15;
            Cinemachine.CinemachineBlend val_16;
            var val_17;
            float val_19;
            Cinemachine.CinemachineBlend val_20;
            val_11 = weightB;
            val_12 = camB;
            val_13 = camA;
            val_14 = overrideId;
            val_15 = this;
            if((val_14 & 2147483648) != 0)
            {
                    val_14 = this.mNextOverrideId;
                this.mNextOverrideId = val_14 + 1;
            }
            
            val_16 = this.GetOverrideFrame(id:  val_14);
            if(val_16 != null)
            {
                    val_17 = val_16;
                val_2.camera = 0;
                mem2[0] = deltaTime;
                val_19 = UnityEngine.Time.realtimeSinceStartup;
            }
            else
            {
                    val_17 = 24;
                mem[24] = 0;
                mem[40] = deltaTime;
                val_19 = UnityEngine.Time.realtimeSinceStartup;
            }
            
            val_2.timeOfOverride = val_19;
            if(val_12 == null)
            {
                    if((((val_13 == 0) ? 1 : 0) & 1) != 0)
            {
                    return val_14;
            }
            
            }
            
            if(val_11 <= 0.0001f)
            {
                goto label_6;
            }
            
            if(val_11 >= 0.9999f)
            {
                goto label_7;
            }
            
            if(val_12 == null)
            {
                goto label_8;
            }
            
            if(val_13 != null)
            {
                goto label_19;
            }
            
            goto label_10;
            label_6:
            val_2.blend = 0;
            if(val_13 == null)
            {
                    return val_14;
            }
            
            mem[24] = val_13;
            return val_14;
            label_7:
            val_2.blend = 0;
            if(val_12 != null)
            {
                goto label_13;
            }
            
            return val_14;
            label_8:
            val_11 = 1f - val_11;
            val_12 = val_13;
            label_10:
            if((this.GetNextActiveFrame(overrideId:  val_14)) == null)
            {
                goto label_15;
            }
            
            val_20 = val_6.blend;
            if(val_20 != null)
            {
                goto label_16;
            }
            
            goto label_18;
            label_15:
            if(64 == 0)
            {
                goto label_18;
            }
            
            val_20 = 64;
            label_16:
            Cinemachine.BlendSourceVirtualCamera val_7 = null;
            val_13 = val_7;
            val_7 = new Cinemachine.BlendSourceVirtualCamera(blend:  val_20, deltaTime:  deltaTime);
            goto label_19;
            label_18:
            Cinemachine.ICinemachineCamera val_8 = (val_6.camera == 0) ? (val_12) : val_6.camera;
            label_19:
            val_15 = val_2.blend;
            if(val_15 != null)
            {
                goto label_20;
            }
            
            Cinemachine.CinemachineBlend val_10 = null;
            val_15 = val_10;
            val_10 = new Cinemachine.CinemachineBlend(a:  val_8, b:  val_12, curve:  UnityEngine.AnimationCurve.Linear(timeStart:  0f, valueStart:  0f, timeEnd:  1f, valueEnd:  1f), duration:  1f, t:  val_11);
            val_2.blend = val_15;
            if(null == 0)
            {
                goto label_21;
            }
            
            label_20:
            typeof(Cinemachine.CinemachineBlend).__il2cppRuntimeField_10 = val_8;
            val_2.blend.<CamB>k__BackingField = val_12;
            val_16 = val_2.blend;
            val_2.blend.<TimeInBlend>k__BackingField = val_11;
            label_13:
            mem[24] = val_12;
            return val_14;
            label_21:
        }
        internal void ReleaseCameraOverride(int overrideId)
        {
            System.Collections.Generic.List<OverrideStackFrame> val_3 = this.mOverrideStack;
            int val_1 = val_3.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            label_6:
            OverrideStackFrame val_2 = this.mOverrideStack.Item[0];
            if(val_2.id == overrideId)
            {
                goto label_5;
            }
            
            val_3 = 0 + 1;
            if(val_3 < val_1)
            {
                goto label_6;
            }
            
            return;
            label_5:
            this.mOverrideStack.RemoveAt(index:  0);
        }
        private void OnEnable()
        {
            this.mPreviousFrameWasOverride = false;
            this.mOutgoingCameraPreviousFrame = 0;
            this.mActiveBlend = 0;
            this.mActiveCameraPreviousFrame = 0;
            Cinemachine.CinemachineCore.Instance.AddActiveBrain(brain:  this);
        }
        private void OnDisable()
        {
            Cinemachine.CinemachineCore.Instance.RemoveActiveBrain(brain:  this);
            this.mPreviousFrameWasOverride = false;
            this.mOutgoingCameraPreviousFrame = 0;
            this.mActiveBlend = 0;
            this.mActiveCameraPreviousFrame = 0;
            this.mOverrideStack.Clear();
        }
        private void Start()
        {
            this.UpdateVirtualCameras(updateFilter:  2, deltaTime:  -1f);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AfterPhysics());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator AfterPhysics()
        {
            typeof(CinemachineBrain.<AfterPhysics>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void LateUpdate()
        {
            UpdateFilter val_3;
            if(this.m_UpdateMethod == 1)
            {
                goto label_0;
            }
            
            if(this.m_UpdateMethod != 2)
            {
                goto label_1;
            }
            
            val_3 = 2;
            goto label_2;
            label_0:
            val_3 = 3;
            label_2:
            this.UpdateVirtualCameras(updateFilter:  val_3, deltaTime:  this.GetEffectiveDeltaTime(fixedDelta:  false));
            label_1:
            this.ProcessActiveCamera(deltaTime:  this.GetEffectiveDeltaTime(fixedDelta:  false));
        }
        private float GetEffectiveDeltaTime(bool fixedDelta)
        {
            var val_8;
            if(Cinemachine.CinemachineBrain.SoloCamera != null)
            {
                    return UnityEngine.Time.unscaledDeltaTime;
            }
            
            val_8 = this.GetActiveOverride();
            if(val_8 != null)
            {
                    if(val_8.Expired == true)
            {
                    return -1f;
            }
            
                return -1f;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return -1f;
            }
            
            if(this.m_IgnoreTimeScale != false)
            {
                    if(fixedDelta == false)
            {
                    return UnityEngine.Time.unscaledDeltaTime;
            }
            
                return UnityEngine.Time.fixedDeltaTime;
            }
            
            if(fixedDelta == false)
            {
                    return UnityEngine.Time.deltaTime;
            }
            
            float val_7 = UnityEngine.Time.timeScale;
            val_7 = UnityEngine.Time.fixedDeltaTime * val_7;
            return -1f;
        }
        private void UpdateVirtualCameras(Cinemachine.CinemachineCore.UpdateFilter updateFilter, float deltaTime)
        {
            var val_11;
            float val_12;
            val_11 = Cinemachine.CinemachineCore.Instance;
            val_1.<CurrentUpdateFilter>k__BackingField = updateFilter;
            UnityEngine.Vector3 val_3 = this.DefaultWorldUp;
            val_12 = val_3.y;
            Cinemachine.CinemachineCore.Instance.UpdateAllActiveVirtualCameras(worldUp:  new UnityEngine.Vector3() {x = val_3.x, y = val_12, z = val_3.z}, deltaTime:  deltaTime);
            Cinemachine.ICinemachineCamera val_4 = this.ActiveVirtualCamera;
            if(val_4 != null)
            {
                    val_11 = Cinemachine.CinemachineCore.Instance;
                UnityEngine.Vector3 val_6 = this.DefaultWorldUp;
                val_12 = val_6.y;
                bool val_7 = val_11.UpdateVirtualCamera(vcam:  val_4, worldUp:  new UnityEngine.Vector3() {x = val_6.x, y = val_12, z = val_6.z}, deltaTime:  deltaTime);
            }
            
            Cinemachine.CinemachineBlend val_8 = this.ActiveBlend;
            if(val_8 != null)
            {
                    UnityEngine.Vector3 val_9 = this.DefaultWorldUp;
                val_8.UpdateCameraState(worldUp:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, deltaTime:  deltaTime);
            }
            
            Cinemachine.CinemachineCore val_10 = Cinemachine.CinemachineCore.Instance;
            val_10.<CurrentUpdateFilter>k__BackingField = 2;
        }
        private void ProcessActiveCamera(float deltaTime)
        {
            float val_26;
            Cinemachine.ICinemachineCamera val_27;
            Cinemachine.ICinemachineCamera val_28;
            Cinemachine.ICinemachineCamera val_29;
            Cinemachine.ICinemachineCamera val_30;
            var val_31;
            var val_32;
            Cinemachine.ICinemachineCamera val_33;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            Cinemachine.CinemachineBlend val_40;
            var val_41;
            Cinemachine.ICinemachineCamera val_42;
            val_26 = deltaTime;
            val_27 = 208;
            if(this.isActiveAndEnabled == false)
            {
                goto label_1;
            }
            
            OverrideStackFrame val_3 = this.GetActiveOverride();
            val_28 = this.ActiveVirtualCamera;
            if(val_28 == null)
            {
                goto label_2;
            }
            
            if(val_3 != null)
            {
                    this.mActiveBlend = 0;
            }
            
            val_29 = this;
            val_30 = this.mActiveCameraPreviousFrame;
            val_31 = this.ActiveBlend;
            if(val_30 == null)
            {
                goto label_4;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_32 = val_30;
            goto label_8;
            label_1:
            this.mPreviousFrameWasOverride = false;
            this.mActiveCameraPreviousFrame = 0;
            this.mOutgoingCameraPreviousFrame = 0;
            return;
            label_2:
            this.mOutgoingCameraPreviousFrame = 0;
            val_29 = this.mActiveCameraPreviousFrame;
            goto label_55;
            label_4:
            val_33 = 0;
            goto label_15;
            label_8:
            val_30 = val_30;
            val_27 = 0;
            if(0 == val_30)
            {
                    val_33 = 0;
                this.mActiveCameraPreviousFrame = 0;
            }
            else
            {
                    val_33 = this.mActiveCameraPreviousFrame;
            }
            
            label_15:
            if(val_33 == val_28)
            {
                goto label_44;
            }
            
            if((((val_33 != null) && (val_26 >= 0f)) && (val_3 == null)) && (this.mPreviousFrameWasOverride != true))
            {
                    val_27 = val_28;
                val_31 = this.CreateBlend(camA:  this.mActiveCameraPreviousFrame, camB:  val_27, blendCurve:  this.LookupBlendCurve(fromKey:  val_33, toKey:  val_28, duration: out  float val_8 = -2.392987E-17f), duration:  0f, activeBlend:  this.mActiveBlend);
            }
            
            if(val_28 == this.mOutgoingCameraPreviousFrame)
            {
                goto label_38;
            }
            
            UnityEngine.Vector3 val_11 = this.DefaultWorldUp;
            val_35 = val_11.y;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_27 = 14;
            val_36 = val_28;
            val_37 = val_35;
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_38 = val_28;
            val_30 = val_28;
            if(val_30.activeInHierarchy != true)
            {
                    if(val_31 != null)
            {
                    if((val_31.Uses(cam:  val_28)) == true)
            {
                goto label_33;
            }
            
            }
            
                UnityEngine.Vector3 val_18 = this.DefaultWorldUp;
                val_35 = val_18.y;
                var val_29 = 0;
                val_29 = val_29 + 1;
                val_39 = val_28;
                val_37 = val_35;
            }
            
            label_33:
            if(this.m_CameraActivatedEvent != null)
            {
                    this.m_CameraActivatedEvent.Invoke(arg0:  val_28);
            }
            
            label_38:
            if(val_31 != null)
            {
                    if(((((val_10.<CamA>k__BackingField) == this.mActiveCameraPreviousFrame) || ((val_10.<CamB>k__BackingField) == this.mActiveCameraPreviousFrame)) || ((val_10.<CamA>k__BackingField) == this.mOutgoingCameraPreviousFrame)) || ((val_10.<CamB>k__BackingField) == this.mOutgoingCameraPreviousFrame))
            {
                goto label_43;
            }
            
            }
            
            if(this.m_CameraCutEvent != null)
            {
                    this.m_CameraCutEvent.Invoke(arg0:  this);
            }
            
            label_44:
            if(val_31 != null)
            {
                    label_43:
                if(val_3 == null)
            {
                    float val_30 = val_10.<TimeInBlend>k__BackingField;
                if(val_26 < 0f)
            {
                    val_26 = val_10.<Duration>k__BackingField;
            }
            
                val_30 = val_30 + val_26;
                val_10.<TimeInBlend>k__BackingField = val_30;
            }
            
                var val_20 = ((val_10.<TimeInBlend>k__BackingField) >= (val_10.<Duration>k__BackingField)) ? 0 : (val_31);
            }
            else
            {
                    val_40 = 0;
            }
            
            if(val_3 == null)
            {
                    this.mActiveBlend = val_40;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_41 = val_28;
            if(val_40 != 0)
            {
                    Cinemachine.CameraState val_22 = val_40.State;
                this.PushStateToUnityCamera(state:  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {<Orthographic>k__BackingField = false}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3(), <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3(), <RawPosition>k__BackingField = new UnityEngine.Vector3(), <RawOrientation>k__BackingField = new UnityEngine.Quaternion(), <PositionDampingBypass>k__BackingField = new UnityEngine.Vector3(), <PositionCorrection>k__BackingField = new UnityEngine.Vector3(), <OrientationCorrection>k__BackingField = new UnityEngine.Quaternion(), mCustom0 = new CustomBlendable(), mCustom1 = new CustomBlendable(), mCustom2 = new CustomBlendable(), mCustom3 = new CustomBlendable()}, vcam:  208);
                this.mOutgoingCameraPreviousFrame = 0;
                this.mOutgoingCameraPreviousFrame = 7254272;
            }
            else
            {
                    this.PushStateToUnityCamera(state:  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {<Orthographic>k__BackingField = false}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3(), <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3(), <RawPosition>k__BackingField = new UnityEngine.Vector3(), <RawOrientation>k__BackingField = new UnityEngine.Quaternion(), <PositionDampingBypass>k__BackingField = new UnityEngine.Vector3(), <PositionCorrection>k__BackingField = new UnityEngine.Vector3(), <OrientationCorrection>k__BackingField = new UnityEngine.Quaternion(), mCustom0 = new CustomBlendable(), mCustom1 = new CustomBlendable(), mCustom2 = new CustomBlendable(), mCustom3 = new CustomBlendable()}, vcam:  208);
                this.mOutgoingCameraPreviousFrame = 0;
            }
            
            label_55:
            this.mActiveCameraPreviousFrame = val_28;
            this.mPreviousFrameWasOverride = (val_3 != 0) ? 1 : 0;
            if(val_3 == null)
            {
                    return;
            }
            
            if(val_3.blend == null)
            {
                    return;
            }
            
            if((val_3.blend.<BlendCurve>k__BackingField) != null)
            {
                    var val_25 = ((val_3.blend.<BlendCurve>k__BackingField.Evaluate(time:  val_3.blend.<TimeInBlend>k__BackingField)) < 0) ? 1 : 0;
            }
            else
            {
                    val_28 = 1;
            }
            
            if(val_28 != 0)
            {
                    this.mActiveCameraPreviousFrame = val_3.blend.<CamA>k__BackingField;
                val_42 = val_3.blend.<CamB>k__BackingField;
            }
            else
            {
                    this.mActiveCameraPreviousFrame = val_3.blend.<CamB>k__BackingField;
                val_42 = val_3.blend.<CamA>k__BackingField;
            }
            
            this.mOutgoingCameraPreviousFrame = val_42;
        }
        public bool get_IsBlending()
        {
            var val_4;
            var val_5;
            val_4 = this;
            if(this.ActiveBlend != null)
            {
                    val_4 = this.ActiveBlend;
                if((val_2.<CamA>k__BackingField) == null)
            {
                    return (bool)((val_2.<CamB>k__BackingField) != 0) ? 1 : 0;
            }
            
                val_5 = 1;
                return (bool)((val_2.<CamB>k__BackingField) != 0) ? 1 : 0;
            }
            
            val_5 = 0;
            return (bool)((val_2.<CamB>k__BackingField) != 0) ? 1 : 0;
        }
        public Cinemachine.CinemachineBlend get_ActiveBlend()
        {
            Cinemachine.CinemachineBlend val_3;
            if(Cinemachine.CinemachineBrain.SoloCamera != null)
            {
                    val_3 = 0;
                return val_3;
            }
            
            if(this.GetActiveOverride() != null)
            {
                    val_3 = val_2.blend;
                if(val_3 != null)
            {
                    return val_3;
            }
            
            }
            
            val_3 = this.mActiveBlend;
            return val_3;
        }
        public bool IsLive(Cinemachine.ICinemachineCamera vcam)
        {
            Cinemachine.ICinemachineCamera val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            if((this.IsLiveItself(vcam:  vcam)) == true)
            {
                goto label_13;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_10 = 11;
            val_11 = vcam;
            val_9 = vcam;
            if(val_9 == null)
            {
                goto label_12;
            }
            
            label_18:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = 12;
            val_12 = val_9;
            if(((val_9 & 1) & 1) == 0)
            {
                goto label_12;
            }
            
            if((this.IsLiveItself(vcam:  val_9)) == true)
            {
                goto label_13;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_13 = val_9;
            val_9 = val_9;
            if(val_9 != null)
            {
                goto label_18;
            }
            
            label_12:
            val_14 = 0;
            return (bool)val_14;
            label_13:
            val_14 = 1;
            return (bool)val_14;
        }
        private bool IsLiveItself(Cinemachine.ICinemachineCamera vcam)
        {
            var val_6;
            if((this.mActiveCameraPreviousFrame != vcam) && (this.ActiveVirtualCamera != vcam))
            {
                    if((this.IsBlending == false) || ((this.ActiveBlend.Uses(cam:  vcam)) == false))
            {
                goto label_4;
            }
            
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_4:
            val_6 = 0;
            return (bool)val_6;
        }
        public Cinemachine.ICinemachineCamera get_ActiveVirtualCamera()
        {
            if(Cinemachine.CinemachineBrain.SoloCamera != null)
            {
                    return Cinemachine.CinemachineBrain.SoloCamera;
            }
            
            if(this.GetActiveOverride() == null)
            {
                    return this.TopCameraFromPriorityQueue();
            }
            
            if(val_2.camera == null)
            {
                    return this.TopCameraFromPriorityQueue();
            }
            
            return (Cinemachine.ICinemachineCamera)val_2.camera;
        }
        public Cinemachine.CameraState get_CurrentCameraState()
        {
        
        }
        private void set_CurrentCameraState(Cinemachine.CameraState value)
        {
        
        }
        private Cinemachine.ICinemachineCamera TopCameraFromPriorityQueue()
        {
            var val_13;
            var val_14;
            UnityEngine.Object val_15;
            var val_16;
            UnityEngine.Object val_17;
            UnityEngine.Camera val_1 = this.OutputCamera;
            if(0 == val_1)
            {
                    val_13 = 0;
            }
            else
            {
                    val_13 = val_1.cullingMask;
            }
            
            int val_6 = Cinemachine.CinemachineCore.Instance.VirtualCameraCount;
            if(val_6 < 1)
            {
                goto label_9;
            }
            
            val_14 = 0;
            label_24:
            val_15 = Cinemachine.CinemachineCore.Instance.GetVirtualCamera(index:  0);
            if(val_15 == null)
            {
                goto label_13;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_16 = val_15;
            goto label_17;
            label_13:
            val_17 = 0;
            goto label_18;
            label_17:
            val_17 = val_15;
            label_18:
            if(0 != val_17)
            {
                    int val_12 = val_17.layer & 31;
                val_12 = 1 << val_12;
                val_12 = val_12 & val_13;
                if(val_12 != 0)
            {
                    return (Cinemachine.ICinemachineCamera)val_15;
            }
            
            }
            
            val_14 = val_14 + 1;
            if(val_14 < val_6)
            {
                goto label_24;
            }
            
            label_9:
            val_15 = 0;
            return (Cinemachine.ICinemachineCamera)val_15;
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
            val_8 = 1152921511652472432;
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
        private Cinemachine.CinemachineBlend CreateBlend(Cinemachine.ICinemachineCamera camA, Cinemachine.ICinemachineCamera camB, UnityEngine.AnimationCurve blendCurve, float duration, Cinemachine.CinemachineBlend activeBlend)
        {
            float val_2;
            float val_4;
            float val_5;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            float val_20;
            string val_24;
            Cinemachine.StaticPointVirtualCamera val_25;
            var val_26;
            float val_28;
            float val_29;
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            val_24 = activeBlend;
            val_25 = camA;
            val_26 = 0;
            if(blendCurve == null)
            {
                    return (Cinemachine.CinemachineBlend)val_26;
            }
            
            if(duration <= 0f)
            {
                    return (Cinemachine.CinemachineBlend)val_26;
            }
            
            if(val_25 == null)
            {
                goto label_3;
            }
            
            if(val_24 != null)
            {
                goto label_4;
            }
            
            goto label_5;
            label_3:
            if(camB == null)
            {
                    return (Cinemachine.CinemachineBlend)val_26;
            }
            
            label_4:
            Cinemachine.CameraState val_1 = Cinemachine.CameraState.Default;
            if(val_24 != null)
            {
                    Cinemachine.CameraState val_6 = val_24.State;
                val_28 = val_7;
                val_29 = val_8;
                val_30 = val_9;
                val_31 = val_10;
                val_32 = val_11;
                val_33 = val_12;
                val_34 = val_13;
            }
            else
            {
                    UnityEngine.Vector3 val_15 = this.transform.position;
                val_28 = val_15.x;
                val_29 = val_15.y;
                val_30 = val_15.z;
                UnityEngine.Quaternion val_17 = this.transform.rotation;
                val_31 = val_17.x;
                val_32 = val_17.y;
                val_33 = val_17.z;
                val_34 = val_17.w;
                UnityEngine.Camera val_18 = this.OutputCamera;
                Cinemachine.LensSettings val_19 = Cinemachine.LensSettings.FromCamera(fromCamera:  0);
            }
            
            if(val_24 != null)
            {
                    val_24 = "Mid-blend";
            }
            else
            {
                    val_24 = "(none)";
            }
            
            val_25 = null;
            val_25 = new Cinemachine.StaticPointVirtualCamera(state:  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {FieldOfView = val_5, OrthographicSize = val_5, NearClipPlane = val_5, FarClipPlane = val_5, Dutch = val_20, <Orthographic>k__BackingField = val_20, <Aspect>k__BackingField = val_20}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3() {x = val_20, y = val_4, z = val_4}, <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_2}, <RawPosition>k__BackingField = new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30}, <RawOrientation>k__BackingField = new UnityEngine.Quaternion() {x = val_31, y = val_32, z = val_33, w = val_34}, <PositionDampingBypass>k__BackingField = new UnityEngine.Vector3(), <PositionCorrection>k__BackingField = new UnityEngine.Vector3(), <OrientationCorrection>k__BackingField = new UnityEngine.Quaternion(), mCustom0 = new CustomBlendable(), mCustom1 = new CustomBlendable(), mCustom2 = new CustomBlendable(), mCustom3 = new CustomBlendable()}, name:  val_24);
            label_5:
            Cinemachine.CinemachineBlend val_22 = null;
            val_26 = val_22;
            val_22 = new Cinemachine.CinemachineBlend(a:  val_25, b:  camB, curve:  blendCurve, duration:  duration, t:  0f);
            return (Cinemachine.CinemachineBlend)val_26;
        }
        private void PushStateToUnityCamera(Cinemachine.CameraState state, Cinemachine.ICinemachineCamera vcam)
        {
            float val_5;
            var val_6;
            BrainEvent val_7;
            this.transform.position = new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B};
            val_5 = V0.16B;
            this.transform.rotation = new UnityEngine.Quaternion() {x = val_5, y = V1.16B, z = V2.16B, w = V3.16B};
            UnityEngine.Camera val_3 = this.OutputCamera;
            if(0 != val_3)
            {
                    if(val_3 != null)
            {
                    val_3.fieldOfView = state.<Lens>k__BackingField.FieldOfView;
                val_3.orthographicSize = state.<Lens>k__BackingField.OrthographicSize;
                val_3.nearClipPlane = state.<Lens>k__BackingField.NearClipPlane;
                val_5 = state.<Lens>k__BackingField.FarClipPlane;
            }
            else
            {
                    val_3.fieldOfView = state.<Lens>k__BackingField.FieldOfView;
                val_3.orthographicSize = state.<Lens>k__BackingField.OrthographicSize;
                val_3.nearClipPlane = state.<Lens>k__BackingField.NearClipPlane;
                val_5 = state.<Lens>k__BackingField.FarClipPlane;
            }
            
                val_3.farClipPlane = val_5;
            }
            
            val_6 = null;
            val_6 = null;
            val_7 = Cinemachine.CinemachineBrain.sPostProcessingHandler;
            if(val_7 == null)
            {
                    return;
            }
            
            val_7 = Cinemachine.CinemachineBrain.sPostProcessingHandler;
            if(val_7 == null)
            {
                    val_7 = 0;
            }
            
            val_7.Invoke(arg0:  this);
        }
        private void AddSubframe()
        {
            var val_6;
            var val_10;
            int val_12;
            int val_1 = UnityEngine.Time.frameCount;
            val_6 = null;
            val_6 = null;
            if(val_1 == Cinemachine.CinemachineBrain.msCurrentFrame)
            {
                    if(Cinemachine.CinemachineBrain.msFirstBrainObjectId != this.GetInstanceID())
            {
                    return;
            }
            
                val_10 = null;
                val_10 = null;
                val_12 = Cinemachine.CinemachineBrain.msSubframes + 1;
            }
            else
            {
                    Cinemachine.CinemachineBrain.msCurrentFrame = val_1;
                val_12 = 1;
                Cinemachine.CinemachineBrain.msFirstBrainObjectId = this.GetInstanceID();
            }
            
            Cinemachine.CinemachineBrain.msSubframes = val_12;
        }
        internal static int GetSubframeCount()
        {
            null = null;
            return System.Math.Max(val1:  0, val2:  1);
        }
        private static CinemachineBrain()
        {
            Cinemachine.CinemachineBrain.sPostProcessingHandler = new CinemachineBrain.BrainEvent();
        }
    
    }

}
