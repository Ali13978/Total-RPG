using UnityEngine;
private sealed class GoogleTranslation.<WaitForTranslations>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal I2.Loc.TranslationJob[] <jobs>__1;
    internal I2.Loc.TranslationJob[] $locvar0;
    internal int $locvar1;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public GoogleTranslation.<WaitForTranslations>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        var val_5;
        var val_6;
        var val_7;
        I2.Loc.TranslationJob[] val_8;
        int val_9;
        var val_10;
        int val_11;
        int val_4 = this.$PC;
        this.$PC = 0;
        val_4 = val_4 | 1;
        if(val_4 != 1)
        {
            goto label_1;
        }
        
        val_5 = null;
        val_5 = null;
        if(I2.Loc.GoogleTranslation.mTranslationJobs.Count <= 0)
        {
            goto label_5;
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = public T[] System.Collections.Generic.List<I2.Loc.TranslationJob>::ToArray();
        val_8 = I2.Loc.GoogleTranslation.mTranslationJobs.ToArray();
        this.<jobs>__1 = val_8;
        this.$locvar0 = val_8;
        val_9 = 0;
        goto label_9;
        label_19:
        val_8 = this.$locvar0;
        val_9 = this.$locvar1 + 1;
        label_9:
        this.$locvar1 = val_9;
        if(val_9 >= this.$locvar0.Length)
        {
            goto label_11;
        }
        
        if(this.$locvar1 >= this.$locvar0.Length)
        {
                val_7 = 0;
        }
        
        I2.Loc.TranslationJob val_5 = this.$locvar0[this.$locvar1];
        if(val_5 == null)
        {
            goto label_19;
        }
        
        val_10 = null;
        val_10 = null;
        bool val_3 = I2.Loc.GoogleTranslation.mTranslationJobs.Remove(item:  val_5);
        goto label_19;
        label_1:
        val_11 = 0;
        return (bool)val_11;
        label_11:
        val_11 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_11;
        }
        
        this.$PC = val_11;
        return (bool)val_11;
        label_5:
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
