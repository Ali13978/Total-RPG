using UnityEngine;

namespace SA.IOSNative.Core
{
    public class AppController : Singleton<SA.IOSNative.Core.AppController>
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnApplicationDidEnterBackground;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnApplicationDidBecomeActive;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnApplicationDidReceiveMemoryWarning;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnApplicationWillResignActive;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnApplicationWillTerminate;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<SA.IOSNative.Models.LaunchUrl> OnOpenURL;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<SA.IOSNative.Models.UniversalLink> OnContinueUserActivity;
        
        // Properties
        public static SA.IOSNative.Models.LaunchUrl LaunchUrl { get; }
        public static SA.IOSNative.Models.UniversalLink LaunchUniversalLink { get; }
        public static SA.IOSNative.UserNotifications.NotificationRequest LaunchNotification { get; }
        
        // Methods
        public AppController()
        {
        
        }
        public static void add_OnApplicationDidEnterBackground(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnApplicationDidEnterBackground;
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  null);
            val_5 = 0;
            if(val_1 == null)
            {
                    return;
            }
            
            val_5 = val_1;
            if(null == null)
            {
                    return;
            }
            
            val_5 = 0;
        }
        public static void remove_OnApplicationDidEnterBackground(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnApplicationDidEnterBackground;
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  null);
            val_5 = 0;
            if(val_1 == null)
            {
                    return;
            }
            
            val_5 = val_1;
            if(null == null)
            {
                    return;
            }
            
            val_5 = 0;
        }
        public static void add_OnApplicationDidBecomeActive(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnApplicationDidBecomeActive;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504840876040 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnApplicationDidBecomeActive(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnApplicationDidBecomeActive;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504840876040 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void add_OnApplicationDidReceiveMemoryWarning(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnApplicationDidReceiveMemoryWarning;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504840876048 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnApplicationDidReceiveMemoryWarning(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnApplicationDidReceiveMemoryWarning;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504840876048 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void add_OnApplicationWillResignActive(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnApplicationWillResignActive;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504840876056 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnApplicationWillResignActive(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnApplicationWillResignActive;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504840876056 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void add_OnApplicationWillTerminate(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnApplicationWillTerminate;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504840876064 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnApplicationWillTerminate(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnApplicationWillTerminate;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504840876064 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void add_OnOpenURL(System.Action<SA.IOSNative.Models.LaunchUrl> value)
        {
            var val_3;
            System.Action<SA.IOSNative.Models.LaunchUrl> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnOpenURL;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504840876072 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnOpenURL(System.Action<SA.IOSNative.Models.LaunchUrl> value)
        {
            var val_3;
            System.Action<SA.IOSNative.Models.LaunchUrl> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnOpenURL;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504840876072 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void add_OnContinueUserActivity(System.Action<SA.IOSNative.Models.UniversalLink> value)
        {
            var val_3;
            System.Action<SA.IOSNative.Models.UniversalLink> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnContinueUserActivity;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504840876080 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnContinueUserActivity(System.Action<SA.IOSNative.Models.UniversalLink> value)
        {
            var val_3;
            System.Action<SA.IOSNative.Models.UniversalLink> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.OnContinueUserActivity;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = SA.IOSNative.Core.AppController.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504840876080 != val_4)
            {
                goto label_8;
            }
        
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public static void Subscribe()
        {
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.enabled = true;
        }
        public static SA.IOSNative.Models.LaunchUrl get_LaunchUrl()
        {
            null = null;
            return (SA.IOSNative.Models.LaunchUrl)new SA.IOSNative.Models.LaunchUrl(absoluteUrl:  System.String.Empty, sourceApplication:  System.String.Empty);
        }
        public static SA.IOSNative.Models.UniversalLink get_LaunchUniversalLink()
        {
            null = null;
            return (SA.IOSNative.Models.UniversalLink)new SA.IOSNative.Models.UniversalLink(absoluteUrl:  System.String.Empty);
        }
        public static SA.IOSNative.UserNotifications.NotificationRequest get_LaunchNotification()
        {
            return (SA.IOSNative.UserNotifications.NotificationRequest)new SA.IOSNative.UserNotifications.NotificationRequest();
        }
        private void openURL(string data)
        {
            var val_2 = null;
            SA.IOSNative.Core.AppController.OnOpenURL.Invoke(obj:  new SA.IOSNative.Models.LaunchUrl(data:  data));
        }
        private void continueUserActivity(string absoluteUrl)
        {
            var val_2 = null;
            SA.IOSNative.Core.AppController.OnContinueUserActivity.Invoke(obj:  new SA.IOSNative.Models.UniversalLink(absoluteUrl:  absoluteUrl));
        }
        private void applicationDidEnterBackground()
        {
            null = null;
            SA.IOSNative.Core.AppController.OnApplicationDidEnterBackground.Invoke();
        }
        private void applicationDidBecomeActive()
        {
            null = null;
            SA.IOSNative.Core.AppController.OnApplicationDidBecomeActive.Invoke();
        }
        private void applicationDidReceiveMemoryWarning()
        {
            null = null;
            SA.IOSNative.Core.AppController.OnApplicationDidReceiveMemoryWarning.Invoke();
        }
        private void applicationWillResignActive()
        {
            null = null;
            SA.IOSNative.Core.AppController.OnApplicationWillResignActive.Invoke();
        }
        private void applicationWillTerminate()
        {
            null = null;
            SA.IOSNative.Core.AppController.OnApplicationWillTerminate.Invoke();
        }
        protected override void OnApplicationQuit()
        {
            var val_1;
            this.OnApplicationQuit();
            val_1 = null;
            val_1 = null;
            SA.IOSNative.Core.AppController.OnApplicationWillTerminate.Invoke();
        }
        private static AppController()
        {
            SA.IOSNative.Core.AppController.OnApplicationDidEnterBackground = new System.Action(object:  0, method:  static System.Void SA.IOSNative.Core.AppController::<OnApplicationDidEnterBackground>m__0());
            SA.IOSNative.Core.AppController.OnApplicationDidBecomeActive = new System.Action(object:  0, method:  static System.Void SA.IOSNative.Core.AppController::<OnApplicationDidBecomeActive>m__1());
            SA.IOSNative.Core.AppController.OnApplicationDidReceiveMemoryWarning = new System.Action(object:  0, method:  static System.Void SA.IOSNative.Core.AppController::<OnApplicationDidReceiveMemoryWarning>m__2());
            SA.IOSNative.Core.AppController.OnApplicationWillResignActive = new System.Action(object:  0, method:  static System.Void SA.IOSNative.Core.AppController::<OnApplicationWillResignActive>m__3());
            SA.IOSNative.Core.AppController.OnApplicationWillTerminate = new System.Action(object:  0, method:  static System.Void SA.IOSNative.Core.AppController::<OnApplicationWillTerminate>m__4());
            SA.IOSNative.Core.AppController.OnOpenURL = new System.Action<SA.IOSNative.Models.LaunchUrl>(object:  0, method:  static System.Void SA.IOSNative.Core.AppController::<OnOpenURL>m__5(SA.IOSNative.Models.LaunchUrl ));
            SA.IOSNative.Core.AppController.OnContinueUserActivity = new System.Action<SA.IOSNative.Models.UniversalLink>(object:  0, method:  static System.Void SA.IOSNative.Core.AppController::<OnContinueUserActivity>m__6(SA.IOSNative.Models.UniversalLink ));
        }
        private static void <OnApplicationDidEnterBackground>m__0()
        {
        
        }
        private static void <OnApplicationDidBecomeActive>m__1()
        {
        
        }
        private static void <OnApplicationDidReceiveMemoryWarning>m__2()
        {
        
        }
        private static void <OnApplicationWillResignActive>m__3()
        {
        
        }
        private static void <OnApplicationWillTerminate>m__4()
        {
        
        }
        private static void <OnOpenURL>m__5(SA.IOSNative.Models.LaunchUrl )
        {
        
        }
        private static void <OnContinueUserActivity>m__6(SA.IOSNative.Models.UniversalLink )
        {
        
        }
    
    }

}
