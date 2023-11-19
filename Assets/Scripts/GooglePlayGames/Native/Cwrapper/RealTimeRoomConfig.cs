using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class RealTimeRoomConfig
    {
        // Methods
        internal static extern UIntPtr RealTimeRoomConfig_PlayerIdsToInvite_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern UIntPtr RealTimeRoomConfig_PlayerIdsToInvite_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index, [In] [Out] char[] out_arg, UIntPtr out_size)
        {
            var val_3;
            if(25808612 == 0)
            {
                goto label_1;
            }
            
            if(out_size == 0)
            {
                goto label_2;
            }
            
            if((out_size + 24) < 1)
            {
                goto label_3;
            }
            
            var val_3 = 0;
            UIntPtr val_1 = out_size + 32;
            do
            {
                mem2[0] = (out_size + 32) + 0;
                val_3 = val_3 + 1;
            }
            while((out_size + 24) != val_3);
            
            val_3 = index;
            goto label_5;
            label_2:
            val_3 = index;
            return (UIntPtr)val_3;
            label_3:
            val_3 = index;
            if((out_size + 24) == 0)
            {
                    return (UIntPtr)val_3;
            }
            
            label_5:
            var val_4 = out_size + 24;
            if(val_4 < 1)
            {
                    return (UIntPtr)val_3;
            }
            
            UIntPtr val_2 = out_size + 32;
            do
            {
                val_4 = val_4 - 1;
                mem2[0] = out_size + 24;
            }
            while(val_4 != 0);
            
            return (UIntPtr)val_3;
            label_1:
        }
        internal static extern uint RealTimeRoomConfig_Variant(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern long RealTimeRoomConfig_ExclusiveBitMask(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (long)X2;
            }
        
        }
        internal static extern bool RealTimeRoomConfig_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern uint RealTimeRoomConfig_MaximumAutomatchingPlayers(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern uint RealTimeRoomConfig_MinimumAutomatchingPlayers(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern void RealTimeRoomConfig_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
    
    }

}
