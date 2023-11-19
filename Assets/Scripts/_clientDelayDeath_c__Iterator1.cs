using UnityEngine;
private sealed class TH_Character.<clientDelayDeath>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal UnityEngine.Vector3 force;
    internal TzarGames.TzarHero.TH_Character $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public TH_Character.<clientDelayDeath>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_11;
        int val_11 = this.$PC;
        this.$PC = 0;
        val_11 = ((val_11 == 1) ? 1 : 0) << 2;
        var val_2 = (val_11 == 0) ? 3 : (val_11);
        if(val_2 != 4)
        {
                val_11 = 0;
            if(val_2 != 3)
        {
                return (bool)val_11;
        }
        
            val_11 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
            if(this.$disposing == true)
        {
                return (bool)val_11;
        }
        
            this.$PC = val_11;
            return (bool)val_11;
        }
        
        if(this.$this.Authoritative != false)
        {
                if(this.$this.ignoreDamage_runtime.ModifiedValue != false)
        {
                val_11 = 0;
            return (bool)val_11;
        }
        
        }
        
        typeof(TzarGames.TzarHero.TH_DamageType_Default).__il2cppRuntimeField_10 = TzarGames.GameFramework.SurfaceTypeBase.Default;
        bool val_10 = this.$this.GotoState<Dead>(stateData:  new TzarGames.TzarHero.DeadEventData(killer:  0, victim:  this.$this, force:  new UnityEngine.Vector3() {x = this.force, y = V9.16B, z = V8.16B}, damageType:  new System.Object()));
        val_11 = 0;
        this.$PC = 0;
        return (bool)val_11;
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
