using UnityEngine;
private sealed class EndlessSaveManager.<getSaveDataRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal string <savedData>__0;
    internal TzarGames.Endless.EndlessSaveData <data>__1;
    internal System.Action<TzarGames.Endless.EndlessSaveData> completeCallback;
    internal TzarGames.Endless.EndlessSaveManager $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public EndlessSaveManager.<getSaveDataRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_10;
        TzarGames.Endless.EndlessSaveData val_11;
        var val_12;
        int val_10 = this.$PC;
        this.$PC = 0;
        val_10 = ((val_10 == 1) ? 1 : 0) << 2;
        var val_2 = (val_10 == 0) ? 3 : (val_10);
        if(val_2 != 4)
        {
                val_10 = 0;
            if(val_2 != 3)
        {
                return (bool)val_10;
        }
        
            val_10 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_10;
        }
        
            this.$PC = val_10;
            return (bool)val_10;
        }
        
        this.<savedData>__0 = TzarGames.SaveManager.LoadDataFromLocalStorageAsString();
        bool val_4 = System.String.IsNullOrEmpty(value:  0);
        if(val_4 != false)
        {
                val_11 = val_4.createDefaultDataAnsSave();
            this.<data>__1 = val_11;
        }
        else
        {
                val_11 = UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
            val_12 = this;
            this.<data>__1 = val_11;
            if(val_11 == null)
        {
                UnityEngine.Debug.LogError(message:  0);
            val_11 = 0.createDefaultDataAnsSave();
            mem[1152921510664978888] = val_11;
        }
        
        }
        
        this.completeCallback.Invoke(obj:  val_11);
        val_10 = 0;
        this.$PC = 0;
        return (bool)val_10;
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
