using UnityEngine;
private sealed class EndlessGameManager_Deathmatch.MatchEnd.<restart>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.EndlessGameManager_Deathmatch.MatchEnd $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public EndlessGameManager_Deathmatch.MatchEnd.<restart>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_5;
        int val_5 = this.$PC;
        this.$PC = 0;
        int val_1 = val_5 + 3;
        val_5 = (val_5 < 3) ? (val_1) : 0;
        val_1 = val_5 - 4;
        if(val_1 >= 2)
        {
            goto label_1;
        }
        
        if(this.$this.Game.Connected == false)
        {
            goto label_4;
        }
        
        this.$this.ForceGotoState<EndlessGameManager_Deathmatch.WaitingForMatch>(stateData:  0);
        val_5 = 0;
        this.$PC = 0;
        return (bool)val_5;
        label_1:
        val_5 = 0;
        if(val_5 != 3)
        {
                return (bool)val_5;
        }
        
        val_5 = 1;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  2f);
        if(this.$disposing == true)
        {
                return (bool)val_5;
        }
        
        this.$PC = val_5;
        return (bool)val_5;
        label_4:
        this.$current = 0;
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_5 = 1;
        return (bool)val_5;
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
