using UnityEngine;
public class FriendInfo
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <UserId>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private bool <IsOnline>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <Room>k__BackingField;
    
    // Properties
    [System.ObsoleteAttribute]
    public string Name { get; }
    public string UserId { get; set; }
    public bool IsOnline { get; set; }
    public string Room { get; set; }
    public bool IsInRoom { get; }
    
    // Methods
    public FriendInfo()
    {
    
    }
    public string get_Name()
    {
        return (string)this.<UserId>k__BackingField;
    }
    public string get_UserId()
    {
        return (string)this.<UserId>k__BackingField;
    }
    protected internal void set_UserId(string value)
    {
        this.<UserId>k__BackingField = value;
    }
    public bool get_IsOnline()
    {
        return (bool)this.<IsOnline>k__BackingField;
    }
    protected internal void set_IsOnline(bool value)
    {
        this.<IsOnline>k__BackingField = value;
    }
    public string get_Room()
    {
        return (string)this.<Room>k__BackingField;
    }
    protected internal void set_Room(string value)
    {
        this.<Room>k__BackingField = value;
    }
    public bool get_IsInRoom()
    {
        string val_3;
        var val_4;
        val_3 = this;
        if((this.<IsOnline>k__BackingField) != false)
        {
                val_3 = this.<Room>k__BackingField;
            val_4 = (System.String.IsNullOrEmpty(value:  0)) ^ 1;
            return (bool)val_4 & 1;
        }
        
        val_4 = 0;
        return (bool)val_4 & 1;
    }
    public override string ToString()
    {
        var val_3;
        if((this.<IsOnline>k__BackingField) != false)
        {
                var val_2 = (this.IsInRoom != true) ? "playing" : "on master";
            return System.String.Format(format:  0, arg0:  "{0}\t is: {1}", arg1:  this.<UserId>k__BackingField);
        }
        
        val_3 = "offline";
        return System.String.Format(format:  0, arg0:  "{0}\t is: {1}", arg1:  this.<UserId>k__BackingField);
    }

}
