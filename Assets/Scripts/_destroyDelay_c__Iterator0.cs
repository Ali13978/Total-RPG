using UnityEngine;
private sealed class TH_Character.Dead.<destroyDelay>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float time;
    internal UnityEngine.GameObject <ownerObject>__0;
    internal TzarGames.TzarHero.TH_Character.Dead $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public TH_Character.Dead.<destroyDelay>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_7;
        int val_7 = this.$PC;
        this.$PC = 0;
        val_7 = ((val_7 == 1) ? 1 : 0) << 2;
        var val_2 = (val_7 == 0) ? 3 : (val_7);
        if(val_2 != 4)
        {
                val_7 = 0;
            if(val_2 != 3)
        {
                return (bool)val_7;
        }
        
            val_7 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  this.time);
            if(this.$disposing == true)
        {
                return (bool)val_7;
        }
        
            this.$PC = val_7;
            return (bool)val_7;
        }
        
        this.$this.destroyDelayRoutine = 0;
        this.<ownerObject>__0 = this.$this.CharacterOwner.gameObject;
        if((TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  0)) != false)
        {
                TzarGames.GameFramework.Instantiator.PushToPool(instanceObject:  0);
        }
        else
        {
                UnityEngine.Object.Destroy(obj:  0);
        }
        
        val_7 = 0;
        this.$PC = 0;
        return (bool)val_7;
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
