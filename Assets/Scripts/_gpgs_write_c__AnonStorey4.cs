using UnityEngine;
private sealed class GpgsSaveGameProvider.<gpgs_write>c__AnonStorey4
{
    // Fields
    internal System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult> callback;
    internal GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata currentGame;
    internal System.TimeSpan playedTime;
    internal string description;
    internal byte[] saveData;
    internal System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> writeCallback;
    
    // Methods
    public GpgsSaveGameProvider.<gpgs_write>c__AnonStorey4()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata game)
    {
        string val_1 = status.ToString();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        string val_3 = 0 + "Saved Game Write: "("Saved Game Write: ");
        UnityEngine.Debug.Log(message:  0);
        if(null != 1)
        {
                return;
        }
        
        typeof(GpgsSaveGameProvider.GpgsCloudWriteResult).__il2cppRuntimeField_10 = 1;
        this = this.callback;
        this.Invoke(obj:  new System.Object());
    }
    internal void <>m__1(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata game)
    {
        string val_1 = status.ToString();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        string val_3 = 0 + "Saved Game Read: "("Saved Game Read: ");
        UnityEngine.Debug.Log(message:  0);
        this.currentGame = game;
        if(null != 1)
        {
                return;
        }
        
        TzarGames.Endless.CloudSaveSystem.GpgsSaveGameProvider.gpgs_writeSavedGame(game:  0, playedTime:  new System.TimeSpan() {_ticks = game}, description:  this.playedTime, savedData:  this.description, callback:  this.saveData);
    }

}
