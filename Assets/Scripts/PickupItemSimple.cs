using UnityEngine;
[UnityEngine.RequireComponent]
public class PickupItemSimple : MonoBehaviour
{
    // Fields
    public float SecondsBeforeRespawn;
    public bool PickupOnCollide;
    public bool SentPickup;
    
    // Methods
    public PickupItemSimple()
    {
        this.SecondsBeforeRespawn = 2f;
        val_1 = new UnityEngine.MonoBehaviour();
    }
    public void OnTriggerEnter(UnityEngine.Collider other)
    {
        PhotonView val_1 = other.GetComponent<PhotonView>();
        if(this.PickupOnCollide == false)
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
    public void Pickup()
    {
        if(this.SentPickup != false)
        {
                return;
        }
        
        this.SentPickup = true;
        this.photonView.RPC(methodName:  "PunPickupSimple", target:  5, parameters:  null);
    }
    [TzarRPC]
    public void PunPickupSimple(PhotonMessageInfo msgInfo)
    {
        PhotonPlayer val_11;
        if(this.SentPickup != false)
        {
                val_11 = msgInfo.sender;
            if(msgInfo.sender.IsLocal != false)
        {
                UnityEngine.GameObject val_1 = this.gameObject;
            bool val_2 = GameObjectExtensions.GetActive(target:  0);
        }
        
        }
        
        this.SentPickup = false;
        UnityEngine.GameObject val_3 = this.gameObject;
        if((GameObjectExtensions.GetActive(target:  0)) != false)
        {
                double val_6 = PhotonNetwork.time;
            double val_11 = (double)msgInfo.timeInt;
            val_11 = val_11 / (-1000);
            val_6 = val_6 + val_11;
            float val_7 = this.SecondsBeforeRespawn - (float)val_6;
            if(val_7 <= 0f)
        {
                return;
        }
        
            this.gameObject.SetActive(value:  false);
            this.Invoke(methodName:  "RespawnAfter", time:  val_7);
            return;
        }
        
        UnityEngine.GameObject val_9 = this.gameObject;
        string val_10 = 0 + "Ignored PU RPC, cause item is inactive. ";
        UnityEngine.Debug.Log(message:  0);
    }
    public void RespawnAfter()
    {
        if(0 == this.gameObject)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  true);
    }

}
