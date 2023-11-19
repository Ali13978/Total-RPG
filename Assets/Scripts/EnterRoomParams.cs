using UnityEngine;
internal class EnterRoomParams
{
    // Fields
    public string RoomName;
    public RoomOptions RoomOptions;
    public TypedLobby Lobby;
    public ExitGames.Client.Photon.Hashtable PlayerProperties;
    public bool OnGameServer;
    public bool CreateIfNotExists;
    public bool RejoinOnly;
    public string[] ExpectedUsers;
    
    // Methods
    public EnterRoomParams()
    {
        this.OnGameServer = true;
    }

}
