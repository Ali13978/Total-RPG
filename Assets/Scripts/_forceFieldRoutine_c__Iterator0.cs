using UnityEngine;
private sealed class EndlessPowerPlaceGameManager.<forceFieldRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.PlayerCharacter player;
    internal UnityEngine.GameObject <field>__0;
    internal TzarGames.Endless.EndlessPowerPlaceGameManager $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public EndlessPowerPlaceGameManager.<forceFieldRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_9;
        int val_9 = this.$PC;
        this.$PC = 0;
        val_9 = val_9 | 1;
        if(val_9 == 1)
        {
                State val_1 = this.player.CurrentState;
            val_9 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_9;
        }
        
            this.$PC = val_9;
            return (bool)val_9;
        }
        
        val_9 = 0;
        return (bool)val_9;
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
