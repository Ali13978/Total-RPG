using UnityEngine;
private sealed class ThirdPersonCamera.<smoothPitchChangeRoutine>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <elapsedTime>__0;
    internal float <startPitch>__0;
    internal float pitch;
    internal float time;
    internal float <timeMultiplier>__0;
    internal TzarGames.Endless.ThirdPersonCamera $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public ThirdPersonCamera.<smoothPitchChangeRoutine>c__Iterator2()
    {
    
    }
    public bool MoveNext()
    {
        int val_6;
        float val_7;
        float val_8;
        TzarGames.Endless.ThirdPersonCamera val_9;
        float val_10;
        float val_11;
        float val_12;
        int val_6 = this.$PC;
        this.$PC = 0;
        val_6 = ((val_6 == 1) ? 1 : 0) << 2;
        var val_2 = (val_6 == 0) ? 3 : (val_6);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_6 = 0;
        if(val_2 != 4)
        {
                return (bool)val_6;
        }
        
        val_7 = this.time;
        val_8 = this.<elapsedTime>__0;
        val_9 = this.$this;
        goto label_3;
        label_1:
        val_8 = this;
        this.<elapsedTime>__0 = 0f;
        val_9 = this;
        this.<startPitch>__0 = this.$this.cameraPitch;
        if(this.$this.cameraPitch <= 180f)
        {
            goto label_5;
        }
        
        val_10 = -360f;
        goto label_6;
        label_5:
        if(this.$this.cameraPitch >= 0)
        {
            goto label_7;
        }
        
        val_10 = 360f;
        label_6:
        float val_3 = this.$this.cameraPitch + val_10;
        this.<startPitch>__0 = val_3;
        this.$this.cameraPitch = val_3;
        label_7:
        float val_7 = this.pitch;
        if(val_7 <= 180f)
        {
            goto label_9;
        }
        
        val_11 = -360f;
        goto label_10;
        label_9:
        if(val_7 >= 0)
        {
            goto label_11;
        }
        
        val_11 = 360f;
        label_10:
        val_7 = val_7 + val_11;
        this.pitch = val_7;
        label_11:
        val_7 = this.time;
        float val_8 = 1f;
        val_8 = val_8 / val_7;
        this.<timeMultiplier>__0 = val_8;
        label_3:
        val_12 = this.<elapsedTime>__0;
        if(val_12 >= 0)
        {
                cameraPitch = this.pitch;
            val_6 = 0;
            pitchChangeCoroutine = 0;
            this.$PC = 0;
            return (bool)val_6;
        }
        
        cameraPitch = UnityEngine.Mathf.Lerp(a:  this.<startPitch>__0, b:  this.pitch, t:  val_12);
        val_12 = this.<elapsedTime>__0;
        float val_5 = UnityEngine.Time.deltaTime;
        val_6 = 1;
        this.$current = 0;
        val_5 = val_5 * (this.<timeMultiplier>__0);
        val_5 = val_12 + val_5;
        this.<elapsedTime>__0 = val_5;
        if(this.$disposing == true)
        {
                return (bool)val_6;
        }
        
        this.$PC = val_6;
        return (bool)val_6;
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
