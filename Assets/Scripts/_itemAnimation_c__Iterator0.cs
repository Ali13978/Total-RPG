using UnityEngine;
private sealed class InventoryItemUI.<itemAnimation>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.GameFramework.AnimatedIconItemComponent animComponent;
    internal UnityEngine.Sprite[] <sprites>__0;
    internal float <frameTime>__0;
    internal int <currentFrame>__0;
    internal TzarGames.Endless.UI.InventoryItemUI $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public InventoryItemUI.<itemAnimation>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_5;
        TzarGames.GameFramework.AnimatedIconItemComponent val_6;
        int val_5 = this.$PC;
        this.$PC = 0;
        val_5 = ((val_5 == 1) ? 1 : 0) << 2;
        var val_2 = (val_5 == 0) ? 3 : (val_5);
        if(val_2 == 4)
        {
            goto label_1;
        }
        
        val_5 = 0;
        if(val_2 != 3)
        {
                return (bool)val_5;
        }
        
        val_6 = this.animComponent;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        this.<sprites>__0 = this.animComponent.sprites;
        goto label_4;
        label_1:
        int val_3 = (this.<currentFrame>__0) + 1;
        this.<currentFrame>__0 = val_3;
        if(val_3 >= (this.<sprites>__0.Length))
        {
            goto label_6;
        }
        
        goto label_7;
        label_3:
        val_6 = this.animComponent;
        this.<sprites>__0 = this.animComponent.sprites;
        if(this.animComponent == null)
        {
            goto label_8;
        }
        
        label_4:
        float val_6 = (float)this.animComponent.fps;
        val_6 = 1f / val_6;
        this.<frameTime>__0 = val_6;
        label_6:
        this.<currentFrame>__0 = 0;
        label_7:
        this.$this.iconImage.sprite = this.<sprites>__0[this.<currentFrame>__0];
        val_5 = 1;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  this.<frameTime>__0);
        if(this.$disposing == true)
        {
                return (bool)val_5;
        }
        
        this.$PC = val_5;
        return (bool)val_5;
        label_8:
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
