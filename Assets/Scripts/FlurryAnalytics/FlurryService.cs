using UnityEngine;

namespace FlurryAnalytics
{
    public class FlurryService : MonoBehaviour, IAnalyticsService
    {
        // Fields
        [UnityEngine.SerializeField]
        private string androidApiKey;
        [UnityEngine.SerializeField]
        private string iosApiKey;
        private bool activated;
        
        // Methods
        public FlurryService()
        {
        
        }
        private void OnEnable()
        {
            if(TzarGames.Common.Privacy.CanCollectData != false)
            {
                    this.activateService();
                return;
            }
            
            this.subscribeToPrivacy();
        }
        private void subscribeToPrivacy()
        {
            System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  this, method:  System.Void FlurryAnalytics.FlurryService::Privacy_OnDataCollectionPermissionChanged(bool allowed));
            TzarGames.Common.Privacy.add_OnDataCollectionPermissionChanged(value:  0);
        }
        private void Privacy_OnDataCollectionPermissionChanged(bool allowed)
        {
            if(allowed == false)
            {
                    return;
            }
            
            if(this.activated != false)
            {
                    return;
            }
            
            this.activateService();
        }
        private void activateService()
        {
            FlurryAnalytics.FlurryAndroid.SetLogEnabled(isEnabled:  false);
            FlurryAnalytics.MonoSingleton<FlurryAnalytics.Flurry>.Instance.StartSession(apiKeyIOS:  public static FlurryAnalytics.Flurry FlurryAnalytics.MonoSingleton<FlurryAnalytics.Flurry>::get_Instance(), apiKeyAndroid:  this.androidApiKey);
            FlurryAnalytics.Flurry val_2 = FlurryAnalytics.MonoSingleton<FlurryAnalytics.Flurry>.Instance;
            string val_3 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
            val_3.LogUserID(userID:  val_3);
            TzarGames.Common.Analytics.AnalyticsManager.AddService(service:  0);
            this.activated = true;
            this.subscribeToPrivacy();
        }
        private void deactivateService()
        {
            this.activated = false;
            TzarGames.Common.Analytics.AnalyticsManager.RemoveService(service:  0);
            System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  this, method:  System.Void FlurryAnalytics.FlurryService::Privacy_OnDataCollectionPermissionChanged(bool allowed));
            TzarGames.Common.Privacy.remove_OnDataCollectionPermissionChanged(value:  0);
        }
        private void OnDisable()
        {
            this.deactivateService();
        }
        public void SendEvent(TzarGames.Common.CustomAnalyticsEvent customEvent, System.Collections.Generic.Dictionary<string, string> paramaters)
        {
            FlurryAnalytics.Flurry val_1 = FlurryAnalytics.MonoSingleton<FlurryAnalytics.Flurry>.Instance;
            string val_2 = customEvent.Name;
            FlurryAnalytics.EventRecordStatus val_3 = val_2.LogEvent(eventName:  val_2, parameters:  paramaters);
        }
        public void SetEnabled(bool enabled)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
    
    }

}
