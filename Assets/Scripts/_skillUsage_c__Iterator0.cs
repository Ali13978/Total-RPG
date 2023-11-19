using UnityEngine;
private sealed class BasicSkillAI.<skillUsage>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <firstUsageTime>__1;
    internal bool <skillResult>__2;
    internal bool <canUseSkill>__3;
    internal float <nextUsageTime>__2;
    internal TzarGames.TzarHero.Skills.BasicSkillAI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public BasicSkillAI.<skillUsage>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_27;
        int val_27 = this.$PC;
        val_27 = 0;
        this.$PC = 0;
        val_27 = (val_27 < 5) ? (val_27 + 3) : 0;
        val_27 = val_27 - 3;
        if(val_27 > 4)
        {
                return (bool);
        }
        
        var val_28 = 25806640 + ((this.$PC < 5 ? (this.$PC + 3) : 0 - 3)) << 2;
        val_28 = val_28 + 25806640;
        goto (25806640 + ((this.$PC < 5 ? (this.$PC + 3) : 0 - 3)) << 2 + 25806640);
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
