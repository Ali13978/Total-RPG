using UnityEngine;
private sealed class EndlessSaveManager.<RestoreSaveDataFromCloud>c__AnonStorey1
{
    // Fields
    internal System.Action<TzarGames.Endless.EndlessSaveData> callback;
    
    // Methods
    public EndlessSaveManager.<RestoreSaveDataFromCloud>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult result)
    {
        var val_4;
        var val_5;
        System.Action<TzarGames.Endless.EndlessSaveData> val_6;
        TzarGames.Endless.EndlessSaveData val_7;
        var val_8;
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4 = result;
        if((result & 1) == 0)
        {
                return;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_5 = result;
        TzarGames.Endless.EndlessSaveData val_3 = TzarGames.Endless.EndlessSaveManager.GetSaveDataFromBytes(bytes:  result);
        if(val_3 != null)
        {
                val_6 = this.callback;
            val_7 = val_3;
            val_8 = public System.Void System.Action<TzarGames.Endless.EndlessSaveData>::Invoke(TzarGames.Endless.EndlessSaveData obj);
        }
        else
        {
                UnityEngine.Debug.LogError(message:  0);
            val_6 = this.callback;
            val_7 = 0;
            val_8 = public System.Void System.Action<TzarGames.Endless.EndlessSaveData>::Invoke(TzarGames.Endless.EndlessSaveData obj);
        }
        
        val_6.Invoke(obj:  val_7);
    }

}
