using UnityEngine;

namespace GooglePlayGames.Native
{
    public class NativeTurnBasedMultiplayerClient : ITurnBasedMultiplayerClient
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.TurnBasedManager mTurnBasedManager;
        private readonly GooglePlayGames.Native.NativeClient mNativeClient;
        private System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> mMatchDelegate;
        
        // Methods
        internal NativeTurnBasedMultiplayerClient(GooglePlayGames.Native.NativeClient nativeClient, GooglePlayGames.Native.PInvoke.TurnBasedManager manager)
        {
            val_1 = new System.Object();
            this.mTurnBasedManager = val_1;
            this.mNativeClient = nativeClient;
        }
        public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            this.CreateQuickMatch(minOpponents:  minOpponents, maxOpponents:  maxOpponents, variant:  variant, exclusiveBitmask:  0, callback:  callback);
        }
        public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            var val_23;
            var val_24;
            GooglePlayGames.Native.PInvoke.TurnBasedManager val_25;
            IntPtr val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_23 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<CreateQuickMatch>c__AnonStorey1).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    val_23 = 16;
                mem[16] = callback;
            }
            
            mem[16] = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<System.Boolean, System.Object>(toInvokeOnGameThread:  0);
            val_24 = GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder.Create();
            GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder val_7 = val_24.SetVariant(variant:  variant).SetMinimumAutomatchingPlayers(minimum:  minOpponents).SetMaximumAutomatchingPlayers(maximum:  maxOpponents).SetExclusiveBitMask(bitmask:  exclusiveBitmask);
            GooglePlayGames.Native.PInvoke.TurnBasedMatchConfig val_8 = val_24.Build();
            val_25 = this.mTurnBasedManager;
            val_26 = System.Void NativeTurnBasedMultiplayerClient.<CreateQuickMatch>c__AnonStorey1::<>m__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match);
            System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> val_9 = new System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  val_1, method:  val_26);
            val_25.CreateMatch(config:  val_8, callback:  this.BridgeMatchToUserCallback(userCallback:  null));
            val_27 = 0;
            if(val_8 != null)
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_28 = val_8;
            }
            
            val_29 = 137;
            if((119 != 119) && (val_27 != 0))
            {
                    val_27 = 0;
                val_29 = 137;
            }
            
            if(val_24 != null)
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                val_30 = val_24;
            }
            
            if(137 == 137)
            {
                    return;
            }
            
            if(val_27 == 0)
            {
                    return;
            }
            
            val_24 = ???;
            val_29 = ???;
            val_25 = ???;
            val_26 = ???;
        }
        public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            typeof(NativeTurnBasedMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey2).__il2cppRuntimeField_10 = callback;
            this.CreateWithInvitationScreen(minOpponents:  minOpponents, maxOpponents:  maxOpponents, variant:  variant, callback:  new System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  new System.Object(), method:  System.Void NativeTurnBasedMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey2::<>m__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)));
        }
        public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            var val_4;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_4 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey3).__il2cppRuntimeField_10 = callback;
                NativeTurnBasedMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey3.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = variant;
                NativeTurnBasedMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey3.__il2cppRuntimeField_name.__il2cppRuntimeField_10 = this;
            }
            else
            {
                    val_4 = 16;
                mem[16] = callback;
                mem[24] = variant;
                mem[32] = this;
            }
            
            mem[16] = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<GooglePlayGames.BasicApi.UIStatus, System.Object>(toInvokeOnGameThread:  0);
            this.mTurnBasedManager.ShowPlayerSelectUI(minimumPlayers:  minOpponents, maxiumPlayers:  maxOpponents, allowAutomatching:  true, callback:  new System.Action<GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse>(object:  val_1, method:  System.Void NativeTurnBasedMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey3::<>m__0(GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse result)));
        }
        public void GetAllInvitations(System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback)
        {
            typeof(NativeTurnBasedMultiplayerClient.<GetAllInvitations>c__AnonStorey4).__il2cppRuntimeField_10 = callback;
            this.mTurnBasedManager.GetAllTurnbasedMatches(callback:  new System.Action<TurnBasedMatchesResponse>(object:  new System.Object(), method:  System.Void NativeTurnBasedMultiplayerClient.<GetAllInvitations>c__AnonStorey4::<>m__0(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchesResponse allMatches)));
        }
        public void GetAllMatches(System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]> callback)
        {
            if(null != 0)
            {
                    typeof(NativeTurnBasedMultiplayerClient.<GetAllMatches>c__AnonStorey5).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    mem[16] = callback;
            }
            
            typeof(NativeTurnBasedMultiplayerClient.<GetAllMatches>c__AnonStorey5).__il2cppRuntimeField_18 = this;
            this.mTurnBasedManager.GetAllTurnbasedMatches(callback:  new System.Action<TurnBasedMatchesResponse>(object:  new System.Object(), method:  System.Void NativeTurnBasedMultiplayerClient.<GetAllMatches>c__AnonStorey5::<>m__0(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchesResponse allMatches)));
        }
        private System.Action<GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse> BridgeMatchToUserCallback(System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> userCallback)
        {
            if(null != 0)
            {
                    typeof(NativeTurnBasedMultiplayerClient.<BridgeMatchToUserCallback>c__AnonStorey6).__il2cppRuntimeField_10 = userCallback;
            }
            else
            {
                    mem[16] = userCallback;
            }
            
            typeof(NativeTurnBasedMultiplayerClient.<BridgeMatchToUserCallback>c__AnonStorey6).__il2cppRuntimeField_18 = this;
            return (System.Action<TurnBasedMatchResponse>)new System.Action<TurnBasedMatchResponse>(object:  new System.Object(), method:  System.Void NativeTurnBasedMultiplayerClient.<BridgeMatchToUserCallback>c__AnonStorey6::<>m__0(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse callbackResult));
        }
        public void AcceptFromInbox(System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            var val_4;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_4 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<AcceptFromInbox>c__AnonStorey7).__il2cppRuntimeField_10 = callback;
                NativeTurnBasedMultiplayerClient.<AcceptFromInbox>c__AnonStorey7.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = this;
            }
            else
            {
                    val_4 = 16;
                mem[16] = callback;
                mem[24] = this;
            }
            
            mem[16] = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<System.Boolean, System.Object>(toInvokeOnGameThread:  0);
            this.mTurnBasedManager.ShowInboxUI(callback:  new System.Action<MatchInboxUIResponse>(object:  val_1, method:  System.Void NativeTurnBasedMultiplayerClient.<AcceptFromInbox>c__AnonStorey7::<>m__0(GooglePlayGames.Native.PInvoke.TurnBasedManager.MatchInboxUIResponse callbackResult)));
        }
        public void AcceptInvitation(string invitationId, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            string val_4;
            var val_5;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_4 = val_1;
                val_5 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<AcceptInvitation>c__AnonStorey8).__il2cppRuntimeField_10 = invitationId;
                typeof(NativeTurnBasedMultiplayerClient.<AcceptInvitation>c__AnonStorey8).__il2cppRuntimeField_18 = callback;
                NativeTurnBasedMultiplayerClient.<AcceptInvitation>c__AnonStorey8.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_8 = this;
            }
            else
            {
                    val_4 = 16;
                mem[16] = invitationId;
                val_5 = 24;
                mem[24] = callback;
                mem[32] = this;
            }
            
            System.Action<T1, T2> val_2 = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<System.Boolean, System.Object>(toInvokeOnGameThread:  0);
            if(null != 0)
            {
                    mem[24] = val_2;
            }
            else
            {
                    mem[24] = val_2;
            }
            
            this.FindInvitationWithId(invitationId:  val_4, callback:  new System.Action<GooglePlayGames.Native.PInvoke.MultiplayerInvitation>(object:  val_1, method:  System.Void NativeTurnBasedMultiplayerClient.<AcceptInvitation>c__AnonStorey8::<>m__0(GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)));
        }
        private void FindInvitationWithId(string invitationId, System.Action<GooglePlayGames.Native.PInvoke.MultiplayerInvitation> callback)
        {
            if(null != 0)
            {
                    typeof(NativeTurnBasedMultiplayerClient.<FindInvitationWithId>c__AnonStorey9).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    mem[16] = callback;
            }
            
            typeof(NativeTurnBasedMultiplayerClient.<FindInvitationWithId>c__AnonStorey9).__il2cppRuntimeField_18 = invitationId;
            this.mTurnBasedManager.GetAllTurnbasedMatches(callback:  new System.Action<TurnBasedMatchesResponse>(object:  new System.Object(), method:  System.Void NativeTurnBasedMultiplayerClient.<FindInvitationWithId>c__AnonStorey9::<>m__0(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchesResponse allMatches)));
        }
        public void RegisterMatchDelegate(GooglePlayGames.BasicApi.Multiplayer.MatchDelegate del)
        {
            GooglePlayGames.BasicApi.Multiplayer.MatchDelegate val_4 = del;
            if(null != 0)
            {
                    typeof(NativeTurnBasedMultiplayerClient.<RegisterMatchDelegate>c__AnonStoreyA).__il2cppRuntimeField_10 = val_4;
            }
            else
            {
                    mem[16] = val_4;
                val_4 = mem[16];
            }
            
            if(val_4 != 0)
            {
                    System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, System.Boolean> val_2 = new System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, System.Boolean>(object:  new System.Object(), method:  System.Void NativeTurnBasedMultiplayerClient.<RegisterMatchDelegate>c__AnonStoreyA::<>m__0(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, bool autoLaunch));
                this.mMatchDelegate = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<System.Object, System.Boolean>(toInvokeOnGameThread:  0);
                return;
            }
            
            this.mMatchDelegate = 0;
        }
        internal void HandleMatchEvent(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent eventType, string matchId, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch match)
        {
            var val_7;
            var val_8;
            System.Collections.IEnumerator val_9;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_7 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<HandleMatchEvent>c__AnonStoreyB).__il2cppRuntimeField_18 = match;
            }
            else
            {
                    val_7 = 24;
                mem[24] = match;
            }
            
            typeof(NativeTurnBasedMultiplayerClient.<HandleMatchEvent>c__AnonStoreyB).__il2cppRuntimeField_28 = this;
            if(null != 0)
            {
                    val_8 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<HandleMatchEvent>c__AnonStoreyB).__il2cppRuntimeField_10 = this.mMatchDelegate;
            }
            else
            {
                    val_8 = 16;
                mem[16] = this.mMatchDelegate;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
            
            if(eventType == 3)
            {
                    string val_2 = 0 + "Ignoring REMOVE event for match ";
                GooglePlayGames.OurUtils.Logger.d(msg:  0);
                return;
            }
            
            if(null != 0)
            {
                    typeof(NativeTurnBasedMultiplayerClient.<HandleMatchEvent>c__AnonStoreyB).__il2cppRuntimeField_20 = (eventType == 2) ? 1 : 0;
            }
            else
            {
                    mem[32] = (eventType == 2) ? 1 : 0;
            }
            
            val_7.ReferToMe();
            System.Collections.IEnumerator val_6 = this.WaitForLogin(method:  new System.Action(object:  val_1, method:  System.Void NativeTurnBasedMultiplayerClient.<HandleMatchEvent>c__AnonStoreyB::<>m__0()));
            val_9 = null;
            GooglePlayGames.Native.PInvoke.Callbacks.AsCoroutine(routine:  val_9);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator WaitForLogin(System.Action method)
        {
            if(null != 0)
            {
                    typeof(NativeTurnBasedMultiplayerClient.<WaitForLogin>c__Iterator0).__il2cppRuntimeField_10 = method;
            }
            else
            {
                    mem[16] = method;
            }
            
            typeof(NativeTurnBasedMultiplayerClient.<WaitForLogin>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void TakeTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, string pendingParticipantId, System.Action<bool> callback)
        {
            System.Byte[] val_5;
            var val_6;
            System.Action<T> val_7;
            val_5 = data;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_6 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<TakeTurn>c__AnonStoreyC).__il2cppRuntimeField_10 = val_5;
                typeof(NativeTurnBasedMultiplayerClient.<TakeTurn>c__AnonStoreyC).__il2cppRuntimeField_18 = callback;
                NativeTurnBasedMultiplayerClient.<TakeTurn>c__AnonStoreyC.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[16] = val_5;
                val_6 = 24;
                mem[24] = callback;
                mem[32] = this;
                val_5 = mem[16];
            }
            
            string val_2 = GooglePlayGames.OurUtils.Logger.describe(b:  0);
            val_7 = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<System.Boolean>(toInvokeOnGameThread:  0);
            if(null != 0)
            {
                    mem[24] = val_7;
            }
            else
            {
                    mem[24] = val_7;
                val_7 = mem[24];
            }
            
            this.FindEqualVersionMatchWithParticipant(match:  match, participantId:  pendingParticipantId, onFailure:  val_7, onFoundParticipantAndMatch:  new System.Action<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(object:  val_1, method:  System.Void NativeTurnBasedMultiplayerClient.<TakeTurn>c__AnonStoreyC::<>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant pendingParticipant, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)));
        }
        private void FindEqualVersionMatch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> onFailure, System.Action<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> onVersionMatch)
        {
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_4;
            GooglePlayGames.Native.PInvoke.TurnBasedManager val_5;
            val_4 = match;
            if(null != 0)
            {
                    typeof(NativeTurnBasedMultiplayerClient.<FindEqualVersionMatch>c__AnonStoreyD).__il2cppRuntimeField_10 = val_4;
                typeof(NativeTurnBasedMultiplayerClient.<FindEqualVersionMatch>c__AnonStoreyD).__il2cppRuntimeField_18 = onFailure;
                typeof(NativeTurnBasedMultiplayerClient.<FindEqualVersionMatch>c__AnonStoreyD).__il2cppRuntimeField_20 = onVersionMatch;
                val_5 = this.mTurnBasedManager;
            }
            else
            {
                    mem[16] = val_4;
                mem[24] = onFailure;
                mem[32] = onVersionMatch;
                val_5 = this.mTurnBasedManager;
                val_4 = mem[16];
            }
            
            val_5.GetMatch(matchId:  val_4.MatchId, callback:  new System.Action<TurnBasedMatchResponse>(object:  new System.Object(), method:  System.Void NativeTurnBasedMultiplayerClient.<FindEqualVersionMatch>c__AnonStoreyD::<>m__0(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse response)));
        }
        private void FindEqualVersionMatchWithParticipant(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string participantId, System.Action<bool> onFailure, System.Action<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> onFoundParticipantAndMatch)
        {
            System.Action<System.Boolean> val_3;
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_4;
            val_3 = onFailure;
            val_4 = match;
            if(null != 0)
            {
                    typeof(NativeTurnBasedMultiplayerClient.<FindEqualVersionMatchWithParticipant>c__AnonStoreyE).__il2cppRuntimeField_10 = participantId;
                typeof(NativeTurnBasedMultiplayerClient.<FindEqualVersionMatchWithParticipant>c__AnonStoreyE).__il2cppRuntimeField_18 = onFoundParticipantAndMatch;
                typeof(NativeTurnBasedMultiplayerClient.<FindEqualVersionMatchWithParticipant>c__AnonStoreyE).__il2cppRuntimeField_20 = val_4;
                typeof(NativeTurnBasedMultiplayerClient.<FindEqualVersionMatchWithParticipant>c__AnonStoreyE).__il2cppRuntimeField_28 = val_3;
            }
            else
            {
                    mem[16] = participantId;
                mem[24] = onFoundParticipantAndMatch;
                mem[32] = val_4;
                mem[40] = val_3;
                val_4 = mem[32];
                val_3 = mem[40];
            }
            
            this.FindEqualVersionMatch(match:  val_4, onFailure:  val_3, onVersionMatch:  new System.Action<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(object:  new System.Object(), method:  System.Void NativeTurnBasedMultiplayerClient.<FindEqualVersionMatchWithParticipant>c__AnonStoreyE::<>m__0(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)));
        }
        public int GetMaxMatchDataSize()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public void Finish(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome outcome, System.Action<bool> callback)
        {
            System.Action<System.Boolean> val_4;
            var val_5;
            System.Action<T> val_6;
            val_4 = callback;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    typeof(NativeTurnBasedMultiplayerClient.<Finish>c__AnonStoreyF).__il2cppRuntimeField_10 = outcome;
                val_5 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<Finish>c__AnonStoreyF).__il2cppRuntimeField_18 = val_4;
                NativeTurnBasedMultiplayerClient.<Finish>c__AnonStoreyF.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_8 = data;
                NativeTurnBasedMultiplayerClient.<Finish>c__AnonStoreyF.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = outcome;
                val_5 = 24;
                mem[24] = val_4;
                mem[32] = data;
                mem[40] = this;
                val_4 = mem[24];
            }
            
            val_6 = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<System.Boolean>(toInvokeOnGameThread:  0);
            if(null != 0)
            {
                    mem[24] = val_6;
            }
            else
            {
                    mem[24] = val_6;
                val_6 = mem[24];
            }
            
            this.FindEqualVersionMatch(match:  match, onFailure:  val_6, onVersionMatch:  new System.Action<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(object:  val_1, method:  System.Void NativeTurnBasedMultiplayerClient.<Finish>c__AnonStoreyF::<>m__0(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)));
        }
        private static GooglePlayGames.Native.Cwrapper.Types.MatchResult ResultToMatchResult(GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult result)
        {
            var val_4;
            var val_5;
            val_4 = W1;
            var val_2 = (val_4 < 4) ? (val_4 + 3) : 0;
            val_2 = val_2 - 3;
            if(val_2 <= 3)
            {
                    var val_4 = 25808476 + ((val_4 < 0x4 ? (W1 + 3) : 0 - 3)) << 2;
                val_4 = val_4 + 25808476;
            }
            else
            {
                    val_4 = 0 + "Received unknown ParticipantResult ";
                GooglePlayGames.OurUtils.Logger.e(msg:  0);
                val_5 = 4;
                return 5;
            }
        
        }
        public void AcknowledgeFinished(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback)
        {
            System.Action<System.Boolean> val_4;
            var val_5;
            System.Action<T> val_6;
            val_4 = callback;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_5 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<AcknowledgeFinished>c__AnonStorey10).__il2cppRuntimeField_10 = val_4;
                NativeTurnBasedMultiplayerClient.<AcknowledgeFinished>c__AnonStorey10.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = this;
            }
            else
            {
                    val_5 = 16;
                mem[16] = val_4;
                mem[24] = this;
                val_4 = mem[16];
            }
            
            val_6 = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<System.Boolean>(toInvokeOnGameThread:  0);
            if(null != 0)
            {
                    mem[16] = val_6;
            }
            else
            {
                    mem[16] = val_6;
                val_6 = mem[16];
            }
            
            this.FindEqualVersionMatch(match:  match, onFailure:  val_6, onVersionMatch:  new System.Action<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(object:  val_1, method:  System.Void NativeTurnBasedMultiplayerClient.<AcknowledgeFinished>c__AnonStorey10::<>m__0(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)));
        }
        public void Leave(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback)
        {
            System.Action<System.Boolean> val_4;
            var val_5;
            System.Action<T> val_6;
            val_4 = callback;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_5 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<Leave>c__AnonStorey11).__il2cppRuntimeField_10 = val_4;
                NativeTurnBasedMultiplayerClient.<Leave>c__AnonStorey11.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = this;
            }
            else
            {
                    val_5 = 16;
                mem[16] = val_4;
                mem[24] = this;
                val_4 = mem[16];
            }
            
            val_6 = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<System.Boolean>(toInvokeOnGameThread:  0);
            if(null != 0)
            {
                    mem[16] = val_6;
            }
            else
            {
                    mem[16] = val_6;
                val_6 = mem[16];
            }
            
            this.FindEqualVersionMatch(match:  match, onFailure:  val_6, onVersionMatch:  new System.Action<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(object:  val_1, method:  System.Void NativeTurnBasedMultiplayerClient.<Leave>c__AnonStorey11::<>m__0(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)));
        }
        public void LeaveDuringTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string pendingParticipantId, System.Action<bool> callback)
        {
            System.Action<System.Boolean> val_4;
            var val_5;
            System.Action<T> val_6;
            val_4 = callback;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_5 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<LeaveDuringTurn>c__AnonStorey12).__il2cppRuntimeField_10 = val_4;
                NativeTurnBasedMultiplayerClient.<LeaveDuringTurn>c__AnonStorey12.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = this;
            }
            else
            {
                    val_5 = 16;
                mem[16] = val_4;
                mem[24] = this;
                val_4 = mem[16];
            }
            
            val_6 = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<System.Boolean>(toInvokeOnGameThread:  0);
            if(null != 0)
            {
                    mem[16] = val_6;
            }
            else
            {
                    mem[16] = val_6;
                val_6 = mem[16];
            }
            
            this.FindEqualVersionMatchWithParticipant(match:  match, participantId:  pendingParticipantId, onFailure:  val_6, onFoundParticipantAndMatch:  new System.Action<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(object:  val_1, method:  System.Void NativeTurnBasedMultiplayerClient.<LeaveDuringTurn>c__AnonStorey12::<>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant pendingParticipant, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)));
        }
        public void Cancel(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback)
        {
            System.Action<System.Boolean> val_4;
            var val_5;
            System.Action<T> val_6;
            val_4 = callback;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_5 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<Cancel>c__AnonStorey13).__il2cppRuntimeField_10 = val_4;
                NativeTurnBasedMultiplayerClient.<Cancel>c__AnonStorey13.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = this;
            }
            else
            {
                    val_5 = 16;
                mem[16] = val_4;
                mem[24] = this;
                val_4 = mem[16];
            }
            
            val_6 = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<System.Boolean>(toInvokeOnGameThread:  0);
            if(null != 0)
            {
                    mem[16] = val_6;
            }
            else
            {
                    mem[16] = val_6;
                val_6 = mem[16];
            }
            
            this.FindEqualVersionMatch(match:  match, onFailure:  val_6, onVersionMatch:  new System.Action<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(object:  val_1, method:  System.Void NativeTurnBasedMultiplayerClient.<Cancel>c__AnonStorey13::<>m__0(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)));
        }
        public void Rematch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            var val_5;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_5 = val_1;
                typeof(NativeTurnBasedMultiplayerClient.<Rematch>c__AnonStorey14).__il2cppRuntimeField_10 = callback;
                NativeTurnBasedMultiplayerClient.<Rematch>c__AnonStorey14.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = this;
            }
            else
            {
                    val_5 = 16;
                mem[16] = callback;
                mem[24] = this;
            }
            
            mem[16] = GooglePlayGames.Native.PInvoke.Callbacks.AsOnGameThreadCallback<System.Boolean, System.Object>(toInvokeOnGameThread:  0);
            this.FindEqualVersionMatch(match:  match, onFailure:  new System.Action<System.Boolean>(object:  val_1, method:  System.Void NativeTurnBasedMultiplayerClient.<Rematch>c__AnonStorey14::<>m__0(bool failed)), onVersionMatch:  new System.Action<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(object:  val_1, method:  System.Void NativeTurnBasedMultiplayerClient.<Rematch>c__AnonStorey14::<>m__1(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)));
        }
        public void DeclineInvitation(string invitationId)
        {
            this.FindInvitationWithId(invitationId:  invitationId, callback:  new System.Action<GooglePlayGames.Native.PInvoke.MultiplayerInvitation>(object:  this, method:  System.Void GooglePlayGames.Native.NativeTurnBasedMultiplayerClient::<DeclineInvitation>m__0(GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)));
        }
        private void <DeclineInvitation>m__0(GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
        {
            if(invitation == null)
            {
                    return;
            }
            
            this.mTurnBasedManager.DeclineInvitation(invitation:  invitation);
        }
    
    }

}
