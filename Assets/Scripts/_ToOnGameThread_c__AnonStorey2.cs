using UnityEngine;
private sealed class NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1.<ToOnGameThread>c__AnonStorey2
{
    // Fields
    internal GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver;
    internal GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original;
    internal byte[] originalData;
    internal GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged;
    internal byte[] unmergedData;
    internal GooglePlayGames.Native.NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1 <>f__ref$1;
    
    // Methods
    public NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1.<ToOnGameThread>c__AnonStorey2()
    {
    
    }
    internal void <>m__0()
    {
        this.<>f__ref$1.conflictCallback.Invoke(resolver:  this.resolver, original:  this.original, originalData:  this.originalData, unmerged:  this.unmerged, unmergedData:  this.unmergedData);
    }

}
