using UnityEngine;
private sealed class NativeSavedGameClient.<CommitUpdate>c__AnonStorey7
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback;
    
    // Methods
    public NativeSavedGameClient.<CommitUpdate>c__AnonStorey7()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.CommitResponse response)
    {
        var val_8;
        System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_9;
        GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus val_10;
        GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata val_11;
        var val_12;
        ResponseStatus val_13;
        if(response == null)
        {
            goto label_1;
        }
        
        val_9 = this.callback;
        if(response.RequestSucceeded() == false)
        {
            goto label_4;
        }
        
        goto label_3;
        label_1:
        val_9 = this.callback;
        val_8 = response.RequestSucceeded();
        if(val_8 == false)
        {
            goto label_4;
        }
        
        label_3:
        val_10 = 1;
        val_11 = response.Data();
        val_12 = public System.Void System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>::Invoke(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus arg1, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata arg2);
        goto label_6;
        label_4:
        ResponseStatus val_5 = response.ResponseStatus();
        val_13 = null;
        val_11 = 0;
        val_10 = GooglePlayGames.Native.NativeSavedGameClient.AsRequestStatus(status:  val_13);
        val_12 = public System.Void System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>::Invoke(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus arg1, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata arg2);
        label_6:
        val_9.Invoke(arg1:  val_10, arg2:  val_11);
    }

}
