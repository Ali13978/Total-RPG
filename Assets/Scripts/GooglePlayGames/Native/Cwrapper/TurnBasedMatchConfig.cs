using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class TurnBasedMatchConfig
    {
        // Methods
        internal static extern UIntPtr TurnBasedMatchConfig_PlayerIdsToInvite_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern UIntPtr TurnBasedMatchConfig_PlayerIdsToInvite_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)index;
            }
        
        }
        internal static extern uint TurnBasedMatchConfig_Variant(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern long TurnBasedMatchConfig_ExclusiveBitMask(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (long)X2;
            }
        
        }
        internal static extern bool TurnBasedMatchConfig_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern uint TurnBasedMatchConfig_MaximumAutomatchingPlayers(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern uint TurnBasedMatchConfig_MinimumAutomatchingPlayers(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern void TurnBasedMatchConfig_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
    
    }

}
