using UnityEngine;
internal class OpJoinRandomRoomParams
{
    // Fields
    public ExitGames.Client.Photon.Hashtable ExpectedCustomRoomProperties;
    public byte ExpectedMaxPlayers;
    public MatchmakingMode MatchingType;
    public TypedLobby TypedLobby;
    public string SqlLobbyFilter;
    public string[] ExpectedUsers;
    
    // Methods
    public OpJoinRandomRoomParams()
    {
    
    }

}
