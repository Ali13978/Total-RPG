using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class AndroidPlatformConfiguration
    {
        // Methods
        internal static extern void AndroidPlatformConfiguration_SetOnLaunchedWithSnapshot(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.OnLaunchedWithSnapshotCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern IntPtr AndroidPlatformConfiguration_Construct()
        {
            if(25808612 != 0)
            {
                    return (IntPtr);
            }
        
        }
        internal static extern void AndroidPlatformConfiguration_SetOptionalIntentHandlerForUI(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.IntentHandler intent_handler, IntPtr intent_handler_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void AndroidPlatformConfiguration_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern bool AndroidPlatformConfiguration_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern void AndroidPlatformConfiguration_SetActivity(System.Runtime.InteropServices.HandleRef self, IntPtr android_app_activity)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void AndroidPlatformConfiguration_SetOnLaunchedWithQuest(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.OnLaunchedWithQuestCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void AndroidPlatformConfiguration_SetOptionalViewForPopups(System.Runtime.InteropServices.HandleRef self, IntPtr android_view)
        {
            if(25808612 == 0)
            {
                goto mem[8386103073678389106];
            }
        
        }
    
    }

}
