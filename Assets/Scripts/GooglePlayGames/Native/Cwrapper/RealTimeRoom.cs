using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class RealTimeRoom
    {
        // Methods
        internal static extern GooglePlayGames.Native.Cwrapper.Types.RealTimeRoomStatus RealTimeRoom_Status(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (RealTimeRoomStatus)X2;
            }
        
        }
        internal static extern UIntPtr RealTimeRoom_Description(System.Runtime.InteropServices.HandleRef self, [In] [Out] char[] out_arg, UIntPtr out_size)
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
            
            val_3 = out_arg;
            goto label_5;
            label_2:
            val_3 = out_arg;
            return (UIntPtr)val_3;
            label_3:
            val_3 = out_arg;
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
        internal static extern uint RealTimeRoom_Variant(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern ulong RealTimeRoom_CreationTime(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ulong)X2;
            }
        
        }
        internal static extern UIntPtr RealTimeRoom_Participants_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr RealTimeRoom_Participants_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
        internal static extern bool RealTimeRoom_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern uint RealTimeRoom_RemainingAutomatchingSlots(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern ulong RealTimeRoom_AutomatchWaitEstimate(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ulong)X2;
            }
        
        }
        internal static extern IntPtr RealTimeRoom_CreatingParticipant(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern UIntPtr RealTimeRoom_Id(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern void RealTimeRoom_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
    
    }

}
