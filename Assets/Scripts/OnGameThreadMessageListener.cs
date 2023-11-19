using UnityEngine;
protected class NativeNearbyConnectionsClient.OnGameThreadMessageListener : IMessageListener
{
    // Fields
    private readonly GooglePlayGames.BasicApi.Nearby.IMessageListener mListener;
    
    // Methods
    public NativeNearbyConnectionsClient.OnGameThreadMessageListener(GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
    {
        this.mListener = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
    }
    public void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage)
    {
        if(null != 0)
        {
                typeof(NativeNearbyConnectionsClient.OnGameThreadMessageListener.<OnMessageReceived>c__AnonStorey0).__il2cppRuntimeField_10 = remoteEndpointId;
            typeof(NativeNearbyConnectionsClient.OnGameThreadMessageListener.<OnMessageReceived>c__AnonStorey0).__il2cppRuntimeField_18 = data;
            typeof(NativeNearbyConnectionsClient.OnGameThreadMessageListener.<OnMessageReceived>c__AnonStorey0).__il2cppRuntimeField_20 = isReliableMessage;
        }
        else
        {
                mem[16] = remoteEndpointId;
            mem[24] = data;
            mem[32] = isReliableMessage;
        }
        
        typeof(NativeNearbyConnectionsClient.OnGameThreadMessageListener.<OnMessageReceived>c__AnonStorey0).__il2cppRuntimeField_28 = this;
        System.Action val_4 = new System.Action(object:  new System.Object(), method:  System.Void NativeNearbyConnectionsClient.OnGameThreadMessageListener.<OnMessageReceived>c__AnonStorey0::<>m__0());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }
    public void OnRemoteEndpointDisconnected(string remoteEndpointId)
    {
        if(null != 0)
        {
                typeof(NativeNearbyConnectionsClient.OnGameThreadMessageListener.<OnRemoteEndpointDisconnected>c__AnonStorey1).__il2cppRuntimeField_10 = remoteEndpointId;
        }
        else
        {
                mem[16] = remoteEndpointId;
        }
        
        typeof(NativeNearbyConnectionsClient.OnGameThreadMessageListener.<OnRemoteEndpointDisconnected>c__AnonStorey1).__il2cppRuntimeField_18 = this;
        System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void NativeNearbyConnectionsClient.OnGameThreadMessageListener.<OnRemoteEndpointDisconnected>c__AnonStorey1::<>m__0());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }

}
