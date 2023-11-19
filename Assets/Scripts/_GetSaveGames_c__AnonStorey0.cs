using UnityEngine;
private sealed class GpgsSaveGameProvider.<GetSaveGames>c__AnonStorey0
{
    // Fields
    internal System.Action<TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult> callback;
    
    // Methods
    public GpgsSaveGameProvider.<GetSaveGames>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(bool result)
    {
        if(result != false)
        {
                TzarGames.Endless.CloudSaveSystem.GpgsSaveGameProvider.gpgs_getSaveGames(callback:  27182);
            return;
        }
        
        typeof(TzarGames.Endless.CloudSaveSystem.DefaultSaveGameListResult).__il2cppRuntimeField_10 = 0;
        this.callback.Invoke(obj:  new System.Object());
    }

}
