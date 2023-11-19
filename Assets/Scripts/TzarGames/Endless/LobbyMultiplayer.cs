using UnityEngine;

namespace TzarGames.Endless
{
    public class LobbyMultiplayer : MonoBehaviour, IChatClientListener
    {
        // Fields
        [UnityEngine.SerializeField]
        private byte maxPlayersPerRoom;
        [UnityEngine.SerializeField]
        private float reconnectDelay;
        [UnityEngine.SerializeField]
        private bool autoConnectWhenDisconnect;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private bool testingMode;
        [UnityEngine.SerializeField]
        private bool testDisconnection;
        [UnityEngine.SerializeField]
        private float testMinConnectionTime;
        [UnityEngine.SerializeField]
        private float testMaxConnectionTime;
        private bool pendingRoomList;
        private bool enableChatConnection;
        private TzarGames.Endless.IChatProvider chatProvider;
        private float lastChatConnectAttemptTime;
        private UnityEngine.Coroutine connectCoroutine;
        private bool waitingForSocialAuth;
        
        // Methods
        public LobbyMultiplayer()
        {
            this.maxPlayersPerRoom = 4;
            this.reconnectDelay = 2f;
            this.testMaxConnectionTime = 10f;
            this.enableChatConnection = true;
        }
        [UnityEngine.ContextMenu]
        public void Connect()
        {
            if(TzarGames.Common.Privacy.CanCollectData == false)
            {
                    return;
            }
            
            if((0 == TzarGames.Endless.SocialSystem.Instance) || (TzarGames.Endless.SocialSystem.Instance.IsAuthenticated == false))
            {
                goto label_8;
            }
            
            if(this.connectCoroutine == null)
            {
                goto label_9;
            }
            
            UnityEngine.Debug.Log(message:  0);
            return;
            label_8:
            UnityEngine.Debug.Log(message:  0);
            this.waitingForSocialAuth = true;
            return;
            label_9:
            this.connectCoroutine = this.StartCoroutine(routine:  this.connectRoutine());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator connectRoutine()
        {
            typeof(LobbyMultiplayer.<connectRoutine>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void OnConnectedToMaster()
        {
            this.tryToCreateOrJoinRandomRoom();
        }
        private void OnJoinedRoom()
        {
            if(this.testDisconnection == false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.testDisconnectionRoutine());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator testDisconnectionRoutine()
        {
            typeof(LobbyMultiplayer.<testDisconnectionRoutine>c__Iterator1).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator connectDelay()
        {
            typeof(LobbyMultiplayer.<connectDelay>c__Iterator2).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void Disconnect()
        {
            if(this.connectCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.connectCoroutine);
                this.connectCoroutine = 0;
            }
            
            this.pendingRoomList = false;
            PhotonNetwork.Disconnect();
        }
        private void OnFailedToConnectToPhoton(DisconnectCause cause)
        {
            string val_1 = 0 + "Failed to connect to server, message: "("Failed to connect to server, message: ");
            UnityEngine.Debug.Log(message:  0);
            if(this.autoConnectWhenDisconnect == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.connectDelay());
        }
        private void tryToCreateOrJoinRandomRoom()
        {
            TypedLobby val_1 = this.getLobby();
            bool val_2 = PhotonNetwork.JoinLobby(typedLobby:  0);
        }
        private void OnJoinedLobby()
        {
            this.pendingRoomList = true;
        }
        private RoomOptions getRoomOptions()
        {
            typeof(RoomOptions).__il2cppRuntimeField_12 = this.maxPlayersPerRoom;
            return (RoomOptions)new RoomOptions();
        }
        private TypedLobby getLobby()
        {
            return (TypedLobby)new TypedLobby(name:  "Lobby", type:  0);
        }
        private RoomInfo getFirstAvailableRoom(RoomInfo[] rooms)
        {
            RoomInfo val_4;
            var val_5;
            var val_4 = 0;
            label_5:
            if(val_4 >= rooms.Length)
            {
                goto label_1;
            }
            
            val_4 = rooms[0];
            if(val_4 != null)
            {
                    val_5 = val_4.PlayerCount;
            }
            else
            {
                    val_5 = 0.PlayerCount;
            }
            
            val_4 = val_4 + 1;
            if(val_5 >= val_4.MaxPlayers)
            {
                goto label_5;
            }
            
            return (RoomInfo)val_4;
            label_1:
            val_4 = 0;
            return (RoomInfo)val_4;
        }
        private void OnReceivedRoomListUpdate()
        {
            if(this.pendingRoomList == false)
            {
                    return;
            }
            
            this.pendingRoomList = false;
            RoomInfo[] val_1 = PhotonNetwork.GetRoomList();
            if((val_1 != null) && (val_1.Length != 0))
            {
                    if((val_1.getFirstAvailableRoom(rooms:  val_1)) != null)
            {
                    UnityEngine.Debug.LogFormat(format:  0, args:  "Trying to join to random room");
                bool val_4 = PhotonNetwork.JoinRandomRoom(expectedCustomRoomProperties:  0, expectedMaxPlayers:  0, matchingType:  this.maxPlayersPerRoom, typedLobby:  0, sqlLobbyFilter:  this.getLobby(), expectedUsers:  0);
                return;
            }
            
            }
            
            RoomOptions val_5 = this.getRoomOptions();
            TypedLobby val_6 = val_5.getLobby();
            bool val_7 = PhotonNetwork.CreateRoom(roomName:  0, roomOptions:  0, typedLobby:  val_5);
        }
        private void OnPhotonCreateRoomFailed(object[] codeAndMsg)
        {
            RoomOptions val_1 = this.getRoomOptions();
            TypedLobby val_2 = val_1.getLobby();
            bool val_3 = PhotonNetwork.CreateRoom(roomName:  0, roomOptions:  0, typedLobby:  val_1);
        }
        private void OnPhotonJoinRoomFailed(object[] codeAndMsg)
        {
        
        }
        private void OnPhotonRandomJoinFailed(object[] codeAndMsg)
        {
            this.tryToCreateOrJoinRandomRoom();
        }
        private void OnDisconnectedFromPhoton()
        {
            var val_4;
            UnityEngine.Debug.Log(message:  0);
            this.pendingRoomList = false;
            if(this.chatProvider != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.chatProvider;
            }
            
            if(this.autoConnectWhenDisconnect == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.connectDelay());
        }
        private void OnDisconnectedFromServer()
        {
            UnityEngine.Debug.Log(message:  0);
            this.pendingRoomList = false;
            if(this.autoConnectWhenDisconnect == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.connectDelay());
        }
        private bool isConnectedToRoom()
        {
            return PhotonNetwork.inRoom;
        }
        private string getRoomName()
        {
            if(PhotonNetwork.room == null)
            {
                    return 0;
            }
            
            Room val_2 = PhotonNetwork.room;
            if(val_2 != null)
            {
                    return val_2.Name;
            }
            
            return val_2.Name;
        }
        private void Awake()
        {
            var val_3;
            if(this.chatProvider != null)
            {
                    return;
            }
            
            TzarGames.Endless.UI.Chat.PhotonChatProvider val_1 = TzarGames.Endless.UI.Chat.PhotonChatProvider.Instance;
            this.chatProvider = val_1;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = val_1;
        }
        private void OnDestroy()
        {
            var val_3;
            var val_4;
            var val_5;
            if(this.chatProvider != null)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                val_3 = 5;
                val_4 = this.chatProvider;
                var val_4 = 0;
                val_4 = val_4 + 1;
                val_3 = 9;
                val_5 = this.chatProvider;
            }
            
            this.Disconnect();
        }
        private void Update()
        {
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            TzarGames.Endless.IChatProvider val_44;
            var val_46;
            var val_47;
            var val_48;
            val_36 = this;
            if(this.waitingForSocialAuth != false)
            {
                    val_37 = 0;
                if(0 != TzarGames.Endless.SocialSystem.Instance)
            {
                    if(TzarGames.Endless.SocialSystem.Instance.IsAuthenticated != false)
            {
                    val_37 = 0;
                UnityEngine.Debug.Log(message:  0);
                this.waitingForSocialAuth = false;
                this.Connect();
            }
            
            }
            
            }
            
            if(PhotonNetwork.connected != false)
            {
                    val_37 = 0;
                if(0 != TzarGames.Endless.SocialSystem.Instance)
            {
                    if(TzarGames.Endless.SocialSystem.Instance.IsAuthenticated == true)
            {
                goto label_16;
            }
            
            }
            
                this.Disconnect();
            }
            
            label_16:
            val_38 = 1152921504869625856;
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_37 = 7;
            val_39 = this.chatProvider;
            if(this.enableChatConnection == true)
            {
                goto label_22;
            }
            
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_37 = 6;
            val_40 = this.chatProvider;
            if(this.chatProvider != 1)
            {
                goto label_28;
            }
            
            label_22:
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_37 = 6;
            val_41 = this.chatProvider;
            if(this.chatProvider != 1)
            {
                    val_37 = 0;
                if(0 != TzarGames.Endless.SocialSystem.Instance)
            {
                    if(TzarGames.Endless.SocialSystem.Instance.IsAuthenticated == false)
            {
                goto label_39;
            }
            
            }
            
            }
            
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_37 = 6;
            val_42 = this.chatProvider;
            if(this.chatProvider != 1)
            {
                    if(this.chatProvider.isConnectedToRoom() == false)
            {
                goto label_46;
            }
            
            }
            
            if(this.enableChatConnection == false)
            {
                    return;
            }
            
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_37 = 6;
            val_43 = this.chatProvider;
            goto label_52;
            label_28:
            val_44 = this.chatProvider;
            var val_40 = 0;
            val_46 = 1152921504869662728;
            val_40 = val_40 + 1;
            goto label_67;
            label_46:
            val_44 = this.chatProvider;
            var val_41 = 0;
            val_46 = 1152921504869662728;
            val_41 = val_41 + 1;
            goto label_67;
            label_52:
            if(this.chatProvider != 1)
            {
                    return;
            }
            
            if(this.enableChatConnection == false)
            {
                    return;
            }
            
            float val_24 = UnityEngine.Time.time;
            val_24 = val_24 - this.lastChatConnectAttemptTime;
            if(val_24 >= 1f)
            {
                goto label_65;
            }
            
            return;
            label_39:
            val_44 = this.chatProvider;
            var val_42 = 0;
            val_46 = 1152921504869662728;
            val_42 = val_42 + 1;
            label_67:
            val_47 = val_44;
            val_36 = ???;
            val_38 = ???;
            label_65:
            mem2[0] = UnityEngine.Time.time;
            string val_28 = TzarGames.Endless.SocialSystem.Instance.GetUserName();
            var val_46 = val_36 + 48;
            if((val_36 + 48 + 258) == 0)
            {
                goto label_73;
            }
            
            var val_43 = val_36 + 48 + 152;
            var val_44 = 0;
            val_43 = val_43 + 8;
            label_75:
            if(((val_36 + 48 + 152 + 8) + -8) == val_38)
            {
                goto label_74;
            }
            
            val_44 = val_44 + 1;
            val_43 = val_43 + 16;
            if(val_44 < (val_36 + 48 + 258))
            {
                goto label_75;
            }
            
            label_73:
            val_37 = 4;
            val_48 = val_36 + 48;
            goto ((val_36 + 48 + ((val_36 + 48 + 152 + 8) + 4)) + 272);
            label_74:
            var val_45 = val_43;
            val_45 = val_45 + 4;
            val_46 = val_46 + val_45;
            val_48 = val_46 + 272;
            goto ((val_36 + 48 + ((val_36 + 48 + 152 + 8) + 4)) + 272);
        }
        public void OnConnected()
        {
            var val_12;
            var val_13;
            var val_14;
            var val_16;
            var val_17;
            TzarGames.Endless.IChatProvider val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            val_12 = this;
            val_13 = this.getRoomName();
            val_14 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_3;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            var val_10 = 0;
            val_16 = 1152921504869662728;
            val_10 = val_10 + 1;
            val_16 = 1152921504869662744;
            val_17 = this.chatProvider;
            goto label_10;
            label_3:
            val_18 = this.chatProvider;
            val_19 = 1152921504869625856;
            var val_11 = 0;
            val_16 = 1152921504869662728;
            val_11 = val_11 + 1;
            val_14 = 1;
            val_20 = val_18;
            goto label_15;
            label_10:
            val_12 = ???;
            val_13 = ???;
            val_19 = ???;
            val_18 = ???;
            val_16 = val_16 + 1;
            label_15:
            typeof(System.String[]).__il2cppRuntimeField_20 = val_13;
            var val_15 = val_12 + 48;
            if((val_12 + 48 + 258) == 0)
            {
                goto label_21;
            }
            
            var val_12 = val_12 + 48 + 152;
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_23:
            if(((val_12 + 48 + 152 + 8) + -8) == val_19)
            {
                goto label_22;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (val_12 + 48 + 258))
            {
                goto label_23;
            }
            
            label_21:
            val_21 = 2;
            val_22 = val_12 + 48;
            goto ((val_12 + 48 + ((val_12 + 48 + 152 + 8) + 2)) + 272);
            label_22:
            var val_14 = val_12;
            val_14 = val_14 + 2;
            val_15 = val_15 + val_14;
            val_22 = val_15 + 272;
            goto ((val_12 + 48 + ((val_12 + 48 + 152 + 8) + 2)) + 272);
        }
        public void OnDisconnected()
        {
        
        }
        public void OnGetMessages(string channelName, string[] senders, object[] messages)
        {
        
        }
    
    }

}
