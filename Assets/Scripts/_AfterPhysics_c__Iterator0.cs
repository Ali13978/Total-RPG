using UnityEngine;
private sealed class CinemachineBrain.<AfterPhysics>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal Cinemachine.CinemachineBrain $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public CinemachineBrain.<AfterPhysics>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_7;
        Cinemachine.CinemachineBrain val_8;
        Cinemachine.CinemachineBrain val_9;
        var val_10;
        Cinemachine.CinemachineBrain val_11;
        float val_13;
        UpdateFilter val_14;
        int val_7 = this.$PC;
        this.$PC = 0;
        val_7 = ((val_7 == 1) ? 1 : 0) << 2;
        var val_2 = (val_7 == 0) ? 3 : (val_7);
        if(val_2 == 4)
        {
            goto label_1;
        }
        
        val_7 = 0;
        if(val_2 != 3)
        {
                return (bool)val_7;
        }
        
        val_8 = this.$this;
        goto label_12;
        label_1:
        val_8 = this;
        val_9 = this.$this;
        if(val_9 == null)
        {
            goto label_4;
        }
        
        if(this.$this.m_UpdateMethod == 2)
        {
            goto label_8;
        }
        
        goto label_6;
        label_4:
        if(null == null)
        {
            goto label_7;
        }
        
        val_9 = null;
        if(this.$this.m_UpdateMethod == 2)
        {
            goto label_8;
        }
        
        label_6:
        if(this.$this.m_UpdateMethod != 1)
        {
            goto label_9;
        }
        
        val_10 = null;
        val_10 = null;
        Cinemachine.CinemachineBrain.msSubframes = 1;
        goto label_12;
        label_9:
        null.AddSubframe();
        val_11 = null;
        if(val_11 == null)
        {
            goto label_14;
        }
        
        val_13 = val_11.GetEffectiveDeltaTime(fixedDelta:  true);
        goto label_15;
        label_7:
        val_9 = 0;
        label_8:
        val_9.AddSubframe();
        val_11 = null;
        if(val_11 != null)
        {
                val_13 = val_11.GetEffectiveDeltaTime(fixedDelta:  true);
        }
        else
        {
                val_13 = 0.GetEffectiveDeltaTime(fixedDelta:  true);
        }
        
        val_14 = 0;
        goto label_18;
        label_14:
        val_13 = 0.GetEffectiveDeltaTime(fixedDelta:  true);
        label_15:
        val_14 = 1;
        label_18:
        val_11.UpdateVirtualCameras(updateFilter:  val_14, deltaTime:  val_13);
        label_12:
        val_7 = 1;
        this.$current = this.$this.mWaitForFixedUpdate;
        if(this.$disposing == true)
        {
                return (bool)val_7;
        }
        
        this.$PC = val_7;
        return (bool)val_7;
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
