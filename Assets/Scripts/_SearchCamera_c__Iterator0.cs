using UnityEngine;
private sealed class LookAtMainCamera.<SearchCamera>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal Unitycoding.LookAtMainCamera $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public LookAtMainCamera.<SearchCamera>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_10;
        Unitycoding.LookAtMainCamera val_11;
        int val_10 = this.$PC;
        this.$PC = 0;
        val_10 = ((val_10 == 1) ? 1 : 0) << 2;
        var val_2 = (val_10 == 0) ? 3 : (val_10);
        if(val_2 != 3)
        {
                val_10 = 0;
            if(val_2 != 4)
        {
                return (bool)val_10;
        }
        
            val_11 = this.$this;
        }
        else
        {
                val_11 = this;
            this.$this.searchCamera = true;
        }
        
        if(0 == this.$this.target)
        {
                if(0 != UnityEngine.Camera.main)
        {
                val_11 = null;
            target = UnityEngine.Camera.main.transform;
        }
        
            val_10 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  2f);
            if(this.$disposing == true)
        {
                return (bool)val_10;
        }
        
            this.$PC = val_10;
            return (bool)val_10;
        }
        
        val_10 = 0;
        searchCamera = false;
        this.$PC = 0;
        return (bool)val_10;
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
