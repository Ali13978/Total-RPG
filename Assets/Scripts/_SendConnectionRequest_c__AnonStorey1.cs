using UnityEngine;
private sealed class NativeNearbyConnectionsClient.<SendConnectionRequest>c__AnonStorey1
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback;
    
    // Methods
    public NativeNearbyConnectionsClient.<SendConnectionRequest>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(long localClientId, GooglePlayGames.Native.PInvoke.NativeConnectionResponse response)
    {
        long val_2;
        Status val_3;
        GooglePlayGames.BasicApi.Nearby.ConnectionResponse val_1 = response.AsResponse(localClientId:  localClientId);
        this.responseCallback.Invoke(obj:  new GooglePlayGames.BasicApi.Nearby.ConnectionResponse() {mLocalClientId = val_2, mRemoteEndpointId = val_2, mResponseStatus = val_3, mPayload = val_3});
    }

}
