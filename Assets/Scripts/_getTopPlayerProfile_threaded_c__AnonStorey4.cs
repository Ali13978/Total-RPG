using UnityEngine;
private sealed class SocialSystem.<getTopPlayerProfile_threaded>c__AnonStorey4
{
    // Fields
    internal string leaderboardId;
    internal bool friend;
    internal System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback;
    internal TzarGames.Endless.SocialSystem $this;
    
    // Methods
    public SocialSystem.<getTopPlayerProfile_threaded>c__AnonStorey4()
    {
    
    }
    internal void <>m__0()
    {
        this.$this.getTopPlayerProfile(leaderboardId:  this.leaderboardId, friend:  (this.friend == true) ? 1 : 0, callback:  new System.Action<System.Boolean, UnityEngine.SocialPlatforms.IUserProfile>(object:  this, method:  System.Void SocialSystem.<getTopPlayerProfile_threaded>c__AnonStorey4::<>m__1(bool result, UnityEngine.SocialPlatforms.IUserProfile profile)));
    }
    internal void <>m__1(bool result, UnityEngine.SocialPlatforms.IUserProfile profile)
    {
        result = result;
        this.callback.Invoke(arg1:  result, arg2:  profile);
    }

}
