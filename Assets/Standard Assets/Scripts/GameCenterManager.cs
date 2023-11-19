using UnityEngine;
public class GameCenterManager : MonoBehaviour
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnAuthFinished;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_LeaderboardResult> OnScoreSubmitted;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_LeaderboardResult> OnScoresListLoaded;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_LeaderboardResult> OnLeadrboardInfoLoaded;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnLeaderboardSetsInfoLoaded;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnAchievementsReset;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnAchievementsLoaded;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_AchievementProgressResult> OnAchievementsProgress;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action OnGameCenterViewDismissed;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnFriendsListLoaded;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_UserInfoLoadResult> OnUserInfoLoaded;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_PlayerSignatureResult> OnPlayerSignatureRetrieveResult;
    private static bool _IsInitialized;
    private static bool _IsAchievementsInfoLoaded;
    private static System.Collections.Generic.Dictionary<string, GK_Player> _players;
    private static System.Collections.Generic.List<string> _friendsList;
    private static System.Collections.Generic.List<GK_LeaderboardSet> _LeaderboardSets;
    private static System.Collections.Generic.Dictionary<int, GK_FriendRequest> _FriendRequests;
    private static GK_Player _player;
    private const string ISN_GC_PP_KEY = "ISN_GameCenterManager";
    
    // Properties
    public static System.Collections.Generic.List<GK_AchievementTemplate> Achievements { get; }
    public static System.Collections.Generic.List<GK_Leaderboard> Leaderboards { get; }
    public static System.Collections.Generic.Dictionary<string, GK_Player> Players { get; }
    public static GK_Player Player { get; }
    public static bool IsInitialized { get; }
    public static System.Collections.Generic.List<GK_LeaderboardSet> LeaderboardSets { get; }
    public static bool IsPlayerAuthenticated { get; }
    public static bool IsAchievementsInfoLoaded { get; }
    public static System.Collections.Generic.List<string> FriendsList { get; }
    public static bool IsPlayerUnderage { get; }
    
    // Methods
    public GameCenterManager()
    {
    
    }
    public static void add_OnAuthFinished(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        string val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.ISN_GC_PP_KEY;
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  null);
        val_5 = 0;
        if(val_1 == null)
        {
                return;
        }
        
        val_5 = val_1;
        if(null == null)
        {
                return;
        }
        
        val_5 = 0;
    }
    public static void remove_OnAuthFinished(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        string val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.ISN_GC_PP_KEY;
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  null);
        val_5 = 0;
        if(val_1 == null)
        {
                return;
        }
        
        val_5 = val_1;
        if(null == null)
        {
                return;
        }
        
        val_5 = 0;
    }
    public static void add_OnScoreSubmitted(System.Action<GK_LeaderboardResult> value)
    {
        var val_3;
        System.Action<GK_LeaderboardResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnScoreSubmitted;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089032 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnScoreSubmitted(System.Action<GK_LeaderboardResult> value)
    {
        var val_3;
        System.Action<GK_LeaderboardResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnScoreSubmitted;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089032 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnScoresListLoaded(System.Action<GK_LeaderboardResult> value)
    {
        var val_3;
        System.Action<GK_LeaderboardResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnScoresListLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089040 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnScoresListLoaded(System.Action<GK_LeaderboardResult> value)
    {
        var val_3;
        System.Action<GK_LeaderboardResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnScoresListLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089040 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnLeadrboardInfoLoaded(System.Action<GK_LeaderboardResult> value)
    {
        var val_3;
        System.Action<GK_LeaderboardResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnLeadrboardInfoLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089048 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnLeadrboardInfoLoaded(System.Action<GK_LeaderboardResult> value)
    {
        var val_3;
        System.Action<GK_LeaderboardResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnLeadrboardInfoLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089048 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnLeaderboardSetsInfoLoaded(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnLeaderboardSetsInfoLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089056 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnLeaderboardSetsInfoLoaded(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnLeaderboardSetsInfoLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089056 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnAchievementsReset(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnAchievementsReset;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089064 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnAchievementsReset(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnAchievementsReset;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089064 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnAchievementsLoaded(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnAchievementsLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089072 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnAchievementsLoaded(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnAchievementsLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089072 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnAchievementsProgress(System.Action<GK_AchievementProgressResult> value)
    {
        var val_3;
        System.Action<GK_AchievementProgressResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnAchievementsProgress;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089080 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnAchievementsProgress(System.Action<GK_AchievementProgressResult> value)
    {
        var val_3;
        System.Action<GK_AchievementProgressResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnAchievementsProgress;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089080 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnGameCenterViewDismissed(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnGameCenterViewDismissed;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089088 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnGameCenterViewDismissed(System.Action value)
    {
        var val_3;
        System.Action val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnGameCenterViewDismissed;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089088 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnFriendsListLoaded(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnFriendsListLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089096 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnFriendsListLoaded(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnFriendsListLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089096 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnUserInfoLoaded(System.Action<GK_UserInfoLoadResult> value)
    {
        var val_3;
        System.Action<GK_UserInfoLoadResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnUserInfoLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089104 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnUserInfoLoaded(System.Action<GK_UserInfoLoadResult> value)
    {
        var val_3;
        System.Action<GK_UserInfoLoadResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnUserInfoLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089104 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnPlayerSignatureRetrieveResult(System.Action<GK_PlayerSignatureResult> value)
    {
        var val_3;
        System.Action<GK_PlayerSignatureResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnPlayerSignatureRetrieveResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089112 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnPlayerSignatureRetrieveResult(System.Action<GK_PlayerSignatureResult> value)
    {
        var val_3;
        System.Action<GK_PlayerSignatureResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterManager.OnPlayerSignatureRetrieveResult;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841089112 != val_4)
        {
            goto label_8;
        }
    
    }
    [System.ObsoleteAttribute]
    public static void init()
    {
        GameCenterManager.Init();
    }
    public static void Init()
    {
        var val_7;
        var val_8;
        var val_10;
        val_7 = 1152921504841084928;
        val_8 = null;
        val_8 = null;
        if(GameCenterManager._IsInitialized == true)
        {
                return;
        }
        
        GameCenterManager._IsInitialized = true;
        SA_EditorAd val_1 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance;
        UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "GameCenterManager");
        GameCenterManager val_3 = AddComponent<GameCenterManager>();
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        List.Enumerator<T> val_5 = GameCenterManager.Leaderboards.GetEnumerator();
        label_15:
        if((0 & 1) == 0)
        {
            goto label_13;
        }
        
        0.InitializationCallback.Refresh();
        goto label_15;
        label_13:
        val_7 = 0;
        val_10 = 1;
        0.Dispose();
        if((val_10 & 1) != 0)
        {
                return;
        }
        
        if(val_7 == 0)
        {
                return;
        }
    
    }
    public static void RetrievePlayerSignature()
    {
    
    }
    public static void ShowGmaeKitNotification(string title, string message)
    {
    
    }
    public static void RegisterAchievement(string achievementId)
    {
        GK_AchievementTemplate val_1 = new GK_AchievementTemplate();
        typeof(GK_AchievementTemplate).__il2cppRuntimeField_18 = X1;
        GameCenterManager.RegisterAchievement(achievement:  null);
    }
    public static void RegisterAchievement(GK_AchievementTemplate achievement)
    {
        var val_4;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        List.Enumerator<T> val_2 = GameCenterManager.Achievements.GetEnumerator();
        label_8:
        if((0 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X21.Equals(value:  X1 + 24)) == false)
        {
            goto label_8;
        }
        
        val_14 = GameCenterManager.Achievements.IndexOf(item:  val_4.InitializationCallback);
        val_15 = 0;
        val_16 = 1;
        val_17 = 1;
        goto label_13;
        label_4:
        val_15 = 0;
        val_14 = 0;
        val_17 = 0;
        val_16 = 1;
        label_13:
        val_4.Dispose();
        if(val_17 != 0)
        {
                val_15 = GameCenterManager.Achievements;
            val_15.set_Item(index:  0, value:  X1);
            return;
        }
        
        GameCenterManager.Achievements.Add(item:  X1);
    }
    public static void ShowLeaderboard(string leaderboardId)
    {
    
    }
    public static void ShowLeaderboard(string leaderboardId, GK_TimeSpan timeSpan)
    {
    
    }
    public static void ShowLeaderboards()
    {
    
    }
    public static void ReportScore(long score, string leaderboardId, long context = 0)
    {
        IOSNativeSettings val_1 = IOSNativeSettings.Instance;
        if(val_1.DisablePluginLogs != false)
        {
                return;
        }
        
        ISN_Logger.Log(message:  0, logType:  0 + "unity reportScore: "("unity reportScore: "));
    }
    public static void ReportScore(double score, string leaderboardId)
    {
        IOSNativeSettings val_1 = IOSNativeSettings.Instance;
        if(val_1.DisablePluginLogs != false)
        {
                return;
        }
        
        ISN_Logger.Log(message:  0, logType:  0 + "unity reportScore double: "("unity reportScore double: "));
    }
    public static void RetrieveFriends()
    {
    
    }
    [System.ObsoleteAttribute]
    public static void LoadUsersData(string[] UIDs)
    {
    
    }
    public static void LoadGKPlayerInfo(string playerId)
    {
    
    }
    public static void LoadGKPlayerPhoto(string playerId, GK_PhotoSize size)
    {
    
    }
    [System.ObsoleteAttribute]
    public static void LoadCurrentPlayerScore(string leaderboardId, GK_TimeSpan timeSpan = 2, GK_CollectionType collection = 1)
    {
    
    }
    public static void LoadLeaderboardInfo(string leaderboardId)
    {
    
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator LoadLeaderboardInfoLocal(string leaderboardId)
    {
        return (System.Collections.IEnumerator)new System.Object();
    }
    public static void LoadScore(string leaderboardId, int startIndex, int length, GK_TimeSpan timeSpan = 2, GK_CollectionType collection = 1)
    {
    
    }
    public static void IssueLeaderboardChallenge(string leaderboardId, string message, string playerId)
    {
    
    }
    public static void IssueLeaderboardChallenge(string leaderboardId, string message, string[] playerIds)
    {
    
    }
    public static void IssueLeaderboardChallenge(string leaderboardId, string message)
    {
    
    }
    public static void IssueAchievementChallenge(string achievementId, string message, string playerId)
    {
    
    }
    public static void LoadLeaderboardSetInfo()
    {
    
    }
    public static void LoadLeaderboardsForSet(string setId)
    {
    
    }
    public static void LoadAchievements()
    {
    
    }
    public static void IssueAchievementChallenge(string achievementId, string message, string[] playerIds)
    {
    
    }
    public static void IssueAchievementChallenge(string achievementId, string message)
    {
    
    }
    public static void ShowAchievements()
    {
    
    }
    public static void ResetAchievements()
    {
        IOSNativeSettings val_1 = IOSNativeSettings.Instance;
        if(val_1.UsePPForAchievements == false)
        {
                return;
        }
        
        GameCenterManager.ResetStoredProgress();
    }
    public static void SubmitAchievement(float percent, string achievementId)
    {
        GameCenterManager.SubmitAchievement(percent:  percent, achievementId:  null, isCompleteNotification:  X1);
    }
    public static void SubmitAchievementNoCache(float percent, string achievementId)
    {
    
    }
    public static void SubmitAchievement(float percent, string achievementId, bool isCompleteNotification)
    {
        if(UnityEngine.Application.internetReachability == 0)
        {
                ISN_CacheManager.SaveAchievementRequest(achievementId:  0, percent:  percent);
        }
        
        IOSNativeSettings val_2 = IOSNativeSettings.Instance;
        if(val_2.UsePPForAchievements == false)
        {
                return;
        }
        
        GameCenterManager.SaveAchievementProgress(achievementId:  null, progress:  percent);
    }
    public static float GetAchievementProgress(string id)
    {
        IOSNativeSettings val_1 = IOSNativeSettings.Instance;
        if(val_1.UsePPForAchievements != false)
        {
                return GameCenterManager.GetStoredAchievementProgress(achievementId:  null);
        }
        
        GK_AchievementTemplate val_4 = GameCenterManager.GetAchievement(achievementId:  null);
        if(val_4 != null)
        {
                return val_4.Progress;
        }
        
        return val_4.Progress;
    }
    public static GK_AchievementTemplate GetAchievement(string achievementId)
    {
        string val_7;
        GK_AchievementTemplate val_8;
        val_7 = X1;
        List.Enumerator<T> val_2 = GameCenterManager.Achievements.GetEnumerator();
        label_7:
        if((0 & 1) == 0)
        {
            goto label_4;
        }
        
        val_8 = 0.InitializationCallback;
        if((X21.Equals(value:  val_7)) == false)
        {
            goto label_7;
        }
        
        0.Dispose();
        return val_8;
        label_4:
        0.Dispose();
        GK_AchievementTemplate val_5 = null;
        val_8 = val_5;
        val_5 = new GK_AchievementTemplate();
        typeof(GK_AchievementTemplate).__il2cppRuntimeField_18 = val_7;
        val_7 = GameCenterManager.Achievements;
        val_7.Add(item:  val_8);
        return val_8;
    }
    public static GK_Leaderboard GetLeaderboard(string id)
    {
        string val_7;
        GK_Leaderboard val_8;
        val_7 = X1;
        List.Enumerator<T> val_2 = GameCenterManager.Leaderboards.GetEnumerator();
        label_8:
        if((0 & 1) == 0)
        {
            goto label_4;
        }
        
        val_8 = 0.InitializationCallback;
        if((X21 + 32.Equals(value:  val_7)) == false)
        {
            goto label_8;
        }
        
        0.Dispose();
        return val_8;
        label_4:
        0.Dispose();
        GK_Leaderboard val_5 = null;
        val_8 = val_5;
        val_5 = new GK_Leaderboard(leaderboardId:  val_7);
        val_7 = GameCenterManager.Leaderboards;
        val_7.Add(item:  val_8);
        return val_8;
    }
    public static GK_Player GetPlayerById(string playerID)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if((GameCenterManager._players.ContainsKey(key:  X1)) != false)
        {
                val_4 = null;
            val_4 = null;
            GK_Player val_2 = GameCenterManager._players.Item[X1];
            return (GK_Player)val_5;
        }
        
        val_5 = 0;
        return (GK_Player)val_5;
    }
    public static void SendFriendRequest(GK_FriendRequest request, System.Collections.Generic.List<string> emails, System.Collections.Generic.List<string> players)
    {
        null = null;
        GameCenterManager._FriendRequests.Add(key:  W21, value:  emails);
    }
    public static System.Collections.Generic.List<GK_AchievementTemplate> get_Achievements()
    {
        if(IOSNativeSettings.Instance != null)
        {
                return (System.Collections.Generic.List<GK_AchievementTemplate>)val_1.Achievements;
        }
        
        return (System.Collections.Generic.List<GK_AchievementTemplate>)val_1.Achievements;
    }
    public static System.Collections.Generic.List<GK_Leaderboard> get_Leaderboards()
    {
        if(IOSNativeSettings.Instance != null)
        {
                return (System.Collections.Generic.List<GK_Leaderboard>)val_1.Leaderboards;
        }
        
        return (System.Collections.Generic.List<GK_Leaderboard>)val_1.Leaderboards;
    }
    public static System.Collections.Generic.Dictionary<string, GK_Player> get_Players()
    {
        null = null;
        return (System.Collections.Generic.Dictionary<System.String, GK_Player>)GameCenterManager._players;
    }
    public static GK_Player get_Player()
    {
        null = null;
        return (GK_Player)GameCenterManager._player;
    }
    public static bool get_IsInitialized()
    {
        null = null;
        return (bool)GameCenterManager._IsInitialized;
    }
    public static System.Collections.Generic.List<GK_LeaderboardSet> get_LeaderboardSets()
    {
        null = null;
        return (System.Collections.Generic.List<GK_LeaderboardSet>)GameCenterManager._LeaderboardSets;
    }
    public static bool get_IsPlayerAuthenticated()
    {
        return false;
    }
    public static bool get_IsAchievementsInfoLoaded()
    {
        null = null;
        return (bool)GameCenterManager._IsAchievementsInfoLoaded;
    }
    public static System.Collections.Generic.List<string> get_FriendsList()
    {
        null = null;
        return (System.Collections.Generic.List<System.String>)GameCenterManager._friendsList;
    }
    public static bool get_IsPlayerUnderage()
    {
        return false;
    }
    private void OnLoaderBoardInfoRetrivedFail(string data)
    {
        int val_4;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        val_4 = val_1.Length;
        if(val_4 == 0)
        {
                val_4 = val_1.Length;
        }
        
        string val_4 = val_1[0];
        string val_5 = val_1[3];
        GameCenterManager.GetLeaderboard(id:  null).ReportLocalPlayerScoreUpdateFail(errorData:  val_1[4], requestId:  System.Convert.ToInt32(value:  0));
    }
    private void OnLoaderBoardInfoRetrived(string data)
    {
        int val_12;
        int val_13;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        val_12 = val_1.Length;
        if(val_12 == 0)
        {
                val_12 = val_1.Length;
        }
        
        string val_13 = val_1[1];
        string val_14 = val_1[2];
        string val_15 = val_1[3];
        string val_16 = val_1[4];
        string val_17 = val_1[5];
        string val_18 = val_1[6];
        string val_19 = val_1[7];
        val_13 = val_1.Length;
        if(val_13 <= 8)
        {
                val_13 = val_1.Length;
        }
        
        val_9._info.MaxRange = System.Convert.ToInt32(value:  0);
        val_9._info.Title = val_1[8];
        val_9._info.Description = val_1[9];
        GK_Player val_10 = GameCenterManager.Player;
        typeof(GK_Score).__il2cppRuntimeField_18 = System.Convert.ToInt64(value:  0);
        typeof(GK_Score).__il2cppRuntimeField_20 = (long)System.Convert.ToInt32(value:  0);
        typeof(GK_Score).__il2cppRuntimeField_10 = System.Convert.ToInt32(value:  0);
        typeof(GK_Score).__il2cppRuntimeField_28 = val_10._PlayerId;
        typeof(GK_Score).__il2cppRuntimeField_30 = val_1[0];
        typeof(GK_Score).__il2cppRuntimeField_3C = System.Convert.ToInt32(value:  0);
        typeof(GK_Score).__il2cppRuntimeField_38 = System.Convert.ToInt32(value:  0);
        GameCenterManager.GetLeaderboard(id:  null).ReportLocalPlayerScoreUpdate(score:  new System.Object(), requestId:  System.Convert.ToInt32(value:  0));
    }
    public void onScoreSubmittedEvent(string data)
    {
        System.String[] val_4;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        val_4 = null;
        if(val_1.Length == 0)
        {
                val_4 = 0;
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  data.Split(separator:  val_4, options:  0).LoadLeaderboardInfoLocal(leaderboardId:  val_4));
    }
    public void onScoreSubmittedFailed(string data)
    {
        int val_5;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        val_5 = val_1.Length;
        if(val_5 == 0)
        {
                val_5 = val_1.Length;
        }
        
        string val_5 = val_1[0];
        typeof(GK_LeaderboardResult).__il2cppRuntimeField_18 = GameCenterManager.GetLeaderboard(id:  null);
        GameCenterManager.OnScoreSubmitted.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  val_1[2])));
    }
    private void OnLeaderboardScoreListLoaded(string data)
    {
        int val_13;
        string val_14;
        var val_15;
        int val_16;
        var val_17;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        val_13 = val_1.Length;
        if(val_13 == 0)
        {
                val_13 = val_1.Length;
        }
        
        string val_18 = val_1[1];
        string val_19 = val_1[2];
        val_14 = 0;
        val_14 = null;
        GK_Leaderboard val_4 = GameCenterManager.GetLeaderboard(id:  val_14);
        val_15 = 3;
        goto label_14;
        label_33:
        val_15 = 4;
        label_14:
        val_16 = val_1.Length;
        if(val_15 >= val_16)
        {
            goto label_16;
        }
        
        if(val_15 >= val_16)
        {
                val_16 = val_1.Length;
        }
        
        string val_20 = val_1[4];
        string val_21 = val_1[(long)val_15 + 1];
        string val_22 = val_1[(long)val_15 + 2];
        val_15 = (((long)val_15 + 1) + 1) + 1;
        string val_23 = val_1[(long)val_15 + 3];
        object val_12 = new System.Object();
        typeof(GK_Score).__il2cppRuntimeField_18 = System.Convert.ToInt64(value:  0);
        typeof(GK_Score).__il2cppRuntimeField_20 = (long)System.Convert.ToInt32(value:  0);
        typeof(GK_Score).__il2cppRuntimeField_28 = val_20;
        typeof(GK_Score).__il2cppRuntimeField_10 = System.Convert.ToInt32(value:  0);
        typeof(GK_Score).__il2cppRuntimeField_30 = val_1[0];
        typeof(GK_Score).__il2cppRuntimeField_38 = System.Convert.ToInt32(value:  val_14);
        typeof(GK_Score).__il2cppRuntimeField_3C = System.Convert.ToInt32(value:  0);
        val_4.UpdateScore(s:  val_12);
        if(GameCenterManager.Player == null)
        {
            goto label_33;
        }
        
        GK_Player val_14 = GameCenterManager.Player;
        if((val_14._PlayerId.Equals(value:  val_20)) == false)
        {
            goto label_33;
        }
        
        val_4.UpdateCurrentPlayerScore(score:  val_12);
        goto label_33;
        label_16:
        typeof(GK_LeaderboardResult).__il2cppRuntimeField_18 = val_4;
        val_17 = null;
        val_17 = null;
        GameCenterManager.OnScoresListLoaded.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnLeaderboardScoreListLoadFailed(string data)
    {
        int val_5;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        val_5 = val_1.Length;
        if(val_5 == 0)
        {
                val_5 = val_1.Length;
        }
        
        string val_5 = val_1[0];
        typeof(GK_LeaderboardResult).__il2cppRuntimeField_18 = GameCenterManager.GetLeaderboard(id:  null);
        GameCenterManager.OnScoresListLoaded.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  val_1[3])));
    }
    private void onAchievementsReset(string array)
    {
        var val_2 = null;
        GameCenterManager.OnAchievementsReset.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void onAchievementsResetFailed(string errorData)
    {
        var val_3 = null;
        GameCenterManager.OnAchievementsReset.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  errorData)));
    }
    private void onAchievementProgressChanged(string array)
    {
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = array.Split(separator:  null);
        string val_5 = val_1[0];
        GK_AchievementTemplate val_2 = GameCenterManager.GetAchievement(achievementId:  null);
        string val_6 = val_1[1];
        val_2._progress = System.Convert.ToSingle(value:  0);
        SA.Common.Models.Result val_4 = new SA.Common.Models.Result();
        typeof(GK_AchievementProgressResult).__il2cppRuntimeField_18 = val_2;
        val_4.SaveLocalProgress(tpl:  val_2);
        GameCenterManager.OnAchievementsProgress.Invoke(obj:  val_4);
    }
    private void onAchievementsLoaded(string array)
    {
        var val_9;
        string val_10;
        var val_11;
        var val_13;
        var val_14;
        val_9 = null;
        val_9 = null;
        val_10 = System.String.Empty;
        if((array.Equals(value:  val_10)) == false)
        {
            goto label_4;
        }
        
        val_11 = null;
        val_11 = null;
        goto label_7;
        label_4:
        val_10 = null;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_3 = array.Split(separator:  val_10);
        val_13 = 0;
        goto label_11;
        label_23:
        typeof(System.Char[]).__il2cppRuntimeField_30 = ???;
        val_3.SaveLocalProgress(tpl:  val_10);
        val_13 = W25 + 1;
        label_11:
        if(val_13 >= val_3.Length)
        {
            goto label_13;
        }
        
        string val_8 = val_3[(long)val_13];
        var val_10 = (long)val_13 + 1;
        val_4.Description = val_3[val_10];
        val_10 = val_10 + 1;
        string val_11 = val_3[(long)val_13 + 2];
        float val_7 = System.Convert.ToSingle(value:  0);
        if((GameCenterManager.GetAchievement(achievementId:  null)) != null)
        {
            goto label_23;
        }
        
        goto label_23;
        label_13:
        val_14 = null;
        val_14 = null;
        GameCenterManager._IsAchievementsInfoLoaded = true;
        label_7:
        GameCenterManager.OnAchievementsLoaded.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void onAchievementsLoadedFailed(string errorData)
    {
        var val_3 = null;
        GameCenterManager.OnAchievementsLoaded.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  errorData)));
    }
    private void onAuthenticateLocalPlayer(string array)
    {
        int val_5;
        var val_6;
        var val_7;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = array.Split(separator:  null);
        val_5 = val_1.Length;
        if(val_5 == 0)
        {
                val_5 = val_1.Length;
        }
        
        if(val_5 <= 1)
        {
                val_5 = val_1.Length;
        }
        
        val_6 = null;
        val_6 = null;
        GameCenterManager._player = new GK_Player(pId:  val_1[0], pName:  val_1[1], pAlias:  val_1[2]);
        ISN_CacheManager.SendAchievementCachedRequest();
        val_7 = null;
        val_7 = null;
        GameCenterManager.ISN_GC_PP_KEY.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error()));
    }
    private void onAuthenticationFailed(string errorData)
    {
        var val_3 = null;
        GameCenterManager.ISN_GC_PP_KEY.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  errorData)));
    }
    private void OnUserInfoLoadedEvent(string array)
    {
        int val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        ISN_Logger.Log(message:  0, logType:  "OnUserInfoLoadedEvent");
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = array.Split(separator:  null);
        val_9 = val_1.Length;
        if(val_9 == 0)
        {
                val_9 = val_1.Length;
        }
        
        string val_9 = val_1[0];
        if(val_9 <= 1)
        {
                val_9 = val_1.Length;
        }
        
        GK_Player val_2 = new GK_Player(pId:  val_9, pName:  val_1[2], pAlias:  val_1[1]);
        val_10 = null;
        val_10 = null;
        val_11 = null;
        if((GameCenterManager._players.ContainsKey(key:  val_9)) != false)
        {
                val_12 = null;
            GameCenterManager._players.set_Item(key:  val_9, value:  val_2);
        }
        else
        {
                val_13 = null;
            GameCenterManager._players.Add(key:  val_9, value:  val_2);
        }
        
        val_14 = null;
        val_14 = null;
        if((System.String.op_Equality(a:  0, b:  GK_Player.__il2cppRuntimeField_name)) != false)
        {
                val_15 = null;
            val_15 = null;
            GameCenterManager._player = val_2;
        }
        
        ISN_Logger.Log(message:  0, logType:  0 + "Player Info loaded, for player with id: "("Player Info loaded, for player with id: "));
        typeof(GK_UserInfoLoadResult).__il2cppRuntimeField_20 = val_2;
        val_16 = null;
        val_16 = null;
        GameCenterManager.OnUserInfoLoaded.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnUserInfoLoadFailedEvent(string playerId)
    {
        var val_2 = null;
        GameCenterManager.OnUserInfoLoaded.Invoke(obj:  new GK_UserInfoLoadResult(id:  playerId));
    }
    private void OnUserPhotoLoadedEvent(string array)
    {
        int val_4;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = array.Split(separator:  null);
        val_4 = val_1.Length;
        if(val_4 == 0)
        {
                val_4 = val_1.Length;
        }
        
        string val_4 = val_1[0];
        string val_5 = val_1[1];
        GK_Player val_3 = GameCenterManager.GetPlayerById(playerID:  null);
        if(val_3 == null)
        {
                return;
        }
        
        val_3.SetPhotoData(size:  System.Convert.ToInt32(value:  0), base64String:  val_1[2]);
    }
    private void OnUserPhotoLoadFailedEvent(string data)
    {
        int val_4;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        val_4 = val_1.Length;
        if(val_4 == 0)
        {
                val_4 = val_1.Length;
        }
        
        string val_4 = val_1[0];
        string val_5 = val_1[1];
        GK_Player val_3 = GameCenterManager.GetPlayerById(playerID:  null);
        if(val_3 == null)
        {
                return;
        }
        
        val_3.SetPhotoLoadFailedEventData(size:  System.Convert.ToInt32(value:  0), errorData:  val_1[2]);
    }
    private void OnFriendListLoadedEvent(string data)
    {
        var val_6;
        var val_7;
        int val_8;
        var val_9;
        var val_10;
        var val_11;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        val_6 = null;
        val_6 = null;
        GameCenterManager._friendsList.Clear();
        val_7 = 0;
        goto label_7;
        label_14:
        GameCenterManager._friendsList.Add(item:  X21);
        val_7 = 1;
        label_7:
        val_8 = val_1.Length;
        if(val_7 >= val_8)
        {
            goto label_9;
        }
        
        val_9 = null;
        val_9 = null;
        val_8 = val_1.Length;
        string val_6 = data.Split(separator:  null)[1];
        if(GameCenterManager._friendsList != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_9:
        IOSNativeSettings val_2 = IOSNativeSettings.Instance;
        if(val_2.DisablePluginLogs != true)
        {
                val_10 = null;
            val_10 = null;
            int val_3 = GameCenterManager._friendsList.Count;
            ISN_Logger.Log(message:  0, logType:  0 + "Friends list loaded, total friends: "("Friends list loaded, total friends: "));
        }
        
        val_11 = null;
        val_11 = null;
        GameCenterManager.OnFriendsListLoaded.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnFriendListLoadFailEvent(string errorData)
    {
        var val_3 = null;
        GameCenterManager.OnFriendsListLoaded.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  errorData)));
    }
    private void OnGameCenterViewDismissedEvent(string data)
    {
        null = null;
        GameCenterManager.OnGameCenterViewDismissed.Invoke();
    }
    private void VerificationSignatureRetrieveFailed(string array)
    {
        var val_3 = null;
        GameCenterManager.OnPlayerSignatureRetrieveResult.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  array)));
    }
    private void VerificationSignatureRetrieved(string array)
    {
        int val_3;
        var val_4;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = array.Split(separator:  null);
        val_3 = val_1.Length;
        if(val_3 == 0)
        {
                val_3 = val_1.Length;
        }
        
        if(val_3 <= 1)
        {
                val_3 = val_1.Length;
        }
        
        if(val_3 <= 2)
        {
                val_3 = val_1.Length;
        }
        
        val_4 = null;
        val_4 = null;
        GameCenterManager.OnPlayerSignatureRetrieveResult.Invoke(obj:  new GK_PlayerSignatureResult(publicKeyUrl:  val_1[0], signature:  val_1[1], salt:  val_1[2], timestamp:  val_1[3]));
    }
    private void SaveLocalProgress(GK_AchievementTemplate tpl)
    {
        string val_3;
        IOSNativeSettings val_1 = IOSNativeSettings.Instance;
        if(val_1.UsePPForAchievements == false)
        {
                return;
        }
        
        if(tpl != null)
        {
                val_3 = tpl.Id;
        }
        else
        {
                val_3 = 7254272;
        }
        
        GameCenterManager.SaveAchievementProgress(achievementId:  null, progress:  tpl.Progress);
    }
    private static void ResetStoredProgress()
    {
        var val_5;
        var val_6;
        List.Enumerator<T> val_2 = GameCenterManager.Achievements.GetEnumerator();
        label_8:
        if((0 & 1) == 0)
        {
            goto label_4;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_3 = 0.InitializationCallback;
        string val_4 = 0 + "ISN_GameCenterManager";
        UnityEngine.PlayerPrefs.DeleteKey(key:  0);
        goto label_8;
        label_4:
        val_5 = 0;
        val_6 = 1;
        0.Dispose();
        if((val_6 & 1) != 0)
        {
                return;
        }
        
        if(val_5 == 0)
        {
                return;
        }
    
    }
    private static void SaveAchievementProgress(string achievementId, float progress)
    {
        if((GameCenterManager.GetStoredAchievementProgress(achievementId:  null)) >= 0)
        {
                return;
        }
        
        string val_2 = 0 + "ISN_GameCenterManager";
        UnityEngine.PlayerPrefs.SetFloat(key:  0, value:  UnityEngine.Mathf.Clamp(value:  progress, min:  0f, max:  100f));
    }
    private static float GetStoredAchievementProgress(string achievementId)
    {
        string val_1 = 0 + "ISN_GameCenterManager";
        if((UnityEngine.PlayerPrefs.HasKey(key:  0)) == false)
        {
                return 0f;
        }
        
        string val_3 = 0 + "ISN_GameCenterManager";
        return UnityEngine.PlayerPrefs.GetFloat(key:  0);
    }
    private void ISN_OnLBSetsLoaded(string array)
    {
        var val_5;
        var val_6;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = array.Split(separator:  null);
        val_5 = 0;
        goto label_4;
        label_14:
        X21.Add(item:  null);
        val_5 = 3;
        label_4:
        var val_2 = val_5 + 2;
        if(val_2 >= val_1.Length)
        {
            goto label_6;
        }
        
        GK_LeaderboardSet val_3 = new GK_LeaderboardSet();
        typeof(GK_LeaderboardSet).__il2cppRuntimeField_10 = val_1[3];
        typeof(GK_LeaderboardSet).__il2cppRuntimeField_18 = val_1[(long)val_5 + 1];
        typeof(GK_LeaderboardSet).__il2cppRuntimeField_20 = val_1[(long)val_2];
        if(GameCenterManager.LeaderboardSets != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_6:
        val_6 = null;
        val_6 = null;
        GameCenterManager.OnLeaderboardSetsInfoLoaded.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void ISN_OnLBSetsLoadFailed(string array)
    {
        var val_3 = null;
        GameCenterManager.OnLeaderboardSetsInfoLoaded.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error()));
    }
    private void ISN_OnLBSetsBoardsLoadFailed(string identifier)
    {
        var val_6;
        var val_7;
        List.Enumerator<T> val_2 = GameCenterManager.LeaderboardSets.GetEnumerator();
        label_7:
        if((0 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X21.Equals(value:  identifier)) == false)
        {
            goto label_7;
        }
        
        0.InitializationCallback.SendFailLoadEvent();
        label_4:
        val_6 = 0;
        val_7 = 1;
        0.Dispose();
        if(( & 1) != 0)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
    
    }
    private void ISN_OnLBSetsBoardsLoaded(string array)
    {
        var val_5;
        var val_9;
        var val_10;
        var val_11;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = array.Split(separator:  null);
        List.Enumerator<T> val_3 = GameCenterManager.LeaderboardSets.GetEnumerator();
        val_9 = 1152921510223088752;
        label_12:
        if((0 & 1) == 0)
        {
            goto label_9;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_6 = val_5.InitializationCallback;
        if((X22.Equals(value:  val_1[0])) == false)
        {
            goto label_12;
        }
        
        val_9 = 1;
        goto label_13;
        label_22:
        val_9 = 2;
        label_13:
        if(val_9 >= val_1.Length)
        {
            goto label_16;
        }
        
        GK_LeaderBoardInfo val_8 = new GK_LeaderBoardInfo();
        typeof(GK_LeaderBoardInfo).__il2cppRuntimeField_10 = val_1[2];
        val_9 = ((long)val_9 + 1) + 1;
        typeof(GK_LeaderBoardInfo).__il2cppRuntimeField_18 = val_1[(long)val_9 + 1];
        typeof(GK_LeaderBoardInfo).__il2cppRuntimeField_20 = val_1[(long)val_9 + 2];
        val_6.AddBoardInfo(info:  null);
        goto label_22;
        label_16:
        val_6.SendSuccessLoadEvent();
        label_9:
        val_10 = 0;
        val_11 = 1;
        val_5.Dispose();
        if((val_11 & 1) != 0)
        {
                return;
        }
        
        if(val_10 == 0)
        {
                return;
        }
    
    }
    public static void DispatchLeaderboardUpdateEvent(GK_LeaderboardResult result, bool isInternal)
    {
        var val_3;
        var val_4;
        System.Action<GK_LeaderboardResult> val_5;
        var val_6;
        val_3 = null;
        if((W2 & 1) == 0)
        {
            goto label_1;
        }
        
        val_4 = null;
        val_5 = GameCenterManager.OnScoreSubmitted;
        if(val_5 != null)
        {
            goto label_8;
        }
        
        goto label_5;
        label_1:
        val_6 = null;
        val_5 = GameCenterManager.OnLeadrboardInfoLoaded;
        if(val_5 != null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_5.Invoke(obj:  isInternal);
    }
    public static System.Collections.Generic.List<GK_TBM_Participant> ParseParticipantsData(string[] data, int index)
    {
        var val_6 = W2;
        goto label_1;
        label_11:
        Add(item:  X22);
        val_6 = val_6 + 5;
        label_1:
        if(val_6 >= (index + 24))
        {
                return (System.Collections.Generic.List<GK_TBM_Participant>)new System.Collections.Generic.List<GK_TBM_Participant>();
        }
        
        int val_2 = index + (((long)(int)((W2 + 5))) << 3);
        if((System.String.op_Equality(a:  0, b:  (index + ((long)(int)((W2 + 5))) << 3) + 32)) == true)
        {
                return (System.Collections.Generic.List<GK_TBM_Participant>)new System.Collections.Generic.List<GK_TBM_Participant>();
        }
        
        GK_TBM_Participant val_5 = GameCenterManager.ParseParticipanData(data:  null, index:  index);
        if(null != 0)
        {
            goto label_11;
        }
        
        goto label_11;
    }
    public static GK_TBM_Participant ParseParticipanData(string[] data, int index)
    {
        var val_11 = mem[index + 24];
        val_11 = index + 24;
        if(val_11 <= W2)
        {
                val_11 = mem[index + 24];
            val_11 = index + 24;
        }
        
        int val_1 = index + (((long)(int)(W2)) << 3);
        if((W2 + 1) >= val_11)
        {
                val_11 = mem[index + 24];
            val_11 = index + 24;
        }
        
        int val_3 = index + (((long)(int)((W2 + 1))) << 3);
        if((W2 + 2) >= val_11)
        {
                val_11 = mem[index + 24];
            val_11 = index + 24;
        }
        
        int val_5 = index + (((long)(int)((W2 + 2))) << 3);
        if((W2 + 3) >= val_11)
        {
                val_11 = mem[index + 24];
            val_11 = index + 24;
        }
        
        int val_7 = index + (((long)(int)((W2 + 3))) << 3);
        var val_8 = W2 + 4;
        int val_9 = index + (((long)(int)((W2 + 4))) << 3);
        return (GK_TBM_Participant)new GK_TBM_Participant(playerId:  (index + ((long)(int)(W2)) << 3) + 32, status:  (index + ((long)(int)((W2 + 1))) << 3) + 32, outcome:  (index + ((long)(int)((W2 + 2))) << 3) + 32, timeoutDate:  (index + ((long)(int)((W2 + 3))) << 3) + 32, lastTurnDate:  (index + ((long)(int)((W2 + 4))) << 3) + 32);
    }
    private static GameCenterManager()
    {
        GameCenterManager.ISN_GC_PP_KEY = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void GameCenterManager::<OnAuthFinished>m__0(SA.Common.Models.Result ));
        GameCenterManager.OnScoreSubmitted = new System.Action<GK_LeaderboardResult>(object:  0, method:  static System.Void GameCenterManager::<OnScoreSubmitted>m__1(GK_LeaderboardResult ));
        GameCenterManager.OnScoresListLoaded = new System.Action<GK_LeaderboardResult>(object:  0, method:  static System.Void GameCenterManager::<OnScoresListLoaded>m__2(GK_LeaderboardResult ));
        GameCenterManager.OnLeadrboardInfoLoaded = new System.Action<GK_LeaderboardResult>(object:  0, method:  static System.Void GameCenterManager::<OnLeadrboardInfoLoaded>m__3(GK_LeaderboardResult ));
        GameCenterManager.OnLeaderboardSetsInfoLoaded = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void GameCenterManager::<OnLeaderboardSetsInfoLoaded>m__4(SA.Common.Models.Result ));
        GameCenterManager.OnAchievementsReset = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void GameCenterManager::<OnAchievementsReset>m__5(SA.Common.Models.Result ));
        GameCenterManager.OnAchievementsLoaded = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void GameCenterManager::<OnAchievementsLoaded>m__6(SA.Common.Models.Result ));
        GameCenterManager.OnAchievementsProgress = new System.Action<GK_AchievementProgressResult>(object:  0, method:  static System.Void GameCenterManager::<OnAchievementsProgress>m__7(GK_AchievementProgressResult ));
        GameCenterManager.OnGameCenterViewDismissed = new System.Action(object:  0, method:  static System.Void GameCenterManager::<OnGameCenterViewDismissed>m__8());
        GameCenterManager.OnFriendsListLoaded = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void GameCenterManager::<OnFriendsListLoaded>m__9(SA.Common.Models.Result ));
        GameCenterManager.OnUserInfoLoaded = new System.Action<GK_UserInfoLoadResult>(object:  0, method:  static System.Void GameCenterManager::<OnUserInfoLoaded>m__A(GK_UserInfoLoadResult ));
        GameCenterManager.OnPlayerSignatureRetrieveResult = new System.Action<GK_PlayerSignatureResult>(object:  0, method:  static System.Void GameCenterManager::<OnPlayerSignatureRetrieveResult>m__B(GK_PlayerSignatureResult ));
        GameCenterManager._IsInitialized = false;
        GameCenterManager._IsAchievementsInfoLoaded = false;
        GameCenterManager._players = new System.Collections.Generic.Dictionary<System.String, GK_Player>();
        GameCenterManager._friendsList = new System.Collections.Generic.List<System.String>();
        GameCenterManager._LeaderboardSets = new System.Collections.Generic.List<GK_LeaderboardSet>();
        GameCenterManager._FriendRequests = new System.Collections.Generic.Dictionary<System.Int32, GK_FriendRequest>();
        GameCenterManager._player = 0;
    }
    private static void <OnAuthFinished>m__0(SA.Common.Models.Result )
    {
    
    }
    private static void <OnScoreSubmitted>m__1(GK_LeaderboardResult )
    {
    
    }
    private static void <OnScoresListLoaded>m__2(GK_LeaderboardResult )
    {
    
    }
    private static void <OnLeadrboardInfoLoaded>m__3(GK_LeaderboardResult )
    {
    
    }
    private static void <OnLeaderboardSetsInfoLoaded>m__4(SA.Common.Models.Result )
    {
    
    }
    private static void <OnAchievementsReset>m__5(SA.Common.Models.Result )
    {
    
    }
    private static void <OnAchievementsLoaded>m__6(SA.Common.Models.Result )
    {
    
    }
    private static void <OnAchievementsProgress>m__7(GK_AchievementProgressResult )
    {
    
    }
    private static void <OnGameCenterViewDismissed>m__8()
    {
    
    }
    private static void <OnFriendsListLoaded>m__9(SA.Common.Models.Result )
    {
    
    }
    private static void <OnUserInfoLoaded>m__A(GK_UserInfoLoadResult )
    {
    
    }
    private static void <OnPlayerSignatureRetrieveResult>m__B(GK_PlayerSignatureResult )
    {
    
    }

}
