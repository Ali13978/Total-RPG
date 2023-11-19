using UnityEngine;
public class SK_RequestCapabilitieResult : Result
{
    // Fields
    private SK_CloudServiceCapability _Capability;
    
    // Properties
    public SK_CloudServiceCapability Capability { get; }
    
    // Methods
    public SK_RequestCapabilitieResult(SK_CloudServiceCapability capability)
    {
        val_1 = new System.Object();
        this._Capability = capability;
    }
    public SK_RequestCapabilitieResult(string errorData)
    {
        this = new System.Object();
        mem[1152921510330657136] = new SA.Common.Models.Error(errorData:  errorData);
    }
    public SK_CloudServiceCapability get_Capability()
    {
        return (SK_CloudServiceCapability)this._Capability;
    }

}
