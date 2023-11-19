using UnityEngine;
private sealed class SimpleMeleeCombatSystem.<meleeHitTimer>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float delayTime;
    internal TzarGames.TzarHero.TH_Character lastTarget;
    internal TzarGames.GameFramework.Weapon template;
    internal TzarGames.TzarHero.SimpleMeleeCombatSystem $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public SimpleMeleeCombatSystem.<meleeHitTimer>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_22;
        float val_23;
        TzarGames.TzarHero.SimpleMeleeCombatSystem val_24;
        TzarGames.TzarHero.TH_Character val_25;
        int val_22 = this.$PC;
        this.$PC = 0;
        val_22 = ((val_22 == 1) ? 1 : 0) << 2;
        var val_2 = (val_22 == 0) ? 3 : (val_22);
        if(val_2 != 4)
        {
                val_22 = 0;
            if(val_2 != 3)
        {
                return (bool)val_22;
        }
        
            val_23 = this.delayTime;
            val_22 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  val_23);
            if(this.$disposing == true)
        {
                return (bool)val_22;
        }
        
            this.$PC = val_22;
            return (bool)val_22;
        }
        
        if((this.$this.enabled == false) || ((this.$this.<Owner>k__BackingField.isDead) == true))
        {
            goto label_9;
        }
        
        if(((0 == this.lastTarget) || ((UnityEngine.Object.op_Implicit(exists:  0)) == false)) || (this.lastTarget.isDead == true))
        {
            goto label_17;
        }
        
        val_24 = this.$this;
        if(this.$this != null)
        {
            goto label_18;
        }
        
        val_24 = this.$this;
        if(val_24 == null)
        {
            goto label_19;
        }
        
        label_18:
        val_25 = this.$this.<Owner>k__BackingField;
        val_23 = this.$this.<Owner>k__BackingField.GetAttackRadius();
        float val_23 = 1.2f;
        val_23 = val_23 * val_23;
        if((val_25.IsObjectInAttackRange(obj:  this.lastTarget, attackRadius:  val_23)) == true)
        {
            goto label_27;
        }
        
        label_17:
        TzarGames.TzarHero.TH_Character val_15 = this.$this.<Owner>k__BackingField.TryFindTargetForAttack();
        this.lastTarget = val_15;
        if(0 == val_15)
        {
            goto label_27;
        }
        
        if(this.lastTarget.isDead == false)
        {
            goto label_29;
        }
        
        label_9:
        val_22 = 0;
        return (bool)val_22;
        label_29:
        this.$this.<Owner>k__BackingField.Target = this.lastTarget;
        val_25 = this.lastTarget;
        UnityEngine.Vector3 val_19 = val_25.Position;
        val_23 = val_19.x;
        this.$this.<Owner>k__BackingField.SetDesiredRotationToPosition(position:  new UnityEngine.Vector3() {x = val_23, y = val_19.y, z = val_19.z});
        label_27:
        if(0 != this.lastTarget)
        {
                if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                val_25 = this.lastTarget;
            this.$this.adjustDamage(target:  val_25, weapon:  this.template);
        }
        
        }
        
        val_22 = 0;
        this.$PC = 0;
        return (bool)val_22;
        label_19:
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
