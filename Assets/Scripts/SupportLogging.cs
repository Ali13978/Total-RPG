using UnityEngine;
public class SupportLogging : MonoBehaviour
{
    // Fields
    public bool LogTrafficStats;
    
    // Methods
    public SupportLogging()
    {
    
    }
    public void Start()
    {
        if(this.LogTrafficStats == false)
        {
                return;
        }
        
        this.InvokeRepeating(methodName:  "LogStats", time:  10f, repeatRate:  10f);
    }
    protected void OnApplicationPause(bool pause)
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = "SupportLogger OnApplicationPause: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = pause;
        typeof(System.Object[]).__il2cppRuntimeField_29 = 30786715;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " connected: ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = PhotonNetwork.connected;
        typeof(System.Object[]).__il2cppRuntimeField_39 = 30786731;
        string val_4 = +0;
        UnityEngine.Debug.Log(message:  0);
    }
    public void OnApplicationQuit()
    {
        this.CancelInvoke();
    }
    public void LogStats()
    {
        if(this.LogTrafficStats == false)
        {
                return;
        }
        
        string val_1 = PhotonNetwork.NetworkStatisticsToString();
        string val_2 = 0 + "SupportLogger ";
        UnityEngine.Debug.Log(message:  0);
    }
    private void LogBasics()
    {
        var val_12;
        string val_13;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        System.Text.StringBuilder val_2 = AppendFormat(format:  "SupportLogger Info: PUN {0}: ", arg0:  "1.90");
        val_12 = null;
        val_12 = null;
        System.Text.StringBuilder val_6 = AppendFormat(format:  "AppID: {0}*** GameVersion: {1} PeerId: {2} ", arg0:  Substring(startIndex:  0, length:  8), arg1:  PhotonNetwork.networkingPeer.AppVersion, arg2:  PhotonNetwork.networkingPeer.PeerID);
        System.Text.StringBuilder val_9 = AppendFormat(format:  "Server: {0}. Region: {1} ", arg0:  PhotonNetwork.ServerAddress, arg1:  PhotonNetwork.networkingPeer.CloudRegion);
        if(null != 0)
        {
                val_13 = "HostType: {0} ";
            System.Text.StringBuilder val_10 = AppendFormat(format:  val_13, arg0:  PhotonNetwork.PhotonServerSettings.HostType);
        }
        else
        {
                val_13 = "HostType: {0} ";
            System.Text.StringBuilder val_11 = AppendFormat(format:  val_13, arg0:  PhotonNetwork.PhotonServerSettings.HostType);
        }
        
        UnityEngine.Debug.Log(message:  0);
    }
    public void OnConnectedToPhoton()
    {
        UnityEngine.Debug.Log(message:  0);
        this.LogBasics();
        if(this.LogTrafficStats == false)
        {
                return;
        }
        
        PhotonNetwork.NetworkStatisticsEnabled = false;
    }
    public void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
        string val_1 = 0 + "SupportLogger OnFailedToConnectToPhoton(" + cause;
        UnityEngine.Debug.Log(message:  0);
        this.LogBasics();
    }
    public void OnJoinedLobby()
    {
        string val_2 = 0 + "SupportLogger OnJoinedLobby(" + PhotonNetwork.lobby;
        UnityEngine.Debug.Log(message:  0);
    }
    public void OnJoinedRoom()
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = "SupportLogger OnJoinedRoom(";
        typeof(System.Object[]).__il2cppRuntimeField_28 = PhotonNetwork.room;
        typeof(System.Object[]).__il2cppRuntimeField_30 = "). ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = PhotonNetwork.lobby;
        typeof(System.Object[]).__il2cppRuntimeField_40 = " GameServer:";
        typeof(System.Object[]).__il2cppRuntimeField_48 = PhotonNetwork.ServerAddress;
        string val_4 = +0;
        UnityEngine.Debug.Log(message:  0);
    }
    public void OnCreatedRoom()
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = "SupportLogger OnCreatedRoom(";
        typeof(System.Object[]).__il2cppRuntimeField_28 = PhotonNetwork.room;
        typeof(System.Object[]).__il2cppRuntimeField_30 = "). ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = PhotonNetwork.lobby;
        typeof(System.Object[]).__il2cppRuntimeField_40 = " GameServer:";
        typeof(System.Object[]).__il2cppRuntimeField_48 = PhotonNetwork.ServerAddress;
        string val_4 = +0;
        UnityEngine.Debug.Log(message:  0);
    }
    public void OnLeftRoom()
    {
        UnityEngine.Debug.Log(message:  0);
    }
    public void OnDisconnectedFromPhoton()
    {
        UnityEngine.Debug.Log(message:  0);
    }

}
