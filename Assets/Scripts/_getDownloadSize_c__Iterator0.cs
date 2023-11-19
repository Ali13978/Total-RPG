using UnityEngine;
private sealed class GameBundleLoader.<getDownloadSize>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal UnityEngine.Coroutine <crt>__0;
    internal TzarGames.Endless.GameBundleLoader $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    private TzarGames.Endless.GameBundleLoader.<getDownloadSize>c__Iterator0.<getDownloadSize>c__AnonStorey1 $locvar0;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public GameBundleLoader.<getDownloadSize>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_10;
        System.Collections.IEnumerator val_11;
        int val_10 = this.$PC;
        this.$PC = 0;
        val_10 = ((val_10 == 1) ? 1 : 0) << 2;
        var val_2 = (val_10 == 0) ? 3 : (val_10);
        if(val_2 != 4)
        {
                val_10 = 0;
            if(val_2 != 3)
        {
                return (bool)val_10;
        }
        
            this.$locvar0 = new System.Object();
            typeof(GameBundleLoader.<getDownloadSize>c__Iterator0.<getDownloadSize>c__AnonStorey1).__il2cppRuntimeField_18 = this;
            this.$locvar0.downloadSizeString = 0;
            this.<crt>__0 = 0;
            System.Action<System.String> val_4 = new System.Action<System.String>(object:  this.$locvar0, method:  System.Void GameBundleLoader.<getDownloadSize>c__Iterator0.<getDownloadSize>c__AnonStorey1::<>m__0(string obj));
            val_11 = AssetBundles.AssetBundleManager.GetAssetDownloadSize(assetName:  0, callback:  this.$this.sceneAssetBundle);
            UnityEngine.Coroutine val_6 = this.$this.StartCoroutine(routine:  val_11);
            this.<crt>__0 = val_6;
            this.$current = val_6;
            val_10 = 1;
            if(this.$disposing == true)
        {
                return (bool)val_10;
        }
        
            this.$PC = val_10;
            return (bool)val_10;
        }
        
        this.$this.downloadSize = 0;
        if(this.$locvar0.downloadSizeString != null)
        {
                string val_7 = 0 + "Download size: "("Download size: ");
            UnityEngine.Debug.Log(message:  0);
            val_11 = this.$this;
            bool val_9 = System.Int64.TryParse(s:  0, result: out  this.$locvar0.downloadSizeString);
        }
        
        val_10 = 0;
        this.$PC = 0;
        return (bool)val_10;
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
