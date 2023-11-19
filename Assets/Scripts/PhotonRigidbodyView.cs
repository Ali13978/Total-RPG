using UnityEngine;
[UnityEngine.RequireComponent]
[UnityEngine.RequireComponent]
[UnityEngine.AddComponentMenu]
public class PhotonRigidbodyView : MonoBehaviour, IPunObservable
{
    // Fields
    [UnityEngine.SerializeField]
    private bool m_SynchronizeVelocity;
    [UnityEngine.SerializeField]
    private bool m_SynchronizeAngularVelocity;
    private UnityEngine.Rigidbody m_Body;
    
    // Methods
    public PhotonRigidbodyView()
    {
        this.m_SynchronizeVelocity = true;
        this.m_SynchronizeAngularVelocity = true;
    }
    private void Awake()
    {
        this.m_Body = this.GetComponent<UnityEngine.Rigidbody>();
    }
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        UnityEngine.Rigidbody val_11;
        bool val_12;
        UnityEngine.Rigidbody val_13;
        bool val_14;
        if(stream.write == false)
        {
            goto label_2;
        }
        
        if((this.m_SynchronizeVelocity & 255) == false)
        {
            goto label_3;
        }
        
        val_11 = this.m_Body;
        UnityEngine.Vector3 val_2 = val_11.velocity;
        stream.SendNext(obj:  val_2);
        val_12 = this.m_SynchronizeAngularVelocity;
        goto label_5;
        label_2:
        if((this.m_SynchronizeVelocity & 255) == false)
        {
            goto label_6;
        }
        
        val_13 = this.m_Body;
        object val_4 = stream.ReceiveNext();
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_13.velocity = new UnityEngine.Vector3() {x = 7.461634E-41f, y = val_5.y};
        val_14 = this.m_SynchronizeAngularVelocity;
        goto label_10;
        label_3:
        val_12 = this.m_SynchronizeVelocity >> 8;
        label_5:
        if(val_12 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = this.m_Body.angularVelocity;
        stream.SendNext(obj:  val_6);
        return;
        label_6:
        val_14 = this.m_SynchronizeVelocity >> 8;
        label_10:
        if(val_14 == false)
        {
                return;
        }
        
        object val_7 = stream.ReceiveNext();
        val_13 = null;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        this.m_Body.angularVelocity = new UnityEngine.Vector3() {x = 7.461634E-41f, y = val_8.y};
    }

}
