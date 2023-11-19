using UnityEngine;
private sealed class GameBundleLoader.LoadingLevel.<InitializeLevelAsync>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <startTime>__0;
    internal UnityEngine.Coroutine <crt>__0;
    internal string levelName;
    internal bool <disconnecting>__0;
    internal float <disconnectStartTime>__0;
    internal float <progress>__1;
    internal float <elapsedTime>__0;
    internal TzarGames.Endless.GameBundleLoader.LoadingLevel $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public GameBundleLoader.LoadingLevel.<InitializeLevelAsync>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        var val_22;
        int val_23;
        GameBundleLoader.LoadingLevel val_24;
        GameBundleLoader.LoadingLevel val_25;
        GameBundleLoader.LoadingLevel val_26;
        var val_27;
        val_22 = this;
        int val_22 = this.$PC;
        this.$PC = 0;
        val_22 = (val_22 < 3) ? (val_22 + 3) : 0;
        if(val_22 == 3)
        {
            goto label_1;
        }
        
        if(val_22 == 4)
        {
            goto label_2;
        }
        
        val_23 = 0;
        if(val_22 != 5)
        {
                return (bool)val_23;
        }
        
        val_24 = this.$this;
        goto label_4;
        label_2:
        AssetBundles.AssetBundleManager.Clear();
        val_24 = val_22;
        TzarGames.Endless.GameBundleLoader val_2 = this.$this.Loader;
        this.$this.request = AssetBundles.AssetBundleManager.LoadLevelAsync(assetBundleName:  0, levelName:  val_2.sceneAssetBundle, isAdditive:  this.levelName);
        val_25 = null;
        val_26 = val_25;
        if(val_25 == null)
        {
                val_26 = null;
        }
        
        if(this.$this.request == null)
        {
            goto label_11;
        }
        
        TzarGames.Endless.GameBundleLoader val_4 = val_26.Loader;
        val_4.OnLoadingStarted.Invoke();
        this.<disconnecting>__0 = false;
        this.<disconnectStartTime>__0 = 0f;
        label_4:
        val_27 = mem[mem[this.$this.request] + 400 + 8];
        val_27 = mem[this.$this.request] + 400 + 8;
        if(((this.$this.request & 1) & 1) != 0)
        {
            goto label_17;
        }
        
        val_27 = mem[mem[this.$this.request] + 432 + 8];
        val_27 = mem[this.$this.request] + 432 + 8;
        if((this.$this.request & 1) == 0)
        {
            goto label_20;
        }
        
        label_17:
        null.updateProgress(progress:  1f);
        val_26 = null;
        if((this.$this.request & 1) == 0)
        {
            goto label_24;
        }
        
        label_11:
        label_74:
        val_26.setError(error:  2);
        val_22 = null.Loader;
        bool val_7 = val_22.GotoState<GameBundleLoader.Failed>(stateData:  0);
        val_23 = 0;
        return (bool)val_23;
        label_1:
        this.$this.Loader.InitializeSourceURL();
        this.<startTime>__0 = UnityEngine.Time.realtimeSinceStartup;
        val_25 = this.$this.Loader.getDownloadSize();
        UnityEngine.Coroutine val_13 = this.$this.Loader.StartCoroutine(routine:  val_25);
        this.<crt>__0 = val_13;
        this.$current = val_13;
        val_23 = 1;
        if(this.$disposing == true)
        {
                return (bool)val_23;
        }
        
        this.$PC = val_23;
        return (bool)val_23;
        label_24:
        TzarGames.Endless.GameBundleLoader val_14 = val_26.Loader;
        val_14.OnLoadingFinished.Invoke();
        float val_15 = UnityEngine.Time.realtimeSinceStartup;
        val_15 = val_15 - (this.<startTime>__0);
        this.<elapsedTime>__0 = val_15;
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Finished loading scene ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = this.levelName;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " in ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = this.<elapsedTime>__0;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        val_25 = " seconds";
        typeof(System.Object[]).__il2cppRuntimeField_40 = val_25;
        string val_16 = +0;
        UnityEngine.Debug.Log(message:  0);
        val_23 = 0;
        this.$PC = 0;
        return (bool)val_23;
        label_20:
        TzarGames.Endless.GameBundleLoader val_17 = null.Loader;
        float val_18 = AssetBundles.AssetBundleManager.GetDownloadProgress(bundleName:  0);
        this.<progress>__1 = val_18;
        this.$this.updateProgress(progress:  val_18);
        if(UnityEngine.Application.internetReachability == 0)
        {
            goto label_66;
        }
        
        if((this.<disconnecting>__0) == false)
        {
            goto label_70;
        }
        
        this.<disconnecting>__0 = false;
        goto label_70;
        label_66:
        if((this.<disconnecting>__0) == false)
        {
            goto label_69;
        }
        
        float val_20 = UnityEngine.Time.time;
        val_20 = val_20 - (this.<disconnectStartTime>__0);
        if(val_20 < 3f)
        {
            goto label_70;
        }
        
        UnityEngine.Debug.LogError(message:  0);
        if(null != null)
        {
            goto label_74;
        }
        
        goto label_74;
        label_69:
        this.<disconnecting>__0 = true;
        this.<disconnectStartTime>__0 = UnityEngine.Time.time;
        label_70:
        this.$current = 0;
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_23 = 1;
        return (bool)val_23;
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
