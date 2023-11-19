using UnityEngine;
private sealed class NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RealTimeMessageReceived>c__AnonStorey4
{
    // Fields
    internal bool isReliable;
    internal string senderId;
    internal byte[] data;
    internal GooglePlayGames.Native.NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener $this;
    
    // Methods
    public NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RealTimeMessageReceived>c__AnonStorey4()
    {
    
    }
    internal void <>m__0()
    {
        var val_3;
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_3 = this.$this.mListener;
        var val_2 = (this.isReliable == true) ? 1 : 0;
    }

}
