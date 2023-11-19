using UnityEngine;
private sealed class NativeSavedGameClient.<ShowSelectSavedGameUI>c__AnonStorey6
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback;
    
    // Methods
    public NativeSavedGameClient.<ShowSelectSavedGameUI>c__AnonStorey6()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.SnapshotSelectUIResponse response)
    {
        UIStatus val_5;
        GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata val_6;
        UIStatus val_1 = response.RequestStatus();
        val_5 = null;
        val_6 = 0;
        if(response.RequestSucceeded() != false)
        {
                val_6 = response.Data();
        }
        
        this.callback.Invoke(arg1:  GooglePlayGames.Native.NativeSavedGameClient.AsUIStatus(uiStatus:  val_5), arg2:  val_6);
    }

}
