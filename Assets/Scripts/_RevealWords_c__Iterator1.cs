using UnityEngine;
private sealed class TextConsoleSimulator.<RevealWords>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TMPro.TMP_Text textComponent;
    internal int <totalWordCount>__0;
    internal int <totalVisibleCharacters>__0;
    internal int <counter>__0;
    internal int <currentWord>__0;
    internal int <visibleCount>__0;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public TextConsoleSimulator.<RevealWords>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        var val_11;
        int val_12;
        int val_13;
        int val_14;
        int val_15;
        int val_16;
        int val_17;
        int val_10 = this.$PC;
        this.$PC = 0;
        val_10 = (val_10 < 3) ? (val_10 + 3) : 0;
        if(val_10 == 3)
        {
            goto label_1;
        }
        
        if(val_10 == 5)
        {
            goto label_2;
        }
        
        val_12 = 0;
        if(val_10 != 4)
        {
                return (bool)val_12;
        }
        
        goto label_4;
        label_1:
        TMPro.TMP_TextInfo val_2 = this.textComponent.textInfo;
        val_13 = this;
        this.<totalWordCount>__0 = val_2.wordCount;
        val_11 = this.textComponent.textInfo;
        val_14 = this;
        val_15 = 0;
        this.<totalVisibleCharacters>__0 = val_3.characterCount;
        this.<counter>__0 = 0;
        this.<currentWord>__0 = 0;
        mem[1152921512523264056] = 0;
        goto label_10;
        label_2:
        val_15 = this.<counter>__0;
        val_13 = this.<totalWordCount>__0;
        val_14 = this.<currentWord>__0;
        label_10:
        val_16 = mem[this.<totalWordCount>__0 + 4];
        val_16 = this.<totalWordCount>__0 + 4;
        int val_4 = val_13 + 1;
        val_15 = val_15 - ((val_15 / val_4) * val_4);
        mem2[0] = val_15;
        if(val_15 == 0)
        {
            goto label_11;
        }
        
        if(val_15 >= val_13)
        {
            goto label_12;
        }
        
        TMPro.TMP_TextInfo val_6 = this.textComponent.textInfo;
        var val_11 = 24;
        val_11 = val_6.wordInfo + (((long)val_14 - 1) * val_11);
        val_17 = this;
        val_16 = (((long)(int)((this.<currentWord>__0 - 1)) * 24) + val_6.wordInfo + 44) + 1;
        this.<visibleCount>__0 = val_16;
        goto label_20;
        label_11:
        val_17 = this;
        val_16 = 0;
        this.<visibleCount>__0 = 0;
        goto label_20;
        label_12:
        val_17 = this.<visibleCount>__0;
        if(val_15 == val_13)
        {
                mem2[0] = val_16;
        }
        else
        {
                val_16 = mem[this.<visibleCount>__0];
            val_16 = val_17;
        }
        
        label_20:
        this.textComponent.maxVisibleCharacters = val_16;
        if(val_17 >= (this.<totalVisibleCharacters>__0))
        {
            goto label_22;
        }
        
        label_4:
        int val_12 = this.<counter>__0;
        val_12 = val_12 + 1;
        this.<counter>__0 = val_12;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_12 = 1;
        return (bool)val_12;
        label_22:
        val_12 = 1;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  1f);
        if(this.$disposing == true)
        {
                return (bool)val_12;
        }
        
        this.$PC = val_12;
        return (bool)val_12;
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
