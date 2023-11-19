using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class LeaderboardManager
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.GameServices mServices;
        private static GooglePlayGames.Native.Cwrapper.LeaderboardManager.ShowAllUICallback <>f__mg$cache0;
        private static GooglePlayGames.Native.Cwrapper.LeaderboardManager.ShowUICallback <>f__mg$cache1;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.FetchResponse> <>f__mg$cache2;
        private static GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchCallback <>f__mg$cache3;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse> <>f__mg$cache4;
        private static GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchScoreSummaryCallback <>f__mg$cache5;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.FetchScorePageResponse> <>f__mg$cache6;
        private static GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchScorePageCallback <>f__mg$cache7;
        
        // Properties
        internal int LeaderboardMaxResults { get; }
        
        // Methods
        internal LeaderboardManager(GooglePlayGames.Native.PInvoke.GameServices services)
        {
            this.mServices = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        internal int get_LeaderboardMaxResults()
        {
            return 25;
        }
        internal void SubmitScore(string leaderboardId, long score, string metadata)
        {
            string val_4;
            var val_5;
            val_4 = metadata;
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  0, paramName:  leaderboardId);
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Native Submitting score: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = score;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " for lb ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = leaderboardId;
            typeof(System.Object[]).__il2cppRuntimeField_40 = " with metadata: ";
            typeof(System.Object[]).__il2cppRuntimeField_48 = val_4;
            string val_2 = +0;
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            System.Runtime.InteropServices.HandleRef val_3 = this.mServices.SelfPtr();
            if(val_4 == null)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = System.String.Empty;
            }
            
            GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_SubmitScore(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper}, leaderboard_id:  val_3.handle, score:  leaderboardId, metadata:  score);
        }
        internal void ShowAllUI(System.Action<GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus> callback)
        {
            LeaderboardManager.ShowAllUICallback val_5;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_2 = this.mServices.SelfPtr();
            val_5 = GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache0;
            if(val_5 == null)
            {
                    GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache0 = new LeaderboardManager.ShowAllUICallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.Callbacks::InternalShowUICallback(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus status, IntPtr data));
                val_5 = GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache0;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  null);
            GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_ShowAllUI(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, callback:  val_2.handle, callback_arg:  val_5);
        }
        internal void ShowUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, System.Action<GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus> callback)
        {
            LeaderboardManager.ShowUICallback val_5;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_2 = this.mServices.SelfPtr();
            val_5 = GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache1;
            if(val_5 == null)
            {
                    GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache1 = new LeaderboardManager.ShowUICallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.Callbacks::InternalShowUICallback(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus status, IntPtr data));
                val_5 = GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache1;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  null);
            GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_ShowUI(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, leaderboard_id:  val_2.handle, time_span:  leaderboardId, callback:  span, callback_arg:  val_5);
        }
        public void LoadLeaderboardData(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, string playerId, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            LeaderboardManager.FetchCallback val_11;
            IntPtr val_12;
            if(null != 0)
            {
                    typeof(LeaderboardManager.<LoadLeaderboardData>c__AnonStorey0).__il2cppRuntimeField_18 = playerId;
                typeof(LeaderboardManager.<LoadLeaderboardData>c__AnonStorey0).__il2cppRuntimeField_20 = rowCount;
                typeof(LeaderboardManager.<LoadLeaderboardData>c__AnonStorey0).__il2cppRuntimeField_28 = callback;
            }
            else
            {
                    mem[24] = playerId;
                mem[32] = rowCount;
                mem[40] = callback;
            }
            
            typeof(LeaderboardManager.<LoadLeaderboardData>c__AnonStorey0).__il2cppRuntimeField_30 = this;
            System.Runtime.InteropServices.HandleRef val_2 = this.mServices.SelfPtr();
            typeof(LeaderboardManager.<LoadLeaderboardData>c__AnonStorey0).__il2cppRuntimeField_10 = new GooglePlayGames.BasicApi.ScorePageToken(internalObject:  new GooglePlayGames.Native.PInvoke.NativeScorePageToken(selfPtr:  GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_ScorePageToken(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, leaderboard_id:  val_2.handle, start:  leaderboardId, time_span:  start, collection:  timeSpan)), id:  leaderboardId, collection:  collection, timespan:  timeSpan);
            System.Runtime.InteropServices.HandleRef val_6 = this.mServices.SelfPtr();
            val_11 = GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache3;
            if(val_11 == null)
            {
                    GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache3 = new LeaderboardManager.FetchCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.LeaderboardManager::InternalFetchCallback(IntPtr response, IntPtr data));
                val_11 = GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache3;
            }
            
            val_12 = System.Void LeaderboardManager.<LoadLeaderboardData>c__AnonStorey0::<>m__0(GooglePlayGames.Native.PInvoke.FetchResponse rsp);
            if((GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache2) == null)
            {
                    System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.FetchResponse> val_9 = null;
                val_12 = val_9;
                val_9 = new System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.FetchResponse>(object:  0, method:  static GooglePlayGames.Native.PInvoke.FetchResponse GooglePlayGames.Native.PInvoke.FetchResponse::FromPointer(IntPtr pointer));
                GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache2 = val_12;
            }
            
            IntPtr val_10 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  new System.Action<GooglePlayGames.Native.PInvoke.FetchResponse>(object:  new System.Object(), method:  val_12));
            GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_Fetch(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_6.wrapper}, data_source:  val_6.handle, leaderboard_id:  1, callback:  leaderboardId, callback_arg:  val_11);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalFetchCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  null, callbackType:  "LeaderboardManager#InternalFetchCallback", response:  1, userData:  data);
        }
        internal void HandleFetch(GooglePlayGames.BasicApi.ScorePageToken token, GooglePlayGames.Native.PInvoke.FetchResponse response, string selfPlayerId, int maxResults, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            DataSource val_24;
            GooglePlayGames.BasicApi.ScorePageToken val_25;
            LeaderboardManager.FetchScoreSummaryCallback val_26;
            var val_27;
            LeaderboardCollection val_28;
            var val_29;
            IntPtr val_30;
            System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse> val_32;
            System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> val_33;
            val_24 = response;
            val_25 = token;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    typeof(LeaderboardManager.<HandleFetch>c__AnonStorey1).__il2cppRuntimeField_18 = selfPlayerId;
                val_26 = val_1;
                val_27 = val_1;
                typeof(LeaderboardManager.<HandleFetch>c__AnonStorey1).__il2cppRuntimeField_20 = maxResults;
                typeof(LeaderboardManager.<HandleFetch>c__AnonStorey1).__il2cppRuntimeField_28 = val_25;
                typeof(LeaderboardManager.<HandleFetch>c__AnonStorey1).__il2cppRuntimeField_30 = callback;
                LeaderboardManager.<HandleFetch>c__AnonStorey1.__il2cppRuntimeField_element_class.__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[24] = selfPlayerId;
                mem[32] = maxResults;
                val_26 = 40;
                mem[40] = val_25;
                val_27 = 48;
                mem[48] = callback;
                mem[56] = this;
                val_25 = mem[40];
            }
            
            System.Runtime.InteropServices.HandleRef val_3 = val_24.SelfPtr();
            GooglePlayGames.BasicApi.LeaderboardScoreData val_5 = null;
            val_28 = val_5;
            val_5 = new GooglePlayGames.BasicApi.LeaderboardScoreData(leaderboardId:  val_25.LeaderboardId, status:  GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper}));
            typeof(LeaderboardManager.<HandleFetch>c__AnonStorey1).__il2cppRuntimeField_10 = val_28;
            System.Runtime.InteropServices.HandleRef val_6 = val_24.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_6.wrapper})) == 1)
            {
                goto label_7;
            }
            
            System.Runtime.InteropServices.HandleRef val_8 = val_24.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_8.wrapper})) != 2)
            {
                goto label_9;
            }
            
            label_7:
            Title = val_24.Leaderboard().Title();
            if(null != 0)
            {
                    val_29 = typeof(LeaderboardManager.<HandleFetch>c__AnonStorey1).__il2cppRuntimeField_10;
            }
            else
            {
                    val_29 = typeof(LeaderboardManager.<HandleFetch>c__AnonStorey1).__il2cppRuntimeField_10;
            }
            
            Id = mem[40].LeaderboardId;
            System.Runtime.InteropServices.HandleRef val_13 = this.mServices.SelfPtr();
            val_24 = val_13.handle;
            val_28 = mem[40].TimeSpan;
            val_26 = GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache5;
            if(val_26 == null)
            {
                    GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache5 = new LeaderboardManager.FetchScoreSummaryCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.LeaderboardManager::InternalFetchSummaryCallback(IntPtr response, IntPtr data));
                val_26 = GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache5;
            }
            
            val_30 = System.Void LeaderboardManager.<HandleFetch>c__AnonStorey1::<>m__0(GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse rsp);
            if((GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache4) == null)
            {
                    System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse> val_19 = null;
                val_30 = val_19;
                val_19 = new System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse>(object:  0, method:  static GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse::FromPointer(IntPtr pointer));
                GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache4 = val_30;
            }
            
            val_32 = GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache4;
            IntPtr val_20 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  new System.Action<GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse>(object:  val_1, method:  val_30));
            GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScoreSummary(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_13.wrapper}, data_source:  val_24, leaderboard_id:  1, time_span:  mem[40].LeaderboardId, collection:  val_28, callback:  mem[40].Collection, callback_arg:  val_26);
            return;
            label_9:
            System.Runtime.InteropServices.HandleRef val_21 = val_24.SelfPtr();
            ResponseStatus val_22 = GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_21.wrapper});
            string val_23 = 0 + "Error returned from fetch: "("Error returned from fetch: ");
            GooglePlayGames.OurUtils.Logger.w(msg:  0);
            if(null != 0)
            {
                
            }
            else
            {
                    val_33 = mem[48];
            }
            
            val_32 = typeof(LeaderboardManager.<HandleFetch>c__AnonStorey1).__il2cppRuntimeField_10;
            val_33.Invoke(obj:  val_32);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalFetchSummaryCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  null, callbackType:  "LeaderboardManager#InternalFetchSummaryCallback", response:  1, userData:  data);
        }
        internal void HandleFetchScoreSummary(GooglePlayGames.BasicApi.LeaderboardScoreData data, GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse response, string selfPlayerId, int maxResults, GooglePlayGames.BasicApi.ScorePageToken token, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            GooglePlayGames.BasicApi.ScorePageToken val_14;
            var val_15;
            val_14 = token;
            val_15 = response;
            System.Runtime.InteropServices.HandleRef val_1 = val_15.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScoreSummaryResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) == 1)
            {
                goto label_2;
            }
            
            System.Runtime.InteropServices.HandleRef val_3 = val_15.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScoreSummaryResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper})) != 2)
            {
                goto label_4;
            }
            
            label_2:
            GooglePlayGames.Native.PInvoke.NativeScoreSummary val_5 = val_15.GetScoreSummary();
            System.Runtime.InteropServices.HandleRef val_6 = val_5.SelfPtr();
            data.ApproximateCount = GooglePlayGames.Native.Cwrapper.ScoreSummary.ScoreSummary_ApproximateNumberOfScores(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_6.wrapper});
            val_15 = val_5.LocalUserScore();
            data.PlayerScore = val_15.AsScore(leaderboardId:  data.Id, selfPlayerId:  selfPlayerId);
            if(maxResults <= 0)
            {
                goto label_12;
            }
            
            this.LoadScorePage(data:  data, maxResults:  maxResults, token:  val_14, callback:  callback);
            return;
            label_4:
            string val_11 = 0 + "Error returned from fetchScoreSummary: "("Error returned from fetchScoreSummary: ");
            GooglePlayGames.OurUtils.Logger.w(msg:  0);
            System.Runtime.InteropServices.HandleRef val_12 = val_15.SelfPtr();
            val_14 = GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScoreSummaryResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_12.wrapper});
            data.Status = val_14;
            label_12:
            callback.Invoke(obj:  data);
        }
        public void LoadScorePage(GooglePlayGames.BasicApi.LeaderboardScoreData data, int maxResults, GooglePlayGames.BasicApi.ScorePageToken token, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            object val_6;
            GooglePlayGames.BasicApi.LeaderboardScoreData val_13;
            var val_14;
            var val_15;
            var val_16;
            LeaderboardManager.FetchScorePageCallback val_17;
            val_13 = data;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_14 = val_1;
                val_15 = val_1;
                typeof(LeaderboardManager.<LoadScorePage>c__AnonStorey2).__il2cppRuntimeField_10 = val_13;
                typeof(LeaderboardManager.<LoadScorePage>c__AnonStorey2).__il2cppRuntimeField_18 = token;
                LeaderboardManager.<LoadScorePage>c__AnonStorey2.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_8 = callback;
                LeaderboardManager.<LoadScorePage>c__AnonStorey2.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_10 = this;
            }
            else
            {
                    val_14 = 16;
                mem[16] = val_13;
                val_15 = 24;
                mem[24] = token;
                mem[32] = callback;
                mem[40] = this;
                val_13 = mem[16];
            }
            
            if(val_13 == 0)
            {
                    mem[16] = new GooglePlayGames.BasicApi.LeaderboardScoreData(leaderboardId:  val_15.LeaderboardId);
            }
            
            object val_4 = mem[24].InternalObject;
            val_16 = 0;
            if(val_4 != null)
            {
                    val_16 = val_4;
                val_16 = 0;
            }
            
            System.Runtime.InteropServices.HandleRef val_7 = this.mServices.SelfPtr();
            val_6 = 0;
            System.Runtime.InteropServices.HandleRef val_8 = val_16.SelfPtr();
            val_6 = val_8.wrapper;
            val_17 = GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache7;
            if(val_17 == null)
            {
                    GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache7 = new LeaderboardManager.FetchScorePageCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.LeaderboardManager::InternalFetchScorePage(IntPtr response, IntPtr data));
                val_17 = GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache7;
            }
            
            if((GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache6) == null)
            {
                    GooglePlayGames.Native.PInvoke.LeaderboardManager.<>f__mg$cache6 = new System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.FetchScorePageResponse>(object:  0, method:  static GooglePlayGames.Native.PInvoke.FetchScorePageResponse GooglePlayGames.Native.PInvoke.FetchScorePageResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_12 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  new System.Action<GooglePlayGames.Native.PInvoke.FetchScorePageResponse>(object:  val_1, method:  System.Void LeaderboardManager.<LoadScorePage>c__AnonStorey2::<>m__0(GooglePlayGames.Native.PInvoke.FetchScorePageResponse rsp)));
            GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScorePage(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_7.wrapper}, data_source:  val_7.handle, token:  1, max_results:  -1058977792, callback:  maxResults, callback_arg:  val_17);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalFetchScorePage(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  null, callbackType:  "LeaderboardManager#InternalFetchScorePage", response:  1, userData:  data);
        }
        internal void HandleFetchScorePage(GooglePlayGames.BasicApi.LeaderboardScoreData data, GooglePlayGames.BasicApi.ScorePageToken token, GooglePlayGames.Native.PInvoke.FetchScorePageResponse rsp, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback)
        {
            string val_37;
            GooglePlayGames.BasicApi.LeaderboardCollection val_38;
            string val_39;
            GooglePlayGames.BasicApi.LeaderboardCollection val_40;
            var val_41;
            var val_42;
            var val_43;
            System.Runtime.InteropServices.HandleRef val_1 = rsp.SelfPtr();
            data.Status = GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScorePageResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
            System.Runtime.InteropServices.HandleRef val_3 = rsp.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScorePageResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper})) != 1)
            {
                    System.Runtime.InteropServices.HandleRef val_5 = rsp.SelfPtr();
                if((GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScorePageResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_5.wrapper})) != 2)
            {
                    callback.Invoke(obj:  data);
            }
            
            }
            
            GooglePlayGames.Native.PInvoke.NativeScorePage val_7 = rsp.GetScorePage();
            System.Runtime.InteropServices.HandleRef val_8 = val_7.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Valid(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_8.wrapper})) != true)
            {
                    callback.Invoke(obj:  data);
            }
            
            System.Runtime.InteropServices.HandleRef val_11 = val_7.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_HasNextScorePage(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_11.wrapper})) != false)
            {
                    if(token != null)
            {
                    val_37 = token.LeaderboardId;
                val_38 = token.Collection;
            }
            else
            {
                    val_37 = 0.LeaderboardId;
                val_38 = 0.Collection;
            }
            
                data.NextPageToken = new GooglePlayGames.BasicApi.ScorePageToken(internalObject:  val_7.GetNextScorePageToken(), id:  val_37, collection:  val_38, timespan:  token.TimeSpan);
            }
            
            System.Runtime.InteropServices.HandleRef val_20 = val_7.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_HasPreviousScorePage(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_20.wrapper})) != false)
            {
                    if(token != null)
            {
                    val_39 = token.LeaderboardId;
                val_40 = token.Collection;
            }
            else
            {
                    val_39 = 0.LeaderboardId;
                val_40 = 0.Collection;
            }
            
                data.PrevPageToken = new GooglePlayGames.BasicApi.ScorePageToken(internalObject:  val_7.GetPreviousScorePageToken(), id:  val_39, collection:  val_40, timespan:  token.TimeSpan);
            }
            
            System.Collections.Generic.IEnumerator<GooglePlayGames.Native.PInvoke.NativeScoreEntry> val_29 = val_7.GetEnumerator();
            label_39:
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_41 = val_29;
            if(((val_29 & 1) & 1) == 0)
            {
                goto label_48;
            }
            
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_42 = val_29;
            int val_35 = data.AddScore(score:  val_29.AsScore(leaderboardId:  data.Id));
            goto label_39;
            label_48:
            if(val_29 != null)
            {
                    var val_39 = 0;
                val_39 = val_39 + 1;
                val_43 = val_29;
            }
            
            callback.Invoke(obj:  data);
        }
    
    }

}
