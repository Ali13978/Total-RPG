using UnityEngine;
private sealed class GpgsSaveGameProvider.<gpgs_getSaveGames>c__AnonStorey5
{
    // Fields
    internal System.Action<TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult> callback;
    
    // Methods
    public GpgsSaveGameProvider.<gpgs_getSaveGames>c__AnonStorey5()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> list)
    {
        string val_1 = 0 + "get save game list: "("get save game list: ");
        UnityEngine.Debug.Log(message:  0);
        this.callback.Invoke(obj:  new GpgsSaveGameProvider.GpgsSaveGameListResult(status:  status, list:  list));
    }

}
