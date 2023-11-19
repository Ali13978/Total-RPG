using UnityEngine;

namespace TzarGames.Endless
{
    public class SocialSystem : MonoBehaviour
    {
        // Fields
        private const string INIT_KEY = "SOCIALSYSTEM_INIT_FLAG";
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static TzarGames.Endless.SocialSystem <Instance>k__BackingField;
        private string editorUserName;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onAuthenticationStarted;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onAuthenticationSuccess;
        [UnityEngine.SerializeField]
        private TzarGames.Common.Events.StringEvent onAuthenticationFailed;
        private bool authInProcess;
        private System.Collections.Generic.List<System.Action<bool, string>> authCallbacks;
        public bool LogDebugInfo;
        private System.Collections.Generic.Dictionary<string, TzarGames.Endless.SocialSystem.TopPlayerCallbackList> getTopPlayerCallbacks;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <AllowWriteScores>k__BackingField;
        private static System.Action<bool> <>f__am$cache0;
        private static System.Action<bool> <>f__am$cache1;
        private static System.Action<bool> <>f__am$cache2;
        private static System.Action<bool, string> <>f__am$cache3;
        
        // Properties
        public static TzarGames.Endless.SocialSystem Instance { get; set; }
        public UnityEngine.Events.UnityEvent OnAuthenticationSuccess { get; }
        public bool IsAuthenticated { get; }
        public bool CanSignOut { get; }
        public bool AllowWriteScores { get; set; }
        
        // Methods
        public SocialSystem()
        {
            this.authCallbacks = new System.Collections.Generic.List<System.Action<System.Boolean, System.String>>();
            this.getTopPlayerCallbacks = new System.Collections.Generic.Dictionary<System.String, TopPlayerCallbackList>();
        }
        public static TzarGames.Endless.SocialSystem get_Instance()
        {
            return (TzarGames.Endless.SocialSystem)TzarGames.Endless.SocialSystem.<Instance>k__BackingField;
        }
        private static void set_Instance(TzarGames.Endless.SocialSystem value)
        {
            TzarGames.Endless.SocialSystem.<Instance>k__BackingField = X1;
        }
        public UnityEngine.Events.UnityEvent get_OnAuthenticationSuccess()
        {
            return (UnityEngine.Events.UnityEvent)this;
        }
        public bool get_IsAuthenticated()
        {
            var val_3;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = UnityEngine.Social.localUser;
        }
        public void Authenticate(System.Action<bool, string> callback)
        {
            this.authCallbacks.Add(item:  callback);
            if(this.authInProcess != false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.authRoutine());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator authRoutine()
        {
            typeof(SocialSystem.<authRoutine>c__Iterator0).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private string getMostExperiencedLeaderboardId()
        {
            return "CgkIsoz8nMQVEAIQAQ";
        }
        private string getTopLevelLeaderboardId()
        {
            return "CgkIsoz8nMQVEAIQAg";
        }
        private string getTopKnightLevelLeaderboardId()
        {
            return "CgkIsoz8nMQVEAIQCQ";
        }
        private string getTopDualistLevelLeaderboardId()
        {
            return "CgkIsoz8nMQVEAIQCA";
        }
        private string getTopStageLeaderboardId()
        {
            return "CgkIsoz8nMQVEAIQAw";
        }
        private string getTopStageLeaderboardId_hardcore()
        {
            return "CgkIsoz8nMQVEAIQBw";
        }
        public void GetMostExperiencedPlayerProfile(bool friend, System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback)
        {
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.getTopPlayerProfile_routine_wait(leaderboardId:  "CgkIsoz8nMQVEAIQAQ", friend:  friend, callback:  callback));
        }
        public void GetTopLevelProfile(bool friend, System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback)
        {
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.getTopPlayerProfile_routine_wait(leaderboardId:  "CgkIsoz8nMQVEAIQAg", friend:  friend, callback:  callback));
        }
        public void GetTopKnightLevelProfile(bool friend, System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback)
        {
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.getTopPlayerProfile_routine_wait(leaderboardId:  "CgkIsoz8nMQVEAIQCQ", friend:  friend, callback:  callback));
        }
        public void GetTopDualistLevelProfile(bool friend, System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback)
        {
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.getTopPlayerProfile_routine_wait(leaderboardId:  "CgkIsoz8nMQVEAIQCQ", friend:  friend, callback:  callback));
        }
        public void GetTopStagePlayerProfile(bool friend, System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback)
        {
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.getTopPlayerProfile_routine_wait(leaderboardId:  "CgkIsoz8nMQVEAIQAw", friend:  friend, callback:  callback));
        }
        private void getTopPlayerProfile_threaded(string leaderboardId, bool friend, System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback)
        {
            if(null != 0)
            {
                    typeof(SocialSystem.<getTopPlayerProfile_threaded>c__AnonStorey4).__il2cppRuntimeField_10 = leaderboardId;
                typeof(SocialSystem.<getTopPlayerProfile_threaded>c__AnonStorey4).__il2cppRuntimeField_18 = friend;
                typeof(SocialSystem.<getTopPlayerProfile_threaded>c__AnonStorey4).__il2cppRuntimeField_20 = callback;
            }
            else
            {
                    mem[16] = leaderboardId;
                mem[24] = friend;
                mem[32] = callback;
            }
            
            typeof(SocialSystem.<getTopPlayerProfile_threaded>c__AnonStorey4).__il2cppRuntimeField_28 = this;
            System.Threading.Thread val_5 = new System.Threading.Thread(start:  new System.Threading.ThreadStart(object:  new System.Object(), method:  System.Void SocialSystem.<getTopPlayerProfile_threaded>c__AnonStorey4::<>m__0()));
            Start();
        }
        private string buildCallbackId(string leaderboardId, bool friend)
        {
            bool val_1 = friend;
            return (string)System.String.Format(format:  0, arg0:  "{0}_{1}", arg1:  leaderboardId);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator getTopPlayerProfile_routine_wait(string leaderboardId, bool friend, System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback)
        {
            if(null != 0)
            {
                    typeof(SocialSystem.<getTopPlayerProfile_routine_wait>c__Iterator1).__il2cppRuntimeField_10 = leaderboardId;
                typeof(SocialSystem.<getTopPlayerProfile_routine_wait>c__Iterator1).__il2cppRuntimeField_18 = friend;
                typeof(SocialSystem.<getTopPlayerProfile_routine_wait>c__Iterator1).__il2cppRuntimeField_20 = callback;
            }
            else
            {
                    mem[16] = leaderboardId;
                mem[24] = friend;
                mem[32] = callback;
            }
            
            typeof(SocialSystem.<getTopPlayerProfile_routine_wait>c__Iterator1).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void getTopPlayerProfile_routine(string leaderboardId, bool friend, System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback)
        {
            friend = friend;
            string val_1 = this.buildCallbackId(leaderboardId:  leaderboardId, friend:  friend);
            if((this.getTopPlayerCallbacks.ContainsKey(key:  val_1)) != false)
            {
                    this.getTopPlayerCallbacks.Item[val_1].Add(item:  callback);
                return;
            }
            
            Add(item:  callback);
            this.getTopPlayerCallbacks.Add(key:  val_1, value:  new SocialSystem.TopPlayerCallbackList());
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.getTopPlayerRoutine(leaderboardId:  leaderboardId, friend:  friend));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator getTopPlayerRoutine(string leaderboardId, bool friend)
        {
            if(null != 0)
            {
                    typeof(SocialSystem.<getTopPlayerRoutine>c__Iterator2).__il2cppRuntimeField_10 = leaderboardId;
                typeof(SocialSystem.<getTopPlayerRoutine>c__Iterator2).__il2cppRuntimeField_18 = friend;
            }
            else
            {
                    mem[16] = leaderboardId;
                mem[24] = friend;
            }
            
            typeof(SocialSystem.<getTopPlayerRoutine>c__Iterator2).__il2cppRuntimeField_48 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void getTopPlayerProfile(string leaderboardId, bool friend, System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback)
        {
            if(null != 0)
            {
                    typeof(SocialSystem.<getTopPlayerProfile>c__AnonStorey6).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    mem[16] = callback;
            }
            
            typeof(SocialSystem.<getTopPlayerProfile>c__AnonStorey6).__il2cppRuntimeField_18 = this;
            var val_6 = ~friend;
            System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> val_5 = null;
            val_6 = val_6 & 1;
            GooglePlayGames.BasicApi.LeaderboardStart val_3 = (friend != true) ? 1 : (val_6);
            val_5 = new System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData>(object:  new System.Object(), method:  System.Void SocialSystem.<getTopPlayerProfile>c__AnonStorey6::<>m__0(GooglePlayGames.BasicApi.LeaderboardScoreData result));
            GooglePlayGames.PlayGamesPlatform.Instance.LoadScores(leaderboardId:  leaderboardId, start:  val_3, rowCount:  val_3, collection:  (friend != true) ? (1 + 1) : 1, timeSpan:  3, callback:  val_5);
        }
        private void getPlayerProfile(string[] userIds, System.Action<bool, UnityEngine.SocialPlatforms.IUserProfile> callback)
        {
            typeof(SocialSystem.<getPlayerProfile>c__AnonStorey7).__il2cppRuntimeField_10 = callback;
            System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> val_2 = new System.Action<UnityEngine.SocialPlatforms.IUserProfile[]>(object:  new System.Object(), method:  System.Void SocialSystem.<getPlayerProfile>c__AnonStorey7::<>m__0(UnityEngine.SocialPlatforms.IUserProfile[] profiles));
            UnityEngine.Social.LoadUsers(userIDs:  0, callback:  userIds);
        }
        public bool get_CanSignOut()
        {
            return true;
        }
        public void SignOut()
        {
            GooglePlayGames.PlayGamesPlatform.Instance.SignOut();
            this.StopAllCoroutines();
            this.authCallbacks.Clear();
            this.getTopPlayerCallbacks.Clear();
        }
        public void ShowDefaultLeaderboardUI()
        {
            UnityEngine.Social.ShowLeaderboardUI();
        }
        public bool get_AllowWriteScores()
        {
            return (bool)this.<AllowWriteScores>k__BackingField;
        }
        public void set_AllowWriteScores(bool value)
        {
            this.<AllowWriteScores>k__BackingField = value;
        }
        private void onGameSaved()
        {
            string val_21;
            var val_22;
            var val_23;
            System.Action<System.Boolean> val_24;
            var val_25;
            string val_26;
            var val_27;
            var val_28;
            var val_29;
            System.Action<System.Boolean> val_31;
            long val_32;
            val_21 = this;
            if(this.IsAuthenticated == false)
            {
                    return;
            }
            
            if((this.<AllowWriteScores>k__BackingField) == false)
            {
                    return;
            }
            
            TzarGames.Endless.ICharacterInfo val_3 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_22 = val_3;
            val_21 = val_3;
            if(val_21 == null)
            {
                    return;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_23 = val_21;
            if(val_21 != null)
            {
                    if((TzarGames.Endless.SocialSystem.<>f__am$cache0) == null)
            {
                    System.Action<System.Boolean> val_6 = null;
                val_24 = val_6;
                val_6 = new System.Action<System.Boolean>(object:  0, method:  static System.Void TzarGames.Endless.SocialSystem::<onGameSaved>m__0(bool result));
                TzarGames.Endless.SocialSystem.<>f__am$cache0 = val_24;
            }
            
                UnityEngine.Social.ReportScore(score:  0, board:  val_21, callback:  "CgkIsoz8nMQVEAIQAQ");
            }
            
            TzarGames.Endless.ICharacterInfo val_8 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_25 = val_8;
            val_26 = val_8;
            if(val_26 >= 2)
            {
                    val_26 = val_26;
                if((TzarGames.Endless.SocialSystem.<>f__am$cache1) == null)
            {
                    val_24 = static System.Void TzarGames.Endless.SocialSystem::<onGameSaved>m__1(bool result);
                TzarGames.Endless.SocialSystem.<>f__am$cache1 = new System.Action<System.Boolean>(object:  0, method:  val_24);
            }
            
                UnityEngine.Social.ReportScore(score:  0, board:  val_26, callback:  "CgkIsoz8nMQVEAIQAw");
                TzarGames.Endless.ICharacterInfo val_12 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
                var val_24 = 0;
                val_24 = val_24 + 1;
                val_27 = val_12;
                if((val_12 & 1) != 0)
            {
                    TzarGames.Endless.ICharacterInfo val_15 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
                var val_25 = 0;
                val_25 = val_25 + 1;
                val_28 = val_15;
                if(((val_15 & 1) & 1) == 0)
            {
                    if((TzarGames.Endless.SocialSystem.<>f__am$cache2) == null)
            {
                    val_24 = static System.Void TzarGames.Endless.SocialSystem::<onGameSaved>m__2(bool result);
                TzarGames.Endless.SocialSystem.<>f__am$cache2 = new System.Action<System.Boolean>(object:  0, method:  val_24);
            }
            
                UnityEngine.Social.ReportScore(score:  0, board:  val_26, callback:  "CgkIsoz8nMQVEAIQBw");
            }
            
            }
            
            }
            
            uint val_19 = TzarGames.GameFramework.CharacterTemplate.GetLevelFromXp(xp:  0);
            if(val_19 == 0)
            {
                    return;
            }
            
            UnityEngine.Social.ReportScore(score:  0, board:  val_19, callback:  "CgkIsoz8nMQVEAIQAg");
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_29 = val_21;
            if(val_21 != 1)
            {
                    if(val_21 != null)
            {
                    return;
            }
            
                val_31 = "CgkIsoz8nMQVEAIQCQ";
                val_32 = 0;
            }
            else
            {
                    val_31 = "CgkIsoz8nMQVEAIQCA";
                val_32 = 0;
            }
            
            UnityEngine.Social.ReportScore(score:  val_32, board:  val_19, callback:  val_31);
        }
        private void Awake()
        {
            TzarGames.Endless.SocialSystem val_15;
            System.Action val_16;
            System.Action<System.Boolean, System.String> val_17;
            val_15 = this;
            PlayGamesClientConfiguration.Builder val_1 = new PlayGamesClientConfiguration.Builder();
            GooglePlayGames.BasicApi.PlayGamesClientConfiguration val_3 = EnableSavedGames().Build();
            GooglePlayGames.PlayGamesPlatform.InitializeInstance(configuration:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = false, mRequestAuthCode = false, mForceRefresh = false, mHidePopups = false, mRequestEmail = false, mRequestIdToken = false});
            GooglePlayGames.PlayGamesPlatform val_7 = GooglePlayGames.PlayGamesPlatform.Activate();
            val_16 = 1152921504721543168;
            if(0 != (TzarGames.Endless.SocialSystem.<Instance>k__BackingField))
            {
                    UnityEngine.Debug.LogError(message:  0);
                val_15 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            TzarGames.Endless.SocialSystem.<Instance>k__BackingField = val_15;
            System.Action val_11 = null;
            val_16 = val_11;
            val_11 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.SocialSystem::onGameSaved());
            TzarGames.Endless.EndlessGameState.Instance.add_OnGameSaved(value:  val_16);
            if((UnityEngine.PlayerPrefs.HasKey(key:  0)) != false)
            {
                    int val_13 = UnityEngine.PlayerPrefs.GetInt(key:  0);
                UnityEngine.PlayerPrefs.SetInt(key:  0, value:  1944255008);
                val_17 = TzarGames.Endless.SocialSystem.<>f__am$cache3;
                if(val_17 == null)
            {
                    System.Action<System.Boolean, System.String> val_14 = null;
                val_16 = val_14;
                val_14 = new System.Action<System.Boolean, System.String>(object:  0, method:  static System.Void TzarGames.Endless.SocialSystem::<Awake>m__3(bool result, string message));
                TzarGames.Endless.SocialSystem.<>f__am$cache3 = val_16;
                val_17 = TzarGames.Endless.SocialSystem.<>f__am$cache3;
            }
            
                this.Authenticate(callback:  val_17);
                return;
            }
            
            UnityEngine.PlayerPrefs.SetInt(key:  0, value:  1944255008);
        }
        private void OnDestroy()
        {
            if(0 != (TzarGames.Endless.SocialSystem.<Instance>k__BackingField))
            {
                    return;
            }
            
            TzarGames.Endless.SocialSystem.<Instance>k__BackingField = 0;
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                    return;
            }
            
            TzarGames.Endless.EndlessGameState.Instance.add_OnGameSaved(value:  new System.Action(object:  this, method:  System.Void TzarGames.Endless.SocialSystem::onGameSaved()));
        }
        public string GetUserName()
        {
            var val_4;
            if(UnityEngine.Social.localUser == null)
            {
                    return 0;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = UnityEngine.Social.localUser;
        }
        private static void <onGameSaved>m__0(bool result)
        {
        
        }
        private static void <onGameSaved>m__1(bool result)
        {
        
        }
        private static void <onGameSaved>m__2(bool result)
        {
        
        }
        private static void <Awake>m__3(bool result, string message)
        {
        
        }
    
    }

}
