using UnityEngine;
private sealed class NativeSavedGameClient.<InternalOpen>c__AnonStorey3
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback;
    internal string filename;
    internal GooglePlayGames.BasicApi.DataSource source;
    internal GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy;
    internal bool prefetchDataOnConflict;
    internal GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback;
    internal GooglePlayGames.Native.NativeSavedGameClient $this;
    
    // Methods
    public NativeSavedGameClient.<InternalOpen>c__AnonStorey3()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse response)
    {
        System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_19;
        GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus val_20;
        GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata val_21;
        var val_22;
        CommonErrorStatus.SnapshotOpenStatus val_23;
        var val_24;
        GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata val_25;
        if(response.RequestSucceeded() == false)
        {
            goto label_2;
        }
        
        if(response.ResponseStatus() != 1)
        {
            goto label_4;
        }
        
        val_19 = this.completedCallback;
        val_20 = 1;
        val_21 = response.Data();
        val_22 = public System.Void System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>::Invoke(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus arg1, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata arg2);
        goto label_12;
        label_2:
        val_19 = this.completedCallback;
        CommonErrorStatus.SnapshotOpenStatus val_5 = response.ResponseStatus();
        val_23 = null;
        val_21 = 0;
        val_20 = GooglePlayGames.Native.NativeSavedGameClient.AsRequestStatus(status:  val_23);
        val_22 = public System.Void System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>::Invoke(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus arg1, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata arg2);
        goto label_12;
        label_4:
        if(response.ResponseStatus() != 3)
        {
            goto label_14;
        }
        
        object val_8 = new System.Object();
        typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4).__il2cppRuntimeField_28 = this;
        if(response == null)
        {
            goto label_16;
        }
        
        val_24 = val_8;
        typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4).__il2cppRuntimeField_18 = response.ConflictOriginal();
        goto label_17;
        label_14:
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        val_19 = this.completedCallback;
        val_21 = 0;
        val_20 = -2;
        val_22 = public System.Void System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>::Invoke(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus arg1, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata arg2);
        label_12:
        val_19.Invoke(arg1:  val_20, arg2:  val_21);
        return;
        label_16:
        val_24 = val_8;
        typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4).__il2cppRuntimeField_18 = 0.ConflictOriginal();
        label_17:
        typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4).__il2cppRuntimeField_20 = response.ConflictUnmerged();
        if(null != 0)
        {
                val_25 = typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4).__il2cppRuntimeField_18;
        }
        else
        {
                val_25 = typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4).__il2cppRuntimeField_18;
        }
        
        NativeSavedGameClient.NativeConflictResolver val_14 = new NativeSavedGameClient.NativeConflictResolver(manager:  this.$this.mSnapshotManager, conflictId:  response.ConflictId(), original:  val_25, unmerged:  typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4).__il2cppRuntimeField_20, completeCallback:  this.completedCallback, retryOpen:  new System.Action(object:  val_8, method:  System.Void NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4::<>m__0()));
        typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4).__il2cppRuntimeField_10 = val_14;
        if(this.prefetchDataOnConflict != false)
        {
                NativeSavedGameClient.Prefetcher val_16 = new NativeSavedGameClient.Prefetcher(dataFetchedCallback:  new System.Action<System.Byte[], System.Byte[]>(object:  val_8, method:  System.Void NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4::<>m__1(byte[] originalData, byte[] unmergedData)), completedCallback:  this.completedCallback);
            this.$this.mSnapshotManager.Read(metadata:  typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4).__il2cppRuntimeField_18, callback:  new System.Action<ReadResponse>(object:  val_16, method:  System.Void NativeSavedGameClient.Prefetcher::OnOriginalDataRead(GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse readResponse)));
            this.$this.mSnapshotManager.Read(metadata:  typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4).__il2cppRuntimeField_20, callback:  new System.Action<ReadResponse>(object:  val_16, method:  System.Void NativeSavedGameClient.Prefetcher::OnUnmergedDataRead(GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse readResponse)));
            return;
        }
        
        this.conflictCallback.Invoke(resolver:  val_14, original:  typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4).__il2cppRuntimeField_18, originalData:  0, unmerged:  typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3.<InternalOpen>c__AnonStorey4).__il2cppRuntimeField_20, unmergedData:  0);
    }

}
