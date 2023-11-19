using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class MultiplayerInvitation
    {
        // Methods
        internal static extern uint MultiplayerInvitation_AutomatchingSlotsAvailable(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern IntPtr MultiplayerInvitation_InvitingParticipant(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern uint MultiplayerInvitation_Variant(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern ulong MultiplayerInvitation_CreationTime(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ulong)X2;
            }
        
        }
        internal static extern UIntPtr MultiplayerInvitation_Participants_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr MultiplayerInvitation_Participants_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
        internal static extern bool MultiplayerInvitation_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.Types.MultiplayerInvitationType MultiplayerInvitation_Type(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (MultiplayerInvitationType)X2;
            }
        
        }
        internal static extern UIntPtr MultiplayerInvitation_Id(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern void MultiplayerInvitation_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
    
    }

}
