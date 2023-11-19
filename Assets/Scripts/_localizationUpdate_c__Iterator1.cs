using UnityEngine;
private sealed class TopPlayerWidgetUI.<localizationUpdate>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal System.Collections.Generic.List.Enumerator<TzarGames.Endless.UI.TopPlayerElementUI> $locvar0;
    internal TzarGames.Endless.UI.TopPlayerWidgetUI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public TopPlayerWidgetUI.<localizationUpdate>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        var val_5;
        List.Enumerator<TzarGames.Endless.UI.TopPlayerElementUI> val_6;
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
        
        List.Enumerator<T> val_4 = this.$this.elements.GetEnumerator();
        mem[1152921511018643840] = val_5;
        this.$locvar0 = val_6;
        label_13:
        if(((this.$locvar0 & 1) & 1) == 0)
        {
            goto label_16;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_8 = this.$locvar0.InitializationCallback;
        val_8.text = this.$this.elementUpdateMethods.Item[val_8].Invoke();
        goto label_13;
        label_16:
        this.$locvar0.Dispose();
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
