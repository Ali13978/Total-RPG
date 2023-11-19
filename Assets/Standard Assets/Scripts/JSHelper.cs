using UnityEngine;
public class JSHelper : MonoBehaviour
{
    // Fields
    private string leaderboardId;
    private string TEST_ACHIEVEMENT_1_ID;
    private string TEST_ACHIEVEMENT_2_ID;
    
    // Methods
    public JSHelper()
    {
        this.leaderboardId = "your.leaderboard1.id.here";
        this.TEST_ACHIEVEMENT_1_ID = "your.achievement.id1.here";
        this.TEST_ACHIEVEMENT_2_ID = "your.achievement.id2.here";
    }
    [System.ObsoleteAttribute]
    private void InitGameCneter()
    {
        this.InitGameCenter();
    }
    public void InitGameCenter()
    {
        GameCenterManager.RegisterAchievement(achievementId:  0);
        GameCenterManager.RegisterAchievement(achievementId:  0);
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void JSHelper::HandleOnAchievementsLoaded(SA.Common.Models.Result res));
        GameCenterManager.add_OnAchievementsLoaded(value:  0);
        System.Action<GK_AchievementProgressResult> val_2 = new System.Action<GK_AchievementProgressResult>(object:  this, method:  System.Void JSHelper::HandleOnAchievementsProgress(GK_AchievementProgressResult progress));
        GameCenterManager.add_OnAchievementsProgress(value:  0);
        System.Action<SA.Common.Models.Result> val_3 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void JSHelper::HandleOnAchievementsReset(SA.Common.Models.Result res));
        GameCenterManager.add_OnAchievementsReset(value:  0);
        System.Action<GK_LeaderboardResult> val_4 = new System.Action<GK_LeaderboardResult>(object:  this, method:  System.Void JSHelper::OnScoreSubmitted(GK_LeaderboardResult result));
        GameCenterManager.add_OnScoreSubmitted(value:  0);
        System.Action<SA.Common.Models.Result> val_5 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void JSHelper::HandleOnAuthFinished(SA.Common.Models.Result r));
        GameCenterManager.add_OnAuthFinished(value:  0);
        UnityEngine.GameObject val_6 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        GameCenterManager.Init();
        ISN_Logger.Log(message:  0, logType:  "InitGameCenter");
    }
    private void SubmitScore(int val)
    {
        ISN_Logger.Log(message:  13591, logType:  "SubmitScore");
        GameCenterManager.ReportScore(score:  0, leaderboardId:  (long)val, context:  this.leaderboardId);
    }
    private void SubmitAchievement(string data)
    {
        if(("|") == null)
        {
                "|" = "|";
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_20 = Chars[0];
        System.String[] val_2 = data.Split(separator:  null);
        string val_5 = val_2[0];
        string val_4 = 0 + "SubmitAchievement: "("SubmitAchievement: ") + val_2[1] + "  ";
        ISN_Logger.Log(message:  val_4, logType:  val_4);
        GameCenterManager.SubmitAchievement(percent:  System.Convert.ToSingle(value:  0), achievementId:  0);
    }
    private void HandleOnAchievementsLoaded(SA.Common.Models.Result res)
    {
        object val_6;
        ISN_Logger.Log(message:  13584, logType:  "Achievements loaded from iOS Game Center");
        List.Enumerator<T> val_2 = GameCenterManager.Achievements.GetEnumerator();
        label_9:
        if((0 & 1) == 0)
        {
            goto label_12;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_3 = 0.InitializationCallback;
        if(val_3 != null)
        {
            
        }
        else
        {
                val_6 = 7254272;
        }
        
        float val_4 = val_3.Progress;
        string val_5 = 0 + val_6 + ":  "(":  ");
        ISN_Logger.Log(message:  val_5, logType:  val_5);
        goto label_9;
        label_12:
        0.Dispose();
        if((0 & 1) != 0)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
    
    }
    private void HandleOnAchievementsProgress(GK_AchievementProgressResult progress)
    {
        string val_4;
        ISN_Logger.Log(message:  13585, logType:  "OnAchievementProgress");
        GK_AchievementTemplate val_1 = progress.Achievement;
        if(val_1 != null)
        {
                val_4 = val_1.Id;
        }
        else
        {
                val_4 = 7254272;
        }
        
        float val_2 = val_1.Progress;
        string val_3 = 0 + val_4 + ":  "(":  ");
        ISN_Logger.Log(message:  val_3, logType:  val_3);
    }
    private void HandleOnAchievementsReset(SA.Common.Models.Result res)
    {
        ISN_Logger.Log(message:  13586, logType:  "All Achievements were reset");
    }
    private void OnScoreSubmitted(GK_LeaderboardResult result)
    {
        if(result.IsSucceeded == false)
        {
                return;
        }
        
        GK_Score val_3 = result.Leaderboard.GetCurrentPlayerScore(timeSpan:  2, collection:  1);
        string val_4 = val_3.LeaderboardId;
        string val_5 = 0 + "Leaderboard ";
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Score: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_3.LongScore;
        typeof(System.Object[]).__il2cppRuntimeField_30 = "\nRank:";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_3.Rank;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_8 = +0;
    }
    private void HandleOnAuthFinished(SA.Common.Models.Result r)
    {
        if(r.IsSucceeded == false)
        {
                return;
        }
        
        string val_5 = GameCenterManager.Player.DisplayName;
        string val_6 = 0 + "ID: "("ID: ") + GameCenterManager.Player.Id + "\nName: "("\nName: ");
    }

}
