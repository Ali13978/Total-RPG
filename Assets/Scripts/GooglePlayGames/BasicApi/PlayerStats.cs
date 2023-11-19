using UnityEngine;

namespace GooglePlayGames.BasicApi
{
    public class PlayerStats
    {
        // Fields
        private static float UNSET_VALUE;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <Valid>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <NumberOfPurchases>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <AvgSessonLength>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <DaysSinceLastPlayed>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <NumberOfSessions>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <SessPercentile>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <SpendPercentile>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <SpendProbability>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <ChurnProbability>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <HighSpenderProbability>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <TotalSpendNext28Days>k__BackingField;
        
        // Properties
        public bool Valid { get; set; }
        public int NumberOfPurchases { get; set; }
        public float AvgSessonLength { get; set; }
        public int DaysSinceLastPlayed { get; set; }
        public int NumberOfSessions { get; set; }
        public float SessPercentile { get; set; }
        public float SpendPercentile { get; set; }
        public float SpendProbability { get; set; }
        public float ChurnProbability { get; set; }
        public float HighSpenderProbability { get; set; }
        public float TotalSpendNext28Days { get; set; }
        
        // Methods
        public PlayerStats()
        {
            this.<Valid>k__BackingField = false;
        }
        public bool get_Valid()
        {
            return (bool)this.<Valid>k__BackingField;
        }
        public void set_Valid(bool value)
        {
            this.<Valid>k__BackingField = value;
        }
        public int get_NumberOfPurchases()
        {
            return (int)this.<NumberOfPurchases>k__BackingField;
        }
        public void set_NumberOfPurchases(int value)
        {
            this.<NumberOfPurchases>k__BackingField = value;
        }
        public float get_AvgSessonLength()
        {
            return (float)this.<AvgSessonLength>k__BackingField;
        }
        public void set_AvgSessonLength(float value)
        {
            this.<AvgSessonLength>k__BackingField = value;
        }
        public int get_DaysSinceLastPlayed()
        {
            return (int)this.<DaysSinceLastPlayed>k__BackingField;
        }
        public void set_DaysSinceLastPlayed(int value)
        {
            this.<DaysSinceLastPlayed>k__BackingField = value;
        }
        public int get_NumberOfSessions()
        {
            return (int)this.<NumberOfSessions>k__BackingField;
        }
        public void set_NumberOfSessions(int value)
        {
            this.<NumberOfSessions>k__BackingField = value;
        }
        public float get_SessPercentile()
        {
            return (float)this.<SessPercentile>k__BackingField;
        }
        public void set_SessPercentile(float value)
        {
            this.<SessPercentile>k__BackingField = value;
        }
        public float get_SpendPercentile()
        {
            return (float)this.<SpendPercentile>k__BackingField;
        }
        public void set_SpendPercentile(float value)
        {
            this.<SpendPercentile>k__BackingField = value;
        }
        public float get_SpendProbability()
        {
            return (float)this.<SpendProbability>k__BackingField;
        }
        public void set_SpendProbability(float value)
        {
            this.<SpendProbability>k__BackingField = value;
        }
        public float get_ChurnProbability()
        {
            return (float)this.<ChurnProbability>k__BackingField;
        }
        public void set_ChurnProbability(float value)
        {
            this.<ChurnProbability>k__BackingField = value;
        }
        public float get_HighSpenderProbability()
        {
            return (float)this.<HighSpenderProbability>k__BackingField;
        }
        public void set_HighSpenderProbability(float value)
        {
            this.<HighSpenderProbability>k__BackingField = value;
        }
        public float get_TotalSpendNext28Days()
        {
            return (float)this.<TotalSpendNext28Days>k__BackingField;
        }
        public void set_TotalSpendNext28Days(float value)
        {
            this.<TotalSpendNext28Days>k__BackingField = value;
        }
        public bool HasNumberOfPurchases()
        {
            null = null;
            return (bool)((this.<NumberOfPurchases>k__BackingField) != (int)GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasAvgSessonLength()
        {
            null = null;
            return (bool)((this.<AvgSessonLength>k__BackingField) != GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasDaysSinceLastPlayed()
        {
            null = null;
            return (bool)((this.<DaysSinceLastPlayed>k__BackingField) != (int)GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasNumberOfSessions()
        {
            null = null;
            return (bool)((this.<NumberOfSessions>k__BackingField) != (int)GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasSessPercentile()
        {
            null = null;
            return (bool)((this.<SessPercentile>k__BackingField) != GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasSpendPercentile()
        {
            null = null;
            return (bool)((this.<SpendPercentile>k__BackingField) != GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasChurnProbability()
        {
            null = null;
            return (bool)((this.<ChurnProbability>k__BackingField) != GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasHighSpenderProbability()
        {
            null = null;
            return (bool)((this.<HighSpenderProbability>k__BackingField) != GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasTotalSpendNext28Days()
        {
            null = null;
            return (bool)((this.<TotalSpendNext28Days>k__BackingField) != GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        private static PlayerStats()
        {
            GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE = -1f;
        }
    
    }

}
