using UnityEngine;
[Cinemachine.DocumentationSortingAttribute]
[Serializable]
public struct CinemachineOrbitalTransposer.Heading
{
    // Fields
    [UnityEngine.TooltipAttribute]
    public Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition m_HeadingDefinition;
    [UnityEngine.RangeAttribute]
    [UnityEngine.TooltipAttribute]
    public int m_VelocityFilterStrength;
    [UnityEngine.RangeAttribute]
    [UnityEngine.TooltipAttribute]
    public float m_HeadingBias;
    
    // Methods
    public CinemachineOrbitalTransposer.Heading(Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition def, int filterStrength, float bias)
    {
        mem[1152921511716748704] = def;
        mem[1152921511716748708] = filterStrength;
        mem[1152921511716748712] = bias;
    }

}
