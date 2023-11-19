using UnityEngine;

namespace Com.Google.Android.Gms.Games.Stats
{
    public class Stats_LoadPlayerStatsResultObject : JavaObjWrapper, Stats_LoadPlayerStatsResult, Result
    {
        // Fields
        private const string CLASS_NAME = "com/google/android/gms/games/stats/Stats$LoadPlayerStatsResult";
        
        // Methods
        public Stats_LoadPlayerStatsResultObject(IntPtr ptr)
        {
        
        }
        public Com.Google.Android.Gms.Games.Stats.PlayerStats getPlayerStats()
        {
            return (Com.Google.Android.Gms.Games.Stats.PlayerStats)new Google.Developers.JavaObjWrapper(rawObject:  this.InvokeCall<System.IntPtr>(name:  "getPlayerStats", sig:  "()Lcom/google/android/gms/games/stats/PlayerStats;", args:  null));
        }
        public Com.Google.Android.Gms.Common.Api.Status getStatus()
        {
            return (Com.Google.Android.Gms.Common.Api.Status)new Google.Developers.JavaObjWrapper(rawObject:  this.InvokeCall<System.IntPtr>(name:  "getStatus", sig:  "()Lcom/google/android/gms/common/api/Status;", args:  null));
        }
    
    }

}
