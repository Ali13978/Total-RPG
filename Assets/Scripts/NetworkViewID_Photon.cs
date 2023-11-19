using UnityEngine;
public class Network_Photon.NetworkViewID_Photon : NetworkViewID
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private int <NativeID>k__BackingField;
    
    // Properties
    public int NativeID { get; set; }
    public override ulong ID { get; }
    public override bool IsUnassigned { get; }
    
    // Methods
    public Network_Photon.NetworkViewID_Photon(int nativeId)
    {
        this.<NativeID>k__BackingField = nativeId;
    }
    public int get_NativeID()
    {
        return (int)this.<NativeID>k__BackingField;
    }
    private void set_NativeID(int value)
    {
        this.<NativeID>k__BackingField = value;
    }
    public override ulong get_ID()
    {
        return (ulong)this.<NativeID>k__BackingField;
    }
    public override bool get_IsUnassigned()
    {
        return (bool)((this.<NativeID>k__BackingField) < 1) ? 1 : 0;
    }

}
