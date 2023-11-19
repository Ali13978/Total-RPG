using UnityEngine;
private sealed class AndroidTokenClient.<FetchTokens>c__AnonStorey0
{
    // Fields
    internal bool silent;
    internal System.Action<int> callback;
    internal GooglePlayGames.Android.AndroidTokenClient $this;
    
    // Methods
    public AndroidTokenClient.<FetchTokens>c__AnonStorey0()
    {
    
    }
    internal void <>m__0()
    {
        this.$this.DoFetchToken(silent:  (this.silent == true) ? 1 : 0, callback:  this.callback);
    }

}
