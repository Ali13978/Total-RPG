using UnityEngine;
private sealed class JSONClass.<>c__Iterator0 : IEnumerable, IEnumerable<I2.Loc.SimpleJSON.JSONNode>, IEnumerator, IDisposable, IEnumerator<I2.Loc.SimpleJSON.JSONNode>
{
    // Fields
    internal System.Collections.Generic.Dictionary.Enumerator<string, I2.Loc.SimpleJSON.JSONNode> $locvar0;
    internal System.Collections.Generic.KeyValuePair<string, I2.Loc.SimpleJSON.JSONNode> <N>__1;
    internal I2.Loc.SimpleJSON.JSONClass $this;
    internal I2.Loc.SimpleJSON.JSONNode $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private I2.Loc.SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public JSONClass.<>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        var val_4;
        Dictionary.Enumerator<System.String, I2.Loc.SimpleJSON.JSONNode> val_5;
        int val_8;
        Dictionary.Enumerator<System.String, I2.Loc.SimpleJSON.JSONNode> val_9;
        int val_8 = this.$PC;
        this.$PC = 0;
        val_8 = ((val_8 == 1) ? 1 : 0) << 2;
        var val_2 = (val_8 == 0) ? 3 : (val_8);
        if(val_2 != 3)
        {
                val_8 = 0;
            if(val_2 != 4)
        {
                return (bool)val_8;
        }
        
            val_9 = this.$locvar0;
        }
        else
        {
                Dictionary.Enumerator<TKey, TValue> val_3 = this.$this.m_Dict.GetEnumerator();
            val_9 = this.$locvar0;
            mem[1152921512248836656] = val_4;
            this.$locvar0 = val_5;
        }
        
        if(((val_9 & 1) & 1) != 0)
        {
                UnityEngine.Playables.PlayableHandle val_7 = val_9.GetHandle();
            this.<N>__1 = val_7.m_Handle;
            mem[1152921512248836680] = val_7.m_Version;
            this.$current = 1152921512248836672;
            val_8 = 1;
            if(this.$disposing == true)
        {
                return (bool)val_8;
        }
        
            this.$PC = val_8;
            return (bool)val_8;
        }
        
        val_9.Dispose();
        val_8 = 0;
        this.$PC = 0;
        return (bool)val_8;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private I2.Loc.SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.get_Current()
    {
        return (I2.Loc.SimpleJSON.JSONNode)this.$current;
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
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator();
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
    {
        I2.Loc.SimpleJSON.JSONClass val_4;
        var val_5;
        val_4 = this;
        if((System.Threading.Interlocked.CompareExchange(location1: ref  0, value:  this.$PC, comparand:  0)) == 2)
        {
                val_5 = val_4;
            return (System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>)val_5;
        }
        
        object val_3 = null;
        val_5 = val_3;
        val_3 = new System.Object();
        val_4 = this.$this;
        typeof(JSONClass.<>c__Iterator0).__il2cppRuntimeField_40 = val_4;
        return (System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>)val_5;
    }

}
