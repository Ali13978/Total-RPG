using UnityEngine;

namespace TzarGames.Common.Analytics
{
    public interface IAnalyticsService
    {
        // Methods
        public abstract void SendEvent(TzarGames.Common.CustomAnalyticsEvent customEvent, System.Collections.Generic.Dictionary<string, string> paramaters); // 0
        public abstract void SetEnabled(bool enabled); // 0
    
    }

}
