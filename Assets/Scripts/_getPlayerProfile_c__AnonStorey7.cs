using UnityEngine;
private sealed class SocialSystem.<getPlayerProfile>c__AnonStorey7
{
    // Fields
    internal System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback;
    
    // Methods
    public SocialSystem.<getPlayerProfile>c__AnonStorey7()
    {
    
    }
    internal void <>m__0(UnityEngine.SocialPlatforms.IUserProfile[] profiles)
    {
        UnityEngine.SocialPlatforms.IUserProfile val_1;
        var val_2;
        var val_3;
        if((profiles != null) && (profiles.Length != 0))
        {
                if(this.callback == null)
        {
                return;
        }
        
            val_1 = profiles[0];
            val_2 = 1;
            val_3 = public System.Void System.Action<System.Boolean, UnityEngine.SocialPlatforms.IUserProfile>::Invoke(System.Boolean arg1, UnityEngine.SocialPlatforms.IUserProfile arg2);
        }
        else
        {
                UnityEngine.Debug.LogError(message:  0);
            if(this.callback == null)
        {
                return;
        }
        
            val_2 = 0;
            val_1 = 0;
            val_3 = public System.Void System.Action<System.Boolean, UnityEngine.SocialPlatforms.IUserProfile>::Invoke(System.Boolean arg1, UnityEngine.SocialPlatforms.IUserProfile arg2);
        }
        
        this.callback.Invoke(arg1:  false, arg2:  val_1);
    }

}
