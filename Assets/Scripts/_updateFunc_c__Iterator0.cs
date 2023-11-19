using UnityEngine;
private sealed class TeleportSkillAI.<updateFunc>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.TeleportSkillAI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public TeleportSkillAI.<updateFunc>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_9;
        var val_10;
        TzarGames.TzarHero.Skills.CharacterSkill val_11;
        float val_12;
        TzarGames.Endless.TeleportSkillAI val_13;
        int val_9 = this.$PC;
        this.$PC = 0;
        val_9 = (val_9 < 3) ? (val_9 + 3) : 0;
        if(val_9 == 3)
        {
            goto label_26;
        }
        
        if(val_9 == 4)
        {
            goto label_1;
        }
        
        val_9 = 0;
        if(val_9 != 5)
        {
                return (bool)val_9;
        }
        
        label_28:
        if((mem[this.$this] + 24.IsAttacking) != false)
        {
                mem[this.$this] + 24.StopAttack();
        }
        
        val_10 = mem[this.$this];
        if(mem[this.$this] != 0)
        {
            goto label_8;
        }
        
        val_10 = mem[this.$this];
        if(val_10 == 0)
        {
            goto label_25;
        }
        
        label_8:
        val_11 = mem[mem[this.$this] + 32];
        val_11 = mem[this.$this] + 32;
        if((mem[this.$this] + 24.UseSkill(skill:  val_11)) == false)
        {
            goto label_11;
        }
        
        mem2[0] = 0;
        val_12 = UnityEngine.Time.time;
        mem2[0] = val_12;
        goto label_26;
        label_1:
        val_11 = null;
        if(this.$this.character.isDead == false)
        {
            goto label_18;
        }
        
        isWaitingToUseTeleport = false;
        goto label_26;
        label_11:
        this.$current = 0;
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_9 = 1;
        return (bool)val_9;
        label_18:
        if(this.$this.character.IsUsingSkill() == true)
        {
            goto label_26;
        }
        
        val_12 = UnityEngine.Time.time;
        val_13 = null;
        if(null != null)
        {
            goto label_24;
        }
        
        val_13 = null;
        if(val_13 == null)
        {
            goto label_25;
        }
        
        label_24:
        float val_10 = this.$this.lastUseTime;
        val_10 = val_12 - val_10;
        if(val_10 > this.$this.usageInterval)
        {
                if(this.$this.isWaitingToUseTeleport == true)
        {
            goto label_28;
        }
        
        }
        
        label_26:
        val_9 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_9;
        }
        
        this.$PC = val_9;
        return (bool)val_9;
        label_25:
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
