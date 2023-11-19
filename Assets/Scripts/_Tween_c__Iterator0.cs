using UnityEngine;
private sealed class UI_TweenScale.<Tween>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <t>__0;
    internal float <maxT>__0;
    internal UnityEngine.UI.Extensions.UI_TweenScale $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public UI_TweenScale.<Tween>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_12;
        float val_13;
        float val_14;
        UnityEngine.UI.Extensions.UI_TweenScale val_15;
        var val_16;
        UnityEngine.AnimationCurve val_17;
        float val_18;
        float val_19;
        UnityEngine.UI.Extensions.UI_TweenScale val_20;
        UnityEngine.Transform val_21;
        UnityEngine.Vector3 val_23;
        var val_24;
        UnityEngine.UI.Extensions.UI_TweenScale val_25;
        UnityEngine.UI.Extensions.UI_TweenScale val_26;
        int val_12 = this.$PC;
        this.$PC = 0;
        val_12 = ((val_12 == 1) ? 1 : 0) << 2;
        var val_2 = (val_12 == 0) ? 3 : (val_12);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_12 = 0;
        if(val_2 != 4)
        {
                return (bool)val_12;
        }
        
        val_13 = this.<maxT>__0;
        val_14 = this.<t>__0;
        goto label_3;
        label_1:
        val_15 = this.$this;
        if(this.$this != null)
        {
            goto label_4;
        }
        
        val_15 = this.$this;
        if(val_15 == null)
        {
            goto label_35;
        }
        
        label_4:
        val_13 = this.$this.initScale;
        this.$this.myTransform.localScale = new UnityEngine.Vector3() {x = val_13, y = V9.16B, z = V10.16B};
        val_14 = this;
        this.<t>__0 = 0f;
        val_17 = (long)this.$this.animCurve.length - 1;
        this.<maxT>__0 = val_13;
        label_3:
        val_18 = this.<t>__0;
        if(val_18 < 0)
        {
            goto label_13;
        }
        
        if(this.$this.isLoop == false)
        {
            goto label_15;
        }
        
        val_19 = this.<t>__0;
        label_13:
        float val_6 = UnityEngine.Time.deltaTime;
        val_20 = this.$this;
        val_6 = this.$this.speed * val_6;
        val_6 = val_19 + val_6;
        this.<t>__0 = val_6;
        if(val_20 == null)
        {
            goto label_17;
        }
        
        if(this.$this.isUniform == true)
        {
            goto label_18;
        }
        
        goto label_21;
        label_17:
        if(this.$this == null)
        {
            goto label_20;
        }
        
        val_20 = this.$this;
        if(this.$this.isUniform == false)
        {
            goto label_21;
        }
        
        label_18:
        val_21 = this.$this.myTransform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        val_17 = this.$this.animCurve;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_17.Evaluate(time:  this.<t>__0));
        val_23 = val_9.x;
        val_24 = val_9.y;
        val_16 = val_9.z;
        if(val_21 != null)
        {
            goto label_36;
        }
        
        goto label_27;
        label_15:
        val_12 = 0;
        this.$PC = 0;
        return (bool)val_12;
        label_20:
        val_20 = 0;
        label_21:
        mem[72] = this.$this.animCurve.Evaluate(time:  this.<t>__0);
        val_17 = this.$this;
        val_25 = val_17;
        if(val_17 != null)
        {
            goto label_31;
        }
        
        val_25 = this.$this;
        if(val_25 == null)
        {
            goto label_35;
        }
        
        label_31:
        mem2[0] = this.$this.animCurveY.Evaluate(time:  this.<t>__0);
        val_26 = this.$this;
        if(this.$this != null)
        {
            goto label_34;
        }
        
        val_26 = this.$this;
        if(val_26 == null)
        {
            goto label_35;
        }
        
        label_34:
        val_21 = this.$this.myTransform;
        val_23 = this.$this.newScale;
        if(val_21 != null)
        {
            goto label_36;
        }
        
        label_27:
        label_36:
        val_21.localScale = new UnityEngine.Vector3() {x = val_23, y = this.$this.speed, z = V10.16B};
        val_12 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_12;
        }
        
        this.$PC = val_12;
        return (bool)val_12;
        label_35:
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
