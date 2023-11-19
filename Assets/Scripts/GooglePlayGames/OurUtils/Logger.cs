using UnityEngine;

namespace GooglePlayGames.OurUtils
{
    public class Logger
    {
        // Fields
        private static bool debugLogEnabled;
        private static bool warningLogEnabled;
        
        // Properties
        public static bool DebugLogEnabled { get; set; }
        public static bool WarningLogEnabled { get; set; }
        
        // Methods
        public Logger()
        {
        
        }
        public static bool get_DebugLogEnabled()
        {
            null = null;
            return (bool)GooglePlayGames.OurUtils.Logger.debugLogEnabled;
        }
        public static void set_DebugLogEnabled(bool value)
        {
            null = null;
            GooglePlayGames.OurUtils.Logger.debugLogEnabled = W1 & 1;
        }
        public static bool get_WarningLogEnabled()
        {
            null = null;
            return (bool)GooglePlayGames.OurUtils.Logger.warningLogEnabled;
        }
        public static void set_WarningLogEnabled(bool value)
        {
            null = null;
            GooglePlayGames.OurUtils.Logger.warningLogEnabled = W1 & 1;
        }
        public static void d(string msg)
        {
            var val_3;
            typeof(Logger.<d>c__AnonStorey0).__il2cppRuntimeField_10 = X1;
            val_3 = null;
            val_3 = null;
            if(GooglePlayGames.OurUtils.Logger.debugLogEnabled == false)
            {
                    return;
            }
            
            System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void Logger.<d>c__AnonStorey0::<>m__0());
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  null);
        }
        public static void w(string msg)
        {
            var val_3;
            typeof(Logger.<w>c__AnonStorey1).__il2cppRuntimeField_10 = X1;
            val_3 = null;
            val_3 = null;
            if(GooglePlayGames.OurUtils.Logger.warningLogEnabled == false)
            {
                    return;
            }
            
            System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void Logger.<w>c__AnonStorey1::<>m__0());
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  null);
        }
        public static void e(string msg)
        {
            var val_3;
            typeof(Logger.<e>c__AnonStorey2).__il2cppRuntimeField_10 = X1;
            val_3 = null;
            val_3 = null;
            if(GooglePlayGames.OurUtils.Logger.warningLogEnabled == false)
            {
                    return;
            }
            
            System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void Logger.<e>c__AnonStorey2::<>m__0());
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  null);
        }
        public static string describe(byte[] b)
        {
            object val_2;
            var val_3;
            val_2 = X1;
            if(val_2 != 0)
            {
                    val_2 = X1 + 24;
                string val_1 = 0 + "byte[" + X1 + 24(X1 + 24);
                return (string)val_3;
            }
            
            val_3 = "(null)";
            return (string)val_3;
        }
        private static string ToLogMessage(string prefix, string logType, string msg)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = logType;
            System.DateTime val_1 = System.DateTime.Now;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_1.ticks._ticks.ToString(format:  "MM/dd/yy H:mm:ss zzz");
            typeof(System.Object[]).__il2cppRuntimeField_30 = msg;
            typeof(System.Object[]).__il2cppRuntimeField_38 = X3;
            return (string)System.String.Format(format:  0, args:  "{0} [Play Games Plugin DLL] {1} {2}: {3}");
        }
        private static Logger()
        {
            GooglePlayGames.OurUtils.Logger.warningLogEnabled = true;
        }
    
    }

}
