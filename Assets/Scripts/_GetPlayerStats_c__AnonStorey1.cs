using UnityEngine;
private sealed class AndroidClient.<GetPlayerStats>c__AnonStorey1
{
    // Fields
    internal System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback;
    
    // Methods
    public AndroidClient.<GetPlayerStats>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(int result, Com.Google.Android.Gms.Games.Stats.PlayerStats stats)
    {
        GooglePlayGames.BasicApi.PlayerStats val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        string val_1 = 0 + "Result for getStats: "("Result for getStats: ");
        UnityEngine.Debug.Log(message:  0);
        val_13 = 0;
        if(stats != null)
        {
                object val_2 = null;
            val_13 = val_2;
            val_2 = new System.Object();
            typeof(GooglePlayGames.BasicApi.PlayerStats).__il2cppRuntimeField_10 = 0;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = stats;
            typeof(GooglePlayGames.BasicApi.PlayerStats).__il2cppRuntimeField_18 = V0.16B;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = stats;
            typeof(GooglePlayGames.BasicApi.PlayerStats).__il2cppRuntimeField_1C = stats;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_16 = stats;
            typeof(GooglePlayGames.BasicApi.PlayerStats).__il2cppRuntimeField_14 = stats;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_17 = stats;
            typeof(GooglePlayGames.BasicApi.PlayerStats).__il2cppRuntimeField_20 = stats;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_18 = stats;
            typeof(GooglePlayGames.BasicApi.PlayerStats).__il2cppRuntimeField_24 = V0.16B;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_19 = stats;
            typeof(GooglePlayGames.BasicApi.PlayerStats).__il2cppRuntimeField_28 = V0.16B;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_20 = stats;
            typeof(GooglePlayGames.BasicApi.PlayerStats).__il2cppRuntimeField_30 = V0.16B;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_21 = stats;
            typeof(GooglePlayGames.BasicApi.PlayerStats).__il2cppRuntimeField_2C = V0.16B;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_22 = stats;
            typeof(GooglePlayGames.BasicApi.PlayerStats).__il2cppRuntimeField_34 = V0.16B;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_23 = stats;
            typeof(GooglePlayGames.BasicApi.PlayerStats).__il2cppRuntimeField_38 = V0.16B;
        }
        
        this.callback.Invoke(arg1:  result, arg2:  val_13);
    }

}
