using UnityEngine;
[Cinemachine.DocumentationSortingAttribute]
[Serializable]
public struct CinemachineTrackedDolly.AutoDolly
{
    // Fields
    [UnityEngine.TooltipAttribute]
    public bool m_Enabled;
    [UnityEngine.TooltipAttribute]
    public float m_PositionOffset;
    [UnityEngine.TooltipAttribute]
    public int m_SearchRadius;
    [UnityEngine.Serialization.FormerlySerializedAsAttribute]
    [UnityEngine.TooltipAttribute]
    public int m_SearchResolution;
    
    // Methods
    public CinemachineTrackedDolly.AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment)
    {
        mem[1152921511721471972] = positionOffset;
        mem[1152921511721471976] = searchRadius;
        mem[1152921511721471980] = stepsPerSegment;
        mem[1152921511721471968] = enabled;
    }

}
