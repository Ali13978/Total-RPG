using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.DisallowMultipleComponent]
    [UnityEngine.AddComponentMenu]
    public class CinemachineFreeLook : CinemachineVirtualCameraBase
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public UnityEngine.Transform m_LookAt;
        [UnityEngine.TooltipAttribute]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public UnityEngine.Transform m_Follow;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        public bool m_CommonLens;
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        [UnityEngine.TooltipAttribute]
        [Cinemachine.LensSettingsPropertyAttribute]
        public Cinemachine.LensSettings m_Lens;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.TooltipAttribute]
        public Cinemachine.AxisState m_YAxis;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.AxisState m_XAxis;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineOrbitalTransposer.Heading m_Heading;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineOrbitalTransposer.Recentering m_RecenterToTargetHeading;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineTransposer.BindingMode m_BindingMode;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        public float m_SplineCurvature;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineFreeLook.Orbit[] m_Orbits;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        private float m_LegacyHeadingBias;
        private bool mUseLegacyRigDefinitions;
        private bool mIsDestroyed;
        private Cinemachine.CameraState m_State;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        [Cinemachine.NoSaveDuringPlayAttribute]
        private Cinemachine.CinemachineVirtualCamera[] m_Rigs;
        private Cinemachine.CinemachineOrbitalTransposer[] mOrbitals;
        private Cinemachine.CinemachineBlend mBlendA;
        private Cinemachine.CinemachineBlend mBlendB;
        public static Cinemachine.CinemachineFreeLook.CreateRigDelegate CreateRigOverride;
        public static Cinemachine.CinemachineFreeLook.DestroyRigDelegate DestroyRigOverride;
        private Cinemachine.CinemachineFreeLook.Orbit[] m_CachedOrbits;
        private float m_CachedTension;
        private UnityEngine.Vector4[] m_CachedKnots;
        private UnityEngine.Vector4[] m_CachedCtrl1;
        private UnityEngine.Vector4[] m_CachedCtrl2;
        
        // Properties
        public static string[] RigNames { get; }
        public override Cinemachine.CameraState State { get; }
        public override UnityEngine.Transform LookAt { get; set; }
        public override UnityEngine.Transform Follow { get; set; }
        public override Cinemachine.ICinemachineCamera LiveChildOrSelf { get; }
        
        // Methods
        public CinemachineFreeLook()
        {
            var val_2;
            this.m_CommonLens = true;
            val_2 = null;
            val_2 = null;
            this.m_Lens = Cinemachine.LensSettings.Default;
            mem[1152921511671604724] = Cinemachine.LensSettings.Default.__il2cppRuntimeField_18;
            mem[1152921511671604716] = Cinemachine.LensSettings.Default.__il2cppRuntimeField_10;
            mem[1152921511671604744] = "Mouse Y";
            this.m_YAxis = ;
            mem[1152921511671604752] = 0;
            mem[1152921511671604756] = 0;
            mem[1152921511671604757] = 0;
            mem[1152921511671604775] = 0;
            mem[1152921511671604773] = 0;
            mem[1152921511671604792] = "Mouse X";
            this.m_XAxis = ;
            mem[1152921511671604800] = 0;
            mem[1152921511671604804] = true;
            mem[1152921511671604805] = 0;
            mem[1152921511671604823] = 0;
            mem[1152921511671604821] = 0;
            this.m_Heading = new Heading();
            mem[1152921511671604832] = 0;
            this.m_RecenterToTargetHeading = 0;
            mem[1152921511671604839] = 0;
            mem[1152921511671604837] = 0;
            mem[1152921511671604848] = 0;
            mem[1152921511671604852] = 0;
            this.m_BindingMode = 5;
            mem[1152921511671604840] = 1065353216;
            mem[1152921511671604844] = 1073741824;
            typeof(Orbit[]).__il2cppRuntimeField_20 = 1083179008;
            typeof(Orbit[]).__il2cppRuntimeField_24 = 1071644672;
            typeof(Orbit[]).__il2cppRuntimeField_28 = 1075838976;
            typeof(Orbit[]).__il2cppRuntimeField_2C = 1075838976 + 2097152;
            typeof(Orbit[]).__il2cppRuntimeField_30 = 1053609165;
            typeof(Orbit[]).__il2cppRuntimeField_34 = 1067869798;
            this.m_LegacyHeadingBias = -1.175494E-38f;
            this.m_Orbits = null;
            Cinemachine.CameraState val_2 = Cinemachine.CameraState.Default;
            this.m_Rigs = null;
        }
        protected override void OnValidate()
        {
            this.OnValidate();
            if(this.m_LegacyHeadingBias != (3.402823E+38f))
            {
                    mem[1152921511671741648] = this.m_LegacyHeadingBias;
                this.m_LegacyHeadingBias = -1.175494E-38f;
                if((25485312 != 1) && ((-1.175494E-38f) != 1))
            {
                    this.m_Heading = new Heading();
                mem[1152921511671741644] = -1.175494E-38f;
                mem[1152921511671741668] = 0;
                mem[1152921511671741664] = 0;
            }
            
                this.mUseLegacyRigDefinitions = true;
            }
            
            this.mOrbitals = 0;
        }
        public Cinemachine.CinemachineVirtualCamera GetRig(int i)
        {
            Cinemachine.CinemachineVirtualCamera val_2;
            this.UpdateRigCache();
            val_2 = 0;
            if(i > 2)
            {
                    return val_2;
            }
            
            int val_1 = i >> 30;
            val_1 = val_1 & 2;
            if(val_1 != 0)
            {
                    return val_2;
            }
            
            val_2 = this.m_Rigs[(long)i];
            return val_2;
        }
        public static string[] get_RigNames()
        {
            typeof(System.String[]).__il2cppRuntimeField_20 = "TopRig";
            typeof(System.String[]).__il2cppRuntimeField_28 = "MiddleRig";
            typeof(System.String[]).__il2cppRuntimeField_30 = "BottomRig";
            return (System.String[])null;
        }
        protected override void OnEnable()
        {
            this.mIsDestroyed = false;
            this.OnEnable();
            this.mOrbitals = 0;
        }
        protected override void OnDestroy()
        {
            UnityEngine.Object val_8;
            var val_9;
            if((this.m_Rigs != null) && (this.m_Rigs.Length >= 1))
            {
                    do
            {
                Cinemachine.CinemachineVirtualCamera val_9 = this.m_Rigs[0];
                if(0 != val_9)
            {
                    val_8 = val_9.gameObject;
                if(0 != val_8)
            {
                    val_9 = val_9.gameObject;
                if(val_9 != null)
            {
                    val_8 = val_9.hideFlags;
            }
            else
            {
                    val_8 = 0.hideFlags;
                val_9 = 0;
            }
            
                val_9.hideFlags = val_8 & 4294967292;
            }
            
            }
            
            }
            while((0 + 1) < this.m_Rigs.Length);
            
            }
            
            this.mIsDestroyed = true;
            this.OnDestroy();
        }
        private void OnTransformChildrenChanged()
        {
            this.mOrbitals = 0;
        }
        private void Reset()
        {
            this.DestroyRigs();
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
        public override Cinemachine.ICinemachineCamera get_LiveChildOrSelf()
        {
            if(this.m_Rigs == null)
            {
                    return (Cinemachine.ICinemachineCamera)this.m_Rigs[1];
            }
            
            if(this.m_Rigs.Length != 3)
            {
                    return (Cinemachine.ICinemachineCamera)this.m_Rigs[1];
            }
            
            if(this.m_YAxis < 0)
            {
                    return (Cinemachine.ICinemachineCamera)this.m_Rigs[2];
            }
            
            if(this.m_YAxis <= 0.66f)
            {
                    return (Cinemachine.ICinemachineCamera)this.m_Rigs[1];
            }
            
            return (Cinemachine.ICinemachineCamera)this.m_Rigs[0];
        }
        public override bool IsLiveChild(Cinemachine.ICinemachineCamera vcam)
        {
            Cinemachine.CinemachineVirtualCamera val_2;
            if(this.m_Rigs == null)
            {
                    return false;
            }
            
            if(this.m_Rigs.Length != 3)
            {
                    return false;
            }
            
            if(this.m_YAxis < 0)
            {
                    val_2 = this.m_Rigs[2];
                return (bool)(val_2 == vcam) ? 1 : 0;
            }
            
            if(this.m_YAxis > 0.66f)
            {
                    val_2 = this.m_Rigs[0];
                return (bool)(val_2 == vcam) ? 1 : 0;
            }
            
            val_2 = this.m_Rigs[1];
            return (bool)(val_2 == vcam) ? 1 : 0;
        }
        public override void RemovePostPipelineStageHook(Cinemachine.CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
        {
            this.RemovePostPipelineStageHook(d:  d);
            this.UpdateRigCache();
            if(this.m_Rigs == null)
            {
                    return;
            }
            
            if(this.m_Rigs.Length < 1)
            {
                    return;
            }
            
            do
            {
                bool val_1 = UnityEngine.Object.op_Inequality(x:  0, y:  this.m_Rigs[0]);
            }
            while((0 + 1) < this.m_Rigs.Length);
        
        }
        public override void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime)
        {
            float val_6;
            float val_7;
            float val_8;
            float val_13;
            float val_14;
            float val_15;
            float val_27;
            Cinemachine.CameraState val_28;
            val_27 = worldUp.y;
            float val_2 = (this.PreviousStateIsValid != true) ? deltaTime : -1f;
            this.UpdateRigCache();
            if(val_2 < 0)
            {
                    Cinemachine.CameraState val_3 = this.PullStateFromVirtualCamera(worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = val_27, z = worldUp.z});
                val_28 = this.m_State;
            }
            else
            {
                    val_28 = this.m_State;
            }
            
            Cinemachine.CameraState val_4 = this.CalculateNewState(worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = val_27, z = worldUp.z}, deltaTime:  val_2);
            if(0 != this)
            {
                    UnityEngine.Vector3 val_10 = this.transform.position;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                this.transform.position = new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15};
                UnityEngine.Transform val_16 = this.m_Rigs[0].transform;
                UnityEngine.Vector3 val_17 = val_16.position;
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
                val_16.position = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
                UnityEngine.Transform val_19 = this.m_Rigs[1].transform;
                UnityEngine.Vector3 val_20 = val_19.position;
                UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
                val_19.position = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
                UnityEngine.Transform val_22 = this.m_Rigs[2].transform;
                UnityEngine.Vector3 val_23 = val_22.position;
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
                val_27 = val_24.y;
                val_22.position = new UnityEngine.Vector3() {x = val_24.x, y = val_27, z = val_24.z};
            }
            
            this.PreviousStateIsValid = true;
            if(val_2 < 0f)
            {
                    if((Cinemachine.CinemachineCore.Instance.IsLive(vcam:  this)) == false)
            {
                goto label_29;
            }
            
            }
            
            label_29:
            this.PushSettingsToRigs();
        }
        public override void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, float deltaTime)
        {
            UnityEngine.Object val_13;
            float val_14;
            float val_15;
            var val_16;
            val_14 = deltaTime;
            val_15 = worldUp.y;
            val_16 = this;
            this.OnTransitionFromCamera(fromCam:  fromCam, worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = val_15, z = worldUp.z}, deltaTime:  val_14);
            if(fromCam == null)
            {
                    return;
            }
            
            val_13 = fromCam;
            if(0 != val_13)
            {
                    return;
            }
            
            this.m_XAxis = null;
            this.m_YAxis = null;
            val_16 = ???;
            val_13 = ???;
            val_14 = ???;
            val_15 = ???;
            goto typeof(Cinemachine.CinemachineFreeLook).__il2cppRuntimeField_2E0;
        }
        private void InvalidateRigCache()
        {
            this.mOrbitals = 0;
        }
        private void DestroyRigs()
        {
            var val_19;
            var val_23;
            System.String[] val_1 = Cinemachine.CinemachineFreeLook.RigNames;
            val_19 = 0;
            System.String[] val_2 = Cinemachine.CinemachineFreeLook.RigNames;
            if( >= val_2.Length)
            {
                goto label_4;
            }
            
            System.Collections.IEnumerator val_4 = this.transform.GetEnumerator();
            goto label_26;
            label_4:
            val_23 = 0;
            goto label_46;
            label_63:
            val_23 = 1;
            label_46:
            if(0 == Cinemachine.CinemachineVirtualCamera[].__il2cppRuntimeField_this_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFF)
            {
                goto label_63;
            }
            
            if(Cinemachine.CinemachineFreeLook.DestroyRigOverride == null)
            {
                goto label_53;
            }
            
            Cinemachine.CinemachineFreeLook.DestroyRigOverride.Invoke(rig:  Cinemachine.CinemachineVirtualCamera[].__il2cppRuntimeField_this_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFF.gameObject);
            goto label_63;
            label_53:
            UnityEngine.GameObject val_18 = Cinemachine.CinemachineVirtualCamera[].__il2cppRuntimeField_this_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFF.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            goto label_63;
        }
        private Cinemachine.CinemachineVirtualCamera[] CreateRigs(Cinemachine.CinemachineVirtualCamera[] copyFrom)
        {
            var val_20;
            Cinemachine.CinemachineVirtualCamera val_21;
            UnityEngine.Object val_22;
            var val_23;
            this.mOrbitals = 0;
            val_20 = 0;
            goto label_1;
            label_61:
            val_20 = 1;
            label_1:
            System.String[] val_1 = Cinemachine.CinemachineFreeLook.RigNames;
            if(val_20 >= val_1.Length)
            {
                    return (Cinemachine.CinemachineVirtualCamera[])null;
            }
            
            if((copyFrom != null) && (copyFrom.Length > val_20))
            {
                    val_21 = copyFrom[1];
            }
            else
            {
                    val_21 = 0;
            }
            
            System.String[] val_2 = Cinemachine.CinemachineFreeLook.RigNames;
            if(Cinemachine.CinemachineFreeLook.CreateRigOverride != null)
            {
                    Cinemachine.CinemachineVirtualCamera[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20 = Cinemachine.CinemachineFreeLook.CreateRigOverride.Invoke(vcam:  this, name:  val_2[1], copyFrom:  val_21);
            }
            else
            {
                    UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  val_2[1]);
                transform.parent = this.transform;
                Cinemachine.CinemachineVirtualCamera[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20 = AddComponent<Cinemachine.CinemachineVirtualCamera>();
                if(0 != val_21)
            {
                    Cinemachine.Utility.ReflectionHelpers.CopyFields(src:  0, dst:  val_21, bindingAttr:  Cinemachine.CinemachineVirtualCamera[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20);
            }
            else
            {
                    UnityEngine.GameObject val_10 = Cinemachine.CinemachineVirtualCamera[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20.GetComponentOwner().gameObject;
                if(val_10 != null)
            {
                    Cinemachine.CinemachineOrbitalTransposer val_11 = val_10.AddComponent<Cinemachine.CinemachineOrbitalTransposer>();
            }
            else
            {
                    Cinemachine.CinemachineOrbitalTransposer val_12 = 0.AddComponent<Cinemachine.CinemachineOrbitalTransposer>();
            }
            
                Cinemachine.CinemachineComposer val_13 = val_10.AddComponent<Cinemachine.CinemachineComposer>();
            }
            
            }
            
            Cinemachine.CinemachineVirtualCamera[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20.InvalidateComponentPipeline();
            val_22 = Cinemachine.CinemachineVirtualCamera[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20.GetCinemachineComponent<Cinemachine.CinemachineOrbitalTransposer>();
            if(0 == val_22)
            {
                    val_22 = Cinemachine.CinemachineVirtualCamera[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20.AddCinemachineComponent<Cinemachine.CinemachineOrbitalTransposer>();
            }
            
            if(0 != val_21)
            {
                goto label_61;
            }
            
            mem2[0] = 0;
            Cinemachine.CinemachineComposer val_18 = Cinemachine.CinemachineVirtualCamera[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20.GetCinemachineComponent<Cinemachine.CinemachineComposer>();
            if(0 == val_18)
            {
                goto label_61;
            }
            
            if(val_18 != null)
            {
                    val_18.m_HorizontalDamping = 0f;
                val_18.m_VerticalDamping = 0f;
            }
            else
            {
                    mem[64] = 0;
                val_18.m_HorizontalDamping = 0f;
            }
            
            val_23 = null;
            val_18.m_ScreenX = 0.5f;
            if(null == null)
            {
                    val_23 = val_23;
            }
            
            val_23 = val_23;
            if(val_18 != null)
            {
                    val_18.m_ScreenY = typeof(System.Single[]).__il2cppRuntimeField_24;
                val_18.m_BiasY = 0f;
                val_18.m_DeadZoneWidth = ;
                val_18.m_DeadZoneHeight = ;
                val_18.m_SoftZoneWidth = 0.8f;
                val_18.m_SoftZoneHeight = 0.8f;
            }
            else
            {
                    mem[72] = typeof(System.Single[]).__il2cppRuntimeField_24;
                mem[80] = 1036831949;
                val_18.m_DeadZoneWidth = 0.1f;
                mem[88] = 1061997773;
                val_18.m_SoftZoneWidth = 0.8f;
                mem[96] = 0;
            }
            
            val_18.m_BiasX = 0f;
            goto label_61;
        }
        private void UpdateRigCache()
        {
            Cinemachine.CinemachineVirtualCamera val_17;
            var val_18;
            var val_19;
            var val_20;
            if(this.mIsDestroyed == true)
            {
                    return;
            }
            
            if((this.m_Rigs != null) && (this.m_Rigs.Length == 3))
            {
                    val_17 = 1152921504721543168;
                if(0 != this.m_Rigs[0])
            {
                    val_17 = this.transform;
                if(0 != this.m_Rigs[0].transform.parent)
            {
                    this.DestroyRigs();
                this.m_Rigs = this.CreateRigs(copyFrom:  this.m_Rigs);
            }
            
            }
            
            }
            
            if(this.mOrbitals != null)
            {
                    if(this.mOrbitals.Length == 3)
            {
                    return;
            }
            
            }
            
            if((this.LocateExistingRigs(rigNames:  Cinemachine.CinemachineFreeLook.RigNames, forceOrbital:  false)) != 3)
            {
                    this.DestroyRigs();
                this.m_Rigs = this.CreateRigs(copyFrom:  0);
                int val_11 = this.LocateExistingRigs(rigNames:  Cinemachine.CinemachineFreeLook.RigNames, forceOrbital:  true);
            }
            
            val_18 = 0;
            goto label_17;
            label_60:
            val_18 = 1;
            mem2[0] = null;
            label_17:
            if(val_18 >= this.m_Rigs.Length)
            {
                goto label_19;
            }
            
            Cinemachine.CinemachineVirtualCamera val_19 = this.m_Rigs[1];
            if(this.m_CommonLens != false)
            {
                    val_19 = null;
                typeof(System.String[]).__il2cppRuntimeField_20 = "m_Script";
                typeof(System.String[]).__il2cppRuntimeField_28 = "Header";
                typeof(System.String[]).__il2cppRuntimeField_30 = "Extensions";
                typeof(System.String[]).__il2cppRuntimeField_38 = "m_Priority";
                typeof(System.String[]).__il2cppRuntimeField_40 = "m_Follow";
                typeof(System.String[]).__il2cppRuntimeField_48 = "m_Lens";
                val_20 = val_19;
            }
            else
            {
                    val_19 = null;
                typeof(System.String[]).__il2cppRuntimeField_20 = "m_Script";
                typeof(System.String[]).__il2cppRuntimeField_28 = "Header";
                typeof(System.String[]).__il2cppRuntimeField_30 = "Extensions";
                typeof(System.String[]).__il2cppRuntimeField_38 = "m_Priority";
                typeof(System.String[]).__il2cppRuntimeField_40 = "m_Follow";
                val_20 = (this.m_CommonLens == true) ? 0 : (val_19);
            }
            
            mem2[0] = val_19;
            if(val_19 != null)
            {
                goto label_60;
            }
            
            goto label_60;
            label_19:
            this.mBlendA = new Cinemachine.CinemachineBlend(a:  this.m_Rigs[1], b:  this.m_Rigs[0], curve:  UnityEngine.AnimationCurve.Linear(timeStart:  0f, valueStart:  0f, timeEnd:  1f, valueEnd:  1f), duration:  1f, t:  0f);
            val_17 = this.m_Rigs[1];
            this.mBlendB = new Cinemachine.CinemachineBlend(a:  this.m_Rigs[2], b:  val_17, curve:  UnityEngine.AnimationCurve.Linear(timeStart:  0f, valueStart:  0f, timeEnd:  1f, valueEnd:  1f), duration:  1f, t:  0f);
            mem[1152921511676132556] = 0;
            mem[1152921511676132604] = 0;
            mem[1152921511676132608] = 1135869952;
            mem[1152921511676132612] = 1;
            mem[1152921511676132560] = 1065353216;
            mem[1152921511676132564] = 0;
        }
        private int LocateExistingRigs(string[] rigNames, bool forceOrbital)
        {
            var val_3;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            this.mOrbitals = null;
            this.m_Rigs = null;
            System.Collections.IEnumerator val_2 = this.transform.GetEnumerator();
            goto label_5;
            label_22:
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_20 = val_2;
            Cinemachine.CinemachineVirtualCamera val_7 = 0.GetComponent<Cinemachine.CinemachineVirtualCamera>();
            if(0 != val_7)
            {
                goto label_16;
            }
            
            label_5:
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_21 = val_2;
            if(((val_2 & 1) & 1) != 0)
            {
                goto label_22;
            }
            
            goto label_80;
            label_16:
            val_3 = val_3;
            val_22 = 0;
            goto label_26;
            label_71:
            val_22 = 1;
            label_26:
            if(val_22 >= rigNames.Length)
            {
                goto label_5;
            }
            
            if(0 != this.mOrbitals[1])
            {
                goto label_71;
            }
            
            string val_23 = rigNames[1];
            if((System.String.op_Equality(a:  0, b:  0.gameObject.name)) == false)
            {
                goto label_71;
            }
            
            this.mOrbitals[1] = val_7.GetCinemachineComponent<Cinemachine.CinemachineOrbitalTransposer>();
            bool val_25 = forceOrbital;
            val_25 = (UnityEngine.Object.op_Equality(x:  0, y:  this.mOrbitals[1])) & val_25;
            if(val_25 != false)
            {
                    this.mOrbitals[1] = val_7.AddCinemachineComponent<Cinemachine.CinemachineOrbitalTransposer>();
            }
            
            if(0 == this.mOrbitals[1])
            {
                goto label_71;
            }
            
            Cinemachine.CinemachineOrbitalTransposer val_27 = this.mOrbitals[1];
            this.mOrbitals[0x1][0].m_HeadingIsSlave = true;
            if(val_22 == 0)
            {
                    Cinemachine.CinemachineOrbitalTransposer val_28 = this.mOrbitals[1];
                typeof(CinemachineOrbitalTransposer.UpdateHeadingDelegate).__il2cppRuntimeField_20 = this;
                typeof(CinemachineOrbitalTransposer.UpdateHeadingDelegate).__il2cppRuntimeField_28 = System.Single Cinemachine.CinemachineFreeLook::<LocateExistingRigs>m__0(Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
                typeof(CinemachineOrbitalTransposer.UpdateHeadingDelegate).__il2cppRuntimeField_10 = System.Single Cinemachine.CinemachineFreeLook::<LocateExistingRigs>m__0(Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
                mem2[0] = null;
            }
            
            this.m_Rigs[1] = val_7;
            var val_29 = val_3;
            val_29 = val_29 + 1;
            val_3 = val_29;
            goto label_71;
            label_80:
            if(val_2 != null)
            {
                    var val_30 = 0;
                val_30 = val_30 + 1;
                val_23 = val_2;
            }
            
            if(0 == 327)
            {
                    return (int)System.Single Cinemachine.CinemachineFreeLook::<LocateExistingRigs>m__0(Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
            }
            
            if(null == null)
            {
                    return (int)System.Single Cinemachine.CinemachineFreeLook::<LocateExistingRigs>m__0(Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
            }
            
            return (int)System.Single Cinemachine.CinemachineFreeLook::<LocateExistingRigs>m__0(Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
        }
        private void PushSettingsToRigs()
        {
            float val_8;
            float val_9;
            float val_10;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            UnityEngine.HideFlags val_18;
            this.UpdateRigCache();
            val_14 = 0;
            goto label_1;
            label_68:
            val_14 = 1;
            label_1:
            if(val_14 >= this.m_Rigs.Length)
            {
                    return;
            }
            
            if(0 == this.m_Rigs[1])
            {
                goto label_68;
            }
            
            if(this.m_CommonLens != false)
            {
                    Cinemachine.CinemachineVirtualCamera val_12 = this.m_Rigs[1];
                mem2[0] = this.m_Lens.FarClipPlane;
                this.m_Rigs[0x1][0].m_Lens = this.m_Lens.FieldOfView;
            }
            
            if(this.mUseLegacyRigDefinitions != false)
            {
                    this.mUseLegacyRigDefinitions = false;
                this.m_Orbits[1] = this.mOrbitals[1];
                Cinemachine.CinemachineOrbitalTransposer val_14 = this.mOrbitals[1];
                this.m_Orbits[1] = -S8;
                if(0 != this.m_Rigs[1])
            {
                    Cinemachine.CinemachineVirtualCamera val_16 = this.m_Rigs[1];
            }
            
            }
            
            Cinemachine.CinemachineVirtualCamera val_17 = this.m_Rigs[1];
            val_15 = null;
            val_15 = null;
            val_16 = this.m_Rigs[1].gameObject;
            if(val_16 != null)
            {
                    val_17 = val_16.hideFlags;
            }
            else
            {
                    val_17 = 0.hideFlags;
                val_16 = 0;
            }
            
            if(Cinemachine.CinemachineCore.sShowHiddenObjects != false)
            {
                    val_18 = val_17 & 4294967292;
            }
            else
            {
                    val_18 = val_17 | 3;
            }
            
            val_16.hideFlags = val_18;
            Cinemachine.CinemachineOrbitalTransposer val_19 = this.mOrbitals[1];
            UnityEngine.Vector3 val_7 = this.GetLocalPositionForCameraFromInput(t:  this.m_YAxis);
            mem2[0] = val_7.x;
            mem2[0] = val_7.y;
            mem2[0] = val_7.z;
            Cinemachine.CinemachineOrbitalTransposer val_20 = this.mOrbitals[1];
            mem2[0] = this.m_BindingMode;
            Cinemachine.CinemachineOrbitalTransposer val_21 = this.mOrbitals[1];
            mem2[0] = Cinemachine.CinemachineCore.sShowHiddenObjects;
            this.mOrbitals[0x1][0].m_Heading = this.m_Heading;
            Cinemachine.CinemachineOrbitalTransposer val_22 = this.mOrbitals[1];
            mem2[0] = this.m_XAxis.mCurrentSpeed;
            mem2[0] = this.m_XAxis.m_InputAxisName;
            this.mOrbitals[0x1][0].m_XAxis = this.m_XAxis.Value;
            Cinemachine.CinemachineOrbitalTransposer val_23 = this.mOrbitals[1];
            mem2[0] = this.m_RecenterToTargetHeading.m_LegacyVelocityFilterStrength;
            this.mOrbitals[0x1][0].m_RecenterToTargetHeading = this.m_RecenterToTargetHeading.m_enabled;
            if(val_14 >= 1)
            {
                    Cinemachine.CinemachineOrbitalTransposer val_24 = this.mOrbitals[1];
                this.mOrbitals[0x1][0].m_RecenterToTargetHeading = 0;
            }
            
            if(this.m_BindingMode != 5)
            {
                goto label_68;
            }
            
            this.m_Rigs[1].SetStateRawPosition(pos:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10});
            goto label_68;
        }
        private Cinemachine.CameraState CalculateNewState(UnityEngine.Vector3 worldUp, float deltaTime)
        {
            Cinemachine.CinemachineBlend val_3;
            Cinemachine.CinemachineBlend val_4;
            Cinemachine.CinemachineBlend val_5;
            Cinemachine.CameraState val_0;
            Cinemachine.CameraState val_1 = this.PullStateFromVirtualCamera(worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z});
            Cinemachine.AxisState val_3 = this.m_YAxis;
            if(val_3 <= 0.5f)
            {
                goto label_0;
            }
            
            val_3 = this.mBlendA;
            if(val_3 == null)
            {
                goto label_5;
            }
            
            val_3 = val_3 + (-0.5f);
            val_3 = val_3 + val_3;
            this.mBlendA.<TimeInBlend>k__BackingField = val_3;
            val_4 = this.mBlendA;
            val_4.UpdateCameraState(worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  deltaTime);
            val_5 = this.mBlendA;
            if(val_5 != null)
            {
                goto label_7;
            }
            
            goto label_4;
            label_0:
            val_3 = this.mBlendB;
            if(val_3 == null)
            {
                goto label_5;
            }
            
            val_3 = val_3 + val_3;
            this.mBlendB.<TimeInBlend>k__BackingField = val_3;
            val_4 = this.mBlendB;
            val_4.UpdateCameraState(worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  deltaTime);
            val_5 = this.mBlendB;
            if(val_5 != null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            Cinemachine.CameraState val_2 = val_5.State;
            label_5:
            return val_0;
        }
        private Cinemachine.CameraState PullStateFromVirtualCamera(UnityEngine.Vector3 worldUp)
        {
            float val_2;
            float val_3;
            UnityEngine.Object val_17;
            var val_18;
            Cinemachine.CameraState val_0;
            Cinemachine.CameraState val_1 = Cinemachine.CameraState.Default;
            UnityEngine.Vector3 val_5 = this.transform.position;
            UnityEngine.Quaternion val_7 = this.transform.rotation;
            val_17 = Cinemachine.CinemachineCore.Instance.FindPotentialTargetBrain(vcam:  this);
            if(0 != val_17)
            {
                    float val_12 = val_17.OutputCamera.aspect;
            }
            
            this.m_Lens.startValue = 1f;
            if(0 != val_17)
            {
                    val_17 = val_17.OutputCamera;
                val_18 = val_17;
                bool val_15 = val_18.orthographic;
            }
            else
            {
                    val_18 = 0;
            }
            
            var val_16 = val_18 & 1;
            val_0.<Lens>k__BackingField.FarClipPlane = this.m_Lens.FarClipPlane;
            val_0.<ReferenceLookAt>k__BackingField.z = val_2;
            val_0.<ReferenceUp>k__BackingField.y = worldUp.y;
            val_0.<ReferenceUp>k__BackingField.x = worldUp.x;
            val_0.<ReferenceUp>k__BackingField.z = worldUp.z;
            val_0.<ReferenceLookAt>k__BackingField.x = val_3;
            val_0.<RawPosition>k__BackingField.x = val_5.x;
            val_0.<RawPosition>k__BackingField.y = val_5.y;
            val_0.<RawPosition>k__BackingField.z = val_5.z;
            val_0.<RawOrientation>k__BackingField.x = val_7.x;
            val_0.<RawOrientation>k__BackingField.y = val_7.y;
            val_0.<RawOrientation>k__BackingField.z = val_7.z;
            val_0.<RawOrientation>k__BackingField.w = val_7.w;
            val_0.<Lens>k__BackingField.FieldOfView = this.m_Lens.FieldOfView;
            return val_0;
        }
        public UnityEngine.Vector3 GetLocalPositionForCameraFromInput(float t)
        {
            if(this.mOrbitals == null)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            this.UpdateCachedSpline();
            float val_8 = -0.5f;
            val_8 = t + val_8;
            var val_1 = (t > 0.5f) ? 2 : 1;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = this.m_CachedKnots[val_1], y = this.m_CachedKnots[val_1], z = this.m_CachedKnots[val_1], w = this.m_CachedKnots[val_1]});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = this.m_CachedCtrl1[val_1], y = this.m_CachedCtrl1[val_1], z = this.m_CachedCtrl1[val_1], w = this.m_CachedCtrl1[val_1]});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = this.m_CachedCtrl2[val_1], y = this.m_CachedCtrl2[val_1], z = this.m_CachedCtrl2[val_1], w = this.m_CachedCtrl2[val_1]});
            val_1 = val_1 + 1;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = this.m_CachedKnots[val_1], y = this.m_CachedKnots[val_1], z = this.m_CachedKnots[val_1], w = this.m_CachedKnots[val_1]});
            float val_25 = (t > 0.5f) ? (val_8) : t;
            val_25 = val_25 + val_25;
            UnityEngine.Vector3 val_7 = Cinemachine.Utility.SplineHelpers.Bezier3(t:  val_25, p0:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, p1:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, p2:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.z, z = val_6.x}, p3:  new UnityEngine.Vector3() {x = val_6.z, z = val_3.x});
            return new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        private void UpdateCachedSpline()
        {
            Orbit[] val_9;
            var val_10;
            var val_11;
            Orbit val_12;
            var val_13;
            var val_14;
            Orbit[] val_15;
            val_9 = this.m_CachedOrbits;
            if((val_9 == null) || (this.m_CachedTension != this.m_SplineCurvature))
            {
                goto label_8;
            }
            
            val_10 = 0;
            val_11 = 0;
            goto label_3;
            label_14:
            val_9 = this.m_CachedOrbits;
            val_11 = 1;
            val_10 = 8;
            label_3:
            if(val_9[val_10] == this.m_Orbits[val_10])
            {
                    val_12 = this.m_CachedOrbits[val_10];
                Orbit val_11 = this.m_Orbits[val_10];
                if(val_11 <= 1)
            {
                    if((((val_12 != val_11) ? 1 : 0) & 1) == 0)
            {
                goto label_14;
            }
            
            }
            
                if(val_12 == val_11)
            {
                    return;
            }
            
            }
            
            label_8:
            this.m_CachedKnots = null;
            this.m_CachedCtrl1 = null;
            this.m_CachedCtrl2 = null;
            Orbit val_12 = this.m_Orbits[2];
            Orbit val_13 = this.m_Orbits[2];
            this.m_CachedKnots[1] = 0;
            Orbit val_14 = this.m_Orbits[1];
            Orbit val_15 = this.m_Orbits[1];
            mem2[0] = 0;
            Orbit val_16 = this.m_Orbits[0];
            Orbit val_17 = this.m_Orbits[0];
            mem2[0] = 0;
            val_13 = mem[this.m_CachedKnots];
            if(mem[this.m_CachedKnots] == 0)
            {
                    val_13 = mem[this.m_CachedKnots];
                if(val_13 == 0)
            {
                    val_13 = 0;
            }
            
            }
            
            UnityEngine.Vector4 val_2 = UnityEngine.Vector4.zero;
            UnityEngine.Vector4 val_3 = UnityEngine.Vector4.Lerp(a:  new UnityEngine.Vector4() {x = 0f, y = 5.142877E-39f, z = 5.87748E-39f, w = 2.295924E-39f}, b:  new UnityEngine.Vector4() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, t:  this.m_SplineCurvature);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
            mem2[0] = val_3.w;
            val_14 = mem[this.m_CachedKnots];
            if(mem[this.m_CachedKnots] == 0)
            {
                    val_14 = mem[this.m_CachedKnots];
                if(val_14 == 0)
            {
                    val_14 = 0;
            }
            
            }
            
            UnityEngine.Vector4 val_4 = UnityEngine.Vector4.zero;
            UnityEngine.Vector4 val_5 = UnityEngine.Vector4.Lerp(a:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f}, b:  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, t:  this.m_SplineCurvature);
            val_12 = val_5.x;
            mem2[0] = val_12;
            mem2[0] = val_5.y;
            mem2[0] = val_5.z;
            mem2[0] = val_5.w;
            Cinemachine.Utility.SplineHelpers.ComputeSmoothControlPoints(knot: ref  0, ctrl1: ref  this.m_CachedKnots, ctrl2: ref  this.m_CachedCtrl1);
            val_15 = null;
            val_11 = 0;
            this.m_CachedOrbits = val_15;
            goto label_44;
            label_49:
            val_15 = this.m_CachedOrbits;
            val_11 = 1;
            label_44:
            val_15[val_11] = this.m_Orbits[val_11];
            if(val_11 != 2)
            {
                goto label_49;
            }
            
            this.m_CachedTension = this.m_SplineCurvature;
        }
        private float <LocateExistingRigs>m__0(Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up)
        {
            if(orbital != null)
            {
                    return orbital.UpdateHeading(deltaTime:  deltaTime, up:  new UnityEngine.Vector3() {x = up.x, y = up.y, z = up.z}, axis: ref  new Cinemachine.AxisState() {Value = this.m_XAxis, m_MaxSpeed = this.m_XAxis, m_AccelTime = this.m_XAxis, m_DecelTime = this.m_XAxis, m_InputAxisName = this.m_XAxis, m_InputAxisValue = this.m_XAxis, m_InvertAxis = this.m_XAxis, mCurrentSpeed = this.m_XAxis, mMinValue = this.m_XAxis, mMaxValue = this.m_XAxis, mWrapAround = this.m_XAxis});
            }
            
            return orbital.UpdateHeading(deltaTime:  deltaTime, up:  new UnityEngine.Vector3() {x = up.x, y = up.y, z = up.z}, axis: ref  new Cinemachine.AxisState() {Value = this.m_XAxis, m_MaxSpeed = this.m_XAxis, m_AccelTime = this.m_XAxis, m_DecelTime = this.m_XAxis, m_InputAxisName = this.m_XAxis, m_InputAxisValue = this.m_XAxis, m_InvertAxis = this.m_XAxis, mCurrentSpeed = this.m_XAxis, mMinValue = this.m_XAxis, mMaxValue = this.m_XAxis, mWrapAround = this.m_XAxis});
        }
    
    }

}
