using UnityEngine;
public class Network_Photon.NetworkMessageInfo_Photon : INetworkMessageInfo
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private TzarGames.GameFramework.NetworkPlayer <Sender>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private double <Timestamp>k__BackingField;
    
    // Properties
    public TzarGames.GameFramework.NetworkPlayer Sender { get; set; }
    public double Timestamp { get; set; }
    
    // Methods
    public Network_Photon.NetworkMessageInfo_Photon(TzarGames.GameFramework.NetworkPlayer sender, double timeStamp)
    {
        this.<Timestamp>k__BackingField = timeStamp;
        this.<Sender>k__BackingField = sender;
    }
    public TzarGames.GameFramework.NetworkPlayer get_Sender()
    {
        return (TzarGames.GameFramework.NetworkPlayer)this.<Sender>k__BackingField;
    }
    private void set_Sender(TzarGames.GameFramework.NetworkPlayer value)
    {
        this.<Sender>k__BackingField = value;
    }
    public double get_Timestamp()
    {
        return (double)this.<Timestamp>k__BackingField;
    }
    private void set_Timestamp(double value)
    {
        this.<Timestamp>k__BackingField = value;
    }

}
