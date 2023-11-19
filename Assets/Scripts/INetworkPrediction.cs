using UnityEngine;
internal interface INetworkPrediction
{
    // Methods
    public abstract void SendClientAdjustment(); // 0
    public abstract void ForcePositionUpdate(double DeltaTime); // 0
    public abstract void SmoothCorrection(UnityEngine.Vector3 OldLocation); // 0
    public abstract FNetworkPredictionData_Client GetPredictionData_Client(); // 0
    public abstract FNetworkPredictionData_Server GetPredictionData_Server(); // 0
    public abstract bool HasPredictionData_Client(); // 0
    public abstract bool HasPredictionData_Server(); // 0
    public abstract void ResetPredictionData_Client(); // 0
    public abstract void ResetPredictionData_Server(); // 0

}
