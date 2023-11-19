using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.DisallowMultipleComponent]
    [UnityEngine.AddComponentMenu]
    public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public UnityEngine.Transform m_LookAt;
        [UnityEngine.TooltipAttribute]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public UnityEngine.Transform m_Follow;
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        [UnityEngine.TooltipAttribute]
        [Cinemachine.LensSettingsPropertyAttribute]
        public Cinemachine.LensSettings m_Lens;
        public const string PipelineName = "cm";
        public static Cinemachine.CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride;
        public static Cinemachine.CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <UserIsDragging>k__BackingField;
        private Cinemachine.CameraState m_State;
        private Cinemachine.CinemachineComponentBase[] m_ComponentPipeline;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private UnityEngine.Transform m_ComponentOwner;
        private static System.Comparison<Cinemachine.CinemachineComponentBase> <>f__am$cache0;
        
        // Properties
        public override Cinemachine.CameraState State { get; }
        public override UnityEngine.Transform LookAt { get; set; }
        public override UnityEngine.Transform Follow { get; set; }
        public bool UserIsDragging { get; set; }
        
        // Methods
        public CinemachineVirtualCamera()
        {
            null = null;
            this.m_Lens = Cinemachine.LensSettings.Default;
            mem[1152921511700496864] = Cinemachine.LensSettings.Default.__il2cppRuntimeField_18;
            mem[1152921511700496856] = Cinemachine.LensSettings.Default.__il2cppRuntimeField_10;
            Cinemachine.CameraState val_1 = Cinemachine.CameraState.Default;
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
        public override void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime)
        {
            float val_9;
            float val_10;
            Cinemachine.CameraState val_11;
            float val_12;
            float val_13;
            float val_14;
            val_9 = worldUp.z;
            val_10 = worldUp.x;
            float val_2 = (this.PreviousStateIsValid != true) ? deltaTime : -1f;
            if(val_2 < 0)
            {
                    Cinemachine.CameraState val_3 = this.PullStateFromVirtualCamera(worldUp:  new UnityEngine.Vector3() {x = val_10, y = worldUp.y, z = val_9});
                val_11 = this.m_State;
            }
            else
            {
                    val_11 = this.m_State;
            }
            
            val_12 = val_10;
            val_13 = worldUp.y;
            val_14 = val_9;
            Cinemachine.CameraState val_4 = this.CalculateNewState(worldUp:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14}, deltaTime:  val_2);
            if((this.<UserIsDragging>k__BackingField) != true)
            {
                    if(0 != this)
            {
                    val_9 = val_12;
                val_10 = val_14;
                val_12 = val_9;
                val_13 = val_13;
                val_14 = val_10;
                this.transform.position = new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14};
            }
            
                if(0 != this)
            {
                    val_9 = val_12;
                val_10 = val_14;
                this.transform.rotation = new UnityEngine.Quaternion() {x = val_9, y = val_13, z = val_10, w = val_2};
            }
            
            }
            
            mem[1152921511701333144] = 1;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.m_ComponentPipeline = 0;
            if(this.ValidatingStreamVersion > 20170926)
            {
                    return;
            }
            
            if(0 != this)
            {
                    if(0 == (this.GetCinemachineComponent(stage:  0)))
            {
                    Cinemachine.CinemachineHardLockToTarget val_5 = this.AddCinemachineComponent<Cinemachine.CinemachineHardLockToTarget>();
            }
            
            }
            
            if(0 == this)
            {
                    return;
            }
            
            if(0 != (this.GetCinemachineComponent(stage:  1)))
            {
                    return;
            }
            
            Cinemachine.CinemachineHardLookAt val_9 = this.AddCinemachineComponent<Cinemachine.CinemachineHardLookAt>();
        }
        protected override void OnDestroy()
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            System.Collections.IEnumerator val_2 = this.transform.GetEnumerator();
            goto label_17;
            label_24:
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_14 = val_2;
            if(0 != (0.GetComponent<Cinemachine.CinemachinePipeline>()))
            {
                    UnityEngine.GameObject val_8 = 0.gameObject;
                val_8.hideFlags = val_8.hideFlags & 4294967292;
            }
            
            label_17:
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_15 = val_2;
            if(((val_2 & 1) & 1) != 0)
            {
                goto label_24;
            }
            
            val_16 = 0;
            val_17 = 102;
            if(val_2 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_18 = val_2;
            }
            
            this.OnDestroy();
        }
        protected override void OnValidate()
        {
            this.OnValidate();
        }
        private void OnTransformChildrenChanged()
        {
            this.m_ComponentPipeline = 0;
        }
        private void Reset()
        {
            this.DestroyPipeline();
        }
        private void DestroyPipeline()
        {
            var val_16;
            var val_17;
            UnityEngine.Transform val_18;
            System.Collections.Generic.List<T> val_20;
            var val_21;
            System.Collections.Generic.List<UnityEngine.Transform> val_1 = new System.Collections.Generic.List<UnityEngine.Transform>();
            System.Collections.IEnumerator val_3 = this.transform.GetEnumerator();
            do
            {
                label_20:
                var val_16 = 0;
                val_16 = val_16 + 1;
                val_16 = val_3;
                if(((val_3 & 1) & 1) == 0)
            {
                goto label_43;
            }
            
                var val_17 = 0;
                val_17 = val_17 + 1;
                val_17 = val_3;
                val_18 = val_3;
                val_18 = 0;
            }
            while(0 == (val_18.GetComponent<Cinemachine.CinemachinePipeline>()));
            
            Add(item:  val_18);
            goto label_20;
            label_43:
            if(val_3 != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_21 = val_3;
            }
            
            if(0 == 95)
            {
                
            }
            else
            {
                    val_20 = 0;
            }
            
            List.Enumerator<T> val_12 = GetEnumerator();
            label_38:
            if((0 & 1) == 0)
            {
                goto label_31;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_13 = 0.InitializationCallback;
            if(Cinemachine.CinemachineVirtualCamera.DestroyPipelineOverride == null)
            {
                goto label_32;
            }
            
            Cinemachine.CinemachineVirtualCamera.DestroyPipelineOverride.Invoke(pipeline:  val_13.gameObject);
            goto label_38;
            label_32:
            UnityEngine.GameObject val_15 = val_13.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            goto label_38;
            label_31:
            0.Dispose();
            this.m_ComponentOwner = 0;
            mem[1152921511702168440] = 0;
        }
        private UnityEngine.Transform CreatePipeline(Cinemachine.CinemachineVirtualCamera copyFrom)
        {
            UnityEngine.Object val_11;
            Cinemachine.CinemachineComponentBase[] val_12;
            Cinemachine.CinemachineComponentBase[] val_13;
            var val_14;
            UnityEngine.Transform val_15;
            val_11 = copyFrom;
            val_12 = 0;
            if(0 != val_11)
            {
                    if(val_11 != null)
            {
                    val_13 = copyFrom.m_ComponentPipeline;
                copyFrom.m_ComponentPipeline = 0;
            }
            else
            {
                    val_13 = 376;
                mem[376] = 0;
            }
            
                val_11.UpdateComponentPipeline();
                val_12 = mem[376];
            }
            
            if(Cinemachine.CinemachineVirtualCamera.CreatePipelineOverride != null)
            {
                    val_14 = Cinemachine.CinemachineVirtualCamera.CreatePipelineOverride.Invoke(vcam:  this, name:  "cm", copyFrom:  val_12);
            }
            else
            {
                    UnityEngine.GameObject val_3 = null;
                val_11 = val_3;
                val_3 = new UnityEngine.GameObject(name:  "cm");
                val_15 = this.transform;
                transform.parent = val_15;
                if(null != 0)
            {
                    Cinemachine.CinemachinePipeline val_6 = AddComponent<Cinemachine.CinemachinePipeline>();
            }
            else
            {
                    Cinemachine.CinemachinePipeline val_7 = AddComponent<Cinemachine.CinemachinePipeline>();
            }
            
                val_14 = transform;
                if((val_12 != 0) && (7254272 >= 1))
            {
                    do
            {
                var val_9 = val_12 + 0;
                val_15 = mem[(val_12 + 0) + 32];
                val_15 = (val_12 + 0) + 32;
                UnityEngine.Component val_11 = AddComponent(componentType:  val_15.GetType());
                Cinemachine.Utility.ReflectionHelpers.CopyFields(src:  val_11, dst:  val_15, bindingAttr:  val_11);
            }
            while((0 + 1) < 7254272);
            
            }
            
            }
            
            mem[1152921511702342984] = 0;
            return (UnityEngine.Transform)val_14;
        }
        public void InvalidateComponentPipeline()
        {
            this.m_ComponentPipeline = 0;
        }
        public UnityEngine.Transform GetComponentOwner()
        {
            this.UpdateComponentPipeline();
            return (UnityEngine.Transform)this.m_ComponentOwner;
        }
        public Cinemachine.CinemachineComponentBase[] GetComponentPipeline()
        {
            this.UpdateComponentPipeline();
            return (Cinemachine.CinemachineComponentBase[])this.m_ComponentPipeline;
        }
        public Cinemachine.CinemachineComponentBase GetCinemachineComponent(Cinemachine.CinemachineCore.Stage stage)
        {
            Cinemachine.CinemachineComponentBase val_1;
            this.UpdateComponentPipeline();
            if(this.m_ComponentPipeline == null)
            {
                goto label_1;
            }
            
            var val_1 = 0;
            label_4:
            if(val_1 >= this.m_ComponentPipeline.Length)
            {
                goto label_1;
            }
            
            val_1 = this.m_ComponentPipeline[0];
            val_1 = val_1 + 1;
            if(val_1 != stage)
            {
                goto label_4;
            }
            
            return (Cinemachine.CinemachineComponentBase)val_1;
            label_1:
            val_1 = 0;
            return (Cinemachine.CinemachineComponentBase)val_1;
        }
        public T GetCinemachineComponent<T>()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = this.GetComponentPipeline();
            if(val_5 == null)
            {
                goto label_1;
            }
            
            val_6 = 0;
            val_7 = __RuntimeMethodHiddenParam + 48;
            label_4:
            if(val_6 >= val_1.Length)
            {
                goto label_2;
            }
            
            Cinemachine.CinemachineComponentBase val_3 = val_5[0];
            val_6 = val_6 + 1;
            if(val_3 == null)
            {
                goto label_4;
            }
            
            val_5 = mem[(__RuntimeMethodHiddenParam + 48)];
            val_5 = val_7;
            if(val_3 == null)
            {
                goto label_7;
            }
            
            val_8 = val_3;
            if(val_8 != null)
            {
                    return (object)val_8;
            }
            
            goto label_7;
            label_1:
            val_7 = __RuntimeMethodHiddenParam + 48;
            label_2:
            label_7:
            val_8 = 0;
            return (object)val_8;
        }
        public T AddCinemachineComponent<T>()
        {
            var val_8;
            var val_9;
            T val_10;
            UnityEngine.Transform val_1 = this.GetComponentOwner();
            if(val_1 != null)
            {
                    val_8 = val_1.GetComponents<Cinemachine.CinemachineComponentBase>();
            }
            else
            {
                    val_8 = val_1.GetComponents<Cinemachine.CinemachineComponentBase>();
            }
            
            UnityEngine.GameObject val_4 = val_1.gameObject;
            if((val_8 != null) && (((UnityEngine.Object.op_Inequality(x:  0, y:  val_4)) ^ 1) != true))
            {
                    int val_8 = val_3.Length;
                val_8 = val_8 - 1;
                if((val_8 & 2147483648) == 0)
            {
                    var val_10 = (long)val_8;
                do
            {
                if(val_10 >= val_3.Length)
            {
                    val_9 = 0;
            }
            
                val_10 = val_8[val_10];
                if(val_10 == val_4)
            {
                    val_8[val_10].enabled = false;
                val_10 = val_8[val_10];
                UnityEngine.Object.DestroyImmediate(obj:  0);
            }
            
                val_10 = val_10 - 1;
            }
            while((val_10 & 2147483648) == 0);
            
            }
            
            }
            
            this.InvalidateComponentPipeline();
            return (object)val_4;
        }
        public void DestroyCinemachineComponent<T>()
        {
            Cinemachine.CinemachineComponentBase[] val_1 = this.GetComponentPipeline();
            if(val_1 == null)
            {
                    return;
            }
            
            if(val_1.Length < 1)
            {
                    return;
            }
            
            do
            {
                Cinemachine.CinemachineComponentBase val_3 = val_1[0];
                if(val_3 != null)
            {
                    val_3.enabled = false;
                UnityEngine.Object.DestroyImmediate(obj:  0);
                this.InvalidateComponentPipeline();
            }
            
            }
            while((0 + 1) < val_1.Length);
        
        }
        public bool get_UserIsDragging()
        {
            return (bool)this.<UserIsDragging>k__BackingField;
        }
        public void set_UserIsDragging(bool value)
        {
            this.<UserIsDragging>k__BackingField = value;
        }
        public void OnPositionDragged(UnityEngine.Vector3 delta)
        {
            this.UpdateComponentPipeline();
            if(this.m_ComponentPipeline == null)
            {
                    return;
            }
            
            if(this.m_ComponentPipeline.Length < 1)
            {
                    return;
            }
            
            do
            {
                this = this.m_ComponentPipeline[0];
            }
            while((0 + 1) < this.m_ComponentPipeline.Length);
        
        }
        private void UpdateComponentPipeline()
        {
            System.Comparison<Cinemachine.CinemachineComponentBase> val_33;
            Cinemachine.CinemachineVirtualCamera val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            UnityEngine.HideFlags val_44;
            if(0 != this.m_ComponentOwner)
            {
                    val_33 = this.transform;
                if(0 != this.m_ComponentOwner.parent)
            {
                    val_34 = 0;
                if(0 != this.m_ComponentOwner.parent)
            {
                    val_34 = this.m_ComponentOwner.parent.gameObject.GetComponent<Cinemachine.CinemachineVirtualCamera>();
            }
            
                this.DestroyPipeline();
                this.m_ComponentOwner = this.CreatePipeline(copyFrom:  val_34);
            }
            
            }
            
            if(0 != this.m_ComponentOwner)
            {
                    if(this.m_ComponentPipeline != null)
            {
                    return;
            }
            
            }
            
            this.m_ComponentOwner = 0;
            System.Collections.Generic.List<Cinemachine.CinemachineComponentBase> val_12 = new System.Collections.Generic.List<Cinemachine.CinemachineComponentBase>();
            System.Collections.IEnumerator val_14 = this.transform.GetEnumerator();
            goto label_35;
            label_45:
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_35 = val_14;
            if(0 == (0.GetComponent<Cinemachine.CinemachinePipeline>()))
            {
                goto label_35;
            }
            
            this.m_ComponentOwner = 0;
            val_36 = 0;
            goto label_33;
            label_38:
            val_36 = 1;
            label_33:
            if(val_36 >= val_20.Length)
            {
                goto label_35;
            }
            
            Add(item:  0.GetComponents<Cinemachine.CinemachineComponentBase>()[1]);
            goto label_38;
            label_35:
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_37 = val_14;
            if(((val_14 & 1) & 1) != 0)
            {
                goto label_45;
            }
            
            val_38 = 0;
            val_39 = 298;
            if(val_14 != null)
            {
                    var val_34 = 0;
                val_34 = val_34 + 1;
                val_40 = val_14;
            }
            
            if(0 == this.m_ComponentOwner)
            {
                    this.m_ComponentOwner = this.CreatePipeline(copyFrom:  0);
            }
            
            val_41 = null;
            val_41 = null;
            val_42 = this.m_ComponentOwner.gameObject;
            if(val_42 != null)
            {
                    val_43 = val_42.hideFlags;
            }
            else
            {
                    val_43 = 0.hideFlags;
                val_42 = 0;
            }
            
            if(Cinemachine.CinemachineCore.sShowHiddenObjects != false)
            {
                    val_44 = val_43 & 4294967292;
            }
            else
            {
                    val_44 = val_43 | 3;
            }
            
            val_42.hideFlags = val_44;
            if((Cinemachine.CinemachineVirtualCamera.<>f__am$cache0) == null)
            {
                    Cinemachine.CinemachineVirtualCamera.<>f__am$cache0 = new System.Comparison<Cinemachine.CinemachineComponentBase>(object:  0, method:  static System.Int32 Cinemachine.CinemachineVirtualCamera::<UpdateComponentPipeline>m__0(Cinemachine.CinemachineComponentBase c1, Cinemachine.CinemachineComponentBase c2));
            }
            
            val_33 = Cinemachine.CinemachineVirtualCamera.<>f__am$cache0;
            if(null != 0)
            {
                    Sort(comparison:  val_33);
            }
            else
            {
                    Sort(comparison:  val_33);
            }
            
            this.m_ComponentPipeline = ToArray();
        }
        private Cinemachine.CameraState CalculateNewState(UnityEngine.Vector3 worldUp, float deltaTime)
        {
            int val_4;
            UnityEngine.Object val_5;
            Cinemachine.CinemachineComponentBase[] val_6;
            var val_7;
            var val_8;
            Stage val_9;
            Stage val_10;
            var val_11;
            Cinemachine.CameraState val_0;
            Cinemachine.CameraState val_1 = this.PullStateFromVirtualCamera(worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z});
            val_4 = null;
            val_5 = this;
            if(0 != this)
            {
                    UnityEngine.Vector3 val_3 = this.position;
                val_5 = 0;
            }
            
            this.UpdateComponentPipeline();
            val_6 = this.m_ComponentPipeline;
            if(val_6 == null)
            {
                goto label_5;
            }
            
            val_7 = 0;
            goto label_6;
            label_12:
            val_6 = this.m_ComponentPipeline;
            val_7 = 1;
            label_6:
            if(val_7 >= this.m_ComponentPipeline.Length)
            {
                goto label_8;
            }
            
            if(this.m_ComponentPipeline[1] != null)
            {
                goto label_12;
            }
            
            goto label_12;
            label_8:
            val_8 = 0;
            val_9 = 0;
            goto label_13;
            label_24:
            val_8 = 1;
            label_13:
            val_4 = this.m_ComponentPipeline.Length;
            if(val_8 >= val_4)
            {
                goto label_15;
            }
            
            if(val_8 >= this.m_ComponentPipeline.Length)
            {
                    val_5 = 0;
            }
            
            Cinemachine.CinemachineComponentBase val_5 = this.m_ComponentPipeline[1];
            if(val_9 < val_5)
            {
                    do
            {
                this.InvokePostPipelineStageCallback(vcam:  this, stage:  val_9, newState: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {<Orthographic>k__BackingField = false}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3(), <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3(), <RawPosition>k__BackingField = new UnityEngine.Vector3(), <RawOrientation>k__BackingField = new UnityEngine.Quaternion(), <PositionDampingBypass>k__BackingField = new UnityEngine.Vector3(), <PositionCorrection>k__BackingField = new UnityEngine.Vector3(), <OrientationCorrection>k__BackingField = new UnityEngine.Quaternion(), mCustom0 = new CustomBlendable(), mCustom1 = new CustomBlendable(), mCustom2 = new CustomBlendable(), mCustom3 = new CustomBlendable()}, deltaTime:  deltaTime);
                val_9 = val_9 + 1;
            }
            while(val_5 != val_9);
            
            }
            
            if(this.m_ComponentPipeline[1] != null)
            {
                goto label_24;
            }
            
            goto label_24;
            label_15:
            if(val_9 > 2)
            {
                    return val_0;
            }
            
            goto label_27;
            label_5:
            val_10 = 0;
            do
            {
                label_27:
                this.InvokePostPipelineStageCallback(vcam:  this, stage:  val_10, newState: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {<Orthographic>k__BackingField = false}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3(), <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3(), <RawPosition>k__BackingField = new UnityEngine.Vector3(), <RawOrientation>k__BackingField = new UnityEngine.Quaternion(), <PositionDampingBypass>k__BackingField = new UnityEngine.Vector3(), <PositionCorrection>k__BackingField = new UnityEngine.Vector3(), <OrientationCorrection>k__BackingField = new UnityEngine.Quaternion(), mCustom0 = new CustomBlendable(), mCustom1 = new CustomBlendable(), mCustom2 = new CustomBlendable(), mCustom3 = new CustomBlendable()}, deltaTime:  deltaTime);
                val_11 = val_10 + 1;
            }
            while(val_11 != 3);
            
            return val_0;
        }
        private Cinemachine.CinemachineCore.Stage AdvancePipelineStage(ref Cinemachine.CameraState state, float deltaTime, Cinemachine.CinemachineCore.Stage curStage, int maxStage)
        {
            Stage val_1 = curStage;
            if(val_1 >= maxStage)
            {
                    return (Stage)val_1;
            }
            
            do
            {
                this.InvokePostPipelineStageCallback(vcam:  this, stage:  val_1 = curStage, newState: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {FieldOfView = state.<Lens>k__BackingField.FieldOfView, OrthographicSize = state.<Lens>k__BackingField.OrthographicSize, NearClipPlane = state.<Lens>k__BackingField.NearClipPlane, FarClipPlane = state.<Lens>k__BackingField.FarClipPlane, Dutch = state.<Lens>k__BackingField.Dutch, <Orthographic>k__BackingField = state.<Lens>k__BackingField.<Orthographic>k__BackingField, <Aspect>k__BackingField = state.<Lens>k__BackingField.<Aspect>k__BackingField}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3() {x = state.<ReferenceUp>k__BackingField.x, y = state.<ReferenceUp>k__BackingField.y, z = state.<ReferenceUp>k__BackingField.z}, <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3() {x = state.<ReferenceLookAt>k__BackingField.x, y = state.<ReferenceLookAt>k__BackingField.y, z = state.<ReferenceLookAt>k__BackingField.z}, <RawPosition>k__BackingField = new UnityEngine.Vector3() {x = state.<RawPosition>k__BackingField.x, y = state.<RawPosition>k__BackingField.y, z = state.<RawPosition>k__BackingField.z}}, deltaTime:  deltaTime);
                val_1 = val_1 + 1;
            }
            while(maxStage != val_1);
            
            val_1 = maxStage;
            return (Stage)val_1;
        }
        private Cinemachine.CameraState PullStateFromVirtualCamera(UnityEngine.Vector3 worldUp)
        {
            float val_15;
            UnityEngine.Object val_16;
            var val_17;
            Cinemachine.CameraState val_0;
            Cinemachine.CameraState val_1 = Cinemachine.CameraState.Default;
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Quaternion val_5 = this.transform.rotation;
            val_15 = worldUp.x;
            val_16 = Cinemachine.CinemachineCore.Instance.FindPotentialTargetBrain(vcam:  this);
            if(0 != val_16)
            {
                    float val_10 = val_16.OutputCamera.aspect;
            }
            else
            {
                    val_15 = 1f;
            }
            
            mem[1152921511705628272] = val_15;
            if(0 != val_16)
            {
                    val_16 = val_16.OutputCamera;
                val_17 = val_16.orthographic;
            }
            else
            {
                    val_17 = 0;
            }
            
            mem[1152921511705628268] = val_17;
            return val_0;
        }
        internal void SetStateRawPosition(UnityEngine.Vector3 pos)
        {
        
        }
        private static int <UpdateComponentPipeline>m__0(Cinemachine.CinemachineComponentBase c1, Cinemachine.CinemachineComponentBase c2)
        {
            var val_1 = X2;
            val_1 = c2 - val_1;
            return (int)val_1;
        }
    
    }

}
