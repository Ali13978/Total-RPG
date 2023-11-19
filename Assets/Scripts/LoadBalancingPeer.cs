using UnityEngine;
internal class LoadBalancingPeer : PhotonPeer
{
    // Fields
    private readonly System.Collections.Generic.Dictionary<byte, object> opParameters;
    
    // Properties
    internal bool IsProtocolSecure { get; }
    
    // Methods
    public LoadBalancingPeer(ExitGames.Client.Photon.ConnectionProtocol protocolType)
    {
        this.opParameters = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
    }
    public LoadBalancingPeer(ExitGames.Client.Photon.IPhotonPeerListener listener, ExitGames.Client.Photon.ConnectionProtocol protocolType)
    {
        this.Listener = listener;
    }
    internal bool get_IsProtocolSecure()
    {
        return (bool)((this.UsedProtocol & 255) == 5) ? 1 : 0;
    }
    public virtual bool OpGetRegions(string appId)
    {
        set_Item(key:  224, value:  appId);
        return this.OpCustom(customOpCode:  220, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true, channelId:  0, encrypt:  true);
    }
    public virtual bool OpJoinLobby(TypedLobby lobby)
    {
        var val_8;
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_9;
        if(true >= 3)
        {
                var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = this.Listener;
        }
        
        if(lobby != null)
        {
                val_9 = 0;
            if(lobby.IsDefault == true)
        {
                return (bool)this.OpCustom(customOpCode:  229, customOpParameters:  val_9 = 0, sendReliable:  true);
        }
        
            System.Collections.Generic.Dictionary<System.Byte, System.Object> val_5 = null;
            val_9 = val_5;
            val_5 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            set_Item(key:  213, value:  lobby.Name);
            set_Item(key:  212, value:  lobby.Type);
            return (bool)this.OpCustom(customOpCode:  229, customOpParameters:  val_9, sendReliable:  true);
        }
        
        return (bool)this.OpCustom(customOpCode:  229, customOpParameters:  val_9, sendReliable:  true);
    }
    public virtual bool OpLeaveLobby()
    {
        var val_3;
        if(true < 3)
        {
                return this.OpCustom(customOpCode:  228, customOpParameters:  0, sendReliable:  true);
        }
        
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_3 = this.Listener;
        return this.OpCustom(customOpCode:  228, customOpParameters:  0, sendReliable:  true);
    }
    private void RoomOptionsToOpParameters(System.Collections.Generic.Dictionary<byte, object> op, RoomOptions roomOptions)
    {
        var val_14;
        object val_15;
        var val_16;
        object val_17;
        val_14 = roomOptions;
        if(val_14 == null)
        {
                RoomOptions val_1 = null;
            val_14 = val_1;
            val_1 = new RoomOptions();
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
        set_Item(key:  253, value:  IsOpen);
        set_Item(key:  254, value:  IsVisible);
        val_15 = null;
        set_Item(key:  250, value:  val_15);
        Extensions.MergeStringKeys(target:  0, addHash:  val_2);
        val_15 = typeof(RoomOptions).__il2cppRuntimeField_12;
        set_Item(key:  255, value:  typeof(RoomOptions).__il2cppRuntimeField_12);
        op.set_Item(key:  248, value:  val_2);
        op.set_Item(key:  241, value:  CleanupCacheOnLeave);
        val_16 = 1;
        if(CleanupCacheOnLeave != false)
        {
                val_15 = true;
            set_Item(key:  249, value:  true);
            val_16 = 3;
        }
        
        op.set_Item(key:  232, value:  true);
        op.set_Item(key:  235, value:  typeof(RoomOptions).__il2cppRuntimeField_14);
        op.set_Item(key:  236, value:  RoomOptions.__il2cppRuntimeField_namespaze);
        if(SuppressRoomEvents != false)
        {
                val_16 = val_16 | 4;
            op.set_Item(key:  237, value:  true);
        }
        
        op.set_Item(key:  204, value:  RoomOptions.__il2cppRuntimeField_element_class);
        if(PublishUserId != false)
        {
                val_16 = val_16 | 8;
            val_17 = true;
            op.set_Item(key:  239, value:  true);
        }
        
        op.set_Item(key:  191, value:  (DeleteNullProperties != true) ? (val_16 | 16) : (val_16));
    }
    public virtual bool OpCreateRoom(EnterRoomParams opParams)
    {
        var val_11;
        var val_12;
        if(true >= 3)
        {
                var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = this.Listener;
        }
        
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        val_12 = 1152921504608284672;
        if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                set_Item(key:  255, value:  opParams.RoomName);
        }
        
        if(opParams.Lobby != null)
        {
                if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                val_12 = 1152921509667196304;
            set_Item(key:  213, value:  opParams.Lobby.Name);
            set_Item(key:  212, value:  opParams.Lobby.Type);
        }
        
        }
        
        if((opParams.ExpectedUsers != null) && (opParams.ExpectedUsers.Length >= 1))
        {
                set_Item(key:  238, value:  opParams.ExpectedUsers);
        }
        
        if(opParams.OnGameServer == false)
        {
                return (bool)this.OpCustom(customOpCode:  227, customOpParameters:  val_3, sendReliable:  true);
        }
        
        if(opParams.PlayerProperties != null)
        {
                if(opParams.PlayerProperties.Count >= 1)
        {
                val_12 = 1152921509667196304;
            set_Item(key:  249, value:  opParams.PlayerProperties);
            set_Item(key:  250, value:  true);
        }
        
        }
        
        RoomOptionsToOpParameters(op:  val_3, roomOptions:  opParams.RoomOptions);
        return (bool)this.OpCustom(customOpCode:  227, customOpParameters:  val_3, sendReliable:  true);
    }
    public virtual bool OpJoinRoom(EnterRoomParams opParams)
    {
        var val_9;
        var val_10;
        if(true >= 3)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = this.Listener;
        }
        
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                set_Item(key:  255, value:  opParams.RoomName);
        }
        
        if(opParams.CreateIfNotExists != false)
        {
                val_10 = 1152921504607805440;
            set_Item(key:  215, value:  1);
            if(opParams.Lobby != null)
        {
                set_Item(key:  213, value:  opParams.Lobby.Name);
            set_Item(key:  212, value:  opParams.Lobby.Type);
        }
        
        }
        
        if(opParams.RejoinOnly != false)
        {
                set_Item(key:  215, value:  3);
        }
        
        if((opParams.ExpectedUsers != null) && (opParams.ExpectedUsers.Length >= 1))
        {
                set_Item(key:  238, value:  opParams.ExpectedUsers);
        }
        
        if(opParams.OnGameServer == false)
        {
                return (bool)this.OpCustom(customOpCode:  226, customOpParameters:  val_3, sendReliable:  true);
        }
        
        if(opParams.PlayerProperties != null)
        {
                if(opParams.PlayerProperties.Count >= 1)
        {
                val_10 = 1152921509667196304;
            set_Item(key:  249, value:  opParams.PlayerProperties);
            set_Item(key:  250, value:  true);
        }
        
        }
        
        if(opParams.CreateIfNotExists == false)
        {
                return (bool)this.OpCustom(customOpCode:  226, customOpParameters:  val_3, sendReliable:  true);
        }
        
        RoomOptionsToOpParameters(op:  val_3, roomOptions:  opParams.RoomOptions);
        return (bool)this.OpCustom(customOpCode:  226, customOpParameters:  val_3, sendReliable:  true);
    }
    public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
    {
        var val_12;
        object val_13;
        if(true >= 3)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = this.Listener;
        }
        
        ExitGames.Client.Photon.Hashtable val_3 = new ExitGames.Client.Photon.Hashtable();
        Extensions.MergeStringKeys(target:  0, addHash:  val_3);
        if(opJoinRandomRoomParams.ExpectedMaxPlayers != 0)
        {
                val_13 = opJoinRandomRoomParams.ExpectedMaxPlayers;
            set_Item(key:  255, value:  opJoinRandomRoomParams.ExpectedMaxPlayers);
        }
        
        if(Count >= 1)
        {
                set_Item(key:  248, value:  val_3);
        }
        
        if(opJoinRandomRoomParams.MatchingType != 0)
        {
                set_Item(key:  223, value:  opJoinRandomRoomParams.MatchingType);
        }
        
        if(opJoinRandomRoomParams.TypedLobby != null)
        {
                if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                val_13 = 1152921509667196304;
            set_Item(key:  213, value:  opJoinRandomRoomParams.TypedLobby.Name);
            set_Item(key:  212, value:  opJoinRandomRoomParams.TypedLobby.Type);
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                set_Item(key:  245, value:  opJoinRandomRoomParams.SqlLobbyFilter);
        }
        
        if((opJoinRandomRoomParams.ExpectedUsers == null) || (opJoinRandomRoomParams.ExpectedUsers.Length < 1))
        {
                return (bool)this.OpCustom(customOpCode:  225, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
        }
        
        set_Item(key:  238, value:  opJoinRandomRoomParams.ExpectedUsers);
        return (bool)this.OpCustom(customOpCode:  225, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
    }
    public virtual bool OpLeaveRoom(bool becomeInactive)
    {
        object val_4;
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_5;
        if(becomeInactive != false)
        {
                System.Collections.Generic.Dictionary<System.Byte, System.Object> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            val_4 = true;
            set_Item(key:  233, value:  true);
            return (bool)this.OpCustom(customOpCode:  254, customOpParameters:  val_5 = 0, sendReliable:  true);
        }
        
        return (bool)this.OpCustom(customOpCode:  254, customOpParameters:  val_5, sendReliable:  true);
    }
    public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
    {
        object val_8;
        var val_9;
        string val_10;
        var val_11;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_8 = lobby;
        val_9 = this;
        if(true >= 3)
        {
                val_10 = "OpGetGameList()";
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_11 = this.Listener;
        }
        
        if(val_8 == null)
        {
            goto label_7;
        }
        
        if(lobby.Type != 2)
        {
            goto label_8;
        }
        
        val_10 = lobby.Name;
        set_Item(key:  213, value:  val_10);
        val_8 = lobby.Type;
        if(null == 0)
        {
            goto label_10;
        }
        
        set_Item(key:  212, value:  lobby.Type);
        goto label_11;
        label_7:
        if(null < 3)
        {
            goto label_18;
        }
        
        val_9 = this.Listener;
        val_13 = "OpGetGameList not sent. Lobby cannot be null.";
        var val_9 = 0;
        val_14 = 1152921504814338056;
        val_9 = val_9 + 1;
        goto label_20;
        label_8:
        if(lobby.Type < 3)
        {
            goto label_18;
        }
        
        val_9 = this.Listener;
        val_13 = "OpGetGameList not sent. LobbyType must be SqlLobby.";
        var val_10 = 0;
        val_14 = 1152921504814338056;
        val_10 = val_10 + 1;
        label_20:
        val_15 = val_9;
        goto label_23;
        label_10:
        set_Item(key:  212, value:  lobby.Type);
        label_11:
        set_Item(key:  245, value:  queryData);
        val_16 = val_9;
        bool val_6 = this.OpCustom(customOpCode:  217, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
        goto label_24;
        label_23:
        label_18:
        val_16 = 0;
        label_24:
        val_16 = val_16 & 1;
        return (bool)val_16;
    }
    public virtual bool OpFindFriends(string[] friendsToFind)
    {
        if(friendsToFind == null)
        {
                return this.OpCustom(customOpCode:  222, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
        }
        
        if(friendsToFind.Length < 1)
        {
                return this.OpCustom(customOpCode:  222, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
        }
        
        set_Item(key:  1, value:  friendsToFind);
        return this.OpCustom(customOpCode:  222, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true);
    }
    public bool OpSetCustomPropertiesOfActor(int actorNr, ExitGames.Client.Photon.Hashtable actorProperties)
    {
        return this.OpSetPropertiesOfActor(actorNr:  actorNr, actorProperties:  Extensions.StripToStringKeys(original:  0), expectedProperties:  0, webForward:  false);
    }
    protected internal bool OpSetPropertiesOfActor(int actorNr, ExitGames.Client.Photon.Hashtable actorProperties, ExitGames.Client.Photon.Hashtable expectedProperties, bool webForward = False)
    {
        int val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_8 = actorNr;
        val_9 = this;
        if(true >= 3)
        {
                val_10 = "OpSetPropertiesOfActor()";
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_11 = this.Listener;
        }
        
        if((val_8 >= 1) && (actorProperties != null))
        {
                val_10 = 1152921509686881040;
            Add(key:  251, value:  actorProperties);
            Add(key:  254, value:  val_8);
            val_8 = true;
            Add(key:  250, value:  true);
            if(expectedProperties != null)
        {
                if(expectedProperties.Count != 0)
        {
                Add(key:  231, value:  expectedProperties);
        }
        
        }
        
            if(webForward != false)
        {
                set_Item(key:  234, value:  true);
        }
        
            val_12 = val_9;
            bool val_5 = this.OpCustom(customOpCode:  252, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true, channelId:  0, encrypt:  false);
        }
        else
        {
                if(null >= 3)
        {
                val_9 = this.Listener;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_13 = val_9;
        }
        
            val_12 = 0;
        }
        
        val_12 = val_12 & 1;
        return (bool)val_12;
    }
    protected internal void OpSetPropertyOfRoom(byte propCode, object value)
    {
        set_Item(key:  propCode, value:  value);
        bool val_2 = this.OpSetPropertiesOfRoom(gameProperties:  new ExitGames.Client.Photon.Hashtable(), expectedProperties:  0, webForward:  false);
    }
    public bool OpSetCustomPropertiesOfRoom(ExitGames.Client.Photon.Hashtable gameProperties, bool broadcast, byte channelId)
    {
        return this.OpSetPropertiesOfRoom(gameProperties:  Extensions.StripToStringKeys(original:  0), expectedProperties:  0, webForward:  false);
    }
    protected internal bool OpSetPropertiesOfRoom(ExitGames.Client.Photon.Hashtable gameProperties, ExitGames.Client.Photon.Hashtable expectedProperties, bool webForward = False)
    {
        var val_7;
        if(true >= 3)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = this.Listener;
        }
        
        Add(key:  251, value:  gameProperties);
        Add(key:  250, value:  true);
        if(expectedProperties != null)
        {
                if(expectedProperties.Count != 0)
        {
                Add(key:  231, value:  expectedProperties);
        }
        
        }
        
        if(webForward == false)
        {
                return (bool)this.OpCustom(customOpCode:  252, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true, channelId:  0, encrypt:  false);
        }
        
        set_Item(key:  234, value:  true);
        return (bool)this.OpCustom(customOpCode:  252, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true, channelId:  0, encrypt:  false);
    }
    public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
    {
        object val_37;
        object val_38;
        var val_39;
        var val_40;
        var val_41;
        object val_42;
        var val_43;
        var val_44;
        var val_46;
        var val_47;
        var val_48;
        val_37 = getLobbyStatistics;
        val_38 = appId;
        val_39 = this;
        if(true >= 3)
        {
                var val_37 = 0;
            val_37 = val_37 + 1;
            val_40 = this.Listener;
        }
        
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        if(val_37 != false)
        {
                val_37 = true;
            set_Item(key:  211, value:  true);
        }
        
        if(authValues != null)
        {
                if(authValues.Token != null)
        {
                set_Item(key:  221, value:  authValues.Token);
            val_41 = this.OpCustom(customOpCode:  230, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  false);
            return false;
        }
        
        }
        
        if(null != 0)
        {
                set_Item(key:  220, value:  appVersion);
        }
        else
        {
                set_Item(key:  220, value:  appVersion);
        }
        
        set_Item(key:  224, value:  val_38);
        val_38 = 1152921504608284672;
        if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                set_Item(key:  210, value:  regionCode);
        }
        
        if(authValues == null)
        {
            goto label_35;
        }
        
        string val_9 = authValues.UserId;
        if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                set_Item(key:  225, value:  authValues.UserId);
        }
        
        if((authValues.AuthType & 255) == 255)
        {
            goto label_35;
        }
        
        if((this.UsedProtocol & 255) != 5)
        {
                if(this.IsEncryptionAvailable == false)
        {
            goto label_26;
        }
        
        }
        
        set_Item(key:  217, value:  authValues.AuthType);
        string val_20 = authValues.Token;
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_30;
        }
        
        string val_23 = authValues.AuthGetParameters;
        if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                set_Item(key:  216, value:  authValues.AuthGetParameters);
        }
        
        if(authValues.AuthPostData == null)
        {
            goto label_35;
        }
        
        val_42 = authValues.AuthPostData;
        val_43 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
        val_44 = 214;
        goto label_37;
        label_30:
        val_42 = authValues.Token;
        val_43 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
        val_44 = 221;
        label_37:
        set_Item(key:  221, value:  val_42);
        label_35:
        val_41 = 1;
        if((this.OpCustom(customOpCode:  230, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable)) == true)
        {
                return false;
        }
        
        val_39 = this.Listener;
        val_46 = "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you\'re connected.";
        var val_38 = 0;
        val_47 = 1152921504814338056;
        val_38 = val_38 + 1;
        goto label_46;
        label_26:
        val_39 = this.Listener;
        val_46 = "OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.";
        var val_39 = 0;
        val_47 = 1152921504814338056;
        val_39 = val_39 + 1;
        label_46:
        val_48 = val_39;
        val_41 = 0;
        return false;
    }
    public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ExitGames.Client.Photon.ConnectionProtocol expectedProtocol)
    {
        object val_31;
        var val_32;
        var val_33;
        object val_34;
        var val_35;
        var val_36;
        val_31 = expectedProtocol;
        if(true >= 3)
        {
                var val_31 = 0;
            val_31 = val_31 + 1;
            val_32 = this.Listener;
        }
        
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        if(authValues != null)
        {
                if(authValues.Token != null)
        {
                set_Item(key:  221, value:  authValues.Token);
            return this.OpCustom(customOpCode:  231, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  false);
        }
        
        }
        
        if(encryptionMode == 10)
        {
                if((val_31 & 255) != 0)
        {
                val_33 = null;
            val_33 = null;
            string val_7 = 0 + "Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: "("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ");
            UnityEngine.Debug.LogWarning(message:  0);
            val_31 = 0;
            PhotonNetwork.PhotonServerSettings.Protocol = 0;
        }
        
        }
        
        set_Item(key:  195, value:  val_31);
        if(null != 0)
        {
                set_Item(key:  193, value:  encryptionMode);
            set_Item(key:  220, value:  appVersion);
        }
        else
        {
                set_Item(key:  193, value:  encryptionMode);
            set_Item(key:  220, value:  appVersion);
        }
        
        set_Item(key:  224, value:  appId);
        if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                set_Item(key:  210, value:  regionCode);
        }
        
        if(authValues == null)
        {
                return (bool)this.OpCustom(customOpCode:  231, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
        }
        
        string val_10 = authValues.UserId;
        if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                set_Item(key:  225, value:  authValues.UserId);
        }
        
        if((authValues.AuthType & 255) == 255)
        {
                return (bool)this.OpCustom(customOpCode:  231, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
        }
        
        set_Item(key:  217, value:  authValues.AuthType);
        string val_17 = authValues.Token;
        if((System.String.IsNullOrEmpty(value:  0)) != false)
        {
                string val_20 = authValues.AuthGetParameters;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                set_Item(key:  216, value:  authValues.AuthGetParameters);
        }
        
            if(authValues.AuthPostData == null)
        {
                return (bool)this.OpCustom(customOpCode:  231, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
        }
        
            val_34 = authValues.AuthPostData;
            val_35 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
            val_36 = 214;
        }
        else
        {
                val_34 = authValues.Token;
            val_35 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
            val_36 = 221;
        }
        
        set_Item(key:  221, value:  val_34);
        return (bool)this.OpCustom(customOpCode:  231, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
    }
    public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
    {
        var val_4;
        if(true >= 5)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = this.Listener;
        }
        
        if(groupsToRemove != null)
        {
                set_Item(key:  239, value:  groupsToRemove);
        }
        
        if(groupsToAdd == null)
        {
                return this.OpCustom(customOpCode:  248, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true, channelId:  0);
        }
        
        set_Item(key:  238, value:  groupsToAdd);
        return this.OpCustom(customOpCode:  248, customOpParameters:  new System.Collections.Generic.Dictionary<System.Byte, System.Object>(), sendReliable:  true, channelId:  0);
    }
    public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
    {
        RaiseEventOptions val_6;
        object val_7;
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_8;
        var val_9;
        val_6 = raiseEventOptions;
        this.opParameters.Clear();
        val_7 = eventCode;
        this.opParameters.set_Item(key:  244, value:  eventCode);
        if(customEventContent != null)
        {
                val_7 = this.opParameters;
            val_7.set_Item(key:  245, value:  customEventContent);
        }
        
        if(val_6 != null)
        {
                if((raiseEventOptions.CachingOption & 255) != 0)
        {
                val_7 = raiseEventOptions.CachingOption;
            this.opParameters.set_Item(key:  247, value:  raiseEventOptions.CachingOption);
        }
        
            if((raiseEventOptions.Receivers & 255) != 0)
        {
                val_7 = raiseEventOptions.Receivers;
            this.opParameters.set_Item(key:  246, value:  raiseEventOptions.Receivers);
        }
        
            if(raiseEventOptions.InterestGroup != 0)
        {
                val_7 = raiseEventOptions.InterestGroup;
            this.opParameters.set_Item(key:  240, value:  raiseEventOptions.InterestGroup);
        }
        
            if(raiseEventOptions.TargetActors != null)
        {
                val_7 = this.opParameters;
            val_7.set_Item(key:  252, value:  raiseEventOptions.TargetActors);
        }
        
            val_8 = this.opParameters;
            if(raiseEventOptions.ForwardToWebhook == false)
        {
                return (bool)this.OpCustom(customOpCode:  253, customOpParameters:  val_8 = this.opParameters, sendReliable:  sendReliable, channelId:  RaiseEventOptions.Default.SequenceChannel, encrypt:  RaiseEventOptions.Default.Encrypt);
        }
        
            val_7 = true;
            val_8.set_Item(key:  234, value:  true);
        }
        else
        {
                val_9 = null;
            val_9 = null;
            val_6 = RaiseEventOptions.Default;
        }
        
        if(val_6 != null)
        {
                return (bool)this.OpCustom(customOpCode:  253, customOpParameters:  val_8, sendReliable:  sendReliable, channelId:  RaiseEventOptions.Default.SequenceChannel, encrypt:  RaiseEventOptions.Default.Encrypt);
        }
    
    }
    public virtual bool OpSettings(bool receiveLobbyStats)
    {
        var val_5;
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_6;
        var val_7;
        if(true >= 5)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = this.Listener;
        }
        
        val_6 = this.opParameters;
        val_6.Clear();
        if(receiveLobbyStats != false)
        {
                val_6 = true;
            this.opParameters.set_Item(key:  0, value:  true);
        }
        
        if(this.opParameters.Count != 0)
        {
                val_7 = this;
            bool val_4 = this.OpCustom(customOpCode:  218, customOpParameters:  this.opParameters, sendReliable:  true);
        }
        else
        {
                val_7 = 1;
        }
        
        val_7 = val_7 & 1;
        return (bool)val_7;
    }

}
