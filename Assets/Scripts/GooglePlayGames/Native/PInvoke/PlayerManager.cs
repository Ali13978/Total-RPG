using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class PlayerManager
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.GameServices mGameServices;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.PlayerManager.FetchSelfResponse> <>f__mg$cache0;
        private static GooglePlayGames.Native.Cwrapper.PlayerManager.FetchSelfCallback <>f__mg$cache1;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.PlayerManager.FetchResponse> <>f__mg$cache2;
        private static GooglePlayGames.Native.Cwrapper.PlayerManager.FetchCallback <>f__mg$cache3;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.PlayerManager.FetchListResponse> <>f__mg$cache4;
        private static GooglePlayGames.Native.Cwrapper.PlayerManager.FetchListCallback <>f__mg$cache5;
        
        // Methods
        internal PlayerManager(GooglePlayGames.Native.PInvoke.GameServices services)
        {
            this.mGameServices = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        internal void FetchSelf(System.Action<GooglePlayGames.Native.PInvoke.PlayerManager.FetchSelfResponse> callback)
        {
            var val_5;
            PlayerManager.FetchSelfCallback val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.mGameServices.AsHandle();
            val_5 = null;
            val_7 = GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache1;
            if(val_7 == null)
            {
                    GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache1 = new PlayerManager.FetchSelfCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.PlayerManager::InternalFetchSelfCallback(IntPtr response, IntPtr data));
                val_5 = null;
                val_7 = GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache1;
            }
            
            if(GooglePlayGames.Native.PInvoke.PlayerManager.__il2cppRuntimeField_static_fields == null)
            {
                    GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache0 = new System.Func<System.IntPtr, FetchSelfResponse>(object:  0, method:  static FetchSelfResponse PlayerManager.FetchSelfResponse::FromPointer(IntPtr selfPointer));
                val_5 = null;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchSelf(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, data_source:  val_1.handle, callback:  1, callback_arg:  val_7);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalFetchSelfCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "PlayerManager#InternalFetchSelfCallback", response:  1, userData:  data);
        }
        internal void FetchList(string[] userIds, System.Action<GooglePlayGames.Native.PInvoke.NativePlayer[]> callback)
        {
            FetchCallback val_4;
            var val_9;
            DataSource val_10;
            var val_11;
            object val_1 = new System.Object();
            typeof(PlayerManager.<FetchList>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            PlayerManager.FetchResponseCollector val_2 = new PlayerManager.FetchResponseCollector();
            if(null != 0)
            {
                    val_9 = val_1;
                val_10 = val_1;
                typeof(PlayerManager.<FetchList>c__AnonStorey0).__il2cppRuntimeField_10 = val_2;
            }
            else
            {
                    val_10 = val_1;
                val_9 = 16;
                mem[16] = val_2;
            }
            
            typeof(PlayerManager.FetchResponseCollector).__il2cppRuntimeField_10 = userIds.Length;
            typeof(PlayerManager.FetchResponseCollector).__il2cppRuntimeField_20 = callback;
            val_11 = 0;
            goto label_8;
            label_17:
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  X26);
            GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_Fetch(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2}, data_source:  val_10, player_id:  1, callback:  val_4, callback_arg:  X25);
            val_11 = 1;
            label_8:
            if(val_11 >= userIds.Length)
            {
                    return;
            }
            
            val_4 = userIds[1];
            System.Runtime.InteropServices.HandleRef val_5 = this.mGameServices.AsHandle();
            if((GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache3) == null)
            {
                    GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache3 = new PlayerManager.FetchCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.PlayerManager::InternalFetchCallback(IntPtr response, IntPtr data));
            }
            
            System.Action<FetchResponse> val_7 = new System.Action<FetchResponse>(object:  val_10, method:  System.Void PlayerManager.<FetchList>c__AnonStorey0::<>m__0(GooglePlayGames.Native.PInvoke.PlayerManager.FetchResponse rsp));
            if((GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache2) != null)
            {
                goto label_17;
            }
            
            GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache2 = new System.Func<System.IntPtr, FetchResponse>(object:  0, method:  static FetchResponse PlayerManager.FetchResponse::FromPointer(IntPtr selfPointer));
            goto label_17;
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalFetchCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "PlayerManager#InternalFetchCallback", response:  1, userData:  data);
        }
        internal void HandleFetchResponse(GooglePlayGames.Native.PInvoke.PlayerManager.FetchResponseCollector collector, GooglePlayGames.Native.PInvoke.PlayerManager.FetchResponse resp)
        {
            System.Collections.Generic.List<GooglePlayGames.Native.PInvoke.NativePlayer> val_7;
            int val_8;
            System.Action<GooglePlayGames.Native.PInvoke.NativePlayer[]> val_9;
            System.Runtime.InteropServices.HandleRef val_1 = resp.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) == 1)
            {
                goto label_2;
            }
            
            System.Runtime.InteropServices.HandleRef val_3 = resp.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper})) != 2)
            {
                goto label_4;
            }
            
            label_2:
            val_7 = collector.results;
            val_7.Add(item:  resp.GetPlayer());
            label_4:
            if(collector != null)
            {
                    val_8 = collector.pendingCount - 1;
                collector.pendingCount = val_8;
            }
            else
            {
                    val_7 = 11993091;
                mem[16] = 11993090;
                val_8 = mem[16];
            }
            
            if(val_8 != 0)
            {
                    return;
            }
            
            if(collector != null)
            {
                    val_9 = collector.callback;
            }
            else
            {
                    val_9 = 64;
            }
            
            val_9.Invoke(obj:  collector.results.ToArray());
        }
        internal void FetchFriends(System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Player>> callback)
        {
            PlayerManager.FetchListCallback val_7;
            if(null != 0)
            {
                    typeof(PlayerManager.<FetchFriends>c__AnonStorey1).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    mem[16] = callback;
            }
            
            typeof(PlayerManager.<FetchFriends>c__AnonStorey1).__il2cppRuntimeField_18 = this;
            System.Runtime.InteropServices.HandleRef val_2 = this.mGameServices.AsHandle();
            val_7 = GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache5;
            if(val_7 == null)
            {
                    GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache5 = new PlayerManager.FetchListCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.PlayerManager::InternalFetchConnectedCallback(IntPtr response, IntPtr data));
                val_7 = GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache5;
            }
            
            if((GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache4) == null)
            {
                    GooglePlayGames.Native.PInvoke.PlayerManager.<>f__mg$cache4 = new System.Func<System.IntPtr, FetchListResponse>(object:  0, method:  static FetchListResponse PlayerManager.FetchListResponse::FromPointer(IntPtr selfPointer));
            }
            
            IntPtr val_6 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  new System.Action<FetchListResponse>(object:  new System.Object(), method:  System.Void PlayerManager.<FetchFriends>c__AnonStorey1::<>m__0(GooglePlayGames.Native.PInvoke.PlayerManager.FetchListResponse rsp)));
            GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchConnected(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, data_source:  val_2.handle, callback:  1, callback_arg:  val_7);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalFetchConnectedCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "PlayerManager#InternalFetchConnectedCallback", response:  1, userData:  data);
        }
        internal void HandleFetchCollected(GooglePlayGames.Native.PInvoke.PlayerManager.FetchListResponse rsp, System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Player>> callback)
        {
            string val_18;
            var val_19;
            var val_20;
            var val_21;
            System.Runtime.InteropServices.HandleRef val_2 = rsp.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper})) == 1)
            {
                goto label_2;
            }
            
            System.Runtime.InteropServices.HandleRef val_4 = rsp.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_4.wrapper})) != 2)
            {
                goto label_31;
            }
            
            label_2:
            System.Runtime.InteropServices.HandleRef val_6 = rsp.SelfPtr();
            string val_9 = 0 + "Got " + GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetData_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_6.wrapper}).ToUInt64()(GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetData_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_6.wrapper}).ToUInt64());
            val_18 = null;
            GooglePlayGames.OurUtils.Logger.d(msg:  val_18);
            System.Collections.Generic.IEnumerator<GooglePlayGames.Native.PInvoke.NativePlayer> val_10 = rsp.GetEnumerator();
            label_24:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_19 = val_10;
            if(((val_10 & 1) & 1) == 0)
            {
                goto label_34;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_20 = val_10;
            Add(item:  val_10.AsPlayer());
            goto label_24;
            label_34:
            if(val_10 != null)
            {
                    var val_20 = 0;
                val_20 = val_20 + 1;
                val_21 = val_10;
            }
            
            label_31:
            System.Runtime.InteropServices.HandleRef val_16 = rsp.SelfPtr();
            callback.Invoke(arg1:  GooglePlayGames.Native.Cwrapper.PlayerManager.PlayerManager_FetchListResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_16.wrapper}), arg2:  new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Player>());
        }
    
    }

}
