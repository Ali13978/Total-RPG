using UnityEngine;
public static class PhotonNetwork
{
    // Fields
    public const string versionPUN = "1.90";
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static string <gameVersion>k__BackingField;
    internal static readonly PhotonHandler photonMono;
    internal static NetworkingPeer networkingPeer;
    public static readonly int MAX_VIEW_IDS;
    internal const string serverSettingsAssetFile = "PhotonServerSettings";
    public static ServerSettings PhotonServerSettings;
    public static bool InstantiateInRoomOnly;
    public static PhotonLogLevel logLevel;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Collections.Generic.List<FriendInfo> <Friends>k__BackingField;
    public static float precisionForVectorSynchronization;
    public static float precisionForQuaternionSynchronization;
    public static float precisionForFloatSynchronization;
    public static bool UseRpcMonoBehaviourCache;
    public static bool UsePrefabCache;
    public static System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> PrefabCache;
    public static System.Collections.Generic.HashSet<UnityEngine.GameObject> SendMonoMessageTargets;
    public static System.Type SendMonoMessageTargetType;
    public static bool StartRpcsAsCoroutine;
    private static bool isOfflineMode;
    private static Room offlineModeRoom;
    [System.ObsoleteAttribute]
    public static int maxConnections;
    private static bool _mAutomaticallySyncScene;
    private static bool m_autoCleanUpPlayerObjects;
    private static int sendInterval;
    private static int sendIntervalOnSerialize;
    private static bool m_isMessageQueueRunning;
    private static bool UsePreciseTimer;
    private static System.Diagnostics.Stopwatch startupStopwatch;
    public static float BackgroundTimeout;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static bool <UseAlternativeUdpPorts>k__BackingField;
    public static PhotonNetwork.EventCallback OnEventCall;
    internal static int lastUsedViewSubId;
    internal static int lastUsedViewSubIdStatic;
    internal static System.Collections.Generic.List<int> manuallyAllocatedViewIds;
    
    // Properties
    public static string gameVersion { get; set; }
    public static string ServerAddress { get; }
    public static CloudRegionCode CloudRegion { get; }
    public static bool connected { get; }
    public static bool connecting { get; }
    public static bool connectedAndReady { get; }
    public static ConnectionState connectionState { get; }
    public static ClientState connectionStateDetailed { get; }
    public static ServerConnection Server { get; }
    public static AuthenticationValues AuthValues { get; set; }
    public static Room room { get; }
    public static PhotonPlayer player { get; }
    public static PhotonPlayer masterClient { get; }
    public static string playerName { get; set; }
    public static PhotonPlayer[] playerList { get; }
    public static PhotonPlayer[] otherPlayers { get; }
    public static System.Collections.Generic.List<FriendInfo> Friends { get; set; }
    public static int FriendsListAge { get; }
    public static IPunPrefabPool PrefabPool { get; set; }
    public static bool offlineMode { get; set; }
    public static bool automaticallySyncScene { get; set; }
    public static bool autoCleanUpPlayerObjects { get; set; }
    public static bool autoJoinLobby { get; set; }
    public static bool EnableLobbyStatistics { get; set; }
    public static System.Collections.Generic.List<TypedLobbyInfo> LobbyStatistics { get; set; }
    public static bool insideLobby { get; }
    public static TypedLobby lobby { get; set; }
    public static int sendRate { get; set; }
    public static int sendRateOnSerialize { get; set; }
    public static bool isMessageQueueRunning { get; set; }
    public static int unreliableCommandsLimit { get; set; }
    public static double time { get; }
    public static int ServerTimestamp { get; }
    public static bool isMasterClient { get; }
    public static bool inRoom { get; }
    public static bool isNonMasterClientInRoom { get; }
    public static int countOfPlayersOnMaster { get; }
    public static int countOfPlayersInRooms { get; }
    public static int countOfPlayers { get; }
    public static int countOfRooms { get; }
    public static bool NetworkStatisticsEnabled { get; set; }
    public static int ResentReliableCommands { get; }
    public static bool CrcCheckEnabled { get; set; }
    public static int PacketLossByCrcCheck { get; }
    public static int MaxResendsBeforeDisconnect { get; set; }
    public static int QuickResends { get; set; }
    public static bool UseAlternativeUdpPorts { get; set; }
    
    // Methods
    private static PhotonNetwork()
    {
        ServerSettings val_15;
        var val_16;
        var val_17;
        NetworkingPeer val_18;
        NetworkingPeer val_19;
        PhotonNetwork.MAX_VIEW_IDS = 1000;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  0, systemTypeInstance:  "PhotonServerSettings");
        val_15 = 0;
        if(val_2 != null)
        {
                val_15 = val_2;
            val_15 = 0;
        }
        
        PhotonNetwork.PhotonServerSettings = val_15;
        PhotonNetwork.InstantiateInRoomOnly = true;
        PhotonNetwork.logLevel = 0;
        PhotonNetwork.precisionForVectorSynchronization = 9.9E-05f;
        PhotonNetwork.precisionForQuaternionSynchronization = 1f;
        PhotonNetwork.precisionForFloatSynchronization = 0.01f;
        PhotonNetwork.UsePrefabCache = true;
        PhotonNetwork.PrefabCache = new System.Collections.Generic.Dictionary<System.String, UnityEngine.GameObject>();
        PhotonNetwork.SendMonoMessageTargetType = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        PhotonNetwork.StartRpcsAsCoroutine = true;
        PhotonNetwork.isOfflineMode = false;
        PhotonNetwork.offlineModeRoom = 0;
        PhotonNetwork._mAutomaticallySyncScene = false;
        PhotonNetwork.m_autoCleanUpPlayerObjects = true;
        PhotonNetwork.sendInterval = 50;
        PhotonNetwork.sendIntervalOnSerialize = 100;
        PhotonNetwork.m_isMessageQueueRunning = true;
        PhotonNetwork.UsePreciseTimer = false;
        PhotonNetwork.BackgroundTimeout = 60f;
        PhotonNetwork.lastUsedViewSubId = 0;
        PhotonNetwork.lastUsedViewSubIdStatic = 0;
        PhotonNetwork.manuallyAllocatedViewIds = new System.Collections.Generic.List<System.Int32>();
        if(0 != PhotonNetwork.PhotonServerSettings)
        {
                UnityEngine.Application.runInBackground = false;
        }
        
        UnityEngine.GameObject val_9 = null;
        val_16 = val_9;
        val_9 = new UnityEngine.GameObject();
        if(null != 0)
        {
                PhotonNetwork.photonMono = AddComponent<PhotonHandler>();
            name = "PhotonMono";
        }
        else
        {
                PhotonNetwork.photonMono = AddComponent<PhotonHandler>();
            0.name = "PhotonMono";
            val_16 = 0;
        }
        
        val_16.hideFlags = 1;
        val_17 = null;
        val_17 = null;
        NetworkingPeer val_12 = null;
        val_18 = val_12;
        val_12 = new NetworkingPeer(playername:  System.String.Empty, connectionProtocol:  26);
        PhotonNetwork.networkingPeer = val_18;
        QuickResendAttempts = 2;
        val_19 = PhotonNetwork.networkingPeer;
        typeof(NetworkingPeer).__il2cppRuntimeField_88 = 7;
        if(PhotonNetwork.UsePreciseTimer != false)
        {
                UnityEngine.Debug.Log(message:  0);
            PhotonNetwork.startupStopwatch = new System.Diagnostics.Stopwatch();
            Start();
            val_19 = PhotonNetwork.networkingPeer;
            val_18 = static System.Int32 PhotonNetwork::<PhotonNetwork>m__0();
            LocalMsTimestampDelegate = new SupportClass.IntegerMillisecondsDelegate(object:  0, method:  val_18);
        }
        
        CustomTypes.Register();
    }
    public static string get_gameVersion()
    {
        null = null;
        return (string)PhotonNetwork.serverSettingsAssetFile;
    }
    public static void set_gameVersion(string value)
    {
        null = null;
        PhotonNetwork.serverSettingsAssetFile = X1;
    }
    public static string get_ServerAddress()
    {
        var val_1;
        NetworkingPeer val_2;
        val_1 = null;
        val_1 = null;
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 == null)
        {
                return "<not connected>";
        }
        
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 != null)
        {
                return val_2.ServerAddress;
        }
        
        val_2 = 0;
        return val_2.ServerAddress;
    }
    public static CloudRegionCode get_CloudRegion()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(PhotonNetwork.networkingPeer == null)
        {
                return 4;
        }
        
        if(PhotonNetwork.connected == false)
        {
                return 4;
        }
        
        if(PhotonNetwork.Server == 2)
        {
                return 4;
        }
        
        val_4 = null;
        val_4 = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.CloudRegion;
        }
        
        return PhotonNetwork.networkingPeer.CloudRegion;
    }
    public static bool get_connected()
    {
        NetworkingPeer val_8;
        var val_9;
        var val_10;
        NetworkingPeer val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        if(PhotonNetwork.offlineMode != false)
        {
                val_9 = 1;
            return (bool)val_9;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = PhotonNetwork.networkingPeer;
        if(val_11 == null)
        {
            goto label_19;
        }
        
        val_11 = PhotonNetwork.networkingPeer;
        if(val_11 == null)
        {
            goto label_10;
        }
        
        if(PhotonNetwork.networkingPeer.IsInitialConnect == true)
        {
            goto label_19;
        }
        
        val_12 = null;
        val_12 = null;
        val_8 = PhotonNetwork.networkingPeer;
        if(val_8.State == 1)
        {
            goto label_19;
        }
        
        val_13 = null;
        val_13 = null;
        val_8 = PhotonNetwork.networkingPeer;
        if(val_8.State == 15)
        {
            goto label_19;
        }
        
        val_14 = null;
        val_14 = null;
        val_8 = PhotonNetwork.networkingPeer;
        if(val_8.State != 14)
        {
            goto label_23;
        }
        
        label_19:
        val_9 = 0;
        return (bool)val_9;
        label_23:
        val_15 = null;
        val_15 = null;
        var val_7 = (PhotonNetwork.networkingPeer.State != 17) ? 1 : 0;
        return (bool)val_9;
        label_10:
    }
    public static bool get_connecting()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(PhotonNetwork.networkingPeer.IsInitialConnect != false)
        {
                val_4 = PhotonNetwork.offlineMode ^ 1;
            return (bool)val_4 & 1;
        }
        
        val_4 = 0;
        return (bool)val_4 & 1;
    }
    public static bool get_connectedAndReady()
    {
        var val_8;
        var val_9;
        if(PhotonNetwork.connected == false)
        {
            goto label_3;
        }
        
        if(PhotonNetwork.offlineMode == false)
        {
            goto label_6;
        }
        
        val_8 = 1;
        goto label_16;
        label_3:
        val_8 = 0;
        label_16:
        val_9 = val_8;
        return (bool)(val_4 != 1) ? 1 : 0;
        label_6:
        ClientState val_4 = PhotonNetwork.connectionStateDetailed;
        if(((val_4 - 12) <= 8) && ((25819296 + ((val_4 - 12)) << 2) != 12))
        {
                if((25819296 + ((val_4 - 12)) << 2) != 0)
        {
            goto label_16;
        }
        
        }
        
        if(((val_4 - 6) > 2) || ((25819332 + ((val_4 - 6)) << 2) == 14))
        {
                return (bool)(val_4 != 1) ? 1 : 0;
        }
        
        if((25819332 + ((val_4 - 6)) << 2) != 0)
        {
            goto label_16;
        }
        
        return (bool)(val_4 != 1) ? 1 : 0;
    }
    public static ConnectionState get_connectionState()
    {
        var val_9;
        NetworkingPeer val_10;
        var val_11;
        var val_12;
        if(PhotonNetwork.offlineMode == true)
        {
            goto label_3;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = PhotonNetwork.networkingPeer;
        if(val_10 == null)
        {
            goto label_6;
        }
        
        val_10 = PhotonNetwork.networkingPeer;
        if(val_10 == null)
        {
                val_10 = 0;
        }
        
        ExitGames.Client.Photon.PeerStateValue val_3 = val_10.PeerState;
        ExitGames.Client.Photon.PeerStateValue val_4 = val_3 & 255;
        var val_6 = (val_4 < 5) ? (val_4 + 11) : 0;
        val_4 = val_6 - 12;
        if(val_4 > 3)
        {
            goto label_10;
        }
        
        var val_9 = 25819000 + ((val_4 < 0x5 ? ((val_3 & 255) + 11) : 0 - 12)) << 2;
        val_9 = val_9 + 25819000;
        goto (25819000 + ((val_4 < 0x5 ? ((val_3 & 255) + 11) : 0 - 12)) << 2 + 25819000);
        label_3:
        val_11 = 2;
        goto label_14;
        label_6:
        val_11 = 0;
        goto label_14;
        label_10:
        val_11 = 0;
        if(val_6 == 0)
        {
                var val_8 = ((val_3 & 255) != 10) ? 0 : 4;
            return (ConnectionState)val_12;
        }
        
        label_14:
        val_12 = ;
        return (ConnectionState)val_12;
    }
    public static ClientState get_connectionStateDetailed()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = null;
        if(PhotonNetwork.offlineMode != false)
        {
                val_6 = null;
            var val_4 = (PhotonNetwork.offlineModeRoom == 0) ? 16 : 9;
            return (ClientState)val_7;
        }
        
        val_8 = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                if(PhotonNetwork.networkingPeer != null)
        {
                return 0.State;
        }
        
            return 0.State;
        }
        
        val_7 = 15;
        return (ClientState)val_7;
    }
    public static ServerConnection get_Server()
    {
        var val_1;
        NetworkingPeer val_2;
        val_1 = null;
        val_1 = null;
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 == null)
        {
                return 2;
        }
        
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 != null)
        {
                return val_2.Server;
        }
        
        val_2 = 0;
        return val_2.Server;
    }
    public static AuthenticationValues get_AuthValues()
    {
        var val_1;
        NetworkingPeer val_2;
        val_1 = null;
        val_1 = null;
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 == null)
        {
                return 0;
        }
        
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 != null)
        {
                return val_2.AuthValues;
        }
        
        val_2 = 0;
        return val_2.AuthValues;
    }
    public static void set_AuthValues(AuthenticationValues value)
    {
        var val_1;
        NetworkingPeer val_2;
        val_1 = null;
        val_1 = null;
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.AuthValues = X1;
    }
    public static Room get_room()
    {
        var val_3 = null;
        if(PhotonNetwork.isOfflineMode != false)
        {
                return (Room)PhotonNetwork.offlineModeRoom;
        }
        
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.CurrentRoom;
        }
        
        return PhotonNetwork.networkingPeer.CurrentRoom;
    }
    public static PhotonPlayer get_player()
    {
        var val_1;
        NetworkingPeer val_2;
        val_1 = null;
        val_1 = null;
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 == null)
        {
                return 0;
        }
        
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 != null)
        {
                return val_2.LocalPlayer;
        }
        
        val_2 = 0;
        return val_2.LocalPlayer;
    }
    public static PhotonPlayer get_masterClient()
    {
        var val_6;
        NetworkingPeer val_7;
        val_6 = null;
        if(PhotonNetwork.offlineMode != false)
        {
                return PhotonNetwork.player;
        }
        
        val_6 = null;
        val_7 = PhotonNetwork.networkingPeer;
        if(val_7 == null)
        {
                return 0;
        }
        
        val_7 = PhotonNetwork.networkingPeer;
        if(val_7 != null)
        {
                return val_7.GetPlayerWithId(number:  val_7.mMasterClientId);
        }
        
        int val_5 = 0.mMasterClientId;
        return val_7.GetPlayerWithId(number:  val_7.mMasterClientId);
    }
    public static string get_playerName()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.PlayerName;
        }
        
        return PhotonNetwork.networkingPeer.PlayerName;
    }
    public static void set_playerName(string value)
    {
        null = null;
        PhotonNetwork.networkingPeer.PlayerName = X1;
    }
    public static PhotonPlayer[] get_playerList()
    {
        var val_1;
        var val_2;
        NetworkingPeer val_3;
        PhotonPlayer[] val_4;
        val_1 = 1152921504973725696;
        val_2 = null;
        val_2 = null;
        val_3 = PhotonNetwork.networkingPeer;
        if(val_3 == null)
        {
            goto label_3;
        }
        
        val_3 = PhotonNetwork.networkingPeer;
        if(val_3 == null)
        {
            goto label_6;
        }
        
        val_4 = mem[PhotonNetwork.networkingPeer + 440];
        val_4 = PhotonNetwork.networkingPeer.mPlayerListCopy;
        return (PhotonPlayer[])val_4;
        label_3:
        val_1 = null;
        val_4 = val_1;
        return (PhotonPlayer[])val_4;
        label_6:
    }
    public static PhotonPlayer[] get_otherPlayers()
    {
        var val_1;
        var val_2;
        NetworkingPeer val_3;
        PhotonPlayer[] val_4;
        val_1 = 1152921504973725696;
        val_2 = null;
        val_2 = null;
        val_3 = PhotonNetwork.networkingPeer;
        if(val_3 == null)
        {
            goto label_3;
        }
        
        val_3 = PhotonNetwork.networkingPeer;
        if(val_3 == null)
        {
            goto label_6;
        }
        
        val_4 = mem[PhotonNetwork.networkingPeer + 432];
        val_4 = PhotonNetwork.networkingPeer.mOtherPlayerListCopy;
        return (PhotonPlayer[])val_4;
        label_3:
        val_1 = null;
        val_4 = val_1;
        return (PhotonPlayer[])val_4;
        label_6:
    }
    public static System.Collections.Generic.List<FriendInfo> get_Friends()
    {
        null = null;
        return (System.Collections.Generic.List<FriendInfo>)PhotonNetwork.<Friends>k__BackingField;
    }
    internal static void set_Friends(System.Collections.Generic.List<FriendInfo> value)
    {
        null = null;
        PhotonNetwork.<Friends>k__BackingField = X1;
    }
    public static int get_FriendsListAge()
    {
        var val_1;
        NetworkingPeer val_2;
        val_1 = null;
        val_1 = null;
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 == null)
        {
                return 0;
        }
        
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 != null)
        {
                return val_2.FriendListAge;
        }
        
        val_2 = 0;
        return val_2.FriendListAge;
    }
    public static IPunPrefabPool get_PrefabPool()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return (IPunPrefabPool)PhotonNetwork.networkingPeer.ObjectPool;
        }
        
        return (IPunPrefabPool)PhotonNetwork.networkingPeer.ObjectPool;
    }
    public static void set_PrefabPool(IPunPrefabPool value)
    {
        null = null;
        PhotonNetwork.networkingPeer.ObjectPool = X1;
    }
    public static bool get_offlineMode()
    {
        null = null;
        return (bool)PhotonNetwork.isOfflineMode;
    }
    public static void set_offlineMode(bool value)
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = null;
        val_9 = null;
        var val_1 = (PhotonNetwork.isOfflineMode == true) ? 1 : 0;
        val_1 = val_1 ^ W1;
        if((val_1 & 1) == 0)
        {
                return;
        }
        
        if((W1 & 1) != 0)
        {
                if(PhotonNetwork.connected != false)
        {
                UnityEngine.Debug.LogError(message:  0);
            return;
        }
        
            val_9 = null;
        }
        
        val_9 = null;
        if((PhotonNetwork.networkingPeer.PeerState & 255) != 0)
        {
                val_10 = null;
            val_10 = null;
        }
        
        val_11 = null;
        val_11 = null;
        PhotonNetwork.isOfflineMode = W1 & 1;
        if(PhotonNetwork.isOfflineMode != false)
        {
                PhotonNetwork.networkingPeer.ChangeLocalID(newID:  0);
            NetworkingPeer.SendMonoMessage(methodString:  0, parameters:  16);
            return;
        }
        
        PhotonNetwork.offlineModeRoom = 0;
        PhotonNetwork.networkingPeer.ChangeLocalID(newID:  0);
    }
    public static bool get_automaticallySyncScene()
    {
        null = null;
        return (bool)PhotonNetwork._mAutomaticallySyncScene;
    }
    public static void set_automaticallySyncScene(bool value)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        PhotonNetwork._mAutomaticallySyncScene = W1 & 1;
        if(PhotonNetwork._mAutomaticallySyncScene == false)
        {
                return;
        }
        
        if(PhotonNetwork.room == null)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        PhotonNetwork.networkingPeer.LoadLevelIfSynced();
    }
    public static bool get_autoCleanUpPlayerObjects()
    {
        null = null;
        return (bool)PhotonNetwork.m_autoCleanUpPlayerObjects;
    }
    public static void set_autoCleanUpPlayerObjects(bool value)
    {
        var val_3;
        if(PhotonNetwork.room != null)
        {
                UnityEngine.Debug.LogError(message:  0);
            return;
        }
        
        val_3 = null;
        val_3 = null;
        PhotonNetwork.m_autoCleanUpPlayerObjects = W1 & 1;
    }
    public static bool get_autoJoinLobby()
    {
        null = null;
        if(PhotonNetwork.PhotonServerSettings != null)
        {
                return (bool)PhotonNetwork.PhotonServerSettings.JoinLobby;
        }
        
        return (bool)PhotonNetwork.PhotonServerSettings.JoinLobby;
    }
    public static void set_autoJoinLobby(bool value)
    {
        null = null;
        PhotonNetwork.PhotonServerSettings.JoinLobby = W1 & 1;
    }
    public static bool get_EnableLobbyStatistics()
    {
        null = null;
        if(PhotonNetwork.PhotonServerSettings != null)
        {
                return (bool)PhotonNetwork.PhotonServerSettings.EnableLobbyStatistics;
        }
        
        return (bool)PhotonNetwork.PhotonServerSettings.EnableLobbyStatistics;
    }
    public static void set_EnableLobbyStatistics(bool value)
    {
        null = null;
        PhotonNetwork.PhotonServerSettings.EnableLobbyStatistics = W1 & 1;
    }
    public static System.Collections.Generic.List<TypedLobbyInfo> get_LobbyStatistics()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return (System.Collections.Generic.List<TypedLobbyInfo>)PhotonNetwork.networkingPeer.LobbyStatistics;
        }
        
        return (System.Collections.Generic.List<TypedLobbyInfo>)PhotonNetwork.networkingPeer.LobbyStatistics;
    }
    private static void set_LobbyStatistics(System.Collections.Generic.List<TypedLobbyInfo> value)
    {
        null = null;
        PhotonNetwork.networkingPeer.LobbyStatistics = X1;
    }
    public static bool get_insideLobby()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return (bool)PhotonNetwork.networkingPeer.insideLobby;
        }
        
        return (bool)PhotonNetwork.networkingPeer.insideLobby;
    }
    public static TypedLobby get_lobby()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.lobby;
        }
        
        return PhotonNetwork.networkingPeer.lobby;
    }
    public static void set_lobby(TypedLobby value)
    {
        null = null;
        PhotonNetwork.networkingPeer.lobby = X1;
    }
    public static int get_sendRate()
    {
        null = null;
        return (int)1000 / PhotonNetwork.sendInterval;
    }
    public static void set_sendRate(int value)
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        PhotonNetwork.sendInterval = 1000 / W1;
        if(0 != PhotonNetwork.photonMono)
        {
                val_5 = null;
            val_5 = null;
            PhotonNetwork.photonMono.updateInterval = PhotonNetwork.sendInterval;
        }
        
        if(PhotonNetwork.sendRateOnSerialize <= W1)
        {
                return;
        }
        
        PhotonNetwork.sendRateOnSerialize = 366878720;
    }
    public static int get_sendRateOnSerialize()
    {
        null = null;
        return (int)1000 / PhotonNetwork.sendIntervalOnSerialize;
    }
    public static void set_sendRateOnSerialize(int value)
    {
        var val_5;
        var val_6;
        PhotonHandler val_7;
        var val_8;
        val_5 = W1;
        if(PhotonNetwork.sendRate < val_5)
        {
                UnityEngine.Debug.LogError(message:  0);
            val_5 = PhotonNetwork.sendRate;
        }
        
        val_6 = null;
        val_6 = null;
        PhotonNetwork.sendIntervalOnSerialize = 1000 / val_5;
        val_7 = PhotonNetwork.photonMono;
        if(0 == val_7)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = PhotonNetwork.photonMono;
        PhotonNetwork.photonMono.updateIntervalOnSerialize = PhotonNetwork.sendIntervalOnSerialize;
    }
    public static bool get_isMessageQueueRunning()
    {
        null = null;
        return (bool)PhotonNetwork.m_isMessageQueueRunning;
    }
    public static void set_isMessageQueueRunning(bool value)
    {
        var val_3;
        if((W1 & 1) != 0)
        {
                PhotonHandler.StartFallbackSendAckThread();
        }
        
        val_3 = null;
        val_3 = null;
        PhotonNetwork.networkingPeer.IsSendingOnlyAcks = (~W1) & 1;
        PhotonNetwork.m_isMessageQueueRunning = W1 & 1;
    }
    public static int get_unreliableCommandsLimit()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.LimitOfUnreliableCommands;
        }
        
        return PhotonNetwork.networkingPeer.LimitOfUnreliableCommands;
    }
    public static void set_unreliableCommandsLimit(int value)
    {
        null = null;
        PhotonNetwork.networkingPeer.LimitOfUnreliableCommands = W1;
    }
    public static double get_time()
    {
        double val_2 = 1000;
        val_2 = (double)PhotonNetwork.ServerTimestamp / val_2;
        return (double)val_2;
    }
    public static int get_ServerTimestamp()
    {
        var val_6;
        var val_7;
        System.Diagnostics.Stopwatch val_9;
        var val_10;
        var val_11;
        val_6 = null;
        if(PhotonNetwork.offlineMode != false)
        {
                val_7 = null;
            if(PhotonNetwork.UsePreciseTimer == false)
        {
                return System.Environment.TickCount;
        }
        
            val_7 = null;
            val_9 = PhotonNetwork.startupStopwatch;
            if(val_9 == null)
        {
                return System.Environment.TickCount;
        }
        
            val_9 = PhotonNetwork.startupStopwatch;
            if(val_9 == null)
        {
                val_9 = 0;
        }
        
            if(val_9.IsRunning == false)
        {
                return System.Environment.TickCount;
        }
        
            val_10 = null;
            val_10 = null;
            return (int)PhotonNetwork.startupStopwatch.ElapsedMilliseconds;
        }
        
        val_11 = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.ServerTimeInMilliSeconds;
        }
        
        return PhotonNetwork.networkingPeer.ServerTimeInMilliSeconds;
    }
    public static bool get_isMasterClient()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = 1152921504973725696;
        if(PhotonNetwork.offlineMode != false)
        {
                val_7 = 1;
            return (bool)(val_6 == val_4.actorID) ? 1 : 0;
        }
        
        val_8 = null;
        val_8 = null;
        val_6 = PhotonNetwork.networkingPeer.mMasterClientId;
        PhotonPlayer val_4 = PhotonNetwork.player;
        return (bool)(val_6 == val_4.actorID) ? 1 : 0;
    }
    public static bool get_inRoom()
    {
        return (bool)(PhotonNetwork.connectionStateDetailed == 9) ? 1 : 0;
    }
    public static bool get_isNonMasterClientInRoom()
    {
        var val_5;
        if(PhotonNetwork.isMasterClient == false)
        {
                return (bool)(PhotonNetwork.room != 0) ? 1 : 0;
        }
        
        val_5 = 0;
        return (bool)(PhotonNetwork.room != 0) ? 1 : 0;
    }
    public static int get_countOfPlayersOnMaster()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.PlayersOnMasterCount;
        }
        
        return PhotonNetwork.networkingPeer.PlayersOnMasterCount;
    }
    public static int get_countOfPlayersInRooms()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.PlayersInRoomsCount;
        }
        
        return PhotonNetwork.networkingPeer.PlayersInRoomsCount;
    }
    public static int get_countOfPlayers()
    {
        null = null;
        int val_2 = PhotonNetwork.networkingPeer.PlayersOnMasterCount;
        val_2 = val_2 + PhotonNetwork.networkingPeer.PlayersInRoomsCount;
        return (int)val_2;
    }
    public static int get_countOfRooms()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.RoomsCount;
        }
        
        return PhotonNetwork.networkingPeer.RoomsCount;
    }
    public static bool get_NetworkStatisticsEnabled()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.TrafficStatsEnabled;
        }
        
        return PhotonNetwork.networkingPeer.TrafficStatsEnabled;
    }
    public static void set_NetworkStatisticsEnabled(bool value)
    {
        null = null;
        PhotonNetwork.networkingPeer.TrafficStatsEnabled = W1 & 1;
    }
    public static int get_ResentReliableCommands()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.ResentReliableCommands;
        }
        
        return PhotonNetwork.networkingPeer.ResentReliableCommands;
    }
    public static bool get_CrcCheckEnabled()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.CrcEnabled;
        }
        
        return PhotonNetwork.networkingPeer.CrcEnabled;
    }
    public static void set_CrcCheckEnabled(bool value)
    {
        var val_9;
        var val_10;
        if(PhotonNetwork.connected != true)
        {
                if(PhotonNetwork.connecting == false)
        {
            goto label_6;
        }
        
        }
        
        val_9 = null;
        val_9 = null;
        bool val_6 = PhotonNetwork.networkingPeer.CrcEnabled;
        string val_7 = 0 + "Can\'t change CrcCheckEnabled while being connected. CrcCheckEnabled stays ";
        UnityEngine.Debug.Log(message:  0);
        return;
        label_6:
        val_10 = null;
        val_10 = null;
        PhotonNetwork.networkingPeer.CrcEnabled = W1 & 1;
    }
    public static int get_PacketLossByCrcCheck()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.PacketLossByCrc;
        }
        
        return PhotonNetwork.networkingPeer.PacketLossByCrc;
    }
    public static int get_MaxResendsBeforeDisconnect()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return (int)PhotonNetwork.networkingPeer + 136;
        }
        
        return (int)PhotonNetwork.networkingPeer + 136;
    }
    public static void set_MaxResendsBeforeDisconnect(int value)
    {
        var val_2;
        var val_2 = W1;
        var val_1 = (val_2 < 3) ? 3 : (val_2);
        val_2 = null;
        val_2 = (val_1 > 10) ? 10 : (val_1);
        val_2 = null;
        PhotonNetwork.networkingPeer.__unknownFiledOffset_88 = val_2;
    }
    public static int get_QuickResends()
    {
        null = null;
        byte val_1 = PhotonNetwork.networkingPeer.QuickResendAttempts;
        val_1 = val_1 & 255;
        return (int)val_1;
    }
    public static void set_QuickResends(int value)
    {
        var val_2;
        byte val_2 = W1;
        var val_1 = (val_2 < 0) ? 0 : (val_2);
        val_2 = null;
        val_2 = (val_1 > 3) ? 3 : (val_1);
        val_2 = null;
        PhotonNetwork.networkingPeer.QuickResendAttempts = val_2;
    }
    public static bool get_UseAlternativeUdpPorts()
    {
        null = null;
        return (bool)PhotonNetwork.<UseAlternativeUdpPorts>k__BackingField;
    }
    public static void set_UseAlternativeUdpPorts(bool value)
    {
        null = null;
        PhotonNetwork.<UseAlternativeUdpPorts>k__BackingField = W1 & 1;
    }
    public static void SwitchToProtocol(ExitGames.Client.Photon.ConnectionProtocol cp)
    {
        null = null;
        PhotonNetwork.networkingPeer.TransportProtocol = W1;
    }
    public static bool ConnectUsingSettings(string gameVersion)
    {
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_30;
        ExitGames.Client.Photon.ConnectionProtocol val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        ServerSettings val_39;
        string val_40;
        string val_41;
        var val_42;
        var val_43;
        string val_44;
        val_22 = null;
        val_22 = null;
        val_23 = null;
        if((PhotonNetwork.networkingPeer.PeerState & 255) == 0)
        {
            goto label_4;
        }
        
        val_24 = null;
        ExitGames.Client.Photon.PeerStateValue val_5 = PhotonNetwork.networkingPeer.PeerState;
        string val_6 = 0 + "ConnectUsingSettings() failed. Can only connect while in state \'Disconnected\'. Current state: "("ConnectUsingSettings() failed. Can only connect while in state \'Disconnected\'. Current state: ");
        UnityEngine.Debug.LogWarning(message:  0);
        goto label_12;
        label_4:
        val_25 = null;
        if(0 != PhotonNetwork.PhotonServerSettings)
        {
            goto label_17;
        }
        
        val_26 = "Can\'t connect: Loading settings failed. ServerSettings asset must be in any \'Resources\' folder as: PhotonServerSettings";
        goto label_20;
        label_17:
        val_27 = null;
        val_27 = null;
        if( == 0)
        {
            goto label_24;
        }
        
        val_28 = null;
        val_28 = null;
        if(PhotonNetwork.logLevel == 0)
        {
                PhotonNetwork.logLevel = PhotonNetwork.PhotonServerSettings.PunLogging;
            val_28 = null;
        }
        
        val_28 = null;
        if((PhotonNetwork.networkingPeer + 56) == 1)
        {
                val_30 = null;
            val_30 = null;
            PhotonNetwork.networkingPeer.__unknownFiledOffset_38 = PhotonNetwork.PhotonServerSettings.NetworkLogging;
        }
        
        val_31 = null;
        val_31 = null;
        PhotonNetwork.SwitchToProtocol(cp:  val_31);
        PhotonNetwork.networkingPeer.SetApp(appId:  PhotonNetwork.PhotonServerSettings.AppID, gameVersion:  X1);
        val_32 = null;
        if(PhotonNetwork.PhotonServerSettings == null)
        {
                val_32 = null;
        }
        
        if(PhotonNetwork.PhotonServerSettings.HostType != 3)
        {
            goto label_45;
        }
        
        val_33 = 1;
        PhotonNetwork.offlineMode = false;
        return (bool)val_33 & 1;
        label_24:
        val_26 = "You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don\'t use ConnectUsingSettings().";
        label_20:
        UnityEngine.Debug.LogError(message:  0);
        label_12:
        val_33 = 0;
        return (bool)val_33 & 1;
        label_45:
        if(PhotonNetwork.offlineMode != false)
        {
                UnityEngine.Debug.LogWarning(message:  0);
        }
        
        PhotonNetwork.offlineMode = false;
        PhotonNetwork.isMessageQueueRunning = false;
        PhotonNetwork.networkingPeer.IsInitialConnect = true;
        val_34 = null;
        if(PhotonNetwork.PhotonServerSettings == null)
        {
                val_34 = null;
        }
        
        if(PhotonNetwork.PhotonServerSettings.HostType != 2)
        {
            goto label_60;
        }
        
        val_35 = null;
        PhotonNetwork.networkingPeer.IsUsingNameServer = false;
        val_36 = null;
        if(PhotonNetwork.PhotonServerSettings == null)
        {
                val_36 = null;
        }
        
        var val_15 = (PhotonNetwork.PhotonServerSettings.ServerPort == 0) ? 0 : PhotonNetwork.networkingPeer;
        if(PhotonNetwork.PhotonServerSettings.ServerPort == 0)
        {
            goto label_65;
        }
        
        val_38 = null;
        val_39 = PhotonNetwork.PhotonServerSettings;
        if(PhotonNetwork.PhotonServerSettings != null)
        {
            goto label_68;
        }
        
        val_39 = PhotonNetwork.PhotonServerSettings;
        if(val_39 == null)
        {
            goto label_69;
        }
        
        label_68:
        val_40 = 0 + PhotonNetwork.PhotonServerSettings.ServerAddress + ":"(":");
        goto label_72;
        label_60:
        val_41 = null;
        if(PhotonNetwork.PhotonServerSettings == null)
        {
                val_41 = null;
        }
        
        if(PhotonNetwork.PhotonServerSettings.HostType == 4)
        {
                return PhotonNetwork.ConnectToBestCloudServer(gameVersion:  val_41);
        }
        
        val_41 = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.ConnectToRegionMaster(region:  PhotonNetwork.PhotonServerSettings.PreferredRegion);
        }
        
        return PhotonNetwork.networkingPeer.ConnectToRegionMaster(region:  PhotonNetwork.PhotonServerSettings.PreferredRegion);
        label_65:
        val_42 = null;
        val_40 = mem[PhotonNetwork.PhotonServerSettings + 64];
        val_40 = PhotonNetwork.PhotonServerSettings.ServerAddress;
        val_37 = PhotonNetwork.networkingPeer;
        label_72:
        val_37.MasterServerAddress = val_40;
        val_43 = null;
        val_43 = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                val_44 = PhotonNetwork.networkingPeer.MasterServerAddress;
        }
        else
        {
                val_44 = 0.MasterServerAddress;
        }
        
        bool val_22 = PhotonNetwork.networkingPeer.Connect(serverAddress:  val_44, type:  0);
        return (bool)val_33 & 1;
        label_69:
    }
    public static bool ConnectToMaster(string masterServerAddress, int port, string appID, string gameVersion)
    {
        string val_16;
        object val_17;
        var val_18;
        NetworkingPeer val_19;
        var val_20;
        NetworkingPeer val_21;
        var val_22;
        var val_23;
        var val_24;
        string val_25;
        val_16 = X4;
        val_17 = port;
        val_18 = null;
        val_18 = null;
        val_19 = PhotonNetwork.networkingPeer;
        val_20 = null;
        if((val_19.PeerState & 255) != 0)
        {
                val_20 = null;
            ExitGames.Client.Photon.PeerStateValue val_5 = PhotonNetwork.networkingPeer.PeerState;
            val_21 = 0 + "ConnectToMaster() failed. Can only connect while in state \'Disconnected\'. Current state: "("ConnectToMaster() failed. Can only connect while in state \'Disconnected\'. Current state: ");
            UnityEngine.Debug.LogWarning(message:  0);
            val_22 = 0;
            return (bool)val_22.Connect(serverAddress:  val_25 = 0.MasterServerAddress, type:  0);
        }
        
        if(PhotonNetwork.offlineMode != false)
        {
                PhotonNetwork.offlineMode = false;
            UnityEngine.Debug.LogWarning(message:  0);
        }
        
        if(PhotonNetwork.isMessageQueueRunning != true)
        {
                PhotonNetwork.isMessageQueueRunning = false;
            UnityEngine.Debug.LogWarning(message:  0);
        }
        
        val_23 = null;
        val_23 = null;
        val_19 = PhotonNetwork.networkingPeer;
        val_19.SetApp(appId:  gameVersion, gameVersion:  val_16);
        PhotonNetwork.networkingPeer.IsUsingNameServer = false;
        PhotonNetwork.networkingPeer.IsInitialConnect = true;
        val_16 = PhotonNetwork.networkingPeer;
        if(appID != null)
        {
                val_17 = 0 + val_17 + ":"(":");
            val_16 = (appID == null) ? 0 : (val_16);
        }
        
        val_16.MasterServerAddress = val_17;
        val_24 = null;
        val_24 = null;
        val_21 = PhotonNetwork.networkingPeer;
        if(val_21 != null)
        {
                val_25 = val_21.MasterServerAddress;
        }
        else
        {
            
        }
        
        val_22 = val_21;
        return (bool)val_22.Connect(serverAddress:  val_25, type:  0);
    }
    public static bool Reconnect()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        object val_19;
        var val_20;
        var val_21;
        var val_22;
        val_15 = null;
        val_15 = null;
        string val_1 = PhotonNetwork.networkingPeer.MasterServerAddress;
        val_16 = null;
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_6;
        }
        
        val_17 = null;
        val_18 = PhotonNetwork.networkingPeer.PeerState;
        val_19 = "Reconnect() failed. It seems the client wasn\'t connected before?! Current state: ";
        goto label_12;
        label_6:
        val_20 = null;
        val_21 = null;
        if((PhotonNetwork.networkingPeer.PeerState & 255) == 0)
        {
            goto label_16;
        }
        
        val_21 = null;
        val_18 = PhotonNetwork.networkingPeer.PeerState;
        val_19 = "Reconnect() failed. Can only connect while in state \'Disconnected\'. Current state: ";
        label_12:
        string val_11 = 0 + val_19;
        UnityEngine.Debug.LogWarning(message:  0);
        return false;
        label_16:
        if(PhotonNetwork.offlineMode != false)
        {
                PhotonNetwork.offlineMode = false;
            UnityEngine.Debug.LogWarning(message:  0);
        }
        
        if(PhotonNetwork.isMessageQueueRunning != true)
        {
                PhotonNetwork.isMessageQueueRunning = false;
            UnityEngine.Debug.LogWarning(message:  0);
        }
        
        val_22 = null;
        val_22 = null;
        PhotonNetwork.networkingPeer.IsUsingNameServer = false;
        PhotonNetwork.networkingPeer.IsInitialConnect = false;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.ReconnectToMaster();
        }
        
        return PhotonNetwork.networkingPeer.ReconnectToMaster();
    }
    public static bool ReconnectAndRejoin()
    {
        var val_12;
        var val_13;
        NetworkingPeer val_14;
        object val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_12 = null;
        val_12 = null;
        val_13 = null;
        if((PhotonNetwork.networkingPeer.PeerState & 255) != 0)
        {
                val_13 = null;
            ExitGames.Client.Photon.PeerStateValue val_5 = PhotonNetwork.networkingPeer.PeerState;
            val_14 = 0 + "ReconnectAndRejoin() failed. Can only connect while in state \'Disconnected\'. Current state: "("ReconnectAndRejoin() failed. Can only connect while in state \'Disconnected\'. Current state: ");
            val_15 = 0;
        }
        else
        {
                if(PhotonNetwork.offlineMode != false)
        {
                PhotonNetwork.offlineMode = false;
            UnityEngine.Debug.LogWarning(message:  0);
        }
        
            val_16 = null;
            val_16 = null;
            val_14 = PhotonNetwork.networkingPeer.GameServerAddress;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
        {
                val_17 = "ReconnectAndRejoin() failed. It seems the client wasn\'t connected to a game server before (no address).";
        }
        else
        {
                val_18 = null;
            val_18 = null;
            val_14 = PhotonNetwork.networkingPeer;
            if(null != 0)
        {
                if(PhotonNetwork.isMessageQueueRunning != true)
        {
                PhotonNetwork.isMessageQueueRunning = false;
            UnityEngine.Debug.LogWarning(message:  0);
        }
        
            val_19 = null;
            val_19 = null;
            PhotonNetwork.networkingPeer.IsUsingNameServer = false;
            PhotonNetwork.networkingPeer.IsInitialConnect = false;
            if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.ReconnectAndRejoin();
        }
        
            return PhotonNetwork.networkingPeer.ReconnectAndRejoin();
        }
        
            val_17 = "ReconnectAndRejoin() failed. It seems the client doesn\'t have any previous room to re-join.";
        }
        
            val_15 = 0;
        }
        
        UnityEngine.Debug.LogWarning(message:  val_15);
        return false;
    }
    public static bool ConnectToBestCloudServer(string gameVersion)
    {
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        string val_15;
        val_10 = X1;
        val_11 = null;
        val_11 = null;
        val_12 = null;
        if((PhotonNetwork.networkingPeer.PeerState & 255) != 0)
        {
                val_13 = null;
            ExitGames.Client.Photon.PeerStateValue val_5 = PhotonNetwork.networkingPeer.PeerState;
            val_10 = 0 + "ConnectToBestCloudServer() failed. Can only connect while in state \'Disconnected\'. Current state: "("ConnectToBestCloudServer() failed. Can only connect while in state \'Disconnected\'. Current state: ");
            UnityEngine.Debug.LogWarning(message:  0);
            return false;
        }
        
        val_14 = null;
        if(0 == PhotonNetwork.PhotonServerSettings)
        {
                UnityEngine.Debug.LogError(message:  0);
            return false;
        }
        
        val_15 = null;
        val_15 = null;
        if(PhotonNetwork.PhotonServerSettings == null)
        {
                val_15 = null;
        }
        
        if(PhotonNetwork.PhotonServerSettings.HostType == 3)
        {
                return PhotonNetwork.ConnectUsingSettings(gameVersion:  val_15);
        }
        
        val_15 = null;
        PhotonNetwork.networkingPeer.IsInitialConnect = true;
        PhotonNetwork.networkingPeer.SetApp(appId:  PhotonNetwork.PhotonServerSettings.AppID, gameVersion:  val_10);
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.ConnectToNameServer();
        }
        
        return PhotonNetwork.networkingPeer.ConnectToNameServer();
    }
    public static bool ConnectToRegion(CloudRegionCode region, string gameVersion)
    {
        string val_12;
        var val_13;
        NetworkingPeer val_14;
        var val_15;
        var val_16;
        var val_17;
        string val_18;
        var val_19;
        val_12 = gameVersion;
        val_13 = null;
        val_13 = null;
        val_14 = PhotonNetwork.networkingPeer;
        val_15 = null;
        if((val_14.PeerState & 255) == 0)
        {
            goto label_4;
        }
        
        val_16 = null;
        ExitGames.Client.Photon.PeerStateValue val_5 = PhotonNetwork.networkingPeer.PeerState;
        val_12 = 0 + "ConnectToRegion() failed. Can only connect while in state \'Disconnected\'. Current state: "("ConnectToRegion() failed. Can only connect while in state \'Disconnected\'. Current state: ");
        UnityEngine.Debug.LogWarning(message:  0);
        goto label_20;
        label_4:
        val_17 = null;
        val_14 = PhotonNetwork.PhotonServerSettings;
        if(0 != val_14)
        {
            goto label_17;
        }
        
        UnityEngine.Debug.LogError(message:  0);
        goto label_20;
        label_17:
        val_18 = null;
        val_18 = null;
        if(PhotonNetwork.PhotonServerSettings == null)
        {
                val_18 = null;
        }
        
        if(PhotonNetwork.PhotonServerSettings.HostType == 3)
        {
                return PhotonNetwork.ConnectUsingSettings(gameVersion:  val_18);
        }
        
        val_18 = null;
        PhotonNetwork.networkingPeer.IsInitialConnect = true;
        val_14 = PhotonNetwork.networkingPeer;
        val_14.SetApp(appId:  PhotonNetwork.PhotonServerSettings.AppID, gameVersion:  X2);
        if(val_12 != 4)
        {
            goto label_32;
        }
        
        label_20:
        var val_12 = 0;
        label_40:
        val_12 = val_12 & 1;
        return (bool)val_12;
        label_32:
        string val_10 = 0 + "ConnectToRegion: "("ConnectToRegion: ");
        UnityEngine.Debug.Log(message:  0);
        val_19 = null;
        val_19 = null;
        bool val_11 = PhotonNetwork.networkingPeer.ConnectToRegionMaster(region:  val_12);
        goto label_40;
    }
    public static void OverrideBestCloudServer(CloudRegionCode region)
    {
        PhotonHandler.BestRegionCodeInPreferences = null;
    }
    public static void RefreshCloudServerRating()
    {
        System.NotImplementedException val_1 = new System.NotImplementedException(message:  "not available at the moment");
    }
    public static void NetworkStatisticsReset()
    {
        null = null;
        PhotonNetwork.networkingPeer.TrafficStatsReset();
    }
    public static string NetworkStatisticsToString()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(PhotonNetwork.networkingPeer == null)
        {
                return "Offline or in OfflineMode. No VitalStats available.";
        }
        
        if(PhotonNetwork.offlineMode != false)
        {
                return "Offline or in OfflineMode. No VitalStats available.";
        }
        
        val_4 = null;
        val_4 = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.VitalStatsToString(all:  false);
        }
        
        return PhotonNetwork.networkingPeer.VitalStatsToString(all:  false);
    }
    [System.ObsoleteAttribute]
    public static void InitializeSecurity()
    {
    
    }
    private static bool VerifyCanUseNetwork()
    {
        var val_3;
        if(PhotonNetwork.connected != false)
        {
                val_3 = 1;
            return (bool)val_3;
        }
        
        UnityEngine.Debug.LogError(message:  0);
        val_3 = 0;
        return (bool)val_3;
    }
    public static void Disconnect()
    {
        var val_8;
        var val_9;
        var val_10;
        NetworkingPeer val_11;
        val_9 = null;
        val_10 = null;
        if(PhotonNetwork.offlineMode != false)
        {
                val_9 = val_10;
            PhotonNetwork.offlineMode = false;
            PhotonNetwork.offlineModeRoom = 0;
            PhotonNetwork.networkingPeer.State = 14;
            PhotonNetwork.networkingPeer.OnStatusChanged(statusCode:  1);
            return;
        }
        
        val_10 = null;
        val_11 = PhotonNetwork.networkingPeer;
        if(val_11 == null)
        {
                return;
        }
        
        val_11 = PhotonNetwork.networkingPeer;
        if(val_11 != null)
        {
                val_8 = ???;
        }
    
    }
    public static bool FindFriends(string[] friendsToFind)
    {
        if(PhotonNetwork.networkingPeer == null)
        {
                return false;
        }
        
        null = null;
        if(PhotonNetwork.isOfflineMode != false)
        {
                return false;
        }
        
        if(PhotonNetwork.networkingPeer == null)
        {
            
        }
    
    }
    public static bool CreateRoom(string roomName)
    {
        return PhotonNetwork.CreateRoom(roomName:  null, roomOptions:  X1, typedLobby:  0, expectedUsers:  0);
    }
    public static bool CreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby)
    {
        return PhotonNetwork.CreateRoom(roomName:  null, roomOptions:  roomOptions, typedLobby:  typedLobby, expectedUsers:  X3);
    }
    public static bool CreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby, string[] expectedUsers)
    {
        NetworkingPeer val_9;
        var val_10;
        string val_11;
        var val_12;
        string val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_10 = expectedUsers;
        val_11 = null;
        val_12 = null;
        if(PhotonNetwork.offlineMode == false)
        {
            goto label_3;
        }
        
        val_11 = val_12;
        val_13 = null;
        if(PhotonNetwork.offlineModeRoom == null)
        {
            goto label_6;
        }
        
        val_14 = "CreateRoom failed. In offline mode you still have to leave a room to enter another.";
        goto label_9;
        label_3:
        val_15 = null;
        val_9 = PhotonNetwork.networkingPeer;
        if((val_9.Server != 0) || (PhotonNetwork.connectedAndReady == false))
        {
            goto label_16;
        }
        
        if(val_10 != null)
        {
            goto label_25;
        }
        
        val_16 = null;
        val_16 = null;
        if(PhotonNetwork.networkingPeer.insideLobby == false)
        {
            goto label_21;
        }
        
        val_17 = null;
        val_17 = null;
        val_10 = PhotonNetwork.networkingPeer.lobby;
        goto label_25;
        label_16:
        val_14 = "CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
        label_9:
        UnityEngine.Debug.LogError(message:  0);
        val_18 = 0;
        return (bool)val_18;
        label_6:
        val_11 = val_13;
        val_18 = 1;
        PhotonNetwork.EnterOfflineRoom(roomName:  val_11, roomOptions:  roomOptions, createdRoom:  typedLobby);
        return (bool)val_18;
        label_21:
        val_10 = 0;
        label_25:
        if(null != 0)
        {
                typeof(EnterRoomParams).__il2cppRuntimeField_10 = roomOptions;
            typeof(EnterRoomParams).__il2cppRuntimeField_18 = typedLobby;
            typeof(EnterRoomParams).__il2cppRuntimeField_20 = val_10;
        }
        else
        {
                mem[16] = roomOptions;
            mem[24] = typedLobby;
            mem[32] = val_10;
        }
        
        typeof(EnterRoomParams).__il2cppRuntimeField_38 = X4;
        val_19 = null;
        val_19 = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.OpCreateGame(enterRoomParams:  new EnterRoomParams());
        }
        
        return PhotonNetwork.networkingPeer.OpCreateGame(enterRoomParams:  new EnterRoomParams());
    }
    public static bool JoinRoom(string roomName)
    {
        return PhotonNetwork.JoinRoom(roomName:  null, expectedUsers:  X1);
    }
    public static bool JoinRoom(string roomName, string[] expectedUsers)
    {
        NetworkingPeer val_9;
        string val_10;
        var val_11;
        string val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_10 = null;
        val_11 = null;
        if(PhotonNetwork.offlineMode == false)
        {
            goto label_3;
        }
        
        val_10 = val_11;
        val_12 = null;
        if(PhotonNetwork.offlineModeRoom == null)
        {
            goto label_6;
        }
        
        val_13 = "JoinRoom failed. In offline mode you still have to leave a room to enter another.";
        goto label_22;
        label_3:
        val_14 = null;
        val_9 = PhotonNetwork.networkingPeer;
        if((val_9.Server != 0) || (PhotonNetwork.connectedAndReady == false))
        {
            goto label_16;
        }
        
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_19;
        }
        
        val_13 = "JoinRoom failed. A roomname is required. If you don\'t know one, how will you join?";
        goto label_22;
        label_16:
        val_13 = "JoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
        label_22:
        UnityEngine.Debug.LogError(message:  0);
        val_15 = 0;
        return (bool)val_15;
        label_6:
        val_10 = val_12;
        val_15 = 1;
        PhotonNetwork.EnterOfflineRoom(roomName:  val_10, roomOptions:  expectedUsers, createdRoom:  false);
        return (bool)val_15;
        label_19:
        EnterRoomParams val_8 = new EnterRoomParams();
        if(null != 0)
        {
                typeof(EnterRoomParams).__il2cppRuntimeField_10 = expectedUsers;
        }
        else
        {
                mem[16] = expectedUsers;
        }
        
        typeof(EnterRoomParams).__il2cppRuntimeField_38 = X2;
        val_16 = null;
        val_16 = null;
        if(PhotonNetwork.networkingPeer == null)
        {
            
        }
    
    }
    public static bool JoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby)
    {
        return PhotonNetwork.JoinOrCreateRoom(roomName:  null, roomOptions:  roomOptions, typedLobby:  typedLobby, expectedUsers:  X3);
    }
    public static bool JoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby, string[] expectedUsers)
    {
        NetworkingPeer val_11;
        string val_12;
        var val_13;
        string val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_12 = null;
        val_13 = null;
        if(PhotonNetwork.offlineMode == false)
        {
            goto label_3;
        }
        
        val_12 = val_13;
        val_14 = null;
        if(PhotonNetwork.offlineModeRoom == null)
        {
            goto label_6;
        }
        
        val_15 = "JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.";
        goto label_22;
        label_3:
        val_16 = null;
        val_11 = PhotonNetwork.networkingPeer;
        if((val_11.Server != 0) || (PhotonNetwork.connectedAndReady == false))
        {
            goto label_16;
        }
        
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_19;
        }
        
        val_15 = "JoinOrCreateRoom failed. A roomname is required. If you don\'t know one, how will you join?";
        goto label_22;
        label_16:
        val_15 = "JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
        label_22:
        UnityEngine.Debug.LogError(message:  0);
        val_17 = 0;
        return (bool)val_17;
        label_6:
        val_12 = val_14;
        val_17 = 1;
        PhotonNetwork.EnterOfflineRoom(roomName:  val_12, roomOptions:  roomOptions, createdRoom:  typedLobby);
        return (bool)val_17;
        label_19:
        if(expectedUsers == null)
        {
                val_18 = null;
            val_18 = null;
            if(PhotonNetwork.networkingPeer.insideLobby != false)
        {
                val_19 = null;
            val_19 = null;
            val_20 = PhotonNetwork.networkingPeer.lobby;
        }
        else
        {
                val_20 = 0;
        }
        
        }
        
        EnterRoomParams val_9 = new EnterRoomParams();
        if(null != 0)
        {
                typeof(EnterRoomParams).__il2cppRuntimeField_10 = roomOptions;
            typeof(EnterRoomParams).__il2cppRuntimeField_18 = typedLobby;
            typeof(EnterRoomParams).__il2cppRuntimeField_20 = val_20;
        }
        else
        {
                mem[16] = roomOptions;
            mem[24] = typedLobby;
            mem[32] = val_20;
        }
        
        typeof(EnterRoomParams).__il2cppRuntimeField_31 = 1;
        PhotonPlayer val_10 = PhotonNetwork.player;
        if(null != 0)
        {
                typeof(EnterRoomParams).__il2cppRuntimeField_28 = val_10.<CustomProperties>k__BackingField;
        }
        else
        {
                mem[40] = val_10.<CustomProperties>k__BackingField;
        }
        
        typeof(EnterRoomParams).__il2cppRuntimeField_38 = X4;
        if(PhotonNetwork.networkingPeer == null)
        {
            
        }
    
    }
    public static bool JoinRandomRoom()
    {
        return PhotonNetwork.JoinRandomRoom(expectedCustomRoomProperties:  null, expectedMaxPlayers:  0, matchingType:  0, typedLobby:  0, sqlLobbyFilter:  0, expectedUsers:  0);
    }
    public static bool JoinRandomRoom(ExitGames.Client.Photon.Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers)
    {
        return PhotonNetwork.JoinRandomRoom(expectedCustomRoomProperties:  null, expectedMaxPlayers:  expectedMaxPlayers, matchingType:  W2, typedLobby:  0, sqlLobbyFilter:  0, expectedUsers:  0);
    }
    public static bool JoinRandomRoom(ExitGames.Client.Photon.Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchingType, TypedLobby typedLobby, string sqlLobbyFilter, string[] expectedUsers)
    {
        NetworkingPeer val_9;
        var val_10;
        string val_11;
        var val_12;
        string val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_10 = sqlLobbyFilter;
        val_11 = null;
        val_12 = null;
        if(PhotonNetwork.offlineMode == false)
        {
            goto label_3;
        }
        
        val_11 = val_12;
        val_13 = null;
        if(PhotonNetwork.offlineModeRoom == null)
        {
            goto label_6;
        }
        
        val_14 = "JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.";
        goto label_9;
        label_3:
        val_15 = null;
        val_9 = PhotonNetwork.networkingPeer;
        if((val_9.Server != 0) || (PhotonNetwork.connectedAndReady == false))
        {
            goto label_16;
        }
        
        if(val_10 != null)
        {
            goto label_25;
        }
        
        val_16 = null;
        val_16 = null;
        if(PhotonNetwork.networkingPeer.insideLobby == false)
        {
            goto label_21;
        }
        
        val_17 = null;
        val_17 = null;
        val_10 = PhotonNetwork.networkingPeer.lobby;
        goto label_25;
        label_16:
        val_14 = "JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
        label_9:
        UnityEngine.Debug.LogError(message:  0);
        val_18 = 0;
        return (bool)val_18;
        label_6:
        val_11 = val_13;
        val_18 = 1;
        PhotonNetwork.EnterOfflineRoom(roomName:  val_11, roomOptions:  "offline room", createdRoom:  false);
        return (bool)val_18;
        label_21:
        val_10 = 0;
        label_25:
        object val_8 = new System.Object();
        if(null != 0)
        {
                typeof(OpJoinRandomRoomParams).__il2cppRuntimeField_10 = expectedMaxPlayers;
            typeof(OpJoinRandomRoomParams).__il2cppRuntimeField_18 = matchingType;
            typeof(OpJoinRandomRoomParams).__il2cppRuntimeField_19 = typedLobby;
            typeof(OpJoinRandomRoomParams).__il2cppRuntimeField_20 = val_10;
            typeof(OpJoinRandomRoomParams).__il2cppRuntimeField_28 = expectedUsers;
        }
        else
        {
                mem[16] = expectedMaxPlayers;
            mem[24] = matchingType;
            typeof(OpJoinRandomRoomParams).__il2cppRuntimeField_19 = typedLobby;
            mem[32] = val_10;
            mem[40] = expectedUsers;
        }
        
        typeof(OpJoinRandomRoomParams).__il2cppRuntimeField_30 = X6;
        val_19 = null;
        val_19 = null;
        if(PhotonNetwork.networkingPeer == null)
        {
            
        }
    
    }
    public static bool ReJoinRoom(string roomName)
    {
        var val_8;
        var val_9;
        if(PhotonNetwork.offlineMode == false)
        {
            goto label_3;
        }
        
        val_8 = "ReJoinRoom failed due to offline mode.";
        goto label_19;
        label_3:
        val_9 = null;
        val_9 = null;
        if((PhotonNetwork.networkingPeer.Server != 0) || (PhotonNetwork.connectedAndReady == false))
        {
            goto label_13;
        }
        
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_16;
        }
        
        val_8 = "ReJoinRoom failed. A roomname is required. If you don\'t know one, how will you join?";
        goto label_19;
        label_13:
        val_8 = "ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
        label_19:
        UnityEngine.Debug.LogError(message:  0);
        return false;
        label_16:
        EnterRoomParams val_6 = new EnterRoomParams();
        if(null != 0)
        {
                typeof(EnterRoomParams).__il2cppRuntimeField_10 = X1;
        }
        else
        {
                mem[16] = X1;
        }
        
        typeof(EnterRoomParams).__il2cppRuntimeField_32 = 1;
        PhotonPlayer val_7 = PhotonNetwork.player;
        typeof(EnterRoomParams).__il2cppRuntimeField_28 = val_7.<CustomProperties>k__BackingField;
        if(PhotonNetwork.networkingPeer == null)
        {
            
        }
    
    }
    private static void EnterOfflineRoom(string roomName, RoomOptions roomOptions, bool createdRoom)
    {
        var val_2 = null;
        PhotonNetwork.offlineModeRoom = new Room(roomName:  roomOptions, options:  createdRoom);
        PhotonNetwork.networkingPeer.ChangeLocalID(newID:  1);
        PhotonNetwork.networkingPeer.State = 6;
        PhotonNetwork.networkingPeer.OnStatusChanged(statusCode:  1024);
        typeof(Room).__il2cppRuntimeField_48 = 1;
        if((W3 & 1) != 0)
        {
                NetworkingPeer.SendMonoMessage(methodString:  0, parameters:  5);
        }
        
        NetworkingPeer.SendMonoMessage(methodString:  0, parameters:  12);
    }
    public static bool JoinLobby()
    {
        return PhotonNetwork.JoinLobby(typedLobby:  null);
    }
    public static bool JoinLobby(TypedLobby typedLobby)
    {
        TypedLobby val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_4 = X1;
        if((PhotonNetwork.connected != false) && (PhotonNetwork.Server == 0))
        {
                if(val_4 == 0)
        {
                val_5 = null;
            val_5 = null;
            val_4 = TypedLobby.Default;
        }
        
            val_6 = null;
            val_6 = null;
            if((PhotonNetwork.networkingPeer.OpJoinLobby(lobby:  val_4)) != false)
        {
                val_7 = null;
            val_7 = null;
            PhotonNetwork.networkingPeer.lobby = val_4;
            val_8 = 1;
            return (bool)val_8;
        }
        
        }
        
        val_8 = 0;
        return (bool)val_8;
    }
    public static bool LeaveLobby()
    {
        var val_3;
        if(PhotonNetwork.connected == false)
        {
                return false;
        }
        
        if(PhotonNetwork.Server != 0)
        {
                return false;
        }
        
        val_3 = null;
        val_3 = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.OpLeaveLobby();
        }
        
        return PhotonNetwork.networkingPeer.OpLeaveLobby();
    }
    public static bool LeaveRoom(bool becomeInactive = True)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = W1;
        val_11 = null;
        if(PhotonNetwork.offlineMode == false)
        {
            goto label_3;
        }
        
        val_11 = null;
        PhotonNetwork.offlineModeRoom = 0;
        val_12 = 1;
        NetworkingPeer.SendMonoMessage(methodString:  0, parameters:  1);
        goto label_8;
        label_3:
        if(PhotonNetwork.room == null)
        {
            goto label_11;
        }
        
        if((val_10 & 1) == 0)
        {
            goto label_12;
        }
        
        Room val_5 = PhotonNetwork.room;
        var val_6 = (PhotonNetwork.__il2cppRuntimeField_cctor_finished != 0) ? 1 : 0;
        goto label_23;
        label_11:
        ClientState val_7 = PhotonNetwork.connectionStateDetailed;
        string val_8 = 0 + "PhotonNetwork.room is null. You don\'t have to call LeaveRoom() when you\'re not in one. State: "("PhotonNetwork.room is null. You don\'t have to call LeaveRoom() when you\'re not in one. State: ");
        UnityEngine.Debug.LogWarning(message:  0);
        goto label_23;
        label_12:
        val_10 = 0;
        label_23:
        val_13 = null;
        val_13 = null;
        bool val_10 = PhotonNetwork.networkingPeer.OpLeaveRoom(becomeInactive:  val_10 & 1);
        val_12 = val_10;
        label_8:
        val_10 = val_12;
        return (bool)val_10;
    }
    public static bool GetCustomRoomList(TypedLobby typedLobby, string sqlLobbyFilter)
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.OpGetGameList(lobby:  sqlLobbyFilter, queryData:  X2);
        }
        
        return PhotonNetwork.networkingPeer.OpGetGameList(lobby:  sqlLobbyFilter, queryData:  X2);
    }
    public static RoomInfo[] GetRoomList()
    {
        var val_3;
        var val_4;
        NetworkingPeer val_5;
        RoomInfo[] val_6;
        val_3 = 1152921504973725696;
        if(PhotonNetwork.offlineMode == true)
        {
            goto label_6;
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = PhotonNetwork.networkingPeer;
        if(val_5 == null)
        {
            goto label_6;
        }
        
        val_5 = PhotonNetwork.networkingPeer;
        if(val_5 == null)
        {
            goto label_9;
        }
        
        val_6 = mem[PhotonNetwork.networkingPeer + 320];
        val_6 = PhotonNetwork.networkingPeer.mGameListCopy;
        return (RoomInfo[])val_6;
        label_6:
        val_3 = null;
        val_6 = val_3;
        return (RoomInfo[])val_6;
        label_9:
    }
    public static void SetPlayerCustomProperties(ExitGames.Client.Photon.Hashtable customProperties)
    {
        var val_5;
        ExitGames.Client.Photon.Hashtable val_13;
        object val_14;
        ExitGames.Client.Photon.Hashtable val_15;
        var val_16;
        val_13 = X1;
        if(val_13 != 0)
        {
            goto label_15;
        }
        
        ExitGames.Client.Photon.Hashtable val_1 = null;
        val_13 = val_1;
        val_1 = new ExitGames.Client.Photon.Hashtable();
        PhotonPlayer val_2 = PhotonNetwork.player;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_4 = val_2.<CustomProperties>k__BackingField.Keys.GetEnumerator();
        label_11:
        if((0 & 1) == 0)
        {
            goto label_7;
        }
        
        val_14;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_10;
        }
        
        }
        
        val_14 = 0;
        label_10:
        set_Item(key:  val_14, value:  0);
        goto label_11;
        label_7:
        val_15 = 0;
        val_16 = 1;
        label_15:
        if(PhotonNetwork.room != null)
        {
                Room val_9 = PhotonNetwork.room;
            PhotonNetwork.player.SetCustomProperties(propertiesToSet:  val_13, expectedValues:  0, webForward:  false);
            return;
        }
        
        PhotonNetwork.player.InternalCacheProperties(properties:  val_13);
    }
    public static void RemovePlayerCustomProperties(string[] customPropertiesToDelete)
    {
        var val_9;
        ExitGames.Client.Photon.Hashtable val_10;
        val_9 = X1;
        if((val_9 != 0) && ((X1 + 24) != 0))
        {
                PhotonPlayer val_1 = PhotonNetwork.player;
            if((val_1.<CustomProperties>k__BackingField) != null)
        {
                if((X1 + 24) <= 0)
        {
                return;
        }
        
            do
        {
            var val_2 = val_9 + 0;
            PhotonPlayer val_3 = PhotonNetwork.player;
            val_10 = val_3.<CustomProperties>k__BackingField;
            if((val_10.ContainsKey(key:  (X1 + 0) + 32)) != false)
        {
                PhotonPlayer val_5 = PhotonNetwork.player;
            val_10 = val_5.<CustomProperties>k__BackingField;
            bool val_6 = val_10.Remove(key:  (X1 + 0) + 32);
        }
        
        }
        while((0 + 1) < (X1 + 24));
        
            return;
        }
        
        }
        
        val_9 = PhotonNetwork.player;
        val_8.<CustomProperties>k__BackingField = new ExitGames.Client.Photon.Hashtable();
    }
    public static bool RaiseEvent(byte eventCode, object eventContent, bool sendReliable, RaiseEventOptions options)
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_12 = X4;
        val_13 = eventContent;
        val_14 = 1152921504973725696;
        if(((val_13 & 255) <= 199) && (PhotonNetwork.inRoom ^ 1 != true))
        {
                val_15 = null;
            val_15 = null;
            options = options & 1;
            val_12 = ???;
            val_13 = ???;
            val_14 = ???;
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  0);
            return false;
        }
    
    }
    public static int AllocateViewID()
    {
        int val_2 = PhotonNetwork.AllocateViewID(ownerId:  PhotonNetwork.player);
        PhotonNetwork.manuallyAllocatedViewIds.Add(item:  val_2);
        return val_2;
    }
    public static int AllocateSceneViewID()
    {
        int val_4;
        if(PhotonNetwork.isMasterClient != false)
        {
                val_4 = PhotonNetwork.AllocateViewID(ownerId:  366878720);
            PhotonNetwork.manuallyAllocatedViewIds.Add(item:  val_4);
            return (int)val_4;
        }
        
        UnityEngine.Debug.LogError(message:  0);
        val_4 = 0;
        return (int)val_4;
    }
    private static int AllocateViewID(int ownerId)
    {
        var val_17;
        var val_18;
        int val_20;
        int val_21;
        int val_22;
        var val_23;
        System.Collections.Generic.List<System.Int32> val_24;
        var val_25;
        var val_26;
        int val_28;
        var val_29;
        var val_30;
        object val_31;
        val_17 = null;
        if(W1 == 0)
        {
            goto label_1;
        }
        
        val_18 = null;
        var val_16 = 0;
        goto label_4;
        label_19:
        val_18 = null;
        label_4:
        val_18 = null;
        val_16 = val_16 + 1;
        val_20 = PhotonNetwork.MAX_VIEW_IDS;
        if(val_16 >= val_20)
        {
            goto label_7;
        }
        
        val_18 = null;
        val_20 = PhotonNetwork.MAX_VIEW_IDS;
        int val_4 = PhotonNetwork.lastUsedViewSubId + 1;
        val_21 = val_4 - ((val_4 / val_20) * val_20);
        if(val_21 == 0)
        {
            goto label_19;
        }
        
        val_22 = val_21 + (PhotonNetwork.MAX_VIEW_IDS * W1);
        if((ContainsKey(key:  val_22)) == true)
        {
            goto label_19;
        }
        
        val_23 = null;
        val_23 = null;
        val_24 = PhotonNetwork.manuallyAllocatedViewIds;
        if((val_24.Contains(item:  val_22)) == true)
        {
            goto label_19;
        }
        
        val_25 = null;
        val_25 = null;
        PhotonNetwork.lastUsedViewSubId = val_21;
        return val_22;
        label_1:
        val_26 = null;
        val_21 = 1152921512420988064;
        label_35:
        val_26 = null;
        val_24 = 0 + 1;
        val_28 = PhotonNetwork.MAX_VIEW_IDS;
        if(val_24 >= val_28)
        {
            goto label_27;
        }
        
        val_26 = null;
        val_28 = PhotonNetwork.MAX_VIEW_IDS;
        int val_10 = PhotonNetwork.lastUsedViewSubIdStatic + 1;
        val_22 = val_10 - ((val_10 / val_28) * val_28);
        if(val_22 == 0)
        {
            goto label_35;
        }
        
        val_29 = null;
        if((ContainsKey(key:  val_22)) == true)
        {
            goto label_35;
        }
        
        val_29 = null;
        PhotonNetwork.lastUsedViewSubIdStatic = val_22;
        return val_22;
        label_7:
        val_30 = W1;
        val_31 = "AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.";
        goto label_40;
        label_27:
        val_30 = 0;
        val_31 = "AllocateViewID() failed. Room (user {0}) is out of \'scene\' viewIDs. It seems all available are in use.";
        label_40:
        System.Exception val_15 = new System.Exception(message:  System.String.Format(format:  0, arg0:  val_31));
    }
    private static int[] AllocateSceneViewIDs(int countOfNewViews)
    {
        if(W1 < 1)
        {
                return (System.Int32[])null;
        }
        
        var val_2 = 0;
        do
        {
            System.Int32[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = PhotonNetwork.AllocateViewID(ownerId:  366878720);
            val_2 = val_2 + 1;
        }
        while(W1 != val_2);
        
        return (System.Int32[])null;
    }
    public static void UnAllocateViewID(int viewID)
    {
        int val_5;
        System.Collections.Generic.Dictionary<System.Int32, PhotonView> val_6;
        var val_7;
        var val_8;
        val_5 = W1;
        val_6 = 1152921504973725696;
        val_7 = null;
        val_7 = null;
        bool val_1 = PhotonNetwork.manuallyAllocatedViewIds.Remove(item:  val_5);
        if((ContainsKey(key:  val_5)) == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_6 = mem[PhotonNetwork.networkingPeer + 472];
        val_6 = PhotonNetwork.networkingPeer.photonViewList;
        PhotonView val_3 = Item[val_5];
        val_5 = System.String.Format(format:  0, arg0:  "UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}", arg1:  val_5);
        UnityEngine.Debug.LogWarning(message:  0);
    }
    public static UnityEngine.GameObject Instantiate(string prefabName, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, byte group)
    {
        return PhotonNetwork.Instantiate(prefabName:  null, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, group:  group, data:  W2);
    }
    public static UnityEngine.GameObject Instantiate(string prefabName, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, byte group, object[] data)
    {
        ClientState val_8;
        byte val_25;
        var val_26;
        UnityEngine.GameObject val_28;
        var val_29;
        string val_31;
        var val_32;
        var val_34;
        var val_35;
        val_25 = data;
        if(PhotonNetwork.connected == false)
        {
            goto label_9;
        }
        
        val_26 = null;
        val_26 = null;
        if(PhotonNetwork.InstantiateInRoomOnly == false)
        {
            goto label_6;
        }
        
        if(PhotonNetwork.inRoom == false)
        {
            goto label_9;
        }
        
        val_26 = null;
        label_6:
        val_26 = null;
        if(PhotonNetwork.UsePrefabCache == false)
        {
            goto label_12;
        }
        
        if((PhotonNetwork.PrefabCache.TryGetValue(key:  group, value: out  0)) == true)
        {
            goto label_23;
        }
        
        label_12:
        System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_7 = UnityEngine.Resources.Load(path:  0, systemTypeInstance:  group);
        val_28 = 0;
        if(val_7 != null)
        {
                val_28 = val_7;
            if(null != null)
        {
                val_28 = 0;
        }
        
        }
        
        val_29 = null;
        val_29 = null;
        if(PhotonNetwork.UsePrefabCache != false)
        {
                PhotonNetwork.PrefabCache.Add(key:  group, value:  val_28);
        }
        
        label_23:
        if(0 != val_28)
        {
            goto label_29;
        }
        
        val_31 = "Failed to Instantiate prefab: ";
        val_32 = ". Verify the Prefab is in a Resources folder (and not in a subfolder)";
        goto label_32;
        label_9:
        val_25 = "Failed to Instantiate prefab: ";
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_25;
        typeof(System.Object[]).__il2cppRuntimeField_28 = group;
        typeof(System.Object[]).__il2cppRuntimeField_30 = ". Client should be in a room. Current connectionStateDetailed: ";
        val_8 = PhotonNetwork.connectionStateDetailed;
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_8;
        string val_11 = +0;
        goto label_50;
        label_29:
        if(0 != (val_28.GetComponent<PhotonView>()))
        {
            goto label_54;
        }
        
        val_31 = "Failed to Instantiate prefab:";
        val_32 = ". Prefab must have a PhotonView component.";
        label_32:
        string val_14 = 0 + val_31 + group;
        label_50:
        UnityEngine.Debug.LogError(message:  0);
        return 0;
        label_54:
        PhotonView[] val_15 = Extensions.GetPhotonViewsInChildren(go:  0);
        val_34 = 0;
        goto label_62;
        label_70:
        var val_16 = null + ((X26) << 2);
        val_34 = 1;
        mem2[0] = null;
        label_62:
        val_35 = null;
        int val_20 = PhotonNetwork.AllocateViewID(ownerId:  PhotonNetwork.player);
        if(null != null)
        {
            goto label_70;
        }
        
        goto label_70;
    }
    public static UnityEngine.GameObject InstantiateSceneObject(string prefabName, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, byte group, object[] data)
    {
        ClientState val_10;
        byte val_23;
        var val_24;
        var val_25;
        UnityEngine.GameObject val_27;
        var val_28;
        string val_30;
        var val_31;
        var val_33;
        UnityEngine.GameObject val_34;
        PhotonPlayer val_35;
        var val_36;
        val_23 = data;
        if(PhotonNetwork.connected == false)
        {
            goto label_9;
        }
        
        val_24 = null;
        val_24 = null;
        if(PhotonNetwork.InstantiateInRoomOnly == false)
        {
            goto label_6;
        }
        
        if(PhotonNetwork.inRoom == false)
        {
            goto label_9;
        }
        
        val_24 = null;
        label_6:
        if(PhotonNetwork.isMasterClient == false)
        {
            goto label_12;
        }
        
        val_25 = null;
        val_25 = null;
        if(PhotonNetwork.UsePrefabCache == false)
        {
            goto label_15;
        }
        
        if((PhotonNetwork.PrefabCache.TryGetValue(key:  group, value: out  0)) == true)
        {
            goto label_26;
        }
        
        label_15:
        System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_9 = UnityEngine.Resources.Load(path:  0, systemTypeInstance:  group);
        val_27 = 0;
        if(val_9 != null)
        {
                val_27 = val_9;
            if(null != null)
        {
                val_27 = 0;
        }
        
        }
        
        val_28 = null;
        val_28 = null;
        if(PhotonNetwork.UsePrefabCache != false)
        {
                PhotonNetwork.PrefabCache.Add(key:  group, value:  val_27);
        }
        
        label_26:
        if(0 != val_27)
        {
            goto label_32;
        }
        
        val_30 = "Failed to InstantiateSceneObject prefab: ";
        val_31 = ". Verify the Prefab is in a Resources folder (and not in a subfolder)";
        goto label_56;
        label_9:
        val_23 = "Failed to InstantiateSceneObject prefab: ";
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_23;
        typeof(System.Object[]).__il2cppRuntimeField_28 = group;
        typeof(System.Object[]).__il2cppRuntimeField_30 = ". Client should be in a room. Current connectionStateDetailed: ";
        val_10 = PhotonNetwork.connectionStateDetailed;
        label_88:
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_10;
        string val_13 = +0;
        goto label_53;
        label_12:
        val_30 = "Failed to InstantiateSceneObject prefab: ";
        val_31 = ". Client is not the MasterClient in this room.";
        goto label_56;
        label_32:
        if(0 != (val_27.GetComponent<PhotonView>()))
        {
            goto label_60;
        }
        
        val_30 = "Failed to InstantiateSceneObject prefab:";
        val_31 = ". Prefab must have a PhotonView component.";
        label_56:
        string val_16 = 0 + val_30 + group;
        label_53:
        UnityEngine.Debug.LogError(message:  0);
        return 0;
        label_60:
        PhotonView[] val_17 = Extensions.GetPhotonViewsInChildren(go:  0);
        System.Int32[] val_18 = PhotonNetwork.AllocateSceneViewIDs(countOfNewViews:  366878720);
        if(val_18 == null)
        {
            goto label_70;
        }
        
        val_33 = null;
        val_33 = null;
        if(PhotonNetwork.networkingPeer == null)
        {
            goto label_74;
        }
        
        val_34 = val_27;
        val_35 = PhotonNetwork.networkingPeer.LocalPlayer;
        goto label_75;
        label_70:
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Failed to InstantiateSceneObject prefab: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = group;
        typeof(System.Object[]).__il2cppRuntimeField_30 = ". No ViewIDs are free to use. Max is: ";
        val_36 = null;
        val_36 = null;
        val_10 = PhotonNetwork.MAX_VIEW_IDS;
        goto label_88;
        label_74:
        val_34 = val_27;
        val_35 = 0.LocalPlayer;
        label_75:
        UnityEngine.GameObject val_22 = PhotonNetwork.networkingPeer.DoInstantiate(evData:  PhotonNetwork.networkingPeer.SendInstantiate(prefabName:  group, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, group:  val_23, viewIDs:  val_18, data:  X3, isGlobalObject:  true), photonPlayer:  val_35, resourceGameObject:  val_34);
        return 0;
    }
    public static int GetPing()
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.RoundTripTime;
        }
        
        return PhotonNetwork.networkingPeer.RoundTripTime;
    }
    public static void FetchServerTimestamp()
    {
        var val_1;
        NetworkingPeer val_2;
        val_1 = null;
        val_1 = null;
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 != null)
        {
                val_2.FetchServerTimestamp();
            return;
        }
    
    }
    public static void SendOutgoingCommands()
    {
        NetworkingPeer val_4;
        var val_5;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        do
        {
            val_5 = null;
            val_5 = null;
            val_4 = PhotonNetwork.networkingPeer;
        }
        while(val_4.SendOutgoingCommands() == true);
    
    }
    public static bool CloseConnection(PhotonPlayer kickPlayer)
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = X1;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return false;
        }
        
        if(PhotonNetwork.player.IsMasterClient == false)
        {
            goto label_7;
        }
        
        if(val_6 == 0)
        {
            goto label_8;
        }
        
        object val_5 = new System.Object();
        typeof(System.Int32[]).__il2cppRuntimeField_20 = X1 + 16;
        typeof(RaiseEventOptions).__il2cppRuntimeField_18 = null;
        val_7 = null;
        val_7 = null;
        val_6 = ???;
        goto typeof(NetworkingPeer).__il2cppRuntimeField_2E0;
        label_7:
        val_8 = "CloseConnection: Only the masterclient can kick another player.";
        goto label_17;
        label_8:
        val_8 = "CloseConnection: No such player connected!";
        label_17:
        UnityEngine.Debug.LogError(message:  0);
        return false;
    }
    public static bool SetMasterClient(PhotonPlayer masterClientPlayer)
    {
        var val_10;
        var val_11;
        if(PhotonNetwork.inRoom != false)
        {
                if(PhotonNetwork.VerifyCanUseNetwork() != false)
        {
                if(PhotonNetwork.offlineMode == false)
        {
            goto label_9;
        }
        
        }
        
        }
        
        val_10 = null;
        val_10 = null;
        if(PhotonNetwork.logLevel == 1)
        {
                UnityEngine.Debug.Log(message:  0);
        }
        
        var val_10 = 0;
        label_26:
        val_10 = val_10 & 1;
        return (bool)val_10;
        label_9:
        Room val_4 = PhotonNetwork.room;
        Add(key:  248, value:  X1 + 16);
        val_11 = null;
        val_11 = null;
        Add(key:  248, value:  PhotonNetwork.networkingPeer.mMasterClientId);
        bool val_8 = PhotonNetwork.networkingPeer.OpSetPropertiesOfRoom(gameProperties:  new ExitGames.Client.Photon.Hashtable(), expectedProperties:  new ExitGames.Client.Photon.Hashtable(), webForward:  false);
        goto label_26;
    }
    public static void Destroy(PhotonView targetView)
    {
        var val_5;
        if(0 != X1)
        {
                val_5 = null;
            val_5 = null;
            PhotonNetwork.networkingPeer.RemoveInstantiatedGO(go:  X1.gameObject, localOnly:  (~PhotonNetwork.inRoom) & 1);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  0);
    }
    public static void Destroy(UnityEngine.GameObject targetGo)
    {
        null = null;
        PhotonNetwork.networkingPeer.RemoveInstantiatedGO(go:  X1, localOnly:  (~PhotonNetwork.inRoom) & 1);
    }
    public static void DestroyPlayerObjects(PhotonPlayer targetPlayer)
    {
        if(PhotonNetwork.player == null)
        {
                UnityEngine.Debug.LogError(message:  0);
        }
        
        PhotonNetwork.DestroyPlayerObjects(targetPlayerId:  366878720);
    }
    public static void DestroyPlayerObjects(int targetPlayerId)
    {
        int val_9;
        var val_10;
        val_9 = W1;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        if(PhotonNetwork.player.IsMasterClient == true)
        {
            goto label_7;
        }
        
        PhotonPlayer val_5 = PhotonNetwork.player;
        if(val_5.actorID != val_9)
        {
            goto label_11;
        }
        
        label_7:
        val_10 = null;
        val_10 = null;
        PhotonNetwork.networkingPeer.DestroyPlayerObjects(playerId:  val_9, localOnly:  false);
        return;
        label_11:
        bool val_7 = PhotonNetwork.isMasterClient;
        val_9 = 0 + "DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone\'s. This is master: "("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone\'s. This is master: ");
        UnityEngine.Debug.LogError(message:  0);
    }
    public static void DestroyAll()
    {
        var val_2;
        if(PhotonNetwork.isMasterClient != false)
        {
                val_2 = null;
            val_2 = null;
            PhotonNetwork.networkingPeer.DestroyAll(localOnly:  false);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  0);
    }
    public static void RemoveRPCs(PhotonPlayer targetPlayer)
    {
        var val_4;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        if((X1 + 40) == 0)
        {
                if(PhotonNetwork.isMasterClient == false)
        {
            goto label_8;
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        PhotonNetwork.networkingPeer.OpCleanRpcBuffer(actorNumber:  X1 + 16);
        return;
        label_8:
        UnityEngine.Debug.LogError(message:  0);
    }
    public static void RemoveRPCs(PhotonView targetPhotonView)
    {
        var val_2;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        PhotonNetwork.networkingPeer.CleanRpcBufferIfMine(view:  X1);
    }
    public static void RemoveRPCsInGroup(int targetGroup)
    {
        var val_2;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        PhotonNetwork.networkingPeer.RemoveRPCsInGroup(group:  W1);
    }
    internal static void RPC(PhotonView view, string methodName, PhotonTargets target, bool encrypt, bool reliable, object[] parameters)
    {
        NetworkingPeer val_15;
        var val_16;
        var val_17;
        var val_19;
        bool val_20;
        bool val_21;
        PhotonTargets val_22;
        PhotonView val_23;
        string val_24;
        PhotonPlayer val_25;
        string val_26;
        var val_27;
        var val_28;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        if(PhotonNetwork.room == null)
        {
            goto label_6;
        }
        
        val_16 = null;
        val_16 = null;
        if(PhotonNetwork.networkingPeer == null)
        {
            goto label_9;
        }
        
        Room val_3 = PhotonNetwork.room;
        val_17 = null;
        if(W9 != 0)
        {
            goto label_13;
        }
        
        val_17 = null;
        if(PhotonNetwork.networkingPeer == null)
        {
                val_17 = null;
        }
        
        if((encrypt != true) || (PhotonNetwork.networkingPeer.hasSwitchedMC == false))
        {
            goto label_18;
        }
        
        val_19 = null;
        val_15 = PhotonNetwork.masterClient;
        val_20 = reliable;
        val_21 = parameters & 1;
        val_22 = 1;
        val_23 = methodName;
        val_24 = target;
        val_25 = val_15;
        goto label_22;
        label_6:
        val_26 = "RPCs can only be sent in rooms. Call of \"";
        val_27 = "\" gets executed locally only, if at all.";
        goto label_25;
        label_9:
        val_26 = "Could not execute RPC ";
        val_27 = ". Possible scene loading in progress?";
        label_25:
        string val_8 = 0 + val_26 + target;
        UnityEngine.Debug.LogWarning(message:  0);
        return;
        label_18:
        label_13:
        val_28 = null;
        val_15 = PhotonNetwork.networkingPeer;
        val_25 = 0;
        val_20 = reliable;
        val_21 = parameters & 1;
        val_23 = methodName;
        val_24 = target;
        val_22 = encrypt;
        label_22:
        val_15.RPC(view:  val_23, methodName:  val_24, target:  val_22, player:  val_25, encrypt:  val_20, reliable:  val_21, parameters:  X6);
    }
    internal static void RPC(PhotonView view, string methodName, PhotonPlayer targetPlayer, bool encrpyt, bool reliable, object[] parameters)
    {
        var val_8;
        var val_9;
        NetworkingPeer val_10;
        string val_11;
        var val_12;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        if(PhotonNetwork.room == null)
        {
            goto label_6;
        }
        
        if(PhotonNetwork.player == null)
        {
                val_8 = 0 + "RPC can\'t be sent to target PhotonPlayer being null! Did not send \""("RPC can\'t be sent to target PhotonPlayer being null! Did not send \"") + targetPlayer;
            UnityEngine.Debug.LogError(message:  0);
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = PhotonNetwork.networkingPeer;
        if(val_10 == null)
        {
            goto label_16;
        }
        
        val_10 = PhotonNetwork.networkingPeer;
        if(val_10 == null)
        {
                val_10 = 0;
        }
        
        val_10.RPC(view:  methodName, methodName:  targetPlayer, target:  1, player:  encrpyt, encrypt:  reliable, reliable:  parameters & 1, parameters:  X6);
        return;
        label_6:
        val_11 = "RPCs can only be sent in rooms. Call of \"";
        val_12 = "\" gets executed locally only, if at all.";
        goto label_22;
        label_16:
        val_11 = "Could not execute RPC ";
        val_12 = ". Possible scene loading in progress?";
        label_22:
        string val_7 = 0 + val_11 + targetPlayer;
        UnityEngine.Debug.LogWarning(message:  0);
    }
    public static void CacheSendMonoMessageTargets(System.Type type)
    {
        System.Type val_2;
        System.Type val_3;
        val_2 = X1;
        val_3 = null;
        if(val_2 == 0)
        {
                val_3 = null;
            val_2 = PhotonNetwork.SendMonoMessageTargetType;
        }
        
        PhotonNetwork.SendMonoMessageTargets = PhotonNetwork.FindGameObjectsWithComponent(type:  val_3);
    }
    public static System.Collections.Generic.HashSet<UnityEngine.GameObject> FindGameObjectsWithComponent(System.Type type)
    {
        var val_7;
        var val_8;
        UnityEngine.Object[] val_2 = UnityEngine.Object.FindObjectsOfType(type:  0);
        val_7 = 0;
        if(val_2 != null)
        {
                val_7 = val_2;
            if(val_7 == null)
        {
                val_7 = 0;
        }
        
        }
        
        val_8 = 0;
        goto label_5;
        label_16:
        val_8 = 1;
        label_5:
        if(val_8 >= 7254272)
        {
                return (System.Collections.Generic.HashSet<UnityEngine.GameObject>)new System.Collections.Generic.HashSet<UnityEngine.GameObject>();
        }
        
        var val_4 = val_7 + 8;
        if(0 == ((val_7 + 8) + 32))
        {
            goto label_16;
        }
        
        bool val_7 = Add(item:  (val_7 + 8) + 32.gameObject);
        goto label_16;
    }
    [System.ObsoleteAttribute]
    public static void SetReceivingEnabled(int group, bool enabled)
    {
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        var val_2 = W2 & 1;
        PhotonNetwork.SetInterestGroups(group:  0, enabled:  enabled);
    }
    public static void SetInterestGroups(byte group, bool enabled)
    {
        var val_4;
        var val_5;
        System.Byte[] val_6;
        System.Byte[] val_7;
        var val_8;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        typeof(System.Byte[]).__il2cppRuntimeField_20 = enabled;
        val_4 = null;
        if((W2 & 1) != 0)
        {
                val_5 = null;
            val_6 = 0;
            val_7 = null;
        }
        else
        {
                val_8 = null;
            val_7 = 0;
            val_6 = null;
        }
        
        PhotonNetwork.networkingPeer.SetInterestGroups(disableGroups:  val_6, enableGroups:  val_7);
    }
    [System.ObsoleteAttribute]
    public static void SetReceivingEnabled(int[] enableGroups, int[] disableGroups)
    {
        System.Byte[] val_2;
        System.Byte[] val_3;
        var val_4;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        if(disableGroups != null)
        {
                val_2 = null;
            System.Array.Copy(sourceArray:  0, destinationArray:  disableGroups, length:  460851360);
        }
        else
        {
                val_2 = 0;
        }
        
        if(X2 != 0)
        {
                val_3 = null;
            System.Array.Copy(sourceArray:  0, destinationArray:  X2, length:  460851360);
        }
        else
        {
                val_3 = 0;
        }
        
        val_4 = null;
        val_4 = null;
        PhotonNetwork.networkingPeer.SetInterestGroups(disableGroups:  val_3, enableGroups:  val_2);
    }
    public static void SetInterestGroups(byte[] disableGroups, byte[] enableGroups)
    {
        var val_2;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        PhotonNetwork.networkingPeer.SetInterestGroups(disableGroups:  enableGroups, enableGroups:  X2);
    }
    [System.ObsoleteAttribute]
    public static void SetSendingEnabled(int group, bool enabled)
    {
        var val_1 = W2 & 1;
        PhotonNetwork.SetSendingEnabled(group:  0, enabled:  enabled);
    }
    public static void SetSendingEnabled(byte group, bool enabled)
    {
        var val_3;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        PhotonNetwork.networkingPeer.SetSendingEnabled(group:  enabled, enabled:  W2 & 1);
    }
    [System.ObsoleteAttribute]
    public static void SetSendingEnabled(int[] enableGroups, int[] disableGroups)
    {
        var val_1;
        System.Byte[] val_2;
        if(disableGroups != null)
        {
                val_1 = null;
            System.Array.Copy(sourceArray:  0, destinationArray:  disableGroups, length:  460851360);
        }
        else
        {
                val_1 = 0;
        }
        
        if(X2 != 0)
        {
                val_2 = null;
            System.Array.Copy(sourceArray:  0, destinationArray:  X2, length:  460851360);
        }
        else
        {
                val_2 = 0;
        }
        
        PhotonNetwork.SetSendingEnabled(disableGroups:  null, enableGroups:  val_2);
    }
    public static void SetSendingEnabled(byte[] disableGroups, byte[] enableGroups)
    {
        var val_2;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        PhotonNetwork.networkingPeer.SetSendingEnabled(disableGroups:  enableGroups, enableGroups:  X2);
    }
    public static void SetLevelPrefix(short prefix)
    {
        var val_2;
        if(PhotonNetwork.VerifyCanUseNetwork() == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        PhotonNetwork.networkingPeer.SetLevelPrefix(prefix:  W1);
    }
    public static void LoadLevel(int levelNumber)
    {
        var val_2;
        if(PhotonNetwork.automaticallySyncScene != false)
        {
                val_2 = null;
            val_2 = null;
            PhotonNetwork.networkingPeer.SetLevelInPropsIfSynced(levelId:  W1, asyncLoading:  false);
        }
        
        PhotonNetwork.isMessageQueueRunning = false;
        PhotonNetwork.networkingPeer.loadingLevelAndPausedNetwork = true;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneBuildIndex:  0);
    }
    public static UnityEngine.AsyncOperation LoadLevelAsync(int levelNumber)
    {
        var val_3;
        if(PhotonNetwork.automaticallySyncScene != false)
        {
                val_3 = null;
            val_3 = null;
            PhotonNetwork.networkingPeer.SetLevelInPropsIfSynced(levelId:  W1, asyncLoading:  true);
        }
        
        PhotonNetwork.isMessageQueueRunning = false;
        PhotonNetwork.networkingPeer.loadingLevelAndPausedNetwork = true;
        return (UnityEngine.AsyncOperation)UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneBuildIndex:  0, mode:  W1);
    }
    public static void LoadLevel(string levelName)
    {
        var val_2;
        if(PhotonNetwork.automaticallySyncScene != false)
        {
                val_2 = null;
            val_2 = null;
            PhotonNetwork.networkingPeer.SetLevelInPropsIfSynced(levelId:  X1, asyncLoading:  false);
        }
        
        PhotonNetwork.isMessageQueueRunning = false;
        PhotonNetwork.networkingPeer.loadingLevelAndPausedNetwork = true;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  0);
    }
    public static UnityEngine.AsyncOperation LoadLevelAsync(string levelName)
    {
        var val_2;
        if(PhotonNetwork.automaticallySyncScene != false)
        {
                val_2 = null;
            val_2 = null;
            PhotonNetwork.networkingPeer.SetLevelInPropsIfSynced(levelId:  X1, asyncLoading:  true);
        }
        
        PhotonNetwork.isMessageQueueRunning = false;
        PhotonNetwork.networkingPeer.loadingLevelAndPausedNetwork = true;
        return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  0, mode:  X1);
    }
    public static bool WebRpc(string name, object parameters)
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.WebRpc(uriPath:  parameters, parameters:  X2);
        }
        
        return PhotonNetwork.networkingPeer.WebRpc(uriPath:  parameters, parameters:  X2);
    }
    private static int <PhotonNetwork>m__0()
    {
        null = null;
        return (int)PhotonNetwork.startupStopwatch.ElapsedMilliseconds;
    }

}
