using UnityEngine;

namespace TzarGames.GoogleFirebase
{
    public class GoogleAnalyticsService : MonoBehaviour, IAnalyticsService
    {
        // Methods
        public GoogleAnalyticsService()
        {
        
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(GoogleAnalyticsService.<Start>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void Privacy_OnDataCollectionPermissionChanged(bool obj)
        {
            bool val_1 = obj;
            string val_2 = 0 + "Changing data collection settings for Firebase Analytics to ";
            UnityEngine.Debug.Log(message:  0);
            bool val_4 = TzarGames.Common.Privacy.CanCollectData;
            Firebase.Analytics.FirebaseAnalytics.SetAnalyticsCollectionEnabled(enabled:  false);
        }
        private void OnDestroy()
        {
            TzarGames.Common.Analytics.AnalyticsManager.RemoveService(service:  0);
        }
        public void SendEvent(TzarGames.Common.CustomAnalyticsEvent customEvent, System.Collections.Generic.Dictionary<string, string> paramaters)
        {
            var val_7;
            int val_1 = paramaters.Count;
            Dictionary.Enumerator<TKey, TValue> val_2 = paramaters.GetEnumerator();
            val_7 = 0;
            goto label_3;
            label_9:
            val_7 = 1;
            typeof(Firebase.Analytics.Parameter[]).__il2cppRuntimeField_20 = paramaters;
            label_3:
            if((0 & 1) == 0)
            {
                goto label_15;
            }
            
            UnityEngine.Playables.PlayableHandle val_3 = 0.GetHandle();
            Firebase.Analytics.Parameter val_5 = new Firebase.Analytics.Parameter(parameterName:  val_3.m_Handle.InitializationCallback, parameterValue:  val_3.m_Handle);
            if((null == 0) || (null != 0))
            {
                goto label_9;
            }
            
            goto label_9;
            label_15:
            0.Dispose();
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  0, parameters:  customEvent.Name);
        }
        public void SetEnabled(bool enabled)
        {
            enabled = enabled;
            Firebase.Analytics.FirebaseAnalytics.SetAnalyticsCollectionEnabled(enabled:  false);
        }
    
    }

}
