using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.AddComponentMenu]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineFollowZoom : CinemachineExtension
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public float m_Width;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_Damping;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_MinFOV;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_MaxFOV;
        
        // Methods
        public CinemachineFollowZoom()
        {
            this.m_Width = ;
            this.m_Damping = ;
            this.m_MinFOV = 3f;
            this.m_MaxFOV = 60f;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void OnValidate()
        {
            this.m_Width = UnityEngine.Mathf.Max(a:  0f, b:  this.m_Width);
            float val_2 = UnityEngine.Mathf.Clamp(value:  this.m_MaxFOV, min:  1f, max:  179f);
            this.m_MaxFOV = val_2;
            this.m_MinFOV = UnityEngine.Mathf.Clamp(value:  this.m_MinFOV, min:  1f, max:  val_2);
        }
        protected override void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, ref Cinemachine.CameraState state, float deltaTime)
        {
            float val_13;
            float val_14;
            var val_15;
            var val_16;
            float val_17;
            float val_18;
            float val_20;
            val_14 = deltaTime;
            val_15 = 1152921511671354704;
            val_16 = this;
            CinemachineFollowZoom.VcamExtraState val_1 = this.GetExtraState<CinemachineFollowZoom.VcamExtraState>(vcam:  vcam);
            if(val_14 >= 0)
            {
                    if(this.enabled ^ 1 == false)
            {
                goto label_2;
            }
            
            }
            
            val_13 = state.<Lens>k__BackingField.FieldOfView;
            val_1.m_previousFrameZoom = val_13;
            label_2:
            if(stage != 0)
            {
                    return;
            }
            
            float val_4 = UnityEngine.Mathf.Max(a:  this.m_Width, b:  0f);
            val_17 = val_4;
            val_18 = state.<ReferenceLookAt>k__BackingField.z;
            float val_14 = V2.16B;
            float val_13 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_4, y = 0f, z = val_14}, b:  new UnityEngine.Vector3() {x = state.<ReferenceLookAt>k__BackingField.x, y = state.<ReferenceLookAt>k__BackingField.y, z = val_18});
            if(val_13 > 0.0001f)
            {
                    val_18 = 0.01745329f;
                float val_6 = this.m_MinFOV * val_18;
                val_6 = val_6 * 0.5f;
                float val_7 = val_13 + val_13;
                val_13 = val_7 * val_6;
                float val_8 = this.m_MaxFOV * val_18;
                val_8 = val_8 * 0.5f;
                val_14 = val_7 * val_8;
                val_17 = UnityEngine.Mathf.Clamp(value:  val_17, min:  val_13, max:  val_14);
                if((val_14 >= 0f) && (this.m_Damping > 0f))
            {
                    float val_15 = val_1.m_previousFrameZoom;
                float val_10 = val_15 * val_18;
                val_10 = val_10 * 0.5f;
                val_15 = val_7 * val_10;
                val_10 = val_17 - val_15;
                float val_11 = Cinemachine.Utility.Damper.Damp(initial:  val_10, dampTime:  this.m_Damping, deltaTime:  val_14);
                val_17 = val_15 + val_11;
            }
            
                val_11 = val_17 / val_7;
                val_11 = val_11 + val_11;
                val_20 = val_11 * 57.29578f;
            }
            else
            {
                    val_20 = 179f;
            }
            
            val_16 = 1152921511671354708;
            val_14 = UnityEngine.Mathf.Clamp(value:  val_20, min:  this.m_MinFOV, max:  this.m_MaxFOV);
            val_1.m_previousFrameZoom = val_14;
            state.<Lens>k__BackingField.FieldOfView = val_14;
            state.<Lens>k__BackingField.<Orthographic>k__BackingField = state.<Lens>k__BackingField.<Orthographic>k__BackingField;
            state.<Lens>k__BackingField.OrthographicSize = state.<Lens>k__BackingField.OrthographicSize;
        }
    
    }

}
