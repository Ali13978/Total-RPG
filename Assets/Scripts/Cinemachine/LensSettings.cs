using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [Serializable]
    public struct LensSettings
    {
        // Fields
        public static Cinemachine.LensSettings Default;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float FieldOfView;
        [UnityEngine.TooltipAttribute]
        public float OrthographicSize;
        [UnityEngine.TooltipAttribute]
        public float NearClipPlane;
        [UnityEngine.TooltipAttribute]
        public float FarClipPlane;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public float Dutch;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <Orthographic>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <Aspect>k__BackingField;
        
        // Properties
        internal bool Orthographic { get; set; }
        internal float Aspect { get; set; }
        
        // Methods
        public LensSettings(float fov, float orthographicSize, float nearClip, float farClip, float dutch, bool ortho, float aspect)
        {
            this.<Aspect>k__BackingField = 0f;
            mem[1152921511747521020] = 0;
            mem[1152921511747521024] = 0;
            this.Dutch = 0f;
            this.<Orthographic>k__BackingField = false;
            mem[1152921511747521013] = 0;
            this.Dutch = fov;
            this.<Orthographic>k__BackingField = orthographicSize;
            this.<Aspect>k__BackingField = nearClip;
            mem[1152921511747521020] = farClip;
            mem[1152921511747521024] = dutch;
            mem[1152921511747521028] = ortho;
            mem[1152921511747521032] = aspect;
        }
        internal bool get_Orthographic()
        {
            return (bool)this;
        }
        internal void set_Orthographic(bool value)
        {
            mem[1152921511747745028] = value;
        }
        internal float get_Aspect()
        {
            return (float)S0;
        }
        internal void set_Aspect(float value)
        {
            mem[1152921511747969032] = value;
        }
        public static Cinemachine.LensSettings FromCamera(UnityEngine.Camera fromCamera)
        {
            var val_14;
            Cinemachine.LensSettings val_15;
            float val_16;
            float val_17;
            float val_18;
            bool val_19;
            float val_20;
            bool val_21;
            Cinemachine.LensSettings val_0;
            val_14 = null;
            val_14 = null;
            val_15 = Cinemachine.LensSettings.Default;
            if(0 != X1)
            {
                    if(X1 != 0)
            {
                    val_15 = X1.fieldOfView;
                val_16 = X1.orthographicSize;
                val_17 = X1.nearClipPlane;
                val_18 = X1.farClipPlane;
                val_21 = X1.orthographic;
            }
            else
            {
                    val_15 = 0.fieldOfView;
                val_16 = 0.orthographicSize;
                val_17 = 0.nearClipPlane;
                val_18 = 0.farClipPlane;
                val_21 = 0.orthographic;
            }
            
                val_19 = val_21;
                val_20 = X1.aspect;
            }
            
            val_0.FieldOfView = val_15;
            val_0.OrthographicSize = val_16;
            val_0.NearClipPlane = val_17;
            val_0.FarClipPlane = val_18;
            val_0.Dutch = Cinemachine.LensSettings.Default.__il2cppRuntimeField_10;
            val_0.<Orthographic>k__BackingField = val_19;
            mem[1152921511748125207] = Cinemachine.LensSettings.Default.__il2cppRuntimeField_17;
            mem[1152921511748125205] = Cinemachine.LensSettings.Default.__il2cppRuntimeField_15;
            val_0.<Aspect>k__BackingField = val_20;
            return val_0;
        }
        public static Cinemachine.LensSettings Lerp(Cinemachine.LensSettings lensA, Cinemachine.LensSettings lensB, float t)
        {
            var val_8;
            Cinemachine.LensSettings val_0;
            float val_1 = UnityEngine.Mathf.Clamp01(value:  t);
            float val_3 = UnityEngine.Mathf.Lerp(a:  lensB.NearClipPlane, b:  X2 + 8, t:  val_1);
            float val_5 = UnityEngine.Mathf.Lerp(a:  lensB.OrthographicSize, b:  X2 + 4, t:  val_1);
            float val_6 = UnityEngine.Mathf.Lerp(a:  lensB.Dutch, b:  X2 + 16, t:  val_1);
            float val_7 = UnityEngine.Mathf.Lerp(a:  lensB.<Aspect>k__BackingField, b:  X2 + 24, t:  val_1);
            if((lensB.<Orthographic>k__BackingField) != false)
            {
                    val_8 = mem[X2 + 20];
                val_8 = X2 + 20;
            }
            else
            {
                    val_8 = 0;
            }
            
            val_0.FarClipPlane = UnityEngine.Mathf.Lerp(a:  lensB.FarClipPlane, b:  X2 + 12, t:  val_1);
            val_0.FieldOfView = UnityEngine.Mathf.Lerp(a:  lensB.FieldOfView, b:  X2, t:  val_1);
            return val_0;
        }
        public void Validate()
        {
        
        }
        private static LensSettings()
        {
            Cinemachine.LensSettings.Default.__il2cppRuntimeField_14 = 0;
            Cinemachine.LensSettings.Default = ;
            Cinemachine.LensSettings.Default.__il2cppRuntimeField_10 = 0;
            Cinemachine.LensSettings.Default.__il2cppRuntimeField_17 = 0;
            Cinemachine.LensSettings.Default.__il2cppRuntimeField_15 = 0;
            Cinemachine.LensSettings.Default.__il2cppRuntimeField_18 = 1065353216;
        }
    
    }

}
