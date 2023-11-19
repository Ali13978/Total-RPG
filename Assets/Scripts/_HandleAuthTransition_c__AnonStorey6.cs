using UnityEngine;
private sealed class NativeClient.<HandleAuthTransition>c__AnonStorey6
{
    // Fields
    internal uint currentAuthGeneration;
    internal GooglePlayGames.Native.NativeClient $this;
    
    // Methods
    public NativeClient.<HandleAuthTransition>c__AnonStorey6()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.AchievementManager.FetchAllResponse results)
    {
        this.$this.PopulateAchievements(authGeneration:  this.currentAuthGeneration, response:  results);
    }
    internal void <>m__1(GooglePlayGames.Native.PInvoke.PlayerManager.FetchSelfResponse results)
    {
        this.$this.PopulateUser(authGeneration:  this.currentAuthGeneration, response:  results);
    }

}
