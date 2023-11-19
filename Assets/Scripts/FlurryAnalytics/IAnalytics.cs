using UnityEngine;

namespace FlurryAnalytics
{
    public interface IAnalytics
    {
        // Methods
        public abstract void StartSession(string apiKeyIOS, string apiKeyAndroid); // 0
        public abstract void LogAppVersion(string version); // 0
        public abstract void SetLogLevel(FlurryAnalytics.LogLevel level); // 0
        public abstract FlurryAnalytics.EventRecordStatus LogEvent(string eventName); // 0
        public abstract FlurryAnalytics.EventRecordStatus LogEvent(string eventName, System.Collections.Generic.Dictionary<string, string> parameters); // 0
        public abstract FlurryAnalytics.EventRecordStatus BeginLogEvent(string eventName); // 0
        public abstract FlurryAnalytics.EventRecordStatus BeginLogEvent(string eventName, System.Collections.Generic.Dictionary<string, string> parameters); // 0
        public abstract void EndLogEvent(string eventName); // 0
        public abstract void EndLogEvent(string eventName, System.Collections.Generic.Dictionary<string, string> parameters); // 0
        public abstract void LogError(string errorID, string message, object target); // 0
        public abstract void LogUserID(string userID); // 0
        public abstract void LogUserAge(int age); // 0
        public abstract void LogUserGender(FlurryAnalytics.UserGender gender); // 0
    
    }

}
