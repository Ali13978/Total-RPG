using UnityEngine;
private sealed class CharacterAI.RandomWalking.<update>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.TzarHero.TH_Character <ch>__0;
    internal TzarGames.TzarHero.CharacterAI.RandomWalking $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public CharacterAI.RandomWalking.<update>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_20;
        float val_21;
        float val_22;
        float val_23;
        CharacterAI.RandomWalking val_24;
        CharacterAI.RandomWalking val_25;
        int val_20 = this.$PC;
        this.$PC = 0;
        int val_1 = val_20 + 3;
        val_20 = (val_20 < 3) ? (val_1) : 0;
        val_1 = val_20 - 4;
        if(val_1 < 2)
        {
                if((this.<ch>__0.IsAttacking) != true)
        {
                if((this.<ch>__0.IsUsingSkill()) != true)
        {
                if(0 == (this.<ch>__0.Target))
        {
            goto label_9;
        }
        
        }
        
        }
        
            this.$current = 0;
            if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
            val_20 = 1;
            return (bool)val_20;
        }
        
        val_20 = 0;
        if(val_20 != 3)
        {
                return (bool)val_20;
        }
        
        TzarGames.TzarHero.CharacterAI val_9 = this.$this.AI;
        this.<ch>__0 = val_9.controlledCharacter;
        label_51:
        val_20 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_20;
        }
        
        this.$PC = val_20;
        return (bool)val_20;
        label_9:
        if(this.$this.walking == false)
        {
            goto label_17;
        }
        
        UnityEngine.Vector3 val_10 = this.<ch>__0.GroundPivotPosition;
        val_21 = val_10.y;
        val_22 = val_10.z;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_21, z = val_22}, b:  new UnityEngine.Vector3() {x = this.$this.lastPos, y = V12.16B, z = V11.16B});
        TzarGames.TzarHero.CharacterAI val_12 = this.$this.AI;
        float val_21 = val_12.stuckSpeed;
        TzarGames.TzarHero.CharacterAI val_13 = this.$this.AI;
        val_23 = val_13.stuckSpeed;
        val_21 = val_21 * val_23;
        if(val_11.x <= val_21)
        {
            goto label_27;
        }
        
        if(this.$this.checkingForStuck == false)
        {
            goto label_46;
        }
        
        this.$this.checkingForStuck = false;
        goto label_46;
        label_17:
        val_24 = this.$this;
        if(this.$this != null)
        {
            goto label_31;
        }
        
        val_24 = this.$this;
        if(val_24 == null)
        {
            goto label_45;
        }
        
        label_31:
        float val_22 = this.$this.lastWaitTime;
        val_22 = UnityEngine.Time.time - val_22;
        if(val_22 < this.$this.waitTime)
        {
            goto label_51;
        }
        
        UnityEngine.Vector3 val_15 = this.$this.findRandomPoint();
        this.<ch>__0.StopMove();
        val_23 = val_15.x;
        val_21 = val_15.y;
        val_22 = val_15.z;
        if((this.<ch>__0.GoToPosition(targetPosition:  new UnityEngine.Vector3() {x = val_23, y = val_21, z = val_22}, reachPositionHandler:  0, stoppingDistance:  0f)) == false)
        {
            goto label_51;
        }
        
        this.$this.checkingForStuck = false;
        this.$this.walking = true;
        goto label_46;
        label_27:
        if(this.$this.checkingForStuck != true)
        {
                this.$this.checkingForStuck = true;
            this.$this.stuckCheckTime = UnityEngine.Time.time;
        }
        
        val_25 = this.$this;
        if(this.$this != null)
        {
            goto label_44;
        }
        
        val_25 = this.$this;
        if(val_25 == null)
        {
            goto label_45;
        }
        
        label_44:
        val_21 = this.$this.stuckTime;
        val_23 = UnityEngine.Time.time - this.$this.stuckCheckTime;
        if(val_23 >= val_21)
        {
                this.<ch>__0.StopMove();
            this.$this.walking = false;
        }
        
        label_46:
        UnityEngine.Vector3 val_19 = this.<ch>__0.GroundPivotPosition;
        this.$this.lastPos = val_19;
        mem2[0] = val_19.y;
        mem2[0] = val_19.z;
        goto label_51;
        label_45:
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
