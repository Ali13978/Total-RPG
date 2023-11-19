using UnityEngine;
private sealed class LobbyClient.<GetPlayerData_INTERNAL>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.GameFramework.Database.ReadDataCompleteHandler handler;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public LobbyClient.<GetPlayerData_INTERNAL>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_4;
        var val_5;
        string val_6;
        var val_7;
        int val_4 = this.$PC;
        this.$PC = 0;
        val_4 = ((val_4 == 1) ? 1 : 0) << 2;
        var val_2 = (val_4 == 0) ? 3 : (val_4);
        if(val_2 != 4)
        {
                val_4 = 0;
            if(val_2 != 3)
        {
                return (bool)val_4;
        }
        
            val_5 = null;
            val_5 = null;
            TzarGames.GameFramework.LobbyClient.pendingPlayerData = true;
        }
        
        val_6 = 1152921504912916480;
        val_7 = null;
        val_7 = null;
        if(TzarGames.GameFramework.LobbyClient.pendingPlayerData != false)
        {
                val_4 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  0.5f);
            if(this.$disposing == true)
        {
                return (bool)val_4;
        }
        
            this.$PC = val_4;
            return (bool)val_4;
        }
        
        val_6 = TzarGames.GameFramework.LobbyClient.globalPlayerData;
        this.handler.Invoke(data:  val_6);
        val_4 = 0;
        this.$PC = 0;
        return (bool)val_4;
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
