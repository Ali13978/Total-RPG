using UnityEngine;
private sealed class ReorderableListContent.<RefreshChildren>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal UnityEngine.UI.Extensions.ReorderableListContent $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public ReorderableListContent.<RefreshChildren>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_18;
        var val_19;
        var val_20;
        var val_21;
        UnityEngine.RectTransform val_22;
        UnityEngine.UI.Extensions.ReorderableListContent val_23;
        UnityEngine.UI.Extensions.ReorderableListElement val_24;
        UnityEngine.UI.Extensions.ReorderableListContent val_25;
        UnityEngine.UI.Extensions.ReorderableListContent val_26;
        UnityEngine.UI.Extensions.ReorderableListContent val_27;
        int val_18 = this.$PC;
        this.$PC = 0;
        val_18 = ((val_18 == 1) ? 1 : 0) << 2;
        var val_2 = (val_18 == 0) ? 3 : (val_18);
        if(val_2 == 4)
        {
            goto label_1;
        }
        
        val_18 = 0;
        if(val_2 != 3)
        {
                return (bool)val_18;
        }
        
        val_19 = 1152921510750633776;
        val_20 = 1152921512697692528;
        val_21 = 0;
        goto label_3;
        label_32:
        val_21 = 1;
        label_3:
        val_22 = this.$this._rect;
        if(val_21 >= val_22.childCount)
        {
            goto label_6;
        }
        
        val_23 = this.$this;
        if(this.$this != null)
        {
            goto label_7;
        }
        
        val_23 = this.$this;
        if(val_23 == null)
        {
            goto label_30;
        }
        
        label_7:
        if((this.$this._cachedChildren.Contains(item:  this.$this._rect.GetChild(index:  1))) == true)
        {
            goto label_32;
        }
        
        val_24 = this.$this._rect.GetChild(index:  1).gameObject.GetComponent<UnityEngine.UI.Extensions.ReorderableListElement>();
        if(val_24 == null)
        {
                val_24 = this.$this._rect.GetChild(index:  1).gameObject.AddComponent<UnityEngine.UI.Extensions.ReorderableListElement>();
        }
        
        this.$this._ele = val_24;
        val_25 = this.$this;
        if(this.$this != null)
        {
            goto label_22;
        }
        
        val_25 = this.$this;
        if(val_25 == null)
        {
            goto label_30;
        }
        
        label_22:
        this.$this._ele.Init(reorderableList:  this.$this._extList);
        val_26 = this.$this;
        if(this.$this != null)
        {
            goto label_25;
        }
        
        val_26 = this.$this;
        if(val_26 == null)
        {
            goto label_30;
        }
        
        label_25:
        this.$this._cachedChildren.Add(item:  this.$this._rect.GetChild(index:  1));
        val_27 = this.$this;
        if(this.$this != null)
        {
            goto label_29;
        }
        
        val_27 = this.$this;
        if(val_27 == null)
        {
            goto label_30;
        }
        
        label_29:
        this.$this._cachedListElement.Add(item:  this.$this._ele);
        goto label_32;
        label_1:
        System.Collections.Generic.List<UnityEngine.Transform> val_19 = this.$this._cachedChildren;
        val_19 = val_19.Count - 1;
        if((val_19 & 2147483648) == 0)
        {
                val_19 = 1152921504721543168;
            val_20 = 1152921512697825648;
            do
        {
            val_22 = this.$this._cachedChildren.Item[val_19];
            if(0 == val_22)
        {
                this.$this._cachedChildren.RemoveAt(index:  val_19);
            val_22 = this.$this._cachedListElement;
            val_22.RemoveAt(index:  val_19);
        }
        
            val_19 = val_19 - 1;
        }
        while((val_19 & 2147483648) == 0);
        
        }
        
        val_18 = 0;
        this.$PC = 0;
        return (bool)val_18;
        label_6:
        this.$current = 0;
        val_18 = 1;
        if(this.$disposing == true)
        {
                return (bool)val_18;
        }
        
        this.$PC = val_18;
        return (bool)val_18;
        label_30:
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
