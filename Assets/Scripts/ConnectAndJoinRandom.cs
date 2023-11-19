using UnityEngine;
public class ConnectAndJoinRandom : MonoBehaviour
{
    // Fields
    public bool AutoConnect;
    public byte Version;
    private bool ConnectInUpdate;
    
    // Methods
    public ConnectAndJoinRandom()
    {
        this.AutoConnect = true;
        this.Version = 1;
        this.ConnectInUpdate = true;
    }
    public virtual void Start()
    {
        PhotonNetwork.autoJoinLobby = false;
    }
    public virtual void Update()
    {
        if(this.ConnectInUpdate == false)
        {
                return;
        }
        
        if(this.AutoConnect == false)
        {
                return;
        }
        
        if(PhotonNetwork.connected == true)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  0);
        this.ConnectInUpdate = false;
        int val_3 = SceneManagerHelper.ActiveSceneBuildIndex;
        this = 0 + this.Version + ".";
        bool val_5 = PhotonNetwork.ConnectUsingSettings(gameVersion:  0);
    }
    public virtual void OnConnectedToMaster()
    {
        UnityEngine.Debug.Log(message:  0);
        bool val_1 = PhotonNetwork.JoinRandomRoom();
    }
    public virtual void OnJoinedLobby()
    {
        UnityEngine.Debug.Log(message:  0);
        bool val_1 = PhotonNetwork.JoinRandomRoom();
    }
    public virtual void OnPhotonRandomJoinFailed()
    {
        UnityEngine.Debug.Log(message:  0);
        typeof(RoomOptions).__il2cppRuntimeField_12 = 4;
        bool val_2 = PhotonNetwork.CreateRoom(roomName:  0, roomOptions:  0, typedLobby:  new RoomOptions());
    }
    public virtual void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
        string val_1 = 0 + "Cause: "("Cause: ");
        UnityEngine.Debug.LogError(message:  0);
    }
    public void OnJoinedRoom()
    {
        UnityEngine.Debug.Log(message:  0);
    }

}
