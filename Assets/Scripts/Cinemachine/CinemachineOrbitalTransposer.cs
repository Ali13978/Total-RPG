using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineOrbitalTransposer : CinemachineTransposer
    {
        // Fields
        [UnityEngine.SpaceAttribute]
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineOrbitalTransposer.Heading m_Heading;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineOrbitalTransposer.Recentering m_RecenterToTargetHeading;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.AxisState m_XAxis;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        private float m_LegacyRadius;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        private float m_LegacyHeightOffset;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        private float m_LegacyHeadingBias;
        [UnityEngine.HideInInspector]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public bool m_HeadingIsSlave;
        internal Cinemachine.CinemachineOrbitalTransposer.UpdateHeadingDelegate HeadingUpdater;
        private float mLastHeadingAxisInputTime;
        private float mHeadingRecenteringVelocity;
        private UnityEngine.Vector3 mLastTargetPosition;
        private Cinemachine.CinemachineOrbitalTransposer.HeadingTracker mHeadingTracker;
        private UnityEngine.Rigidbody mTargetRigidBody;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Transform <PreviousTarget>k__BackingField;
        private UnityEngine.Quaternion mHeadingPrevFrame;
        private UnityEngine.Vector3 mOffsetPrevFrame;
        private static Cinemachine.CinemachineOrbitalTransposer.UpdateHeadingDelegate <>f__am$cache0;
        
        // Properties
        private UnityEngine.Transform PreviousTarget { get; set; }
        
        // Methods
        public CinemachineOrbitalTransposer()
        {
            var val_4;
            mem[1152921511715027976] = 0;
            this.m_Heading = new Heading();
            this.m_RecenterToTargetHeading = 1;
            mem[1152921511715027983] = 0;
            mem[1152921511715027984] = 1065353216;
            mem[1152921511715027988] = 1073741824;
            mem[1152921511715027992] = 0;
            mem[1152921511715027981] = 0;
            mem[1152921511715028016] = "Mouse X";
            this.m_XAxis = ;
            mem[1152921511715028024] = 0;
            mem[1152921511715028028] = 1;
            mem[1152921511715028029] = 0;
            mem[1152921511715028047] = 0;
            this.m_LegacyRadius = 3.402823E+38f;
            this.m_LegacyHeightOffset = 9.183409E-41f;
            this.m_LegacyHeadingBias = -1.175494E-38f;
            mem[1152921511715028045] = 0;
            val_4 = null;
            if((Cinemachine.CinemachineOrbitalTransposer.<>f__am$cache0) == null)
            {
                    typeof(CinemachineOrbitalTransposer.UpdateHeadingDelegate).__il2cppRuntimeField_20 = 0;
                typeof(CinemachineOrbitalTransposer.UpdateHeadingDelegate).__il2cppRuntimeField_28 = static System.Single Cinemachine.CinemachineOrbitalTransposer::<HeadingUpdater>m__0(Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
                typeof(CinemachineOrbitalTransposer.UpdateHeadingDelegate).__il2cppRuntimeField_10 = static System.Single Cinemachine.CinemachineOrbitalTransposer::<HeadingUpdater>m__0(Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up);
                Cinemachine.CinemachineOrbitalTransposer.<>f__am$cache0 = null;
                val_4 = null;
            }
            
            this.HeadingUpdater = Cinemachine.CinemachineOrbitalTransposer.<>f__am$cache0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.mLastTargetPosition = val_1;
            mem[1152921511715028084] = val_1.y;
            mem[1152921511715028088] = val_1.z;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            this.mHeadingPrevFrame = val_2;
            mem[1152921511715028124] = val_2.y;
            mem[1152921511715028128] = val_2.z;
            mem[1152921511715028132] = val_2.w;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.mOffsetPrevFrame = val_3;
            mem[1152921511715028140] = val_3.y;
            mem[1152921511715028144] = val_3.z;
        }
        protected override void OnValidate()
        {
            if(this.m_LegacyRadius != (3.402823E+38f))
            {
                    float val_2 = this.m_LegacyHeightOffset;
                if((val_2 != (3.402823E+38f)) && (this.m_LegacyHeadingBias != (3.402823E+38f)))
            {
                    float val_3 = -this.m_LegacyRadius;
                float val_1 = 0f;
                val_1 = val_1 / 10f;
                val_2 = val_2 / 10f;
                mem[1152921511715140004] = val_1;
                mem[1152921511715140008] = val_2;
                this.m_LegacyRadius = 3.402823E+38f;
                this.m_LegacyHeightOffset = 9.183409E-41f;
                this.m_LegacyHeadingBias = -1.175494E-38f;
                mem[1152921511715139876] = 0;
                mem[1152921511715139880] = 0;
                val_3 = val_3 / 10f;
                mem[1152921511715139884] = 0;
                mem[1152921511715139976] = this.m_LegacyHeadingBias;
                mem[1152921511715140012] = val_3;
                if((0 != 1) && (0 != 1))
            {
                    this.m_Heading = 0;
                mem[1152921511715139972] = 0;
                mem[1152921511715139992] = 0;
                mem[1152921511715139996] = 0;
            }
            
            }
            
            }
            
            this.OnValidate();
        }
        public float UpdateHeading(float deltaTime, UnityEngine.Vector3 up, ref Cinemachine.AxisState axis)
        {
            var val_14;
            float val_15;
            float val_16;
            float val_18;
            val_15 = up.y;
            if(deltaTime >= 0f)
            {
                goto label_1;
            }
            
            val_14 = Cinemachine.CinemachineCore.Instance;
            if((val_14.IsLive(vcam:  this.VirtualCamera)) == false)
            {
                goto label_6;
            }
            
            label_1:
            if((1152921511715300256 & 1) != 0)
            {
                    this.mLastHeadingAxisInputTime = UnityEngine.Time.time;
                this.mHeadingRecenteringVelocity = 0f;
            }
            
            label_6:
            val_16 = axis.Value;
            UnityEngine.Quaternion val_5 = this.GetReferenceOrientation(worldUp:  new UnityEngine.Vector3() {x = up.x, y = val_15, z = up.z});
            float val_14 = val_5.y;
            float val_6 = this.GetTargetHeading(currentHeading:  val_16, targetOrientation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_14, z = val_5.z, w = val_5.w}, deltaTime:  val_5.y);
            if(deltaTime >= 0)
            {
                goto label_7;
            }
            
            this.mHeadingRecenteringVelocity = 0f;
            if(this.m_RecenterToTargetHeading != 0)
            {
                goto label_13;
            }
            
            goto label_25;
            label_7:
            if(this.m_RecenterToTargetHeading == 0)
            {
                goto label_25;
            }
            
            float val_7 = UnityEngine.Time.time;
            float val_13 = this.mLastHeadingAxisInputTime;
            val_13 = val_13 + val_14;
            if(val_7 <= val_13)
            {
                goto label_25;
            }
            
            val_16 = val_7 / 3f;
            if(val_16 <= deltaTime)
            {
                goto label_13;
            }
            
            val_14 = 1152921504719998976;
            float val_8 = UnityEngine.Mathf.DeltaAngle(current:  axis.Value, target:  val_6);
            val_15 = System.Math.Abs(val_8);
            if(val_15 >= 0)
            {
                goto label_16;
            }
            
            axis.Value = val_6;
            this.mHeadingRecenteringVelocity = 0f;
            goto label_25;
            label_13:
            axis.Value = val_6;
            label_25:
            if(this.m_RecenterToTargetHeading != 5)
            {
                    return (float)axis.Value;
            }
            
            axis.Value = 0f;
            return (float)axis.Value;
            label_16:
            float val_9 = deltaTime / val_16;
            val_18 = (UnityEngine.Mathf.Sign(f:  val_8)) * (UnityEngine.Mathf.Min(a:  val_15, b:  val_9 * val_15));
            val_14 = val_18 - this.mHeadingRecenteringVelocity;
            if(val_18 < 0)
            {
                    if(val_14 < 0)
            {
                goto label_22;
            }
            
            }
            
            if((val_18 > 0f) && (val_14 > 0f))
            {
                    label_22:
                val_18 = val_9 * val_18;
                val_18 = val_18 + this.mHeadingRecenteringVelocity;
            }
            
            float val_15 = axis.Value;
            val_15 = val_18 + val_15;
            axis.Value = val_15;
            this.mHeadingRecenteringVelocity = val_18;
            goto label_25;
        }
        private void OnEnable()
        {
            this.<PreviousTarget>k__BackingField = 0;
            mem[1152921511715396868] = 0;
            mem[1152921511715396876] = 1;
            mem[1152921511715396872] = 1135869952;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.mLastTargetPosition = val_1;
            mem[1152921511715396916] = val_1.y;
            mem[1152921511715396920] = val_1.z;
        }
        private UnityEngine.Transform get_PreviousTarget()
        {
            return (UnityEngine.Transform)this.<PreviousTarget>k__BackingField;
        }
        private void set_PreviousTarget(UnityEngine.Transform value)
        {
            this.<PreviousTarget>k__BackingField = value;
        }
        public override void MutateCameraState(ref Cinemachine.CameraState curState, float deltaTime)
        {
            float val_28;
            UnityEngine.Rigidbody val_29;
            var val_30;
            var val_31;
            float val_35;
            float val_36;
            float val_37;
            UpdateHeadingDelegate val_38;
            float val_39;
            float val_40;
            float val_41;
            float val_42;
            float val_43;
            float val_44;
            float val_45;
            var val_49;
            val_28 = deltaTime;
            this.InitPrevFrameStateInfo(curState: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {FieldOfView = curState.<Lens>k__BackingField.FieldOfView, OrthographicSize = curState.<Lens>k__BackingField.OrthographicSize, NearClipPlane = curState.<Lens>k__BackingField.NearClipPlane, FarClipPlane = curState.<Lens>k__BackingField.FarClipPlane, Dutch = curState.<Lens>k__BackingField.Dutch, <Orthographic>k__BackingField = curState.<Lens>k__BackingField.<Orthographic>k__BackingField, <Aspect>k__BackingField = curState.<Lens>k__BackingField.<Aspect>k__BackingField}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z}, <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceLookAt>k__BackingField.x, y = curState.<ReferenceLookAt>k__BackingField.y, z = curState.<ReferenceLookAt>k__BackingField.z}, <RawPosition>k__BackingField = new UnityEngine.Vector3() {x = curState.<RawPosition>k__BackingField.x, y = curState.<RawPosition>k__BackingField.y, z = curState.<RawPosition>k__BackingField.z}}, deltaTime:  val_28);
            if(0 != this.FollowTarget)
            {
                    UnityEngine.Transform val_3 = this.FollowTarget;
                this.<PreviousTarget>k__BackingField = val_3;
                bool val_4 = UnityEngine.Object.op_Equality(x:  0, y:  val_3);
                val_29 = 0;
                val_30 = this;
                if(val_4 != true)
            {
                    val_29 = this.<PreviousTarget>k__BackingField.GetComponent<UnityEngine.Rigidbody>();
                val_30 = (val_4 != true) ? 0 : (this);
            }
            
                mem2[0] = val_29;
                bool val_8 = UnityEngine.Object.op_Equality(x:  0, y:  this.<PreviousTarget>k__BackingField);
                var val_9 = (val_8 != true) ? 0 : (this);
                if(val_8 != false)
            {
                    UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
                val_35 = val_10.x;
                val_36 = val_10.y;
                val_37 = val_10.z;
                val_31 = this;
            }
            else
            {
                    UnityEngine.Vector3 val_11 = this.<PreviousTarget>k__BackingField.position;
                val_35 = val_11.x;
                val_36 = val_11.y;
                val_37 = val_11.z;
            }
            
                mem2[0] = val_35;
                mem2[0] = val_36;
                mem2[0] = val_37;
                this.mHeadingTracker = 0;
            }
            
            val_38 = this.HeadingUpdater;
            val_39 = curState.<ReferenceUp>k__BackingField.y;
            val_40 = val_38.Invoke(orbital:  this, deltaTime:  val_28, up:  new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = val_39, z = curState.<ReferenceUp>k__BackingField.z});
            if((this & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_14 = this.FollowTarget.position;
            this.mLastTargetPosition = val_14;
            mem[1152921511715810996] = val_14.y;
            mem[1152921511715811000] = val_14.z;
            if(null != 5)
            {
                    val_40 = val_40 + val_14.x;
            }
            
            val_38 = 1152921504719839232;
            UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.AngleAxis(angle:  val_40, axis:  new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z});
            val_41 = val_15.x;
            UnityEngine.Vector3 val_16 = this.EffectiveOffset;
            val_42 = val_16.x;
            UnityEngine.Vector3 val_17 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_41, y = val_15.y, z = val_15.z, w = val_15.w}, point:  new UnityEngine.Vector3() {x = val_42, y = val_16.y, z = val_16.z});
            this.TrackTarget(deltaTime:  val_28, up:  new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z}, desiredCameraOffset:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, outTargetPosition: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, outTargetOrient: out  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_43 = 0f;
            val_44 = 0f;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.up;
            val_45 = val_18.y;
            UnityEngine.Vector3 val_19 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_43, y = 0f, z = val_44, w = 0f}, point:  new UnityEngine.Vector3() {x = val_18.x, y = val_45, z = val_18.z});
            curState.<ReferenceUp>k__BackingField.x = val_19.x;
            curState.<ReferenceUp>k__BackingField.y = val_19.y;
            curState.<ReferenceUp>k__BackingField.z = val_19.z;
            if(val_28 >= 0f)
            {
                    UnityEngine.Vector3 val_20 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_41, y = val_15.y, z = val_15.z, w = val_15.w}, point:  new UnityEngine.Vector3() {x = val_42, y = val_16.y, z = val_16.z});
                val_43 = val_20.y;
                UnityEngine.Vector3 val_21 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = this.mHeadingPrevFrame, y = val_20.y, z = V7.16B, w = val_15.w}, point:  new UnityEngine.Vector3() {x = this.mOffsetPrevFrame, y = val_16.y, z = val_16.z});
                val_44 = val_21.x;
                UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_43, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_44, y = val_21.y, z = val_21.z});
                val_45 = val_22.y;
                UnityEngine.Vector3 val_23 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f}, point:  new UnityEngine.Vector3() {x = val_22.x, y = val_45, z = val_22.z});
                val_42 = val_42;
                val_41 = val_41;
                curState.<PositionDampingBypass>k__BackingField.x = val_23.x;
                curState.<PositionDampingBypass>k__BackingField.y = val_23.y;
                curState.<PositionDampingBypass>k__BackingField.z = val_23.z;
            }
            
            val_49 = val_41;
            UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f}, rhs:  new UnityEngine.Quaternion() {x = val_41, y = val_15.y, z = val_15.z, w = val_15.w});
            val_28 = 0f;
            val_39 = 0f;
            UnityEngine.Vector3 val_25 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_24.x, y = val_24.y, z = val_24.z, w = val_24.w}, point:  new UnityEngine.Vector3() {x = val_42, y = val_16.y, z = val_16.z});
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_28, y = 0f, z = val_39}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
            curState.<RawPosition>k__BackingField.x = val_26.x;
            curState.<RawPosition>k__BackingField.y = val_26.y;
            curState.<RawPosition>k__BackingField.z = val_26.z;
            UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.identity;
            val_49 = val_27.x;
            this.mHeadingPrevFrame = val_27;
            this.mOffsetPrevFrame = val_16;
            mem[1152921511715811036] = val_27.y;
            mem[1152921511715811040] = val_27.z;
            mem[1152921511715811044] = val_27.w;
            mem[1152921511715811052] = val_16.y;
            mem[1152921511715811056] = val_16.z;
        }
        public override void OnPositionDragged(UnityEngine.Vector3 delta)
        {
            float val_2;
            float val_3;
            float val_4;
            Cinemachine.CameraState val_1 = this.VcamState;
            UnityEngine.Quaternion val_5 = this.GetReferenceOrientation(worldUp:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w});
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, point:  new UnityEngine.Vector3() {x = delta.x, y = delta.y, z = delta.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.y, y = val_5.x, z = delta.x}, b:  new UnityEngine.Vector3() {x = 0f, y = val_7.y, z = val_7.z});
            mem[1152921511716009300] = val_8.x;
            mem[1152921511716009304] = val_8.y;
            mem[1152921511716009308] = val_8.z;
            UnityEngine.Vector3 val_9 = this.EffectiveOffset;
            mem[1152921511716009300] = val_9.x;
            mem[1152921511716009304] = val_9.y;
            mem[1152921511716009308] = val_9.z;
        }
        private static string GetFullName(UnityEngine.GameObject current)
        {
            var val_10;
            if(0 == X1)
            {
                    val_10 = null;
                val_10 = null;
                return (string)System.String.Empty;
            }
            
            if(0 == X1.transform.parent)
            {
                    string val_5 = X1.name;
                return 0 + "/"("/");
            }
            
            string val_9 = X1.name;
            return 0 + X1.transform.parent.gameObject + "/"("/");
        }
        private float GetTargetHeading(float currentHeading, UnityEngine.Quaternion targetOrientation, float deltaTime)
        {
            float val_31;
            float val_32;
            HeadingTracker val_33;
            var val_34;
            var val_35;
            HeadingTracker val_37;
            float val_38;
            float val_39;
            float val_40;
            val_31 = targetOrientation.z;
            val_32 = targetOrientation.x;
            val_33 = this;
            val_34 = 0f;
            if(true == 5)
            {
                    return (float)val_34;
            }
            
            val_35 = 1152921504721543168;
            if(0 == this.FollowTarget)
            {
                    val_34 = currentHeading;
                return (float)val_34;
            }
            
            if(this.m_Heading == 1)
            {
                    if(0 == this.mTargetRigidBody)
            {
                    val_35 = this.FollowTarget;
                string val_9 = System.String.Format(format:  0, arg0:  "Attempted to use HeadingDerivationMode.Velocity to calculate heading for {0}. No RigidBody was present on \'{1}\'. Defaulting to position delta", arg1:  Cinemachine.CinemachineOrbitalTransposer.GetFullName(current:  this.VirtualCamera.VirtualCameraGameObject));
                UnityEngine.Debug.Log(message:  0);
                this.m_Heading = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            var val_11 = (this.m_Heading < 4) ? UnityEngine.Debug.__il2cppRuntimeField_cctor_finished : 0;
            if(val_11 == 18)
            {
                goto label_17;
            }
            
            if(val_11 == 17)
            {
                goto label_18;
            }
            
            if(val_11 != 16)
            {
                    return (float)val_34;
            }
            
            UnityEngine.Vector3 val_13 = this.FollowTarget.position;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = this.mLastTargetPosition, y = V11.16B, z = val_32});
            goto label_25;
            label_17:
            UnityEngine.Vector3 val_16 = this.FollowTarget.forward;
            goto label_25;
            label_18:
            UnityEngine.Vector3 val_17 = this.mTargetRigidBody.velocity;
            label_25:
            if(this.mHeadingTracker != null)
            {
                    val_37 = this.mHeadingTracker;
            }
            else
            {
                    CinemachineOrbitalTransposer.HeadingTracker val_19 = null;
                val_37 = val_19;
                val_19 = new CinemachineOrbitalTransposer.HeadingTracker(filterSize:  (UnityEngine.Debug.__il2cppRuntimeField_cctor_finished + (UnityEngine.Debug.__il2cppRuntimeField_cctor_finished) << 2));
                this.mHeadingTracker = val_37;
            }
            
            DecayHistory();
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.up;
            val_35 = 1152921504719839232;
            UnityEngine.Vector3 val_21 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_32, y = targetOrientation.y, z = val_31, w = targetOrientation.w}, point:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            val_32 = val_21.z;
            val_38 = val_17.x;
            val_39 = val_17.y;
            val_40 = val_17.z;
            UnityEngine.Vector3 val_22 = Cinemachine.Utility.UnityVectorExtensions.ProjectOntoPlane(vector:  new UnityEngine.Vector3() {x = val_38, y = val_39, z = val_40}, planeNormal:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_32});
            if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z})) != true)
            {
                    val_38 = val_22.x;
                val_39 = val_22.y;
                val_40 = val_22.z;
                this.mHeadingTracker.Add(velocity:  new UnityEngine.Vector3() {x = val_38, y = val_39, z = val_40});
            }
            
            val_33 = this.mHeadingTracker;
            UnityEngine.Vector3 val_25 = val_33.GetReliableHeading();
            val_31 = val_25.x;
            val_34 = currentHeading;
            if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z})) != false)
            {
                    return (float)val_34;
            }
            
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_29 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_32, y = targetOrientation.y, z = val_31, w = targetOrientation.w}, point:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            float val_30 = Cinemachine.Utility.UnityVectorExtensions.SignedAngle(from:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, to:  new UnityEngine.Vector3() {x = val_31, y = val_25.y, z = val_25.z}, refNormal:  new UnityEngine.Vector3() {x = val_21.x, y = val_32, z = val_21.x});
            return (float)val_34;
        }
        private static float <HeadingUpdater>m__0(Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, UnityEngine.Vector3 up)
        {
            return X1.UpdateHeading(deltaTime:  deltaTime, up:  new UnityEngine.Vector3() {x = up.x, y = up.y, z = up.z}, axis: ref  new Cinemachine.AxisState() {Value = X1 + 160, m_MaxSpeed = X1 + 160, m_AccelTime = X1 + 160, m_DecelTime = X1 + 160, m_InputAxisName = X1 + 160, m_InputAxisValue = X1 + 160, m_InvertAxis = X1 + 160, mCurrentSpeed = X1 + 160, mMinValue = X1 + 160, mMaxValue = X1 + 160, mWrapAround = X1 + 160});
        }
    
    }

}
