using UnityEngine;
private sealed class TH_Dropped.<triggeredCheck>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal int <count>__0;
    internal TzarGames.TzarHero.TH_Dropped $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public TH_Dropped.<triggeredCheck>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_11;
        UnityEngine.Object val_12;
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
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_11;
        }
        
            this.$PC = val_11;
            return (bool)val_11;
        }
        
        int val_3 = this.$this.triggeredList.Count;
        val_11 = 0;
        this.<count>__0 = val_3;
        if(val_3 < 1)
        {
                return (bool)val_11;
        }
        
        var val_12 = 0;
        label_19:
        val_12 = this.$this.triggeredList.Item[0];
        if((0 == val_12) || (this.$this.item.AutoPickup == false))
        {
            goto label_15;
        }
        
        val_12 = val_12.gameObject;
        if((this.$this.tryTakeItem(go:  val_12)) == true)
        {
            goto label_18;
        }
        
        label_15:
        val_12 = val_12 + 1;
        if(val_12 < (this.<count>__0))
        {
            goto label_19;
        }
        
        label_18:
        this.$this.triggeredList.Clear();
        val_11 = 0;
        this.$this.triggeredCheckRoutine = 0;
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
