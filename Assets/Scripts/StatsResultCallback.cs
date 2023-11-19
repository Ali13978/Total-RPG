using UnityEngine;
private class AndroidClient.StatsResultCallback : ResultCallbackProxy<Com.Google.Android.Gms.Games.Stats.Stats_LoadPlayerStatsResultObject>
{
    // Fields
    private System.Action<int, Com.Google.Android.Gms.Games.Stats.PlayerStats> callback;
    
    // Methods
    public AndroidClient.StatsResultCallback(System.Action<int, Com.Google.Android.Gms.Games.Stats.PlayerStats> callback)
    {
        this.callback = callback;
    }
    public override void OnResult(Com.Google.Android.Gms.Games.Stats.Stats_LoadPlayerStatsResultObject arg_Result_1)
    {
        this.callback.Invoke(arg1:  arg_Result_1.getStatus().getStatusCode(), arg2:  arg_Result_1.getPlayerStats());
    }

}
