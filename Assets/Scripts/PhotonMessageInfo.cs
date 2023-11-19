using UnityEngine;
public struct PhotonMessageInfo
{
    // Fields
    private readonly int timeInt;
    public readonly PhotonPlayer sender;
    public readonly PhotonView photonView;
    
    // Properties
    public double timestamp { get; }
    
    // Methods
    public PhotonMessageInfo(PhotonPlayer player, int timestamp, PhotonView view)
    {
        mem[1152921512396727144] = player;
        mem[1152921512396727152] = view;
        this.photonView = timestamp;
    }
    public double get_timestamp()
    {
        double val_1 = (double)this.photonView;
        val_1 = val_1 / 1000;
        return (double)val_1;
    }
    public override string ToString()
    {
    
    }

}
