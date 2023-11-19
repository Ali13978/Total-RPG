using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class VideoManager
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.GameServices mServices;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse> <>f__mg$cache0;
        private static GooglePlayGames.Native.Cwrapper.VideoManager.CaptureCapabilitiesCallback <>f__mg$cache1;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.GetCaptureStateResponse> <>f__mg$cache2;
        private static GooglePlayGames.Native.Cwrapper.VideoManager.CaptureStateCallback <>f__mg$cache3;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse> <>f__mg$cache4;
        private static GooglePlayGames.Native.Cwrapper.VideoManager.IsCaptureAvailableCallback <>f__mg$cache5;
        
        // Properties
        internal int NumCaptureModes { get; }
        internal int NumQualityLevels { get; }
        
        // Methods
        internal VideoManager(GooglePlayGames.Native.PInvoke.GameServices services)
        {
            this.mServices = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        internal int get_NumCaptureModes()
        {
            return 2;
        }
        internal int get_NumQualityLevels()
        {
            return 4;
        }
        internal void GetCaptureCapabilities(System.Action<GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse> callback)
        {
            var val_5;
            VideoManager.CaptureCapabilitiesCallback val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.AsHandle();
            val_5 = null;
            val_7 = GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache1;
            if(val_7 == null)
            {
                    GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache1 = new VideoManager.CaptureCapabilitiesCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.VideoManager::InternalCaptureCapabilitiesCallback(IntPtr response, IntPtr data));
                val_5 = null;
                val_7 = GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache1;
            }
            
            if(GooglePlayGames.Native.PInvoke.VideoManager.__il2cppRuntimeField_static_fields == null)
            {
                    GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache0 = new System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse>(object:  0, method:  static GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse GooglePlayGames.Native.PInvoke.GetCaptureCapabilitiesResponse::FromPointer(IntPtr pointer));
                val_5 = null;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_GetCaptureCapabilities(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_7);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalCaptureCapabilitiesCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "VideoManager#CaptureCapabilitiesCallback", response:  1, userData:  data);
        }
        internal void ShowCaptureOverlay()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.AsHandle();
            GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_ShowCaptureOverlay(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal void GetCaptureState(System.Action<GooglePlayGames.Native.PInvoke.GetCaptureStateResponse> callback)
        {
            VideoManager.CaptureStateCallback val_6;
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.AsHandle();
            val_6 = GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache3;
            if(val_6 == null)
            {
                    GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache3 = new VideoManager.CaptureStateCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.VideoManager::InternalCaptureStateCallback(IntPtr response, IntPtr data));
                val_6 = GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache3;
            }
            
            if((GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache2) == null)
            {
                    GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache2 = new System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.GetCaptureStateResponse>(object:  0, method:  static GooglePlayGames.Native.PInvoke.GetCaptureStateResponse GooglePlayGames.Native.PInvoke.GetCaptureStateResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_GetCaptureState(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_6);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalCaptureStateCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "VideoManager#CaptureStateCallback", response:  1, userData:  data);
        }
        internal void IsCaptureAvailable(GooglePlayGames.Native.Cwrapper.Types.VideoCaptureMode captureMode, System.Action<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse> callback)
        {
            VideoManager.IsCaptureAvailableCallback val_6;
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.AsHandle();
            val_6 = GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache5;
            if(val_6 == null)
            {
                    GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache5 = new VideoManager.IsCaptureAvailableCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.VideoManager::InternalIsCaptureAvailableCallback(IntPtr response, IntPtr data));
                val_6 = GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache5;
            }
            
            if((GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache4) == null)
            {
                    GooglePlayGames.Native.PInvoke.VideoManager.<>f__mg$cache4 = new System.Func<System.IntPtr, GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(object:  0, method:  static GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_IsCaptureAvailable(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, capture_mode:  val_1.handle, callback:  captureMode, callback_arg:  val_6);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalIsCaptureAvailableCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "VideoManager#IsCaptureAvailableCallback", response:  1, userData:  data);
        }
        internal bool IsCaptureSupported()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.AsHandle();
            return GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_IsCaptureSupported(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal void RegisterCaptureOverlayStateChangedListener(GooglePlayGames.Native.PInvoke.CaptureOverlayStateListenerHelper helper)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.AsHandle();
            IntPtr val_2 = helper.AsPointer();
            GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_RegisterCaptureOverlayStateChangedListener(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, helper:  val_1.handle);
        }
        internal void UnregisterCaptureOverlayStateChangedListener()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.AsHandle();
            GooglePlayGames.Native.Cwrapper.VideoManager.VideoManager_UnregisterCaptureOverlayStateChangedListener(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
    
    }

}
