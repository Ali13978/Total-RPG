using UnityEngine;
private sealed class TH_Character.<waitForAttackEndAndChangeState>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.TzarHero.TH_Character $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public TH_Character.<waitForAttackEndAndChangeState>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_4;
        System.Type val_5;
        int val_4 = this.$PC;
        this.$PC = 0;
        val_4 = val_4 | 1;
        if(val_4 != 1)
        {
            goto label_0;
        }
        
        if(this.$this.IsAttacking == false)
        {
            goto label_2;
        }
        
        val_4 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_4;
        }
        
        this.$PC = val_4;
        return (bool)val_4;
        label_0:
        val_4 = 0;
        return (bool)val_4;
        label_2:
        this.$this.pendingChangeStateAfterAttack = false;
        if(this.$this != null)
        {
                val_5 = this.$this.pendingStateToChangeAfterAttack;
        }
        else
        {
                val_5 = 16;
        }
        
        bool val_3 = this.$this.GotoState(stateType:  val_5, stateData:  0);
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
