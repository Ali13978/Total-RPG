using UnityEngine;

namespace TzarGames.GameFramework
{
    public class LobbyClient : StateMachine
    {
        // Fields
        public string LobbyIP;
        public int LobbyPort;
        public bool useLocalhostIp;
        private TzarGames.GameFramework.GameManager gameManager;
        private TzarGames.GameFramework.Room currentRoom;
        private System.Collections.Generic.List<TzarGames.GameFramework.Room> rooms;
        private TzarGames.GameFramework.Room pendingEnterRoom;
        private string mapName;
        private static bool autoAuthorizationInProcess;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.LobbyClient.DeathmatchRequestCompleteDelegate OnDeathmatchRequestComplete;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Common.TG_VoidDelegate OnUpdateSignal;
        private static bool pendingPlayerData;
        private static string globalPlayerData;
        private static bool registrationFailed;
        private static bool registered;
        
        // Properties
        public string AccountID { get; }
        public System.Collections.Generic.List<TzarGames.GameFramework.Room> Rooms { get; }
        public TzarGames.GameFramework.Room CurrentRoom { get; }
        public static bool IsReadingPlayerData { get; }
        public bool Logged { get; }
        
        // Methods
        public LobbyClient()
        {
            this.LobbyPort = 45000;
            this.LobbyIP = "127.0.0.1";
            this.rooms = new System.Collections.Generic.List<TzarGames.GameFramework.Room>();
        }
        public void add_OnDeathmatchRequestComplete(TzarGames.GameFramework.LobbyClient.DeathmatchRequestCompleteDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnDeathmatchRequestComplete);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511385478184 != this.OnDeathmatchRequestComplete);
        
        }
        public void remove_OnDeathmatchRequestComplete(TzarGames.GameFramework.LobbyClient.DeathmatchRequestCompleteDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnDeathmatchRequestComplete);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511385614760 != this.OnDeathmatchRequestComplete);
        
        }
        public void add_OnUpdateSignal(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnUpdateSignal);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511385751344 != this.OnUpdateSignal);
        
        }
        public void remove_OnUpdateSignal(TzarGames.Common.TG_VoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnUpdateSignal);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511385887920 != this.OnUpdateSignal);
        
        }
        public string get_AccountID()
        {
            return 0;
        }
        private void Update()
        {
        
        }
        public System.Collections.Generic.List<TzarGames.GameFramework.Room> get_Rooms()
        {
            return (System.Collections.Generic.List<TzarGames.GameFramework.Room>)this.rooms;
        }
        public TzarGames.GameFramework.Room get_CurrentRoom()
        {
            return (TzarGames.GameFramework.Room)this.currentRoom;
        }
        public void LauchGame(string mapNameToStart)
        {
            this.mapName = mapNameToStart;
            if((System.String.op_Equality(a:  0, b:  this.CurrentState)) != true)
            {
                    return;
            }
            
            System.NotImplementedException val_3 = new System.NotImplementedException();
        }
        private void Start()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public void BeginBox(int x, int y, int width, int height, UnityEngine.GUIStyle style)
        {
            UnityEngine.GUIStyle val_6 = style;
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
            if(val_6 == null)
            {
                    val_6 = UnityEngine.GUIStyle.op_Implicit(str:  0);
            }
            
            UnityEngine.GUILayout.BeginVertical(style:  0, options:  val_6);
            UnityEngine.GUILayout.FlexibleSpace();
            UnityEngine.GUILayout.EndVertical();
            UnityEngine.GUILayout.EndArea();
            int val_2 = x + 10;
            int val_3 = y + 5;
            int val_4 = width - 20;
            int val_5 = height - 10;
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
            UnityEngine.GUILayout.FlexibleSpace();
        }
        public void BeginBox(int width, int height)
        {
            int val_1 = UnityEngine.Screen.width;
            int val_2 = UnityEngine.Screen.height;
            var val_3 = (val_1 < 0) ? (val_1 + 1) : (val_1);
            val_3 = val_3 >> 1;
            var val_6 = (val_2 < 0) ? (val_2 + 1) : (val_2);
            val_6 = val_6 >> 1;
            height = val_6 - (((height < 0) ? (height + 1) : height) >> 1);
            val_2.BeginBox(x:  val_3 - (((width < 0) ? (width + 1) : width) >> 1), y:  height, width:  width, height:  height, style:  0);
        }
        public void EndBox()
        {
            UnityEngine.GUILayout.FlexibleSpace();
            UnityEngine.GUILayout.EndArea();
        }
        public void ConnectToLobby()
        {
        
        }
        public void DisconnectFromLobby()
        {
        
        }
        public UnityEngine.Coroutine AutoLobbyAuthorization(string login, string password)
        {
            return this.StartCoroutine(routine:  TzarGames.GameFramework.LobbyClient.AutoLobbyAuthorization_INTERNAL(login:  null, password:  login, lobbyAddress:  password, lobbyPort:  0));
        }
        public static bool get_IsReadingPlayerData()
        {
            null = null;
            return (bool)TzarGames.GameFramework.LobbyClient.pendingPlayerData;
        }
        public UnityEngine.Coroutine GetPlayerData(string login, TzarGames.GameFramework.Database.ReadDataCompleteHandler handler)
        {
            string val_5;
            string val_6;
            val_5 = this.CurrentState;
            if((System.String.op_Equality(a:  0, b:  val_5)) == true)
            {
                    return 0;
            }
            
            val_5 = 1152921504912916480;
            val_6 = null;
            val_6 = null;
            if(TzarGames.GameFramework.LobbyClient.pendingPlayerData == false)
            {
                    return this.StartCoroutine(routine:  TzarGames.GameFramework.LobbyClient.GetPlayerData_INTERNAL(login:  val_6, handler:  val_5));
            }
            
            return 0;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private static System.Collections.IEnumerator GetPlayerData_INTERNAL(string login, TzarGames.GameFramework.Database.ReadDataCompleteHandler handler)
        {
            typeof(LobbyClient.<GetPlayerData_INTERNAL>c__Iterator0).__il2cppRuntimeField_10 = X2;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [TzarRPC]
        private void fromlobby_registrationSuccess()
        {
            null = null;
            TzarGames.GameFramework.LobbyClient.registrationFailed = false;
            TzarGames.GameFramework.LobbyClient.registered = true;
        }
        [TzarRPC]
        private void fromlobby_registrationFailed()
        {
            null = null;
            TzarGames.GameFramework.LobbyClient.registrationFailed = true;
            TzarGames.GameFramework.LobbyClient.registered = false;
        }
        public bool get_Logged()
        {
            return false;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public static System.Collections.IEnumerator AutoLobbyAuthorization_INTERNAL(string login, string password, string lobbyAddress, int lobbyPort)
        {
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void CreateRoom(string name)
        {
            if((System.String.op_Equality(a:  0, b:  this.CurrentState)) != true)
            {
                    return;
            }
            
            System.NotImplementedException val_3 = new System.NotImplementedException();
        }
        public void ExitRoom()
        {
            if((System.String.op_Equality(a:  0, b:  this.CurrentState)) != true)
            {
                    return;
            }
            
            System.NotImplementedException val_3 = new System.NotImplementedException();
        }
        public void RequestRoomList()
        {
            if((System.String.op_Equality(a:  0, b:  this.CurrentState)) != false)
            {
                    return;
            }
            
            System.NotImplementedException val_4 = new System.NotImplementedException();
        }
        private void uLobby_OnConnected()
        {
            UnityEngine.Debug.Log(message:  0);
        }
        private void uLobby_OnDisconnected()
        {
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarRPC]
        private void client_startGame(string serverIp, int port, string login, string password)
        {
            if((System.String.op_Equality(a:  0, b:  this.CurrentState)) != true)
            {
                    return;
            }
            
            this.currentRoom.inGame = true;
            this.currentRoom.gameAddress = serverIp;
            this.currentRoom.gamePort = port;
            System.NotImplementedException val_3 = new System.NotImplementedException();
        }
        [TzarRPC]
        private void client_noServer()
        {
            UnityEngine.Debug.Log(message:  0);
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [TzarRPC]
        private void client_noPlayerData()
        {
            var val_1;
            UnityEngine.Debug.Log(message:  0);
            val_1 = null;
            val_1 = null;
            TzarGames.GameFramework.LobbyClient.pendingPlayerData = false;
        }
        [TzarRPC]
        private void fromlobby_notifyUpdate()
        {
            UnityEngine.Debug.Log(message:  0);
            if(this.OnUpdateSignal == null)
            {
                    return;
            }
            
            this.OnUpdateSignal.Invoke();
        }
        public static bool IsValidNickName(string nickName)
        {
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return false;
            }
            
            if(X1.Length > 32)
            {
                    return false;
            }
            
            System.Text.RegularExpressions.Match val_4 = System.Text.RegularExpressions.Regex.Match(input:  0, pattern:  X1);
            if(val_4 != null)
            {
                    return val_4.Success;
            }
            
            return val_4.Success;
        }
        public bool RequestNickNameChange(string newNickName)
        {
            if((TzarGames.GameFramework.LobbyClient.IsValidNickName(nickName:  null)) != true)
            {
                    return false;
            }
            
            System.NotImplementedException val_3 = new System.NotImplementedException();
        }
        [TzarRPC]
        private void fromlobby_message(int messageCode)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public void RequestDeathmatch()
        {
            if((System.String.op_Equality(a:  0, b:  this.CurrentState)) != true)
            {
                    return;
            }
            
            System.NotImplementedException val_3 = new System.NotImplementedException();
        }
        private void OnGameSessionEnd()
        {
            if(0 == this.gameManager)
            {
                    return;
            }
            
            this.gameManager.remove_OnGamemanagerDestroy(value:  new TzarGames.Common.TG_VoidDelegate(object:  this, method:  System.Void TzarGames.GameFramework.LobbyClient::OnGameSessionEnd()));
        }
        private static LobbyClient()
        {
        
        }
    
    }

}
