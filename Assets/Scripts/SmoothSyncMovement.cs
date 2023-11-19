using UnityEngine;
[UnityEngine.RequireComponent]
public class SmoothSyncMovement : MonoBehaviour, IPunObservable
{
    // Fields
    public float SmoothingDelay;
    private UnityEngine.Vector3 correctPlayerPos;
    private UnityEngine.Quaternion correctPlayerRot;
    
    // Methods
    public SmoothSyncMovement()
    {
        this.SmoothingDelay = 5f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.correctPlayerPos = val_1;
        mem[1152921512487123896] = val_1.y;
        mem[1152921512487123900] = val_1.z;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this.correctPlayerRot = val_2;
        mem[1152921512487123908] = val_2.y;
        mem[1152921512487123912] = val_2.z;
        mem[1152921512487123916] = val_2.w;
    }
    public void Awake()
    {
        object val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = this;
        PhotonView val_1 = this.photonView;
        List.Enumerator<T> val_2 = val_1.ObservedComponents.GetEnumerator();
        label_6:
        if((0 & 1) == 0)
        {
            goto label_3;
        }
        
        if(0 != 0.InitializationCallback)
        {
            goto label_6;
        }
        
        val_8 = 0;
        val_9 = 12;
        goto label_7;
        label_3:
        val_8 = 0;
        val_9 = 0;
        label_7:
        val_10 = 1;
        0.Dispose();
        if(val_9 != 0)
        {
                return;
        }
        
        val_7 = 0 + this;
        UnityEngine.Debug.LogWarning(message:  0);
    }
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        var val_12;
        object val_13;
        val_12 = stream;
        if(val_12.isWriting != false)
        {
                UnityEngine.Vector3 val_3 = this.transform.position;
            val_13 = val_3;
            val_12.SendNext(obj:  val_3);
            UnityEngine.Quaternion val_5 = this.transform.rotation;
            val_12.SendNext(obj:  val_5);
            return;
        }
        
        object val_6 = val_12.ReceiveNext();
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        this.correctPlayerPos = new UnityEngine.Vector3();
        mem[1152921512487427992] = ???;
        mem[1152921512487427996] = ???;
        val_13 = val_12.ReceiveNext();
        val_12 = null;
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y});
        this.correctPlayerRot = new UnityEngine.Quaternion();
    }
    public void Update()
    {
        if(this.photonView.isMine != false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = this.transform.position;
        float val_7 = UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = this.correctPlayerPos, y = V11.16B, z = V12.16B}, t:  val_7 * this.SmoothingDelay);
        this.transform.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Quaternion val_12 = this.transform.rotation;
        float val_13 = UnityEngine.Time.deltaTime;
        val_13 = val_13 * this.SmoothingDelay;
        UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, b:  new UnityEngine.Quaternion() {x = this.correctPlayerRot, y = V12.16B, z = val_6.z, w = val_7}, t:  val_13);
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w};
    }

}
