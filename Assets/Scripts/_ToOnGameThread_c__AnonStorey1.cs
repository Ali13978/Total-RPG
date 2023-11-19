using UnityEngine;
private sealed class NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1
{
    // Fields
    internal GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback;
    
    // Methods
    public NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData)
    {
        if(null != 0)
        {
                typeof(NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1.<ToOnGameThread>c__AnonStorey2).__il2cppRuntimeField_38 = this;
            typeof(NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1.<ToOnGameThread>c__AnonStorey2).__il2cppRuntimeField_10 = resolver;
            typeof(NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1.<ToOnGameThread>c__AnonStorey2).__il2cppRuntimeField_18 = original;
            typeof(NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1.<ToOnGameThread>c__AnonStorey2).__il2cppRuntimeField_20 = originalData;
            typeof(NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1.<ToOnGameThread>c__AnonStorey2).__il2cppRuntimeField_28 = unmerged;
        }
        else
        {
                mem[56] = this;
            mem[16] = resolver;
            mem[24] = original;
            mem[32] = originalData;
            mem[40] = unmerged;
        }
        
        typeof(NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1.<ToOnGameThread>c__AnonStorey2).__il2cppRuntimeField_30 = unmergedData;
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1.<ToOnGameThread>c__AnonStorey2::<>m__0());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }

}
