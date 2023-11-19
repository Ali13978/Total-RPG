using UnityEngine;
private sealed class MazeObjectActivator.<updateRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal UnityEngine.Vector3 <targetPos>__1;
    internal float <sqrDistance>__1;
    internal TzarGames.Endless.Maze.MazeObjectActivator $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public MazeObjectActivator.<updateRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_3;
        TzarGames.Endless.Maze.MazeObjectActivator val_4;
        var val_5;
        int val_6 = this.$PC;
        val_3 = 0;
        this.$PC = 0;
        val_6 = val_6 | 1;
        if(val_6 != 1)
        {
                return (bool)val_3;
        }
        
        UnityEngine.Vector3 val_1 = this.$this.<Target>k__BackingField.position;
        this.<targetPos>__1 = val_1;
        mem[1152921510738657652] = val_1.y;
        mem[1152921510738657656] = val_1.z;
        val_4 = this.$this;
        if(this.$this != null)
        {
            goto label_4;
        }
        
        val_4 = this.$this;
        if(val_4 == null)
        {
            goto label_5;
        }
        
        label_4:
        float val_7 = this.$this.radius;
        val_5 = 0;
        val_7 = val_7 * this.$this.radius;
        this.<sqrDistance>__1 = val_7;
        goto label_6;
        label_27:
        val_5 = 1;
        label_6:
        if(val_5 >= this.$this.objects.Length)
        {
            goto label_9;
        }
        
        var val_2 = this.$this.objects + (1 * 24);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<targetPos>__1, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = (1 * 24) + this.$this.objects + 40, y = (1 * 24) + this.$this.objects + 40 + 4, z = (1 * 24) + this.$this.objects + 48});
        if(val_3.x <= (this.<sqrDistance>__1))
        {
            goto label_15;
        }
        
        if(((1 * 24) + this.$this.objects + 52) == 0)
        {
            goto label_27;
        }
        
        var val_4 = this.$this.objects + (1 * 24);
        mem2[0] = (1 * 24) + this.$this.objects + 32;
        mem2[0] = (1 * 24) + this.$this.objects + 40;
        mem2[0] = (1 * 24) + this.$this.objects + 40 + 4;
        mem2[0] = 0;
        mem2[0] = (1 * 24) + this.$this.objects + 48;
        mem2[0] = (1 * 24) + this.$this.objects + 55;
        mem2[0] = (1 * 24) + this.$this.objects + 53;
        (1 * 24) + this.$this.objects + 32.Deactivate();
        goto label_27;
        label_15:
        if(((1 * 24) + this.$this.objects + 52) != 0)
        {
            goto label_27;
        }
        
        var val_5 = this.$this.objects + (1 * 24);
        mem2[0] = (1 * 24) + this.$this.objects + 32;
        mem2[0] = (1 * 24) + this.$this.objects + 40;
        mem2[0] = (1 * 24) + this.$this.objects + 40 + 4;
        mem2[0] = 1;
        mem2[0] = (1 * 24) + this.$this.objects + 48;
        mem2[0] = (1 * 24) + this.$this.objects + 55;
        mem2[0] = (1 * 24) + this.$this.objects + 53;
        (1 * 24) + this.$this.objects + 32.Activate();
        goto label_27;
        label_9:
        val_3 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_3;
        }
        
        this.$PC = val_3;
        return (bool)val_3;
        label_5:
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
