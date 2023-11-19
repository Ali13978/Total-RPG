using UnityEngine;
private class GpgsSaveGameProvider.GpgsCloudReadResult : ICloudSaveReadResult
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private bool <Success>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private byte[] <Data>k__BackingField;
    
    // Properties
    public bool Success { get; set; }
    public byte[] Data { get; set; }
    
    // Methods
    public GpgsSaveGameProvider.GpgsCloudReadResult(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, byte[] data)
    {
        this.<Data>k__BackingField = data;
        this.<Success>k__BackingField = (status == 1) ? 1 : 0;
    }
    public bool get_Success()
    {
        return (bool)this.<Success>k__BackingField;
    }
    private void set_Success(bool value)
    {
        this.<Success>k__BackingField = value;
    }
    public byte[] get_Data()
    {
        return (System.Byte[])this.<Data>k__BackingField;
    }
    private void set_Data(byte[] value)
    {
        this.<Data>k__BackingField = value;
    }

}
