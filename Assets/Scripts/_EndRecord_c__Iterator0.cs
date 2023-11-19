using UnityEngine;
private sealed class MayaAnimationRecorder.<EndRecord>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal int <i>__1;
    internal MayaAnimationRecorder $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public MayaAnimationRecorder.<EndRecord>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_7;
        var val_8;
        var val_9;
        int val_10;
        int val_6 = this.$PC;
        this.$PC = 0;
        val_6 = ((val_6 == 1) ? 1 : 0) << 2;
        var val_2 = (val_6 == 0) ? 3 : (val_6);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_7 = 0;
        if(val_2 != 4)
        {
                return (bool)val_7;
        }
        
        val_8 = this;
        val_9 = 1152921512591761288;
        goto label_13;
        label_1:
        val_9 = this;
        this.$this.ShowLog(logStr:  "Writing Anim Data into Files ...");
        val_8 = this;
        val_10 = 0;
        this.<i>__1 = 0;
        goto label_5;
        label_13:
        val_10 = (this.<i>__1) + 1;
        this.<i>__1 = val_10;
        label_5:
        if(val_10 >= this.$this.objAnims.Length)
        {
            goto label_9;
        }
        
        val_10 = this.<i>__1;
        this.$this.objAnims[val_10].WriteIntoFile();
        int val_3 = (this.<i>__1) * 1717986919;
        val_3 = val_3 >> 34;
        val_3 = val_3 + (val_3 >> 63);
        val_3 = (this.<i>__1) - (val_3 * 10);
        if(val_3 != 0)
        {
            goto label_13;
        }
        
        val_7 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_7;
        }
        
        this.$PC = val_7;
        return (bool)val_7;
        label_9:
        UnityEngine.Coroutine val_5 = this.$this.StartCoroutine(methodName:  "exportToMayaAnimation");
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
