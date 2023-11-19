using UnityEngine;
private sealed class ApplicationManager.<ApplicationInit>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.GameFramework.ApplicationManager $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public ApplicationManager.<ApplicationInit>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        this.$PC = 0;
        if(this.$PC != 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_1 = this.$this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        0.localProcessCmdArgs();
        return false;
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
    
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
