using UnityEngine;
private sealed class NativeClient.<LoadUsers>c__AnonStorey9
{
    // Fields
    internal System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback;
    
    // Methods
    public NativeClient.<LoadUsers>c__AnonStorey9()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.NativePlayer[] nativeUsers)
    {
        var val_5;
        object val_1 = new System.Object();
        typeof(NativeClient.<LoadUsers>c__AnonStorey9.<LoadUsers>c__AnonStoreyA).__il2cppRuntimeField_18 = this;
        val_5 = 0;
        typeof(NativeClient.<LoadUsers>c__AnonStorey9.<LoadUsers>c__AnonStoreyA).__il2cppRuntimeField_10 = null;
        goto label_3;
        label_15:
        var val_2 = X23 + ((X24) << 3);
        val_5 = 1;
        mem2[0] = null;
        label_3:
        GooglePlayGames.BasicApi.Multiplayer.Player val_3 = nativeUsers[1].AsPlayer();
        if((val_3 == null) || (val_3 != null))
        {
            goto label_15;
        }
        
        goto label_15;
    }

}
