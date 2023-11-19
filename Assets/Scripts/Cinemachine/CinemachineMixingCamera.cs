using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.DisallowMultipleComponent]
    [UnityEngine.AddComponentMenu]
    public class CinemachineMixingCamera : CinemachineVirtualCameraBase
    {
        // Fields
        public const int MaxCameras = 8;
        [UnityEngine.TooltipAttribute]
        public float m_Weight0;
        [UnityEngine.TooltipAttribute]
        public float m_Weight1;
        [UnityEngine.TooltipAttribute]
        public float m_Weight2;
        [UnityEngine.TooltipAttribute]
        public float m_Weight3;
        [UnityEngine.TooltipAttribute]
        public float m_Weight4;
        [UnityEngine.TooltipAttribute]
        public float m_Weight5;
        [UnityEngine.TooltipAttribute]
        public float m_Weight6;
        [UnityEngine.TooltipAttribute]
        public float m_Weight7;
        private Cinemachine.CameraState m_State;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.ICinemachineCamera <LiveChild>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Transform <LookAt>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Transform <Follow>k__BackingField;
        private Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;
        private System.Collections.Generic.Dictionary<Cinemachine.CinemachineVirtualCameraBase, int> m_indexMap;
        
        // Properties
        private Cinemachine.ICinemachineCamera LiveChild { get; set; }
        public override Cinemachine.CameraState State { get; }
        public override UnityEngine.Transform LookAt { get; set; }
        public override UnityEngine.Transform Follow { get; set; }
        public override Cinemachine.ICinemachineCamera LiveChildOrSelf { get; }
        public Cinemachine.CinemachineVirtualCameraBase[] ChildCameras { get; }
        
        // Methods
        public CinemachineMixingCamera()
        {
            this.m_Weight4 = 0.5f;
            this.m_Weight5 = 0f;
            this.m_Weight6 = 0.5f;
            this.m_Weight7 = 0f;
            this.m_Weight0 = 0.5f;
            this.m_Weight1 = 0f;
            this.m_Weight2 = 0.5f;
            this.m_Weight3 = 0f;
            Cinemachine.CameraState val_1 = Cinemachine.CameraState.Default;
        }
        public float GetWeight(int index)
        {
            var val_2 = (index < 8) ? (index + 3) : 0;
            val_2 = val_2 - 3;
            if(val_2 <= 7)
            {
                    var val_4 = 25808296 + ((index < 8 ? (index + 3) : 0 - 3)) << 2;
                val_4 = val_4 + 25808296;
            }
            else
            {
                    this = 0 + "CinemachineMixingCamera: Invalid index: "("CinemachineMixingCamera: Invalid index: ");
                UnityEngine.Debug.LogError(message:  0);
                return 0f;
            }
        
        }
        public void SetWeight(int index, float w)
        {
            var val_2 = (index < 8) ? (index + 3) : 0;
            val_2 = val_2 - 3;
            if(val_2 <= 7)
            {
                    var val_4 = 25808328 + ((index < 8 ? (index + 3) : 0 - 3)) << 2;
                val_4 = val_4 + 25808328;
            }
            else
            {
                    this = 0 + "CinemachineMixingCamera: Invalid index: "("CinemachineMixingCamera: Invalid index: ");
                UnityEngine.Debug.LogError(message:  0);
            }
        
        }
        public float GetWeight(Cinemachine.CinemachineVirtualCameraBase vcam)
        {
            Cinemachine.CinemachineVirtualCameraBase val_7;
            var val_8;
            val_7 = vcam;
            if((this.m_indexMap.TryGetValue(key:  val_7, value: out  0)) != false)
            {
                    float val_3 = this.GetWeight(index:  0);
                return 0f;
            }
            
            if(0 != val_7)
            {
                    val_8 = val_7.Name;
            }
            else
            {
                    val_8 = "(null)";
            }
            
            val_7 = 0 + "CinemachineMixingCamera: Invalid child: "("CinemachineMixingCamera: Invalid child: ");
            UnityEngine.Debug.LogError(message:  0);
            return 0f;
        }
        public void SetWeight(Cinemachine.CinemachineVirtualCameraBase vcam, float w)
        {
            Cinemachine.CinemachineVirtualCameraBase val_6;
            var val_7;
            val_6 = vcam;
            if((this.m_indexMap.TryGetValue(key:  val_6, value: out  0)) != false)
            {
                    this.SetWeight(index:  0, w:  w);
                return;
            }
            
            if(0 != val_6)
            {
                    val_7 = val_6.Name;
            }
            else
            {
                    val_7 = "(null)";
            }
            
            val_6 = 0 + "CinemachineMixingCamera: Invalid child: "("CinemachineMixingCamera: Invalid child: ");
            UnityEngine.Debug.LogError(message:  0);
        }
        private void set_LiveChild(Cinemachine.ICinemachineCamera value)
        {
            this.<LiveChild>k__BackingField = value;
        }
        private Cinemachine.ICinemachineCamera get_LiveChild()
        {
            return (Cinemachine.ICinemachineCamera)this.<LiveChild>k__BackingField;
        }
        public override Cinemachine.CameraState get_State()
        {
        
        }
        public override UnityEngine.Transform get_LookAt()
        {
            return (UnityEngine.Transform)this.<LookAt>k__BackingField;
        }
        public override void set_LookAt(UnityEngine.Transform value)
        {
            this.<LookAt>k__BackingField = value;
        }
        public override UnityEngine.Transform get_Follow()
        {
            return (UnityEngine.Transform)this.<Follow>k__BackingField;
        }
        public override void set_Follow(UnityEngine.Transform value)
        {
            this.<Follow>k__BackingField = value;
        }
        public override Cinemachine.ICinemachineCamera get_LiveChildOrSelf()
        {
            return (Cinemachine.ICinemachineCamera)this.<LiveChild>k__BackingField;
        }
        public override void RemovePostPipelineStageHook(Cinemachine.CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
        {
            var val_1;
            this.RemovePostPipelineStageHook(d:  d);
            this.ValidateListOfChildren();
            val_1 = 0;
            goto label_0;
            label_5:
            val_1 = 1;
            label_0:
            if(val_1 >= this.m_ChildCameras.Length)
            {
                    return;
            }
            
            if(this.m_ChildCameras[1] != null)
            {
                goto label_5;
            }
            
            goto label_5;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.<LiveChild>k__BackingField = 0;
            this.m_ChildCameras = 0;
            this.m_indexMap = 0;
        }
        public void OnTransformChildrenChanged()
        {
            this.<LiveChild>k__BackingField = 0;
            this.m_ChildCameras = 0;
            this.m_indexMap = 0;
        }
        protected override void OnValidate()
        {
            this.OnValidate();
            var val_3 = 0;
            do
            {
                this.SetWeight(index:  0, w:  UnityEngine.Mathf.Max(a:  0f, b:  this.GetWeight(index:  0)));
                val_3 = val_3 + 1;
            }
            while(val_3 != 8);
        
        }
        public override bool IsLiveChild(Cinemachine.ICinemachineCamera vcam)
        {
            var val_2;
            this.ValidateListOfChildren();
            val_2 = 0;
            label_4:
            if(val_2 >= (this.m_ChildCameras.Length << ))
            {
                    return false;
            }
            
            if(null == vcam)
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            if(val_2 <= 7)
            {
                goto label_4;
            }
            
            return false;
            label_3:
            if((this.GetWeight(index:  0)) <= 0.0001f)
            {
                    return false;
            }
            
            if(null != null)
            {
                    return 1152921507351368464.isActiveAndEnabled;
            }
            
            return 1152921507351368464.isActiveAndEnabled;
        }
        public Cinemachine.CinemachineVirtualCameraBase[] get_ChildCameras()
        {
            this.ValidateListOfChildren();
            return (Cinemachine.CinemachineVirtualCameraBase[])this.m_ChildCameras;
        }
        protected void InvalidateListOfChildren()
        {
            this.<LiveChild>k__BackingField = 0;
            this.m_ChildCameras = 0;
            this.m_indexMap = 0;
        }
        protected void ValidateListOfChildren()
        {
            var val_11;
            int val_12;
            if(this.m_ChildCameras != null)
            {
                    return;
            }
            
            this.m_indexMap = new System.Collections.Generic.Dictionary<Cinemachine.CinemachineVirtualCameraBase, System.Int32>();
            System.Collections.Generic.List<Cinemachine.CinemachineVirtualCameraBase> val_2 = new System.Collections.Generic.List<Cinemachine.CinemachineVirtualCameraBase>();
            val_11 = 0;
            goto label_2;
            label_15:
            val_11 = 1;
            label_2:
            if(val_11 >= val_3.Length)
            {
                goto label_4;
            }
            
            T val_11 = this.GetComponentsInChildren<Cinemachine.CinemachineVirtualCameraBase>(includeInactive:  true)[1];
            UnityEngine.Transform val_6 = this.transform;
            if(0 != val_11.transform.parent)
            {
                goto label_15;
            }
            
            if(null != 0)
            {
                    val_12 = Count;
            }
            else
            {
                    val_12 = Count;
            }
            
            Add(item:  val_11);
            if(val_12 > 7)
            {
                goto label_15;
            }
            
            this.m_indexMap.Add(key:  val_11, value:  val_12);
            goto label_15;
            label_4:
            this.m_ChildCameras = ToArray();
        }
        public override void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime)
        {
            float val_5;
            this.ValidateListOfChildren();
            this.<LiveChild>k__BackingField = 0;
            var val_6 = 0;
            val_5 = 0f;
            float val_5 = 0f;
            label_16:
            if(val_6 >= (this.m_ChildCameras.Length << ))
            {
                    return;
            }
            
            if(1152921507351368464.isActiveAndEnabled == false)
            {
                goto label_15;
            }
            
            float val_3 = UnityEngine.Mathf.Max(a:  0f, b:  this.GetWeight(index:  0));
            if(val_3 <= 0.0001f)
            {
                goto label_15;
            }
            
            val_5 = val_5 + val_3;
            if(val_5 == val_3)
            {
                    if(null != null)
            {
                goto label_11;
            }
            
            }
            else
            {
                    val_3 = val_3 / val_5;
                Cinemachine.CameraState val_4 = Cinemachine.CameraState.Lerp(stateA:  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {<Orthographic>k__BackingField = false}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3(), <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3(), <RawPosition>k__BackingField = new UnityEngine.Vector3(), <RawOrientation>k__BackingField = new UnityEngine.Quaternion(), <PositionDampingBypass>k__BackingField = new UnityEngine.Vector3(), <PositionCorrection>k__BackingField = new UnityEngine.Vector3(), <OrientationCorrection>k__BackingField = new UnityEngine.Quaternion(), mCustom0 = new CustomBlendable(), mCustom1 = new CustomBlendable(), mCustom2 = new CustomBlendable(), mCustom3 = new CustomBlendable()}, stateB:  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {<Orthographic>k__BackingField = false}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3(), <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3(), <RawPosition>k__BackingField = new UnityEngine.Vector3(), <RawOrientation>k__BackingField = new UnityEngine.Quaternion(), <PositionDampingBypass>k__BackingField = new UnityEngine.Vector3(), <PositionCorrection>k__BackingField = new UnityEngine.Vector3(), <OrientationCorrection>k__BackingField = new UnityEngine.Quaternion(), mCustom0 = new CustomBlendable(), mCustom1 = new CustomBlendable(), mCustom2 = new CustomBlendable(), mCustom3 = new CustomBlendable()}, t:  val_3);
            }
            
            label_11:
            if(val_3 > val_5)
            {
                    val_5 = val_3;
                this.<LiveChild>k__BackingField = null;
            }
            
            label_15:
            val_6 = val_6 + 1;
            if(val_6 <= 7)
            {
                goto label_16;
            }
        
        }
    
    }

}
