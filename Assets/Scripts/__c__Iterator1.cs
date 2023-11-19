using UnityEngine;
private sealed class JSONNode.<>c__Iterator1 : IEnumerable, IEnumerable<I2.Loc.SimpleJSON.JSONNode>, IEnumerator, IDisposable, IEnumerator<I2.Loc.SimpleJSON.JSONNode>
{
    // Fields
    internal System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode> $locvar0;
    internal I2.Loc.SimpleJSON.JSONNode <C>__1;
    internal System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode> $locvar1;
    internal I2.Loc.SimpleJSON.JSONNode <D>__2;
    internal I2.Loc.SimpleJSON.JSONNode $this;
    internal I2.Loc.SimpleJSON.JSONNode $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private I2.Loc.SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public JSONNode.<>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_14;
        var val_15;
        var val_16;
        System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode> val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        this.$PC = 0;
        var val_1 = (this.$PC == 1) ? 1 : 0;
        val_1 = val_1 << 2;
        var val_2 = (this.$PC == 0) ? 3 : (val_1);
        if(val_2 == 4)
        {
            goto label_1;
        }
        
        val_14 = 0;
        if(val_2 != 3)
        {
                return (bool)val_14;
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_15 = this.$this;
        goto label_8;
        label_1:
        if(this.$PC != 1)
        {
            goto label_47;
        }
        
        val_16 = this;
        val_17 = this.$locvar1;
        val_18 = 0;
        goto label_10;
        label_8:
        val_18 = 0;
        this.$locvar0 = this.$this;
        goto label_48;
        label_54:
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_19 = this.$locvar0;
        this.<C>__1 = this.$locvar0;
        System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> val_5 = this.$locvar0.DeepChilds;
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_20 = val_5;
        val_17 = val_5;
        val_16 = this;
        this.$locvar1 = val_17;
        label_10:
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_21 = val_17;
        if(((val_17 & 1) & 1) == 0)
        {
            goto label_30;
        }
        
        var val_20 = mem[val_5];
        if((mem[val_5] + 258) == 0)
        {
            goto label_32;
        }
        
        var val_16 = mem[val_5] + 152;
        var val_17 = 0;
        val_16 = val_16 + 8;
        label_34:
        if(((mem[val_5] + 152 + 8) + -8) == null)
        {
            goto label_33;
        }
        
        val_17 = val_17 + 1;
        val_16 = val_16 + 16;
        if(val_17 < (mem[val_5] + 258))
        {
            goto label_34;
        }
        
        label_32:
        val_22 = this.$locvar1;
        goto label_35;
        label_30:
        if(this.$locvar1 == null)
        {
            goto label_36;
        }
        
        var val_21 = mem[val_5];
        if((mem[val_5] + 258) == 0)
        {
            goto label_37;
        }
        
        var val_18 = mem[val_5] + 152;
        var val_19 = 0;
        val_18 = val_18 + 8;
        label_39:
        if(((mem[val_5] + 152 + 8) + -8) == null)
        {
            goto label_38;
        }
        
        val_19 = val_19 + 1;
        val_18 = val_18 + 16;
        if(val_19 < (mem[val_5] + 258))
        {
            goto label_39;
        }
        
        label_37:
        val_23 = this.$locvar1;
        goto label_40;
        label_33:
        val_20 = val_20 + (((mem[val_5] + 152 + 8)) << 4);
        val_22 = val_20 + 272;
        label_35:
        this.<D>__2 = this.$locvar1;
        this.$current = this.$locvar1;
        val_14 = 1;
        if(this.$disposing == true)
        {
                return (bool)val_14;
        }
        
        this.$PC = val_14;
        return (bool)val_14;
        label_38:
        val_21 = val_21 + (((mem[val_5] + 152 + 8)) << 4);
        val_23 = val_21 + 272;
        label_40:
        label_36:
        if(235 == 235)
        {
            goto label_48;
        }
        
        if(235 != 292)
        {
            goto label_44;
        }
        
        val_24 = 292;
        goto label_66;
        label_44:
        if(val_18 != 0)
        {
                val_18 = 0;
        }
        else
        {
                label_47:
            val_18 = 0;
        }
        
        label_48:
        var val_22 = 0;
        val_22 = val_22 + 1;
        val_25 = this.$locvar0;
        if(((this.$locvar0 & 1) & 1) != 0)
        {
            goto label_54;
        }
        
        val_24 = 283;
        label_66:
        val_17 = this.$locvar0;
        if(val_17 != null)
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            val_26 = val_17;
        }
        
        if(283 != 283)
        {
                if(283 == 292)
        {
                val_14 = 1;
            return (bool)val_14;
        }
        
        }
        
        val_14 = 0;
        this.$PC = 0;
        return (bool)val_14;
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
        System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode> val_9;
        var val_10;
        var val_11;
        var val_12;
        val_9 = this;
        this.$disposing = true;
        this.$PC = 0;
        if(this.$PC != 1)
        {
                return;
        }
        
        if(this.$locvar1 != null)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_10 = this.$locvar1;
        }
        
        val_11 = 96;
        val_9 = this.$locvar0;
        if(val_9 != null)
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            val_12 = val_9;
        }
        
        if(val_11 == 96)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_9 = ???;
        val_11 = ???;
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
        I2.Loc.SimpleJSON.JSONNode val_4;
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
        typeof(JSONNode.<>c__Iterator1).__il2cppRuntimeField_30 = val_4;
        return (System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>)val_5;
    }

}
