using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class TurnBasedManager
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.GameServices mGameServices;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cache0;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cache1;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse> <>f__mg$cache2;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.PlayerSelectUICallback <>f__mg$cache3;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchesResponse> <>f__mg$cache4;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchesCallback <>f__mg$cache5;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cache6;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cache7;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.TurnBasedManager.MatchInboxUIResponse> <>f__mg$cache8;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.MatchInboxUICallback <>f__mg$cache9;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.MultiplayerStatusCallback <>f__mg$cacheA;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cacheB;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cacheC;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.MultiplayerStatusCallback <>f__mg$cacheD;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.MultiplayerStatusCallback <>f__mg$cacheE;
        private static GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cacheF;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse> <>f__mg$cache10;
        
        // Methods
        internal TurnBasedManager(GooglePlayGames.Native.PInvoke.GameServices services)
        {
            this.mGameServices = services;
        }
        internal void GetMatch(string matchId, System.Action<GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse> callback)
        {
            TurnBasedMultiplayerManager.TurnBasedMatchCallback val_4;
            TurnBasedMultiplayerManager.TurnBasedMatchCallback val_5;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_5 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache0;
            if(val_5 == null)
            {
                    val_4 = null;
                val_4 = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalTurnBasedMatchCallback(IntPtr response, IntPtr data));
                GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache0 = val_4;
                val_5 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache0;
            }
            
            IntPtr val_2 = GooglePlayGames.Native.PInvoke.TurnBasedManager.ToCallbackPointer(callback:  val_4);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_FetchMatch(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, match_id:  val_1.handle, callback:  matchId, callback_arg:  val_5);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalTurnBasedMatchCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "TurnBasedManager#InternalTurnBasedMatchCallback", response:  1, userData:  data);
        }
        internal void CreateMatch(GooglePlayGames.Native.PInvoke.TurnBasedMatchConfig config, System.Action<GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse> callback)
        {
            TurnBasedMultiplayerManager.TurnBasedMatchCallback val_5;
            TurnBasedMultiplayerManager.TurnBasedMatchCallback val_6;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache1;
            if(val_6 == null)
            {
                    val_5 = null;
                val_5 = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalTurnBasedMatchCallback(IntPtr response, IntPtr data));
                GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache1 = val_5;
                val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache1;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.TurnBasedManager.ToCallbackPointer(callback:  val_5);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_CreateTurnBasedMatch(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, config:  val_1.handle, callback:  config.AsPointer(), callback_arg:  val_6);
        }
        internal void ShowPlayerSelectUI(uint minimumPlayers, uint maxiumPlayers, bool allowAutomatching, System.Action<GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse> callback)
        {
            TurnBasedMultiplayerManager.PlayerSelectUICallback val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_7 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache3;
            if(val_7 == null)
            {
                    GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache3 = new TurnBasedMultiplayerManager.PlayerSelectUICallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalPlayerSelectUIcallback(IntPtr response, IntPtr data));
                val_7 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache3;
            }
            
            if((GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache2) == null)
            {
                    GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache2 = new System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse>(object:  0, method:  static GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_ShowPlayerSelectUI(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, minimum_players:  val_1.handle, maximum_players:  minimumPlayers, allow_automatch:  maxiumPlayers, callback:  allowAutomatching, callback_arg:  val_7);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalPlayerSelectUIcallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "TurnBasedManager#PlayerSelectUICallback", response:  1, userData:  data);
        }
        internal void GetAllTurnbasedMatches(System.Action<GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchesResponse> callback)
        {
            TurnBasedMultiplayerManager.TurnBasedMatchesCallback val_6;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache5;
            if(val_6 == null)
            {
                    GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache5 = new TurnBasedMultiplayerManager.TurnBasedMatchesCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalTurnBasedMatchesCallback(IntPtr response, IntPtr data));
                val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache5;
            }
            
            if((GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache4) == null)
            {
                    GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache4 = new System.Func<System.IntPtr, TurnBasedMatchesResponse>(object:  0, method:  static TurnBasedMatchesResponse TurnBasedManager.TurnBasedMatchesResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_FetchMatches(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_6);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalTurnBasedMatchesCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "TurnBasedManager#TurnBasedMatchesCallback", response:  1, userData:  data);
        }
        internal void AcceptInvitation(GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation, System.Action<GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse> callback)
        {
            string val_7;
            TurnBasedMultiplayerManager.TurnBasedMatchCallback val_8;
            var val_9;
            IntPtr val_1 = invitation.AsPointer();
            string val_2 = 0 + "Accepting invitation: "("Accepting invitation: ");
            val_7 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_7);
            System.Runtime.InteropServices.HandleRef val_3 = this.mGameServices.AsHandle();
            val_9 = null;
            if((GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache6) == null)
            {
                    val_8 = null;
                val_8 = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalTurnBasedMatchCallback(IntPtr response, IntPtr data));
                GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache6 = val_8;
                val_9 = null;
            }
            
            IntPtr val_5 = GooglePlayGames.Native.PInvoke.TurnBasedManager.ToCallbackPointer(callback:  val_8);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_AcceptInvitation(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper}, invitation:  val_3.handle, callback:  invitation.AsPointer(), callback_arg:  GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache6);
        }
        internal void DeclineInvitation(GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            IntPtr val_2 = invitation.AsPointer();
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_DeclineInvitation(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, invitation:  val_1.handle);
        }
        internal void TakeTurn(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch match, byte[] data, GooglePlayGames.Native.PInvoke.MultiplayerParticipant nextParticipant, System.Action<GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse> callback)
        {
            var val_8;
            IntPtr val_9;
            IntPtr val_10;
            System.Byte[] val_11;
            IntPtr val_12;
            TurnBasedMultiplayerManager.TurnBasedMatchCallback val_13;
            var val_14;
            val_8 = callback;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_9 = val_1.wrapper;
            val_10 = val_1.handle;
            val_11 = match.AsPointer();
            val_12 = match.Results().AsPointer();
            val_14 = null;
            if((GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache7) == null)
            {
                    val_13 = null;
                val_8 = val_8;
                val_9 = val_9;
                val_10 = val_10;
                val_11 = val_11;
                val_12 = val_12;
                val_13 = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalTurnBasedMatchCallback(IntPtr response, IntPtr data));
                GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache7 = val_13;
                val_14 = null;
            }
            
            IntPtr val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.ToCallbackPointer(callback:  val_13);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_TakeMyTurn(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_9}, match:  val_10, match_data:  val_11, match_data_size:  data, results:  0, next_participant:  val_12, callback:  nextParticipant.AsPointer(), callback_arg:  GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache7);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalMatchInboxUICallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "TurnBasedManager#MatchInboxUICallback", response:  1, userData:  data);
        }
        internal void ShowInboxUI(System.Action<GooglePlayGames.Native.PInvoke.TurnBasedManager.MatchInboxUIResponse> callback)
        {
            TurnBasedMultiplayerManager.MatchInboxUICallback val_6;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache9;
            if(val_6 == null)
            {
                    GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache9 = new TurnBasedMultiplayerManager.MatchInboxUICallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalMatchInboxUICallback(IntPtr response, IntPtr data));
                val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache9;
            }
            
            if((GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache8) == null)
            {
                    GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache8 = new System.Func<System.IntPtr, MatchInboxUIResponse>(object:  0, method:  static MatchInboxUIResponse TurnBasedManager.MatchInboxUIResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_ShowMatchInboxUI(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_6);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalMultiplayerStatusCallback(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus status, IntPtr data)
        {
            string val_3;
            string val_1 = 0 + "InternalMultiplayerStatusCallback: "("InternalMultiplayerStatusCallback: ");
            val_3 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_3);
            GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToTempCallback<System.Action<MultiplayerStatus>>(handle:  0).Invoke(obj:  data);
        }
        internal void LeaveDuringMyTurn(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch match, GooglePlayGames.Native.PInvoke.MultiplayerParticipant nextParticipant, System.Action<GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus> callback)
        {
            TurnBasedMultiplayerManager.MultiplayerStatusCallback val_6;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheA;
            if(val_6 == null)
            {
                    GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheA = new TurnBasedMultiplayerManager.MultiplayerStatusCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalMultiplayerStatusCallback(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus status, IntPtr data));
                val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheA;
            }
            
            IntPtr val_5 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_LeaveMatchDuringMyTurn(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, match:  val_1.handle, next_participant:  match.AsPointer(), callback:  nextParticipant.AsPointer(), callback_arg:  val_6);
        }
        internal void FinishMatchDuringMyTurn(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch match, byte[] data, GooglePlayGames.Native.PInvoke.ParticipantResults results, System.Action<GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse> callback)
        {
            TurnBasedMultiplayerManager.TurnBasedMatchCallback val_6;
            var val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_7 = null;
            if((GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheB) == null)
            {
                    val_6 = null;
                val_6 = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalTurnBasedMatchCallback(IntPtr response, IntPtr data));
                GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheB = val_6;
                val_7 = null;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.TurnBasedManager.ToCallbackPointer(callback:  val_6);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_FinishMatchDuringMyTurn(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, match:  val_1.handle, match_data:  match.AsPointer(), match_data_size:  data, results:  0, callback:  results.AsPointer(), callback_arg:  GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheB);
        }
        internal void ConfirmPendingCompletion(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch match, System.Action<GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse> callback)
        {
            TurnBasedMultiplayerManager.TurnBasedMatchCallback val_5;
            TurnBasedMultiplayerManager.TurnBasedMatchCallback val_6;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheC;
            if(val_6 == null)
            {
                    val_5 = null;
                val_5 = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalTurnBasedMatchCallback(IntPtr response, IntPtr data));
                GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheC = val_5;
                val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheC;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.TurnBasedManager.ToCallbackPointer(callback:  val_5);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_ConfirmPendingCompletion(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, match:  val_1.handle, callback:  match.AsPointer(), callback_arg:  val_6);
        }
        internal void LeaveMatchDuringTheirTurn(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch match, System.Action<GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus> callback)
        {
            TurnBasedMultiplayerManager.MultiplayerStatusCallback val_5;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_5 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheD;
            if(val_5 == null)
            {
                    GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheD = new TurnBasedMultiplayerManager.MultiplayerStatusCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalMultiplayerStatusCallback(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus status, IntPtr data));
                val_5 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheD;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_LeaveMatchDuringTheirTurn(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, match:  val_1.handle, callback:  match.AsPointer(), callback_arg:  val_5);
        }
        internal void CancelMatch(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch match, System.Action<GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus> callback)
        {
            TurnBasedMultiplayerManager.MultiplayerStatusCallback val_5;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_5 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheE;
            if(val_5 == null)
            {
                    GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheE = new TurnBasedMultiplayerManager.MultiplayerStatusCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalMultiplayerStatusCallback(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus status, IntPtr data));
                val_5 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheE;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_CancelMatch(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, match:  val_1.handle, callback:  match.AsPointer(), callback_arg:  val_5);
        }
        internal void Rematch(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch match, System.Action<GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse> callback)
        {
            TurnBasedMultiplayerManager.TurnBasedMatchCallback val_5;
            TurnBasedMultiplayerManager.TurnBasedMatchCallback val_6;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheF;
            if(val_6 == null)
            {
                    val_5 = null;
                val_5 = new TurnBasedMultiplayerManager.TurnBasedMatchCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.TurnBasedManager::InternalTurnBasedMatchCallback(IntPtr response, IntPtr data));
                GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheF = val_5;
                val_6 = GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cacheF;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.TurnBasedManager.ToCallbackPointer(callback:  val_5);
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_Rematch(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, match:  val_1.handle, callback:  match.AsPointer(), callback_arg:  val_6);
        }
        private static IntPtr ToCallbackPointer(System.Action<GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse> callback)
        {
            if((GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache10) != null)
            {
                    return GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  X1);
            }
            
            GooglePlayGames.Native.PInvoke.TurnBasedManager.<>f__mg$cache10 = new System.Func<System.IntPtr, TurnBasedMatchResponse>(object:  0, method:  static TurnBasedMatchResponse TurnBasedManager.TurnBasedMatchResponse::FromPointer(IntPtr pointer));
            return GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  X1);
        }
    
    }

}
