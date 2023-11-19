using UnityEngine;
[Serializable]
private class MazeBuildObject.SpawnInfo
{
    // Fields
    public UnityEngine.GameObject Prefab;
    public UnityEngine.Transform Parent;
    [UnityEngine.RangeAttribute]
    public float ChancePercent;
    
    // Methods
    public MazeBuildObject.SpawnInfo()
    {
        this.ChancePercent = 50f;
    }

}
