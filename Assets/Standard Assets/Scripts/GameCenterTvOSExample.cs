using UnityEngine;
public class GameCenterTvOSExample : MonoBehaviour
{
    // Fields
    private int hiScore;
    private bool _IsUILocked;
    private string TEST_LEADERBOARD_1;
    private string TEST_ACHIEVEMENT_1_ID;
    private string TEST_ACHIEVEMENT_2_ID;
    private static System.Action<SA.Common.Models.Result> <>f__am$cache0;
    
    // Methods
    public GameCenterTvOSExample()
    {
        this.hiScore = 200;
        this.TEST_LEADERBOARD_1 = "your.ios.leaderbord1.id";
        this.TEST_ACHIEVEMENT_1_ID = "your.achievement.id1.here";
        this.TEST_ACHIEVEMENT_2_ID = "your.achievement.id2.here";
    }
    private void Start()
    {
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterTvOSExample::OnAuthFinished(SA.Common.Models.Result res));
        GameCenterManager.add_OnAuthFinished(value:  null);
        GameCenterManager.add_OnScoreSubmitted(value:  new System.Action<GK_LeaderboardResult>(object:  this, method:  System.Void GameCenterTvOSExample::OnScoreSubmitted(GK_LeaderboardResult result)) = new System.Action<GK_LeaderboardResult>(object:  this, method:  System.Void GameCenterTvOSExample::OnScoreSubmitted(GK_LeaderboardResult result)));
        GameCenterManager.add_OnAchievementsProgress(value:  new System.Action<GK_AchievementProgressResult>(object:  this, method:  System.Void GameCenterTvOSExample::HandleOnAchievementsProgress(GK_AchievementProgressResult result)) = new System.Action<GK_AchievementProgressResult>(object:  this, method:  System.Void GameCenterTvOSExample::HandleOnAchievementsProgress(GK_AchievementProgressResult result)));
        GameCenterManager.add_OnAchievementsReset(value:  new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterTvOSExample::HandleOnAchievementsReset(SA.Common.Models.Result obj)) = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterTvOSExample::HandleOnAchievementsReset(SA.Common.Models.Result obj)));
        GameCenterManager.add_OnAchievementsLoaded(value:  new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterTvOSExample::OnAchievementsLoaded(SA.Common.Models.Result result)) = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterTvOSExample::OnAchievementsLoaded(SA.Common.Models.Result result)));
        GameCenterManager.RegisterAchievement(achievementId:  new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterTvOSExample::OnAchievementsLoaded(SA.Common.Models.Result result)));
        GameCenterManager.RegisterAchievement(achievementId:  new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterTvOSExample::OnAchievementsLoaded(SA.Common.Models.Result result)));
        GameCenterManager.add_OnGameCenterViewDismissed(value:  new System.Action(object:  this, method:  System.Void GameCenterTvOSExample::GameCenterManager_OnGameCenterViewDismissed()) = new System.Action(object:  this, method:  System.Void GameCenterTvOSExample::GameCenterManager_OnGameCenterViewDismissed()));
        GameCenterManager.Init();
    }
    private void OnAuthFinished(SA.Common.Models.Result res)
    {
        string val_7;
        this._IsUILocked = true;
        if(res.IsSucceeded != false)
        {
                GK_Player val_2 = GameCenterManager.Player;
            GK_Player val_3 = GameCenterManager.Player;
            string val_4 = 0 + "ID: "("ID: ") + val_2._PlayerId + "\nAlias: "("\nAlias: ");
            val_7 = "Player Authed ";
        }
        else
        {
                val_7 = "Game Center ";
        }
        
        IOSMessage.Create(title:  0, message:  val_7).add_OnComplete(value:  new System.Action(object:  this, method:  System.Void GameCenterTvOSExample::<OnAuthFinished>m__0()));
    }
    public void ShowAchivemnets()
    {
        string val_1 = 0 + "ShowAchivemnets ";
        UnityEngine.Debug.Log(message:  0);
        if(this._IsUILocked == true)
        {
                return;
        }
        
        this._IsUILocked = true;
    }
    public void SubmitAchievement()
    {
        UnityEngine.Debug.Log(message:  0);
        float val_1 = GameCenterManager.GetAchievementProgress(id:  null);
        val_1 = val_1 + 2.432f;
        GameCenterManager.SubmitAchievement(percent:  val_1, achievementId:  null);
    }
    public void ResetAchievements()
    {
        UnityEngine.Debug.Log(message:  0);
        GameCenterManager.ResetAchievements();
    }
    public void ShowLeaderboards()
    {
        string val_1 = 0 + "ShowLeaderboards";
        UnityEngine.Debug.Log(message:  0);
        if(this._IsUILocked == true)
        {
                return;
        }
        
        this._IsUILocked = true;
    }
    public void ShowLeaderboardByID()
    {
        System.Action<SA.Common.Models.Result> val_2;
        UnityEngine.Debug.Log(message:  0);
        val_2 = GameCenterTvOSExample.<>f__am$cache0;
        if(val_2 == null)
        {
                GameCenterTvOSExample.<>f__am$cache0 = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void GameCenterTvOSExample::<ShowLeaderboardByID>m__1(SA.Common.Models.Result obj));
            val_2 = GameCenterTvOSExample.<>f__am$cache0;
        }
        
        GameCenterManager.add_OnFriendsListLoaded(value:  null);
    }
    public void ReportScore()
    {
        UnityEngine.Debug.Log(message:  0);
        int val_1 = this.hiScore;
        val_1 = val_1 + 1;
        this.hiScore = val_1;
        GameCenterManager.ReportScore(score:  null, leaderboardId:  "ReportScore", context:  this.TEST_LEADERBOARD_1);
    }
    private void OnScoreSubmitted(GK_LeaderboardResult result)
    {
        GK_LeaderboardResult val_5 = result;
        if(val_5.IsSucceeded == false)
        {
                return;
        }
        
        GK_Score val_2 = result._Leaderboard.GetCurrentPlayerScore(timeSpan:  2, collection:  1);
        val_5 = 0 + "Leaderboard ";
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Score: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_2._Score;
        typeof(System.Object[]).__il2cppRuntimeField_30 = "\nRank:";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_2._Rank;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_4 = +0;
        IOSNativePopUpManager.showMessage(title:  0, message:  val_5);
    }
    private void OnAchievementsLoaded(SA.Common.Models.Result result)
    {
        var val_11;
        object val_12;
        val_11 = result;
        ISN_Logger.Log(message:  0, logType:  "OnAchievementsLoaded");
        if(val_11 != null)
        {
                ISN_Logger.Log(message:  0, logType:  val_11.IsSucceeded);
        }
        else
        {
                ISN_Logger.Log(message:  0, logType:  0.IsSucceeded);
        }
        
        if(val_11.IsSucceeded == false)
        {
                return;
        }
        
        ISN_Logger.Log(message:  0, logType:  "Achievements were loaded from iOS Game Center");
        List.Enumerator<T> val_7 = GameCenterManager.Achievements.GetEnumerator();
        label_12:
        if((0 & 1) == 0)
        {
            goto label_15;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_8 = 0.InitializationCallback;
        if(val_8 != null)
        {
            
        }
        else
        {
                val_12 = 7254272;
        }
        
        float val_9 = val_8.Progress;
        ISN_Logger.Log(message:  0, logType:  0 + val_12 + ":  "(":  "));
        goto label_12;
        label_15:
        0.Dispose();
        if((0 & 1) != 0)
        {
                return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    private void HandleOnAchievementsReset(SA.Common.Models.Result obj)
    {
        ISN_Logger.Log(message:  0, logType:  "All Achievements were reset");
    }
    private void HandleOnAchievementsProgress(GK_AchievementProgressResult result)
    {
        GK_AchievementProgressResult val_4 = result;
        if(val_4.IsSucceeded == false)
        {
                return;
        }
        
        if(result._tpl != null)
        {
                val_4 = result._tpl.Id;
        }
        else
        {
                val_4 = 7254272;
        }
        
        float val_2 = result._tpl.Progress;
        ISN_Logger.Log(message:  0, logType:  0 + val_4 + ":  "(":  "));
    }
    private void GameCenterManager_OnGameCenterViewDismissed()
    {
        UnityEngine.Debug.Log(message:  0);
        this._IsUILocked = false;
    }
    private void <OnAuthFinished>m__0()
    {
        this._IsUILocked = false;
    }
    private static void <ShowLeaderboardByID>m__1(SA.Common.Models.Result obj)
    {
        string val_3 = 0 + "Loaded: "("Loaded: ") + GameCenterManager.FriendsList.Count;
        UnityEngine.Debug.Log(message:  0);
    }

}
