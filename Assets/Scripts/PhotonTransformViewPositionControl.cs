using UnityEngine;
public class PhotonTransformViewPositionControl
{
    // Fields
    private PhotonTransformViewPositionModel m_Model;
    private float m_CurrentSpeed;
    private double m_LastSerializeTime;
    private UnityEngine.Vector3 m_SynchronizedSpeed;
    private float m_SynchronizedTurnSpeed;
    private UnityEngine.Vector3 m_NetworkPosition;
    private System.Collections.Generic.Queue<UnityEngine.Vector3> m_OldNetworkPositions;
    private bool m_UpdatedPositionAfterOnSerialize;
    
    // Methods
    public PhotonTransformViewPositionControl(PhotonTransformViewPositionModel model)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.m_SynchronizedSpeed = val_1;
        mem[1152921512460472764] = val_1.y;
        mem[1152921512460472768] = val_1.z;
        this.m_OldNetworkPositions = new System.Collections.Generic.Queue<UnityEngine.Vector3>();
        this.m_UpdatedPositionAfterOnSerialize = true;
        this.m_Model = model;
    }
    private UnityEngine.Vector3 GetOldestStoredNetworkPosition()
    {
        System.Collections.Generic.Queue<UnityEngine.Vector3> val_3;
        UnityEngine.Vector3 val_4;
        float val_5;
        float val_6;
        val_3 = this;
        val_4 = this.m_NetworkPosition;
        if(this.m_OldNetworkPositions.Count < 1)
        {
                return new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6};
        }
        
        val_3 = this.m_OldNetworkPositions;
        UnityEngine.Vector3 val_2 = val_3.Peek();
        val_4 = val_2.x;
        val_5 = val_2.y;
        val_6 = val_2.z;
        return new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6};
    }
    public void SetSynchronizedValues(UnityEngine.Vector3 speed, float turnSpeed)
    {
        this.m_SynchronizedSpeed = speed;
        mem[1152921512460719292] = speed.y;
        mem[1152921512460719296] = speed.z;
        this.m_SynchronizedTurnSpeed = turnSpeed;
    }
    public UnityEngine.Vector3 UpdatePosition(UnityEngine.Vector3 currentPosition)
    {
        float val_19;
        float val_20;
        float val_21;
        float val_25;
        float val_26;
        float val_27;
        val_19 = currentPosition.x;
        UnityEngine.Vector3 val_1 = this.GetExtrapolatedPositionOffset();
        val_20 = val_1.x;
        val_21 = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.m_NetworkPosition, y = V12.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_20, y = val_1.y, z = val_21});
        val_25 = val_2.y;
        InterpolateOptions val_19 = this.m_Model.InterpolateOption;
        val_26 = currentPosition.y;
        val_27 = currentPosition.z;
        val_19 = (val_19 < 5) ? (val_19 + 5) : 0;
        if(val_19 > 9)
        {
                return new UnityEngine.Vector3() {};
        }
        
        var val_20 = 25819056 + (this.m_Model.InterpolateOption < 0x5 ? (this.m_Model.InterpolateOption + 5) : 0) << 2;
        val_20 = val_20 + 25819056;
        goto (25819056 + (this.m_Model.InterpolateOption < 0x5 ? (this.m_Model.InterpolateOption + 5) : 0) << 2 + 25819056);
    }
    public UnityEngine.Vector3 GetNetworkPosition()
    {
        return new UnityEngine.Vector3() {x = this.m_NetworkPosition};
    }
    public UnityEngine.Vector3 GetExtrapolatedPositionOffset()
    {
        PhotonTransformViewPositionModel val_16;
        double val_17;
        float val_18;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        float val_33;
        float val_34;
        float val_35;
        val_16 = this;
        val_17 = this.m_LastSerializeTime;
        val_18 = (float)PhotonNetwork.time - val_17;
        if(this.m_Model.ExtrapolateIncludingRoundTripTime != false)
        {
                float val_16 = 1000f;
            val_17 = (float)PhotonNetwork.GetPing();
            val_16 = val_17 / val_16;
            val_18 = val_18 + val_16;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_22 = val_4.x;
        val_23 = val_4.y;
        val_24 = val_4.z;
        if(this.m_Model.ExtrapolateOption == 3)
        {
            goto label_10;
        }
        
        if(this.m_Model.ExtrapolateOption == 2)
        {
            goto label_11;
        }
        
        if(this.m_Model.ExtrapolateOption != 1)
        {
                return new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24};
        }
        
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_18 * this.m_SynchronizedTurnSpeed, z:  0f);
        val_26 = val_6.w;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.m_SynchronizedSpeed, y = V14.16B, z = V13.16B}, d:  val_18);
        val_27 = val_6.x;
        val_28 = val_6.y;
        val_29 = val_6.z;
        UnityEngine.Vector3 val_8 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_27, y = val_28, z = val_29, w = val_26}, point:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        goto label_17;
        label_10:
        UnityEngine.Vector3 val_9 = this.GetOldestStoredNetworkPosition();
        val_26 = val_9.x;
        val_25 = val_9.z;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.m_NetworkPosition, y = val_23, z = val_24}, b:  new UnityEngine.Vector3() {x = val_26, y = val_9.y, z = val_25});
        val_16 = this.m_Model;
        val_33 = val_10.x;
        val_34 = val_10.y;
        val_35 = val_10.z;
        if(val_16 != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_11:
        UnityEngine.Vector3 val_11 = this.GetOldestStoredNetworkPosition();
        val_26 = val_11.x;
        val_25 = val_11.z;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.m_NetworkPosition, y = val_23, z = val_24}, b:  new UnityEngine.Vector3() {x = val_26, y = val_11.y, z = val_25});
        val_33 = val_12.x;
        val_34 = val_12.y;
        val_35 = val_12.z;
        label_21:
        val_27 = val_33;
        val_28 = val_34;
        val_29 = val_35;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29}, d:  (float)PhotonNetwork.sendRateOnSerialize);
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  val_18);
        label_17:
        val_22 = val_15.x;
        val_23 = val_15.y;
        val_24 = val_15.z;
        return new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24};
    }
    public void OnPhotonSerializeView(UnityEngine.Vector3 currentPosition, PhotonStream stream, PhotonMessageInfo info)
    {
        if(this.m_Model.SynchronizeEnabled == false)
        {
                return;
        }
        
        if(stream.write != false)
        {
                this.SerializeData(currentPosition:  new UnityEngine.Vector3() {x = currentPosition.x, y = currentPosition.y, z = currentPosition.z}, stream:  stream, info:  new PhotonMessageInfo() {timeInt = info.timeInt, sender = info.sender, photonView = info.photonView});
        }
        else
        {
                this.DeserializeData(stream:  stream, info:  new PhotonMessageInfo() {timeInt = info.timeInt, sender = info.sender, photonView = info.photonView});
        }
        
        this.m_LastSerializeTime = PhotonNetwork.time;
        this.m_UpdatedPositionAfterOnSerialize = false;
    }
    private void SerializeData(UnityEngine.Vector3 currentPosition, PhotonStream stream, PhotonMessageInfo info)
    {
        PhotonTransformViewPositionModel val_1;
        stream.SendNext(obj:  currentPosition);
        this.m_NetworkPosition = currentPosition;
        mem[1152921512461464556] = currentPosition.y;
        mem[1152921512461464560] = currentPosition.z;
        if(this.m_Model.ExtrapolateOption != 1)
        {
                val_1 = this.m_Model;
            if(this.m_Model.InterpolateOption != 3)
        {
                return;
        }
        
        }
        
        val_1 = this.m_SynchronizedSpeed;
        stream.SendNext(obj:  this.m_SynchronizedSpeed);
        stream.SendNext(obj:  this.m_SynchronizedTurnSpeed);
    }
    private void DeserializeData(PhotonStream stream, PhotonMessageInfo info)
    {
        var val_13;
        var val_14;
        var val_17;
        float val_18;
        var val_19;
        UnityEngine.Vector3 val_20;
        float val_21;
        val_13 = stream;
        object val_1 = val_13.ReceiveNext();
        val_14 = null;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        if(this.m_Model.ExtrapolateOption != 1)
        {
                if(this.m_Model.InterpolateOption != 3)
        {
            goto label_7;
        }
        
        }
        
        object val_3 = val_13.ReceiveNext();
        val_14 = null;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
        this.m_SynchronizedSpeed = new UnityEngine.Vector3();
        mem[1152921512461690124] = ???;
        mem[1152921512461690128] = ???;
        object val_5 = val_13.ReceiveNext();
        val_13 = null;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y});
        this.m_SynchronizedTurnSpeed = null;
        label_7:
        if(this.m_OldNetworkPositions.Count != 0)
        {
                val_17 = this;
            val_19 = 1152921512461690144;
            val_20 = this.m_NetworkPosition;
        }
        else
        {
                val_19 = this;
            val_17 = this;
            this.m_NetworkPosition = new UnityEngine.Vector3();
            mem[1152921512461690140] = ???;
            mem[1152921512461690144] = ???;
            val_20 = 7.461634E-41f;
            val_21 = W24;
            val_18 = W25;
        }
        
        this.m_OldNetworkPositions.Enqueue(item:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_18});
        this.m_NetworkPosition = new UnityEngine.Vector3();
        mem[1152921512461690140] = ???;
        mem[1152921512461690144] = ???;
        goto label_18;
        label_23:
        UnityEngine.Vector3 val_8 = this.m_OldNetworkPositions.Dequeue();
        label_18:
        if(this.m_OldNetworkPositions.Count <= this.m_Model.ExtrapolateNumberOfStoredPositions)
        {
                return;
        }
        
        if(this.m_OldNetworkPositions != null)
        {
            goto label_23;
        }
        
        goto label_23;
    }

}
