using UnityEngine;
private sealed class RubyShopUI.<showResult>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Common.IPurchaseResult result;
    internal TzarGames.Endless.UI.RubyShopUI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public RubyShopUI.<showResult>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_15;
        var val_16;
        float val_17;
        TzarGames.Endless.UI.RubyShopUI val_18;
        var val_19;
        System.Collections.IEnumerator val_20;
        var val_21;
        var val_22;
        var val_23;
        int val_15 = this.$PC;
        this.$PC = 0;
        val_15 = ((val_15 == 1) ? 1 : 0) << 2;
        var val_2 = (val_15 == 0) ? 3 : (val_15);
        if(val_2 == 4)
        {
            goto label_5;
        }
        
        val_15 = 0;
        if(val_2 != 3)
        {
                return (bool)val_15;
        }
        
        val_16 = 0;
        val_17 = UnityEngine.Time.time;
        val_18 = this.$this;
        if(this.$this != null)
        {
            goto label_3;
        }
        
        val_18 = this.$this;
        if(val_18 == null)
        {
            goto label_4;
        }
        
        label_3:
        float val_16 = this.$this.lastWaitStartTime;
        val_16 = val_17 - val_16;
        if(val_16 < 0)
        {
                float val_4 = UnityEngine.Time.time;
            val_17 = val_4;
            UnityEngine.WaitForSeconds val_5 = null;
            val_4 = val_17 - this.$this.lastWaitStartTime;
            val_4 = this.$this.minWaitTime - val_4;
            val_5 = new UnityEngine.WaitForSeconds(seconds:  val_4);
            val_15 = 1;
            this.$current = val_5;
            if(this.$disposing == true)
        {
                return (bool)val_15;
        }
        
            this.$PC = val_15;
            return (bool)val_15;
        }
        
        label_5:
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_19 = this.result;
        if((this.result & 1) == 0)
        {
            goto label_15;
        }
        
        if(this.$this == null)
        {
            goto label_16;
        }
        
        val_20 = this.$this.showSuccessAndReturn();
        goto label_17;
        label_15:
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_21 = this.result;
        goto label_22;
        label_16:
        val_20 = 0.showSuccessAndReturn();
        label_17:
        UnityEngine.Coroutine val_9 = this.$this.StartCoroutine(routine:  val_20);
        goto label_38;
        label_22:
        this.$this.setFailureReasonText(reason:  this.result);
        bool val_11 = this.$this.GotoState<RubyShopUI.Failure>(stateData:  0);
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_22 = this.result;
        val_20 = this.result.ToString();
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        this.$this.onPurchaseFailed.Invoke(arg0:  val_20);
        label_38:
        val_15 = 0;
        this.$PC = 0;
        return (bool)val_15;
        label_4:
        val_23 = ;
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
