using UnityEngine;

namespace Com.Google.Android.Gms.Games.Stats
{
    public interface PlayerStats
    {
        // Methods
        public abstract float getAverageSessionLength(); // 0
        public abstract float getChurnProbability(); // 0
        public abstract int getDaysSinceLastPlayed(); // 0
        public abstract int getNumberOfPurchases(); // 0
        public abstract int getNumberOfSessions(); // 0
        public abstract float getSessionPercentile(); // 0
        public abstract float getSpendPercentile(); // 0
        public abstract float getSpendProbability(); // 0
        public abstract float getHighSpenderProbability(); // 0
        public abstract float getTotalSpendNext28Days(); // 0
    
    }

}
