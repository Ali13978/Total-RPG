using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class ParticipantResults
    {
        // Methods
        internal static extern IntPtr ParticipantResults_WithResult(System.Runtime.InteropServices.HandleRef self, string participant_id, uint placing, GooglePlayGames.Native.Cwrapper.Types.MatchResult result)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)participant_id;
            }
        
        }
        internal static extern bool ParticipantResults_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.Types.MatchResult ParticipantResults_MatchResultForParticipant(System.Runtime.InteropServices.HandleRef self, string participant_id)
        {
            if(25808612 != 0)
            {
                    return (MatchResult)participant_id;
            }
        
        }
        internal static extern uint ParticipantResults_PlaceForParticipant(System.Runtime.InteropServices.HandleRef self, string participant_id)
        {
            if(25808612 != 0)
            {
                    return (uint)participant_id;
            }
        
        }
        internal static extern bool ParticipantResults_HasResultsForParticipant(System.Runtime.InteropServices.HandleRef self, string participant_id)
        {
            if(25808612 != 0)
            {
                    return (bool)(participant_id != 255) ? 1 : 0;
            }
        
        }
        internal static extern void ParticipantResults_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
    
    }

}
