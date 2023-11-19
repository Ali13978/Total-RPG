using UnityEngine;
public interface IPunCallbacks
{
    // Methods
    public abstract void OnConnectedToPhoton(); // 0
    public abstract void OnLeftRoom(); // 0
    public abstract void OnMasterClientSwitched(PhotonPlayer newMasterClient); // 0
    public abstract void OnPhotonCreateRoomFailed(object[] codeAndMsg); // 0
    public abstract void OnPhotonJoinRoomFailed(object[] codeAndMsg); // 0
    public abstract void OnCreatedRoom(); // 0
    public abstract void OnJoinedLobby(); // 0
    public abstract void OnLeftLobby(); // 0
    public abstract void OnFailedToConnectToPhoton(DisconnectCause cause); // 0
    public abstract void OnConnectionFail(DisconnectCause cause); // 0
    public abstract void OnDisconnectedFromPhoton(); // 0
    public abstract void OnPhotonInstantiate(PhotonMessageInfo info); // 0
    public abstract void OnReceivedRoomListUpdate(); // 0
    public abstract void OnJoinedRoom(); // 0
    public abstract void OnPhotonPlayerConnected(PhotonPlayer newPlayer); // 0
    public abstract void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer); // 0
    public abstract void OnPhotonRandomJoinFailed(object[] codeAndMsg); // 0
    public abstract void OnConnectedToMaster(); // 0
    public abstract void OnPhotonMaxCccuReached(); // 0
    public abstract void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable propertiesThatChanged); // 0
    public abstract void OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps); // 0
    public abstract void OnUpdatedFriendList(); // 0
    public abstract void OnCustomAuthenticationFailed(string debugMessage); // 0
    public abstract void OnCustomAuthenticationResponse(System.Collections.Generic.Dictionary<string, object> data); // 0
    public abstract void OnWebRpcResponse(ExitGames.Client.Photon.OperationResponse response); // 0
    public abstract void OnOwnershipRequest(object[] viewAndPlayer); // 0
    public abstract void OnLobbyStatisticsUpdate(); // 0
    public abstract void OnPhotonPlayerActivityChanged(PhotonPlayer otherPlayer); // 0
    public abstract void OnOwnershipTransfered(object[] viewAndPlayers); // 0

}
