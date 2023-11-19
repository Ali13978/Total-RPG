using UnityEngine;

namespace GooglePlayGames.Native
{
    public class NativeClient : IPlayGamesClient
    {
        // Fields
        private readonly GooglePlayGames.IClientImpl clientImpl;
        private readonly object GameServicesLock;
        private readonly object AuthStateLock;
        private readonly GooglePlayGames.BasicApi.PlayGamesClientConfiguration mConfiguration;
        private GooglePlayGames.Native.PInvoke.GameServices mServices;
        private GooglePlayGames.Native.NativeTurnBasedMultiplayerClient mTurnBasedClient;
        private GooglePlayGames.Native.NativeRealtimeMultiplayerClient mRealTimeClient;
        private GooglePlayGames.BasicApi.SavedGame.ISavedGameClient mSavedGameClient;
        private GooglePlayGames.BasicApi.Events.IEventsClient mEventsClient;
        private GooglePlayGames.BasicApi.Video.IVideoClient mVideoClient;
        private GooglePlayGames.TokenClient mTokenClient;
        private System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, bool> mInvitationDelegate;
        private System.Collections.Generic.Dictionary<string, GooglePlayGames.BasicApi.Achievement> mAchievements;
        private GooglePlayGames.BasicApi.Multiplayer.Player mUser;
        private System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Player> mFriends;
        private System.Action<bool, string> mPendingAuthCallbacks;
        private GooglePlayGames.Native.NativeClient.AuthState mAuthState;
        private uint mAuthGeneration;
        private bool friendsLoading;
        private static System.Predicate<GooglePlayGames.BasicApi.Achievement> <>f__am$cache0;
        private static System.Predicate<GooglePlayGames.BasicApi.Achievement> <>f__am$cache1;
        
        // Methods
        internal NativeClient(GooglePlayGames.BasicApi.PlayGamesClientConfiguration configuration, GooglePlayGames.IClientImpl clientImpl)
        {
            var val_4;
            var val_5;
            GooglePlayGames.BasicApi.PlayGamesClientConfiguration val_6;
            this.GameServicesLock = new System.Object();
            this.AuthStateLock = new System.Object();
            GooglePlayGames.OurUtils.PlayGamesHelperObject.CreateObject();
            GooglePlayGames.BasicApi.PlayGamesClientConfiguration val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.PlayGamesClientConfiguration>(value:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = false, mRequestAuthCode = false, mForceRefresh = false, mHidePopups = false, mRequestEmail = false, mRequestIdToken = false});
            mem[1152921512045845592] = val_4;
            mem[1152921512045845576] = val_5;
            this.clientImpl = clientImpl;
            this.mConfiguration = val_6;
        }
        private GooglePlayGames.Native.PInvoke.GameServices GameServices()
        {
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            return (GooglePlayGames.Native.PInvoke.GameServices)this.mServices;
        }
        public void Authenticate(System.Action<bool, string> callback, bool silent)
        {
            bool val_5;
            var val_6;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_5 = val_1;
                typeof(NativeClient.<Authenticate>c__AnonStorey0).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    val_5 = true;
                mem[16] = callback;
            }
            
            typeof(NativeClient.<Authenticate>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            System.Threading.Monitor.Enter(obj:  0);
            if(this.mAuthState == 1)
            {
                    GooglePlayGames.Native.NativeClient.InvokeCallbackOnGameThread<System.Boolean, System.Object>(callback:  0, data:  val_5, msg:  1);
                System.Threading.Monitor.Exit(obj:  0);
                return;
            }
            
            System.Threading.Monitor.Exit(obj:  0);
            this.friendsLoading = false;
            this.InitializeTokenClient();
            UnityEngine.Debug.Log(message:  0);
            System.Action<System.Int32> val_2 = new System.Action<System.Int32>(object:  val_1, method:  System.Void NativeClient.<Authenticate>c__AnonStorey0::<>m__0(int result));
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = this.mTokenClient;
            bool val_4 = silent;
            goto mem[.ctor(object:  val_1, method:  System.Void NativeClient.<Authenticate>c__AnonStorey0::<>m__0(int result))];
        }
        private static System.Action<T> AsOnGameThreadCallback<T>(System.Action<T> callback)
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = __RuntimeMethodHiddenParam;
            if((X2 + 48) != 0)
            {
                    mem2[0] = val_1;
            }
            else
            {
                    mem[16] = val_1;
                val_1 = mem[16];
            }
            
            if(val_1 != 0)
            {
                    val_2 = mem[X2 + 48 + 40];
                val_2 = X2 + 48 + 40;
                val_3 = X2 + 48 + 24;
                return (System.Action<T>)val_3;
            }
            
            val_2 = mem[X2 + 48 + 16 + 8];
            val_2 = X2 + 48 + 16 + 8;
            val_3 = val_2;
            return (System.Action<T>)val_3;
        }
        private static void InvokeCallbackOnGameThread<T, S>(System.Action<T, S> callback, T data, S msg)
        {
            object val_2 = data;
            if((X4 + 48) != 0)
            {
                    mem2[0] = val_2;
                mem2[0] = msg;
                mem2[0] = __RuntimeMethodHiddenParam;
            }
            else
            {
                    mem[16] = val_2;
                mem[24] = msg;
                mem[32] = __RuntimeMethodHiddenParam;
                val_2 = mem[16];
            }
            
            if(val_2 == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  X4 + 48, method:  X4 + 48 + 16);
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
        }
        private static void InvokeCallbackOnGameThread<T>(System.Action<T> callback, T data)
        {
            object val_2 = data;
            if((X3 + 48) != 0)
            {
                    mem2[0] = val_2;
                mem2[0] = __RuntimeMethodHiddenParam;
            }
            else
            {
                    mem[16] = val_2;
                mem[24] = __RuntimeMethodHiddenParam;
                val_2 = mem[16];
            }
            
            if(val_2 == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  X3 + 48, method:  X3 + 48 + 16);
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
        }
        private void InitializeGameServices()
        {
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            System.Threading.Monitor.Enter(obj:  0);
            if(this.mServices != null)
            {
                goto label_1;
            }
            
            GooglePlayGames.Native.PInvoke.GameServicesBuilder val_1 = GooglePlayGames.Native.PInvoke.GameServicesBuilder.Create();
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_26 = this.clientImpl;
            this.RegisterInvitationDelegate(invitationDelegate:  this.mConfiguration.mEnableSavedGames.disabledSprite);
            GameServicesBuilder.AuthFinishedCallback val_4 = new GameServicesBuilder.AuthFinishedCallback(object:  this, method:  System.Void GooglePlayGames.Native.NativeClient::HandleAuthTransition(GooglePlayGames.Native.Cwrapper.Types.AuthOperation operation, GooglePlayGames.Native.Cwrapper.CommonErrorStatus.AuthStatus status));
            val_1.SetOnAuthFinishedCallback(callback:  null);
            System.Action<MultiplayerEvent, System.String, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> val_5 = new System.Action<MultiplayerEvent, System.String, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(object:  this, method:  System.Void GooglePlayGames.Native.NativeClient::<InitializeGameServices>m__1(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent eventType, string matchId, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch match));
            val_1.SetOnTurnBasedMatchEventCallback(callback:  null);
            System.Action<MultiplayerEvent, System.String, GooglePlayGames.Native.PInvoke.MultiplayerInvitation> val_6 = new System.Action<MultiplayerEvent, System.String, GooglePlayGames.Native.PInvoke.MultiplayerInvitation>(object:  this, method:  System.Void GooglePlayGames.Native.NativeClient::HandleInvitation(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent eventType, string invitationId, GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation));
            val_1.SetOnMultiplayerInvitationEventCallback(callback:  null);
            if(this.mConfiguration.mEnableSavedGames.EnableSavedGames != false)
            {
                    val_1.EnableSnapshots();
            }
            
            val_27 = 0;
            goto label_12;
            label_17:
            val_27 = 1;
            label_12:
            if(val_27 >= 0)
            {
                goto label_14;
            }
            
            val_1.AddOauthScope(scope:  this.mConfiguration.mInvitationDelegate);
            goto label_17;
            label_14:
            if((this.mConfiguration.mEnableSavedGames.StackBehaviourPush & 1) != 0)
            {
                    val_1.SetShowConnectingPopup(flag:  false);
            }
            
            UnityEngine.Debug.Log(message:  0);
            GooglePlayGames.Native.PInvoke.GameServices val_10 = val_1.Build(configRef:  this.clientImpl);
            this.mServices = val_10;
            GooglePlayGames.Native.PInvoke.EventManager val_11 = new GooglePlayGames.Native.PInvoke.EventManager(services:  val_10);
            GooglePlayGames.Native.NativeEventClient val_12 = new GooglePlayGames.Native.NativeEventClient(manager:  null);
            this.mEventsClient = null;
            GooglePlayGames.Native.PInvoke.VideoManager val_13 = new GooglePlayGames.Native.PInvoke.VideoManager(services:  this.mServices);
            GooglePlayGames.Native.NativeVideoClient val_14 = new GooglePlayGames.Native.NativeVideoClient(manager:  null);
            this.mVideoClient = null;
            GooglePlayGames.Native.PInvoke.TurnBasedManager val_15 = new GooglePlayGames.Native.PInvoke.TurnBasedManager(services:  this.mServices);
            GooglePlayGames.Native.NativeTurnBasedMultiplayerClient val_16 = new GooglePlayGames.Native.NativeTurnBasedMultiplayerClient(nativeClient:  this, manager:  null);
            this.mTurnBasedClient = null;
            RegisterMatchDelegate(del:  this.mConfiguration.mEnableSavedGames.Payload);
            GooglePlayGames.Native.PInvoke.RealtimeManager val_18 = new GooglePlayGames.Native.PInvoke.RealtimeManager(gameServices:  this.mServices);
            GooglePlayGames.Native.NativeRealtimeMultiplayerClient val_19 = new GooglePlayGames.Native.NativeRealtimeMultiplayerClient(nativeClient:  this, manager:  null);
            this.mRealTimeClient = null;
            if(this.mConfiguration.mEnableSavedGames.EnableSavedGames != false)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager val_21 = new GooglePlayGames.Native.PInvoke.SnapshotManager(services:  this.mServices);
                GooglePlayGames.Native.NativeSavedGameClient val_22 = new GooglePlayGames.Native.NativeSavedGameClient(manager:  null);
                this.mSavedGameClient = null;
            }
            else
            {
                    GooglePlayGames.Native.UnsupportedSavedGamesClient val_23 = new GooglePlayGames.Native.UnsupportedSavedGamesClient(message:  "You must enable saved games before it can be used. See PlayGamesClientConfiguration.Builder.EnableSavedGames.");
                this.mSavedGameClient = null;
            }
            
            this.InitializeTokenClient();
            val_28 = 0;
            val_29 = 473;
            if(this.clientImpl != null)
            {
                    var val_27 = 0;
                val_27 = val_27 + 1;
                val_31 = this.clientImpl;
            }
            
            val_30 = 491;
            if((473 != 473) && (val_28 != 0))
            {
                    val_28 = 0;
                val_30 = 491;
            }
            
            if(val_1 != null)
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_32 = val_1;
            }
            
            if((491 == 491) || (val_28 == 0))
            {
                goto label_43;
            }
            
            label_1:
            val_28 = 0;
            label_43:
            System.Threading.Monitor.Exit(obj:  0);
            if(503 == 503)
            {
                    return;
            }
            
            if(val_28 == 0)
            {
                    return;
            }
        
        }
        private void InitializeTokenClient()
        {
            GooglePlayGames.TokenClient val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            val_26 = this;
            if(this.mTokenClient != null)
            {
                    return;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_27 = this.clientImpl;
            val_28 = 24708448;
            this.mTokenClient = this.clientImpl;
            if(GooglePlayGames.GameInfo.WebClientIdInitialized() != true)
            {
                    if(((this.mConfiguration.mEnableSavedGames.Size & 1) & 1) == 0)
            {
                    if(this.mConfiguration.mEnableSavedGames.EnableSavedGames == false)
            {
                goto label_9;
            }
            
            }
            
                val_28 = 0;
                GooglePlayGames.OurUtils.Logger.e(msg:  0);
            }
            
            label_9:
            val_29 = null;
            val_29 = null;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_28 = 8;
            val_30 = this.mTokenClient;
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_31 = this.mTokenClient;
            bool val_10 = this.mConfiguration.mEnableSavedGames.EnableSavedGames;
            val_32 = 0;
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_32 = 6;
            val_33 = this.mTokenClient;
            System.Reflection.Emit.StackBehaviour val_13 = this.mConfiguration.mEnableSavedGames.StackBehaviourPop & 1;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_34 = 7;
            val_35 = this.mTokenClient;
            val_36 = mem[val_14 + 8];
            val_36 = val_14 + 8;
            int val_16 = this.mConfiguration.mEnableSavedGames.Size & 1;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_36 = 11;
            val_37 = this.mTokenClient;
            System.Reflection.Emit.StackBehaviour val_19 = this.mConfiguration.mEnableSavedGames.StackBehaviourPush & 1;
            val_39 = 1152921505019217056;
            typeof(System.String[]).__il2cppRuntimeField_20 = "https://www.googleapis.com/auth/games_lite";
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_38 = 10;
            val_40 = this.mTokenClient;
            if(this.mConfiguration.mEnableSavedGames.EnableSavedGames != false)
            {
                    val_39 = "https://www.googleapis.com/auth/drive.appdata";
                typeof(System.String[]).__il2cppRuntimeField_20 = val_39;
                var val_33 = 0;
                val_33 = val_33 + 1;
                val_42 = 10;
                val_43 = this.mTokenClient;
            }
            
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_44 = 10;
            val_45 = this.mTokenClient;
            val_26 = this.mTokenClient;
            long val_24 = this.mConfiguration.mEnableSavedGames.LocalClientId;
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_46 = 9;
            val_47 = val_26;
        }
        internal void HandleInvitation(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent eventType, string invitationId, GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
        {
            var val_7;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_7 = val_1;
                typeof(NativeClient.<HandleInvitation>c__AnonStorey4).__il2cppRuntimeField_10 = this.mInvitationDelegate;
            }
            else
            {
                    val_7 = 16;
                mem[16] = this.mInvitationDelegate;
            }
            
            if(val_7 == 0)
            {
                goto label_3;
            }
            
            if(eventType != 3)
            {
                goto label_4;
            }
            
            string val_2 = 0 + "Ignoring REMOVED for invitation ";
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            return;
            label_3:
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Received ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = eventType;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " for invitation ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = invitationId;
            typeof(System.Object[]).__il2cppRuntimeField_40 = " but no handler was registered.";
            string val_3 = +0;
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            return;
            label_4:
            typeof(NativeClient.<HandleInvitation>c__AnonStorey4).__il2cppRuntimeField_20 = (eventType == 2) ? 1 : 0;
            typeof(NativeClient.<HandleInvitation>c__AnonStorey4).__il2cppRuntimeField_18 = invitation.AsInvitation();
            System.Action val_6 = new System.Action(object:  val_1, method:  System.Void NativeClient.<HandleInvitation>c__AnonStorey4::<>m__0());
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
        }
        public string GetUserEmail()
        {
            var val_4;
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.mTokenClient;
            }
            else
            {
                    UnityEngine.Debug.Log(message:  0);
                return 0;
            }
        
        }
        public string GetIdToken()
        {
            var val_4;
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.mTokenClient;
            }
            else
            {
                    UnityEngine.Debug.Log(message:  0);
                return 0;
            }
        
        }
        public string GetServerAuthCode()
        {
            var val_4;
            if(this.IsAuthenticated() != false)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.mTokenClient;
            }
            else
            {
                    UnityEngine.Debug.Log(message:  0);
                return 0;
            }
        
        }
        public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback)
        {
            var val_3;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = this.mTokenClient;
            bool val_2 = reAuthenticateIfNeeded;
            goto x4;
        }
        public bool IsAuthenticated()
        {
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            return (bool)(this.mAuthState == 1) ? 1 : 0;
        }
        public void LoadFriends(System.Action<bool> callback)
        {
            IntPtr val_7;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    typeof(NativeClient.<LoadFriends>c__AnonStorey5).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    mem[16] = callback;
            }
            
            typeof(NativeClient.<LoadFriends>c__AnonStorey5).__il2cppRuntimeField_18 = this;
            if(this.IsAuthenticated() == false)
            {
                goto label_3;
            }
            
            if(this.mFriends == null)
            {
                goto label_4;
            }
            
            val_7 = 1152921512048010736;
            goto label_5;
            label_3:
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            val_7 = 1152921512048011920;
            label_5:
            System.Action val_4 = new System.Action(object:  val_1, method:  val_7);
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
            return;
            label_4:
            this.mServices.PlayerManager().FetchFriends(callback:  new System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Player>>(object:  val_1, method:  System.Void NativeClient.<LoadFriends>c__AnonStorey5::<>m__2(GooglePlayGames.BasicApi.ResponseStatus status, System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Player> players)));
        }
        public UnityEngine.SocialPlatforms.IUserProfile[] GetFriends()
        {
            System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Player> val_3;
            var val_4;
            if((this.mFriends == null) && (this.friendsLoading != true))
            {
                    GooglePlayGames.OurUtils.Logger.w(msg:  0);
                this.friendsLoading = true;
                this.LoadFriends(callback:  new System.Action<System.Boolean>(object:  this, method:  System.Void GooglePlayGames.Native.NativeClient::<GetFriends>m__2(bool ok)));
            }
            
            if(this.mFriends != null)
            {
                    val_3 = this.mFriends;
                T[] val_2 = val_3.ToArray();
                return (UnityEngine.SocialPlatforms.IUserProfile[])val_4;
            }
            
            val_3 = null;
            val_4 = val_3;
            return (UnityEngine.SocialPlatforms.IUserProfile[])val_4;
        }
        private void PopulateAchievements(uint authGeneration, GooglePlayGames.Native.PInvoke.AchievementManager.FetchAllResponse response)
        {
            System.Collections.Generic.Dictionary<System.String, GooglePlayGames.BasicApi.Achievement> val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            object val_22;
            var val_23;
            if(this.mAuthGeneration != authGeneration)
            {
                goto label_1;
            }
            
            ResponseStatus val_1 = response.Status();
            string val_2 = 0 + "Populating Achievements, status = "("Populating Achievements, status = ");
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            System.Threading.Monitor.Enter(obj:  0);
            if(response.Status() != 1)
            {
                    if(response.Status() != 2)
            {
                goto label_10;
            }
            
            }
            
            val_16 = null;
            val_16 = new System.Collections.Generic.Dictionary<System.String, GooglePlayGames.BasicApi.Achievement>();
            System.Collections.Generic.IEnumerator<GooglePlayGames.Native.PInvoke.NativeAchievement> val_6 = response.GetEnumerator();
            val_17 = 0;
            goto label_28;
            label_36:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_18 = val_6;
            set_Item(key:  val_6.Id(), value:  val_6.AsAchievement());
            if(val_6 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_19 = val_6;
            }
            
            val_17 = val_17;
            if(213 != 213)
            {
                    val_17 = 0;
                if(val_17 != 0)
            {
                    val_17 = 0;
            }
            
            }
            
            label_28:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_20 = val_6;
            if(((val_6 & 1) & 1) != 0)
            {
                goto label_36;
            }
            
            val_21 = 1152921504942256128;
            val_22 = this.AuthStateLock;
            goto label_37;
            label_1:
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            return;
            label_37:
            if(val_6 == null)
            {
                goto label_41;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_23 = val_6;
            goto label_45;
            label_10:
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            val_16 = this.mPendingAuthCallbacks;
            this.mPendingAuthCallbacks = 0;
            if(val_16 != null)
            {
                    GooglePlayGames.Native.NativeClient.InvokeCallbackOnGameThread<System.Boolean, System.Object>(callback:  0, data:  val_16, msg:  0);
            }
            
            this.SignOut();
            System.Threading.Monitor.Exit(obj:  0);
            return;
            label_45:
            label_41:
            if(213 == 245)
            {
                
            }
            
            string val_15 = 0 + "Found " + Count;
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            this.mAchievements = val_16;
            System.Threading.Monitor.Exit(obj:  0);
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            this.MaybeFinishAuthentication();
        }
        private void MaybeFinishAuthentication()
        {
            System.Threading.Monitor.Enter(obj:  0);
            if((this.mUser != null) && (this.mAchievements != null))
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  0);
                this.mPendingAuthCallbacks = 0;
                this.mAuthState = 1;
                System.Threading.Monitor.Exit(obj:  0);
                if(this.mPendingAuthCallbacks == null)
            {
                    return;
            }
            
                string val_1 = 0 + "Invoking Callbacks: "("Invoking Callbacks: ");
                GooglePlayGames.OurUtils.Logger.d(msg:  0);
                GooglePlayGames.Native.NativeClient.InvokeCallbackOnGameThread<System.Boolean, System.Object>(callback:  0, data:  this.mPendingAuthCallbacks, msg:  1);
                return;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Auth not finished. User=";
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.mUser;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " achievements=";
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.mAchievements;
            string val_2 = +0;
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            System.Threading.Monitor.Exit(obj:  0);
        }
        private void PopulateUser(uint authGeneration, GooglePlayGames.Native.PInvoke.PlayerManager.FetchSelfResponse response)
        {
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            if(this.mAuthGeneration == authGeneration)
            {
                    System.Threading.Monitor.Enter(obj:  0);
                if(response.Status() != 1)
            {
                    if(response.Status() != 2)
            {
                goto label_7;
            }
            
            }
            
                this.mUser = response.Self().AsPlayer();
                this.mFriends = 0;
                System.Threading.Monitor.Exit(obj:  0);
                string val_5 = 0 + "Found User: "("Found User: ");
                GooglePlayGames.OurUtils.Logger.d(msg:  0);
                GooglePlayGames.OurUtils.Logger.d(msg:  0);
                this.MaybeFinishAuthentication();
                return;
            }
            
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            return;
            label_7:
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            this.mPendingAuthCallbacks = 0;
            if(this.mPendingAuthCallbacks != null)
            {
                    GooglePlayGames.Native.NativeClient.InvokeCallbackOnGameThread<System.Boolean, System.Object>(callback:  0, data:  this.mPendingAuthCallbacks, msg:  0);
            }
            
            this.SignOut();
            System.Threading.Monitor.Exit(obj:  0);
        }
        private void HandleAuthTransition(GooglePlayGames.Native.Cwrapper.Types.AuthOperation operation, GooglePlayGames.Native.Cwrapper.CommonErrorStatus.AuthStatus status)
        {
            AuthOperation val_9;
            GooglePlayGames.Native.NativeClient val_10;
            IntPtr val_11;
            val_9 = operation;
            val_10 = this;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Starting Auth Transition. Op: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_9;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " status: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = status;
            string val_1 = +0;
            val_11 = 1152921504942256128;
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            System.Threading.Monitor.Enter(obj:  0);
            if(val_9 == 2)
            {
                goto label_18;
            }
            
            if(val_9 != 1)
            {
                goto label_19;
            }
            
            if(status != 1)
            {
                goto label_20;
            }
            
            val_9 = null;
            val_9 = new System.Object();
            typeof(NativeClient.<HandleAuthTransition>c__AnonStorey6).__il2cppRuntimeField_18 = val_10;
            typeof(NativeClient.<HandleAuthTransition>c__AnonStorey6).__il2cppRuntimeField_10 = this.mAuthGeneration;
            System.Action<FetchAllResponse> val_4 = new System.Action<FetchAllResponse>(object:  val_9, method:  System.Void NativeClient.<HandleAuthTransition>c__AnonStorey6::<>m__0(GooglePlayGames.Native.PInvoke.AchievementManager.FetchAllResponse results));
            this.mServices.AchievementManager().FetchAll(callback:  null);
            val_10 = this.mServices.PlayerManager();
            val_11 = System.Void NativeClient.<HandleAuthTransition>c__AnonStorey6::<>m__1(GooglePlayGames.Native.PInvoke.PlayerManager.FetchSelfResponse results);
            System.Action<FetchSelfResponse> val_6 = new System.Action<FetchSelfResponse>(object:  val_9, method:  val_11);
            val_10.FetchSelf(callback:  null);
            goto label_32;
            label_18:
            this.ToUnauthenticated();
            goto label_32;
            label_19:
            val_10 = 0 + "Unknown AuthOperation ";
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            goto label_32;
            label_20:
            this.mAuthState = 0;
            string val_8 = 0 + "AuthState == "("AuthState == ") + 0;
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            val_9 = this.mPendingAuthCallbacks;
            this.mPendingAuthCallbacks = 0;
            GooglePlayGames.Native.NativeClient.InvokeCallbackOnGameThread<System.Boolean, System.Object>(callback:  0, data:  val_9, msg:  0);
            label_32:
            System.Threading.Monitor.Exit(obj:  0);
        }
        private void ToUnauthenticated()
        {
            var val_3;
            var val_4;
            val_3 = 0;
            System.Threading.Monitor.Enter(obj:  0);
            this.mUser = 0;
            this.mFriends = 0;
            this.mAchievements = 0;
            this.mAuthState = 0;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 1;
            val_4 = this.clientImpl;
            this.mTokenClient = this.clientImpl;
            this.mAuthGeneration = this.mAuthGeneration + 1;
            System.Threading.Monitor.Exit(obj:  0);
        }
        public void SignOut()
        {
            var val_2;
            this.ToUnauthenticated();
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            if(this.mServices == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.mTokenClient;
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            this.mServices.SignOut();
        }
        public string GetUserId()
        {
            if(this.mUser == null)
            {
                    return 0;
            }
            
            if(this.mUser != null)
            {
                    return this.mUser.id;
            }
            
            return this.mUser.id;
        }
        public string GetUserDisplayName()
        {
            if(this.mUser == null)
            {
                    return 0;
            }
            
            if(this.mUser != null)
            {
                    return this.mUser.userName;
            }
            
            return this.mUser.userName;
        }
        public string GetUserImageUrl()
        {
            if(this.mUser == null)
            {
                    return 0;
            }
            
            if(this.mUser != null)
            {
                    return this.mUser.AvatarURL;
            }
            
            return this.mUser.AvatarURL;
        }
        public void SetGravityForPopups(GooglePlayGames.BasicApi.Gravity gravity)
        {
            if(null != 0)
            {
                    typeof(NativeClient.<SetGravityForPopups>c__AnonStorey7).__il2cppRuntimeField_10 = gravity;
            }
            else
            {
                    mem[16] = gravity;
            }
            
            typeof(NativeClient.<SetGravityForPopups>c__AnonStorey7).__il2cppRuntimeField_18 = this;
            System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void NativeClient.<SetGravityForPopups>c__AnonStorey7::<>m__0());
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
        }
        public void GetPlayerStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
        {
            if(null != 0)
            {
                    typeof(NativeClient.<GetPlayerStats>c__AnonStorey8).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    mem[16] = callback;
            }
            
            typeof(NativeClient.<GetPlayerStats>c__AnonStorey8).__il2cppRuntimeField_18 = this;
            System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void NativeClient.<GetPlayerStats>c__AnonStorey8::<>m__0());
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
        }
        public void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback)
        {
            typeof(NativeClient.<LoadUsers>c__AnonStorey9).__il2cppRuntimeField_10 = callback;
            this.mServices.PlayerManager().FetchList(userIds:  userIds, callback:  new System.Action<GooglePlayGames.Native.PInvoke.NativePlayer[]>(object:  new System.Object(), method:  System.Void NativeClient.<LoadUsers>c__AnonStorey9::<>m__0(GooglePlayGames.Native.PInvoke.NativePlayer[] nativeUsers)));
        }
        public GooglePlayGames.BasicApi.Achievement GetAchievement(string achId)
        {
            System.Collections.Generic.Dictionary<System.String, GooglePlayGames.BasicApi.Achievement> val_3;
            var val_4;
            val_3 = this.mAchievements;
            if(val_3 != null)
            {
                    val_3 = this.mAchievements;
                if((val_3.ContainsKey(key:  achId)) != false)
            {
                    GooglePlayGames.BasicApi.Achievement val_2 = this.mAchievements.Item[achId];
                return (GooglePlayGames.BasicApi.Achievement)val_4;
            }
            
            }
            
            val_4 = 0;
            return (GooglePlayGames.BasicApi.Achievement)val_4;
        }
        public void LoadAchievements(System.Action<GooglePlayGames.BasicApi.Achievement[]> callback)
        {
            typeof(NativeClient.<LoadAchievements>c__AnonStoreyB).__il2cppRuntimeField_10 = callback;
            int val_2 = this.mAchievements.Count;
            typeof(NativeClient.<LoadAchievements>c__AnonStoreyB).__il2cppRuntimeField_18 = null;
            this.mAchievements.Values.CopyTo(array:  typeof(NativeClient.<LoadAchievements>c__AnonStoreyB).__il2cppRuntimeField_18, index:  0);
            System.Action val_4 = new System.Action(object:  new System.Object(), method:  System.Void NativeClient.<LoadAchievements>c__AnonStoreyB::<>m__0());
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
        }
        public void UnlockAchievement(string achId, System.Action<bool> callback)
        {
            string val_4;
            System.Predicate<GooglePlayGames.BasicApi.Achievement> val_5;
            val_4 = achId;
            if(null != 0)
            {
                    typeof(NativeClient.<UnlockAchievement>c__AnonStoreyC).__il2cppRuntimeField_10 = val_4;
                typeof(NativeClient.<UnlockAchievement>c__AnonStoreyC).__il2cppRuntimeField_18 = this;
            }
            else
            {
                    mem[16] = val_4;
                mem[24] = this;
                val_4 = mem[16];
            }
            
            val_5 = GooglePlayGames.Native.NativeClient.<>f__am$cache0;
            if(val_5 == null)
            {
                    GooglePlayGames.Native.NativeClient.<>f__am$cache0 = new System.Predicate<GooglePlayGames.BasicApi.Achievement>(object:  0, method:  static System.Boolean GooglePlayGames.Native.NativeClient::<UnlockAchievement>m__3(GooglePlayGames.BasicApi.Achievement a));
                val_5 = GooglePlayGames.Native.NativeClient.<>f__am$cache0;
            }
            
            this.UpdateAchievement(updateType:  "Unlock", achId:  val_4, callback:  callback, alreadyDone:  val_5, updateAchievment:  new System.Action<GooglePlayGames.BasicApi.Achievement>(object:  new System.Object(), method:  System.Void NativeClient.<UnlockAchievement>c__AnonStoreyC::<>m__0(GooglePlayGames.BasicApi.Achievement a)));
        }
        public void RevealAchievement(string achId, System.Action<bool> callback)
        {
            string val_4;
            System.Predicate<GooglePlayGames.BasicApi.Achievement> val_5;
            val_4 = achId;
            if(null != 0)
            {
                    typeof(NativeClient.<RevealAchievement>c__AnonStoreyD).__il2cppRuntimeField_10 = val_4;
                typeof(NativeClient.<RevealAchievement>c__AnonStoreyD).__il2cppRuntimeField_18 = this;
            }
            else
            {
                    mem[16] = val_4;
                mem[24] = this;
                val_4 = mem[16];
            }
            
            val_5 = GooglePlayGames.Native.NativeClient.<>f__am$cache1;
            if(val_5 == null)
            {
                    GooglePlayGames.Native.NativeClient.<>f__am$cache1 = new System.Predicate<GooglePlayGames.BasicApi.Achievement>(object:  0, method:  static System.Boolean GooglePlayGames.Native.NativeClient::<RevealAchievement>m__4(GooglePlayGames.BasicApi.Achievement a));
                val_5 = GooglePlayGames.Native.NativeClient.<>f__am$cache1;
            }
            
            this.UpdateAchievement(updateType:  "Reveal", achId:  val_4, callback:  callback, alreadyDone:  val_5, updateAchievment:  new System.Action<GooglePlayGames.BasicApi.Achievement>(object:  new System.Object(), method:  System.Void NativeClient.<RevealAchievement>c__AnonStoreyD::<>m__0(GooglePlayGames.BasicApi.Achievement a)));
        }
        private void UpdateAchievement(string updateType, string achId, System.Action<bool> callback, System.Predicate<GooglePlayGames.BasicApi.Achievement> alreadyDone, System.Action<GooglePlayGames.BasicApi.Achievement> updateAchievment)
        {
            string val_14;
            string val_15;
            GooglePlayGames.Native.NativeClient val_16;
            var val_17;
            var val_18;
            System.Action<T> val_19;
            var val_20;
            var val_21;
            val_14 = alreadyDone;
            val_15 = achId;
            val_16 = this;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_17 = val_1;
                val_18 = val_1;
                typeof(NativeClient.<UpdateAchievement>c__AnonStoreyE).__il2cppRuntimeField_10 = val_15;
                typeof(NativeClient.<UpdateAchievement>c__AnonStoreyE).__il2cppRuntimeField_18 = callback;
                NativeClient.<UpdateAchievement>c__AnonStoreyE.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_8 = val_16;
                NativeClient.<UpdateAchievement>c__AnonStoreyE.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = GooglePlayGames.Native.NativeClient.AsOnGameThreadCallback<System.Boolean>(callback:  0);
            }
            else
            {
                    val_17 = 16;
                mem[16] = val_15;
                val_18 = 24;
                mem[24] = callback;
                mem[32] = val_16;
                mem[24] = GooglePlayGames.Native.NativeClient.AsOnGameThreadCallback<System.Boolean>(callback:  0);
            }
            
            GooglePlayGames.BasicApi.IPlayGamesClient val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            this.InitializeGameServices();
            GooglePlayGames.BasicApi.Achievement val_5 = this.GetAchievement(achId:  mem[16]);
            if(val_5 == null)
            {
                goto label_4;
            }
            
            val_15 = val_14.Invoke(obj:  val_5);
            val_14 = mem[16];
            if(val_15 == false)
            {
                goto label_7;
            }
            
            string val_9 = 0 + "Did not need to perform " + updateType + ": on achievement "(": on achievement ");
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            val_20 = 1;
            val_21 = public System.Void System.Action<System.Boolean>::Invoke(System.Boolean obj);
            goto label_14;
            label_4:
            val_16 = mem[16];
            string val_10 = 0 + "Could not " + updateType + ", no achievement with ID ";
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            val_19 = mem[24];
            val_20 = 0;
            val_21 = public System.Void System.Action<System.Boolean>::Invoke(System.Boolean obj);
            label_14:
            val_19.Invoke(obj:  false);
            return;
            label_7:
            string val_11 = 0 + "Performing " + updateType + " on ";
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            updateAchievment.Invoke(obj:  val_5);
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            this.mServices.AchievementManager().Fetch(achId:  mem[16], callback:  new System.Action<FetchResponse>(object:  val_1, method:  System.Void NativeClient.<UpdateAchievement>c__AnonStoreyE::<>m__0(GooglePlayGames.Native.PInvoke.AchievementManager.FetchResponse rsp)));
        }
        public void IncrementAchievement(string achId, int steps, System.Action<bool> callback)
        {
            string val_15;
            var val_16;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_15 = val_1;
                val_16 = val_1;
                typeof(NativeClient.<IncrementAchievement>c__AnonStoreyF).__il2cppRuntimeField_10 = achId;
                typeof(NativeClient.<IncrementAchievement>c__AnonStoreyF).__il2cppRuntimeField_18 = callback;
                NativeClient.<IncrementAchievement>c__AnonStoreyF.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_8 = this;
                GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
                NativeClient.<IncrementAchievement>c__AnonStoreyF.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = GooglePlayGames.Native.NativeClient.AsOnGameThreadCallback<System.Boolean>(callback:  0);
                this.InitializeGameServices();
            }
            else
            {
                    val_15 = 16;
                mem[16] = achId;
                val_16 = 24;
                mem[24] = callback;
                mem[32] = this;
                GooglePlayGames.BasicApi.IPlayGamesClient val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
                mem[24] = GooglePlayGames.Native.NativeClient.AsOnGameThreadCallback<System.Boolean>(callback:  0);
                this.InitializeGameServices();
            }
            
            GooglePlayGames.BasicApi.Achievement val_6 = this.GetAchievement(achId:  val_15);
            if(val_6 == null)
            {
                goto label_3;
            }
            
            if(val_6.IsIncremental == false)
            {
                goto label_4;
            }
            
            if((steps & 2147483648) != 0)
            {
                goto label_27;
            }
            
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            this.mServices.AchievementManager().Increment(achievementId:  mem[16], numSteps:  System.Convert.ToUInt32(value:  0));
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            this.mServices.AchievementManager().Fetch(achId:  mem[16], callback:  new System.Action<FetchResponse>(object:  val_1, method:  System.Void NativeClient.<IncrementAchievement>c__AnonStoreyF::<>m__0(GooglePlayGames.Native.PInvoke.AchievementManager.FetchResponse rsp)));
            return;
            label_3:
            string val_13 = 0 + "Could not increment, no achievement with ID ";
            goto label_17;
            label_4:
            string val_14 = 0 + "Could not increment, achievement with ID " + mem[16];
            label_17:
            label_27:
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            val_16.Invoke(obj:  false);
        }
        public void SetStepsAtLeast(string achId, int steps, System.Action<bool> callback)
        {
            string val_15;
            var val_16;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_15 = val_1;
                val_16 = val_1;
                typeof(NativeClient.<SetStepsAtLeast>c__AnonStorey10).__il2cppRuntimeField_10 = achId;
                typeof(NativeClient.<SetStepsAtLeast>c__AnonStorey10).__il2cppRuntimeField_18 = callback;
                NativeClient.<SetStepsAtLeast>c__AnonStorey10.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_8 = this;
                GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
                NativeClient.<SetStepsAtLeast>c__AnonStorey10.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = GooglePlayGames.Native.NativeClient.AsOnGameThreadCallback<System.Boolean>(callback:  0);
                this.InitializeGameServices();
            }
            else
            {
                    val_15 = 16;
                mem[16] = achId;
                val_16 = 24;
                mem[24] = callback;
                mem[32] = this;
                GooglePlayGames.BasicApi.IPlayGamesClient val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
                mem[24] = GooglePlayGames.Native.NativeClient.AsOnGameThreadCallback<System.Boolean>(callback:  0);
                this.InitializeGameServices();
            }
            
            GooglePlayGames.BasicApi.Achievement val_6 = this.GetAchievement(achId:  val_15);
            if(val_6 == null)
            {
                goto label_3;
            }
            
            if(val_6.IsIncremental == false)
            {
                goto label_4;
            }
            
            if((steps & 2147483648) != 0)
            {
                goto label_27;
            }
            
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            this.mServices.AchievementManager().SetStepsAtLeast(achivementId:  mem[16], numSteps:  System.Convert.ToUInt32(value:  0));
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            this.mServices.AchievementManager().Fetch(achId:  mem[16], callback:  new System.Action<FetchResponse>(object:  val_1, method:  System.Void NativeClient.<SetStepsAtLeast>c__AnonStorey10::<>m__0(GooglePlayGames.Native.PInvoke.AchievementManager.FetchResponse rsp)));
            return;
            label_3:
            string val_13 = 0 + "Could not increment, no achievement with ID ";
            goto label_17;
            label_4:
            string val_14 = 0 + "Could not increment, achievement with ID " + mem[16];
            label_17:
            label_27:
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            val_16.Invoke(obj:  false);
        }
        public void ShowAchievementsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> cb)
        {
            var val_6;
            System.Action<UIStatus> val_7;
            typeof(NativeClient.<ShowAchievementsUI>c__AnonStorey11).__il2cppRuntimeField_10 = cb;
            if(this.IsAuthenticated() == false)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            if((typeof(NativeClient.<ShowAchievementsUI>c__AnonStorey11).__il2cppRuntimeField_10) != 0)
            {
                    System.Action<UIStatus> val_3 = null;
                val_7 = val_3;
                val_3 = new System.Action<UIStatus>(object:  new System.Object(), method:  System.Void NativeClient.<ShowAchievementsUI>c__AnonStorey11::<>m__0(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus result));
            }
            else
            {
                    val_7 = GooglePlayGames.Native.PInvoke.Callbacks.NoopUICallback;
            }
            
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            this.mServices.AchievementManager().ShowAllUI(callback:  GooglePlayGames.Native.NativeClient.AsOnGameThreadCallback<UIStatus>(callback:  0));
        }
        public int LeaderboardMaxResults()
        {
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            GooglePlayGames.Native.PInvoke.LeaderboardManager val_1 = this.mServices.LeaderboardManager();
            if(val_1 != null)
            {
                    return val_1.LeaderboardMaxResults;
            }
            
            return val_1.LeaderboardMaxResults;
        }
        public void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, System.Action<GooglePlayGames.BasicApi.UIStatus> cb)
        {
            var val_6;
            System.Action<UIStatus> val_7;
            typeof(NativeClient.<ShowLeaderboardUI>c__AnonStorey12).__il2cppRuntimeField_10 = cb;
            if(this.IsAuthenticated() == false)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            if((typeof(NativeClient.<ShowLeaderboardUI>c__AnonStorey12).__il2cppRuntimeField_10) != 0)
            {
                    System.Action<UIStatus> val_3 = null;
                val_7 = val_3;
                val_3 = new System.Action<UIStatus>(object:  new System.Object(), method:  System.Void NativeClient.<ShowLeaderboardUI>c__AnonStorey12::<>m__0(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus result));
            }
            else
            {
                    val_7 = GooglePlayGames.Native.PInvoke.Callbacks.NoopUICallback;
            }
            
            System.Action<T> val_4 = GooglePlayGames.Native.NativeClient.AsOnGameThreadCallback<UIStatus>(callback:  0);
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            GooglePlayGames.Native.PInvoke.LeaderboardManager val_5 = this.mServices.LeaderboardManager();
            if(leaderboardId != null)
            {
                    val_5.ShowUI(leaderboardId:  leaderboardId, span:  span, callback:  val_4);
                return;
            }
            
            val_5.ShowAllUI(callback:  val_4);
        }
        public void LoadScores(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            this.mServices.LeaderboardManager().LoadLeaderboardData(leaderboardId:  leaderboardId, start:  start, rowCount:  rowCount, collection:  collection, timeSpan:  timeSpan, playerId:  this.mUser.id, callback:  GooglePlayGames.Native.NativeClient.AsOnGameThreadCallback<GooglePlayGames.BasicApi.LeaderboardScoreData>(callback:  0));
        }
        public void LoadMoreScores(GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            this.mServices.LeaderboardManager().LoadScorePage(data:  0, maxResults:  rowCount, token:  token, callback:  GooglePlayGames.Native.NativeClient.AsOnGameThreadCallback<GooglePlayGames.BasicApi.LeaderboardScoreData>(callback:  0));
        }
        public void SubmitScore(string leaderboardId, long score, System.Action<bool> callback)
        {
            System.Action<T> val_1 = GooglePlayGames.Native.NativeClient.AsOnGameThreadCallback<System.Boolean>(callback:  0);
            if(this.IsAuthenticated() != true)
            {
                    val_1.Invoke(obj:  false);
            }
            
            this.InitializeGameServices();
            if(leaderboardId != null)
            {
                    System.Threading.Monitor.Enter(obj:  0);
                System.Threading.Monitor.Exit(obj:  0);
                this.mServices.LeaderboardManager().SubmitScore(leaderboardId:  leaderboardId, score:  score, metadata:  0);
                val_1.Invoke(obj:  true);
                return;
            }
            
            System.ArgumentNullException val_5 = new System.ArgumentNullException(paramName:  "leaderboardId");
        }
        public void SubmitScore(string leaderboardId, long score, string metadata, System.Action<bool> callback)
        {
            System.Action<T> val_1 = GooglePlayGames.Native.NativeClient.AsOnGameThreadCallback<System.Boolean>(callback:  0);
            if(this.IsAuthenticated() != true)
            {
                    val_1.Invoke(obj:  false);
            }
            
            this.InitializeGameServices();
            if(leaderboardId != null)
            {
                    System.Threading.Monitor.Enter(obj:  0);
                System.Threading.Monitor.Exit(obj:  0);
                this.mServices.LeaderboardManager().SubmitScore(leaderboardId:  leaderboardId, score:  score, metadata:  metadata);
                val_1.Invoke(obj:  true);
                return;
            }
            
            System.ArgumentNullException val_5 = new System.ArgumentNullException(paramName:  "leaderboardId");
        }
        public GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient GetRtmpClient()
        {
            GooglePlayGames.Native.NativeRealtimeMultiplayerClient val_2;
            if(this.IsAuthenticated() != false)
            {
                    System.Threading.Monitor.Enter(obj:  0);
                val_2 = this.mRealTimeClient;
                System.Threading.Monitor.Exit(obj:  0);
                return (GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient)val_2;
            }
            
            val_2 = 0;
            return (GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient)val_2;
        }
        public GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient GetTbmpClient()
        {
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            return (GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient)this.mTurnBasedClient;
        }
        public GooglePlayGames.BasicApi.SavedGame.ISavedGameClient GetSavedGameClient()
        {
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            return (GooglePlayGames.BasicApi.SavedGame.ISavedGameClient)this.mSavedGameClient;
        }
        public GooglePlayGames.BasicApi.Events.IEventsClient GetEventsClient()
        {
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            return (GooglePlayGames.BasicApi.Events.IEventsClient)this.mEventsClient;
        }
        public GooglePlayGames.BasicApi.Video.IVideoClient GetVideoClient()
        {
            System.Threading.Monitor.Enter(obj:  0);
            System.Threading.Monitor.Exit(obj:  0);
            return (GooglePlayGames.BasicApi.Video.IVideoClient)this.mVideoClient;
        }
        public void RegisterInvitationDelegate(GooglePlayGames.BasicApi.InvitationReceivedDelegate invitationDelegate)
        {
            GooglePlayGames.BasicApi.InvitationReceivedDelegate val_4 = invitationDelegate;
            if(null != 0)
            {
                    typeof(NativeClient.<RegisterInvitationDelegate>c__AnonStorey13).__il2cppRuntimeField_10 = val_4;
            }
            else
            {
                    mem[16] = val_4;
                val_4 = mem[16];
            }
            
            if(val_4 != 0)
            {
                    System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, System.Boolean> val_2 = new System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, System.Boolean>(object:  new System.Object(), method:  System.Void NativeClient.<RegisterInvitationDelegate>c__AnonStorey13::<>m__0(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation, bool autoAccept));
                this.mInvitationDelegate = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<System.Object, System.Boolean>(toInvokeOnGameThread:  0);
                return;
            }
            
            this.mInvitationDelegate = 0;
        }
        public IntPtr GetApiClient()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.AsHandle();
            return GooglePlayGames.Native.Cwrapper.InternalHooks.InternalHooks_GetApiClient(services:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        private static void <AsOnGameThreadCallback`1>m__0<T>(T )
        {
        
        }
        private void <InitializeGameServices>m__1(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent eventType, string matchId, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch match)
        {
            this.mTurnBasedClient.HandleMatchEvent(eventType:  eventType, matchId:  matchId, match:  match);
        }
        private void <GetFriends>m__2(bool ok)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "loading: ";
            bool val_1 = ok;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_1;
            typeof(System.Object[]).__il2cppRuntimeField_29 = 29090361;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " mFriends = ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.mFriends;
            string val_2 = +0;
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            if(ok != true)
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  0);
            }
            
            this.friendsLoading = val_1 ^ 1;
        }
        private static bool <UnlockAchievement>m__3(GooglePlayGames.BasicApi.Achievement a)
        {
            if(X1 != 0)
            {
                    return X1.IsUnlocked;
            }
            
            return X1.IsUnlocked;
        }
        private static bool <RevealAchievement>m__4(GooglePlayGames.BasicApi.Achievement a)
        {
            if(X1 != 0)
            {
                    return X1.IsRevealed;
            }
            
            return X1.IsRevealed;
        }
    
    }

}
