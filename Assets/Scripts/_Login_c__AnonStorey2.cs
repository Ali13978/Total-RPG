using UnityEngine;
private sealed class FacebookPlatform.<Login>c__AnonStorey2
{
    // Fields
    internal System.Action<bool> callback;
    
    // Methods
    public FacebookPlatform.<Login>c__AnonStorey2()
    {
    
    }
    internal void <>m__0(Facebook.Unity.ILoginResult result)
    {
        var val_5;
        var val_6;
        if(Facebook.Unity.FB.IsLoggedIn != false)
        {
                UnityEngine.Debug.Log(message:  0);
            if(this.callback != null)
        {
                this.callback.Invoke(obj:  true);
        }
        
            val_5 = null;
            val_5 = null;
            TzarGames.Endless.FacebookPlatform.userIdKey = Facebook.Unity.AccessToken.CurrentAccessToken.UserId;
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  "1j3kf84kmg89vmd84mg9bmfo9ejgjeofj");
            return;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_6 = result;
        typeof(System.Object[]).__il2cppRuntimeField_20 = result;
        UnityEngine.Debug.LogFormat(format:  0, args:  "Facebool login error {0}");
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke(obj:  false);
    }

}
