using UnityEngine;
private sealed class PrefabAsyncLoader.<Load>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal UnityEngine.ResourceRequest <request>__0;
    internal SA.Common.Models.PrefabAsyncLoader $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public PrefabAsyncLoader.<Load>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_11;
        var val_12;
        UnityEngine.GameObject val_13;
        var val_14;
        var val_15;
        int val_11 = this.$PC;
        this.$PC = 0;
        val_11 = ((val_11 == 1) ? 1 : 0) << 2;
        var val_2 = (val_11 == 0) ? 3 : (val_11);
        if(val_2 != 4)
        {
                val_11 = 0;
            if(val_2 != 3)
        {
                return (bool)val_11;
        }
        
            UnityEngine.ResourceRequest val_3 = UnityEngine.Resources.LoadAsync(path:  0);
            this.<request>__0 = val_3;
            this.$current = val_3;
            val_11 = 1;
            if(this.$disposing == true)
        {
                return (bool)val_11;
        }
        
            this.$PC = val_11;
            return (bool)val_11;
        }
        
        if(0 == (this.<request>__0.asset))
        {
                val_12 = this;
            string val_6 = 0 + "Prefab not found at path: "("Prefab not found at path: ");
            UnityEngine.Debug.LogWarning(message:  0);
            val_13 = 0;
            val_14 = public System.Void System.Action<UnityEngine.GameObject>::Invoke(UnityEngine.GameObject obj);
        }
        else
        {
                UnityEngine.Object val_7 = this.<request>__0.asset;
            UnityEngine.Object val_8 = UnityEngine.Object.Instantiate(original:  0);
            val_15 = 0;
            val_12 = this;
            val_13 = (null == null) ? (val_8) : 0;
            val_14 = public System.Void System.Action<UnityEngine.GameObject>::Invoke(UnityEngine.GameObject obj);
        }
        
        this.$this.ObjectLoadedAction.Invoke(obj:  val_13);
        UnityEngine.GameObject val_10 = this.$this.gameObject;
        UnityEngine.Object.Destroy(obj:  0);
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
