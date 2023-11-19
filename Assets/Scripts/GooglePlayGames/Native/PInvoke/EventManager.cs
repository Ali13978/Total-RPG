using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class EventManager
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.GameServices mServices;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.EventManager.FetchAllResponse> <>f__mg$cache0;
        private static GooglePlayGames.Native.Cwrapper.EventManager.FetchAllCallback <>f__mg$cache1;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.EventManager.FetchResponse> <>f__mg$cache2;
        private static GooglePlayGames.Native.Cwrapper.EventManager.FetchCallback <>f__mg$cache3;
        
        // Methods
        internal EventManager(GooglePlayGames.Native.PInvoke.GameServices services)
        {
            this.mServices = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        internal void FetchAll(GooglePlayGames.Native.Cwrapper.Types.DataSource source, System.Action<GooglePlayGames.Native.PInvoke.EventManager.FetchAllResponse> callback)
        {
            var val_5;
            EventManager.FetchAllCallback val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.SelfPtr();
            val_5 = null;
            val_7 = GooglePlayGames.Native.PInvoke.EventManager.<>f__mg$cache1;
            if(val_7 == null)
            {
                    GooglePlayGames.Native.PInvoke.EventManager.<>f__mg$cache1 = new EventManager.FetchAllCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.EventManager::InternalFetchAllCallback(IntPtr response, IntPtr data));
                val_5 = null;
                val_7 = GooglePlayGames.Native.PInvoke.EventManager.<>f__mg$cache1;
            }
            
            if(GooglePlayGames.Native.PInvoke.EventManager.__il2cppRuntimeField_static_fields == null)
            {
                    GooglePlayGames.Native.PInvoke.EventManager.<>f__mg$cache0 = new System.Func<System.IntPtr, FetchAllResponse>(object:  0, method:  static FetchAllResponse EventManager.FetchAllResponse::FromPointer(IntPtr pointer));
                val_5 = null;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.EventManager.EventManager_FetchAll(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, data_source:  val_1.handle, callback:  source, callback_arg:  val_7);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalFetchAllCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  null, callbackType:  "EventManager#FetchAllCallback", response:  1, userData:  data);
        }
        internal void Fetch(GooglePlayGames.Native.Cwrapper.Types.DataSource source, string eventId, System.Action<GooglePlayGames.Native.PInvoke.EventManager.FetchResponse> callback)
        {
            EventManager.FetchCallback val_6;
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.SelfPtr();
            val_6 = GooglePlayGames.Native.PInvoke.EventManager.<>f__mg$cache3;
            if(val_6 == null)
            {
                    GooglePlayGames.Native.PInvoke.EventManager.<>f__mg$cache3 = new EventManager.FetchCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.EventManager::InternalFetchCallback(IntPtr response, IntPtr data));
                val_6 = GooglePlayGames.Native.PInvoke.EventManager.<>f__mg$cache3;
            }
            
            if((GooglePlayGames.Native.PInvoke.EventManager.<>f__mg$cache2) == null)
            {
                    GooglePlayGames.Native.PInvoke.EventManager.<>f__mg$cache2 = new System.Func<System.IntPtr, FetchResponse>(object:  0, method:  static FetchResponse EventManager.FetchResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.EventManager.EventManager_Fetch(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, data_source:  val_1.handle, event_id:  source, callback:  eventId, callback_arg:  val_6);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalFetchCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  null, callbackType:  "EventManager#FetchCallback", response:  1, userData:  data);
        }
        internal void Increment(string eventId, uint steps)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.SelfPtr();
            GooglePlayGames.Native.Cwrapper.EventManager.EventManager_Increment(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, event_id:  val_1.handle, steps:  eventId);
        }
    
    }

}
