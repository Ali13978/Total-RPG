using UnityEngine;
public abstract class BasePackage
{
    // Fields
    protected System.IO.MemoryStream buffer;
    protected System.IO.BinaryWriter writer;
    
    // Methods
    protected BasePackage()
    {
        this.buffer = new System.IO.MemoryStream();
    }
    public void initWriter()
    {
        this.writer = new System.IO.BinaryWriter(output:  this.buffer);
        if(this.writer == null)
        {
            
        }
    
    }
    public abstract int getId(); // 0
    public byte[] getBytes()
    {
        if(this.buffer == null)
        {
            
        }
    
    }
    public void send()
    {
        NetworkManagerExample.send(pack:  0);
    }
    public void writeInt(int val)
    {
        if(this.writer == null)
        {
            
        }
    
    }
    public void writeString(string val)
    {
    
    }
    public void writeFloat(float val)
    {
        if(this.writer == null)
        {
            
        }
    
    }

}
