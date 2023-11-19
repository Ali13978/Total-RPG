using UnityEngine;
public class PhotonStream
{
    // Fields
    private bool write;
    private System.Collections.Generic.Queue<object> writeData;
    private object[] readData;
    internal byte currentItem;
    
    // Properties
    public bool isWriting { get; }
    public bool isReading { get; }
    public int Count { get; }
    
    // Methods
    public PhotonStream(bool write, object[] incomingData)
    {
        this.write = write;
        if(incomingData != null)
        {
                this.readData = incomingData;
            return;
        }
        
        this.writeData = new System.Collections.Generic.Queue<System.Object>(count:  10);
    }
    public void SetReadStream(object[] incomingData, byte pos = 0)
    {
        this.readData = incomingData;
        this.currentItem = pos;
        this.write = false;
    }
    internal void ResetWriteStream()
    {
        this.writeData.Clear();
    }
    public bool get_isWriting()
    {
        return (bool)this.write;
    }
    public bool get_isReading()
    {
        return (bool)(this.write == false) ? 1 : 0;
    }
    public int get_Count()
    {
        if(this.write != false)
        {
                if(this.writeData != null)
        {
                return this.writeData.Count;
        }
        
            return this.writeData.Count;
        }
        
        if(this.readData != null)
        {
                return (int)this.readData.Length;
        }
        
        return (int)this.readData.Length;
    }
    public object ReceiveNext()
    {
        object val_1;
        if(this.write != false)
        {
                UnityEngine.Debug.LogError(message:  0);
            val_1 = 0;
            return val_1;
        }
        
        byte val_1 = this.currentItem;
        val_1 = this.readData[this.currentItem];
        val_1 = val_1 + 1;
        this.currentItem = val_1;
        return val_1;
    }
    public object PeekNext()
    {
        byte val_1;
        object val_2;
        val_1 = this;
        if(this.write != false)
        {
                UnityEngine.Debug.LogError(message:  0);
            val_2 = 0;
            return val_2;
        }
        
        val_1 = this.currentItem;
        val_2 = this.readData[val_1];
        return val_2;
    }
    public void SendNext(object obj)
    {
        if(this.write != false)
        {
                this.writeData.Enqueue(item:  obj);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  0);
    }
    public object[] ToArray()
    {
        if(this.write == false)
        {
                return (System.Object[])this.readData;
        }
        
        if(this.writeData != null)
        {
                return this.writeData.ToArray();
        }
        
        return this.writeData.ToArray();
    }
    public void Serialize(ref bool myBool)
    {
        byte val_4;
        if(this.write != false)
        {
                this = this.writeData;
            this.Enqueue(item:  (myBool == true) ? 1 : 0);
            return;
        }
        
        val_4 = this.currentItem;
        if(this.readData.Length <= val_4)
        {
                return;
        }
        
        object val_4 = this.readData[val_4];
        val_4 = null;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        myBool = null;
        byte val_5 = this.currentItem;
        val_5 = val_5 + 1;
        this.currentItem = val_5;
    }
    public void Serialize(ref int myInt)
    {
        byte val_3;
        if(this.write != false)
        {
                1152921512399230832 = myInt;
            this.writeData.Enqueue(item:  myInt);
            return;
        }
        
        val_3 = this.currentItem;
        if(this.readData.Length <= val_3)
        {
                return;
        }
        
        object val_3 = this.readData[val_3];
        val_3 = null;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        myInt = null;
        byte val_4 = this.currentItem;
        val_4 = val_4 + 1;
        this.currentItem = val_4;
    }
    public void Serialize(ref string value)
    {
        byte val_3;
        string val_4;
        if(this.write != false)
        {
                this.writeData.Enqueue(item:  value);
            return;
        }
        
        val_3 = this.currentItem;
        if(this.readData.Length <= val_3)
        {
                return;
        }
        
        val_3 = this.readData[val_3];
        if(val_3 == null)
        {
            goto label_7;
        }
        
        val_4 = val_3;
        if(null != null)
        {
                val_4 = 0;
        }
        
        value = val_4;
        if(null == null)
        {
            goto label_10;
        }
        
        goto label_10;
        label_7:
        value = 0;
        label_10:
        byte val_3 = this.currentItem;
        val_3 = val_3 + 1;
        this.currentItem = val_3;
    }
    public void Serialize(ref char value)
    {
        byte val_3;
        if(this.write != false)
        {
                1152921512399806768 = value;
            this.writeData.Enqueue(item:  value);
            return;
        }
        
        val_3 = this.currentItem;
        if(this.readData.Length <= val_3)
        {
                return;
        }
        
        object val_3 = this.readData[val_3];
        val_3 = null;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        value = null;
        byte val_4 = this.currentItem;
        val_4 = val_4 + 1;
        this.currentItem = val_4;
    }
    public void Serialize(ref short value)
    {
        byte val_3;
        if(this.write != false)
        {
                1152921512400098832 = value;
            this.writeData.Enqueue(item:  value);
            return;
        }
        
        val_3 = this.currentItem;
        if(this.readData.Length <= val_3)
        {
                return;
        }
        
        object val_3 = this.readData[val_3];
        val_3 = null;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        value = null;
        byte val_4 = this.currentItem;
        val_4 = val_4 + 1;
        this.currentItem = val_4;
    }
    public void Serialize(ref float obj)
    {
        byte val_3;
        if(this.write != false)
        {
                1152921512400390896 = obj;
            this.writeData.Enqueue(item:  obj);
            return;
        }
        
        val_3 = this.currentItem;
        if(this.readData.Length <= val_3)
        {
                return;
        }
        
        object val_3 = this.readData[val_3];
        val_3 = null;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        obj = null;
        byte val_4 = this.currentItem;
        val_4 = val_4 + 1;
        this.currentItem = val_4;
    }
    public void Serialize(ref PhotonPlayer obj)
    {
        byte val_5;
        PhotonPlayer val_6;
        if(this.write != false)
        {
                this.writeData.Enqueue(item:  obj);
            return;
        }
        
        val_5 = this.currentItem;
        if(this.readData.Length <= val_5)
        {
                return;
        }
        
        val_5 = this.readData[val_5];
        if(val_5 != null)
        {
                val_6 = val_5;
            val_6 = 0;
            obj = val_6;
        }
        else
        {
                obj = 0;
        }
        
        byte val_5 = this.currentItem;
        val_5 = val_5 + 1;
        this.currentItem = val_5;
    }
    public void Serialize(ref UnityEngine.Vector3 obj)
    {
        byte val_2;
        object val_3;
        var val_4;
        val_3 = 1152921512400966848;
        if(this.write != false)
        {
                val_3 = obj.x;
            this.writeData.Enqueue(item:  obj.x);
            return;
        }
        
        val_2 = this.currentItem;
        if(this.readData.Length <= val_2)
        {
                return;
        }
        
        object val_2 = this.readData[val_2];
        val_2 = null;
        val_4 = 0;
        obj.z = UnityEngine.Vector3.__il2cppRuntimeField_element_class;
        obj.x = null;
        byte val_3 = this.currentItem;
        val_3 = val_3 + 1;
        this.currentItem = val_3;
    }
    public void Serialize(ref UnityEngine.Vector2 obj)
    {
        byte val_2;
        if(this.write != false)
        {
                1152921512401258944 = obj.x;
            this.writeData.Enqueue(item:  obj.x);
            return;
        }
        
        val_2 = this.currentItem;
        if(this.readData.Length <= val_2)
        {
                return;
        }
        
        object val_2 = this.readData[val_2];
        val_2 = null;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        obj.x = null;
        byte val_3 = this.currentItem;
        val_3 = val_3 + 1;
        this.currentItem = val_3;
    }
    public void Serialize(ref UnityEngine.Quaternion obj)
    {
        byte val_2;
        if(this.write != false)
        {
                1152921512401551056 = obj.x;
            this.writeData.Enqueue(item:  obj.x);
            return;
        }
        
        val_2 = this.currentItem;
        if(this.readData.Length <= val_2)
        {
                return;
        }
        
        object val_2 = this.readData[val_2];
        val_2 = null;
        obj.x = null;
        byte val_3 = this.currentItem;
        val_3 = val_3 + 1;
        this.currentItem = val_3;
    }

}
