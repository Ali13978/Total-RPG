using UnityEngine;
private sealed class Spinner.<Increase>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal Unitycoding.UIWidgets.Spinner $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public Spinner.<Increase>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        Unitycoding.UIWidgets.Spinner val_3;
        var val_4;
        float val_5;
        Unitycoding.UIWidgets.Spinner val_6;
        Unitycoding.UIWidgets.Spinner val_7;
        int val_8;
        Unitycoding.UIWidgets.Spinner val_9;
        int val_3 = this.$PC;
        this.$PC = 0;
        val_3 = val_3 | 1;
        if(val_3 != 1)
        {
            goto label_1;
        }
        
        val_3 = this.$this;
        if(this.$this != null)
        {
            goto label_2;
        }
        
        val_3 = this.$this;
        if(val_3 == null)
        {
            goto label_14;
        }
        
        label_2:
        float val_4 = this.$this.m_Current;
        val_4 = val_4 + this.$this.step;
        this.$this.m_Current = val_4;
        if(this.$this == null)
        {
            goto label_4;
        }
        
        val_4 = this.$this;
        val_5 = this.$this.m_Current;
        val_6 = this.$this;
        val_7 = this.$this;
        goto label_8;
        label_1:
        val_8 = 0;
        return (bool)val_8;
        label_4:
        val_4 = this.$this;
        val_6 = this.$this;
        val_5 = this.$this.m_Current;
        if(val_6 == null)
        {
            goto label_7;
        }
        
        val_7 = val_6;
        goto label_8;
        label_7:
        val_7 = this.$this;
        if(val_7 == null)
        {
            goto label_14;
        }
        
        label_8:
        mem2[0] = UnityEngine.Mathf.Clamp(value:  val_5, min:  this.$this.min, max:  this.$this.max);
        val_9 = this.$this;
        if(this.$this != null)
        {
            goto label_13;
        }
        
        val_9 = this.$this;
        if(val_9 == null)
        {
            goto label_14;
        }
        
        label_13:
        this.$this.onChange.Invoke(arg0:  this.$this.m_Current);
        val_8 = 1;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  this.$this.changeDelay);
        if(this.$disposing == true)
        {
                return (bool)val_8;
        }
        
        this.$PC = val_8;
        return (bool)val_8;
        label_14:
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
