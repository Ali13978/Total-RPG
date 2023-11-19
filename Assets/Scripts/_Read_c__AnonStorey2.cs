using UnityEngine;
private sealed class NativeIOSCloudSaveProvider.<Read>c__AnonStorey2
{
    // Fields
    internal GK_SavedGame game;
    internal TzarGames.Endless.CloudSaveSystem.NativeIOSCloudSaveProvider.<Read>c__AnonStorey3 <>f__ref$3;
    
    // Methods
    public NativeIOSCloudSaveProvider.<Read>c__AnonStorey2()
    {
    
    }
    internal void <>m__0(GK_SaveDataLoaded loaded)
    {
        GK_SaveDataLoaded val_6 = loaded;
        if(val_6.IsSucceeded == false)
        {
            goto label_5;
        }
        
        val_6 = val_6.SavedGame;
        if(val_6.IsDataLoaded == false)
        {
            goto label_5;
        }
        
        typeof(TzarGames.Endless.CloudSaveSystem.DefaultReadResult).__il2cppRuntimeField_10 = 1;
        val_6 = this.game;
        typeof(TzarGames.Endless.CloudSaveSystem.DefaultReadResult).__il2cppRuntimeField_18 = val_6.Data;
        goto label_8;
        label_5:
        typeof(TzarGames.Endless.CloudSaveSystem.DefaultReadResult).__il2cppRuntimeField_10 = 0;
        label_8:
        this.<>f__ref$3.callback.Invoke(obj:  new System.Object());
    }

}
