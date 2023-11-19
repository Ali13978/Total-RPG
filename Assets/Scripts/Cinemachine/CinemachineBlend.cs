using UnityEngine;

namespace Cinemachine
{
    public class CinemachineBlend
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.ICinemachineCamera <CamA>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.ICinemachineCamera <CamB>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.AnimationCurve <BlendCurve>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <TimeInBlend>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <Duration>k__BackingField;
        
        // Properties
        public Cinemachine.ICinemachineCamera CamA { get; set; }
        public Cinemachine.ICinemachineCamera CamB { get; set; }
        public UnityEngine.AnimationCurve BlendCurve { get; set; }
        public float TimeInBlend { get; set; }
        public float BlendWeight { get; }
        public bool IsValid { get; }
        public float Duration { get; set; }
        public bool IsComplete { get; }
        public string Description { get; }
        public Cinemachine.CameraState State { get; }
        
        // Methods
        public CinemachineBlend(Cinemachine.ICinemachineCamera a, Cinemachine.ICinemachineCamera b, UnityEngine.AnimationCurve curve, float duration, float t)
        {
            val_1 = new System.Object();
            if((a != null) && (b != null))
            {
                    this.<CamA>k__BackingField = a;
                this.<CamB>k__BackingField = b;
                this.<BlendCurve>k__BackingField = val_1;
                this.<TimeInBlend>k__BackingField = t;
                this.<Duration>k__BackingField = duration;
                return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "Blend cameras cannot be null");
        }
        public Cinemachine.ICinemachineCamera get_CamA()
        {
            return (Cinemachine.ICinemachineCamera)this.<CamA>k__BackingField;
        }
        public void set_CamA(Cinemachine.ICinemachineCamera value)
        {
            this.<CamA>k__BackingField = value;
        }
        public Cinemachine.ICinemachineCamera get_CamB()
        {
            return (Cinemachine.ICinemachineCamera)this.<CamB>k__BackingField;
        }
        public void set_CamB(Cinemachine.ICinemachineCamera value)
        {
            this.<CamB>k__BackingField = value;
        }
        public UnityEngine.AnimationCurve get_BlendCurve()
        {
            return (UnityEngine.AnimationCurve)this.<BlendCurve>k__BackingField;
        }
        public void set_BlendCurve(UnityEngine.AnimationCurve value)
        {
            this.<BlendCurve>k__BackingField = value;
        }
        public float get_TimeInBlend()
        {
            return (float)this.<TimeInBlend>k__BackingField;
        }
        public void set_TimeInBlend(float value)
        {
            this.<TimeInBlend>k__BackingField = value;
        }
        public float get_BlendWeight()
        {
            if((this.<BlendCurve>k__BackingField) == null)
            {
                    return 0f;
            }
            
            return this.<BlendCurve>k__BackingField.Evaluate(time:  this.<TimeInBlend>k__BackingField);
        }
        public bool get_IsValid()
        {
            if((this.<CamA>k__BackingField) == null)
            {
                    return (bool)((this.<CamB>k__BackingField) != 0) ? 1 : 0;
            }
            
            return true;
        }
        public float get_Duration()
        {
            return (float)this.<Duration>k__BackingField;
        }
        public void set_Duration(float value)
        {
            this.<Duration>k__BackingField = value;
        }
        public bool get_IsComplete()
        {
            return (bool)((this.<TimeInBlend>k__BackingField) >= (this.<Duration>k__BackingField)) ? 1 : 0;
        }
        public string get_Description()
        {
            var val_7;
            var val_8;
            var val_9;
            object val_10;
            int val_11;
            if((this.<CamA>k__BackingField) == null)
            {
                goto label_1;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = this.<CamA>k__BackingField;
            goto label_5;
            label_1:
            val_8 = "(none)";
            goto label_6;
            label_5:
            val_8 = 0 + "[" + this.<CamA>k__BackingField(this.<CamA>k__BackingField);
            label_6:
            if((this.<CamB>k__BackingField) == null)
            {
                goto label_9;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = this.<CamB>k__BackingField;
            goto label_13;
            label_9:
            val_10 = "(none)";
            goto label_14;
            label_13:
            val_10 = 0 + "[" + this.<CamB>k__BackingField(this.<CamB>k__BackingField);
            label_14:
            if((this.<BlendCurve>k__BackingField) != null)
            {
                    float val_5 = this.<BlendCurve>k__BackingField.Evaluate(time:  this.<TimeInBlend>k__BackingField);
                val_5 = val_5 * 100f;
                val_11 = (int)val_5;
                return (string)System.String.Format(format:  0, arg0:  "{0} {1}% from {2}", arg1:  val_10, arg2:  val_11 = 0);
            }
            
            return (string)System.String.Format(format:  0, arg0:  "{0} {1}% from {2}", arg1:  val_10, arg2:  val_11);
        }
        public bool Uses(Cinemachine.ICinemachineCamera cam)
        {
            Cinemachine.ICinemachineCamera val_2;
            var val_3;
            var val_4;
            if((this.<CamA>k__BackingField) == cam)
            {
                goto label_8;
            }
            
            val_2 = this.<CamB>k__BackingField;
            if(val_2 == cam)
            {
                goto label_8;
            }
            
            val_3 = null;
            if((this.<CamA>k__BackingField) == null)
            {
                goto label_5;
            }
            
            if((0 & 1) != 0)
            {
                goto label_8;
            }
            
            val_2 = this.<CamB>k__BackingField;
            val_3 = null;
            label_5:
            if((val_2 == null) || ((0 & 1) == 0))
            {
                goto label_14;
            }
            
            label_8:
            val_4 = 1;
            return (bool)val_4;
            label_14:
            val_4 = 0;
            return (bool)val_4;
        }
        public void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime)
        {
            bool val_2 = Cinemachine.CinemachineCore.Instance.UpdateVirtualCamera(vcam:  this.<CamA>k__BackingField, worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  deltaTime);
            bool val_4 = Cinemachine.CinemachineCore.Instance.UpdateVirtualCamera(vcam:  this.<CamB>k__BackingField, worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  deltaTime);
        }
        public Cinemachine.CameraState get_State()
        {
            var val_5;
            var val_6;
            float val_7;
            Cinemachine.CameraState val_0;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = this.<CamA>k__BackingField;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = this.<CamB>k__BackingField;
            if((this.<BlendCurve>k__BackingField) != null)
            {
                    val_7 = this.<BlendCurve>k__BackingField.Evaluate(time:  this.<TimeInBlend>k__BackingField);
            }
            else
            {
                    val_7 = 0f;
            }
            
            Cinemachine.CameraState val_4 = Cinemachine.CameraState.Lerp(stateA:  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {<Orthographic>k__BackingField = false}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3(), <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3(), <RawPosition>k__BackingField = new UnityEngine.Vector3(), <RawOrientation>k__BackingField = new UnityEngine.Quaternion(), <PositionDampingBypass>k__BackingField = new UnityEngine.Vector3(), <PositionCorrection>k__BackingField = new UnityEngine.Vector3(), <OrientationCorrection>k__BackingField = new UnityEngine.Quaternion(), mCustom0 = new CustomBlendable(), mCustom1 = new CustomBlendable(), mCustom2 = new CustomBlendable(), mCustom3 = new CustomBlendable()}, stateB:  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {<Orthographic>k__BackingField = false}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3(), <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3(), <RawPosition>k__BackingField = new UnityEngine.Vector3(), <RawOrientation>k__BackingField = new UnityEngine.Quaternion(), <PositionDampingBypass>k__BackingField = new UnityEngine.Vector3(), <PositionCorrection>k__BackingField = new UnityEngine.Vector3(), <OrientationCorrection>k__BackingField = new UnityEngine.Quaternion(), mCustom0 = new CustomBlendable(), mCustom1 = new CustomBlendable(), mCustom2 = new CustomBlendable(), mCustom3 = new CustomBlendable()}, t:  val_7);
            return val_0;
        }
    
    }

}
