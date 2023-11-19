using UnityEngine;
private sealed class ThirdPersonCamera.<offsetChangeRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float time;
    internal float <speedScale>__0;
    internal float <alpha>__0;
    internal float <startOffset>__0;
    internal float targetOffset;
    internal TzarGames.Endless.ThirdPersonCamera $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public ThirdPersonCamera.<offsetChangeRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_5;
        float val_6;
        TzarGames.Endless.ThirdPersonCamera val_7;
        float val_8;
        int val_5 = this.$PC;
        this.$PC = 0;
        val_5 = ((val_5 == 1) ? 1 : 0) << 2;
        var val_2 = (val_5 == 0) ? 3 : (val_5);
        if(val_2 != 3)
        {
                val_5 = 0;
            if(val_2 != 4)
        {
                return (bool)val_5;
        }
        
            val_6 = this.<alpha>__0;
        }
        else
        {
                float val_6 = this.time;
            val_6 = this;
            val_6 = 1f / val_6;
            this.<speedScale>__0 = val_6;
            this.<alpha>__0 = 0f;
            val_7 = this.$this;
            this.<startOffset>__0 = this.$this.cameraOffset;
        }
        
        val_8 = this.<alpha>__0;
        if(val_8 >= 0)
        {
                val_7 = this.targetOffset;
            this.$this.cameraOffset = val_7;
            val_5 = 0;
            this.$this.cameraOffsetCoroutine = 0;
            this.$PC = 0;
            return (bool)val_5;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = val_3 * (this.<speedScale>__0);
        val_8 = val_8 + val_3;
        this.<alpha>__0 = val_8;
        val_8 = UnityEngine.Mathf.Lerp(a:  this.<startOffset>__0, b:  this.targetOffset, t:  val_8);
        this.$this.cameraOffset = val_8;
        val_5 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_5;
        }
        
        this.$PC = val_5;
        return (bool)val_5;
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
