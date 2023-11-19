using UnityEngine;
private sealed class CharacterAI.<tick>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.TzarHero.CharacterAI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public CharacterAI.<tick>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        var val_5;
        int val_6;
        TzarGames.TzarHero.CharacterAI val_7;
        TzarGames.TzarHero.CharacterAI val_8;
        float val_9;
        var val_10;
        var val_11;
        val_5 = 27539;
        int val_5 = this.$PC;
        this.$PC = 0;
        val_5 = (val_5 < 3) ? (val_5 + 3) : 0;
        if(val_5 == 3)
        {
            goto label_1;
        }
        
        if(val_5 == 5)
        {
            goto label_2;
        }
        
        val_6 = 0;
        if(val_5 != 4)
        {
                return (bool)val_6;
        }
        
        val_7 = this.$this;
        goto label_11;
        label_2:
        val_7 = this;
        val_8 = this.$this;
        if(this.$this != null)
        {
            goto label_5;
        }
        
        val_8 = null;
        if(val_8 == null)
        {
            goto label_6;
        }
        
        label_5:
        if(this.$this.lastBehaviour == this.$this.aiBehaviour)
        {
            goto label_9;
        }
        
        null.updateState();
        goto label_9;
        label_1:
        val_7 = this;
        if(this.$this.startDelay > 0f)
        {
                val_9 = mem[this.$this + 80];
            val_9 = this.$this.startDelay;
            val_6 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  val_9);
            if(this.$disposing == true)
        {
                return (bool)val_6;
        }
        
            this.$PC = val_6;
            return (bool)val_6;
        }
        
        label_11:
        mem[this.$this].updateState();
        if(mem[this.$this] != 0)
        {
                val_10 = mem[mem[this.$this] + 72];
            val_10 = mem[this.$this] + 72;
        }
        else
        {
                val_10 = 0;
        }
        
        mem2[0] = val_10;
        label_9:
        State val_3 = mem[this.$this].CurrentState;
        val_9 = mem[mem[this.$this] + 76];
        val_9 = mem[this.$this] + 76;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  val_9);
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_6 = 1;
        return (bool)val_6;
        label_6:
        val_11 = ;
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
