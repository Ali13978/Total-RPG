using UnityEngine;
public interface IPunTurnManagerCallbacks
{
    // Methods
    public abstract void OnTurnBegins(int turn); // 0
    public abstract void OnTurnCompleted(int turn); // 0
    public abstract void OnPlayerMove(PhotonPlayer player, int turn, object move); // 0
    public abstract void OnPlayerFinished(PhotonPlayer player, int turn, object move); // 0
    public abstract void OnTurnTimeEnds(int turn); // 0

}
