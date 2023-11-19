using UnityEngine;
private class GpgsSaveGameProvider.GpgsSaveGameListResult : ICloudGetSaveGameListResult
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private bool <Success>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[] <Files>k__BackingField;
    
    // Properties
    public bool Success { get; set; }
    public TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[] Files { get; set; }
    
    // Methods
    public GpgsSaveGameProvider.GpgsSaveGameListResult(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> list)
    {
        TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[] val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = status;
        val_1 = new System.Object();
        this.<Success>k__BackingField = (val_11 == 1) ? 1 : 0;
        if(val_1 == null)
        {
                return;
        }
        
        int val_3 = val_1.Count;
        val_11 = null;
        this.<Files>k__BackingField = val_11;
        if(val_1.Count < 1)
        {
                return;
        }
        
        do
        {
            GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata val_5 = val_1.Item[0];
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = val_5;
            typeof(GpgsSaveGameProvider.GpgsSaveFile).__il2cppRuntimeField_10 = val_5;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_13 = val_5;
            typeof(GpgsSaveGameProvider.GpgsSaveFile).__il2cppRuntimeField_18 = val_5;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = val_5;
            typeof(GpgsSaveGameProvider.GpgsSaveFile).__il2cppRuntimeField_20 = val_5;
            typeof(GpgsSaveGameProvider.GpgsSaveFile).__il2cppRuntimeField_28 = null;
            this.<Files>k__BackingField[0] = new System.Object();
            val_11 = 0 + 1;
        }
        while(val_11 < val_1.Count);
    
    }
    public bool get_Success()
    {
        return (bool)this.<Success>k__BackingField;
    }
    private void set_Success(bool value)
    {
        this.<Success>k__BackingField = value;
    }
    public TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[] get_Files()
    {
        return (TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[])this.<Files>k__BackingField;
    }
    private void set_Files(TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[] value)
    {
        this.<Files>k__BackingField = value;
    }

}
