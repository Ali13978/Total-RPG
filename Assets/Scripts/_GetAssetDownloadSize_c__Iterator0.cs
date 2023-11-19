using UnityEngine;
private sealed class AssetBundleManager.<GetAssetDownloadSize>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal string assetName;
    internal string <bundleBaseDownloadingURL>__0;
    internal string <url>__0;
    internal UnityEngine.Networking.UnityWebRequest <webRequest>__0;
    internal string <size>__0;
    internal System.Action<string> callback;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public AssetBundleManager.<GetAssetDownloadSize>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_12;
        UnityEngine.Networking.UnityWebRequest val_13;
        string val_14;
        int val_12 = this.$PC;
        this.$PC = 0;
        val_12 = ((val_12 == 1) ? 1 : 0) << 2;
        var val_2 = (val_12 == 0) ? 3 : (val_12);
        if(val_2 != 3)
        {
                val_12 = 0;
            if(val_2 != 4)
        {
                return (bool)val_12;
        }
        
            val_13 = this.<webRequest>__0;
        }
        else
        {
                string val_3 = AssetBundles.AssetBundleManager.GetAssetBundleBaseDownloadingURL(bundleName:  null);
            this.<bundleBaseDownloadingURL>__0 = val_3;
            val_14 = this.<bundleBaseDownloadingURL>__0;
            if((val_3.EndsWith(value:  "/")) != true)
        {
                val_14 = 0 + val_14;
            this.<bundleBaseDownloadingURL>__0 = val_14;
        }
        
            this.<url>__0 = 0 + val_14;
            UnityEngine.Networking.UnityWebRequest val_8 = UnityEngine.Networking.UnityWebRequest.Head(uri:  0);
            val_13 = this.<webRequest>__0;
            this.<webRequest>__0 = val_8;
            UnityEngine.Networking.UnityWebRequestAsyncOperation val_9 = val_8.SendWebRequest();
        }
        
        if((mem[this.<webRequest>__0].isDone) != false)
        {
                string val_11 = mem[this.<webRequest>__0].GetResponseHeader(name:  "Content-Length");
            val_13 = this.callback;
            this.<size>__0 = val_11;
            val_13.Invoke(obj:  val_11);
            val_12 = 0;
            this.$PC = 0;
            return (bool)val_12;
        }
        
        val_12 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_12;
        }
        
        this.$PC = val_12;
        return (bool)val_12;
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
