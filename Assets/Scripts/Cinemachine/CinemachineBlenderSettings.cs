using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [Serializable]
    public sealed class CinemachineBlenderSettings : ScriptableObject
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineBlenderSettings.CustomBlend[] m_CustomBlends;
        public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**";
        
        // Methods
        public CinemachineBlenderSettings()
        {
        
        }
        public UnityEngine.AnimationCurve GetBlendCurveForVirtualCameras(string fromCameraName, string toCameraName, UnityEngine.AnimationCurve defaultCurve)
        {
            var val_13;
            UnityEngine.AnimationCurve val_14;
            CustomBlend[] val_15;
            var val_16;
            var val_17;
            var val_18;
            val_14 = defaultCurve;
            val_15 = this.m_CustomBlends;
            val_16 = 0;
            if(val_15 == null)
            {
                goto label_1;
            }
            
            val_13 = 1152921504608284672;
            val_17 = 0;
            val_14 = 24;
            goto label_2;
            label_36:
            val_15 = this.m_CustomBlends;
            val_17 = 1;
            label_2:
            if(val_17 >= this.m_CustomBlends.Length)
            {
                goto label_4;
            }
            
            var val_1 = this.m_CustomBlends + (1 * val_14);
            if((System.String.op_Equality(a:  0, b:  (1 * val_14) + this.m_CustomBlends + 32)) != false)
            {
                    if((System.String.op_Equality(a:  0, b:  (1 * val_14) + this.m_CustomBlends + 32)) == true)
            {
                goto label_12;
            }
            
            }
            
            if((System.String.op_Equality(a:  0, b:  (1 * val_14) + this.m_CustomBlends + 32)) == false)
            {
                goto label_15;
            }
            
            if(((System.String.IsNullOrEmpty(value:  0)) == true) || ((System.String.op_Equality(a:  0, b:  (1 * val_14) + this.m_CustomBlends + 32)) == false))
            {
                goto label_21;
            }
            
            goto label_36;
            label_15:
            if((((System.String.op_Equality(a:  0, b:  (1 * val_14) + this.m_CustomBlends + 32)) == false) || ((System.String.IsNullOrEmpty(value:  0)) == true)) || ((System.String.op_Equality(a:  0, b:  (1 * val_14) + this.m_CustomBlends + 32)) == false))
            {
                goto label_36;
            }
            
            goto label_36;
            label_21:
            if((System.String.op_Equality(a:  0, b:  (1 * val_14) + this.m_CustomBlends + 32)) == false)
            {
                goto label_36;
            }
            
            goto label_36;
            label_4:
            val_18 = ;
            val_14 = ;
            val_16 = ;
            if(((1 * val_14) + this.m_CustomBlends + 48) != 0)
            {
                    return (UnityEngine.AnimationCurve)val_18;
            }
            
            label_1:
            var val_13 = (val_16 == 0) ? (val_14) : (val_16);
            return (UnityEngine.AnimationCurve)val_18;
            label_12:
            val_18;
            return (UnityEngine.AnimationCurve)val_18;
        }
    
    }

}
