using UnityEngine;

namespace ExitGames.Client.Photon.Chat
{
    public class ChatClient : IPhotonPeerListener
    {
        // Fields
        private const int FriendRequestListMax = 1024;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <NameServerAddress>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <FrontendAddress>k__BackingField;
        private string chatRegion;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private ExitGames.Client.Photon.Chat.ChatState <State>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private ExitGames.Client.Photon.Chat.ChatDisconnectCause <DisconnectedCause>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <AppVersion>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <AppId>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private ExitGames.Client.Photon.Chat.AuthenticationValues <AuthValues>k__BackingField;
        public int MessageLimit;
        public readonly System.Collections.Generic.Dictionary<string, ExitGames.Client.Photon.Chat.ChatChannel> PublicChannels;
        public readonly System.Collections.Generic.Dictionary<string, ExitGames.Client.Photon.Chat.ChatChannel> PrivateChannels;
        private readonly System.Collections.Generic.HashSet<string> PublicChannelsUnsubscribing;
        private readonly ExitGames.Client.Photon.Chat.IChatClientListener listener;
        public ExitGames.Client.Photon.Chat.ChatPeer chatPeer;
        private const string ChatAppName = "chat";
        private bool didAuthenticate;
        private int msDeltaForServiceCalls;
        private int msTimestampOfLastServiceCall;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <UseBackgroundWorkerForSending>k__BackingField;
        
        // Properties
        public string NameServerAddress { get; set; }
        public string FrontendAddress { get; set; }
        public string ChatRegion { get; set; }
        public ExitGames.Client.Photon.Chat.ChatState State { get; set; }
        public ExitGames.Client.Photon.Chat.ChatDisconnectCause DisconnectedCause { get; set; }
        public bool CanChat { get; }
        private bool HasPeer { get; }
        public string AppVersion { get; set; }
        public string AppId { get; set; }
        public ExitGames.Client.Photon.Chat.AuthenticationValues AuthValues { get; set; }
        public string UserId { get; set; }
        public bool UseBackgroundWorkerForSending { get; set; }
        public ExitGames.Client.Photon.ConnectionProtocol TransportProtocol { get; set; }
        public System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, System.Type> SocketImplementationConfig { get; }
        public ExitGames.Client.Photon.DebugLevel DebugOut { get; set; }
        
        // Methods
        public ChatClient(ExitGames.Client.Photon.Chat.IChatClientListener listener, ExitGames.Client.Photon.ConnectionProtocol protocol = 0)
        {
            this.msDeltaForServiceCalls = 50;
            this.chatRegion = "EU";
            this.<State>k__BackingField = 0;
            this.listener = listener;
            this.chatPeer = new ExitGames.Client.Photon.Chat.ChatPeer(listener:  this, protocol:  protocol);
            this.PublicChannels = new System.Collections.Generic.Dictionary<System.String, ExitGames.Client.Photon.Chat.ChatChannel>();
            this.PrivateChannels = new System.Collections.Generic.Dictionary<System.String, ExitGames.Client.Photon.Chat.ChatChannel>();
            this.PublicChannelsUnsubscribing = new System.Collections.Generic.HashSet<System.String>();
        }
        public string get_NameServerAddress()
        {
            return (string)this.<NameServerAddress>k__BackingField;
        }
        private void set_NameServerAddress(string value)
        {
            this.<NameServerAddress>k__BackingField = value;
        }
        public string get_FrontendAddress()
        {
            return (string)this.<FrontendAddress>k__BackingField;
        }
        private void set_FrontendAddress(string value)
        {
            this.<FrontendAddress>k__BackingField = value;
        }
        public string get_ChatRegion()
        {
            return (string)this.chatRegion;
        }
        public void set_ChatRegion(string value)
        {
            this.chatRegion = value;
        }
        public ExitGames.Client.Photon.Chat.ChatState get_State()
        {
            return (ExitGames.Client.Photon.Chat.ChatState)this.<State>k__BackingField;
        }
        private void set_State(ExitGames.Client.Photon.Chat.ChatState value)
        {
            this.<State>k__BackingField = value;
        }
        public ExitGames.Client.Photon.Chat.ChatDisconnectCause get_DisconnectedCause()
        {
            return (ExitGames.Client.Photon.Chat.ChatDisconnectCause)this.<DisconnectedCause>k__BackingField;
        }
        private void set_DisconnectedCause(ExitGames.Client.Photon.Chat.ChatDisconnectCause value)
        {
            this.<DisconnectedCause>k__BackingField = value;
        }
        public bool get_CanChat()
        {
            if((this.<State>k__BackingField) != 7)
            {
                    return false;
            }
            
            return (bool)(this.chatPeer != 0) ? 1 : 0;
        }
        public bool CanChatInChannel(string channelName)
        {
            System.Collections.Generic.Dictionary<System.String, ExitGames.Client.Photon.Chat.ChatChannel> val_4;
            var val_5;
            if(((this.<State>k__BackingField) == 7) && (this.chatPeer != null))
            {
                    val_4 = this.PublicChannels;
                if((val_4.ContainsKey(key:  channelName)) != false)
            {
                    val_5 = (this.PublicChannelsUnsubscribing.Contains(item:  channelName)) ^ 1;
                return (bool)val_5 & 1;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5 & 1;
        }
        private bool get_HasPeer()
        {
            return (bool)(this.chatPeer != 0) ? 1 : 0;
        }
        public string get_AppVersion()
        {
            return (string)this.<AppVersion>k__BackingField;
        }
        private void set_AppVersion(string value)
        {
            this.<AppVersion>k__BackingField = value;
        }
        public string get_AppId()
        {
            return (string)this.<AppId>k__BackingField;
        }
        private void set_AppId(string value)
        {
            this.<AppId>k__BackingField = value;
        }
        public ExitGames.Client.Photon.Chat.AuthenticationValues get_AuthValues()
        {
            return (ExitGames.Client.Photon.Chat.AuthenticationValues)this.<AuthValues>k__BackingField;
        }
        public void set_AuthValues(ExitGames.Client.Photon.Chat.AuthenticationValues value)
        {
            this.<AuthValues>k__BackingField = value;
        }
        public string get_UserId()
        {
            if((this.<AuthValues>k__BackingField) == null)
            {
                    return 0;
            }
            
            return (string)this.<AuthValues>k__BackingField.<UserId>k__BackingField;
        }
        private void set_UserId(string value)
        {
            ExitGames.Client.Photon.Chat.AuthenticationValues val_2 = this.<AuthValues>k__BackingField;
            if(val_2 != null)
            {
                goto label_1;
            }
            
            object val_1 = null;
            val_2 = val_1;
            typeof(ExitGames.Client.Photon.Chat.AuthenticationValues).__il2cppRuntimeField_10 = 255;
            val_1 = new System.Object();
            this.<AuthValues>k__BackingField = val_2;
            if(null == 0)
            {
                goto label_2;
            }
            
            label_1:
            typeof(ExitGames.Client.Photon.Chat.AuthenticationValues).__il2cppRuntimeField_30 = value;
            return;
            label_2:
        }
        public bool get_UseBackgroundWorkerForSending()
        {
            return (bool)this.<UseBackgroundWorkerForSending>k__BackingField;
        }
        public void set_UseBackgroundWorkerForSending(bool value)
        {
            this.<UseBackgroundWorkerForSending>k__BackingField = value;
        }
        public ExitGames.Client.Photon.ConnectionProtocol get_TransportProtocol()
        {
            if(this.chatPeer != null)
            {
                    return this.chatPeer.TransportProtocol;
            }
            
            return this.chatPeer.TransportProtocol;
        }
        public void set_TransportProtocol(ExitGames.Client.Photon.ConnectionProtocol value)
        {
            ExitGames.Client.Photon.Chat.IChatClientListener val_7;
            string val_8;
            var val_9;
            var val_10;
            if(this.chatPeer == null)
            {
                goto label_1;
            }
            
            if((this.chatPeer.PeerState & 255) == 0)
            {
                goto label_2;
            }
            
            val_7 = this.listener;
            val_8 = "Can\'t set TransportProtocol. Disconnect first! ";
            if(this.chatPeer == null)
            {
                goto label_3;
            }
            
            ExitGames.Client.Photon.PeerStateValue val_3 = this.chatPeer.PeerState;
            val_9 = 0 + "PeerState: "("PeerState: ");
            goto label_6;
            label_1:
            val_7 = this.listener;
            val_8 = "Can\'t set TransportProtocol. Disconnect first! ";
            label_3:
            val_9 = "The chatPeer is null.";
            label_6:
            string val_5 = 0 + val_8;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_10 = val_7;
            return;
            label_2:
            this.chatPeer.TransportProtocol = value;
        }
        public System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, System.Type> get_SocketImplementationConfig()
        {
            if(this.chatPeer != null)
            {
                    return (System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, System.Type>)this;
            }
            
            return (System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, System.Type>)this;
        }
        public bool Connect(string appId, string appVersion, ExitGames.Client.Photon.Chat.AuthenticationValues authValues)
        {
            string val_7;
            ExitGames.Client.Photon.Chat.IChatClientListener val_8;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_7 = appId;
            val_8 = this;
            mem2[0] = 3000;
            this.<DisconnectedCause>k__BackingField = 0;
            if(authValues == null)
            {
                goto label_2;
            }
            
            this.<AuthValues>k__BackingField = authValues;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_5;
            }
            
            val_8 = this.listener;
            val_10 = "Connect failed: no UserId specified in authentication values.";
            var val_8 = 0;
            val_11 = 1152921504978767880;
            val_8 = val_8 + 1;
            goto label_16;
            label_2:
            if(3000 == 0)
            {
                goto label_14;
            }
            
            val_8 = this.listener;
            val_10 = "Connect failed: no authentication values specified";
            var val_9 = 0;
            val_11 = 1152921504978767880;
            val_9 = val_9 + 1;
            label_16:
            val_12 = val_8;
            goto label_19;
            label_5:
            this.<AppVersion>k__BackingField = appVersion;
            this.<AppId>k__BackingField = val_7;
            this.didAuthenticate = false;
            this.chatPeer.QuickResendAttempts = 2;
            mem2[0] = 7;
            val_7 = 1152921512497089008;
            this.PublicChannels.Clear();
            this.PrivateChannels.Clear();
            this.PublicChannelsUnsubscribing.Clear();
            this.<NameServerAddress>k__BackingField = this.chatPeer.GetNameServerAddress();
            val_13 = this.chatPeer.Connect();
            if(val_13 != false)
            {
                    this.<State>k__BackingField = 1;
            }
            
            if((this.<UseBackgroundWorkerForSending>k__BackingField) == false)
            {
                    return (bool)val_13 & 1;
            }
            
            System.Func<System.Boolean> val_4 = null;
            val_7 = val_4;
            val_4 = new System.Func<System.Boolean>(object:  this, method:  System.Boolean ExitGames.Client.Photon.Chat.ChatClient::SendOutgoingInBackground());
            val_8 = this.msDeltaForServiceCalls;
            byte val_5 = ExitGames.Client.Photon.SupportClass.StartBackgroundCalls(myThread:  0, millisecondsInterval:  107347968, taskName:  val_8);
            return (bool)val_13 & 1;
            label_19:
            label_14:
            val_13 = 0;
            return (bool)val_13 & 1;
        }
        public void Service()
        {
            label_1:
            if(this.chatPeer != null)
            {
                    if(this.chatPeer.DispatchIncomingCommands() == true)
            {
                goto label_1;
            }
            
            }
            
            if((this.<UseBackgroundWorkerForSending>k__BackingField) == true)
            {
                    return;
            }
            
            int val_7 = this.msTimestampOfLastServiceCall;
            if(val_7 != 0)
            {
                    val_7 = System.Environment.TickCount - val_7;
                if(val_7 <= this.msDeltaForServiceCalls)
            {
                    return;
            }
            
            }
            
            this.msTimestampOfLastServiceCall = System.Environment.TickCount;
            do
            {
                if(this.chatPeer == null)
            {
                    return;
            }
            
            }
            while(this.chatPeer.SendOutgoingCommands() == true);
        
        }
        private bool SendOutgoingInBackground()
        {
            do
            {
                if(this.chatPeer == null)
            {
                    return (bool)((this.<State>k__BackingField) != 11) ? 1 : 0;
            }
            
            }
            while(this.chatPeer.SendOutgoingCommands() == true);
            
            return (bool)((this.<State>k__BackingField) != 11) ? 1 : 0;
        }
        [System.ObsoleteAttribute]
        public void SendAcksOnly()
        {
            if(this.chatPeer == null)
            {
                    return;
            }
            
            bool val_1 = this.chatPeer.SendAcksOnly();
        }
        public void Disconnect()
        {
            if(this.chatPeer == null)
            {
                    return;
            }
            
            if((this.chatPeer.PeerState & 255) == 0)
            {
                    return;
            }
            
            this.chatPeer.Disconnect();
        }
        public void StopThread()
        {
            if(this.chatPeer == null)
            {
                    return;
            }
            
            this.chatPeer.StopThread();
        }
        public bool Subscribe(string[] channels)
        {
            return this.Subscribe(channels:  channels, messagesFromHistory:  0);
        }
        public bool Subscribe(string[] channels, int messagesFromHistory)
        {
            ExitGames.Client.Photon.Chat.IChatClientListener val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_5;
            }
            
            if((channels == null) || (channels.Length == 0))
            {
                goto label_4;
            }
            
            return this.SendChannelOperation(channels:  channels, operation:  0, historyLength:  messagesFromHistory);
            label_1:
            if(this.chatPeer == null)
            {
                goto label_5;
            }
            
            if(this.chatPeer == null)
            {
                    return false;
            }
            
            val_3 = this.listener;
            val_4 = "Subscribe called while not connected to front end server.";
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_5 = val_3;
            return false;
            label_4:
            if(this.chatPeer < 2)
            {
                    return false;
            }
            
            val_3 = this.listener;
            val_4 = "Subscribe can\'t be called for empty or null channels-list.";
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_6 = val_3;
            return false;
            label_5:
        }
        public bool Unsubscribe(string[] channels)
        {
            string val_4;
            ExitGames.Client.Photon.Chat.IChatClientListener val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_9;
            }
            
            if((channels == null) || (channels.Length == 0))
            {
                goto label_4;
            }
            
            if(channels.Length <= 0)
            {
                    return this.SendChannelOperation(channels:  channels, operation:  1, historyLength:  0);
            }
            
            do
            {
                val_4 = channels[0];
                bool val_1 = this.PublicChannelsUnsubscribing.Add(item:  val_4);
            }
            while((0 + 1) < channels.Length);
            
            return this.SendChannelOperation(channels:  channels, operation:  1, historyLength:  0);
            label_1:
            if(this.chatPeer == null)
            {
                goto label_9;
            }
            
            if(this.chatPeer == null)
            {
                    return false;
            }
            
            val_5 = this.listener;
            val_6 = "Unsubscribe called while not connected to front end server.";
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_7 = val_5;
            return false;
            label_4:
            if(this.chatPeer < 2)
            {
                    return false;
            }
            
            val_5 = this.listener;
            val_6 = "Unsubscribe can\'t be called for empty or null channels-list.";
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_8 = val_5;
            return false;
            label_9:
        }
        public bool PublishMessage(string channelName, object message, bool forwardAsWebhook = False)
        {
            return this.publishMessage(channelName:  channelName, message:  message, reliable:  true, forwardAsWebhook:  forwardAsWebhook);
        }
        internal bool PublishMessageUnreliable(string channelName, object message, bool forwardAsWebhook = False)
        {
            return this.publishMessage(channelName:  channelName, message:  message, reliable:  false, forwardAsWebhook:  forwardAsWebhook);
        }
        private bool publishMessage(string channelName, object message, bool reliable, bool forwardAsWebhook = False)
        {
            System.Collections.Generic.Dictionary<System.Byte, System.Object> val_7;
            object val_8;
            ExitGames.Client.Photon.Chat.IChatClientListener val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_8 = forwardAsWebhook;
            val_9 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_9;
            }
            
            if((message == null) || ((System.String.IsNullOrEmpty(value:  0)) == true))
            {
                goto label_6;
            }
            
            System.Collections.Generic.Dictionary<System.Byte, System.Object> val_2 = null;
            val_7 = val_2;
            val_2 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            if(null == 0)
            {
                goto label_7;
            }
            
            Add(key:  1, value:  channelName);
            goto label_8;
            label_1:
            if(this.chatPeer == null)
            {
                goto label_9;
            }
            
            if(this.chatPeer == null)
            {
                goto label_17;
            }
            
            val_9 = this.listener;
            val_10 = "PublishMessage called while not connected to front end server.";
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_11 = val_9;
            goto label_23;
            label_6:
            val_9 = this.listener;
            val_10 = "PublishMessage parameters must be non-null and not empty.";
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_12 = val_9;
            goto label_22;
            label_7:
            Add(key:  1, value:  channelName);
            label_8:
            Add(key:  3, value:  message);
            if(val_8 != false)
            {
                    val_8 = 1;
                Add(key:  21, value:  1);
            }
            
            val_9 = this.chatPeer;
            val_13 = val_9;
            bool val_5 = val_13.OpCustom(customOpCode:  2, customOpParameters:  val_7, sendReliable:  reliable);
            goto label_27;
            label_22:
            label_23:
            label_17:
            val_13 = 0;
            label_27:
            val_13 = val_13 & 1;
            return (bool)val_13;
            label_9:
        }
        public bool SendPrivateMessage(string target, object message, bool forwardAsWebhook = False)
        {
            return this.sendPrivateMessage(target:  target, message:  message, encrypt:  false, reliable:  true, forwardAsWebhook:  forwardAsWebhook);
        }
        public bool SendPrivateMessage(string target, object message, bool encrypt, bool forwardAsWebhook)
        {
            return this.sendPrivateMessage(target:  target, message:  message, encrypt:  encrypt, reliable:  true, forwardAsWebhook:  forwardAsWebhook);
        }
        internal bool SendPrivateMessageUnreliable(string target, object message, bool encrypt, bool forwardAsWebhook = False)
        {
            return this.sendPrivateMessage(target:  target, message:  message, encrypt:  encrypt, reliable:  false, forwardAsWebhook:  forwardAsWebhook);
        }
        private bool sendPrivateMessage(string target, object message, bool encrypt, bool reliable, bool forwardAsWebhook = False)
        {
            object val_8;
            ExitGames.Client.Photon.Chat.IChatClientListener val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_8 = target;
            val_9 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_9;
            }
            
            if((message == null) || ((System.String.IsNullOrEmpty(value:  0)) == true))
            {
                goto label_6;
            }
            
            if(null == 0)
            {
                goto label_7;
            }
            
            Add(key:  225, value:  val_8);
            goto label_8;
            label_1:
            if(this.chatPeer == null)
            {
                goto label_9;
            }
            
            if(this.chatPeer == null)
            {
                goto label_17;
            }
            
            val_9 = this.listener;
            val_10 = "SendPrivateMessage called while not connected to front end server.";
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_11 = val_9;
            goto label_23;
            label_6:
            val_9 = this.listener;
            val_10 = "SendPrivateMessage parameters must be non-null and not empty.";
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_12 = val_9;
            goto label_22;
            label_7:
            Add(key:  225, value:  val_8);
            label_8:
            val_8 = 1152921509686881040;
            Add(key:  3, value:  message);
            if(forwardAsWebhook != false)
            {
                    Add(key:  21, value:  1);
            }
            
            val_9 = this.chatPeer;
            val_13 = val_9;
            bool val_6 = val_13.OpCustom(customOpCode:  3, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  reliable, channelId:  0, encrypt:  encrypt);
            goto label_27;
            label_22:
            label_23:
            label_17:
            val_13 = 0;
            label_27:
            val_13 = val_13 & 1;
            return (bool)val_13;
            label_9:
        }
        private bool SetOnlineStatus(int status, object message, bool skipMessage)
        {
            object val_4;
            int val_5;
            ExitGames.Client.Photon.Chat.IChatClientListener val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_4 = message;
            val_5 = status;
            val_6 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_7;
            }
            
            val_5 = val_5;
            Add(key:  10, value:  val_5);
            if(skipMessage == false)
            {
                goto label_4;
            }
            
            val_4 = true;
            val_7 = 12;
            val_8 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
            goto label_6;
            label_1:
            if(this.chatPeer == null)
            {
                goto label_7;
            }
            
            if(this.chatPeer == null)
            {
                goto label_8;
            }
            
            val_6 = this.listener;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_9 = val_6;
            goto label_13;
            label_4:
            val_7 = 3;
            val_8 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
            label_6:
            set_Item(key:  3, value:  val_4);
            val_6 = this.chatPeer;
            val_10 = val_6;
            bool val_2 = val_10.OpCustom(customOpCode:  5, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
            goto label_16;
            label_13:
            label_8:
            val_10 = 0;
            label_16:
            val_10 = val_10 & 1;
            return (bool)val_10;
            label_7:
        }
        public bool SetOnlineStatus(int status)
        {
            return this.SetOnlineStatus(status:  status, message:  0, skipMessage:  true);
        }
        public bool SetOnlineStatus(int status, object message)
        {
            return this.SetOnlineStatus(status:  status, message:  message, skipMessage:  false);
        }
        public bool AddFriends(string[] friends)
        {
            object val_5;
            ExitGames.Client.Photon.Chat.IChatClientListener val_6;
            var val_7;
            var val_8;
            var val_10;
            var val_11;
            val_5 = friends;
            val_6 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_8;
            }
            
            if((val_5 == null) || (friends.Length == 0))
            {
                goto label_4;
            }
            
            if(friends.Length >= 1025)
            {
                goto label_5;
            }
            
            Add(key:  11, value:  val_5);
            if(this.chatPeer != null)
            {
                    return this.chatPeer.OpCustom(customOpCode:  6, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
            }
            
            return this.chatPeer.OpCustom(customOpCode:  6, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
            label_1:
            if(this.chatPeer == null)
            {
                goto label_8;
            }
            
            if(this.chatPeer == null)
            {
                    return false;
            }
            
            val_6 = this.listener;
            val_7 = "AddFriends called while not connected to front end server.";
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_8 = val_6;
            return false;
            label_4:
            if(this.chatPeer < 2)
            {
                    return false;
            }
            
            val_6 = this.listener;
            val_7 = "AddFriends can\'t be called for empty or null list.";
            var val_6 = 0;
            val_10 = 1152921504978767880;
            val_6 = val_6 + 1;
            goto label_39;
            label_5:
            if(this.chatPeer < 2)
            {
                    return false;
            }
            
            val_6 = this.listener;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "AddFriends max list size exceeded: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = friends.Length;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " > ";
            val_5 = 1024;
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_5;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            val_7 = +0;
            var val_7 = 0;
            val_10 = 1152921504978767880;
            val_7 = val_7 + 1;
            label_39:
            val_11 = val_6;
            return false;
            label_8:
        }
        public bool RemoveFriends(string[] friends)
        {
            object val_5;
            ExitGames.Client.Photon.Chat.IChatClientListener val_6;
            var val_7;
            var val_8;
            var val_10;
            var val_11;
            val_5 = friends;
            val_6 = this;
            if((this.<State>k__BackingField) != 7)
            {
                goto label_1;
            }
            
            if(this.chatPeer == null)
            {
                goto label_8;
            }
            
            if((val_5 == null) || (friends.Length == 0))
            {
                goto label_4;
            }
            
            if(friends.Length >= 1025)
            {
                goto label_5;
            }
            
            Add(key:  11, value:  val_5);
            if(this.chatPeer != null)
            {
                    return this.chatPeer.OpCustom(customOpCode:  7, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
            }
            
            return this.chatPeer.OpCustom(customOpCode:  7, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
            label_1:
            if(this.chatPeer == null)
            {
                goto label_8;
            }
            
            if(this.chatPeer == null)
            {
                    return false;
            }
            
            val_6 = this.listener;
            val_7 = "RemoveFriends called while not connected to front end server.";
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_8 = val_6;
            return false;
            label_4:
            if(this.chatPeer < 2)
            {
                    return false;
            }
            
            val_6 = this.listener;
            val_7 = "RemoveFriends can\'t be called for empty or null list.";
            var val_6 = 0;
            val_10 = 1152921504978767880;
            val_6 = val_6 + 1;
            goto label_39;
            label_5:
            if(this.chatPeer < 2)
            {
                    return false;
            }
            
            val_6 = this.listener;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "RemoveFriends max list size exceeded: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = friends.Length;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " > ";
            val_5 = 1024;
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_5;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            val_7 = +0;
            var val_7 = 0;
            val_10 = 1152921504978767880;
            val_7 = val_7 + 1;
            label_39:
            val_11 = val_6;
            return false;
            label_8:
        }
        public string GetPrivateChannelNameByUser(string userName)
        {
            string val_1;
            if((this.<AuthValues>k__BackingField) != null)
            {
                    val_1 = this.<AuthValues>k__BackingField.<UserId>k__BackingField;
                return System.String.Format(format:  0, arg0:  "{0}:{1}", arg1:  val_1 = 0);
            }
            
            return System.String.Format(format:  0, arg0:  "{0}:{1}", arg1:  val_1);
        }
        public bool TryGetChannel(string channelName, bool isPrivate, out ExitGames.Client.Photon.Chat.ChatChannel channel)
        {
            System.Collections.Generic.Dictionary<System.String, ExitGames.Client.Photon.Chat.ChatChannel> val_3;
            if(isPrivate != false)
            {
                    val_3 = this.PrivateChannels;
                if(val_3 != null)
            {
                    return val_3.TryGetValue(key:  channelName, value: out  ExitGames.Client.Photon.Chat.ChatChannel val_2 = channel);
            }
            
                return val_3.TryGetValue(key:  channelName, value: out  val_2);
            }
            
            val_3 = this.PublicChannels;
            if(val_3 != null)
            {
                    return val_3.TryGetValue(key:  channelName, value: out  val_2);
            }
            
            return val_3.TryGetValue(key:  channelName, value: out  val_2);
        }
        public bool TryGetChannel(string channelName, out ExitGames.Client.Photon.Chat.ChatChannel channel)
        {
            if((this.PublicChannels.TryGetValue(key:  channelName, value: out  ExitGames.Client.Photon.Chat.ChatChannel val_1 = channel)) != false)
            {
                    return true;
            }
            
            if(this.PrivateChannels != null)
            {
                    return this.PrivateChannels.TryGetValue(key:  channelName, value: out  val_1);
            }
            
            return this.PrivateChannels.TryGetValue(key:  channelName, value: out  val_1);
        }
        public void set_DebugOut(ExitGames.Client.Photon.DebugLevel value)
        {
            mem2[0] = value;
        }
        public ExitGames.Client.Photon.DebugLevel get_DebugOut()
        {
            if(this.chatPeer != null)
            {
                    return (ExitGames.Client.Photon.DebugLevel)this;
            }
            
            return (ExitGames.Client.Photon.DebugLevel)this;
        }
        private void ExitGames.Client.Photon.IPhotonPeerListener.DebugReturn(ExitGames.Client.Photon.DebugLevel level, string message)
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.listener;
        }
        private void ExitGames.Client.Photon.IPhotonPeerListener.OnEvent(ExitGames.Client.Photon.EventData eventData)
        {
            if(eventData.Code > 6)
            {
                    return;
            }
            
            var val_1 = 25806560 + (eventData.Code) << 2;
            val_1 = val_1 - 3;
            if(val_1 > 5)
            {
                    return;
            }
            
            var val_2 = 25806144 + ((25806560 + (eventData.Code) << 2 - 3)) << 2;
            val_2 = val_2 + 25806144;
            goto (25806144 + ((25806560 + (eventData.Code) << 2 - 3)) << 2 + 25806144);
        }
        private void ExitGames.Client.Photon.IPhotonPeerListener.OnOperationResponse(ExitGames.Client.Photon.OperationResponse operationResponse)
        {
            ExitGames.Client.Photon.Chat.ChatPeer val_5;
            ExitGames.Client.Photon.Chat.IChatClientListener val_6;
            byte val_7;
            var val_8;
            var val_10;
            var val_11;
            val_6 = this;
            if((operationResponse.OperationCode & 255) == 230)
            {
                    this.HandleAuthResponse(operationResponse:  operationResponse);
                return;
            }
            
            if(operationResponse.OperationCode < 65536)
            {
                    return;
            }
            
            val_5 = this.chatPeer;
            if(operationResponse.OperationCode == 0)
            {
                    return;
            }
            
            if(operationResponse == null)
            {
                goto label_6;
            }
            
            val_6 = this.listener;
            val_7 = operationResponse.OperationCode;
            if(operationResponse.ReturnCode == 2)
            {
                goto label_7;
            }
            
            goto label_9;
            label_6:
            val_5 = operationResponse.ReturnCode;
            val_6 = this.listener;
            val_7 = operationResponse.OperationCode;
            if(val_5 != 2)
            {
                goto label_9;
            }
            
            label_7:
            val_8 = System.String.Format(format:  0, arg0:  "Chat Operation {0} unknown on server. Check your AppId and make sure it\'s for a Chat application.");
            var val_5 = 0;
            val_10 = 1152921504978767880;
            val_5 = val_5 + 1;
            goto label_22;
            label_9:
            val_5 = val_7;
            val_8 = System.String.Format(format:  0, arg0:  "Chat Operation {0} failed (Code: {1}). Debug Message: {2}", arg1:  val_7, arg2:  operationResponse.ReturnCode);
            var val_6 = 0;
            val_10 = 1152921504978767880;
            val_6 = val_6 + 1;
            label_22:
            val_11 = val_6;
        }
        private void ExitGames.Client.Photon.IPhotonPeerListener.OnStatusChanged(ExitGames.Client.Photon.StatusCode statusCode)
        {
            var val_15;
            var val_17;
            string val_19;
            string val_20;
            string val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            ExitGames.Client.Photon.Chat.IChatClientListener val_27;
            var val_28;
            ExitGames.Client.Photon.Chat.IChatClientListener val_29;
            var val_30;
            var val_31;
            val_17 = this;
            if(statusCode > 1047)
            {
                goto label_1;
            }
            
            if(statusCode == 1024)
            {
                goto label_2;
            }
            
            if(statusCode != 1025)
            {
                    return;
            }
            
            if((this.<State>k__BackingField) != 4)
            {
                goto label_4;
            }
            
            this.ConnectToFrontEnd();
            return;
            label_1:
            if(statusCode == 1048)
            {
                goto label_5;
            }
            
            if(statusCode != 1049)
            {
                    return;
            }
            
            this.<State>k__BackingField = 10;
            val_19 = public System.Void ExitGames.Client.Photon.PhotonPeer::Disconnect();
            goto label_8;
            label_2:
            if(((this.chatPeer & 1) & 1) == 0)
            {
                goto label_10;
            }
            
            if(this.didAuthenticate == true)
            {
                goto label_53;
            }
            
            val_20 = this.<AppVersion>k__BackingField;
            val_21 = this.<AppId>k__BackingField;
            val_19 = val_20;
            bool val_3 = this.chatPeer.AuthenticateOnNameServer(appId:  val_21, appVersion:  val_19, region:  this.chatRegion, authValues:  this.<AuthValues>k__BackingField);
            this.didAuthenticate = val_3;
            if((val_3 == true) || (val_3 == false))
            {
                goto label_53;
            }
            
            string val_4 = 0 + "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you\'re connected. State: "("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you\'re connected. State: ");
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_22 = val_17;
            goto label_53;
            label_5:
            if(this.didAuthenticate == true)
            {
                    return;
            }
            
            val_20 = this.<AppVersion>k__BackingField;
            val_21 = this.<AppId>k__BackingField;
            bool val_6 = this.chatPeer.AuthenticateOnNameServer(appId:  val_21, appVersion:  val_20, region:  this.chatRegion, authValues:  this.<AuthValues>k__BackingField);
            this.didAuthenticate = val_6;
            if(val_6 == true)
            {
                    return;
            }
            
            if(val_6 == false)
            {
                    return;
            }
            
            string val_7 = 0 + "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you\'re connected. State: "("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you\'re connected. State: ");
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_23 = val_17;
            return;
            label_4:
            this.<State>k__BackingField = 11;
            val_24 = 1152921504978731008;
            var val_16 = 0;
            val_25 = 1152921504978767880;
            val_16 = val_16 + 1;
            val_25 = 1152921504978767896;
            val_26 = this.listener;
            goto label_37;
            label_10:
            bool val_8 = this.chatPeer.EstablishEncryption();
            label_53:
            if((this.<State>k__BackingField) != 6)
            {
                    if((this.<State>k__BackingField) != 1)
            {
                    return;
            }
            
                val_27 = this.listener;
                this.<State>k__BackingField = 2;
                var val_17 = 0;
                val_25 = 1152921504978767880;
                val_17 = val_17 + 1;
                val_19 = 3;
                val_28 = val_27;
                return;
            }
            
            bool val_9 = this.AuthenticateOnFrontEnd();
            return;
            label_37:
            val_29 = this.listener;
            var val_18 = 0;
            val_25 = 1152921504978767880;
            val_18 = val_18 + 1;
            val_25 = 1152921504978767896;
            val_30 = val_29;
            label_8:
            val_15 = ???;
            val_27 = ???;
            val_31 = ???;
            val_20 = ???;
            val_21 = ???;
            val_25 = val_25 + 3;
        }
        private bool SendChannelOperation(string[] channels, byte operation, int historyLength)
        {
            Add(key:  0, value:  channels);
            if(historyLength == 0)
            {
                    return (bool)this.chatPeer.OpCustom(customOpCode:  operation, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
            }
            
            Add(key:  14, value:  historyLength);
            return (bool)this.chatPeer.OpCustom(customOpCode:  operation, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
        }
        private void HandlePrivateMessageEvent(ExitGames.Client.Photon.EventData eventData)
        {
            string val_13;
            var val_14;
            string val_15;
            ExitGames.Client.Photon.Chat.ChatChannel val_16;
            var val_17;
            val_13 = eventData.Parameters.Item[5];
            if(val_13 != null)
            {
                    if(null == null)
            {
                goto label_5;
            }
            
            }
            
            val_13 = 0;
            label_5:
            if((((this.<AuthValues>k__BackingField) == null) || ((this.<AuthValues>k__BackingField.<UserId>k__BackingField) == null)) || ((this.<AuthValues>k__BackingField.<UserId>k__BackingField.Equals(value:  val_13)) == false))
            {
                goto label_8;
            }
            
            val_14 = eventData.Parameters.Item[225];
            if(val_14 != null)
            {
                    if(null == null)
            {
                goto label_12;
            }
            
            }
            
            val_14 = 0;
            label_12:
            val_15 = val_14;
            goto label_13;
            label_8:
            val_15 = val_13;
            label_13:
            string val_7 = this.GetPrivateChannelNameByUser(userName:  val_15);
            if((this.PrivateChannels.TryGetValue(key:  val_7, value: out  0)) != true)
            {
                    ExitGames.Client.Photon.Chat.ChatChannel val_11 = new ExitGames.Client.Photon.Chat.ChatChannel(name:  val_7);
                typeof(ExitGames.Client.Photon.Chat.ChatChannel).__il2cppRuntimeField_2C = 1;
                typeof(ExitGames.Client.Photon.Chat.ChatChannel).__il2cppRuntimeField_28 = this.MessageLimit;
                val_16 = val_11;
                if(null == 0)
            {
                    val_16 = val_11;
            }
            
                this.PrivateChannels.Add(key:  ExitGames.Client.Photon.Chat.ChatChannel.__il2cppRuntimeField_name, value:  val_16);
            }
            
            Add(sender:  val_13, message:  eventData.Parameters.Item[3]);
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_17 = this.listener;
        }
        private void HandleChatMessagesEvent(ExitGames.Client.Photon.EventData eventData)
        {
            ExitGames.Client.Photon.Chat.IChatClientListener val_13;
            System.Object[] val_14;
            System.String[] val_15;
            string val_16;
            System.Collections.Generic.Dictionary<System.String, ExitGames.Client.Photon.Chat.ChatChannel> val_17;
            var val_18;
            var val_19;
            val_13 = this;
            ExitGames.Client.Photon.Chat.ChatChannel val_7 = 0;
            object val_1 = eventData.Parameters.Item[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_14 = val_1;
            if(val_14 != null)
            {
                goto label_4;
            }
            
            label_3:
            val_14 = 0;
            label_4:
            object val_3 = eventData.Parameters.Item[4];
            if(val_3 == null)
            {
                goto label_7;
            }
            
            val_15 = val_3;
            if(val_15 != null)
            {
                goto label_8;
            }
            
            label_7:
            val_15 = 0;
            label_8:
            val_16 = eventData.Parameters.Item[1];
            if(val_16 != null)
            {
                    if(null == null)
            {
                goto label_12;
            }
            
            }
            
            val_16 = 0;
            label_12:
            val_17 = this.PublicChannels;
            bool val_9 = val_17.TryGetValue(key:  val_16, value: out  val_7);
            if(val_9 != false)
            {
                    val_17 = val_7;
                val_17.Add(senders:  val_15, messages:  val_14);
                val_13 = this.listener;
                var val_13 = 0;
                val_13 = val_13 + 1;
                val_18 = val_13;
                return;
            }
            
            if(val_9 < true)
            {
                    return;
            }
            
            val_13 = this.listener;
            string val_10 = 0 + "Channel " + val_16;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_19 = val_13;
        }
        private void HandleSubscribeEvent(ExitGames.Client.Photon.EventData eventData)
        {
            var val_9;
            var val_10;
            var val_11;
            System.Collections.Generic.Dictionary<System.String, ExitGames.Client.Photon.Chat.ChatChannel> val_12;
            var val_13;
            object val_1 = eventData.Parameters.Item[0];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_9 = val_1;
            if(val_9 != null)
            {
                goto label_4;
            }
            
            label_3:
            val_9 = 0;
            label_4:
            object val_3 = eventData.Parameters.Item[15];
            if(val_3 == null)
            {
                goto label_7;
            }
            
            val_10 = val_3;
            if(val_10 != null)
            {
                goto label_8;
            }
            
            label_7:
            val_10 = 0;
            label_8:
            val_11 = 0;
            goto label_9;
            label_22:
            val_11 = 1;
            label_9:
            if(val_11 >= 7254272)
            {
                goto label_11;
            }
            
            var val_5 = val_10 + 1;
            if(((val_10 + 1) + 32) == 0)
            {
                goto label_22;
            }
            
            var val_6 = val_9 + 8;
            if((this.PublicChannels.ContainsKey(key:  (val_9 + 8) + 32)) == true)
            {
                goto label_22;
            }
            
            if(null != 0)
            {
                    typeof(ExitGames.Client.Photon.Chat.ChatChannel).__il2cppRuntimeField_28 = this.MessageLimit;
                val_12 = this.PublicChannels;
            }
            else
            {
                    mem[40] = this.MessageLimit;
                val_12 = this.PublicChannels;
            }
            
            val_12.Add(key:  ExitGames.Client.Photon.Chat.ChatChannel.__il2cppRuntimeField_name, value:  new ExitGames.Client.Photon.Chat.ChatChannel(name:  (val_9 + 8) + 32));
            goto label_22;
            label_11:
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_13 = this.listener;
        }
        private void HandleUnsubscribeEvent(ExitGames.Client.Photon.EventData eventData)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = 0;
            object val_1 = eventData.Item[0];
            val_7 = 0;
            if(val_1 != null)
            {
                    val_7 = val_1;
                if(val_7 == null)
            {
                    val_7 = 0;
            }
            
            }
            
            val_8 = 0;
            goto label_4;
            label_10:
            val_6 = public System.Boolean System.Collections.Generic.HashSet<System.String>::Remove(System.String item);
            bool val_3 = Remove(item:  val_1);
            val_8 = 1;
            label_4:
            if(val_8 >= 7254272)
            {
                goto label_6;
            }
            
            var val_4 = val_7 + 8;
            bool val_5 = this.PublicChannels.Remove(key:  (val_7 + 8) + 32);
            if(this.PublicChannelsUnsubscribing != null)
            {
                goto label_10;
            }
            
            goto label_10;
            label_6:
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_6 = 7;
            val_9 = this.listener;
        }
        private void HandleAuthResponse(ExitGames.Client.Photon.OperationResponse operationResponse)
        {
            var val_19;
            var val_21;
            var val_22;
            ExitGames.Client.Photon.Chat.ChatPeer val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            ExitGames.Client.Photon.Chat.ChatPeer val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            val_21 = operationResponse;
            val_22 = this;
            val_23 = this.chatPeer;
            if(true >= 3)
            {
                    val_23 = this.listener;
                val_24 = this.chatPeer.GetNameServerAddress();
                var val_19 = 0;
                val_19 = val_19 + 1;
                val_25 = val_23;
                val_26 = 0 + val_21.ToStringFull() + " on: "(" on: ");
            }
            
            short val_23 = operationResponse.ReturnCode;
            if(val_23 == 0)
            {
                goto label_13;
            }
            
            var val_20 = 32754;
            var val_21 = 32741;
            val_20 = val_23 + val_20;
            val_21 = val_23 + val_21;
            var val_5 = (val_20 < 3) ? (val_21) : 0;
            if(val_5 > 13)
            {
                goto label_14;
            }
            
            if(val_5 == 0)
            {
                goto label_15;
            }
            
            if(val_5 != 13)
            {
                goto label_58;
            }
            
            val_27 = 10;
            goto label_36;
            label_13:
            if((this.<State>k__BackingField) == 6)
            {
                goto label_18;
            }
            
            if((this.<State>k__BackingField) != 2)
            {
                goto label_58;
            }
            
            this.<State>k__BackingField = 4;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_28 = 3;
            val_29 = this.listener;
            goto label_24;
            label_14:
            if(val_5 == 14)
            {
                goto label_25;
            }
            
            if(val_5 != 15)
            {
                goto label_58;
            }
            
            val_27 = 7;
            goto label_36;
            label_15:
            val_23 = val_23 & 65535;
            if(val_23 == (-3))
            {
                goto label_28;
            }
            
            if(val_23 != 32767)
            {
                goto label_29;
            }
            
            val_27 = 6;
            goto label_36;
            label_18:
            this.<State>k__BackingField = 7;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_30 = 3;
            val_31 = this.listener;
            goto label_35;
            label_25:
            val_27 = 8;
            goto label_36;
            label_28:
            val_27 = 9;
            label_36:
            this.<DisconnectedCause>k__BackingField = 9;
            label_29:
            val_23 = this.chatPeer;
            if(9 != 0)
            {
                    val_23 = this.listener;
                string val_6 = 0 + "Authentication request error: "("Authentication request error: ") + operationResponse.ReturnCode;
                var val_25 = 0;
                val_25 = val_25 + 1;
                val_32 = val_23;
            }
            
            val_33 = this.chatPeer;
            this.<State>k__BackingField = 10;
            if(val_33 != null)
            {
                goto label_72;
            }
            
            goto label_48;
            label_24:
            val_23 = operationResponse.Parameters;
            if((val_23.ContainsKey(key:  221)) == false)
            {
                goto label_51;
            }
            
            val_23 = this.<AuthValues>k__BackingField;
            if(val_23 == null)
            {
                    object val_10 = null;
                val_23 = val_10;
                typeof(ExitGames.Client.Photon.Chat.AuthenticationValues).__il2cppRuntimeField_10 = 255;
                val_10 = new System.Object();
                this.<AuthValues>k__BackingField = val_23;
            }
            
            object val_11 = val_21.Item[221];
            if(val_11 == null)
            {
                goto label_55;
            }
            
            var val_12 = (null == null) ? (val_11) : 0;
            goto label_56;
            label_51:
            if((public System.Boolean System.Collections.Generic.Dictionary<System.Byte, System.Object>::ContainsKey(System.Byte key)) == 0)
            {
                goto label_58;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_35 = this.listener;
            goto val_9;
            label_35:
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_36 = this.listener;
            val_19 = ???;
            val_21 = ???;
            val_22 = ???;
            val_23 = ???;
            val_24 = ???;
            label_55:
            val_34 = 0;
            label_56:
            mem2[0] = val_34;
            object val_15 = val_21.Item[230];
            val_37 = 0;
            if(val_15 != null)
            {
                    val_37 = val_15;
                if(null != null)
            {
                    val_37 = 0;
            }
            
            }
            
            val_33 = mem[val_22 + 112];
            val_33 = val_22 + 112;
            mem2[0] = val_37;
            if(val_33 != 0)
            {
                goto label_72;
            }
            
            label_48:
            label_72:
            label_58:
            var val_17 = val_19 - 48;
        }
        private void HandleStatusUpdate(ExitGames.Client.Photon.EventData eventData)
        {
            var val_10;
            var val_11;
            var val_12;
            val_10 = eventData.Parameters.Item[5];
            if(val_10 == null)
            {
                goto label_3;
            }
            
            if(null == null)
            {
                goto label_4;
            }
            
            label_3:
            val_10 = 0;
            label_4:
            object val_3 = eventData.Parameters.Item[10];
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            bool val_5 = eventData.Parameters.ContainsKey(key:  3);
            if(val_5 != false)
            {
                    val_11 = eventData.Parameters.Item[3];
            }
            else
            {
                    val_11 = 0;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_12 = this.listener;
            bool val_8 = val_5;
            return;
            label_20:
            goto label_20;
        }
        private void ConnectToFrontEnd()
        {
            var val_4;
            this.<State>k__BackingField = 6;
            if(6 > 2)
            {
                    string val_1 = 0 + "Connecting to frontend ";
                var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.listener;
            }
            
            bool val_3 = this.chatPeer.Connect(serverAddress:  this.<FrontendAddress>k__BackingField, applicationName:  "chat");
        }
        private bool AuthenticateOnFrontEnd()
        {
            ExitGames.Client.Photon.Chat.IChatClientListener val_4;
            var val_5;
            var val_7;
            var val_8;
            var val_9;
            val_4 = this;
            if((this.<AuthValues>k__BackingField) == null)
            {
                goto label_1;
            }
            
            if((this.<AuthValues>k__BackingField.<Token>k__BackingField) == null)
            {
                goto label_2;
            }
            
            val_5 = null;
            val_5 = null;
            if((System.String.op_Equality(a:  0, b:  this.<AuthValues>k__BackingField.<Token>k__BackingField)) == false)
            {
                goto label_5;
            }
            
            label_2:
            if(System.String.Empty == null)
            {
                    return false;
            }
            
            val_4 = this.listener;
            val_7 = "Can\'t authenticate on front end server. Secret is not set";
            var val_4 = 0;
            val_8 = 1152921504978767880;
            val_4 = val_4 + 1;
            goto label_16;
            label_1:
            if((this.<AuthValues>k__BackingField) == null)
            {
                    return false;
            }
            
            val_4 = this.listener;
            val_7 = "Can\'t authenticate on front end server. Authentication Values are not set";
            var val_5 = 0;
            val_8 = 1152921504978767880;
            val_5 = val_5 + 1;
            label_16:
            val_9 = val_4;
            return false;
            label_5:
            Add(key:  221, value:  this.<AuthValues>k__BackingField.<Token>k__BackingField);
            if(this.chatPeer != null)
            {
                    return this.chatPeer.OpCustom(customOpCode:  230, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
            }
            
            return this.chatPeer.OpCustom(customOpCode:  230, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
        }
    
    }

}
