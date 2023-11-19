using UnityEngine;
[Serializable]
public class ServerSettings : ScriptableObject
{
    // Fields
    public string AppID;
    public string VoiceAppID;
    public string ChatAppID;
    public ServerSettings.HostingOption HostType;
    public CloudRegionCode PreferredRegion;
    public CloudRegionFlag EnabledRegions;
    public ExitGames.Client.Photon.ConnectionProtocol Protocol;
    public string ServerAddress;
    public int ServerPort;
    public int VoiceServerPort;
    public bool JoinLobby;
    public bool EnableLobbyStatistics;
    public PhotonLogLevel PunLogging;
    public ExitGames.Client.Photon.DebugLevel NetworkLogging;
    public bool RunInBackground;
    public System.Collections.Generic.List<string> RpcList;
    [UnityEngine.HideInInspector]
    public bool DisableAutoOpenWizard;
    
    // Properties
    public static CloudRegionCode BestRegionCodeInPreferences { get; }
    
    // Methods
    public ServerSettings()
    {
        null = null;
        this.AppID = System.String.Empty;
        this.VoiceAppID = System.String.Empty;
        this.EnabledRegions = 0;
        this.ChatAppID = System.String.Empty;
        this.ServerPort = 5055;
        this.VoiceServerPort = 5055;
        this.NetworkLogging = 257;
        this.ServerAddress = System.String.Empty;
        this.RpcList = new System.Collections.Generic.List<System.String>();
    }
    public void UseCloudBestRegion(string cloudAppid)
    {
        this.HostType = 4;
        this.AppID = cloudAppid;
    }
    public void UseCloud(string cloudAppid)
    {
        this.HostType = 1;
        this.AppID = cloudAppid;
    }
    public void UseCloud(string cloudAppid, CloudRegionCode code)
    {
        this.AppID = cloudAppid;
        this.HostType = 1;
        this.PreferredRegion = code;
    }
    public void UseMyServer(string serverAddress, int serverPort, string application)
    {
        this.HostType = 2;
        this.ServerPort = serverPort;
        this.AppID = (application == null) ? "master" : application;
        this.ServerAddress = serverAddress;
    }
    public static bool IsAppId(string val)
    {
        return true;
    }
    public static CloudRegionCode get_BestRegionCodeInPreferences()
    {
        return PhotonHandler.BestRegionCodeInPreferences;
    }
    public static void ResetBestRegionCodeInPreferences()
    {
        PhotonHandler.BestRegionCodeInPreferences = 0;
    }
    public override string ToString()
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = "ServerSettings: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = this.HostType;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = this.ServerAddress;
        return (string)+0;
    }

}
