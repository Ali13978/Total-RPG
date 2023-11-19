using UnityEngine;
private sealed class MessageSlot.<DelayCrossFade>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float delay;
    internal UnityEngine.UI.Graphic graphic;
    internal float duration;
    internal bool ignoreTimeScale;
    internal Unitycoding.UIWidgets.MessageSlot $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public MessageSlot.<DelayCrossFade>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_7;
        float val_8;
        bool val_9;
        var val_10;
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
        
            val_8 = this.delay;
            val_7 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  val_8);
            if(this.$disposing == true)
        {
                return (bool)val_7;
        }
        
            this.$PC = val_7;
            return (bool)val_7;
        }
        
        val_9 = 1152921504985706496;
        if(this.$this != null)
        {
                val_10 = null;
        }
        
        val_10 = null;
        var val_5 = (((Unitycoding.UIWidgets.MessageSlot.__il2cppRuntimeField_typeHierarchy + Unitycoding.UIWidgets.MessageContainer.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_10) ? this.$this : 0;
        val_8 = this.duration;
        val_9 = this.ignoreTimeScale;
        var val_6 = (val_9 == true) ? 1 : 0;
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
