using UnityEngine;
public class RoomInfo
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private bool <removedFromList>k__BackingField;
    private ExitGames.Client.Photon.Hashtable customPropertiesField;
    protected byte maxPlayersField;
    protected int emptyRoomTtlField;
    protected int playerTtlField;
    protected string[] expectedUsersField;
    protected bool openField;
    protected bool visibleField;
    protected bool autoCleanUpField;
    protected string nameField;
    protected internal int masterClientIdField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private bool <serverSideMasterClient>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private int <PlayerCount>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private bool <IsLocalClientInside>k__BackingField;
    
    // Properties
    public bool removedFromList { get; set; }
    protected internal bool serverSideMasterClient { get; set; }
    public ExitGames.Client.Photon.Hashtable CustomProperties { get; }
    public string Name { get; }
    public int PlayerCount { get; set; }
    public bool IsLocalClientInside { get; set; }
    public byte MaxPlayers { get; }
    public bool IsOpen { get; }
    public bool IsVisible { get; }
    [System.ObsoleteAttribute]
    public ExitGames.Client.Photon.Hashtable customProperties { get; }
    [System.ObsoleteAttribute]
    public string name { get; }
    [System.ObsoleteAttribute]
    public int playerCount { get; set; }
    [System.ObsoleteAttribute]
    public bool isLocalClientInside { get; set; }
    [System.ObsoleteAttribute]
    public byte maxPlayers { get; }
    [System.ObsoleteAttribute]
    public bool open { get; }
    [System.ObsoleteAttribute]
    public bool visible { get; }
    
    // Methods
    protected internal RoomInfo(string roomName, ExitGames.Client.Photon.Hashtable properties)
    {
        this.openField = true;
        this.visibleField = true;
        this.customPropertiesField = new ExitGames.Client.Photon.Hashtable();
        this.autoCleanUpField = PhotonNetwork.autoCleanUpPlayerObjects;
        val_4 = new System.Object();
        this.InternalCacheProperties(propertiesToCache:  ExitGames.Client.Photon.Hashtable val_4 = properties);
        this.nameField = roomName;
    }
    public bool get_removedFromList()
    {
        return (bool)this.<removedFromList>k__BackingField;
    }
    internal void set_removedFromList(bool value)
    {
        this.<removedFromList>k__BackingField = value;
    }
    protected internal bool get_serverSideMasterClient()
    {
        return (bool)this.<serverSideMasterClient>k__BackingField;
    }
    private void set_serverSideMasterClient(bool value)
    {
        this.<serverSideMasterClient>k__BackingField = value;
    }
    public ExitGames.Client.Photon.Hashtable get_CustomProperties()
    {
        return (ExitGames.Client.Photon.Hashtable)this.customPropertiesField;
    }
    public string get_Name()
    {
        return (string)this.nameField;
    }
    public int get_PlayerCount()
    {
        return (int)this.<PlayerCount>k__BackingField;
    }
    private void set_PlayerCount(int value)
    {
        this.<PlayerCount>k__BackingField = value;
    }
    public bool get_IsLocalClientInside()
    {
        return (bool)this.<IsLocalClientInside>k__BackingField;
    }
    public void set_IsLocalClientInside(bool value)
    {
        this.<IsLocalClientInside>k__BackingField = value;
    }
    public byte get_MaxPlayers()
    {
        return (byte)this.maxPlayersField;
    }
    public bool get_IsOpen()
    {
        return (bool)this.openField;
    }
    public bool get_IsVisible()
    {
        return (bool)this.visibleField;
    }
    public override bool Equals(object other)
    {
        if(other == null)
        {
                return false;
        }
        
        return false;
    }
    public override int GetHashCode()
    {
        if(this.nameField == null)
        {
            
        }
    
    }
    public override string ToString()
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = this.nameField;
        bool val_6 = this.visibleField;
        val_6 = val_6 ^ 1;
        var val_2 = (val_6 == true) ? 1 : (val_6);
        var val_3 = null + ((this.visibleField == true ? 1 : (this.visibleField ^ 1)) << 3);
        mem2[0] = (val_6 == true) ? "visible" : "hidden";
        typeof(System.Object[]).__il2cppRuntimeField_30 = (this.openField == true) ? "open" : "closed";
        typeof(System.Object[]).__il2cppRuntimeField_38 = this.maxPlayersField;
        typeof(System.Object[]).__il2cppRuntimeField_39 = 30633359;
        typeof(System.Object[]).__il2cppRuntimeField_40 = this.<PlayerCount>k__BackingField;
        typeof(System.Object[]).__il2cppRuntimeField_44 = 268435457;
        return (string)System.String.Format(format:  0, args:  "Room: \'{0}\' {1},{2} {4}/{3} players.");
    }
    public string ToStringFull()
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = this.nameField;
        bool val_7 = this.visibleField;
        val_7 = val_7 ^ 1;
        var val_2 = (val_7 == true) ? 1 : (val_7);
        var val_3 = null + ((this.visibleField == true ? 1 : (this.visibleField ^ 1)) << 3);
        mem2[0] = (val_7 == true) ? "visible" : "hidden";
        typeof(System.Object[]).__il2cppRuntimeField_30 = (this.openField == true) ? "open" : "closed";
        typeof(System.Object[]).__il2cppRuntimeField_38 = this.maxPlayersField;
        typeof(System.Object[]).__il2cppRuntimeField_39 = 30633956;
        typeof(System.Object[]).__il2cppRuntimeField_40 = this.<PlayerCount>k__BackingField;
        typeof(System.Object[]).__il2cppRuntimeField_44 = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_48 = Extensions.ToStringFull(origin:  0);
        return (string)System.String.Format(format:  0, args:  "Room: \'{0}\' {1},{2} {4}/{3} players.\ncustomProps: {5}");
    }
    protected internal void InternalCacheProperties(ExitGames.Client.Photon.Hashtable propertiesToCache)
    {
        ExitGames.Client.Photon.Hashtable val_43;
        var val_44;
        var val_47;
        var val_48;
        System.String[] val_49;
        if(propertiesToCache == null)
        {
                return;
        }
        
        if(propertiesToCache.Count == 0)
        {
                return;
        }
        
        val_43 = this.customPropertiesField;
        if((val_43.Equals(obj:  propertiesToCache)) == true)
        {
                return;
        }
        
        if((propertiesToCache.ContainsKey(key:  251)) != false)
        {
                object val_5 = propertiesToCache.Item[251];
            val_44 = null;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            this.<removedFromList>k__BackingField = null;
            if(null != null)
        {
                return;
        }
        
        }
        
        if((propertiesToCache.ContainsKey(key:  255)) != false)
        {
                object val_8 = propertiesToCache.Item[255];
            val_47 = null;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y});
            this.maxPlayersField = null;
        }
        
        if((propertiesToCache.ContainsKey(key:  253)) != false)
        {
                object val_11 = propertiesToCache.Item[253];
            val_47 = null;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y});
            this.openField = null;
        }
        
        if((propertiesToCache.ContainsKey(key:  254)) != false)
        {
                object val_14 = propertiesToCache.Item[254];
            val_47 = null;
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y});
            this.visibleField = null;
        }
        
        if((propertiesToCache.ContainsKey(key:  252)) != false)
        {
                object val_17 = propertiesToCache.Item[252];
            val_47 = null;
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y});
            this.<PlayerCount>k__BackingField = null;
        }
        
        if((propertiesToCache.ContainsKey(key:  249)) != false)
        {
                object val_20 = propertiesToCache.Item[249];
            val_47 = null;
            UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y});
            this.autoCleanUpField = null;
        }
        
        if((propertiesToCache.ContainsKey(key:  248)) != false)
        {
                this.<serverSideMasterClient>k__BackingField = true;
            object val_23 = propertiesToCache.Item[248];
            val_47 = null;
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y});
            this.masterClientIdField = null;
            if(this.masterClientIdField != 0)
        {
                val_48 = null;
            val_48 = null;
            PhotonNetwork.networkingPeer.UpdateMasterClient();
        }
        
        }
        
        if((propertiesToCache.ContainsKey(key:  247)) != false)
        {
                object val_26 = propertiesToCache.Item[247];
            val_49 = 0;
            if(val_26 != null)
        {
                val_49 = val_26;
            if(val_49 == null)
        {
                val_49 = 0;
        }
        
        }
        
            this.expectedUsersField = val_49;
        }
        
        if((propertiesToCache.ContainsKey(key:  245)) != false)
        {
                object val_29 = propertiesToCache.Item[245];
            val_47 = null;
            UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y});
            this.emptyRoomTtlField = null;
        }
        
        if((propertiesToCache.ContainsKey(key:  246)) != false)
        {
                object val_32 = propertiesToCache.Item[246];
            val_47 = null;
            UnityEngine.Vector2 val_33 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y});
            this.playerTtlField = null;
        }
        
        val_43 = this.customPropertiesField;
        Extensions.MergeStringKeys(target:  0, addHash:  val_43);
        Extensions.StripKeysWithNullValues(original:  0);
        return;
        label_50:
        goto label_50;
    }
    public ExitGames.Client.Photon.Hashtable get_customProperties()
    {
        return (ExitGames.Client.Photon.Hashtable)this.customPropertiesField;
    }
    public string get_name()
    {
        return (string)this.nameField;
    }
    public int get_playerCount()
    {
        return (int)this.<PlayerCount>k__BackingField;
    }
    public void set_playerCount(int value)
    {
        this.<PlayerCount>k__BackingField = value;
    }
    public bool get_isLocalClientInside()
    {
        return (bool)this.<IsLocalClientInside>k__BackingField;
    }
    public void set_isLocalClientInside(bool value)
    {
        this.<IsLocalClientInside>k__BackingField = value;
    }
    public byte get_maxPlayers()
    {
        return (byte)this.maxPlayersField;
    }
    public bool get_open()
    {
        return (bool)this.openField;
    }
    public bool get_visible()
    {
        return (bool)this.visibleField;
    }

}
