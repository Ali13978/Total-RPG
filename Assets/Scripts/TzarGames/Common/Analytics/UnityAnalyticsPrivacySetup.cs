using UnityEngine;

namespace TzarGames.Common.Analytics
{
    public static class UnityAnalyticsPrivacySetup
    {
        // Methods
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void init()
        {
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Analytics.Analytics.enabled = false;
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Analytics.Analytics.deviceStatsEnabled = false;
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Analytics.Analytics.limitUserTracking = false;
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Analytics.PerformanceReporting.enabled = false;
        }
    
    }

}
