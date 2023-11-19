using UnityEngine;

namespace GooglePlayGames.Native
{
    public class NativeNearbyConnectionClientFactory
    {
        // Fields
        private static GooglePlayGames.Native.PInvoke.NearbyConnectionsManager sManager;
        private static System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient> sCreationCallback;
        private static System.Action<GooglePlayGames.Native.Cwrapper.NearbyConnectionsStatus.InitializationStatus> <>f__mg$cache0;
        
        // Methods
        public NativeNearbyConnectionClientFactory()
        {
        
        }
        internal static GooglePlayGames.Native.PInvoke.NearbyConnectionsManager GetManager()
        {
            return (GooglePlayGames.Native.PInvoke.NearbyConnectionsManager)GooglePlayGames.Native.NativeNearbyConnectionClientFactory.sManager;
        }
        public static void Create(System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient> callback)
        {
            if(GooglePlayGames.Native.NativeNearbyConnectionClientFactory.sManager != null)
            {
                    X1.Invoke(obj:  new GooglePlayGames.Native.NativeNearbyConnectionsClient(manager:  GooglePlayGames.Native.NativeNearbyConnectionClientFactory.GetManager()));
                return;
            }
            
            GooglePlayGames.Native.NativeNearbyConnectionClientFactory.sCreationCallback = X1;
            GooglePlayGames.Native.NativeNearbyConnectionClientFactory.InitializeFactory();
        }
        internal static void InitializeFactory()
        {
            System.Action<InitializationStatus> val_8;
            var val_9;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.CreateObject();
            string val_1 = GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.ReadServiceId();
            GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder val_2 = new GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder();
            val_8 = GooglePlayGames.Native.NativeNearbyConnectionClientFactory.<>f__mg$cache0;
            if(val_8 == null)
            {
                    GooglePlayGames.Native.NativeNearbyConnectionClientFactory.<>f__mg$cache0 = new System.Action<InitializationStatus>(object:  0, method:  static System.Void GooglePlayGames.Native.NativeNearbyConnectionClientFactory::OnManagerInitialized(GooglePlayGames.Native.Cwrapper.NearbyConnectionsStatus.InitializationStatus status));
                val_8 = GooglePlayGames.Native.NativeNearbyConnectionClientFactory.<>f__mg$cache0;
            }
            
            GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder val_4 = SetOnInitializationFinished(callback:  val_8);
            GooglePlayGames.Android.AndroidClient val_5 = new GooglePlayGames.Android.AndroidClient();
            val_9 = null;
            val_9 = null;
            UnityEngine.Debug.Log(message:  0);
            GooglePlayGames.Native.NativeNearbyConnectionClientFactory.sManager = Build(configuration:  CreatePlatformConfiguration(clientConfig:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration, mScopes = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration, mRequestAuthCode = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10, mForceRefresh = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10, mHidePopups = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10, mRequestEmail = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10, mRequestIdToken = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10, mAccountName = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_10, mInvitationDelegate = GooglePlayGames.BasicApi.PlayGamesClientConfiguration.DefaultConfiguration.__il2cppRuntimeField_20}));
        }
        internal static void OnManagerInitialized(GooglePlayGames.Native.Cwrapper.NearbyConnectionsStatus.InitializationStatus status)
        {
            GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient val_5;
            System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient> val_6;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Nearby Init Complete: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = W1;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " sManager = ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = GooglePlayGames.Native.NativeNearbyConnectionClientFactory.sManager;
            string val_1 = +0;
            val_5 = 1152921504718028800;
            UnityEngine.Debug.Log(message:  0);
            if(W1 == 1)
            {
                    val_6 = GooglePlayGames.Native.NativeNearbyConnectionClientFactory.sCreationCallback;
                if(val_6 == null)
            {
                    return;
            }
            
                GooglePlayGames.Native.NativeNearbyConnectionsClient val_3 = null;
                val_5 = val_3;
                val_3 = new GooglePlayGames.Native.NativeNearbyConnectionsClient(manager:  GooglePlayGames.Native.NativeNearbyConnectionClientFactory.GetManager());
                val_6.Invoke(obj:  val_5);
                GooglePlayGames.Native.NativeNearbyConnectionClientFactory.sCreationCallback = 0;
                return;
            }
            
            val_6 = 0 + "ERROR: NearbyConnectionManager not initialized: "("ERROR: NearbyConnectionManager not initialized: ");
            UnityEngine.Debug.LogError(message:  0);
        }
    
    }

}
