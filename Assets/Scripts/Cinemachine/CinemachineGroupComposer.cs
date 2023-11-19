using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineGroupComposer : CinemachineComposer
    {
        // Fields
        [UnityEngine.SpaceAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_GroupFramingSize;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineGroupComposer.FramingMode m_FramingMode;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_FrameDamping;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode;
        [UnityEngine.TooltipAttribute]
        public float m_MaxDollyIn;
        [UnityEngine.TooltipAttribute]
        public float m_MaxDollyOut;
        [UnityEngine.TooltipAttribute]
        public float m_MinimumDistance;
        [UnityEngine.TooltipAttribute]
        public float m_MaximumDistance;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_MinimumFOV;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_MaximumFOV;
        [UnityEngine.TooltipAttribute]
        public float m_MinimumOrthoSize;
        [UnityEngine.TooltipAttribute]
        public float m_MaximumOrthoSize;
        private float m_prevTargetHeight;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Bounds <m_LastBounds>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Matrix4x4 <m_lastBoundsMatrix>k__BackingField;
        
        // Properties
        public Cinemachine.CinemachineTargetGroup TargetGroup { get; }
        public UnityEngine.Bounds m_LastBounds { get; set; }
        public UnityEngine.Matrix4x4 m_lastBoundsMatrix { get; set; }
        
        // Methods
        public CinemachineGroupComposer()
        {
            this.m_GroupFramingSize = 0.8f;
            this.m_MaxDollyIn = ;
            this.m_MaxDollyOut = ;
            this.m_MinimumDistance = 1f;
            this.m_MaximumDistance = 5000f;
            this.m_FramingMode = 2;
            this.m_FrameDamping = 2f;
            this.m_AdjustmentMode = 2;
            this.m_MinimumFOV = ;
            this.m_MaximumFOV = ;
            this.m_MinimumOrthoSize = 1f;
            this.m_MaximumOrthoSize = 100f;
        }
        private void OnValidate()
        {
            this.m_GroupFramingSize = UnityEngine.Mathf.Max(a:  0.0001f, b:  this.m_GroupFramingSize);
            this.m_MaxDollyIn = UnityEngine.Mathf.Max(a:  0f, b:  this.m_MaxDollyIn);
            this.m_MaxDollyOut = UnityEngine.Mathf.Max(a:  0f, b:  this.m_MaxDollyOut);
            float val_4 = UnityEngine.Mathf.Max(a:  0f, b:  this.m_MinimumDistance);
            this.m_MinimumDistance = val_4;
            this.m_MaximumDistance = UnityEngine.Mathf.Max(a:  val_4, b:  this.m_MaximumDistance);
            float val_6 = UnityEngine.Mathf.Max(a:  1f, b:  this.m_MinimumFOV);
            this.m_MinimumFOV = val_6;
            this.m_MaximumFOV = UnityEngine.Mathf.Clamp(value:  this.m_MaximumFOV, min:  val_6, max:  179f);
            float val_8 = UnityEngine.Mathf.Max(a:  0.01f, b:  this.m_MinimumOrthoSize);
            this.m_MinimumOrthoSize = val_8;
            this.m_MaximumOrthoSize = UnityEngine.Mathf.Max(a:  val_8, b:  this.m_MaximumOrthoSize);
        }
        public Cinemachine.CinemachineTargetGroup get_TargetGroup()
        {
            var val_4;
            UnityEngine.Transform val_1 = this.LookAtTarget;
            val_4 = 0;
            if(0 == val_1)
            {
                    return (Cinemachine.CinemachineTargetGroup)val_1.GetComponent<Cinemachine.CinemachineTargetGroup>();
            }
            
            return (Cinemachine.CinemachineTargetGroup)val_1.GetComponent<Cinemachine.CinemachineTargetGroup>();
        }
        public override void MutateCameraState(ref Cinemachine.CameraState curState, float deltaTime)
        {
            float val_12;
            float val_18;
            float val_19;
            float val_20;
            UnityEngine.Matrix4x4 val_21;
            float val_23;
            UnityEngine.Bounds val_24;
            var val_41;
            var val_42;
            UnityEngine.Object val_43;
            float val_44;
            float val_45;
            float val_46;
            float val_52;
            float val_53;
            float val_54;
            float val_56;
            float val_57;
            val_41 = 1152921511713165424;
            val_42 = this;
            val_43 = this.TargetGroup;
            if(0 == val_43)
            {
                goto label_32;
            }
            
            if((this.IsValid == false) || ((0 & 1) == 0))
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_5 = val_43.transform.position;
            UnityEngine.Vector3 val_6 = this.GetLookAtPointAndSetTrackedPoint(lookAt:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            curState.<ReferenceLookAt>k__BackingField.x = val_6.x;
            curState.<ReferenceLookAt>k__BackingField.y = val_6.y;
            curState.<ReferenceLookAt>k__BackingField.z = val_6.z;
            val_46 = curState.<RawPosition>k__BackingField.x;
            val_45 = curState.<RawPosition>k__BackingField.y;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V14.16B, y = V13.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_46, y = val_45, z = curState.<RawPosition>k__BackingField.z});
            if(val_7.x < 0)
            {
                    return;
            }
            
            if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) == false)
            {
                goto label_11;
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.forward;
            goto label_14;
            label_5:
            this.m_prevTargetHeight = 0f;
            return;
            label_11:
            label_14:
            UnityEngine.Bounds val_10 = val_43.BoundingBox;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_12);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, upwards:  new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z});
            val_46 = val_15.z;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
            val_53 = val_14.y;
            val_52 = val_14.x;
            val_54 = val_14.z;
            UnityEngine.Matrix4x4 val_17 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_52, y = val_53, z = val_54}, q:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_46, w = val_15.w}, s:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.z, z = val_7.z});
            mem[1152921511713133716] = val_18;
            mem[1152921511713133700] = val_19;
            mem[1152921511713133684] = val_20;
            this.<m_lastBoundsMatrix>k__BackingField = val_21;
            UnityEngine.Bounds val_22 = val_43.GetViewSpaceBoundingBox(mView:  new UnityEngine.Matrix4x4() {m00 = val_21, m10 = val_21, m20 = val_21, m30 = val_21, m01 = val_20, m11 = val_20, m21 = val_20, m31 = val_20, m02 = val_19, m12 = val_19, m22 = val_19, m32 = val_19, m03 = val_18, m13 = val_18, m23 = val_18, m33 = val_18});
            mem[1152921511713133660] = val_23;
            this.<m_LastBounds>k__BackingField = val_24;
            float val_25 = this.GetTargetHeight(b:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_24, y = val_24, z = val_24}, m_Extents = new UnityEngine.Vector3() {x = val_24, y = val_23, z = val_23}});
            val_56 = val_25;
            val_44 = val_25;
            val_45 = val_20;
            if(deltaTime >= 0f)
            {
                    val_52 = val_56 - this.m_prevTargetHeight;
                val_54 = deltaTime;
                val_53 = this.m_prevTargetHeight;
                val_56 = (Cinemachine.Utility.Damper.Damp(initial:  val_52, dampTime:  this.m_FrameDamping, deltaTime:  val_54)) + val_53;
            }
            
            this.m_prevTargetHeight = val_56;
            val_43 = this.<m_LastBounds>k__BackingField;
            if(((((curState.<Lens>k__BackingField.FieldOfView.Size) & 1) & 1) == 0) && (this.m_AdjustmentMode != 0))
            {
                    float val_42 = curState.<Lens>k__BackingField.FieldOfView;
                float val_41 = 0.01745329f;
                val_41 = val_42 * val_41;
                val_41 = val_41 * 0.5f;
                val_41 = val_41 + val_41;
                val_42 = val_56 / val_41;
                float val_43 = this.m_MaxDollyIn;
                val_41 = val_42 + val_54;
                float val_44 = val_7.x;
                val_43 = val_44 - val_43;
                val_44 = val_44 + this.m_MaxDollyOut;
                val_46 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.Clamp(value:  val_41, min:  val_43, max:  val_44), min:  this.m_MinimumDistance, max:  this.m_MaximumDistance);
                UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_46);
                UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_44, y = this.<m_LastBounds>k__BackingField, z = val_45}, b:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
                UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, b:  new UnityEngine.Vector3() {x = curState.<RawPosition>k__BackingField.x, y = curState.<RawPosition>k__BackingField.y, z = curState.<RawPosition>k__BackingField.z});
                val_54 = curState.<PositionCorrection>k__BackingField.z;
                val_52 = curState.<PositionCorrection>k__BackingField.x;
                val_53 = curState.<PositionCorrection>k__BackingField.y;
                UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_52, y = val_53, z = val_54}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
                curState.<PositionCorrection>k__BackingField.x = val_34.x;
                curState.<PositionCorrection>k__BackingField.y = val_34.y;
                curState.<PositionCorrection>k__BackingField.z = val_34.z;
            }
            
            if((((curState.<Lens>k__BackingField.FieldOfView.Size) & 1) & 1) == 0)
            {
                    if(this.m_AdjustmentMode == 1)
            {
                goto label_32;
            }
            
            }
            
            val_46 = curState.<Lens>k__BackingField.FieldOfView;
            val_44 = val_34.y;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = curState.<PositionCorrection>k__BackingField.y, y = val_45, z = curState.<PositionCorrection>k__BackingField.x}, b:  new UnityEngine.Vector3() {x = val_46, y = val_44, z = val_34.z});
            float val_45 = val_37.x;
            val_45 = val_45 - val_37.z;
            if(val_45 > 0.0001f)
            {
                    float val_38 = val_45 + val_45;
                val_38 = val_56 / val_38;
                val_38 = val_38 + val_38;
                val_57 = val_38 * 57.29578f;
            }
            else
            {
                    val_57 = 179f;
            }
            
            val_43 = 1152921511713165432;
            val_45 = this.m_MaximumFOV;
            float val_46 = 0.5f;
            val_46 = val_56 * val_46;
            curState.<Lens>k__BackingField.FieldOfView = UnityEngine.Mathf.Clamp(value:  val_57, min:  this.m_MinimumFOV, max:  val_45);
            curState.<Lens>k__BackingField.OrthographicSize = UnityEngine.Mathf.Clamp(value:  val_46, min:  this.m_MinimumOrthoSize, max:  this.m_MaximumOrthoSize);
            curState.<Lens>k__BackingField.<Aspect>k__BackingField = curState.<Lens>k__BackingField.<Aspect>k__BackingField;
            curState.<Lens>k__BackingField.NearClipPlane = curState.<Lens>k__BackingField.NearClipPlane;
            label_32:
            this.MutateCameraState(curState: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {FieldOfView = curState.<Lens>k__BackingField.FieldOfView, OrthographicSize = curState.<Lens>k__BackingField.OrthographicSize, NearClipPlane = curState.<Lens>k__BackingField.NearClipPlane, FarClipPlane = curState.<Lens>k__BackingField.FarClipPlane, Dutch = curState.<Lens>k__BackingField.Dutch, <Orthographic>k__BackingField = curState.<Lens>k__BackingField.<Orthographic>k__BackingField, <Aspect>k__BackingField = curState.<Lens>k__BackingField.<Aspect>k__BackingField}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z}, <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceLookAt>k__BackingField.x, y = curState.<ReferenceLookAt>k__BackingField.y, z = curState.<ReferenceLookAt>k__BackingField.z}, <RawPosition>k__BackingField = new UnityEngine.Vector3() {x = curState.<RawPosition>k__BackingField.x, y = curState.<RawPosition>k__BackingField.y, z = curState.<RawPosition>k__BackingField.z}}, deltaTime:  deltaTime);
        }
        public UnityEngine.Bounds get_m_LastBounds()
        {
            UnityEngine.Bounds val_0;
            val_0.m_Extents.y = ;
            val_0.m_Center.x = this.<m_LastBounds>k__BackingField;
            return val_0;
        }
        private void set_m_LastBounds(UnityEngine.Bounds value)
        {
            mem[1152921511713423212] = value.m_Extents.y;
            this.<m_LastBounds>k__BackingField = value.m_Center.x;
        }
        public UnityEngine.Matrix4x4 get_m_lastBoundsMatrix()
        {
            UnityEngine.Matrix4x4 val_0;
            val_0.m00 = this.<m_lastBoundsMatrix>k__BackingField;
            val_0.m03 = null;
            val_0.m02 = null;
            val_0.m01 = null;
            return val_0;
        }
        private void set_m_lastBoundsMatrix(UnityEngine.Matrix4x4 value)
        {
            mem[1152921511713663476] = value.m03;
            mem[1152921511713663460] = value.m02;
            mem[1152921511713663444] = value.m01;
            this.<m_lastBoundsMatrix>k__BackingField = value.m00;
        }
        private float GetTargetHeight(UnityEngine.Bounds b)
        {
            float val_1 = UnityEngine.Mathf.Max(a:  0.0001f, b:  this.m_GroupFramingSize);
            FramingMode val_18 = this.m_FramingMode;
            val_18 = (val_18 < 3) ? (val_18 + 5) : 0;
            if(val_18 > 7)
            {
                    return (float);
            }
            
            var val_19 = 25808264 + (this.m_FramingMode < 0x3 ? (this.m_FramingMode + 5) : 0) << 2;
            val_19 = val_19 + 25808264;
            goto (25808264 + (this.m_FramingMode < 0x3 ? (this.m_FramingMode + 5) : 0) << 2 + 25808264);
        }
    
    }

}
