using UnityEngine;
private sealed class NativeClient.<UnlockAchievement>c__AnonStoreyC
{
    // Fields
    internal string achId;
    internal GooglePlayGames.Native.NativeClient $this;
    
    // Methods
    public NativeClient.<UnlockAchievement>c__AnonStoreyC()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.Achievement a)
    {
        a.IsUnlocked = true;
        System.Threading.Monitor.Enter(obj:  0);
        System.Threading.Monitor.Exit(obj:  0);
        this.$this.mServices.AchievementManager().Unlock(achievementId:  this.achId);
    }

}
