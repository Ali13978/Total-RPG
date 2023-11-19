using UnityEngine;
internal class NetworkingPeer : LoadBalancingPeer, IPhotonPeerListener
{
    // Fields
    protected internal string AppId;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private AuthenticationValues <AuthValues>k__BackingField;
    private string tokenCache;
    public AuthModeOption AuthMode;
    public EncryptionMode EncryptionMode;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private bool <IsUsingNameServer>k__BackingField;
    public const string NameServerHost = "ns.exitgames.com";
    public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";
    private static readonly System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, int> ProtocolToNameServerPort;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <MasterServerAddress>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <GameServerAddress>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private ServerConnection <Server>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private ClientState <State>k__BackingField;
    public bool IsInitialConnect;
    public bool insideLobby;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private TypedLobby <lobby>k__BackingField;
    protected internal System.Collections.Generic.List<TypedLobbyInfo> LobbyStatistics;
    public System.Collections.Generic.Dictionary<string, RoomInfo> mGameList;
    public RoomInfo[] mGameListCopy;
    private string playername;
    private bool mPlayernameHasToBeUpdated;
    private Room currentRoom;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private PhotonPlayer <LocalPlayer>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private int <PlayersOnMasterCount>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private int <PlayersInRoomsCount>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private int <RoomsCount>k__BackingField;
    private JoinType lastJoinType;
    protected internal EnterRoomParams enterRoomParamsCache;
    private bool didAuthenticate;
    private string[] friendListRequested;
    private int friendListTimestamp;
    private bool isFetchingFriendList;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Collections.Generic.List<Region> <AvailableRegions>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private CloudRegionCode <CloudRegion>k__BackingField;
    public System.Collections.Generic.Dictionary<int, PhotonPlayer> mActors;
    public PhotonPlayer[] mOtherPlayerListCopy;
    public PhotonPlayer[] mPlayerListCopy;
    public bool hasSwitchedMC;
    private System.Collections.Generic.HashSet<byte> allowedReceivingGroups;
    private System.Collections.Generic.HashSet<byte> blockSendingGroups;
    protected internal System.Collections.Generic.Dictionary<int, PhotonView> photonViewList;
    private readonly PhotonStream readStream;
    private readonly PhotonStream pStream;
    private readonly System.Collections.Generic.Dictionary<int, ExitGames.Client.Photon.Hashtable> dataPerGroupReliable;
    private readonly System.Collections.Generic.Dictionary<int, ExitGames.Client.Photon.Hashtable> dataPerGroupUnreliable;
    protected internal short currentLevelPrefix;
    protected internal bool loadingLevelAndPausedNetwork;
    protected internal const string CurrentSceneProperty = "curScn";
    protected internal const string CurrentScenePropertyLoadAsync = "curScnLa";
    public static bool UsePrefabCache;
    internal IPunPrefabPool ObjectPool;
    public static System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> PrefabCache;
    private System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<System.Reflection.MethodInfo>> monoRPCMethodsCache;
    private readonly System.Collections.Generic.Dictionary<string, int> rpcShortcuts;
    private static readonly string OnPhotonInstantiateString;
    private string cachedServerAddress;
    private string cachedApplicationName;
    private ServerConnection cachedServerType;
    private UnityEngine.AsyncOperation _AsyncLevelLoadingOperation;
    private bool _isReconnecting;
    private System.Collections.Generic.Dictionary<int, object[]> tempInstantiationData;
    public static int ObjectsInOneUpdate;
    private RaiseEventOptions options;
    public const int SyncViewId = 0;
    public const int SyncCompressed = 1;
    public const int SyncNullValues = 2;
    public const int SyncFirstValue = 3;
    
    // Properties
    protected internal string AppVersion { get; }
    public AuthenticationValues AuthValues { get; set; }
    private string TokenForInit { get; }
    public bool IsUsingNameServer { get; set; }
    public string NameServerAddress { get; }
    public string MasterServerAddress { get; set; }
    public string GameServerAddress { get; set; }
    protected internal ServerConnection Server { get; set; }
    public ClientState State { get; set; }
    public TypedLobby lobby { get; set; }
    private bool requestLobbyStatistics { get; }
    public string PlayerName { get; set; }
    public Room CurrentRoom { get; set; }
    public PhotonPlayer LocalPlayer { get; set; }
    public int PlayersOnMasterCount { get; set; }
    public int PlayersInRoomsCount { get; set; }
    public int RoomsCount { get; set; }
    protected internal int FriendListAge { get; }
    public bool IsAuthorizeSecretAvailable { get; }
    public System.Collections.Generic.List<Region> AvailableRegions { get; set; }
    public CloudRegionCode CloudRegion { get; set; }
    public int mMasterClientId { get; set; }
    
    // Methods
    public NetworkingPeer(string playername, ExitGames.Client.Photon.ConnectionProtocol connectionProtocol)
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        this.LobbyStatistics = new System.Collections.Generic.List<TypedLobbyInfo>();
        this.mGameList = new System.Collections.Generic.Dictionary<System.String, RoomInfo>();
        this.mGameListCopy = null;
        val_20 = null;
        val_20 = null;
        this.playername = System.String.Empty;
        this.mActors = new System.Collections.Generic.Dictionary<System.Int32, PhotonPlayer>();
        this.mOtherPlayerListCopy = null;
        this.mPlayerListCopy = null;
        this.allowedReceivingGroups = new System.Collections.Generic.HashSet<System.Byte>();
        this.blockSendingGroups = new System.Collections.Generic.HashSet<System.Byte>();
        this.photonViewList = new System.Collections.Generic.Dictionary<System.Int32, PhotonView>();
        this.readStream = new PhotonStream(write:  false, incomingData:  0);
        this.pStream = new PhotonStream(write:  true, incomingData:  0);
        this.dataPerGroupReliable = new System.Collections.Generic.Dictionary<System.Int32, ExitGames.Client.Photon.Hashtable>();
        this.dataPerGroupUnreliable = new System.Collections.Generic.Dictionary<System.Int32, ExitGames.Client.Photon.Hashtable>();
        this.monoRPCMethodsCache = new System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<System.Reflection.MethodInfo>>();
        this.tempInstantiationData = new System.Collections.Generic.Dictionary<System.Int32, System.Object[]>();
        this.options = new RaiseEventOptions();
        this.Listener = this;
        this.LimitOfUnreliableCommands = 40;
        val_21 = null;
        val_21 = null;
        this.<lobby>k__BackingField = TypedLobby.Default;
        this.PlayerName = playername;
        this.<LocalPlayer>k__BackingField = new PhotonPlayer(isLocal:  true, actorID:  0, name:  this.playername);
        this.AddNewPlayer(ID:  ID, player:  this.<LocalPlayer>k__BackingField);
        val_22 = null;
        val_22 = null;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_17 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(capacity:  Count);
        this.rpcShortcuts = val_17;
        val_23 = 0;
        goto label_10;
        label_21:
        set_Item(key:  val_17, value:  0);
        val_23 = 1;
        label_10:
        val_24 = null;
        val_24 = null;
        if(val_23 >= Count)
        {
            goto label_15;
        }
        
        val_25 = null;
        val_25 = null;
        string val_19 = Item[1];
        if(this.rpcShortcuts != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_15:
        this.<State>k__BackingField = 1;
    }
    protected internal string get_AppVersion()
    {
        return System.String.Format(format:  0, arg0:  "{0}_{1}", arg1:  PhotonNetwork.gameVersion);
    }
    public AuthenticationValues get_AuthValues()
    {
        return (AuthenticationValues)this.<AuthValues>k__BackingField;
    }
    public void set_AuthValues(AuthenticationValues value)
    {
        this.<AuthValues>k__BackingField = value;
    }
    private string get_TokenForInit()
    {
        if(this.AuthMode == 0)
        {
                return 0;
        }
        
        if((this.<AuthValues>k__BackingField) == null)
        {
                return 0;
        }
        
        return this.<AuthValues>k__BackingField.Token;
    }
    public bool get_IsUsingNameServer()
    {
        return (bool)this.<IsUsingNameServer>k__BackingField;
    }
    protected internal void set_IsUsingNameServer(bool value)
    {
        this.<IsUsingNameServer>k__BackingField = value;
    }
    public string get_NameServerAddress()
    {
        return this.GetNameServerAddress();
    }
    public string get_MasterServerAddress()
    {
        return (string)this.<MasterServerAddress>k__BackingField;
    }
    protected internal void set_MasterServerAddress(string value)
    {
        this.<MasterServerAddress>k__BackingField = value;
    }
    public string get_GameServerAddress()
    {
        return (string)this.<GameServerAddress>k__BackingField;
    }
    protected internal void set_GameServerAddress(string value)
    {
        this.<GameServerAddress>k__BackingField = value;
    }
    protected internal ServerConnection get_Server()
    {
        return (ServerConnection)this.<Server>k__BackingField;
    }
    private void set_Server(ServerConnection value)
    {
        this.<Server>k__BackingField = value;
    }
    public ClientState get_State()
    {
        return (ClientState)this.<State>k__BackingField;
    }
    internal void set_State(ClientState value)
    {
        this.<State>k__BackingField = value;
    }
    public TypedLobby get_lobby()
    {
        return (TypedLobby)this.<lobby>k__BackingField;
    }
    public void set_lobby(TypedLobby value)
    {
        this.<lobby>k__BackingField = value;
    }
    private bool get_requestLobbyStatistics()
    {
        var val_3;
        if(PhotonNetwork.EnableLobbyStatistics != false)
        {
                var val_2 = ((this.<Server>k__BackingField) == 0) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public string get_PlayerName()
    {
        return (string)this.playername;
    }
    public void set_PlayerName(string value)
    {
        string val_6;
        if((System.String.IsNullOrEmpty(value:  0)) == true)
        {
                return;
        }
        
        val_6 = this.playername;
        if((value.Equals(value:  val_6)) == true)
        {
                return;
        }
        
        if((this.<LocalPlayer>k__BackingField) != null)
        {
                this.<LocalPlayer>k__BackingField.NickName = value;
        }
        
        this.playername = value;
        if(this.currentRoom == null)
        {
                return;
        }
        
        if(this.currentRoom.IsLocalClientInside == false)
        {
                return;
        }
        
        if(this.currentRoom == null)
        {
                return;
        }
        
        this.SendPlayerName();
    }
    public Room get_CurrentRoom()
    {
        Room val_2;
        if(this.currentRoom != null)
        {
                val_2 = 0;
            if(this.currentRoom.IsLocalClientInside == false)
        {
                return (Room)val_2;
        }
        
            val_2 = this.currentRoom;
            return (Room)val_2;
        }
        
        val_2 = 0;
        return (Room)val_2;
    }
    private void set_CurrentRoom(Room value)
    {
        this.currentRoom = value;
    }
    public PhotonPlayer get_LocalPlayer()
    {
        return (PhotonPlayer)this.<LocalPlayer>k__BackingField;
    }
    internal void set_LocalPlayer(PhotonPlayer value)
    {
        this.<LocalPlayer>k__BackingField = value;
    }
    public int get_PlayersOnMasterCount()
    {
        return (int)this.<PlayersOnMasterCount>k__BackingField;
    }
    internal void set_PlayersOnMasterCount(int value)
    {
        this.<PlayersOnMasterCount>k__BackingField = value;
    }
    public int get_PlayersInRoomsCount()
    {
        return (int)this.<PlayersInRoomsCount>k__BackingField;
    }
    internal void set_PlayersInRoomsCount(int value)
    {
        this.<PlayersInRoomsCount>k__BackingField = value;
    }
    public int get_RoomsCount()
    {
        return (int)this.<RoomsCount>k__BackingField;
    }
    internal void set_RoomsCount(int value)
    {
        this.<RoomsCount>k__BackingField = value;
    }
    protected internal int get_FriendListAge()
    {
        var val_2;
        if((this.isFetchingFriendList != true) && (this.friendListTimestamp != 0))
        {
                val_2 = System.Environment.TickCount - this.friendListTimestamp;
            return (int)val_2;
        }
        
        val_2 = 0;
        return (int)val_2;
    }
    public bool get_IsAuthorizeSecretAvailable()
    {
        var val_4;
        var val_5;
        val_4 = this;
        if((this.<AuthValues>k__BackingField) != null)
        {
                val_4 = this.<AuthValues>k__BackingField.Token;
            val_5 = (System.String.IsNullOrEmpty(value:  0)) ^ 1;
            return (bool)val_5 & 1;
        }
        
        val_5 = 0;
        return (bool)val_5 & 1;
    }
    public System.Collections.Generic.List<Region> get_AvailableRegions()
    {
        return (System.Collections.Generic.List<Region>)this.<AvailableRegions>k__BackingField;
    }
    protected internal void set_AvailableRegions(System.Collections.Generic.List<Region> value)
    {
        this.<AvailableRegions>k__BackingField = value;
    }
    public CloudRegionCode get_CloudRegion()
    {
        return (CloudRegionCode)this.<CloudRegion>k__BackingField;
    }
    protected internal void set_CloudRegion(CloudRegionCode value)
    {
        this.<CloudRegion>k__BackingField = value;
    }
    public int get_mMasterClientId()
    {
        if(PhotonNetwork.offlineMode != false)
        {
                if((this.<LocalPlayer>k__BackingField) != null)
        {
                return this.<LocalPlayer>k__BackingField.ID;
        }
        
            return this.<LocalPlayer>k__BackingField.ID;
        }
        
        if(this.currentRoom == null)
        {
                return 0;
        }
        
        if(this.currentRoom.IsLocalClientInside == false)
        {
                return 0;
        }
        
        if(this.currentRoom == null)
        {
                return 0;
        }
        
        if(this.currentRoom.IsLocalClientInside == false)
        {
                return 0.MasterClientId;
        }
        
        if(this.currentRoom != null)
        {
                return 0.MasterClientId;
        }
        
        return 0.MasterClientId;
    }
    private void set_mMasterClientId(int value)
    {
        if(this.currentRoom == null)
        {
                return;
        }
        
        if(this.currentRoom.IsLocalClientInside == false)
        {
                return;
        }
        
        if(this.currentRoom == null)
        {
                return;
        }
        
        if(this.currentRoom.IsLocalClientInside != false)
        {
                if(this.currentRoom != null)
        {
            goto label_4;
        }
        
        }
        
        label_4:
        0.MasterClientId = value;
    }
    private string GetNameServerAddress()
    {
        var val_9;
        var val_10;
        var val_11;
        ExitGames.Client.Photon.ConnectionProtocol val_1 = this.TransportProtocol;
        val_9 = null;
        val_9 = null;
        bool val_3 = NetworkingPeer.SyncFirstValue.TryGetValue(key:  val_1, value: out  0);
        val_10 = null;
        val_10 = null;
        ExitGames.Client.Photon.ConnectionProtocol val_4 = val_1 & 255;
        if(val_4 == 5)
        {
            goto label_6;
        }
        
        if(val_4 != 4)
        {
            goto label_7;
        }
        
        val_11 = "ws://";
        goto label_9;
        label_6:
        val_11 = "wss://";
        goto label_9;
        label_7:
        label_9:
        if(PhotonNetwork.UseAlternativeUdpPorts == false)
        {
                return (string)System.String.Format(format:  0, arg0:  "{0}{1}:{2}", arg1:  System.String.__il2cppRuntimeField_static_fields, arg2:  "ns.exitgames.com");
        }
        
        ExitGames.Client.Photon.ConnectionProtocol val_7 = this.TransportProtocol & 255;
        return (string)System.String.Format(format:  0, arg0:  "{0}{1}:{2}", arg1:  System.String.__il2cppRuntimeField_static_fields, arg2:  "ns.exitgames.com");
    }
    public override bool Connect(string serverAddress, string applicationName)
    {
        UnityEngine.Debug.LogError(message:  0);
        return false;
    }
    public bool ReconnectToMaster()
    {
        AuthenticationValues val_2;
        string val_3;
        val_2 = this.<AuthValues>k__BackingField;
        if(val_2 != null)
        {
                val_3 = this.tokenCache;
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  0);
            AuthenticationValues val_1 = null;
            val_2 = val_1;
            val_1 = new AuthenticationValues();
            val_3 = this.tokenCache;
            this.<AuthValues>k__BackingField = val_2;
            if(null == 0)
        {
                val_2 = 0;
        }
        
        }
        
        val_2.Token = val_3;
        return this.Connect(serverAddress:  this.<MasterServerAddress>k__BackingField, type:  0);
    }
    public bool ReconnectAndRejoin()
    {
        AuthenticationValues val_4;
        string val_5;
        val_4 = this.<AuthValues>k__BackingField;
        if(val_4 != null)
        {
                val_5 = this.tokenCache;
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  0);
            AuthenticationValues val_1 = null;
            val_4 = val_1;
            val_1 = new AuthenticationValues();
            val_5 = this.tokenCache;
            this.<AuthValues>k__BackingField = val_4;
            if(null == 0)
        {
                val_4 = 0;
        }
        
        }
        
        val_4.Token = val_5;
        if((System.String.IsNullOrEmpty(value:  0)) == true)
        {
                return false;
        }
        
        if(this.enterRoomParamsCache == null)
        {
                return false;
        }
        
        this.lastJoinType = 1;
        this.enterRoomParamsCache.RejoinOnly = 1;
        return this.Connect(serverAddress:  this.<GameServerAddress>k__BackingField, type:  1);
    }
    public bool Connect(string serverAddress, ServerConnection type)
    {
        var val_5;
        var val_6;
        var val_7;
        object val_8;
        ClientState val_9;
        val_5 = this;
        val_6 = null;
        val_6 = null;
        if(PhotonHandler.AppQuits != false)
        {
                UnityEngine.Debug.LogWarning(message:  0);
            return false;
        }
        
        if((this.<State>k__BackingField) == 14)
        {
                ClientState val_1 = PhotonNetwork.connectionStateDetailed;
            val_5 = 0 + "Connect() failed. Can\'t connect while disconnecting (still). Current state: "("Connect() failed. Can\'t connect while disconnecting (still). Current state: ");
            UnityEngine.Debug.LogError(message:  0);
            return false;
        }
        
        this.cachedServerAddress = serverAddress;
        this.cachedServerType = type;
        val_7 = null;
        val_7 = null;
        this.cachedApplicationName = System.String.Empty;
        this.SetupProtocol(serverType:  type);
        if((this.AuthMode != 0) && ((this.<AuthValues>k__BackingField) != null))
        {
                val_8 = this.<AuthValues>k__BackingField.Token;
        }
        else
        {
                val_8 = 0;
        }
        
        if((this.Connect(serverAddress:  serverAddress, applicationName:  System.String.Empty, custom:  val_8)) == false)
        {
                return false;
        }
        
        if(type == 0)
        {
            goto label_21;
        }
        
        if(type == 1)
        {
            goto label_22;
        }
        
        if(type != 2)
        {
                return false;
        }
        
        val_9 = 17;
        goto label_25;
        label_21:
        val_9 = 12;
        goto label_25;
        label_22:
        val_9 = 6;
        label_25:
        this.<State>k__BackingField = val_9;
        return false;
    }
    private bool Reconnect()
    {
        var val_4;
        object val_5;
        ClientState val_6;
        this._isReconnecting = true;
        val_4 = null;
        val_4 = null;
        PhotonNetwork.SwitchToProtocol(cp:  0);
        this.SetupProtocol(serverType:  this.cachedServerType);
        val_5 = 0;
        if(this.AuthMode != 0)
        {
                if((this.<AuthValues>k__BackingField) != null)
        {
                val_5 = this.<AuthValues>k__BackingField.Token;
        }
        else
        {
                val_5 = 0;
        }
        
        }
        
        bool val_2 = this.Connect(serverAddress:  this.cachedServerAddress, applicationName:  this.cachedApplicationName, custom:  val_5);
        if(val_2 == false)
        {
                return val_2;
        }
        
        if(this.cachedServerType == 0)
        {
            goto label_8;
        }
        
        if(this.cachedServerType == 1)
        {
            goto label_9;
        }
        
        if(this.cachedServerType != 2)
        {
                return val_2;
        }
        
        val_6 = 17;
        goto label_12;
        label_8:
        val_6 = 12;
        goto label_12;
        label_9:
        val_6 = 6;
        label_12:
        this.<State>k__BackingField = val_6;
        return val_2;
    }
    public bool ConnectToNameServer()
    {
        var val_5;
        bool val_6;
        object val_7;
        val_5 = null;
        val_5 = null;
        if(PhotonHandler.AppQuits == false)
        {
            goto label_3;
        }
        
        UnityEngine.Debug.LogWarning(message:  0);
        label_11:
        val_6 = 0;
        return (bool)val_6;
        label_3:
        val_6 = true;
        this.<IsUsingNameServer>k__BackingField = val_6;
        this.<CloudRegion>k__BackingField = 4;
        if((this.<State>k__BackingField) == 18)
        {
                return (bool)val_6;
        }
        
        this.SetupProtocol(serverType:  2);
        this.cachedServerType = 2;
        this.cachedServerAddress = this.GetNameServerAddress();
        this.cachedApplicationName = "ns";
        if((this.AuthMode != 0) && ((this.<AuthValues>k__BackingField) != null))
        {
                val_7 = this.<AuthValues>k__BackingField.Token;
        }
        else
        {
                val_7 = 0;
        }
        
        if((this.Connect(serverAddress:  this.GetNameServerAddress(), applicationName:  "ns", custom:  val_7)) == false)
        {
            goto label_11;
        }
        
        val_6 = 1;
        this.<State>k__BackingField = 17;
        return (bool)val_6;
    }
    public bool ConnectToRegionMaster(CloudRegionCode region)
    {
        var val_5;
        object val_6;
        val_5 = null;
        val_5 = null;
        if(PhotonHandler.AppQuits != false)
        {
                UnityEngine.Debug.LogWarning(message:  0);
            return false;
        }
        
        this.<IsUsingNameServer>k__BackingField = true;
        this.<CloudRegion>k__BackingField = region;
        if((this.<State>k__BackingField) == 18)
        {
                return this.CallAuthenticate();
        }
        
        this.cachedServerType = 2;
        this.cachedServerAddress = this.GetNameServerAddress();
        this.cachedApplicationName = "ns";
        this.SetupProtocol(serverType:  2);
        if((this.AuthMode != 0) && ((this.<AuthValues>k__BackingField) != null))
        {
                val_6 = this.<AuthValues>k__BackingField.Token;
        }
        else
        {
                val_6 = 0;
        }
        
        if((this.Connect(serverAddress:  this.GetNameServerAddress(), applicationName:  "ns", custom:  val_6)) == false)
        {
                return false;
        }
        
        this.<State>k__BackingField = 17;
        return false;
    }
    protected internal void SetupProtocol(ServerConnection serverType)
    {
        ExitGames.Client.Photon.ConnectionProtocol val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_19;
        System.Type val_20;
        var val_21;
        var val_22;
        var val_23;
        val_14 = this.TransportProtocol;
        if(this.AuthMode == 2)
        {
                val_15 = null;
            if(serverType == 2)
        {
                val_16 = null;
            if((PhotonNetwork.logLevel & 2147483648) == 0)
        {
                UnityEngine.Debug.LogWarning(message:  0);
        }
        
            val_14 = 5;
        }
        else
        {
                val_17 = null;
            if((PhotonNetwork.logLevel & 2147483648) == 0)
        {
                string val_4 = 0 + "Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): "("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): ");
            UnityEngine.Debug.LogWarning(message:  0);
            val_17 = null;
        }
        
            val_17 = null;
            val_14 = mem[PhotonNetwork.PhotonServerSettings + 60];
            val_14 = PhotonNetwork.PhotonServerSettings.Protocol;
        }
        
        }
        
        val_19 = 1152921504609562624;
        val_20 = System.Type.GetType(typeName:  0, throwOnError:  true);
        if(val_20 != null)
        {
            goto label_28;
        }
        
        val_20 = System.Type.GetType(typeName:  0, throwOnError:  true);
        if(val_20 != null)
        {
            goto label_28;
        }
        
        val_20 = System.Type.GetType(typeName:  0, throwOnError:  true);
        if(val_20 != null)
        {
            goto label_28;
        }
        
        val_20 = System.Type.GetType(typeName:  0, throwOnError:  true);
        if(val_20 == null)
        {
            goto label_29;
        }
        
        label_28:
        set_Item(key:  4, value:  val_20);
        set_Item(key:  5, value:  val_20);
        label_29:
        val_21 = null;
        val_21 = null;
        if(PhotonHandler.PingImplementation == null)
        {
                val_22 = null;
            val_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_22 = null;
            PhotonHandler.PingImplementation = val_20;
        }
        
        if((this.TransportProtocol & 255) == val_14)
        {
                return;
        }
        
        val_20 = 1152921504973725696;
        val_23 = null;
        val_23 = null;
        if((PhotonNetwork.logLevel & 2147483648) == 0)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = "Protocol switch from: ";
            val_19 = 1152921504814460928;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.TransportProtocol;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " to: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_14;
            typeof(System.Object[]).__il2cppRuntimeField_40 = ".";
            val_20 = +0;
            UnityEngine.Debug.LogWarning(message:  0);
        }
        
        this.TransportProtocol = val_14;
    }
    public override void Disconnect()
    {
        var val_4;
        var val_5;
        val_4 = this;
        if((this.PeerState & 255) != 0)
        {
                this.<State>k__BackingField = 14;
            this.Disconnect();
            return;
        }
        
        val_5 = null;
        val_5 = null;
        if(PhotonHandler.AppQuits == true)
        {
                return;
        }
        
        val_4 = System.String.Format(format:  0, arg0:  "Can\'t execute Disconnect() while not connected. Nothing changed. State: {0}");
        UnityEngine.Debug.LogWarning(message:  0);
    }
    private bool CallAuthenticate()
    {
        AuthenticationValues val_12;
        string val_13;
        var val_14;
        var val_15;
        val_12 = this.<AuthValues>k__BackingField;
        if(val_12 == null)
        {
                AuthenticationValues val_1 = null;
            val_12 = val_1;
            val_1 = new AuthenticationValues();
            UserId = this.playername;
        }
        
        string val_2 = AppVersion;
        if(this.AuthMode != 0)
        {
                val_13 = this.<CloudRegion>k__BackingField.ToString();
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_14 = null;
            val_14 = null;
            val_15 = this;
            bool val_5 = this.OpAuthenticateOnce(appId:  this.AppId, appVersion:  val_2, authValues:  val_12, regionCode:  val_13, encryptionMode:  this.EncryptionMode, expectedProtocol:  PhotonNetwork.PhotonServerSettings.Protocol);
            return (bool)this.OpAuthenticate(appId:  this.AppId, appVersion:  val_2, authValues:  val_12, regionCode:  val_13 = this.<CloudRegion>k__BackingField.ToString(), getLobbyStatistics:  this.requestLobbyStatistics);
        }
        
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_15 = this;
        return (bool)this.OpAuthenticate(appId:  this.AppId, appVersion:  val_2, authValues:  val_12, regionCode:  val_13, getLobbyStatistics:  this.requestLobbyStatistics);
    }
    private void DisconnectToReconnect()
    {
        var val_1;
        if((this.<Server>k__BackingField) == 0)
        {
            goto label_0;
        }
        
        if((this.<Server>k__BackingField) == 1)
        {
            goto label_1;
        }
        
        if((this.<Server>k__BackingField) != 2)
        {
                return;
        }
        
        val_1 = 19;
        goto label_4;
        label_0:
        val_1 = 5;
        goto label_4;
        label_1:
        val_1 = 11;
        label_4:
        this.<State>k__BackingField = 11;
        this.Disconnect();
    }
    public bool GetRegions()
    {
        var val_2;
        if((this.<Server>k__BackingField) == 2)
        {
                if((this.OpGetRegions(appId:  this.AppId)) != false)
        {
                val_2 = 1;
            this.<AvailableRegions>k__BackingField = 0;
            return (bool)val_2;
        }
        
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    public override bool OpFindFriends(string[] friendsToFind)
    {
        if(this.isFetchingFriendList != false)
        {
                return false;
        }
        
        this.friendListRequested = friendsToFind;
        this.isFetchingFriendList = true;
        return this.OpFindFriends(friendsToFind:  friendsToFind);
    }
    public bool OpCreateGame(EnterRoomParams enterRoomParams)
    {
        enterRoomParams.OnGameServer = ((this.<Server>k__BackingField) == 1) ? 1 : 0;
        enterRoomParams.PlayerProperties = this.GetLocalActorProperties();
        if((this.<Server>k__BackingField) != 1)
        {
                this.enterRoomParamsCache = enterRoomParams;
        }
        
        this.lastJoinType = 0;
        return this.OpCreateRoom(opParams:  enterRoomParams);
    }
    public override bool OpJoinRoom(EnterRoomParams opParams)
    {
        opParams.OnGameServer = ((this.<Server>k__BackingField) == 1) ? 1 : 0;
        if((this.<Server>k__BackingField) != 1)
        {
            goto label_1;
        }
        
        var val_2 = (opParams.CreateIfNotExists == true) ? 3 : 1;
        if(this != null)
        {
            goto label_3;
        }
        
        goto label_3;
        label_1:
        this.enterRoomParamsCache = opParams;
        label_3:
        this.lastJoinType = (opParams.CreateIfNotExists == true) ? 3 : 1;
        return this.OpJoinRoom(opParams:  opParams);
    }
    public override bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
    {
        this.enterRoomParamsCache = new EnterRoomParams();
        typeof(EnterRoomParams).__il2cppRuntimeField_20 = opJoinRandomRoomParams.TypedLobby;
        this.enterRoomParamsCache.ExpectedUsers = opJoinRandomRoomParams.ExpectedUsers;
        this.lastJoinType = 2;
        return this.OpJoinRandomRoom(opJoinRandomRoomParams:  opJoinRandomRoomParams);
    }
    public override bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
    {
        if(PhotonNetwork.offlineMode != false)
        {
                return false;
        }
        
        sendReliable = sendReliable;
        return this.OpRaiseEvent(eventCode:  eventCode, customEventContent:  customEventContent, sendReliable:  sendReliable, raiseEventOptions:  raiseEventOptions);
    }
    private void ReadoutProperties(ExitGames.Client.Photon.Hashtable gameProperties, ExitGames.Client.Photon.Hashtable pActorProperties, int targetActorNr)
    {
        float val_6;
        float val_7;
        PhotonPlayer val_21;
        ExitGames.Client.Photon.Hashtable val_22;
        ExitGames.Client.Photon.Hashtable val_23;
        string val_24;
        PhotonPlayer val_25;
        var val_26;
        var val_27;
        val_22 = pActorProperties;
        if((val_22 == null) || (val_22.Count < 1))
        {
            goto label_41;
        }
        
        if(targetActorNr < 1)
        {
            goto label_3;
        }
        
        PhotonPlayer val_2 = this.GetPlayerWithId(number:  targetActorNr);
        val_21 = val_2;
        if(val_21 == null)
        {
            goto label_41;
        }
        
        val_22 = val_2.ReadoutPropertiesForActorNr(actorProperties:  val_22, actorNr:  targetActorNr);
        val_21.InternalCacheProperties(properties:  val_22);
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_21;
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_22;
        NetworkingPeer.SendMonoMessage(methodString:  null, parameters:  21);
        goto label_41;
        label_3:
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_5 = val_22.Keys.GetEnumerator();
        goto label_35;
        label_37:
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7, y = val_6});
        val_23 = val_22.Item[val_6];
        val_23 = 0;
        val_24 = val_23.Item[255];
        if(val_24 != null)
        {
                if(null == null)
        {
            goto label_23;
        }
        
        }
        
        val_24 = 0;
        label_23:
        val_25 = this.GetPlayerWithId(number:  val_6);
        if(val_25 == null)
        {
                val_25 = null;
            val_25 = new PhotonPlayer(isLocal:  false, actorID:  val_6, name:  val_24);
            this.AddNewPlayer(ID:  val_6, player:  val_25);
            if(null == 0)
        {
            goto label_36;
        }
        
        }
        
        label_36:
        InternalCacheProperties(properties:  val_23);
        val_21 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_25;
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_23;
        NetworkingPeer.SendMonoMessage(methodString:  null, parameters:  21);
        label_35:
        if((0 & 1) != 0)
        {
            goto label_37;
        }
        
        val_22 = 0;
        val_26 = 1;
        goto label_38;
        label_58:
        val_27 = ;
        if((public System.Boolean Dictionary.KeyCollection.Enumerator<System.Object, System.Object>::MoveNext()) != 1)
        {
            goto label_39;
        }
        
        val_22 = val_6;
        val_26 = 0;
        label_38:
        label_41:
        if(this.currentRoom == null)
        {
                return;
        }
        
        if(this.currentRoom.IsLocalClientInside == false)
        {
                return;
        }
        
        if(gameProperties == null)
        {
                return;
        }
        
        if(this.currentRoom == null)
        {
                return;
        }
        
        if(this.currentRoom.IsLocalClientInside != false)
        {
                if(this.currentRoom != null)
        {
            goto label_47;
        }
        
        }
        
        label_47:
        0.InternalCacheProperties(propertiesToCache:  gameProperties);
        val_22 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = gameProperties;
        NetworkingPeer.SendMonoMessage(methodString:  null, parameters:  20);
        if(PhotonNetwork.automaticallySyncScene == false)
        {
                return;
        }
        
        this.LoadLevelIfSynced();
        return;
        label_39:
        goto label_58;
    }
    private ExitGames.Client.Photon.Hashtable ReadoutPropertiesForActorNr(ExitGames.Client.Photon.Hashtable actorProperties, int actorNr)
    {
        ExitGames.Client.Photon.Hashtable val_4 = actorProperties;
        if((val_4.ContainsKey(key:  actorNr)) == false)
        {
                return (ExitGames.Client.Photon.Hashtable)val_4;
        }
        
        object val_2 = val_4.Item[actorNr];
        val_4 = 0;
        if(val_2 == null)
        {
                return (ExitGames.Client.Photon.Hashtable)val_4;
        }
        
        val_4 = val_2;
        val_4 = 0;
        return (ExitGames.Client.Photon.Hashtable)val_4;
    }
    public void ChangeLocalID(int newID)
    {
        PhotonPlayer val_8;
        System.Collections.Generic.Dictionary<System.Int32, PhotonPlayer> val_9;
        val_8 = this.<LocalPlayer>k__BackingField;
        val_9 = this.mActors;
        if(val_8 == null)
        {
                string val_2 = System.String.Format(format:  0, arg0:  "LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", arg1:  0, arg2:  (val_9 == 0) ? 1 : 0);
            UnityEngine.Debug.LogWarning(message:  0);
            val_8 = this.<LocalPlayer>k__BackingField;
            val_9 = this.mActors;
            if(val_8 == null)
        {
                val_8 = 0;
        }
        
        }
        
        if((val_9.ContainsKey(key:  val_8.ID)) != false)
        {
                bool val_6 = this.mActors.Remove(key:  this.<LocalPlayer>k__BackingField.ID);
        }
        
        this.<LocalPlayer>k__BackingField.InternalChangeLocalID(newID:  newID);
        this.mActors.set_Item(key:  this.<LocalPlayer>k__BackingField.ID, value:  this.<LocalPlayer>k__BackingField);
        this.RebuildPlayerListCopies();
    }
    private void LeftLobbyCleanup()
    {
        this.mGameList = new System.Collections.Generic.Dictionary<System.String, RoomInfo>();
        this.mGameListCopy = null;
        if(this.insideLobby == false)
        {
                return;
        }
        
        this.insideLobby = false;
        NetworkingPeer.SendMonoMessage(methodString:  null, parameters:  7);
    }
    private void LeftRoomCleanup()
    {
        System.Collections.Generic.List<System.Int32> val_13;
        var val_14;
        Room val_15;
        var val_16;
        val_13 = this;
        if(this.currentRoom == null)
        {
            goto label_1;
        }
        
        var val_13 = this.currentRoom.IsLocalClientInside;
        val_13 = val_13 ^ 1;
        val_14 = ((this.currentRoom == 0) ? 1 : 0) | val_13;
        if((this.currentRoom == null) || ((this.currentRoom.IsLocalClientInside == false) || (this.currentRoom == null)))
        {
            goto label_4;
        }
        
        if(this.currentRoom.IsLocalClientInside == false)
        {
            goto label_5;
        }
        
        val_15 = this.currentRoom;
        if(val_15 != null)
        {
            goto label_6;
        }
        
        label_5:
        val_15 = 0;
        label_6:
        bool val_5 = val_15.AutoCleanUp;
        goto label_7;
        label_1:
        val_14 = 1;
        label_4:
        val_15 = 0;
        label_7:
        this.currentRoom = 0;
        this.hasSwitchedMC = false;
        this.mActors = new System.Collections.Generic.Dictionary<System.Int32, PhotonPlayer>();
        this.mPlayerListCopy = null;
        this.mOtherPlayerListCopy = null;
        this.allowedReceivingGroups = new System.Collections.Generic.HashSet<System.Byte>();
        this.blockSendingGroups = new System.Collections.Generic.HashSet<System.Byte>();
        this.mGameList = new System.Collections.Generic.Dictionary<System.String, RoomInfo>();
        this.mGameListCopy = null;
        this.isFetchingFriendList = false;
        this.ChangeLocalID(newID:  0);
        if(PhotonNetwork.autoCleanUpPlayerObjects != false)
        {
                this.LocalCleanupAnythingInstantiated(destroyInstantiatedGameObjects:  true);
            System.Collections.Generic.List<System.Int32> val_11 = null;
            val_13 = val_11;
            val_11 = new System.Collections.Generic.List<System.Int32>();
            val_16 = null;
            val_16 = null;
            PhotonNetwork.manuallyAllocatedViewIds = val_13;
        }
        
        if(((val_14 & 1) & 1) != 0)
        {
                return;
        }
        
        NetworkingPeer.SendMonoMessage(methodString:  null, parameters:  1);
    }
    protected internal void LocalCleanupAnythingInstantiated(bool destroyInstantiatedGameObjects)
    {
        var val_6;
        var val_7;
        System.Collections.Generic.Dictionary<System.Int32, System.Object[]> val_12;
        var val_13;
        var val_14;
        val_12 = this.tempInstantiationData;
        if(val_12.Count >= 1)
        {
                UnityEngine.Debug.LogWarning(message:  0);
        }
        
        if(destroyInstantiatedGameObjects == false)
        {
            goto label_20;
        }
        
        System.Collections.Generic.HashSet<UnityEngine.GameObject> val_2 = new System.Collections.Generic.HashSet<UnityEngine.GameObject>();
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_4 = this.photonViewList.Values.GetEnumerator();
        label_12:
        if((0 & 1) == 0)
        {
            goto label_8;
        }
        
        if(val_7 == false)
        {
            goto label_12;
        }
        
        bool val_9 = Add(item:  val_6.gameObject);
        goto label_12;
        label_8:
        HashSet.Enumerator<T> val_10 = GetEnumerator();
        label_17:
        if((0 & 1) == 0)
        {
            goto label_16;
        }
        
        this.RemoveInstantiatedGO(go:  0.InitializationCallback, localOnly:  true);
        goto label_17;
        label_16:
        val_13 = 0;
        val_12 = 1;
        0.Dispose();
        label_20:
        this.tempInstantiationData.Clear();
        val_14 = null;
        val_14 = null;
        PhotonNetwork.lastUsedViewSubId = 0;
        PhotonNetwork.lastUsedViewSubIdStatic = 0;
    }
    private void GameEnteredOnGameServer(ExitGames.Client.Photon.OperationResponse operationResponse)
    {
        ExitGames.Client.Photon.Hashtable val_20;
        PhotonNetworkingMessage val_21;
        var val_22;
        PhotonNetworkingMessage val_23;
        System.Object[] val_24;
        System.Int32[] val_25;
        ExitGames.Client.Photon.Hashtable val_26;
        Room val_27;
        var val_28;
        var val_29;
        val_21 = this;
        if(operationResponse.ReturnCode == 0)
        {
            goto label_2;
        }
        
        if(operationResponse.OperationCode == 225)
        {
            goto label_3;
        }
        
        if(operationResponse.OperationCode == 226)
        {
            goto label_4;
        }
        
        if(operationResponse.OperationCode != 227)
        {
            goto label_5;
        }
        
        val_22 = null;
        val_22 = null;
        if(PhotonNetwork.logLevel >= 1)
        {
                string val_1 = 0 + "Create failed on GameServer. Changing back to MasterServer. Msg: "("Create failed on GameServer. Changing back to MasterServer. Msg: ");
            UnityEngine.Debug.Log(message:  0);
        }
        
        val_20 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = operationResponse.ReturnCode;
        typeof(System.Object[]).__il2cppRuntimeField_22 = 118550;
        typeof(System.Object[]).__il2cppRuntimeField_28 = operationResponse.DebugMessage;
        val_23 = null;
        val_24 = 3;
        goto label_79;
        label_2:
        IsLocalClientInside = true;
        this.currentRoom = new Room(roomName:  this.enterRoomParamsCache.RoomName, options:  0);
        this.<State>k__BackingField = 9;
        if((operationResponse.Parameters.ContainsKey(key:  252)) == false)
        {
            goto label_30;
        }
        
        object val_4 = operationResponse.Parameters.Item[252];
        if(val_4 == null)
        {
            goto label_33;
        }
        
        val_25 = val_4;
        if(val_25 != null)
        {
            goto label_34;
        }
        
        label_33:
        val_25 = 0;
        label_34:
        this.UpdatedActorList(actorsInRoom:  val_25);
        label_30:
        object val_6 = operationResponse.Item[254];
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        this.ChangeLocalID(newID:  53248);
        object val_8 = operationResponse.Item[249];
        val_20 = 0;
        if(val_8 != null)
        {
                val_20 = val_8;
            val_20 = 0;
        }
        
        object val_11 = operationResponse.Item[248];
        val_26 = 0;
        if(val_11 != null)
        {
                val_26 = val_11;
            val_26 = 0;
        }
        
        this.ReadoutProperties(gameProperties:  val_26, pActorProperties:  val_20, targetActorNr:  0);
        if((this.currentRoom == null) || (this.currentRoom.IsLocalClientInside == false))
        {
            goto label_47;
        }
        
        val_27 = this.currentRoom;
        if(val_27 != null)
        {
            goto label_48;
        }
        
        label_47:
        val_27 = 0;
        label_48:
        if(val_27.serverSideMasterClient != true)
        {
                this.CheckMasterClient(leavingPlayerId:  0);
        }
        
        if(this.mPlayernameHasToBeUpdated != false)
        {
                this.SendPlayerName();
        }
        
        if(operationResponse.OperationCode != 227)
        {
                return;
        }
        
        val_21 = null;
        NetworkingPeer.SendMonoMessage(methodString:  val_21, parameters:  5);
        return;
        label_4:
        val_28 = null;
        val_28 = null;
        if(PhotonNetwork.logLevel >= 1)
        {
                string val_17 = 0 + "Join failed on GameServer. Changing back to MasterServer. Msg: "("Join failed on GameServer. Changing back to MasterServer. Msg: ");
            UnityEngine.Debug.Log(message:  0);
            if(operationResponse.ReturnCode == 32758)
        {
                UnityEngine.Debug.Log(message:  0);
        }
        
        }
        
        val_20 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = operationResponse.ReturnCode;
        typeof(System.Object[]).__il2cppRuntimeField_22 = 118551;
        typeof(System.Object[]).__il2cppRuntimeField_28 = operationResponse.DebugMessage;
        val_23 = null;
        val_24 = 4;
        goto label_79;
        label_3:
        val_29 = null;
        val_29 = null;
        if(PhotonNetwork.logLevel >= 1)
        {
                string val_18 = 0 + "Join failed on GameServer. Changing back to MasterServer. Msg: "("Join failed on GameServer. Changing back to MasterServer. Msg: ");
            UnityEngine.Debug.Log(message:  0);
            if(operationResponse.ReturnCode == 32758)
        {
                UnityEngine.Debug.Log(message:  0);
        }
        
        }
        
        val_20 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = operationResponse.ReturnCode;
        typeof(System.Object[]).__il2cppRuntimeField_22 = 118551;
        typeof(System.Object[]).__il2cppRuntimeField_28 = operationResponse.DebugMessage;
        val_23 = null;
        val_24 = 15;
        label_79:
        NetworkingPeer.SendMonoMessage(methodString:  val_23, parameters:  val_24);
        label_5:
        this.DisconnectToReconnect();
        return;
        label_105:
        goto label_105;
    }
    private void AddNewPlayer(int ID, PhotonPlayer player)
    {
        if((this.mActors.ContainsKey(key:  ID)) != false)
        {
                string val_3 = 0 + "Adding player twice: "("Adding player twice: ");
            UnityEngine.Debug.LogError(message:  0);
            return;
        }
        
        this.mActors.set_Item(key:  ID, value:  player);
        this.RebuildPlayerListCopies();
    }
    private void RemovePlayer(int ID, PhotonPlayer player)
    {
        bool val_1 = this.mActors.Remove(key:  ID);
        if(player.IsLocal != false)
        {
                return;
        }
        
        this.RebuildPlayerListCopies();
    }
    private void RebuildPlayerListCopies()
    {
        var val_5;
        int val_1 = this.mActors.Count;
        this.mPlayerListCopy = null;
        this.mActors.Values.CopyTo(array:  this.mPlayerListCopy, index:  0);
        System.Collections.Generic.List<PhotonPlayer> val_3 = new System.Collections.Generic.List<PhotonPlayer>();
        val_5 = 0;
        goto label_4;
        label_12:
        val_5 = 1;
        label_4:
        if(val_5 >= this.mPlayerListCopy.Length)
        {
            goto label_6;
        }
        
        if(this.mPlayerListCopy[0x1][0].IsLocal == true)
        {
            goto label_12;
        }
        
        Add(item:  this.mPlayerListCopy[1]);
        goto label_12;
        label_6:
        this.mOtherPlayerListCopy = ToArray();
    }
    private void ResetPhotonViewsOnSerialize()
    {
        var val_3;
        var val_4;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.photonViewList.Values.GetEnumerator();
        goto label_3;
        label_6:
        mem2[0] = 0;
        label_3:
        if((0 & 1) == 0)
        {
            goto label_4;
        }
        
        if(0 != 0)
        {
            goto label_6;
        }
        
        goto label_6;
        label_4:
        val_3 = 0;
        val_4 = 1;
        if((val_4 & 1) != 0)
        {
                return;
        }
        
        if(val_3 == 0)
        {
                return;
        }
    
    }
    private void HandleEventLeave(int actorID, ExitGames.Client.Photon.EventData evLeave)
    {
        var val_32;
        int val_33;
        var val_34;
        string val_35;
        var val_36;
        var val_37;
        Room val_38;
        Room val_39;
        val_32 = evLeave;
        val_33 = actorID;
        val_34 = null;
        val_34 = null;
        if(PhotonNetwork.logLevel >= 1)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = "HandleEventLeave for player ID: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_33;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " evLeave: ";
            val_35 = val_32.ToStringFull();
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_35;
            string val_2 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        
        PhotonPlayer val_3 = this.GetPlayerWithId(number:  val_33);
        if(val_3 == null)
        {
            goto label_22;
        }
        
        val_35 = val_3.IsInactive;
        if((evLeave.Parameters.ContainsKey(key:  233)) != false)
        {
                val_36 = evLeave.Parameters.Item[233];
            val_37 = null;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_3.IsInactive = false;
            if(val_35 ^ val_3.IsInactive != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = val_3;
            NetworkingPeer.SendMonoMessage(methodString:  null, parameters:  28);
        }
        
            if((val_35 & val_3.IsInactive) != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = "HandleEventLeave for player ID: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_33;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " isInactive: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_3.IsInactive;
            typeof(System.Object[]).__il2cppRuntimeField_39 = 30353584;
            typeof(System.Object[]).__il2cppRuntimeField_40 = ". Stopping handling if inactive.";
            val_33 = +0;
            UnityEngine.Debug.LogWarning(message:  0);
            return;
        }
        
        }
        
        if((evLeave.Parameters.ContainsKey(key:  203)) == false)
        {
            goto label_60;
        }
        
        val_36 = val_32.Item[203];
        val_37 = null;
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        if(null == null)
        {
            goto label_77;
        }
        
        object val_18 = val_32.Item[203];
        val_32 = null;
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y});
        this.mMasterClientId = 53248;
        this.UpdateMasterClient();
        goto label_77;
        label_22:
        val_33 = System.String.Format(format:  0, arg0:  "Received event Leave for unknown player ID: {0}");
        UnityEngine.Debug.LogError(message:  0);
        return;
        label_60:
        if((this.currentRoom == null) || (this.currentRoom.IsLocalClientInside == false))
        {
            goto label_75;
        }
        
        val_38 = this.currentRoom;
        if(val_38 != null)
        {
            goto label_76;
        }
        
        label_75:
        val_38 = 0;
        label_76:
        if(val_38.serverSideMasterClient != true)
        {
                this.CheckMasterClient(leavingPlayerId:  val_33);
        }
        
        label_77:
        if((val_35 | (~val_3.IsInactive)) == false)
        {
                return;
        }
        
        if((this.currentRoom == null) || ((this.currentRoom.IsLocalClientInside == false) || (this.currentRoom == null)))
        {
            goto label_84;
        }
        
        if(this.currentRoom.IsLocalClientInside == false)
        {
            goto label_82;
        }
        
        val_39 = this.currentRoom;
        if(val_39 != null)
        {
            goto label_83;
        }
        
        label_82:
        val_39 = 0;
        label_83:
        if(val_39.AutoCleanUp != false)
        {
                this.DestroyPlayerObjects(playerId:  val_33, localOnly:  true);
        }
        
        label_84:
        this.RemovePlayer(ID:  val_33, player:  val_3);
        val_33 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_3;
        NetworkingPeer.SendMonoMessage(methodString:  null, parameters:  14);
    }
    private void CheckMasterClient(int leavingPlayerId)
    {
        var val_9;
        PhotonPlayer val_10;
        var val_11;
        var val_12;
        val_10 = this;
        if(this.mMasterClientId != leavingPlayerId)
        {
                if(((leavingPlayerId < 1) ? 1 : 0) == 0)
        {
                return;
        }
        
        }
        
        if(this.mActors.Count <= 1)
        {
            goto label_4;
        }
        
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_5 = this.mActors.Keys.GetEnumerator();
        val_9 = 2147483647;
        goto label_7;
        label_9:
        int val_6 = (val_5.host_enumerator.current.Value >= leavingPlayerId) ? (val_9) : val_5.host_enumerator.current.Value;
        label_7:
        if((0 & 1) == 0)
        {
            goto label_8;
        }
        
        goto label_9;
        label_4:
        val_9 = this.<LocalPlayer>k__BackingField.ID;
        goto label_14;
        label_8:
        val_11 = 0;
        val_12 = 1;
        label_14:
        this.mMasterClientId = val_6;
        if(leavingPlayerId < 1)
        {
                return;
        }
        
        val_10 = this.GetPlayerWithId(number:  val_6);
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_10;
        NetworkingPeer.SendMonoMessage(methodString:  null, parameters:  2);
    }
    protected internal void UpdateMasterClient()
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = PhotonNetwork.masterClient;
        NetworkingPeer.SendMonoMessage(methodString:  null, parameters:  2);
    }
    private static int ReturnLowestPlayerId(PhotonPlayer[] players, int playerIdToIgnore)
    {
        var val_5;
        if((playerIdToIgnore != 0) && ((playerIdToIgnore + 24) != 0))
        {
                val_5 = 2147483647;
            if((playerIdToIgnore + 24) < 1)
        {
                return (int)val_5;
        }
        
            do
        {
            int val_1 = playerIdToIgnore + 0;
            if(((playerIdToIgnore + 0) + 32.ID) != W2)
        {
                if(((playerIdToIgnore + 0) + 32.ID) < val_5)
        {
                val_5 = (playerIdToIgnore + 0) + 32.ID;
        }
        
        }
        
        }
        while((0 + 1) < (playerIdToIgnore + 24));
        
            return (int)val_5;
        }
        
        val_5 = 0;
        return (int)val_5;
    }
    protected internal bool SetMasterClient(int playerId, bool sync)
    {
        var val_6;
        int val_7;
        var val_8;
        val_6 = sync;
        val_7 = playerId;
        if((this.mMasterClientId == val_7) || ((this.mActors.ContainsKey(key:  val_7)) == false))
        {
            goto label_6;
        }
        
        if(val_6 == false)
        {
            goto label_4;
        }
        
        ExitGames.Client.Photon.Hashtable val_3 = null;
        val_6 = val_3;
        val_3 = new ExitGames.Client.Photon.Hashtable();
        Add(key:  1, value:  val_7);
        if((this & 1) == 0)
        {
            goto label_6;
        }
        
        label_4:
        this.hasSwitchedMC = true;
        if(this.currentRoom != null)
        {
                if(this.currentRoom.IsLocalClientInside != false)
        {
                if(this.currentRoom != null)
        {
            goto label_9;
        }
        
        }
        
        }
        
        label_9:
        0.MasterClientId = val_7;
        val_6 = null;
        val_7 = this.GetPlayerWithId(number:  val_7);
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_7;
        NetworkingPeer.SendMonoMessage(methodString:  null, parameters:  2);
        val_8 = 1;
        return (bool)val_8;
        label_6:
        val_8 = 0;
        return (bool)val_8;
    }
    public bool SetMasterClient(int nextMasterId)
    {
        Add(key:  248, value:  nextMasterId);
        Add(key:  248, value:  this.mMasterClientId);
        return (bool)this.OpSetPropertiesOfRoom(gameProperties:  new ExitGames.Client.Photon.Hashtable(), expectedProperties:  new ExitGames.Client.Photon.Hashtable(), webForward:  false);
    }
    protected internal PhotonPlayer GetPlayerWithId(int number)
    {
        if(this.mActors == null)
        {
                return (PhotonPlayer)0;
        }
        
        PhotonPlayer val_1 = 0;
        bool val_2 = this.mActors.TryGetValue(key:  number, value: out  val_1);
        0 = val_1;
        return (PhotonPlayer)0;
    }
    private void SendPlayerName()
    {
        PhotonPlayer val_5;
        if((this.<State>k__BackingField) == 8)
        {
                this.mPlayernameHasToBeUpdated = true;
            return;
        }
        
        if((this.<LocalPlayer>k__BackingField) == null)
        {
                return;
        }
        
        this.<LocalPlayer>k__BackingField.NickName = this.playername;
        set_Item(key:  255, value:  this.playername);
        val_5 = this.<LocalPlayer>k__BackingField;
        if(val_5.ID < 1)
        {
                return;
        }
        
        val_5 = this.<LocalPlayer>k__BackingField;
        bool val_4 = this.OpSetPropertiesOfActor(actorNr:  val_5.ID, actorProperties:  new ExitGames.Client.Photon.Hashtable(), expectedProperties:  0, webForward:  false);
        this.mPlayernameHasToBeUpdated = false;
    }
    private ExitGames.Client.Photon.Hashtable GetLocalActorProperties()
    {
        if(PhotonNetwork.player != null)
        {
                PhotonPlayer val_2 = PhotonNetwork.player;
            if(val_2 != null)
        {
                return val_2.AllProperties;
        }
        
            return val_2.AllProperties;
        }
        
        set_Item(key:  255, value:  this.playername);
        return (ExitGames.Client.Photon.Hashtable)new ExitGames.Client.Photon.Hashtable();
    }
    public void DebugReturn(ExitGames.Client.Photon.DebugLevel level, string message)
    {
        ExitGames.Client.Photon.DebugLevel val_1 = level & 255;
        val_1 = val_1 - 1;
        if(val_1 > 4)
        {
                return;
        }
        
        var val_14 = 25811704 + (((level & 255) - 1)) << 2;
        val_14 = val_14 + 25811704;
        goto (25811704 + (((level & 255) - 1)) << 2 + 25811704);
    }
    public void OnOperationResponse(ExitGames.Client.Photon.OperationResponse operationResponse)
    {
        PhotonNetworkingMessage val_144;
        var val_145;
        NetworkingPeer val_146;
        var val_147;
        var val_148;
        string val_149;
        var val_151;
        string val_152;
        var val_153;
        AuthenticationValues val_154;
        string val_155;
        ExitGames.Client.Photon.Hashtable val_156;
        PhotonNetworkingMessage val_163;
        var val_164;
        string val_169;
        ExitGames.Client.Photon.Hashtable val_170;
        var val_191;
        var val_192;
        var val_193;
        var val_194;
        var val_195;
        CloudRegionCode val_196;
        CloudRegionCode val_197;
        val_144 = this;
        val_145 = null;
        val_145 = null;
        val_146 = PhotonNetwork.networkingPeer;
        if((PhotonNetwork.networkingPeer.<State>k__BackingField) == 14)
        {
                val_147 = null;
            val_147 = null;
            if(PhotonNetwork.logLevel < 1)
        {
                return;
        }
        
            val_144 = 0 + "OperationResponse ignored while disconnecting. Code: "("OperationResponse ignored while disconnecting. Code: ");
            UnityEngine.Debug.Log(message:  0);
            return;
        }
        
        if(operationResponse.ReturnCode > 32759)
        {
            goto label_15;
        }
        
        if(operationResponse.ReturnCode == 0)
        {
            goto label_16;
        }
        
        if(operationResponse.ReturnCode != 32752)
        {
            goto label_33;
        }
        
        val_148 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Operation ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = operationResponse.OperationCode;
        typeof(System.Object[]).__il2cppRuntimeField_29 = 30361204;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ";
        val_149 = operationResponse.DebugMessage;
        if(val_149 != null)
        {
            goto label_30;
        }
        
        goto label_61;
        label_15:
        if(operationResponse.ReturnCode == 32760)
        {
            goto label_32;
        }
        
        if(operationResponse.ReturnCode != (-3))
        {
            goto label_33;
        }
        
        string val_2 = 0 + "Operation " + operationResponse.OperationCode;
        goto label_36;
        label_16:
        val_151 = null;
        val_151 = null;
        if(PhotonNetwork.logLevel < 1)
        {
            goto label_48;
        }
        
        UnityEngine.Debug.Log(message:  0);
        goto label_48;
        label_32:
        string val_3 = operationResponse.ToStringFull();
        string val_4 = 0 + "Operation failed: "("Operation failed: ");
        UnityEngine.Debug.LogWarning(message:  0);
        goto label_48;
        label_33:
        val_148 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Operation failed: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = operationResponse.ToStringFull();
        typeof(System.Object[]).__il2cppRuntimeField_30 = " Server: ";
        val_149 = this.<Server>k__BackingField;
        if((this.<Server>k__BackingField) == 0)
        {
            goto label_61;
        }
        
        label_30:
        label_61:
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_149;
        string val_6 = +0;
        label_36:
        UnityEngine.Debug.LogError(message:  0);
        label_48:
        val_146 = operationResponse.Parameters;
        val_152 = 1152921512376060240;
        val_153 = 221;
        if((val_146.ContainsKey(key:  221)) != false)
        {
                val_154 = this.<AuthValues>k__BackingField;
            if(val_154 == null)
        {
                AuthenticationValues val_8 = null;
            val_154 = val_8;
            val_8 = new AuthenticationValues();
            this.<AuthValues>k__BackingField = val_154;
        }
        
            object val_9 = operationResponse.Item[221];
            if(val_9 != null)
        {
                var val_10 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_155 = 0;
        }
        
            Token = val_155;
            val_146 = this.<AuthValues>k__BackingField;
            val_153 = 0;
            this.tokenCache = val_146.Token;
        }
        
        byte val_146 = operationResponse.OperationCode;
        byte val_12 = val_146 & 255;
        if((val_12 - 217) > 14)
        {
            goto label_77;
        }
        
        if(((25812160 + (((operationResponse.OperationCode & 255) - 217)) << 2) - 41) > 10)
        {
            goto label_78;
        }
        
        var val_145 = 25811724;
        val_145 = (25811724 + ((25812160 + (((operationResponse.OperationCode & 255) - 217)) << 2 - 41)) << 2) + val_145;
        goto (25811724 + ((25812160 + (((operationResponse.OperationCode & 255) - 217)) << 2 - 41)) << 2 + 25811724);
        label_78:
        if((25812160 + (((operationResponse.OperationCode & 255) - 217)) << 2) != 0)
        {
                return;
        }
        
        label_77:
        val_146 = val_12 - 251;
        val_12 = val_12 - 198;
        var val_17 = (val_146 < 4) ? (val_12) : 0;
        if(val_17 == 0)
        {
            goto label_84;
        }
        
        if(val_17 == 53)
        {
            goto label_85;
        }
        
        if(val_17 == 56)
        {
            goto label_484;
        }
        
        return;
        label_84:
        val_144 = System.String.Format(format:  0, arg0:  "OperationResponse unhandled: {0}");
        UnityEngine.Debug.LogWarning(message:  0);
        return;
        label_85:
        object val_19 = operationResponse.Item[249];
        val_146 = 0;
        if(val_19 != null)
        {
                val_146 = val_19;
            val_146 = 0;
        }
        
        object val_22 = operationResponse.Item[248];
        val_156 = 0;
        if(val_22 != null)
        {
                val_156 = val_22;
            val_156 = 0;
        }
        
        this.ReadoutProperties(gameProperties:  val_156, pActorProperties:  val_146, targetActorNr:  0);
        return;
        label_230:
        if((0 & 1) == 0)
        {
            goto label_488;
        }
        
        if(1152921505024093152 == 0)
        {
            goto label_223;
        }
        
        val_169 = ;
        if(1152921505024093152 == null)
        {
            goto label_224;
        }
        
        label_223:
        val_169 = 0;
        label_224:
        val_170 = 0.Item[1152921505024093152];
        val_170 = 0;
        RoomInfo val_58 = new RoomInfo(roomName:  val_169, properties:  val_170);
        this.mGameList.set_Item(key:  val_169, value:  null);
        goto label_230;
        label_488:
        val_146 = this.mGameList.Count;
        this.mGameListCopy = null;
        this.mGameList.Values.CopyTo(array:  this.mGameListCopy, index:  0);
        val_144 = null;
        val_163 = val_144;
        val_164 = 11;
        NetworkingPeer.SendMonoMessage(methodString:  val_163, parameters:  11);
        return;
        label_452:
        val_191 = null;
        val_191 = null;
        if(PhotonNetwork.logLevel < 1)
        {
            goto label_439;
        }
        
        string val_109 = 0 + "Skipping region because it\'s not in PhotonServerSettings.EnabledRegions: "("Skipping region because it\'s not in PhotonServerSettings.EnabledRegions: ");
        UnityEngine.Debug.Log(message:  0);
        goto label_439;
        label_455:
        if((System.String.IsNullOrEmpty(value:  0)) == true)
        {
            goto label_439;
        }
        
        val_152 = System.Object.__il2cppRuntimeField_byval_arg.ToLower();
        val_192 = null;
        val_192 = null;
        if(PhotonNetwork.PhotonServerSettings.HostType != 4)
        {
            goto label_448;
        }
        
        val_193 = null;
        val_193 = null;
        if( == 0)
        {
            goto label_448;
        }
        
        val_194 = null;
        val_194 = null;
        CloudRegionFlag val_147 = PhotonNetwork.PhotonServerSettings.EnabledRegions;
        val_147 = val_147 & (Region.ParseFlag(region:  0));
        if(val_147 == 0)
        {
            goto label_452;
        }
        
        label_448:
        object val_115 =  + 0;
        Add(item:  new Region(code:  Region.Parse(codeAsString:  0), regionCodeString:  val_152, address:  (val_66 + 0) + 32));
        label_439:
        if((0 + 1) < 1152921512379201696)
        {
            goto label_455;
        }
        
        val_195 = null;
        val_195 = null;
        if(PhotonNetwork.PhotonServerSettings.HostType != 4)
        {
                return;
        }
        
        object val_118 = new System.Object();
        val_196 = PhotonHandler.BestRegionCodeInPreferences;
        if(null == 0)
        {
            goto label_462;
        }
        
        val_197 = val_118;
        typeof(NetworkingPeer.<OnOperationResponse>c__AnonStorey0).__il2cppRuntimeField_10 = val_196;
        goto label_463;
        label_484:
        DisconnectToReconnect();
        return;
        label_462:
        val_197 = 16;
        mem[16] = val_196;
        val_196 = mem[16];
        label_463:
        if(val_196 != 4)
        {
                if((Exists(match:  new System.Predicate<Region>(object:  val_118, method:  System.Boolean NetworkingPeer.<OnOperationResponse>c__AnonStorey0::<>m__0(Region x)))) != false)
        {
                string val_142 = 0 + "Best region found in PlayerPrefs. Connecting to: "("Best region found in PlayerPrefs. Connecting to: ");
            UnityEngine.Debug.Log(message:  0);
            if((ConnectToRegionMaster(region:  mem[16])) == true)
        {
                return;
        }
        
        }
        
        }
        
        PhotonHandler.PingAvailableRegionsAndConnectToBest();
        return;
        label_533:
        goto label_533;
    }
    public void OnStatusChanged(ExitGames.Client.Photon.StatusCode statusCode)
    {
        DisconnectCause val_35;
        ExitGames.Client.Photon.StatusCode val_36;
        PhotonNetworkingMessage val_37;
        var val_38;
        val_36 = statusCode;
        val_37 = this;
        val_38 = null;
        val_38 = null;
        if(PhotonNetwork.logLevel >= 1)
        {
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_35 = this.<State>k__BackingField;
            string val_3 = System.String.Format(format:  0, arg0:  "OnStatusChanged: {0} current State: {1}", arg1:  val_36.ToString());
            UnityEngine.Debug.Log(message:  0);
            val_36 = null;
        }
        
        if((val_36 - 1039) > 10)
        {
            goto label_10;
        }
        
        if((25812224 + ((val_36 - 1039)) << 2) > 14)
        {
                return;
        }
        
        var val_36 = 25811768 + (25812224 + ((val_36 - 1039)) << 2) << 2;
        val_36 = val_36 + 25811768;
        goto (25811768 + (25812224 + ((val_36 - 1039)) << 2) << 2 + 25811768);
        label_10:
        if((val_36 - 1022) > 8)
        {
            goto label_12;
        }
        
        if(((25812272 + ((val_36 - 1022)) << 2) - 16) > 4)
        {
            goto label_13;
        }
        
        var val_37 = 25811828;
        val_37 = (25811828 + ((25812272 + ((val_36 - 1022)) << 2 - 16)) << 2) + val_37;
        goto (25811828 + ((25812272 + ((val_36 - 1022)) << 2 - 16)) << 2 + 25811828);
        label_13:
        if((25812272 + ((val_36 - 1022)) << 2) != 0)
        {
                return;
        }
        
        label_12:
        val_37 = 0 + "Received unknown status code: "("Received unknown status code: ");
        UnityEngine.Debug.LogError(message:  0);
    }
    public void OnEvent(ExitGames.Client.Photon.EventData photonEvent)
    {
        object val_169;
        var val_170;
        EventCallback val_172;
        var val_173;
        PhotonPlayer val_174;
        var val_177;
        var val_178;
        var val_179;
        string val_200;
        ExitGames.Client.Photon.Hashtable val_201;
        var val_205;
        PhotonNetworkingMessage val_206;
        System.Object[] val_207;
        string val_210;
        ExitGames.Client.Photon.Hashtable val_211;
        object val_222;
        val_169 = this;
        val_170 = null;
        val_170 = null;
        if(PhotonNetwork.logLevel >= 1)
        {
                string val_1 = System.String.Format(format:  0, arg0:  "OnEvent: {0}");
            UnityEngine.Debug.Log(message:  0);
        }
        
        if((photonEvent.Parameters.ContainsKey(key:  254)) != false)
        {
                val_172 = photonEvent.Item[254];
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            PhotonPlayer val_5 = this.GetPlayerWithId(number:  53248);
        }
        else
        {
                val_174 = 0;
            val_173 = 0;
        }
        
        if((photonEvent.Code - 200) > 10)
        {
            goto label_17;
        }
        
        if((25812320 + ((photonEvent.Code - 200)) << 2) > 20)
        {
                return;
        }
        
        var val_168 = 25811848 + (25812320 + ((photonEvent.Code - 200)) << 2) << 2;
        val_168 = val_168 + 25811848;
        goto (25811848 + (25812320 + ((photonEvent.Code - 200)) << 2) << 2 + 25811848);
        label_17:
        if((photonEvent.Code - 223) > 7)
        {
            goto label_19;
        }
        
        if(((25812368 + ((photonEvent.Code - 223)) << 2) - 22) > 5)
        {
            goto label_20;
        }
        
        var val_169 = 25811932;
        val_169 = (25811932 + ((25812368 + ((photonEvent.Code - 223)) << 2 - 22)) << 2) + val_169;
        goto (25811932 + ((25812368 + ((photonEvent.Code - 223)) << 2 - 22)) << 2 + 25811932);
        label_20:
        if((25812368 + ((photonEvent.Code - 223)) << 2) != 0)
        {
                return;
        }
        
        label_19:
        byte val_11 = photonEvent.Code - 222;
        var val_12 = ((photonEvent.Code - 251) < 5) ? (val_11) : 0;
        val_11 = val_12 - 29;
        if(val_11 > 4)
        {
            goto label_24;
        }
        
        var val_170 = 25811956;
        val_170 = (25811956 + ((val_10 < 5 ? (photonEvent.Code - 222) : 0 - 29)) << 2) + val_170;
        goto (25811956 + ((val_10 < 5 ? (photonEvent.Code - 222) : 0 - 29)) << 2 + 25811956);
        label_24:
        if(val_12 != 0)
        {
                return;
        }
        
        if(photonEvent.Code > 199)
        {
                return;
        }
        
        val_178 = null;
        val_178 = null;
        if(PhotonNetwork.OnEventCall == null)
        {
            goto label_34;
        }
        
        val_177 = 245;
        val_179 = null;
        val_169 = photonEvent.Item[245];
        val_179 = null;
        val_172 = PhotonNetwork.OnEventCall;
        val_172.Invoke(eventCode:  photonEvent.Code, content:  val_169, senderId:  0);
        return;
        label_165:
        if((0 & 1) == 0)
        {
            goto label_167;
        }
        
        if(1 == 0)
        {
            goto label_154;
        }
        
        val_200 = ;
        if(1 == null)
        {
            goto label_155;
        }
        
        label_154:
        val_200 = 0;
        label_155:
        val_201 = 0.Item[1];
        val_201 = 0;
        RoomInfo val_78 = new RoomInfo(roomName:  val_200, properties:  val_201);
        if(removedFromList == false)
        {
            goto label_161;
        }
        
        bool val_81 = 26946632.Remove(key:  val_200);
        goto label_165;
        label_161:
        26946632.set_Item(key:  val_200, value:  null);
        goto label_165;
        label_184:
        Add(item:  26946632);
        val_205 = 1;
        if(val_205 >= 1152921512380337888)
        {
            goto label_171;
        }
        
        TypedLobbyInfo val_86 = new TypedLobbyInfo();
        object val_87 =  + 8;
        typeof(TypedLobbyInfo).__il2cppRuntimeField_10 = 1152921505030702720;
        object val_88 =  + 1;
        typeof(TypedLobbyInfo).__il2cppRuntimeField_18 = 1152921505030702720;
        object val_89 =  + 4;
        typeof(TypedLobbyInfo).__il2cppRuntimeField_1C = 1152921505030702720;
        object val_90 =  + 4;
        typeof(TypedLobbyInfo).__il2cppRuntimeField_20 = 1152921505030702720;
        if(26946632 != 0)
        {
            goto label_184;
        }
        
        goto label_184;
        label_171:
        val_169 = null;
        val_206 = val_169;
        val_207 = 27;
        goto label_216;
        label_207:
        if((0 & 1) == 0)
        {
            goto label_415;
        }
        
        if(1 == 0)
        {
            goto label_200;
        }
        
        val_210 = ;
        if(1 == null)
        {
            goto label_201;
        }
        
        label_200:
        val_210 = 0;
        label_201:
        val_211 = 0.Item[1];
        val_211 = 0;
        RoomInfo val_107 = new RoomInfo(roomName:  val_210, properties:  val_211);
        set_Item(key:  val_210, value:  null);
        goto label_207;
        label_415:
        label_167:
        val_172 = Count;
        typeof(System.Object[]).__il2cppRuntimeField_140 = null;
        Values.CopyTo(array:  typeof(System.Object[]).__il2cppRuntimeField_140, index:  0);
        val_169 = null;
        val_206 = val_169;
        val_207 = 11;
        goto label_216;
        label_34:
        string val_116 = 0 + "Warning: Unhandled event "("Warning: Unhandled event ") + photonEvent;
        goto label_246;
        label_216:
        NetworkingPeer.SendMonoMessage(methodString:  null, parameters:  null);
        return;
        label_246:
        val_169 = 0 + "Can\'t find PhotonView of incoming OwnershipRequest. ViewId not found: "("Can\'t find PhotonView of incoming OwnershipRequest. ViewId not found: ");
        val_222 = 0;
        UnityEngine.Debug.LogWarning(message:  null);
        return;
        label_460:
        goto label_460;
    }
    public void OnMessage(object messages)
    {
    
    }
    private void SetupEncryption(System.Collections.Generic.Dictionary<byte, object> encryptionData)
    {
        System.Byte[] val_16;
        System.Byte[] val_17;
        System.Byte[] val_18;
        var val_19;
        if((this.AuthMode == 0) && (true == 1))
        {
                string val_1 = Extensions.ToStringFull(origin:  0);
            string val_2 = 0 + "SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: "("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ");
            UnityEngine.Debug.LogWarning(message:  0);
            return;
        }
        
        if(true == 3)
        {
                string val_3 = Extensions.ToStringFull(origin:  0);
            string val_4 = 0 + "SetupEncryption() got called. ";
            UnityEngine.Debug.Log(message:  0);
        }
        
        object val_5 = encryptionData.Item[0];
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        if(null == null)
        {
            goto label_19;
        }
        
        if(null != 10)
        {
            goto label_20;
        }
        
        object val_7 = encryptionData.Item[1];
        if(val_7 == null)
        {
            goto label_22;
        }
        
        val_16 = val_7;
        if(val_16 != null)
        {
            goto label_23;
        }
        
        label_22:
        val_16 = 0;
        label_23:
        object val_9 = encryptionData.Item[2];
        if(val_9 == null)
        {
            goto label_25;
        }
        
        val_17 = val_9;
        if(val_17 != null)
        {
            goto label_26;
        }
        
        label_25:
        val_17 = 0;
        label_26:
        bool val_11 = this.InitDatagramEncryption(encryptionSecret:  val_16, hmacSecret:  val_17);
        return;
        label_19:
        val_16 = encryptionData.Item[1];
        if(val_16 == null)
        {
            goto label_29;
        }
        
        val_18 = val_16;
        if(val_18 != null)
        {
            goto label_30;
        }
        
        label_29:
        val_18 = 0;
        label_30:
        this.InitPayloadEncryption(secret:  val_18);
        return;
        label_20:
        val_19 = new System.ArgumentOutOfRangeException();
        label_33:
        goto label_33;
    }
    protected internal void UpdatedActorList(int[] actorsInRoom)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        goto label_1;
        label_11:
        val_4 = 1;
        label_1:
        if(val_4 >= actorsInRoom.Length)
        {
                return;
        }
        
        int val_4 = actorsInRoom[1];
        if((this.<LocalPlayer>k__BackingField.ID) == val_4)
        {
            goto label_11;
        }
        
        actorsInRoom[1] = this.mActors.ContainsKey(key:  val_4);
        if(actorsInRoom[1] == true)
        {
            goto label_11;
        }
        
        val_5 = null;
        val_5 = null;
        this.AddNewPlayer(ID:  val_4, player:  new PhotonPlayer(isLocal:  false, actorID:  val_4, name:  System.String.Empty));
        goto label_11;
    }
    private void SendVacantViewIds()
    {
        System.Collections.Generic.List<T> val_10;
        var val_11;
        UnityEngine.Debug.Log(message:  0);
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = this.photonViewList.Values.GetEnumerator();
        label_10:
        if((0 & 1) == 0)
        {
            goto label_5;
        }
        
        if(0.isOwnerActive == true)
        {
            goto label_10;
        }
        
        Add(item:  0.viewID);
        goto label_10;
        label_5:
        val_10 = 0;
        val_11 = 1;
        int val_7 = Count;
        string val_8 = 0 + "Sending vacant view IDs. Length: "("Sending vacant view IDs. Length: ");
        UnityEngine.Debug.Log(message:  0);
        T[] val_9 = ToArray();
    }
    public static void SendMonoMessage(PhotonNetworkingMessage methodString, object[] parameters)
    {
        object val_9;
        var val_10;
        System.Collections.Generic.HashSet<UnityEngine.GameObject> val_13;
        var val_14;
        var val_15;
        val_9 = X2;
        val_10 = null;
        val_10 = null;
        val_13 = PhotonNetwork.SendMonoMessageTargets;
        if(val_13 != null)
        {
                val_13 = PhotonNetwork.SendMonoMessageTargets;
        }
        else
        {
                val_13 = PhotonNetwork.FindGameObjectsWithComponent(type:  0);
        }
        
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        if((val_9 != 0) && ((X2 + 24) == 1))
        {
                val_9 = mem[X2 + 32];
            val_9 = X2 + 32;
        }
        
        HashSet.Enumerator<T> val_6 = val_13.GetEnumerator();
        label_19:
        if((0 & 1) == 0)
        {
            goto label_14;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_7 = 0.InitializationCallback;
        if(0 == val_7)
        {
            goto label_19;
        }
        
        val_7.SendMessage(methodName:  parameters.ToString(), value:  val_9, options:  1);
        goto label_19;
        label_14:
        val_14 = 0;
        val_15 = 1;
        0.Dispose();
        if((val_15 & 1) != 0)
        {
                return;
        }
        
        if(val_14 == 0)
        {
                return;
        }
    
    }
    protected internal void ExecuteRpc(ExitGames.Client.Photon.Hashtable rpcData, int senderID = 0)
    {
        var val_79;
        var val_80;
        int val_83;
        var val_84;
        string val_85;
        var val_86;
        System.Object[] val_87;
        var val_88;
        var val_89;
        var val_90;
        System.Type[] val_91;
        var val_92;
        UnityEngine.MonoBehaviour[] val_95;
        System.Collections.Generic.List<System.Reflection.MethodInfo> val_96;
        var val_97;
        var val_98;
        var val_99;
        System.Collections.IEnumerator val_100;
        string val_106;
        string val_107;
        var val_108;
        string val_109;
        var val_110;
        string val_111;
        if(rpcData == null)
        {
            goto label_2;
        }
        
        val_79 = 1152921512375239264;
        if((rpcData.ContainsKey(key:  0)) == false)
        {
            goto label_2;
        }
        
        object val_3 = rpcData.Item[0];
        val_80 = null;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        if((rpcData.ContainsKey(key:  1)) == false)
        {
            goto label_5;
        }
        
        object val_6 = rpcData.Item[1];
        val_80 = null;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y});
        goto label_8;
        label_2:
        string val_8 = ExitGames.Client.Photon.SupportClass.DictionaryToString(dictionary:  0);
        label_76:
        string val_9 = 0 + "Malformed RPC; this should never occur. Content: "("Malformed RPC; this should never occur. Content: ");
        label_141:
        UnityEngine.Debug.LogError(message:  0);
        return;
        label_5:
        val_83 = 0;
        label_8:
        if((rpcData.ContainsKey(key:  5)) == false)
        {
            goto label_15;
        }
        
        object val_11 = rpcData.Item[5];
        val_80 = null;
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y});
        val_84 = null;
        val_84 = null;
        if(null <= (Count - 1))
        {
            goto label_22;
        }
        
        string val_15 = 0 + "Could not find RPC with index: "("Could not find RPC with index: ") + null;
        goto label_141;
        label_15:
        object val_16 = rpcData.Item[3];
        val_85 = 0;
        if(val_16 == null)
        {
            goto label_28;
        }
        
        val_85 = val_16;
        if(null == null)
        {
            goto label_28;
        }
        
        val_85 = 0;
        goto label_28;
        label_22:
        val_86 = null;
        val_86 = null;
        val_85 = Item[53248];
        label_28:
        if((rpcData.ContainsKey(key:  4)) == false)
        {
            goto label_34;
        }
        
        object val_20 = rpcData.Item[4];
        if(val_20 == null)
        {
            goto label_34;
        }
        
        val_87 = val_20;
        if(val_20 != null)
        {
            goto label_35;
        }
        
        label_34:
        val_87 = null;
        label_35:
        PhotonView val_22 = this.GetPhotonView(viewID:  53248);
        if(0 != val_22)
        {
            goto label_38;
        }
        
        val_88 = null;
        val_88 = null;
        object val_24 = 1152921504606900224 / PhotonNetwork.MAX_VIEW_IDS;
        if(val_24 != mem[1152921512382337008].ID)
        {
            goto label_42;
        }
        
        val_89 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Received RPC \"";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_85;
        typeof(System.Object[]).__il2cppRuntimeField_30 = "\" for viewID ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = null;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_40 = " but this PhotonView does not exist! View was/is ours.";
        typeof(System.Object[]).__il2cppRuntimeField_48 = (val_24 == senderID) ? " Owner called." : " Remote called.";
        typeof(System.Object[]).__il2cppRuntimeField_50 = " By: ";
        typeof(System.Object[]).__il2cppRuntimeField_58 = senderID;
        typeof(System.Object[]).__il2cppRuntimeField_5C = 268435457;
        goto label_68;
        label_38:
        if(val_22.prefix != val_83)
        {
            goto label_70;
        }
        
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_73;
        }
        
        string val_29 = ExitGames.Client.Photon.SupportClass.DictionaryToString(dictionary:  0);
        goto label_76;
        label_42:
        val_89 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Received RPC \"";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_85;
        typeof(System.Object[]).__il2cppRuntimeField_30 = "\" for viewID ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = null;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_40 = " but this PhotonView does not exist! Was remote PV.";
        typeof(System.Object[]).__il2cppRuntimeField_48 = (val_24 == senderID) ? " Owner called." : " Remote called.";
        typeof(System.Object[]).__il2cppRuntimeField_50 = " By: ";
        typeof(System.Object[]).__il2cppRuntimeField_58 = senderID;
        typeof(System.Object[]).__il2cppRuntimeField_5C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_60 = " Maybe GO was destroyed but RPC not cleaned up.";
        label_68:
        string val_31 = +0;
        UnityEngine.Debug.LogWarning(message:  0);
        return;
        label_70:
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Received RPC \"";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_85;
        typeof(System.Object[]).__il2cppRuntimeField_30 = "\" on viewID ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = null;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_40 = " with a prefix of ";
        typeof(System.Object[]).__il2cppRuntimeField_48 = val_83;
        typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_50 = ", our prefix is ";
        typeof(System.Object[]).__il2cppRuntimeField_58 = val_22.prefix;
        typeof(System.Object[]).__il2cppRuntimeField_5C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_60 = ". The RPC has been ignored.";
        string val_33 = +0;
        goto label_141;
        label_73:
        val_90 = null;
        val_90 = null;
        if(PhotonNetwork.logLevel >= 2)
        {
                string val_34 = 0 + "Received RPC: "("Received RPC: ");
            UnityEngine.Debug.Log(message:  0);
        }
        
        if(val_22.group != 0)
        {
                if((mem[1152921512382337112].Contains(item:  val_22.group)) == false)
        {
                return;
        }
        
        }
        
        val_91 = null;
        val_91 = null;
        val_92 = 0;
        goto label_155;
        label_167:
        val_92 = 1;
        label_155:
        if(typeof(System.Object[]).__il2cppRuntimeField_28 == 0)
        {
            goto label_159;
        }
        
        System.Type[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20 = typeof(System.Object[]).__il2cppRuntimeField_28.GetType();
        goto label_167;
        label_159:
        System.Type[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20 = 0;
        goto label_167;
        label_277:
        var val_79 = 0;
        val_95 = ;
        val_79 = val_79 + 1;
        if(val_79 >= (val_22.RpcMonoBehaviours + 24))
        {
            goto label_179;
        }
        
        UnityEngine.MonoBehaviour[] val_37 = val_95 + (((long)(int)((0 + 1))) << 3);
        if(0 != ((val_22.RpcMonoBehaviours + ((long)(int)((0 + 1))) << 3) + 32))
        {
            goto label_185;
        }
        
        UnityEngine.Debug.LogError(message:  0);
        goto label_277;
        label_185:
        System.Type val_39 = (val_22.RpcMonoBehaviours + ((long)(int)((0 + 1))) << 3) + 32.GetType();
        System.Collections.Generic.List<System.Reflection.MethodInfo> val_40 = 0;
        if((mem[1152921512382337184].TryGetValue(key:  val_39, value: out  val_40)) != false)
        {
                val_96 = val_40;
        }
        else
        {
                System.Type val_43 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_96 = ExitGames.Client.Photon.SupportClass.GetMethods(type:  0, attribute:  val_39);
            mem[1152921512382337184].set_Item(key:  val_39, value:  val_96);
            val_85 = val_85;
        }
        
        if(val_96 == null)
        {
            goto label_277;
        }
        
        val_97 = 0;
        goto label_199;
        label_276:
        val_96 = val_96;
        val_97 = 1;
        label_199:
        if(val_97 >= val_96.Count)
        {
            goto label_277;
        }
        
        System.Reflection.MethodInfo val_46 = val_96.Item[1];
        if((val_46.Equals(value:  val_85)) == false)
        {
            goto label_276;
        }
        
        System.Reflection.ParameterInfo[] val_48 = Extensions.GetCachedParemeters(mo:  0);
         =  + 1;
        if((val_48.CheckTypeMatch(methodParameters:  val_48, callParameterTypes:  val_91)) == false)
        {
            goto label_276;
        }
        
        int val_81 = 0;
        val_81 = val_81 + 1;
        object val_50 = val_46.Invoke(obj:  (val_22.RpcMonoBehaviours + ((long)(int)((0 + 1))) << 3) + 32, parameters:  val_87);
        val_98 = null;
        val_98 = null;
        if(PhotonNetwork.StartRpcsAsCoroutine == false)
        {
            goto label_276;
        }
        
        val_99 = val_85;
        if(val_46 != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
        {
            goto label_276;
        }
        
        if(val_50 == null)
        {
            goto label_268;
        }
        
        val_100 = val_50;
        if(val_100 != null)
        {
            goto label_270;
        }
        
        val_100 = 0;
        goto label_270;
        label_268:
        val_100 = 0;
        label_270:
        UnityEngine.Coroutine val_69 = (val_22.RpcMonoBehaviours + ((long)(int)((0 + 1))) << 3) + 32.StartCoroutine(routine:  val_100);
        goto label_276;
        label_179:
        if( == 1)
        {
                return;
        }
        
        val_106 = null;
        val_107 = val_85;
        val_108 = 0;
        val_109 = System.String.Empty;
        goto label_282;
        label_297:
        val_109 =  + 0;
        val_108 = 1;
        label_282:
        val_110 = null;
        val_110 = null;
        val_111 = val_109;
        if((System.String.op_Inequality(a:  0, b:  val_111)) != false)
        {
                val_111 = val_109;
            val_109 = 0 + val_111;
        }
        
        if(System.Type[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20 == 0)
        {
            goto label_297;
        }
        
        goto label_297;
        label_390:
        goto label_390;
    }
    private bool CheckTypeMatch(System.Reflection.ParameterInfo[] methodParameters, System.Type[] callParameterTypes)
    {
        var val_4;
        var val_5;
        var val_6;
        System.Type val_7;
        val_5 = 0;
        if(methodParameters.Length < callParameterTypes.Length)
        {
                return (bool)val_5;
        }
        
        val_6 = 0;
        goto label_4;
        label_22:
        val_6 = 1;
        label_4:
        if(val_6 >= callParameterTypes.Length)
        {
            goto label_6;
        }
        
        val_4 = methodParameters[1];
        val_7 = callParameterTypes[1];
        if(val_7 == null)
        {
            goto label_22;
        }
        
        if(val_6 >= callParameterTypes.Length)
        {
                val_7 = mem[callParameterTypes[0x1] + 32];
            val_7 = callParameterTypes[0x1] + 32;
        }
        
        if(((val_4 & 1) & 1) != 0)
        {
            goto label_22;
        }
        
        if(val_4.IsEnum == false)
        {
            goto label_16;
        }
        
        val_4 = System.Enum.GetUnderlyingType(enumType:  0);
        if((val_4 & 1) != 0)
        {
            goto label_22;
        }
        
        label_16:
        val_5 = 0;
        return (bool)val_5;
        label_6:
        val_5 = 1;
        return (bool)val_5;
    }
    internal ExitGames.Client.Photon.Hashtable SendInstantiate(string prefabName, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, byte group, int[] viewIDs, object[] data, bool isGlobalObject)
    {
        string val_10 = prefabName;
        set_Item(key:  0, value:  val_10 = prefabName);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) != false)
        {
                val_10 = 1;
            set_Item(key:  1, value:  position);
        }
        
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
        if((UnityEngine.Quaternion.op_Inequality(lhs:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, rhs:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w})) != false)
        {
                val_10 = 2;
            set_Item(key:  2, value:  rotation);
        }
        
        if((group & 255) != 0)
        {
                val_10 = 3;
            set_Item(key:  3, value:  group);
        }
        
        if(viewIDs.Length >= 2)
        {
                set_Item(key:  4, value:  viewIDs);
        }
        
        if(data != null)
        {
                set_Item(key:  5, value:  data);
        }
        
        if(this.currentLevelPrefix >= 1)
        {
                set_Item(key:  8, value:  this.currentLevelPrefix);
        }
        
        set_Item(key:  6, value:  PhotonNetwork.ServerTimestamp);
        set_Item(key:  7, value:  viewIDs[0]);
        RaiseEventOptions val_8 = new RaiseEventOptions();
        typeof(RaiseEventOptions).__il2cppRuntimeField_10 = (isGlobalObject != true) ? (4 + 1) : 4;
        return (ExitGames.Client.Photon.Hashtable)new ExitGames.Client.Photon.Hashtable();
    }
    internal UnityEngine.GameObject DoInstantiate(ExitGames.Client.Photon.Hashtable evData, PhotonPlayer photonPlayer, UnityEngine.GameObject resourceGameObject)
    {
        string val_48;
        var val_49;
        string val_50;
        var val_51;
        float val_52;
        float val_53;
        float val_54;
        var val_57;
        float val_58;
        float val_59;
        float val_60;
        var val_61;
        object val_62;
        object val_63;
        var val_64;
        System.Object[] val_65;
        var val_66;
        var val_67;
        UnityEngine.GameObject val_69;
        var val_70;
        var val_72;
        var val_73;
        var val_75;
        var val_76;
        PhotonPlayer val_77;
        var val_78;
        UnityEngine.GameObject val_29 = resourceGameObject;
        object val_1 = evData.Item[0];
        val_48 = 0;
        if(val_1 != null)
        {
                val_48 = val_1;
            if(null != null)
        {
                val_48 = 0;
        }
        
        }
        
        val_49 = evData.Item[6];
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        object val_5 = evData.Item[7];
        val_49 = null;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y});
        if((evData.ContainsKey(key:  1)) != false)
        {
                object val_8 = evData.Item[1];
            val_51 = null;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y});
        }
        else
        {
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_52 = val_10.x;
            val_53 = val_10.y;
            val_54 = val_10.z;
        }
        
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
        val_57 = val_11.x;
        val_58 = val_11.y;
        val_59 = val_11.z;
        val_60 = val_11.w;
        if((evData.ContainsKey(key:  2)) != false)
        {
                object val_13 = evData.Item[2];
            val_51 = null;
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        }
        
        if((evData.ContainsKey(key:  3)) != false)
        {
                object val_16 = evData.Item[3];
            val_51 = null;
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_11.z});
        }
        else
        {
                val_61 = 0;
        }
        
        if((evData.ContainsKey(key:  8)) != false)
        {
                object val_19 = evData.Item[8];
            val_51 = null;
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_11.z});
        }
        else
        {
                val_62 = 0;
        }
        
        if((evData.ContainsKey(key:  4)) == false)
        {
            goto label_38;
        }
        
        object val_22 = evData.Item[4];
        val_51 = 0;
        if(val_22 == null)
        {
            goto label_42;
        }
        
        val_51 = val_22;
        if(val_51 != null)
        {
            goto label_42;
        }
        
        val_51 = 0;
        goto label_42;
        label_38:
        val_51 = null;
        typeof(System.Int32[]).__il2cppRuntimeField_20 = null;
        label_42:
        val_63 = 1152921512383808160;
        val_64 = public System.Boolean System.Collections.Generic.Dictionary<System.Object, System.Object>::ContainsKey(System.Object key);
        if((evData.ContainsKey(key:  5)) == false)
        {
            goto label_46;
        }
        
        val_64 = 0;
        val_63 = evData.Item[5];
        val_65 = 0;
        if(val_63 == null)
        {
            goto label_49;
        }
        
        val_65 = val_63;
        if(val_65 != null)
        {
            goto label_49;
        }
        
        label_46:
        val_65 = 0;
        label_49:
        if(val_61 == 0)
        {
            goto label_50;
        }
        
        val_63 = mem[1152921512383677288];
        val_64 = public System.Boolean System.Collections.Generic.HashSet<System.Byte>::Contains(System.Byte item);
        if((val_63.Contains(item:  0)) == false)
        {
            goto label_52;
        }
        
        label_50:
        if(mem[1152921512383677352] == 0)
        {
            goto label_53;
        }
        
        var val_51 = mem[1152921512383677352];
        if((mem[1152921512383677352] + 258) == 0)
        {
            goto label_54;
        }
        
        var val_47 = mem[1152921512383677352] + 152;
        var val_48 = 0;
        val_47 = val_47 + 8;
        label_56:
        if(((mem[1152921512383677352] + 152 + 8) + -8) == null)
        {
            goto label_55;
        }
        
        val_48 = val_48 + 1;
        val_47 = val_47 + 16;
        if(val_48 < (mem[1152921512383677352] + 258))
        {
            goto label_56;
        }
        
        label_54:
        val_64 = 0;
        val_66 = mem[1152921512383677352];
        goto label_57;
        label_53:
        if(0 != val_29)
        {
            goto label_80;
        }
        
        val_67 = null;
        val_67 = null;
        if(NetworkingPeer.UsePrefabCache != false)
        {
                if((NetworkingPeer.PrefabCache.TryGetValue(key:  val_48, value: out  val_29)) == true)
        {
            goto label_74;
        }
        
        }
        
        System.Type val_32 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_33 = UnityEngine.Resources.Load(path:  0, systemTypeInstance:  val_48);
        val_69 = 0;
        if(val_33 != null)
        {
                val_69 = val_33;
            if(null != null)
        {
                val_69 = 0;
        }
        
        }
        
        val_70 = null;
        val_70 = null;
        if(NetworkingPeer.UsePrefabCache != false)
        {
                NetworkingPeer.PrefabCache.Add(key:  val_48, value:  val_69);
        }
        
        label_74:
        if(0 != val_69)
        {
            goto label_80;
        }
        
        val_62 = 0 + "PhotonNetwork error: Could not Instantiate the prefab ["("PhotonNetwork error: Could not Instantiate the prefab [") + val_48;
        UnityEngine.Debug.LogError(message:  0);
        label_52:
        val_72 = 0;
        return (UnityEngine.GameObject);
        label_80:
        val_73 = 0;
        goto label_91;
        label_106:
        val_73 = 1;
        mem[1152921512383676949] = 1;
        label_91:
        Extensions.GetPhotonViewsInChildren(go:  0)[1].viewID = typeof(System.Int32[]).__il2cppRuntimeField_24;
        val_37[0x1] + 32.prefix = 0;
        mem2[0] = null;
        if((val_37[0x1] + 32) != 0)
        {
            goto label_106;
        }
        
        goto label_106;
        label_55:
        val_51 = val_51 + (((mem[1152921512383677352] + 152 + 8)) << 4);
        val_66 = val_51 + 272;
        label_57:
        val_78 = 0;
        goto label_131;
        label_152:
        val_63.viewID = 417246176;
        val_78 = 1;
        label_131:
        if(val_78 >= val_39.Length)
        {
            goto label_133;
        }
        
        PhotonView val_52 = Extensions.GetPhotonViewsInChildren(go:  0)[1];
        val_39[0x1][0].didAwake = false;
        val_39[0x1] + 32.viewID = 0;
        val_39[0x1] + 32.prefix = 0;
        mem2[0] = null;
        mem2[0] = 1;
        mem2[0] = val_65;
        mem2[0] = 1;
        if((val_39[0x1] + 32) != 0)
        {
            goto label_152;
        }
        
        goto label_152;
        label_133:
        val_75 = 1152921504972926976;
        val_76 = null;
        val_77 = photonPlayer;
        val_72 = mem[1152921512383677352];
        val_50 = NetworkingPeer.OnPhotonInstantiateString;
        val_62 = 0;
        SendMessage(methodName:  val_50, value:  0, options:  1);
        return (UnityEngine.GameObject);
        label_167:
        goto label_167;
    }
    private void StoreInstantiationData(int instantiationId, object[] instantiationData)
    {
        this.tempInstantiationData.set_Item(key:  instantiationId, value:  instantiationData);
    }
    public object[] FetchInstantiationData(int instantiationId)
    {
        System.Object[] val_1 = 0;
        if(instantiationId == 0)
        {
                return (System.Object[])0;
        }
        
        bool val_2 = this.tempInstantiationData.TryGetValue(key:  instantiationId, value: out  val_1);
        0 = val_1;
        return (System.Object[])0;
    }
    private void RemoveInstantiationData(int instantiationId)
    {
        bool val_1 = this.tempInstantiationData.Remove(key:  instantiationId);
    }
    public void DestroyPlayerObjects(int playerId, bool localOnly)
    {
        UnityEngine.Object val_6;
        var val_17;
        var val_18;
        var val_19;
        val_17 = localOnly;
        if(playerId <= 0)
        {
            goto label_1;
        }
        
        if(val_17 != true)
        {
                this.OpRemoveFromServerInstantiationsOfPlayer(actorNr:  playerId);
            this.OpCleanRpcBuffer(actorNumber:  playerId);
            this.SendDestroyOfPlayer(actorNr:  playerId);
        }
        
        System.Collections.Generic.HashSet<UnityEngine.GameObject> val_2 = new System.Collections.Generic.HashSet<UnityEngine.GameObject>();
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_4 = this.photonViewList.Values.GetEnumerator();
        label_13:
        if((0 & 1) == 0)
        {
            goto label_5;
        }
        
        if((0 == val_6) || (val_6.CreatorActorNr != playerId))
        {
            goto label_13;
        }
        
        bool val_10 = Add(item:  val_6.gameObject);
        goto label_13;
        label_1:
        val_6 = playerId;
        val_18 = 0 + "Failed to Destroy objects of playerId: "("Failed to Destroy objects of playerId: ");
        UnityEngine.Debug.LogError(message:  0);
        return;
        label_5:
        HashSet.Enumerator<T> val_12 = GetEnumerator();
        val_17 = 1152921512375878400;
        label_23:
        if((0 & 1) == 0)
        {
            goto label_22;
        }
        
        this.RemoveInstantiatedGO(go:  0.InitializationCallback, localOnly:  true);
        goto label_23;
        label_22:
        0.Dispose();
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_15 = this.photonViewList.Values.GetEnumerator();
        goto label_31;
        label_32:
        mem2[0] = val_15.host_enumerator.current.Value;
        label_31:
        if((0 & 1) == 0)
        {
            goto label_29;
        }
        
        if(0 != playerId)
        {
            goto label_31;
        }
        
        int val_16 = 0.CreatorActorNr;
        goto label_32;
        label_29:
        val_18 = 0;
        val_19 = 1;
        if((val_19 & 1) != 0)
        {
                return;
        }
        
        if(val_18 == 0)
        {
                return;
        }
    
    }
    public void DestroyAll(bool localOnly)
    {
        if(localOnly != true)
        {
                this.OpRemoveCompleteCache();
            this.SendDestroyOfAll();
        }
        
        this.LocalCleanupAnythingInstantiated(destroyInstantiatedGameObjects:  true);
    }
    protected internal void RemoveInstantiatedGO(UnityEngine.GameObject go, bool localOnly)
    {
        UnityEngine.Object val_17;
        object val_18;
        T val_19;
        int val_20;
        T val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        object val_27;
        val_17 = go;
        if(0 != val_17)
        {
            goto label_3;
        }
        
        val_18 = 0;
        goto label_6;
        label_3:
        T[] val_2 = val_17.GetComponentsInChildren<PhotonView>(includeInactive:  true);
        if((val_2 == null) || (val_2.Length <= 0))
        {
            goto label_9;
        }
        
        val_19 = val_2[0];
        if(val_19 == 0)
        {
            goto label_10;
        }
        
        val_20 = val_19.CreatorActorNr;
        goto label_11;
        label_9:
        label_52:
        label_57:
        val_17 = 0 + "Failed to \'network-remove\' GameObject because has no PhotonView components: "("Failed to \'network-remove\' GameObject because has no PhotonView components: ");
        val_18 = 0;
        label_6:
        UnityEngine.Debug.LogError(message:  val_18);
        return;
        label_10:
        val_20 = 0.CreatorActorNr;
        label_11:
        if(localOnly == true)
        {
            goto label_16;
        }
        
        if(val_19.isMine == false)
        {
            goto label_52;
        }
        
        if((val_2[0] + 108) <= 0)
        {
            goto label_18;
        }
        
        this.ServerCleanInstantiateAndDestroy(instantiateId:  val_2[0] + 108, creatorId:  val_20, isRuntimeInstantiated:  val_2[0] + 117);
        label_16:
        int val_17 = val_2.Length;
        val_17 = val_17 - 1;
        if((val_17 & 2147483648) == 0)
        {
                var val_18 = (long)val_17;
            do
        {
            val_21 = val_2[val_18];
            if(0 != val_21)
        {
                if((val_2[(long)(int)((val_2.Length - 1))][0] + 108) >= 1)
        {
                bool val_11 = this.LocalCleanPhotonView(view:  val_21);
        }
        
            if(localOnly != true)
        {
                this.OpCleanRpcBuffer(view:  val_21);
        }
        
        }
        
            val_18 = val_18 - 1;
        }
        while((val_18 & 2147483648) == 0);
        
        }
        
        val_22 = 1152921504973725696;
        val_23 = null;
        val_23 = null;
        if(PhotonNetwork.logLevel >= 2)
        {
                string val_12 = val_17.name;
            val_22 = 0 + "Network destroy Instantiated GO: "("Network destroy Instantiated GO: ");
            UnityEngine.Debug.Log(message:  0);
        }
        
        if(this.ObjectPool == null)
        {
            goto label_36;
        }
        
        val_24 = 0;
        val_25 = 0;
        goto label_39;
        label_44:
        val_24 = 0;
        val_2.viewID = 0;
        val_25 = 1;
        label_39:
        if(val_25 >= val_14.Length)
        {
            goto label_41;
        }
        
        if((Extensions.GetPhotonViewsInChildren(go:  0)[1]) != null)
        {
            goto label_44;
        }
        
        goto label_44;
        label_41:
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_24 = 1;
        val_26 = this.ObjectPool;
        goto label_49;
        label_36:
        UnityEngine.Object.Destroy(obj:  0);
        return;
        label_49:
        val_27 = ???;
        label_18:
        string val_16 = 0 + "Failed to \'network-remove\' GameObject because it is missing a valid InstantiationId on view: "("Failed to \'network-remove\' GameObject because it is missing a valid InstantiationId on view: ") + val_27;
        goto label_57;
    }
    private void ServerCleanInstantiateAndDestroy(int instantiateId, int creatorId, bool isRuntimeInstantiated)
    {
        var val_7;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        set_Item(key:  7, value:  instantiateId);
        RaiseEventOptions val_2 = new RaiseEventOptions();
        typeof(RaiseEventOptions).__il2cppRuntimeField_10 = 6;
        typeof(System.Int32[]).__il2cppRuntimeField_20 = creatorId;
        typeof(RaiseEventOptions).__il2cppRuntimeField_18 = null;
        ExitGames.Client.Photon.Hashtable val_3 = new ExitGames.Client.Photon.Hashtable();
        set_Item(key:  0, value:  instantiateId);
        val_7 = 0;
        if(isRuntimeInstantiated == true)
        {
                return;
        }
        
        RaiseEventOptions val_5 = null;
        val_7 = val_5;
        val_5 = new RaiseEventOptions();
        typeof(RaiseEventOptions).__il2cppRuntimeField_10 = 5;
        string val_6 = 0 + "Destroying GO as global. ID: "("Destroying GO as global. ID: ");
        UnityEngine.Debug.Log(message:  0);
    }
    private void SendDestroyOfPlayer(int actorNr)
    {
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        set_Item(key:  0, value:  actorNr);
    }
    private void SendDestroyOfAll()
    {
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        set_Item(key:  0, value:  0);
    }
    private void OpRemoveFromServerInstantiationsOfPlayer(int actorNr)
    {
        RaiseEventOptions val_1 = new RaiseEventOptions();
        typeof(RaiseEventOptions).__il2cppRuntimeField_10 = 6;
        typeof(System.Int32[]).__il2cppRuntimeField_20 = actorNr;
        typeof(RaiseEventOptions).__il2cppRuntimeField_18 = null;
        goto typeof(NetworkingPeer).__il2cppRuntimeField_2E0;
    }
    protected internal void RequestOwnership(int viewID, int fromOwner)
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = "RequestOwnership(): ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = viewID;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " from: ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = fromOwner;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_40 = " Time: ";
        int val_1 = System.Environment.TickCount;
        int val_5 = (long)val_1;
        val_5 = val_5 * 274877907;
        val_5 = val_5 >> 38;
        val_5 = val_5 + (val_5 >> 63);
        val_5 = val_1 - (val_5 * 1000);
        typeof(System.Object[]).__il2cppRuntimeField_48 = val_5;
        typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
        string val_3 = +0;
        UnityEngine.Debug.Log(message:  0);
        typeof(System.Int32[]).__il2cppRuntimeField_20 = viewID;
        typeof(System.Int32[]).__il2cppRuntimeField_24 = fromOwner;
        RaiseEventOptions val_4 = new RaiseEventOptions();
        typeof(RaiseEventOptions).__il2cppRuntimeField_20 = 1;
    }
    protected internal void TransferOwnership(int viewID, int playerID)
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = "TransferOwnership() view ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = viewID;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " to: ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = playerID;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_40 = " Time: ";
        int val_1 = System.Environment.TickCount;
        int val_5 = (long)val_1;
        val_5 = val_5 * 274877907;
        val_5 = val_5 >> 38;
        val_5 = val_5 + (val_5 >> 63);
        val_5 = val_1 - (val_5 * 1000);
        typeof(System.Object[]).__il2cppRuntimeField_48 = val_5;
        typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
        string val_3 = +0;
        UnityEngine.Debug.Log(message:  0);
        typeof(System.Int32[]).__il2cppRuntimeField_20 = viewID;
        typeof(System.Int32[]).__il2cppRuntimeField_24 = playerID;
        RaiseEventOptions val_4 = new RaiseEventOptions();
        typeof(RaiseEventOptions).__il2cppRuntimeField_20 = 1;
    }
    public bool LocalCleanPhotonView(PhotonView view)
    {
        System.Collections.Generic.Dictionary<System.Int32, PhotonView> val_2;
        if(view != null)
        {
                view.removedFromLocalViewList = true;
            val_2 = this.photonViewList;
        }
        else
        {
                mem[118] = 1;
            val_2 = this.photonViewList;
        }
        
        if(val_2 != null)
        {
                return val_2.Remove(key:  view.viewID);
        }
        
        return val_2.Remove(key:  view.viewID);
    }
    public PhotonView GetPhotonView(int viewID)
    {
        int val_8;
        var val_9;
        UnityEngine.Object val_10;
        val_8 = viewID;
        PhotonView val_1 = 0;
        bool val_2 = this.photonViewList.TryGetValue(key:  val_8, value: out  val_1);
        val_9 = 1152921504721543168;
        if(0 != val_1)
        {
            goto label_10;
        }
        
        System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_9 = UnityEngine.Object.FindObjectsOfType(type:  0);
        var val_8 = 0;
        label_13:
        if(val_8 >= val_5.Length)
        {
            goto label_10;
        }
        
        val_10 = val_9[0];
        val_8 = val_8 + 1;
        if(val_10.viewID != val_8)
        {
            goto label_13;
        }
        
        if(val_9[0] == null)
        {
                return (PhotonView)val_10;
        }
        
        val_8 = 0 + "Had to lookup view that wasn\'t in photonViewList: "("Had to lookup view that wasn\'t in photonViewList: ");
        UnityEngine.Debug.LogWarning(message:  0);
        return (PhotonView)val_10;
        label_10:
        val_10 = val_1;
        return (PhotonView)val_10;
    }
    public void RegisterPhotonView(PhotonView netView)
    {
        int val_15;
        UnityEngine.Object val_16;
        var val_17;
        var val_18;
        object val_19;
        System.Collections.Generic.Dictionary<System.Int32, PhotonView> val_20;
        val_16 = netView;
        if(UnityEngine.Application.isPlaying == false)
        {
            goto label_1;
        }
        
        if(val_16.viewID == 0)
        {
            goto label_3;
        }
        
        PhotonView val_5 = 0;
        if((this.photonViewList.TryGetValue(key:  val_16.viewID, value: out  val_5)) != false)
        {
                val_15 = val_5;
            if(0 == val_16)
        {
                return;
        }
        
            string val_9 = System.String.Format(format:  0, arg0:  "PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn\'t destroyed on scene load?! Check for \'DontDestroyOnLoad\'. Destroying old entry, adding new.", arg1:  val_16.viewID, arg2:  val_16);
            UnityEngine.Debug.LogError(message:  0);
            this.RemoveInstantiatedGO(go:  val_5.gameObject, localOnly:  true);
        }
        
        val_15 = val_16.viewID;
        this.photonViewList.Add(key:  val_15, value:  val_16);
        val_17 = null;
        val_17 = null;
        if(PhotonNetwork.logLevel < 2)
        {
                return;
        }
        
        val_18 = val_16.viewID;
        val_19 = "Registered PhotonView: ";
        goto label_24;
        label_1:
        System.Collections.Generic.Dictionary<System.Int32, PhotonView> val_13 = null;
        val_20 = val_13;
        val_13 = new System.Collections.Generic.Dictionary<System.Int32, PhotonView>();
        this.photonViewList = val_20;
        return;
        label_3:
        val_19 = "PhotonView register is ignored, because viewID is 0. No id assigned yet to: ";
        label_24:
        val_20 = 0 + val_19;
        UnityEngine.Debug.Log(message:  0);
    }
    public void OpCleanRpcBuffer(int actorNumber)
    {
        RaiseEventOptions val_1 = new RaiseEventOptions();
        typeof(RaiseEventOptions).__il2cppRuntimeField_10 = 6;
        typeof(System.Int32[]).__il2cppRuntimeField_20 = actorNumber;
        typeof(RaiseEventOptions).__il2cppRuntimeField_18 = null;
        goto typeof(NetworkingPeer).__il2cppRuntimeField_2E0;
    }
    public void OpRemoveCompleteCacheOfPlayer(int actorNumber)
    {
        RaiseEventOptions val_1 = new RaiseEventOptions();
        typeof(RaiseEventOptions).__il2cppRuntimeField_10 = 6;
        typeof(System.Int32[]).__il2cppRuntimeField_20 = actorNumber;
        typeof(RaiseEventOptions).__il2cppRuntimeField_18 = null;
        goto typeof(NetworkingPeer).__il2cppRuntimeField_2E0;
    }
    public void OpRemoveCompleteCache()
    {
        RaiseEventOptions val_1 = new RaiseEventOptions();
        if(null != 0)
        {
                typeof(RaiseEventOptions).__il2cppRuntimeField_10 = 6;
        }
        else
        {
                mem[16] = 6;
        }
        
        typeof(RaiseEventOptions).__il2cppRuntimeField_20 = 2;
        goto typeof(NetworkingPeer).__il2cppRuntimeField_2E0;
    }
    private void RemoveCacheOfLeftPlayers()
    {
        set_Item(key:  244, value:  0);
        set_Item(key:  247, value:  7);
        bool val_2 = this.OpCustom(customOpCode:  253, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true, channelId:  0);
    }
    public void CleanRpcBufferIfMine(PhotonView view)
    {
        PhotonPlayer val_8 = this.<LocalPlayer>k__BackingField;
        if(view.ownerId == val_8.ID)
        {
            goto label_3;
        }
        
        val_8 = this.<LocalPlayer>k__BackingField;
        if(val_8.IsMasterClient == false)
        {
            goto label_5;
        }
        
        label_3:
        this.OpCleanRpcBuffer(view:  view);
        return;
        label_5:
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Cannot remove cached RPCs on a PhotonView thats not ours! ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = view.owner;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " scene: ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = view.isSceneView;
        typeof(System.Object[]).__il2cppRuntimeField_39 = 30391044;
        string val_7 = +0;
        UnityEngine.Debug.LogError(message:  0);
    }
    public void OpCleanRpcBuffer(PhotonView view)
    {
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        set_Item(key:  0, value:  view.viewID);
        RaiseEventOptions val_3 = new RaiseEventOptions();
        typeof(RaiseEventOptions).__il2cppRuntimeField_10 = 6;
    }
    public void RemoveRPCsInGroup(int group)
    {
        var val_3;
        var val_4;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.photonViewList.Values.GetEnumerator();
        label_6:
        if((0 & 1) == 0)
        {
            goto label_3;
        }
        
        if((???) != group)
        {
            goto label_6;
        }
        
        this.CleanRpcBufferIfMine(view:  0);
        goto label_6;
        label_3:
        val_3 = 0;
        val_4 = 1;
        if((val_4 & 1) != 0)
        {
                return;
        }
        
        if(val_3 == 0)
        {
                return;
        }
    
    }
    public void SetLevelPrefix(short prefix)
    {
        this.currentLevelPrefix = prefix;
    }
    internal void RPC(PhotonView view, string methodName, PhotonTargets target, PhotonPlayer player, bool encrypt, bool reliable, object[] parameters)
    {
        bool val_37;
        PhotonPlayer val_38;
        var val_39;
        System.Collections.Generic.HashSet<System.Byte> val_40;
        var val_41;
        object val_42;
        object val_43;
        var val_44;
        val_37 = encrypt;
        val_38 = player;
        val_39 = this;
        val_40 = this.blockSendingGroups;
        if((val_40.Contains(item:  view.group)) == true)
        {
                return;
        }
        
        if(view.viewID <= 0)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = "Illegal view ID:";
            typeof(System.Object[]).__il2cppRuntimeField_28 = view.viewID;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " method: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = methodName;
            typeof(System.Object[]).__il2cppRuntimeField_40 = " GO:";
            typeof(System.Object[]).__il2cppRuntimeField_48 = view.gameObject.name;
            string val_7 = +0;
            UnityEngine.Debug.LogError(message:  0);
        }
        
        val_41 = null;
        val_41 = null;
        if(PhotonNetwork.logLevel >= 2)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = "Sending RPC \"";
            typeof(System.Object[]).__il2cppRuntimeField_28 = methodName;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "\" to target: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = target;
            typeof(System.Object[]).__il2cppRuntimeField_40 = " or player:";
            typeof(System.Object[]).__il2cppRuntimeField_48 = val_38;
            typeof(System.Object[]).__il2cppRuntimeField_50 = ".";
            string val_8 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        
        ExitGames.Client.Photon.Hashtable val_9 = null;
        val_40 = val_9;
        val_9 = new ExitGames.Client.Photon.Hashtable();
        val_37 = 1152921504607805440;
        set_Item(key:  0, value:  view.viewID);
        if(view.prefix >= 1)
        {
                set_Item(key:  1, value:  view.prefix);
        }
        
        set_Item(key:  2, value:  PhotonNetwork.ServerTimestamp);
        if((this.rpcShortcuts.TryGetValue(key:  methodName, value: out  0)) != false)
        {
                val_42 = 1152921512387705248;
            val_43 = 0;
        }
        else
        {
                val_42 = 3;
            val_43 = methodName;
        }
        
        set_Item(key:  3, value:  val_43);
        if((parameters != 0) && ((parameters + 24) >= 1))
        {
                set_Item(key:  4, value:  parameters);
        }
        
        if(val_38 == null)
        {
            goto label_79;
        }
        
        val_37 = val_37;
        if((this.<LocalPlayer>k__BackingField.ID) != val_38.ID)
        {
            goto label_81;
        }
        
        val_44 = val_38;
        goto label_82;
        label_79:
        if(target > 6)
        {
            goto label_83;
        }
        
        var val_37 = 25811976 + (target) << 2;
        val_37 = val_37 + 25811976;
        goto (25811976 + (target) << 2 + 25811976);
        label_81:
        RaiseEventOptions val_19 = new RaiseEventOptions();
        val_38 = val_38.ID;
        typeof(System.Int32[]).__il2cppRuntimeField_20 = val_38;
        if(null != 0)
        {
                typeof(RaiseEventOptions).__il2cppRuntimeField_18 = null;
        }
        else
        {
                mem[24] = null;
        }
        
        typeof(RaiseEventOptions).__il2cppRuntimeField_23 = val_37;
        bool val_22 = reliable;
        return;
        label_83:
        val_39 = 0 + "Unsupported target enum: "("Unsupported target enum: ");
        UnityEngine.Debug.LogError(message:  0);
        return;
        label_82:
        val_39.ExecuteRpc(rpcData:  val_40, senderID:  ID);
    }
    public void SetInterestGroups(byte[] disableGroups, byte[] enableGroups)
    {
        var val_10;
        var val_11;
        System.Collections.Generic.HashSet<System.Byte> val_12;
        var val_13;
        if(disableGroups == null)
        {
            goto label_15;
        }
        
        if(disableGroups.Length == 0)
        {
            goto label_2;
        }
        
        if(disableGroups.Length <= 0)
        {
            goto label_15;
        }
        
        val_10 = ". The group number should be at least 1.";
        label_14:
        val_11 = 0;
        byte val_11 = disableGroups[val_11];
        if(val_11 == 0)
        {
            goto label_5;
        }
        
        val_12 = this.allowedReceivingGroups;
        if((val_12.Contains(item:  val_11)) == false)
        {
            goto label_9;
        }
        
        val_12 = this.allowedReceivingGroups;
        bool val_2 = val_12.Remove(item:  val_11);
        goto label_9;
        label_5:
        string val_3 = 0 + "Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: "("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ") + 0;
        UnityEngine.Debug.LogError(message:  0);
        label_9:
        if((val_11 + 1) < disableGroups.Length)
        {
            goto label_14;
        }
        
        goto label_15;
        label_2:
        System.Collections.Generic.HashSet<System.Byte> val_13 = this.allowedReceivingGroups;
        val_13.Clear();
        label_15:
        if(enableGroups == null)
        {
            goto label_29;
        }
        
        if(enableGroups.Length == 0)
        {
            goto label_18;
        }
        
        if(enableGroups.Length <= 0)
        {
            goto label_29;
        }
        
        val_10 = ". The group number should be at least 1.";
        do
        {
            val_11 = 0;
            byte val_12 = enableGroups[val_11];
            if(val_12 != 0)
        {
                val_12 = this.allowedReceivingGroups;
            bool val_5 = val_12.Add(item:  val_12);
        }
        else
        {
                string val_6 = 0 + "Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: "("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ") + 0;
            UnityEngine.Debug.LogError(message:  0);
        }
        
        }
        while((val_11 + 1) < enableGroups.Length);
        
        goto label_29;
        label_18:
        val_13 = 0;
        goto label_30;
        label_32:
        bool val_8 = X23.Add(item:  val_13);
        val_13 = val_13 + 1;
        label_30:
        val_12 = this.allowedReceivingGroups;
        val_13 = val_13 & 255;
        if(val_13 != 255)
        {
            goto label_32;
        }
        
        bool val_9 = val_12.Add(item:  255);
        label_29:
        bool val_10 = this.OpChangeGroups(groupsToRemove:  disableGroups, groupsToAdd:  enableGroups);
    }
    public void SetSendingEnabled(byte group, bool enabled)
    {
        if(enabled != false)
        {
                bool val_2 = this.blockSendingGroups.Remove(item:  group);
            return;
        }
        
        bool val_3 = this.blockSendingGroups.Add(item:  group);
    }
    public void SetSendingEnabled(byte[] disableGroups, byte[] enableGroups)
    {
        byte val_3;
        System.Collections.Generic.HashSet<System.Byte> val_4;
        val_3 = disableGroups;
        if((val_3 != null) && (disableGroups.Length >= 1))
        {
                do
        {
            val_4 = this.blockSendingGroups;
            bool val_1 = val_4.Add(item:  val_3[0]);
        }
        while((0 + 1) < disableGroups.Length);
        
        }
        
        if(enableGroups == null)
        {
                return;
        }
        
        if(enableGroups.Length < 1)
        {
                return;
        }
        
        val_4 = 1152921512387873264;
        do
        {
            val_3 = enableGroups[0];
            bool val_3 = this.blockSendingGroups.Remove(item:  val_3);
        }
        while((0 + 1) < enableGroups.Length);
    
    }
    public void NewSceneLoaded()
    {
        int val_3;
        System.Collections.Generic.List<T> val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        if(this.loadingLevelAndPausedNetwork != false)
        {
                this.loadingLevelAndPausedNetwork = false;
            PhotonNetwork.isMessageQueueRunning = false;
        }
        
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        Dictionary.Enumerator<TKey, TValue> val_2 = this.photonViewList.GetEnumerator();
        label_10:
        if((0 & 1) == 0)
        {
            goto label_5;
        }
        
        UnityEngine.Playables.PlayableHandle val_5 = val_3.GetHandle();
        if(0 != val_5.m_Handle)
        {
            goto label_10;
        }
        
        Add(item:  val_5.m_Handle.GetHashCode());
        goto label_10;
        label_5:
        val_15 = 0;
        val_16 = 1;
        val_3.Dispose();
        val_17 = 0;
        if(((val_16 & 1) != 0) || (val_15 == 0))
        {
            goto label_14;
        }
        
        val_17 = 0;
        goto label_14;
        label_20:
        bool val_8 = val_16.Remove(key:  0);
        val_17 = 1;
        label_14:
        if(null == 0)
        {
            goto label_15;
        }
        
        if(val_17 < Count)
        {
            goto label_16;
        }
        
        goto label_18;
        label_15:
        if(val_17 >= Count)
        {
            goto label_18;
        }
        
        label_16:
        int val_11 = Item[1];
        if(this.photonViewList != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_18:
        val_18 = 1152921510151766592;
        if(Count < 1)
        {
                return;
        }
        
        val_17 = 1152921504973725696;
        val_19 = null;
        val_19 = null;
        if(PhotonNetwork.logLevel < 1)
        {
                return;
        }
        
        val_3 = Count;
        val_18 = 0 + "New level loaded. Removed " + val_3;
        UnityEngine.Debug.Log(message:  0);
    }
    public void RunViewUpdate()
    {
        int val_6;
        byte val_7;
        var val_53;
        var val_54;
        UnityEngine.Object val_55;
        var val_56;
        var val_57;
        System.Collections.Generic.Dictionary<System.Int32, PhotonView> val_58;
        var val_59;
        var val_60;
        var val_61;
        ExitGames.Client.Photon.Hashtable val_62;
        var val_63;
        var val_64;
        ExitGames.Client.Photon.Hashtable val_65;
        var val_66;
        val_53 = this;
        val_54 = 1152921504973725696;
        if(PhotonNetwork.connected == false)
        {
                return;
        }
        
        if(PhotonNetwork.offlineMode == true)
        {
                return;
        }
        
        if(this.mActors == null)
        {
                return;
        }
        
        if(this.mActors.Count < 2)
        {
                return;
        }
        
        this.options.Reset();
        Dictionary.Enumerator<TKey, TValue> val_5 = this.photonViewList.GetEnumerator();
        val_56 = 1152921512388528752;
        if(((-807860096) & 1) == 0)
        {
                return;
        }
        
        val_57 = 1152921512388529776;
        val_58 = 1152921504721543168;
        val_59 = 1152921512388531824;
        val_60 = 0;
        label_79:
        UnityEngine.Playables.PlayableHandle val_8 = val_6.GetHandle();
        val_55;
        if(0 != val_8.m_Handle)
        {
            goto label_14;
        }
        
        UnityEngine.Playables.PlayableHandle val_10 = val_6.GetHandle();
        val_6 = val_10.m_Handle.GetHashCode();
        string val_12 = System.String.Format(format:  0, arg0:  "PhotonView with ID {0} wasn\'t properly unregistered! Please report this case to developer@photonengine.com");
        UnityEngine.Debug.LogError(message:  0);
        if(val_60 == 0)
        {
                System.Collections.Generic.List<System.Int32> val_13 = null;
            val_60 = val_13;
            val_13 = new System.Collections.Generic.List<System.Int32>(capacity:  4);
        }
        
        UnityEngine.Playables.PlayableHandle val_14 = val_6.GetHandle();
        val_55 = val_14.m_Handle.GetHashCode();
        Add(item:  val_55);
        goto label_24;
        label_14:
        if(((???) == 0) || (val_8.m_Handle.isMine == false))
        {
            goto label_24;
        }
        
        if(val_8.m_Handle.gameObject.activeInHierarchy == false)
        {
            goto label_69;
        }
        
        if((this.blockSendingGroups.Contains(item:  val_7)) == false)
        {
            goto label_29;
        }
        
        val_58 = val_58;
        goto label_31;
        label_29:
        System.Object[] val_21 = this.OnSerializeWrite(view:  val_8.m_Handle);
        val_58 = val_58;
        if(val_21 == null)
        {
            goto label_31;
        }
        
        if((???) != 1)
        {
                if(val_7 == 0)
        {
            goto label_34;
        }
        
        }
        
        val_56 = val_56;
        val_54 = val_54;
        if((this.dataPerGroupReliable.TryGetValue(key:  val_7, value: out  0)) != true)
        {
                val_61 = null;
            val_61 = null;
            ExitGames.Client.Photon.Hashtable val_25 = null;
            val_62 = val_25;
            val_25 = new ExitGames.Client.Photon.Hashtable(x:  NetworkingPeer.ObjectsInOneUpdate);
            if(val_8.m_Handle == 0)
        {
                val_62 = val_62;
        }
        
            this.dataPerGroupReliable.set_Item(key:  val_7, value:  val_62);
        }
        
        val_6 = Count + 10;
        val_59 = 1152921512388531824;
        Add(key:  val_6, value:  val_21);
        val_63 = null;
        val_58 = 1152921504721543168;
        val_63 = null;
        if(Count < NetworkingPeer.ObjectsInOneUpdate)
        {
            goto label_69;
        }
        
        this.options.InterestGroup = val_7;
        val_6 = PhotonNetwork.ServerTimestamp;
        set_Item(key:  0, value:  val_6);
        if((this.currentLevelPrefix & 2147483648) == 0)
        {
                val_6 = this.currentLevelPrefix;
            set_Item(key:  1, value:  val_6);
        }
        
        int val_53 = 1;
        val_53 = val_53 - Count;
        val_55 = val_62;
        if(null != 0)
        {
            goto label_78;
        }
        
        goto label_56;
        label_31:
        val_56 = val_56;
        val_54 = val_54;
        val_59 = 1152921512388531824;
        goto label_69;
        label_34:
        val_56 = val_56;
        val_54 = val_54;
        if((this.dataPerGroupUnreliable.TryGetValue(key:  val_7, value: out  0)) != true)
        {
                val_64 = null;
            val_64 = null;
            ExitGames.Client.Photon.Hashtable val_34 = null;
            val_65 = val_34;
            val_34 = new ExitGames.Client.Photon.Hashtable(x:  NetworkingPeer.ObjectsInOneUpdate);
            if(val_8.m_Handle == 0)
        {
                val_65 = val_65;
        }
        
            this.dataPerGroupUnreliable.set_Item(key:  val_7, value:  val_65);
        }
        
        val_6 = Count + 10;
        val_59 = 1152921512388531824;
        Add(key:  val_6, value:  val_21);
        int val_54 = val_53;
        val_54 = val_54 + 1;
        val_66 = null;
        val_58 = 1152921504721543168;
        val_66 = null;
        if(Count < NetworkingPeer.ObjectsInOneUpdate)
        {
            goto label_69;
        }
        
        this.options.InterestGroup = val_7;
        val_6 = PhotonNetwork.ServerTimestamp;
        set_Item(key:  0, value:  val_6);
        if((this.currentLevelPrefix & 2147483648) == 0)
        {
                val_6 = this.currentLevelPrefix;
            set_Item(key:  1, value:  val_6);
        }
        
        int val_55 = val_54;
        val_55 = val_55 - Count;
        val_55 = val_65;
        if(null != 0)
        {
            goto label_78;
        }
        
        label_56:
        label_78:
        Clear();
        val_58 = 1152921504721543168;
        label_69:
        label_24:
        if((0 & 1) != 0)
        {
            goto label_79;
        }
        
        if(val_60 != 0)
        {
                val_55 = val_60.Count;
            if(val_55 >= 1)
        {
                val_59 = 1152921510151767616;
            val_57 = 1152921512385869536;
            var val_56 = 0;
            do
        {
            val_58 = this.photonViewList;
            bool val_42 = val_58.Remove(key:  val_60.Item[0]);
            val_56 = val_56 + 1;
        }
        while(val_55 != val_56);
        
        }
        
        }
        
        if(val_55 == 0)
        {
                return;
        }
        
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_44 = this.dataPerGroupReliable.Keys.GetEnumerator();
        do
        {
            label_98:
            if((0 & 1) == 0)
        {
            goto label_116;
        }
        
            this.options.InterestGroup = ;
            ExitGames.Client.Photon.Hashtable val_45 = this.dataPerGroupReliable.Item[-807860192];
        }
        while(val_45.Count == 0);
        
        val_45.set_Item(key:  0, value:  PhotonNetwork.ServerTimestamp);
        if((this.currentLevelPrefix & 2147483648) == 0)
        {
                val_45.set_Item(key:  1, value:  this.currentLevelPrefix);
        }
        
        val_45.Clear();
        goto label_98;
        label_116:
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_49 = this.dataPerGroupUnreliable.Keys.GetEnumerator();
        do
        {
            label_113:
            if((0 & 1) == 0)
        {
            goto label_117;
        }
        
            this.options.InterestGroup = ;
            ExitGames.Client.Photon.Hashtable val_50 = this.dataPerGroupUnreliable.Item[-807860224];
        }
        while(val_50.Count == 0);
        
        val_50.set_Item(key:  0, value:  PhotonNetwork.ServerTimestamp);
        if((this.currentLevelPrefix & 2147483648) == 0)
        {
                val_50.set_Item(key:  1, value:  this.currentLevelPrefix);
        }
        
        val_50.Clear();
        goto label_113;
        label_117:
        if((0 & 1) != 0)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
    
    }
    private object[] OnSerializeWrite(PhotonView view)
    {
        System.Object[] val_8;
        int val_9;
        if(view.synchronization == 0)
        {
            goto label_28;
        }
        
        int val_1 = PhotonNetwork.ServerTimestamp;
        this.pStream.ResetWriteStream();
        this.pStream.SendNext(obj:  0);
        this.pStream.SendNext(obj:  0);
        this.pStream.SendNext(obj:  0);
        view.SerializeView(stream:  this.pStream, info:  new PhotonMessageInfo());
        val_8 = 0;
        if(this.pStream.Count < 4)
        {
                return (System.Object[])val_8;
        }
        
        val_8 = this.pStream.ToArray();
        val_8[0] = view.viewID;
        val_9 = val_3.Length;
        if(val_9 <= 1)
        {
                val_9 = val_3.Length;
        }
        
        val_8[1] = null;
        val_8[2] = 0;
        if(view.synchronization == 2)
        {
                return (System.Object[])val_8;
        }
        
        if(view.synchronization != 3)
        {
            goto label_24;
        }
        
        if((this.AlmostEquals(lastData:  val_8, currentContent:  view.lastOnSerializeDataSent)) == false)
        {
            goto label_25;
        }
        
        if(view.mixedModeIsReliable == true)
        {
            goto label_28;
        }
        
        view.mixedModeIsReliable = true;
        view.lastOnSerializeDataSent = val_8;
        return (System.Object[])val_8;
        label_24:
        if(view.synchronization == 1)
        {
                view.lastOnSerializeDataSent = val_8;
            val_8 = this.DeltaCompressionWrite(previousContent:  view.lastOnSerializeDataSent, currentContent:  val_8);
            return (System.Object[])val_8;
        }
        
        label_28:
        val_8 = 0;
        return (System.Object[])val_8;
        label_25:
        view.mixedModeIsReliable = false;
        view.lastOnSerializeDataSent = val_8;
        return (System.Object[])val_8;
    }
    private void OnSerializeRead(object[] data, PhotonPlayer sender, int networkTime, short correctPrefix)
    {
        System.Object[] val_17;
        System.Collections.Generic.HashSet<System.Byte> val_18;
        UnityEngine.Object val_19;
        byte val_20;
        var val_21;
        val_17 = data;
        object val_17 = val_17[0];
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_19 = this.GetPhotonView(viewID:  53248);
        if(0 == val_19)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = "Received OnSerialization for view ID ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = null;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            val_20 = ". We have no such PhotonView! Ignored this if you\'re leaving a room. State: ";
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_20;
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.<State>k__BackingField;
            val_19 = +0;
            UnityEngine.Debug.LogWarning(message:  0);
            return;
        }
        
        if(val_19.prefix >= 1)
        {
                if(((int)correctPrefix & 65535) != val_19.prefix)
        {
            goto label_29;
        }
        
        }
        
        val_20 = val_2.group;
        if(val_20 != 0)
        {
                val_18 = this.allowedReceivingGroups;
            bool val_7 = val_18.Contains(item:  val_20);
            if(val_7 == false)
        {
                return;
        }
        
        }
        
        if(val_2.synchronization != 1)
        {
            goto label_35;
        }
        
        val_17 = val_7.DeltaCompressionRead(lastOnSerializeDataReceived:  val_2.lastOnSerializeDataReceived, incomingData:  val_17);
        if(val_17 == null)
        {
            goto label_36;
        }
        
        val_2.lastOnSerializeDataReceived = val_17;
        label_35:
        if(sender.ID != val_2.ownerId)
        {
                if((val_2.ownerId & 71776119061217280) != 0)
        {
                if(val_2.ownerId != 0)
        {
            goto label_41;
        }
        
        }
        
            if(val_2.currentMasterID == 1)
        {
                val_2.ownerId = sender.ID;
        }
        
        }
        
        label_41:
        val_20 = this.readStream;
        val_20.SetReadStream(incomingData:  val_17, pos:  3);
        val_19.DeserializeView(stream:  this.readStream, info:  new PhotonMessageInfo());
        return;
        label_29:
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Received OnSerialization for view ID ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = null;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " with prefix ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = correctPrefix;
        typeof(System.Object[]).__il2cppRuntimeField_3A = 118763;
        val_20 = ". Our prefix is ";
        typeof(System.Object[]).__il2cppRuntimeField_40 = val_20;
        typeof(System.Object[]).__il2cppRuntimeField_48 = val_19.prefix;
        typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
        val_19 = +0;
        UnityEngine.Debug.LogError(message:  0);
        return;
        label_36:
        val_21 = null;
        val_21 = null;
        if(PhotonNetwork.logLevel < 1)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Skipping packet for ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_19.name;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " [";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_19.viewID;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_40 = "] as we haven\'t received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.";
        string val_16 = +0;
        UnityEngine.Debug.Log(message:  0);
    }
    private object[] DeltaCompressionWrite(object[] previousContent, object[] currentContent)
    {
        var val_4;
        object val_5;
        int val_6;
        var val_7;
        var val_8;
        if(((previousContent == null) || (currentContent == null)) || (previousContent.Length != currentContent.Length))
        {
            goto label_3;
        }
        
        if(previousContent.Length < 4)
        {
            goto label_4;
        }
        
        val_5 = null;
        if( != false)
        {
                val_5 = val_5;
        }
        
        previousContent[1] = val_5;
        val_6 = currentContent.Length;
        val_4 = 0;
        val_7 = 0;
        if(val_6 >= 4)
        {
                do
        {
            object val_5 = currentContent[3];
            if((AlmostEquals(one:  val_5, two:  previousContent[3])) != false)
        {
                val_7 = val_7 + 1;
            mem2[0] = 0;
        }
        else
        {
                mem2[0] = val_5;
            if(val_5 == null)
        {
                if(val_4 == 0)
        {
                System.Collections.Generic.Queue<System.Int32> val_2 = null;
            val_4 = val_2;
            val_2 = new System.Collections.Generic.Queue<System.Int32>(count:  currentContent.Length);
            if(null == 0)
        {
                val_4 = 0;
        }
        
        }
        
            val_4.Enqueue(item:  3);
        }
        
        }
        
            val_6 = currentContent.Length;
        }
        while((3 + 1) < val_6);
        
        }
        
        if(val_7 < 1)
        {
            goto label_27;
        }
        
        val_6 = val_6 - 3;
        if(val_7 != val_6)
        {
            goto label_22;
        }
        
        label_4:
        val_8 = 0;
        return (System.Object[])val_8;
        label_3:
        val_8 = currentContent;
        return (System.Object[])val_8;
        label_22:
        previousContent[1] = true;
        if(val_4 != 0)
        {
                previousContent[2] = val_4.ToArray();
        }
        
        label_27:
        previousContent[0] = currentContent[0];
        return (System.Object[])val_8;
    }
    private object[] DeltaCompressionRead(object[] lastOnSerializeDataReceived, object[] incomingData)
    {
        var val_5;
        int val_6;
        var val_7;
        val_5 = incomingData;
        object val_5 = val_5[1];
        val_6 = null;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        if(null == null)
        {
                return (System.Object[])val_5;
        }
        
        if(lastOnSerializeDataReceived == null)
        {
            goto label_6;
        }
        
        val_6 = val_5[2];
        val_7 = 3;
        goto label_8;
        label_22:
        val_7 = 4;
        label_8:
        if(val_7 >= incomingData.Length)
        {
                return (System.Object[])val_5;
        }
        
        if(val_6 != null)
        {
                if((Extensions.Contains(target:  0, nr:  val_6)) == true)
        {
            goto label_22;
        }
        
        }
        
        if(val_5[4] != null)
        {
            goto label_22;
        }
        
        mem2[0] = lastOnSerializeDataReceived[4];
        goto label_22;
        label_6:
        val_5 = 0;
        return (System.Object[])val_5;
    }
    private bool AlmostEquals(object[] lastData, object[] currentContent)
    {
        var val_4;
        var val_2 = ((lastData | currentContent) == null) ? 1 : 0;
        if(lastData == null)
        {
                return (bool)val_4;
        }
        
        if(currentContent == null)
        {
                return (bool)val_4;
        }
        
        val_4 = 0;
        if(lastData.Length != currentContent.Length)
        {
                return (bool)val_4;
        }
        
        var val_6 = 0;
        label_6:
        if(val_6 >= currentContent.Length)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        if((this.AlmostEquals(one:  currentContent[0], two:  lastData[0])) == true)
        {
            goto label_6;
        }
        
        val_4 = 0;
        return (bool)val_4;
        label_3:
        val_4 = 1;
        return (bool)val_4;
    }
    private bool AlmostEquals(object one, object two)
    {
        var val_21;
        var val_22;
        float val_24;
        float val_25;
        var val_26;
        float val_27;
        float val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        float val_33;
        var val_34;
        val_22 = two;
        if((val_22 == null) || (one == null))
        {
            goto label_2;
        }
        
        if(((one & 1) & 1) != 0)
        {
            goto label_4;
        }
        
        if(one == null)
        {
            goto label_6;
        }
        
        val_21 = 1152921504719785984;
        if(null != null)
        {
            goto label_6;
        }
        
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
        val_22 = 1152921504973725696;
        val_26 = null;
        val_26 = null;
        val_28 = PhotonNetwork.precisionForVectorSynchronization;
        val_29 = 0;
        bool val_4 = Extensions.AlmostEquals(target:  new UnityEngine.Vector3() {x = 7.461634E-41f, y = V9.16B, z = V10.16B}, second:  new UnityEngine.Vector3() {x = 7.461634E-41f, y = V12.16B, z = V11.16B}, sqrMagnitudePrecision:  val_28);
        goto label_29;
        label_2:
        var val_6 = ((val_22 | one) == 0) ? 1 : 0;
        return (bool)val_30;
        label_6:
        if(one == null)
        {
            goto label_15;
        }
        
        val_21 = 1152921504730062848;
        if(null != null)
        {
            goto label_15;
        }
        
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y});
        val_22 = 1152921504973725696;
        val_31 = null;
        val_31 = null;
        val_27 = PhotonNetwork.precisionForVectorSynchronization;
        val_29 = 0;
        bool val_9 = Extensions.AlmostEquals(target:  new UnityEngine.Vector2() {x = 7.461634E-41f, y = V9.16B}, second:  new UnityEngine.Vector2() {x = 7.461634E-41f, y = V10.16B}, sqrMagnitudePrecision:  val_27);
        goto label_29;
        label_15:
        if(one == null)
        {
            goto label_23;
        }
        
        val_21 = 1152921504719839232;
        if(null != null)
        {
            goto label_23;
        }
        
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y});
        val_22 = 1152921504973725696;
        val_32 = null;
        val_32 = null;
        val_33 = V7.16B;
        val_24 = PhotonNetwork.precisionForQuaternionSynchronization;
        val_29 = 0;
        bool val_12 = Extensions.AlmostEquals(target:  new UnityEngine.Quaternion() {x = 7.461634E-41f, y = V10.16B, z = V11.16B, w = V12.16B}, second:  new UnityEngine.Quaternion() {x = 7.461634E-41f, y = V14.16B, z = V13.16B, w = val_33}, maxAngle:  val_24);
        goto label_29;
        label_23:
        if(one == null)
        {
            goto label_37;
        }
        
        val_21 = 1152921504608444416;
        if(null != null)
        {
            goto label_37;
        }
        
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y});
        val_22 = 1152921504973725696;
        val_34 = null;
        val_34 = null;
        val_25 = PhotonNetwork.precisionForFloatSynchronization;
        val_29 = 0;
        label_29:
        if((Extensions.AlmostEquals(target:  7.461634E-41f, second:  7.461634E-41f, floatDiff:  val_25)) == false)
        {
            goto label_37;
        }
        
        label_4:
        val_30 = 1;
        return (bool)val_30;
        label_37:
        val_30 = 0;
        return (bool)val_30;
    }
    protected internal static bool GetMethod(UnityEngine.MonoBehaviour monob, string methodType, out System.Reflection.MethodInfo mi)
    {
        UnityEngine.Object val_10;
        var val_11;
        val_10 = methodType;
        mem2[0] = 0;
        if((0 == val_10) || ((System.String.IsNullOrEmpty(value:  0)) == true))
        {
            goto label_11;
        }
        
        val_10 = ExitGames.Client.Photon.SupportClass.GetMethods(type:  0, attribute:  val_10.GetType());
        var val_10 = 0;
        label_15:
        if(val_10 >= val_10.Count)
        {
            goto label_11;
        }
        
        System.Reflection.MethodInfo val_8 = val_10.Item[0];
        val_10 = val_10 + 1;
        if((val_8.Equals(value:  mi)) == false)
        {
            goto label_15;
        }
        
        mem2[0] = val_8;
        val_11 = 1;
        return (bool)val_11;
        label_11:
        val_11 = 0;
        return (bool)val_11;
    }
    protected internal void LoadLevelIfSynced()
    {
        var val_33;
        string val_34;
        var val_35;
        var val_36;
        val_33 = this;
        if(PhotonNetwork.automaticallySyncScene == false)
        {
                return;
        }
        
        if(PhotonNetwork.isMasterClient == true)
        {
                return;
        }
        
        if(PhotonNetwork.room == null)
        {
                return;
        }
        
        if(this._AsyncLevelLoadingOperation != null)
        {
                if(this._AsyncLevelLoadingOperation.isDone == false)
        {
                return;
        }
        
            this._AsyncLevelLoadingOperation = 0;
        }
        
        val_33 = PhotonNetwork.room.CustomProperties;
        val_34 = "curScn";
        if((val_33.ContainsKey(key:  "curScn")) == false)
        {
                return;
        }
        
        bool val_11 = PhotonNetwork.room.CustomProperties.ContainsKey(key:  "curScnLa");
        val_33 = PhotonNetwork.room.CustomProperties.Item["curScn"];
        if(val_33 == null)
        {
                return;
        }
        
        val_35 = 1152921504607113216;
        if(null == null)
        {
            goto label_24;
        }
        
        val_35 = 1152921504608284672;
        if(null != null)
        {
                return;
        }
        
        val_36 = null;
        val_34 = SceneManagerHelper.ActiveSceneName;
        val_36 = null;
        if((System.String.op_Inequality(a:  0, b:  val_34)) == false)
        {
                return;
        }
        
        if(val_11 == false)
        {
            goto label_30;
        }
        
        if(null != null)
        {
                val_33 = 0;
        }
        
        UnityEngine.AsyncOperation val_21 = PhotonNetwork.LoadLevelAsync(levelName:  0);
        return;
        label_24:
        val_34 = SceneManagerHelper.ActiveSceneBuildIndex;
        UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        if(val_34 == null)
        {
                return;
        }
        
        if(val_11 != false)
        {
                UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y});
            UnityEngine.AsyncOperation val_27 = PhotonNetwork.LoadLevelAsync(levelNumber:  0);
            return;
        }
        
        UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y});
        PhotonNetwork.LoadLevel(levelNumber:  0);
        return;
        label_30:
        if(null != null)
        {
                val_33 = 0;
        }
        
        PhotonNetwork.LoadLevel(levelName:  0);
        return;
        label_51:
        goto label_51;
    }
    protected internal void SetLevelInPropsIfSynced(object levelId, bool asyncLoading = False)
    {
        object val_24;
        string val_25;
        object val_27;
        object val_28;
        val_24 = levelId;
        if(PhotonNetwork.automaticallySyncScene == false)
        {
                return;
        }
        
        if(PhotonNetwork.isMasterClient == false)
        {
                return;
        }
        
        if(PhotonNetwork.room == null)
        {
                return;
        }
        
        if(val_24 == null)
        {
            goto label_10;
        }
        
        if((asyncLoading != true) && ((PhotonNetwork.room.CustomProperties.ContainsKey(key:  "curScn")) != false))
        {
                val_25 = PhotonNetwork.room.CustomProperties.Item["curScn"];
            if(val_25 != null)
        {
                if(null == null)
        {
                val_27 = SceneManagerHelper.ActiveSceneBuildIndex;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            if(val_27 == null)
        {
                return;
        }
        
        }
        
            if((null == null) && (SceneManagerHelper.ActiveSceneName != null))
        {
                val_27 = SceneManagerHelper.ActiveSceneName;
            if(null != null)
        {
                val_25 = 0;
        }
        
            if((val_27.Equals(value:  val_25)) == true)
        {
                return;
        }
        
        }
        
        }
        
        }
        
        val_27 = 1152921504607113216;
        if(null == null)
        {
            goto label_30;
        }
        
        val_27 = 1152921504608284672;
        if(null == null)
        {
            goto label_31;
        }
        
        UnityEngine.Debug.LogError(message:  0);
        goto label_34;
        label_10:
        UnityEngine.Debug.LogError(message:  0);
        return;
        label_30:
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y});
        val_24 = null;
        val_28 = "curScn";
        goto label_38;
        label_31:
        if(null != 0)
        {
                val_27 = "curScn";
        }
        else
        {
                val_27 = "curScn";
            if(null != null)
        {
                val_24 = 0;
        }
        
        }
        
        val_28 = val_27;
        label_38:
        set_Item(key:  val_28, value:  val_24);
        label_34:
        if(asyncLoading != false)
        {
                set_Item(key:  "curScnLa", value:  true);
        }
        
        PhotonNetwork.room.SetCustomProperties(propertiesToSet:  new ExitGames.Client.Photon.Hashtable(), expectedValues:  0, webForward:  false);
        bool val_22 = this.SendOutgoingCommands();
        return;
        label_48:
        goto label_48;
    }
    public void SetApp(string appId, string gameVersion)
    {
        this.AppId = appId.Trim();
        if((System.String.IsNullOrEmpty(value:  0)) != false)
        {
                return;
        }
        
        string val_4 = gameVersion.Trim();
        PhotonNetwork.gameVersion = 0;
    }
    public bool WebRpc(string uriPath, object parameters)
    {
        if(null != 0)
        {
                Add(key:  209, value:  uriPath);
        }
        else
        {
                Add(key:  209, value:  uriPath);
        }
        
        Add(key:  208, value:  parameters);
        return this.OpCustom(customOpCode:  219, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
    }
    private static NetworkingPeer()
    {
        if(null != 0)
        {
                Add(key:  0, value:  194);
            Add(key:  1, value:  181);
            Add(key:  4, value:  133);
        }
        else
        {
                Add(key:  0, value:  194);
            Add(key:  1, value:  181);
            Add(key:  4, value:  133);
        }
        
        Add(key:  5, value:  149);
        NetworkingPeer.SyncFirstValue = new System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, System.Int32>();
        NetworkingPeer.SyncFirstValue.__il2cppRuntimeField_3 = 268435456;
        NetworkingPeer.UsePrefabCache = true;
        NetworkingPeer.PrefabCache = new System.Collections.Generic.Dictionary<System.String, UnityEngine.GameObject>();
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        NetworkingPeer.OnPhotonInstantiateString = 18.ToString();
        NetworkingPeer.ObjectsInOneUpdate = 10;
    }

}
