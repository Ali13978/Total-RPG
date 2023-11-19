using UnityEngine;
private sealed class PushToPoolOnTime.<timeRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float timeToWait;
    internal TzarGames.GameFramework.PushToPoolOnTime $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public PushToPoolOnTime.<timeRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_9;
        bool val_10;
        int val_9 = this.$PC;
        this.$PC = 0;
        val_9 = ((val_9 == 1) ? 1 : 0) << 2;
        var val_2 = (val_9 == 0) ? 3 : (val_9);
        if(val_2 != 4)
        {
                val_9 = 0;
            if(val_2 != 3)
        {
                return (bool)val_9;
        }
        
            val_9 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  this.timeToWait);
            if(this.$disposing == true)
        {
                return (bool)val_9;
        }
        
            this.$PC = val_9;
            return (bool)val_9;
        }
        
        UnityEngine.GameObject val_4 = this.$this.gameObject;
        val_10 = TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  0);
        if(val_10 != false)
        {
                UnityEngine.GameObject val_6 = this.$this.gameObject;
            TzarGames.GameFramework.Instantiator.PushToPool(instanceObject:  0);
        }
        else
        {
                val_10 = this.$this.destroyIfNoPool;
            UnityEngine.GameObject val_7 = this.$this.gameObject;
            if(val_10 != false)
        {
                UnityEngine.Object.Destroy(obj:  0);
        }
        else
        {
                string val_8 = 0 + "No pool found for object ";
            UnityEngine.Debug.LogError(message:  0);
        }
        
        }
        
        val_9 = 0;
        this.$this.coroutine = 0;
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
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
