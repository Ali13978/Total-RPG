using UnityEngine;

namespace ExitGames.Client.Photon.Chat
{
    public class ChatPeer : PhotonPeer
    {
        // Fields
        public const string NameServerHost = "ns.exitgames.com";
        public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";
        private static readonly System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, int> ProtocolToNameServerPort;
        
        // Properties
        public string NameServerAddress { get; }
        internal virtual bool IsProtocolSecure { get; }
        
        // Methods
        public ChatPeer(ExitGames.Client.Photon.IPhotonPeerListener listener, ExitGames.Client.Photon.ConnectionProtocol protocol)
        {
            this.ConfigUnitySockets();
        }
        public string get_NameServerAddress()
        {
            return this.GetNameServerAddress();
        }
        internal virtual bool get_IsProtocolSecure()
        {
            return (bool)((this.UsedProtocol & 255) == 5) ? 1 : 0;
        }
        [System.Diagnostics.ConditionalAttribute]
        private void ConfigUnitySockets()
        {
            System.Type val_9 = System.Type.GetType(typeName:  0, throwOnError:  true);
            if(val_9 == null)
            {
                    val_9 = System.Type.GetType(typeName:  0, throwOnError:  true);
                if(val_9 == null)
            {
                    val_9 = System.Type.GetType(typeName:  0, throwOnError:  true);
                if(val_9 == null)
            {
                    val_9 = System.Type.GetType(typeName:  0, throwOnError:  true);
                if(val_9 == null)
            {
                    val_9 = System.Type.GetType(typeName:  0, throwOnError:  true);
                if(val_9 == null)
            {
                    val_9 = System.Type.GetType(typeName:  0, throwOnError:  true);
                if(val_9 == null)
            {
                    val_9 = System.Type.GetType(typeName:  0, throwOnError:  true);
                if(val_9 == null)
            {
                    val_9 = System.Type.GetType(typeName:  0, throwOnError:  true);
                if(val_9 == null)
            {
                    return;
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            set_Item(key:  4, value:  val_9);
            this.set_Item(key:  5, value:  val_9);
        }
        private string GetNameServerAddress()
        {
            var val_8;
            var val_9;
            val_8 = this;
            val_9 = null;
            val_9 = null;
            bool val_3 = ExitGames.Client.Photon.Chat.ChatPeer.ProtocolToNameServerPort.TryGetValue(key:  this.TransportProtocol, value: out  0);
            if((this.TransportProtocol & 255) <= 5)
            {
                    if((25806592 + (val_4 & 255)) > 8)
            {
                    return (string)System.String.Format(format:  0, arg0:  null, arg1:  "ns.exitgames.com");
            }
            
                var val_8 = 25806168 + (25806592 + (val_4 & 255)) << 2;
                val_8 = val_8 + 25806168;
            }
            else
            {
                    System.ArgumentOutOfRangeException val_7 = new System.ArgumentOutOfRangeException();
            }
        
        }
        public bool Connect()
        {
            var val_6;
            if(true < 3)
            {
                    return this.Connect(serverAddress:  this.GetNameServerAddress(), applicationName:  "NameServer");
            }
            
            string val_2 = this.GetNameServerAddress();
            string val_3 = 0 + "Connecting to nameserver ";
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = this.Listener;
            return this.Connect(serverAddress:  this.GetNameServerAddress(), applicationName:  "NameServer");
        }
        public bool AuthenticateOnNameServer(string appId, string appVersion, string region, ExitGames.Client.Photon.Chat.AuthenticationValues authValues)
        {
            var val_14;
            var val_15;
            object val_16;
            var val_17;
            var val_18;
            if(true >= 3)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_14 = this.Listener;
            }
            
            if(null != 0)
            {
                    val_15 = 1152921509667196304;
                set_Item(key:  220, value:  appVersion);
                set_Item(key:  224, value:  appId);
            }
            else
            {
                    val_15 = 1152921509667196304;
                set_Item(key:  220, value:  appVersion);
                set_Item(key:  224, value:  appId);
            }
            
            set_Item(key:  210, value:  region);
            if(authValues == null)
            {
                    return (bool)this.OpCustom(customOpCode:  230, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    set_Item(key:  225, value:  authValues.<UserId>k__BackingField);
            }
            
            if(authValues.authType == 255)
            {
                    return (bool)this.OpCustom(customOpCode:  230, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
            }
            
            set_Item(key:  217, value:  authValues.authType);
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    set_Item(key:  216, value:  authValues.<AuthGetParameters>k__BackingField);
            }
            
                val_16 = authValues.<AuthPostData>k__BackingField;
                if(val_16 == null)
            {
                    return (bool)this.OpCustom(customOpCode:  230, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
            }
            
                val_17 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
                val_18 = 214;
            }
            else
            {
                    val_16 = authValues.<Token>k__BackingField;
                val_17 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
                val_18 = 221;
            }
            
            set_Item(key:  221, value:  val_16);
            return (bool)this.OpCustom(customOpCode:  230, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
        }
        private static ChatPeer()
        {
            if(null != 0)
            {
                    Add(key:  0, value:  194);
                Add(key:  1, value:  181);
                Add(key:  4, value:  133);
            }
            else
            {
                    Add(key:  0, value:  194);
                Add(key:  1, value:  181);
                Add(key:  4, value:  133);
            }
            
            Add(key:  5, value:  149);
            ExitGames.Client.Photon.Chat.ChatPeer.ProtocolToNameServerPort = new System.Collections.Generic.Dictionary<ExitGames.Client.Photon.ConnectionProtocol, System.Int32>();
        }
    
    }

}
