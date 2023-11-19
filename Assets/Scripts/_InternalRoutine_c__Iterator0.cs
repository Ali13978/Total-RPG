using UnityEngine;
private sealed class Coroutine.<InternalRoutine>c__Iterator0<T> : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal System.Collections.IEnumerator coroutine;
    internal object <yielded>__1;
    internal TzarGames.Common.Coroutine<T> $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public Coroutine.<InternalRoutine>c__Iterator0<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    public bool MoveNext()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        bool val_4 = true;
        mem[1152921511079362564] = 0;
        val_4 = val_4 | 1;
        if(val_4 != 1)
        {
                return false;
        }
        
        var val_8 = mem[34820096];
        if((mem[34820096] + 258) == 0)
        {
            goto label_3;
        }
        
        var val_5 = mem[34820096] + 152;
        var val_6 = 0;
        val_5 = val_5 + 8;
        label_5:
        if(((mem[34820096] + 152 + 8) + -8) == null)
        {
            goto label_4;
        }
        
        val_6 = val_6 + 1;
        val_5 = val_5 + 16;
        if(val_6 < (mem[34820096] + 258))
        {
            goto label_5;
        }
        
        label_3:
        val_8 = 34820096;
        goto label_6;
        label_4:
        var val_7 = val_5;
        val_7 = val_7 + 1;
        val_8 = val_8 + val_7;
        val_8 = val_8 + 272;
        label_6:
        if((0 & 1) == 0)
        {
                return false;
        }
        
        var val_11 = mem[34820096];
        if((mem[34820096] + 258) == 0)
        {
            goto label_9;
        }
        
        var val_9 = mem[34820096] + 152;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_11:
        if(((mem[34820096] + 152 + 8) + -8) == null)
        {
            goto label_10;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (mem[34820096] + 258))
        {
            goto label_11;
        }
        
        label_9:
        val_9 = 34820096;
        goto label_12;
        label_10:
        val_11 = val_11 + (((mem[34820096] + 152 + 8)) << 4);
        val_9 = val_11 + 272;
        label_12:
        mem[1152921511079362536] = 34820096;
        if(==0)
        {
            goto label_13;
        }
        
        System.Type val_1 = GetType();
        if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
        {
            goto label_16;
        }
        
        label_13:
        var val_14 = __RuntimeMethodHiddenParam;
        if((__RuntimeMethodHiddenParam + 258) == 0)
        {
            goto label_18;
        }
        
        var val_12 = __RuntimeMethodHiddenParam + 152;
        var val_13 = 0;
        val_12 = val_12 + 8;
        label_20:
        if(((__RuntimeMethodHiddenParam + 152 + 8) + -8) == null)
        {
            goto label_19;
        }
        
        val_13 = val_13 + 1;
        val_12 = val_12 + 16;
        if(val_13 < (__RuntimeMethodHiddenParam + 258))
        {
            goto label_20;
        }
        
        label_18:
        val_10 = __RuntimeMethodHiddenParam;
        goto label_21;
        label_19:
        val_14 = val_14 + (((__RuntimeMethodHiddenParam + 152 + 8)) << 4);
        val_10 = val_14 + 272;
        label_21:
        mem[1152921511079362552] = __RuntimeMethodHiddenParam;
        if(val_10 != 0)
        {
                return false;
        }
        
        mem[1152921511079362564] = 1;
        return false;
        label_16:
        if(val_1 == null)
        {
            goto label_25;
        }
        
        val_11 = val_1;
        if(val_11 != null)
        {
            goto label_26;
        }
        
        label_25:
        val_11 = 0;
        label_26:
        mem2[0] = val_11;
        return false;
        label_32:
        mem[8] = ;
        goto label_32;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.Generic.IEnumerator<object>.get_Current()
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
        mem[1152921511079706752] = 1;
        mem[1152921511079706756] = 0;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
