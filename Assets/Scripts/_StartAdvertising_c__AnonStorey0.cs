using UnityEngine;
private sealed class NativeNearbyConnectionsClient.<StartAdvertising>c__AnonStorey0
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback;
    internal System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> requestCallback;
    
    // Methods
    public NativeNearbyConnectionsClient.<StartAdvertising>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(long localClientId, GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult result)
    {
        GooglePlayGames.BasicApi.Nearby.AdvertisingResult val_1 = result.AsResult();
        this.resultCallback.Invoke(obj:  new GooglePlayGames.BasicApi.Nearby.AdvertisingResult() {mStatus = val_1.mStatus, mLocalEndpointName = val_1.mLocalEndpointName});
    }
    internal void <>m__1(long localClientId, GooglePlayGames.Native.PInvoke.NativeConnectionRequest request)
    {
        string val_2;
        string val_3;
        GooglePlayGames.BasicApi.Nearby.ConnectionRequest val_1 = request.AsRequest();
        this.requestCallback.Invoke(obj:  new GooglePlayGames.BasicApi.Nearby.ConnectionRequest() {mRemoteEndpoint = new GooglePlayGames.BasicApi.Nearby.EndpointDetails() {mEndpointId = val_2, mName = val_2, mServiceId = val_3}, mPayload = val_3});
    }

}
