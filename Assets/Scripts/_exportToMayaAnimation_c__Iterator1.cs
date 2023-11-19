using UnityEngine;
private sealed class MayaAnimationRecorder.<exportToMayaAnimation>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal string <newFilePath>__0;
    internal string <maFileData>__0;
    internal System.IO.StreamWriter <writer>__0;
    internal int <i>__1;
    internal System.IO.StreamReader <reader>__2;
    internal MayaAnimationRecorder $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public MayaAnimationRecorder.<exportToMayaAnimation>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_15;
        int val_16;
        MayaAnimationRecorder val_17;
        MayaAnimationRecorder val_18;
        var val_19;
        MayaAnimationRecorder val_20;
        int val_14 = this.$PC;
        this.$PC = 0;
        val_14 = ((val_14 == 1) ? 1 : 0) << 2;
        var val_2 = (val_14 == 0) ? 3 : (val_14);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_15 = 0;
        if(val_2 != 4)
        {
                return (bool)val_15;
        }
        
        val_16 = this.<i>__1;
        val_17 = this.$this;
        goto label_30;
        label_1:
        val_17 = this;
        val_18 = this.$this;
        if(this.$this != null)
        {
            goto label_4;
        }
        
        val_18 = null;
        if(val_18 == null)
        {
            goto label_5;
        }
        
        label_4:
        this.<newFilePath>__0 = 0 + this.$this.saveFolderPath;
        this.$this.ShowLog(logStr:  "Adjusting Spine Joint Orient Values ...");
        string val_4 = System.IO.File.ReadAllText(path:  0);
        this.<maFileData>__0 = val_4;
        this.<maFileData>__0 = System.Text.RegularExpressions.Regex.Replace(input:  0, pattern:  val_4, replacement:  "\".jo\" -type \"double3\" [^ ]* [^ ]* [^ ]*");
        this.$this.ShowLog(logStr:  "Combining File into one ...");
        this.<writer>__0 = new System.IO.StreamWriter(path:  this.<newFilePath>__0);
        val_16 = this;
        val_19 = 0;
        this.<i>__1 = 0;
        goto label_14;
        label_5:
        label_30:
        val_19 = X23 + 1;
        mem2[0] = val_19;
        label_14:
        if(val_19 >= this.$this.objAnims.Length)
        {
            goto label_17;
        }
        
        MayaNodeDataContainer[] val_7 = this.$this.objAnims + ((X23) << 3);
        this.<reader>__2 = new System.IO.StreamReader(path:  mem[(this.$this.objAnims + (X23) << 3) + 32].getFinalFilePath());
        MayaNodeDataContainer[] val_10 = this.$this.objAnims + ((X23) << 3);
        bool val_11 = mem[(this.$this.objAnims + (X23) << 3) + 32].cleanFile();
        val_20 = null;
        int val_15 = this.$this.processPerFrame;
        val_15 = X23 - ((X23 / val_15) * val_15);
        if(val_15 != 0)
        {
            goto label_30;
        }
        
        this.$current = 0;
        val_15 = 1;
        if(this.$disposing == true)
        {
                return (bool)val_15;
        }
        
        this.$PC = val_15;
        return (bool)val_15;
        label_17:
        val_20 = 0 + "Succeed export animation to : "("Succeed export animation to : ");
        null.ShowLog(logStr:  val_20);
        val_15 = 0;
        this.$PC = 0;
        return (bool)val_15;
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
