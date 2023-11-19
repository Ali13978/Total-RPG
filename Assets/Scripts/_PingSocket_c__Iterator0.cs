using UnityEngine;
private sealed class PhotonPingManager.<PingSocket>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal Region region;
    internal ExitGames.Client.Photon.PhotonPing <ping>__1;
    internal float <rttSum>__0;
    internal int <replyCount>__0;
    internal string <regionAddress>__0;
    internal int <indexOfColon>__0;
    internal int <indexOfProtocol>__0;
    internal int <i>__2;
    internal bool <overtime>__3;
    internal System.Diagnostics.Stopwatch <sw>__3;
    internal int <rtt>__3;
    internal PhotonPingManager $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public PhotonPingManager.<PingSocket>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_28;
        int val_26 = this.$PC;
        val_28 = 0;
        this.$PC = 0;
        val_26 = (val_26 < 4) ? (val_26 + 3) : 0;
        val_26 = val_26 - 3;
        if(val_26 > 3)
        {
                return (bool);
        }
        
        var val_27 = 25819016 + ((this.$PC < 4 ? (this.$PC + 3) : 0 - 3)) << 2;
        val_27 = val_27 + 25819016;
        goto (25819016 + ((this.$PC < 4 ? (this.$PC + 3) : 0 - 3)) << 2 + 25819016);
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.Generic.IEnumerator<object>.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Dispose()
    {
        this.$disposing = true;
        this.$PC = 0;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
