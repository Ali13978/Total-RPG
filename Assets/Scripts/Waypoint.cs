using UnityEngine;
[Cinemachine.DocumentationSortingAttribute]
[Serializable]
public struct CinemachineSmoothPath.Waypoint
{
    // Fields
    [UnityEngine.TooltipAttribute]
    public UnityEngine.Vector3 position;
    [UnityEngine.TooltipAttribute]
    public float roll;
    
    // Properties
    internal UnityEngine.Vector4 AsVector4 { get; }
    
    // Methods
    internal UnityEngine.Vector4 get_AsVector4()
    {
    
    }
    internal static Cinemachine.CinemachineSmoothPath.Waypoint FromVector4(UnityEngine.Vector4 v)
    {
        return new Waypoint() {position = new UnityEngine.Vector3() {x = -7.08012E-16f, y = 2.524355E-29f, z = 4.203895E-45f}, roll = 0f};
    }

}
