using UnityEngine;
public enum PhotonNetworkingMessage
{
    // Fields
    OnConnectedToPhoton = 0
    ,OnLeftRoom = 1
    ,OnMasterClientSwitched = 2
    ,OnPhotonCreateRoomFailed = 3
    ,OnPhotonJoinRoomFailed = 4
    ,OnCreatedRoom = 5
    ,OnJoinedLobby = 6
    ,OnLeftLobby = 7
    ,OnDisconnectedFromPhoton = 8
    ,OnConnectionFail = 9
    ,OnFailedToConnectToPhoton = 10
    ,OnReceivedRoomListUpdate = 11
    ,OnJoinedRoom = 12
    ,OnPhotonPlayerConnected = 13
    ,OnPhotonPlayerDisconnected = 14
    ,OnPhotonRandomJoinFailed = 15
    ,OnConnectedToMaster = 16
    ,OnPhotonSerializeView = 17
    ,OnPhotonInstantiate = 18
    ,OnPhotonMaxCccuReached = 19
    ,OnPhotonCustomRoomPropertiesChanged = 20
    ,OnPhotonPlayerPropertiesChanged = 21
    ,OnUpdatedFriendList = 22
    ,OnCustomAuthenticationFailed = 23
    ,OnCustomAuthenticationResponse = 24
    ,OnWebRpcResponse = 25
    ,OnOwnershipRequest = 26
    ,OnLobbyStatisticsUpdate = 27
    ,OnPhotonPlayerActivityChanged = 28
    ,OnOwnershipTransfered = 29
    

}