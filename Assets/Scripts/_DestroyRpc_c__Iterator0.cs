using UnityEngine;
private sealed class OnClickDestroy.<DestroyRpc>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal OnClickDestroy $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public OnClickDestroy.<DestroyRpc>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_6;
        int val_6 = this.$PC;
        this.$PC = 0;
        val_6 = ((val_6 == 1) ? 1 : 0) << 2;
        var val_2 = (val_6 == 0) ? 3 : (val_6);
        if(val_2 != 4)
        {
                val_6 = 0;
            if(val_2 != 3)
        {
                return (bool)val_6;
        }
        
            UnityEngine.GameObject val_3 = this.$this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            this.$current = 0;
            val_6 = 1;
            if(this.$disposing == true)
        {
                return (bool)val_6;
        }
        
            this.$PC = val_6;
            return (bool)val_6;
        }
        
        int val_5 = this.$this.photonView.viewID;
        PhotonNetwork.UnAllocateViewID(viewID:  0);
        val_6 = 0;
        this.$PC = 0;
        return (bool)val_6;
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
        var val_2;
        GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder.InternalOnInitializationFinishedCallback(status:  -723277736, userData:  new System.NotSupportedException());
        if(val_2 == 0)
        {
                return;
        }
    
    }

}
