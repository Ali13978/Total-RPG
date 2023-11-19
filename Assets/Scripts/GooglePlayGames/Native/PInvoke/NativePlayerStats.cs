using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativePlayerStats : BaseReferenceHolder
    {
        // Methods
        internal NativePlayerStats(IntPtr selfPointer)
        {
        
        }
        internal bool Valid()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_Valid(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool HasAverageSessionLength()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_HasAverageSessionLength(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal float AverageSessionLength()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_AverageSessionLength(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool HasChurnProbability()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_HasChurnProbability(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal float ChurnProbability()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_ChurnProbability(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool HasDaysSinceLastPlayed()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_HasDaysSinceLastPlayed(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal int DaysSinceLastPlayed()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_DaysSinceLastPlayed(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool HasNumberOfPurchases()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_HasNumberOfPurchases(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal int NumberOfPurchases()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_NumberOfPurchases(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool HasNumberOfSessions()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_HasNumberOfSessions(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal int NumberOfSessions()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_NumberOfSessions(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool HasSessionPercentile()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_HasSessionPercentile(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal float SessionPercentile()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_SessionPercentile(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool HasSpendPercentile()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_HasSpendPercentile(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal float SpendPercentile()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_SpendPercentile(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.BasicApi.PlayerStats AsPlayerStats()
        {
            bool val_20;
            System.Runtime.InteropServices.HandleRef val_2 = this.SelfPtr();
            object val_20 = val_2.wrapper;
            val_20 = GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_Valid(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_20});
            val_20 = val_20;
            Valid = val_20;
            System.Runtime.InteropServices.HandleRef val_4 = this.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_Valid(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_4.wrapper})) == false)
            {
                    return (GooglePlayGames.BasicApi.PlayerStats)new GooglePlayGames.BasicApi.PlayerStats();
            }
            
            System.Runtime.InteropServices.HandleRef val_6 = this.SelfPtr();
            AvgSessonLength = GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_AverageSessionLength(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_6.wrapper});
            System.Runtime.InteropServices.HandleRef val_8 = this.SelfPtr();
            ChurnProbability = GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_ChurnProbability(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_8.wrapper});
            System.Runtime.InteropServices.HandleRef val_10 = this.SelfPtr();
            DaysSinceLastPlayed = GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_DaysSinceLastPlayed(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_10.wrapper});
            System.Runtime.InteropServices.HandleRef val_12 = this.SelfPtr();
            NumberOfPurchases = GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_NumberOfPurchases(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_12.wrapper});
            System.Runtime.InteropServices.HandleRef val_14 = this.SelfPtr();
            val_20 = GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_NumberOfSessions(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_14.wrapper});
            NumberOfSessions = val_20;
            System.Runtime.InteropServices.HandleRef val_16 = this.SelfPtr();
            SessPercentile = GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_SessionPercentile(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_16.wrapper});
            System.Runtime.InteropServices.HandleRef val_18 = this.SelfPtr();
            float val_19 = GooglePlayGames.Native.Cwrapper.PlayerStats.PlayerStats_SpendPercentile(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_18.wrapper});
            if(null != 0)
            {
                    SpendPercentile = val_19;
            }
            else
            {
                    SpendPercentile = val_19;
            }
            
            SpendProbability = -1f;
            return (GooglePlayGames.BasicApi.PlayerStats)new GooglePlayGames.BasicApi.PlayerStats();
        }
    
    }

}
