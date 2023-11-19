using UnityEngine;
private sealed class NativeIOSCloudSaveProvider.<IsnGameSavesOnActionSavesFetched>c__AnonStorey4
{
    // Fields
    internal GK_FetchResult gkFetchResult;
    internal TzarGames.Endless.CloudSaveSystem.DefaultSaveGameListResult result;
    internal TzarGames.Endless.CloudSaveSystem.NativeIOSCloudSaveProvider $this;
    
    // Methods
    public NativeIOSCloudSaveProvider.<IsnGameSavesOnActionSavesFetched>c__AnonStorey4()
    {
    
    }
    internal void <>m__0(iCloudData data)
    {
        var val_8;
        var val_20;
        var val_21;
        string val_22;
        if(data.IsEmpty != false)
        {
                UnityEngine.Debug.LogWarning(message:  0);
            val_20 = 0;
        }
        else
        {
                val_20 = data.DictionaryValue;
        }
        
        int val_4 = this.gkFetchResult.SavedGames.Count;
        this.result.<Files>k__BackingField = null;
        System.Collections.Generic.List<GK_SavedGame> val_5 = this.gkFetchResult.SavedGames;
        List.Enumerator<T> val_6 = val_5.GetEnumerator();
        val_21 = 0;
        goto label_12;
        label_44:
        val_21 = 1;
        typeof(TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[]).__il2cppRuntimeField_20 = val_5;
        typeof(TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[]).__il2cppRuntimeField_28 = this.result;
        label_12:
        if((0 & 1) == 0)
        {
            goto label_49;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_9 = val_8.InitializationCallback;
        string val_10 = val_9.Name;
        object val_11 = new System.Object();
        this.result.<Files>k__BackingField[1] = null;
        typeof(TzarGames.Endless.CloudSaveSystem.DefaultSaveFile).__il2cppRuntimeField_10 = val_10;
        if(val_20 == null)
        {
            goto label_21;
        }
        
        if((val_20.TryGetValue(key:  val_10, value: out  0)) == false)
        {
            goto label_22;
        }
        
        if((UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0)) == null)
        {
            goto label_24;
        }
        
        if(null != 0)
        {
            goto label_41;
        }
        
        goto label_41;
        label_21:
        val_22 = 0 + "Save ";
        if(null != 0)
        {
            goto label_41;
        }
        
        goto label_41;
        label_22:
        UnityEngine.Debug.LogWarning(message:  0);
        val_22 = 0 + "Save ";
        if(null != 0)
        {
            goto label_41;
        }
        
        goto label_41;
        label_24:
        string val_17 = 0 + "Failed to parse meta file ";
        UnityEngine.Debug.Log(message:  0);
        val_22 = 0 + "Save ";
        label_41:
        typeof(TzarGames.Endless.CloudSaveSystem.DefaultSaveFile).__il2cppRuntimeField_18 = val_22;
        System.DateTime val_19 = val_9.ModificationDate;
        if(null != 0)
        {
            goto label_44;
        }
        
        goto label_44;
        label_49:
        val_8.Dispose();
        this.result.<Success>k__BackingField = true;
        this.$this.processGetSaveGameCallbacks(result:  this.result);
    }

}
