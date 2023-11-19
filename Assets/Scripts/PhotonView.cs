using UnityEngine;
[UnityEngine.AddComponentMenu]
public class PhotonView : MonoBehaviour
{
    // Fields
    public int ownerId;
    public byte group;
    protected internal bool mixedModeIsReliable;
    public bool OwnerShipWasTransfered;
    public int prefixBackup;
    internal object[] instantiationDataField;
    protected internal object[] lastOnSerializeDataSent;
    protected internal object[] lastOnSerializeDataReceived;
    public ViewSynchronization synchronization;
    public OnSerializeTransform onSerializeTransformOption;
    public OnSerializeRigidBody onSerializeRigidBodyOption;
    public OwnershipOption ownershipTransfer;
    public System.Collections.Generic.List<UnityEngine.Component> ObservedComponents;
    private System.Collections.Generic.Dictionary<UnityEngine.Component, System.Reflection.MethodInfo> m_OnSerializeMethodInfos;
    [UnityEngine.SerializeField]
    private int viewIdField;
    public int instantiationId;
    public int currentMasterID;
    protected internal bool didAwake;
    [UnityEngine.SerializeField]
    protected internal bool isRuntimeInstantiated;
    protected internal bool removedFromLocalViewList;
    internal UnityEngine.MonoBehaviour[] RpcMonoBehaviours;
    private System.Reflection.MethodInfo OnSerializeMethodInfo;
    private bool failedToFindOnSerialize;
    
    // Properties
    public int prefix { get; set; }
    public object[] instantiationData { get; set; }
    public int viewID { get; set; }
    public bool isSceneView { get; }
    public PhotonPlayer owner { get; }
    public int OwnerActorNr { get; }
    public bool isOwnerActive { get; }
    public int CreatorActorNr { get; }
    public bool isMine { get; }
    
    // Methods
    public PhotonView()
    {
        this.prefixBackup = 0;
        this.onSerializeTransformOption = 3;
        this.onSerializeRigidBodyOption = 2;
        this.currentMasterID = 0;
        this.m_OnSerializeMethodInfos = new System.Collections.Generic.Dictionary<UnityEngine.Component, System.Reflection.MethodInfo>(capacity:  3);
        this = new UnityEngine.MonoBehaviour();
    }
    public int get_prefix()
    {
        int val_1;
        var val_2;
        NetworkingPeer val_3;
        val_1 = this.prefixBackup;
        if(val_1 != 1)
        {
                return val_1;
        }
        
        val_2 = null;
        val_2 = null;
        val_3 = PhotonNetwork.networkingPeer;
        if(val_3 == null)
        {
            goto label_4;
        }
        
        val_3 = PhotonNetwork.networkingPeer;
        if(val_3 == null)
        {
            goto label_7;
        }
        
        val_1 = mem[PhotonNetwork.networkingPeer + 512];
        val_1 = PhotonNetwork.networkingPeer.currentLevelPrefix;
        this.prefixBackup = val_1;
        return val_1;
        label_4:
        val_1 = this.prefixBackup;
        return val_1;
        label_7:
    }
    public void set_prefix(int value)
    {
        this.prefixBackup = value;
    }
    public object[] get_instantiationData()
    {
        System.Object[] val_2;
        var val_3;
        if(this.didAwake != false)
        {
                val_2 = this.instantiationDataField;
            return val_1;
        }
        
        val_3 = null;
        val_3 = null;
        System.Object[] val_1 = PhotonNetwork.networkingPeer.FetchInstantiationData(instantiationId:  this.instantiationId);
        this.instantiationDataField = val_1;
        return val_1;
    }
    public void set_instantiationData(object[] value)
    {
        this.instantiationDataField = value;
    }
    public int get_viewID()
    {
        return (int)this.viewIdField;
    }
    public void set_viewID(int value)
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = 6;
        val_3 = null;
        val_3 = null;
        int val_2 = PhotonNetwork.MAX_VIEW_IDS;
        this.viewIdField = value;
        val_2 = value / val_2;
        this.ownerId = val_2;
        if(((this.viewIdField == 0) ? 0 : (val_2)) != 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        PhotonNetwork.networkingPeer.RegisterPhotonView(netView:  this);
    }
    public bool get_isSceneView()
    {
        return (bool)(this.CreatorActorNr == 0) ? 1 : 0;
    }
    public PhotonPlayer get_owner()
    {
        return PhotonPlayer.Find(ID:  -761249664);
    }
    public int get_OwnerActorNr()
    {
        return (int)this.ownerId;
    }
    public bool get_isOwnerActive()
    {
        var val_1;
        if(this.ownerId == 0)
        {
                return false;
        }
        
        val_1 = null;
        val_1 = null;
        if(null != 0)
        {
                return ContainsKey(key:  this.ownerId);
        }
        
        return ContainsKey(key:  this.ownerId);
    }
    public int get_CreatorActorNr()
    {
        null = null;
        return (int)this.viewIdField / PhotonNetwork.MAX_VIEW_IDS;
    }
    public bool get_isMine()
    {
        var val_4;
        PhotonPlayer val_1 = PhotonNetwork.player;
        if(this.ownerId == val_1.actorID)
        {
                val_4 = 1;
            return (bool)val_4;
        }
        
        if(this.isOwnerActive == false)
        {
                return PhotonNetwork.isMasterClient;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    protected internal void Awake()
    {
        var val_2;
        if(this.viewIdField != 0)
        {
                val_2 = null;
            val_2 = null;
            PhotonNetwork.networkingPeer.RegisterPhotonView(netView:  this);
            this.instantiationDataField = PhotonNetwork.networkingPeer.FetchInstantiationData(instantiationId:  this.instantiationId);
        }
        
        this.didAwake = true;
    }
    public void RequestOwnership()
    {
        null = null;
        PhotonNetwork.networkingPeer.RequestOwnership(viewID:  this.viewIdField, fromOwner:  this.ownerId);
    }
    public void TransferOwnership(PhotonPlayer newOwner)
    {
        this.TransferOwnership(newOwnerId:  newOwner.actorID);
    }
    public void TransferOwnership(int newOwnerId)
    {
        null = null;
        PhotonNetwork.networkingPeer.TransferOwnership(viewID:  this.viewIdField, playerID:  newOwnerId);
        this.ownerId = newOwnerId;
    }
    public void OnMasterClientSwitched(PhotonPlayer newMasterClient)
    {
        if((this.CreatorActorNr == 0) && (this.OwnerShipWasTransfered != true))
        {
                if(this.currentMasterID != 1)
        {
                if(this.ownerId != this.currentMasterID)
        {
            goto label_3;
        }
        
        }
        
            this.ownerId = newMasterClient.actorID;
        }
        else
        {
                label_3:
        }
        
        this.currentMasterID = newMasterClient.actorID;
    }
    protected internal void OnDestroy()
    {
        var val_5;
        var val_6;
        var val_7;
        if(this.removedFromLocalViewList == true)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if((PhotonNetwork.networkingPeer.LocalCleanPhotonView(view:  this)) == false)
        {
                return;
        }
        
        if(this.instantiationId < 1)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(PhotonHandler.AppQuits == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(PhotonNetwork.logLevel < 1)
        {
                return;
        }
        
        string val_4 = 0 + "PUN-instantiated \'"("PUN-instantiated \'") + this.gameObject.name;
        UnityEngine.Debug.Log(message:  0);
    }
    public void SerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        var val_4;
        var val_5;
        val_4 = 1152921512436958032;
        if(this.ObservedComponents == null)
        {
                return;
        }
        
        if(this.ObservedComponents.Count < 1)
        {
                return;
        }
        
        val_5 = 0;
        goto label_3;
        label_7:
        this.SerializeComponent(component:  X23.Item[0], stream:  stream, info:  new PhotonMessageInfo() {timeInt = info.timeInt, photonView = info.photonView});
        val_5 = 1;
        label_3:
        if(val_5 >= this.ObservedComponents.Count)
        {
                return;
        }
        
        if(this.ObservedComponents != null)
        {
            goto label_7;
        }
        
        goto label_7;
    }
    public void DeserializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        var val_4;
        var val_5;
        val_4 = 1152921512437135472;
        if(this.ObservedComponents == null)
        {
                return;
        }
        
        if(this.ObservedComponents.Count < 1)
        {
                return;
        }
        
        val_5 = 0;
        goto label_3;
        label_7:
        this.DeserializeComponent(component:  X23.Item[0], stream:  stream, info:  new PhotonMessageInfo() {timeInt = info.timeInt, photonView = info.photonView});
        val_5 = 1;
        label_3:
        if(val_5 >= this.ObservedComponents.Count)
        {
                return;
        }
        
        if(this.ObservedComponents != null)
        {
            goto label_7;
        }
        
        goto label_7;
    }
    protected internal void DeserializeComponent(UnityEngine.Component component, PhotonStream stream, PhotonMessageInfo info)
    {
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        PhotonStream val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        val_51 = 1152921512437378608;
        val_52 = stream;
        val_53 = this;
        if(0 == component)
        {
                return;
        }
        
        if(component == null)
        {
            goto label_4;
        }
        
        if(null == null)
        {
            goto label_9;
        }
        
        if(null == null)
        {
            goto label_10;
        }
        
        label_4:
        UnityEngine.Debug.LogError(message:  0);
        return;
        label_9:
        if(this.onSerializeRigidBodyOption == 0)
        {
            goto label_13;
        }
        
        if(this.onSerializeRigidBodyOption == 1)
        {
            goto label_14;
        }
        
        if(this.onSerializeRigidBodyOption != 2)
        {
                return;
        }
        
        val_54 = val_52.ReceiveNext();
        val_50 = 1152921504719785984;
        val_51 = null;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        component.velocity = new UnityEngine.Vector3() {x = 7.461634E-41f, y = val_5.y};
        val_55 = val_52.ReceiveNext();
        val_53 = null;
        ExecuteComponentOnSerialize(component:  component, stream:  val_55, info:  new PhotonMessageInfo() {timeInt = new UnityEngine.Vector3(), sender = new UnityEngine.Vector3(), photonView = UnityEngine.Vector3.__il2cppRuntimeField_name});
        return;
        label_10:
        if(this.onSerializeRigidBodyOption == 0)
        {
            goto label_25;
        }
        
        if(this.onSerializeRigidBodyOption == 1)
        {
            goto label_26;
        }
        
        if(this.onSerializeRigidBodyOption != 2)
        {
                return;
        }
        
        val_54 = val_52.ReceiveNext();
        val_51 = null;
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        component.velocity = new UnityEngine.Vector2() {x = 7.461634E-41f, y = val_9.y};
        val_56 = val_52.ReceiveNext();
        val_53 = null;
        var val_13 = (typeof(System.Single).__il2cppRuntimeField_4C < 5) ? ((typeof(System.Single).__il2cppRuntimeField_4C + 9)) : 0;
        val_13 = val_13 - 9;
        if(val_13 > 4)
        {
                return;
        }
        
        goto (25819164 + ((typeof(System.Single).__il2cppRuntimeField_4C < 0x5 ? (typeof(System.Single).__il2cppRuntimeField_4C + 9) : 0 - 9)) << 2 + 25819164);
        label_14:
        val_58 = val_52.ReceiveNext();
        val_57 = null;
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        component.angularVelocity = new UnityEngine.Vector3() {x = 7.461634E-41f, y = val_17.y};
        return;
        label_13:
        object val_18 = val_52.ReceiveNext();
        val_57 = null;
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        component.velocity = new UnityEngine.Vector3() {x = 7.461634E-41f, y = val_19.y};
        return;
        label_26:
        val_59 = val_52.ReceiveNext();
        val_57 = null;
        UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        component.angularVelocity = 7.461634E-41f;
        return;
        label_25:
        object val_22 = val_52.ReceiveNext();
        val_57 = null;
        UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        component.velocity = new UnityEngine.Vector2() {x = 7.461634E-41f, y = val_23.y};
    }
    protected internal void SerializeComponent(UnityEngine.Component component, PhotonStream stream, PhotonMessageInfo info)
    {
        object val_19;
        var val_20;
        val_19 = this;
        if(0 == component)
        {
                return;
        }
        
        if(component == null)
        {
            goto label_4;
        }
        
        if(null == null)
        {
            goto label_9;
        }
        
        if(null != null)
        {
            goto label_10;
        }
        
        if(this.onSerializeRigidBodyOption == 0)
        {
            goto label_11;
        }
        
        if(this.onSerializeRigidBodyOption == 1)
        {
            goto label_12;
        }
        
        if(this.onSerializeRigidBodyOption != 2)
        {
                return;
        }
        
        UnityEngine.Vector2 val_4 = component.velocity;
        val_19 = val_4;
        stream.SendNext(obj:  val_4);
        float val_5 = component.angularVelocity;
        val_20 = null;
        goto label_28;
        label_4:
        label_10:
        System.Type val_6 = component.GetType();
        string val_7 = 0 + "Observed type is not serializable: "("Observed type is not serializable: ");
        UnityEngine.Debug.LogError(message:  0);
        return;
        label_9:
        if(this.onSerializeRigidBodyOption == 0)
        {
            goto label_22;
        }
        
        if(this.onSerializeRigidBodyOption == 1)
        {
            goto label_23;
        }
        
        if(this.onSerializeRigidBodyOption != 2)
        {
                return;
        }
        
        UnityEngine.Vector3 val_8 = component.velocity;
        val_19 = val_8;
        stream.SendNext(obj:  val_8);
        UnityEngine.Vector3 val_9 = component.angularVelocity;
        val_20 = null;
        goto label_28;
        label_22:
        UnityEngine.Vector3 val_12 = component.velocity;
        goto label_36;
        label_23:
        UnityEngine.Vector3 val_13 = component.angularVelocity;
        goto label_36;
        label_11:
        UnityEngine.Vector2 val_14 = component.velocity;
        val_20 = null;
        goto label_42;
        label_12:
        float val_15 = component.angularVelocity;
        val_20 = null;
        goto label_42;
        label_36:
        val_20 = null;
        label_42:
        label_28:
        stream.SendNext(obj:  val_18);
    }
    protected internal void ExecuteComponentOnSerialize(UnityEngine.Component component, PhotonStream stream, PhotonMessageInfo info)
    {
        var val_14;
        var val_15;
        var val_16;
        System.Reflection.MethodInfo val_17;
        val_14 = 1152921512437875280;
        if(component != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = component;
            return;
        }
        
        if(0 == component)
        {
                return;
        }
        
        System.Reflection.MethodInfo val_2 = 0;
        if((this.m_OnSerializeMethodInfos.TryGetValue(key:  component, value: out  val_2)) != true)
        {
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_16 = 0;
            if((NetworkingPeer.GetMethod(monob:  0, methodType:  null, mi: out  17.ToString())) != false)
        {
                val_17 = val_2;
        }
        else
        {
                string val_12 = 0 + "The observed monobehaviour (" + component.name;
            UnityEngine.Debug.LogError(message:  0);
            val_17 = 0;
        }
        
            this.m_OnSerializeMethodInfos.Add(key:  component, value:  val_17);
        }
        
        if(0 == 0)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = stream;
        typeof(System.Object[]).__il2cppRuntimeField_28 = info.timeInt;
        object val_13 = 0.Invoke(obj:  component, parameters:  null);
    }
    public void RefreshRpcMonoBehaviourCache()
    {
        this.RpcMonoBehaviours = this.GetComponents<UnityEngine.MonoBehaviour>();
    }
    public void RPC(string methodName, PhotonTargets target, object[] parameters)
    {
        PhotonNetwork.RPC(view:  null, methodName:  this, target:  methodName, encrypt:  target, reliable:  false, parameters:  1);
    }
    public void UnreliableRPC(string methodName, PhotonTargets target, object[] parameters)
    {
        PhotonNetwork.RPC(view:  null, methodName:  this, target:  methodName, encrypt:  target, reliable:  false, parameters:  0);
    }
    public void RpcSecure(string methodName, PhotonTargets target, bool encrypt, object[] parameters)
    {
        PhotonNetwork.RPC(view:  null, methodName:  this, target:  methodName, encrypt:  target, reliable:  encrypt, parameters:  1);
    }
    public void RPC(string methodName, PhotonPlayer targetPlayer, object[] parameters)
    {
        PhotonNetwork.RPC(view:  null, methodName:  this, targetPlayer:  methodName, encrpyt:  targetPlayer, reliable:  false, parameters:  1);
    }
    public void UnreliableRPC(string methodName, PhotonPlayer targetPlayer, object[] parameters)
    {
        PhotonNetwork.RPC(view:  null, methodName:  this, targetPlayer:  methodName, encrpyt:  targetPlayer, reliable:  false, parameters:  0);
    }
    public void RpcSecure(string methodName, PhotonPlayer targetPlayer, bool encrypt, object[] parameters)
    {
        PhotonNetwork.RPC(view:  null, methodName:  this, targetPlayer:  methodName, encrpyt:  targetPlayer, reliable:  encrypt, parameters:  1);
    }
    public static PhotonView Get(UnityEngine.Component component)
    {
        if(X1 != 0)
        {
                return X1.GetComponent<PhotonView>();
        }
        
        return X1.GetComponent<PhotonView>();
    }
    public static PhotonView Get(UnityEngine.GameObject gameObj)
    {
        if(X1 != 0)
        {
                return X1.GetComponent<PhotonView>();
        }
        
        return X1.GetComponent<PhotonView>();
    }
    public static PhotonView Find(int viewID)
    {
        null = null;
        if(PhotonNetwork.networkingPeer != null)
        {
                return PhotonNetwork.networkingPeer.GetPhotonView(viewID:  W1);
        }
        
        return PhotonNetwork.networkingPeer.GetPhotonView(viewID:  W1);
    }
    public override string ToString()
    {
        var val_11;
        var val_12;
        System.Object[] val_13;
        var val_14;
        var val_15;
        string val_16;
        typeof(System.Object[]).__il2cppRuntimeField_20 = this.viewIdField;
        typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
        if(0 != this.gameObject)
        {
                val_11 = this.gameObject.name;
        }
        else
        {
                val_11 = "GO==null";
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_11;
        int val_5 = this.CreatorActorNr;
        var val_7 = (val_5 == 0) ? 0 : "View ({3}){0} on {1} {2}";
        var val_8 = (val_5 == 0) ? 0 : 2;
        if(val_5 == 0)
        {
            goto label_14;
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = System.String.Empty;
        if(((val_5 == 0) ? 0 : (null)) != 0)
        {
            goto label_18;
        }
        
        val_12 = 0;
        goto label_18;
        label_14:
        val_14 = 2;
        val_13 = "View ({3}){0} on {1} {2}";
        val_12 = null;
        val_16 = "(scene)";
        label_18:
        System.Object[].__il2cppRuntimeField_name.__il2cppRuntimeField_20 = val_16;
        typeof(System.Object[]).__il2cppRuntimeField_38 = this.prefix;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        return (string)System.String.Format(format:  0, args:  val_13);
    }

}
