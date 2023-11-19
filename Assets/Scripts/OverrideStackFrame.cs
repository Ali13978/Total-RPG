using UnityEngine;
private class CinemachineBrain.OverrideStackFrame
{
    // Fields
    public int id;
    public Cinemachine.ICinemachineCamera camera;
    public Cinemachine.CinemachineBlend blend;
    public float deltaTime;
    public float timeOfOverride;
    
    // Properties
    public bool Active { get; }
    public bool Expired { get; }
    
    // Methods
    public CinemachineBrain.OverrideStackFrame()
    {
    
    }
    public bool get_Active()
    {
        return (bool)(this.camera != 0) ? 1 : 0;
    }
    public bool get_Expired()
    {
        var val_7;
        if(UnityEngine.Application.isPlaying == false)
        {
                return (bool)((UnityEngine.Time.realtimeSinceStartup - this.timeOfOverride) > UnityEngine.Time.maximumDeltaTime) ? 1 : 0;
        }
        
        val_7 = 0;
        return (bool)((UnityEngine.Time.realtimeSinceStartup - this.timeOfOverride) > UnityEngine.Time.maximumDeltaTime) ? 1 : 0;
    }

}
