using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class GameServices
    {
        // Methods
        internal static extern void GameServices_Flush(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.GameServices.FlushCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern bool GameServices_IsAuthorized(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern void GameServices_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void GameServices_SignOut(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void GameServices_StartAuthorizationUI(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 == 0)
            {
                goto mem[7305798977971376997];
            }
        
        }
    
    }

}
