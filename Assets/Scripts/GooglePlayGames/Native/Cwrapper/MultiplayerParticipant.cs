using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class MultiplayerParticipant
    {
        // Methods
        internal static extern GooglePlayGames.Native.Cwrapper.Types.ParticipantStatus MultiplayerParticipant_Status(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ParticipantStatus)X2;
            }
        
        }
        internal static extern uint MultiplayerParticipant_MatchRank(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern bool MultiplayerParticipant_IsConnectedToRoom(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern UIntPtr MultiplayerParticipant_DisplayName(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern bool MultiplayerParticipant_HasPlayer(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern UIntPtr MultiplayerParticipant_AvatarUrl(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.ImageResolution resolution, [In] [Out] char[] out_arg, UIntPtr out_size)
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
            
            val_3 = resolution;
            goto label_5;
            label_2:
            val_3 = resolution;
            return (UIntPtr)val_3;
            label_3:
            val_3 = resolution;
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
        internal static extern GooglePlayGames.Native.Cwrapper.Types.MatchResult MultiplayerParticipant_MatchResult(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (MatchResult)X2;
            }
        
        }
        internal static extern IntPtr MultiplayerParticipant_Player(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void MultiplayerParticipant_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern bool MultiplayerParticipant_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern bool MultiplayerParticipant_HasMatchResult(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern UIntPtr MultiplayerParticipant_Id(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
    
    }

}
