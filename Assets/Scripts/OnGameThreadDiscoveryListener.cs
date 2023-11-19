using UnityEngine;
protected class NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener : IDiscoveryListener
{
    // Fields
    private readonly GooglePlayGames.BasicApi.Nearby.IDiscoveryListener mListener;
    
    // Methods
    public NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener(GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener)
    {
        this.mListener = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
    }
    public void OnEndpointFound(GooglePlayGames.BasicApi.Nearby.EndpointDetails discoveredEndpoint)
    {
        if(null != 0)
        {
                typeof(NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener.<OnEndpointFound>c__AnonStorey0).__il2cppRuntimeField_20 = discoveredEndpoint.mServiceId;
            typeof(NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener.<OnEndpointFound>c__AnonStorey0).__il2cppRuntimeField_10 = discoveredEndpoint.mEndpointId;
        }
        else
        {
                mem[32] = discoveredEndpoint.mServiceId;
            mem[16] = discoveredEndpoint.mEndpointId;
        }
        
        typeof(NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener.<OnEndpointFound>c__AnonStorey0).__il2cppRuntimeField_28 = this;
        System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener.<OnEndpointFound>c__AnonStorey0::<>m__0());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }
    public void OnEndpointLost(string lostEndpointId)
    {
        if(null != 0)
        {
                typeof(NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener.<OnEndpointLost>c__AnonStorey1).__il2cppRuntimeField_10 = lostEndpointId;
        }
        else
        {
                mem[16] = lostEndpointId;
        }
        
        typeof(NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener.<OnEndpointLost>c__AnonStorey1).__il2cppRuntimeField_18 = this;
        System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void NativeNearbyConnectionsClient.OnGameThreadDiscoveryListener.<OnEndpointLost>c__AnonStorey1::<>m__0());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }

}
