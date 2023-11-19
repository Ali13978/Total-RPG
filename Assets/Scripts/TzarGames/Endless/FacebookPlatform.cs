using UnityEngine;

namespace TzarGames.Endless
{
    public class FacebookPlatform : MonoBehaviour
    {
        // Fields
        private static string cachedUserId;
        private const string userIdKey = "1j3kf84kmg89vmd84mg9bmfo9ejgjeofj";
        private TzarGames.Common.CustomAnalyticsEvent getAppLinkEvent;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static TzarGames.Endless.FacebookPlatform <Instance>k__BackingField;
        
        // Properties
        public static TzarGames.Endless.FacebookPlatform Instance { get; set; }
        public static bool IsLoggedIn { get; }
        public static string UserID { get; }
        public static string AccessToken { get; }
        
        // Methods
        public FacebookPlatform()
        {
        
        }
        public static TzarGames.Endless.FacebookPlatform get_Instance()
        {
            null = null;
            return (TzarGames.Endless.FacebookPlatform)TzarGames.Endless.FacebookPlatform.<Instance>k__BackingField;
        }
        private static void set_Instance(TzarGames.Endless.FacebookPlatform value)
        {
            null = null;
            TzarGames.Endless.FacebookPlatform.<Instance>k__BackingField = X1;
        }
        private void Awake()
        {
            if(0 != TzarGames.Endless.FacebookPlatform.Instance)
            {
                    UnityEngine.Debug.LogError(message:  0);
                UnityEngine.GameObject val_3 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            TzarGames.Endless.FacebookPlatform.Instance = null;
            if(Facebook.Unity.FB.IsInitialized != false)
            {
                    Facebook.Unity.FB.ActivateApp();
            }
            else
            {
                    Facebook.Unity.FB.Init(onInitComplete:  0, onHideUnity:  new Facebook.Unity.InitDelegate(object:  this, method:  System.Void TzarGames.Endless.FacebookPlatform::initCallback()), authResponse:  new Facebook.Unity.HideUnityDelegate(object:  this, method:  System.Void TzarGames.Endless.FacebookPlatform::onHideUnity(bool isUnityShown)));
            }
            
            System.Action<System.Boolean> val_8 = new System.Action<System.Boolean>(object:  this, method:  System.Void TzarGames.Endless.FacebookPlatform::Privacy_OnDataCollectionPermissionChanged(bool canCollectData));
            TzarGames.Common.Privacy.add_OnDataCollectionPermissionChanged(value:  0);
        }
        private void Privacy_OnDataCollectionPermissionChanged(bool canCollectData)
        {
            bool val_1 = canCollectData;
            string val_2 = 0 + "Changing data collection settings for Facebook to ";
            UnityEngine.Debug.Log(message:  0);
            bool val_3 = Facebook.Unity.FB.IsInitialized;
            if(val_3 == false)
            {
                    return;
            }
            
            val_3.enableDataCollection(enable:  canCollectData);
        }
        private void enableDataCollection(bool enable)
        {
            enable = (~enable) & 1;
            Facebook.Unity.FB.LimitAppEventUsage = false;
            bool val_1 = enable;
            FB.Mobile.SetAdvertiserIDCollectionEnabled(advertiserIDCollectionEnabled:  false);
            FB.Mobile.SetAutoLogAppEventsEnabled(autoLogAppEventsEnabled:  false);
        }
        private void initCallback()
        {
            if(Facebook.Unity.FB.IsInitialized != false)
            {
                    Facebook.Unity.FB.ActivateApp();
                bool val_2 = TzarGames.Common.Privacy.CanCollectData;
                val_2.enableDataCollection(enable:  val_2);
                UnityEngine.Debug.Log(message:  0);
                Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> val_4 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult>(object:  this, method:  System.Void TzarGames.Endless.FacebookPlatform::HandleFetchDeferredAppLinkData(Facebook.Unity.IAppLinkResult result));
                FB.Mobile.FetchDeferredAppLinkData(callback:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        private void HandleFetchDeferredAppLinkData(Facebook.Unity.IAppLinkResult result)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if(result != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_11 = result;
            }
            else
            {
                    UnityEngine.Debug.Log(message:  0);
                return;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_10;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = result;
            goto label_14;
            label_10:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_13 = result;
            goto label_18;
            label_14:
            typeof(System.Object[]).__il2cppRuntimeField_20 = result;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_14 = result;
            goto label_26;
            label_18:
            typeof(System.Object[]).__il2cppRuntimeField_20 = result;
            UnityEngine.Debug.LogFormat(format:  0, args:  "Facebook FetchDeferredAppLinkData error {0}");
            return;
            label_26:
            typeof(System.Object[]).__il2cppRuntimeField_28 = result;
            UnityEngine.Debug.LogFormat(format:  0, args:  "Facebook FetchDeferredAppLinkData url: {0} target url: {1}");
            if(0 == this.getAppLinkEvent)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.String> val_8 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_15 = result;
            Add(key:  "url", value:  result);
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_16 = result;
            Add(key:  "target-url", value:  result);
            TzarGames.Common.Analytics.AnalyticsManager.SendEvent(customEvent:  0, paramaters:  this.getAppLinkEvent);
        }
        private void onHideUnity(bool isUnityShown)
        {
        
        }
        public static bool get_IsLoggedIn()
        {
            return Facebook.Unity.FB.IsLoggedIn;
        }
        public static string get_UserID()
        {
            string val_4;
            var val_5;
            var val_6;
            if(TzarGames.Endless.FacebookPlatform.IsLoggedIn != false)
            {
                    Facebook.Unity.AccessToken val_2 = Facebook.Unity.AccessToken.CurrentAccessToken;
                if(val_2 != null)
            {
                    return val_2.UserId;
            }
            
                return val_2.UserId;
            }
            
            val_5 = null;
            val_5 = null;
            if(TzarGames.Endless.FacebookPlatform.userIdKey == null)
            {
                    val_6 = null;
                val_4 = UnityEngine.PlayerPrefs.GetString(key:  0, defaultValue:  "1j3kf84kmg89vmd84mg9bmfo9ejgjeofj");
                val_6 = null;
                TzarGames.Endless.FacebookPlatform.userIdKey = val_4;
                val_5 = null;
            }
            
            val_5 = null;
            return (string)TzarGames.Endless.FacebookPlatform.userIdKey;
        }
        public static string get_AccessToken()
        {
            Facebook.Unity.AccessToken val_1 = Facebook.Unity.AccessToken.CurrentAccessToken;
            if(val_1 != null)
            {
                    return val_1.TokenString;
            }
            
            return val_1.TokenString;
        }
        public static void FeedShare(System.Uri link, System.Action<bool> shareResult)
        {
            var val_6;
            System.Action<System.Boolean> val_7;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_6 = val_1;
                typeof(FacebookPlatform.<FeedShare>c__AnonStorey0).__il2cppRuntimeField_10 = X2;
            }
            else
            {
                    val_6 = 16;
                mem[16] = X2;
            }
            
            typeof(FacebookPlatform.<FeedShare>c__AnonStorey0).__il2cppRuntimeField_18 = shareResult;
            if(TzarGames.Endless.FacebookPlatform.check() == false)
            {
                    return;
            }
            
            if(TzarGames.Endless.FacebookPlatform.IsLoggedIn == false)
            {
                goto label_8;
            }
            
            if(null == 0)
            {
                goto label_9;
            }
            
            val_7 = typeof(FacebookPlatform.<FeedShare>c__AnonStorey0).__il2cppRuntimeField_18;
            goto label_10;
            label_8:
            System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  val_1, method:  System.Void FacebookPlatform.<FeedShare>c__AnonStorey0::<>m__0(bool x));
            TzarGames.Endless.FacebookPlatform.Login(callback:  null);
            return;
            label_9:
            val_7 = typeof(FacebookPlatform.<FeedShare>c__AnonStorey0).__il2cppRuntimeField_18;
            label_10:
            TzarGames.Endless.FacebookPlatform.feed(link:  null, shareResultCallback:  val_7);
        }
        private static void feed(System.Uri link, System.Action<bool> shareResultCallback)
        {
            var val_3;
            typeof(FacebookPlatform.<feed>c__AnonStorey1).__il2cppRuntimeField_10 = X2;
            val_3 = null;
            val_3 = null;
            Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> val_2 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult>(object:  new System.Object(), method:  System.Void FacebookPlatform.<feed>c__AnonStorey1::<>m__0(Facebook.Unity.IShareResult result));
            Facebook.Unity.FB.FeedShare(toId:  0, link:  System.String.Empty, linkName:  shareResultCallback, linkCaption:  System.String.Empty, linkDescription:  System.String.Empty, picture:  System.String.Empty, mediaSource:  0, callback:  System.String.Empty);
        }
        public static void Login(System.Action<bool> callback)
        {
            typeof(FacebookPlatform.<Login>c__AnonStorey2).__il2cppRuntimeField_10 = X1;
            if(TzarGames.Endless.FacebookPlatform.check() == false)
            {
                    return;
            }
            
            if(null != 0)
            {
                    Add(item:  "public_profile");
                Add(item:  "email");
            }
            else
            {
                    Add(item:  "public_profile");
                Add(item:  "email");
            }
            
            Add(item:  "user_friends");
            Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> val_4 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult>(object:  new System.Object(), method:  System.Void FacebookPlatform.<Login>c__AnonStorey2::<>m__0(Facebook.Unity.ILoginResult result));
            Facebook.Unity.FB.LogInWithReadPermissions(permissions:  0, callback:  new System.Collections.Generic.List<System.String>());
        }
        private static bool check()
        {
            var val_5;
            var val_6;
            if(0 == TzarGames.Endless.FacebookPlatform.Instance)
            {
                    val_5 = "No Facebook platform instance";
            }
            else
            {
                    if(Facebook.Unity.FB.IsInitialized != false)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
                val_5 = "Facebook SDK is not initialized";
            }
            
            UnityEngine.Debug.LogError(message:  0);
            val_6 = 0;
            return (bool)val_6;
        }
        private static FacebookPlatform()
        {
        
        }
    
    }

}
