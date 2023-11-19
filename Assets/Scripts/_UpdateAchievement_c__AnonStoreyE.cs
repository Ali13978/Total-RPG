using UnityEngine;
private sealed class NativeClient.<UpdateAchievement>c__AnonStoreyE
{
    // Fields
    internal string achId;
    internal System.Action<bool> callback;
    internal GooglePlayGames.Native.NativeClient $this;
    
    // Methods
    public NativeClient.<UpdateAchievement>c__AnonStoreyE()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.AchievementManager.FetchResponse rsp)
    {
        if(rsp.Status() == 1)
        {
                bool val_2 = this.$this.mAchievements.Remove(key:  this.achId);
            this.$this.mAchievements.Add(key:  this.achId, value:  rsp.Achievement().AsAchievement());
            this.callback.Invoke(obj:  true);
            return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Cannot refresh achievement ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = this.achId;
        typeof(System.Object[]).__il2cppRuntimeField_30 = ": ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = rsp.Status();
        string val_6 = +0;
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        this.callback.Invoke(obj:  false);
    }

}
