using UnityEngine;
private sealed class GameBundleLoader.Initialization.<Initialize>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal AssetBundles.AssetBundleLoadManifestOperation <request>__1;
    internal bool <notCached>__2;
    internal UnityEngine.Hash128 <hash>__2;
    internal UnityEngine.Coroutine <crt>__3;
    internal TzarGames.Endless.GameBundleLoader.Initialization $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public GameBundleLoader.Initialization.<Initialize>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        var val_30;
        int val_31;
        var val_32;
        var val_33;
        GameBundleLoader.Initialization val_34;
        GameBundleLoader.BundleLoadErrors val_35;
        System.Collections.IEnumerator val_36;
        int val_37;
        val_30 = this;
        int val_30 = this.$PC;
        this.$PC = 0;
        int val_1 = val_30 + 3;
        val_30 = (val_30 < 4) ? (val_1) : 0;
        val_1 = val_30 - 3;
        if(val_1 < 2)
        {
            goto label_1;
        }
        
        if(val_30 == 5)
        {
            goto label_2;
        }
        
        val_31 = 0;
        if(val_30 != 6)
        {
                return (bool)val_31;
        }
        
        val_32 = this.$this.Loader;
        val_33 = 1152921510688116000;
        goto label_6;
        label_1:
        if(UnityEngine.Caching.ready == false)
        {
            goto label_7;
        }
        
        if(0 != AssetBundles.AssetBundleManager.AssetBundleManifestObject)
        {
            goto label_27;
        }
        
        TzarGames.Endless.GameBundleLoader val_6 = this.$this.Loader;
        if(val_6.useLocalManifestFile == false)
        {
            goto label_17;
        }
        
        AssetBundles.AssetBundleManager.SetSourceAssetBundleDirectory(relativePath:  0);
        goto label_20;
        label_2:
        if((this.<request>__1.HasError()) != true)
        {
                if(0 != AssetBundles.AssetBundleManager.AssetBundleManifestObject)
        {
            goto label_27;
        }
        
        }
        
        val_34 = this.$this;
        val_35 = 1;
        goto label_29;
        label_7:
        val_31 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_31;
        }
        
        this.$PC = val_31;
        return (bool)val_31;
        label_27:
        TzarGames.Endless.GameBundleLoader val_12 = this.$this.Loader;
        val_12.initComplete = true;
        this.<notCached>__2 = true;
        TzarGames.Endless.GameBundleLoader val_14 = this.$this.Loader;
        UnityEngine.Hash128 val_15 = AssetBundles.AssetBundleManager.AssetBundleManifestObject.GetAssetBundleHash(assetBundleName:  val_14.sceneAssetBundle);
        this.<hash>__2 = val_15;
        mem[1152921510688277252] = val_15.m_u32_2;
        mem[1152921510688277256] = val_15.m_u32_3;
        TzarGames.Endless.GameBundleLoader val_16 = this.$this.Loader;
        if((UnityEngine.Caching.IsVersionCached(url:  0, hash:  new UnityEngine.Hash128() {m_u32_0 = val_16.sceneAssetBundle, m_u32_1 = val_16.sceneAssetBundle, m_u32_2 = this.<hash>__2, m_u32_3 = this.<hash>__2})) != false)
        {
                val_36 = 0;
            this.<notCached>__2 = false;
        }
        
        val_32 = this.$this.Loader;
        if((((this.<notCached>__2) == true) ? 1 : 0) == 0)
        {
            goto label_45;
        }
        
        val_32.InitializeSourceURL();
        val_36 = this.$this.Loader.getDownloadSize();
        UnityEngine.Coroutine val_23 = this.$this.Loader.StartCoroutine(routine:  val_36);
        this.<crt>__3 = val_23;
        this.$current = val_23;
        if(this.$disposing == true)
        {
            goto label_58;
        }
        
        val_37 = 3;
        goto label_51;
        label_45:
        val_33 = 1152921510686544560;
        label_6:
        bool val_24 = val_32.GotoState<GameBundleLoader.LoadingLevel>(stateData:  0);
        val_31 = 0;
        this.$PC = 0;
        return (bool)val_31;
        label_17:
        this.$this.Loader.InitializeSourceURL();
        label_20:
        AssetBundles.AssetBundleManager.Clear();
        val_34 = this.$this;
        val_36 = AssetBundles.AssetBundleManager.Initialize(loadManifestFromCache:  false);
        this.<request>__1 = val_36;
        if(val_36 == null)
        {
            goto label_56;
        }
        
        val_36 = val_34.Loader;
        this.$current = val_36.StartCoroutine(routine:  this.<request>__1);
        if(this.$disposing == true)
        {
            goto label_58;
        }
        
        val_37 = 2;
        label_51:
        this.$PC = val_37;
        label_58:
        val_31 = 1;
        return (bool)val_31;
        label_56:
        val_35 = 0;
        label_29:
        val_34.setError(error:  val_35);
        val_30 = this.$this.Loader;
        bool val_29 = val_30.GotoState<GameBundleLoader.Failed>(stateData:  0);
        val_31 = 0;
        return (bool)val_31;
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
