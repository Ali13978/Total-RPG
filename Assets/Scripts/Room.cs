using UnityEngine;
public class Room : RoomInfo
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string[] <PropertiesListedInLobby>k__BackingField;
    
    // Properties
    public string Name { get; set; }
    public bool IsOpen { get; set; }
    public bool IsVisible { get; set; }
    public string[] PropertiesListedInLobby { get; set; }
    public bool AutoCleanUp { get; }
    public int MaxPlayers { get; set; }
    public int PlayerCount { get; }
    public string[] ExpectedUsers { get; }
    public int PlayerTtl { get; set; }
    public int EmptyRoomTtl { get; set; }
    protected internal int MasterClientId { get; set; }
    [System.ObsoleteAttribute]
    public string name { get; set; }
    [System.ObsoleteAttribute]
    public bool open { get; set; }
    [System.ObsoleteAttribute]
    public bool visible { get; set; }
    [System.ObsoleteAttribute]
    public string[] propertiesListedInLobby { get; set; }
    [System.ObsoleteAttribute]
    public bool autoCleanUp { get; }
    [System.ObsoleteAttribute]
    public int maxPlayers { get; set; }
    [System.ObsoleteAttribute]
    public int playerCount { get; }
    [System.ObsoleteAttribute]
    public string[] expectedUsers { get; }
    [System.ObsoleteAttribute]
    protected internal int masterClientId { get; set; }
    
    // Methods
    internal Room(string roomName, RoomOptions options)
    {
        RoomOptions val_2 = options;
        if(val_2 != null)
        {
            goto label_1;
        }
        
        RoomOptions val_1 = null;
        val_2 = val_1;
        val_1 = new RoomOptions();
        if(null == 0)
        {
            goto label_2;
        }
        
        label_1:
        mem[1152921512441610841] = RoomOptions.__il2cppRuntimeField_name;
        mem[1152921512441610840] = typeof(RoomOptions).__il2cppRuntimeField_11;
        mem[1152921512441610842] = 0;
        mem[1152921512441610816] = typeof(RoomOptions).__il2cppRuntimeField_12;
        this.InternalCacheProperties(propertiesToCache:  RoomOptions.__il2cppRuntimeField_byval_arg);
        this.<PropertiesListedInLobby>k__BackingField = RoomOptions.__il2cppRuntimeField_this_arg;
        return;
        label_2:
        mem[1152921512441610841] = 3;
        mem[1152921512441610840] = 0;
        mem[1152921512441610842] = 0;
        mem[1152921512441610816] = 183;
        this.InternalCacheProperties(propertiesToCache:  64);
    }
    public string get_Name()
    {
        return (string)this;
    }
    internal void set_Name(string value)
    {
        mem[1152921512441847136] = value;
    }
    public bool get_IsOpen()
    {
        return (bool)this;
    }
    public void set_IsOpen(bool value)
    {
        NetworkingPeer val_9;
        var val_10;
        val_9 = 1152921504973725696;
        Room val_1 = PhotonNetwork.room;
        if((0 & 1) == 0)
        {
                UnityEngine.Debug.LogWarning(message:  0);
        }
        
        var val_2 = ("Can\'t set open when not in that room." != 0) ? 1 : 0;
        val_2 = val_2 ^ value;
        if(val_2 != false)
        {
                if(PhotonNetwork.offlineMode != true)
        {
                val_10 = null;
            val_10 = null;
            val_9 = PhotonNetwork.networkingPeer;
            Add(key:  253, value:  value);
            bool val_7 = val_9.OpSetPropertiesOfRoom(gameProperties:  new ExitGames.Client.Photon.Hashtable(), expectedProperties:  0, webForward:  false);
        }
        
        }
        
        mem[1152921512442088680] = value;
    }
    public bool get_IsVisible()
    {
        return (bool)this;
    }
    public void set_IsVisible(bool value)
    {
        NetworkingPeer val_9;
        var val_10;
        val_9 = 1152921504973725696;
        Room val_1 = PhotonNetwork.room;
        if((0 & 1) == 0)
        {
                UnityEngine.Debug.LogWarning(message:  0);
        }
        
        var val_2 = ("Can\'t set visible when not in that room." != 0) ? 1 : 0;
        val_2 = val_2 ^ value;
        if(val_2 != false)
        {
                if(PhotonNetwork.offlineMode != true)
        {
                val_10 = null;
            val_10 = null;
            val_9 = PhotonNetwork.networkingPeer;
            Add(key:  254, value:  value);
            bool val_7 = val_9.OpSetPropertiesOfRoom(gameProperties:  new ExitGames.Client.Photon.Hashtable(), expectedProperties:  0, webForward:  false);
        }
        
        }
        
        mem[1152921512442338441] = value;
    }
    public string[] get_PropertiesListedInLobby()
    {
        return (System.String[])this.<PropertiesListedInLobby>k__BackingField;
    }
    private void set_PropertiesListedInLobby(string[] value)
    {
        this.<PropertiesListedInLobby>k__BackingField = value;
    }
    public bool get_AutoCleanUp()
    {
        return (bool)this;
    }
    public int get_MaxPlayers()
    {
        return (int)this;
    }
    public void set_MaxPlayers(int value)
    {
        int val_7;
        NetworkingPeer val_8;
        var val_9;
        val_7 = value;
        val_8 = 1152921504973725696;
        Room val_1 = PhotonNetwork.room;
        if((0 & 1) == 0)
        {
                UnityEngine.Debug.LogWarning(message:  0);
        }
        
        if(val_7 >= 256)
        {
                string val_2 = 0 + "Can\'t set Room.MaxPlayers to: "("Can\'t set Room.MaxPlayers to: ") + val_7;
            UnityEngine.Debug.LogWarning(message:  0);
            val_7 = 255;
        }
        
        if(val_7 != null)
        {
                if(PhotonNetwork.offlineMode != true)
        {
                val_9 = null;
            val_9 = null;
            val_8 = PhotonNetwork.networkingPeer;
            Add(key:  255, value:  val_7);
            bool val_6 = val_8.OpSetPropertiesOfRoom(gameProperties:  new ExitGames.Client.Photon.Hashtable(), expectedProperties:  0, webForward:  false);
        }
        
        }
        
        mem[1152921512443079072] = val_7;
    }
    public int get_PlayerCount()
    {
        var val_3;
        int val_4;
        val_3 = 1152921504973725696;
        if(PhotonNetwork.playerList != null)
        {
                val_3 = PhotonNetwork.playerList;
            val_4 = val_2.Length;
            return (int)val_4;
        }
        
        val_4 = 0;
        return (int)val_4;
    }
    public string[] get_ExpectedUsers()
    {
        return (System.String[])this;
    }
    public int get_PlayerTtl()
    {
        return (int)this;
    }
    public void set_PlayerTtl(int value)
    {
        NetworkingPeer val_4;
        var val_5;
        val_4 = 1152921504973725696;
        Room val_1 = PhotonNetwork.room;
        if((0 & 1) == 0)
        {
                UnityEngine.Debug.LogWarning(message:  0);
        }
        
        if("Can\'t set PlayerTtl when not in a room." != value)
        {
                if(PhotonNetwork.offlineMode != true)
        {
                val_5 = null;
            val_5 = null;
            val_4 = PhotonNetwork.networkingPeer;
            val_4.OpSetPropertyOfRoom(propCode:  246, value:  value);
        }
        
        }
        
        mem[1152921512443703368] = value;
    }
    public int get_EmptyRoomTtl()
    {
        return (int)this;
    }
    public void set_EmptyRoomTtl(int value)
    {
        NetworkingPeer val_4;
        var val_5;
        val_4 = 1152921504973725696;
        Room val_1 = PhotonNetwork.room;
        if((0 & 1) == 0)
        {
                UnityEngine.Debug.LogWarning(message:  0);
        }
        
        if("Can\'t set EmptyRoomTtl when not in a room." != value)
        {
                if(PhotonNetwork.offlineMode != true)
        {
                val_5 = null;
            val_5 = null;
            val_4 = PhotonNetwork.networkingPeer;
            val_4.OpSetPropertyOfRoom(propCode:  245, value:  value);
        }
        
        }
        
        mem[1152921512443943908] = value;
    }
    protected internal int get_MasterClientId()
    {
        return (int)this;
    }
    protected internal void set_MasterClientId(int value)
    {
        mem[1152921512444176136] = value;
    }
    public void SetCustomProperties(ExitGames.Client.Photon.Hashtable propertiesToSet, ExitGames.Client.Photon.Hashtable expectedValues, bool webForward = False)
    {
        System.Collections.IDictionary val_15;
        ExitGames.Client.Photon.Hashtable val_16;
        ExitGames.Client.Photon.Hashtable val_17;
        var val_18;
        var val_19;
        val_16 = expectedValues;
        val_17 = propertiesToSet;
        if(val_17 == null)
        {
                return;
        }
        
        val_15 = 1152921504971223040;
        val_17 = Extensions.StripToStringKeys(original:  0);
        val_16 = Extensions.StripToStringKeys(original:  0);
        if(val_16 != null)
        {
                var val_4 = (val_16.Count == 0) ? 1 : 0;
        }
        else
        {
                val_18 = 1;
        }
        
        if(val_18 == 0)
        {
                if(PhotonNetwork.offlineMode ^ 1 == true)
        {
            goto label_9;
        }
        
        }
        
        Extensions.Merge(target:  0, addHash:  val_15);
        Extensions.StripKeysWithNullValues(original:  0);
        label_9:
        if(PhotonNetwork.offlineMode != true)
        {
                val_19 = null;
            val_19 = null;
            bool val_11 = PhotonNetwork.networkingPeer.OpSetPropertiesOfRoom(gameProperties:  val_17, expectedProperties:  val_16, webForward:  webForward);
        }
        
        if((PhotonNetwork.offlineMode != true) && (((val_18 != 0) ? 1 : 0) == 0))
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_17;
        NetworkingPeer.SendMonoMessage(methodString:  0, parameters:  20);
    }
    public void SetPropertiesListedInLobby(string[] propsListedInLobby)
    {
        var val_3;
        set_Item(key:  250, value:  propsListedInLobby);
        val_3 = null;
        val_3 = null;
        bool val_2 = PhotonNetwork.networkingPeer.OpSetPropertiesOfRoom(gameProperties:  new ExitGames.Client.Photon.Hashtable(), expectedProperties:  0, webForward:  false);
        this.<PropertiesListedInLobby>k__BackingField = propsListedInLobby;
    }
    public void ClearExpectedUsers()
    {
        var val_4;
        set_Item(key:  247, value:  null);
        set_Item(key:  247, value:  this);
        val_4 = null;
        val_4 = null;
        bool val_3 = PhotonNetwork.networkingPeer.OpSetPropertiesOfRoom(gameProperties:  new ExitGames.Client.Photon.Hashtable(), expectedProperties:  new ExitGames.Client.Photon.Hashtable(), webForward:  false);
    }
    public void SetExpectedUsers(string[] expectedUsers)
    {
        var val_4;
        set_Item(key:  247, value:  expectedUsers);
        set_Item(key:  247, value:  this);
        val_4 = null;
        val_4 = null;
        bool val_3 = PhotonNetwork.networkingPeer.OpSetPropertiesOfRoom(gameProperties:  new ExitGames.Client.Photon.Hashtable(), expectedProperties:  new ExitGames.Client.Photon.Hashtable(), webForward:  false);
    }
    public override string ToString()
    {
        var val_7;
        typeof(System.Object[]).__il2cppRuntimeField_20 = ???;
        var val_2 = (System.Object[].__il2cppRuntimeField_namespaze != 0) ? 1 : ((System.Object[].__il2cppRuntimeField_namespaze ^ 1));
        mem2[0] = (System.Object[].__il2cppRuntimeField_namespaze != 0) ? "visible" : "hidden";
        typeof(System.Object[]).__il2cppRuntimeField_30 = (((null + (System.Object[].__il2cppRuntimeField_namespaze != null ? 1 : (System.Object[].__il2cppRuntimeField_namespaze ^ 1)) << 3)) != 0) ? "open" : "closed";
        val_7 = System.Object[].__il2cppRuntimeField_namespaze;
        typeof(System.Object[]).__il2cppRuntimeField_38 = System.Object[].__il2cppRuntimeField_namespaze;
        typeof(System.Object[]).__il2cppRuntimeField_39 = 30617833;
        typeof(System.Object[]).__il2cppRuntimeField_40 = System.Object[].__il2cppRuntimeField_namespaze.PlayerCount;
        typeof(System.Object[]).__il2cppRuntimeField_44 = 268435457;
        return (string)System.String.Format(format:  0, args:  "Room: \'{0}\' {1},{2} {4}/{3} players.");
    }
    public string ToStringFull()
    {
        var val_8;
        typeof(System.Object[]).__il2cppRuntimeField_20 = ???;
        var val_2 = (System.Object[].__il2cppRuntimeField_namespaze != 0) ? 1 : ((System.Object[].__il2cppRuntimeField_namespaze ^ 1));
        mem2[0] = (System.Object[].__il2cppRuntimeField_namespaze != 0) ? "visible" : "hidden";
        typeof(System.Object[]).__il2cppRuntimeField_30 = (((null + (System.Object[].__il2cppRuntimeField_namespaze != null ? 1 : (System.Object[].__il2cppRuntimeField_namespaze ^ 1)) << 3)) != 0) ? "open" : "closed";
        val_8 = System.Object[].__il2cppRuntimeField_namespaze;
        typeof(System.Object[]).__il2cppRuntimeField_38 = System.Object[].__il2cppRuntimeField_namespaze;
        typeof(System.Object[]).__il2cppRuntimeField_39 = 30618383;
        typeof(System.Object[]).__il2cppRuntimeField_40 = System.Object[].__il2cppRuntimeField_namespaze.PlayerCount;
        typeof(System.Object[]).__il2cppRuntimeField_44 = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_48 = Extensions.ToStringFull(origin:  0);
        return (string)System.String.Format(format:  0, args:  "Room: \'{0}\' {1},{2} {4}/{3} players.\ncustomProps: {5}");
    }
    public string get_name()
    {
        return (string)this;
    }
    internal void set_name(string value)
    {
        mem[1152921512445365664] = value;
    }
    public bool get_open()
    {
        return (bool)this;
    }
    public void set_open(bool value)
    {
        this.IsOpen = value;
    }
    public bool get_visible()
    {
        return (bool)this;
    }
    public void set_visible(bool value)
    {
        this.IsVisible = value;
    }
    public string[] get_propertiesListedInLobby()
    {
        return (System.String[])this.<PropertiesListedInLobby>k__BackingField;
    }
    private void set_propertiesListedInLobby(string[] value)
    {
        this.<PropertiesListedInLobby>k__BackingField = value;
    }
    public bool get_autoCleanUp()
    {
        return (bool)this;
    }
    public int get_maxPlayers()
    {
        return (int)this;
    }
    public void set_maxPlayers(int value)
    {
        this.MaxPlayers = value;
    }
    public int get_playerCount()
    {
        return this.PlayerCount;
    }
    public string[] get_expectedUsers()
    {
        return (System.String[])this;
    }
    protected internal int get_masterClientId()
    {
        return (int)this;
    }
    protected internal void set_masterClientId(int value)
    {
        mem[1152921512446973224] = value;
    }

}
