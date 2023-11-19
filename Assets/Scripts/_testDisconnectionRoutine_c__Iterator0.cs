using UnityEngine;
private sealed class PhotonClientServerManager.<testDisconnectionRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <time>__0;
    internal TzarGames.GameFramework.NetworkSubsystem_Photon.PhotonClientServerManager $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public PhotonClientServerManager.<testDisconnectionRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_5;
        TzarGames.GameFramework.NetworkSubsystem_Photon.PhotonClientServerManager val_6;
        int val_5 = this.$PC;
        this.$PC = 0;
        val_5 = ((val_5 == 1) ? 1 : 0) << 2;
        var val_2 = (val_5 == 0) ? 3 : (val_5);
        if(val_2 == 4)
        {
            goto label_1;
        }
        
        val_5 = 0;
        if(val_2 != 3)
        {
                return (bool)val_5;
        }
        
        val_6 = this.$this;
        if(this.$this != null)
        {
            goto label_3;
        }
        
        val_6 = this.$this;
        if(val_6 == null)
        {
            goto label_4;
        }
        
        label_3:
        float val_3 = UnityEngine.Random.Range(min:  this.$this.testMinConnectionTime, max:  this.$this.testMaxConnectionTime);
        this.<time>__0 = val_3;
        val_5 = 1;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  val_3);
        if(this.$disposing == true)
        {
                return (bool)val_5;
        }
        
        this.$PC = val_5;
        return (bool)val_5;
        label_1:
        27533.Disconnect();
        val_5 = 0;
        this.$PC = 0;
        return (bool)val_5;
        label_4:
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
