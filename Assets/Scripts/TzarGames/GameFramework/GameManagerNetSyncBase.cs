using UnityEngine;

namespace TzarGames.GameFramework
{
    public abstract class GameManagerNetSyncBase : MonoBehaviour
    {
        // Fields
        private TzarGames.GameFramework.GameManager gameManager;
        private static TzarGames.GameFramework.INetInfoProvider netInfoProvider;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.NetworkViewBase myNetworkView;
        private TzarGames.GameFramework.Player serverPlayer;
        private System.Collections.Generic.Dictionary<TzarGames.GameFramework.NetworkPlayer, TzarGames.GameFramework.Player> _netPlayerMapping;
        private System.Collections.Generic.List<TzarGames.GameFramework.Player> _registeredPlayers;
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<TzarGames.GameFramework.RpcCallInfo>> sessionToRpcCalls;
        private System.Collections.Generic.List<TzarGames.GameFramework.NetworkViewID> allocatedViewIds;
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject, System.Collections.Generic.List<TzarGames.GameFramework.Player>> relatedObjects;
        [UnityEngine.SerializeField]
        private bool receiveDataFromOwnerPlayer;
        [UnityEngine.SerializeField]
        private bool checkLoginAndPassword;
        private bool enableSessions;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private int maximumSessions;
        [UnityEngine.SerializeField]
        private int playersPerSession;
        private GameSessionManager _sessionManager;
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<TzarGames.GameFramework.Player>> _sessionPlayerMapping;
        private bool isAuthorized;
        private System.Collections.Generic.Dictionary<string, string> _pendingPlayersAndPasswords;
        private System.Collections.Generic.List<string> loginsInInitProcess;
        private float connectionPendingTime;
        private const float authorizationPendingTime = 30;
        protected const string LoginKey = "login";
        
        // Properties
        public bool ReceiveDataFromOwnerPlayer { get; }
        public TzarGames.GameFramework.GameManager GameManager { get; }
        public bool CheckLoginAndPassword { get; }
        public bool IsSessionsEnabled { get; }
        public bool IsAuthorized { get; }
        public TzarGames.GameFramework.Player ServerPlayer { get; }
        public TzarGames.GameFramework.NetworkViewBase MyNetworkView { get; }
        public static bool Connected { get; }
        public static bool IsServer { get; }
        public static bool IsClient { get; }
        public static bool Connecting { get; }
        public static bool Disconnecting { get; }
        public static double NetworkTime { get; }
        
        // Methods
        protected GameManagerNetSyncBase()
        {
            this._netPlayerMapping = new System.Collections.Generic.Dictionary<TzarGames.GameFramework.NetworkPlayer, TzarGames.GameFramework.Player>();
            this._registeredPlayers = new System.Collections.Generic.List<TzarGames.GameFramework.Player>();
            this.sessionToRpcCalls = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<TzarGames.GameFramework.RpcCallInfo>>();
            this.allocatedViewIds = new System.Collections.Generic.List<TzarGames.GameFramework.NetworkViewID>();
            this.maximumSessions = 132;
            this.playersPerSession = 4;
            this.relatedObjects = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, System.Collections.Generic.List<TzarGames.GameFramework.Player>>();
            this._sessionPlayerMapping = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<TzarGames.GameFramework.Player>>();
            this._pendingPlayersAndPasswords = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this.connectionPendingTime = 60f;
            this.loginsInInitProcess = new System.Collections.Generic.List<System.String>();
        }
        public bool get_ReceiveDataFromOwnerPlayer()
        {
            return (bool)this.receiveDataFromOwnerPlayer;
        }
        public TzarGames.GameFramework.GameManager get_GameManager()
        {
            return (TzarGames.GameFramework.GameManager)this.gameManager;
        }
        public bool get_CheckLoginAndPassword()
        {
            return (bool)this.checkLoginAndPassword;
        }
        public bool get_IsSessionsEnabled()
        {
            return (bool)this.enableSessions;
        }
        public void AddPlayerToPendingList(string login, string password)
        {
            if((this._pendingPlayersAndPasswords.ContainsKey(key:  login)) != false)
            {
                    return;
            }
            
            this._pendingPlayersAndPasswords.Add(key:  login, value:  password);
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.pendingListCheck(login:  login));
        }
        public void DisconnectPlayerByLogin(string login)
        {
            var val_8;
            if((TzarGames.GameFramework.Player.GetPlayerByLogin(login:  0)) == null)
            {
                    return;
            }
            
            this = ???;
            val_8 = ???;
            goto typeof(TzarGames.GameFramework.GameManagerNetSyncBase).__il2cppRuntimeField_220;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator pendingListCheck(string login)
        {
            if(null != 0)
            {
                    typeof(GameManagerNetSyncBase.<pendingListCheck>c__Iterator0).__il2cppRuntimeField_10 = login;
            }
            else
            {
                    mem[16] = login;
            }
            
            typeof(GameManagerNetSyncBase.<pendingListCheck>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void RemovePlayerFromPendingList(string login)
        {
            if((this._pendingPlayersAndPasswords.ContainsKey(key:  login)) == false)
            {
                    return;
            }
            
            bool val_2 = this._pendingPlayersAndPasswords.Remove(key:  login);
        }
        public bool get_IsAuthorized()
        {
            return (bool)this.isAuthorized;
        }
        protected bool TryGetPasswordForLogin(string login, out string password)
        {
            if(this._pendingPlayersAndPasswords != null)
            {
                    return this._pendingPlayersAndPasswords.TryGetValue(key:  login, value: out  string val_1 = password);
            }
            
            return this._pendingPlayersAndPasswords.TryGetValue(key:  login, value: out  val_1);
        }
        public void InitializeLocalPlayer(TzarGames.GameFramework.Player localPlayer)
        {
            localPlayer.NetworkPlayer = this;
        }
        private void registerNetworkPlayer(TzarGames.GameFramework.Player player, TzarGames.GameFramework.NetworkPlayer networkPlayer, int sessionId)
        {
            var val_9;
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<TzarGames.GameFramework.Player>> val_13;
            TzarGames.GameFramework.NetworkPlayer val_14;
            System.Collections.Generic.List<TzarGames.GameFramework.Player> val_15;
            var val_16;
            System.Collections.Generic.Dictionary<TzarGames.GameFramework.NetworkPlayer, TzarGames.GameFramework.Player> val_17;
            if(player != null)
            {
                    val_14 = player;
                player.NetworkPlayer = networkPlayer;
            }
            else
            {
                    val_14 = 24;
                mem[24] = networkPlayer;
            }
            
            player.SessionID = sessionId;
            if((this._sessionPlayerMapping.ContainsKey(key:  sessionId)) != false)
            {
                    val_15 = this._sessionPlayerMapping.Item[sessionId];
            }
            else
            {
                    System.Collections.Generic.List<TzarGames.GameFramework.Player> val_4 = null;
                val_15 = val_4;
                val_4 = new System.Collections.Generic.List<TzarGames.GameFramework.Player>();
                val_13 = this._sessionPlayerMapping;
                val_13.Add(key:  sessionId, value:  val_15);
            }
            
            if((Contains(item:  player)) == true)
            {
                goto label_9;
            }
            
            List.Enumerator<T> val_7 = GetEnumerator();
            label_16:
            if((0 & 1) == 0)
            {
                goto label_11;
            }
            
            val_13.Add(item:  player);
            player.NeighbourPlayers.Add(item:  val_9.InitializationCallback);
            goto label_16;
            label_11:
            val_16 = 0;
            val_13 = 1;
            val_9.Dispose();
            Add(item:  player);
            label_9:
            val_17 = this._netPlayerMapping;
            if((val_17.ContainsKey(key:  val_14)) != true)
            {
                    val_17 = this._netPlayerMapping;
                val_17.Add(key:  mem[24], value:  player);
            }
            
            this._registeredPlayers.Add(item:  player);
        }
        private void unregisterNetworkPlayer(TzarGames.GameFramework.Player player)
        {
            var val_12;
            UnityEngine.Object val_32;
            var val_33;
            var val_34;
            TzarGames.GameFramework.NetworkPlayer val_35;
            var val_36;
            if(this.enableSessions != false)
            {
                    bool val_1 = this._sessionManager.RemovePlayer(player:  player);
            }
            
            if((this._sessionPlayerMapping.ContainsKey(key:  player.SessionID)) != false)
            {
                    bool val_4 = this._sessionPlayerMapping.Item[player.SessionID].Remove(item:  player);
            }
            
            if(0 == player.PlayerObject)
            {
                goto label_57;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_6 = player.PlayerObject.GetComponent<TzarGames.GameFramework.NetworkViewBase>();
            val_32 = val_6;
            if(0 != val_32)
            {
                    if(TzarGames.GameFramework.GameManagerNetSyncBase.Connected != false)
            {
                    val_32 = val_6;
            }
            
                this.UnallocateViewID(viewId:  val_6);
            }
            
            if(TzarGames.GameFramework.GameManagerNetSyncBase.IsServer == false)
            {
                goto label_57;
            }
            
            List.Enumerator<T> val_10 = player.NeighbourPlayers.GetEnumerator();
            label_50:
            if((0 & 1) == 0)
            {
                goto label_28;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_13 = val_12.InitializationCallback;
            if(val_13.itsMe == true)
            {
                goto label_50;
            }
            
            if(((val_6 & 1) & 1) == 0)
            {
                goto label_33;
            }
            
            if((this & 1) == 0)
            {
                goto label_50;
            }
            
            TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkPlayer> val_17 = new TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkPlayer>(object:  this, method:  System.Void TzarGames.GameFramework.GameManagerNetSyncBase::client_playerDisconnected(TzarGames.GameFramework.NetworkPlayer player));
            typeof(System.Object[]).__il2cppRuntimeField_20 = player.NetworkPlayer;
            this.myNetworkView.RPC<TzarGames.GameFramework.NetworkPlayer>(methodDelegate:  null, player:  val_13, args:  null);
            goto label_50;
            label_33:
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_13;
            UnityEngine.Debug.LogWarningFormat(format:  0, args:  "client_playerDisconnecnted fail player not connected {0}");
            goto label_50;
            label_28:
            val_12.Dispose();
            if(player.Login != null)
            {
                    if((this._pendingPlayersAndPasswords.ContainsKey(key:  player.Login)) != false)
            {
                    bool val_22 = this._pendingPlayersAndPasswords.Remove(key:  player.Login);
            }
            
            }
            
            label_57:
            if(player.itsMe != true)
            {
                    TzarGames.GameFramework.Player.Remove(player:  0);
            }
            
            List.Enumerator<T> val_25 = player.NeighbourPlayers.GetEnumerator();
            label_69:
            if((0 & 1) == 0)
            {
                goto label_66;
            }
            
            bool val_27 = 0.InitializationCallback.Remove(item:  player);
            goto label_69;
            label_66:
            val_33 = 0;
            val_34 = 1;
            0.Dispose();
            val_35 = player.NetworkPlayer;
            if(val_35 != null)
            {
                    val_36 = public System.Boolean System.Collections.Generic.Dictionary<TzarGames.GameFramework.NetworkPlayer, TzarGames.GameFramework.Player>::ContainsKey(TzarGames.GameFramework.NetworkPlayer key);
                if((this._netPlayerMapping.ContainsKey(key:  val_35)) != false)
            {
                    val_35 = this._netPlayerMapping;
                val_36 = public System.Boolean System.Collections.Generic.Dictionary<TzarGames.GameFramework.NetworkPlayer, TzarGames.GameFramework.Player>::Remove(TzarGames.GameFramework.NetworkPlayer key);
                bool val_29 = val_35.Remove(key:  player.NetworkPlayer);
            }
            
            }
            
            player.NetworkPlayer = 0;
            bool val_30 = this._registeredPlayers.Remove(item:  player);
        }
        protected bool IsPlayerRegistered(TzarGames.GameFramework.Player player)
        {
            if(this._registeredPlayers != null)
            {
                    return this._registeredPlayers.Contains(item:  player);
            }
            
            return this._registeredPlayers.Contains(item:  player);
        }
        protected abstract TzarGames.GameFramework.NetworkPlayer GetOrCreateNetworkPlayerForLocalPlayer(); // 0
        protected abstract TzarGames.GameFramework.NetworkPlayer[] GetAllNetworkPlayers(); // 0
        protected abstract void RemoveNetworkPlayer(TzarGames.GameFramework.NetworkPlayer player); // 0
        protected abstract TzarGames.GameFramework.NetworkPlayer InitializeServerPlayer(); // 0
        protected abstract bool ShouldSendClientDisconnectedEventToOtherClients(); // 0
        public TzarGames.GameFramework.Player get_ServerPlayer()
        {
            TzarGames.GameFramework.Player val_3;
            if(TzarGames.GameFramework.GameManagerNetSyncBase.Connected == false)
            {
                goto label_3;
            }
            
            if(TzarGames.GameFramework.GameManagerNetSyncBase.IsServer == false)
            {
                goto label_6;
            }
            
            if(this.gameManager != null)
            {
                    return this.gameManager.LocalPlayer;
            }
            
            return this.gameManager.LocalPlayer;
            label_3:
            val_3 = 0;
            return val_3;
            label_6:
            val_3 = this.serverPlayer;
            return val_3;
        }
        public System.Collections.Generic.List<TzarGames.GameFramework.Player> GetPlayersInSession(int sessionID)
        {
            var val_4;
            System.Collections.Generic.List<TzarGames.GameFramework.Player> val_1 = 0;
            if(this.enableSessions == false)
            {
                    return (System.Collections.Generic.List<TzarGames.GameFramework.Player>)TzarGames.GameFramework.Player.Players;
            }
            
            if((this._sessionPlayerMapping.TryGetValue(key:  sessionID, value: out  val_1)) == false)
            {
                    return (System.Collections.Generic.List<TzarGames.GameFramework.Player>)TzarGames.GameFramework.Player.Players;
            }
            
            val_4 = val_1;
            return (System.Collections.Generic.List<TzarGames.GameFramework.Player>)TzarGames.GameFramework.Player.Players;
        }
        private void OnSessionCreated(int sessionId)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "New session created (ID ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = sessionId;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = ") at time ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = UnityEngine.Time.time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            string val_2 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        private void OnSessionDestroyed(int sessionId)
        {
            string val_1 = 0 + "Session destroyed (ID " + sessionId;
            UnityEngine.Debug.Log(message:  0);
        }
        public TzarGames.GameFramework.Player GetPlayerByGameObject(UnityEngine.GameObject obj)
        {
            var val_5;
            var val_6;
            val_5 = obj;
            List.Enumerator<T> val_2 = TzarGames.GameFramework.Player.Players.GetEnumerator();
            label_8:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            val_6 = 0.InitializationCallback;
            if(0 != X21)
            {
                goto label_8;
            }
            
            0.Dispose();
            return (TzarGames.GameFramework.Player)val_6;
            label_4:
            0.Dispose();
            val_6 = 0;
            return (TzarGames.GameFramework.Player)val_6;
        }
        private void Awake()
        {
            UnityEngine.Object val_3;
            var val_4;
            val_3 = this.myNetworkView;
            if(0 == val_3)
            {
                    val_3 = public TzarGames.GameFramework.NetworkViewBase UnityEngine.Component::GetComponent<TzarGames.GameFramework.NetworkViewBase>();
                this.myNetworkView = this.GetComponent<TzarGames.GameFramework.NetworkViewBase>();
            }
            
            val_4 = null;
            val_4 = null;
            TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey = this;
        }
        protected abstract TzarGames.GameFramework.INetInfoProvider InitializeNetInfoProvider(); // 0
        public virtual void Initialize(TzarGames.GameFramework.GameManager targetGameManager)
        {
            TzarGames.GameFramework.NetworkPlayer val_5;
            this.gameManager = targetGameManager;
            TzarGames.GameFramework.Player val_1 = targetGameManager.LocalPlayer;
            val_5 = this;
            val_1.NetworkPlayer = val_5;
            if(this.enableSessions == false)
            {
                    return;
            }
            
            this._sessionManager = new GameSessionManager(maxPlayersPerSession:  this.playersPerSession, maxSessions:  this.maximumSessions, startGroupIndex:  2);
            typeof(GameSessionManager).__il2cppRuntimeField_10 = new GameSessionManager.SessionCallback(object:  this, method:  System.Void TzarGames.GameFramework.GameManagerNetSyncBase::OnSessionCreated(int sessionId));
            GameSessionManager.SessionCallback val_4 = null;
            val_5 = System.Void TzarGames.GameFramework.GameManagerNetSyncBase::OnSessionDestroyed(int sessionId);
            val_4 = new GameSessionManager.SessionCallback(object:  this, method:  val_5);
            this._sessionManager.onSessionDestroyed = val_4;
        }
        public void HandleRespawnPlayerObject(TzarGames.GameFramework.Player player, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        {
            if(TzarGames.GameFramework.GameManagerNetSyncBase.IsServer == false)
            {
                    return;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = player.NetworkPlayer;
            typeof(System.Object[]).__il2cppRuntimeField_28 = position;
            typeof(System.Object[]).__il2cppRuntimeField_30 = rotation;
            this.RPC<TzarGames.GameFramework.NetworkPlayer, UnityEngine.Vector3, UnityEngine.Quaternion>(method:  new TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkPlayer, UnityEngine.Vector3, UnityEngine.Quaternion>(object:  this, method:  System.Void TzarGames.GameFramework.GameManagerNetSyncBase::fromserver_respawn(TzarGames.GameFramework.NetworkPlayer netPlayer, UnityEngine.Vector3 location, UnityEngine.Quaternion rotation)), targetRpcMode:  2, parameters:  null);
        }
        private void sendClientMessage(TzarGames.GameFramework.Player player, TzarGames.GameFramework.GameserverMessages error)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = error;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            this.myNetworkView.RPC<System.Int32>(methodDelegate:  new TzarGames.GameFramework.RPCall<System.Int32>(object:  this, method:  System.Void TzarGames.GameFramework.GameManagerNetSyncBase::fromserver_message(int code)), player:  player.NetworkPlayer, args:  null);
        }
        [TzarRPC]
        protected void fromserver_message(int code)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = code;
            UnityEngine.Debug.LogFormat(format:  0, args:  "Server message: {0}");
            if(code != 1)
            {
                    return;
            }
            
            this.isAuthorized = true;
        }
        public TzarGames.GameFramework.NetworkViewBase get_MyNetworkView()
        {
            return (TzarGames.GameFramework.NetworkViewBase)this.myNetworkView;
        }
        public void RPC<A>(TzarGames.GameFramework.RPCall<A> method, TzarGames.GameFramework.TzarRPCModes targetRpcMode, object[] parameters)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_16 = parameters;
            val_17 = targetRpcMode;
            val_18 = this;
            val_19 = 1152921504721543168;
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_3 = this.MyNetworkView;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_5 = this.MyNetworkView;
            val_16 = ???;
            val_17 = ???;
            val_18 = ???;
            val_19 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public void RPC<A, B>(TzarGames.GameFramework.RPCall<A, B> method, TzarGames.GameFramework.TzarRPCModes targetRpcMode, object[] parameters)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_16 = parameters;
            val_17 = targetRpcMode;
            val_18 = this;
            val_19 = 1152921504721543168;
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_3 = this.MyNetworkView;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_5 = this.MyNetworkView;
            val_16 = ???;
            val_17 = ???;
            val_18 = ???;
            val_19 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public void RPC<A, B, C>(TzarGames.GameFramework.RPCall<A, B, C> method, TzarGames.GameFramework.TzarRPCModes targetRpcMode, object[] parameters)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_16 = parameters;
            val_17 = targetRpcMode;
            val_18 = this;
            val_19 = 1152921504721543168;
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_3 = this.MyNetworkView;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_5 = this.MyNetworkView;
            val_16 = ???;
            val_17 = ???;
            val_18 = ???;
            val_19 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public void RPC<A, B, C, D>(TzarGames.GameFramework.RPCall<A, B, C, D> method, TzarGames.GameFramework.TzarRPCModes targetRpcMode, object[] parameters)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_16 = parameters;
            val_17 = targetRpcMode;
            val_18 = this;
            val_19 = 1152921504721543168;
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_3 = this.MyNetworkView;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_5 = this.MyNetworkView;
            val_16 = ???;
            val_17 = ???;
            val_18 = ???;
            val_19 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public void RPC<A, B, C, D, E>(TzarGames.GameFramework.RPCall<A, B, C, D, E> method, TzarGames.GameFramework.TzarRPCModes targetRpcMode, object[] parameters)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_16 = parameters;
            val_17 = targetRpcMode;
            val_18 = this;
            val_19 = 1152921504721543168;
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_3 = this.MyNetworkView;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_5 = this.MyNetworkView;
            val_16 = ???;
            val_17 = ???;
            val_18 = ???;
            val_19 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public void RPC<A, B, C, D, E, F>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F> method, TzarGames.GameFramework.TzarRPCModes targetRpcMode, object[] parameters)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_16 = parameters;
            val_17 = targetRpcMode;
            val_18 = this;
            val_19 = 1152921504721543168;
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_3 = this.MyNetworkView;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_5 = this.MyNetworkView;
            val_16 = ???;
            val_17 = ???;
            val_18 = ???;
            val_19 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public void RPC<A, B, C, D, E, F, G>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G> method, TzarGames.GameFramework.TzarRPCModes targetRpcMode, object[] parameters)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_16 = parameters;
            val_17 = targetRpcMode;
            val_18 = this;
            val_19 = 1152921504721543168;
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_3 = this.MyNetworkView;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_5 = this.MyNetworkView;
            val_16 = ???;
            val_17 = ???;
            val_18 = ???;
            val_19 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public void RPC<A, B, C, D, E, F, G, H>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H> method, TzarGames.GameFramework.TzarRPCModes targetRpcMode, object[] parameters)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_16 = parameters;
            val_17 = targetRpcMode;
            val_18 = this;
            val_19 = 1152921504721543168;
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_3 = this.MyNetworkView;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_5 = this.MyNetworkView;
            val_16 = ???;
            val_17 = ???;
            val_18 = ???;
            val_19 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public void RPC<A, B, C, D, E, F, G, H, I>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I> method, TzarGames.GameFramework.TzarRPCModes targetRpcMode, object[] parameters)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_16 = parameters;
            val_17 = targetRpcMode;
            val_18 = this;
            val_19 = 1152921504721543168;
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_3 = this.MyNetworkView;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_5 = this.MyNetworkView;
            val_16 = ???;
            val_17 = ???;
            val_18 = ???;
            val_19 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public void RPC<A, B, C, D, E, F, G, H, I, J>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I, J> method, TzarGames.GameFramework.TzarRPCModes targetRpcMode, object[] parameters)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_16 = parameters;
            val_17 = targetRpcMode;
            val_18 = this;
            val_19 = 1152921504721543168;
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_3 = this.MyNetworkView;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_5 = this.MyNetworkView;
            val_16 = ???;
            val_17 = ???;
            val_18 = ???;
            val_19 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public void RPC<A, B, C, D, E, F, G, H, I, J, K>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I, J, K> method, TzarGames.GameFramework.TzarRPCModes targetRpcMode, object[] parameters)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_16 = parameters;
            val_17 = targetRpcMode;
            val_18 = this;
            val_19 = 1152921504721543168;
            if(0 == this.MyNetworkView)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_3 = this.MyNetworkView;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_5 = this.MyNetworkView;
            val_16 = ???;
            val_17 = ???;
            val_18 = ???;
            val_19 = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public TzarGames.GameFramework.Player GetPlayerByNetPlayer(TzarGames.GameFramework.NetworkPlayer netPlayer)
        {
            var val_3;
            if((this._netPlayerMapping.ContainsKey(key:  netPlayer)) != false)
            {
                    TzarGames.GameFramework.Player val_2 = this._netPlayerMapping.Item[netPlayer];
                return (TzarGames.GameFramework.Player)val_3;
            }
            
            val_3 = 0;
            return (TzarGames.GameFramework.Player)val_3;
        }
        public static int GetLastPing(TzarGames.GameFramework.Player player)
        {
            var val_4;
            string val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_6 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            if(val_6 != null)
            {
                    val_6 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
                var val_4 = 0;
                val_4 = val_4 + 1;
                val_7 = val_6;
            }
            else
            {
                    TzarGames.GameFramework.GameManagerNetSyncBase.logNetInfoProviderMessage();
                return 0;
            }
        
        }
        public static int GetPing(TzarGames.GameFramework.Player player)
        {
            var val_4;
            string val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_6 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            if(val_6 != null)
            {
                    val_6 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
                var val_4 = 0;
                val_4 = val_4 + 1;
                val_7 = val_6;
            }
            else
            {
                    TzarGames.GameFramework.GameManagerNetSyncBase.logNetInfoProviderMessage();
                return 0;
            }
        
        }
        public void AddGameObjectRelationship(UnityEngine.GameObject go, TzarGames.GameFramework.Player player)
        {
            if((this.relatedObjects.ContainsKey(key:  go)) != true)
            {
                    this.relatedObjects.Add(key:  go, value:  new System.Collections.Generic.List<TzarGames.GameFramework.Player>());
            }
            
            System.Collections.Generic.List<TzarGames.GameFramework.Player> val_4 = this.relatedObjects.Item[go];
            if((val_4.Contains(item:  player)) != false)
            {
                    return;
            }
            
            val_4.Add(item:  player);
        }
        public void RemoveGameObjectRelationship(UnityEngine.GameObject go, TzarGames.GameFramework.Player player)
        {
            if((this.relatedObjects.ContainsKey(key:  go)) == false)
            {
                    return;
            }
            
            bool val_3 = this.relatedObjects.Item[go].Remove(item:  player);
        }
        public void RemoveObjectFromRelationshipList(UnityEngine.GameObject go)
        {
            if((this.relatedObjects.ContainsKey(key:  go)) == false)
            {
                    return;
            }
            
            bool val_2 = this.relatedObjects.Remove(key:  go);
        }
        public bool IsObjectRelatedToPlayer(UnityEngine.GameObject go, TzarGames.GameFramework.Player player)
        {
            if((this.relatedObjects.ContainsKey(key:  go)) == false)
            {
                    return false;
            }
            
            System.Collections.Generic.List<TzarGames.GameFramework.Player> val_2 = this.relatedObjects.Item[go];
            if(val_2 != null)
            {
                    return val_2.Contains(item:  player);
            }
            
            return val_2.Contains(item:  player);
        }
        public abstract void NetDestroy(UnityEngine.GameObject obj); // 0
        public void DestroyRemoteNetworkView(TzarGames.GameFramework.NetworkViewBase targetNetworkView)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = targetNetworkView;
            this.RPC<TzarGames.GameFramework.NetworkViewID>(method:  new TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkViewID>(object:  this, method:  System.Void TzarGames.GameFramework.GameManagerNetSyncBase::client_removeObjectWithViewID(TzarGames.GameFramework.NetworkViewID id)), targetRpcMode:  3, parameters:  null);
        }
        [TzarRPC]
        protected void client_removeObjectWithViewID(TzarGames.GameFramework.NetworkViewID id)
        {
            var val_7;
            TzarGames.GameFramework.NetworkViewBase val_1 = this.FindNetworkViewByViewID(id:  id);
            if(0 == val_1)
            {
                goto label_3;
            }
            
            UnityEngine.GameObject val_5 = val_1.gameObject;
            val_7 = val_5;
            if((TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  val_1.gameObject)) == false)
            {
                goto label_6;
            }
            
            TzarGames.GameFramework.Instantiator.PushToPool(instanceObject:  val_5);
            return;
            label_3:
            val_7 = 0 + "NetworkView with given id not found. ViewID: "("NetworkView with given id not found. ViewID: ");
            UnityEngine.Debug.LogWarning(message:  0);
            return;
            label_6:
            UnityEngine.Object.Destroy(obj:  0);
        }
        public void BufferedRPC(System.Delegate methodDelegate, int sessionID, TzarGames.GameFramework.NetworkViewBase caller, bool callForConnectedPlayers, object[] parameters)
        {
            this.ObjectBufferedRPC(methodDelegate:  methodDelegate, sessionID:  sessionID, obj:  0, caller:  caller, callForConnectedPlayers:  callForConnectedPlayers, parameters:  parameters);
        }
        public void ObjectBufferedRPC(System.Delegate methodDelegate, int sessionID, object obj, TzarGames.GameFramework.NetworkViewBase caller, bool callForConnectedPlayers, object[] parameters)
        {
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<TzarGames.GameFramework.RpcCallInfo>> val_6;
            if(TzarGames.GameFramework.GameManagerNetSyncBase.IsServer != false)
            {
                    if(callForConnectedPlayers != false)
            {
                    caller.RPC(methodDelegate:  methodDelegate, mode:  2, args:  parameters);
            }
            
                val_6 = this.sessionToRpcCalls;
                if((val_6.ContainsKey(key:  sessionID)) != true)
            {
                    val_6 = this.sessionToRpcCalls;
                val_6.Add(key:  sessionID, value:  new System.Collections.Generic.List<TzarGames.GameFramework.RpcCallInfo>());
            }
            
                this.sessionToRpcCalls.Item[sessionID].Add(item:  new TzarGames.GameFramework.RpcCallInfo() {methodDelegate = methodDelegate, caller = caller, relatedObject = obj, SessionID = parameters, paramGetFunc = ???});
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  0);
        }
        public void DynamicBufferedRPC(System.Delegate methodDelegate, int sessionID, TzarGames.GameFramework.NetworkViewBase caller, TzarGames.GameFramework.GameManager.dlgGetParameters paramGetFunc)
        {
            if(TzarGames.GameFramework.GameManagerNetSyncBase.IsServer != false)
            {
                    caller.RPC(methodDelegate:  methodDelegate, mode:  2, args:  paramGetFunc.Invoke());
            }
            
            if((this.sessionToRpcCalls.ContainsKey(key:  sessionID)) != true)
            {
                    this.sessionToRpcCalls.Add(key:  sessionID, value:  new System.Collections.Generic.List<TzarGames.GameFramework.RpcCallInfo>());
            }
            
            this.sessionToRpcCalls.Item[sessionID].Add(item:  new TzarGames.GameFramework.RpcCallInfo() {methodDelegate = methodDelegate, caller = caller, parameters = paramGetFunc});
        }
        public void RemoveCustomBufferedRpcByMethodName(TzarGames.GameFramework.NetworkViewBase caller, string methodName)
        {
            var val_2;
            var val_8;
            UnityEngine.Object val_9;
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<TzarGames.GameFramework.RpcCallInfo>> val_14;
            string val_15;
            var val_16;
            var val_17;
            val_14 = this.sessionToRpcCalls;
            Dictionary.Enumerator<TKey, TValue> val_1 = val_14.GetEnumerator();
            goto label_4;
            label_16:
            UnityEngine.Playables.PlayableHandle val_4 = val_2.GetHandle();
            val_14;
            int val_6 = val_4.m_Handle.Count - 1;
            if((val_6 & 2147483648) == 0)
            {
                    do
            {
                TzarGames.GameFramework.RpcCallInfo val_7 = val_4.m_Handle.Item[val_6];
                val_15 = val_8;
                if(0 == val_9)
            {
                    val_15 = val_15.Method;
                if((System.String.op_Equality(a:  0, b:  val_15)) != false)
            {
                    val_4.m_Handle.RemoveAt(index:  val_6);
            }
            
            }
            
                val_6 = val_6 - 1;
            }
            while((val_6 & 2147483648) == 0);
            
            }
            
            label_4:
            if((0 & 1) != 0)
            {
                goto label_16;
            }
            
            val_16 = 0;
            val_17 = 1;
            val_2.Dispose();
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        public void RemoveCustomBufferedRPCsByCaller(TzarGames.GameFramework.NetworkViewBase caller)
        {
            var val_2;
            UnityEngine.Object val_7;
            int val_11;
            var val_12;
            var val_13;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.sessionToRpcCalls.GetEnumerator();
            goto label_4;
            label_11:
            UnityEngine.Playables.PlayableHandle val_4 = val_2.GetHandle();
            val_11 = val_4.m_Handle.Count - 1;
            if((val_11 & 2147483648) == 0)
            {
                    do
            {
                TzarGames.GameFramework.RpcCallInfo val_6 = val_4.m_Handle.Item[val_11];
                if(0 == val_7)
            {
                    val_4.m_Handle.RemoveAt(index:  val_11);
            }
            
                val_11 = val_11 - 1;
            }
            while((val_11 & 2147483648) == 0);
            
            }
            
            label_4:
            if((0 & 1) != 0)
            {
                goto label_11;
            }
            
            val_12 = 0;
            val_13 = 1;
            val_2.Dispose();
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        public void RemoveCustomBufferedRpcByObject(object related)
        {
            var val_5;
            int val_7;
            var val_8;
            var val_9;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.sessionToRpcCalls.GetEnumerator();
            goto label_4;
            label_9:
            UnityEngine.Playables.PlayableHandle val_2 = 0.GetHandle();
            val_7 = val_2.m_Handle.Count - 1;
            if((val_7 & 2147483648) == 0)
            {
                    do
            {
                TzarGames.GameFramework.RpcCallInfo val_4 = val_2.m_Handle.Item[val_7];
                if(val_5 == related)
            {
                    val_2.m_Handle.RemoveAt(index:  val_7);
            }
            
                val_7 = val_7 - 1;
            }
            while((val_7 & 2147483648) == 0);
            
            }
            
            label_4:
            if((0 & 1) != 0)
            {
                goto label_9;
            }
            
            val_8 = 0;
            val_9 = 1;
            0.Dispose();
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        private void executeBufferedRpcsForPlayer(TzarGames.GameFramework.Player player)
        {
            UnityEngine.Object val_7;
            var val_16;
            System.Delegate val_18;
            var val_19;
            System.Object[] val_20;
            var val_21;
            var val_25;
            TzarGames.GameFramework.NetworkPlayer val_26;
            var val_27;
            var val_28;
            val_25 = player;
            val_26 = player.NetworkPlayer;
            if(((val_26 & 1) & 1) == 0)
            {
                goto label_3;
            }
            
            val_26 = this.sessionToRpcCalls;
            if((val_26.TryGetValue(key:  player.SessionID, value: out  0)) == false)
            {
                    return;
            }
            
            int val_5 = val_2.Count - 1;
            if((val_5 & 2147483648) != 0)
            {
                goto label_8;
            }
            
            label_17:
            TzarGames.GameFramework.RpcCallInfo val_6 = val_2.Item[val_5];
            if(0 != val_7)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
            {
                goto label_15;
            }
            
            }
            
            val_2.RemoveAt(index:  val_5);
            label_15:
            val_5 = val_5 - 1;
            if((val_5 & 2147483648) == 0)
            {
                goto label_17;
            }
            
            label_8:
            val_26 = this.sessionToRpcCalls;
            if((val_26.ContainsKey(key:  player.SessionID)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_13 = this.sessionToRpcCalls.Item[player.SessionID].GetEnumerator();
            label_33:
            if((0 & 1) == 0)
            {
                goto label_24;
            }
            
            if(((val_19 & 1) & 1) != 0)
            {
                goto label_33;
            }
            
            if(val_20 == 0)
            {
                goto label_27;
            }
            
            val_19.RPC(methodDelegate:  val_18, player:  player.NetworkPlayer, args:  val_20);
            goto label_33;
            label_27:
            val_19.RPC(methodDelegate:  val_18, player:  player.NetworkPlayer, args:  val_21.Invoke());
            goto label_33;
            label_3:
            val_25 = 0 + "Exec rpc failed - player not connected "("Exec rpc failed - player not connected ");
            UnityEngine.Debug.LogWarning(message:  0);
            return;
            label_24:
            val_27 = 0;
            val_28 = 1;
            val_16.Dispose();
            if((val_28 & 1) != 0)
            {
                    return;
            }
            
            if(val_27 == 0)
            {
                    return;
            }
        
        }
        private void updateRelationsForPlayer(TzarGames.GameFramework.Player player)
        {
            var val_2;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.relatedObjects.GetEnumerator();
            do
            {
                label_13:
                if((0 & 1) == 0)
            {
                goto label_16;
            }
            
                UnityEngine.Playables.PlayableHandle val_4 = val_2.GetHandle();
            }
            while(0 == val_4.m_Handle.InitializationCallback);
            
            if(0 == (val_4.m_Handle.InitializationCallback.GetComponent<TzarGames.GameFramework.NetworkViewBase>()))
            {
                goto label_13;
            }
            
            if(((val_4.m_Handle.Contains(item:  player)) == true) || (player != null))
            {
                goto label_13;
            }
            
            goto label_13;
            label_16:
            val_2.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        protected abstract void SetNetViewVisibilityForPlayer(TzarGames.GameFramework.NetworkPlayer player, TzarGames.GameFramework.NetworkViewBase netView, bool visible); // 0
        public void UnallocateViewID(TzarGames.GameFramework.NetworkViewID viewId)
        {
            if((TzarGames.GameFramework.NetworkViewID.op_Equality(a:  0, b:  viewId)) == true)
            {
                    return;
            }
            
            if(((viewId & 1) & 1) == 0)
            {
                goto typeof(TzarGames.GameFramework.GameManagerNetSyncBase).__il2cppRuntimeField_1E0;
            }
        
        }
        protected abstract void Handle_UnallocateViewID(TzarGames.GameFramework.NetworkViewID viewId); // 0
        protected virtual void Handle_OnDisconnectedFromServer()
        {
            int val_5;
            System.Collections.Generic.List<TzarGames.GameFramework.Player> val_1 = TzarGames.GameFramework.Player.Players;
            UnityEngine.Debug.Log(message:  0);
            val_5 = val_1.Count - 1;
            if((val_5 & 2147483648) == 0)
            {
                    do
            {
                this.playerDisconnected(player:  val_1.Item[val_5]);
                val_5 = val_5 - 1;
            }
            while((val_5 & 2147483648) == 0);
            
            }
            
            this.allocatedViewIds.Clear();
            this.loginsInInitProcess.Clear();
            this.isAuthorized = false;
            this.serverPlayer = 0;
        }
        public TzarGames.GameFramework.NetworkViewID AllocateNetworkViewID()
        {
            goto typeof(TzarGames.GameFramework.GameManagerNetSyncBase).__il2cppRuntimeField_200;
        }
        protected abstract TzarGames.GameFramework.NetworkViewID Handle_AllocateNetworkViewID(); // 0
        public void SetNetworkViewIdTo(UnityEngine.GameObject obj, TzarGames.GameFramework.NetworkViewID viewID)
        {
            TzarGames.GameFramework.Player val_2 = this.ServerPlayer;
            if((obj.GetComponent<TzarGames.GameFramework.NetworkViewBase>()) == null)
            {
                
            }
        
        }
        public static TzarGames.GameFramework.NetworkViewID GetNetworkViewIdFrom(UnityEngine.GameObject obj)
        {
            if((X1.GetComponent<TzarGames.GameFramework.NetworkViewBase>()) == null)
            {
                
            }
        
        }
        private static void logNetInfoProviderMessage()
        {
            UnityEngine.Debug.LogWarning(message:  0);
        }
        public static bool get_Connected()
        {
            var val_2;
            string val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            if(val_3 == null)
            {
                    return false;
            }
            
            val_3 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            if(val_3 != null)
            {
                    val_4 = val_3;
            }
            
            label_11:
            var val_2 = 0;
            val_2 = val_2 + 1;
            goto label_11;
        }
        public static bool get_IsServer()
        {
            var val_2;
            string val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            if(val_3 == null)
            {
                    return false;
            }
            
            val_3 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            if(val_3 != null)
            {
                    val_4 = val_3;
            }
            
            label_11:
            var val_2 = 0;
            val_2 = val_2 + 1;
            goto label_11;
        }
        public static bool get_IsClient()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_3 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            goto x2;
        }
        public static bool get_Connecting()
        {
            var val_4;
            string val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_6 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            if(val_6 == null)
            {
                goto label_3;
            }
            
            val_6 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            if(val_6 != null)
            {
                    val_7 = val_6;
            }
            
            label_13:
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_13;
            label_3:
            TzarGames.GameFramework.GameManagerNetSyncBase.logNetInfoProviderMessage();
            return false;
        }
        public static bool get_Disconnecting()
        {
            var val_4;
            string val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_6 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            if(val_6 == null)
            {
                goto label_3;
            }
            
            val_6 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            if(val_6 != null)
            {
                    val_7 = val_6;
            }
            
            label_13:
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_13;
            label_3:
            TzarGames.GameFramework.GameManagerNetSyncBase.logNetInfoProviderMessage();
            return false;
        }
        public static double get_NetworkTime()
        {
            var val_4;
            string val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_6 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            if(val_6 == null)
            {
                goto label_3;
            }
            
            val_6 = TzarGames.GameFramework.GameManagerNetSyncBase.LoginKey;
            if(val_6 != null)
            {
                    val_7 = val_6;
            }
            
            label_13:
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_13;
            label_3:
            TzarGames.GameFramework.GameManagerNetSyncBase.logNetInfoProviderMessage();
            return -1;
        }
        public abstract TzarGames.GameFramework.INetworkMessageInfo CreateNetworkMessageInfo(TzarGames.GameFramework.NetworkPlayer player); // 0
        public abstract void CloseConnection(TzarGames.GameFramework.Player player, bool sendDisconnectNotification); // 0
        [TzarRPC]
        protected void fromserver_respawn(TzarGames.GameFramework.NetworkPlayer netPlayer, UnityEngine.Vector3 location, UnityEngine.Quaternion rotation)
        {
            this.gameManager.RespawnPlayerObject(player:  this.GetPlayerByNetPlayer(netPlayer:  netPlayer), position:  new UnityEngine.Vector3() {x = location.x, y = location.y, z = location.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator handleConnectedPlayer(TzarGames.GameFramework.Player newPlayer)
        {
            if(null != 0)
            {
                    typeof(GameManagerNetSyncBase.<handleConnectedPlayer>c__Iterator1).__il2cppRuntimeField_10 = newPlayer;
            }
            else
            {
                    mem[16] = newPlayer;
            }
            
            typeof(GameManagerNetSyncBase.<handleConnectedPlayer>c__Iterator1).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [TzarRPC]
        protected void client_playerEnteredToGame(TzarGames.GameFramework.NetworkPlayer netPlayer)
        {
            if(netPlayer == null)
            {
                    return;
            }
            
            TzarGames.GameFramework.Player val_1 = this.GetPlayerByNetPlayer(netPlayer:  netPlayer);
            UnityEngine.Coroutine val_2 = this.gameManager.StartCoroutine(routine:  this.gameManager);
        }
        protected void Handle_OnPlayerDisconnected(TzarGames.GameFramework.NetworkPlayer player)
        {
            TzarGames.GameFramework.Player val_1 = 0;
            if((this._netPlayerMapping.TryGetValue(key:  player, value: out  val_1)) == false)
            {
                    return;
            }
            
            if(val_1 == 0)
            {
                    return;
            }
            
            this.playerDisconnected(player:  val_1);
        }
        protected void Handle_OnServerInitialized()
        {
            UnityEngine.Object val_14;
            TzarGames.GameFramework.GameManager val_15;
            UnityEngine.Debug.Log(message:  0);
            val_14 = this.gameManager;
            if(0 == val_14)
            {
                    val_14 = public TzarGames.GameFramework.GameManager UnityEngine.Component::GetComponent<TzarGames.GameFramework.GameManager>();
                val_15 = this.GetComponent<TzarGames.GameFramework.GameManager>();
                this.gameManager = val_15;
            }
            else
            {
                    val_15 = this.gameManager;
            }
            
            TzarGames.GameFramework.Player val_4 = val_15.LocalPlayer;
            val_4.NetworkPlayer = this;
            TzarGames.GameFramework.Player val_5 = this.ServerPlayer;
            val_5.NetworkPlayer = this;
            if(this.gameManager.enterMatchWhenOffline != true)
            {
                    TzarGames.GameFramework.Player val_6 = this.ServerPlayer;
                if(0 != val_6.PlayerObject)
            {
                    UnityEngine.Debug.Log(message:  0);
                TzarGames.GameFramework.Player val_8 = this.ServerPlayer;
                UnityEngine.Object.Destroy(obj:  0);
                TzarGames.GameFramework.Player val_9 = this.ServerPlayer;
                val_9.PlayerObject = 0;
                TzarGames.GameFramework.Player val_10 = this.ServerPlayer;
                val_10.PlayerComponent = 0;
            }
            
            }
            
            UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  this.playerReadyCoroutine(player:  this.ServerPlayer));
        }
        protected void Handle_OnPlayerConnected(TzarGames.GameFramework.NetworkPlayer connectedPlayer, System.Collections.Generic.Dictionary<string, object> localData)
        {
            int val_3;
            var val_7;
            var val_8;
            object val_9;
            if((localData != null) && (localData.Count >= 1))
            {
                    val_7 = localData.Item["login"];
                if(val_7 != null)
            {
                    if(null == null)
            {
                goto label_5;
            }
            
            }
            
                val_7 = 0;
            }
            else
            {
                    if(this.checkLoginAndPassword != false)
            {
                    val_3 = UnityEngine.Random.Range(min:  0, max:  0);
                val_8 = val_3;
                val_9 = "Unknown player ";
            }
            else
            {
                    val_3 = connectedPlayer;
                val_8 = val_3;
                val_9 = "Player ";
            }
            
                val_7 = 0 + val_9;
            }
            
            label_5:
            val_6.NetworkPlayer = connectedPlayer;
            this._netPlayerMapping.Add(key:  connectedPlayer, value:  TzarGames.GameFramework.Player.Create(login:  0));
        }
        [TzarRPC]
        protected void fromclient_ready(TzarGames.GameFramework.INetworkMessageInfo info)
        {
            var val_10;
            var val_11;
            TzarGames.GameFramework.NetworkPlayer val_12;
            val_10 = this;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = info;
            val_12 = info;
            if(val_12 == null)
            {
                    return;
            }
            
            if((val_12 & 1) == 0)
            {
                    return;
            }
            
            TzarGames.GameFramework.Player val_2 = this.GetPlayerByNetPlayer(netPlayer:  val_12);
            if(val_2 != null)
            {
                    val_12 = this.loginsInInitProcess;
                if((val_12.Contains(item:  val_2.Login)) == true)
            {
                    return;
            }
            
                if((this.IsPlayerRegistered(player:  val_2)) == true)
            {
                    return;
            }
            
                UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.playerReadyCoroutine(player:  val_2));
                return;
            }
            
            val_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_12;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            UnityEngine.Debug.LogErrorFormat(format:  0, args:  "Failed to get player by info.sender with ID: {0}");
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator playerReadyCoroutine(TzarGames.GameFramework.Player player)
        {
            if(null != 0)
            {
                    typeof(GameManagerNetSyncBase.<playerReadyCoroutine>c__Iterator2).__il2cppRuntimeField_10 = player;
            }
            else
            {
                    mem[16] = player;
            }
            
            typeof(GameManagerNetSyncBase.<playerReadyCoroutine>c__Iterator2).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [TzarRPC]
        protected void client_playerDisconnected(TzarGames.GameFramework.NetworkPlayer player)
        {
            this.Handle_OnPlayerDisconnected(player:  player);
        }
        private TzarGames.GameFramework.NetworkViewID SpawnPlayerOnClients(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, TzarGames.GameFramework.Player player, byte[] data)
        {
            var val_5;
            var val_11;
            TzarGames.GameFramework.NetworkViewBase val_12;
            TzarGames.GameFramework.GameManagerNetSyncBase val_13;
            var val_15;
            var val_16;
            var val_17;
            val_11 = data;
            val_12 = this.myNetworkView;
            val_13 = this;
            if(val_11 == null)
            {
                    val_11 = null;
            }
            
            if(this.enableSessions != false)
            {
                    System.Collections.Generic.List<TzarGames.GameFramework.Player> val_1 = this._sessionPlayerMapping.Item[player.SessionID];
            }
            else
            {
                    System.Collections.Generic.List<TzarGames.GameFramework.Player> val_2 = TzarGames.GameFramework.Player.Players;
            }
            
            if(val_2 == null)
            {
                    return (TzarGames.GameFramework.NetworkViewID)val_13;
            }
            
            List.Enumerator<T> val_3 = val_2.GetEnumerator();
            label_48:
            if((0 & 1) == 0)
            {
                goto label_9;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_6 = val_5.InitializationCallback;
            if(val_6 == null)
            {
                goto label_10;
            }
            
            if(val_6 == null)
            {
                goto label_11;
            }
            
            val_6.GetObjectData(info:  public System.Void System.MulticastDelegate::GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context), context:  new System.Runtime.Serialization.StreamingContext() {state = data});
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_7 = val_6 & 1;
            if(((val_7 & 1) != 0) || ((val_6.IsConnected == false) || (val_7 != null)))
            {
                goto label_48;
            }
            
            val_15 = val_11;
            if(player == val_6)
            {
                    val_15 = val_11;
                if(this.receiveDataFromOwnerPlayer != false)
            {
                    val_15 = null;
            }
            
            }
            
            TzarGames.GameFramework.RPCall<UnityEngine.Vector3, UnityEngine.Quaternion, TzarGames.GameFramework.NetworkViewID, TzarGames.GameFramework.NetworkPlayer, System.Int32, System.Byte[]> val_9 = new TzarGames.GameFramework.RPCall<UnityEngine.Vector3, UnityEngine.Quaternion, TzarGames.GameFramework.NetworkViewID, TzarGames.GameFramework.NetworkPlayer, System.Int32, System.Byte[]>(object:  this, method:  System.Void TzarGames.GameFramework.GameManagerNetSyncBase::SpawnPlayerRemote(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, TzarGames.GameFramework.NetworkViewID id, TzarGames.GameFramework.NetworkPlayer networkPlayer, int sessionId, byte[] dataBytes));
            typeof(System.Object[]).__il2cppRuntimeField_20 = position;
            typeof(System.Object[]).__il2cppRuntimeField_28 = rotation;
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_13;
            typeof(System.Object[]).__il2cppRuntimeField_38 = player.NetworkPlayer;
            val_16 = System.Object[].__il2cppRuntimeField_namespaze;
            typeof(System.Object[]).__il2cppRuntimeField_40 = System.Object[].__il2cppRuntimeField_namespaze;
            typeof(System.Object[]).__il2cppRuntimeField_44 = 268435457;
            if(null != null)
            {
                    val_16 = val_15;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_48 = val_15;
            val_12.RPC<UnityEngine.Vector3, UnityEngine.Quaternion, TzarGames.GameFramework.NetworkViewID, TzarGames.GameFramework.NetworkPlayer, System.Int32, System.Byte[]>(methodDelegate:  null, player:  1152921511377518576, args:  null);
            goto label_48;
            label_10:
            UnityEngine.Debug.LogError(message:  0);
            goto label_48;
            label_11:
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_6.Login;
            UnityEngine.Debug.LogErrorFormat(format:  0, args:  "NetworkPlayer is null for player {0}");
            goto label_48;
            label_9:
            val_17 = 0;
            val_12 = 1;
            val_13 = val_13;
            val_5.Dispose();
            if((val_12 & 1) != 0)
            {
                    return (TzarGames.GameFramework.NetworkViewID)val_13;
            }
            
            if(val_17 == 0)
            {
                    return (TzarGames.GameFramework.NetworkViewID)val_13;
            }
            
            return (TzarGames.GameFramework.NetworkViewID)val_13;
        }
        [TzarRPC]
        protected void SpawnPlayerRemote(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, TzarGames.GameFramework.NetworkViewID id, TzarGames.GameFramework.NetworkPlayer networkPlayer, int sessionId, byte[] dataBytes)
        {
            System.Byte[] val_11;
            TzarGames.GameFramework.Player val_13;
            val_11 = dataBytes;
            TzarGames.GameFramework.Player val_3 = 0;
            if(networkPlayer == null)
            {
                    return;
            }
            
            if((TzarGames.GameFramework.NetworkViewID.op_Equality(a:  0, b:  id)) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            if((networkPlayer & 1) == 0)
            {
                goto label_6;
            }
            
            TzarGames.GameFramework.Player val_2 = this.gameManager.LocalPlayer;
            goto label_8;
            label_6:
            if((this._netPlayerMapping.TryGetValue(key:  networkPlayer, value: out  val_3)) == false)
            {
                goto label_10;
            }
            
            val_13 = val_3;
            goto label_11;
            label_10:
            string val_5 = 0 + "Player ";
            label_8:
            val_13 = TzarGames.GameFramework.Player.Create(login:  0);
            label_11:
            val_6.NetworkPlayer = networkPlayer;
            val_11 = this.gameManager.SpawnObjectForPlayer(player:  val_13, position:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, rotation:  new UnityEngine.Quaternion() {x = rot.x, y = rot.y, z = rot.z, w = rot.w}, playerData:  val_11);
            mem2[0] = sessionId;
            this.registerNetworkPlayer(player:  val_13, networkPlayer:  networkPlayer, sessionId:  sessionId);
            this.allocatedViewIds.Add(item:  id);
            if(0 != (val_11.GetComponent<TzarGames.GameFramework.NetworkViewBase>()))
            {
                    TzarGames.GameFramework.Player val_10 = this.ServerPlayer;
                val_11 = val_10.NetworkPlayer;
                if(this.enableSessions == false)
            {
                    return;
            }
            
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  0);
        }
        protected virtual void SetupPlayerObjectNetworkView(TzarGames.GameFramework.Player player, TzarGames.GameFramework.NetworkViewBase networkView)
        {
        
        }
        protected void Handle_OnConnectedToServer()
        {
            var val_12;
            TzarGames.GameFramework.Player val_13;
            var val_14;
            TzarGames.GameFramework.Player val_1 = this.gameManager.LocalPlayer;
            val_1.NetworkPlayer = this;
            val_13 = this.serverPlayer;
            if(val_13 == null)
            {
                    val_12 = "Server";
                val_13 = TzarGames.GameFramework.Player.Create(login:  0);
                this.serverPlayer = val_13;
            }
            
            val_2.NetworkPlayer = this;
            this.registerNetworkPlayer(player:  this.serverPlayer, networkPlayer:  this.serverPlayer.NetworkPlayer, sessionId:  0);
            val_14 = 0;
            goto label_8;
            label_31:
            val_14 = 1;
            label_8:
            if(val_14 >= this.gameManager)
            {
                goto label_10;
            }
            
            if(((this._netPlayerMapping.TryGetValue(key:  (TzarGames.GameFramework.GameManagerNetSyncBase)[1152921511378270512].myNetworkView, value: out  0)) == true) || ((((TzarGames.GameFramework.GameManagerNetSyncBase)[1152921511378270512].myNetworkView & 1) & 1) != 0))
            {
                goto label_31;
            }
            
            string val_7 = 0 + "Player ";
            if((TzarGames.GameFramework.Player.GetPlayerByLogin(login:  0)) != null)
            {
                goto label_20;
            }
            
            TzarGames.GameFramework.Player val_9 = TzarGames.GameFramework.Player.Create(login:  0);
            if(val_9 == null)
            {
                goto label_23;
            }
            
            label_20:
            val_9.NetworkPlayer = (TzarGames.GameFramework.GameManagerNetSyncBase)[1152921511378270512].myNetworkView;
            this._netPlayerMapping.Add(key:  (TzarGames.GameFramework.GameManagerNetSyncBase)[1152921511378270512].myNetworkView, value:  val_9);
            goto label_31;
            label_23:
            string val_10 = 0 + "Failed to create player for net ID: "("Failed to create player for net ID: ");
            UnityEngine.Debug.LogError(message:  0);
            goto label_31;
            label_10:
            this.myNetworkView.RPC<TzarGames.GameFramework.INetworkMessageInfo>(methodDelegate:  new TzarGames.GameFramework.RPCall<TzarGames.GameFramework.INetworkMessageInfo>(object:  this, method:  System.Void TzarGames.GameFramework.GameManagerNetSyncBase::fromclient_ready(TzarGames.GameFramework.INetworkMessageInfo info)), mode:  5, args:  null);
        }
        public void SpawnOtherPlayersForPlayer(TzarGames.GameFramework.Player player)
        {
            var val_3;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            List.Enumerator<T> val_1 = player.NeighbourPlayers.GetEnumerator();
            label_80:
            if((0 & 1) == 0)
            {
                goto label_83;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = val_3.InitializationCallback;
            if(((X22 & 1) & 1) == 0)
            {
                goto label_6;
            }
            
            if((X22 == player.NetworkPlayer) || (0 == X22))
            {
                goto label_80;
            }
            
            TzarGames.GameFramework.NetworkViewBase val_7 = X22.GetComponent<TzarGames.GameFramework.NetworkViewBase>();
            if(0 == val_7)
            {
                goto label_18;
            }
            
            if(((val_7 & 1) & 1) == 0)
            {
                goto label_20;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_4.Login;
            UnityEngine.Debug.LogErrorFormat(format:  0, args:  "NetworkView ID for player {0} is unassigned, failed to call SpawnPlayerRemote");
            goto label_80;
            label_6:
            typeof(System.Object[]).__il2cppRuntimeField_20 = player.NetworkPlayer;
            UnityEngine.Debug.LogWarningFormat(format:  0, args:  "SpawnOtherPlayersForPlayer - player not connected {0}");
            goto label_80;
            label_18:
            UnityEngine.Debug.LogError(message:  0);
            goto label_80;
            label_20:
            var val_19 = X22;
            if((X22 + 258) == 0)
            {
                goto label_42;
            }
            
            var val_16 = X22 + 152;
            var val_17 = 0;
            val_16 = val_16 + 8;
            label_44:
            if(((X22 + 152 + 8) + -8) == null)
            {
                goto label_43;
            }
            
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            if(val_17 < (X22 + 258))
            {
                goto label_44;
            }
            
            label_42:
            val_17 = X22;
            goto label_45;
            label_43:
            var val_18 = val_16;
            val_18 = val_18 + 4;
            val_19 = val_19 + val_18;
            val_17 = val_19 + 272;
            label_45:
            val_18 = mem[((X22 + ((X22 + 152 + 8) + 4)) + 272) + 8];
            val_18 = ((X22 + ((X22 + 152 + 8) + 4)) + 272) + 8;
            val_19 = X22;
            if(val_19 == 0)
            {
                    val_18 = 0;
                val_19 = null;
            }
            
            TzarGames.GameFramework.RPCall<UnityEngine.Vector3, UnityEngine.Quaternion, TzarGames.GameFramework.NetworkViewID, TzarGames.GameFramework.NetworkPlayer, System.Int32, System.Byte[]> val_11 = new TzarGames.GameFramework.RPCall<UnityEngine.Vector3, UnityEngine.Quaternion, TzarGames.GameFramework.NetworkViewID, TzarGames.GameFramework.NetworkPlayer, System.Int32, System.Byte[]>(object:  this, method:  System.Void TzarGames.GameFramework.GameManagerNetSyncBase::SpawnPlayerRemote(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, TzarGames.GameFramework.NetworkViewID id, TzarGames.GameFramework.NetworkPlayer networkPlayer, int sessionId, byte[] dataBytes));
            UnityEngine.Vector3 val_13 = X28.transform.position;
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_13;
            UnityEngine.Quaternion val_15 = val_13.transform.rotation;
            if(val_15 != 0)
            {
                    val_20 = mem[null + 48];
                if(val_15 == 0)
            {
                    val_20 = 0;
            }
            
            }
            
            val_20 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_15;
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_7;
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_4;
            if(player.SessionID != 0)
            {
                    val_21 = mem[null + 48];
                if(player.SessionID == 0)
            {
                    val_21 = 0;
            }
            
            }
            
            val_21 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_40 = player.SessionID;
            typeof(System.Object[]).__il2cppRuntimeField_44 = 268435457;
            if(null != null)
            {
                    val_21 = mem[null + 48];
                if(null == null)
            {
                    val_21 = 0;
            }
            
            }
            
            val_21 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_48 = val_19;
            mem[1152921511378512208].RPC<UnityEngine.Vector3, UnityEngine.Quaternion, TzarGames.GameFramework.NetworkViewID, TzarGames.GameFramework.NetworkPlayer, System.Int32, System.Byte[]>(methodDelegate:  null, player:  player.NetworkPlayer, args:  null);
            goto label_80;
            label_83:
            val_3.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(mem[1152921511378512208] == 0)
            {
                    return;
            }
        
        }
        public virtual void RemoveRPCs(TzarGames.GameFramework.NetworkViewBase netView)
        {
            this.RemoveCustomBufferedRPCsByCaller(caller:  netView);
        }
        public void DestroyOnOthers(UnityEngine.GameObject obj)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = obj.GetComponent<TzarGames.GameFramework.NetworkViewBase>();
            this.RPC<TzarGames.GameFramework.NetworkViewID>(method:  new TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkViewID>(object:  this, method:  System.Void TzarGames.GameFramework.GameManagerNetSyncBase::rpc_destroyObject(TzarGames.GameFramework.NetworkViewID id)), targetRpcMode:  3, parameters:  null);
        }
        [TzarRPC]
        protected void rpc_destroyObject(TzarGames.GameFramework.NetworkViewID id)
        {
            UnityEngine.GameObject val_2 = this.FindNetworkViewByViewID(id:  id).gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
        public TzarGames.GameFramework.NetworkViewBase FindNetworkViewByViewID(TzarGames.GameFramework.NetworkViewID id)
        {
            var val_4;
            T val_5;
            val_4 = public static T[] UnityEngine.Object::FindObjectsOfType<TzarGames.GameFramework.NetworkViewBase>();
            var val_4 = 0;
            label_7:
            if(val_4 >= val_1.Length)
            {
                goto label_4;
            }
            
            if(val_4 >= val_1.Length)
            {
                    val_4 = 0;
            }
            
            val_5 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[0];
            val_4 = val_4 + 1;
            if((TzarGames.GameFramework.NetworkViewID.op_Equality(a:  0, b:  val_5)) == false)
            {
                goto label_7;
            }
            
            return (TzarGames.GameFramework.NetworkViewBase)val_5;
            label_4:
            val_5 = 0;
            return (TzarGames.GameFramework.NetworkViewBase)val_5;
        }
        private void playerDisconnected(TzarGames.GameFramework.Player player)
        {
            if(player != null)
            {
                    player.DisconnectingFlag = true;
                UnityEngine.Coroutine val_1 = this.gameManager.StartCoroutine(routine:  this.gameManager);
                this.unregisterNetworkPlayer(player:  player);
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  0);
        }
        public void CloseConnectionWithServerMessage(TzarGames.GameFramework.Player player, TzarGames.GameFramework.GameserverMessages messageType)
        {
            this.sendClientMessage(player:  player, error:  messageType);
            goto typeof(TzarGames.GameFramework.GameManagerNetSyncBase).__il2cppRuntimeField_220;
        }
        public bool HandleSpawnObjectForPlayer(TzarGames.GameFramework.Player player, UnityEngine.GameObject go, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, byte[] playerData)
        {
            TzarGames.GameFramework.NetworkPlayer val_6;
            var val_7;
            var val_8;
            val_7 = go;
            if(TzarGames.GameFramework.GameManagerNetSyncBase.IsServer == false)
            {
                goto label_3;
            }
            
            TzarGames.GameFramework.NetworkViewID val_2 = this.SpawnPlayerOnClients(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, player:  player, data:  playerData);
            if(((TzarGames.GameFramework.NetworkViewID.op_Equality(a:  0, b:  val_2)) == true) || ((val_2 & 1) != 0))
            {
                goto label_6;
            }
            
            val_7 = val_7.GetComponent<TzarGames.GameFramework.NetworkViewBase>();
            val_6 = player.NetworkPlayer;
            label_3:
            val_8 = 1;
            return (bool)val_8;
            label_6:
            this.sendClientMessage(player:  player, error:  2);
            val_8 = 0;
            return (bool)val_8;
        }
        protected void Handle_OnServerChanged(TzarGames.GameFramework.NetworkPlayer newServerPlayer)
        {
            TzarGames.GameFramework.NetworkPlayer val_12;
            var val_13;
            val_12 = null;
            if(newServerPlayer != 0)
            {
                    val_13 = mem[null + 48];
                if(newServerPlayer == 0)
            {
                    val_13 = 0;
            }
            
            }
            
            val_13 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_20 = newServerPlayer;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_28 = newServerPlayer & 1;
            typeof(System.Object[]).__il2cppRuntimeField_29 = 26457012;
            TzarGames.GameFramework.Player val_2 = this.gameManager.LocalPlayer;
            typeof(System.Object[]).__il2cppRuntimeField_30 = (val_2.NetworkPlayer != 0) ? 1 : 0;
            typeof(System.Object[]).__il2cppRuntimeField_31 = 26457076;
            UnityEngine.Debug.LogFormat(format:  0, args:  "Server changed to player {0} (its me: {1}), local player has networkPlayer: {2}");
            TzarGames.GameFramework.Player val_4 = this.GetPlayerByNetPlayer(netPlayer:  newServerPlayer);
            if(val_4 != null)
            {
                    if(val_4.itsMe == false)
            {
                    return;
            }
            
                if((this.IsPlayerRegistered(player:  val_4)) == true)
            {
                    return;
            }
            
            }
            
            UnityEngine.Debug.LogWarning(message:  0);
            TzarGames.GameFramework.Player val_8 = this.ServerPlayer;
            val_12 = this;
            val_8.NetworkPlayer = val_12;
            UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.playerReadyCoroutine(player:  this.ServerPlayer));
        }
        private void OnDestroy()
        {
            TzarGames.GameFramework.Player.RemoveAll();
            this._netPlayerMapping.Clear();
        }
        private static GameManagerNetSyncBase()
        {
        
        }
    
    }

}
