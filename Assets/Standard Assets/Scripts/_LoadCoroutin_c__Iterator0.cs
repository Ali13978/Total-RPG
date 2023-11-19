using UnityEngine;
private sealed class WWWTextureLoader.<LoadCoroutin>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal UnityEngine.WWW <www>__0;
    internal SA.Common.Models.WWWTextureLoader $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public WWWTextureLoader.<LoadCoroutin>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_8;
        UnityEngine.WWW val_9;
        UnityEngine.Texture2D val_10;
        var val_11;
        string val_12;
        int val_8 = this.$PC;
        this.$PC = 0;
        val_8 = ((val_8 == 1) ? 1 : 0) << 2;
        var val_2 = (val_8 == 0) ? 3 : (val_8);
        if(val_2 != 4)
        {
                val_8 = 0;
            if(val_2 != 3)
        {
                return (bool)val_8;
        }
        
            UnityEngine.WWW val_3 = null;
            val_9 = val_3;
            val_3 = new UnityEngine.WWW(url:  this.$this._url);
            val_8 = 1;
            this.<www>__0 = val_9;
            this.$current = val_9;
            if(this.$disposing == true)
        {
                return (bool)val_8;
        }
        
            this.$PC = val_8;
            return (bool)val_8;
        }
        
        val_9 = this.$this;
        if((this.<www>__0.error) != null)
        {
                val_10 = 0;
            val_11 = public System.Void System.Action<UnityEngine.Texture2D>::Invoke(UnityEngine.Texture2D obj);
        }
        else
        {
                UnityEngine.Texture2D val_5 = this.<www>__0.texture;
            val_12 = null;
            SA.Common.Models.WWWTextureLoader.UpdateLocalCache(url:  val_12, image:  this.$this._url);
            val_9 = this.<www>__0.texture;
            val_10 = val_9;
            val_11 = public System.Void System.Action<UnityEngine.Texture2D>::Invoke(UnityEngine.Texture2D obj);
        }
        
        this.$this.OnLoad.Invoke(obj:  val_10);
        UnityEngine.GameObject val_7 = this.$this.gameObject;
        UnityEngine.Object.Destroy(obj:  0);
        val_8 = 0;
        this.$PC = 0;
        return (bool)val_8;
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
