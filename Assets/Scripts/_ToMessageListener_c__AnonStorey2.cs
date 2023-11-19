using UnityEngine;
private sealed class NativeNearbyConnectionsClient.<ToMessageListener>c__AnonStorey2
{
    // Fields
    internal GooglePlayGames.BasicApi.Nearby.IMessageListener listener;
    
    // Methods
    public NativeNearbyConnectionsClient.<ToMessageListener>c__AnonStorey2()
    {
    
    }
    internal void <>m__0(long localClientId, string endpointId, byte[] data, bool isReliable)
    {
        var val_3;
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_3 = this.listener;
        bool val_2 = isReliable;
    }
    internal void <>m__1(long localClientId, string endpointId)
    {
        var val_2;
        var val_2 = 0;
        val_2 = val_2 + 1;
        val_2 = this.listener;
    }

}
