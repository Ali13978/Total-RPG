using UnityEngine;
private sealed class LobbyMultiplayer.<connectRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal string <gameVersion>__0;
    internal TzarGames.Endless.LobbyMultiplayer $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public LobbyMultiplayer.<connectRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        TzarGames.Endless.LobbyMultiplayer val_7;
        int val_8;
        string val_9;
        val_7 = this;
        int val_7 = this.$PC;
        this.$PC = 0;
        val_7 = (val_7 < 3) ? (val_7 + 3) : 0;
        if(val_7 == 5)
        {
            goto label_1;
        }
        
        if(val_7 != 4)
        {
                val_8 = 0;
            if(val_7 != 3)
        {
                return (bool)val_8;
        }
        
            val_8 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_8;
        }
        
            this.$PC = val_8;
            return (bool)val_8;
        }
        
        UnityEngine.Debug.Log(message:  0);
        if(PhotonNetwork.connectionState == 0)
        {
            goto label_18;
        }
        
        if(PhotonNetwork.connectionState != 3)
        {
            goto label_13;
        }
        
        UnityEngine.Debug.Log(message:  0);
        label_1:
        if(PhotonNetwork.connectionState == 3)
        {
                this.$current = 0;
            if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
            val_8 = 1;
            return (bool)val_8;
        }
        
        label_18:
        this.$this.connectCoroutine = 0;
        this.<gameVersion>__0 = TzarGames.Endless.EndlessGameState.MultiplayerVersion;
        if(this.$this.testingMode != false)
        {
                val_9 = "TESTING";
            this.<gameVersion>__0 = val_9;
        }
        else
        {
                val_9 = this.<gameVersion>__0;
        }
        
        bool val_6 = PhotonNetwork.ConnectUsingSettings(gameVersion:  0);
        val_8 = 0;
        this.$PC = 0;
        return (bool)val_8;
        label_13:
        val_7 = this.$this;
        val_8 = 0;
        this.$this.connectCoroutine = 0;
        return (bool)val_8;
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
