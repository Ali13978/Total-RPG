using UnityEngine;
private sealed class ScrollRectTweener.<DoMove>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float duration;
    internal UnityEngine.Vector2 <posOffset>__0;
    internal float <currentTime>__0;
    internal UnityEngine.UI.Extensions.ScrollRectTweener $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public ScrollRectTweener.<DoMove>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_6;
        float val_7;
        float val_8;
        UnityEngine.UI.Extensions.ScrollRectTweener val_9;
        UnityEngine.UI.Extensions.ScrollRectTweener val_10;
        UnityEngine.Vector2 val_11;
        float val_12;
        UnityEngine.UI.Extensions.ScrollRectTweener val_13;
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
        
        val_7 = this.<currentTime>__0;
        val_8 = this.duration;
        goto label_3;
        label_1:
        val_8 = this;
        if(this.duration < 0)
        {
            goto label_4;
        }
        
        val_9 = this.$this;
        if(this.$this != null)
        {
            goto label_5;
        }
        
        val_9 = this.$this;
        if(val_9 == null)
        {
            goto label_18;
        }
        
        label_5:
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.$this.targetPos, y = V10.16B}, b:  new UnityEngine.Vector2() {x = this.$this.startPos, y = V8.16B});
        val_7 = 0f;
        this.<posOffset>__0 = val_3;
        mem[1152921512790860600] = val_3.y;
        this.<currentTime>__0 = 0f;
        label_3:
        if(val_7 < 0)
        {
            goto label_9;
        }
        
        val_10 = this.$this;
        if(this.$this != null)
        {
            goto label_10;
        }
        
        val_10 = this.$this;
        if(val_10 == null)
        {
            goto label_18;
        }
        
        label_10:
        val_11 = this.$this.targetPos;
        this.$this.scrollRect.normalizedPosition = new UnityEngine.Vector2() {x = val_11, y = this.$this.startPos};
        if(this.$this.disableDragWhileTweening != false)
        {
                this.$this.RestoreScrollability();
        }
        
        val_6 = 0;
        this.$PC = 0;
        return (bool)val_6;
        label_9:
        val_12 = val_7 + UnityEngine.Time.deltaTime;
        this.<currentTime>__0 = val_12;
        val_13 = this.$this;
        if(this.$this != null)
        {
            goto label_17;
        }
        
        val_13 = this.$this;
        if(val_13 == null)
        {
            goto label_18;
        }
        
        val_12 = this.<currentTime>__0;
        label_17:
        UnityEngine.Vector2 val_5 = 0.EaseVector(currentTime:  val_12, startValue:  new UnityEngine.Vector2() {x = this.$this.startPos, y = this.$this.startPos}, changeInValue:  new UnityEngine.Vector2() {x = this.<posOffset>__0}, duration:  this.duration);
        val_11 = val_5.x;
        this.$this.scrollRect.normalizedPosition = new UnityEngine.Vector2() {x = val_11, y = val_5.y};
        val_6 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_6;
        }
        
        this.$PC = val_6;
        return (bool)val_6;
        label_4:
        val_6 = 0;
        return (bool)val_6;
        label_18:
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
