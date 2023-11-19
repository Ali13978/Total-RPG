using UnityEngine;
[UnityEngine.RequireComponent]
public class PickupItem : MonoBehaviour, IPunObservable
{
    // Fields
    public float SecondsBeforeRespawn;
    public bool PickupOnTrigger;
    public bool PickupIsMine;
    public UnityEngine.MonoBehaviour OnPickedUpCall;
    public bool SentPickup;
    public double TimeOfRespawn;
    public static System.Collections.Generic.HashSet<PickupItem> DisabledPickupItems;
    
    // Properties
    public int ViewID { get; }
    
    // Methods
    public PickupItem()
    {
        this.SecondsBeforeRespawn = 2f;
        val_1 = new UnityEngine.MonoBehaviour();
    }
    public int get_ViewID()
    {
        if(this.photonView != null)
        {
                return (int)val_1.viewIdField;
        }
        
        return (int)val_1.viewIdField;
    }
    public void OnTriggerEnter(UnityEngine.Collider other)
    {
        PhotonView val_1 = other.GetComponent<PhotonView>();
        if(this.PickupOnTrigger == false)
        {
                return;
        }
        
        if(0 == val_1)
        {
                return;
        }
        
        if(val_1.isMine == false)
        {
                return;
        }
        
        this.Pickup();
    }
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if(stream.write != false)
        {
                if(this.SecondsBeforeRespawn <= 0f)
        {
            goto label_3;
        }
        
        }
        
        object val_1 = stream.ReceiveNext();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.SecondsBeforeRespawn});
        this.gameObject.transform.position = new UnityEngine.Vector3() {x = 7.461634E-41f, y = V9.16B, z = V10.16B};
        return;
        label_3:
        UnityEngine.Vector3 val_7 = this.gameObject.transform.position;
        stream.SendNext(obj:  val_7);
    }
    public void Pickup()
    {
        if(this.SentPickup != false)
        {
                return;
        }
        
        this.SentPickup = true;
        this.photonView.RPC(methodName:  "PunPickup", target:  5, parameters:  null);
    }
    public void Drop()
    {
        if(this.PickupIsMine == false)
        {
                return;
        }
        
        this.photonView.RPC(methodName:  "PunRespawn", target:  5, parameters:  null);
    }
    public void Drop(UnityEngine.Vector3 newPosition)
    {
        if(this.PickupIsMine == false)
        {
                return;
        }
        
        this = this.photonView;
        typeof(System.Object[]).__il2cppRuntimeField_20 = newPosition;
        this.RPC(methodName:  "PunRespawn", target:  5, parameters:  null);
    }
    [TzarRPC]
    public void PunPickup(PhotonMessageInfo msgInfo)
    {
        object val_10;
        UnityEngine.MonoBehaviour val_11;
        val_10 = this;
        if(msgInfo.sender.IsLocal != false)
        {
                this.SentPickup = false;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        if((GameObjectExtensions.GetActive(target:  0)) == false)
        {
            goto label_3;
        }
        
        this.PickupIsMine = msgInfo.sender.IsLocal;
        val_11 = this.OnPickedUpCall;
        if(0 != val_11)
        {
                val_11 = this.OnPickedUpCall;
            val_11.SendMessage(methodName:  "OnPickedUp", value:  this);
        }
        
        if(this.SecondsBeforeRespawn <= 0f)
        {
            goto label_9;
        }
        
        double val_5 = PhotonNetwork.time;
        double val_10 = (double)msgInfo.timeInt;
        val_10 = val_10 / (-1000);
        val_5 = val_5 + val_10;
        val_5 = (double)this.SecondsBeforeRespawn - val_5;
        if(val_5 <= 0f)
        {
                return;
        }
        
        goto label_13;
        label_3:
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Ignored PU RPC, cause item is inactive. ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = this.gameObject;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " SecondsBeforeRespawn: ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = this.SecondsBeforeRespawn;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_40 = " TimeOfRespawn: ";
        typeof(System.Object[]).__il2cppRuntimeField_48 = this.TimeOfRespawn;
        val_11 = " respawn in future: ";
        typeof(System.Object[]).__il2cppRuntimeField_50 = val_11;
        typeof(System.Object[]).__il2cppRuntimeField_58 = (this.TimeOfRespawn > PhotonNetwork.time) ? 1 : 0;
        typeof(System.Object[]).__il2cppRuntimeField_59 = 30748309;
        val_10 = +0;
        UnityEngine.Debug.Log(message:  0);
        return;
        label_9:
        label_13:
        this.PickedUp(timeUntilRespawn:  0f);
    }
    internal void PickedUp(float timeUntilRespawn)
    {
        var val_4;
        this.gameObject.SetActive(value:  false);
        val_4 = null;
        val_4 = null;
        bool val_2 = PickupItem.DisabledPickupItems.Add(item:  this);
        this.TimeOfRespawn = 0;
        if(timeUntilRespawn <= 0f)
        {
                return;
        }
        
        double val_3 = PhotonNetwork.time;
        val_3 = (double)timeUntilRespawn + val_3;
        this.TimeOfRespawn = val_3;
        this.Invoke(methodName:  "PunRespawn", time:  timeUntilRespawn);
    }
    [TzarRPC]
    internal void PunRespawn(UnityEngine.Vector3 pos)
    {
        UnityEngine.Debug.Log(message:  0);
        this.PunRespawn();
        this.gameObject.transform.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
    }
    [TzarRPC]
    internal void PunRespawn()
    {
        null = null;
        bool val_1 = PickupItem.DisabledPickupItems.Remove(item:  this);
        this.TimeOfRespawn = 0;
        this.PickupIsMine = false;
        if(0 == this.gameObject)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  true);
    }
    private static PickupItem()
    {
        PickupItem.DisabledPickupItems = new System.Collections.Generic.HashSet<PickupItem>();
    }

}
