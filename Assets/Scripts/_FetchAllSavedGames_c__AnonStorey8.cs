using UnityEngine;
private sealed class NativeSavedGameClient.<FetchAllSavedGames>c__AnonStorey8
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> callback;
    
    // Methods
    public NativeSavedGameClient.<FetchAllSavedGames>c__AnonStorey8()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.FetchAllResponse response)
    {
        System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_11;
        System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> val_12;
        GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus val_13;
        System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_14;
        var val_15;
        ResponseStatus val_16;
        if(response == null)
        {
            goto label_1;
        }
        
        val_12 = this.callback;
        if(response.RequestSucceeded() == false)
        {
            goto label_4;
        }
        
        goto label_3;
        label_1:
        val_12 = this.callback;
        val_11 = response.RequestSucceeded();
        if(val_11 == false)
        {
            goto label_4;
        }
        
        label_3:
        System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata> val_4 = response.Data();
        System.Collections.Generic.IEnumerable<TResult> val_5 = System.Linq.Enumerable.Cast<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(source:  0);
        val_13 = 1;
        val_14 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0);
        val_15 = public System.Void System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>::Invoke(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus arg1, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> arg2);
        goto label_6;
        label_4:
        ResponseStatus val_7 = response.ResponseStatus();
        val_16 = null;
        System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_9 = null;
        val_11 = val_9;
        val_9 = new System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>();
        val_13 = GooglePlayGames.Native.NativeSavedGameClient.AsRequestStatus(status:  val_16);
        val_14 = val_11;
        val_15 = public System.Void System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>::Invoke(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus arg1, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> arg2);
        label_6:
        val_12.Invoke(arg1:  val_13, arg2:  val_14);
    }

}
