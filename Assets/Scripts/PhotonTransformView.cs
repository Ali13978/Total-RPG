using UnityEngine;
[UnityEngine.RequireComponent]
[UnityEngine.AddComponentMenu]
public class PhotonTransformView : MonoBehaviour, IPunObservable
{
    // Fields
    [UnityEngine.SerializeField]
    public PhotonTransformViewPositionModel m_PositionModel;
    [UnityEngine.SerializeField]
    public PhotonTransformViewRotationModel m_RotationModel;
    [UnityEngine.SerializeField]
    public PhotonTransformViewScaleModel m_ScaleModel;
    private PhotonTransformViewPositionControl m_PositionControl;
    private PhotonTransformViewRotationControl m_RotationControl;
    private PhotonTransformViewScaleControl m_ScaleControl;
    private PhotonView m_PhotonView;
    private bool m_ReceivedNetworkUpdate;
    private bool m_firstTake;
    
    // Methods
    public PhotonTransformView()
    {
        this.m_PositionModel = new PhotonTransformViewPositionModel();
        object val_2 = null;
        typeof(PhotonTransformViewRotationModel).__il2cppRuntimeField_14 = 1;
        typeof(PhotonTransformViewRotationModel).__il2cppRuntimeField_18 = 1127481344;
        typeof(PhotonTransformViewRotationModel).__il2cppRuntimeField_1C = 1084227584;
        val_2 = new System.Object();
        this.m_RotationModel = val_2;
        object val_3 = null;
        typeof(PhotonTransformViewScaleModel).__il2cppRuntimeField_18 = 1065353216;
        val_3 = new System.Object();
        this.m_ScaleModel = val_3;
    }
    private void Awake()
    {
        this.m_PhotonView = this.GetComponent<PhotonView>();
        this.m_PositionControl = new PhotonTransformViewPositionControl(model:  this.m_PositionModel);
        typeof(PhotonTransformViewRotationControl).__il2cppRuntimeField_10 = this.m_RotationModel;
        this.m_RotationControl = new System.Object();
        this.m_ScaleControl = new PhotonTransformViewScaleControl(model:  this.m_ScaleModel);
    }
    private void OnEnable()
    {
        this.m_firstTake = true;
    }
    private void Update()
    {
        if(0 == this.m_PhotonView)
        {
                return;
        }
        
        if(this.m_PhotonView.isMine == true)
        {
                return;
        }
        
        if(PhotonNetwork.connected == false)
        {
                return;
        }
        
        this.UpdatePosition();
        this.UpdateRotation();
        this.UpdateScale();
    }
    private void UpdatePosition()
    {
        if(this.m_PositionModel.SynchronizeEnabled == false)
        {
                return;
        }
        
        if(this.m_ReceivedNetworkUpdate == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.transform.localPosition;
        UnityEngine.Vector3 val_4 = this.m_PositionControl.UpdatePosition(currentPosition:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    private void UpdateRotation()
    {
        if(this.m_RotationModel.SynchronizeEnabled == false)
        {
                return;
        }
        
        if(this.m_ReceivedNetworkUpdate == false)
        {
                return;
        }
        
        UnityEngine.Quaternion val_3 = this.transform.localRotation;
        UnityEngine.Quaternion val_4 = this.m_RotationControl.GetRotation(currentRotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        this.transform.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
    }
    private void UpdateScale()
    {
        if(this.m_ScaleModel.SynchronizeEnabled == false)
        {
                return;
        }
        
        if(this.m_ReceivedNetworkUpdate == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.transform.localScale;
        UnityEngine.Vector3 val_4 = this.m_ScaleControl.GetScale(currentScale:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public void SetSynchronizedValues(UnityEngine.Vector3 speed, float turnSpeed)
    {
        this.m_PositionControl.m_SynchronizedSpeed = speed;
        mem2[0] = speed.y;
        mem2[0] = speed.z;
        this.m_PositionControl.m_SynchronizedTurnSpeed = turnSpeed;
    }
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        float val_12;
        float val_13;
        float val_14;
        PhotonView val_15;
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        this.m_PositionControl.OnPhotonSerializeView(currentPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, stream:  stream, info:  new PhotonMessageInfo() {timeInt = info.timeInt, photonView = info.photonView});
        UnityEngine.Quaternion val_4 = this.transform.localRotation;
        this.m_RotationControl.OnPhotonSerializeView(currentRotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, stream:  stream, info:  new PhotonMessageInfo() {timeInt = info.timeInt, photonView = info.photonView});
        UnityEngine.Vector3 val_6 = this.transform.localScale;
        val_12 = val_6.x;
        val_13 = val_6.y;
        val_14 = val_6.z;
        this.m_ScaleControl.OnPhotonSerializeView(currentScale:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14}, stream:  stream, info:  new PhotonMessageInfo() {timeInt = info.timeInt, photonView = info.photonView});
        val_15 = this.m_PhotonView;
        if(val_15.isMine != true)
        {
                val_15 = this.m_PositionModel;
            if(this.m_PositionModel.DrawErrorGizmo != false)
        {
                this.DoDrawEstimatedPositionError();
        }
        
        }
        
        if(stream.write == true)
        {
                return;
        }
        
        this.m_ReceivedNetworkUpdate = true;
        if(this.m_firstTake == false)
        {
                return;
        }
        
        this.m_firstTake = false;
        if(this.m_PositionModel.SynchronizeEnabled != false)
        {
                val_15 = this.m_PositionControl;
            val_12 = this.m_PositionControl.m_NetworkPosition;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14};
        }
        
        if(this.m_RotationModel.SynchronizeEnabled != false)
        {
                val_15 = this.m_RotationControl;
            val_12 = this.m_RotationControl.m_NetworkRotation;
            this.transform.localRotation = new UnityEngine.Quaternion() {x = val_12, y = val_13, z = val_14, w = val_4.w};
        }
        
        if(this.m_ScaleModel.SynchronizeEnabled == false)
        {
                return;
        }
        
        this.transform.localScale = new UnityEngine.Vector3() {x = this.m_ScaleControl.m_NetworkScale, y = val_13, z = val_14};
    }
    private void DoDrawEstimatedPositionError()
    {
        float val_21;
        float val_22;
        if(0 != this.transform.parent)
        {
                UnityEngine.Vector3 val_6 = this.transform.parent.position;
            val_22 = val_6.x;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = this.m_PositionControl.m_NetworkPosition, y = this.m_PositionControl.m_NetworkPosition, z = V10.16B});
            val_21 = val_7.z;
        }
        
        UnityEngine.Vector3 val_9 = this.transform.position;
        UnityEngine.Color val_10 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_21}, end:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, color:  new UnityEngine.Color() {r = val_10.r, g = val_10.b, b = 2f, a = val_7.y}, duration:  ???);
        UnityEngine.Vector3 val_12 = this.transform.position;
        UnityEngine.Vector3 val_14 = this.transform.position;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        UnityEngine.Color val_17 = UnityEngine.Color.green;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, end:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, color:  new UnityEngine.Color() {r = val_17.r, g = val_17.b, b = 2f, a = val_7.y}, duration:  ???);
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_21}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        UnityEngine.Color val_20 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_21}, end:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, color:  new UnityEngine.Color() {r = val_20.r, g = val_20.b, b = 2f, a = val_7.y}, duration:  ???);
    }

}
