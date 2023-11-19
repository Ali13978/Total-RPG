using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineFramingTransposer : CinemachineComponentBase
    {
        // Fields
        [Cinemachine.NoSaveDuringPlayAttribute]
        [UnityEngine.HideInInspector]
        public System.Action OnGUICallback;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public float m_LookaheadTime;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public float m_LookaheadSmoothing;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_XDamping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_YDamping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_ZDamping;
        [UnityEngine.SpaceAttribute]
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_ScreenX;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_ScreenY;
        [UnityEngine.TooltipAttribute]
        public float m_CameraDistance;
        [UnityEngine.SpaceAttribute]
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_DeadZoneWidth;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_DeadZoneHeight;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        public float m_DeadZoneDepth;
        [UnityEngine.SpaceAttribute]
        [UnityEngine.TooltipAttribute]
        public bool m_UnlimitedSoftZone;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_SoftZoneWidth;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_SoftZoneHeight;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_BiasX;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_BiasY;
        [UnityEngine.SpaceAttribute]
        [UnityEngine.TooltipAttribute]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        public Cinemachine.CinemachineFramingTransposer.FramingMode m_GroupFramingMode;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode;
        [UnityEngine.TooltipAttribute]
        public float m_GroupFramingSize;
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
        private const float kMinimumCameraDistance = 0.01;
        private UnityEngine.Vector3 m_PreviousCameraPosition;
        private Cinemachine.Utility.PositionPredictor m_Predictor;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <TrackedPoint>k__BackingField;
        private float m_prevTargetHeight;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Bounds <m_LastBounds>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Matrix4x4 <m_lastBoundsMatrix>k__BackingField;
        
        // Properties
        public UnityEngine.Rect SoftGuideRect { get; set; }
        public UnityEngine.Rect HardGuideRect { get; set; }
        public override bool IsValid { get; }
        public override Cinemachine.CinemachineCore.Stage Stage { get; }
        public UnityEngine.Vector3 TrackedPoint { get; set; }
        public UnityEngine.Bounds m_LastBounds { get; set; }
        public UnityEngine.Matrix4x4 m_lastBoundsMatrix { get; set; }
        public Cinemachine.CinemachineTargetGroup TargetGroup { get; }
        
        // Methods
        public CinemachineFramingTransposer()
        {
            this.m_LookaheadSmoothing = ;
            this.m_XDamping = ;
            this.m_YDamping = 1f;
            this.m_ZDamping = 1f;
            this.m_DeadZoneHeight = 0.1f;
            this.m_GroupFramingMode = 2;
            this.m_AdjustmentMode = 2;
            this.m_SoftZoneWidth = 0.8f;
            this.m_SoftZoneHeight = 0.8f;
            this.m_GroupFramingSize = 0.8f;
            this.m_ScreenX = ;
            this.m_ScreenY = ;
            this.m_CameraDistance = 10f;
            this.m_DeadZoneWidth = 0.1f;
            this.m_MaxDollyIn = 5000f;
            this.m_MaxDollyOut = 5000f;
            this.m_MinimumDistance = ;
            this.m_MaximumDistance = ;
            this.m_MinimumFOV = 3f;
            this.m_MaximumFOV = 60f;
            this.m_MinimumOrthoSize = 1f;
            this.m_MaximumOrthoSize = 0f;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.m_PreviousCameraPosition = val_1;
            mem[1152921511710100088] = val_1.y;
            mem[1152921511710100092] = val_1.z;
            this.m_Predictor = new Cinemachine.Utility.PositionPredictor();
            this = new UnityEngine.MonoBehaviour();
        }
        public UnityEngine.Rect get_SoftGuideRect()
        {
            float val_3 = this.m_ScreenX;
            float val_4 = this.m_ScreenY;
            float val_2 = 0.5f;
            val_2 = this.m_DeadZoneHeight * val_2;
            val_3 = val_3 - (this.m_DeadZoneWidth * val_2);
            val_4 = val_4 - val_2;
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        public void set_SoftGuideRect(UnityEngine.Rect value)
        {
            float val_1 = UnityEngine.Mathf.Clamp01(value:  value.m_XMin);
            this.m_DeadZoneWidth = val_1;
            float val_2 = UnityEngine.Mathf.Clamp01(value:  val_1);
            this.m_DeadZoneHeight = val_2;
            float val_7 = this.m_DeadZoneWidth;
            val_7 = val_7 * 0.5f;
            val_2 = val_2 + val_7;
            float val_3 = UnityEngine.Mathf.Clamp01(value:  val_2);
            this.m_ScreenX = val_3;
            float val_8 = this.m_DeadZoneHeight;
            val_8 = val_8 * 0.5f;
            val_3 = val_3 + val_8;
            this.m_ScreenY = UnityEngine.Mathf.Clamp01(value:  val_3);
            this.m_SoftZoneWidth = UnityEngine.Mathf.Max(a:  this.m_SoftZoneWidth, b:  this.m_DeadZoneWidth);
            this.m_SoftZoneHeight = UnityEngine.Mathf.Max(a:  this.m_SoftZoneHeight, b:  this.m_DeadZoneHeight);
        }
        public UnityEngine.Rect get_HardGuideRect()
        {
            float val_7 = 0.5f;
            val_7 = this.m_ScreenX - (this.m_SoftZoneWidth * val_7);
            float val_8 = this.m_SoftZoneWidth;
            float val_9 = this.m_SoftZoneHeight;
            val_8 = val_8 - this.m_DeadZoneWidth;
            val_9 = val_9 - this.m_DeadZoneHeight;
            val_8 = this.m_BiasX * val_8;
            val_9 = this.m_BiasY * val_9;
            CinemachineFreeLook.Orbit val_4 = new CinemachineFreeLook.Orbit(h:  val_8, r:  val_9);
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_7, y = this.m_ScreenY - (this.m_SoftZoneHeight * val_7)}, b:  new UnityEngine.Vector2() {x = val_4.m_Height, y = val_4.m_Radius});
            CinemachineFreeLook.Orbit val_6 = new CinemachineFreeLook.Orbit(h:  val_5.x, r:  val_5.y);
            return new UnityEngine.Rect() {m_XMin = val_6.m_Height, m_YMin = val_6.m_Radius, m_Width = 0f, m_Height = 0f};
        }
        public void set_HardGuideRect(UnityEngine.Rect value)
        {
            var val_16;
            float val_17;
            float val_19;
            var val_20;
            val_16 = this;
            val_17 = 0f;
            float val_1 = UnityEngine.Mathf.Clamp(value:  value.m_XMin, min:  val_17, max:  2f);
            this.m_SoftZoneWidth = val_1;
            this.m_SoftZoneHeight = UnityEngine.Mathf.Clamp(value:  val_1, min:  val_17, max:  2f);
            this.m_DeadZoneWidth = UnityEngine.Mathf.Min(a:  this.m_DeadZoneWidth, b:  this.m_SoftZoneWidth);
            float val_4 = UnityEngine.Mathf.Min(a:  this.m_DeadZoneHeight, b:  this.m_SoftZoneHeight);
            this.m_DeadZoneHeight = val_4;
            CinemachineFreeLook.Orbit val_5 = new CinemachineFreeLook.Orbit(h:  this.m_ScreenX, r:  this.m_ScreenY);
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_4, y = this.m_SoftZoneHeight}, b:  new UnityEngine.Vector2() {x = val_5.m_Height, y = val_5.m_Radius});
            float val_8 = UnityEngine.Mathf.Max(a:  val_17, b:  this.m_SoftZoneWidth - this.m_DeadZoneWidth);
            float val_15 = this.m_SoftZoneHeight;
            val_15 = val_15 - this.m_DeadZoneHeight;
            float val_9 = UnityEngine.Mathf.Max(a:  val_17, b:  val_15);
            val_19 = val_17;
            val_20 = val_16;
            var val_10 = (val_8 < 0) ? 0 : (val_16);
            if(val_8 < 0)
            {
                goto label_5;
            }
            
            val_19 = val_6.x / val_8;
            if(val_10 == 0)
            {
                goto label_8;
            }
            
            val_20 = val_10;
            label_5:
            mem2[0] = UnityEngine.Mathf.Clamp(value:  val_19, min:  -0.5f, max:  0.5f);
            if(val_9 >= 0)
            {
                    val_17 = UnityEngine.Mathf.Clamp(value:  val_6.y / val_9, min:  -0.5f, max:  0.5f);
                val_16 = (val_9 < 0) ? 0 : (val_16);
            }
            
            mem2[0] = val_17;
            return;
            label_8:
        }
        private void OnValidate()
        {
            this.m_CameraDistance = UnityEngine.Mathf.Max(a:  this.m_CameraDistance, b:  0.01f);
            this.m_DeadZoneDepth = UnityEngine.Mathf.Max(a:  this.m_DeadZoneDepth, b:  0f);
            this.m_GroupFramingSize = UnityEngine.Mathf.Max(a:  0.0001f, b:  this.m_GroupFramingSize);
            this.m_MaxDollyIn = UnityEngine.Mathf.Max(a:  0f, b:  this.m_MaxDollyIn);
            this.m_MaxDollyOut = UnityEngine.Mathf.Max(a:  0f, b:  this.m_MaxDollyOut);
            float val_6 = UnityEngine.Mathf.Max(a:  0f, b:  this.m_MinimumDistance);
            this.m_MinimumDistance = val_6;
            this.m_MaximumDistance = UnityEngine.Mathf.Max(a:  val_6, b:  this.m_MaximumDistance);
            float val_8 = UnityEngine.Mathf.Max(a:  1f, b:  this.m_MinimumFOV);
            this.m_MinimumFOV = val_8;
            this.m_MaximumFOV = UnityEngine.Mathf.Clamp(value:  this.m_MaximumFOV, min:  val_8, max:  179f);
            float val_10 = UnityEngine.Mathf.Max(a:  0.01f, b:  this.m_MinimumOrthoSize);
            this.m_MinimumOrthoSize = val_10;
            this.m_MaximumOrthoSize = UnityEngine.Mathf.Max(a:  val_10, b:  this.m_MaximumOrthoSize);
        }
        public override bool get_IsValid()
        {
            if(this.enabled == false)
            {
                    return false;
            }
            
            if(0 == this.FollowTarget)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Equality(x:  0, y:  this.LookAtTarget);
        }
        public override Cinemachine.CinemachineCore.Stage get_Stage()
        {
            return 0;
        }
        public UnityEngine.Vector3 get_TrackedPoint()
        {
            return new UnityEngine.Vector3() {x = this.<TrackedPoint>k__BackingField};
        }
        private void set_TrackedPoint(UnityEngine.Vector3 value)
        {
            this.<TrackedPoint>k__BackingField = value;
            mem[1152921511711124492] = value.y;
            mem[1152921511711124496] = value.z;
        }
        public override void MutateCameraState(ref Cinemachine.CameraState curState, float deltaTime)
        {
            Cinemachine.Utility.PositionPredictor val_49;
            float val_50;
            var val_51;
            float val_52;
            float val_53;
            float val_54;
            float val_58;
            float val_59;
            float val_60;
            float val_61;
            float val_62;
            float val_63;
            float val_64;
            float val_65;
            float val_70;
            float val_71;
            float val_72;
            float val_76;
            float val_77;
            float val_78;
            val_50 = deltaTime;
            val_51 = 1152921511711321824;
            if(val_50 < 0)
            {
                    val_49 = this.m_Predictor;
                val_49.Reset();
                val_52 = curState.<RawOrientation>k__BackingField.x;
                val_53 = curState.<RawOrientation>k__BackingField.z;
                UnityEngine.Vector3 val_1 = UnityEngine.Vector3.back;
                val_54 = val_1.z;
                UnityEngine.Vector3 val_2 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_52, y = curState.<RawOrientation>k__BackingField.y, z = val_53, w = curState.<RawOrientation>k__BackingField.w}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_54});
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  this.m_CameraDistance);
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = curState.<RawPosition>k__BackingField.x, y = curState.<RawPosition>k__BackingField.y, z = curState.<RawPosition>k__BackingField.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                this.m_PreviousCameraPosition = val_4;
                mem[1152921511711289976] = val_4.y;
                val_50 = val_50;
                mem[1152921511711289980] = val_4.z;
            }
            
            if((this & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_6 = this.FollowTarget.position;
            curState.<ReferenceLookAt>k__BackingField.x = val_6.x;
            curState.<ReferenceLookAt>k__BackingField.y = val_6.y;
            curState.<ReferenceLookAt>k__BackingField.z = val_6.z;
            this.m_Predictor.Smoothing = this.m_LookaheadSmoothing;
            this.m_Predictor.AddPosition(pos:  new UnityEngine.Vector3() {x = curState.<ReferenceLookAt>k__BackingField.x, y = curState.<ReferenceLookAt>k__BackingField.y, z = curState.<ReferenceLookAt>k__BackingField.z});
            if(this.m_LookaheadTime <= 0f)
            {
                goto label_11;
            }
            
            UnityEngine.Vector3 val_7 = this.m_Predictor.PredictPosition(lookaheadTime:  this.m_LookaheadTime);
            val_58 = val_7.x;
            val_59 = val_7.y;
            val_60 = val_7.z;
            if(this != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_11:
            val_58 = curState.<ReferenceLookAt>k__BackingField.x;
            val_59 = curState.<ReferenceLookAt>k__BackingField.y;
            val_60 = curState.<ReferenceLookAt>k__BackingField.z;
            label_14:
            this.<TrackedPoint>k__BackingField = val_6;
            mem[1152921511711289996] = val_59;
            mem[1152921511711290000] = val_60;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = curState.<RawOrientation>k__BackingField.x, y = curState.<RawOrientation>k__BackingField.y, z = curState.<RawOrientation>k__BackingField.z, w = curState.<RawOrientation>k__BackingField.w});
            UnityEngine.Vector3 val_9 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, point:  new UnityEngine.Vector3() {x = this.m_PreviousCameraPosition, y = val_54, z = curState.<RawPosition>k__BackingField.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, point:  new UnityEngine.Vector3() {x = this.<TrackedPoint>k__BackingField, y = val_54, z = curState.<RawPosition>k__BackingField.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            float val_49 = val_11.z;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            float val_15 = UnityEngine.Mathf.Max(a:  0.01f, b:  this.m_CameraDistance - (this.m_DeadZoneDepth * 0.5f));
            float val_47 = this.m_DeadZoneDepth;
            float val_48 = this.m_CameraDistance;
            val_47 = val_48 + (val_47 * 0.5f);
            val_61 = val_15;
            float val_17 = UnityEngine.Mathf.Max(a:  val_61, b:  val_47);
            val_48 = val_49 - val_17;
            float val_20 = (val_49 > val_17) ? (val_48) : ((val_49 < 0) ? (val_49 - val_15) : val_12.z);
            val_49 = this.TargetGroup;
            if((0 != val_49) && (this.m_GroupFramingMode != 3))
            {
                    val_62 = val_50;
                val_61 = val_49 - val_20;
                val_63 = val_20 + (this.AdjustCameraDepthAndLensForGroupFraming(group:  val_49, targetZ:  val_61, curState: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {FieldOfView = curState.<Lens>k__BackingField.FieldOfView, OrthographicSize = curState.<Lens>k__BackingField.OrthographicSize, NearClipPlane = curState.<Lens>k__BackingField.NearClipPlane, FarClipPlane = curState.<Lens>k__BackingField.FarClipPlane, Dutch = curState.<Lens>k__BackingField.Dutch, <Orthographic>k__BackingField = curState.<Lens>k__BackingField.<Orthographic>k__BackingField, <Aspect>k__BackingField = curState.<Lens>k__BackingField.<Aspect>k__BackingField}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z}, <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceLookAt>k__BackingField.x, y = curState.<ReferenceLookAt>k__BackingField.y, z = curState.<ReferenceLookAt>k__BackingField.z}, <RawPosition>k__BackingField = new UnityEngine.Vector3() {x = curState.<RawPosition>k__BackingField.x, y = curState.<RawPosition>k__BackingField.y, z = curState.<RawPosition>k__BackingField.z}}, deltaTime:  val_62));
            }
            
            val_49 = val_49 - val_63;
            if(((curState.<Lens>k__BackingField.FieldOfView.Size) & 1) != 0)
            {
                    val_64 = curState.<Lens>k__BackingField.OrthographicSize;
            }
            else
            {
                    val_62 = (curState.<Lens>k__BackingField.FieldOfView) * 0.5f;
                val_61 = val_62 * 0.01745329f;
                val_64 = val_49 * val_61;
            }
            
            UnityEngine.Rect val_25 = this.SoftGuideRect;
            val_65 = val_25.m_Height;
            UnityEngine.Rect val_27 = curState.<Lens>k__BackingField.FieldOfView.ScreenToOrtho(rScreen:  new UnityEngine.Rect() {m_XMin = val_25.m_XMin, m_YMin = val_25.m_YMin, m_Width = val_25.m_Width, m_Height = val_65}, orthoSize:  val_64, aspect:  curState.<Lens>k__BackingField.FieldOfView.GetDuration());
            if(val_50 < 0)
            {
                    UnityEngine.Vector2 val_28 = UnityEngine.Vector2.zero;
                UnityEngine.Vector3 val_29 = 0.OrthoOffsetToScreenBounds(targetPos2D:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_49}, screenRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
                val_53 = curState.<RawOrientation>k__BackingField.w;
                val_70 = val_12.y;
                val_71 = val_12.x;
                val_72 = val_63;
            }
            else
            {
                    UnityEngine.Vector3 val_30 = curState.<Lens>k__BackingField.FieldOfView.OrthoOffsetToScreenBounds(targetPos2D:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_49}, screenRect:  new UnityEngine.Rect() {m_XMin = val_27.m_XMin, m_YMin = val_27.m_YMin, m_Width = val_27.m_Width, m_Height = val_27.m_Height});
                UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_63}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
                UnityEngine.Vector3 val_32 = UnityEngine.Vector3.zero;
                val_76 = val_32.x;
                val_77 = val_32.y;
                val_65 = val_32.z;
                if(this.m_UnlimitedSoftZone != false)
            {
                    val_53 = curState.<RawOrientation>k__BackingField.w;
                val_78 = val_31.y;
            }
            else
            {
                    UnityEngine.Rect val_33 = this.HardGuideRect;
                UnityEngine.Rect val_35 = curState.<Lens>k__BackingField.FieldOfView.ScreenToOrtho(rScreen:  new UnityEngine.Rect() {m_XMin = val_33.m_XMin, m_YMin = val_33.m_YMin, m_Width = val_33.m_Width, m_Height = val_33.m_Height}, orthoSize:  val_64, aspect:  curState.<Lens>k__BackingField.FieldOfView.GetDuration());
                UnityEngine.Vector3 val_36 = curState.<Lens>k__BackingField.FieldOfView.OrthoOffsetToScreenBounds(targetPos2D:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_49}, screenRect:  new UnityEngine.Rect() {m_XMin = val_35.m_XMin, m_YMin = val_35.m_YMin, m_Width = val_35.m_Width, m_Height = val_35.m_Height});
                float val_50 = 0.0001f;
                val_78 = val_31.y;
                val_50 = val_36.x / (val_31.x + val_50);
                val_53 = curState.<RawOrientation>k__BackingField.w;
                UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_78, z = val_31.z}, d:  UnityEngine.Mathf.Max(a:  val_50, b:  val_36.y / (val_78 + val_50)));
                val_76 = val_41.x;
                val_77 = val_41.y;
                val_65 = val_41.z;
            }
            
                UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_78, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_76, y = val_77, z = val_65});
                UnityEngine.Vector3 val_43 = Cinemachine.Utility.Damper.Damp(initial:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, dampTime:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, deltaTime:  val_50);
                val_71 = val_76;
                val_70 = val_77;
                val_72 = val_65;
            }
            
            UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_71, y = val_70, z = val_72}, b:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z});
            val_52 = curState.<RawOrientation>k__BackingField.y;
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z});
            val_50 = val_45.x;
            val_54 = val_45.z;
            UnityEngine.Vector3 val_46 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = curState.<RawOrientation>k__BackingField.x, y = val_52, z = curState.<RawOrientation>k__BackingField.z, w = val_53}, point:  new UnityEngine.Vector3() {x = val_50, y = val_45.y, z = val_54});
            this.m_PreviousCameraPosition = val_46;
            mem[1152921511711289976] = val_46.y;
            mem[1152921511711289980] = val_46.z;
            curState.<RawPosition>k__BackingField.x = val_46.x;
            curState.<RawPosition>k__BackingField.y = val_46.y;
            curState.<RawPosition>k__BackingField.z = val_46.z;
        }
        private UnityEngine.Rect ScreenToOrtho(UnityEngine.Rect rScreen, float orthoSize, float aspect)
        {
            float val_2 = aspect;
            float val_1 = orthoSize;
            rScreen.m_XMin = 1f - rScreen.m_XMin;
            val_1 = val_1 + val_1;
            rScreen.m_XMin = rScreen.m_XMin + (-0.5f);
            rScreen.m_XMin = val_1 * rScreen.m_XMin;
            rScreen.m_XMin = 1f - rScreen.m_XMin;
            rScreen.m_XMin = rScreen.m_XMin + (-0.5f);
            rScreen.m_XMin = val_1 * rScreen.m_XMin;
            val_2 = val_1 * val_2;
            rScreen.m_XMin = rScreen.m_XMin + (-0.5f);
            rScreen.m_XMin = val_2 * rScreen.m_XMin;
            rScreen.m_XMin = rScreen.m_XMin + (-0.5f);
            rScreen.m_XMin = val_2 * rScreen.m_XMin;
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        private UnityEngine.Vector3 OrthoOffsetToScreenBounds(UnityEngine.Vector3 targetPos2D, UnityEngine.Rect screenRect)
        {
            float val_2;
            float val_3;
            float val_4;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_2 = val_1.x;
            val_3 = val_1.y;
            if(targetPos2D.x < 0)
            {
                    val_4 = targetPos2D.x - val_1.x;
                val_2 = val_2 + val_4;
            }
            
            if(targetPos2D.x > val_4)
            {
                    val_4 = targetPos2D.x - val_4;
                val_2 = val_2 + val_4;
            }
            
            if(targetPos2D.y < 0)
            {
                    val_4 = targetPos2D.y - val_4;
                val_3 = val_3 + val_4;
            }
            
            if(targetPos2D.y <= val_4)
            {
                    return new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_1.z};
            }
            
            val_4 = targetPos2D.y - val_4;
            val_3 = val_3 + val_4;
            return new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_1.z};
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
            mem[1152921511711803592] = value.m_Extents.y;
            this.<m_LastBounds>k__BackingField = value.m_Center.x;
        }
        public UnityEngine.Matrix4x4 get_m_lastBoundsMatrix()
        {
            UnityEngine.Matrix4x4 val_0;
            val_0.m03 = ;
            val_0.m02 = ;
            val_0.m01 = ;
            val_0.m00 = this.<m_lastBoundsMatrix>k__BackingField;
            return val_0;
        }
        private void set_m_lastBoundsMatrix(UnityEngine.Matrix4x4 value)
        {
            mem[1152921511712043840] = value.m02;
            mem[1152921511712043856] = value.m03;
            this.<m_lastBoundsMatrix>k__BackingField = value.m00;
            mem[1152921511712043824] = value.m01;
        }
        public Cinemachine.CinemachineTargetGroup get_TargetGroup()
        {
            var val_4;
            UnityEngine.Transform val_1 = this.FollowTarget;
            val_4 = 0;
            if(0 == val_1)
            {
                    return (Cinemachine.CinemachineTargetGroup)val_1.GetComponent<Cinemachine.CinemachineTargetGroup>();
            }
            
            return (Cinemachine.CinemachineTargetGroup)val_1.GetComponent<Cinemachine.CinemachineTargetGroup>();
        }
        private float AdjustCameraDepthAndLensForGroupFraming(Cinemachine.CinemachineTargetGroup group, float targetZ, ref Cinemachine.CameraState curState, float deltaTime)
        {
            float val_10;
            float val_11;
            float val_12;
            UnityEngine.Matrix4x4 val_13;
            float val_15;
            UnityEngine.Bounds val_16;
            float val_30;
            float val_32;
            float val_33;
            UnityEngine.Bounds val_34;
            float val_35;
            float val_37;
            UnityEngine.Bounds val_1 = group.BoundingBox;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = curState.<RawOrientation>k__BackingField.x, y = curState.<RawOrientation>k__BackingField.y, z = curState.<RawOrientation>k__BackingField.z, w = curState.<RawOrientation>k__BackingField.w}, point:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  val_5.x);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_30 = val_7.z;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_9 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_30}, q:  new UnityEngine.Quaternion() {x = curState.<RawOrientation>k__BackingField.x, y = curState.<RawOrientation>k__BackingField.y, z = curState.<RawOrientation>k__BackingField.z, w = curState.<RawOrientation>k__BackingField.w}, s:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.z, z = val_7.y});
            mem[1152921511712338816] = val_10;
            mem[1152921511712338800] = val_11;
            mem[1152921511712338784] = val_12;
            this.<m_lastBoundsMatrix>k__BackingField = val_13;
            UnityEngine.Bounds val_14 = group.GetViewSpaceBoundingBox(mView:  new UnityEngine.Matrix4x4() {m00 = val_13, m10 = val_13, m20 = val_13, m30 = val_13, m01 = val_12, m11 = val_12, m21 = val_12, m31 = val_12, m02 = val_11, m12 = val_11, m22 = val_11, m32 = val_11, m03 = val_10, m13 = val_10, m23 = val_10, m33 = val_10});
            mem[1152921511712338760] = val_15;
            this.<m_LastBounds>k__BackingField = val_16;
            val_32 = deltaTime;
            val_33 = this.GetTargetHeight(b:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_16, y = val_16, z = val_16}, m_Extents = new UnityEngine.Vector3() {x = val_16, y = val_15, z = val_15}});
            if(val_32 >= 0f)
            {
                    float val_29 = this.m_prevTargetHeight;
                val_29 = val_33 - val_29;
                val_33 = (Cinemachine.Utility.Damper.Damp(initial:  val_29, dampTime:  this.m_ZDamping, deltaTime:  val_32)) + this.m_prevTargetHeight;
            }
            
            this.m_prevTargetHeight = val_33;
            val_34 = this.<m_LastBounds>k__BackingField;
            val_35 = 0f;
            if(((((curState.<Lens>k__BackingField.FieldOfView.Size) & 1) & 1) == 0) && (this.m_AdjustmentMode != 0))
            {
                    float val_30 = 0.01745329f;
                val_30 = (curState.<Lens>k__BackingField.FieldOfView) * val_30;
                val_30 = val_30 * 0.5f;
                val_30 = val_30 + val_30;
                val_30 = val_33 / val_30;
                float val_31 = this.m_MaxDollyIn;
                val_30 = val_30 + val_32;
                val_31 = targetZ - val_31;
                val_32 = this.m_MaximumDistance;
                float val_23 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.Clamp(value:  val_30, min:  val_31, max:  this.m_MaxDollyOut + targetZ), min:  this.m_MinimumDistance, max:  val_32);
                val_23 = val_23 - targetZ;
                float val_32 = 0f;
                val_35 = val_23 + val_32;
            }
            
            if((((curState.<Lens>k__BackingField.FieldOfView.Size) & 1) & 1) == 0)
            {
                    if(this.m_AdjustmentMode == 1)
            {
                    return (float)-val_35;
            }
            
            }
            
            val_32 = val_35 + targetZ;
            val_30 = val_32 - val_32;
            if(val_30 > 0.0001f)
            {
                    float val_26 = val_30 + val_30;
                val_26 = val_33 / val_26;
                val_26 = val_26 + val_26;
                val_37 = val_26 * 57.29578f;
            }
            else
            {
                    val_37 = 179f;
            }
            
            val_34 = 1152921511712374664;
            val_30 = UnityEngine.Mathf.Clamp(value:  val_37, min:  this.m_MinimumFOV, max:  this.m_MaximumFOV);
            float val_33 = 0.5f;
            val_33 = val_33 * val_33;
            curState.<Lens>k__BackingField.FieldOfView = val_30;
            curState.<Lens>k__BackingField.OrthographicSize = UnityEngine.Mathf.Clamp(value:  val_33, min:  this.m_MinimumOrthoSize, max:  this.m_MaximumOrthoSize);
            curState.<Lens>k__BackingField.<Aspect>k__BackingField = curState.<Lens>k__BackingField.<Aspect>k__BackingField;
            curState.<Lens>k__BackingField.NearClipPlane = curState.<Lens>k__BackingField.NearClipPlane;
            return (float)-val_35;
        }
        private float GetTargetHeight(UnityEngine.Bounds b)
        {
            var val_13 = 1152921504719998976;
            float val_1 = UnityEngine.Mathf.Max(a:  0.0001f, b:  this.m_GroupFramingSize);
            FramingMode val_13 = this.m_GroupFramingMode;
            val_13 = (val_13 < 3) ? (val_13 + 5) : 0;
            if(val_13 > 7)
            {
                    return (float);
            }
            
            var val_14 = 25808232 + (this.m_GroupFramingMode < 0x3 ? (this.m_GroupFramingMode + 5) : 0) << 2;
            val_14 = val_14 + 25808232;
            goto (25808232 + (this.m_GroupFramingMode < 0x3 ? (this.m_GroupFramingMode + 5) : 0) << 2 + 25808232);
        }
    
    }

}
