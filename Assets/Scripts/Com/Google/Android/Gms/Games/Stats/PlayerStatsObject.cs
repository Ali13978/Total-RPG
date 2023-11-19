using UnityEngine;

namespace Com.Google.Android.Gms.Games.Stats
{
    public class PlayerStatsObject : JavaObjWrapper, PlayerStats
    {
        // Fields
        private const string CLASS_NAME = "com/google/android/gms/games/stats/PlayerStats";
        
        // Properties
        public static float UNSET_VALUE { get; }
        public static int CONTENTS_FILE_DESCRIPTOR { get; }
        public static int PARCELABLE_WRITE_RETURN_VALUE { get; }
        
        // Methods
        public PlayerStatsObject(IntPtr ptr)
        {
        
        }
        public static float get_UNSET_VALUE()
        {
            return Google.Developers.JavaObjWrapper.GetStaticFloatField(clsName:  0, name:  "com/google/android/gms/games/stats/PlayerStats");
        }
        public static int get_CONTENTS_FILE_DESCRIPTOR()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/games/stats/PlayerStats");
        }
        public static int get_PARCELABLE_WRITE_RETURN_VALUE()
        {
            return Google.Developers.JavaObjWrapper.GetStaticIntField(clsName:  0, name:  "com/google/android/gms/games/stats/PlayerStats");
        }
        public float getAverageSessionLength()
        {
            return this.InvokeCall<System.Single>(name:  "getAverageSessionLength", sig:  "()F", args:  null);
        }
        public float getChurnProbability()
        {
            return this.InvokeCall<System.Single>(name:  "getChurnProbability", sig:  "()F", args:  null);
        }
        public int getDaysSinceLastPlayed()
        {
            return this.InvokeCall<System.Int32>(name:  "getDaysSinceLastPlayed", sig:  "()I", args:  null);
        }
        public int getNumberOfPurchases()
        {
            return this.InvokeCall<System.Int32>(name:  "getNumberOfPurchases", sig:  "()I", args:  null);
        }
        public int getNumberOfSessions()
        {
            return this.InvokeCall<System.Int32>(name:  "getNumberOfSessions", sig:  "()I", args:  null);
        }
        public float getSessionPercentile()
        {
            return this.InvokeCall<System.Single>(name:  "getSessionPercentile", sig:  "()F", args:  null);
        }
        public float getSpendPercentile()
        {
            return this.InvokeCall<System.Single>(name:  "getSpendPercentile", sig:  "()F", args:  null);
        }
        public float getSpendProbability()
        {
            return this.InvokeCall<System.Single>(name:  "getSpendProbability", sig:  "()F", args:  null);
        }
        public float getHighSpenderProbability()
        {
            return this.InvokeCall<System.Single>(name:  "getHighSpenderProbability", sig:  "()F", args:  null);
        }
        public float getTotalSpendNext28Days()
        {
            return this.InvokeCall<System.Single>(name:  "getTotalSpendNext28Days", sig:  "()F", args:  null);
        }
    
    }

}
