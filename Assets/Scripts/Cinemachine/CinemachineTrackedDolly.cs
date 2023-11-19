using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineTrackedDolly : CinemachineComponentBase
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachinePathBase m_Path;
        [UnityEngine.TooltipAttribute]
        public float m_PathPosition;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachinePathBase.PositionUnits m_PositionUnits;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Vector3 m_PathOffset;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_XDamping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_YDamping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_ZDamping;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineTrackedDolly.CameraUpMode m_CameraUp;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_PitchDamping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_YawDamping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_RollDamping;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineTrackedDolly.AutoDolly m_AutoDolly;
        private float m_PreviousPathPosition;
        private UnityEngine.Quaternion m_PreviousOrientation;
        private UnityEngine.Vector3 m_PreviousCameraPosition;
        
        // Properties
        public override bool IsValid { get; }
        public override Cinemachine.CinemachineCore.Stage Stage { get; }
        private UnityEngine.Vector3 AngularDamping { get; }
        
        // Methods
        public CinemachineTrackedDolly()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.m_PathOffset = val_1;
            mem[1152921511720482692] = val_1.y;
            mem[1152921511720482696] = val_1.z;
            this.m_ZDamping = 1f;
            this.m_AutoDolly = 0;
            mem[1152921511720482736] = 2;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            this.m_PreviousOrientation = val_2;
            mem[1152921511720482752] = val_2.y;
            mem[1152921511720482756] = val_2.z;
            mem[1152921511720482760] = val_2.w;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.m_PreviousCameraPosition = val_3;
            mem[1152921511720482768] = val_3.y;
            mem[1152921511720482772] = val_3.z;
        }
        public override bool get_IsValid()
        {
            if(this.enabled == false)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  0, y:  this.m_Path);
        }
        public override Cinemachine.CinemachineCore.Stage get_Stage()
        {
            return 0;
        }
        public override void MutateCameraState(ref Cinemachine.CameraState curState, float deltaTime)
        {
            Cinemachine.CinemachinePathBase val_44;
            float val_45;
            float val_47;
            float val_48;
            float val_49;
            Cinemachine.CinemachinePathBase val_50;
            PositionUnits val_51;
            float val_52;
            float val_53;
            float val_57;
            float val_58;
            float val_59;
            float val_60;
            float val_62;
            float val_63;
            float val_64;
            float val_65;
            float val_66;
            val_45 = deltaTime;
            if(val_45 < 0)
            {
                    this.m_PreviousPathPosition = this.m_PathPosition;
                this.m_PreviousCameraPosition = deltaTime;
                mem[1152921511720888656] = ???;
                mem[1152921511720888660] = ???;
            }
            
            if((this & 1) == 0)
            {
                    return;
            }
            
            if((this.m_AutoDolly != 0) && (0 != this.FollowTarget))
            {
                    UnityEngine.Vector3 val_6 = this.FollowTarget.transform.position;
                int val_7 = UnityEngine.Mathf.FloorToInt(f:  this.m_Path.GetPathPositionFromDistance(distance:  this.m_PreviousPathPosition));
                if(val_45 >= 0)
            {
                    var val_8 = (UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished > 0) ? UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished : 0;
            }
            
                val_47 = val_6.y;
                val_48 = val_6.z;
                this.m_PathPosition = val_6.x;
                if(this.m_PositionUnits == 1)
            {
                    float val_9 = this.m_Path.GetPathDistanceFromPosition(pos:  val_6.x);
                this.m_PathPosition = val_9;
            }
            
                val_9 = val_9 + val_9;
                this.m_PathPosition = val_9;
            }
            
            val_49 = this.m_PathPosition;
            if(val_45 < 0f)
            {
                goto label_17;
            }
            
            val_50 = this;
            val_51 = 1152921511720888560;
            float val_10 = this.m_Path.MaxUnit(units:  this.m_PositionUnits);
            val_52 = this;
            if(val_10 <= 0f)
            {
                goto label_30;
            }
            
            float val_47 = this.m_PreviousPathPosition;
            float val_44 = val_49;
            if((this.m_Path & 1) == 0)
            {
                goto label_28;
            }
            
            val_44 = val_44 - val_47;
            float val_46 = 0.5f;
            val_46 = val_10 * val_46;
            if(System.Math.Abs(val_44) <= val_46)
            {
                goto label_28;
            }
            
            if(val_44 <= val_47)
            {
                goto label_27;
            }
            
            val_47 = val_10 + val_47;
            goto label_28;
            label_17:
            val_52 = this.m_PreviousPathPosition;
            val_50 = this.m_Path;
            val_51 = this.m_PositionUnits;
            goto label_29;
            label_27:
            val_47 = val_47 - val_10;
            label_28:
            this.m_PreviousPathPosition = val_47;
            label_30:
            val_48 = val_45;
            val_47 = this.m_PreviousPathPosition;
            val_49 = val_47 - (Cinemachine.Utility.Damper.Damp(initial:  val_47 - val_44, dampTime:  this.m_ZDamping, deltaTime:  val_48));
            label_29:
            this.m_PreviousPathPosition = val_49;
            UnityEngine.Quaternion val_13 = this.m_Path.EvaluateOrientationAtUnit(pos:  val_49, units:  this.m_PositionUnits);
            val_44 = this.m_Path;
            UnityEngine.Vector3 val_14 = val_44.EvaluatePositionAtUnit(pos:  val_49, units:  this.m_PositionUnits);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_16 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w}, point:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_18 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w}, point:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_53 = val_18.z;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_20 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w}, point:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(d:  this.m_PathOffset, a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(d:  val_22.x, a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_53});
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(d:  val_24.x, a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
            val_57 = val_45;
            val_58 = val_26.x;
            val_59 = val_26.y;
            val_60 = val_26.z;
            if(val_57 >= 0f)
            {
                    UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.m_PreviousCameraPosition, y = val_20.z, z = val_57}, b:  new UnityEngine.Vector3() {x = val_58, y = val_59, z = val_60});
                UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, rhs:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_53}), a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_53});
                UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
                val_53 = val_45;
                UnityEngine.Vector3 val_31 = Cinemachine.Utility.Damper.Damp(initial:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, dampTime:  this.m_XDamping, deltaTime:  val_53);
                val_57 = val_53;
                UnityEngine.Vector3 val_32 = Cinemachine.Utility.Damper.Damp(initial:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, dampTime:  this.m_YDamping, deltaTime:  val_57);
                UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
                UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.m_PreviousCameraPosition, y = val_20.z, z = val_57}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
                val_58 = val_34.x;
                val_59 = val_34.y;
                val_60 = val_34.z;
            }
            
            this.m_PreviousCameraPosition = val_34;
            mem[1152921511720888656] = val_59;
            mem[1152921511720888660] = val_60;
            UnityEngine.Quaternion val_35 = this.GetTargetOrientationAtPathPoint(pathOrientation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w}, up:  new UnityEngine.Vector3() {x = val_58, y = val_59, z = val_60});
            val_62 = val_35.x;
            val_63 = val_35.y;
            val_64 = val_35.z;
            val_65 = val_35.w;
            if((val_57 >= 0) && (val_57 >= 0f))
            {
                    val_66 = this.m_PreviousOrientation;
                UnityEngine.Quaternion val_36 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_66, y = val_53, z = val_29.z, w = val_57});
                UnityEngine.Quaternion val_37 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_36.x, y = val_36.y, z = val_36.z, w = val_36.w}, rhs:  new UnityEngine.Quaternion() {x = val_62, y = val_63, z = val_64, w = val_65});
                do
            {
                if(val_37.x > 180f)
            {
                    val_66 = val_37.x + (-360f);
            }
            
                val_44 = 0 + 1;
            }
            while(val_44 != 3);
            
                UnityEngine.Vector3 val_38 = this.AngularDamping;
                UnityEngine.Vector3 val_39 = Cinemachine.Utility.Damper.Damp(initial:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, dampTime:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, deltaTime:  val_57);
                UnityEngine.Quaternion val_40 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
                UnityEngine.Quaternion val_41 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = this.m_PreviousOrientation, y = val_29.z, z = val_57, w = val_37.x}, rhs:  new UnityEngine.Quaternion() {x = val_40.x, y = val_40.y, z = val_40.z, w = val_40.w});
                val_62 = val_41.x;
                val_63 = val_41.y;
                val_64 = val_41.z;
                val_65 = val_41.w;
            }
            
            this.m_PreviousOrientation = val_41;
            mem[1152921511720888640] = val_63;
            mem[1152921511720888644] = val_64;
            mem[1152921511720888648] = val_65;
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.up;
            val_45 = val_42.x;
            UnityEngine.Vector3 val_43 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_62, y = val_63, z = val_64, w = val_65}, point:  new UnityEngine.Vector3() {x = val_45, y = val_42.y, z = val_42.z});
        }
        public override void OnPositionDragged(UnityEngine.Vector3 delta)
        {
            UnityEngine.Quaternion val_1 = this.m_Path.EvaluateOrientationAtUnit(pos:  this.m_PathPosition, units:  this.m_PositionUnits);
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
            UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, point:  new UnityEngine.Vector3() {x = delta.x, y = delta.y, z = delta.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.m_PathOffset, y = val_1.y, z = val_1.x}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.m_PathOffset = val_4;
            mem[1152921511721070468] = val_4.y;
            mem[1152921511721070472] = val_4.z;
        }
        private UnityEngine.Quaternion GetTargetOrientationAtPathPoint(UnityEngine.Quaternion pathOrientation, UnityEngine.Vector3 up)
        {
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            var val_24;
            val_18 = up.z;
            val_19 = up.y;
            val_20 = pathOrientation.w;
            val_21 = pathOrientation.z;
            val_22 = pathOrientation.y;
            val_23 = pathOrientation.x;
            val_24 = this;
            CameraUpMode val_18 = this.m_CameraUp;
            val_18 = (val_18 < 5) ? (val_18 + 3) : 0;
            if(val_18 > 7)
            {
                    return new UnityEngine.Quaternion() {};
            }
            
            var val_19 = 25805976 + (this.m_CameraUp < 0x5 ? (this.m_CameraUp + 3) : 0) << 2;
            val_19 = val_19 + 25805976;
            goto (25805976 + (this.m_CameraUp < 0x5 ? (this.m_CameraUp + 3) : 0) << 2 + 25805976);
        }
        private UnityEngine.Vector3 get_AngularDamping()
        {
            CameraUpMode val_1 = this.m_CameraUp >> 32;
            if(this.m_CameraUp <= 4)
            {
                    if((25806496 + this.m_CameraUp) > 5)
            {
                    return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
                var val_2 = 25806008 + (25806496 + this.m_CameraUp) << 2;
                val_2 = val_2 + 25806008;
            }
            else
            {
                    return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
        
        }
    
    }

}
