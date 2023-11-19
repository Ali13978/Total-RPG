using UnityEngine;

namespace TzarGames.Common.Analytics
{
    public static class AnalyticsManager
    {
        // Fields
        private static System.Collections.Generic.List<TzarGames.Common.Analytics.IAnalyticsService> _services;
        
        // Methods
        public static void AddService(TzarGames.Common.Analytics.IAnalyticsService service)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((TzarGames.Common.Analytics.AnalyticsManager._services.Contains(item:  X1)) != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            TzarGames.Common.Analytics.AnalyticsManager._services.Add(item:  X1);
        }
        public static void RemoveService(TzarGames.Common.Analytics.IAnalyticsService service)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((TzarGames.Common.Analytics.AnalyticsManager._services.Contains(item:  X1)) == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            bool val_2 = TzarGames.Common.Analytics.AnalyticsManager._services.Remove(item:  X1);
        }
        public static void SendEvent(TzarGames.Common.CustomAnalyticsEvent customEvent, System.Collections.Generic.Dictionary<string, string> paramaters)
        {
            var val_4;
            System.Collections.Generic.List<TzarGames.Common.Analytics.IAnalyticsService> val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_12;
            val_8 = X2;
            if(TzarGames.Common.Privacy.CanCollectData == false)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            val_7 = TzarGames.Common.Analytics.AnalyticsManager._services;
            List.Enumerator<T> val_2 = val_7.GetEnumerator();
            label_18:
            if((0 & 1) == 0)
            {
                goto label_7;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_10 = val_4.InitializationCallback;
            goto label_18;
            label_7:
            val_8 = 0;
            val_12 = 1;
            val_4.Dispose();
            if((val_12 & 1) != 0)
            {
                    return;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
        
        }
        private static AnalyticsManager()
        {
            TzarGames.Common.Analytics.AnalyticsManager._services = new System.Collections.Generic.List<TzarGames.Common.Analytics.IAnalyticsService>();
        }
    
    }

}
