using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class AndroidClient : IClientImpl
    {
        // Fields
        internal const string BridgeActivityClass = "com.google.games.bridge.NativeBridgeActivity";
        private const string LaunchBridgeMethod = "launchBridgeIntent";
        private const string LaunchBridgeSignature = "(Landroid/app/Activity;Landroid/content/Intent;)V";
        private GooglePlayGames.TokenClient tokenClient;
        private static UnityEngine.AndroidJavaObject invisible;
        private static System.Action<IntPtr> <>f__am$cache0;
        
        // Methods
        public AndroidClient()
        {
        
        }
        public GooglePlayGames.Native.PInvoke.PlatformConfiguration CreatePlatformConfiguration(GooglePlayGames.BasicApi.PlayGamesClientConfiguration clientConfig)
        {
            System.Action<System.IntPtr> val_8;
            var val_9;
            GooglePlayGames.Native.PInvoke.AndroidPlatformConfiguration val_1 = GooglePlayGames.Native.PInvoke.AndroidPlatformConfiguration.Create();
            UnityEngine.AndroidJavaObject val_2 = GooglePlayGames.Android.AndroidTokenClient.GetActivity();
            val_1.SetActivity(activity:  val_2.GetRawObject());
            val_8 = GooglePlayGames.Android.AndroidClient.<>f__am$cache0;
            if(val_8 == null)
            {
                    System.Action<System.IntPtr> val_4 = new System.Action<System.IntPtr>(object:  0, method:  static System.Void GooglePlayGames.Android.AndroidClient::<CreatePlatformConfiguration>m__0(IntPtr intent));
                GooglePlayGames.Android.AndroidClient.<>f__am$cache0 = null;
                val_8 = GooglePlayGames.Android.AndroidClient.<>f__am$cache0;
            }
            
            val_1.SetOptionalIntentHandlerForUI(intentHandler:  val_8);
            if(clientConfig.mHidePopups != false)
            {
                    val_1.SetOptionalViewForPopups(view:  GooglePlayGames.Android.AndroidTokenClient.CreateInvisibleView().GetRawObject());
            }
            
            if(val_2 != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                val_9 = val_2;
            }
            
            if(105 == 105)
            {
                    return (GooglePlayGames.Native.PInvoke.PlatformConfiguration)val_1;
            }
            
            if(0 == 0)
            {
                    return (GooglePlayGames.Native.PInvoke.PlatformConfiguration)val_1;
            }
            
            return (GooglePlayGames.Native.PInvoke.PlatformConfiguration)val_1;
        }
        public GooglePlayGames.TokenClient CreateTokenClient(bool reset)
        {
            GooglePlayGames.TokenClient val_3;
            var val_4;
            val_3 = this.tokenClient;
            if(val_3 != null)
            {
                    if(reset == false)
            {
                    return val_3;
            }
            
                var val_3 = 0;
                val_3 = val_3 + 1;
                val_4 = val_3;
            }
            else
            {
                    object val_1 = null;
                val_3 = val_1;
                val_1 = new System.Object();
                this.tokenClient = val_3;
                return val_3;
            }
            
            val_3 = this.tokenClient;
            return val_3;
        }
        private static void LaunchBridgeIntent(IntPtr bridgedIntent)
        {
            int val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            UnityEngine.jvalue[] val_1 = UnityEngine.AndroidJNIHelper.CreateJNIArgArray(args:  0);
            UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.NativeBridgeActivity");
            UnityEngine.AndroidJavaObject val_3 = GooglePlayGames.Android.AndroidTokenClient.GetActivity();
            val_11 = val_1.Length;
            if(val_11 == 0)
            {
                    val_11 = val_1.Length;
            }
            
            val_1[0] = val_3.GetRawObject();
            val_1[1] = X1;
            UnityEngine.AndroidJNI.CallStaticVoidMethod(clazz:  0, methodID:  GetRawClass(), args:  UnityEngine.AndroidJNI.GetStaticMethodID(clazz:  0, name:  GetRawClass(), sig:  "launchBridgeIntent"));
            val_12 = 0;
            if(val_3 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_13 = val_3;
            }
            
            val_14 = 135;
            if((117 != 117) && (val_12 != 0))
            {
                    val_15 = 0;
                val_14 = 135;
            }
            else
            {
                    val_15 = val_12;
            }
            
            if(null == 0)
            {
                goto label_15;
            }
            
            UnityEngine.AndroidJavaClass val_14 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_16;
            }
            
            var val_12 = mem[null + 152];
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_18:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_17;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (mem[null + 258]))
            {
                goto label_18;
            }
            
            label_16:
            val_16 = null;
            goto label_19;
            label_17:
            val_14 = val_14 + (((mem[null + 152] + 8)) << 4);
            label_19:
            label_15:
            if((135 != 135) && (val_15 != 0))
            {
                    val_17 = 0;
                val_18 = 189;
            }
            else
            {
                    val_18 = 189;
                val_17 = val_15;
            }
            
            label_40:
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  0, jniArgs:  null);
            if(189 == 189)
            {
                    return;
            }
            
            if(val_17 != 0)
            {
                goto label_24;
            }
            
            return;
            label_41:
            if( != )
            {
                goto label_39;
            }
            
            goto label_40;
            label_39:
            mem[8] = ;
            label_24:
            var val_10 = (???) - 64;
            goto label_41;
        }
        public void Signout()
        {
            var val_2;
            if(this.tokenClient == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.tokenClient;
        }
        public void GetPlayerStats(IntPtr apiClient, System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
        {
            typeof(AndroidClient.<GetPlayerStats>c__AnonStorey1).__il2cppRuntimeField_10 = callback;
            System.Action<System.Int32, Com.Google.Android.Gms.Games.Stats.PlayerStats> val_3 = new System.Action<System.Int32, Com.Google.Android.Gms.Games.Stats.PlayerStats>(object:  new System.Object(), method:  System.Void AndroidClient.<GetPlayerStats>c__AnonStorey1::<>m__0(int result, Com.Google.Android.Gms.Games.Stats.PlayerStats stats));
            AndroidClient.StatsResultCallback val_4 = new AndroidClient.StatsResultCallback(callback:  null);
            Com.Google.Android.Gms.Games.Games.Stats.loadPlayerStats(arg_GoogleApiClient_1:  new Com.Google.Android.Gms.Common.Api.GoogleApiClient(ptr:  apiClient), arg_bool_2:  true).setResultCallback(arg_ResultCallback_1:  null);
        }
        public void SetGravityForPopups(IntPtr apiClient, GooglePlayGames.BasicApi.Gravity gravity)
        {
            Com.Google.Android.Gms.Common.Api.GoogleApiClient val_1 = new Com.Google.Android.Gms.Common.Api.GoogleApiClient(ptr:  apiClient);
            GooglePlayGames.BasicApi.Gravity val_2 = gravity | 1;
            Com.Google.Android.Gms.Games.Games.setGravityForPopups(arg_GoogleApiClient_1:  0, arg_int_2:  336474112);
        }
        private static void <CreatePlatformConfiguration>m__0(IntPtr intent)
        {
            typeof(AndroidClient.<CreatePlatformConfiguration>c__AnonStorey0).__il2cppRuntimeField_10 = UnityEngine.AndroidJNI.NewGlobalRef(obj:  0);
            System.Action val_3 = new System.Action(object:  new System.Object(), method:  System.Void AndroidClient.<CreatePlatformConfiguration>c__AnonStorey0::<>m__0());
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
        }
    
    }

}
