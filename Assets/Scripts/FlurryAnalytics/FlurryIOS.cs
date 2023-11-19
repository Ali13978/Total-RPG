using UnityEngine;

namespace FlurryAnalytics
{
    public static class FlurryIOS
    {
        // Methods
        public static void StartSession(string apiKey)
        {
        
        }
        public static bool ActiveSessionExists()
        {
            return false;
        }
        public static void PauseBackgroundSession()
        {
        
        }
        public static void AddOrigin(string originName, string originVersion)
        {
        
        }
        public static void AddOrigin(string originName, string originVersion, System.Collections.Generic.Dictionary<string, string> parameters)
        {
        
        }
        public static void SetAppVersion(string version)
        {
        
        }
        public static string GetFlurryAgentVersion()
        {
            null = null;
            return (string)System.String.Empty;
        }
        public static void SetShowErrorInLogEnabled(bool value)
        {
        
        }
        public static void SetDebugLogEnabled(bool value)
        {
        
        }
        public static void SetLogLevel(FlurryAnalytics.LogLevel level)
        {
        
        }
        public static void SetSessionContinueSeconds(int seconds)
        {
        
        }
        public static void SetCrashReportingEnabled(bool value)
        {
        
        }
        public static FlurryAnalytics.EventRecordStatus LogEvent(string eventName)
        {
            return 0;
        }
        public static FlurryAnalytics.EventRecordStatus LogEvent(string eventName, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            return 0;
        }
        public static void LogError(string errorID, string message, System.Exception exception)
        {
        
        }
        public static FlurryAnalytics.EventRecordStatus LogEvent(string eventName, bool timed)
        {
            return 0;
        }
        public static FlurryAnalytics.EventRecordStatus LogEvent(string eventName, System.Collections.Generic.Dictionary<string, string> parameters, bool timed)
        {
            return 0;
        }
        public static void EndTimedEvent(string eventName, System.Collections.Generic.Dictionary<string, string> parameters)
        {
        
        }
        public static void LogAllPageViewsForTarget(IntPtr target)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public static void StopLogPageViewsForTarget(IntPtr target)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public static void LogPageView()
        {
        
        }
        public static void SetUserId(string userID)
        {
        
        }
        public static void SetAge(int age)
        {
        
        }
        public static void SetGender(string gender)
        {
        
        }
        public static void SetLatitude(double latitude, double longitude, float horizontalAccuracy, float verticalAccuracy)
        {
        
        }
        public static void SetSessionReportsOnCloseEnabled(bool sendSessionReportsOnClose)
        {
        
        }
        public static void SetSessionReportsOnPauseEnabled(bool setSessionReportsOnPauseEnabled)
        {
        
        }
        public static void SetBackgroundSessionEnabled(bool setBackgroundSessionEnabled)
        {
        
        }
        public static void SetEventLoggingEnabled(bool value)
        {
        
        }
        private static void ToKeyValue(System.Collections.Generic.Dictionary<string, string> dictionary, out string keys, out string values)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_12 = 1152921511854558992;
            if(keys != null)
            {
                    val_13 = keys.Count;
            }
            else
            {
                    val_13 = 0.Count;
                val_12 = 0;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_5 = val_12.GetEnumerator();
            val_14 = 1;
            goto label_3;
            label_10:
            val_14 = 2;
            label_3:
            if((0 & 1) == 0)
            {
                goto label_15;
            }
            
            UnityEngine.Playables.PlayableHandle val_6 = 0.GetHandle();
            System.Text.StringBuilder val_8 = Append(value:  val_6.m_Handle.InitializationCallback);
            System.Text.StringBuilder val_9 = Append(value:  val_6.m_Handle);
            if(val_14 >= val_13)
            {
                goto label_10;
            }
            
            System.Text.StringBuilder val_10 = Append(value:  "\n");
            System.Text.StringBuilder val_11 = Append(value:  "\n");
            goto label_10;
            label_15:
            val_15 = public System.Void Dictionary.Enumerator<System.String, System.String>::Dispose();
            0.Dispose();
            if(((0 & 1) == 0) && (null != null))
            {
                    val_15 = 0;
            }
            
            values = new System.Text.StringBuilder();
            mem2[0] = new System.Text.StringBuilder();
        }
    
    }

}
