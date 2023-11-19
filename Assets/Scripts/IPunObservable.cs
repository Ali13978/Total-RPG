using UnityEngine;
public interface IPunObservable
{
    // Methods
    public abstract void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info); // 0

}
