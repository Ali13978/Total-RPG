using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class RealtimeManager
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.GameServices mGameServices;
        private static GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeRoomCallback <>f__mg$cache0;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse> <>f__mg$cache1;
        private static GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.PlayerSelectUICallback <>f__mg$cache2;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.RealtimeManager.RoomInboxUIResponse> <>f__mg$cache3;
        private static GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RoomInboxUICallback <>f__mg$cache4;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.RealtimeManager.WaitingRoomUIResponse> <>f__mg$cache5;
        private static GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.WaitingRoomUICallback <>f__mg$cache6;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.RealtimeManager.FetchInvitationsResponse> <>f__mg$cache7;
        private static GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.FetchInvitationsCallback <>f__mg$cache8;
        private static GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.LeaveRoomCallback <>f__mg$cache9;
        private static GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeRoomCallback <>f__mg$cacheA;
        private static GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.SendReliableMessageCallback <>f__mg$cacheB;
        private static System.Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, IntPtr> <>f__am$cache0;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse> <>f__mg$cacheC;
        
        // Methods
        internal RealtimeManager(GooglePlayGames.Native.PInvoke.GameServices gameServices)
        {
            this.mGameServices = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        internal void CreateRoom(GooglePlayGames.Native.PInvoke.RealtimeRoomConfig config, GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper helper, System.Action<GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse> callback)
        {
            RealTimeMultiplayerManager.RealTimeRoomCallback val_6;
            RealTimeMultiplayerManager.RealTimeRoomCallback val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_7 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache0;
            if(val_7 == null)
            {
                    val_6 = null;
                val_6 = new RealTimeMultiplayerManager.RealTimeRoomCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealtimeManager::InternalRealTimeRoomCallback(IntPtr response, IntPtr data));
                GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache0 = val_6;
                val_7 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache0;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.RealtimeManager.ToCallbackPointer(callback:  val_6);
            GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_CreateRealTimeRoom(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, config:  val_1.handle, helper:  config.AsPointer(), callback:  helper.AsPointer(), callback_arg:  val_7);
        }
        internal void ShowPlayerSelectUI(uint minimumPlayers, uint maxiumPlayers, bool allowAutomatching, System.Action<GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse> callback)
        {
            RealTimeMultiplayerManager.PlayerSelectUICallback val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_7 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache2;
            if(val_7 == null)
            {
                    GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache2 = new RealTimeMultiplayerManager.PlayerSelectUICallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealtimeManager::InternalPlayerSelectUIcallback(IntPtr response, IntPtr data));
                val_7 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache2;
            }
            
            if((GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache1) == null)
            {
                    GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache1 = new System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse>(object:  0, method:  static GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_ShowPlayerSelectUI(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, minimum_players:  val_1.handle, maximum_players:  minimumPlayers, allow_automatch:  maxiumPlayers, callback:  allowAutomatching, callback_arg:  val_7);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalPlayerSelectUIcallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "RealtimeManager#PlayerSelectUICallback", response:  1, userData:  data);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalRealTimeRoomCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "RealtimeManager#InternalRealTimeRoomCallback", response:  1, userData:  data);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalRoomInboxUICallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "RealtimeManager#InternalRoomInboxUICallback", response:  1, userData:  data);
        }
        internal void ShowRoomInboxUI(System.Action<GooglePlayGames.Native.PInvoke.RealtimeManager.RoomInboxUIResponse> callback)
        {
            RealTimeMultiplayerManager.RoomInboxUICallback val_6;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_6 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache4;
            if(val_6 == null)
            {
                    GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache4 = new RealTimeMultiplayerManager.RoomInboxUICallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealtimeManager::InternalRoomInboxUICallback(IntPtr response, IntPtr data));
                val_6 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache4;
            }
            
            if((GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache3) == null)
            {
                    GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache3 = new System.Func<System.IntPtr, RoomInboxUIResponse>(object:  0, method:  static RoomInboxUIResponse RealtimeManager.RoomInboxUIResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_ShowRoomInboxUI(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_6);
        }
        internal void ShowWaitingRoomUI(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, uint minimumParticipantsBeforeStarting, System.Action<GooglePlayGames.Native.PInvoke.RealtimeManager.WaitingRoomUIResponse> callback)
        {
            RealTimeMultiplayerManager.WaitingRoomUICallback val_8;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_2 = this.mGameServices.AsHandle();
            val_8 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache6;
            if(val_8 == null)
            {
                    GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache6 = new RealTimeMultiplayerManager.WaitingRoomUICallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealtimeManager::InternalWaitingRoomUICallback(IntPtr response, IntPtr data));
                val_8 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache6;
            }
            
            if((GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache5) == null)
            {
                    GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache5 = new System.Func<System.IntPtr, WaitingRoomUIResponse>(object:  0, method:  static WaitingRoomUIResponse RealtimeManager.WaitingRoomUIResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_6 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_ShowWaitingRoomUI(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, room:  val_2.handle, min_participants_to_start:  room.AsPointer(), callback:  minimumParticipantsBeforeStarting, callback_arg:  val_8);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalWaitingRoomUICallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "RealtimeManager#InternalWaitingRoomUICallback", response:  1, userData:  data);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalFetchInvitationsCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "RealtimeManager#InternalFetchInvitationsCallback", response:  1, userData:  data);
        }
        internal void FetchInvitations(System.Action<GooglePlayGames.Native.PInvoke.RealtimeManager.FetchInvitationsResponse> callback)
        {
            RealTimeMultiplayerManager.FetchInvitationsCallback val_6;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_6 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache8;
            if(val_6 == null)
            {
                    GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache8 = new RealTimeMultiplayerManager.FetchInvitationsCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealtimeManager::InternalFetchInvitationsCallback(IntPtr response, IntPtr data));
                val_6 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache8;
            }
            
            if((GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache7) == null)
            {
                    GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache7 = new System.Func<System.IntPtr, FetchInvitationsResponse>(object:  0, method:  static FetchInvitationsResponse RealtimeManager.FetchInvitationsResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_FetchInvitations(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_6);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalLeaveRoomCallback(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus response, IntPtr data)
        {
            GooglePlayGames.OurUtils.Logger.d(msg:  null);
            System.Action<MultiplayerStatus> val_1 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToTempCallback<System.Action<MultiplayerStatus>>(handle:  0);
            if(val_1 == null)
            {
                    return;
            }
            
            val_1.Invoke(obj:  data);
        }
        internal void LeaveRoom(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, System.Action<GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus> callback)
        {
            RealTimeMultiplayerManager.LeaveRoomCallback val_5;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_5 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache9;
            if(val_5 == null)
            {
                    GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache9 = new RealTimeMultiplayerManager.LeaveRoomCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealtimeManager::InternalLeaveRoomCallback(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus response, IntPtr data));
                val_5 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cache9;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
            GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_LeaveRoom(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, room:  val_1.handle, callback:  room.AsPointer(), callback_arg:  val_5);
        }
        internal void AcceptInvitation(GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation, GooglePlayGames.Native.PInvoke.RealTimeEventListenerHelper listener, System.Action<GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse> callback)
        {
            RealTimeMultiplayerManager.RealTimeRoomCallback val_6;
            RealTimeMultiplayerManager.RealTimeRoomCallback val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_7 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cacheA;
            if(val_7 == null)
            {
                    val_6 = null;
                val_6 = new RealTimeMultiplayerManager.RealTimeRoomCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealtimeManager::InternalRealTimeRoomCallback(IntPtr response, IntPtr data));
                GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cacheA = val_6;
                val_7 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cacheA;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.RealtimeManager.ToCallbackPointer(callback:  val_6);
            GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_AcceptInvitation(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, invitation:  val_1.handle, helper:  invitation.AsPointer(), callback:  listener.AsPointer(), callback_arg:  val_7);
        }
        internal void DeclineInvitation(GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            IntPtr val_2 = invitation.AsPointer();
            GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_DeclineInvitation(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, invitation:  val_1.handle);
        }
        internal void SendReliableMessage(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant, byte[] data, System.Action<GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus> callback)
        {
            RealTimeMultiplayerManager.SendReliableMessageCallback val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_7 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cacheB;
            if(val_7 == null)
            {
                    GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cacheB = new RealTimeMultiplayerManager.SendReliableMessageCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.RealtimeManager::InternalSendReliableMessageCallback(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus response, IntPtr data));
                val_7 = GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cacheB;
            }
            
            IntPtr val_6 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
            GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_SendReliableMessage(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, room:  val_1.handle, participant:  room.AsPointer(), data:  participant.AsPointer(), data_size:  data, callback:  GooglePlayGames.Native.PInvoke.PInvokeUtilities.ArrayToSizeT<System.Byte>(array:  0), callback_arg:  val_7);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalSendReliableMessageCallback(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.MultiplayerStatus response, IntPtr data)
        {
            string val_3;
            string val_1 = 0 + "Entering internal callback for InternalSendReliableMessageCallback ";
            val_3 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_3);
            System.Action<MultiplayerStatus> val_2 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToTempCallback<System.Action<MultiplayerStatus>>(handle:  0);
            if(val_2 == null)
            {
                    return;
            }
            
            val_2.Invoke(obj:  data);
        }
        internal void SendUnreliableMessageToAll(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, byte[] data)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            UIntPtr val_3 = GooglePlayGames.Native.PInvoke.PInvokeUtilities.ArrayToSizeT<System.Byte>(array:  0);
            GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_SendUnreliableMessageToOthers(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, room:  val_1.handle, data:  room.AsPointer(), data_size:  data);
        }
        internal void SendUnreliableMessageToSpecificParticipants(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, System.Collections.Generic.List<GooglePlayGames.Native.PInvoke.MultiplayerParticipant> recipients, byte[] data)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            if((GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__am$cache0) == null)
            {
                    GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__am$cache0 = new System.Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.IntPtr>(object:  0, method:  static System.IntPtr GooglePlayGames.Native.PInvoke.RealtimeManager::<SendUnreliableMessageToSpecificParticipants>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant r));
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_4 = System.Linq.Enumerable.Select<System.Object, System.IntPtr>(source:  0, selector:  recipients);
            long val_6 = System.Linq.Enumerable.LongCount<GooglePlayGames.Native.PInvoke.MultiplayerParticipant>(source:  0);
            UIntPtr val_7 = GooglePlayGames.Native.PInvoke.PInvokeUtilities.ArrayToSizeT<System.Byte>(array:  0);
            GooglePlayGames.Native.Cwrapper.RealTimeMultiplayerManager.RealTimeMultiplayerManager_SendUnreliableMessage(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, room:  val_1.handle, participants:  room.AsPointer(), participants_size:  System.Linq.Enumerable.ToArray<System.IntPtr>(source:  0), data:  0, data_size:  data);
        }
        private static IntPtr ToCallbackPointer(System.Action<GooglePlayGames.Native.PInvoke.RealtimeManager.RealTimeRoomResponse> callback)
        {
            if((GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cacheC) != null)
            {
                    return GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  X1);
            }
            
            GooglePlayGames.Native.PInvoke.RealtimeManager.<>f__mg$cacheC = new System.Func<System.IntPtr, RealTimeRoomResponse>(object:  0, method:  static RealTimeRoomResponse RealtimeManager.RealTimeRoomResponse::FromPointer(IntPtr pointer));
            return GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  X1);
        }
        private static IntPtr <SendUnreliableMessageToSpecificParticipants>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant r)
        {
            if(X1 != 0)
            {
                    return X1.AsPointer();
            }
            
            return X1.AsPointer();
        }
    
    }

}
