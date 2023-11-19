using UnityEngine;
[Cinemachine.DocumentationSortingAttribute]
[Serializable]
public struct CinemachineOrbitalTransposer.Recentering
{
    // Fields
    [UnityEngine.TooltipAttribute]
    public bool m_enabled;
    [UnityEngine.TooltipAttribute]
    public float m_RecenterWaitTime;
    [UnityEngine.TooltipAttribute]
    public float m_RecenteringTime;
    [UnityEngine.SerializeField]
    [UnityEngine.HideInInspector]
    [UnityEngine.Serialization.FormerlySerializedAsAttribute]
    private int m_LegacyHeadingDefinition;
    [UnityEngine.SerializeField]
    [UnityEngine.HideInInspector]
    [UnityEngine.Serialization.FormerlySerializedAsAttribute]
    private int m_LegacyVelocityFilterStrength;
    
    // Methods
    public CinemachineOrbitalTransposer.Recentering(bool enabled, float recenterWaitTime, float recenteringSpeed)
    {
        mem[1152921511716864804] = recenterWaitTime;
        mem[1152921511716864808] = recenteringSpeed;
        this.m_LegacyVelocityFilterStrength = enabled;
        mem[1152921511716864812] = 0;
    }
    public void Validate()
    {
    
    }
    internal bool LegacyUpgrade(ref Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition heading, ref int velocityFilter)
    {
        if(W8 == 1)
        {
                return false;
        }
        
        if(W9 == 1)
        {
                return false;
        }
        
        heading = ;
        velocityFilter = ;
        mem[1152921511717096844] = 0;
        return true;
    }

}
