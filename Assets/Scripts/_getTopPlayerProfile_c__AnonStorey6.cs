using UnityEngine;
private sealed class SocialSystem.<getTopPlayerProfile>c__AnonStorey6
{
    // Fields
    internal System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback;
    internal TzarGames.Endless.SocialSystem $this;
    
    // Methods
    public SocialSystem.<getTopPlayerProfile>c__AnonStorey6()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.LeaderboardScoreData result)
    {
        var val_6;
        if(result == null)
        {
            goto label_5;
        }
        
        if(result.Status != 2)
        {
                if(result.Status != 1)
        {
            goto label_5;
        }
        
        }
        
        UnityEngine.SocialPlatforms.IScore[] val_3 = result.Scores;
        if(val_3.Length == 0)
        {
            goto label_5;
        }
        
        UnityEngine.SocialPlatforms.IScore val_6 = result.Scores[0];
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_6 = val_6;
        goto label_12;
        label_5:
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke(arg1:  false, arg2:  0);
        return;
        label_12:
        typeof(System.String[]).__il2cppRuntimeField_20 = val_6;
        val_6.getPlayerProfile(userIds:  null, callback:  this.callback);
    }

}
