using UnityEngine;
private sealed class InventoryUI.<showTabRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Endless.UI.InventoryUI.ItemTab tab;
    internal TzarGames.Endless.UI.InventoryUI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public InventoryUI.<showTabRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_3;
        int val_3 = this.$PC;
        this.$PC = 0;
        val_3 = ((val_3 == 1) ? 1 : 0) << 2;
        var val_2 = (val_3 == 0) ? 3 : (val_3);
        if(val_2 == 4)
        {
            goto label_0;
        }
        
        val_3 = 0;
        if(val_2 != 3)
        {
                return (bool)val_3;
        }
        
        if(this.$this.currentTab == this.tab)
        {
            goto label_3;
        }
        
        val_3 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_3;
        }
        
        this.$PC = val_3;
        return (bool)val_3;
        label_0:
        this.tab.Button.interactable = false;
        if(this.$this.currentTab != null)
        {
                this.$this.currentTab.Button.interactable = true;
        }
        
        val_3 = 0;
        this.$this.currentTab = this.tab;
        this.$PC = 0;
        return (bool)val_3;
        label_3:
        val_3 = 0;
        return (bool)val_3;
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
