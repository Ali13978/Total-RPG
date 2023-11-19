using UnityEngine;
private class NativeSavedGameClient.Prefetcher
{
    // Fields
    private readonly object mLock;
    private bool mOriginalDataFetched;
    private byte[] mOriginalData;
    private bool mUnmergedDataFetched;
    private byte[] mUnmergedData;
    private System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback;
    private readonly System.Action<byte[], byte[]> mDataFetchedCallback;
    private static System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> <>f__am$cache0;
    private static System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> <>f__am$cache1;
    
    // Methods
    internal NativeSavedGameClient.Prefetcher(System.Action<byte[], byte[]> dataFetchedCallback, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback)
    {
        this.mLock = new System.Object();
        this.mDataFetchedCallback = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        this.completedCallback = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
    }
    internal void OnOriginalDataRead(GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse readResponse)
    {
        System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_10;
        var val_11;
        val_10 = readResponse;
        System.Threading.Monitor.Enter(obj:  0);
        if(val_10.RequestSucceeded() != false)
        {
                GooglePlayGames.OurUtils.Logger.d(msg:  0);
            this.mOriginalDataFetched = true;
            this.mOriginalData = val_10.Data();
            this.MaybeProceed();
        }
        else
        {
                GooglePlayGames.OurUtils.Logger.e(msg:  0);
            ResponseStatus val_7 = val_10.ResponseStatus();
            this.completedCallback.Invoke(arg1:  GooglePlayGames.Native.NativeSavedGameClient.AsRequestStatus(status:  null), arg2:  0);
            val_11 = null;
            if((NativeSavedGameClient.Prefetcher.<>f__am$cache0) == null)
        {
                System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_9 = new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(object:  0, method:  static System.Void NativeSavedGameClient.Prefetcher::<OnOriginalDataRead>m__0(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus , GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata ));
            NativeSavedGameClient.Prefetcher.<>f__am$cache0 = null;
            val_11 = null;
        }
        
            val_10 = NativeSavedGameClient.Prefetcher.<>f__am$cache0;
            this.completedCallback = val_10;
        }
        
        System.Threading.Monitor.Exit(obj:  0);
    }
    internal void OnUnmergedDataRead(GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse readResponse)
    {
        ReadResponse val_10 = readResponse;
        System.Threading.Monitor.Enter(obj:  0);
        if(val_10.RequestSucceeded() != false)
        {
                GooglePlayGames.OurUtils.Logger.d(msg:  0);
            this.mUnmergedDataFetched = true;
            this.mUnmergedData = val_10.Data();
            this.MaybeProceed();
        }
        else
        {
                GooglePlayGames.OurUtils.Logger.e(msg:  0);
            ResponseStatus val_7 = val_10.ResponseStatus();
            this.completedCallback.Invoke(arg1:  GooglePlayGames.Native.NativeSavedGameClient.AsRequestStatus(status:  null), arg2:  0);
            if((NativeSavedGameClient.Prefetcher.<>f__am$cache1) == null)
        {
                System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_9 = new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(object:  0, method:  static System.Void NativeSavedGameClient.Prefetcher::<OnUnmergedDataRead>m__1(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus , GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata ));
            NativeSavedGameClient.Prefetcher.<>f__am$cache1 = null;
        }
        
            val_10 = NativeSavedGameClient.Prefetcher.<>f__am$cache1;
            this.completedCallback = val_10;
        }
        
        System.Threading.Monitor.Exit(obj:  0);
    }
    private void MaybeProceed()
    {
        if((this.mOriginalDataFetched != false) && (this.mUnmergedDataFetched != false))
        {
                GooglePlayGames.OurUtils.Logger.d(msg:  0);
            this.mDataFetchedCallback.Invoke(arg1:  this.mOriginalData, arg2:  this.mUnmergedData);
            return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Not all data fetched - original:";
        typeof(System.Object[]).__il2cppRuntimeField_28 = this.mOriginalDataFetched;
        typeof(System.Object[]).__il2cppRuntimeField_29 = 29275626;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " unmerged:";
        typeof(System.Object[]).__il2cppRuntimeField_38 = this.mUnmergedDataFetched;
        typeof(System.Object[]).__il2cppRuntimeField_39 = 29275642;
        string val_1 = +0;
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
    }
    private static void <OnOriginalDataRead>m__0(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus , GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata )
    {
    
    }
    private static void <OnUnmergedDataRead>m__1(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus , GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata )
    {
    
    }

}
