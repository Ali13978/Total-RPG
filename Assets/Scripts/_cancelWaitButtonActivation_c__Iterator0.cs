using UnityEngine;
private sealed class RubyShopUI.Wait.<cancelWaitButtonActivation>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.UI.RubyShopUI.Wait $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public RubyShopUI.Wait.<cancelWaitButtonActivation>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_6;
        int val_6 = this.$PC;
        this.$PC = 0;
        val_6 = ((val_6 == 1) ? 1 : 0) << 2;
        var val_2 = (val_6 == 0) ? 3 : (val_6);
        if(val_2 != 4)
        {
                val_6 = 0;
            if(val_2 != 3)
        {
                return (bool)val_6;
        }
        
            TzarGames.Endless.UI.RubyShopUI val_3 = this.$this.Shop;
            val_6 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  val_3.cancelWaitTime);
            if(this.$disposing == true)
        {
                return (bool)val_6;
        }
        
            this.$PC = val_6;
            return (bool)val_6;
        }
        
        TzarGames.Endless.UI.RubyShopUI val_5 = this.$this.Shop;
        val_5.cancelWaitButton.SetActive(value:  true);
        val_6 = 0;
        this.$PC = 0;
        return (bool)val_6;
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
