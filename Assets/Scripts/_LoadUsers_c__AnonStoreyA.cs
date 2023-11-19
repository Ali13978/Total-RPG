using UnityEngine;
private sealed class NativeClient.<LoadUsers>c__AnonStorey9.<LoadUsers>c__AnonStoreyA
{
    // Fields
    internal UnityEngine.SocialPlatforms.IUserProfile[] users;
    internal GooglePlayGames.Native.NativeClient.<LoadUsers>c__AnonStorey9 <>f__ref$9;
    
    // Methods
    public NativeClient.<LoadUsers>c__AnonStorey9.<LoadUsers>c__AnonStoreyA()
    {
    
    }
    internal void <>m__0()
    {
        this.<>f__ref$9.callback.Invoke(obj:  this.users);
    }

}
