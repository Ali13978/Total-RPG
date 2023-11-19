using UnityEngine;
private struct CinemachineCore.UpdateStatus
{
    // Fields
    private const int kWindowSize = 30;
    public int lastUpdateFrame;
    public int lastUpdateSubframe;
    public int windowStart;
    public int numWindowLateUpdateMoves;
    public int numWindowFixedUpdateMoves;
    public int numWindows;
    public Cinemachine.CinemachineCore.UpdateFilter preferredUpdate;
    public UnityEngine.Matrix4x4 targetPos;
    
    // Methods
    public CinemachineCore.UpdateStatus(int currentFrame)
    {
    
    }
    public Cinemachine.CinemachineCore.UpdateFilter ChoosePreferredUpdate(int currentFrame, UnityEngine.Matrix4x4 pos, Cinemachine.CinemachineCore.UpdateFilter updateFilter)
    {
        return (UpdateFilter)this.numWindowFixedUpdateMoves;
    }

}
