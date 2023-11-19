using UnityEngine;
private sealed class NativeRealtimeMultiplayerClient.ActiveState.<HandleConnectedSetChanged>c__AnonStorey0
{
    // Fields
    internal string selfId;
    
    // Methods
    public NativeRealtimeMultiplayerClient.ActiveState.<HandleConnectedSetChanged>c__AnonStorey0()
    {
    
    }
    internal bool <>m__0(string peerId)
    {
        bool val_1 = peerId.Equals(value:  this.selfId);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    internal bool <>m__1(string peerId)
    {
        bool val_1 = peerId.Equals(value:  this.selfId);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    internal bool <>m__2(string peer)
    {
        bool val_1 = peer.Equals(value:  this.selfId);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    internal bool <>m__3(string peer)
    {
        bool val_1 = peer.Equals(value:  this.selfId);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }

}
