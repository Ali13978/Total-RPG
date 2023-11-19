using UnityEngine;
private sealed class GpgsSaveGameProvider.<gpgs_read>c__AnonStorey3
{
    // Fields
    internal System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult> callback;
    internal System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, byte[]> readBinaryCallback;
    
    // Methods
    public GpgsSaveGameProvider.<gpgs_read>c__AnonStorey3()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, byte[] data)
    {
        System.Byte[] val_5;
        TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult val_6;
        val_5 = data;
        string val_1 = status.ToString();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_6 = 0 + "Saved Game Binary Read: "("Saved Game Binary Read: ");
        UnityEngine.Debug.Log(message:  0);
        if(null != 1)
        {
                return;
        }
        
        object val_4 = null;
        val_6 = val_4;
        val_4 = new System.Object();
        typeof(GpgsSaveGameProvider.GpgsCloudReadResult).__il2cppRuntimeField_10 = 1;
        typeof(GpgsSaveGameProvider.GpgsCloudReadResult).__il2cppRuntimeField_18 = val_5;
        val_5 = this.callback;
        val_5.Invoke(obj:  val_6);
    }
    internal void <>m__1(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata game)
    {
        var val_7;
        string val_1 = status.ToString();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        string val_3 = 0 + "Saved Game Read: "("Saved Game Read: ");
        UnityEngine.Debug.Log(message:  0);
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_7 = GooglePlayGames.PlayGamesPlatform.Instance.SavedGame;
    }

}
