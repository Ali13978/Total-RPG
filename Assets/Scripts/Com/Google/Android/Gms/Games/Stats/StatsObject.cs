using UnityEngine;

namespace Com.Google.Android.Gms.Games.Stats
{
    public class StatsObject : JavaObjWrapper, Stats
    {
        // Fields
        private const string CLASS_NAME = "com/google/android/gms/games/stats/Stats";
        
        // Methods
        public StatsObject(IntPtr ptr)
        {
        
        }
        public Com.Google.Android.Gms.Common.Api.PendingResult<Com.Google.Android.Gms.Games.Stats.Stats_LoadPlayerStatsResultObject> loadPlayerStats(Com.Google.Android.Gms.Common.Api.GoogleApiClient arg_GoogleApiClient_1, bool arg_bool_2)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_GoogleApiClient_1;
            typeof(System.Object[]).__il2cppRuntimeField_28 = arg_bool_2;
            typeof(System.Object[]).__il2cppRuntimeField_29 = 28686008;
            return (Com.Google.Android.Gms.Common.Api.PendingResult<Com.Google.Android.Gms.Games.Stats.Stats_LoadPlayerStatsResultObject>)new Com.Google.Android.Gms.Common.Api.PendingResult<Com.Google.Android.Gms.Games.Stats.Stats_LoadPlayerStatsResultObject>(ptr:  this.InvokeCall<System.IntPtr>(name:  "loadPlayerStats", sig:  "(Lcom/google/android/gms/common/api/GoogleApiClient;Z)Lcom/google/android/gms/common/api/PendingResult;", args:  null));
        }
    
    }

}
