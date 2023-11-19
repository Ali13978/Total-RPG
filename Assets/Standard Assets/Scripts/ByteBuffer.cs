using UnityEngine;
public class ByteBuffer
{
    // Fields
    private byte[] buffer;
    public int pointer;
    
    // Methods
    public ByteBuffer(byte[] buf)
    {
        this.buffer = buf;
    }
    public int readInt()
    {
        int val_2 = this.pointer;
        val_2 = val_2 + 4;
        this.pointer = val_2;
        return (int)System.BitConverter.ToInt32(value:  0, startIndex:  this.buffer);
    }
    public float readFloat()
    {
        int val_2 = this.pointer;
        val_2 = val_2 + 4;
        this.pointer = val_2;
        return (float)System.BitConverter.ToSingle(value:  0, startIndex:  this.buffer);
    }

}
