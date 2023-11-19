using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class Achievement
    {
        // Methods
        internal static extern uint Achievement_TotalSteps(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern UIntPtr Achievement_Description(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern void Achievement_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern UIntPtr Achievement_UnlockedIconUrl(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern ulong Achievement_LastModifiedTime(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ulong)X2;
            }
        
        }
        internal static extern UIntPtr Achievement_RevealedIconUrl(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern uint Achievement_CurrentSteps(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.Types.AchievementState Achievement_State(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (AchievementState)X2;
            }
        
        }
        internal static extern bool Achievement_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern ulong Achievement_LastModified(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ulong)X2;
            }
        
        }
        internal static extern ulong Achievement_XP(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ulong)X2;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.Types.AchievementType Achievement_Type(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (AchievementType)X2;
            }
        
        }
        internal static extern UIntPtr Achievement_Id(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern UIntPtr Achievement_Name(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
    
    }

}
