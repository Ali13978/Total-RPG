using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineTransposer : CinemachineComponentBase
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineTransposer.BindingMode m_BindingMode;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Vector3 m_FollowOffset;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_XDamping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_YDamping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_ZDamping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_PitchDamping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_YawDamping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_RollDamping;
        private UnityEngine.Vector3 m_PreviousTargetPosition;
        private UnityEngine.Quaternion m_PreviousReferenceOrientation;
        private UnityEngine.Quaternion m_targetOrientationOnAssign;
        private UnityEngine.Transform m_previousTarget;
        
        // Properties
        protected UnityEngine.Vector3 EffectiveOffset { get; }
        public override bool IsValid { get; }
        public override Cinemachine.CinemachineCore.Stage Stage { get; }
        protected UnityEngine.Vector3 Damping { get; }
        protected UnityEngine.Vector3 AngularDamping { get; }
        
        // Methods
        public CinemachineTransposer()
        {
            this.m_BindingMode = 1;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.back;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  10f);
            this.m_FollowOffset = val_2;
            mem[1152921511721583992] = val_2.y;
            mem[1152921511721583996] = val_2.z;
            this.m_XDamping = 1f;
            this.m_YDamping = 1f;
            this.m_ZDamping = 1f;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.m_PreviousTargetPosition = val_3;
            mem[1152921511721584028] = val_3.y;
            mem[1152921511721584032] = val_3.z;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            this.m_PreviousReferenceOrientation = val_4;
            mem[1152921511721584040] = val_4.y;
            mem[1152921511721584044] = val_4.z;
            mem[1152921511721584048] = val_4.w;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            this.m_targetOrientationOnAssign = val_5;
            mem[1152921511721584056] = val_5.y;
            mem[1152921511721584060] = val_5.z;
            mem[1152921511721584064] = val_5.w;
        }
        protected virtual void OnValidate()
        {
            UnityEngine.Vector3 val_1 = this.EffectiveOffset;
            this.m_FollowOffset = val_1;
            mem[1152921511721695992] = val_1.y;
            mem[1152921511721695996] = val_1.z;
        }
        protected UnityEngine.Vector3 get_EffectiveOffset()
        {
            var val_1;
            if(this.m_BindingMode != 5)
            {
                    return new UnityEngine.Vector3() {x = this.m_FollowOffset, y = V8.16B, z = V9.16B};
            }
            
            val_1 = -System.Math.Abs(S9);
            return new UnityEngine.Vector3() {x = this.m_FollowOffset, y = V8.16B, z = V9.16B};
        }
        public override bool get_IsValid()
        {
            if(this.enabled == false)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  0, y:  this.FollowTarget);
        }
        public override Cinemachine.CinemachineCore.Stage get_Stage()
        {
            return 0;
        }
        public override void MutateCameraState(ref Cinemachine.CameraState curState, float deltaTime)
        {
            float val_6 = deltaTime;
            this.InitPrevFrameStateInfo(curState: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {FieldOfView = curState.<Lens>k__BackingField.FieldOfView, OrthographicSize = curState.<Lens>k__BackingField.OrthographicSize, NearClipPlane = curState.<Lens>k__BackingField.NearClipPlane, FarClipPlane = curState.<Lens>k__BackingField.FarClipPlane, Dutch = curState.<Lens>k__BackingField.Dutch, <Orthographic>k__BackingField = curState.<Lens>k__BackingField.<Orthographic>k__BackingField, <Aspect>k__BackingField = curState.<Lens>k__BackingField.<Aspect>k__BackingField}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z}, <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceLookAt>k__BackingField.x, y = curState.<ReferenceLookAt>k__BackingField.y, z = curState.<ReferenceLookAt>k__BackingField.z}, <RawPosition>k__BackingField = new UnityEngine.Vector3() {x = curState.<RawPosition>k__BackingField.x, y = curState.<RawPosition>k__BackingField.y, z = curState.<RawPosition>k__BackingField.z}}, deltaTime:  val_6 = deltaTime);
            if((this & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this.EffectiveOffset;
            this.TrackTarget(deltaTime:  val_6, up:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, desiredCameraOffset:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, outTargetPosition: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, outTargetOrient: out  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_6 = 0f;
            UnityEngine.Vector3 val_2 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6, y = 0f, z = 0f, w = 0f}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6, y = 0f, z = 0f, w = 0f}, point:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        public override void OnPositionDragged(UnityEngine.Vector3 delta)
        {
            Cinemachine.CameraState val_1 = this.VcamState;
            UnityEngine.Quaternion val_2 = this.GetReferenceOrientation(worldUp:  new UnityEngine.Vector3() {x = delta.x, y = delta.y, z = delta.z});
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, point:  new UnityEngine.Vector3() {x = delta.x, y = delta.y, z = delta.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.m_FollowOffset, y = val_2.y, z = val_2.x}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            this.m_FollowOffset = val_5;
            mem[1152921511722346856] = val_5.y;
            mem[1152921511722346860] = val_5.z;
            UnityEngine.Vector3 val_6 = this.EffectiveOffset;
            this.m_FollowOffset = val_6;
            mem[1152921511722346856] = val_6.y;
            mem[1152921511722346860] = val_6.z;
        }
        protected void InitPrevFrameStateInfo(ref Cinemachine.CameraState curState, float deltaTime)
        {
            UnityEngine.Transform val_10;
            var val_11;
            float val_15;
            float val_16;
            float val_17;
            float val_18;
            val_10 = this.m_previousTarget;
            UnityEngine.Transform val_1 = this.FollowTarget;
            if(deltaTime >= 0)
            {
                    if(0 == val_10)
            {
                goto label_4;
            }
            
            }
            
            val_10 = this.FollowTarget;
            this.m_previousTarget = val_10;
            bool val_4 = UnityEngine.Object.op_Equality(x:  0, y:  val_10);
            var val_5 = (val_4 != true) ? 0 : (this);
            if(val_4 != false)
            {
                    UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
                val_15 = val_6.x;
                val_16 = val_6.y;
                val_17 = val_6.z;
                val_18 = val_6.w;
                val_11 = this;
            }
            else
            {
                    val_10 = this.FollowTarget;
                UnityEngine.Quaternion val_8 = val_10.rotation;
                val_15 = val_8.x;
                val_16 = val_8.y;
                val_17 = val_8.z;
                val_18 = val_8.w;
            }
            
            mem2[0] = val_15;
            mem2[0] = val_16;
            mem2[0] = val_17;
            mem2[0] = val_18;
            label_4:
            if(deltaTime >= 0)
            {
                    return;
            }
            
            this.m_PreviousTargetPosition = val_8.x;
            mem[1152921511722524924] = val_8.y;
            mem[1152921511722524928] = val_8.z;
            UnityEngine.Quaternion val_9 = this.GetReferenceOrientation(worldUp:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            this.m_PreviousReferenceOrientation = val_9;
            mem[1152921511722524936] = val_9.y;
            mem[1152921511722524940] = val_9.z;
            mem[1152921511722524944] = val_9.w;
        }
        protected void TrackTarget(float deltaTime, UnityEngine.Vector3 up, UnityEngine.Vector3 desiredCameraOffset, out UnityEngine.Vector3 outTargetPosition, out UnityEngine.Quaternion outTargetOrient)
        {
            float val_20;
            float val_21;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            UnityEngine.Vector3 val_30;
            float val_31;
            float val_32;
            float val_36;
            float val_37;
            float val_38;
            float val_39;
            float val_40;
            float val_41;
            float val_47;
            UnityEngine.Vector3 val_51;
            float val_52;
            val_20 = up.y;
            val_21 = up.z;
            UnityEngine.Quaternion val_1 = this.GetReferenceOrientation(worldUp:  new UnityEngine.Vector3() {x = up.x, y = val_20, z = val_21});
            val_23 = val_1.x;
            val_24 = deltaTime;
            val_25 = val_1.y;
            val_26 = val_1.z;
            val_27 = val_1.w;
            if(val_24 >= 0f)
            {
                    val_28 = this.m_PreviousReferenceOrientation;
                UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_28, y = up.x, z = up.y, w = up.z});
                UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, rhs:  new UnityEngine.Quaternion() {x = val_23, y = val_25, z = val_26, w = val_27});
                var val_20 = 0;
                do
            {
                if(val_3.x > 180f)
            {
                    val_28 = val_3.x + (-360f);
            }
            
                val_20 = val_20 + 1;
            }
            while(val_20 != 3);
            
                UnityEngine.Vector3 val_4 = this.AngularDamping;
                UnityEngine.Vector3 val_5 = Cinemachine.Utility.Damper.Damp(initial:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, dampTime:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, deltaTime:  deltaTime);
                UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
                val_24 = this.m_PreviousReferenceOrientation;
                val_20 = val_25;
                val_21 = val_23;
                UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_24, y = val_20, z = val_21, w = val_3.x}, rhs:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w});
                val_23 = val_7.x;
                val_25 = val_7.y;
                val_26 = val_7.z;
                val_27 = val_7.w;
            }
            
            this.m_PreviousReferenceOrientation = val_1;
            mem[1152921511722715320] = val_25;
            mem[1152921511722715324] = val_26;
            mem[1152921511722715328] = val_27;
            UnityEngine.Vector3 val_9 = this.FollowTarget.position;
            val_30 = this.m_PreviousTargetPosition;
            val_30 = val_30;
            val_31 = desiredCameraOffset.y;
            val_27 = val_27;
            val_29 = ???;
            val_32 = val_9.z;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_32}, b:  new UnityEngine.Vector3() {x = val_30, y = val_29, z = val_31});
            val_36 = val_10.x;
            val_37 = deltaTime;
            val_38 = val_10.y;
            val_39 = val_10.z;
            if(val_37 >= 0f)
            {
                    val_40 = 9.999999E-09f;
                if(val_37 < 0)
            {
                    Cinemachine.CameraState val_11 = this.VcamState;
            }
            else
            {
                    val_40 = val_25;
                val_37 = val_23;
                val_41 = val_26;
                UnityEngine.Vector3 val_12 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_37, y = val_40, z = val_41, w = val_27}, point:  new UnityEngine.Vector3() {x = val_37, y = val_40, z = val_10.z});
                val_30 = up.x;
                UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, upwards:  new UnityEngine.Vector3() {x = val_30, y = up.y, z = up.z});
            }
            
                UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w});
                UnityEngine.Vector3 val_15 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w}, point:  new UnityEngine.Vector3() {x = val_36, y = val_38, z = val_39});
                UnityEngine.Vector3 val_16 = this.Damping;
                UnityEngine.Vector3 val_17 = Cinemachine.Utility.Damper.Damp(initial:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, dampTime:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, deltaTime:  deltaTime);
                val_47 = val_13.z;
                UnityEngine.Vector3 val_18 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_47, w = val_13.w}, point:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
                val_25 = val_25;
                val_23 = val_23;
                val_26 = val_26;
                val_29 = val_29;
                val_36 = val_18.x;
                val_38 = val_18.y;
                val_39 = val_18.z;
            }
            
            val_51 = val_30;
            val_52 = val_31;
            val_51 = val_51;
            val_38 = val_38;
            val_39 = val_39;
            val_52 = val_52;
            val_27 = val_27;
            val_29 = val_29;
            val_36 = val_36;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_51, y = val_29, z = val_52}, b:  new UnityEngine.Vector3() {x = val_36, y = val_38, z = val_39});
            this.m_PreviousTargetPosition = val_19;
            mem[1152921511722715308] = val_19.y;
            mem[1152921511722715312] = val_19.z;
            outTargetPosition.x = val_19.x;
            outTargetPosition.y = val_19.y;
            outTargetPosition.z = val_19.z;
            outTargetOrient.x = val_23;
            outTargetOrient.y = val_25;
            outTargetOrient.z = val_26;
            outTargetOrient.w = val_27;
        }
        protected UnityEngine.Vector3 get_Damping()
        {
            if(this.m_BindingMode == 5)
            {
                
            }
            
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        protected UnityEngine.Vector3 get_AngularDamping()
        {
            if(this.m_BindingMode <= 5)
            {
                    if((25806528 + (this.m_BindingMode) << 2) > 6)
            {
                    return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
                var val_1 = 25806080 + (25806528 + (this.m_BindingMode) << 2) << 2;
                val_1 = val_1 + 25806080;
            }
            else
            {
                    return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
        
        }
        public UnityEngine.Vector3 GeTargetCameraPosition(UnityEngine.Vector3 worldUp)
        {
            if((0 & 1) == 0)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            UnityEngine.Vector3 val_2 = 0.FollowTarget.position;
            UnityEngine.Quaternion val_3 = this.GetReferenceOrientation(worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z});
            UnityEngine.Vector3 val_4 = this.EffectiveOffset;
            UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, point:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        }
        public UnityEngine.Quaternion GetReferenceOrientation(UnityEngine.Vector3 worldUp)
        {
            UnityEngine.Quaternion val_20;
            float val_21;
            float val_22;
            float val_23;
            if(0 != this.FollowTarget)
            {
                    UnityEngine.Quaternion val_4 = this.FollowTarget.rotation;
                BindingMode val_16 = this.m_BindingMode;
                val_20 = val_4.x;
                val_21 = val_4.y;
                val_22 = val_4.z;
                val_23 = val_4.w;
                val_16 = (val_16 < 6) ? (val_16 + 6) : 0;
                if(val_16 > 11)
            {
                    return new UnityEngine.Quaternion() {x = val_20, y = val_21, z = val_22, w = val_23};
            }
            
                var val_17 = 25806032 + (this.m_BindingMode < 0x6 ? (this.m_BindingMode + 6) : 0) << 2;
                val_17 = val_17 + 25806032;
            }
            else
            {
                    UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
                val_20 = val_13.x;
                val_21 = val_13.y;
                val_22 = val_13.z;
                val_23 = val_13.w;
                return new UnityEngine.Quaternion() {x = val_20, y = val_21, z = val_22, w = val_23};
            }
        
        }
        private static UnityEngine.Quaternion Uppify(UnityEngine.Quaternion q, UnityEngine.Vector3 up)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_2 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = q.x, y = q.y, z = q.z, w = q.w}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, toDirection:  new UnityEngine.Vector3() {x = up.x, y = up.y, z = up.z});
            return UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, rhs:  new UnityEngine.Quaternion() {x = q.x, y = q.y, z = q.z, w = q.w});
        }
    
    }

}
