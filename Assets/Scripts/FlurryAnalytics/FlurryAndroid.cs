using UnityEngine;

namespace FlurryAnalytics
{
    public static class FlurryAndroid
    {
        // Fields
        private static readonly string s_FlurryAgentClassName;
        private static readonly string s_UnityPlayerClassName;
        private static readonly string s_UnityPlayerActivityName;
        private static UnityEngine.AndroidJavaClass s_FlurryAgent;
        
        // Properties
        private static UnityEngine.AndroidJavaClass FlurryAgent { get; }
        
        // Methods
        private static UnityEngine.AndroidJavaClass get_FlurryAgent()
        {
            UnityEngine.AndroidJavaClass val_4;
            var val_5;
            val_4 = 0;
            if(UnityEngine.Application.platform != 11)
            {
                    return val_4;
            }
            
            val_5 = null;
            val_5 = null;
            if(FlurryAnalytics.FlurryAndroid.s_FlurryAgent == null)
            {
                    FlurryAnalytics.FlurryAndroid.s_FlurryAgent = new UnityEngine.AndroidJavaClass(className:  FlurryAnalytics.FlurryAndroid.__il2cppRuntimeField_static_fields);
                val_5 = null;
            }
            
            val_5 = null;
            val_4 = FlurryAnalytics.FlurryAndroid.s_FlurryAgent;
            return val_4;
        }
        public static void Dispose()
        {
            var val_1;
            UnityEngine.AndroidJavaClass val_2;
            val_1 = null;
            val_1 = null;
            val_2 = FlurryAnalytics.FlurryAndroid.s_FlurryAgent;
            if(val_2 != null)
            {
                    val_2 = FlurryAnalytics.FlurryAndroid.s_FlurryAgent;
                if(val_2 == null)
            {
                    val_2 = 0;
            }
            
                val_2.Dispose();
                val_1 = null;
            }
            
            val_1 = null;
            FlurryAnalytics.FlurryAndroid.s_FlurryAgent = 0;
        }
        public static void Init(string apiKey)
        {
            var val_13;
            var val_14;
            var val_15;
            System.Object[] val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_13 = null;
            val_13 = null;
            UnityEngine.AndroidJavaClass val_1 = null;
            val_14 = val_1;
            val_1 = new UnityEngine.AndroidJavaClass(className:  FlurryAnalytics.FlurryAndroid.s_UnityPlayerClassName);
            val_15 = null;
            val_15 = null;
            UnityEngine.AndroidJavaObject val_2 = GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  FlurryAnalytics.FlurryAndroid.s_UnityPlayerActivityName);
            val_16 = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_2;
            typeof(System.Object[]).__il2cppRuntimeField_28 = X1;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "init", args:  val_16);
            val_17 = 0;
            if(val_2 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_18 = val_2;
            }
            
            val_19 = 88;
            if((70 != 70) && (val_17 != 0))
            {
                    val_17 = 0;
                val_19 = 88;
            }
            
            if(null == 0)
            {
                goto label_23;
            }
            
            UnityEngine.AndroidJavaClass val_16 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_24;
            }
            
            var val_14 = mem[null + 152];
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_26:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_25;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (mem[null + 258]))
            {
                goto label_26;
            }
            
            label_24:
            val_20 = val_14;
            goto label_27;
            label_25:
            val_16 = val_16 + (((mem[null + 152] + 8)) << 4);
            label_27:
            label_23:
            if(88 == 88)
            {
                    return;
            }
            
            if(val_17 == 0)
            {
                    return;
            }
            
            val_14 = ???;
            val_17 = ???;
            val_16 = ???;
        }
        public static void OnStartSession()
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_11 = null;
            val_11 = null;
            UnityEngine.AndroidJavaClass val_1 = null;
            val_12 = val_1;
            val_1 = new UnityEngine.AndroidJavaClass(className:  FlurryAnalytics.FlurryAndroid.s_UnityPlayerClassName);
            val_13 = null;
            val_13 = null;
            UnityEngine.AndroidJavaObject val_2 = GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  FlurryAnalytics.FlurryAndroid.s_UnityPlayerActivityName);
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_2;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "onStartSession", args:  null);
            val_14 = 0;
            if(val_2 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_15 = val_2;
            }
            
            val_16 = 84;
            if((66 != 66) && (val_14 != 0))
            {
                    val_14 = 0;
                val_16 = 84;
            }
            
            if(null == 0)
            {
                goto label_20;
            }
            
            UnityEngine.AndroidJavaClass val_14 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_21;
            }
            
            var val_12 = mem[null + 152];
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_23:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_22;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (mem[null + 258]))
            {
                goto label_23;
            }
            
            label_21:
            val_17 = val_12;
            goto label_24;
            label_22:
            val_14 = val_14 + (((mem[null + 152] + 8)) << 4);
            label_24:
            label_20:
            if(84 == 84)
            {
                    return;
            }
            
            if(val_14 == 0)
            {
                    return;
            }
            
            val_12 = ???;
            val_14 = ???;
        }
        public static void OnEndSession()
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_11 = null;
            val_11 = null;
            UnityEngine.AndroidJavaClass val_1 = null;
            val_12 = val_1;
            val_1 = new UnityEngine.AndroidJavaClass(className:  FlurryAnalytics.FlurryAndroid.s_UnityPlayerClassName);
            val_13 = null;
            val_13 = null;
            UnityEngine.AndroidJavaObject val_2 = GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  FlurryAnalytics.FlurryAndroid.s_UnityPlayerActivityName);
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_2;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "onEndSession", args:  null);
            val_14 = 0;
            if(val_2 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_15 = val_2;
            }
            
            val_16 = 84;
            if((66 != 66) && (val_14 != 0))
            {
                    val_14 = 0;
                val_16 = 84;
            }
            
            if(null == 0)
            {
                goto label_20;
            }
            
            UnityEngine.AndroidJavaClass val_14 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_21;
            }
            
            var val_12 = mem[null + 152];
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_23:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_22;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (mem[null + 258]))
            {
                goto label_23;
            }
            
            label_21:
            val_17 = val_12;
            goto label_24;
            label_22:
            val_14 = val_14 + (((mem[null + 152] + 8)) << 4);
            label_24:
            label_20:
            if(84 == 84)
            {
                    return;
            }
            
            if(val_14 == 0)
            {
                    return;
            }
            
            val_12 = ???;
            val_14 = ???;
        }
        public static bool IsSessionActive()
        {
            UnityEngine.AndroidJavaClass val_1 = FlurryAnalytics.FlurryAndroid.FlurryAgent;
            if(val_1 != null)
            {
                    return val_1.CallStatic<System.Boolean>(methodName:  "isSessionActive", args:  null);
            }
            
            return val_1.CallStatic<System.Boolean>(methodName:  "isSessionActive", args:  null);
        }
        public static string GetSessionId()
        {
            UnityEngine.AndroidJavaClass val_1 = FlurryAnalytics.FlurryAndroid.FlurryAgent;
            if(val_1 != null)
            {
                    return val_1.CallStatic<System.String>(methodName:  "getSessionId", args:  null);
            }
            
            return val_1.CallStatic<System.String>(methodName:  "getSessionId", args:  null);
        }
        public static int GetAgentVersion()
        {
            UnityEngine.AndroidJavaClass val_1 = FlurryAnalytics.FlurryAndroid.FlurryAgent;
            if(val_1 != null)
            {
                    return val_1.CallStatic<System.Int32>(methodName:  "getAgentVersion", args:  null);
            }
            
            return val_1.CallStatic<System.Int32>(methodName:  "getAgentVersion", args:  null);
        }
        public static string GetReleaseVersion()
        {
            UnityEngine.AndroidJavaClass val_1 = FlurryAnalytics.FlurryAndroid.FlurryAgent;
            if(val_1 != null)
            {
                    return val_1.CallStatic<System.String>(methodName:  "getReleaseVersion", args:  null);
            }
            
            return val_1.CallStatic<System.String>(methodName:  "getReleaseVersion", args:  null);
        }
        public static void SetLogEnabled(bool isEnabled)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = W1 & 1;
            typeof(System.Object[]).__il2cppRuntimeField_21 = 28283996;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "setLogEnabled", args:  null);
        }
        public static void SetLogLevel(FlurryAnalytics.LogLevel logLevel)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = W1;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "setLogLevel", args:  null);
        }
        public static void SetVersionName(string versionName)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = X1;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "setVersionName", args:  null);
        }
        public static void SetReportLocation(bool reportLocation)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = W1 & 1;
            typeof(System.Object[]).__il2cppRuntimeField_21 = 28285534;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "setReportLocation", args:  null);
        }
        public static void SetLocation(float lat, float lon)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = lat;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_28 = lon;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "setLocation", args:  null);
        }
        public static void ClearLocation()
        {
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "clearLocation", args:  null);
        }
        public static void SetContinueSessionMillis(long millis)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = X1;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "setContinueSessionMillis", args:  null);
        }
        public static void SetLogEvents(bool logEvents)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = W1 & 1;
            typeof(System.Object[]).__il2cppRuntimeField_21 = 28287541;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "setLogEvents", args:  null);
        }
        public static void SetCaptureUncaughtExceptions(bool isEnabled)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = W1 & 1;
            typeof(System.Object[]).__il2cppRuntimeField_21 = 28288043;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "setCaptureUncaughtExceptions", args:  null);
        }
        public static void AddOrigin(string originName, string originVersion)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = originVersion;
            typeof(System.Object[]).__il2cppRuntimeField_28 = X2;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "addOrigin", args:  null);
        }
        public static void AddOrigin(string originName, string originVersion, System.Collections.Generic.Dictionary<string, string> originParameters)
        {
            string val_12;
            UnityEngine.AndroidJavaObject val_13;
            var val_14;
            var val_15;
            val_12 = originVersion;
            val_13 = FlurryAnalytics.FlurryAndroid.DictionaryToJavaHashMap(dictionary:  null);
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_12;
            typeof(System.Object[]).__il2cppRuntimeField_28 = originParameters;
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_13;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "addOrigin", args:  null);
            val_14 = 58;
            if(val_13 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_15 = val_13;
            }
            
            if(58 == 58)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_13 = ???;
            val_14 = ???;
            val_12 = ???;
        }
        public static void SetPulseEnabled(bool isEnabled)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = W1 & 1;
            typeof(System.Object[]).__il2cppRuntimeField_21 = 28289677;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "setPulseEnabled", args:  null);
        }
        public static FlurryAnalytics.EventRecordStatus LogEvent(string eventId)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = X1;
            return FlurryAnalytics.FlurryAndroid.JavaObjectToEventRecordStatus(javaObject:  FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logEvent", args:  null));
        }
        public static FlurryAnalytics.EventRecordStatus LogEvent(string eventId, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            var val_6;
            UnityEngine.AndroidJavaObject val_1 = FlurryAnalytics.FlurryAndroid.DictionaryToJavaHashMap(dictionary:  null);
            typeof(System.Object[]).__il2cppRuntimeField_20 = parameters;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_1;
            typeof(System.Object[]).__il2cppRuntimeField_30 = null;
            if(val_1 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                val_6 = val_1;
            }
            
            if(69 == 69)
            {
                    return (FlurryAnalytics.EventRecordStatus)FlurryAnalytics.FlurryAndroid.JavaObjectToEventRecordStatus(javaObject:  FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logEvent", args:  null));
            }
            
            if(0 == 0)
            {
                    return (FlurryAnalytics.EventRecordStatus)FlurryAnalytics.FlurryAndroid.JavaObjectToEventRecordStatus(javaObject:  FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logEvent", args:  null));
            }
            
            return (FlurryAnalytics.EventRecordStatus)FlurryAnalytics.FlurryAndroid.JavaObjectToEventRecordStatus(javaObject:  FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logEvent", args:  null));
        }
        public static FlurryAnalytics.EventRecordStatus LogEvent(string eventId, bool timed)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = timed;
            typeof(System.Object[]).__il2cppRuntimeField_28 = W2 & 1;
            typeof(System.Object[]).__il2cppRuntimeField_29 = 28291405;
            return (FlurryAnalytics.EventRecordStatus)FlurryAnalytics.FlurryAndroid.JavaObjectToEventRecordStatus(javaObject:  FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logEvent", args:  null));
        }
        public static FlurryAnalytics.EventRecordStatus LogEvent(string eventId, System.Collections.Generic.Dictionary<string, string> parameters, bool timed)
        {
            var val_7;
            UnityEngine.AndroidJavaObject val_1 = FlurryAnalytics.FlurryAndroid.DictionaryToJavaHashMap(dictionary:  null);
            typeof(System.Object[]).__il2cppRuntimeField_20 = parameters;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_1;
            typeof(System.Object[]).__il2cppRuntimeField_30 = W3 & 1;
            typeof(System.Object[]).__il2cppRuntimeField_31 = 28292067;
            if(val_1 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_7 = val_1;
            }
            
            if(69 == 69)
            {
                    return (FlurryAnalytics.EventRecordStatus)FlurryAnalytics.FlurryAndroid.JavaObjectToEventRecordStatus(javaObject:  FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logEvent", args:  null));
            }
            
            if(0 == 0)
            {
                    return (FlurryAnalytics.EventRecordStatus)FlurryAnalytics.FlurryAndroid.JavaObjectToEventRecordStatus(javaObject:  FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logEvent", args:  null));
            }
            
            return (FlurryAnalytics.EventRecordStatus)FlurryAnalytics.FlurryAndroid.JavaObjectToEventRecordStatus(javaObject:  FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logEvent", args:  null));
        }
        public static void EndTimedEvent(string eventId)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = X1;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "endTimedEvent", args:  null);
        }
        public static void EndTimedEvent(string eventId, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            UnityEngine.AndroidJavaObject val_10;
            var val_11;
            var val_12;
            val_10 = FlurryAnalytics.FlurryAndroid.DictionaryToJavaHashMap(dictionary:  null);
            typeof(System.Object[]).__il2cppRuntimeField_20 = parameters;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_10;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "endTimedEvent", args:  null);
            val_11 = 54;
            if(val_10 != null)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_12 = val_10;
            }
            
            if(54 == 54)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_10 = ???;
            val_11 = ???;
        }
        public static void OnError(string errorId, string message, string errorClass)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = message;
            typeof(System.Object[]).__il2cppRuntimeField_28 = errorClass;
            typeof(System.Object[]).__il2cppRuntimeField_30 = X3;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "onError", args:  null);
        }
        public static void OnPageView()
        {
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "onPageView", args:  null);
        }
        public static void SetAge(int age)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = W1;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "setAge", args:  null);
        }
        public static void SetGender(byte gender)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = W1;
            typeof(System.Object[]).__il2cppRuntimeField_21 = 28295205;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "setGender", args:  null);
        }
        public static void SetUserId(string userId)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = X1;
            FlurryAnalytics.FlurryAndroid.FlurryAgent.CallStatic(methodName:  "setUserId", args:  null);
        }
        private static UnityEngine.AndroidJavaObject DictionaryToJavaHashMap(System.Collections.Generic.Dictionary<string, string> dictionary)
        {
            var val_5;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            UnityEngine.AndroidJavaObject val_1 = new UnityEngine.AndroidJavaObject(className:  "java.util.HashMap", args:  null);
            Dictionary.Enumerator<TKey, TValue> val_4 = X1.GetEnumerator();
            val_14 = "java.lang.String";
            val_15 = 0;
            goto label_35;
            label_40:
            UnityEngine.Playables.PlayableHandle val_7 = val_5.GetHandle();
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_7.m_Handle.InitializationCallback;
            UnityEngine.AndroidJavaObject val_9 = new UnityEngine.AndroidJavaObject(className:  "java.lang.String", args:  null);
            typeof(System.Object[]).__il2cppRuntimeField_20 = ;
            UnityEngine.AndroidJavaObject val_10 = new UnityEngine.AndroidJavaObject(className:  "java.lang.String", args:  null);
            typeof(System.Object[]).__il2cppRuntimeField_20 = null;
            typeof(System.Object[]).__il2cppRuntimeField_28 = null;
            UnityEngine.jvalue[] val_12 = UnityEngine.AndroidJNIHelper.CreateJNIArgArray(args:  0);
            IntPtr val_13 = UnityEngine.AndroidJNI.CallObjectMethod(obj:  0, methodID:  GetRawObject(), args:  UnityEngine.AndroidJNIHelper.GetMethodID(javaClass:  0, methodName:  GetRawClass(), signature:  "put"));
            val_14 = val_14;
            if(null == 0)
            {
                goto label_20;
            }
            
            UnityEngine.AndroidJavaObject val_16 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_21;
            }
            
            var val_14 = mem[null + 152];
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_23:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_22;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (mem[null + 258]))
            {
                goto label_23;
            }
            
            label_21:
            val_16 = null;
            goto label_24;
            label_22:
            val_16 = val_16 + (((mem[null + 152] + 8)) << 4);
            label_24:
            label_20:
            val_17 = 189;
            if((169 != 169) && (val_15 != 0))
            {
                    val_18 = 0;
                val_17 = 189;
            }
            else
            {
                    val_18 = val_15;
            }
            
            if(null == 0)
            {
                goto label_28;
            }
            
            UnityEngine.AndroidJavaObject val_19 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_29;
            }
            
            var val_17 = mem[null + 152];
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_31:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_30;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < (mem[null + 258]))
            {
                goto label_31;
            }
            
            label_29:
            val_19 = null;
            goto label_32;
            label_30:
            val_19 = val_19 + (((mem[null + 152] + 8)) << 4);
            label_32:
            label_28:
            val_15 = val_18;
            if(189 != 189)
            {
                    val_15 = 0;
                if(val_18 != 0)
            {
                    val_15 = 0;
            }
            
            }
            
            label_35:
            if((0 & 1) != 0)
            {
                goto label_40;
            }
            
            val_5.Dispose();
            if(189 == 220)
            {
                    return (UnityEngine.AndroidJavaObject)null;
            }
            
            if( == 0)
            {
                    return (UnityEngine.AndroidJavaObject)null;
            }
            
            return (UnityEngine.AndroidJavaObject)null;
        }
        private static FlurryAnalytics.EventRecordStatus JavaObjectToEventRecordStatus(UnityEngine.AndroidJavaObject javaObject)
        {
            if(X1 != 0)
            {
                    return X1.Call<System.Int32>(methodName:  "ordinal", args:  null);
            }
            
            return X1.Call<System.Int32>(methodName:  "ordinal", args:  null);
        }
        private static FlurryAndroid()
        {
            FlurryAnalytics.FlurryAndroid.s_FlurryAgentClassName = "com.flurry.android.FlurryAgent";
            FlurryAnalytics.FlurryAndroid.s_UnityPlayerClassName = "com.unity3d.player.UnityPlayer";
            FlurryAnalytics.FlurryAndroid.s_UnityPlayerActivityName = "currentActivity";
        }
    
    }

}
