using UnityEngine;
private sealed class AndroidClient.<CreatePlatformConfiguration>c__AnonStorey0
{
    // Fields
    internal IntPtr intentRef;
    
    // Methods
    public AndroidClient.<CreatePlatformConfiguration>c__AnonStorey0()
    {
    
    }
    internal void <>m__0()
    {
        var val_7;
        var val_8;
        val_7 = this;
        GooglePlayGames.Android.AndroidClient.LaunchBridgeIntent(bridgedIntent:  this);
        val_8 = 1;
        UnityEngine.AndroidJNI.DeleteGlobalRef(obj:  0);
        if((val_8 & 1) != 0)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_7 = ???;
        val_8 = ???;
    }

}
