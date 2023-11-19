using UnityEngine;
private sealed class EndlessGameManager.<getOtherPlayerData>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <startTime>__0;
    internal TzarGames.GameFramework.Player player;
    internal System.Action<byte[]> getDataHandler;
    internal byte[] <data>__0;
    internal TzarGames.Endless.EndlessGameManager $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public EndlessGameManager.<getOtherPlayerData>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        System.Action<System.Byte[]> val_11;
        int val_12;
        TzarGames.GameFramework.Player val_13;
        val_11 = this;
        int val_11 = this.$PC;
        this.$PC = 0;
        val_11 = ((val_11 == 1) ? 1 : 0) << 2;
        var val_2 = (val_11 == 0) ? 3 : (val_11);
        if(val_2 != 4)
        {
                val_12 = 0;
            if(val_2 != 3)
        {
                return (bool)val_12;
        }
        
            this.<startTime>__0 = UnityEngine.Time.time;
        }
        
        val_13 = this.player;
        if((this.$this.playersData.ContainsKey(key:  val_13)) != false)
        {
                System.Byte[] val_5 = this.$this.playersData.Item[this.player];
            this.<data>__0 = val_5;
            this.getDataHandler.Invoke(obj:  val_5);
            val_13 = this.player;
            bool val_6 = this.$this.playersData.Remove(key:  val_13);
            val_12 = 0;
            this.$PC = 0;
            return (bool)val_12;
        }
        
        float val_7 = UnityEngine.Time.time;
        val_7 = val_7 - (this.<startTime>__0);
        if(val_7 < 5f)
        {
                if(this.player.IsConnected != false)
        {
                val_12 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_12;
        }
        
            this.$PC = val_12;
            return (bool)val_12;
        }
        
        }
        
        val_13 = this.player.Login;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_13;
        UnityEngine.Debug.LogErrorFormat(format:  0, args:  "Failed to get player data for player {0}");
        val_11 = this.getDataHandler;
        val_11.Invoke(obj:  0);
        val_12 = 0;
        return (bool)val_12;
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
