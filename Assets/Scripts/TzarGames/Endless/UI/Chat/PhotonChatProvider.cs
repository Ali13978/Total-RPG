using UnityEngine;

namespace TzarGames.Endless.UI.Chat
{
    internal class PhotonChatProvider : IChatClientListener, IChatProvider
    {
        // Fields
        private const string appVersion = "1.0";
        private System.Collections.Generic.List<TzarGames.Endless.IChatClientListener> _listeners;
        private ExitGames.Client.Photon.Chat.ChatClient chatClient;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <UserID>k__BackingField;
        private static TzarGames.Endless.UI.Chat.PhotonChatProvider _instance;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <ActiveChannel>k__BackingField;
        
        // Properties
        public string UserID { get; set; }
        public static TzarGames.Endless.UI.Chat.PhotonChatProvider Instance { get; }
        public string ActiveChannel { get; set; }
        
        // Methods
        private PhotonChatProvider()
        {
            this._listeners = new System.Collections.Generic.List<TzarGames.Endless.IChatClientListener>();
            this.chatClient = new ExitGames.Client.Photon.Chat.ChatClient(listener:  this, protocol:  0);
        }
        public string get_UserID()
        {
            return (string)this.<UserID>k__BackingField;
        }
        private void set_UserID(string value)
        {
            this.<UserID>k__BackingField = value;
        }
        public static TzarGames.Endless.UI.Chat.PhotonChatProvider get_Instance()
        {
            TzarGames.Endless.UI.Chat.PhotonChatProvider val_2;
            TzarGames.Endless.UI.Chat.PhotonChatProvider val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(TzarGames.Endless.UI.Chat.PhotonChatProvider._instance == null)
            {
                    val_2 = val_3;
                val_3 = new TzarGames.Endless.UI.Chat.PhotonChatProvider();
                val_4 = null;
                val_4 = null;
                TzarGames.Endless.UI.Chat.PhotonChatProvider._instance = val_2;
                val_3 = null;
            }
            
            val_3 = null;
            return (TzarGames.Endless.UI.Chat.PhotonChatProvider)TzarGames.Endless.UI.Chat.PhotonChatProvider._instance;
        }
        public string get_ActiveChannel()
        {
            return (string)this.<ActiveChannel>k__BackingField;
        }
        public void set_ActiveChannel(string value)
        {
            this.<ActiveChannel>k__BackingField = value;
        }
        public void AddListener(TzarGames.Endless.IChatClientListener listener)
        {
            if((this._listeners.Contains(item:  listener)) != false)
            {
                    return;
            }
            
            this._listeners.Add(item:  listener);
        }
        public void RemoveListener(TzarGames.Endless.IChatClientListener listener)
        {
            if((this._listeners.Contains(item:  listener)) == false)
            {
                    return;
            }
            
            bool val_2 = this._listeners.Remove(item:  listener);
        }
        public void SubscribeToChannels(string[] channels)
        {
            bool val_1 = this.chatClient.Subscribe(channels:  channels);
        }
        public void UpdateState()
        {
            this.chatClient.Service();
        }
        public void Connect(string userId)
        {
            var val_5;
            if(this.chatClient.State != 11)
            {
                    if(this.chatClient.State != 0)
            {
                    return;
            }
            
            }
            
            this.<UserID>k__BackingField = userId;
            this.chatClient.ChatRegion = "EU";
            val_5 = null;
            val_5 = null;
            bool val_4 = this.chatClient.Connect(appId:  PhotonNetwork.PhotonServerSettings.ChatAppID, appVersion:  "1.0", authValues:  new ExitGames.Client.Photon.Chat.AuthenticationValues(userId:  userId));
        }
        public void SendMessageToChannel(string channel, string message)
        {
            bool val_1 = this.chatClient.PublishMessage(channelName:  channel, message:  message, forwardAsWebhook:  false);
        }
        public void Disconnect()
        {
            this.chatClient.Disconnect();
        }
        public TzarGames.Endless.TzarChatState GetState()
        {
            var val_3;
            var val_4;
            ExitGames.Client.Photon.Chat.ChatState val_1 = this.chatClient.State;
            if(val_1 == 7)
            {
                    val_3 = 0;
            }
            else
            {
                    val_3 = 1;
                if(val_1 != 0)
            {
                    if(val_1 != 11)
            {
                    return (TzarGames.Endless.TzarChatState)(val_1 == 10) ? (2 + 1) : 2;
            }
            
            }
            
            }
            
            val_4 = val_3;
            return (TzarGames.Endless.TzarChatState)(val_1 == 10) ? (2 + 1) : 2;
        }
        public void DebugReturn(ExitGames.Client.Photon.DebugLevel level, string message)
        {
        
        }
        public void OnChatStateChange(ExitGames.Client.Photon.Chat.ChatState state)
        {
        
        }
        public void OnConnected()
        {
            var val_4;
            var val_5;
            var val_6;
            List.Enumerator<T> val_1 = this._listeners.GetEnumerator();
            label_8:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 0.InitializationCallback;
            goto label_8;
            label_2:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            if((val_6 & 1) != 0)
            {
                    return;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
        
        }
        public void OnDisconnected()
        {
            var val_4;
            var val_5;
            var val_6;
            this.<UserID>k__BackingField = 0;
            List.Enumerator<T> val_1 = this._listeners.GetEnumerator();
            label_8:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 0.InitializationCallback;
            goto label_8;
            label_2:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            if((val_6 & 1) != 0)
            {
                    return;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
        
        }
        public void OnGetMessages(string channelName, string[] senders, object[] messages)
        {
            var val_4;
            var val_5;
            var val_6;
            List.Enumerator<T> val_1 = this._listeners.GetEnumerator();
            label_8:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 0.InitializationCallback;
            goto label_8;
            label_2:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            if((val_6 & 1) != 0)
            {
                    return;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
        
        }
        public void OnPrivateMessage(string sender, object message, string channelName)
        {
        
        }
        public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
        {
        
        }
        public void OnSubscribed(string[] channels, bool[] results)
        {
        
        }
        public void OnUnsubscribed(string[] channels)
        {
        
        }
        private static PhotonChatProvider()
        {
        
        }
    
    }

}
