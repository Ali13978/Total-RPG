using UnityEngine;

namespace GooglePlayGames.Native
{
    public class NativeRealtimeMultiplayerClient : IRealTimeMultiplayerClient
    {
        // Fields
        private readonly object mSessionLock;
        private readonly GooglePlayGames.Native.NativeClient mNativeClient;
        private readonly GooglePlayGames.Native.PInvoke.RealtimeManager mRealtimeManager;
        private GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession mCurrentSession;
        
        // Methods
        internal NativeRealtimeMultiplayerClient(GooglePlayGames.Native.NativeClient nativeClient, GooglePlayGames.Native.PInvoke.RealtimeManager manager)
        {
            this.mSessionLock = new System.Object();
            val_2 = new System.Object();
            this.mNativeClient = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            this.mRealtimeManager = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            this.mCurrentSession = this.GetTerminatedSession();
            System.Action<System.Boolean> val_6 = new System.Action<System.Boolean>(object:  this, method:  System.Void GooglePlayGames.Native.NativeRealtimeMultiplayerClient::HandleAppPausing(bool paused));
            GooglePlayGames.OurUtils.PlayGamesHelperObject.AddPauseCallback(callback:  0);
        }
        private GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession GetTerminatedSession()
        {
            NativeRealtimeMultiplayerClient.RoomSession val_2 = new NativeRealtimeMultiplayerClient.RoomSession(manager:  this.mRealtimeManager, listener:  new NativeRealtimeMultiplayerClient.NoopListener());
            EnterState(handler:  new NativeRealtimeMultiplayerClient.ShutdownState(session:  val_2), fireStateEnteredEvent:  false);
            return (RoomSession)val_2;
        }
        public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
        {
            this.CreateQuickGame(minOpponents:  minOpponents, maxOpponents:  maxOpponents, variant:  variant, exclusiveBitMask:  0, listener:  listener);
        }
        public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
        {
            ulong val_20;
            uint val_21;
            GooglePlayGames.Native.PInvoke.RealtimeManager val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            val_20 = exclusiveBitMask;
            val_21 = maxOpponents;
            System.Threading.Monitor.Enter(obj:  0);
            NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey2 val_1 = new NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey2();
            typeof(NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey2).__il2cppRuntimeField_18 = this;
            val_22 = this.mRealtimeManager;
            NativeRealtimeMultiplayerClient.RoomSession val_2 = new NativeRealtimeMultiplayerClient.RoomSession(manager:  val_22, listener:  listener);
            typeof(NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey2).__il2cppRuntimeField_10 = null;
            if(this.mCurrentSession.IsActive() == false)
            {
                goto label_3;
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            LeaveRoom();
            goto label_8;
            label_3:
            this.mCurrentSession = typeof(NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey2).__il2cppRuntimeField_10;
            string val_5 = 0 + "QuickGame: Setting MinPlayersToStart = "("QuickGame: Setting MinPlayersToStart = ");
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            this.mCurrentSession.MinPlayersToStart = minOpponents;
            GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder val_6 = GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder.Create();
            val_22 = null;
            val_22 = new NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey0();
            val_20 = val_6.SetMinimumAutomatchingPlayers(minimum:  minOpponents).SetMaximumAutomatchingPlayers(maximum:  val_21).SetVariant(variantValue:  variant).SetExclusiveBitMask(bitmask:  val_20).Build();
            if(null != 0)
            {
                    typeof(NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey0).__il2cppRuntimeField_10 = val_20;
            }
            else
            {
                    mem[16] = val_20;
                val_20 = mem[16];
            }
            
            if(null != 0)
            {
                    typeof(NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey1).__il2cppRuntimeField_18 = null;
            }
            else
            {
                    mem[24] = null;
            }
            
            typeof(NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey1).__il2cppRuntimeField_20 = val_22;
            typeof(NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey1).__il2cppRuntimeField_10 = GooglePlayGames.Native.NativeRealtimeMultiplayerClient.HelperForSession(session:  new NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey1() = new NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey1());
            val_21 = null;
            val_21 = new System.Action(object:  null, method:  System.Void NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey1::<>m__0());
            StartRoomCreation(currentPlayerId:  this.mNativeClient.GetUserId(), createRoom:  val_21);
            val_23 = 0;
            if((typeof(NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey1).__il2cppRuntimeField_10) == 0)
            {
                goto label_29;
            }
            
            if((val_14 + 258) == 0)
            {
                goto label_30;
            }
            
            var val_18 = val_14 + 152;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_32:
            if(((val_14 + 152 + 8) + -8) == null)
            {
                goto label_31;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (val_14 + 258))
            {
                goto label_32;
            }
            
            label_30:
            val_24 = typeof(NativeRealtimeMultiplayerClient.<CreateQuickGame>c__AnonStorey1).__il2cppRuntimeField_10;
            goto label_33;
            label_31:
            val_24 = ((val_14 + ((val_14 + 152 + 8)) << 4)) + 272;
            label_33:
            label_29:
            val_25 = 321;
            if((301 != 301) && (val_23 != 0))
            {
                    val_23 = 0;
                val_25 = 321;
            }
            
            if(val_20 == 0)
            {
                goto label_36;
            }
            
            var val_22 = val_20;
            if((val_12 + 258) == 0)
            {
                goto label_37;
            }
            
            var val_20 = val_12 + 152;
            var val_21 = 0;
            val_20 = val_20 + 8;
            label_39:
            if(((val_12 + 152 + 8) + -8) == null)
            {
                goto label_38;
            }
            
            val_21 = val_21 + 1;
            val_20 = val_20 + 16;
            if(val_21 < (val_12 + 258))
            {
                goto label_39;
            }
            
            label_37:
            val_26 = val_20;
            goto label_40;
            label_38:
            val_22 = val_22 + (((val_12 + 152 + 8)) << 4);
            val_26 = val_22 + 272;
            label_40:
            label_36:
            if((321 != 321) && (val_23 != 0))
            {
                    val_23 = 0;
            }
            
            if(val_6 != null)
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_27 = val_6;
            }
            
            if((339 == 339) || (val_23 == 0))
            {
                goto label_49;
            }
            
            label_8:
            val_23 = 0;
            label_49:
            System.Threading.Monitor.Exit(obj:  0);
            if(351 == 351)
            {
                    return;
            }
            
            if(val_23 == 0)
            {
                    return;
            }
        
        }
        private static GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper HelperForSession(GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession session)
        {
            NativeRealtimeMultiplayerClient.<HelperForSession>c__AnonStorey3 val_1 = new NativeRealtimeMultiplayerClient.<HelperForSession>c__AnonStorey3();
            typeof(NativeRealtimeMultiplayerClient.<HelperForSession>c__AnonStorey3).__il2cppRuntimeField_10 = X1;
            GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper val_8 = GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper.Create().SetOnDataReceivedCallback(callback:  new System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean>(object:  val_1, method:  System.Void NativeRealtimeMultiplayerClient.<HelperForSession>c__AnonStorey3::<>m__0(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant, byte[] data, bool isReliable))).SetOnParticipantStatusChangedCallback(callback:  new System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant>(object:  val_1, method:  System.Void NativeRealtimeMultiplayerClient.<HelperForSession>c__AnonStorey3::<>m__1(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant))).SetOnRoomConnectedSetChangedCallback(callback:  new System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom>(object:  val_1, method:  System.Void NativeRealtimeMultiplayerClient.<HelperForSession>c__AnonStorey3::<>m__2(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)));
            if(val_8 != null)
            {
                    return val_8.SetOnRoomStatusChangedCallback(callback:  new System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom>(object:  val_1, method:  System.Void NativeRealtimeMultiplayerClient.<HelperForSession>c__AnonStorey3::<>m__3(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)));
            }
            
            return val_8.SetOnRoomStatusChangedCallback(callback:  new System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom>(object:  val_1, method:  System.Void NativeRealtimeMultiplayerClient.<HelperForSession>c__AnonStorey3::<>m__3(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)));
        }
        private void HandleAppPausing(bool paused)
        {
            if(paused == false)
            {
                    return;
            }
            
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            this.LeaveRoom();
        }
        public void CreateWithInvitationScreen(uint minOpponents, uint maxOppponents, uint variant, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
        {
            GooglePlayGames.Native.NativeRealtimeMultiplayerClient val_7;
            NativeRealtimeMultiplayerClient.RoomSession val_8;
            val_7 = this;
            if(null != 0)
            {
                    typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey5).__il2cppRuntimeField_10 = variant;
            }
            else
            {
                    mem[16] = variant;
            }
            
            typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey5).__il2cppRuntimeField_18 = val_7;
            System.Threading.Monitor.Enter(obj:  0);
            NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4 val_2 = new NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4();
            typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4).__il2cppRuntimeField_18 = new NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey5();
            val_8 = null;
            val_8 = new NativeRealtimeMultiplayerClient.RoomSession(manager:  this.mRealtimeManager, listener:  listener);
            typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4).__il2cppRuntimeField_10 = val_8;
            if(this.mCurrentSession.IsActive() != false)
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  0);
                LeaveRoom();
            }
            else
            {
                    this.mCurrentSession = typeof(NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4).__il2cppRuntimeField_10;
                ShowingUI = true;
                val_7 = this.mRealtimeManager;
                val_8 = System.Void NativeRealtimeMultiplayerClient.<CreateWithInvitationScreen>c__AnonStorey4::<>m__0(GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse response);
                System.Action<GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse> val_6 = new System.Action<GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse>(object:  null, method:  val_8);
                val_7.ShowPlayerSelectUI(minimumPlayers:  minOpponents, maxiumPlayers:  maxOppponents, allowAutomatching:  true, callback:  null);
            }
            
            System.Threading.Monitor.Exit(obj:  0);
        }
        public void ShowWaitingRoomUI()
        {
            System.Threading.Monitor.Enter(obj:  0);
            this.mCurrentSession.ShowWaitingRoomUI();
            System.Threading.Monitor.Exit(obj:  0);
        }
        public void GetAllInvitations(System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback)
        {
            typeof(NativeRealtimeMultiplayerClient.<GetAllInvitations>c__AnonStorey8).__il2cppRuntimeField_10 = callback;
            this.mRealtimeManager.FetchInvitations(callback:  new System.Action<FetchInvitationsResponse>(object:  new NativeRealtimeMultiplayerClient.<GetAllInvitations>c__AnonStorey8(), method:  System.Void NativeRealtimeMultiplayerClient.<GetAllInvitations>c__AnonStorey8::<>m__0(GooglePlayGames.Native.PInvoke.RealtimeManager.FetchInvitationsResponse response)));
        }
        public void AcceptFromInbox(GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
        {
            GooglePlayGames.Native.NativeRealtimeMultiplayerClient val_6;
            NativeRealtimeMultiplayerClient.RoomSession val_7;
            val_6 = this;
            System.Threading.Monitor.Enter(obj:  0);
            NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9 val_1 = new NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9();
            typeof(NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9).__il2cppRuntimeField_18 = val_6;
            val_7 = null;
            val_7 = new NativeRealtimeMultiplayerClient.RoomSession(manager:  this.mRealtimeManager, listener:  listener);
            typeof(NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9).__il2cppRuntimeField_10 = val_7;
            if(this.mCurrentSession.IsActive() != false)
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  0);
                LeaveRoom();
            }
            else
            {
                    this.mCurrentSession = typeof(NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9).__il2cppRuntimeField_10;
                ShowingUI = true;
                val_6 = this.mRealtimeManager;
                val_7 = System.Void NativeRealtimeMultiplayerClient.<AcceptFromInbox>c__AnonStorey9::<>m__0(GooglePlayGames.Native.PInvoke.RealtimeManager.RoomInboxUIResponse response);
                System.Action<RoomInboxUIResponse> val_5 = new System.Action<RoomInboxUIResponse>(object:  null, method:  val_7);
                val_6.ShowRoomInboxUI(callback:  null);
            }
            
            System.Threading.Monitor.Exit(obj:  0);
        }
        public void AcceptInvitation(string invitationId, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
        {
            GooglePlayGames.Native.NativeRealtimeMultiplayerClient val_7;
            NativeRealtimeMultiplayerClient.RoomSession val_8;
            val_7 = this;
            if(null != 0)
            {
                    typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyD).__il2cppRuntimeField_10 = invitationId;
            }
            else
            {
                    mem[16] = invitationId;
            }
            
            typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyD).__il2cppRuntimeField_18 = val_7;
            System.Threading.Monitor.Enter(obj:  0);
            NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC val_2 = new NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC();
            typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC).__il2cppRuntimeField_18 = new NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyD();
            val_8 = null;
            val_8 = new NativeRealtimeMultiplayerClient.RoomSession(manager:  this.mRealtimeManager, listener:  listener);
            typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC).__il2cppRuntimeField_10 = val_8;
            if(this.mCurrentSession.IsActive() != false)
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  0);
                LeaveRoom();
            }
            else
            {
                    this.mCurrentSession = typeof(NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC).__il2cppRuntimeField_10;
                val_7 = this.mRealtimeManager;
                val_8 = System.Void NativeRealtimeMultiplayerClient.<AcceptInvitation>c__AnonStoreyC::<>m__0(GooglePlayGames.Native.PInvoke.RealtimeManager.FetchInvitationsResponse response);
                System.Action<FetchInvitationsResponse> val_6 = new System.Action<FetchInvitationsResponse>(object:  null, method:  val_8);
                val_7.FetchInvitations(callback:  null);
            }
            
            System.Threading.Monitor.Exit(obj:  0);
        }
        public GooglePlayGames.BasicApi.Multiplayer.Invitation GetInvitation()
        {
            if(this.mCurrentSession != null)
            {
                    return this.mCurrentSession.GetInvitation();
            }
            
            return this.mCurrentSession.GetInvitation();
        }
        public void LeaveRoom()
        {
            this.mCurrentSession.LeaveRoom();
        }
        public void SendMessageToAll(bool reliable, byte[] data)
        {
            reliable = reliable;
            this.mCurrentSession.SendMessageToAll(reliable:  reliable, data:  data);
        }
        public void SendMessageToAll(bool reliable, byte[] data, int offset, int length)
        {
            reliable = reliable;
            this.mCurrentSession.SendMessageToAll(reliable:  reliable, data:  data, offset:  offset, length:  length);
        }
        public void SendMessage(bool reliable, string participantId, byte[] data)
        {
            reliable = reliable;
            this.mCurrentSession.SendMessage(reliable:  reliable, participantId:  participantId, data:  data);
        }
        public void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length)
        {
            reliable = reliable;
            this.mCurrentSession.SendMessage(reliable:  reliable, participantId:  participantId, data:  data, offset:  offset, length:  length);
        }
        public System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> GetConnectedParticipants()
        {
            if(this.mCurrentSession != null)
            {
                    return this.mCurrentSession.GetConnectedParticipants();
            }
            
            return this.mCurrentSession.GetConnectedParticipants();
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant GetSelf()
        {
            if(this.mCurrentSession == null)
            {
                
            }
        
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant GetParticipant(string participantId)
        {
            if(this.mCurrentSession == null)
            {
                
            }
        
        }
        public bool IsRoomConnected()
        {
            if(this.mCurrentSession == null)
            {
                
            }
        
        }
        public void DeclineInvitation(string invitationId)
        {
            if(null != 0)
            {
                    typeof(NativeRealtimeMultiplayerClient.<DeclineInvitation>c__AnonStorey10).__il2cppRuntimeField_10 = invitationId;
            }
            else
            {
                    mem[16] = invitationId;
            }
            
            typeof(NativeRealtimeMultiplayerClient.<DeclineInvitation>c__AnonStorey10).__il2cppRuntimeField_18 = this;
            this.mRealtimeManager.FetchInvitations(callback:  new System.Action<FetchInvitationsResponse>(object:  new NativeRealtimeMultiplayerClient.<DeclineInvitation>c__AnonStorey10(), method:  System.Void NativeRealtimeMultiplayerClient.<DeclineInvitation>c__AnonStorey10::<>m__0(GooglePlayGames.Native.PInvoke.RealtimeManager.FetchInvitationsResponse response)));
        }
        private static T WithDefault<T>(T presented, T defaultValue)
        {
            return (object)(defaultValue == 0) ? __RuntimeMethodHiddenParam : defaultValue;
        }
    
    }

}
