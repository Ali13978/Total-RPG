using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class RealTimeMultiplayerManager
    {
        // Methods
        internal static extern void RealTimeMultiplayerManager_CreateRealTimeRoom(System.Runtime.InteropServices.HandleRef self, IntPtr config, IntPtr helper, GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeRoomCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_LeaveRoom(System.Runtime.InteropServices.HandleRef self, IntPtr room, GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.LeaveRoomCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_SendUnreliableMessage(System.Runtime.InteropServices.HandleRef self, IntPtr room, IntPtr[] participants, UIntPtr participants_size, byte[] data, UIntPtr data_size)
        {
            if(25808612 != 0)
            {
                    var val_3 = (participants_size == 0) ? 0 : (participants_size + 32);
                var val_4 = (data_size == 0) ? 0 : (data_size + 32);
                return;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_ShowWaitingRoomUI(System.Runtime.InteropServices.HandleRef self, IntPtr room, uint min_participants_to_start, GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.WaitingRoomUICallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_ShowPlayerSelectUI(System.Runtime.InteropServices.HandleRef self, uint minimum_players, uint maximum_players, bool allow_automatch, GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.PlayerSelectUICallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    PlayerSelectUICallback val_1 = callback & 1;
                return;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_DismissInvitation(System.Runtime.InteropServices.HandleRef self, IntPtr invitation)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_DeclineInvitation(System.Runtime.InteropServices.HandleRef self, IntPtr invitation)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_SendReliableMessage(System.Runtime.InteropServices.HandleRef self, IntPtr room, IntPtr participant, byte[] data, UIntPtr data_size, GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.SendReliableMessageCallback callback, IntPtr callback_arg)
        {
            UIntPtr val_3 = data_size;
            if(25808612 != 0)
            {
                    val_3 = (val_3 == 0) ? 0 : (val_3 + 32);
                return;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_AcceptInvitation(System.Runtime.InteropServices.HandleRef self, IntPtr invitation, IntPtr helper, GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeRoomCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_FetchInvitations(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.FetchInvitationsCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_SendUnreliableMessageToOthers(System.Runtime.InteropServices.HandleRef self, IntPtr room, byte[] data, UIntPtr data_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (data_size == 0) ? 0 : (data_size + 32);
                return;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_ShowRoomInboxUI(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RoomInboxUICallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_RealTimeRoomResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus RealTimeMultiplayerManager_RealTimeRoomResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (MultiplayerStatus)X2;
            }
        
        }
        internal static extern IntPtr RealTimeMultiplayerManager_RealTimeRoomResponse_GetRoom(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_RoomInboxUIResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus RealTimeMultiplayerManager_RoomInboxUIResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIStatus)X2;
            }
        
        }
        internal static extern IntPtr RealTimeMultiplayerManager_RoomInboxUIResponse_GetInvitation(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_WaitingRoomUIResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus RealTimeMultiplayerManager_WaitingRoomUIResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIStatus)X2;
            }
        
        }
        internal static extern IntPtr RealTimeMultiplayerManager_WaitingRoomUIResponse_GetRoom(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void RealTimeMultiplayerManager_FetchInvitationsResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus RealTimeMultiplayerManager_FetchInvitationsResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern UIntPtr RealTimeMultiplayerManager_FetchInvitationsResponse_GetInvitations_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr RealTimeMultiplayerManager_FetchInvitationsResponse_GetInvitations_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
    
    }

}
