using UnityEngine;
private sealed class SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5
{
    // Fields
    internal string leaderboardId;
    internal bool friend;
    internal bool waiting;
    internal bool lastResult;
    internal UnityEngine.SocialPlatforms.IUserProfile lastProfile;
    internal TzarGames.Endless.SocialSystem.<getTopPlayerRoutine>c__Iterator2 <>f__ref$2;
    
    // Methods
    public SocialSystem.<getTopPlayerRoutine>c__Iterator2.<getTopPlayerRoutine>c__AnonStorey5()
    {
    
    }
    internal void <>m__0(bool result, UnityEngine.SocialPlatforms.IUserProfile profile)
    {
        if((this.<>f__ref$2.$this.LogDebugInfo) != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = "get top player profile completed: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.leaderboardId;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " friend: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.friend;
            typeof(System.Object[]).__il2cppRuntimeField_39 = 24388584;
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        
        this.waiting = false;
        this.lastResult = result;
        this.lastProfile = profile;
    }

}
