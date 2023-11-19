using UnityEngine;
private sealed class TextConsoleSimulator.<RevealCharacters>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TMPro.TMP_Text textComponent;
    internal TMPro.TMP_TextInfo <textInfo>__0;
    internal int <totalVisibleCharacters>__0;
    internal int <visibleCount>__0;
    internal TMPro.Examples.TextConsoleSimulator $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public TextConsoleSimulator.<RevealCharacters>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_5;
        int val_6;
        TMPro.Examples.TextConsoleSimulator val_7;
        int val_8;
        int val_5 = this.$PC;
        this.$PC = 0;
        val_5 = (val_5 < 3) ? (val_5 + 3) : 0;
        if(val_5 == 5)
        {
            goto label_1;
        }
        
        if(val_5 == 4)
        {
            goto label_2;
        }
        
        val_5 = 0;
        if(val_5 != 3)
        {
                return (bool)val_5;
        }
        
        this.<textInfo>__0 = this.textComponent.textInfo;
        this.<totalVisibleCharacters>__0 = val_2.characterCount;
        this.<visibleCount>__0 = 0;
        label_1:
        if(this.$this.hasTextChanged == false)
        {
            goto label_8;
        }
        
        val_6 = this;
        this.<totalVisibleCharacters>__0 = this.<textInfo>__0.characterCount;
        val_7 = this.$this;
        this.$this.hasTextChanged = false;
        goto label_11;
        label_2:
        val_8 = 0;
        this.<visibleCount>__0 = 0;
        goto label_12;
        label_8:
        val_6 = this.<totalVisibleCharacters>__0;
        label_11:
        if((this.<visibleCount>__0) > val_6)
        {
                val_5 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  1f);
            if(this.$disposing == true)
        {
                return (bool)val_5;
        }
        
            this.$PC = val_5;
            return (bool)val_5;
        }
        
        val_8 = mem[this.<totalVisibleCharacters>__0 + 4];
        val_8 = this.<totalVisibleCharacters>__0 + 4;
        label_12:
        val_7 = this.textComponent;
        val_7.maxVisibleCharacters = val_8;
        int val_6 = this.<visibleCount>__0;
        val_6 = val_6 + 1;
        this.<visibleCount>__0 = val_6;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  0f);
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_5 = 1;
        return (bool)val_5;
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
