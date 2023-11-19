using UnityEngine;

namespace GooglePlayGames
{
    public class PlayGamesPlatform : ISocialPlatform
    {
        // Fields
        private static GooglePlayGames.PlayGamesPlatform sInstance;
        private static bool sNearbyInitializePending;
        private static GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient sNearbyConnectionClient;
        private readonly GooglePlayGames.BasicApi.PlayGamesClientConfiguration mConfiguration;
        private GooglePlayGames.PlayGamesLocalUser mLocalUser;
        private GooglePlayGames.BasicApi.IPlayGamesClient mClient;
        private string mDefaultLbUi;
        private System.Collections.Generic.Dictionary<string, string> mIdMap;
        
        // Properties
        public static bool DebugLogEnabled { get; set; }
        public static GooglePlayGames.PlayGamesPlatform Instance { get; }
        public static GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient Nearby { get; }
        public GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient RealTime { get; }
        public GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient TurnBased { get; }
        public GooglePlayGames.BasicApi.SavedGame.ISavedGameClient SavedGame { get; }
        public GooglePlayGames.BasicApi.Events.IEventsClient Events { get; }
        public GooglePlayGames.BasicApi.Video.IVideoClient Video { get; }
        public UnityEngine.SocialPlatforms.ILocalUser localUser { get; }
        
        // Methods
        internal PlayGamesPlatform(GooglePlayGames.BasicApi.IPlayGamesClient client)
        {
            var val_4;
            this.mIdMap = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this.mClient = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            this.mLocalUser = new GooglePlayGames.PlayGamesLocalUser(plaf:  this);
            val_4 = null;
            val_4 = null;
            this.mConfiguration = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration;
            mem[1152921511904145856] = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10;
            mem[1152921511904145872] = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_20;
        }
        private PlayGamesPlatform(GooglePlayGames.BasicApi.PlayGamesClientConfiguration configuration)
        {
            this.mIdMap = new System.Collections.Generic.Dictionary<System.String, System.String>();
            GooglePlayGames.OurUtils.Logger.w(msg:  null);
            this.mLocalUser = new GooglePlayGames.PlayGamesLocalUser(plaf:  this);
            mem[1152921511904319424] = configuration.mRequestAuthCode;
            mem[1152921511904319440] = configuration.mInvitationDelegate;
            this.mConfiguration = configuration.mEnableSavedGames;
        }
        public static bool get_DebugLogEnabled()
        {
            return GooglePlayGames.OurUtils.Logger.DebugLogEnabled;
        }
        public static void set_DebugLogEnabled(bool value)
        {
            var val_1 = W1 & 1;
            GooglePlayGames.OurUtils.Logger.DebugLogEnabled = false;
        }
        public static GooglePlayGames.PlayGamesPlatform get_Instance()
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = null;
            val_1 = null;
            if(GooglePlayGames.PlayGamesPlatform.sInstance == null)
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  null);
                val_2 = null;
                val_2 = null;
                GooglePlayGames.PlayGamesPlatform.InitializeInstance(configuration:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = false, mRequestAuthCode = false, mForceRefresh = false, mHidePopups = false, mRequestEmail = false, mRequestIdToken = false});
            }
            
            val_3 = null;
            val_3 = null;
            return (GooglePlayGames.PlayGamesPlatform)GooglePlayGames.PlayGamesPlatform.sInstance;
        }
        public static GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient get_Nearby()
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = null;
            val_1 = null;
            if(GooglePlayGames.PlayGamesPlatform.sNearbyConnectionClient == null)
            {
                    val_2 = null;
                val_2 = null;
                if(GooglePlayGames.PlayGamesPlatform.sNearbyInitializePending != true)
            {
                    GooglePlayGames.PlayGamesPlatform.sNearbyInitializePending = true;
                GooglePlayGames.PlayGamesPlatform.InitializeNearby(callback:  null);
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            return (GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient)GooglePlayGames.PlayGamesPlatform.sNearbyConnectionClient;
        }
        public GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient get_RealTime()
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.mClient;
        }
        public GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient get_TurnBased()
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.mClient;
        }
        public GooglePlayGames.BasicApi.SavedGame.ISavedGameClient get_SavedGame()
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.mClient;
        }
        public GooglePlayGames.BasicApi.Events.IEventsClient get_Events()
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.mClient;
        }
        public GooglePlayGames.BasicApi.Video.IVideoClient get_Video()
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.mClient;
            goto x2;
        }
        public UnityEngine.SocialPlatforms.ILocalUser get_localUser()
        {
            return (UnityEngine.SocialPlatforms.ILocalUser)this.mLocalUser;
        }
        public static void InitializeInstance(GooglePlayGames.BasicApi.PlayGamesClientConfiguration configuration)
        {
            null = null;
            if(GooglePlayGames.PlayGamesPlatform.sInstance != null)
            {
                    GooglePlayGames.OurUtils.Logger.w(msg:  null);
                return;
            }
            
            GooglePlayGames.PlayGamesPlatform val_1 = null;
            val_1 = new GooglePlayGames.PlayGamesPlatform(configuration:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = X1, mScopes = X1, mRequestAuthCode = X1 + 16, mForceRefresh = X1 + 16, mHidePopups = X1 + 16, mRequestEmail = X1 + 16, mRequestIdToken = X1 + 16, mAccountName = X1 + 16, mInvitationDelegate = X1 + 32, mMatchDelegate = X1 + 32});
            GooglePlayGames.PlayGamesPlatform.sInstance = val_1;
        }
        public static void InitializeNearby(System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient> callback)
        {
            var val_5;
            var val_6;
            typeof(PlayGamesPlatform.<InitializeNearby>c__AnonStorey0).__il2cppRuntimeField_10 = X1;
            UnityEngine.Debug.Log(message:  0);
            val_5 = null;
            val_5 = null;
            if(GooglePlayGames.PlayGamesPlatform.sNearbyConnectionClient == null)
            {
                goto label_6;
            }
            
            if((typeof(PlayGamesPlatform.<InitializeNearby>c__AnonStorey0).__il2cppRuntimeField_10) == 0)
            {
                goto label_8;
            }
            
            UnityEngine.Debug.Log(message:  0);
            val_6 = null;
            val_6 = null;
            typeof(PlayGamesPlatform.<InitializeNearby>c__AnonStorey0).__il2cppRuntimeField_10.Invoke(obj:  GooglePlayGames.PlayGamesPlatform.sNearbyConnectionClient);
            return;
            label_6:
            GooglePlayGames.NearbyConnectionClientFactory.Create(callback:  new System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient>(object:  new System.Object(), method:  System.Void PlayGamesPlatform.<InitializeNearby>c__AnonStorey0::<>m__0(GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient client)) = new System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient>(object:  new System.Object(), method:  System.Void PlayGamesPlatform.<InitializeNearby>c__AnonStorey0::<>m__0(GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient client)));
            return;
            label_8:
            UnityEngine.Debug.Log(message:  0);
        }
        public static GooglePlayGames.PlayGamesPlatform Activate()
        {
            GooglePlayGames.OurUtils.Logger.d(msg:  null);
            GooglePlayGames.PlayGamesPlatform val_1 = GooglePlayGames.PlayGamesPlatform.Instance;
            UnityEngine.Social.Active = 0;
            UnityEngine.SocialPlatforms.ISocialPlatform val_2 = UnityEngine.Social.Active;
            GooglePlayGames.OurUtils.Logger.d(msg:  0 + "PlayGamesPlatform activated: "("PlayGamesPlatform activated: "));
            return GooglePlayGames.PlayGamesPlatform.Instance;
        }
        public IntPtr GetApiClient()
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.mClient;
            goto x2;
        }
        public void SetGravityForPopups(GooglePlayGames.BasicApi.Gravity gravity)
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.mClient;
            goto x3;
        }
        public void AddIdMapping(string fromId, string toId)
        {
            this.mIdMap.set_Item(key:  fromId, value:  toId);
        }
        public void Authenticate(System.Action<bool> callback)
        {
            this.Authenticate(callback:  callback, silent:  false);
        }
        public void Authenticate(System.Action<bool, string> callback)
        {
            this.Authenticate(callback:  callback, silent:  false);
        }
        public void Authenticate(System.Action<bool> callback, bool silent)
        {
            typeof(PlayGamesPlatform.<Authenticate>c__AnonStorey1).__il2cppRuntimeField_10 = callback;
            this.Authenticate(callback:  new System.Action<System.Boolean, System.String>(object:  new System.Object(), method:  System.Void PlayGamesPlatform.<Authenticate>c__AnonStorey1::<>m__0(bool success, string msg)), silent:  silent);
        }
        public void Authenticate(System.Action<bool, string> callback, bool silent)
        {
            GooglePlayGames.BasicApi.IPlayGamesClient val_3;
            var val_4;
            val_3 = this.mClient;
            if(val_3 == null)
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  null);
                val_3 = GooglePlayGames.PlayGamesClientFactory.GetPlatformPlayGamesClient(config:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = false, mRequestAuthCode = false, mForceRefresh = false, mHidePopups = false, mRequestEmail = false, mRequestIdToken = false});
                this.mClient = val_3;
                if(val_3 == null)
            {
                goto label_9;
            }
            
            }
            
            val_4 = val_3;
            label_9:
            var val_3 = 0;
            val_3 = val_3 + 1;
            silent = silent;
            goto label_9;
        }
        public void Authenticate(UnityEngine.SocialPlatforms.ILocalUser unused, System.Action<bool> callback)
        {
            this.Authenticate(callback:  callback, silent:  false);
        }
        public void Authenticate(UnityEngine.SocialPlatforms.ILocalUser unused, System.Action<bool, string> callback)
        {
            this.Authenticate(callback:  callback, silent:  false);
        }
        public bool IsAuthenticated()
        {
            var val_2;
            if(this.mClient == null)
            {
                    return false;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.mClient;
        }
        public void SignOut()
        {
            var val_3;
            if(this.mClient != null)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                val_3 = this.mClient;
            }
            
            this.mLocalUser = new GooglePlayGames.PlayGamesLocalUser(plaf:  this);
        }
        public void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback)
        {
            var val_4;
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                callback.Invoke(obj:  null);
            }
        
        }
        public string GetUserId()
        {
            var val_4;
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                return "0";
            }
        
        }
        public string GetIdToken()
        {
            var val_2;
            if(this.mClient != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                val_2 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                return 0;
            }
        
        }
        public string GetServerAuthCode()
        {
            var val_3;
            var val_4;
            if(this.mClient == null)
            {
                    return 0;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = this.mClient;
            if((this.mClient & 1) == 0)
            {
                    return 0;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = this.mClient;
        }
        public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback)
        {
            object val_17;
            var val_18;
            var val_19;
            var val_20;
            GooglePlayGames.BasicApi.IPlayGamesClient val_21;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            object val_1 = null;
            val_17 = val_1;
            val_1 = new System.Object();
            if(null != 0)
            {
                    val_18 = val_17;
                typeof(PlayGamesPlatform.<GetAnotherServerAuthCode>c__AnonStorey2).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    val_18 = 16;
                mem[16] = callback;
            }
            
            typeof(PlayGamesPlatform.<GetAnotherServerAuthCode>c__AnonStorey2).__il2cppRuntimeField_18 = this;
            if(this.mClient == null)
            {
                goto label_16;
            }
            
            var val_16 = 0;
            val_19 = 1152921504938938376;
            val_16 = val_16 + 1;
            val_19 = 1152921504938938392;
            val_20 = this.mClient;
            val_21 = this.mClient;
            if((this.mClient & 1) == 0)
            {
                goto label_8;
            }
            
            var val_17 = 0;
            val_19 = 1152921504938938376;
            val_17 = val_17 + 1;
            val_19 = 1152921504938938392;
            val_23 = val_21;
            goto label_14;
            label_8:
            if((val_21 == null) || (reAuthenticateIfNeeded ^ 1 == true))
            {
                goto label_16;
            }
            
            System.Action<System.Boolean, System.String> val_5 = null;
            val_24 = val_5;
            val_25 = public System.Void System.Action<System.Boolean, System.String>::.ctor(object object, IntPtr method);
            val_5 = new System.Action<System.Boolean, System.String>(object:  val_17, method:  System.Void PlayGamesPlatform.<GetAnotherServerAuthCode>c__AnonStorey2::<>m__0(bool success, string msg));
            var val_18 = 0;
            val_19 = 1152921504938938376;
            val_18 = val_18 + 1;
            val_26 = val_21;
            goto label_20;
            label_16:
            GooglePlayGames.OurUtils.Logger.e(msg:  null);
            mem[16].Invoke(obj:  0);
            return;
            label_14:
            bool val_6 = reAuthenticateIfNeeded;
            val_21 = ???;
            val_24 = ???;
            val_17 = ???;
            val_18 = ???;
            label_20:
        }
        public string GetUserEmail()
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.mClient;
            goto x2;
        }
        public void GetPlayerStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
        {
            var val_4;
            var val_5;
            var val_6;
            if(this.mClient == null)
            {
                goto label_6;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 1;
            val_5 = this.mClient;
            if((this.mClient & 1) == 0)
            {
                goto label_6;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 11;
            val_6 = this.mClient;
            goto label_11;
            label_6:
            GooglePlayGames.OurUtils.Logger.e(msg:  null);
            callback.Invoke(arg1:  4, arg2:  new GooglePlayGames.BasicApi.PlayerStats());
            return;
            label_11:
        }
        public GooglePlayGames.BasicApi.Achievement GetAchievement(string achievementId)
        {
            var val_4;
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                return 0;
            }
        
        }
        public string GetUserDisplayName()
        {
            var val_4;
            var val_5;
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                val_5 = null;
                val_5 = null;
                return (string)System.String.Empty;
            }
        
        }
        public string GetUserImageUrl()
        {
            var val_4;
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                return 0;
            }
        
        }
        public void ReportProgress(string achievementID, double progress, System.Action<bool> callback)
        {
            double val_26;
            string val_27;
            double val_28;
            int val_29;
            var val_30;
            string val_31;
            var val_32;
            var val_33;
            string val_34;
            string val_35;
            var val_36;
            string val_37;
            string val_38;
            double val_39;
            double val_40;
            string val_41;
            string val_42;
            string val_43;
            var val_44;
            string val_45;
            var val_46;
            val_26 = progress;
            val_27 = achievementID;
            if(this.IsAuthenticated() == false)
            {
                goto label_1;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = "ReportProgress, ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_27;
            typeof(System.Object[]).__il2cppRuntimeField_30 = ", ";
            val_28 = val_26;
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_28;
            val_29 = 1152921504608284672;
            val_30 = 0;
            string val_3 = +0;
            val_31 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_31);
            string val_4 = this.MapId(id:  val_27);
            if(val_26 >= 0)
            {
                goto label_19;
            }
            
            GooglePlayGames.OurUtils.Logger.d(msg:  null);
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_32 = this.mClient;
            return;
            label_1:
            GooglePlayGames.OurUtils.Logger.e(msg:  null);
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  false);
            return;
            label_19:
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_30 = 13;
            val_33 = this.mClient;
            val_28 = this.mClient;
            if(val_28 == null)
            {
                goto label_36;
            }
            
            val_27 = 1152921504608497664;
            bool val_7 = val_28.IsIncremental;
            int val_8 = val_28.CurrentSteps;
            var val_10 = (val_7 != true) ? "INCREMENTAL" : "STANDARD";
            val_28 = val_28.TotalSteps;
            string val_11 = 0 + "Achievement is ";
            val_34 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_34);
            val_29 = val_29;
            if(val_7 == false)
            {
                goto label_41;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Current steps: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_8;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "/";
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_28;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            string val_12 = +0;
            val_35 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_35);
            val_36 = 0;
            string val_13 = 0 + "Progress " + val_26;
            val_37 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_37);
            if((val_26 >= 0f) && (val_26 <= 1))
            {
                    val_36 = 0;
                string val_14 = 0 + "Progress " + val_26;
                val_38 = null;
                GooglePlayGames.OurUtils.Logger.w(msg:  val_38);
            }
            
            double val_28 = 100;
            val_28 = val_26 / val_28;
            val_26 = val_28 * (double)val_28;
            if(val_26 >= 0f)
            {
                goto label_69;
            }
            
            if(val_26 != (-0.5))
            {
                goto label_70;
            }
            
            val_39 = val_26;
            val_40 = -1;
            goto label_71;
            label_36:
            val_27 = 1152921504608497664;
            string val_15 = 0 + "Unable to locate achievement ";
            val_41 = null;
            GooglePlayGames.OurUtils.Logger.w(msg:  val_41);
            GooglePlayGames.OurUtils.Logger.w(msg:  val_41);
            label_41:
            if(val_26 >= 100)
            {
                goto label_76;
            }
            
            string val_16 = 0 + "Progress " + val_26;
            val_42 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_42);
            goto label_112;
            label_76:
            string val_17 = 0 + "Progress " + val_26;
            val_43 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_43);
            val_27 = val_4;
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_44 = this.mClient;
            return;
            label_69:
            if(val_26 != 0.5)
            {
                goto label_91;
            }
            
            val_39 = val_26;
            val_40 = 1;
            label_71:
            val_40 = val_39 + val_40;
            var val_18 = (((long)val_39 & (4.94065645841247E-324)) != 0) ? (val_39) : (val_40);
            goto label_94;
            label_70:
            double val_20 = val_26 + (-0.5);
            goto label_94;
            label_91:
            double val_21 = val_26 + 0.5;
            label_94:
            val_29 = (int)val_26;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Target steps: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_29;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = ", cur steps:";
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_8;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            val_28 = +0;
            val_45 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_45);
            GooglePlayGames.OurUtils.Logger.d(msg:  0 + "Steps to increment: "("Steps to increment: "));
            val_27 = val_4;
            if(((val_29 - val_8) & 2147483648) == 0)
            {
                    var val_30 = 0;
                val_30 = val_30 + 1;
                val_46 = this.mClient;
                return;
            }
            
            label_112:
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  false);
        }
        public void RevealAchievement(string achievementID, System.Action<bool> callback)
        {
            string val_6;
            var val_7;
            if(this.IsAuthenticated() != false)
            {
                    string val_3 = 0 + "RevealAchievement: "("RevealAchievement: ");
                val_6 = null;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_6);
                string val_4 = this.MapId(id:  achievementID);
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_7 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  false);
                return;
            }
        
        }
        public void UnlockAchievement(string achievementID, System.Action<bool> callback)
        {
            string val_6;
            var val_7;
            if(this.IsAuthenticated() != false)
            {
                    string val_3 = 0 + "UnlockAchievement: "("UnlockAchievement: ");
                val_6 = null;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_6);
                string val_4 = this.MapId(id:  achievementID);
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_7 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  false);
                return;
            }
        
        }
        public void IncrementAchievement(string achievementID, int steps, System.Action<bool> callback)
        {
            var val_6;
            var val_7;
            string val_8;
            var val_9;
            val_7 = this;
            if(this.IsAuthenticated() != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = "IncrementAchievement: ";
                typeof(System.Object[]).__il2cppRuntimeField_28 = achievementID;
                typeof(System.Object[]).__il2cppRuntimeField_30 = ", steps ";
                typeof(System.Object[]).__il2cppRuntimeField_38 = steps;
                typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
                val_6 = +0;
                val_8 = null;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_8);
                val_7 = this.MapId(id:  achievementID);
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_9 = this.mClient;
                return;
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  null);
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  false);
        }
        public void SetStepsAtLeast(string achievementID, int steps, System.Action<bool> callback)
        {
            var val_6;
            var val_7;
            string val_8;
            var val_9;
            val_7 = this;
            if(this.IsAuthenticated() != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = "SetStepsAtLeast: ";
                typeof(System.Object[]).__il2cppRuntimeField_28 = achievementID;
                typeof(System.Object[]).__il2cppRuntimeField_30 = ", steps ";
                typeof(System.Object[]).__il2cppRuntimeField_38 = steps;
                typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
                val_6 = +0;
                val_8 = null;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_8);
                val_7 = this.MapId(id:  achievementID);
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_9 = this.mClient;
                return;
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  null);
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  false);
        }
        public void LoadAchievementDescriptions(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback)
        {
            IntPtr val_6;
            var val_7;
            typeof(PlayGamesPlatform.<LoadAchievementDescriptions>c__AnonStorey3).__il2cppRuntimeField_10 = callback;
            if(this.IsAuthenticated() != false)
            {
                    val_6 = System.Void PlayGamesPlatform.<LoadAchievementDescriptions>c__AnonStorey3::<>m__0(GooglePlayGames.BasicApi.Achievement[] ach);
                null = new System.Action<GooglePlayGames.BasicApi.Achievement[]>(object:  new System.Object(), method:  val_6);
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_6 = 14;
                val_7 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                if((typeof(PlayGamesPlatform.<LoadAchievementDescriptions>c__AnonStorey3).__il2cppRuntimeField_10) == 0)
            {
                    return;
            }
            
                typeof(PlayGamesPlatform.<LoadAchievementDescriptions>c__AnonStorey3).__il2cppRuntimeField_10.Invoke(obj:  0);
            }
        
        }
        public void LoadAchievements(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback)
        {
            IntPtr val_6;
            var val_7;
            typeof(PlayGamesPlatform.<LoadAchievements>c__AnonStorey4).__il2cppRuntimeField_10 = callback;
            if(this.IsAuthenticated() != false)
            {
                    val_6 = System.Void PlayGamesPlatform.<LoadAchievements>c__AnonStorey4::<>m__0(GooglePlayGames.BasicApi.Achievement[] ach);
                null = new System.Action<GooglePlayGames.BasicApi.Achievement[]>(object:  new System.Object(), method:  val_6);
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_6 = 14;
                val_7 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                typeof(PlayGamesPlatform.<LoadAchievements>c__AnonStorey4).__il2cppRuntimeField_10.Invoke(obj:  0);
            }
        
        }
        public UnityEngine.SocialPlatforms.IAchievement CreateAchievement()
        {
            return (UnityEngine.SocialPlatforms.IAchievement)new GooglePlayGames.PlayGamesAchievement();
        }
        public void ReportScore(long score, string board, System.Action<bool> callback)
        {
            var val_6;
            string val_7;
            string val_8;
            var val_9;
            val_7 = board;
            if(this.IsAuthenticated() != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = "ReportScore: score=";
                typeof(System.Object[]).__il2cppRuntimeField_28 = score;
                typeof(System.Object[]).__il2cppRuntimeField_30 = ", board=";
                typeof(System.Object[]).__il2cppRuntimeField_38 = val_7;
                val_6 = +0;
                val_8 = null;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_8);
                val_7 = this.MapId(id:  val_7);
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_9 = this.mClient;
                return;
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  null);
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  false);
        }
        public void ReportScore(long score, string board, string metadata, System.Action<bool> callback)
        {
            string val_6;
            string val_7;
            var val_8;
            val_6 = board;
            if(this.IsAuthenticated() != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = "ReportScore: score=";
                typeof(System.Object[]).__il2cppRuntimeField_28 = score;
                typeof(System.Object[]).__il2cppRuntimeField_30 = ", board=";
                typeof(System.Object[]).__il2cppRuntimeField_38 = val_6;
                typeof(System.Object[]).__il2cppRuntimeField_40 = " metadata=";
                typeof(System.Object[]).__il2cppRuntimeField_48 = metadata;
                string val_3 = +0;
                val_7 = null;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_7);
                string val_4 = this.MapId(id:  val_6);
                val_6 = this.mClient;
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_8 = val_6;
                return;
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  null);
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(obj:  false);
        }
        public void LoadScores(string leaderboardId, System.Action<UnityEngine.SocialPlatforms.IScore[]> callback)
        {
            var val_4;
            typeof(PlayGamesPlatform.<LoadScores>c__AnonStorey5).__il2cppRuntimeField_10 = callback;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = this.mClient;
            this.LoadScores(leaderboardId:  leaderboardId, start:  2, rowCount:  this.mClient, collection:  1, timeSpan:  3, callback:  new System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData>(object:  new System.Object(), method:  System.Void PlayGamesPlatform.<LoadScores>c__AnonStorey5::<>m__0(GooglePlayGames.BasicApi.LeaderboardScoreData scoreData)));
        }
        public void LoadScores(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            var val_5;
            if(this.IsAuthenticated() != false)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_5 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                callback.Invoke(obj:  new GooglePlayGames.BasicApi.LeaderboardScoreData(leaderboardId:  leaderboardId, status:  -3));
            }
        
        }
        public void LoadMoreScores(GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            var val_6;
            if(this.IsAuthenticated() != false)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                val_6 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                callback.Invoke(obj:  new GooglePlayGames.BasicApi.LeaderboardScoreData(leaderboardId:  token.LeaderboardId, status:  -3));
            }
        
        }
        public UnityEngine.SocialPlatforms.ILeaderboard CreateLeaderboard()
        {
            return (UnityEngine.SocialPlatforms.ILeaderboard)new GooglePlayGames.PlayGamesLeaderboard(id:  this.mDefaultLbUi);
        }
        public void ShowAchievementsUI()
        {
            this.ShowAchievementsUI(callback:  0);
        }
        public void ShowAchievementsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> callback)
        {
            var val_5;
            string val_6;
            var val_7;
            if(this.IsAuthenticated() != false)
            {
                    val_5 = callback;
                string val_3 = 0 + "ShowAchievementsUI callback is ";
                val_6 = null;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_6);
                var val_5 = 0;
                val_5 = val_5 + 1;
                val_5 = 19;
                val_7 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
            }
        
        }
        public void ShowLeaderboardUI()
        {
            GooglePlayGames.OurUtils.Logger.d(msg:  null);
            this.ShowLeaderboardUI(leaderboardId:  this.MapId(id:  this.mDefaultLbUi), span:  3, callback:  0);
        }
        public void ShowLeaderboardUI(string leaderboardId)
        {
            var val_3;
            var val_4;
            if(leaderboardId != null)
            {
                    val_3 = this.MapId(id:  leaderboardId);
            }
            else
            {
                    val_3 = 0;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = this.mClient;
        }
        public void ShowLeaderboardUI(string leaderboardId, System.Action<GooglePlayGames.BasicApi.UIStatus> callback)
        {
            this.ShowLeaderboardUI(leaderboardId:  leaderboardId, span:  3, callback:  callback);
        }
        public void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, System.Action<GooglePlayGames.BasicApi.UIStatus> callback)
        {
            string val_5;
            var val_6;
            if(this.IsAuthenticated() != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = "ShowLeaderboardUI, lbId=";
                typeof(System.Object[]).__il2cppRuntimeField_28 = leaderboardId;
                typeof(System.Object[]).__il2cppRuntimeField_30 = " callback is ";
                typeof(System.Object[]).__il2cppRuntimeField_38 = callback;
                string val_3 = +0;
                val_5 = null;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_5);
                var val_5 = 0;
                val_5 = val_5 + 1;
                val_6 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  -3);
            }
        
        }
        public void SetDefaultLeaderboardForUI(string lbid)
        {
            string val_3;
            string val_4;
            string val_1 = 0 + "SetDefaultLeaderboardForUI: "("SetDefaultLeaderboardForUI: ");
            val_3 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_3);
            if(lbid != null)
            {
                    string val_2 = this.MapId(id:  lbid);
            }
            else
            {
                    val_4 = 0;
            }
            
            this.mDefaultLbUi = val_4;
        }
        public void LoadFriends(UnityEngine.SocialPlatforms.ILocalUser user, System.Action<bool> callback)
        {
            var val_4;
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.mClient;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  null);
                if(callback == null)
            {
                    return;
            }
            
                callback.Invoke(obj:  false);
            }
        
        }
        public void LoadScores(UnityEngine.SocialPlatforms.ILeaderboard board, System.Action<bool> callback)
        {
            System.Action<System.Boolean> val_26;
            var val_27;
            var val_28;
            var val_29;
            IntPtr val_30;
            string val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            val_26 = callback;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_27 = val_1;
                val_28 = val_1;
                typeof(PlayGamesPlatform.<LoadScores>c__AnonStorey6).__il2cppRuntimeField_10 = board;
                typeof(PlayGamesPlatform.<LoadScores>c__AnonStorey6).__il2cppRuntimeField_18 = val_26;
            }
            else
            {
                    val_27 = 16;
                mem[16] = board;
                val_28 = 24;
                mem[24] = val_26;
            }
            
            typeof(PlayGamesPlatform.<LoadScores>c__AnonStorey6).__il2cppRuntimeField_20 = this;
            if(this.IsAuthenticated() == false)
            {
                goto label_3;
            }
            
            var val_21 = val_27;
            if((board + 258) == 0)
            {
                goto label_5;
            }
            
            var val_18 = board + 152;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_7:
            if(((board + 152 + 8) + -8) == null)
            {
                goto label_6;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (board + 258))
            {
                goto label_7;
            }
            
            label_5:
            val_29 = val_27;
            goto label_8;
            label_3:
            GooglePlayGames.OurUtils.Logger.e(msg:  null);
            if(val_28 == 0)
            {
                    return;
            }
            
            val_28.Invoke(obj:  false);
            return;
            label_6:
            var val_20 = val_18;
            val_20 = val_20 + 4;
            val_21 = val_21 + val_20;
            val_29 = val_21 + 272;
            label_8:
            UnityEngine.SocialPlatforms.ILeaderboard val_4 = val_27 + 7;
            var val_5 = (val_27 < 3) ? (val_4) : 0;
            if(val_5 > 9)
            {
                    return;
            }
            
            val_4 = val_5 & 65535;
            val_4 = 897 >> val_4;
            if((val_4 & 1) == 0)
            {
                    return;
            }
            
            if(mem[16] != 0)
            {
                
            }
            
            mem2[0] = 1;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "LoadScores, board=";
            typeof(System.Object[]).__il2cppRuntimeField_28 = mem[16];
            typeof(System.Object[]).__il2cppRuntimeField_30 = " callback is ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = mem[24];
            string val_9 = +0;
            val_31 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_31);
            val_26 = this.mClient;
            var val_25 = mem[16];
            if((board + 258) == 0)
            {
                goto label_41;
            }
            
            var val_22 = board + 152;
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_43:
            if(((board + 152 + 8) + -8) == null)
            {
                goto label_42;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < (board + 258))
            {
                goto label_43;
            }
            
            label_41:
            val_32 = mem[16];
            goto label_44;
            label_42:
            var val_24 = val_22;
            val_24 = val_24 + 1;
            val_25 = val_25 + val_24;
            val_32 = val_25 + 272;
            label_44:
            val_33 = mem[16];
            var val_29 = mem[16];
            if((board + 258) == 0)
            {
                goto label_47;
            }
            
            var val_26 = board + 152;
            var val_27 = 0;
            val_26 = val_26 + 8;
            label_49:
            if(((board + 152 + 8) + -8) == null)
            {
                goto label_48;
            }
            
            val_27 = val_27 + 1;
            val_26 = val_26 + 16;
            if(val_27 < (board + 258))
            {
                goto label_49;
            }
            
            label_47:
            val_34 = mem[16];
            goto label_50;
            label_48:
            var val_28 = val_26;
            val_28 = val_28 + 3;
            val_29 = val_29 + val_28;
            val_34 = val_29 + 272;
            label_50:
            UnityEngine.SocialPlatforms.ILeaderboard val_10 = mem[16] >> 32;
            if(val_10 < 1)
            {
                goto label_51;
            }
            
            var val_34 = mem[16];
            if((board + 258) == 0)
            {
                goto label_54;
            }
            
            var val_30 = board + 152;
            var val_31 = 0;
            val_30 = val_30 + 8;
            label_56:
            if(((board + 152 + 8) + -8) == null)
            {
                goto label_55;
            }
            
            val_31 = val_31 + 1;
            val_30 = val_30 + 16;
            if(val_31 < (board + 258))
            {
                goto label_56;
            }
            
            label_54:
            val_35 = mem[16];
            goto label_57;
            label_51:
            val_36 = ((val_10 < 1) ? 1 : 0) << 1;
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_37 = this.mClient;
            goto label_62;
            label_55:
            var val_33 = val_30;
            val_33 = val_33 + 3;
            val_34 = val_34 + val_33;
            val_35 = val_34 + 272;
            label_57:
            val_28 = mem[16] >> 32;
            val_36 = 2;
            goto label_63;
            label_62:
            val_28 = this.mClient;
            val_26 = (val_10 < 1) ? (val_26) : 0;
            val_33 = (val_10 < 1) ? (val_33) : 0;
            label_63:
            var val_38 = mem[16];
            if((board + 258) == 0)
            {
                goto label_66;
            }
            
            var val_35 = board + 152;
            var val_36 = 0;
            val_35 = val_35 + 8;
            label_68:
            if(((board + 152 + 8) + -8) == null)
            {
                goto label_67;
            }
            
            val_36 = val_36 + 1;
            val_35 = val_35 + 16;
            if(val_36 < (board + 258))
            {
                goto label_68;
            }
            
            label_66:
            val_38 = mem[16];
            goto label_69;
            label_67:
            var val_37 = val_35;
            val_37 = val_37 + 2;
            val_38 = val_38 + val_37;
            val_38 = val_38 + 272;
            label_69:
            val_30 = System.Void PlayGamesPlatform.<LoadScores>c__AnonStorey6::<>m__0(GooglePlayGames.BasicApi.LeaderboardScoreData scoreData);
            var val_15 = (mem[16] == 1) ? (1 + 1) : 1;
            System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> val_16 = new System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData>(object:  val_1, method:  val_30);
            var val_42 = val_26;
            if((val_10 < 0x1 ? this.mClient : 0 + 258) == 0)
            {
                goto label_71;
            }
            
            var val_39 = val_10 < 0x1 ? this.mClient : 0 + 152;
            var val_40 = 0;
            val_39 = val_39 + 8;
            label_73:
            if(((val_10 < 0x1 ? this.mClient : 0 + 152 + 8) + -8) == null)
            {
                goto label_72;
            }
            
            val_40 = val_40 + 1;
            val_39 = val_39 + 16;
            if(val_40 < (val_10 < 0x1 ? this.mClient : 0 + 258))
            {
                goto label_73;
            }
            
            label_71:
            val_39 = val_26;
            return;
            label_72:
            var val_41 = val_39;
            val_41 = val_41 + 21;
            val_42 = val_42 + val_41;
            val_39 = val_42 + 272;
            return;
            label_75:
            goto label_75;
        }
        public bool GetLoading(UnityEngine.SocialPlatforms.ILeaderboard board)
        {
            var val_2;
            if(board == null)
            {
                    return false;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = board;
            goto x2;
        }
        public void RegisterInvitationDelegate(GooglePlayGames.BasicApi.InvitationReceivedDelegate deleg)
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.mClient;
            goto x3;
        }
        internal void HandleLoadingScores(GooglePlayGames.PlayGamesLeaderboard board, GooglePlayGames.BasicApi.LeaderboardScoreData scoreData, System.Action<bool> callback)
        {
            System.Action<System.Boolean> val_10;
            GooglePlayGames.PlayGamesLeaderboard val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = callback;
            val_11 = board;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_12 = val_1;
                val_13 = val_1;
                typeof(PlayGamesPlatform.<HandleLoadingScores>c__AnonStorey7).__il2cppRuntimeField_10 = val_11;
                typeof(PlayGamesPlatform.<HandleLoadingScores>c__AnonStorey7).__il2cppRuntimeField_18 = val_10;
                PlayGamesPlatform.<HandleLoadingScores>c__AnonStorey7.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_8 = this;
            }
            else
            {
                    val_12 = 16;
                mem[16] = val_11;
                val_13 = 24;
                mem[24] = val_10;
                mem[32] = this;
                val_11 = mem[16];
            }
            
            GooglePlayGames.BasicApi.LeaderboardScoreData val_12 = scoreData;
            bool val_2 = val_11.SetFromData(data:  val_12);
            if(((val_2 != false) && (val_12.HasAllScores() != true)) && (scoreData.NextPageToken != null))
            {
                    var val_10 = mem[16].ScoreCount;
                val_10 = (board + 32) - val_10;
                GooglePlayGames.BasicApi.ScorePageToken val_7 = scoreData.NextPageToken;
                System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> val_8 = new System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData>(object:  val_1, method:  System.Void PlayGamesPlatform.<HandleLoadingScores>c__AnonStorey7::<>m__0(GooglePlayGames.BasicApi.LeaderboardScoreData nextScoreData));
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_14 = this.mClient;
            }
            else
            {
                    val_12 = val_2;
                val_13.Invoke(obj:  val_12);
            }
        
        }
        internal UnityEngine.SocialPlatforms.IUserProfile[] GetFriends()
        {
            GooglePlayGames.BasicApi.IPlayGamesClient val_8;
            var val_9;
            var val_10;
            var val_11;
            if(this.IsAuthenticated() != false)
            {
                    val_8 = this.mClient;
                val_10 = null;
                var val_7 = 0;
                val_7 = val_7 + 1;
                val_11 = val_8;
            }
            else
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  null);
                val_9 = 1152921505441590448;
                val_10 = 0;
                val_8 = ???;
                var val_8 = X10;
                val_8 = val_8 + 32;
                val_9 = val_9 + val_8;
                val_11 = val_9 + 272;
            }
        
        }
        private string MapId(string id)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_4;
            string val_5;
            string val_6;
            val_5 = id;
            if(val_5 != null)
            {
                    val_4 = this.mIdMap;
                if((val_4.ContainsKey(key:  val_5)) == false)
            {
                    return (string)val_5;
            }
            
                string val_3 = 0 + "Mapping alias " + val_5 + " to ID ";
                val_6 = null;
                GooglePlayGames.OurUtils.Logger.d(msg:  val_6);
                val_5 = this.mIdMap.Item[val_5];
                return (string)val_5;
            }
            
            val_5 = 0;
            return (string)val_5;
        }
        private static PlayGamesPlatform()
        {
        
        }
    
    }

}
