using UnityEngine;
public class PhotonPlayer : IComparable<PhotonPlayer>, IComparable<int>, IEquatable<PhotonPlayer>, IEquatable<int>
{
    // Fields
    private int actorID;
    private string nameField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <UserId>k__BackingField;
    public readonly bool IsLocal;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private bool <IsInactive>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private ExitGames.Client.Photon.Hashtable <CustomProperties>k__BackingField;
    public object TagObject;
    
    // Properties
    public int ID { get; }
    public string NickName { get; set; }
    public string UserId { get; set; }
    public bool IsMasterClient { get; }
    public bool IsInactive { get; set; }
    public ExitGames.Client.Photon.Hashtable CustomProperties { get; set; }
    public ExitGames.Client.Photon.Hashtable AllProperties { get; }
    [System.ObsoleteAttribute]
    public string name { get; set; }
    [System.ObsoleteAttribute]
    public string userId { get; set; }
    [System.ObsoleteAttribute]
    public bool isLocal { get; }
    [System.ObsoleteAttribute]
    public bool isMasterClient { get; }
    [System.ObsoleteAttribute]
    public bool isInactive { get; set; }
    [System.ObsoleteAttribute]
    public ExitGames.Client.Photon.Hashtable customProperties { get; set; }
    [System.ObsoleteAttribute]
    public ExitGames.Client.Photon.Hashtable allProperties { get; }
    
    // Methods
    public PhotonPlayer(bool isLocal, int actorID, string name)
    {
        var val_4;
        this.actorID = 0;
        val_4 = null;
        val_4 = null;
        this.nameField = System.String.Empty;
        val_1 = new System.Object();
        this.nameField = val_1;
        this.<CustomProperties>k__BackingField = new ExitGames.Client.Photon.Hashtable();
        this.actorID = actorID;
        this.IsLocal = isLocal;
    }
    protected internal PhotonPlayer(bool isLocal, int actorID, ExitGames.Client.Photon.Hashtable properties)
    {
        var val_4;
        this.actorID = 0;
        val_4 = null;
        val_4 = null;
        this.nameField = System.String.Empty;
        val_1 = new System.Object();
        this.actorID = actorID;
        this.<CustomProperties>k__BackingField = new ExitGames.Client.Photon.Hashtable();
        this.IsLocal = isLocal;
        this.InternalCacheProperties(properties:  ExitGames.Client.Photon.Hashtable val_1 = properties);
    }
    public int get_ID()
    {
        return (int)this.actorID;
    }
    public string get_NickName()
    {
        return (string)this.nameField;
    }
    public void set_NickName(string value)
    {
        string val_5;
        if(this.IsLocal == false)
        {
            goto label_1;
        }
        
        if((System.String.IsNullOrEmpty(value:  0)) == true)
        {
                return;
        }
        
        val_5 = this.nameField;
        if((value.Equals(value:  val_5)) == false)
        {
            goto label_6;
        }
        
        return;
        label_1:
        UnityEngine.Debug.LogError(message:  0);
        return;
        label_6:
        this.nameField = value;
        PhotonNetwork.playerName = null;
    }
    public string get_UserId()
    {
        return (string)this.<UserId>k__BackingField;
    }
    internal void set_UserId(string value)
    {
        this.<UserId>k__BackingField = value;
    }
    public bool get_IsMasterClient()
    {
        null = null;
        return (bool)(PhotonNetwork.networkingPeer.mMasterClientId == this.actorID) ? 1 : 0;
    }
    public bool get_IsInactive()
    {
        return (bool)this.<IsInactive>k__BackingField;
    }
    public void set_IsInactive(bool value)
    {
        this.<IsInactive>k__BackingField = value;
    }
    public ExitGames.Client.Photon.Hashtable get_CustomProperties()
    {
        return (ExitGames.Client.Photon.Hashtable)this.<CustomProperties>k__BackingField;
    }
    internal void set_CustomProperties(ExitGames.Client.Photon.Hashtable value)
    {
        this.<CustomProperties>k__BackingField = value;
    }
    public ExitGames.Client.Photon.Hashtable get_AllProperties()
    {
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        Extensions.Merge(target:  0, addHash:  val_1);
        set_Item(key:  255, value:  this.nameField);
        return val_1;
    }
    public override bool Equals(object p)
    {
        return false;
    }
    public override int GetHashCode()
    {
        return (int)this.actorID;
    }
    internal void InternalChangeLocalID(int newID)
    {
        if(this.IsLocal != false)
        {
                this.actorID = newID;
            return;
        }
        
        UnityEngine.Debug.LogError(message:  0);
    }
    internal void InternalCacheProperties(ExitGames.Client.Photon.Hashtable properties)
    {
        ExitGames.Client.Photon.Hashtable val_14;
        string val_15;
        string val_16;
        if(properties == null)
        {
                return;
        }
        
        if(properties.Count == 0)
        {
                return;
        }
        
        val_14 = this.<CustomProperties>k__BackingField;
        if((val_14.Equals(obj:  properties)) == true)
        {
                return;
        }
        
        if((properties.ContainsKey(key:  255)) != false)
        {
                object val_5 = properties.Item[255];
            val_15 = 0;
            if(val_5 != null)
        {
                val_15 = val_5;
            if(null != null)
        {
                val_15 = 0;
        }
        
        }
        
            this.nameField = val_15;
        }
        
        if((properties.ContainsKey(key:  253)) != false)
        {
                object val_8 = properties.Item[253];
            val_16 = 0;
            if(val_8 != null)
        {
                val_16 = val_8;
            if(null != null)
        {
                val_16 = 0;
        }
        
        }
        
            this.<UserId>k__BackingField = val_16;
        }
        
        if((properties.ContainsKey(key:  254)) != false)
        {
                object val_11 = properties.Item[254];
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            this.<IsInactive>k__BackingField = null;
        }
        
        val_14 = this.<CustomProperties>k__BackingField;
        Extensions.MergeStringKeys(target:  0, addHash:  val_14);
        Extensions.StripKeysWithNullValues(original:  0);
        return;
        label_17:
        goto label_17;
    }
    public void SetCustomProperties(ExitGames.Client.Photon.Hashtable propertiesToSet, ExitGames.Client.Photon.Hashtable expectedValues, bool webForward = False)
    {
        ExitGames.Client.Photon.Hashtable val_10;
        var val_11;
        var val_12;
        ExitGames.Client.Photon.Hashtable val_13;
        var val_14;
        NetworkingPeer val_15;
        val_10 = propertiesToSet;
        if(val_10 == null)
        {
                return;
        }
        
        val_10 = Extensions.StripToStringKeys(original:  0);
        ExitGames.Client.Photon.Hashtable val_2 = Extensions.StripToStringKeys(original:  0);
        if(val_2 != null)
        {
                var val_4 = (val_2.Count == 0) ? 1 : 0;
        }
        else
        {
                val_11 = 1;
        }
        
        if(this.actorID >= 1)
        {
                val_12 = PhotonNetwork.offlineMode ^ 1;
        }
        else
        {
                val_12 = 0;
        }
        
        if(val_11 != 0)
        {
                val_13 = this.<CustomProperties>k__BackingField;
            Extensions.Merge(target:  0, addHash:  val_13);
            Extensions.StripKeysWithNullValues(original:  0);
        }
        
        if((val_12 & 1) != 0)
        {
                val_14 = null;
            val_14 = null;
            val_15 = PhotonNetwork.networkingPeer;
            bool val_7 = val_15.OpSetPropertiesOfActor(actorNr:  this.actorID, actorProperties:  val_10, expectedProperties:  val_2, webForward:  webForward);
            if(val_11 == 0)
        {
                return;
        }
        
        }
        
        this.InternalCacheProperties(properties:  val_10);
        typeof(System.Object[]).__il2cppRuntimeField_20 = this;
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_10;
        NetworkingPeer.SendMonoMessage(methodString:  0, parameters:  21);
    }
    public static PhotonPlayer Find(int ID)
    {
        var val_1;
        NetworkingPeer val_2;
        val_1 = null;
        val_1 = null;
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 == null)
        {
                return 0;
        }
        
        val_2 = PhotonNetwork.networkingPeer;
        if(val_2 != null)
        {
                return val_2.GetPlayerWithId(number:  W1);
        }
        
        val_2 = 0;
        return val_2.GetPlayerWithId(number:  W1);
    }
    public PhotonPlayer Get(int id)
    {
        return PhotonPlayer.Find(ID:  -766795120);
    }
    public PhotonPlayer GetNext()
    {
        return this.GetNextFor(currentPlayerId:  this.actorID);
    }
    public PhotonPlayer GetNextFor(PhotonPlayer currentPlayer)
    {
        if(currentPlayer == null)
        {
                return 0;
        }
        
        return this.GetNextFor(currentPlayerId:  currentPlayer.actorID);
    }
    public PhotonPlayer GetNextFor(int currentPlayerId)
    {
        var val_6;
        var val_7;
        var val_8;
        NetworkingPeer val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        int val_14;
        val_6 = currentPlayerId;
        val_7 = 1152921504973725696;
        val_8 = null;
        val_8 = null;
        val_9 = PhotonNetwork.networkingPeer;
        if(val_9 == null)
        {
            goto label_12;
        }
        
        val_9 = PhotonNetwork.networkingPeer;
        if(val_9 == null)
        {
            goto label_6;
        }
        
        if(null == 0)
        {
            goto label_12;
        }
        
        val_10 = null;
        val_10 = null;
        if(Count < 2)
        {
            goto label_12;
        }
        
        val_11 = null;
        val_11 = null;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = Keys.GetEnumerator();
        val_7 = 2147483647;
        goto label_21;
        label_20:
        int val_4 = (val_3.host_enumerator.current.Value > val_7) ? val_3.host_enumerator.current.Value : (val_7);
        label_21:
        if((0 & 1) == 0)
        {
            goto label_19;
        }
        
        if( >= val_6)
        {
            goto label_20;
        }
        
        goto label_21;
        label_12:
        val_12 = 0;
        return (PhotonPlayer)Item[val_14];
        label_19:
        val_6 = 0;
        val_13 = 1;
        if(val_4 == 2147483647)
        {
                val_14 = val_6;
            return (PhotonPlayer)Item[val_14];
        }
        
        val_14 = val_4;
        return (PhotonPlayer)Item[val_14];
        label_6:
    }
    public int CompareTo(PhotonPlayer other)
    {
        if(other == null)
        {
                return (int)0;
        }
        
        0;
        return (int)0;
    }
    public int CompareTo(int other)
    {
        return -766214388;
    }
    public bool Equals(PhotonPlayer other)
    {
        if(other != null)
        {
                bool val_1 = this.Equals(obj:  other);
            0 = val_1;
        }
        
        val_1 = 0;
        return (bool)val_1;
    }
    public bool Equals(int other)
    {
        return (bool)this.Equals(obj:  other);
    }
    public override string ToString()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_3;
        }
        
        var val_2 = ((this.<IsInactive>k__BackingField) == true) ? " (inactive)" : " ";
        bool val_3 = this.IsMasterClient;
        val_15 = null;
        if(val_3 == false)
        {
            goto label_4;
        }
        
        val_19 = "(master)";
        val_18 = val_2;
        val_17 = this.actorID;
        val_16 = "#{0:00}{1}{2}";
        return (string)System.String.Format(format:  0, arg0:  (val_3 != true) ? 0 : "#{0:00}{1}{2}", arg1:  (val_3 != true) ? 0 : this.actorID, arg2:  (val_3 != true) ? 0 : (val_2));
        label_3:
        var val_8 = ((this.<IsInactive>k__BackingField) == true) ? " (inactive)" : " ";
        bool val_9 = this.IsMasterClient;
        val_20 = null;
        if(val_9 == false)
        {
            goto label_6;
        }
        
        val_24 = "(master)";
        val_21 = val_8;
        val_22 = this.nameField;
        val_23 = "\'{0}\'{1}{2}";
        return System.String.Format(format:  0, arg0:  (val_9 != true) ? 0 : "\'{0}\'{1}{2}", arg1:  (val_9 != true) ? 0 : this.nameField, arg2:  (val_9 != true) ? 0 : (val_8));
        label_4:
        val_15 = null;
        return (string)System.String.Format(format:  0, arg0:  (val_3 != true) ? 0 : "#{0:00}{1}{2}", arg1:  (val_3 != true) ? 0 : this.actorID, arg2:  (val_3 != true) ? 0 : (val_2));
        label_6:
        val_20 = null;
        return System.String.Format(format:  0, arg0:  (val_9 != true) ? 0 : "\'{0}\'{1}{2}", arg1:  (val_9 != true) ? 0 : this.nameField, arg2:  (val_9 != true) ? 0 : (val_8));
    }
    public string ToStringFull()
    {
        var val_7;
        var val_8;
        var val_9;
        string val_10;
        var val_11;
        typeof(System.Object[]).__il2cppRuntimeField_20 = this.actorID;
        typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_28 = this.nameField;
        var val_2 = ((this.<IsInactive>k__BackingField) == true) ? 0 : 2;
        if((this.<IsInactive>k__BackingField) != false)
        {
                val_8 = 2;
            val_9 = "#{0:00} \'{1}\'{2} {3}";
            val_7 = null;
            val_10 = " (inactive)";
        }
        else
        {
                val_11 = null;
            val_11 = null;
            val_10 = System.String.Empty;
            if((((this.<IsInactive>k__BackingField) == true) ? 0 : (null)) == 0)
        {
                val_7 = 0;
        }
        
        }
        
        var val_4 = val_7 + ((this.<IsInactive>k__BackingField == true ? 0 : 2) << 3);
        mem2[0] = val_10;
        mem[56] = Extensions.ToStringFull(origin:  0);
        return (string)System.String.Format(format:  0, args:  ((this.<IsInactive>k__BackingField) == true) ? 0 : "#{0:00} \'{1}\'{2} {3}");
    }
    public string get_name()
    {
        return (string)this.nameField;
    }
    public void set_name(string value)
    {
        this.NickName = value;
    }
    public string get_userId()
    {
        return (string)this.<UserId>k__BackingField;
    }
    internal void set_userId(string value)
    {
        this.<UserId>k__BackingField = value;
    }
    public bool get_isLocal()
    {
        return (bool)this.IsLocal;
    }
    public bool get_isMasterClient()
    {
        return this.IsMasterClient;
    }
    public bool get_isInactive()
    {
        return (bool)this.<IsInactive>k__BackingField;
    }
    public void set_isInactive(bool value)
    {
        this.<IsInactive>k__BackingField = value;
    }
    public ExitGames.Client.Photon.Hashtable get_customProperties()
    {
        return (ExitGames.Client.Photon.Hashtable)this.<CustomProperties>k__BackingField;
    }
    internal void set_customProperties(ExitGames.Client.Photon.Hashtable value)
    {
        this.<CustomProperties>k__BackingField = value;
    }
    public ExitGames.Client.Photon.Hashtable get_allProperties()
    {
        return this.AllProperties;
    }

}
