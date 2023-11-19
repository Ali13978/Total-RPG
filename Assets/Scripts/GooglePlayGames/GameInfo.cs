using UnityEngine;

namespace GooglePlayGames
{
    public static class GameInfo
    {
        // Fields
        private const string UnescapedApplicationId = "APP_ID";
        private const string UnescapedIosClientId = "IOS_CLIENTID";
        private const string UnescapedWebClientId = "WEB_CLIENTID";
        private const string UnescapedNearbyServiceId = "NEARBY_SERVICE_ID";
        public const string ApplicationId = "739868870194";
        public const string IosClientId = "__IOS_CLIENTID__";
        public const string WebClientId = "";
        public const string NearbyConnectionServiceId = "";
        
        // Methods
        public static bool ApplicationIdInitialized()
        {
            string val_6;
            var val_7;
            var val_8;
            bool val_1 = System.String.IsNullOrEmpty(value:  0);
            if(val_1 != false)
            {
                    val_7 = 0;
            }
            else
            {
                    val_8 = "739868870194";
                val_6 = GooglePlayGames.GameInfo.ToEscapedToken(token:  val_1);
                if("739868870194" == null)
            {
                    val_8 = "739868870194";
            }
            
                bool val_4 = Equals(value:  val_6);
                val_7 = val_4 ^ 1;
            }
            
            val_4 = val_7;
            return (bool)val_4;
        }
        public static bool IosClientIdInitialized()
        {
            string val_6;
            var val_7;
            var val_8;
            bool val_1 = System.String.IsNullOrEmpty(value:  0);
            if(val_1 != false)
            {
                    val_7 = 0;
            }
            else
            {
                    val_8 = "__IOS_CLIENTID__";
                val_6 = GooglePlayGames.GameInfo.ToEscapedToken(token:  val_1);
                if("__IOS_CLIENTID__" == null)
            {
                    val_8 = "__IOS_CLIENTID__";
            }
            
                bool val_4 = Equals(value:  val_6);
                val_7 = val_4 ^ 1;
            }
            
            val_4 = val_7;
            return (bool)val_4;
        }
        public static bool WebClientIdInitialized()
        {
            string val_6;
            var val_7;
            var val_8;
            string val_9;
            val_6 = 1152921504608284672;
            val_7 = null;
            val_7 = null;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_8 = 0;
            }
            else
            {
                    val_9 = null;
                val_9 = null;
                val_6 = System.String.Empty;
                bool val_4 = val_6.Equals(value:  GooglePlayGames.GameInfo.ToEscapedToken(token:  val_9));
                val_8 = val_4 ^ 1;
            }
            
            val_4 = val_8;
            return (bool)val_4;
        }
        public static bool NearbyConnectionsInitialized()
        {
            string val_6;
            var val_7;
            var val_8;
            string val_9;
            val_6 = 1152921504608284672;
            val_7 = null;
            val_7 = null;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_8 = 0;
            }
            else
            {
                    val_9 = null;
                val_9 = null;
                val_6 = System.String.Empty;
                bool val_4 = val_6.Equals(value:  GooglePlayGames.GameInfo.ToEscapedToken(token:  val_9));
                val_8 = val_4 ^ 1;
            }
            
            val_4 = val_8;
            return (bool)val_4;
        }
        private static string ToEscapedToken(string token)
        {
            return System.String.Format(format:  0, arg0:  "__{0}__");
        }
    
    }

}
