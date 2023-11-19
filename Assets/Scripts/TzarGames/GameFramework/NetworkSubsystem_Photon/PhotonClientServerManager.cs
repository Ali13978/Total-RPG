using UnityEngine;

namespace TzarGames.GameFramework.NetworkSubsystem_Photon
{
    public class PhotonClientServerManager : MonoBehaviour
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.NetworkSubsystem_Photon.PhotonClientServerManager.DefaultAction defaultAction;
        [UnityEngine.SerializeField]
        private byte maxPlayersPerRoom;
        [UnityEngine.SerializeField]
        private float reconnectDelay;
        [UnityEngine.SerializeField]
        private bool autoConnectWhenDisconnect;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private bool testDisconnection;
        [UnityEngine.SerializeField]
        private float testMinConnectionTime;
        [UnityEngine.SerializeField]
        private float testMaxConnectionTime;
        public float guiDrawMargin;
        [UnityEngine.SerializeField]
        private bool drawGui;
        private TzarGames.GameFramework.NetworkSubsystem_Photon.TzarNetworkConnectionError _lastConnectionError;
        
        // Properties
        public TzarGames.GameFramework.NetworkSubsystem_Photon.TzarNetworkConnectionError LastConnectionError { get; }
        public bool IsDisconnected { get; }
        
        // Methods
        public PhotonClientServerManager()
        {
            this.maxPlayersPerRoom = 16;
            this.reconnectDelay = 2f;
            this.testMaxConnectionTime = 10f;
            this.guiDrawMargin = 300f;
            this._lastConnectionError = 65506;
        }
        public TzarGames.GameFramework.NetworkSubsystem_Photon.TzarNetworkConnectionError get_LastConnectionError()
        {
            TzarGames.GameFramework.NetworkSubsystem_Photon.TzarNetworkConnectionError val_3;
            if(this.IsDisconnected != false)
            {
                    val_3 = 65506;
                this._lastConnectionError = 65506;
                return val_3;
            }
            
            val_3 = this._lastConnectionError;
            return val_3;
        }
        public bool get_IsDisconnected()
        {
            return (bool)(PhotonNetwork.connectionState == 0) ? 1 : 0;
        }
        public void StartServer()
        {
            if(PhotonNetwork.connectionState != 0)
            {
                    return;
            }
            
            bool val_2 = PhotonNetwork.ConnectUsingSettings(gameVersion:  0);
        }
        private void OnConnectedToMaster()
        {
            var val_3;
            typeof(RoomOptions).__il2cppRuntimeField_12 = this.maxPlayersPerRoom;
            val_3 = null;
            val_3 = null;
            bool val_2 = PhotonNetwork.JoinOrCreateRoom(roomName:  0, roomOptions:  "Test room", typedLobby:  new RoomOptions());
        }
        public void ConnectToServer()
        {
            if(PhotonNetwork.connectionState != 0)
            {
                    return;
            }
            
            bool val_2 = PhotonNetwork.ConnectUsingSettings(gameVersion:  0);
        }
        private void OnJoinedRoom()
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = PhotonNetwork.room.Name;
            UnityEngine.Debug.LogFormat(format:  0, args:  "Joined to room: {0}");
            if(this.testDisconnection == false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.testDisconnectionRoutine());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator testDisconnectionRoutine()
        {
            typeof(PhotonClientServerManager.<testDisconnectionRoutine>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void OnFailedToConnectToPhoton(DisconnectCause cause)
        {
            string val_1 = 0 + "Failed to connect to server, message: "("Failed to connect to server, message: ");
            UnityEngine.Debug.Log(message:  0);
            this._lastConnectionError = cause;
            if(this.autoConnectWhenDisconnect == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.connectDelay());
        }
        public void Disconnect()
        {
            PhotonNetwork.Disconnect();
        }
        private void OnDisconnectedFromPhoton()
        {
            UnityEngine.Debug.Log(message:  0);
            if(this.autoConnectWhenDisconnect == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.connectDelay());
        }
        private void OnDisconnectedFromServer()
        {
            if(this.autoConnectWhenDisconnect == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.connectDelay());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator connectDelay()
        {
            typeof(PhotonClientServerManager.<connectDelay>c__Iterator1).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void Start()
        {
            DefaultAction val_2 = this.defaultAction;
            val_2 = (val_2 < 3) ? (val_2 + 3) : 0;
            if(val_2 != 5)
            {
                    if(val_2 != 4)
            {
                    return;
            }
            
                this.StartServer();
                return;
            }
            
            this.ConnectToServer();
        }
        private void OnDestroy()
        {
            this.Disconnect();
        }
    
    }

}
