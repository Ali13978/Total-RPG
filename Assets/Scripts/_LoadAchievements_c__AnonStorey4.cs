using UnityEngine;
private sealed class PlayGamesPlatform.<LoadAchievements>c__AnonStorey4
{
    // Fields
    internal System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback;
    
    // Methods
    public PlayGamesPlatform.<LoadAchievements>c__AnonStorey4()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.Achievement[] ach)
    {
        goto label_2;
        label_11:
        var val_1 = null + ((X26) << 3);
        0 = 1;
        mem2[0] = ach.Length;
        label_2:
        null = new GooglePlayGames.PlayGamesAchievement(ach:  ach[1]);
        if((null == 0) || (null != 0))
        {
            goto label_11;
        }
        
        goto label_11;
    }

}
