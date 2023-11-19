using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class Player
    {
        // Methods
        internal static extern IntPtr Player_CurrentLevel(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern UIntPtr Player_Name(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern void Player_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern UIntPtr Player_AvatarUrl(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.ImageResolution resolution, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)resolution;
            }
        
        }
        internal static extern ulong Player_LastLevelUpTime(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ulong)X2;
            }
        
        }
        internal static extern UIntPtr Player_Title(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern ulong Player_CurrentXP(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ulong)X2;
            }
        
        }
        internal static extern bool Player_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern bool Player_HasLevelInfo(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern IntPtr Player_NextLevel(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern UIntPtr Player_Id(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
    
    }

}
