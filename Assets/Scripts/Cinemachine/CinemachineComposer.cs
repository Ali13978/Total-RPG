using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineComposer : CinemachineComponentBase
    {
        // Fields
        [Cinemachine.NoSaveDuringPlayAttribute]
        [UnityEngine.HideInInspector]
        public System.Action OnGUICallback;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Vector3 m_TrackedObjectOffset;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public float m_LookaheadTime;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public float m_LookaheadSmoothing;
        [UnityEngine.SpaceAttribute]
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_HorizontalDamping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_VerticalDamping;
        [UnityEngine.SpaceAttribute]
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_ScreenX;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_ScreenY;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_DeadZoneWidth;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_DeadZoneHeight;
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
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <TrackedPoint>k__BackingField;
        private UnityEngine.Vector3 m_CameraPosPrevFrame;
        private UnityEngine.Vector3 m_LookAtPrevFrame;
        private UnityEngine.Vector2 m_ScreenOffsetPrevFrame;
        private UnityEngine.Quaternion m_CameraOrientationPrevFrame;
        private Cinemachine.Utility.PositionPredictor m_Predictor;
        
        // Properties
        public override bool IsValid { get; }
        public override Cinemachine.CinemachineCore.Stage Stage { get; }
        public UnityEngine.Vector3 TrackedPoint { get; set; }
        public UnityEngine.Rect SoftGuideRect { get; set; }
        public UnityEngine.Rect HardGuideRect { get; set; }
        
        // Methods
        public CinemachineComposer()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.m_TrackedObjectOffset = val_1;
            mem[1152921511708179980] = val_1.y;
            mem[1152921511708179984] = val_1.z;
            this.m_LookaheadSmoothing = ;
            this.m_HorizontalDamping = ;
            this.m_VerticalDamping = 0.5f;
            this.m_ScreenX = 0.5f;
            this.m_ScreenY = ;
            this.m_DeadZoneWidth = ;
            this.m_DeadZoneHeight = 0.1f;
            this.m_SoftZoneWidth = 0.8f;
            this.m_SoftZoneHeight = 0.8f;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.m_CameraPosPrevFrame = val_2;
            mem[1152921511708180052] = val_2.y;
            mem[1152921511708180056] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.m_LookAtPrevFrame = val_3;
            mem[1152921511708180064] = val_3.y;
            mem[1152921511708180068] = val_3.z;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            this.m_ScreenOffsetPrevFrame = val_4;
            mem[1152921511708180076] = val_4.y;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            this.m_CameraOrientationPrevFrame = val_5;
            mem[1152921511708180084] = val_5.y;
            mem[1152921511708180088] = val_5.z;
            mem[1152921511708180092] = val_5.w;
            this.m_Predictor = new Cinemachine.Utility.PositionPredictor();
            this = new UnityEngine.MonoBehaviour();
        }
        public override bool get_IsValid()
        {
            if(this.enabled == false)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  0, y:  this.LookAtTarget);
        }
        public override Cinemachine.CinemachineCore.Stage get_Stage()
        {
            return 1;
        }
        public UnityEngine.Vector3 get_TrackedPoint()
        {
            return new UnityEngine.Vector3() {x = this.<TrackedPoint>k__BackingField};
        }
        private void set_TrackedPoint(UnityEngine.Vector3 value)
        {
            this.<TrackedPoint>k__BackingField = value;
            mem[1152921511708636232] = value.y;
            mem[1152921511708636236] = value.z;
        }
        protected virtual UnityEngine.Vector3 GetLookAtPointAndSetTrackedPoint(UnityEngine.Vector3 lookAt)
        {
            float val_9;
            float val_10;
            float val_11;
            float val_15;
            float val_16;
            var val_17;
            val_9 = lookAt.z;
            val_10 = lookAt.y;
            val_11 = lookAt.x;
            if(0 != this.LookAtTarget)
            {
                    UnityEngine.Quaternion val_5 = this.LookAtTarget.transform.rotation;
                UnityEngine.Vector3 val_6 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = this.m_TrackedObjectOffset, y = V15.16B, z = V14.16B});
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                val_11 = val_7.x;
                val_10 = val_7.y;
                val_9 = val_7.z;
            }
            
            this.m_Predictor.Smoothing = this.m_LookaheadSmoothing;
            this.m_Predictor.AddPosition(pos:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9});
            val_15 = val_9;
            val_16 = val_10;
            val_17 = val_11;
            if(this.m_LookaheadTime > 0f)
            {
                    UnityEngine.Vector3 val_8 = this.m_Predictor.PredictPosition(lookaheadTime:  this.m_LookaheadTime);
                val_17 = val_8.x;
                val_16 = val_8.y;
                val_15 = val_8.z;
            }
            
            this.<TrackedPoint>k__BackingField = val_8;
            mem[1152921511708772808] = val_16;
            mem[1152921511708772812] = val_15;
            return new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9};
        }
        public override void PrePipelineMutateCameraState(ref Cinemachine.CameraState curState)
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            if((1152921511708966096 & 1) == 0)
            {
                    return;
            }
            
            curState.<ReferenceLookAt>k__BackingField.x = curState.<ReferenceLookAt>k__BackingField.x;
            curState.<ReferenceLookAt>k__BackingField.y = curState.<ReferenceLookAt>k__BackingField.y;
            curState.<ReferenceLookAt>k__BackingField.z = curState.<ReferenceLookAt>k__BackingField.z;
        }
        public override void MutateCameraState(ref Cinemachine.CameraState curState, float deltaTime)
        {
            Cinemachine.Utility.PositionPredictor val_30;
            float val_31;
            var val_32;
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            float val_38;
            float val_39;
            float val_44;
            float val_45;
            float val_46;
            float val_47;
            UnityEngine.Vector3 val_48;
            var val_49;
            var val_50;
            float val_51;
            float val_52;
            float val_53;
            float val_54;
            float val_55;
            val_31 = deltaTime;
            val_32 = 1152921511709131840;
            if(val_31 < 0)
            {
                    val_30 = this.m_Predictor;
                val_30.Reset();
            }
            
            if((this & 1) == 0)
            {
                    return;
            }
            
            if((val_32 & 1) == 0)
            {
                    return;
            }
            
            val_30 = 1152921504719785984;
            val_33 = deltaTime;
            val_34 = V2.16B;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<TrackedPoint>k__BackingField, y = V10.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_33, y = V1.16B, z = val_34});
            val_35 = val_1.x;
            if(val_35 < 0)
            {
                    if(val_31 < 0f)
            {
                    return;
            }
            
                curState.<RawOrientation>k__BackingField.x = this.m_CameraOrientationPrevFrame;
                curState.<RawOrientation>k__BackingField.y = typeof(Cinemachine.CinemachineComposer).__il2cppRuntimeField_150;
                curState.<RawOrientation>k__BackingField.w = ;
                return;
            }
            
            if(((curState.<Lens>k__BackingField.FieldOfView.Size) & 1) != 0)
            {
                    val_36 = ((curState.<Lens>k__BackingField.OrthographicSize) / val_35) * 114.5916f;
                float val_4 = curState.<Lens>k__BackingField.FieldOfView.GetDuration();
                val_37 = curState.<Lens>k__BackingField.OrthographicSize;
                val_4 = val_4 * val_37;
                val_38 = val_4 / val_35;
                val_39 = val_38 * 114.5916f;
            }
            else
            {
                    val_36 = curState.<Lens>k__BackingField.FieldOfView;
                float val_28 = 0.01745329f;
                val_28 = val_36 * val_28;
                val_28 = val_28 * 0.5f;
                double val_29 = (double)curState.<Lens>k__BackingField.FieldOfView.GetDuration();
                val_29 = (double)val_28 * val_29;
                val_37 = 57.2957801818848;
                val_29 = val_29 + val_29;
                val_38 = val_29 * val_37;
                val_39 = (float)val_38;
            }
            
            UnityEngine.Rect val_6 = this.SoftGuideRect;
            UnityEngine.Rect val_8 = curState.<Lens>k__BackingField.FieldOfView.ScreenToFOV(rScreen:  new UnityEngine.Rect() {m_XMin = val_6.m_XMin, m_YMin = val_6.m_YMin, m_Width = val_6.m_Width, m_Height = val_6.m_Height}, fov:  val_36, fovH:  val_39, aspect:  curState.<Lens>k__BackingField.FieldOfView.GetDuration());
            if(val_31 < 0)
            {
                    UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
                val_44 = 0f;
                val_45 = 0f;
                val_46 = 0f;
                val_47 = 0f;
                bool val_10 = this.RotateToScreenBounds(state: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {FieldOfView = curState.<Lens>k__BackingField.FieldOfView, OrthographicSize = curState.<Lens>k__BackingField.OrthographicSize, NearClipPlane = curState.<Lens>k__BackingField.NearClipPlane, FarClipPlane = curState.<Lens>k__BackingField.FarClipPlane, Dutch = curState.<Lens>k__BackingField.Dutch, <Orthographic>k__BackingField = curState.<Lens>k__BackingField.<Orthographic>k__BackingField, <Aspect>k__BackingField = curState.<Lens>k__BackingField.<Aspect>k__BackingField}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z}, <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceLookAt>k__BackingField.x, y = curState.<ReferenceLookAt>k__BackingField.y, z = curState.<ReferenceLookAt>k__BackingField.z}, <RawPosition>k__BackingField = new UnityEngine.Vector3() {x = curState.<RawPosition>k__BackingField.x, y = curState.<RawPosition>k__BackingField.y, z = curState.<RawPosition>k__BackingField.z}}, screenRect:  new UnityEngine.Rect() {m_XMin = val_44, m_YMin = val_45, m_Width = val_46, m_Height = val_47}, rigOrientation: ref  new UnityEngine.Quaternion() {x = curState.<RawOrientation>k__BackingField.x, y = curState.<RawOrientation>k__BackingField.x, z = curState.<RawOrientation>k__BackingField.x, w = curState.<RawOrientation>k__BackingField.x}, fov:  val_36, fovH:  val_39, deltaTime:  -1f);
                val_48 = this.m_LookAtPrevFrame;
                val_49 = 1152921511709099968;
                val_50 = 1152921511709099972;
            }
            else
            {
                    val_48 = this;
                val_49 = 1152921511709099964;
                val_50 = 1152921511709099964;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.m_CameraPosPrevFrame, y = V15.16B, z = val_6.m_YMin}, b:  new UnityEngine.Vector3() {x = curState.<PositionDampingBypass>k__BackingField.x, y = curState.<PositionDampingBypass>k__BackingField.y, z = curState.<PositionDampingBypass>k__BackingField.z});
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.m_LookAtPrevFrame, y = val_36, z = this.m_LookAtPrevFrame}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
                if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z})) != false)
            {
                    UnityEngine.Vector3 val_14 = UnityEngine.Vector3.forward;
                val_52 = this.m_CameraOrientationPrevFrame;
                val_53 = val_12.z;
                val_54 = val_12.y;
                UnityEngine.Vector3 val_15 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_52, y = val_53, z = val_54, w = curState.<PositionDampingBypass>k__BackingField.z}, point:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
                val_55 = curState.<ReferenceUp>k__BackingField.x;
                UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, upwards:  new UnityEngine.Vector3() {x = val_55, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z});
            }
            else
            {
                    UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, upwards:  new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z});
                val_51 = val_17.z;
                UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = this.m_ScreenOffsetPrevFrame, y = curState.<ReferenceUp>k__BackingField.z});
                val_53 = val_17.y;
                val_52 = val_17.x;
                val_54 = val_51;
                val_55 = val_17.w;
                UnityEngine.Quaternion val_19 = Cinemachine.Utility.UnityQuaternionExtensions.ApplyCameraRotation(orient:  new UnityEngine.Quaternion() {x = val_52, y = val_53, z = val_54, w = val_55}, rot:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, worldUp:  new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.z, z = val_39});
            }
            
                UnityEngine.Rect val_20 = this.HardGuideRect;
                UnityEngine.Rect val_22 = curState.<Lens>k__BackingField.FieldOfView.ScreenToFOV(rScreen:  new UnityEngine.Rect() {m_XMin = val_20.m_XMin, m_YMin = val_20.m_YMin, m_Width = val_20.m_Width, m_Height = val_20.m_Height}, fov:  val_36, fovH:  val_39, aspect:  curState.<Lens>k__BackingField.FieldOfView.GetDuration());
                bool val_23 = this.RotateToScreenBounds(state: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {FieldOfView = curState.<Lens>k__BackingField.FieldOfView, OrthographicSize = curState.<Lens>k__BackingField.OrthographicSize, NearClipPlane = curState.<Lens>k__BackingField.NearClipPlane, FarClipPlane = curState.<Lens>k__BackingField.FarClipPlane, Dutch = curState.<Lens>k__BackingField.Dutch, <Orthographic>k__BackingField = curState.<Lens>k__BackingField.<Orthographic>k__BackingField, <Aspect>k__BackingField = curState.<Lens>k__BackingField.<Aspect>k__BackingField}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z}, <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceLookAt>k__BackingField.x, y = curState.<ReferenceLookAt>k__BackingField.y, z = curState.<ReferenceLookAt>k__BackingField.z}, <RawPosition>k__BackingField = new UnityEngine.Vector3() {x = curState.<RawPosition>k__BackingField.x, y = curState.<RawPosition>k__BackingField.y, z = curState.<RawPosition>k__BackingField.z}}, screenRect:  new UnityEngine.Rect() {m_XMin = val_22.m_XMin, m_YMin = val_22.m_YMin, m_Width = val_22.m_Width, m_Height = val_22.m_Height}, rigOrientation: ref  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w}, fov:  val_36, fovH:  val_39, deltaTime:  -1f);
                val_44 = val_8.m_XMin;
                val_45 = val_8.m_YMin;
                val_46 = val_8.m_Width;
                val_47 = val_8.m_Height;
                bool val_24 = this.RotateToScreenBounds(state: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {FieldOfView = curState.<Lens>k__BackingField.FieldOfView, OrthographicSize = curState.<Lens>k__BackingField.OrthographicSize, NearClipPlane = curState.<Lens>k__BackingField.NearClipPlane, FarClipPlane = curState.<Lens>k__BackingField.FarClipPlane, Dutch = curState.<Lens>k__BackingField.Dutch, <Orthographic>k__BackingField = curState.<Lens>k__BackingField.<Orthographic>k__BackingField, <Aspect>k__BackingField = curState.<Lens>k__BackingField.<Aspect>k__BackingField}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.y, z = curState.<ReferenceUp>k__BackingField.z}, <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3() {x = curState.<ReferenceLookAt>k__BackingField.x, y = curState.<ReferenceLookAt>k__BackingField.y, z = curState.<ReferenceLookAt>k__BackingField.z}, <RawPosition>k__BackingField = new UnityEngine.Vector3() {x = curState.<RawPosition>k__BackingField.x, y = curState.<RawPosition>k__BackingField.y, z = curState.<RawPosition>k__BackingField.z}}, screenRect:  new UnityEngine.Rect() {m_XMin = val_44, m_YMin = val_45, m_Width = val_46, m_Height = val_47}, rigOrientation: ref  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w}, fov:  val_36, fovH:  val_39, deltaTime:  val_31);
            }
            
            this.m_CameraPosPrevFrame = val_44;
            mem[1152921511709099956] = val_45;
            mem[1152921511709099960] = val_46;
            this.m_LookAtPrevFrame = this.<TrackedPoint>k__BackingField;
            mem[1152921511709099968] = typeof(Cinemachine.CinemachineComposer).__il2cppRuntimeField_150;
            mem[1152921511709099972] = ???;
            UnityEngine.Quaternion val_25 = Cinemachine.Utility.UnityQuaternionExtensions.Normalized(q:  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w});
            val_31 = val_25.x;
            this.m_CameraOrientationPrevFrame = val_25;
            val_34 = this.m_LookAtPrevFrame;
            val_35 = val_25.z;
            mem[1152921511709099988] = val_25.y;
            mem[1152921511709099992] = val_35;
            mem[1152921511709099996] = val_25.w;
            val_33 = val_25.y;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_34, y = val_25.x, z = val_25.x}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_33, z = val_25.z});
            UnityEngine.Vector2 val_27 = Cinemachine.Utility.UnityQuaternionExtensions.GetCameraRotationToTarget(orient:  new UnityEngine.Quaternion() {x = val_31, y = val_25.y, z = val_35, w = val_25.w}, lookAtDir:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, worldUp:  new UnityEngine.Vector3() {x = curState.<ReferenceUp>k__BackingField.x, y = curState.<ReferenceUp>k__BackingField.z, z = val_39});
            this.m_ScreenOffsetPrevFrame = val_27;
            mem[1152921511709099980] = val_27.y;
            curState.<RawOrientation>k__BackingField.x = this.m_CameraOrientationPrevFrame;
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
        private UnityEngine.Rect ScreenToFOV(UnityEngine.Rect rScreen, float fov, float fovH, float aspect)
        {
            float val_7;
            UnityEngine.Matrix4x4 val_1 = UnityEngine.Matrix4x4.Perspective(fov:  fov, aspect:  aspect, zNear:  0.01f, zFar:  10000f);
            float val_23 = val_7;
            val_23 = val_23 + val_23;
            float val_24 = -1f;
            val_24 = val_23 + val_24;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.left;
            float val_12 = Cinemachine.Utility.UnityVectorExtensions.SignedAngle(from:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, refNormal:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.z});
            float val_25 = 0.5f;
            val_25 = fov * val_25;
            val_12 = val_25 + val_12;
            val_12 = val_12 / fov;
            val_12 = val_12 + val_12;
            float val_26 = -1f;
            val_26 = val_12 + val_26;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.left;
            float val_15 = Cinemachine.Utility.UnityVectorExtensions.SignedAngle(from:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, refNormal:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.z});
            val_15 = val_25 + val_15;
            val_15 = val_15 / fov;
            val_15 = val_15 + val_15;
            val_15 = val_15 + (-1f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.up;
            float val_18 = Cinemachine.Utility.UnityVectorExtensions.SignedAngle(from:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, refNormal:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.z});
            float val_19 = fovH * 0.5f;
            val_18 = val_19 + val_18;
            val_18 = val_18 / fovH;
            val_18 = val_18 + val_18;
            val_18 = val_18 + (-1f);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.up;
            float val_22 = Cinemachine.Utility.UnityVectorExtensions.SignedAngle(from:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, refNormal:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.z});
            val_22 = val_19 + val_22;
            val_22 = val_22 / fovH;
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        private bool RotateToScreenBounds(ref Cinemachine.CameraState state, UnityEngine.Rect screenRect, ref UnityEngine.Quaternion rigOrientation, float fov, float fovH, float deltaTime)
        {
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            float val_14;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<TrackedPoint>k__BackingField, y = V12.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = screenRect.m_XMin, y = screenRect.m_YMin, z = screenRect.m_Width});
            UnityEngine.Vector2 val_2 = Cinemachine.Utility.UnityQuaternionExtensions.GetCameraRotationToTarget(orient:  new UnityEngine.Quaternion() {x = rigOrientation.x, y = rigOrientation.y, z = rigOrientation.z, w = rigOrientation.w}, lookAtDir:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, worldUp:  new UnityEngine.Vector3() {x = state.<ReferenceUp>k__BackingField.x, y = state.<ReferenceUp>k__BackingField.z, z = screenRect.m_XMin});
            val_10 = val_1.y;
            bool val_3 = this.ClampVerticalBounds(r: ref  new UnityEngine.Rect() {m_XMin = screenRect.m_XMin, m_YMin = screenRect.m_YMin, m_Width = screenRect.m_Width, m_Height = screenRect.m_Height}, dir:  new UnityEngine.Vector3() {x = val_1.x, y = val_10, z = val_1.z}, up:  new UnityEngine.Vector3() {x = state.<ReferenceUp>k__BackingField.x, y = state.<ReferenceUp>k__BackingField.y, z = state.<ReferenceUp>k__BackingField.z}, fov:  fov);
            val_11 = val_1.x + (-0.5f);
            if(val_2.x < 0)
            {
                    val_12 = val_2.x - (val_11 * fov);
                val_13 = fovH;
            }
            else
            {
                    val_13 = fovH;
                val_11 = val_11 + (-0.5f);
                val_11 = val_11 * fov;
                if(val_2.x > val_11)
            {
                    val_12 = val_2.x - val_11;
            }
            else
            {
                    val_12 = 0f;
            }
            
            }
            
            val_11 = val_11 + (-0.5f);
            if(val_2.y < 0)
            {
                    val_14 = val_2.y - (val_11 * val_13);
            }
            else
            {
                    val_11 = val_11 + (-0.5f);
                val_11 = val_11 * val_13;
                if(val_2.y > val_11)
            {
                    val_14 = val_2.y - val_11;
            }
            else
            {
                    val_14 = 0f;
            }
            
            }
            
            if(deltaTime >= 0f)
            {
                    val_10 = this.m_HorizontalDamping;
                val_12 = Cinemachine.Utility.Damper.Damp(initial:  val_12, dampTime:  this.m_VerticalDamping, deltaTime:  deltaTime);
                val_14 = Cinemachine.Utility.Damper.Damp(initial:  val_14, dampTime:  val_10, deltaTime:  deltaTime);
            }
            
            UnityEngine.Quaternion val_8 = Cinemachine.Utility.UnityQuaternionExtensions.ApplyCameraRotation(orient:  new UnityEngine.Quaternion() {x = rigOrientation.x, y = rigOrientation.y, z = rigOrientation.z, w = rigOrientation.w}, rot:  new UnityEngine.Vector2() {x = val_12, y = val_14}, worldUp:  new UnityEngine.Vector3() {x = state.<ReferenceUp>k__BackingField.x, y = state.<ReferenceUp>k__BackingField.z, z = screenRect.m_XMin});
            rigOrientation.x = val_8.x;
            rigOrientation.y = val_8.y;
            rigOrientation.z = val_8.z;
            rigOrientation.w = val_8.w;
            return false;
        }
        private bool ClampVerticalBounds(ref UnityEngine.Rect r, UnityEngine.Vector3 dir, UnityEngine.Vector3 up, float fov)
        {
            float val_8;
            var val_9;
            val_8 = fov;
            float val_8 = up.z;
            float val_1 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = dir.x, y = dir.y, z = dir.z}, to:  new UnityEngine.Vector3() {x = up.x, y = up.y, z = val_8});
            float val_2 = val_8 * 0.5f;
            float val_3 = val_2 + 1f;
            if(val_1 >= 0)
            {
                goto label_4;
            }
            
            val_2 = val_3 - val_1;
            val_2 = val_2 / val_8;
            val_8 = 1f - val_2;
            if(1f <= val_8)
            {
                goto label_4;
            }
            
            val_8 = 1f;
            float val_5 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Min(a:  val_8, b:  val_8), b:  val_8);
            goto label_7;
            label_4:
            float val_9 = 180f;
            val_9 = val_9 - val_3;
            if(val_1 <= val_9)
            {
                goto label_9;
            }
            
            val_9 = val_1 - val_9;
            val_8 = val_9 / val_8;
            if(val_8 <= val_9)
            {
                goto label_9;
            }
            
            float val_7 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Max(a:  val_9, b:  val_8), b:  val_8);
            label_7:
            val_9 = 1;
            return (bool)val_9;
            label_9:
            val_9 = 0;
            return (bool)val_9;
        }
    
    }

}
