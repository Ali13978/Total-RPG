using UnityEngine;

namespace Com.Google.Android.Gms.Games
{
    public class Games : JavaObjWrapper
    {
        // Fields
        private const string CLASS_NAME = "com/google/android/gms/games/Games";
        
        // Properties
        public static string EXTRA_PLAYER_IDS { get; }
        public static string EXTRA_STATUS { get; }
        public static object SCOPE_GAMES { get; }
        public static object API { get; }
        public static object GamesMetadata { get; }
        public static object Achievements { get; }
        public static object Events { get; }
        public static object Leaderboards { get; }
        public static object Invitations { get; }
        public static object TurnBasedMultiplayer { get; }
        public static object RealTimeMultiplayer { get; }
        public static object Players { get; }
        public static object Notifications { get; }
        public static object Snapshots { get; }
        public static Com.Google.Android.Gms.Games.Stats.StatsObject Stats { get; }
        
        // Methods
        public Games(IntPtr ptr)
        {
        
        }
        public static string get_EXTRA_PLAYER_IDS()
        {
            return Google.Developers.JavaObjWrapper.GetStaticStringField(clsName:  0, name:  "com/google/android/gms/games/Games");
        }
        public static string get_EXTRA_STATUS()
        {
            return Google.Developers.JavaObjWrapper.GetStaticStringField(clsName:  0, name:  "com/google/android/gms/games/Games");
        }
        public static object get_SCOPE_GAMES()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "SCOPE_GAMES");
        }
        public static object get_API()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "API");
        }
        public static object get_GamesMetadata()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "GamesMetadata");
        }
        public static object get_Achievements()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "Achievements");
        }
        public static object get_Events()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "Events");
        }
        public static object get_Leaderboards()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "Leaderboards");
        }
        public static object get_Invitations()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "Invitations");
        }
        public static object get_TurnBasedMultiplayer()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "TurnBasedMultiplayer");
        }
        public static object get_RealTimeMultiplayer()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "RealTimeMultiplayer");
        }
        public static object get_Players()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "Players");
        }
        public static object get_Notifications()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "Notifications");
        }
        public static object get_Snapshots()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "Snapshots");
        }
        public static Com.Google.Android.Gms.Games.Stats.StatsObject get_Stats()
        {
            return Google.Developers.JavaObjWrapper.GetStaticObjectField<Com.Google.Android.Gms.Games.Stats.StatsObject>(clsName:  0, name:  "com/google/android/gms/games/Games", sig:  "Stats");
        }
        public static string getAppId(Com.Google.Android.Gms.Common.Api.GoogleApiClient arg_GoogleApiClient_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = X1;
            return Google.Developers.JavaObjWrapper.StaticInvokeCall<Com.Google.Android.Gms.Common.Api.PendingResult<Com.Google.Android.Gms.Common.Api.Status>>(type:  0, name:  "com/google/android/gms/games/Games", sig:  "getAppId", args:  "(Lcom/google/android/gms/common/api/GoogleApiClient;)Ljava/lang/String;");
        }
        public static string getCurrentAccountName(Com.Google.Android.Gms.Common.Api.GoogleApiClient arg_GoogleApiClient_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = X1;
            return Google.Developers.JavaObjWrapper.StaticInvokeCall<Com.Google.Android.Gms.Common.Api.PendingResult<Com.Google.Android.Gms.Common.Api.Status>>(type:  0, name:  "com/google/android/gms/games/Games", sig:  "getCurrentAccountName", args:  "(Lcom/google/android/gms/common/api/GoogleApiClient;)Ljava/lang/String;");
        }
        public static int getSdkVariant(Com.Google.Android.Gms.Common.Api.GoogleApiClient arg_GoogleApiClient_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = X1;
            return Google.Developers.JavaObjWrapper.StaticInvokeCall<System.Int32>(type:  0, name:  "com/google/android/gms/games/Games", sig:  "getSdkVariant", args:  "(Lcom/google/android/gms/common/api/GoogleApiClient;)I");
        }
        public static object getSettingsIntent(Com.Google.Android.Gms.Common.Api.GoogleApiClient arg_GoogleApiClient_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = X1;
            return Google.Developers.JavaObjWrapper.StaticInvokeCall<Com.Google.Android.Gms.Common.Api.PendingResult<Com.Google.Android.Gms.Common.Api.Status>>(type:  0, name:  "com/google/android/gms/games/Games", sig:  "getSettingsIntent", args:  "(Lcom/google/android/gms/common/api/GoogleApiClient;)Landroid/content/Intent;");
        }
        public static void setGravityForPopups(Com.Google.Android.Gms.Common.Api.GoogleApiClient arg_GoogleApiClient_1, int arg_int_2)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_int_2;
            typeof(System.Object[]).__il2cppRuntimeField_28 = W2;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            Google.Developers.JavaObjWrapper.StaticInvokeCallVoid(type:  0, name:  "com/google/android/gms/games/Games", sig:  "setGravityForPopups", args:  "(Lcom/google/android/gms/common/api/GoogleApiClient;I)V");
        }
        public static void setViewForPopups(Com.Google.Android.Gms.Common.Api.GoogleApiClient arg_GoogleApiClient_1, object arg_object_2)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = arg_object_2;
            typeof(System.Object[]).__il2cppRuntimeField_28 = X2;
            Google.Developers.JavaObjWrapper.StaticInvokeCallVoid(type:  0, name:  "com/google/android/gms/games/Games", sig:  "setViewForPopups", args:  "(Lcom/google/android/gms/common/api/GoogleApiClient;Landroid/view/View;)V");
        }
        public static Com.Google.Android.Gms.Common.Api.PendingResult<Com.Google.Android.Gms.Common.Api.Status> signOut(Com.Google.Android.Gms.Common.Api.GoogleApiClient arg_GoogleApiClient_1)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = X1;
            return Google.Developers.JavaObjWrapper.StaticInvokeCall<Com.Google.Android.Gms.Common.Api.PendingResult<Com.Google.Android.Gms.Common.Api.Status>>(type:  0, name:  "com/google/android/gms/games/Games", sig:  "signOut", args:  "(Lcom/google/android/gms/common/api/GoogleApiClient;)Lcom/google/android/gms/common/api/PendingResult;");
        }
    
    }

}
