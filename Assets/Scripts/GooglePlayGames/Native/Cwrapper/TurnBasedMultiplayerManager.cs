using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class TurnBasedMultiplayerManager
    {
        // Methods
        internal static extern void TurnBasedMultiplayerManager_ShowPlayerSelectUI(System.Runtime.InteropServices.HandleRef self, uint minimum_players, uint maximum_players, bool allow_automatch, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.PlayerSelectUICallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    PlayerSelectUICallback val_1 = callback & 1;
                return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_CancelMatch(System.Runtime.InteropServices.HandleRef self, IntPtr match, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.MultiplayerStatusCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_DismissMatch(System.Runtime.InteropServices.HandleRef self, IntPtr match)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_ShowMatchInboxUI(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.MatchInboxUICallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_SynchronizeData(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_Rematch(System.Runtime.InteropServices.HandleRef self, IntPtr match, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_DismissInvitation(System.Runtime.InteropServices.HandleRef self, IntPtr invitation)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_FetchMatch(System.Runtime.InteropServices.HandleRef self, string match_id, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_DeclineInvitation(System.Runtime.InteropServices.HandleRef self, IntPtr invitation)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_FinishMatchDuringMyTurn(System.Runtime.InteropServices.HandleRef self, IntPtr match, byte[] match_data, UIntPtr match_data_size, IntPtr results, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg)
        {
            UIntPtr val_3 = match_data_size;
            if(25808612 != 0)
            {
                    val_3 = (val_3 == 0) ? 0 : (val_3 + 32);
                return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_FetchMatches(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchesCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_CreateTurnBasedMatch(System.Runtime.InteropServices.HandleRef self, IntPtr config, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_AcceptInvitation(System.Runtime.InteropServices.HandleRef self, IntPtr invitation, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_TakeMyTurn(System.Runtime.InteropServices.HandleRef self, IntPtr match, byte[] match_data, UIntPtr match_data_size, IntPtr results, IntPtr next_participant, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg)
        {
            UIntPtr val_3 = match_data_size;
            if(25808612 != 0)
            {
                    val_3 = (val_3 == 0) ? 0 : (val_3 + 32);
                return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_ConfirmPendingCompletion(System.Runtime.InteropServices.HandleRef self, IntPtr match, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMatchCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_LeaveMatchDuringMyTurn(System.Runtime.InteropServices.HandleRef self, IntPtr match, IntPtr next_participant, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.MultiplayerStatusCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_LeaveMatchDuringTheirTurn(System.Runtime.InteropServices.HandleRef self, IntPtr match, GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.MultiplayerStatusCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_TurnBasedMatchResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus TurnBasedMultiplayerManager_TurnBasedMatchResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (MultiplayerStatus)X2;
            }
        
        }
        internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchResponse_GetMatch(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_TurnBasedMatchesResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (MultiplayerStatus)X2;
            }
        
        }
        internal static extern UIntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetInvitations_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetInvitations_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
        internal static extern UIntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetMyTurnMatches_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetMyTurnMatches_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
        internal static extern UIntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetTheirTurnMatches_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetTheirTurnMatches_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
        internal static extern UIntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetCompletedMatches_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetCompletedMatches_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_MatchInboxUIResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus TurnBasedMultiplayerManager_MatchInboxUIResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIStatus)X2;
            }
        
        }
        internal static extern IntPtr TurnBasedMultiplayerManager_MatchInboxUIResponse_GetMatch(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void TurnBasedMultiplayerManager_PlayerSelectUIResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIStatus)X2;
            }
        
        }
        internal static extern UIntPtr TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetPlayerIds_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern UIntPtr TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetPlayerIds_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)index;
            }
        
        }
        internal static extern uint TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetMinimumAutomatchingPlayers(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
        internal static extern uint TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetMaximumAutomatchingPlayers(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (uint)X2;
            }
        
        }
    
    }

}
