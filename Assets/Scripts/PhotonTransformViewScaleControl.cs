using UnityEngine;
public class PhotonTransformViewScaleControl
{
    // Fields
    private PhotonTransformViewScaleModel m_Model;
    private UnityEngine.Vector3 m_NetworkScale;
    
    // Methods
    public PhotonTransformViewScaleControl(PhotonTransformViewScaleModel model)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.m_NetworkScale = val_1;
        mem[1152921512462635820] = val_1.y;
        mem[1152921512462635824] = val_1.z;
        this.m_Model = model;
    }
    public UnityEngine.Vector3 GetNetworkScale()
    {
        return new UnityEngine.Vector3() {x = this.m_NetworkScale};
    }
    public UnityEngine.Vector3 GetScale(UnityEngine.Vector3 currentScale)
    {
        PhotonTransformViewScaleModel val_8 = this;
        InterpolateOptions val_8 = this.m_Model.InterpolateOption;
        val_8 = (val_8 < 3) ? (val_8 + 3) : 0;
        if(val_8 > 5)
        {
                return new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        
        var val_9 = 25819120 + (this.m_Model.InterpolateOption < 0x3 ? (this.m_Model.InterpolateOption + 3) : 0) << 2;
        val_9 = val_9 + 25819120;
        goto (25819120 + (this.m_Model.InterpolateOption < 0x3 ? (this.m_Model.InterpolateOption + 3) : 0) << 2 + 25819120);
    }
    public void OnPhotonSerializeView(UnityEngine.Vector3 currentScale, PhotonStream stream, PhotonMessageInfo info)
    {
        if(this.m_Model.SynchronizeEnabled == false)
        {
                return;
        }
        
        if(stream.write != false)
        {
                stream.SendNext(obj:  currentScale);
            this.m_NetworkScale = currentScale;
            mem[1152921512463030156] = currentScale.y;
            mem[1152921512463030160] = currentScale.z;
            return;
        }
        
        this.m_Model = stream.ReceiveNext();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = currentScale.x, y = currentScale.y, z = currentScale.z});
        this.m_NetworkScale = new UnityEngine.Vector3();
        mem[1152921512463030156] = ???;
        mem[1152921512463030160] = ???;
    }

}
