using UnityEngine;
private sealed class JSONClass.<GetEnumerator>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal System.Collections.Generic.Dictionary.Enumerator<string, I2.Loc.SimpleJSON.JSONNode> $locvar0;
    internal System.Collections.Generic.KeyValuePair<string, I2.Loc.SimpleJSON.JSONNode> <N>__1;
    internal I2.Loc.SimpleJSON.JSONClass $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public JSONClass.<GetEnumerator>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        var val_4;
        Dictionary.Enumerator<System.String, I2.Loc.SimpleJSON.JSONNode> val_5;
        int val_9;
        Dictionary.Enumerator<System.String, I2.Loc.SimpleJSON.JSONNode> val_10;
        int val_8 = this.$PC;
        this.$PC = 0;
        val_8 = ((val_8 == 1) ? 1 : 0) << 2;
        var val_2 = (val_8 == 0) ? 3 : (val_8);
        if(val_2 != 3)
        {
                val_9 = 0;
            if(val_2 != 4)
        {
                return (bool)val_9;
        }
        
            val_10 = this.$locvar0;
        }
        else
        {
                Dictionary.Enumerator<TKey, TValue> val_3 = this.$this.m_Dict.GetEnumerator();
            val_10 = this.$locvar0;
            mem[1152921512249778736] = val_4;
            this.$locvar0 = val_5;
        }
        
        if(((val_10 & 1) & 1) != 0)
        {
                UnityEngine.Playables.PlayableHandle val_7 = val_10.GetHandle();
            this.<N>__1 = val_7.m_Handle;
            mem[1152921512249778760] = val_7.m_Version;
            this.$current = val_7.m_Handle;
            val_9 = 1;
            if(this.$disposing == true)
        {
                return (bool)val_9;
        }
        
            this.$PC = val_9;
            return (bool)val_9;
        }
        
        val_10.Dispose();
        val_9 = 0;
        this.$PC = 0;
        return (bool)val_9;
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
        if(this.$PC != 1)
        {
                return;
        }
        
        this.$locvar0.Dispose();
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
