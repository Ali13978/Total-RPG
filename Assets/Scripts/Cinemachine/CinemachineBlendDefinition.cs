using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [Serializable]
    public struct CinemachineBlendDefinition
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineBlendDefinition.Style m_Style;
        [UnityEngine.TooltipAttribute]
        public float m_Time;
        
        // Properties
        public UnityEngine.AnimationCurve BlendCurve { get; }
        
        // Methods
        public CinemachineBlendDefinition(Cinemachine.CinemachineBlendDefinition.Style style, float time)
        {
            mem[1152921511730412816] = style;
            mem[1152921511730412820] = time;
        }
        public UnityEngine.AnimationCurve get_BlendCurve()
        {
        
        }
    
    }

}
