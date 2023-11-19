using UnityEngine;
private sealed class NativeNearbyConnectionsClient.OnGameThreadMessageListener.<OnMessageReceived>c__AnonStorey0
{
    // Fields
    internal string remoteEndpointId;
    internal byte[] data;
    internal bool isReliableMessage;
    internal GooglePlayGames.Native.NativeNearbyConnectionsClient.OnGameThreadMessageListener $this;
    
    // Methods
    public NativeNearbyConnectionsClient.OnGameThreadMessageListener.<OnMessageReceived>c__AnonStorey0()
    {
    
    }
    internal void <>m__0()
    {
        var val_3;
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_3 = this.$this.mListener;
        var val_2 = (this.isReliableMessage == true) ? 1 : 0;
    }

}
