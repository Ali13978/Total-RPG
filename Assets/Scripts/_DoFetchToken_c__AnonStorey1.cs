using UnityEngine;
private sealed class AndroidTokenClient.<DoFetchToken>c__AnonStorey1
{
    // Fields
    internal System.Action<int> callback;
    internal GooglePlayGames.Android.AndroidTokenClient $this;
    
    // Methods
    public AndroidTokenClient.<DoFetchToken>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(int rc, string authCode, string email, string idToken)
    {
        this.$this.authCode = authCode;
        this.$this.email = email;
        this.$this.idToken = idToken;
        this.callback.Invoke(obj:  rc);
    }

}
