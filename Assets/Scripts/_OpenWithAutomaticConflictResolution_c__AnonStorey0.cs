using UnityEngine;
private sealed class NativeSavedGameClient.<OpenWithAutomaticConflictResolution>c__AnonStorey0
{
    // Fields
    internal GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy;
    internal System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback;
    
    // Methods
    public NativeSavedGameClient.<OpenWithAutomaticConflictResolution>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData)
    {
        var val_9;
        var val_11;
        var val_12;
        var val_14;
        var val_15;
        var val_17;
        var val_18;
        var val_2 = (this.resolutionStrategy < 3) ? (this.resolutionStrategy + 3) : 0;
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        if(val_2 == 5)
        {
            goto label_2;
        }
        
        if(val_2 != 4)
        {
            goto label_3;
        }
        
        var val_9 = 0;
        val_11 = 1152921504940855304;
        val_9 = val_9 + 1;
        goto label_33;
        label_1:
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_12 = original;
        goto label_13;
        label_2:
        var val_11 = 0;
        val_14 = 1152921504940855304;
        val_11 = val_11 + 1;
        goto label_37;
        label_3:
        string val_3 = 0 + "Unhandled strategy ";
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        this.completedCallback.Invoke(arg1:  -2, arg2:  0);
        return;
        label_13:
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_15 = unmerged;
        val_9 = unmerged;
        if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan(), t2:  new System.TimeSpan() {_ticks = original})) == false)
        {
            goto label_32;
        }
        
        var val_13 = 0;
        val_11 = 1152921504940855304;
        val_13 = val_13 + 1;
        label_33:
        val_17 = resolver;
        goto label_41;
        label_32:
        var val_14 = 0;
        val_14 = 1152921504940855304;
        val_14 = val_14 + 1;
        label_37:
        val_18 = resolver;
        label_41:
    }

}
