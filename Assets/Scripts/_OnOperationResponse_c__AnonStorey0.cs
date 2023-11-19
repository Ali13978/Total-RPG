using UnityEngine;
private sealed class NetworkingPeer.<OnOperationResponse>c__AnonStorey0
{
    // Fields
    internal CloudRegionCode bestFromPrefs;
    
    // Methods
    public NetworkingPeer.<OnOperationResponse>c__AnonStorey0()
    {
    
    }
    internal bool <>m__0(Region x)
    {
        return (bool)(x.Code == this.bestFromPrefs) ? 1 : 0;
    }

}
