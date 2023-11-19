using UnityEngine;
public class RoomOptions
{
    // Fields
    private bool isVisibleField;
    private bool isOpenField;
    public byte MaxPlayers;
    public int PlayerTtl;
    public int EmptyRoomTtl;
    private bool cleanupCacheOnLeaveField;
    public ExitGames.Client.Photon.Hashtable CustomRoomProperties;
    public string[] CustomRoomPropertiesForLobby;
    public string[] Plugins;
    private bool suppressRoomEventsField;
    private bool publishUserIdField;
    private bool deleteNullPropertiesField;
    
    // Properties
    public bool IsVisible { get; set; }
    public bool IsOpen { get; set; }
    public bool CleanupCacheOnLeave { get; set; }
    public bool SuppressRoomEvents { get; }
    public bool PublishUserId { get; set; }
    public bool DeleteNullProperties { get; set; }
    [System.ObsoleteAttribute]
    public bool isVisible { get; set; }
    [System.ObsoleteAttribute]
    public bool isOpen { get; set; }
    [System.ObsoleteAttribute]
    public byte maxPlayers { get; set; }
    [System.ObsoleteAttribute]
    public bool cleanupCacheOnLeave { get; set; }
    [System.ObsoleteAttribute]
    public ExitGames.Client.Photon.Hashtable customRoomProperties { get; set; }
    [System.ObsoleteAttribute]
    public string[] customRoomPropertiesForLobby { get; set; }
    [System.ObsoleteAttribute]
    public string[] plugins { get; set; }
    [System.ObsoleteAttribute]
    public bool suppressRoomEvents { get; }
    [System.ObsoleteAttribute]
    public bool publishUserId { get; set; }
    
    // Methods
    public RoomOptions()
    {
        this.isVisibleField = true;
        this.isOpenField = true;
        this.cleanupCacheOnLeaveField = PhotonNetwork.autoCleanUpPlayerObjects;
        this.CustomRoomPropertiesForLobby = null;
    }
    public bool get_IsVisible()
    {
        return (bool)this.isVisibleField;
    }
    public void set_IsVisible(bool value)
    {
        this.isVisibleField = value;
    }
    public bool get_IsOpen()
    {
        return (bool)this.isOpenField;
    }
    public void set_IsOpen(bool value)
    {
        this.isOpenField = value;
    }
    public bool get_CleanupCacheOnLeave()
    {
        return (bool)this.cleanupCacheOnLeaveField;
    }
    public void set_CleanupCacheOnLeave(bool value)
    {
        this.cleanupCacheOnLeaveField = value;
    }
    public bool get_SuppressRoomEvents()
    {
        return (bool)this.suppressRoomEventsField;
    }
    public bool get_PublishUserId()
    {
        return (bool)this.publishUserIdField;
    }
    public void set_PublishUserId(bool value)
    {
        this.publishUserIdField = value;
    }
    public bool get_DeleteNullProperties()
    {
        return (bool)this.deleteNullPropertiesField;
    }
    public void set_DeleteNullProperties(bool value)
    {
        this.deleteNullPropertiesField = value;
    }
    public bool get_isVisible()
    {
        return (bool)this.isVisibleField;
    }
    public void set_isVisible(bool value)
    {
        this.isVisibleField = value;
    }
    public bool get_isOpen()
    {
        return (bool)this.isOpenField;
    }
    public void set_isOpen(bool value)
    {
        this.isOpenField = value;
    }
    public byte get_maxPlayers()
    {
        return (byte)this.MaxPlayers;
    }
    public void set_maxPlayers(byte value)
    {
        this.MaxPlayers = value;
    }
    public bool get_cleanupCacheOnLeave()
    {
        return (bool)this.cleanupCacheOnLeaveField;
    }
    public void set_cleanupCacheOnLeave(bool value)
    {
        this.cleanupCacheOnLeaveField = value;
    }
    public ExitGames.Client.Photon.Hashtable get_customRoomProperties()
    {
        return (ExitGames.Client.Photon.Hashtable)this.CustomRoomProperties;
    }
    public void set_customRoomProperties(ExitGames.Client.Photon.Hashtable value)
    {
        this.CustomRoomProperties = value;
    }
    public string[] get_customRoomPropertiesForLobby()
    {
        return (System.String[])this.CustomRoomPropertiesForLobby;
    }
    public void set_customRoomPropertiesForLobby(string[] value)
    {
        this.CustomRoomPropertiesForLobby = value;
    }
    public string[] get_plugins()
    {
        return (System.String[])this.Plugins;
    }
    public void set_plugins(string[] value)
    {
        this.Plugins = value;
    }
    public bool get_suppressRoomEvents()
    {
        return (bool)this.suppressRoomEventsField;
    }
    public bool get_publishUserId()
    {
        return (bool)this.publishUserIdField;
    }
    public void set_publishUserId(bool value)
    {
        this.publishUserIdField = value;
    }

}
