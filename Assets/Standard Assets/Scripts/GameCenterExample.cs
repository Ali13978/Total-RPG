using UnityEngine;
public class GameCenterExample : BaseIOSFeaturePreview
{
    // Fields
    private int hiScore;
    private string TEST_LEADERBOARD_1;
    private string TEST_LEADERBOARD_2;
    private string TEST_ACHIEVEMENT_1_ID;
    private string TEST_ACHIEVEMENT_2_ID;
    private static bool IsInitialized;
    private static long LB2BestScores;
    
    // Methods
    public GameCenterExample()
    {
        this.hiScore = 200;
        this.TEST_LEADERBOARD_1 = "your.ios.leaderbord1.id";
        this.TEST_LEADERBOARD_2 = "combined.board.1";
        this.TEST_ACHIEVEMENT_1_ID = "your.achievement.id1.here";
        this.TEST_ACHIEVEMENT_2_ID = "your.achievement.id2.here";
    }
    private void Awake()
    {
        var val_7;
        var val_8;
        val_7 = null;
        val_7 = null;
        if(GameCenterExample.IsInitialized == true)
        {
                return;
        }
        
        GameCenterManager.RegisterAchievement(achievementId:  null);
        GameCenterManager.RegisterAchievement(achievementId:  null);
        GameCenterManager.add_OnAchievementsProgress(value:  new System.Action<GK_AchievementProgressResult>(object:  this, method:  System.Void GameCenterExample::HandleOnAchievementsProgress(GK_AchievementProgressResult result)) = new System.Action<GK_AchievementProgressResult>(object:  this, method:  System.Void GameCenterExample::HandleOnAchievementsProgress(GK_AchievementProgressResult result)));
        GameCenterManager.add_OnAchievementsReset(value:  new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterExample::HandleOnAchievementsReset(SA.Common.Models.Result obj)) = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterExample::HandleOnAchievementsReset(SA.Common.Models.Result obj)));
        GameCenterManager.add_OnAchievementsLoaded(value:  new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterExample::OnAchievementsLoaded(SA.Common.Models.Result result)) = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterExample::OnAchievementsLoaded(SA.Common.Models.Result result)));
        GameCenterManager.add_OnScoreSubmitted(value:  new System.Action<GK_LeaderboardResult>(object:  this, method:  System.Void GameCenterExample::OnScoreSubmitted(GK_LeaderboardResult result)) = new System.Action<GK_LeaderboardResult>(object:  this, method:  System.Void GameCenterExample::OnScoreSubmitted(GK_LeaderboardResult result)));
        GameCenterManager.add_OnLeadrboardInfoLoaded(value:  new System.Action<GK_LeaderboardResult>(object:  this, method:  System.Void GameCenterExample::OnLeadrboardInfoLoaded(GK_LeaderboardResult result)) = new System.Action<GK_LeaderboardResult>(object:  this, method:  System.Void GameCenterExample::OnLeadrboardInfoLoaded(GK_LeaderboardResult result)));
        GameCenterManager.add_OnAuthFinished(value:  new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterExample::OnAuthFinished(SA.Common.Models.Result res)) = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterExample::OnAuthFinished(SA.Common.Models.Result res)));
        GameCenterManager.Init();
        val_8 = null;
        val_8 = null;
        GameCenterExample.IsInitialized = true;
    }
    private void OnGUI()
    {
        var val_43;
        this.UpdateToStartPos();
        if(GameCenterManager.Player != null)
        {
                int val_2 = UnityEngine.Screen.width;
            GK_Player val_3 = GameCenterManager.Player;
            string val_4 = 0 + "ID: "("ID: ");
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
            int val_5 = UnityEngine.Screen.width;
            GK_Player val_6 = GameCenterManager.Player;
            string val_7 = 0 + "Name: "("Name: ");
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
            int val_8 = UnityEngine.Screen.width;
            GK_Player val_9 = GameCenterManager.Player;
            string val_10 = 0 + "Alias: "("Alias: ");
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
            GK_Player val_11 = GameCenterManager.Player;
            if(0 != val_11._SmallPhoto)
        {
                GK_Player val_13 = GameCenterManager.Player;
            float val_43 = 0f;
            UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_43, m_Width = 0f, m_Height = 0f}, image:  0);
        }
        
        }
        
        val_43 = val_43 + 0f;
        val_43 = 0f + val_43;
        mem[1152921510365424168] = 0f + val_43;
        int val_15 = UnityEngine.Screen.width;
        float val_44 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_44, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Game Center Leaderboards");
        val_44 = val_44 + 0f;
        mem[1152921510365424168] = val_44;
        float val_45 = 0f;
        bool val_16 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_45, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        val_45 = 0f + val_45;
        mem[1152921510365424172] = val_45;
        float val_46 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_46, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                System.Action<SA.Common.Models.Result> val_18 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterExample::OnLeaderboardSetsInfoLoaded(SA.Common.Models.Result res));
            GameCenterManager.add_OnLeaderboardSetsInfoLoaded(value:  null);
        }
        
        val_46 = 0f + val_46;
        mem[1152921510365424172] = GameCenterManager.__il2cppRuntimeField_cctor_finished;
        mem[1152921510365424168] = val_46;
        float val_47 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_47, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                GameCenterManager.ShowLeaderboard(leaderboardId:  null);
        }
        
        val_47 = 0f + val_47;
        mem[1152921510365424172] = val_47;
        float val_49 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_49, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                int val_48 = this.hiScore;
            val_48 = val_48 + 1;
            this.hiScore = val_48;
            GameCenterManager.ReportScore(score:  null, leaderboardId:  "Report Score LB 1", context:  this.TEST_LEADERBOARD_1);
        }
        
        val_49 = 0f + val_49;
        mem[1152921510365424172] = val_49;
        float val_50 = 0f;
        bool val_21 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_50, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        mem[1152921510365424172] = GameCenterManager.__il2cppRuntimeField_cctor_finished;
        val_50 = val_50 + 0f;
        mem[1152921510365424168] = val_50 + 0f;
        int val_23 = UnityEngine.Screen.width;
        float val_51 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_51, m_Width = 0f, m_Height = 0f}, text:  0, style:  0 + "Leaderboard #2, user best score: "("Leaderboard #2, user best score: "));
        val_51 = val_51 + 0f;
        mem[1152921510365424168] = val_51;
        float val_52 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_52, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                GameCenterManager.ShowLeaderboard(leaderboardId:  null);
        }
        
        val_52 = 0f + val_52;
        mem[1152921510365424172] = val_52;
        float val_53 = 0f;
        bool val_26 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_53, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        val_53 = 0f + val_53;
        mem[1152921510365424172] = val_53;
        float val_55 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_55, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                int val_54 = this.hiScore;
            val_54 = val_54 + 1;
            this.hiScore = val_54;
            System.Action<GK_LeaderboardResult> val_28 = new System.Action<GK_LeaderboardResult>(object:  this, method:  System.Void GameCenterExample::OnScoreSubmitted(GK_LeaderboardResult result));
            GameCenterManager.add_OnScoreSubmitted(value:  null);
            GameCenterManager.ReportScore(score:  val_55, leaderboardId:  null);
        }
        
        val_55 = 0f + val_55;
        mem[1152921510365424172] = val_55;
        float val_56 = 0f;
        bool val_29 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_56, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        val_56 = 0f + val_56;
        mem[1152921510365424172] = val_56;
        float val_57 = 0f;
        val_43 = "Send Challenge";
        bool val_30 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_57, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        mem[1152921510365424172] = GameCenterManager.__il2cppRuntimeField_cctor_finished;
        val_57 = val_57 + 0f;
        mem[1152921510365424168] = val_57 + 0f;
        int val_32 = UnityEngine.Screen.width;
        float val_58 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_58, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Game Center Achievements");
        val_58 = val_58 + 0f;
        mem[1152921510365424168] = val_58;
        float val_59 = 0f;
        bool val_33 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_59, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        val_59 = 0f + val_59;
        mem[1152921510365424172] = val_59;
        float val_60 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_60, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                GameCenterManager.ResetAchievements();
        }
        
        val_60 = 0f + val_60;
        mem[1152921510365424172] = val_60;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                float val_36 = GameCenterManager.GetAchievementProgress(id:  null);
            val_36 = val_36 + 2.432f;
            GameCenterManager.SubmitAchievement(percent:  val_36, achievementId:  null);
        }
        
        val_36 = 0f + val_36;
        mem[1152921510365424172] = val_36;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                float val_61 = 88.66f;
            GameCenterManager.SubmitAchievement(percent:  val_61, achievementId:  null, isCompleteNotification:  this.TEST_ACHIEVEMENT_2_ID);
        }
        
        val_61 = 0f + val_61;
        mem[1152921510365424172] = val_61;
        float val_62 = 0f;
        bool val_38 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_62, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        mem[1152921510365424172] = GameCenterManager.__il2cppRuntimeField_cctor_finished;
        val_62 = val_62 + 0f;
        mem[1152921510365424168] = val_62 + 0f;
        int val_40 = UnityEngine.Screen.width;
        float val_63 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_63, m_Width = 0f, m_Height = 0f}, text:  0, style:  "More");
        val_63 = val_63 + 0f;
        mem[1152921510365424168] = val_63;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        System.Action<GK_PlayerSignatureResult> val_42 = null;
        val_43 = val_42;
        val_42 = new System.Action<GK_PlayerSignatureResult>(object:  this, method:  System.Void GameCenterExample::OnPlayerSignatureRetrieveResult(GK_PlayerSignatureResult result));
        GameCenterManager.add_OnPlayerSignatureRetrieveResult(value:  val_42);
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
    private void OnLeaderboardSetsInfoLoaded(SA.Common.Models.Result res)
    {
        System.Action<ISN_LoadSetLeaderboardsInfoResult> val_11;
        var val_12;
        ISN_Logger.Log(message:  0, logType:  "OnLeaderboardSetsInfoLoaded");
        System.Action<SA.Common.Models.Result> val_1 = null;
        val_11 = val_1;
        val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterExample::OnLeaderboardSetsInfoLoaded(SA.Common.Models.Result res));
        GameCenterManager.remove_OnLeaderboardSetsInfoLoaded(value:  null);
        if(res.IsSucceeded == false)
        {
            goto label_13;
        }
        
        List.Enumerator<T> val_4 = GameCenterManager.LeaderboardSets.GetEnumerator();
        label_10:
        if((0 & 1) == 0)
        {
            goto label_8;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_5 = 0.InitializationCallback;
        ISN_Logger.Log(message:  0, logType:  public GK_LeaderboardSet List.Enumerator<GK_LeaderboardSet>::get_Current());
        ISN_Logger.Log(message:  0, logType:  public GK_LeaderboardSet List.Enumerator<GK_LeaderboardSet>::get_Current());
        ISN_Logger.Log(message:  0, logType:  public GK_LeaderboardSet List.Enumerator<GK_LeaderboardSet>::get_Current());
        goto label_10;
        label_8:
        val_12 = 0;
        val_11 = 1;
        0.Dispose();
        label_13:
        if(GameCenterManager.LeaderboardSets.Count == 0)
        {
                return;
        }
        
        GK_LeaderboardSet val_9 = GameCenterManager.LeaderboardSets.Item[0];
        System.Action<ISN_LoadSetLeaderboardsInfoResult> val_10 = null;
        val_11 = val_10;
        val_10 = new System.Action<ISN_LoadSetLeaderboardsInfoResult>(object:  this, method:  System.Void GameCenterExample::OnLoaderboardsInfoLoaded(ISN_LoadSetLeaderboardsInfoResult res));
        if(val_9 != null)
        {
                val_9.add_OnLoaderboardsInfoLoaded(value:  val_11);
        }
        else
        {
                val_9.add_OnLoaderboardsInfoLoaded(value:  val_11);
        }
        
        val_9.LoadLeaderBoardsInfo();
    }
    private void OnLoaderboardsInfoLoaded(ISN_LoadSetLeaderboardsInfoResult res)
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = res;
        val_8 = val_7.LeaderBoardsSet;
        val_8.remove_OnLoaderboardsInfoLoaded(value:  new System.Action<ISN_LoadSetLeaderboardsInfoResult>(object:  this, method:  System.Void GameCenterExample::OnLoaderboardsInfoLoaded(ISN_LoadSetLeaderboardsInfoResult res)));
        if(val_7.IsSucceeded == false)
        {
                return;
        }
        
        GK_LeaderboardSet val_4 = val_7.LeaderBoardsSet;
        List.Enumerator<T> val_5 = val_4._BoardsInfo.GetEnumerator();
        val_8 = 1152921510365954720;
        label_10:
        if((0 & 1) == 0)
        {
            goto label_8;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_6 = 0.InitializationCallback;
        ISN_Logger.Log(message:  0, logType:  public GK_LeaderBoardInfo List.Enumerator<GK_LeaderBoardInfo>::get_Current());
        ISN_Logger.Log(message:  0, logType:  public GK_LeaderBoardInfo List.Enumerator<GK_LeaderBoardInfo>::get_Current());
        ISN_Logger.Log(message:  0, logType:  public GK_LeaderBoardInfo List.Enumerator<GK_LeaderBoardInfo>::get_Current());
        goto label_10;
        label_8:
        val_7 = 0;
        val_9 = 1;
        0.Dispose();
        if((val_9 & 1) != 0)
        {
                return;
        }
        
        if(val_7 == 0)
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
    private void OnLeadrboardInfoLoaded(GK_LeaderboardResult result)
    {
        string val_8;
        string val_9;
        var val_10;
        val_9 = this;
        if(result.IsSucceeded == false)
        {
                return;
        }
        
        GK_Score val_2 = result._Leaderboard.GetCurrentPlayerScore(timeSpan:  2, collection:  1);
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Score: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_2._Score;
        typeof(System.Object[]).__il2cppRuntimeField_30 = "\nRank:";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_2._Rank;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_4 = +0;
        IOSNativePopUpManager.showMessage(title:  0, message:  0 + "Leaderboard ");
        float val_8 = 100f;
        val_8 = (float)val_2._Score / val_8;
        ISN_Logger.Log(message:  0, logType:  0 + "double score representation: "("double score representation: "));
        ISN_Logger.Log(message:  0, logType:  0 + "long score representation: "("long score representation: "));
        val_8 = val_2._LeaderboardId;
        val_9 = this.TEST_LEADERBOARD_2;
        if((val_8.Equals(value:  val_9)) == false)
        {
                return;
        }
        
        ISN_Logger.Log(message:  0, logType:  "Updating leaderboard 2 score");
        val_8 = 1152921504849657856;
        val_9 = val_2._Score;
        val_10 = null;
        val_10 = null;
        GameCenterExample.LB2BestScores = val_9;
    }
    private void OnScoreSubmitted(SA.Common.Models.Result result)
    {
        UnityEngine.LogType val_3;
        object val_4;
        System.Action<GK_LeaderboardResult> val_1 = new System.Action<GK_LeaderboardResult>(object:  this, method:  System.Void GameCenterExample::OnScoreSubmitted(GK_LeaderboardResult result));
        GameCenterManager.remove_OnScoreSubmitted(value:  null);
        if(result.IsSucceeded != false)
        {
                val_3 = "Score Submitted";
            val_4 = 0;
        }
        else
        {
                val_3 = "Score Submit Failed";
            val_4 = 0;
        }
        
        ISN_Logger.Log(message:  val_4, logType:  val_3);
    }
    private void OnAuthFinished(SA.Common.Models.Result res)
    {
        string val_5;
        string val_6;
        string val_7;
        val_5 = res;
        if(val_5.IsSucceeded != false)
        {
                GK_Player val_2 = GameCenterManager.Player;
            val_5 = val_2._PlayerId;
            GK_Player val_3 = GameCenterManager.Player;
            string val_4 = 0 + "ID: "("ID: ") + val_5 + "\nAlias: "("\nAlias: ");
            val_6 = 0;
            val_7 = "Player Authed ";
        }
        else
        {
                val_6 = 0;
            val_7 = "Game Center ";
        }
        
        IOSNativePopUpManager.showMessage(title:  val_6, message:  val_7);
    }
    private void OnPlayerSignatureRetrieveResult(GK_PlayerSignatureResult result)
    {
        var val_15;
        ISN_Logger.Log(message:  0, logType:  "OnPlayerSignatureRetrieveResult");
        if(result == null)
        {
            goto label_1;
        }
        
        val_15 = result;
        if(result.IsSucceeded == true)
        {
            goto label_2;
        }
        
        goto label_4;
        label_1:
        val_15 = 0;
        if(0.IsSucceeded == false)
        {
            goto label_4;
        }
        
        label_2:
        ISN_Logger.Log(message:  0, logType:  0 + "PublicKeyUrl: "("PublicKeyUrl: "));
        ISN_Logger.Log(message:  0, logType:  0 + "Signature: "("Signature: "));
        ISN_Logger.Log(message:  0, logType:  0 + "Salt: "("Salt: "));
        string val_7 = 0 + "Timestamp: "("Timestamp: ");
        goto label_7;
        label_4:
        int val_9 = val_15.Error.Code;
        ISN_Logger.Log(message:  0, logType:  0 + "Error code: "("Error code: "));
        string val_12 = val_15.Error.Message;
        label_7:
        ISN_Logger.Log(message:  0, logType:  0 + "Error description: "("Error description: "));
        System.Action<GK_PlayerSignatureResult> val_14 = new System.Action<GK_PlayerSignatureResult>(object:  this, method:  System.Void GameCenterExample::OnPlayerSignatureRetrieveResult(GK_PlayerSignatureResult result));
        GameCenterManager.remove_OnPlayerSignatureRetrieveResult(value:  null);
    }
    private static GameCenterExample()
    {
    
    }

}
