using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class AchievementManager
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.GameServices mServices;
        private static GooglePlayGames.Native.Cwrapper.AchievementManager.ShowAllUICallback <>f__mg$cache0;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.AchievementManager.FetchAllResponse> <>f__mg$cache1;
        private static GooglePlayGames.Native.Cwrapper.AchievementManager.FetchAllCallback <>f__mg$cache2;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.AchievementManager.FetchResponse> <>f__mg$cache3;
        private static GooglePlayGames.Native.Cwrapper.AchievementManager.FetchCallback <>f__mg$cache4;
        
        // Methods
        internal AchievementManager(GooglePlayGames.Native.PInvoke.GameServices services)
        {
            this.mServices = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        internal void ShowAllUI(System.Action<GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus> callback)
        {
            AchievementManager.ShowAllUICallback val_5;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_2 = this.mServices.SelfPtr();
            val_5 = GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache0;
            if(val_5 == null)
            {
                    GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache0 = new AchievementManager.ShowAllUICallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.Callbacks::InternalShowUICallback(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus status, IntPtr data));
                val_5 = GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache0;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  null);
            GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_ShowAllUI(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, callback:  val_2.handle, callback_arg:  val_5);
        }
        internal void FetchAll(System.Action<GooglePlayGames.Native.PInvoke.AchievementManager.FetchAllResponse> callback)
        {
            AchievementManager.FetchAllCallback val_7;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_2 = this.mServices.SelfPtr();
            val_7 = GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache2;
            if(val_7 == null)
            {
                    GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache2 = new AchievementManager.FetchAllCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.AchievementManager::InternalFetchAllCallback(IntPtr response, IntPtr data));
                val_7 = GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache2;
            }
            
            if((GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache1) == null)
            {
                    GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache1 = new System.Func<System.IntPtr, FetchAllResponse>(object:  0, method:  static FetchAllResponse AchievementManager.FetchAllResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_5 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_FetchAll(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, data_source:  val_2.handle, callback:  1, callback_arg:  val_7);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalFetchAllCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  null, callbackType:  "AchievementManager#InternalFetchAllCallback", response:  1, userData:  data);
        }
        internal void Fetch(string achId, System.Action<GooglePlayGames.Native.PInvoke.AchievementManager.FetchResponse> callback)
        {
            AchievementManager.FetchCallback val_8;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_3 = this.mServices.SelfPtr();
            val_8 = GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache4;
            if(val_8 == null)
            {
                    GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache4 = new AchievementManager.FetchCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.AchievementManager::InternalFetchCallback(IntPtr response, IntPtr data));
                val_8 = GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache4;
            }
            
            if((GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache3) == null)
            {
                    GooglePlayGames.Native.PInvoke.AchievementManager.<>f__mg$cache3 = new System.Func<System.IntPtr, FetchResponse>(object:  0, method:  static FetchResponse AchievementManager.FetchResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_6 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_Fetch(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper}, data_source:  val_3.handle, achievement_id:  1, callback:  achId, callback_arg:  val_8);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalFetchCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  null, callbackType:  "AchievementManager#InternalFetchCallback", response:  1, userData:  data);
        }
        internal void Increment(string achievementId, uint numSteps)
        {
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_2 = this.mServices.SelfPtr();
            GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_Increment(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, achievement_id:  val_2.handle, steps:  achievementId);
        }
        internal void SetStepsAtLeast(string achivementId, uint numSteps)
        {
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_2 = this.mServices.SelfPtr();
            GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_SetStepsAtLeast(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, achievement_id:  val_2.handle, steps:  achivementId);
        }
        internal void Reveal(string achievementId)
        {
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_2 = this.mServices.SelfPtr();
            GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_Reveal(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, achievement_id:  val_2.handle);
        }
        internal void Unlock(string achievementId)
        {
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_2 = this.mServices.SelfPtr();
            GooglePlayGames.Native.Cwrapper.AchievementManager.AchievementManager_Unlock(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, achievement_id:  val_2.handle);
        }
    
    }

}
