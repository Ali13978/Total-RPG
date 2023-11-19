using UnityEngine;
private sealed class AndroidTokenClient.<GetAnotherServerAuthCode>c__AnonStorey2
{
    // Fields
    internal System.Action<string> callback;
    internal GooglePlayGames.Android.AndroidTokenClient $this;
    
    // Methods
    public AndroidTokenClient.<GetAnotherServerAuthCode>c__AnonStorey2()
    {
    
    }
    internal void <>m__0(int rc, string authCode, string email, string idToken)
    {
        this.$this.authCode = authCode;
        this.callback.Invoke(obj:  authCode);
    }

}
