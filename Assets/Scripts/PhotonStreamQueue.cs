using UnityEngine;
public class PhotonStreamQueue
{
    // Fields
    private int m_SampleRate;
    private int m_SampleCount;
    private int m_ObjectsPerSample;
    private float m_LastSampleTime;
    private int m_LastFrameCount;
    private int m_NextObjectIndex;
    private System.Collections.Generic.List<object> m_Objects;
    private bool m_IsWriting;
    
    // Methods
    public PhotonStreamQueue(int sampleRate)
    {
        this.m_ObjectsPerSample = 0;
        this.m_LastSampleTime = -Infinityf;
        this.m_LastFrameCount = 0;
        this.m_NextObjectIndex = 0;
        this.m_Objects = new System.Collections.Generic.List<System.Object>();
        this.m_SampleRate = sampleRate;
    }
    private void BeginWritePackage()
    {
        float val_8 = (float)this.m_SampleRate;
        val_8 = 1f / val_8;
        val_8 = this.m_LastSampleTime + val_8;
        if(UnityEngine.Time.realtimeSinceStartup < 0)
        {
                this.m_IsWriting = false;
            return;
        }
        
        if(this.m_SampleCount == 1)
        {
                this.m_ObjectsPerSample = this.m_Objects.Count;
        }
        else
        {
                if(this.m_SampleCount >= 2)
        {
                int val_9 = this.m_SampleCount;
            val_9 = this.m_Objects.Count / val_9;
            if(val_9 != this.m_ObjectsPerSample)
        {
                UnityEngine.Debug.LogWarning(message:  0);
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Objects in List: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.m_Objects.Count;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " / Sample Count: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.m_SampleCount;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = " = ";
            int val_10 = this.m_SampleCount;
            val_10 = this.m_Objects.Count / val_10;
            typeof(System.Object[]).__il2cppRuntimeField_48 = val_10;
            typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_50 = " != ";
            typeof(System.Object[]).__il2cppRuntimeField_58 = this.m_ObjectsPerSample;
            typeof(System.Object[]).__il2cppRuntimeField_5C = 268435457;
            string val_6 = +0;
            UnityEngine.Debug.LogWarning(message:  0);
        }
        
        }
        
        }
        
        int val_11 = this.m_SampleCount;
        val_11 = val_11 + 1;
        this.m_IsWriting = true;
        this.m_SampleCount = val_11;
        this.m_LastSampleTime = UnityEngine.Time.realtimeSinceStartup;
    }
    public void Reset()
    {
        this.m_SampleCount = -4294967296;
        this.m_ObjectsPerSample = -1;
        this.m_LastSampleTime = -Infinityf;
        this.m_LastFrameCount = -1;
        this.m_Objects.Clear();
    }
    public void SendNext(object obj)
    {
        if(UnityEngine.Time.frameCount != this.m_LastFrameCount)
        {
                this.BeginWritePackage();
        }
        
        this.m_LastFrameCount = UnityEngine.Time.frameCount;
        if(this.m_IsWriting == false)
        {
                return;
        }
        
        this.m_Objects.Add(item:  obj);
    }
    public bool HasQueuedObjects()
    {
        return (bool)(this.m_NextObjectIndex != 1) ? 1 : 0;
    }
    public object ReceiveNext()
    {
        int val_2;
        if(this.m_NextObjectIndex == 1)
        {
                return 0;
        }
        
        val_2 = this.m_NextObjectIndex;
        if(this.m_NextObjectIndex >= this.m_Objects.Count)
        {
                int val_2 = this.m_ObjectsPerSample;
            val_2 = val_2 - val_2;
            this.m_NextObjectIndex = val_2;
        }
        
        val_2 = val_2 + 1;
        this.m_NextObjectIndex = val_2;
        if(this.m_Objects != null)
        {
                return this.m_Objects.Item[val_2];
        }
        
        return this.m_Objects.Item[val_2];
    }
    public void Serialize(PhotonStream stream)
    {
        var val_5;
        if((this.m_Objects.Count >= 1) && ((this.m_ObjectsPerSample & 2147483648) != 0))
        {
                this.m_ObjectsPerSample = this.m_Objects.Count;
        }
        
        stream.SendNext(obj:  this.m_SampleCount);
        stream.SendNext(obj:  this.m_ObjectsPerSample);
        val_5 = 0;
        goto label_7;
        label_12:
        stream.SendNext(obj:  1152921504607113216);
        val_5 = 1;
        label_7:
        if(val_5 >= this.m_Objects.Count)
        {
            goto label_10;
        }
        
        object val_4 = this.m_Objects.Item[1];
        if(stream != null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_10:
        this.m_Objects.Clear();
        this.m_SampleCount = 0;
    }
    public void Deserialize(PhotonStream stream)
    {
        var val_11;
        var val_12;
        System.Collections.Generic.List<System.Object> val_13;
        this.m_Objects.Clear();
        object val_1 = stream.ReceiveNext();
        val_11 = 1152921504607113216;
        val_12 = null;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        this.m_SampleCount = null;
        object val_3 = stream.ReceiveNext();
        val_12 = null;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
        val_13 = this.m_Objects;
        this.m_ObjectsPerSample = null;
        if((1152921504606900224 * this.m_SampleCount) > 0)
        {
                do
        {
            val_13.Add(item:  stream.ReceiveNext());
            int val_11 = this.m_SampleCount;
            val_13 = this.m_Objects;
            val_11 = 0 + 1;
            val_11 = this.m_ObjectsPerSample * val_11;
        }
        while(val_11 < val_11);
        
        }
        
        this.m_NextObjectIndex = (val_13.Count < 1) ? -1 : 0;
    }

}
