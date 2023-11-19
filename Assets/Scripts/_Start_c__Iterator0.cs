using UnityEngine;
private sealed class TweenRunner.<Start>c__Iterator0<T> : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal T tweenInfo;
    internal float <elapsedTime>__0;
    internal float <percentage>__1;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public TweenRunner.<Start>c__Iterator0<T>()
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
        float val_10;
        var val_11;
        bool val_8 = true;
        mem[1152921512666804532] = 0;
        val_8 = ((val_8 == 1) ? 1 : 0) << 2;
        var val_2 = (val_8 == 0) ? 3 : (val_8);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_8 = 0;
        if(val_2 != 4)
        {
                return (bool)val_8;
        }
        
        val_9 = this;
        val_11 = 1152921512666804480;
        goto label_3;
        label_1:
        val_11 = 1152921512666804480;
        if(ValidTarget() == false)
        {
            goto label_4;
        }
        
        val_9 = this;
        mem[1152921512666804512] = 0f;
        val_10 = 0f;
        label_3:
        if(val_10 >= 0)
        {
                val_8 = 0;
            mem[1152921512666804532] = 0;
            return (bool)val_8;
        }
        
        if((val_11 & 1) == 0)
        {
            goto label_7;
        }
        
        float val_4 = UnityEngine.Time.unscaledDeltaTime;
        goto label_8;
        label_4:
        val_8 = 0;
        return (bool)val_8;
        label_7:
        float val_5 = UnityEngine.Time.deltaTime;
        label_8:
        float val_6 = mem[1152921512666804512] + val_5;
        mem[1152921512666804512] = val_6;
        val_10 = val_5;
        val_5 = val_6 / val_10;
        mem[1152921512666804516] = UnityEngine.Mathf.Clamp01(value:  val_5);
        val_8 = 1;
        mem[1152921512666804520] = 0;
        mem[1152921512666804532] = val_8;
        return (bool)val_8;
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
        mem[1152921512667140528] = 1;
        mem[1152921512667140532] = 0;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
