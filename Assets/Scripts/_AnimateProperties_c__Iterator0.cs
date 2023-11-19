using UnityEngine;
private sealed class ShaderPropAnimator.<AnimateProperties>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <glowPower>__1;
    internal TMPro.Examples.ShaderPropAnimator $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public ShaderPropAnimator.<AnimateProperties>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_8;
        TMPro.Examples.ShaderPropAnimator val_9;
        TMPro.Examples.ShaderPropAnimator val_10;
        var val_11;
        int val_8 = this.$PC;
        this.$PC = 0;
        val_8 = ((val_8 == 1) ? 1 : 0) << 2;
        var val_2 = (val_8 == 0) ? 3 : (val_8);
        if(val_2 != 3)
        {
                val_8 = 0;
            if(val_2 != 4)
        {
                return (bool)val_8;
        }
        
            val_9 = this.$this;
        }
        else
        {
                val_9 = this;
            this.$this.m_frame = UnityEngine.Random.Range(min:  0f, max:  1f);
        }
        
        val_10 = null;
        if(null != null)
        {
            goto label_5;
        }
        
        val_10 = null;
        if(val_10 == null)
        {
            goto label_6;
        }
        
        label_5:
        this.<glowPower>__1 = this.$this.GlowCurve.Evaluate(time:  this.$this.m_frame);
        val_11 = null;
        val_11 = null;
        this.$this.m_Material.SetFloat(nameID:  TMPro.ShaderUtilities.ID_GlowPower, value:  this.<glowPower>__1);
        float val_6 = UnityEngine.Random.Range(min:  0.2f, max:  0.3f);
        val_6 = UnityEngine.Time.deltaTime * val_6;
        val_6 = this.$this.m_frame + val_6;
        m_frame = val_6;
        val_8 = 1;
        this.$current = new UnityEngine.WaitForEndOfFrame();
        if(this.$disposing == true)
        {
                return (bool)val_8;
        }
        
        this.$PC = val_8;
        return (bool)val_8;
        label_6:
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
