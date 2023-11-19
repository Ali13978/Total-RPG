using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class Builder
    {
        // Methods
        internal static extern void GameServices_Builder_SetOnAuthActionStarted(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Builder.OnAuthActionStartedCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void GameServices_Builder_AddOauthScope(System.Runtime.InteropServices.HandleRef self, string scope)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void GameServices_Builder_SetLogging(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Builder.OnLogCallback callback, IntPtr callback_arg, GooglePlayGames.Native.Cwrapper.Types.LogLevel min_level)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern IntPtr GameServices_Builder_Construct()
        {
            if(25808612 != 0)
            {
                    return (IntPtr);
            }
        
        }
        internal static extern void GameServices_Builder_EnableSnapshots(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void GameServices_Builder_SetOnLog(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Builder.OnLogCallback callback, IntPtr callback_arg, GooglePlayGames.Native.Cwrapper.Types.LogLevel min_level)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void GameServices_Builder_SetDefaultOnLog(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.LogLevel min_level)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void GameServices_Builder_SetOnAuthActionFinished(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Builder.OnAuthActionFinishedCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void GameServices_Builder_SetOnTurnBasedMatchEvent(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Builder.OnTurnBasedMatchEventCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void GameServices_Builder_SetOnQuestCompleted(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Builder.OnQuestCompletedCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void GameServices_Builder_SetOnMultiplayerInvitationEvent(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Builder.OnMultiplayerInvitationEventCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void GameServices_Builder_SetShowConnectingPopup(System.Runtime.InteropServices.HandleRef self, bool flag)
        {
            if(25808612 != 0)
            {
                    var val_1 = W3 & 1;
                return;
            }
        
        }
        internal static extern IntPtr GameServices_Builder_Create(System.Runtime.InteropServices.HandleRef self, IntPtr platform)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)platform;
            }
        
        }
        internal static extern void GameServices_Builder_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 == 0)
            {
                goto mem[7305798977971376997];
            }
        
        }
    
    }

}
