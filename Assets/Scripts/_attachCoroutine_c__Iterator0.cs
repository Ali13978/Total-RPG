using UnityEngine;
private sealed class DamageParticles.<attachCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.Common.TransformAttachment <attachment>__0;
    internal UnityEngine.Transform target;
    internal TzarGames.GameFramework.DamageParticles $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public DamageParticles.<attachCoroutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_7;
        UnityEngine.Transform val_8;
        int val_7 = this.$PC;
        this.$PC = 0;
        val_7 = ((val_7 == 1) ? 1 : 0) << 2;
        var val_2 = (val_7 == 0) ? 3 : (val_7);
        if(val_2 != 3)
        {
                val_7 = 0;
            if(val_2 != 4)
        {
                return (bool)val_7;
        }
        
            val_8 = this.target;
        }
        else
        {
                this.<attachment>__0 = new TzarGames.Common.TransformAttachment();
            val_8 = this;
            SetAttachment(parent:  this.$this.attachPoint, child:  this.target);
        }
        
        if(0 != null)
        {
                if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                this.<attachment>__0.Update();
            val_7 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_7;
        }
        
            this.$PC = val_7;
            return (bool)val_7;
        }
        
        }
        
        val_7 = 0;
        this.$PC = 0;
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
