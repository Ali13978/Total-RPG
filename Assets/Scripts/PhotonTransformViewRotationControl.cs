using UnityEngine;
public class PhotonTransformViewRotationControl
{
    // Fields
    private PhotonTransformViewRotationModel m_Model;
    private UnityEngine.Quaternion m_NetworkRotation;
    
    // Methods
    public PhotonTransformViewRotationControl(PhotonTransformViewRotationModel model)
    {
        this.m_Model = model;
    }
    public UnityEngine.Quaternion GetNetworkRotation()
    {
        return new UnityEngine.Quaternion() {x = this.m_NetworkRotation};
    }
    public UnityEngine.Quaternion GetRotation(UnityEngine.Quaternion currentRotation)
    {
        PhotonTransformViewRotationModel val_6 = this;
        InterpolateOptions val_6 = this.m_Model.InterpolateOption;
        val_6 = (val_6 < 3) ? (val_6 + 3) : 0;
        if(val_6 > 5)
        {
                return new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        }
        
        var val_7 = 25819096 + (this.m_Model.InterpolateOption < 0x3 ? (this.m_Model.InterpolateOption + 3) : 0) << 2;
        val_7 = val_7 + 25819096;
        goto (25819096 + (this.m_Model.InterpolateOption < 0x3 ? (this.m_Model.InterpolateOption + 3) : 0) << 2 + 25819096);
    }
    public void OnPhotonSerializeView(UnityEngine.Quaternion currentRotation, PhotonStream stream, PhotonMessageInfo info)
    {
        if(this.m_Model.SynchronizeEnabled == false)
        {
                return;
        }
        
        if(stream.write != false)
        {
                stream.SendNext(obj:  currentRotation);
            this.m_NetworkRotation = currentRotation;
            mem[1152921512462378044] = currentRotation.y;
            mem[1152921512462378048] = currentRotation.z;
            mem[1152921512462378052] = currentRotation.w;
            return;
        }
        
        this.m_Model = stream.ReceiveNext();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = currentRotation.x, y = currentRotation.y, z = currentRotation.z});
        this.m_NetworkRotation = new UnityEngine.Quaternion();
    }

}
