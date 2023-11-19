using UnityEngine;
private class GpgsSaveGameProvider.GpgsCloudWriteResult : ICloudSaveWriteResult
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private bool <Success>k__BackingField;
    
    // Properties
    public bool Success { get; set; }
    
    // Methods
    public GpgsSaveGameProvider.GpgsCloudWriteResult(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata data)
    {
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

}
