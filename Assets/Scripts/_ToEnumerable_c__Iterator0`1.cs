using UnityEngine;
private sealed class PInvokeUtilities.<ToEnumerable>c__Iterator0<T> : IEnumerable, IEnumerable<T>, IEnumerator, IDisposable, IEnumerator<T>
{
    // Fields
    internal ulong <i>__1;
    internal UIntPtr size;
    internal System.Func<UIntPtr, T> getElement;
    internal T $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private T System.Collections.Generic.IEnumerator<T>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public PInvokeUtilities.<ToEnumerable>c__Iterator0<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    public bool MoveNext()
    {
        var val_6;
        var val_7;
        mem[1152921512181986084] = 0;
        var val_3 = (W8 == 0) ? 3 : (((W8 == 1) ? 1 : 0) << 2);
        if(val_3 != 4)
        {
                val_6 = 0;
            if(val_3 != 3)
        {
                return (bool)val_6;
        }
        
            val_7 = 0;
            mem[1152921512181986048] = 0;
        }
        else
        {
                val_7 = val_3 + 1;
            mem[1152921512181986048] = val_7;
        }
        
        if(val_7 < InitializationCallback)
        {
                mem[1152921512181986072] = val_7;
            val_6 = 1;
            if((__RuntimeMethodHiddenParam + 24 + 168) != 0)
        {
                return (bool)val_6;
        }
        
            mem[1152921512181986084] = val_6;
            return (bool)val_6;
        }
        
        val_6 = 0;
        mem[1152921512181986084] = 0;
        return (bool)val_6;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private T System.Collections.Generic.IEnumerator<T>.get_Current()
    {
        return (object)this;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Dispose()
    {
        mem[1152921512182326176] = 1;
        mem[1152921512182326180] = 0;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        if(this == null)
        {
            
        }
    
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
    {
        PInvokeUtilities.<ToEnumerable>c__Iterator0<T> val_3;
        var val_4;
        val_3 = this;
        if((System.Threading.Interlocked.CompareExchange(location1: ref  0, value:  -1014118364, comparand:  0)) == 2)
        {
                val_4 = val_3;
            return (System.Collections.Generic.IEnumerator<T>)val_4;
        }
        
        val_4 = __RuntimeMethodHiddenParam + 24 + 168 + 24;
        if(val_4 != 0)
        {
                mem2[0] = __RuntimeMethodHiddenParam + 24 + 168 + 24;
        }
        else
        {
                mem[24] = __RuntimeMethodHiddenParam + 24 + 168 + 24;
        }
        
        mem2[0] = val_3;
        return (System.Collections.Generic.IEnumerator<T>)val_4;
    }

}
