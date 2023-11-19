using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class AchievementManager
    {
        // Methods
        internal static extern void AchievementManager_FetchAll(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, GooglePlayGames.Native.Cwrapper.AchievementManager.FetchAllCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void AchievementManager_Reveal(System.Runtime.InteropServices.HandleRef self, string achievement_id)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void AchievementManager_Unlock(System.Runtime.InteropServices.HandleRef self, string achievement_id)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void AchievementManager_ShowAllUI(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.AchievementManager.ShowAllUICallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void AchievementManager_SetStepsAtLeast(System.Runtime.InteropServices.HandleRef self, string achievement_id, uint steps)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void AchievementManager_Increment(System.Runtime.InteropServices.HandleRef self, string achievement_id, uint steps)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void AchievementManager_Fetch(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, string achievement_id, GooglePlayGames.Native.Cwrapper.AchievementManager.FetchCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void AchievementManager_FetchAllResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus AchievementManager_FetchAllResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern UIntPtr AchievementManager_FetchAllResponse_GetData_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr AchievementManager_FetchAllResponse_GetData_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
        internal static extern void AchievementManager_FetchResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus AchievementManager_FetchResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern IntPtr AchievementManager_FetchResponse_GetData(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
    
    }

}
