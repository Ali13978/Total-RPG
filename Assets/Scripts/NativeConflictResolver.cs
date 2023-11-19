using UnityEngine;
private class NativeSavedGameClient.NativeConflictResolver : IConflictResolver
{
    // Fields
    private readonly GooglePlayGames.Native.PInvoke.SnapshotManager mManager;
    private readonly string mConflictId;
    private readonly GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata mOriginal;
    private readonly GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata mUnmerged;
    private readonly System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> mCompleteCallback;
    private readonly System.Action mRetryFileOpen;
    
    // Methods
    internal NativeSavedGameClient.NativeConflictResolver(GooglePlayGames.Native.PInvoke.SnapshotManager manager, string conflictId, GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata original, GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata unmerged, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completeCallback, System.Action retryOpen)
    {
        val_1 = new System.Object();
        this.mManager = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        this.mConflictId = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        this.mOriginal = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        this.mUnmerged = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        this.mCompleteCallback = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        this.mRetryFileOpen = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
    }
    public void ResolveConflict(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate metadataUpdate, byte[] updatedData)
    {
        var val_6 = 0;
        if(( != this.mOriginal) && ( != this.mUnmerged))
        {
                GooglePlayGames.OurUtils.Logger.e(msg:  0);
            this.mCompleteCallback.Invoke(arg1:  -4, arg2:  0);
            return;
        }
        
        NativeSnapshotMetadataChange.Builder val_2 = new NativeSnapshotMetadataChange.Builder();
        this.mManager.Resolve(metadata:  null, metadataChange:  From(update:  new GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate() {mDescriptionUpdated = metadataUpdate.mDescriptionUpdated, mCoverImageUpdated = metadataUpdate.mCoverImageUpdated, mNewPlayedTime = new System.Nullable<System.TimeSpan>() {HasValue = metadataUpdate.mNewPlayedTime.HasValue}}).Build(), conflictId:  this.mConflictId, updatedData:  updatedData, callback:  new System.Action<OpenResponse>(object:  this, method:  System.Void NativeSavedGameClient.NativeConflictResolver::<ResolveConflict>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse response)));
    }
    public void ChooseMetadata(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata)
    {
        var val_5 = 0;
        if(( != this.mOriginal) && ( != this.mUnmerged))
        {
                GooglePlayGames.OurUtils.Logger.e(msg:  0);
            this.mCompleteCallback.Invoke(arg1:  -4, arg2:  0);
            return;
        }
        
        NativeSnapshotMetadataChange.Builder val_2 = new NativeSnapshotMetadataChange.Builder();
        this.mManager.Resolve(metadata:  null, metadataChange:  Build(), conflictId:  this.mConflictId, callback:  new System.Action<OpenResponse>(object:  this, method:  System.Void NativeSavedGameClient.NativeConflictResolver::<ChooseMetadata>m__1(GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse response)));
    }
    private void <ResolveConflict>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse response)
    {
        CommonErrorStatus.SnapshotOpenStatus val_5;
        if(response.RequestSucceeded() != false)
        {
                this.mRetryFileOpen.Invoke();
            return;
        }
        
        CommonErrorStatus.SnapshotOpenStatus val_3 = response.ResponseStatus();
        val_5 = null;
        this.mCompleteCallback.Invoke(arg1:  GooglePlayGames.Native.NativeSavedGameClient.AsRequestStatus(status:  val_5), arg2:  0);
    }
    private void <ChooseMetadata>m__1(GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse response)
    {
        CommonErrorStatus.SnapshotOpenStatus val_5;
        if(response.RequestSucceeded() != false)
        {
                this.mRetryFileOpen.Invoke();
            return;
        }
        
        CommonErrorStatus.SnapshotOpenStatus val_3 = response.ResponseStatus();
        val_5 = null;
        this.mCompleteCallback.Invoke(arg1:  GooglePlayGames.Native.NativeSavedGameClient.AsRequestStatus(status:  val_5), arg2:  0);
    }

}
