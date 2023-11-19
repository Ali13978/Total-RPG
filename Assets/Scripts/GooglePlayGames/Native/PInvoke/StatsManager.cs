using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class StatsManager
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.GameServices mServices;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.StatsManager.FetchForPlayerResponse> <>f__mg$cache0;
        private static GooglePlayGames.Native.Cwrapper.StatsManager.FetchForPlayerCallback <>f__mg$cache1;
        
        // Methods
        internal StatsManager(GooglePlayGames.Native.PInvoke.GameServices services)
        {
            this.mServices = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        internal void FetchForPlayer(System.Action<GooglePlayGames.Native.PInvoke.StatsManager.FetchForPlayerResponse> callback)
        {
            var val_6;
            StatsManager.FetchForPlayerCallback val_8;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_2 = this.mServices.AsHandle();
            val_6 = null;
            val_8 = GooglePlayGames.Native.PInvoke.StatsManager.<>f__mg$cache1;
            if(val_8 == null)
            {
                    GooglePlayGames.Native.PInvoke.StatsManager.<>f__mg$cache1 = new StatsManager.FetchForPlayerCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.StatsManager::InternalFetchForPlayerCallback(IntPtr response, IntPtr data));
                val_6 = null;
                val_8 = GooglePlayGames.Native.PInvoke.StatsManager.<>f__mg$cache1;
            }
            
            if(GooglePlayGames.Native.PInvoke.StatsManager.__il2cppRuntimeField_static_fields == null)
            {
                    GooglePlayGames.Native.PInvoke.StatsManager.<>f__mg$cache0 = new System.Func<System.IntPtr, FetchForPlayerResponse>(object:  0, method:  static FetchForPlayerResponse StatsManager.FetchForPlayerResponse::FromPointer(IntPtr pointer));
                val_6 = null;
            }
            
            IntPtr val_5 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.StatsManager.StatsManager_FetchForPlayer(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, data_source:  val_2.handle, callback:  1, callback_arg:  val_8);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalFetchForPlayerCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "StatsManager#InternalFetchForPlayerCallback", response:  1, userData:  data);
        }
    
    }

}
