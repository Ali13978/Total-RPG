using UnityEngine;
private sealed class NativeNearbyConnectionsClient.<ToDiscoveryListener>c__AnonStorey3
{
    // Fields
    internal GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener;
    
    // Methods
    public NativeNearbyConnectionsClient.<ToDiscoveryListener>c__AnonStorey3()
    {
    
    }
    internal void <>m__0(long localClientId, GooglePlayGames.Native.PInvoke.NativeEndpointDetails endpoint)
    {
        var val_5;
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_1 = endpoint.ToDetails();
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_5 = this.listener;
    }
    internal void <>m__1(long localClientId, string lostEndpointId)
    {
        var val_2;
        var val_2 = 0;
        val_2 = val_2 + 1;
        val_2 = this.listener;
    }

}
