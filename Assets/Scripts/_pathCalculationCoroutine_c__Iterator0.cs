using UnityEngine;
private sealed class NavMeshCharacterMovement.<pathCalculationCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.GameFramework.NavMeshPathResult <result>__0;
    internal System.Action<TzarGames.GameFramework.IPathResult> callback;
    internal TzarGames.GameFramework.NavMeshCharacterMovement $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public NavMeshCharacterMovement.<pathCalculationCoroutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_9;
        TzarGames.GameFramework.NavMeshPathResult val_10;
        int val_9 = this.$PC;
        this.$PC = 0;
        val_9 = val_9 | 1;
        if(val_9 != 1)
        {
            goto label_1;
        }
        
        if(this.$this.agent.pathPending == false)
        {
            goto label_4;
        }
        
        val_9 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_9;
        }
        
        this.$PC = val_9;
        return (bool)val_9;
        label_1:
        val_9 = 0;
        return (bool)val_9;
        label_4:
        this.$this.pathCoroutine = 0;
        this.<result>__0 = new TzarGames.GameFramework.NavMeshPathResult();
        val_10 = this.<result>__0;
        if(this.$this.agent.pathStatus != 0)
        {
                this.<result>__0.AllocatedCornerCount = 0;
            this.<result>__0.<ResultType>k__BackingField = 2;
        }
        else
        {
                this.<result>__0.<ResultType>k__BackingField = (this.$this.agent.pathStatus != 0) ? 1 : 0;
            val_10 = this.<result>__0.PathPoints;
            this.<result>__0.AllocatedCornerCount = this.$this.agent.path.GetCornersNonAlloc(results:  val_10);
        }
        
        this.callback.Invoke(obj:  this.<result>__0);
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
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
