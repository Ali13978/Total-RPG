using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal sealed class AndroidPlatformConfiguration : PlatformConfiguration
    {
        // Fields
        private static GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.IntentHandler <>f__mg$cache0;
        
        // Methods
        private AndroidPlatformConfiguration(IntPtr selfPointer)
        {
        
        }
        internal void SetActivity(IntPtr activity)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.AndroidPlatformConfiguration_SetActivity(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, android_app_activity:  val_1.handle);
        }
        internal void SetOptionalIntentHandlerForUI(System.Action<IntPtr> intentHandler)
        {
            AndroidPlatformConfiguration.IntentHandler val_5;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_2 = this.SelfPtr();
            val_5 = GooglePlayGames.Native.PInvoke.AndroidPlatformConfiguration.<>f__mg$cache0;
            if(val_5 == null)
            {
                    GooglePlayGames.Native.PInvoke.AndroidPlatformConfiguration.<>f__mg$cache0 = new AndroidPlatformConfiguration.IntentHandler(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.AndroidPlatformConfiguration::InternalIntentHandler(IntPtr intent, IntPtr userData));
                val_5 = GooglePlayGames.Native.PInvoke.AndroidPlatformConfiguration.<>f__mg$cache0;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  null);
            GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.AndroidPlatformConfiguration_SetOptionalIntentHandlerForUI(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, intent_handler:  val_2.handle, intent_handler_arg:  val_5);
        }
        internal void SetOptionalViewForPopups(IntPtr view)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.AndroidPlatformConfiguration_SetOptionalViewForPopups(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, android_view:  val_1.handle);
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.AndroidPlatformConfiguration_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalIntentHandler(IntPtr intent, IntPtr userData)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  null, callbackType:  "AndroidPlatformConfiguration#InternalIntentHandler", response:  0, userData:  userData);
        }
        internal static GooglePlayGames.Native.PInvoke.AndroidPlatformConfiguration Create()
        {
            return (GooglePlayGames.Native.PInvoke.AndroidPlatformConfiguration)new GooglePlayGames.Native.PInvoke.PlatformConfiguration(selfPointer:  GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.AndroidPlatformConfiguration_Construct());
        }
    
    }

}
