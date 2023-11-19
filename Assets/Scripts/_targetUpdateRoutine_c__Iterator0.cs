using UnityEngine;
private sealed class EndlessEnemyAI.<targetUpdateRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.EndlessEnemyAI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public EndlessEnemyAI.<targetUpdateRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_51;
        int val_53;
        float val_55;
        TzarGames.TzarHero.TH_Character val_57;
        var val_72;
        int val_51 = this.$PC;
        val_51 = 0;
        this.$PC = 0;
        val_51 = (val_51 < 5) ? (val_51 + 3) : 0;
        val_51 = val_51 - 3;
        if(val_51 > 4)
        {
                return (bool)val_51;
        }
        
        var val_52 = 25486816 + ((this.$PC < 5 ? (this.$PC + 3) : 0 - 3)) << 2;
        val_52 = val_52 + 25486816;
        goto (25486816 + ((this.$PC < 5 ? (this.$PC + 3) : 0 - 3)) << 2 + 25486816);
        if((( | (mem[this.$this] + 24.IsAttacking)) == true) || ((mem[this.$this] + 96.isDead) == true))
        {
            goto label_145;
        }
        
        val_72 = mem[this.$this];
        if(mem[this.$this] != 0)
        {
            goto label_146;
        }
        
        val_72 = mem[this.$this];
        if(val_72 == 0)
        {
            goto label_147;
        }
        
        label_146:
        val_57 = mem[mem[this.$this] + 96];
        val_57 = mem[this.$this] + 96;
        mem[this.$this] + 24.AttackCharacterContinuously(character:  val_57);
        label_145:
        val_55 = mem[mem[this.$this] + 32];
        val_55 = mem[this.$this] + 32;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  val_55);
        if(this.$disposing != true)
        {
                val_53 = 4;
            this.$PC = val_53;
        }
        
        val_51 = 1;
        return (bool)val_51;
        label_147:
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
