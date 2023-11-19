using UnityEngine;
private sealed class ActionNodeDownloadAssetBundle.<download>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal string assetUrl;
    internal int assetVersion;
    internal UnityEngine.WWW <www>__0;
    internal TzarGames.Common.ScriptViz.ActionNodeDownloadAssetBundle $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public ActionNodeDownloadAssetBundle.<download>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_11;
        TzarGames.Common.ScriptViz.ActionNodeDownloadAssetBundle val_12;
        UnityEngine.WWW val_13;
        UnityEngine.WWW val_14;
        float val_15;
        int val_11 = this.$PC;
        this.$PC = 0;
        val_11 = ((val_11 == 1) ? 1 : 0) << 2;
        var val_2 = (val_11 == 0) ? 3 : (val_11);
        if(val_2 != 4)
        {
                val_11 = 0;
            if(val_2 != 3)
        {
                return (bool)val_11;
        }
        
            UnityEngine.Debug.Log(message:  0);
            val_12 = this.$this;
            val_13 = UnityEngine.WWW.LoadFromCacheOrDownload(url:  0, version:  this.assetUrl);
            this.<www>__0 = val_13;
            val_14 = this.<www>__0;
        }
        else
        {
                val_14 = this;
            val_13 = this.<www>__0;
            val_12 = val_12;
        }
        
        val_12.impulseProgress(progress:  val_13.progress);
        if((this.<www>__0.isDone) != false)
        {
                val_15 = this.<www>__0.progress;
            this.$this.impulseProgress(progress:  val_15);
            if(this.$this.loadAllWhenDonloadComplete != false)
        {
                UnityEngine.Object[] val_8 = this.<www>__0.assetBundle.LoadAllAssets();
        }
        
            val_13 = this.<www>__0.assetBundle;
            this.$this.assetBundleSlot.VariableImpulse(variable:  val_13);
            this.$this.finishSlot.Impulse();
            val_11 = 0;
            this.$PC = 0;
            return (bool)val_11;
        }
        
        val_15 = this.$this.progressUpdateInterval;
        val_11 = 1;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  val_15);
        if(this.$disposing == true)
        {
                return (bool)val_11;
        }
        
        this.$PC = val_11;
        return (bool)val_11;
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
