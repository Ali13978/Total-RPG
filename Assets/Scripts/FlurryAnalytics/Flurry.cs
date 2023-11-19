using UnityEngine;

namespace FlurryAnalytics
{
    public sealed class Flurry : MonoSingleton<FlurryAnalytics.Flurry>, IAnalytics
    {
        // Methods
        public Flurry()
        {
        
        }
        private void Awake()
        {
            Application.LogCallback val_1 = new Application.LogCallback(object:  this, method:  System.Void FlurryAnalytics.Flurry::ErrorHandler(string condition, string stackTrace, UnityEngine.LogType type));
            UnityEngine.Application.RegisterLogCallback(handler:  0);
        }
        protected override void OnDestroy()
        {
            FlurryAnalytics.FlurryAndroid.Dispose();
            this.OnDestroy();
        }
        private void ErrorHandler(string condition, string stackTrace, UnityEngine.LogType type)
        {
            if(type != 0)
            {
                    return;
            }
            
            this.LogError(errorID:  "Uncaught Unity Exception", message:  condition, target:  this);
        }
        public void StartSession(string apiKeyIOS, string apiKeyAndroid)
        {
            FlurryAnalytics.FlurryAndroid.Init(apiKey:  null);
            FlurryAnalytics.FlurryAndroid.OnStartSession();
        }
        public void LogAppVersion(string version)
        {
            FlurryAnalytics.FlurryAndroid.SetVersionName(versionName:  null);
        }
        public void SetLogLevel(FlurryAnalytics.LogLevel level)
        {
            FlurryAnalytics.FlurryAndroid.SetLogLevel(logLevel:  null);
        }
        public FlurryAnalytics.EventRecordStatus LogEvent(string eventName)
        {
            return FlurryAnalytics.FlurryAndroid.LogEvent(eventId:  null);
        }
        public FlurryAnalytics.EventRecordStatus LogEvent(string eventName, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            return FlurryAnalytics.FlurryAndroid.LogEvent(eventId:  null, parameters:  eventName);
        }
        public FlurryAnalytics.EventRecordStatus LogEvent(string eventName, bool timed)
        {
            timed = timed;
            return FlurryAnalytics.FlurryAndroid.LogEvent(eventId:  null, timed:  eventName);
        }
        public FlurryAnalytics.EventRecordStatus BeginLogEvent(string eventName)
        {
            return FlurryAnalytics.FlurryAndroid.LogEvent(eventId:  null, timed:  eventName);
        }
        public FlurryAnalytics.EventRecordStatus BeginLogEvent(string eventName, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            return FlurryAnalytics.FlurryAndroid.LogEvent(eventId:  null, parameters:  eventName, timed:  parameters);
        }
        public void EndLogEvent(string eventName)
        {
            FlurryAnalytics.FlurryAndroid.EndTimedEvent(eventId:  null);
        }
        public void EndLogEvent(string eventName, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            FlurryAnalytics.FlurryAndroid.EndTimedEvent(eventId:  null, parameters:  eventName);
        }
        public void LogError(string errorID, string message, object target)
        {
            target.GetType() = null;
            FlurryAnalytics.FlurryAndroid.OnError(errorId:  target.GetType(), message:  errorID, errorClass:  message);
        }
        public void LogUserID(string userID)
        {
            FlurryAnalytics.FlurryAndroid.SetUserId(userId:  null);
        }
        public void LogUserAge(int age)
        {
            FlurryAnalytics.FlurryAndroid.SetAge(age:  330670080);
        }
        public void LogUserGender(FlurryAnalytics.UserGender gender)
        {
            FlurryAnalytics.UserGender val_2 = gender;
            val_2 = (val_2 == 1) ? 1 : ((val_2 != 2) ? -1 : 0);
            FlurryAnalytics.FlurryAndroid.SetGender(gender:  0);
        }
    
    }

}
