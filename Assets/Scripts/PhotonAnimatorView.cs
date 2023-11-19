using UnityEngine;
[UnityEngine.RequireComponent]
[UnityEngine.RequireComponent]
[UnityEngine.AddComponentMenu]
public class PhotonAnimatorView : MonoBehaviour, IPunObservable
{
    // Fields
    private UnityEngine.Animator m_Animator;
    private PhotonStreamQueue m_StreamQueue;
    [UnityEngine.HideInInspector]
    [UnityEngine.SerializeField]
    private bool ShowLayerWeightsInspector;
    [UnityEngine.HideInInspector]
    [UnityEngine.SerializeField]
    private bool ShowParameterInspector;
    [UnityEngine.HideInInspector]
    [UnityEngine.SerializeField]
    private System.Collections.Generic.List<PhotonAnimatorView.SynchronizedParameter> m_SynchronizeParameters;
    [UnityEngine.HideInInspector]
    [UnityEngine.SerializeField]
    private System.Collections.Generic.List<PhotonAnimatorView.SynchronizedLayer> m_SynchronizeLayers;
    private UnityEngine.Vector3 m_ReceiverPosition;
    private float m_LastDeserializeTime;
    private bool m_WasSynchronizeTypeChanged;
    private PhotonView m_PhotonView;
    private System.Collections.Generic.List<string> m_raisedDiscreteTriggersCache;
    
    // Methods
    public PhotonAnimatorView()
    {
        this.ShowLayerWeightsInspector = true;
        this.ShowParameterInspector = true;
        this.m_SynchronizeParameters = new System.Collections.Generic.List<SynchronizedParameter>();
        this.m_WasSynchronizeTypeChanged = true;
        this.m_SynchronizeLayers = new System.Collections.Generic.List<SynchronizedLayer>();
        this.m_raisedDiscreteTriggersCache = new System.Collections.Generic.List<System.String>();
    }
    private void Awake()
    {
        this.m_PhotonView = this.GetComponent<PhotonView>();
        this.m_StreamQueue = new PhotonStreamQueue(sampleRate:  120);
        this.m_Animator = this.GetComponent<UnityEngine.Animator>();
    }
    private void Update()
    {
        if((this.m_Animator.applyRootMotion != false) && (this.m_PhotonView.isMine != true))
        {
                if(PhotonNetwork.connected != false)
        {
                this.m_Animator.applyRootMotion = false;
        }
        
        }
        
        if(PhotonNetwork.inRoom != false)
        {
                if(PhotonNetwork.room.PlayerCount > 1)
        {
            goto label_15;
        }
        
        }
        
        this.m_StreamQueue.Reset();
        return;
        label_15:
        if(this.m_PhotonView.isMine != false)
        {
                this.SerializeDataContinuously();
            this.CacheDiscreteTriggers();
            return;
        }
        
        this.DeserializeDataContinuously();
    }
    public void CacheDiscreteTriggers()
    {
        goto label_1;
        label_11:
        0 = 1;
        label_1:
        if(0 >= this.m_SynchronizeParameters.Count)
        {
                return;
        }
        
        SynchronizedParameter val_2 = this.m_SynchronizeParameters.Item[1];
        if(((val_2.SynchronizeType != 1) || (val_2.Type != 9)) || (((this.m_Animator.GetBool(name:  val_2.Name)) == false) || (val_2.Type != 9)))
        {
            goto label_11;
        }
        
        this.m_raisedDiscreteTriggersCache.Add(item:  val_2.Name);
    }
    public bool DoesLayerSynchronizeTypeExist(int layerIndex)
    {
        typeof(PhotonAnimatorView.<DoesLayerSynchronizeTypeExist>c__AnonStorey0).__il2cppRuntimeField_10 = layerIndex;
        return (bool)((this.m_SynchronizeLayers.FindIndex(match:  new System.Predicate<SynchronizedLayer>(object:  new System.Object(), method:  System.Boolean PhotonAnimatorView.<DoesLayerSynchronizeTypeExist>c__AnonStorey0::<>m__0(PhotonAnimatorView.SynchronizedLayer item)))) != 1) ? 1 : 0;
    }
    public bool DoesParameterSynchronizeTypeExist(string name)
    {
        typeof(PhotonAnimatorView.<DoesParameterSynchronizeTypeExist>c__AnonStorey1).__il2cppRuntimeField_10 = name;
        return (bool)((this.m_SynchronizeParameters.FindIndex(match:  new System.Predicate<SynchronizedParameter>(object:  new System.Object(), method:  System.Boolean PhotonAnimatorView.<DoesParameterSynchronizeTypeExist>c__AnonStorey1::<>m__0(PhotonAnimatorView.SynchronizedParameter item)))) != 1) ? 1 : 0;
    }
    public System.Collections.Generic.List<PhotonAnimatorView.SynchronizedLayer> GetSynchronizedLayers()
    {
        return (System.Collections.Generic.List<SynchronizedLayer>)this.m_SynchronizeLayers;
    }
    public System.Collections.Generic.List<PhotonAnimatorView.SynchronizedParameter> GetSynchronizedParameters()
    {
        return (System.Collections.Generic.List<SynchronizedParameter>)this.m_SynchronizeParameters;
    }
    public PhotonAnimatorView.SynchronizeType GetLayerSynchronizeType(int layerIndex)
    {
        var val_5;
        PhotonAnimatorView.SynchronizeType val_6;
        val_5 = this;
        typeof(PhotonAnimatorView.<GetLayerSynchronizeType>c__AnonStorey2).__il2cppRuntimeField_10 = layerIndex;
        int val_3 = this.m_SynchronizeLayers.FindIndex(match:  new System.Predicate<SynchronizedLayer>(object:  new System.Object(), method:  System.Boolean PhotonAnimatorView.<GetLayerSynchronizeType>c__AnonStorey2::<>m__0(PhotonAnimatorView.SynchronizedLayer item)));
        if(val_3 != 1)
        {
                val_5 = this.m_SynchronizeLayers.Item[val_3];
            val_6 = val_4.SynchronizeType;
            return (SynchronizeType)val_6;
        }
        
        val_6 = 0;
        return (SynchronizeType)val_6;
    }
    public PhotonAnimatorView.SynchronizeType GetParameterSynchronizeType(string name)
    {
        var val_5;
        PhotonAnimatorView.SynchronizeType val_6;
        val_5 = this;
        typeof(PhotonAnimatorView.<GetParameterSynchronizeType>c__AnonStorey3).__il2cppRuntimeField_10 = name;
        int val_3 = this.m_SynchronizeParameters.FindIndex(match:  new System.Predicate<SynchronizedParameter>(object:  new System.Object(), method:  System.Boolean PhotonAnimatorView.<GetParameterSynchronizeType>c__AnonStorey3::<>m__0(PhotonAnimatorView.SynchronizedParameter item)));
        if(val_3 != 1)
        {
                val_5 = this.m_SynchronizeParameters.Item[val_3];
            val_6 = val_4.SynchronizeType;
            return (SynchronizeType)val_6;
        }
        
        val_6 = 0;
        return (SynchronizeType)val_6;
    }
    public void SetLayerSynchronized(int layerIndex, PhotonAnimatorView.SynchronizeType synchronizeType)
    {
        typeof(PhotonAnimatorView.<SetLayerSynchronized>c__AnonStorey4).__il2cppRuntimeField_10 = layerIndex;
        if(UnityEngine.Application.isPlaying != false)
        {
                this.m_WasSynchronizeTypeChanged = true;
        }
        
        int val_4 = this.m_SynchronizeLayers.FindIndex(match:  new System.Predicate<SynchronizedLayer>(object:  new System.Object(), method:  System.Boolean PhotonAnimatorView.<SetLayerSynchronized>c__AnonStorey4::<>m__0(PhotonAnimatorView.SynchronizedLayer item)));
        if(val_4 != 1)
        {
                SynchronizedLayer val_5 = this.m_SynchronizeLayers.Item[val_4];
            val_5.SynchronizeType = synchronizeType;
            return;
        }
        
        if(null != 0)
        {
                typeof(PhotonAnimatorView.SynchronizedLayer).__il2cppRuntimeField_14 = typeof(PhotonAnimatorView.<SetLayerSynchronized>c__AnonStorey4).__il2cppRuntimeField_10;
        }
        else
        {
                typeof(PhotonAnimatorView.SynchronizedLayer).__il2cppRuntimeField_14 = typeof(PhotonAnimatorView.<SetLayerSynchronized>c__AnonStorey4).__il2cppRuntimeField_10;
        }
        
        typeof(PhotonAnimatorView.SynchronizedLayer).__il2cppRuntimeField_10 = synchronizeType;
        this.m_SynchronizeLayers.Add(item:  new System.Object());
    }
    public void SetParameterSynchronized(string name, PhotonAnimatorView.ParameterType type, PhotonAnimatorView.SynchronizeType synchronizeType)
    {
        typeof(PhotonAnimatorView.<SetParameterSynchronized>c__AnonStorey5).__il2cppRuntimeField_10 = name;
        if(UnityEngine.Application.isPlaying != false)
        {
                this.m_WasSynchronizeTypeChanged = true;
        }
        
        int val_4 = this.m_SynchronizeParameters.FindIndex(match:  new System.Predicate<SynchronizedParameter>(object:  new System.Object(), method:  System.Boolean PhotonAnimatorView.<SetParameterSynchronized>c__AnonStorey5::<>m__0(PhotonAnimatorView.SynchronizedParameter item)));
        if(val_4 != 1)
        {
                SynchronizedParameter val_5 = this.m_SynchronizeParameters.Item[val_4];
            val_5.SynchronizeType = synchronizeType;
            return;
        }
        
        if(null != 0)
        {
                typeof(PhotonAnimatorView.SynchronizedParameter).__il2cppRuntimeField_18 = typeof(PhotonAnimatorView.<SetParameterSynchronized>c__AnonStorey5).__il2cppRuntimeField_10;
            typeof(PhotonAnimatorView.SynchronizedParameter).__il2cppRuntimeField_10 = type;
        }
        else
        {
                mem[24] = typeof(PhotonAnimatorView.<SetParameterSynchronized>c__AnonStorey5).__il2cppRuntimeField_10;
            mem[16] = type;
        }
        
        typeof(PhotonAnimatorView.SynchronizedParameter).__il2cppRuntimeField_14 = synchronizeType;
        this.m_SynchronizeParameters.Add(item:  new System.Object());
    }
    private void SerializeDataContinuously()
    {
        var val_18;
        var val_19;
        PhotonStreamQueue val_20;
        var val_21;
        var val_23;
        if(0 == this.m_Animator)
        {
                return;
        }
        
        val_18 = 0;
        goto label_4;
        label_14:
        val_18 = 1;
        label_4:
        if(val_18 >= this.m_SynchronizeLayers.Count)
        {
            goto label_6;
        }
        
        SynchronizedLayer val_4 = this.m_SynchronizeLayers.Item[1];
        if(val_4.SynchronizeType != 2)
        {
            goto label_14;
        }
        
        SynchronizedLayer val_5 = this.m_SynchronizeLayers.Item[1];
        this.m_StreamQueue.SendNext(obj:  this.m_Animator.GetLayerWeight(layerIndex:  val_5.LayerIndex));
        goto label_14;
        label_6:
        val_19 = 0;
        goto label_15;
        label_32:
        val_19 = 1;
        label_15:
        if(val_19 >= this.m_SynchronizeParameters.Count)
        {
                return;
        }
        
        SynchronizedParameter val_8 = this.m_SynchronizeParameters.Item[1];
        if(val_8.SynchronizeType != 2)
        {
            goto label_32;
        }
        
        PhotonAnimatorView.ParameterType val_10 = val_8.Type + 11;
        var val_11 = ((val_8.Type - 1) < 4) ? (val_10) : 0;
        val_10 = val_11 - 12;
        if(val_10 > 3)
        {
            goto label_21;
        }
        
        var val_18 = 25818916 + ((val_9 < 0x4 ? (val_8.Type + 11) : 0 - 12)) << 2;
        val_18 = val_18 + 25818916;
        goto (25818916 + ((val_9 < 0x4 ? (val_8.Type + 11) : 0 - 12)) << 2 + 25818916);
        label_21:
        if(val_11 != 0)
        {
                return;
        }
        
        if(val_8.Type != 9)
        {
            goto label_32;
        }
        
        val_20 = this.m_StreamQueue;
        val_23 = null;
        bool val_14 = this.m_Animator.GetBool(name:  val_8.Name);
        val_21 = ;
        SendNext(obj:  null);
        goto label_32;
    }
    private void DeserializeDataContinuously()
    {
        var val_23;
        var val_24;
        var val_25;
        string val_26;
        UnityEngine.Animator val_27;
        var val_28;
        if(this.m_StreamQueue.m_NextObjectIndex == 1)
        {
                return;
        }
        
        val_23 = 0;
        goto label_3;
        label_15:
        val_23 = 1;
        label_3:
        if(val_23 >= this.m_SynchronizeLayers.Count)
        {
            goto label_5;
        }
        
        SynchronizedLayer val_2 = this.m_SynchronizeLayers.Item[1];
        if(val_2.SynchronizeType != 2)
        {
            goto label_15;
        }
        
        SynchronizedLayer val_3 = this.m_SynchronizeLayers.Item[1];
        object val_4 = this.m_StreamQueue.ReceiveNext();
        val_24 = null;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        this.m_Animator.SetLayerWeight(layerIndex:  val_3.LayerIndex, weight:  7.461634E-41f);
        goto label_15;
        label_5:
        val_25 = 0;
        goto label_16;
        label_44:
        val_25 = 1;
        label_16:
        if(val_25 >= this.m_SynchronizeParameters.Count)
        {
                return;
        }
        
        SynchronizedParameter val_7 = this.m_SynchronizeParameters.Item[1];
        if(val_7.SynchronizeType != 2)
        {
            goto label_44;
        }
        
        PhotonAnimatorView.ParameterType val_9 = val_7.Type + 9;
        var val_10 = ((val_7.Type - 1) < 4) ? (val_9) : 0;
        val_9 = val_10 - 10;
        if(val_9 > 3)
        {
            goto label_22;
        }
        
        var val_23 = 25818932 + ((val_8 < 0x4 ? (val_7.Type + 9) : 0 - 10)) << 2;
        val_23 = val_23 + 25818932;
        goto (25818932 + ((val_8 < 0x4 ? (val_7.Type + 9) : 0 - 10)) << 2 + 25818932);
        label_22:
        if(val_10 != 0)
        {
                return;
        }
        
        if(val_7.Type != 9)
        {
            goto label_44;
        }
        
        val_26 = val_7.Name;
        val_27 = this.m_Animator;
        val_28 = this.m_StreamQueue.ReceiveNext();
        val_24 = null;
        label_48:
        goto label_48;
    }
    private void SerializeDataDiscretly(PhotonStream stream)
    {
        var val_16;
        var val_17;
        var val_18;
        var val_20;
        val_16 = 0;
        goto label_1;
        label_11:
        val_16 = 1;
        label_1:
        if(val_16 >= this.m_SynchronizeLayers.Count)
        {
            goto label_3;
        }
        
        SynchronizedLayer val_2 = this.m_SynchronizeLayers.Item[1];
        if(val_2.SynchronizeType != 1)
        {
            goto label_11;
        }
        
        SynchronizedLayer val_3 = this.m_SynchronizeLayers.Item[1];
        stream.SendNext(obj:  this.m_Animator.GetLayerWeight(layerIndex:  val_3.LayerIndex));
        goto label_11;
        label_3:
        val_17 = 0;
        goto label_12;
        label_29:
        val_17 = 1;
        label_12:
        if(val_17 >= this.m_SynchronizeParameters.Count)
        {
            goto label_14;
        }
        
        SynchronizedParameter val_6 = this.m_SynchronizeParameters.Item[1];
        if(val_6.SynchronizeType != 1)
        {
            goto label_29;
        }
        
        PhotonAnimatorView.ParameterType val_8 = val_6.Type + 8;
        var val_9 = ((val_6.Type - 1) < 4) ? (val_8) : 0;
        val_8 = val_9 - 9;
        if(val_8 > 3)
        {
            goto label_18;
        }
        
        var val_16 = 25818948 + ((val_7 < 0x4 ? (val_6.Type + 8) : 0 - 9)) << 2;
        val_16 = val_16 + 25818948;
        goto (25818948 + ((val_7 < 0x4 ? (val_6.Type + 8) : 0 - 9)) << 2 + 25818948);
        label_18:
        if(val_9 != 0)
        {
                return;
        }
        
        if(val_6.Type != 9)
        {
            goto label_29;
        }
        
        val_20 = null;
        bool val_12 = this.m_raisedDiscreteTriggersCache.Contains(item:  val_6.Name);
        val_18 = ;
        stream.SendNext(obj:  null);
        goto label_29;
        label_14:
        this.m_raisedDiscreteTriggersCache.Clear();
    }
    private void DeserializeDataDiscretly(PhotonStream stream)
    {
        var val_28;
        int val_29;
        var val_30;
        var val_31;
        val_28 = 0;
        goto label_1;
        label_13:
        val_28 = 1;
        label_1:
        if(val_28 >= this.m_SynchronizeLayers.Count)
        {
            goto label_3;
        }
        
        SynchronizedLayer val_2 = this.m_SynchronizeLayers.Item[1];
        if(val_2.SynchronizeType != 1)
        {
            goto label_13;
        }
        
        SynchronizedLayer val_3 = this.m_SynchronizeLayers.Item[1];
        val_29 = val_3.LayerIndex;
        object val_4 = stream.ReceiveNext();
        val_30 = null;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        this.m_Animator.SetLayerWeight(layerIndex:  val_29, weight:  7.461634E-41f);
        goto label_13;
        label_3:
        val_31 = 0;
        goto label_14;
        label_59:
        val_31 = 1;
        label_14:
        if(val_31 >= this.m_SynchronizeParameters.Count)
        {
                return;
        }
        
        SynchronizedParameter val_7 = this.m_SynchronizeParameters.Item[1];
        if(val_7.SynchronizeType != 1)
        {
            goto label_59;
        }
        
        PhotonAnimatorView.ParameterType val_9 = val_7.Type + 8;
        var val_10 = ((val_7.Type - 1) < 4) ? (val_9) : 0;
        val_9 = val_10 - 9;
        if(val_9 > 3)
        {
            goto label_20;
        }
        
        var val_28 = 25818964 + ((val_8 < 0x4 ? (val_7.Type + 8) : 0 - 9)) << 2;
        val_28 = val_28 + 25818964;
        goto (25818964 + ((val_8 < 0x4 ? (val_7.Type + 8) : 0 - 9)) << 2 + 25818964);
        label_20:
        if(val_10 != 0)
        {
                return;
        }
        
        if(val_7.Type != 9)
        {
            goto label_59;
        }
        
        if(stream.PeekNext() == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        object val_15 = stream.ReceiveNext();
        val_29 = null;
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        if(null == null)
        {
            goto label_59;
        }
        
        this.m_Animator.SetTrigger(name:  val_7.Name);
        goto label_59;
        label_63:
        goto label_63;
    }
    private void SerializeSynchronizationTypeState(PhotonStream stream)
    {
        var val_11;
        var val_12;
        var val_11 = this.m_SynchronizeLayers.Count;
        val_11 = this.m_SynchronizeParameters.Count + val_11;
        val_11 = 0;
        goto label_3;
        label_10:
        var val_3 = null + X27;
        val_11 = 1;
        mem2[0] = ???;
        label_3:
        if(val_11 >= this.m_SynchronizeLayers.Count)
        {
            goto label_5;
        }
        
        SynchronizedLayer val_5 = this.m_SynchronizeLayers.Item[1];
        if(null != null)
        {
            goto label_10;
        }
        
        goto label_10;
        label_5:
        val_12 = 0;
        goto label_11;
        label_19:
        System.Collections.Generic.List<SynchronizedLayer> val_6 = null + this.m_SynchronizeLayers;
        val_12 = 1;
        mem2[0] = 1152921512453879760;
        label_11:
        if(val_12 >= this.m_SynchronizeParameters.Count)
        {
            goto label_13;
        }
        
        SynchronizedParameter val_9 = this.m_SynchronizeParameters.Item[1];
        int val_10 = this.m_SynchronizeLayers.Count + val_12;
        goto label_19;
        label_13:
        stream.SendNext(obj:  null);
    }
    private void DeserializeSynchronizationTypeState(PhotonStream stream)
    {
        var val_10;
        var val_11;
        var val_12;
        object val_1 = stream.ReceiveNext();
        if(val_1 == null)
        {
            goto label_2;
        }
        
        val_10 = val_1;
        if(val_10 != null)
        {
            goto label_3;
        }
        
        label_2:
        val_10 = 0;
        label_3:
        val_11 = 0;
        goto label_4;
        label_11:
        val_11 = 1;
        mem2[0] = ???;
        label_4:
        if(val_11 >= this.m_SynchronizeLayers.Count)
        {
            goto label_6;
        }
        
        var val_5 = val_10 + 1;
        if(this.m_SynchronizeLayers.Item[1] != null)
        {
            goto label_11;
        }
        
        goto label_11;
        label_6:
        val_12 = 0;
        goto label_12;
        label_20:
        val_12 = 1;
        mem2[0] = 1152921512453879760;
        label_12:
        if(val_12 >= this.m_SynchronizeParameters.Count)
        {
                return;
        }
        
        var val_10 = val_10 + ((long)this.m_SynchronizeLayers.Count + val_12);
        if(this.m_SynchronizeParameters.Item[1] != null)
        {
            goto label_20;
        }
        
        goto label_20;
    }
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if(0 == this.m_Animator)
        {
                return;
        }
        
        if(stream.write != false)
        {
                if(this.m_WasSynchronizeTypeChanged != false)
        {
                this.m_StreamQueue.Reset();
            this.SerializeSynchronizationTypeState(stream:  stream);
            this.m_WasSynchronizeTypeChanged = false;
        }
        
            this.m_StreamQueue.Serialize(stream:  stream);
            this.SerializeDataDiscretly(stream:  stream);
            return;
        }
        
        if(stream.PeekNext() != null)
        {
                this.DeserializeSynchronizationTypeState(stream:  stream);
        }
        
        this.m_StreamQueue.Deserialize(stream:  stream);
        this.DeserializeDataDiscretly(stream:  stream);
    }

}
