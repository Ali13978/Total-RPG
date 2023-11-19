using UnityEngine;
private sealed class PhotonHandler.<PingAvailableRegionsCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal PhotonPingManager <pingManager>__0;
    internal System.Collections.Generic.List.Enumerator<Region> $locvar0;
    internal Region <best>__0;
    internal bool connectToBest;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public PhotonHandler.<PingAvailableRegionsCoroutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        var val_11;
        List.Enumerator<Region> val_12;
        var val_30;
        var val_31;
        var val_32;
        PhotonPingManager val_33;
        var val_34;
        var val_35;
        bool val_36;
        var val_37;
        int val_38;
        var val_39;
        int val_29 = this.$PC;
        this.$PC = 0;
        int val_1 = val_29 + 3;
        val_29 = (val_29 < 3) ? (val_1) : 0;
        val_1 = val_29 - 3;
        if(val_1 >= 2)
        {
            goto label_1;
        }
        
        val_30 = null;
        val_30 = null;
        val_31 = null;
        if(PhotonNetwork.networkingPeer.AvailableRegions == null)
        {
            goto label_5;
        }
        
        val_31 = null;
        if(PhotonNetwork.networkingPeer.AvailableRegions == null)
        {
            goto label_14;
        }
        
        val_32 = null;
        val_32 = null;
        if(PhotonNetwork.networkingPeer.AvailableRegions.Count == 0)
        {
            goto label_14;
        }
        
        val_33 = this;
        this.<pingManager>__0 = new System.Object();
        val_34 = null;
        val_34 = null;
        List.Enumerator<T> val_10 = PhotonNetwork.networkingPeer.AvailableRegions.GetEnumerator();
        mem[1152921512405694648] = val_11;
        this.$locvar0 = val_12;
        label_24:
        if(((this.$locvar0 & 1) & 1) == 0)
        {
            goto label_19;
        }
        
        val_35 = null;
        val_35 = null;
        UnityEngine.Coroutine val_16 = PhotonHandler.PlayerPrefsKey.StartCoroutine(routine:  PingSocket(region:  this.$locvar0.InitializationCallback));
        goto label_24;
        label_1:
        val_38 = 0;
        if(val_29 != 5)
        {
                return (bool);
        }
        
        val_33 = this.<pingManager>__0;
        goto label_69;
        label_14:
        val_39 = "No regions available. Are you sure your appid is valid and setup?";
        goto label_30;
        label_5:
        if(PhotonNetwork.connectionStateDetailed != 17)
        {
                if(PhotonNetwork.connectionStateDetailed != 18)
        {
            goto label_36;
        }
        
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Waiting for AvailableRegions. State: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = PhotonNetwork.connectionStateDetailed;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " Server: ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = PhotonNetwork.Server;
        typeof(System.Object[]).__il2cppRuntimeField_40 = " PhotonNetwork.networkingPeer.AvailableRegions ";
        val_36 = (PhotonNetwork.networkingPeer.AvailableRegions != 0) ? 1 : 0;
        typeof(System.Object[]).__il2cppRuntimeField_48 = val_36;
        typeof(System.Object[]).__il2cppRuntimeField_49 = 30464597;
        string val_23 = +0;
        UnityEngine.Debug.Log(message:  0);
        val_38 = 1;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  0.25f);
        if(this.$disposing == true)
        {
                return (bool);
        }
        
        this.$PC = val_38;
        return (bool);
        label_36:
        val_39 = "Call ConnectToNameServer to ping available regions.";
        label_30:
        UnityEngine.Debug.LogError(message:  0);
        val_38 = 0;
        return (bool);
        label_19:
        val_36 = 0;
        val_37 = 1;
        this.$locvar0.Dispose();
        label_69:
        this.$current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_38 = 1;
        return (bool);
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
