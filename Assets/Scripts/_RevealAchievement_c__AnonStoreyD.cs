using UnityEngine;
private sealed class NativeClient.<RevealAchievement>c__AnonStoreyD
{
    // Fields
    internal string achId;
    internal GooglePlayGames.Native.NativeClient $this;
    
    // Methods
    public NativeClient.<RevealAchievement>c__AnonStoreyD()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.Achievement a)
    {
        a.IsRevealed = true;
        System.Threading.Monitor.Enter(obj:  0);
        System.Threading.Monitor.Exit(obj:  0);
        this.$this.mServices.AchievementManager().Reveal(achievementId:  this.achId);
    }

}
